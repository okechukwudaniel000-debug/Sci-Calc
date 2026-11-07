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
        
        btnCube = New Button()
        btnReciprocal = New Button()
        btnSin = New Button()
        btnCos = New Button()
        btnTan = New Button()
        
        btnExp = New Button()
        btnSqrt = New Button()
        btnAsin = New Button()
        btnAcos = New Button()
        btnAtan = New Button()
        
        btnLog = New Button()
        btnLn = New Button()
        btnOpenBracket = New Button()
        btnCloseBracket = New Button()
        btnFactorial = New Button()
        
        btnClear = New Button()
        btnPercent = New Button()
        btnDivide = New Button()
        btnMultiply = New Button()
        btnMinus = New Button()
        
        btnSeven = New Button()
        btnEight = New Button()
        btnNine = New Button()
        btnPlus = New Button()
        
        btnFour = New Button()
        btnFive = New Button()
        btnSix = New Button()
        
        btnOne = New Button()
        btnTwo = New Button()
        btnThree = New Button()
        btnEquals = New Button()
        
        btnZero = New Button()
        btnDecimal = New Button()
        btnE = New Button()

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
        pnlDisplay.Padding = New Padding(24, 16, 24, 12)
        pnlDisplay.Size = New Size(420, 150)
        pnlDisplay.TabIndex = 0

        '
        ' lblMode
        '
        lblMode.AutoSize = True
        lblMode.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblMode.ForeColor = Color.FromArgb(255, 159, 10)
        lblMode.Location = New Point(24, 14)
        lblMode.Name = "lblMode"
        lblMode.Size = New Size(44, 23)
        lblMode.TabIndex = 0
        lblMode.Text = "DEG"

        '
        ' txtExpression
        '
        txtExpression.BackColor = Color.FromArgb(24, 25, 28)
        txtExpression.BorderStyle = BorderStyle.None
        txtExpression.Font = New Font("Segoe UI", 15.0F, FontStyle.Regular)
        txtExpression.ForeColor = Color.FromArgb(160, 165, 175)
        txtExpression.Location = New Point(24, 42)
        txtExpression.Name = "txtExpression"
        txtExpression.ReadOnly = True
        txtExpression.Size = New Size(372, 34)
        txtExpression.TabIndex = 1
        txtExpression.TextAlign = HorizontalAlignment.Right

        '
        ' txtResult
        '
        txtResult.BackColor = Color.FromArgb(24, 25, 28)
        txtResult.BorderStyle = BorderStyle.None
        txtResult.Font = New Font("Segoe UI Semibold", 28.0F, FontStyle.Bold)
        txtResult.ForeColor = Color.White
        txtResult.Location = New Point(24, 78)
        txtResult.Name = "txtResult"
        txtResult.ReadOnly = True
        txtResult.Size = New Size(372, 62)
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
        pnlKeypad.Location = New Point(0, 150)
        pnlKeypad.Name = "pnlKeypad"
        pnlKeypad.Padding = New Padding(12, 10, 12, 16)
        pnlKeypad.RowCount = 8
        pnlKeypad.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        pnlKeypad.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        pnlKeypad.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        pnlKeypad.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        pnlKeypad.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        pnlKeypad.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        pnlKeypad.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        pnlKeypad.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        pnlKeypad.Size = New Size(420, 520)
        pnlKeypad.TabIndex = 1

        ' Configure Buttons
        ConfigureButton(btnDegRad, "DEG", Color.FromArgb(44, 46, 51), Color.FromArgb(255, 159, 10), 10.0F)
        ConfigureButton(btnSquare, "x²", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 13.0F)
        ConfigureButton(btnPower, "xʸ", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 13.0F)
        ConfigureButton(btnPi, "π", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 14.0F)
        ConfigureButton(btnDelete, "⌫", Color.FromArgb(50, 52, 58), Color.FromArgb(255, 140, 140), 14.0F)

        ConfigureButton(btnCube, "x³", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 13.0F)
        ConfigureButton(btnReciprocal, "1/x", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 11.5F)
        ConfigureButton(btnSin, "sin", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 12.5F)
        ConfigureButton(btnCos, "cos", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 12.5F)
        ConfigureButton(btnTan, "tan", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 12.5F)

        ConfigureButton(btnExp, "eˣ", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 13.0F)
        ConfigureButton(btnSqrt, "√x", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 13.0F)
        ConfigureButton(btnAsin, "sin⁻¹", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 11.0F)
        ConfigureButton(btnAcos, "cos⁻¹", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 11.0F)
        ConfigureButton(btnAtan, "tan⁻¹", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 11.0F)

        ConfigureButton(btnLog, "log", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 12.5F)
        ConfigureButton(btnLn, "ln", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 12.5F)
        ConfigureButton(btnOpenBracket, "(", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 14.0F)
        ConfigureButton(btnCloseBracket, ")", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 14.0F)
        ConfigureButton(btnFactorial, "n!", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 13.0F)

        ' Row 4 (Clear / Ops)
        ConfigureButton(btnClear, "AC", Color.FromArgb(255, 179, 0), Color.FromArgb(20, 20, 20), 14.0F, True)
        ConfigureButton(btnPercent, "%", Color.FromArgb(50, 52, 58), Color.FromArgb(235, 240, 250), 13.5F)
        ConfigureButton(btnDivide, "÷", Color.FromArgb(58, 62, 70), Color.FromArgb(255, 179, 0), 18.0F, True)
        ConfigureButton(btnMultiply, "×", Color.FromArgb(58, 62, 70), Color.FromArgb(255, 179, 0), 18.0F, True)
        ConfigureButton(btnMinus, "−", Color.FromArgb(58, 62, 70), Color.FromArgb(255, 179, 0), 18.0F, True)

        ' Digits & Ops
        ConfigureButton(btnSeven, "7", Color.FromArgb(60, 64, 72), Color.White, 16.0F)
        ConfigureButton(btnEight, "8", Color.FromArgb(60, 64, 72), Color.White, 16.0F)
        ConfigureButton(btnNine, "9", Color.FromArgb(60, 64, 72), Color.White, 16.0F)
        ConfigureButton(btnPlus, "+", Color.FromArgb(58, 62, 70), Color.FromArgb(255, 179, 0), 18.0F, True)

        ConfigureButton(btnFour, "4", Color.FromArgb(60, 64, 72), Color.White, 16.0F)
        ConfigureButton(btnFive, "5", Color.FromArgb(60, 64, 72), Color.White, 16.0F)
        ConfigureButton(btnSix, "6", Color.FromArgb(60, 64, 72), Color.White, 16.0F)

        ConfigureButton(btnOne, "1", Color.FromArgb(60, 64, 72), Color.White, 16.0F)
        ConfigureButton(btnTwo, "2", Color.FromArgb(60, 64, 72), Color.White, 16.0F)
        ConfigureButton(btnThree, "3", Color.FromArgb(60, 64, 72), Color.White, 16.0F)
        ConfigureButton(btnEquals, "=", Color.FromArgb(255, 179, 0), Color.FromArgb(20, 20, 20), 20.0F, True)

        ConfigureButton(btnZero, "0", Color.FromArgb(60, 64, 72), Color.White, 16.0F)
        ConfigureButton(btnDecimal, ".", Color.FromArgb(60, 64, 72), Color.White, 18.0F)
        ConfigureButton(btnE, "e", Color.FromArgb(44, 46, 51), Color.FromArgb(220, 225, 235), 14.0F)

        ' Row 0: Scientific Row 1
        pnlKeypad.Controls.Add(btnDegRad, 0, 0)
        pnlKeypad.Controls.Add(btnSquare, 1, 0)
        pnlKeypad.Controls.Add(btnPower, 2, 0)
        pnlKeypad.Controls.Add(btnPi, 3, 0)
        pnlKeypad.Controls.Add(btnDelete, 4, 0)

        ' Row 1: Scientific Row 2
        pnlKeypad.Controls.Add(btnCube, 0, 1)
        pnlKeypad.Controls.Add(btnReciprocal, 1, 1)
        pnlKeypad.Controls.Add(btnSin, 2, 1)
        pnlKeypad.Controls.Add(btnCos, 3, 1)
        pnlKeypad.Controls.Add(btnTan, 4, 1)

        ' Row 2: Scientific Row 3
        pnlKeypad.Controls.Add(btnExp, 0, 2)
        pnlKeypad.Controls.Add(btnSqrt, 1, 2)
        pnlKeypad.Controls.Add(btnAsin, 2, 2)
        pnlKeypad.Controls.Add(btnAcos, 3, 2)
        pnlKeypad.Controls.Add(btnAtan, 4, 2)

        ' Row 3: Scientific Row 4
        pnlKeypad.Controls.Add(btnLog, 0, 3)
        pnlKeypad.Controls.Add(btnLn, 1, 3)
        pnlKeypad.Controls.Add(btnOpenBracket, 2, 3)
        pnlKeypad.Controls.Add(btnCloseBracket, 3, 3)
        pnlKeypad.Controls.Add(btnFactorial, 4, 3)

        ' Row 4: AC, %, ÷, ×, −
        pnlKeypad.Controls.Add(btnClear, 0, 4)
        pnlKeypad.Controls.Add(btnPercent, 1, 4)
        pnlKeypad.Controls.Add(btnDivide, 2, 4)
        pnlKeypad.Controls.Add(btnMultiply, 3, 4)
        pnlKeypad.Controls.Add(btnMinus, 4, 4)

        ' Row 5: 7, 8, 9, + (spans 2 rows)
        pnlKeypad.Controls.Add(btnSeven, 0, 5)
        pnlKeypad.Controls.Add(btnEight, 1, 5)
        pnlKeypad.Controls.Add(btnNine, 2, 5)
        pnlKeypad.Controls.Add(btnPlus, 3, 5)
        pnlKeypad.SetRowSpan(btnPlus, 2)
        pnlKeypad.Controls.Add(btnEquals, 4, 5)
        pnlKeypad.SetRowSpan(btnEquals, 3)

        ' Row 6: 4, 5, 6
        pnlKeypad.Controls.Add(btnFour, 0, 6)
        pnlKeypad.Controls.Add(btnFive, 1, 6)
        pnlKeypad.Controls.Add(btnSix, 2, 6)

        ' Row 7: 1, 2, 3, 0 (or 1, 2, 3, ., 0)
        ' Let's place: 1, 2, 3, 0, .
        ' Actually: let row 7 be 1, 2, 3, 0, .
        pnlKeypad.Controls.Add(btnOne, 0, 7)
        pnlKeypad.Controls.Add(btnTwo, 1, 7)
        pnlKeypad.Controls.Add(btnThree, 2, 7)
        pnlKeypad.Controls.Add(btnZero, 3, 7)

        '
        ' Form1
        '
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(30, 31, 34)
        ClientSize = New Size(440, 680)
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

    Friend WithEvents btnCube As Button
    Friend WithEvents btnReciprocal As Button
    Friend WithEvents btnSin As Button
    Friend WithEvents btnCos As Button
    Friend WithEvents btnTan As Button

    Friend WithEvents btnExp As Button
    Friend WithEvents btnSqrt As Button
    Friend WithEvents btnAsin As Button
    Friend WithEvents btnAcos As Button
    Friend WithEvents btnAtan As Button

    Friend WithEvents btnLog As Button
    Friend WithEvents btnLn As Button
    Friend WithEvents btnOpenBracket As Button
    Friend WithEvents btnCloseBracket As Button
    Friend WithEvents btnFactorial As Button

    Friend WithEvents btnClear As Button
    Friend WithEvents btnPercent As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnMinus As Button

    Friend WithEvents btnSeven As Button
    Friend WithEvents btnEight As Button
    Friend WithEvents btnNine As Button
    Friend WithEvents btnPlus As Button

    Friend WithEvents btnFour As Button
    Friend WithEvents btnFive As Button
    Friend WithEvents btnSix As Button

    Friend WithEvents btnOne As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnThree As Button

    Friend WithEvents btnZero As Button
    Friend WithEvents btnDecimal As Button
    Friend WithEvents btnE As Button
    Friend WithEvents btnEquals As Button

End Class
