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

    ''' <summary>
    ''' Flag indicating whether the current text in txtResult represents an error/status message.
    ''' </summary>
    Private isErrorDisplayed As Boolean = False

    ''' <summary>
    ''' Current value stored in calculator memory (M).
    ''' </summary>
    Private memoryValue As Double = 0.0

    ''' <summary>
    ''' Indicates whether the calculator currently holds a non-zero value in memory.
    ''' </summary>
    Private hasMemoryValue As Boolean = False

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
            If isResultDisplayed OrElse IsErrorState() OrElse txtResult.Text = "0" Then
                ResetDisplayForNewInput(btn.Text)
            Else
                txtResult.AppendText(btn.Text)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Handles the click event for the zero button.
    ''' </summary>
    Private Sub ZeroButton_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        If isResultDisplayed OrElse IsErrorState() Then
            ResetDisplayForNewInput("0")
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
        If isResultDisplayed OrElse IsErrorState() OrElse String.IsNullOrEmpty(txtResult.Text) OrElse txtResult.Text = "0" Then
            ResetDisplayForNewInput("0.")
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
        ResetDisplayForNewInput("0")
        txtExpression.Text = ""
    End Sub

    ''' <summary>
    ''' Handles the backspace / delete button.
    ''' </summary>
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If isResultDisplayed OrElse IsErrorState() Then
            ResetDisplayForNewInput("0")
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
            If IsErrorState() Then
                ResetDisplayForNewInput("0")
            End If

            ResetDisplayForNewInput()
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
            If isResultDisplayed OrElse IsErrorState() OrElse txtResult.Text = "0" Then
                ResetDisplayForNewInput(btn.Text)
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
        If Not String.IsNullOrEmpty(txtResult.Text) AndAlso Not IsErrorState() Then
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
        If Not String.IsNullOrEmpty(txtResult.Text) AndAlso Not IsErrorState() Then
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
        If Not String.IsNullOrEmpty(txtResult.Text) AndAlso Not IsErrorState() Then
            Dim currentText As String = txtResult.Text
            Dim lastChar As Char = currentText(currentText.Length - 1)
            If IsOperator(lastChar) Then
                txtResult.Text = currentText.Substring(0, currentText.Length - 1) & "^"
            ElseIf lastChar <> "("c Then
                txtResult.AppendText("^")
            End If
            ResetDisplayForNewInput()
        End If
    End Sub

    Private Sub ReciprocalButton_Click(sender As Object, e As EventArgs) Handles btnReciprocal.Click
        AppendPostfixPower("^(-1)")
    End Sub

    Private Sub ExpButton_Click(sender As Object, e As EventArgs) Handles btnExp.Click
        If isResultDisplayed OrElse IsErrorState() OrElse txtResult.Text = "0" Then
            ResetDisplayForNewInput("e^")
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
            Dim rawExpression As String = txtResult.Text.Trim()

            ' Validate parentheses balance
            Dim unclosedCount As Integer = CheckParenthesesBalance(rawExpression)

            ' If there are unclosed brackets (e.g., (5 + 3 * 2), auto-complete them
            If unclosedCount > 0 Then
                Dim autoCompletedBrackets As String = New String(")"c, unclosedCount)
                rawExpression &= autoCompletedBrackets
            End If

            ' Display the completed expression in txtExpression
            txtExpression.Text = rawExpression & " ="

            ' Standardize characters for evaluation
            Dim cleanExpr As String = rawExpression.Replace("×", "*").Replace("÷", "/").Replace("−", "-")

            Dim result As Double = ScientificExpressionEvaluator.Evaluate(cleanExpr, currentAngleMode)

            If Double.IsNaN(result) OrElse Double.IsInfinity(result) Then
                DisplayError("Invalid operation")
            Else
                Dim formattedResult As String = FormatResult(result)
                txtResult.Text = formattedResult
                txtResult.ForeColor = Color.Black
                isResultDisplayed = True
                isErrorDisplayed = False
                AddHistoryItem(rawExpression, formattedResult)
            End If
        Catch ex As DivideByZeroException
            DisplayError("Cannot divide by zero")
        Catch ex As InvalidOperationException
            DisplayError(ex.Message)
        Catch ex As ArgumentException
            DisplayError("Invalid input")
        Catch ex As Exception
            DisplayError("Invalid input")
        End Try
    End Sub

#End Region

#Region "Helper Methods"

    Private Sub AppendPostfixPower(powerText As String)
        If Not String.IsNullOrEmpty(txtResult.Text) AndAlso txtResult.Text <> "0" AndAlso Not IsErrorState() Then
            Dim lastChar As Char = txtResult.Text(txtResult.Text.Length - 1)
            If Not IsOperator(lastChar) AndAlso lastChar <> "("c Then
                txtResult.AppendText(powerText)
                ResetDisplayForNewInput()
            End If
        End If
    End Sub

    Private Sub AppendScientificFunction(functionText As String)
        If isResultDisplayed OrElse IsErrorState() OrElse txtResult.Text = "0" Then
            ResetDisplayForNewInput(functionText)
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
        If isResultDisplayed OrElse IsErrorState() OrElse txtResult.Text = "0" Then
            ResetDisplayForNewInput(constantSymbol)
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
        If Math.Abs(value) < 0.00000000000001 AndAlso value <> 0.0 Then
            value = 0.0
        End If

        If Math.Abs(value) < 1000000000000.0 AndAlso (Math.Abs(value) >= 0.000001 OrElse value = 0.0) Then
            Return value.ToString("G12", CultureInfo.InvariantCulture)
        Else
            Return value.ToString("E6", CultureInfo.InvariantCulture)
        End If
    End Function

    ''' <summary>
    ''' Inspects the expression and returns the count of missing closing brackets,
    ''' or throws InvalidOperationException if closing brackets appear before opening ones.
    ''' </summary>
    Private Function CheckParenthesesBalance(expr As String) As Integer
        Dim depth As Integer = 0
        For i As Integer = 0 To expr.Length - 1
            If expr(i) = "("c Then
                depth += 1
            ElseIf expr(i) = ")"c Then
                depth -= 1
                If depth < 0 Then
                    Throw New InvalidOperationException("Mismatched parentheses: unexpected ')'")
                End If
            End If
        Next
        Return depth
    End Function

    Private Function IsOperator(c As Char) As Boolean
        Return "+-*/^×÷−".Contains(c)
    End Function

    Private Function IsErrorState() As Boolean
        Return isErrorDisplayed OrElse txtResult.Text.StartsWith("Error")
    End Function

    Private Sub ResetDisplayForNewInput(Optional initialText As String = "")
        isResultDisplayed = False
        isErrorDisplayed = False
        txtResult.ForeColor = Color.Black
        If Not String.IsNullOrEmpty(initialText) Then
            txtResult.Text = initialText
        End If
    End Sub

    Private Sub DisplayError(message As String)
        txtResult.Text = message
        txtResult.ForeColor = Color.FromArgb(215, 38, 56)
        isResultDisplayed = True
        isErrorDisplayed = True
    End Sub

#End Region

#Region "Keyboard Navigation & Hotkeys"

    ''' <summary>
    ''' Handles non-character command keys (Enter, Esc, Backspace, Delete, Arrows) at the form level.
    ''' </summary>
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.Enter
                btnEquals.PerformClick()
                Return True

            Case Keys.Escape
                btnClear.PerformClick()
                Return True

            Case Keys.Back
                btnDelete.PerformClick()
                Return True

            Case Keys.Delete
                btnClear.PerformClick()
                Return True

            Case Keys.Control Or Keys.C
                If Not String.IsNullOrEmpty(txtResult.Text) AndAlso Not IsErrorState() Then
                    Clipboard.SetText(txtResult.Text)
                End If
                Return True

            Case Keys.Control Or Keys.V
                If Clipboard.ContainsText() Then
                    Dim pasted As String = Clipboard.GetText().Trim()
                    If Not String.IsNullOrEmpty(pasted) Then
                        ' Allow standard digits, math operators, constants, and function names
                        Dim safeChars As String = "0123456789.+-*/^%eπ(), "
                        Dim isClean As Boolean = pasted.All(Function(ch) safeChars.Contains(ch) OrElse Char.IsLetter(ch))
                        If isClean Then
                            ' Also update txtExpression so the user sees the pasted formula
                            txtExpression.Text = pasted
                            If isResultDisplayed OrElse IsErrorState() OrElse txtResult.Text = "0" Then
                                ResetDisplayForNewInput(pasted)
                            Else
                                txtResult.AppendText(pasted)
                            End If
                        End If
                    End If
                End If
                Return True

            Case Keys.Control Or Keys.D
                btnDegRad.PerformClick()
                Return True

            Case Keys.Control Or Keys.H
                btnHistory.PerformClick()
                Return True
        End Select

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    ''' <summary>
    ''' Handles printable character input across standard digits, operators, brackets, and scientific shortcut keys.
    ''' </summary>
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Dim ch As Char = e.KeyChar

        Select Case ch
            Case "0"c
                btnZero.PerformClick()
                e.Handled = True
            Case "1"c
                btnOne.PerformClick()
                e.Handled = True
            Case "2"c
                btnTwo.PerformClick()
                e.Handled = True
            Case "3"c
                btnThree.PerformClick()
                e.Handled = True
            Case "4"c
                btnFour.PerformClick()
                e.Handled = True
            Case "5"c
                btnFive.PerformClick()
                e.Handled = True
            Case "6"c
                btnSix.PerformClick()
                e.Handled = True
            Case "7"c
                btnSeven.PerformClick()
                e.Handled = True
            Case "8"c
                btnEight.PerformClick()
                e.Handled = True
            Case "9"c
                btnNine.PerformClick()
                e.Handled = True

            Case "."c, ","c
                btnDecimal.PerformClick()
                e.Handled = True

            Case "+"c
                btnPlus.PerformClick()
                e.Handled = True
            Case "-"c
                btnMinus.PerformClick()
                e.Handled = True
            Case "*"c, "x"c, "X"c
                btnMultiply.PerformClick()
                e.Handled = True
            Case "/"c
                btnDivide.PerformClick()
                e.Handled = True
            Case "="c
                btnEquals.PerformClick()
                e.Handled = True

            Case "("c
                btnOpenBracket.PerformClick()
                e.Handled = True
            Case ")"c
                btnCloseBracket.PerformClick()
                e.Handled = True
            Case "%"c
                btnPercent.PerformClick()
                e.Handled = True
            Case "^"c
                btnPower.PerformClick()
                e.Handled = True
            Case "!"c
                btnFactorial.PerformClick()
                e.Handled = True

            ' Scientific function letter shortcuts:
            Case "s"c, "S"c
                btnSin.PerformClick()
                e.Handled = True
            Case "c"c, "C"c
                btnCos.PerformClick()
                e.Handled = True
            Case "t"c, "T"c
                btnTan.PerformClick()
                e.Handled = True
            Case "l"c, "L"c
                btnLog.PerformClick()
                e.Handled = True
            Case "n"c, "N"c
                btnLn.PerformClick()
                e.Handled = True
            Case "r"c, "R"c
                btnSqrt.PerformClick()
                e.Handled = True
            Case "p"c, "P"c
                btnPi.PerformClick()
                e.Handled = True
            Case "e"c, "E"c
                btnE.PerformClick()
                e.Handled = True
        End Select
    End Sub

#End Region

#Region "Calculation History"

    ''' <summary>
    ''' Represents a single calculation record in history.
    ''' </summary>
    Public Class CalculationHistoryItem
        Public Property Expression As String
        Public Property Result As String

        Public Sub New(expr As String, res As String)
            Expression = expr
            Result = res
        End Sub

        Public Overrides Function ToString() As String
            Return $"{Expression} = {Result}"
        End Function
    End Class

    ''' <summary>
    ''' Toggles the collapsible history drawer.
    ''' </summary>
    Private Sub HistoryButton_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        pnlHistory.Visible = Not pnlHistory.Visible
        If pnlHistory.Visible Then
            ClientSize = New Size(540 + pnlHistory.Width, ClientSize.Height)
            btnHistory.BackColor = Color.FromArgb(230, 240, 255)
            btnHistory.ForeColor = Color.FromArgb(0, 120, 215)
        Else
            ClientSize = New Size(540, ClientSize.Height)
            btnHistory.BackColor = Color.White
            btnHistory.ForeColor = Color.FromArgb(90, 90, 90)
        End If
    End Sub

    ''' <summary>
    ''' Clears all calculation history entries.
    ''' </summary>
    Private Sub ClearHistoryButton_Click(sender As Object, e As EventArgs) Handles btnClearHistory.Click
        lstHistory.Items.Clear()
    End Sub

    ''' <summary>
    ''' Re-inserts the clicked past calculation result into the calculator input.
    ''' </summary>
    Private Sub HistoryList_Click(sender As Object, e As EventArgs) Handles lstHistory.Click
        Dim selectedItem As CalculationHistoryItem = TryCast(lstHistory.SelectedItem, CalculationHistoryItem)
        If selectedItem IsNot Nothing Then
            Dim selectedResult As String = selectedItem.Result

            If isResultDisplayed OrElse IsErrorState() OrElse txtResult.Text = "0" Then
                ResetDisplayForNewInput(selectedResult)
            Else
                Dim currentText As String = txtResult.Text
                Dim lastChar As Char = currentText(currentText.Length - 1)

                If IsOperator(lastChar) OrElse lastChar = "("c Then
                    txtResult.AppendText(selectedResult)
                Else
                    txtResult.AppendText("×" & selectedResult)
                End If
            End If
            txtExpression.Text = selectedItem.Expression & " ="
        End If
    End Sub

    ''' <summary>
    ''' Custom owner-draw rendering for modern, readable two-line history items (Expression + Result).
    ''' </summary>
    Private Sub HistoryList_DrawItem(sender As Object, e As DrawItemEventArgs) Handles lstHistory.DrawItem
        If e.Index < 0 OrElse e.Index >= lstHistory.Items.Count Then Return

        Dim item As CalculationHistoryItem = TryCast(lstHistory.Items(e.Index), CalculationHistoryItem)
        If item Is Nothing Then Return

        Dim isSelected As Boolean = (e.State And DrawItemState.Selected) = DrawItemState.Selected
        Dim backBrush As Brush = If(isSelected, New SolidBrush(Color.FromArgb(230, 240, 255)), New SolidBrush(Color.White))
        e.Graphics.FillRectangle(backBrush, e.Bounds)

        ' Draw subtle bottom border line between items
        Using penLine As New Pen(Color.FromArgb(240, 240, 240))
            e.Graphics.DrawLine(penLine, e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1)
        End Using

        ' Top line: expression in gray
        Using exprFont As New Font("Segoe UI", 8.5F, FontStyle.Regular),
              exprBrush As New SolidBrush(Color.FromArgb(120, 120, 120))
            Dim exprRect As New Rectangle(e.Bounds.Left + 8, e.Bounds.Top + 4, e.Bounds.Width - 16, 16)
            Dim sf As New StringFormat() With {.Alignment = StringAlignment.Far}
            e.Graphics.DrawString(item.Expression & " =", exprFont, exprBrush, exprRect, sf)
        End Using

        ' Bottom line: result in bold black
        Using resFont As New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold),
              resBrush As New SolidBrush(If(isSelected, Color.FromArgb(0, 120, 215), Color.Black))
            Dim resRect As New Rectangle(e.Bounds.Left + 8, e.Bounds.Top + 20, e.Bounds.Width - 16, 22)
            Dim sf As New StringFormat() With {.Alignment = StringAlignment.Far}
            e.Graphics.DrawString(item.Result, resFont, resBrush, resRect, sf)
        End Using

        backBrush.Dispose()
    End Sub

    Private Sub HistoryList_MeasureItem(sender As Object, e As MeasureItemEventArgs) Handles lstHistory.MeasureItem
        e.ItemHeight = 46
    End Sub

    Private Sub AddHistoryItem(expression As String, result As String)
        Dim item As New CalculationHistoryItem(expression, result)
        lstHistory.Items.Insert(0, item)
    End Sub

