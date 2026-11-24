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
        pnlScientific = New TableLayoutPanel()
        btnDelete = New Button()
        btnOpenBracket = New Button()
        btnCloseBracket = New Button()
        btnClear = New Button()
        btnPi = New Button()
        btnLog = New Button()
        btnSqrt = New Button()
        btnSquare = New Button()
        btnCube = New Button()
        btnPower = New Button()
        btnSin = New Button()
        btnCos = New Button()
        btnTan = New Button()
        btnE = New Button()
        btnFactorial = New Button()
        btnExp = New Button()
        btnReciprocal = New Button()
        btnLn = New Button()
        btnPercent = New Button()
        btnDegRad = New Button()
        pnlNumeric = New TableLayoutPanel()
        btnSeven = New Button()
        btnEight = New Button()
        btnNine = New Button()
        btnDivide = New Button()
        btnFour = New Button()
        btnFive = New Button()
        btnSix = New Button()
        btnMultiply = New Button()
        btnOne = New Button()
        btnTwo = New Button()
        btnThree = New Button()
        btnMinus = New Button()
        btnZero = New Button()
        btnDecimal = New Button()
        btnEquals = New Button()
        btnPlus = New Button()
        pnlHistory = New Panel()
        lblHistoryHeader = New Label()
        lstHistory = New ListBox()
        btnClearHistory = New Button()
        pnlDisplay.SuspendLayout()
        pnlMemory.SuspendLayout()
        pnlKeypad.SuspendLayout()
        pnlScientific.SuspendLayout()
        pnlNumeric.SuspendLayout()
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
        pnlDisplay.Margin = New Padding(0)
        pnlDisplay.Name = "pnlDisplay"
        pnlDisplay.Padding = New Padding(12, 8, 12, 6)
        pnlDisplay.Size = New Size(920, 160)
        pnlDisplay.TabIndex = 0
        ' 
        ' btnHistory
        ' 
        btnHistory.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnHistory.BackColor = Color.White
        btnHistory.Cursor = Cursors.Hand
        btnHistory.FlatStyle = FlatStyle.Flat
        btnHistory.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnHistory.ForeColor = Color.FromArgb(CByte(90), CByte(90), CByte(90))
        btnHistory.Location = New Point(825, 6)
        btnHistory.Margin = New Padding(0)
        btnHistory.Name = "btnHistory"
        btnHistory.Size = New Size(83, 40)
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
        txtExpression.Size = New Size(760, 40)
        txtExpression.TabIndex = 1
        txtExpression.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtResult
        ' 
        txtResult.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtResult.BackColor = Color.White
        txtResult.BorderStyle = BorderStyle.FixedSingle
        txtResult.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtResult.ForeColor = Color.Black
        txtResult.Location = New Point(12, 54)
        txtResult.Name = "txtResult"
        txtResult.ReadOnly = True
        txtResult.Size = New Size(896, 61)
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
        pnlMemory.Location = New Point(12, 122)
        pnlMemory.Margin = New Padding(0)
        pnlMemory.Name = "pnlMemory"
        pnlMemory.Size = New Size(896, 32)
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
        btnMC.Size = New Size(44, 28)
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
        btnMR.Location = New Point(48, 0)
        btnMR.Margin = New Padding(0, 0, 4, 0)
        btnMR.Name = "btnMR"
        btnMR.Size = New Size(44, 28)
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
        btnMPlus.Location = New Point(96, 0)
        btnMPlus.Margin = New Padding(0, 0, 4, 0)
        btnMPlus.Name = "btnMPlus"
        btnMPlus.Size = New Size(44, 28)
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
        btnMMinus.Location = New Point(144, 0)
        btnMMinus.Margin = New Padding(0, 0, 8, 0)
        btnMMinus.Name = "btnMMinus"
        btnMMinus.Size = New Size(44, 28)
        btnMMinus.TabIndex = 3
        btnMMinus.Text = "M−"
        btnMMinus.UseVisualStyleBackColor = True
        ' 
        ' lblMemoryStatus
        ' 
        lblMemoryStatus.AutoSize = True
        lblMemoryStatus.Font = New Font("Segoe UI", 8.0F, FontStyle.Italic)
        lblMemoryStatus.ForeColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        lblMemoryStatus.Location = New Point(200, 5)
        lblMemoryStatus.Margin = New Padding(4, 5, 0, 0)
        lblMemoryStatus.Name = "lblMemoryStatus"
        lblMemoryStatus.Size = New Size(0, 19)
        lblMemoryStatus.TabIndex = 4
        ' 
        ' pnlKeypad
        ' 
        pnlKeypad.BackColor = Color.FromArgb(CByte(242), CByte(243), CByte(245))
        pnlKeypad.ColumnCount = 3
        pnlKeypad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 47.0F))
        pnlKeypad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.0F))
        pnlKeypad.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        pnlKeypad.Controls.Add(pnlScientific, 0, 0)
        pnlKeypad.Controls.Add(pnlNumeric, 1, 0)
        pnlKeypad.Controls.Add(pnlHistory, 2, 0)
        pnlKeypad.Dock = DockStyle.Fill
        pnlKeypad.Location = New Point(0, 160)
        pnlKeypad.Margin = New Padding(0)
        pnlKeypad.Name = "pnlKeypad"
        pnlKeypad.Padding = New Padding(8)
        pnlKeypad.RowCount = 1
        pnlKeypad.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        pnlKeypad.Size = New Size(920, 480)
        pnlKeypad.TabIndex = 1
        ' 
        ' pnlScientific
        ' 
        pnlScientific.BackColor = Color.FromArgb(CByte(32), CByte(37), CByte(44))
        pnlScientific.ColumnCount = 5
        pnlScientific.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        pnlScientific.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        pnlScientific.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        pnlScientific.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        pnlScientific.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        pnlScientific.Controls.Add(btnDelete, 0, 0)
        pnlScientific.Controls.Add(btnOpenBracket, 1, 0)
        pnlScientific.Controls.Add(btnCloseBracket, 2, 0)
        pnlScientific.Controls.Add(btnClear, 3, 0)
        pnlScientific.Controls.Add(btnPi, 4, 0)
        pnlScientific.Controls.Add(btnLog, 0, 1)
        pnlScientific.Controls.Add(btnSqrt, 1, 1)
        pnlScientific.Controls.Add(btnSquare, 2, 1)
        pnlScientific.Controls.Add(btnCube, 3, 1)
        pnlScientific.Controls.Add(btnPower, 4, 1)
        pnlScientific.Controls.Add(btnSin, 0, 2)
        pnlScientific.Controls.Add(btnCos, 1, 2)
        pnlScientific.Controls.Add(btnTan, 2, 2)
        pnlScientific.Controls.Add(btnE, 3, 2)
        pnlScientific.Controls.Add(btnFactorial, 4, 2)
        pnlScientific.Controls.Add(btnExp, 0, 3)
        pnlScientific.Controls.Add(btnReciprocal, 1, 3)
        pnlScientific.Controls.Add(btnLn, 2, 3)
        pnlScientific.Controls.Add(btnPercent, 3, 3)
        pnlScientific.Controls.Add(btnDegRad, 4, 3)
        pnlScientific.Dock = DockStyle.Fill
        pnlScientific.Location = New Point(11, 11)
        pnlScientific.Margin = New Padding(3)
        pnlScientific.Name = "pnlScientific"
        pnlScientific.Padding = New Padding(6)
        pnlScientific.RowCount = 4
        pnlScientific.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0F))
        pnlScientific.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0F))
        pnlScientific.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0F))
        pnlScientific.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0F))
        pnlScientific.Size = New Size(418, 458)
        pnlScientific.TabIndex = 0
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(45), CByte(52), CByte(62))
        btnDelete.Dock = DockStyle.Fill
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(9, 9)
        btnDelete.Margin = New Padding(3)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 105)
        btnDelete.TabIndex = 0
        btnDelete.Text = "⌫"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnOpenBracket
        ' 
        btnOpenBracket.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(95))
        btnOpenBracket.Dock = DockStyle.Fill
        btnOpenBracket.FlatAppearance.BorderSize = 0
        btnOpenBracket.FlatStyle = FlatStyle.Flat
        btnOpenBracket.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnOpenBracket.ForeColor = Color.White
        btnOpenBracket.Location = New Point(90, 9)
        btnOpenBracket.Margin = New Padding(3)
        btnOpenBracket.Name = "btnOpenBracket"
        btnOpenBracket.Size = New Size(75, 105)
        btnOpenBracket.TabIndex = 1
        btnOpenBracket.Text = "("
        btnOpenBracket.UseVisualStyleBackColor = False
        ' 
        ' btnCloseBracket
        ' 
        btnCloseBracket.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(95))
        btnCloseBracket.Dock = DockStyle.Fill
        btnCloseBracket.FlatAppearance.BorderSize = 0
        btnCloseBracket.FlatStyle = FlatStyle.Flat
        btnCloseBracket.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnCloseBracket.ForeColor = Color.White
        btnCloseBracket.Location = New Point(171, 9)
        btnCloseBracket.Margin = New Padding(3)
        btnCloseBracket.Name = "btnCloseBracket"
        btnCloseBracket.Size = New Size(75, 105)
        btnCloseBracket.TabIndex = 2
        btnCloseBracket.Text = ")"
        btnCloseBracket.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(242), CByte(140), CByte(107))
        btnClear.Dock = DockStyle.Fill
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(252, 9)
        btnClear.Margin = New Padding(3)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 105)
        btnClear.TabIndex = 3
        btnClear.Text = "C"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnPi
        ' 
        btnPi.BackColor = Color.FromArgb(CByte(45), CByte(52), CByte(62))
        btnPi.Dock = DockStyle.Fill
        btnPi.FlatAppearance.BorderSize = 0
        btnPi.FlatStyle = FlatStyle.Flat
        btnPi.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnPi.ForeColor = Color.White
        btnPi.Location = New Point(333, 9)
        btnPi.Margin = New Padding(3)
        btnPi.Name = "btnPi"
        btnPi.Size = New Size(76, 105)
        btnPi.TabIndex = 4
        btnPi.Text = "π"
        btnPi.UseVisualStyleBackColor = False
        ' 
        ' btnLog
        ' 
        btnLog.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(95))
        btnLog.Dock = DockStyle.Fill
        btnLog.FlatAppearance.BorderSize = 0
        btnLog.FlatStyle = FlatStyle.Flat
        btnLog.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnLog.ForeColor = Color.White
        btnLog.Location = New Point(9, 120)
        btnLog.Margin = New Padding(3)
        btnLog.Name = "btnLog"
        btnLog.Size = New Size(75, 105)
        btnLog.TabIndex = 5
        btnLog.Text = "Log"
        btnLog.UseVisualStyleBackColor = False
        ' 
        ' btnSqrt
        ' 
        btnSqrt.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(95))
        btnSqrt.Dock = DockStyle.Fill
        btnSqrt.FlatAppearance.BorderSize = 0
        btnSqrt.FlatStyle = FlatStyle.Flat
        btnSqrt.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnSqrt.ForeColor = Color.White
        btnSqrt.Location = New Point(90, 120)
        btnSqrt.Margin = New Padding(3)
        btnSqrt.Name = "btnSqrt"
        btnSqrt.Size = New Size(75, 105)
        btnSqrt.TabIndex = 6
        btnSqrt.Text = "Sqrt"
        btnSqrt.UseVisualStyleBackColor = False
        ' 
        ' btnSquare
        ' 
        btnSquare.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(95))
        btnSquare.Dock = DockStyle.Fill
        btnSquare.FlatAppearance.BorderSize = 0
        btnSquare.FlatStyle = FlatStyle.Flat
        btnSquare.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnSquare.ForeColor = Color.White
        btnSquare.Location = New Point(171, 120)
        btnSquare.Margin = New Padding(3)
        btnSquare.Name = "btnSquare"
        btnSquare.Size = New Size(75, 105)
        btnSquare.TabIndex = 7
        btnSquare.Text = "x²"
        btnSquare.UseVisualStyleBackColor = False
        ' 
        ' btnCube
        ' 
        btnCube.BackColor = Color.FromArgb(CByte(45), CByte(52), CByte(62))
        btnCube.Dock = DockStyle.Fill
        btnCube.FlatAppearance.BorderSize = 0
        btnCube.FlatStyle = FlatStyle.Flat
        btnCube.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnCube.ForeColor = Color.White
        btnCube.Location = New Point(252, 120)
        btnCube.Margin = New Padding(3)
        btnCube.Name = "btnCube"
        btnCube.Size = New Size(75, 105)
        btnCube.TabIndex = 8
        btnCube.Text = "x³"
        btnCube.UseVisualStyleBackColor = False
        ' 
        ' btnPower
        ' 
        btnPower.BackColor = Color.FromArgb(CByte(45), CByte(52), CByte(62))
        btnPower.Dock = DockStyle.Fill
        btnPower.FlatAppearance.BorderSize = 0
        btnPower.FlatStyle = FlatStyle.Flat
        btnPower.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnPower.ForeColor = Color.White
        btnPower.Location = New Point(333, 120)
        btnPower.Margin = New Padding(3)
        btnPower.Name = "btnPower"
        btnPower.Size = New Size(76, 105)
        btnPower.TabIndex = 9
        btnPower.Text = "xʸ"
        btnPower.UseVisualStyleBackColor = False
        ' 
        ' btnSin
        ' 
        btnSin.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(95))
        btnSin.Dock = DockStyle.Fill
        btnSin.FlatAppearance.BorderSize = 0
        btnSin.FlatStyle = FlatStyle.Flat
        btnSin.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnSin.ForeColor = Color.White
        btnSin.Location = New Point(9, 231)
        btnSin.Margin = New Padding(3)
        btnSin.Name = "btnSin"
        btnSin.Size = New Size(75, 105)
        btnSin.TabIndex = 10
        btnSin.Text = "Sin"
        btnSin.UseVisualStyleBackColor = False
        ' 
        ' btnCos
        ' 
        btnCos.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(95))
        btnCos.Dock = DockStyle.Fill
        btnCos.FlatAppearance.BorderSize = 0
        btnCos.FlatStyle = FlatStyle.Flat
        btnCos.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnCos.ForeColor = Color.White
        btnCos.Location = New Point(90, 231)
        btnCos.Margin = New Padding(3)
        btnCos.Name = "btnCos"
        btnCos.Size = New Size(75, 105)
        btnCos.TabIndex = 11
        btnCos.Text = "Cos"
        btnCos.UseVisualStyleBackColor = False
        ' 
        ' btnTan
        ' 
        btnTan.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(95))
        btnTan.Dock = DockStyle.Fill
        btnTan.FlatAppearance.BorderSize = 0
        btnTan.FlatStyle = FlatStyle.Flat
        btnTan.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnTan.ForeColor = Color.White
        btnTan.Location = New Point(171, 231)
        btnTan.Margin = New Padding(3)
        btnTan.Name = "btnTan"
        btnTan.Size = New Size(75, 105)
        btnTan.TabIndex = 12
        btnTan.Text = "Tan"
        btnTan.UseVisualStyleBackColor = False
        ' 
        ' btnE
        ' 
        btnE.BackColor = Color.FromArgb(CByte(45), CByte(52), CByte(62))
        btnE.Dock = DockStyle.Fill
        btnE.FlatAppearance.BorderSize = 0
        btnE.FlatStyle = FlatStyle.Flat
        btnE.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnE.ForeColor = Color.White
        btnE.Location = New Point(252, 231)
        btnE.Margin = New Padding(3)
        btnE.Name = "btnE"
        btnE.Size = New Size(75, 105)
        btnE.TabIndex = 13
        btnE.Text = "e"
        btnE.UseVisualStyleBackColor = False
        ' 
        ' btnFactorial
        ' 
        btnFactorial.BackColor = Color.FromArgb(CByte(45), CByte(52), CByte(62))
        btnFactorial.Dock = DockStyle.Fill
        btnFactorial.FlatAppearance.BorderSize = 0
        btnFactorial.FlatStyle = FlatStyle.Flat
        btnFactorial.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnFactorial.ForeColor = Color.White
        btnFactorial.Location = New Point(333, 231)
        btnFactorial.Margin = New Padding(3)
        btnFactorial.Name = "btnFactorial"
        btnFactorial.Size = New Size(76, 105)
        btnFactorial.TabIndex = 14
        btnFactorial.Text = "n!"
        btnFactorial.UseVisualStyleBackColor = False
        ' 
        ' btnExp
        ' 
        btnExp.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(95))
        btnExp.Dock = DockStyle.Fill
        btnExp.FlatAppearance.BorderSize = 0
        btnExp.FlatStyle = FlatStyle.Flat
        btnExp.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnExp.ForeColor = Color.White
        btnExp.Location = New Point(9, 342)
        btnExp.Margin = New Padding(3)
        btnExp.Name = "btnExp"
        btnExp.Size = New Size(75, 107)
        btnExp.TabIndex = 15
        btnExp.Text = "Exp"
        btnExp.UseVisualStyleBackColor = False
        ' 
        ' btnReciprocal
        ' 
        btnReciprocal.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(95))
        btnReciprocal.Dock = DockStyle.Fill
        btnReciprocal.FlatAppearance.BorderSize = 0
        btnReciprocal.FlatStyle = FlatStyle.Flat
        btnReciprocal.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnReciprocal.ForeColor = Color.White
        btnReciprocal.Location = New Point(90, 342)
        btnReciprocal.Margin = New Padding(3)
        btnReciprocal.Name = "btnReciprocal"
        btnReciprocal.Size = New Size(75, 107)
        btnReciprocal.TabIndex = 16
        btnReciprocal.Text = "1/x"
        btnReciprocal.UseVisualStyleBackColor = False
        ' 
        ' btnLn
        ' 
        btnLn.BackColor = Color.FromArgb(CByte(70), CByte(80), CByte(95))
        btnLn.Dock = DockStyle.Fill
        btnLn.FlatAppearance.BorderSize = 0
        btnLn.FlatStyle = FlatStyle.Flat
        btnLn.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnLn.ForeColor = Color.White
        btnLn.Location = New Point(171, 342)
        btnLn.Margin = New Padding(3)
        btnLn.Name = "btnLn"
        btnLn.Size = New Size(75, 107)
        btnLn.TabIndex = 17
        btnLn.Text = "ln x"
        btnLn.UseVisualStyleBackColor = False
        ' 
        ' btnPercent
        ' 
        btnPercent.BackColor = Color.FromArgb(CByte(45), CByte(52), CByte(62))
        btnPercent.Dock = DockStyle.Fill
        btnPercent.FlatAppearance.BorderSize = 0
        btnPercent.FlatStyle = FlatStyle.Flat
        btnPercent.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnPercent.ForeColor = Color.White
        btnPercent.Location = New Point(252, 342)
        btnPercent.Margin = New Padding(3)
        btnPercent.Name = "btnPercent"
        btnPercent.Size = New Size(75, 107)
        btnPercent.TabIndex = 18
        btnPercent.Text = "%"
        btnPercent.UseVisualStyleBackColor = False
        ' 
        ' btnDegRad
        ' 
        btnDegRad.BackColor = Color.FromArgb(CByte(45), CByte(52), CByte(62))
        btnDegRad.Dock = DockStyle.Fill
        btnDegRad.FlatAppearance.BorderSize = 0
        btnDegRad.FlatStyle = FlatStyle.Flat
        btnDegRad.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnDegRad.ForeColor = Color.White
        btnDegRad.Location = New Point(333, 342)
        btnDegRad.Margin = New Padding(3)
        btnDegRad.Name = "btnDegRad"
        btnDegRad.Size = New Size(76, 107)
        btnDegRad.TabIndex = 19
        btnDegRad.Text = "DEG"
        btnDegRad.UseVisualStyleBackColor = False
        ' 
        ' pnlNumeric
        ' 
        pnlNumeric.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        pnlNumeric.ColumnCount = 4
        pnlNumeric.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        pnlNumeric.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        pnlNumeric.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        pnlNumeric.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        pnlNumeric.Controls.Add(btnSeven, 0, 0)
        pnlNumeric.Controls.Add(btnEight, 1, 0)
        pnlNumeric.Controls.Add(btnNine, 2, 0)
        pnlNumeric.Controls.Add(btnDivide, 3, 0)
        pnlNumeric.Controls.Add(btnFour, 0, 1)
        pnlNumeric.Controls.Add(btnFive, 1, 1)
        pnlNumeric.Controls.Add(btnSix, 2, 1)
        pnlNumeric.Controls.Add(btnMultiply, 3, 1)
        pnlNumeric.Controls.Add(btnOne, 0, 2)
        pnlNumeric.Controls.Add(btnTwo, 1, 2)
        pnlNumeric.Controls.Add(btnThree, 2, 2)
        pnlNumeric.Controls.Add(btnMinus, 3, 2)
        pnlNumeric.Controls.Add(btnZero, 0, 3)
        pnlNumeric.Controls.Add(btnDecimal, 1, 3)
        pnlNumeric.Controls.Add(btnEquals, 2, 3)
        pnlNumeric.Controls.Add(btnPlus, 3, 3)
        pnlNumeric.Dock = DockStyle.Fill
        pnlNumeric.Location = New Point(435, 11)
        pnlNumeric.Margin = New Padding(3)
        pnlNumeric.Name = "pnlNumeric"
        pnlNumeric.Padding = New Padding(4)
        pnlNumeric.RowCount = 4
        pnlNumeric.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0F))
        pnlNumeric.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0F))
        pnlNumeric.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0F))
        pnlNumeric.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0F))
        pnlNumeric.Size = New Size(292, 458)
        pnlNumeric.TabIndex = 1
        ' 
        ' btnSeven
        ' 
        btnSeven.BackColor = Color.White
        btnSeven.Dock = DockStyle.Fill
        btnSeven.FlatAppearance.BorderColor = Color.FromArgb(CByte(228), CByte(230), CByte(235))
        btnSeven.FlatStyle = FlatStyle.Flat
        btnSeven.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnSeven.ForeColor = Color.Black
        btnSeven.Location = New Point(7, 7)
        btnSeven.Margin = New Padding(3)
        btnSeven.Name = "btnSeven"
        btnSeven.Size = New Size(65, 106)
        btnSeven.TabIndex = 0
        btnSeven.Text = "7"
        btnSeven.UseVisualStyleBackColor = False
        ' 
        ' btnEight
        ' 
        btnEight.BackColor = Color.White
        btnEight.Dock = DockStyle.Fill
        btnEight.FlatAppearance.BorderColor = Color.FromArgb(CByte(228), CByte(230), CByte(235))
        btnEight.FlatStyle = FlatStyle.Flat
        btnEight.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnEight.ForeColor = Color.Black
        btnEight.Location = New Point(78, 7)
        btnEight.Margin = New Padding(3)
        btnEight.Name = "btnEight"
        btnEight.Size = New Size(65, 106)
        btnEight.TabIndex = 1
        btnEight.Text = "8"
        btnEight.UseVisualStyleBackColor = False
        ' 
        ' btnNine
        ' 
        btnNine.BackColor = Color.White
        btnNine.Dock = DockStyle.Fill
        btnNine.FlatAppearance.BorderColor = Color.FromArgb(CByte(228), CByte(230), CByte(235))
        btnNine.FlatStyle = FlatStyle.Flat
        btnNine.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnNine.ForeColor = Color.Black
        btnNine.Location = New Point(149, 7)
        btnNine.Margin = New Padding(3)
        btnNine.Name = "btnNine"
        btnNine.Size = New Size(65, 106)
        btnNine.TabIndex = 2
        btnNine.Text = "9"
        btnNine.UseVisualStyleBackColor = False
        ' 
        ' btnDivide
        ' 
        btnDivide.BackColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        btnDivide.Dock = DockStyle.Fill
        btnDivide.FlatAppearance.BorderColor = Color.FromArgb(CByte(220), CByte(224), CByte(230))
        btnDivide.FlatStyle = FlatStyle.Flat
        btnDivide.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnDivide.ForeColor = Color.Black
        btnDivide.Location = New Point(220, 7)
        btnDivide.Margin = New Padding(3)
        btnDivide.Name = "btnDivide"
        btnDivide.Size = New Size(65, 106)
        btnDivide.TabIndex = 3
        btnDivide.Text = "/"
        btnDivide.UseVisualStyleBackColor = False
        ' 
        ' btnFour
        ' 
        btnFour.BackColor = Color.White
        btnFour.Dock = DockStyle.Fill
        btnFour.FlatAppearance.BorderColor = Color.FromArgb(CByte(228), CByte(230), CByte(235))
        btnFour.FlatStyle = FlatStyle.Flat
        btnFour.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnFour.ForeColor = Color.Black
        btnFour.Location = New Point(7, 119)
        btnFour.Margin = New Padding(3)
        btnFour.Name = "btnFour"
        btnFour.Size = New Size(65, 106)
        btnFour.TabIndex = 4
        btnFour.Text = "4"
        btnFour.UseVisualStyleBackColor = False
        ' 
        ' btnFive
        ' 
        btnFive.BackColor = Color.White
        btnFive.Dock = DockStyle.Fill
        btnFive.FlatAppearance.BorderColor = Color.FromArgb(CByte(228), CByte(230), CByte(235))
        btnFive.FlatStyle = FlatStyle.Flat
        btnFive.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnFive.ForeColor = Color.Black
        btnFive.Location = New Point(78, 119)
        btnFive.Margin = New Padding(3)
        btnFive.Name = "btnFive"
        btnFive.Size = New Size(65, 106)
        btnFive.TabIndex = 5
        btnFive.Text = "5"
        btnFive.UseVisualStyleBackColor = False
        ' 
        ' btnSix
        ' 
        btnSix.BackColor = Color.White
        btnSix.Dock = DockStyle.Fill
        btnSix.FlatAppearance.BorderColor = Color.FromArgb(CByte(228), CByte(230), CByte(235))
        btnSix.FlatStyle = FlatStyle.Flat
        btnSix.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnSix.ForeColor = Color.Black
        btnSix.Location = New Point(149, 119)
        btnSix.Margin = New Padding(3)
        btnSix.Name = "btnSix"
        btnSix.Size = New Size(65, 106)
        btnSix.TabIndex = 6
        btnSix.Text = "6"
        btnSix.UseVisualStyleBackColor = False
        ' 
        ' btnMultiply
        ' 
        btnMultiply.BackColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        btnMultiply.Dock = DockStyle.Fill
        btnMultiply.FlatAppearance.BorderColor = Color.FromArgb(CByte(220), CByte(224), CByte(230))
        btnMultiply.FlatStyle = FlatStyle.Flat
        btnMultiply.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnMultiply.ForeColor = Color.Black
        btnMultiply.Location = New Point(220, 119)
        btnMultiply.Margin = New Padding(3)
        btnMultiply.Name = "btnMultiply"
        btnMultiply.Size = New Size(65, 106)
        btnMultiply.TabIndex = 7
        btnMultiply.Text = "*"
        btnMultiply.UseVisualStyleBackColor = False
        ' 
        ' btnOne
        ' 
        btnOne.BackColor = Color.White
        btnOne.Dock = DockStyle.Fill
        btnOne.FlatAppearance.BorderColor = Color.FromArgb(CByte(228), CByte(230), CByte(235))
        btnOne.FlatStyle = FlatStyle.Flat
        btnOne.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnOne.ForeColor = Color.Black
        btnOne.Location = New Point(7, 231)
        btnOne.Margin = New Padding(3)
        btnOne.Name = "btnOne"
        btnOne.Size = New Size(65, 106)
        btnOne.TabIndex = 8
        btnOne.Text = "1"
        btnOne.UseVisualStyleBackColor = False
        ' 
        ' btnTwo
        ' 
        btnTwo.BackColor = Color.White
        btnTwo.Dock = DockStyle.Fill
        btnTwo.FlatAppearance.BorderColor = Color.FromArgb(CByte(228), CByte(230), CByte(235))
        btnTwo.FlatStyle = FlatStyle.Flat
        btnTwo.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnTwo.ForeColor = Color.Black
        btnTwo.Location = New Point(78, 231)
        btnTwo.Margin = New Padding(3)
        btnTwo.Name = "btnTwo"
        btnTwo.Size = New Size(65, 106)
        btnTwo.TabIndex = 9
        btnTwo.Text = "2"
        btnTwo.UseVisualStyleBackColor = False
        ' 
        ' btnThree
        ' 
        btnThree.BackColor = Color.White
        btnThree.Dock = DockStyle.Fill
        btnThree.FlatAppearance.BorderColor = Color.FromArgb(CByte(228), CByte(230), CByte(235))
        btnThree.FlatStyle = FlatStyle.Flat
        btnThree.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnThree.ForeColor = Color.Black
        btnThree.Location = New Point(149, 231)
        btnThree.Margin = New Padding(3)
        btnThree.Name = "btnThree"
        btnThree.Size = New Size(65, 106)
        btnThree.TabIndex = 10
        btnThree.Text = "3"
        btnThree.UseVisualStyleBackColor = False
        ' 
        ' btnMinus
        ' 
        btnMinus.BackColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        btnMinus.Dock = DockStyle.Fill
        btnMinus.FlatAppearance.BorderColor = Color.FromArgb(CByte(220), CByte(224), CByte(230))
        btnMinus.FlatStyle = FlatStyle.Flat
        btnMinus.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnMinus.ForeColor = Color.Black
        btnMinus.Location = New Point(220, 231)
        btnMinus.Margin = New Padding(3)
        btnMinus.Name = "btnMinus"
        btnMinus.Size = New Size(65, 106)
        btnMinus.TabIndex = 11
        btnMinus.Text = "-"
        btnMinus.UseVisualStyleBackColor = False
        ' 
        ' btnZero
        ' 
        btnZero.BackColor = Color.White
        btnZero.Dock = DockStyle.Fill
        btnZero.FlatAppearance.BorderColor = Color.FromArgb(CByte(228), CByte(230), CByte(235))
        btnZero.FlatStyle = FlatStyle.Flat
        btnZero.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnZero.ForeColor = Color.Black
        btnZero.Location = New Point(7, 343)
        btnZero.Margin = New Padding(3)
        btnZero.Name = "btnZero"
        btnZero.Size = New Size(65, 108)
        btnZero.TabIndex = 12
        btnZero.Text = "0"
        btnZero.UseVisualStyleBackColor = False
        ' 
        ' btnDecimal
        ' 
        btnDecimal.BackColor = Color.White
        btnDecimal.Dock = DockStyle.Fill
        btnDecimal.FlatAppearance.BorderColor = Color.FromArgb(CByte(228), CByte(230), CByte(235))
        btnDecimal.FlatStyle = FlatStyle.Flat
        btnDecimal.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnDecimal.ForeColor = Color.Black
        btnDecimal.Location = New Point(78, 343)
        btnDecimal.Margin = New Padding(3)
        btnDecimal.Name = "btnDecimal"
        btnDecimal.Size = New Size(65, 108)
        btnDecimal.TabIndex = 13
        btnDecimal.Text = "."
        btnDecimal.UseVisualStyleBackColor = False
        ' 
        ' btnEquals
        ' 
        btnEquals.BackColor = Color.FromArgb(CByte(168), CByte(216), CByte(185))
        btnEquals.Dock = DockStyle.Fill
        btnEquals.FlatAppearance.BorderSize = 0
        btnEquals.FlatStyle = FlatStyle.Flat
        btnEquals.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnEquals.ForeColor = Color.FromArgb(CByte(20), CByte(50), CByte(25))
        btnEquals.Location = New Point(149, 343)
        btnEquals.Margin = New Padding(3)
        btnEquals.Name = "btnEquals"
        btnEquals.Size = New Size(65, 108)
        btnEquals.TabIndex = 14
        btnEquals.Text = "="
        btnEquals.UseVisualStyleBackColor = False
        ' 
        ' btnPlus
        ' 
        btnPlus.BackColor = Color.FromArgb(CByte(236), CByte(239), CByte(244))
        btnPlus.Dock = DockStyle.Fill
        btnPlus.FlatAppearance.BorderColor = Color.FromArgb(CByte(220), CByte(224), CByte(230))
        btnPlus.FlatStyle = FlatStyle.Flat
        btnPlus.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnPlus.ForeColor = Color.Black
        btnPlus.Location = New Point(220, 343)
        btnPlus.Margin = New Padding(3)
        btnPlus.Name = "btnPlus"
        btnPlus.Size = New Size(65, 108)
        btnPlus.TabIndex = 15
        btnPlus.Text = "+"
        btnPlus.UseVisualStyleBackColor = False
        ' 
        ' pnlHistory
        ' 
        pnlHistory.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        pnlHistory.BorderStyle = BorderStyle.FixedSingle
        pnlHistory.Controls.Add(lstHistory)
        pnlHistory.Controls.Add(lblHistoryHeader)
        pnlHistory.Controls.Add(btnClearHistory)
        pnlHistory.Dock = DockStyle.Fill
        pnlHistory.Location = New Point(733, 11)
        pnlHistory.Margin = New Padding(3)
        pnlHistory.Name = "pnlHistory"
        pnlHistory.Padding = New Padding(6)
        pnlHistory.Size = New Size(176, 458)
        pnlHistory.TabIndex = 2
        ' 
        ' lblHistoryHeader
        ' 
        lblHistoryHeader.Dock = DockStyle.Top
        lblHistoryHeader.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        lblHistoryHeader.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        lblHistoryHeader.Location = New Point(6, 6)
        lblHistoryHeader.Name = "lblHistoryHeader"
        lblHistoryHeader.Size = New Size(162, 30)
        lblHistoryHeader.TabIndex = 0
        lblHistoryHeader.Text = "History"
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
        lstHistory.Location = New Point(6, 36)
        lstHistory.Name = "lstHistory"
        lstHistory.Size = New Size(162, 380)
        lstHistory.TabIndex = 1
        ' 
        ' btnClearHistory
        ' 
        btnClearHistory.Dock = DockStyle.Bottom
        btnClearHistory.FlatStyle = FlatStyle.Flat
        btnClearHistory.Font = New Font("Segoe UI", 9.0F)
        btnClearHistory.ForeColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        btnClearHistory.Location = New Point(6, 416)
        btnClearHistory.Name = "btnClearHistory"
        btnClearHistory.Size = New Size(162, 34)
        btnClearHistory.TabIndex = 2
        btnClearHistory.Text = "🗑 Clear History"
        btnClearHistory.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(242), CByte(243), CByte(245))
        ClientSize = New Size(920, 640)
        Controls.Add(pnlKeypad)
        Controls.Add(pnlDisplay)
        FormBorderStyle = FormBorderStyle.FixedDialog
        KeyPreview = True
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Scientific Calculator"
        pnlDisplay.ResumeLayout(False)
        pnlDisplay.PerformLayout()
        pnlMemory.ResumeLayout(False)
        pnlMemory.PerformLayout()
        pnlKeypad.ResumeLayout(False)
        pnlScientific.ResumeLayout(False)
        pnlNumeric.ResumeLayout(False)
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
    Friend WithEvents pnlScientific As TableLayoutPanel
    Friend WithEvents pnlNumeric As TableLayoutPanel
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
