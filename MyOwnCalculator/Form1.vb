''' <summary>
''' Represents the main interface for the calculator application.
''' </summary>
Public Class Form1

#Region "Event Handlers"

    ''' <summary>
    ''' Handles the click event for numeric buttons (1-9).
    ''' </summary>
    Private Sub NumericButton_Click(sender As Object, e As EventArgs) Handles _
        btnOne.Click, btnTwo.Click, btnThree.Click, btnFour.Click, btnFive.Click,
        btnSix.Click, btnSeven.Click, btnEight.Click, btnNine.Click

        Dim btn As Button = TryCast(sender, Button)
        If btn IsNot Nothing Then
            ' Replace initial zero
            If txtDisplay.Text = "0" Then
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
        ' Avoid leading zeros unless it's a decimal
        If txtDisplay.Text <> "0" Then
            txtDisplay.AppendText("0")
        End If
    End Sub

    ''' <summary>
    ''' Handles the click event for the decimal point button.
    ''' </summary>
    Private Sub DecimalButton_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        If String.IsNullOrEmpty(txtDisplay.Text) OrElse txtDisplay.Text = "0" Then
            txtDisplay.Text = "0."
        ElseIf Not txtDisplay.Text.Contains(".") Then
            txtDisplay.AppendText(".")
        End If
    End Sub

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
        If txtDisplay.Text.Length > 0 AndAlso txtDisplay.Text <> "0" Then
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1)
        End If

        ' If the display becomes empty or was just an error, reset to "0"
        If String.IsNullOrEmpty(txtDisplay.Text) OrElse txtDisplay.Text = "Error" Then
            txtDisplay.Text = "0"
        End If
    End Sub

    ''' <summary>
    ''' Handles the click event for operator buttons (+, -, *, /).
    ''' </summary>
    Private Sub OperatorButton_Click(sender As Object, e As EventArgs) Handles _
        btnPlus.Click, btnMinus.Click, btnMultiply.Click, btnDivide.Click

        Dim btn As Button = TryCast(sender, Button)
        If btn IsNot Nothing AndAlso Not String.IsNullOrEmpty(txtDisplay.Text) Then
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
    ''' Handles the click event for the equals button to evaluate the expression.
    ''' </summary>
    Private Sub EqualsButton_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        If String.IsNullOrEmpty(txtDisplay.Text) OrElse txtDisplay.Text = "0.00" Then Return

        Try
            Dim expression As String = txtDisplay.Text
            Using table As New DataTable()
                Dim result As Object = table.Compute(expression, String.Empty)
                txtDisplay.Text = result.ToString()
            End Using
        Catch ex As Exception
            txtDisplay.Text = "Error"
        End Try
    End Sub


#End Region

#Region "Helper Methods"

    ''' <summary>
    ''' Determines if a character is a mathematical operator.
    ''' </summary>
    ''' <param name="c">The character to check.</param>
    ''' <returns>True if the character is an operator; otherwise, false.</returns>
    Private Function IsOperator(c As Char) As Boolean
        Return "+-*/".Contains(c)
    End Function

#End Region

End Class
