<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        pnlDisplay = New Panel()
        lblMode = New Label()
        txtExpression = New TextBox()
        txtResult = New TextBox()
        pnlKeypad = New TableLayoutPanel()

        btnDegRad = New Button()
        btnSquare = New Button()
        btnPower = New Button()
        btnPi = New Button()
        btnDelete = New Button()

        btnExp = New Button()
        btnReciprocal = New Button()
        btnSin = New Button()
        btnCos = New Button()
        btnTan = New Button()

        btnSqrt = New Button()
        btnLog = New Button()
        btnLn = New Button()
        btnOpenBracket = New Button()
        btnCloseBracket = New Button()

        btnClear = New Button()
        btnPercent = New Button()
        btnFactorial = New Button()
        btnDivide = New Button()
        btnMultiply = New Button()

        btnSeven = New Button()
        btnEight = New Button()
        btnNine = New Button()
        btnMinus = New Button()
        btnE = New Button()

        btnFour = New Button()
        btnFive = New Button()
        btnSix = New Button()
        btnPlus = New Button()
        btnCube = New Button()

        btnOne = New Button()
        btnTwo = New Button()
        btnThree = New Button()
        btnEquals = New Button()

        btnZero = New Button()
        btnDecimal = New Button()

        pnlDisplay.SuspendLayout()
        SuspendLayout()

        '
        ' pnlDisplay
        '
        pnlDisplay.BackColor = Color.White
        pnlDisplay.Controls.Add(lblMode)
        pnlDisplay.Controls.Add(txtExpression)
        pnlDisplay.Controls.Add(txtResult)
        pnlDisplay.Dock = DockStyle.Top
        pnlDisplay.Location = New Point(0, 0)
        pnlDisplay.Name = "pnlDisplay"
        pnlDisplay.Padding = New Padding(12, 10, 12, 8)
        pnlDisplay.Size = New Size(540, 95)
        pnlDisplay.TabIndex = 0

        '
        ' lblMode
        '
        lblMode.AutoSize = True
        lblMode.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblMode.ForeColor = Color.FromArgb(100, 100, 100)
        lblMode.Location = New Point(12, 8)
        lblMode.Name = "lblMode"
        lblMode.Size = New Size(38, 20)
        lblMode.TabIndex = 0
        lblMode.Text = "DEG"

        '
        ' txtExpression
        '
        txtExpression.BackColor = Color.White
        txtExpression.BorderStyle = BorderStyle.None
        txtExpression.Font = New Font("Segoe UI", 10.5F, FontStyle.Regular)
        txtExpression.ForeColor = Color.FromArgb(120, 120, 120)
        txtExpression.Location = New Point(60, 8)
        txtExpression.Name = "txtExpression"
        txtExpression.ReadOnly = True
        txtExpression.Size = New Size(465, 24)
        txtExpression.TabIndex = 1
        txtExpression.TextAlign = HorizontalAlignment.Right

        '
        ' txtResult
        '
        txtResult.BackColor = Color.White
        txtResult.BorderStyle = BorderStyle.FixedSingle
        txtResult.Font = New Font("Segoe UI Semibold", 20.0F, FontStyle.Bold)
        txtResult.ForeColor = Color.Black
        txtResult.Location = New Point(12, 34)
        txtResult.Name = "txtResult"
        txtResult.ReadOnly = True
        txtResult.Size = New Size(516, 52)
        txtResult.TabIndex = 2
        txtResult.Text = "0"
        txtResult.TextAlign = HorizontalAlignment.Right

        '
        ' pnlKeypad
        '
        pnlKeypad.BackColor = Color.FromArgb(242, 243, 245)
        pnlKeypad.ColumnCount = 8
        pnlKeypad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        pnlKeypad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        pnlKeypad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        pnlKeypad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        pnlKeypad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        pnlKeypad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        pnlKeypad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        pnlKeypad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        pnlKeypad.Dock = DockStyle.Fill
        pnlKeypad.Location = New Point(0, 95)
        pnlKeypad.Name = "pnlKeypad"
        pnlKeypad.Padding = New Padding(10, 8, 10, 10)
        pnlKeypad.RowCount = 5
        pnlKeypad.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        pnlKeypad.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        pnlKeypad.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        pnlKeypad.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        pnlKeypad.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        pnlKeypad.Size = New Size(540, 385)
        pnlKeypad.TabIndex = 1

        ' Button Styling matching the reference clean light Windows desktop style
        Dim btnWhite As Color = Color.White
        Dim btnTextDark As Color = Color.FromArgb(10, 10, 10)

        ' Left Numeric / Standard Pad:
        ' Row 0: ⌫, CE, C, ±
        ConfigureButton(btnDelete, "⌫", btnWhite, btnTextDark, 12.0F, True)
        ConfigureButton(btnOpenBracket, "(", btnWhite, btnTextDark, 12.0F, True)
        ConfigureButton(btnClear, "C", btnWhite, btnTextDark, 12.0F, True)
        ConfigureButton(btnCloseBracket, ")", btnWhite, btnTextDark, 12.0F, True)

        ' Row 1: 7, 8, 9, +
        ConfigureButton(btnSeven, "7", btnWhite, btnTextDark, 13.0F, True)
        ConfigureButton(btnEight, "8", btnWhite, btnTextDark, 13.0F, True)
        ConfigureButton(btnNine, "9", btnWhite, btnTextDark, 13.0F, True)
        ConfigureButton(btnPlus, "+", btnWhite, btnTextDark, 13.0F, True)

        ' Row 2: 4, 5, 6, -
        ConfigureButton(btnFour, "4", btnWhite, btnTextDark, 13.0F, True)
        ConfigureButton(btnFive, "5", btnWhite, btnTextDark, 13.0F, True)
        ConfigureButton(btnSix, "6", btnWhite, btnTextDark, 13.0F, True)
        ConfigureButton(btnMinus, "-", btnWhite, btnTextDark, 14.0F, True)

        ' Row 3: 1, 2, 3, *
        ConfigureButton(btnOne, "1", btnWhite, btnTextDark, 13.0F, True)
        ConfigureButton(btnTwo, "2", btnWhite, btnTextDark, 13.0F, True)
        ConfigureButton(btnThree, "3", btnWhite, btnTextDark, 13.0F, True)
        ConfigureButton(btnMultiply, "*", btnWhite, btnTextDark, 13.0F, True)

        ' Row 4: 0, ., =, /
        ConfigureButton(btnZero, "0", btnWhite, btnTextDark, 13.0F, True)
        ConfigureButton(btnDecimal, ".", btnWhite, btnTextDark, 14.0F, True)
        ConfigureButton(btnEquals, "=", btnWhite, btnTextDark, 13.0F, True)
        ConfigureButton(btnDivide, "/", btnWhite, btnTextDark, 13.0F, True)

        ' Right Scientific Pad:
        ' Row 0: π, Log, Sqrt, x²
        ConfigureButton(btnPi, "π", btnWhite, btnTextDark, 12.0F, True)
        ConfigureButton(btnLog, "Log", btnWhite, btnTextDark, 11.5F, True)
        ConfigureButton(btnSqrt, "Sqrt", btnWhite, btnTextDark, 11.5F, True)
        ConfigureButton(btnSquare, "x²", btnWhite, btnTextDark, 11.5F, True)

        ' Row 1: DEG/RAD (Sinh pos), Sin, xʸ (Dec pos), x³
        ConfigureButton(btnDegRad, "DEG", btnWhite, btnTextDark, 11.0F, True)
        ConfigureButton(btnSin, "Sin", btnWhite, btnTextDark, 11.5F, True)
        ConfigureButton(btnPower, "xʸ", btnWhite, btnTextDark, 11.5F, True)
        ConfigureButton(btnCube, "x³", btnWhite, btnTextDark, 11.5F, True)

        ' Row 2: n! (Cosh pos), Cos, e (Bin pos), 1/x
        ConfigureButton(btnFactorial, "n!", btnWhite, btnTextDark, 11.5F, True)
        ConfigureButton(btnCos, "Cos", btnWhite, btnTextDark, 11.5F, True)
        ConfigureButton(btnE, "e", btnWhite, btnTextDark, 12.0F, True)
        ConfigureButton(btnReciprocal, "1/x", btnWhite, btnTextDark, 11.0F, True)

        ' Row 3: (Tanh pos empty / unused spacer?), Tan, (Hex pos), ln x
        ' We can place Tan at Col 5, btnLn at Col 7. For Col 4 and Col 6:
        ' We will place btnLn at Col 7.
        ConfigureButton(btnTan, "Tan", btnWhite, btnTextDark, 11.5F, True)
        ConfigureButton(btnLn, "ln x", btnWhite, btnTextDark, 11.0F, True)

        ' Row 4: Exp, Mod (or secondary), (Oct pos), %
        ConfigureButton(btnExp, "Exp", btnWhite, btnTextDark, 11.5F, True)
        ConfigureButton(btnPercent, "%", btnWhite, btnTextDark, 12.0F, True)

        ' Add to TableLayoutPanel Grid (8 columns x 5 rows)
        ' Row 0
        pnlKeypad.Controls.Add(btnDelete, 0, 0)
        pnlKeypad.Controls.Add(btnOpenBracket, 1, 0)
        pnlKeypad.Controls.Add(btnClear, 2, 0)
        pnlKeypad.Controls.Add(btnCloseBracket, 3, 0)
        pnlKeypad.Controls.Add(btnPi, 4, 0)
        pnlKeypad.Controls.Add(btnLog, 5, 0)
        pnlKeypad.Controls.Add(btnSqrt, 6, 0)
        pnlKeypad.Controls.Add(btnSquare, 7, 0)

        ' Row 1
        pnlKeypad.Controls.Add(btnSeven, 0, 1)
        pnlKeypad.Controls.Add(btnEight, 1, 1)
        pnlKeypad.Controls.Add(btnNine, 2, 1)
        pnlKeypad.Controls.Add(btnPlus, 3, 1)
        pnlKeypad.Controls.Add(btnDegRad, 4, 1)
        pnlKeypad.Controls.Add(btnSin, 5, 1)
        pnlKeypad.Controls.Add(btnPower, 6, 1)
        pnlKeypad.Controls.Add(btnCube, 7, 1)

        ' Row 2
        pnlKeypad.Controls.Add(btnFour, 0, 2)
        pnlKeypad.Controls.Add(btnFive, 1, 2)
        pnlKeypad.Controls.Add(btnSix, 2, 2)
        pnlKeypad.Controls.Add(btnMinus, 3, 2)
        pnlKeypad.Controls.Add(btnFactorial, 4, 2)
        pnlKeypad.Controls.Add(btnCos, 5, 2)
        pnlKeypad.Controls.Add(btnE, 6, 2)
        pnlKeypad.Controls.Add(btnReciprocal, 7, 2)

        ' Row 3
        pnlKeypad.Controls.Add(btnOne, 0, 3)
        pnlKeypad.Controls.Add(btnTwo, 1, 3)
        pnlKeypad.Controls.Add(btnThree, 2, 3)
        pnlKeypad.Controls.Add(btnMultiply, 3, 3)
        pnlKeypad.Controls.Add(btnTan, 5, 3)
        pnlKeypad.Controls.Add(btnLn, 7, 3)

        ' Row 4
        pnlKeypad.Controls.Add(btnZero, 0, 4)
        pnlKeypad.Controls.Add(btnDecimal, 1, 4)
        pnlKeypad.Controls.Add(btnEquals, 2, 4)
        pnlKeypad.Controls.Add(btnDivide, 3, 4)
        pnlKeypad.Controls.Add(btnExp, 4, 4)
        pnlKeypad.Controls.Add(btnPercent, 7, 4)

        '
        ' Form1
        '
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(242, 243, 245)
        ClientSize = New Size(540, 480)
        Controls.Add(pnlKeypad)
        Controls.Add(pnlDisplay)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        pnlDisplay.ResumeLayout(False)
        pnlDisplay.PerformLayout()
        ResumeLayout(False)
    End Sub

    Private Sub ConfigureButton(btn As Button, text As String, backColor As Color, foreColor As Color, fontSize As Single, Optional isBold As Boolean = False)
        btn.Dock = DockStyle.Fill
        btn.Margin = New Padding(3)
        btn.Text = text
        btn.BackColor = backColor
        btn.ForeColor = foreColor
        btn.FlatStyle = FlatStyle.Standard
        btn.Cursor = Cursors.Default
        Dim style As FontStyle = If(isBold, FontStyle.Bold, FontStyle.Regular)
        btn.Font = New Font("Segoe UI", fontSize, style)
        btn.UseVisualStyleBackColor = True
    End Sub

    Friend WithEvents pnlDisplay As Panel
    Friend WithEvents lblMode As Label
    Friend WithEvents txtExpression As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents pnlKeypad As TableLayoutPanel

    Friend WithEvents btnDegRad As Button
    Friend WithEvents btnSquare As Button
    Friend WithEvents btnPower As Button
    Friend WithEvents btnPi As Button
    Friend WithEvents btnDelete As Button

    Friend WithEvents btnExp As Button
    Friend WithEvents btnReciprocal As Button
    Friend WithEvents btnSin As Button
    Friend WithEvents btnCos As Button
    Friend WithEvents btnTan As Button

    Friend WithEvents btnSqrt As Button
    Friend WithEvents btnLog As Button
    Friend WithEvents btnLn As Button
    Friend WithEvents btnOpenBracket As Button
    Friend WithEvents btnCloseBracket As Button

    Friend WithEvents btnClear As Button
    Friend WithEvents btnPercent As Button
    Friend WithEvents btnFactorial As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnMultiply As Button

    Friend WithEvents btnSeven As Button
    Friend WithEvents btnEight As Button
    Friend WithEvents btnNine As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnE As Button

    Friend WithEvents btnFour As Button
    Friend WithEvents btnFive As Button
    Friend WithEvents btnSix As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnCube As Button

    Friend WithEvents btnOne As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnThree As Button

    Friend WithEvents btnZero As Button
    Friend WithEvents btnDecimal As Button
    Friend WithEvents btnEquals As Button

End Class
