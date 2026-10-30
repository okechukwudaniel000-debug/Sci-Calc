Imports System.Globalization
Imports System.Text.RegularExpressions

''' <summary>
''' High-precision, recursive-descent scientific mathematical expression evaluator.
''' Supports standard arithmetic, parentheses, exponentiation (^), unary operators,
''' functions (sin, cos, tan, sqrt, log10, ln), and constants (pi, e).
''' </summary>
Public Class ScientificExpressionEvaluator

    Private ReadOnly _expression As String
    Private _pos As Integer = 0
    Private _currentChar As Char = ControlChars.NullChar

    Public Sub New(expression As String)
        If String.IsNullOrWhiteSpace(expression) Then
            Throw New ArgumentException("Expression cannot be empty.")
        End If
        ' Remove whitespace and standardize decimal separator
        _expression = expression.Replace(" ", "").Replace(ControlChars.Tab, "")
        If _expression.Length > 0 Then
            _currentChar = _expression(0)
        End If
    End Sub

    Public Shared Function Evaluate(expression As String) As Double
        Dim evaluator As New ScientificExpressionEvaluator(expression)
        Dim result As Double = evaluator.ParseExpression()
        If evaluator._pos < evaluator._expression.Length Then
            Throw New InvalidOperationException($"Unexpected character: '{evaluator._currentChar}' at position {evaluator._pos}")
        End If
        Return result
    End Function

    Private Sub Advance()
        _pos += 1
        If _pos < _expression.Length Then
            _currentChar = _expression(_pos)
        Else
            _currentChar = ControlChars.NullChar
        End If
    End Sub

    ''' <summary>
    ''' Handles addition and subtraction: + and -
    ''' </summary>
    Private Function ParseExpression() As Double
        Dim result As Double = ParseTerm()

        While _currentChar = "+"c OrElse _currentChar = "-"c
            Dim op As Char = _currentChar
            Advance()
            Dim term As Double = ParseTerm()
            If op = "+"c Then
                result += term
            Else
                result -= term
            End If
        End While

        Return result
    End Function

    ''' <summary>
    ''' Handles multiplication and division: * and /
    ''' </summary>
    Private Function ParseTerm() As Double
        Dim result As Double = ParseFactor()

        While _currentChar = "*"c OrElse _currentChar = "/"c
            Dim op As Char = _currentChar
            Advance()
            Dim factor As Double = ParseFactor()
            If op = "*"c Then
                result *= factor
            Else
                If factor = 0.0 Then
                    Throw New DivideByZeroException("Division by zero.")
                End If
                result /= factor
            End If
        End While

        Return result
    End Function

    ''' <summary>
    ''' Handles exponentiation (right-associative): ^
    ''' </summary>
    Private Function ParseFactor() As Double
        Dim result As Double = ParseUnary()

        If _currentChar = "^"c Then
            Advance()
            Dim exponent As Double = ParseFactor() ' Right-associative
            result = Math.Pow(result, exponent)
            If Double.IsNaN(result) OrElse Double.IsInfinity(result) Then
                Throw New InvalidOperationException("Invalid power operation.")
            End If
        End If

        Return result
    End Function

    ''' <summary>
    ''' Handles unary plus and minus: +x, -x
    ''' </summary>
    Private Function ParseUnary() As Double
        If _currentChar = "+"c Then
            Advance()
            Return ParseUnary()
        ElseIf _currentChar = "-"c Then
            Advance()
            Return -ParseUnary()
        End If

        Return ParsePrimary()
    End Function

    ''' <summary>
    ''' Handles numbers, parentheses, functions (sin, cos, tan, sqrt, log10, ln), and constants (pi, e).
    ''' </summary>
    Private Function ParsePrimary() As Double
        ' Parentheses
        If _currentChar = "("c Then
            Advance()
            Dim result As Double = ParseExpression()
            If _currentChar <> ")"c Then
                Throw New InvalidOperationException("Missing closing parenthesis.")
            End If
            Advance()
            Return result
        End If

        ' Numbers
        If Char.IsDigit(_currentChar) OrElse _currentChar = "."c Then
            Return ParseNumber()
        End If

        ' Identifiers (Functions or Constants)
        If Char.IsLetter(_currentChar) Then
            Dim identifier As String = ParseIdentifier().ToLowerInvariant()

            ' Check Constants
            If identifier = "pi" OrElse identifier = "π" Then
                Return Math.PI
            ElseIf identifier = "e" Then
                Return Math.E
            End If

            ' Functions must be followed by (
            If _currentChar <> "("c Then
                Throw New InvalidOperationException($"Function '{identifier}' must be followed by '('.")
            End If
            Advance() ' Skip '('

            Dim argument As Double = ParseExpression()

            If _currentChar <> ")"c Then
                Throw New InvalidOperationException($"Missing closing parenthesis for function '{identifier}'.")
            End If
            Advance() ' Skip ')'

            Select Case identifier
                Case "sin"
                    ' In radians; for angle handling standard Math.Sin
                    Return Math.Sin(argument)
                Case "cos"
                    Return Math.Cos(argument)
                Case "tan"
                    ' Tan undefined at pi/2 + k*pi
                    Dim cosVal As Double = Math.Cos(argument)
                    If Math.Abs(cosVal) < 1E-15 Then
                        Throw New InvalidOperationException("Tangent undefined.")
                    End If
                    Return Math.Tan(argument)
                Case "sqrt"
                    If argument < 0 Then
                        Throw New InvalidOperationException("Cannot calculate square root of a negative number.")
                    End If
                    Return Math.Sqrt(argument)
                Case "log10", "log"
                    If argument <= 0 Then
                        Throw New InvalidOperationException("Logarithm undefined for values <= 0.")
                    End If
                    Return Math.Log10(argument)
                Case "ln"
                    If argument <= 0 Then
                        Throw New InvalidOperationException("Natural log undefined for values <= 0.")
                    End If
                    Return Math.Log(argument)
                Case Else
                    Throw New InvalidOperationException($"Unknown function: {identifier}")
            End Select
        End If

        Throw New InvalidOperationException($"Unexpected character: '{_currentChar}'")
    End Function

    Private Function ParseNumber() As Double
        Dim startPos As Integer = _pos
        Dim hasDecimal As Boolean = False

        While _pos < _expression.Length AndAlso (Char.IsDigit(_currentChar) OrElse (_currentChar = "."c AndAlso Not hasDecimal))
            If _currentChar = "."c Then
                hasDecimal = True
            End If
            Advance()
        End While

        ' Handle scientific notation in numbers (e.g., 1e-5 or 2.5E+3) if produced by previous calculation
        If (_currentChar = "e"c OrElse _currentChar = "E"c) AndAlso _pos + 1 < _expression.Length Then
            Dim nextChar As Char = _expression(_pos + 1)
            If Char.IsDigit(nextChar) OrElse nextChar = "+"c OrElse nextChar = "-"c Then
                Advance() ' skip 'e'
                If _currentChar = "+"c OrElse _currentChar = "-"c Then
                    Advance()
                End If
                While _pos < _expression.Length AndAlso Char.IsDigit(_currentChar)
                    Advance()
                End While
            End If
        End If

        Dim numStr As String = _expression.Substring(startPos, _pos - startPos)
        Dim val As Double
        If Double.TryParse(numStr, NumberStyles.Float, CultureInfo.InvariantCulture, val) Then
            Return val
        End If

        Throw New InvalidOperationException($"Invalid number format: '{numStr}'")
    End Function

    Private Function ParseIdentifier() As String
        Dim startPos As Integer = _pos
        While _pos < _expression.Length AndAlso (Char.IsLetterOrDigit(_currentChar) OrElse _currentChar = "π"c)
            Advance()
        End While
        Return _expression.Substring(startPos, _pos - startPos)
    End Function

End Class
