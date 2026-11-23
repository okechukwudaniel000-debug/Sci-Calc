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

        '
        ' btnDelete
        '
        btnDelete.Dock = DockStyle.Fill
        btnDelete.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnDelete.Margin = New Padding(3)
        btnDelete.Name = "btnDelete"
        btnDelete.Text = "⌫"
        btnDelete.UseVisualStyleBackColor = True
        '
        ' btnOpenBracket
        '
        btnOpenBracket.Dock = DockStyle.Fill
        btnOpenBracket.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnOpenBracket.Margin = New Padding(3)
        btnOpenBracket.Name = "btnOpenBracket"
        btnOpenBracket.Text = "("
        btnOpenBracket.UseVisualStyleBackColor = True
        '
        ' btnClear
        '
        btnClear.Dock = DockStyle.Fill
        btnClear.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnClear.Margin = New Padding(3)
        btnClear.Name = "btnClear"
        btnClear.Text = "C"
        btnClear.UseVisualStyleBackColor = True
        '
        ' btnCloseBracket
        '
        btnCloseBracket.Dock = DockStyle.Fill
        btnCloseBracket.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnCloseBracket.Margin = New Padding(3)
        btnCloseBracket.Name = "btnCloseBracket"
        btnCloseBracket.Text = ")"
        btnCloseBracket.UseVisualStyleBackColor = True
        '
        ' btnSeven
        '
        btnSeven.Dock = DockStyle.Fill
        btnSeven.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnSeven.Margin = New Padding(3)
        btnSeven.Name = "btnSeven"
        btnSeven.Text = "7"
        btnSeven.UseVisualStyleBackColor = True
        '
        ' btnEight
        '
        btnEight.Dock = DockStyle.Fill
        btnEight.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnEight.Margin = New Padding(3)
        btnEight.Name = "btnEight"
        btnEight.Text = "8"
        btnEight.UseVisualStyleBackColor = True
        '
        ' btnNine
        '
        btnNine.Dock = DockStyle.Fill
        btnNine.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnNine.Margin = New Padding(3)
        btnNine.Name = "btnNine"
        btnNine.Text = "9"
        btnNine.UseVisualStyleBackColor = True
        '
        ' btnPlus
        '
        btnPlus.Dock = DockStyle.Fill
        btnPlus.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnPlus.Margin = New Padding(3)
        btnPlus.Name = "btnPlus"
        btnPlus.Text = "+"
        btnPlus.UseVisualStyleBackColor = True
        '
        ' btnFour
        '
        btnFour.Dock = DockStyle.Fill
        btnFour.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnFour.Margin = New Padding(3)
        btnFour.Name = "btnFour"
        btnFour.Text = "4"
        btnFour.UseVisualStyleBackColor = True
        '
        ' btnFive
        '
        btnFive.Dock = DockStyle.Fill
        btnFive.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnFive.Margin = New Padding(3)
        btnFive.Name = "btnFive"
        btnFive.Text = "5"
        btnFive.UseVisualStyleBackColor = True
        '
        ' btnSix
        '
        btnSix.Dock = DockStyle.Fill
        btnSix.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnSix.Margin = New Padding(3)
        btnSix.Name = "btnSix"
        btnSix.Text = "6"
        btnSix.UseVisualStyleBackColor = True
        '
        ' btnMinus
        '
        btnMinus.Dock = DockStyle.Fill
        btnMinus.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnMinus.Margin = New Padding(3)
        btnMinus.Name = "btnMinus"
        btnMinus.Text = "-"
        btnMinus.UseVisualStyleBackColor = True
        '
        ' btnOne
        '
        btnOne.Dock = DockStyle.Fill
        btnOne.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnOne.Margin = New Padding(3)
        btnOne.Name = "btnOne"
        btnOne.Text = "1"
        btnOne.UseVisualStyleBackColor = True
        '
        ' btnTwo
        '
        btnTwo.Dock = DockStyle.Fill
        btnTwo.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnTwo.Margin = New Padding(3)
        btnTwo.Name = "btnTwo"
        btnTwo.Text = "2"
        btnTwo.UseVisualStyleBackColor = True
        '
        ' btnThree
        '
        btnThree.Dock = DockStyle.Fill
        btnThree.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnThree.Margin = New Padding(3)
        btnThree.Name = "btnThree"
        btnThree.Text = "3"
        btnThree.UseVisualStyleBackColor = True
        '
        ' btnMultiply
        '
        btnMultiply.Dock = DockStyle.Fill
        btnMultiply.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnMultiply.Margin = New Padding(3)
        btnMultiply.Name = "btnMultiply"
        btnMultiply.Text = "*"
        btnMultiply.UseVisualStyleBackColor = True
        '
        ' btnZero
        '
        btnZero.Dock = DockStyle.Fill
        btnZero.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnZero.Margin = New Padding(3)
        btnZero.Name = "btnZero"
        btnZero.Text = "0"
        btnZero.UseVisualStyleBackColor = True
        '
        ' btnDecimal
        '
        btnDecimal.Dock = DockStyle.Fill
        btnDecimal.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnDecimal.Margin = New Padding(3)
        btnDecimal.Name = "btnDecimal"
        btnDecimal.Text = "."
        btnDecimal.UseVisualStyleBackColor = True
        '
        ' btnEquals
        '
        btnEquals.Dock = DockStyle.Fill
        btnEquals.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnEquals.Margin = New Padding(3)
        btnEquals.Name = "btnEquals"
        btnEquals.Text = "="
        btnEquals.UseVisualStyleBackColor = True
        '
        ' btnDivide
        '
        btnDivide.Dock = DockStyle.Fill
        btnDivide.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnDivide.Margin = New Padding(3)
        btnDivide.Name = "btnDivide"
        btnDivide.Text = "/"
        btnDivide.UseVisualStyleBackColor = True
        '
        ' btnPi
        '
        btnPi.Dock = DockStyle.Fill
        btnPi.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnPi.Margin = New Padding(3)
        btnPi.Name = "btnPi"
        btnPi.Text = "π"
        btnPi.UseVisualStyleBackColor = True
        '
        ' btnLog
        '
        btnLog.Dock = DockStyle.Fill
        btnLog.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        btnLog.Margin = New Padding(3)
        btnLog.Name = "btnLog"
        btnLog.Text = "Log"
        btnLog.UseVisualStyleBackColor = True
        '
        ' btnSqrt
        '
        btnSqrt.Dock = DockStyle.Fill
        btnSqrt.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        btnSqrt.Margin = New Padding(3)
        btnSqrt.Name = "btnSqrt"
        btnSqrt.Text = "Sqrt"
        btnSqrt.UseVisualStyleBackColor = True
        '
        ' btnSquare
        '
        btnSquare.Dock = DockStyle.Fill
        btnSquare.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        btnSquare.Margin = New Padding(3)
        btnSquare.Name = "btnSquare"
        btnSquare.Text = "x²"
        btnSquare.UseVisualStyleBackColor = True
        '
        ' btnDegRad
        '
        btnDegRad.Dock = DockStyle.Fill
        btnDegRad.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnDegRad.Margin = New Padding(3)
        btnDegRad.Name = "btnDegRad"
        btnDegRad.Text = "DEG"
        btnDegRad.UseVisualStyleBackColor = True
        '
        ' btnSin
        '
        btnSin.Dock = DockStyle.Fill
        btnSin.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        btnSin.Margin = New Padding(3)
        btnSin.Name = "btnSin"
        btnSin.Text = "Sin"
        btnSin.UseVisualStyleBackColor = True
        '
        ' btnPower
        '
        btnPower.Dock = DockStyle.Fill
        btnPower.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        btnPower.Margin = New Padding(3)
        btnPower.Name = "btnPower"
        btnPower.Text = "xʸ"
        btnPower.UseVisualStyleBackColor = True
        '
        ' btnCube
        '
        btnCube.Dock = DockStyle.Fill
        btnCube.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        btnCube.Margin = New Padding(3)
        btnCube.Name = "btnCube"
        btnCube.Text = "x³"
        btnCube.UseVisualStyleBackColor = True
        '
        ' btnFactorial
        '
        btnFactorial.Dock = DockStyle.Fill
        btnFactorial.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        btnFactorial.Margin = New Padding(3)
        btnFactorial.Name = "btnFactorial"
        btnFactorial.Text = "n!"
        btnFactorial.UseVisualStyleBackColor = True
        '
        ' btnCos
        '
        btnCos.Dock = DockStyle.Fill
        btnCos.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        btnCos.Margin = New Padding(3)
        btnCos.Name = "btnCos"
        btnCos.Text = "Cos"
        btnCos.UseVisualStyleBackColor = True
        '
        ' btnE
        '
        btnE.Dock = DockStyle.Fill
        btnE.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnE.Margin = New Padding(3)
        btnE.Name = "btnE"
        btnE.Text = "e"
        btnE.UseVisualStyleBackColor = True
        '
        ' btnReciprocal
        '
        btnReciprocal.Dock = DockStyle.Fill
        btnReciprocal.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnReciprocal.Margin = New Padding(3)
        btnReciprocal.Name = "btnReciprocal"
        btnReciprocal.Text = "1/x"
        btnReciprocal.UseVisualStyleBackColor = True
        '
        ' btnTan
        '
        btnTan.Dock = DockStyle.Fill
        btnTan.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        btnTan.Margin = New Padding(3)
        btnTan.Name = "btnTan"
        btnTan.Text = "Tan"
        btnTan.UseVisualStyleBackColor = True
        '
        ' btnLn
        '
        btnLn.Dock = DockStyle.Fill
        btnLn.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnLn.Margin = New Padding(3)
        btnLn.Name = "btnLn"
        btnLn.Text = "ln x"
        btnLn.UseVisualStyleBackColor = True
        '
        ' btnExp
        '
        btnExp.Dock = DockStyle.Fill
        btnExp.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        btnExp.Margin = New Padding(3)
        btnExp.Name = "btnExp"
        btnExp.Text = "Exp"
        btnExp.UseVisualStyleBackColor = True
        '
        ' btnPercent
        '
        btnPercent.Dock = DockStyle.Fill
        btnPercent.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnPercent.Margin = New Padding(3)
        btnPercent.Name = "btnPercent"
        btnPercent.Text = "%"
        btnPercent.UseVisualStyleBackColor = True

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