#End Region

#Region "Memory Registers (MC, MR, M+, M-)"

    Private Function GetCurrentNumericValue() As Double
        If String.IsNullOrEmpty(txtResult.Text) OrElse IsErrorState() Then
            Return 0.0
        End If

        Dim val As Double
        If Double.TryParse(txtResult.Text, NumberStyles.Float, CultureInfo.InvariantCulture, val) Then
            Return val
        End If

        Try
            Dim cleanExpr As String = txtResult.Text.Replace("×", "*").Replace("÷", "/").Replace("−", "-")
            Return ScientificExpressionEvaluator.Evaluate(cleanExpr, currentAngleMode)
        Catch
            Return 0.0
        End Try
    End Function

    Private Sub UpdateMemoryUi()
        If hasMemoryValue Then
            btnMC.Enabled = True
            btnMR.Enabled = True
            btnMC.ForeColor = Color.FromArgb(0, 120, 215)
            btnMR.ForeColor = Color.FromArgb(0, 120, 215)
            lblMemoryStatus.Text = $"M = {FormatResult(memoryValue)}"
        Else
            btnMC.Enabled = False
            btnMR.Enabled = False
            btnMC.ForeColor = Color.FromArgb(120, 120, 120)
            btnMR.ForeColor = Color.FromArgb(120, 120, 120)
            lblMemoryStatus.Text = ""
        End If
    End Sub

    Private Sub MC_Click(sender As Object, e As EventArgs) Handles btnMC.Click
        memoryValue = 0.0
        hasMemoryValue = False
        UpdateMemoryUi()
    End Sub

    Private Sub MR_Click(sender As Object, e As EventArgs) Handles btnMR.Click
        If hasMemoryValue Then
            Dim formatted As String = FormatResult(memoryValue)
            If isResultDisplayed OrElse IsErrorState() OrElse txtResult.Text = "0" Then
                ResetDisplayForNewInput(formatted)
            Else
                Dim currentText As String = txtResult.Text
                Dim lastChar As Char = currentText(currentText.Length - 1)
                If IsOperator(lastChar) OrElse lastChar = "("c Then
                    txtResult.AppendText(formatted)
                Else
                    txtResult.AppendText("×" & formatted)
                End If
            End If
        End If
    End Sub

    Private Sub MPlus_Click(sender As Object, e As EventArgs) Handles btnMPlus.Click
        Dim currentVal As Double = GetCurrentNumericValue()
        memoryValue += currentVal
        hasMemoryValue = True
        isResultDisplayed = True
        UpdateMemoryUi()
    End Sub

    Private Sub MMinus_Click(sender As Object, e As EventArgs) Handles btnMMinus.Click
        Dim currentVal As Double = GetCurrentNumericValue()
        memoryValue -= currentVal
        hasMemoryValue = True
        isResultDisplayed = True
        UpdateMemoryUi()
    End Sub

#End Region

End Class
