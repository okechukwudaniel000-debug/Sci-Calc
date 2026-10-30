Imports System.Globalization

''' <summary>
''' Represents the main interface for the Scientific Calculator application.
''' Supports standard arithmetic operations and advanced scientific functions.
''' </summary>
Public Class Form1

#Region "Event Handlers - Numeric Buttons"

    ''' <summary>
    ''' Handles the click event for numeric buttons (1-9).
    ''' </summary>
    Private Sub NumericButton_Click(sender As Object, e As EventArgs) Handles _
        btnOne.Click, btnTwo.Click, btnThree.Click, btnFour.Click, btnFive.Click,
        btnSix.Click, btnSeven.Click, btnEight.Click, btnNine.Click

        Dim btn As Button = TryCast(sender, Button)
        If btn IsNot Nothing Then
            ' Replace initial zero or previous error
            If txtDisplay.Text = "0" OrElse txtDisplay.Text.StartsWith("Error") Then
                txtDisplay.Text = btn.Text
            Else
                txtDisplay.AppendText(btn.Text)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Handles the click event for the zero button.
    ''' </summary>
    Private Sub ZeroButton_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        If txtDisplay.Text.StartsWith("Error") Then
            txtDisplay.Text = "0"
            Return
        End If

        ' Avoid leading zeros unless it's following an operator or decimal
        If txtDisplay.Text <> "0" Then
            txtDisplay.AppendText("0")
        End If
    End Sub

    ''' <summary>
    ''' Handles the click event for the decimal point button.
    ''' </summary>
    Private Sub DecimalButton_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        If String.IsNullOrEmpty(txtDisplay.Text) OrElse txtDisplay.Text = "0" OrElse txtDisplay.Text.StartsWith("Error") Then
            txtDisplay.Text = "0."
            Return
        End If

        ' Find the last number token in the expression
        Dim currentText As String = txtDisplay.Text
        Dim lastOpIndex As Integer = currentText.LastIndexOfAny(New Char() {"+"c, "-"c, "*"c, "/"c, "^"c, "("c})
        Dim currentNumber As String = If(lastOpIndex = -1, currentText, currentText.Substring(lastOpIndex + 1))

        If Not currentNumber.Contains(".") Then
            txtDisplay.AppendText(".")
        End If
    End Sub

#End Region

#Region "Event Handlers - Control Buttons"

    ''' <summary>
    ''' Handles the click event for the clear button.
    ''' </summary>
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Text = "0"
    End Sub

    ''' <summary>
    ''' Handles the click event for the delete button to remove the last character.
    ''' </summary>
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtDisplay.Text.StartsWith("Error") Then
            txtDisplay.Text = "0"
            Return
        End If

        If txtDisplay.Text.Length > 0 AndAlso txtDisplay.Text <> "0" Then
            ' If deleting a function like "sin(", "cos(", "tan(", "ln(", "log10(", "sqrt("
            Dim funcs() As String = {"log10(", "sqrt(", "sin(", "cos(", "tan(", "ln("}
            Dim matchedFunc As Boolean = False
            For Each f As String In funcs
                If txtDisplay.Text.EndsWith(f, StringComparison.OrdinalIgnoreCase) Then
                    txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - f.Length)
                    matchedFunc = True
                    Exit For
                End If
            Next

            If Not matchedFunc Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1)
            End If
        End If

        ' If the display becomes empty, reset to "0"
        If String.IsNullOrEmpty(txtDisplay.Text) Then
            txtDisplay.Text = "0"
        End If
    End Sub

#End Region

#Region "Event Handlers - Operator Buttons"

    ''' <summary>
    ''' Handles the click event for operator buttons (+, -, *, /).
    ''' </summary>
    Private Sub OperatorButton_Click(sender As Object, e As EventArgs) Handles _
        btnPlus.Click, btnMinus.Click, btnMultiply.Click, btnDivide.Click

        Dim btn As Button = TryCast(sender, Button)
        If btn IsNot Nothing AndAlso Not String.IsNullOrEmpty(txtDisplay.Text) Then
            If txtDisplay.Text.StartsWith("Error") Then
                txtDisplay.Text = "0"
            End If

            Dim currentText As String = txtDisplay.Text
            Dim lastChar As Char = currentText(currentText.Length - 1)

            ' If the last character is an operator, replace it instead of appending
            If IsOperator(lastChar) Then
                txtDisplay.Text = currentText.Substring(0, currentText.Length - 1) & btn.Text
            Else
                txtDisplay.AppendText(btn.Text)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Handles parenthesis buttons - appends opening and closing brackets.
    ''' </summary>
    Private Sub BracketButton_Click(sender As Object, e As EventArgs) Handles _
        btnOpenBracket.Click, btnCloseBracket.Click

        Dim btn As Button = TryCast(sender, Button)
        If btn IsNot Nothing Then
            If txtDisplay.Text = "0" OrElse txtDisplay.Text.StartsWith("Error") Then
                txtDisplay.Text = btn.Text
            Else
                Dim currentText As String = txtDisplay.Text
                Dim lastChar As Char = currentText(currentText.Length - 1)

                ' Implicit multiplication before opening bracket if following a digit or closing bracket
                If btn.Text = "(" AndAlso (Char.IsDigit(lastChar) OrElse lastChar = ")"c OrElse lastChar = "e"c OrElse lastChar = "π"c) Then
                    txtDisplay.AppendText("*" & btn.Text)
                Else
                    txtDisplay.AppendText(btn.Text)
                End If
            End If
        End If
    End Sub

#End Region

#Region "Event Handlers - Scientific Functions (Trigonometric)"

    ''' <summary>
    ''' Handles the sine function button - appends "sin(" to the expression.
    ''' </summary>
    Private Sub SinButton_Click(sender As Object, e As EventArgs) Handles btnSin.Click
        AppendScientificFunction("sin(")
    End Sub

    ''' <summary>
    ''' Handles the cosine function button - appends "cos(" to the expression.
    ''' </summary>
    Private Sub CosButton_Click(sender As Object, e As EventArgs) Handles btnCos.Click
        AppendScientificFunction("cos(")
    End Sub

    ''' <summary>
    ''' Handles the tangent function button - appends "tan(" to the expression.
    ''' </summary>
    Private Sub TanButton_Click(sender As Object, e As EventArgs) Handles btnTan.Click
        AppendScientificFunction("tan(")
    End Sub

