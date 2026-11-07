Imports System.Globalization

''' <summary>
''' Represents the main interface for the Scientific Calculator application.
''' Supports standard arithmetic operations and advanced scientific functions
''' following modern scientific calculator layouts.
''' </summary>
Public Class Form1

    ''' <summary>
    ''' Current angle mode for trigonometric calculations (Degrees or Radians).
    ''' </summary>
    Private currentAngleMode As AngleMode = AngleMode.Degrees

    ''' <summary>
    ''' Flag indicating whether the current result is just computed and a new digit should reset the input.
    ''' </summary>
    Private isResultDisplayed As Boolean = False

#Region "Event Handlers - Angle Mode"

    ''' <summary>
    ''' Handles toggling between Degrees and Radians mode.
    ''' </summary>
    Private Sub DegRadButton_Click(sender As Object, e As EventArgs) Handles btnDegRad.Click
        If currentAngleMode = AngleMode.Degrees Then
            currentAngleMode = AngleMode.Radians
            lblMode.Text = "RAD"
            btnDegRad.Text = "RAD"
            lblMode.ForeColor = Color.FromArgb(0, 180, 255)
            btnDegRad.ForeColor = Color.FromArgb(0, 180, 255)
        Else
            currentAngleMode = AngleMode.Degrees
            lblMode.Text = "DEG"
            btnDegRad.Text = "DEG"
            lblMode.ForeColor = Color.FromArgb(255, 159, 10)
            btnDegRad.ForeColor = Color.FromArgb(255, 159, 10)
        End If
    End Sub

#End Region

