<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.DebuggerNonUserCode()>
<Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)>
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
        btnHistory = New Button()
        lblMode = New Label()
        txtExpression = New TextBox()
        txtResult = New TextBox()
        pnlMemory = New FlowLayoutPanel()
        btnMC = New Button()
        btnMR = New Button()
        btnMPlus = New Button()
        btnMMinus = New Button()
        lblMemoryStatus = New Label()
        pnlKeypad = New TableLayoutPanel()
        btnDelete = New Button()
        btnOpenBracket = New Button()
        btnClear = New Button()
        btnCloseBracket = New Button()
        btnPi = New Button()
        btnLog = New Button()
        btnSqrt = New Button()
        btnSquare = New Button()
        btnSeven = New Button()
        btnEight = New Button()
        btnNine = New Button()
        btnPlus = New Button()
        btnDegRad = New Button()
        btnSin = New Button()
        btnPower = New Button()
        btnCube = New Button()
        btnFour = New Button()
        btnFive = New Button()
        btnSix = New Button()
        btnMinus = New Button()
        btnFactorial = New Button()
        btnCos = New Button()
        btnE = New Button()
        btnReciprocal = New Button()
        btnOne = New Button()
        btnTwo = New Button()
        btnThree = New Button()
        btnMultiply = New Button()
        btnTan = New Button()
        btnLn = New Button()
        btnZero = New Button()
        btnDecimal = New Button()
        btnEquals = New Button()
        btnDivide = New Button()
        btnExp = New Button()
        btnPercent = New Button()
        pnlHistory = New Panel()
        lstHistory = New ListBox()
        lblHistoryHeader = New Label()
        btnClearHistory = New Button()
        pnlDisplay.SuspendLayout()
        pnlMemory.SuspendLayout()
        pnlKeypad.SuspendLayout()
        pnlHistory.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlDisplay
        ' 
        pnlDisplay.BackColor = Color.White
        pnlDisplay.Controls.Add(btnHistory)
        pnlDisplay.Controls.Add(lblMode)
        pnlDisplay.Controls.Add(txtExpression)
        pnlDisplay.Controls.Add(txtResult)
        pnlDisplay.Controls.Add(pnlMemory)
        pnlDisplay.Dock = DockStyle.Top
        pnlDisplay.Location = New Point(0, 0)
        pnlDisplay.Name = "pnlDisplay"
        pnlDisplay.Padding = New Padding(12, 8, 12, 6)
        pnlDisplay.Size = New Size(917, 161)
        pnlDisplay.TabIndex = 0
        ' 
        ' btnHistory
        ' 
        btnHistory.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnHistory.BackColor = Color.White
        btnHistory.Cursor = Cursors.Hand
        btnHistory.FlatStyle = FlatStyle.Flat
        btnHistory.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnHistory.ForeColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        btnHistory.Location = New Point(822, 6)
        btnHistory.Margin = New Padding(0)
        btnHistory.Name = "btnHistory"
        btnHistory.Size = New Size(83, 43)
        btnHistory.TabIndex = 3
        btnHistory.Text = "🕒 History"
        btnHistory.UseVisualStyleBackColor = True
        ' 
        ' lblMode
        ' 
        lblMode.AutoSize = True
        lblMode.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblMode.ForeColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        lblMode.Location = New Point(12, 8)
        lblMode.Name = "lblMode"
        lblMode.Size = New Size(39, 20)
        lblMode.TabIndex = 0
        lblMode.Text = "DEG"
        ' 
        ' txtExpression
        ' 
        txtExpression.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtExpression.BackColor = Color.White
        txtExpression.BorderStyle = BorderStyle.None
        txtExpression.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtExpression.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        txtExpression.Location = New Point(58, 8)
        txtExpression.Multiline = True
        txtExpression.Name = "txtExpression"
        txtExpression.ReadOnly = True
        txtExpression.Size = New Size(757, 41)
        txtExpression.TabIndex = 1
        txtExpression.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtResult
        ' 
        txtResult.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtResult.BackColor = Color.White
        txtResult.BorderStyle = BorderStyle.FixedSingle
        txtResult.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtResult.ForeColor = Color.Black
        txtResult.Location = New Point(12, 70)
        txtResult.Name = "txtResult"
        txtResult.ReadOnly = True
        txtResult.Size = New Size(893, 57)
        txtResult.TabIndex = 2
        txtResult.Text = "0"
        txtResult.TextAlign = HorizontalAlignment.Right
        ' 
        ' pnlMemory
        ' 
        pnlMemory.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlMemory.BackColor = Color.White
        pnlMemory.Controls.Add(btnMC)
        pnlMemory.Controls.Add(btnMR)
        pnlMemory.Controls.Add(btnMPlus)
        pnlMemory.Controls.Add(btnMMinus)
        pnlMemory.Controls.Add(lblMemoryStatus)
        pnlMemory.Location = New Point(12, 126)
        pnlMemory.Margin = New Padding(0)
        pnlMemory.Name = "pnlMemory"
        pnlMemory.Size = New Size(893, 28)
        pnlMemory.TabIndex = 4
        ' 
        ' btnMC
        ' 
        btnMC.Cursor = Cursors.Hand
        btnMC.Enabled = False
        btnMC.FlatAppearance.BorderSize = 0
        btnMC.FlatStyle = FlatStyle.Flat
        btnMC.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        btnMC.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        btnMC.Location = New Point(0, 0)
        btnMC.Margin = New Padding(0, 0, 4, 0)
        btnMC.Name = "btnMC"
        btnMC.Size = New Size(42, 26)
        btnMC.TabIndex = 0
        btnMC.Text = "MC"
        btnMC.UseVisualStyleBackColor = True
        ' 
        ' btnMR
        ' 
        btnMR.Cursor = Cursors.Hand
        btnMR.Enabled = False
        btnMR.FlatAppearance.BorderSize = 0
        btnMR.FlatStyle = FlatStyle.Flat
        btnMR.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        btnMR.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        btnMR.Location = New Point(46, 0)
        btnMR.Margin = New Padding(0, 0, 4, 0)
        btnMR.Name = "btnMR"
        btnMR.Size = New Size(42, 26)
        btnMR.TabIndex = 1
        btnMR.Text = "MR"
        btnMR.UseVisualStyleBackColor = True
        ' 
        ' btnMPlus
        ' 
        btnMPlus.Cursor = Cursors.Hand
        btnMPlus.FlatAppearance.BorderSize = 0
        btnMPlus.FlatStyle = FlatStyle.Flat
        btnMPlus.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        btnMPlus.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btnMPlus.Location = New Point(92, 0)
        btnMPlus.Margin = New Padding(0, 0, 4, 0)
        btnMPlus.Name = "btnMPlus"
        btnMPlus.Size = New Size(42, 26)
        btnMPlus.TabIndex = 2
        btnMPlus.Text = "M+"
        btnMPlus.UseVisualStyleBackColor = True
        ' 
        ' btnMMinus
        ' 
        btnMMinus.Cursor = Cursors.Hand
        btnMMinus.FlatAppearance.BorderSize = 0
        btnMMinus.FlatStyle = FlatStyle.Flat
        btnMMinus.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        btnMMinus.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        btnMMinus.Location = New Point(138, 0)
        btnMMinus.Margin = New Padding(0, 0, 8, 0)
        btnMMinus.Name = "btnMMinus"
        btnMMinus.Size = New Size(42, 26)
        btnMMinus.TabIndex = 3
        btnMMinus.Text = "M−"
        btnMMinus.UseVisualStyleBackColor = True
        ' 
        ' lblMemoryStatus
        ' 
        lblMemoryStatus.AutoSize = True
        lblMemoryStatus.Font = New Font("Segoe UI", 8.0F, FontStyle.Italic)
        lblMemoryStatus.ForeColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        lblMemoryStatus.Location = New Point(190, 4)
        lblMemoryStatus.Margin = New Padding(2, 4, 0, 0)
        lblMemoryStatus.Name = "lblMemoryStatus"
        lblMemoryStatus.Size = New Size(0, 19)
        lblMemoryStatus.TabIndex = 4
        ' 
        ' pnlKeypad
        ' 
        pnlKeypad.BackColor = Color.FromArgb(CByte(242), CByte(243), CByte(245))
        pnlKeypad.ColumnCount = 8
        pnlKeypad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        pnlKeypad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        pnlKeypad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        pnlKeypad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        pnlKeypad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        pnlKeypad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        pnlKeypad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        pnlKeypad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        pnlKeypad.Controls.Add(btnDelete, 0, 0)
        pnlKeypad.Controls.Add(btnOpenBracket, 1, 0)
        pnlKeypad.Controls.Add(btnClear, 2, 0)
        pnlKeypad.Controls.Add(btnCloseBracket, 3, 0)
        pnlKeypad.Controls.Add(btnPi, 4, 0)
        pnlKeypad.Controls.Add(btnLog, 5, 0)
        pnlKeypad.Controls.Add(btnSqrt, 6, 0)
        pnlKeypad.Controls.Add(btnSquare, 7, 0)
        pnlKeypad.Controls.Add(btnSeven, 0, 1)
        pnlKeypad.Controls.Add(btnEight, 1, 1)
        pnlKeypad.Controls.Add(btnNine, 2, 1)
        pnlKeypad.Controls.Add(btnPlus, 3, 1)
        pnlKeypad.Controls.Add(btnDegRad, 4, 1)
        pnlKeypad.Controls.Add(btnSin, 5, 1)
        pnlKeypad.Controls.Add(btnPower, 6, 1)
        pnlKeypad.Controls.Add(btnCube, 7, 1)
        pnlKeypad.Controls.Add(btnFour, 0, 2)
        pnlKeypad.Controls.Add(btnFive, 1, 2)
        pnlKeypad.Controls.Add(btnSix, 2, 2)
        pnlKeypad.Controls.Add(btnMinus, 3, 2)
        pnlKeypad.Controls.Add(btnFactorial, 4, 2)
        pnlKeypad.Controls.Add(btnCos, 5, 2)
        pnlKeypad.Controls.Add(btnE, 6, 2)
        pnlKeypad.Controls.Add(btnReciprocal, 7, 2)
        pnlKeypad.Controls.Add(btnOne, 0, 3)
        pnlKeypad.Controls.Add(btnTwo, 1, 3)
        pnlKeypad.Controls.Add(btnThree, 2, 3)
        pnlKeypad.Controls.Add(btnMultiply, 3, 3)
        pnlKeypad.Controls.Add(btnTan, 5, 3)
        pnlKeypad.Controls.Add(btnLn, 7, 3)
        pnlKeypad.Controls.Add(btnZero, 0, 4)
        pnlKeypad.Controls.Add(btnDecimal, 1, 4)
        pnlKeypad.Controls.Add(btnEquals, 2, 4)
        pnlKeypad.Controls.Add(btnDivide, 3, 4)
        pnlKeypad.Controls.Add(btnExp, 4, 4)
        pnlKeypad.Controls.Add(btnPercent, 7, 4)
        pnlKeypad.Dock = DockStyle.Fill
        pnlKeypad.Location = New Point(0, 161)
        pnlKeypad.Name = "pnlKeypad"
        pnlKeypad.Padding = New Padding(10, 8, 10, 10)
        pnlKeypad.RowCount = 5
        pnlKeypad.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        pnlKeypad.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        pnlKeypad.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        pnlKeypad.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        pnlKeypad.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        pnlKeypad.Size = New Size(677, 473)
        pnlKeypad.TabIndex = 1
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Silver
        btnDelete.Dock = DockStyle.Fill
        btnDelete.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnDelete.Location = New Point(13, 11)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(76, 85)
        btnDelete.TabIndex = 0
        btnDelete.Text = "⌫"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnOpenBracket
        ' 
        btnOpenBracket.Dock = DockStyle.Fill
        btnOpenBracket.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnOpenBracket.Location = New Point(95, 11)
        btnOpenBracket.Name = "btnOpenBracket"
        btnOpenBracket.Size = New Size(76, 85)
        btnOpenBracket.TabIndex = 1
        btnOpenBracket.Text = "("
        btnOpenBracket.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnClear.Dock = DockStyle.Fill
        btnClear.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnClear.Location = New Point(177, 11)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(76, 85)
        btnClear.TabIndex = 2
        btnClear.Text = "C"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnCloseBracket
        ' 
        btnCloseBracket.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnCloseBracket.Dock = DockStyle.Fill
        btnCloseBracket.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnCloseBracket.Location = New Point(259, 11)
        btnCloseBracket.Name = "btnCloseBracket"
        btnCloseBracket.Size = New Size(76, 85)
        btnCloseBracket.TabIndex = 3
        btnCloseBracket.Text = ")"
        btnCloseBracket.UseVisualStyleBackColor = False
        ' 
        ' btnPi
        ' 
        btnPi.Dock = DockStyle.Fill
        btnPi.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnPi.Location = New Point(341, 11)
        btnPi.Name = "btnPi"
        btnPi.Size = New Size(76, 85)
        btnPi.TabIndex = 4
        btnPi.Text = "π"
        btnPi.UseVisualStyleBackColor = True
        ' 
        ' btnLog
        ' 
        btnLog.Dock = DockStyle.Fill
        btnLog.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        btnLog.Location = New Point(423, 11)
        btnLog.Name = "btnLog"
        btnLog.Size = New Size(76, 85)
        btnLog.TabIndex = 5
        btnLog.Text = "Log"
        btnLog.UseVisualStyleBackColor = True
        ' 
        ' btnSqrt
        ' 
        btnSqrt.Dock = DockStyle.Fill
        btnSqrt.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        btnSqrt.Location = New Point(505, 11)
        btnSqrt.Name = "btnSqrt"
        btnSqrt.Size = New Size(76, 85)
        btnSqrt.TabIndex = 6
        btnSqrt.Text = "Sqrt"
        btnSqrt.UseVisualStyleBackColor = True
        ' 
        ' btnSquare
        ' 
        btnSquare.Dock = DockStyle.Fill
        btnSquare.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        btnSquare.Location = New Point(587, 11)
        btnSquare.Name = "btnSquare"
        btnSquare.Size = New Size(77, 85)
        btnSquare.TabIndex = 7
        btnSquare.Text = "x²"
        btnSquare.UseVisualStyleBackColor = True
        ' 
        ' btnSeven
        ' 
        btnSeven.Dock = DockStyle.Fill
        btnSeven.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnSeven.Location = New Point(13, 102)
        btnSeven.Name = "btnSeven"
        btnSeven.Size = New Size(76, 85)
        btnSeven.TabIndex = 8
        btnSeven.Text = "7"
        btnSeven.UseVisualStyleBackColor = True
        ' 
        ' btnEight
        ' 
        btnEight.Dock = DockStyle.Fill
        btnEight.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnEight.Location = New Point(95, 102)
        btnEight.Name = "btnEight"
        btnEight.Size = New Size(76, 85)
        btnEight.TabIndex = 9
        btnEight.Text = "8"
        btnEight.UseVisualStyleBackColor = True
        ' 
        ' btnNine
        ' 
        btnNine.Dock = DockStyle.Fill
        btnNine.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnNine.Location = New Point(177, 102)
        btnNine.Name = "btnNine"
        btnNine.Size = New Size(76, 85)
        btnNine.TabIndex = 10
        btnNine.Text = "9"
        btnNine.UseVisualStyleBackColor = True
        ' 
        ' btnPlus
        ' 
        btnPlus.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnPlus.Dock = DockStyle.Fill
        btnPlus.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnPlus.Location = New Point(259, 102)
        btnPlus.Name = "btnPlus"
        btnPlus.Size = New Size(76, 85)
        btnPlus.TabIndex = 11
        btnPlus.Text = "+"
        btnPlus.UseVisualStyleBackColor = False
        ' 
        ' btnDegRad
        ' 
        btnDegRad.Dock = DockStyle.Fill
        btnDegRad.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnDegRad.Location = New Point(341, 102)
        btnDegRad.Name = "btnDegRad"
        btnDegRad.Size = New Size(76, 85)
        btnDegRad.TabIndex = 12
        btnDegRad.Text = "DEG"
        btnDegRad.UseVisualStyleBackColor = True
        ' 
        ' btnSin
        ' 
        btnSin.Dock = DockStyle.Fill
        btnSin.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        btnSin.Location = New Point(423, 102)
        btnSin.Name = "btnSin"
        btnSin.Size = New Size(76, 85)
        btnSin.TabIndex = 13
        btnSin.Text = "Sin"
        btnSin.UseVisualStyleBackColor = True
        ' 
        ' btnPower
        ' 
        btnPower.Dock = DockStyle.Fill
        btnPower.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        btnPower.Location = New Point(505, 102)
        btnPower.Name = "btnPower"
        btnPower.Size = New Size(76, 85)
        btnPower.TabIndex = 14
        btnPower.Text = "xʸ"
        btnPower.UseVisualStyleBackColor = True
        ' 
        ' btnCube
        ' 
        btnCube.Dock = DockStyle.Fill
        btnCube.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        btnCube.Location = New Point(587, 102)
        btnCube.Name = "btnCube"
        btnCube.Size = New Size(77, 85)
        btnCube.TabIndex = 15
        btnCube.Text = "x³"
        btnCube.UseVisualStyleBackColor = True
        ' 
        ' btnFour
        ' 
        btnFour.Dock = DockStyle.Fill
        btnFour.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnFour.Location = New Point(13, 193)
        btnFour.Name = "btnFour"
        btnFour.Size = New Size(76, 85)
        btnFour.TabIndex = 16
        btnFour.Text = "4"
        btnFour.UseVisualStyleBackColor = True
        ' 
        ' btnFive
        ' 
        btnFive.Dock = DockStyle.Fill
        btnFive.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnFive.Location = New Point(95, 193)
        btnFive.Name = "btnFive"
        btnFive.Size = New Size(76, 85)
        btnFive.TabIndex = 17
        btnFive.Text = "5"
        btnFive.UseVisualStyleBackColor = True
        ' 
        ' btnSix
        ' 
        btnSix.Dock = DockStyle.Fill
        btnSix.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnSix.Location = New Point(177, 193)
        btnSix.Name = "btnSix"
        btnSix.Size = New Size(76, 85)
        btnSix.TabIndex = 18
        btnSix.Text = "6"
        btnSix.UseVisualStyleBackColor = True
        ' 
        ' btnMinus
        ' 
        btnMinus.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnMinus.Dock = DockStyle.Fill
        btnMinus.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnMinus.Location = New Point(259, 193)
        btnMinus.Name = "btnMinus"
        btnMinus.Size = New Size(76, 85)
        btnMinus.TabIndex = 19
        btnMinus.Text = "-"
        btnMinus.UseVisualStyleBackColor = False
        ' 
        ' btnFactorial
        ' 
        btnFactorial.Dock = DockStyle.Fill
        btnFactorial.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        btnFactorial.Location = New Point(341, 193)
        btnFactorial.Name = "btnFactorial"
        btnFactorial.Size = New Size(76, 85)
        btnFactorial.TabIndex = 20
        btnFactorial.Text = "n!"
        btnFactorial.UseVisualStyleBackColor = True
        ' 
        ' btnCos
        ' 
        btnCos.Dock = DockStyle.Fill
        btnCos.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        btnCos.Location = New Point(423, 193)
        btnCos.Name = "btnCos"
        btnCos.Size = New Size(76, 85)
        btnCos.TabIndex = 21
        btnCos.Text = "Cos"
        btnCos.UseVisualStyleBackColor = True
        ' 
        ' btnE
        ' 
        btnE.Dock = DockStyle.Fill
        btnE.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnE.Location = New Point(505, 193)
        btnE.Name = "btnE"
        btnE.Size = New Size(76, 85)
        btnE.TabIndex = 22
        btnE.Text = "e"
        btnE.UseVisualStyleBackColor = True
        ' 
        ' btnReciprocal
        ' 
        btnReciprocal.Dock = DockStyle.Fill
        btnReciprocal.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnReciprocal.Location = New Point(587, 193)
        btnReciprocal.Name = "btnReciprocal"
        btnReciprocal.Size = New Size(77, 85)
        btnReciprocal.TabIndex = 23
        btnReciprocal.Text = "1/x"
        btnReciprocal.UseVisualStyleBackColor = True
        ' 
        ' btnOne
        ' 
        btnOne.Dock = DockStyle.Fill
        btnOne.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnOne.Location = New Point(13, 284)
        btnOne.Name = "btnOne"
        btnOne.Size = New Size(76, 85)
        btnOne.TabIndex = 24
        btnOne.Text = "1"
        btnOne.UseVisualStyleBackColor = True
        ' 
        ' btnTwo
        ' 
        btnTwo.Dock = DockStyle.Fill
        btnTwo.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnTwo.Location = New Point(95, 284)
        btnTwo.Name = "btnTwo"
        btnTwo.Size = New Size(76, 85)
        btnTwo.TabIndex = 25
        btnTwo.Text = "2"
        btnTwo.UseVisualStyleBackColor = True
        ' 
        ' btnThree
        ' 
        btnThree.Dock = DockStyle.Fill
        btnThree.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnThree.Location = New Point(177, 284)
        btnThree.Name = "btnThree"
        btnThree.Size = New Size(76, 85)
        btnThree.TabIndex = 26
        btnThree.Text = "3"
        btnThree.UseVisualStyleBackColor = True
        ' 
        ' btnMultiply
        ' 
        btnMultiply.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnMultiply.Dock = DockStyle.Fill
        btnMultiply.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnMultiply.Location = New Point(259, 284)
        btnMultiply.Name = "btnMultiply"
        btnMultiply.Size = New Size(76, 85)
        btnMultiply.TabIndex = 27
        btnMultiply.Text = "*"
        btnMultiply.UseVisualStyleBackColor = False
        ' 
        ' btnTan
        ' 
        btnTan.Dock = DockStyle.Fill
        btnTan.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        btnTan.Location = New Point(423, 284)
        btnTan.Name = "btnTan"
        btnTan.Size = New Size(76, 85)
        btnTan.TabIndex = 28
        btnTan.Text = "Tan"
        btnTan.UseVisualStyleBackColor = True
        ' 
        ' btnLn
        ' 
        btnLn.Dock = DockStyle.Fill
        btnLn.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnLn.Location = New Point(587, 284)
        btnLn.Name = "btnLn"
        btnLn.Size = New Size(77, 85)
        btnLn.TabIndex = 29
        btnLn.Text = "ln x"
        btnLn.UseVisualStyleBackColor = True
        ' 
        ' btnZero
        ' 
        btnZero.Dock = DockStyle.Fill
        btnZero.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnZero.Location = New Point(13, 375)
        btnZero.Name = "btnZero"
        btnZero.Size = New Size(76, 85)
        btnZero.TabIndex = 30
        btnZero.Text = "0"
        btnZero.UseVisualStyleBackColor = True
        ' 
        ' btnDecimal
        ' 
        btnDecimal.Dock = DockStyle.Fill
        btnDecimal.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnDecimal.Location = New Point(95, 375)
        btnDecimal.Name = "btnDecimal"
        btnDecimal.Size = New Size(76, 85)
        btnDecimal.TabIndex = 31
        btnDecimal.Text = "."
        btnDecimal.UseVisualStyleBackColor = True
        ' 
        ' btnEquals
        ' 
        btnEquals.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnEquals.Dock = DockStyle.Fill
        btnEquals.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnEquals.Location = New Point(177, 375)
        btnEquals.Name = "btnEquals"
        btnEquals.Size = New Size(76, 85)
        btnEquals.TabIndex = 32
        btnEquals.Text = "="
        btnEquals.UseVisualStyleBackColor = False
        ' 
        ' btnDivide
        ' 
        btnDivide.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnDivide.Dock = DockStyle.Fill
        btnDivide.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnDivide.Location = New Point(259, 375)
        btnDivide.Name = "btnDivide"
        btnDivide.Size = New Size(76, 85)
        btnDivide.TabIndex = 33
        btnDivide.Text = "/"
        btnDivide.UseVisualStyleBackColor = False
        ' 
        ' btnExp
        ' 
        btnExp.Dock = DockStyle.Fill
        btnExp.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        btnExp.Location = New Point(341, 375)
        btnExp.Name = "btnExp"
        btnExp.Size = New Size(76, 85)
        btnExp.TabIndex = 34
        btnExp.Text = "Exp"
        btnExp.UseVisualStyleBackColor = True
        ' 
        ' btnPercent
        ' 
        btnPercent.Dock = DockStyle.Fill
        btnPercent.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnPercent.Location = New Point(587, 375)
        btnPercent.Name = "btnPercent"
        btnPercent.Size = New Size(77, 85)
        btnPercent.TabIndex = 35
        btnPercent.Text = "%"
        btnPercent.UseVisualStyleBackColor = True
        ' 
        ' pnlHistory
        ' 
        pnlHistory.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        pnlHistory.Controls.Add(lstHistory)
        pnlHistory.Controls.Add(lblHistoryHeader)
        pnlHistory.Controls.Add(btnClearHistory)
        pnlHistory.Dock = DockStyle.Right
        pnlHistory.Location = New Point(677, 161)
        pnlHistory.Name = "pnlHistory"
        pnlHistory.Padding = New Padding(8)
        pnlHistory.Size = New Size(240, 473)
        pnlHistory.TabIndex = 2
        pnlHistory.Visible = False
        ' 
        ' lstHistory
        ' 
        lstHistory.BorderStyle = BorderStyle.None
        lstHistory.Cursor = Cursors.Hand
        lstHistory.Dock = DockStyle.Fill
        lstHistory.DrawMode = DrawMode.OwnerDrawVariable
        lstHistory.Font = New Font("Segoe UI", 9.5F)
        lstHistory.FormattingEnabled = True
        lstHistory.IntegralHeight = False
        lstHistory.ItemHeight = 44
        lstHistory.Location = New Point(8, 33)
        lstHistory.Name = "lstHistory"
        lstHistory.Size = New Size(224, 402)
        lstHistory.TabIndex = 2
        ' 
        ' lblHistoryHeader
        ' 
        lblHistoryHeader.Dock = DockStyle.Top
        lblHistoryHeader.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblHistoryHeader.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        lblHistoryHeader.Location = New Point(8, 8)
        lblHistoryHeader.Name = "lblHistoryHeader"
        lblHistoryHeader.Size = New Size(224, 25)
        lblHistoryHeader.TabIndex = 0
        lblHistoryHeader.Text = "History"
        ' 
        ' btnClearHistory
        ' 
        btnClearHistory.Dock = DockStyle.Bottom
        btnClearHistory.FlatStyle = FlatStyle.Flat
        btnClearHistory.Font = New Font("Segoe UI", 9.0F)
        btnClearHistory.ForeColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        btnClearHistory.Location = New Point(8, 435)
        btnClearHistory.Name = "btnClearHistory"
        btnClearHistory.Size = New Size(224, 30)
        btnClearHistory.TabIndex = 1
        btnClearHistory.Text = "🗑 Clear History"
        btnClearHistory.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(243), CByte(245))
        ClientSize = New Size(917, 634)
        Controls.Add(pnlKeypad)
        Controls.Add(pnlHistory)
        Controls.Add(pnlDisplay)
        FormBorderStyle = FormBorderStyle.FixedDialog
        KeyPreview = True
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        pnlDisplay.ResumeLayout(False)
        pnlDisplay.PerformLayout()
        pnlMemory.ResumeLayout(False)
        pnlMemory.PerformLayout()
        pnlKeypad.ResumeLayout(False)
        pnlHistory.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlDisplay As Panel
    Friend WithEvents lblMode As Label
    Friend WithEvents btnHistory As Button
    Friend WithEvents txtExpression As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents pnlMemory As FlowLayoutPanel
    Friend WithEvents btnMC As Button
    Friend WithEvents btnMR As Button
    Friend WithEvents btnMPlus As Button
    Friend WithEvents btnMMinus As Button
    Friend WithEvents lblMemoryStatus As Label
    Friend WithEvents pnlKeypad As TableLayoutPanel
    Friend WithEvents pnlHistory As Panel
    Friend WithEvents lblHistoryHeader As Label
    Friend WithEvents btnClearHistory As Button
    Friend WithEvents lstHistory As ListBox

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