#End Region

#Region "Event Handlers - Scientific Functions (Powers and Roots)"

    ''' <summary>
    ''' Handles the square root function button - appends "sqrt(" to the expression.
    ''' </summary>
    Private Sub SqrtButton_Click(sender As Object, e As EventArgs) Handles btnSqrt.Click
        AppendScientificFunction("sqrt(")
    End Sub

    ''' <summary>
    ''' Handles the square function button - appends "^2" to the current expression.
    ''' </summary>
    Private Sub SquareButton_Click(sender As Object, e As EventArgs) Handles btnSquare.Click
        If Not String.IsNullOrEmpty(txtDisplay.Text) AndAlso txtDisplay.Text <> "0" AndAlso Not txtDisplay.Text.StartsWith("Error") Then
            Dim lastChar As Char = txtDisplay.Text(txtDisplay.Text.Length - 1)
            If Not IsOperator(lastChar) AndAlso lastChar <> "("c Then
                txtDisplay.AppendText("^2")
            End If
        End If
    End Sub

    ''' <summary>
    ''' Handles the power function button - appends "^" for exponentiation (x^y).
    ''' </summary>
    Private Sub PowerButton_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        If Not String.IsNullOrEmpty(txtDisplay.Text) AndAlso Not txtDisplay.Text.StartsWith("Error") Then
            Dim currentText As String = txtDisplay.Text
            Dim lastChar As Char = currentText(currentText.Length - 1)
            If IsOperator(lastChar) Then
                txtDisplay.Text = currentText.Substring(0, currentText.Length - 1) & "^"
            ElseIf lastChar <> "("c Then
                txtDisplay.AppendText("^")
            End If
        End If
    End Sub

#End Region

#Region "Event Handlers - Scientific Functions (Logarithmic)"

    ''' <summary>
    ''' Handles the logarithm (base 10) function button - appends "log10(" to the expression.
    ''' </summary>
    Private Sub LogButton_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        AppendScientificFunction("log10(")
    End Sub

    ''' <summary>
    ''' Handles the natural logarithm function button - appends "ln(" to the expression.
    ''' </summary>
    Private Sub LnButton_Click(sender As Object, e As EventArgs) Handles btnLn.Click
        AppendScientificFunction("ln(")
    End Sub

#End Region

#Region "Event Handlers - Constants"

    ''' <summary>
    ''' Handles the pi constant button - appends pi.
    ''' </summary>
    Private Sub PiButton_Click(sender As Object, e As EventArgs) Handles btnPi.Click
        AppendConstant("π")
    End Sub

    ''' <summary>
    ''' Handles the Euler's number (e) constant button - appends e.
    ''' </summary>
    Private Sub EButton_Click(sender As Object, e As EventArgs) Handles btnE.Click
        AppendConstant("e")
    End Sub

#End Region

#Region "Event Handlers - Calculation"

    ''' <summary>
    ''' Handles the click event for the equals button to evaluate the expression.
    ''' Evaluates standard arithmetic, powers, roots, trigonometry, and logarithms.
    ''' </summary>
    Private Sub EqualsButton_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        If String.IsNullOrEmpty(txtDisplay.Text) OrElse txtDisplay.Text = "0" OrElse txtDisplay.Text.StartsWith("Error") Then
            Return
        End If

        Try
            Dim expression As String = txtDisplay.Text
            
            ' Auto-close any unclosed parentheses for user convenience
            Dim openCount As Integer = expression.Count(Function(c) c = "("c)
            Dim closeCount As Integer = expression.Count(Function(c) c = ")"c)
            If openCount > closeCount Then
                expression &= New String(")"c, openCount - closeCount)
            End If

            ' Evaluate using our dedicated scientific evaluator
            Dim result As Double = ScientificExpressionEvaluator.Evaluate(expression)
            
            If Double.IsNaN(result) OrElse Double.IsInfinity(result) Then
                txtDisplay.Text = "Error: Invalid Operation"
            Else
                txtDisplay.Text = FormatResult(result)
            End If
        Catch ex As DivideByZeroException
            txtDisplay.Text = "Error: Division by Zero"
        Catch ex As InvalidOperationException
            txtDisplay.Text = "Error: " & ex.Message
        Catch ex As Exception
            txtDisplay.Text = "Error: Invalid Expression"
        End Try
    End Sub

#End Region

#Region "Helper Methods - Scientific Expression Processing"

    ''' <summary>
    ''' Appends a scientific function to the display with proper handling.
    ''' Replaces initial zero and manages function syntax.
    ''' </summary>
    ''' <param name="functionText">The function text to append (e.g., "sin(", "log10(")</param>
    Private Sub AppendScientificFunction(functionText As String)
        If txtDisplay.Text = "0" OrElse txtDisplay.Text.StartsWith("Error") Then
            txtDisplay.Text = functionText
        Else
            Dim currentText As String = txtDisplay.Text
            Dim lastChar As Char = currentText(currentText.Length - 1)
            
            ' If the last character is an operator or opening bracket, append directly
            If IsOperator(lastChar) OrElse lastChar = "("c Then
                txtDisplay.AppendText(functionText)
            Else
                ' Otherwise, insert implicit multiplication before the function
                txtDisplay.AppendText("*" & functionText)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Appends a mathematical constant (e.g., π or e) to the display.
    ''' </summary>
    ''' <param name="constantSymbol">The symbol of the constant</param>
    Private Sub AppendConstant(constantSymbol As String)
        If txtDisplay.Text = "0" OrElse txtDisplay.Text.StartsWith("Error") Then
            txtDisplay.Text = constantSymbol
        Else
            Dim currentText As String = txtDisplay.Text
            Dim lastChar As Char = currentText(currentText.Length - 1)
            
            If IsOperator(lastChar) OrElse lastChar = "("c Then
                txtDisplay.AppendText(constantSymbol)
            Else
                txtDisplay.AppendText("*" & constantSymbol)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Formats the result to a reasonable number of decimal places.
    ''' Removes trailing zeros and unnecessary decimal points.
    ''' </summary>
    ''' <param name="value">The numeric result to format</param>
    ''' <returns>Formatted string representation</returns>
    Private Function FormatResult(value As Double) As String
        ' Limit precision and clean roundoff issues (e.g. sin(pi) -> 0)
        If Math.Abs(value) < 1E-14 AndAlso value <> 0.0 Then
            value = 0.0
        End If

        If Math.Abs(value) < 1000000000000.0 AndAlso (Math.Abs(value) >= 0.000001 OrElse value = 0.0) Then
            Dim str As String = value.ToString("G12", CultureInfo.InvariantCulture)
            Return str
        Else
            Return value.ToString("E6", CultureInfo.InvariantCulture)
        End If
    End Function

#End Region

#Region "Helper Methods - Validation"

    ''' <summary>
    ''' Determines if a character is a mathematical operator.
    ''' </summary>
    ''' <param name="c">The character to check.</param>
    ''' <returns>True if the character is an operator; otherwise, false.</returns>
    Private Function IsOperator(c As Char) As Boolean
        Return "+-*/^".Contains(c)
    End Function

#End Region

End Class