#Region "Event Handlers - Numeric Buttons"

    ''' <summary>
    ''' Handles the click event for numeric buttons (1-9).
    ''' </summary>
    Private Sub NumericButton_Click(sender As Object, e As EventArgs) Handles _
        btnOne.Click, btnTwo.Click, btnThree.Click, btnFour.Click, btnFive.Click,
        btnSix.Click, btnNine.Click, btnEight.Click, btnSeven.Click

        Dim btn As Button = TryCast(sender, Button)
        If btn IsNot Nothing Then
            If isResultDisplayed OrElse txtResult.Text = "0" OrElse txtResult.Text.StartsWith("Error") Then
                txtResult.Text = btn.Text
                isResultDisplayed = False
            Else
                txtResult.AppendText(btn.Text)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Handles the click event for the zero button.
    ''' </summary>
    Private Sub ZeroButton_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        If isResultDisplayed OrElse txtResult.Text.StartsWith("Error") Then
            txtResult.Text = "0"
            isResultDisplayed = False
            Return
        End If

        If txtResult.Text <> "0" Then
            txtResult.AppendText("0")
        End If
    End Sub

    ''' <summary>
    ''' Handles the click event for the decimal point button.
    ''' </summary>
    Private Sub DecimalButton_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        If isResultDisplayed OrElse String.IsNullOrEmpty(txtResult.Text) OrElse txtResult.Text = "0" OrElse txtResult.Text.StartsWith("Error") Then
            txtResult.Text = "0."
            isResultDisplayed = False
            Return
        End If

        Dim currentText As String = txtResult.Text
        Dim lastOpIndex As Integer = currentText.LastIndexOfAny(New Char() {"+"c, "-"c, "*"c, "/"c, "×"c, "÷"c, "−"c, "^"c, "("c})
        Dim currentNumber As String = If(lastOpIndex = -1, currentText, currentText.Substring(lastOpIndex + 1))

        If Not currentNumber.Contains(".") Then
            txtResult.AppendText(".")
        End If
    End Sub

#End Region

#Region "Event Handlers - Control Buttons"

    ''' <summary>
    ''' Handles the All Clear (AC) button.
    ''' </summary>
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtResult.Text = "0"
        txtExpression.Text = ""
        isResultDisplayed = False
    End Sub

    ''' <summary>
    ''' Handles the backspace / delete button.
    ''' </summary>
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If isResultDisplayed OrElse txtResult.Text.StartsWith("Error") Then
            txtResult.Text = "0"
            isResultDisplayed = False
            Return
        End If

        If txtResult.Text.Length > 0 AndAlso txtResult.Text <> "0" Then
            Dim funcs() As String = {"log(", "ln(", "sqrt(", "sin(", "cos(", "tan(", "asin(", "acos(", "atan("}
            Dim matchedFunc As Boolean = False
            For Each f As String In funcs
                If txtResult.Text.EndsWith(f, StringComparison.OrdinalIgnoreCase) Then
                    txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - f.Length)
                    matchedFunc = True
                    Exit For
                End If
            Next

            If Not matchedFunc Then
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1)
            End If
        End If

        If String.IsNullOrEmpty(txtResult.Text) Then
            txtResult.Text = "0"
        End If
    End Sub

#End Region

#Region "Event Handlers - Operator Buttons"

    ''' <summary>
    ''' Handles operator buttons (+, −, ×, ÷).
    ''' </summary>
    Private Sub OperatorButton_Click(sender As Object, e As EventArgs) Handles _
        btnPlus.Click, btnMinus.Click, btnMultiply.Click, btnDivide.Click

        Dim btn As Button = TryCast(sender, Button)
        If btn IsNot Nothing AndAlso Not String.IsNullOrEmpty(txtResult.Text) Then
            If txtResult.Text.StartsWith("Error") Then
                txtResult.Text = "0"
            End If

            isResultDisplayed = False
            Dim currentText As String = txtResult.Text
            Dim lastChar As Char = currentText(currentText.Length - 1)

            Dim opChar As String = btn.Text
            If IsOperator(lastChar) Then
                txtResult.Text = currentText.Substring(0, currentText.Length - 1) & opChar
            Else
                txtResult.AppendText(opChar)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Handles parenthesis buttons: ( and )
    ''' </summary>
    Private Sub BracketButton_Click(sender As Object, e As EventArgs) Handles _
        btnOpenBracket.Click, btnCloseBracket.Click

        Dim btn As Button = TryCast(sender, Button)
        If btn IsNot Nothing Then
            If isResultDisplayed OrElse txtResult.Text = "0" OrElse txtResult.Text.StartsWith("Error") Then
                txtResult.Text = btn.Text
                isResultDisplayed = False
            Else
                Dim currentText As String = txtResult.Text
                Dim lastChar As Char = currentText(currentText.Length - 1)

                If btn.Text = "(" AndAlso (Char.IsDigit(lastChar) OrElse lastChar = ")"c OrElse lastChar = "e"c OrElse lastChar = "π"c) Then
                    txtResult.AppendText("×" & btn.Text)
                Else
                    txtResult.AppendText(btn.Text)
                End If
            End If
        End If
    End Sub

    ''' <summary>
    ''' Handles percentage button (%).
    ''' </summary>
    Private Sub PercentButton_Click(sender As Object, e As EventArgs) Handles btnPercent.Click
        If Not String.IsNullOrEmpty(txtResult.Text) AndAlso Not txtResult.Text.StartsWith("Error") Then
            Dim lastChar As Char = txtResult.Text(txtResult.Text.Length - 1)
            If Char.IsDigit(lastChar) OrElse lastChar = ")"c OrElse lastChar = "π"c OrElse lastChar = "e"c Then
                txtResult.AppendText("%")
                isResultDisplayed = False
            End If
        End If
    End Sub

    ''' <summary>
    ''' Handles factorial button (n!).
    ''' </summary>
    Private Sub FactorialButton_Click(sender As Object, e As EventArgs) Handles btnFactorial.Click
        If Not String.IsNullOrEmpty(txtResult.Text) AndAlso Not txtResult.Text.StartsWith("Error") Then
            Dim lastChar As Char = txtResult.Text(txtResult.Text.Length - 1)
            If Char.IsDigit(lastChar) OrElse lastChar = ")"c Then
                txtResult.AppendText("!")
                isResultDisplayed = False
            End If
        End If
    End Sub

#End Region

#Region "Event Handlers - Scientific Functions"

    Private Sub SinButton_Click(sender As Object, e As EventArgs) Handles btnSin.Click
        AppendScientificFunction("sin(")
    End Sub

    Private Sub CosButton_Click(sender As Object, e As EventArgs) Handles btnCos.Click
        AppendScientificFunction("cos(")
    End Sub

    Private Sub TanButton_Click(sender As Object, e As EventArgs) Handles btnTan.Click
        AppendScientificFunction("tan(")
    End Sub

    Private Sub SqrtButton_Click(sender As Object, e As EventArgs) Handles btnSqrt.Click
        AppendScientificFunction("sqrt(")
    End Sub

    Private Sub SquareButton_Click(sender As Object, e As EventArgs) Handles btnSquare.Click
        AppendPostfixPower("^2")
    End Sub

    Private Sub CubeButton_Click(sender As Object, e As EventArgs) Handles btnCube.Click
        AppendPostfixPower("^3")
    End Sub

    Private Sub PowerButton_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        If Not String.IsNullOrEmpty(txtResult.Text) AndAlso Not txtResult.Text.StartsWith("Error") Then
            Dim currentText As String = txtResult.Text
            Dim lastChar As Char = currentText(currentText.Length - 1)
            If IsOperator(lastChar) Then
                txtResult.Text = currentText.Substring(0, currentText.Length - 1) & "^"
            ElseIf lastChar <> "("c Then
                txtResult.AppendText("^")
            End If
            isResultDisplayed = False
        End If
    End Sub

    Private Sub ReciprocalButton_Click(sender As Object, e As EventArgs) Handles btnReciprocal.Click
        AppendPostfixPower("^(-1)")
    End Sub

    Private Sub ExpButton_Click(sender As Object, e As EventArgs) Handles btnExp.Click
        If isResultDisplayed OrElse txtResult.Text = "0" OrElse txtResult.Text.StartsWith("Error") Then
            txtResult.Text = "e^"
            isResultDisplayed = False
        Else
            Dim lastChar As Char = txtResult.Text(txtResult.Text.Length - 1)
            If IsOperator(lastChar) OrElse lastChar = "("c Then
                txtResult.AppendText("e^")
            Else
                txtResult.AppendText("×e^")
            End If
        End If
    End Sub

    Private Sub LogButton_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        AppendScientificFunction("log(")
    End Sub

    Private Sub LnButton_Click(sender As Object, e As EventArgs) Handles btnLn.Click
        AppendScientificFunction("ln(")
    End Sub

    Private Sub PiButton_Click(sender As Object, e As EventArgs) Handles btnPi.Click
        AppendConstant("π")
    End Sub

    Private Sub EButton_Click(sender As Object, e As EventArgs) Handles btnE.Click
        AppendConstant("e")
    End Sub

#End Region

#Region "Event Handlers - Calculation"

    ''' <summary>
    ''' Evaluates the current mathematical expression and updates display.
    ''' </summary>
    Private Sub EqualsButton_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        If String.IsNullOrEmpty(txtResult.Text) OrElse txtResult.Text.StartsWith("Error") Then
            Return
        End If

        Try
            Dim rawExpression As String = txtResult.Text

            ' Auto-close open parentheses
            Dim openCount As Integer = rawExpression.Count(Function(c) c = "("c)
            Dim closeCount As Integer = rawExpression.Count(Function(c) c = ")"c)
            If openCount > closeCount Then
                rawExpression &= New String(")"c, openCount - closeCount)
            End If

            ' Display the full expression in txtExpression
            txtExpression.Text = rawExpression & " ="

            ' Standardize characters for evaluation
            Dim cleanExpr As String = rawExpression.Replace("×", "*").Replace("÷", "/").Replace("−", "-")

            Dim result As Double = ScientificExpressionEvaluator.Evaluate(cleanExpr, currentAngleMode)

            If Double.IsNaN(result) OrElse Double.IsInfinity(result) Then
                txtResult.Text = "Error: Invalid Operation"
            Else
                txtResult.Text = FormatResult(result)
            End If
            isResultDisplayed = True
        Catch ex As DivideByZeroException
            txtResult.Text = "Error: Division by 0"
            isResultDisplayed = True
        Catch ex As InvalidOperationException
            txtResult.Text = "Error: " & ex.Message
            isResultDisplayed = True
        Catch ex As Exception
            txtResult.Text = "Error: Invalid Expression"
            isResultDisplayed = True
        End Try
    End Sub

