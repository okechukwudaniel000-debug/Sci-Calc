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
        pnlDisplay.BackColor = Color.FromArgb(24, 25, 28)
        pnlDisplay.Controls.Add(lblMode)
        pnlDisplay.Controls.Add(txtExpression)
        pnlDisplay.Controls.Add(txtResult)
        pnlDisplay.Dock = DockStyle.Top
        pnlDisplay.Location = New Point(0, 0)
        pnlDisplay.Name = "pnlDisplay"
        pnlDisplay.Padding = New Padding(20, 12, 20, 10)
        pnlDisplay.Size = New Size(420, 140)
        pnlDisplay.TabIndex = 0

        '
        ' lblMode
        '
        lblMode.AutoSize = True
        lblMode.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblMode.ForeColor = Color.FromArgb(255, 159, 10)
        lblMode.Location = New Point(20, 10)
        lblMode.Name = "lblMode"
        lblMode.Size = New Size(42, 21)
        lblMode.TabIndex = 0
        lblMode.Text = "DEG"

        '
        ' txtExpression
        '
        txtExpression.BackColor = Color.FromArgb(24, 25, 28)
        txtExpression.BorderStyle = BorderStyle.None
        txtExpression.Font = New Font("Segoe UI", 13.0F, FontStyle.Regular)
        txtExpression.ForeColor = Color.FromArgb(160, 165, 175)
        txtExpression.Location = New Point(20, 36)
        txtExpression.Name = "txtExpression"
        txtExpression.ReadOnly = True
        txtExpression.Size = New Size(380, 29)
        txtExpression.TabIndex = 1
        txtExpression.TextAlign = HorizontalAlignment.Right

        '
        ' txtResult
        '
        txtResult.BackColor = Color.FromArgb(24, 25, 28)
        txtResult.BorderStyle = BorderStyle.None
        txtResult.Font = New Font("Segoe UI Semibold", 26.0F, FontStyle.Bold)
        txtResult.ForeColor = Color.White
        txtResult.Location = New Point(20, 70)
        txtResult.Name = "txtResult"
        txtResult.ReadOnly = True
        txtResult.Size = New Size(380, 58)
        txtResult.TabIndex = 2
        txtResult.Text = "0"
        txtResult.TextAlign = HorizontalAlignment.Right

        '
        ' pnlKeypad
        '
        pnlKeypad.BackColor = Color.FromArgb(30, 31, 34)
        pnlKeypad.ColumnCount = 5
        pnlKeypad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        pnlKeypad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        pnlKeypad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        pnlKeypad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        pnlKeypad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        pnlKeypad.Dock = DockStyle.Fill
        pnlKeypad.Location = New Point(0, 140)
        pnlKeypad.Name = "pnlKeypad"
        pnlKeypad.Padding = New Padding(10, 8, 10, 12)
        pnlKeypad.RowCount = 8
        pnlKeypad.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        pnlKeypad.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        pnlKeypad.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        pnlKeypad.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        pnlKeypad.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        pnlKeypad.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        pnlKeypad.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        pnlKeypad.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        pnlKeypad.Size = New Size(420, 510)
        pnlKeypad.TabIndex = 1

        ' Button Styling
        ' Scientific functions: Sleek charcoal background
        ConfigureButton(btnDegRad, "DEG", Color.FromArgb(44, 46, 51), Color.FromArgb(255, 159, 10), 10.0F, True)
        ConfigureButton(btnSquare, "x²", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 13.0F)
        ConfigureButton(btnPower, "xʸ", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 13.0F)
        ConfigureButton(btnPi, "π", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 14.0F)
        ConfigureButton(btnDelete, "⌫", Color.FromArgb(50, 52, 58), Color.FromArgb(255, 130, 130), 14.0F, True)

        ConfigureButton(btnExp, "eˣ", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 13.0F)
        ConfigureButton(btnReciprocal, "1/x", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 11.5F)
        ConfigureButton(btnSin, "sin", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 12.5F)
        ConfigureButton(btnCos, "cos", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 12.5F)
        ConfigureButton(btnTan, "tan", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 12.5F)

        ConfigureButton(btnSqrt, "√", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 13.5F)
        ConfigureButton(btnLog, "log", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 12.5F)
        ConfigureButton(btnLn, "ln", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 12.5F)
        ConfigureButton(btnOpenBracket, "(", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 14.0F)
        ConfigureButton(btnCloseBracket, ")", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 14.0F)

        ' Row 3: AC, %, n!, ÷, ×
        ConfigureButton(btnClear, "AC", Color.FromArgb(255, 179, 0), Color.FromArgb(20, 20, 20), 14.0F, True)
        ConfigureButton(btnPercent, "%", Color.FromArgb(50, 52, 58), Color.FromArgb(235, 240, 250), 13.5F)
        ConfigureButton(btnFactorial, "n!", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 12.5F)
        ConfigureButton(btnDivide, "÷", Color.FromArgb(58, 62, 70), Color.FromArgb(255, 179, 0), 18.0F, True)
        ConfigureButton(btnMultiply, "×", Color.FromArgb(58, 62, 70), Color.FromArgb(255, 179, 0), 18.0F, True)

        ' Row 4: 7, 8, 9, −, e
        ConfigureButton(btnSeven, "7", Color.FromArgb(60, 64, 72), Color.White, 16.0F)
        ConfigureButton(btnEight, "8", Color.FromArgb(60, 64, 72), Color.White, 16.0F)
        ConfigureButton(btnNine, "9", Color.FromArgb(60, 64, 72), Color.White, 16.0F)
        ConfigureButton(btnMinus, "−", Color.FromArgb(58, 62, 70), Color.FromArgb(255, 179, 0), 18.0F, True)
        ConfigureButton(btnE, "e", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 13.5F)

        ' Row 5: 4, 5, 6, +, x³
        ConfigureButton(btnFour, "4", Color.FromArgb(60, 64, 72), Color.White, 16.0F)
        ConfigureButton(btnFive, "5", Color.FromArgb(60, 64, 72), Color.White, 16.0F)
        ConfigureButton(btnSix, "6", Color.FromArgb(60, 64, 72), Color.White, 16.0F)
        ConfigureButton(btnPlus, "+", Color.FromArgb(58, 62, 70), Color.FromArgb(255, 179, 0), 18.0F, True)
        ConfigureButton(btnCube, "x³", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 13.0F)

        ' Row 6: 1, 2, 3, = (row span 2)
        ConfigureButton(btnOne, "1", Color.FromArgb(60, 64, 72), Color.White, 16.0F)
        ConfigureButton(btnTwo, "2", Color.FromArgb(60, 64, 72), Color.White, 16.0F)
        ConfigureButton(btnThree, "3", Color.FromArgb(60, 64, 72), Color.White, 16.0F)
        ConfigureButton(btnEquals, "=", Color.FromArgb(255, 179, 0), Color.FromArgb(20, 20, 20), 22.0F, True)

        ' Row 7: 0 (col span 2), .
        ConfigureButton(btnZero, "0", Color.FromArgb(60, 64, 72), Color.White, 16.0F)
        ConfigureButton(btnDecimal, ".", Color.FromArgb(60, 64, 72), Color.White, 18.0F, True)

        ' Add to TableLayoutPanel Grid
        ' Row 0: Scientific Row 1
        pnlKeypad.Controls.Add(btnDegRad, 0, 0)
        pnlKeypad.Controls.Add(btnSquare, 1, 0)
        pnlKeypad.Controls.Add(btnPower, 2, 0)
        pnlKeypad.Controls.Add(btnPi, 3, 0)
        pnlKeypad.Controls.Add(btnDelete, 4, 0)

        ' Row 1: Scientific Row 2
        pnlKeypad.Controls.Add(btnExp, 0, 1)
        pnlKeypad.Controls.Add(btnReciprocal, 1, 1)
        pnlKeypad.Controls.Add(btnSin, 2, 1)
        pnlKeypad.Controls.Add(btnCos, 3, 1)
        pnlKeypad.Controls.Add(btnTan, 4, 1)

        ' Row 2: Scientific Row 3
        pnlKeypad.Controls.Add(btnSqrt, 0, 2)
        pnlKeypad.Controls.Add(btnLog, 1, 2)
        pnlKeypad.Controls.Add(btnLn, 2, 2)
        pnlKeypad.Controls.Add(btnOpenBracket, 3, 2)
        pnlKeypad.Controls.Add(btnCloseBracket, 4, 2)

        ' Row 3: AC, %, n!, ÷, ×
        pnlKeypad.Controls.Add(btnClear, 0, 3)
        pnlKeypad.Controls.Add(btnPercent, 1, 3)
        pnlKeypad.Controls.Add(btnFactorial, 2, 3)
        pnlKeypad.Controls.Add(btnDivide, 3, 3)
        pnlKeypad.Controls.Add(btnMultiply, 4, 3)

        ' Row 4: 7, 8, 9, −, e
        pnlKeypad.Controls.Add(btnSeven, 0, 4)
        pnlKeypad.Controls.Add(btnEight, 1, 4)
        pnlKeypad.Controls.Add(btnNine, 2, 4)
        pnlKeypad.Controls.Add(btnMinus, 3, 4)
        pnlKeypad.Controls.Add(btnE, 4, 4)

        ' Row 5: 4, 5, 6, +, x³
        pnlKeypad.Controls.Add(btnFour, 0, 5)
        pnlKeypad.Controls.Add(btnFive, 1, 5)
        pnlKeypad.Controls.Add(btnSix, 2, 5)
        pnlKeypad.Controls.Add(btnPlus, 3, 5)
        pnlKeypad.Controls.Add(btnCube, 4, 5)

        ' Row 6: 1, 2, 3, = (spans rows 6 and 7, cols 3 and 4 or col 4)
        ' Let's place: 1 at (0,6), 2 at (1,6), 3 at (2,6)
        ' Equals at (3,6) with ColSpan=2 and RowSpan=2!
        pnlKeypad.Controls.Add(btnOne, 0, 6)
        pnlKeypad.Controls.Add(btnTwo, 1, 6)
        pnlKeypad.Controls.Add(btnThree, 2, 6)
        pnlKeypad.Controls.Add(btnEquals, 3, 6)
        pnlKeypad.SetColumnSpan(btnEquals, 2)
        pnlKeypad.SetRowSpan(btnEquals, 2)

        ' Row 7: 0 (cols 0 & 1, colSpan 2), . at col 2
        pnlKeypad.Controls.Add(btnZero, 0, 7)
        pnlKeypad.SetColumnSpan(btnZero, 2)
        pnlKeypad.Controls.Add(btnDecimal, 2, 7)

        '
        ' Form1
        '
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(30, 31, 34)
        ClientSize = New Size(420, 650)
        Controls.Add(pnlKeypad)
        Controls.Add(pnlDisplay)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Scientific Calculator"
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
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand
        Dim style As FontStyle = If(isBold, FontStyle.Bold, FontStyle.Regular)
        btn.Font = New Font("Segoe UI", fontSize, style)
        btn.UseVisualStyleBackColor = False
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