#End Region

#Region "Helper Methods"

    Private Sub AppendPostfixPower(powerText As String)
        If Not String.IsNullOrEmpty(txtResult.Text) AndAlso txtResult.Text <> "0" AndAlso Not txtResult.Text.StartsWith("Error") Then
            Dim lastChar As Char = txtResult.Text(txtResult.Text.Length - 1)
            If Not IsOperator(lastChar) AndAlso lastChar <> "("c Then
                txtResult.AppendText(powerText)
                isResultDisplayed = False
            End If
        End If
    End Sub

    Private Sub AppendScientificFunction(functionText As String)
        If isResultDisplayed OrElse txtResult.Text = "0" OrElse txtResult.Text.StartsWith("Error") Then
            txtResult.Text = functionText
            isResultDisplayed = False
        Else
            Dim currentText As String = txtResult.Text
            Dim lastChar As Char = currentText(currentText.Length - 1)

            If IsOperator(lastChar) OrElse lastChar = "("c Then
                txtResult.AppendText(functionText)
            Else
                txtResult.AppendText("×" & functionText)
            End If
        End If
    End Sub

    Private Sub AppendConstant(constantSymbol As String)
        If isResultDisplayed OrElse txtResult.Text = "0" OrElse txtResult.Text.StartsWith("Error") Then
            txtResult.Text = constantSymbol
            isResultDisplayed = False
        Else
            Dim currentText As String = txtResult.Text
            Dim lastChar As Char = currentText(currentText.Length - 1)

            If IsOperator(lastChar) OrElse lastChar = "("c Then
                txtResult.AppendText(constantSymbol)
            Else
                txtResult.AppendText("×" & constantSymbol)
            End If
        End If
    End Sub

    Private Function FormatResult(value As Double) As String
        If Math.Abs(value) < 1E-14 AndAlso value <> 0.0 Then
            value = 0.0
        End If

        If Math.Abs(value) < 1000000000000.0 AndAlso (Math.Abs(value) >= 0.000001 OrElse value = 0.0) Then
            Return value.ToString("G12", CultureInfo.InvariantCulture)
        Else
            Return value.ToString("E6", CultureInfo.InvariantCulture)
        End If
    End Function

    Private Function IsOperator(c As Char) As Boolean
        Return "+-*/^×÷−".Contains(c)
    End Function

#End Region

End Class
