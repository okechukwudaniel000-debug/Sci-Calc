<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it from the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ' Standard buttons
        btnDecimal = New Button()
        btnClear = New Button()
        btnOne = New Button()
        btnTwo = New Button()
        btnThree = New Button()
        btnFour = New Button()
        btnFive = New Button()
        btnSix = New Button()
        btnSeven = New Button()
        btnEight = New Button()
        btnNine = New Button()
        btnZero = New Button()
        btnPlus = New Button()
        btnMinus = New Button()
        btnMultiply = New Button()
        btnDivide = New Button()
        btnEquals = New Button()
        btnDelete = New Button()
        
        ' Scientific buttons
        btnDegRad = New Button()
        lblMode = New Label()
        btnOpenBracket = New Button()
        btnCloseBracket = New Button()
        btnSin = New Button()
        btnCos = New Button()
        btnTan = New Button()
        btnSqrt = New Button()
        btnSquare = New Button()
        btnPower = New Button()
        btnLog = New Button()
        btnLn = New Button()
        btnPi = New Button()
        btnE = New Button()
        
        txtDisplay = New RichTextBox()
        SuspendLayout()
        
        ' 
        ' lblMode
        ' 
        lblMode.AutoSize = True
        lblMode.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblMode.ForeColor = Color.FromArgb(0, 150, 255)
        lblMode.Location = New Point(48, 18)
        lblMode.Name = "lblMode"
        lblMode.Size = New Size(50, 25)
        lblMode.TabIndex = 32
        lblMode.Text = "DEG"
        ' 
        ' btnDegRad
        ' 
        btnDegRad.BackColor = Color.FromArgb(60, 60, 60)
        btnDegRad.FlatAppearance.BorderSize = 0
        btnDegRad.FlatStyle = FlatStyle.Flat
        btnDegRad.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        btnDegRad.ForeColor = Color.White
        btnDegRad.Location = New Point(110, 12)
        btnDegRad.Name = "btnDegRad"
        btnDegRad.Size = New Size(100, 32)
        btnDegRad.TabIndex = 33
        btnDegRad.Text = "DEG / RAD"
        btnDegRad.UseVisualStyleBackColor = False
        ' 
        ' txtDisplay
        ' 
        txtDisplay.BackColor = Color.FromArgb(32, 32, 32)
        txtDisplay.BorderStyle = BorderStyle.None
        txtDisplay.Font = New Font("Segoe UI Semibold", 28F, FontStyle.Bold)
        txtDisplay.ForeColor = Color.White
        txtDisplay.Location = New Point(48, 50)
        txtDisplay.Name = "txtDisplay"
        txtDisplay.ReadOnly = True
        txtDisplay.ScrollBars = RichTextBoxScrollBars.None
        txtDisplay.Size = New Size(850, 100)
        txtDisplay.TabIndex = 1
        txtDisplay.Text = "0"
        txtDisplay.SelectionAlignment = HorizontalAlignment.Right        
        ' Row 1: Scientific Functions (Trig and Brackets)
        ' btnOpenBracket
        btnOpenBracket.BackColor = Color.FromArgb(80, 80, 80)
        btnOpenBracket.FlatAppearance.BorderSize = 0
        btnOpenBracket.FlatStyle = FlatStyle.Flat
        btnOpenBracket.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        btnOpenBracket.ForeColor = Color.White
        btnOpenBracket.Location = New Point(48, 180)
        btnOpenBracket.Name = "btnOpenBracket"
        btnOpenBracket.Size = New Size(65, 65)
        btnOpenBracket.TabIndex = 20
        btnOpenBracket.Text = "("
        btnOpenBracket.UseVisualStyleBackColor = False
        
        ' btnCloseBracket
        btnCloseBracket.BackColor = Color.FromArgb(80, 80, 80)
        btnCloseBracket.FlatAppearance.BorderSize = 0
        btnCloseBracket.FlatStyle = FlatStyle.Flat
        btnCloseBracket.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        btnCloseBracket.ForeColor = Color.White
        btnCloseBracket.Location = New Point(119, 180)
        btnCloseBracket.Name = "btnCloseBracket"
        btnCloseBracket.Size = New Size(65, 65)
        btnCloseBracket.TabIndex = 21
        btnCloseBracket.Text = ")"
        btnCloseBracket.UseVisualStyleBackColor = False
        
        ' btnSin
        btnSin.BackColor = Color.FromArgb(100, 150, 255)
        btnSin.FlatAppearance.BorderSize = 0
        btnSin.FlatStyle = FlatStyle.Flat
        btnSin.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        btnSin.ForeColor = Color.White
        btnSin.Location = New Point(190, 180)
        btnSin.Name = "btnSin"
        btnSin.Size = New Size(65, 65)
        btnSin.TabIndex = 22
        btnSin.Text = "sin"
        btnSin.UseVisualStyleBackColor = False
        
        ' btnCos
        btnCos.BackColor = Color.FromArgb(100, 150, 255)
        btnCos.FlatAppearance.BorderSize = 0
        btnCos.FlatStyle = FlatStyle.Flat
        btnCos.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        btnCos.ForeColor = Color.White
        btnCos.Location = New Point(261, 180)
        btnCos.Name = "btnCos"
        btnCos.Size = New Size(65, 65)
        btnCos.TabIndex = 23
        btnCos.Text = "cos"
        btnCos.UseVisualStyleBackColor = False
        
        ' btnTan
        btnTan.BackColor = Color.FromArgb(100, 150, 255)
        btnTan.FlatAppearance.BorderSize = 0
        btnTan.FlatStyle = FlatStyle.Flat
        btnTan.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        btnTan.ForeColor = Color.White
        btnTan.Location = New Point(332, 180)
        btnTan.Name = "btnTan"
        btnTan.Size = New Size(65, 65)
        btnTan.TabIndex = 24
        btnTan.Text = "tan"
        btnTan.UseVisualStyleBackColor = False
        
        ' btnSqrt
        btnSqrt.BackColor = Color.FromArgb(150, 200, 100)
        btnSqrt.FlatAppearance.BorderSize = 0
        btnSqrt.FlatStyle = FlatStyle.Flat
        btnSqrt.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        btnSqrt.ForeColor = Color.White
        btnSqrt.Location = New Point(403, 180)
        btnSqrt.Name = "btnSqrt"
        btnSqrt.Size = New Size(65, 65)
        btnSqrt.TabIndex = 25
        btnSqrt.Text = "√"
        btnSqrt.UseVisualStyleBackColor = False
        
        ' btnSquare
        btnSquare.BackColor = Color.FromArgb(150, 200, 100)
        btnSquare.FlatAppearance.BorderSize = 0
        btnSquare.FlatStyle = FlatStyle.Flat
        btnSquare.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        btnSquare.ForeColor = Color.White
        btnSquare.Location = New Point(474, 180)
        btnSquare.Name = "btnSquare"
        btnSquare.Size = New Size(65, 65)
        btnSquare.TabIndex = 26
        btnSquare.Text = "x²"
        btnSquare.UseVisualStyleBackColor = False
        
        ' btnPower
        btnPower.BackColor = Color.FromArgb(150, 200, 100)
        btnPower.FlatAppearance.BorderSize = 0
        btnPower.FlatStyle = FlatStyle.Flat
        btnPower.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        btnPower.ForeColor = Color.White
        btnPower.Location = New Point(545, 180)
        btnPower.Name = "btnPower"
        btnPower.Size = New Size(65, 65)
        btnPower.TabIndex = 27
        btnPower.Text = "x^y"
        btnPower.UseVisualStyleBackColor = False
        
        ' btnLog
        btnLog.BackColor = Color.FromArgb(200, 150, 100)
        btnLog.FlatAppearance.BorderSize = 0
        btnLog.FlatStyle = FlatStyle.Flat
        btnLog.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        btnLog.ForeColor = Color.White
        btnLog.Location = New Point(616, 180)
        btnLog.Name = "btnLog"
        btnLog.Size = New Size(65, 65)
        btnLog.TabIndex = 28
        btnLog.Text = "log"
        btnLog.UseVisualStyleBackColor = False
        
        ' btnLn
        btnLn.BackColor = Color.FromArgb(200, 150, 100)
        btnLn.FlatAppearance.BorderSize = 0
        btnLn.FlatStyle = FlatStyle.Flat
        btnLn.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        btnLn.ForeColor = Color.White
        btnLn.Location = New Point(687, 180)
        btnLn.Name = "btnLn"
        btnLn.Size = New Size(65, 65)
        btnLn.TabIndex = 29
        btnLn.Text = "ln"
        btnLn.UseVisualStyleBackColor = False
        
        ' btnPi
        btnPi.BackColor = Color.FromArgb(200, 100, 150)
        btnPi.FlatAppearance.BorderSize = 0
        btnPi.FlatStyle = FlatStyle.Flat
        btnPi.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        btnPi.ForeColor = Color.White
        btnPi.Location = New Point(758, 180)
        btnPi.Name = "btnPi"
        btnPi.Size = New Size(65, 65)
        btnPi.TabIndex = 30
        btnPi.Text = "π"
        btnPi.UseVisualStyleBackColor = False
        
        ' btnE
        btnE.BackColor = Color.FromArgb(200, 100, 150)
        btnE.FlatAppearance.BorderSize = 0
        btnE.FlatStyle = FlatStyle.Flat
        btnE.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        btnE.ForeColor = Color.White
        btnE.Location = New Point(829, 180)
        btnE.Name = "btnE"
        btnE.Size = New Size(65, 65)
        btnE.TabIndex = 31
        btnE.Text = "e"
        btnE.UseVisualStyleBackColor = False        
        ' Row 2: Numbers 7, 8, 9 and operators
        ' btnSeven
        btnSeven.BackColor = Color.FromArgb(45, 45, 45)
        btnSeven.FlatAppearance.BorderSize = 0
        btnSeven.FlatStyle = FlatStyle.Flat
        btnSeven.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnSeven.ForeColor = Color.White
        btnSeven.Location = New Point(48, 261)
        btnSeven.Name = "btnSeven"
        btnSeven.Size = New Size(65, 65)
        btnSeven.TabIndex = 10
        btnSeven.Text = "7"
        btnSeven.UseVisualStyleBackColor = False
        
        ' btnEight
        btnEight.BackColor = Color.FromArgb(45, 45, 45)
        btnEight.FlatAppearance.BorderSize = 0
        btnEight.FlatStyle = FlatStyle.Flat
        btnEight.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnEight.ForeColor = Color.White
        btnEight.Location = New Point(119, 261)
        btnEight.Name = "btnEight"
        btnEight.Size = New Size(65, 65)
        btnEight.TabIndex = 11
        btnEight.Text = "8"
        btnEight.UseVisualStyleBackColor = False
        
        ' btnNine
        btnNine.BackColor = Color.FromArgb(45, 45, 45)
        btnNine.FlatAppearance.BorderSize = 0
        btnNine.FlatStyle = FlatStyle.Flat
        btnNine.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnNine.ForeColor = Color.White
        btnNine.Location = New Point(190, 261)
        btnNine.Name = "btnNine"
        btnNine.Size = New Size(65, 65)
        btnNine.TabIndex = 12
        btnNine.Text = "9"
        btnNine.UseVisualStyleBackColor = False
        
        ' btnMultiply
        btnMultiply.BackColor = Color.FromArgb(255, 159, 10)
        btnMultiply.FlatAppearance.BorderSize = 0
        btnMultiply.FlatStyle = FlatStyle.Flat
        btnMultiply.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnMultiply.ForeColor = Color.White
        btnMultiply.Location = New Point(261, 261)
        btnMultiply.Name = "btnMultiply"
        btnMultiply.Size = New Size(65, 65)
        btnMultiply.TabIndex = 16
        btnMultiply.Text = "*"
        btnMultiply.UseVisualStyleBackColor = False
        
        ' btnDivide
        btnDivide.BackColor = Color.FromArgb(255, 159, 10)
        btnDivide.FlatAppearance.BorderSize = 0
        btnDivide.FlatStyle = FlatStyle.Flat
        btnDivide.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnDivide.ForeColor = Color.White
        btnDivide.Location = New Point(332, 261)
        btnDivide.Name = "btnDivide"
        btnDivide.Size = New Size(65, 65)
        btnDivide.TabIndex = 17
        btnDivide.Text = "/"
        btnDivide.UseVisualStyleBackColor = False
        
        ' Row 3: Numbers 4, 5, 6 and minus
        ' btnFour
        btnFour.BackColor = Color.FromArgb(45, 45, 45)
        btnFour.FlatAppearance.BorderSize = 0
        btnFour.FlatStyle = FlatStyle.Flat
        btnFour.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnFour.ForeColor = Color.White
        btnFour.Location = New Point(48, 342)
        btnFour.Name = "btnFour"
        btnFour.Size = New Size(65, 65)
        btnFour.TabIndex = 7
        btnFour.Text = "4"
        btnFour.UseVisualStyleBackColor = False
        
        ' btnFive
        btnFive.BackColor = Color.FromArgb(45, 45, 45)
        btnFive.FlatAppearance.BorderSize = 0
        btnFive.FlatStyle = FlatStyle.Flat
        btnFive.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnFive.ForeColor = Color.White
        btnFive.Location = New Point(119, 342)
        btnFive.Name = "btnFive"
        btnFive.Size = New Size(65, 65)
        btnFive.TabIndex = 8
        btnFive.Text = "5"
        btnFive.UseVisualStyleBackColor = False
        
        ' btnSix
        btnSix.BackColor = Color.FromArgb(45, 45, 45)
        btnSix.FlatAppearance.BorderSize = 0
        btnSix.FlatStyle = FlatStyle.Flat
        btnSix.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnSix.ForeColor = Color.White
        btnSix.Location = New Point(190, 342)
        btnSix.Name = "btnSix"
        btnSix.Size = New Size(65, 65)
        btnSix.TabIndex = 9
        btnSix.Text = "6"
        btnSix.UseVisualStyleBackColor = False
        
        ' btnMinus
        btnMinus.BackColor = Color.FromArgb(255, 159, 10)
        btnMinus.FlatAppearance.BorderSize = 0
        btnMinus.FlatStyle = FlatStyle.Flat
        btnMinus.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnMinus.ForeColor = Color.White
        btnMinus.Location = New Point(261, 342)
        btnMinus.Name = "btnMinus"
        btnMinus.Size = New Size(65, 65)
        btnMinus.TabIndex = 15
        btnMinus.Text = "-"
        btnMinus.UseVisualStyleBackColor = False        
        ' Row 4: Numbers 1, 2, 3 and plus
        ' btnOne
        btnOne.BackColor = Color.FromArgb(45, 45, 45)
        btnOne.FlatAppearance.BorderSize = 0
        btnOne.FlatStyle = FlatStyle.Flat
        btnOne.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnOne.ForeColor = Color.White
        btnOne.Location = New Point(48, 423)
        btnOne.Name = "btnOne"
        btnOne.Size = New Size(65, 65)
        btnOne.TabIndex = 4
        btnOne.Text = "1"
        btnOne.UseVisualStyleBackColor = False
        
        ' btnTwo
        btnTwo.BackColor = Color.FromArgb(45, 45, 45)
        btnTwo.FlatAppearance.BorderSize = 0
        btnTwo.FlatStyle = FlatStyle.Flat
        btnTwo.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnTwo.ForeColor = Color.White
        btnTwo.Location = New Point(119, 423)
        btnTwo.Name = "btnTwo"
        btnTwo.Size = New Size(65, 65)
        btnTwo.TabIndex = 5
        btnTwo.Text = "2"
        btnTwo.UseVisualStyleBackColor = False
        
        ' btnThree
        btnThree.BackColor = Color.FromArgb(45, 45, 45)
        btnThree.FlatAppearance.BorderSize = 0
        btnThree.FlatStyle = FlatStyle.Flat
        btnThree.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnThree.ForeColor = Color.White
        btnThree.Location = New Point(190, 423)
        btnThree.Name = "btnThree"
        btnThree.Size = New Size(65, 65)
        btnThree.TabIndex = 6
        btnThree.Text = "3"
        btnThree.UseVisualStyleBackColor = False
        
        ' btnPlus
        btnPlus.BackColor = Color.FromArgb(255, 159, 10)
        btnPlus.FlatAppearance.BorderSize = 0
        btnPlus.FlatStyle = FlatStyle.Flat
        btnPlus.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnPlus.ForeColor = Color.White
        btnPlus.Location = New Point(261, 423)
        btnPlus.Name = "btnPlus"
        btnPlus.Size = New Size(65, 65)
        btnPlus.TabIndex = 14
        btnPlus.Text = "+"
        btnPlus.UseVisualStyleBackColor = False
        
        ' Row 5: 0, decimal, clear, delete
        ' btnZero
        btnZero.BackColor = Color.FromArgb(45, 45, 45)
        btnZero.FlatAppearance.BorderSize = 0
        btnZero.FlatStyle = FlatStyle.Flat
        btnZero.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnZero.ForeColor = Color.White
        btnZero.Location = New Point(48, 504)
        btnZero.Name = "btnZero"
        btnZero.Size = New Size(65, 65)
        btnZero.TabIndex = 13
        btnZero.Text = "0"
        btnZero.UseVisualStyleBackColor = False
        
        ' btnDecimal
        btnDecimal.BackColor = Color.FromArgb(64, 64, 64)
        btnDecimal.FlatAppearance.BorderSize = 0
        btnDecimal.FlatStyle = FlatStyle.Flat
        btnDecimal.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnDecimal.ForeColor = Color.White
        btnDecimal.Location = New Point(119, 504)
        btnDecimal.Name = "btnDecimal"
        btnDecimal.Size = New Size(65, 65)
        btnDecimal.TabIndex = 2
        btnDecimal.Text = "."
        btnDecimal.UseVisualStyleBackColor = False
        
        ' btnClear
        btnClear.BackColor = Color.IndianRed
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(190, 504)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(65, 65)
        btnClear.TabIndex = 3
        btnClear.Text = "C"
        btnClear.UseVisualStyleBackColor = False
        
        ' btnDelete
        btnDelete.BackColor = Color.FromArgb(75, 75, 75)
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(261, 504)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(65, 65)
        btnDelete.TabIndex = 19
        btnDelete.Text = "⌫"
        btnDelete.UseVisualStyleBackColor = False
        
        ' btnEquals
        btnEquals.BackColor = Color.FromArgb(0, 122, 255)
        btnEquals.FlatAppearance.BorderSize = 0
        btnEquals.FlatStyle = FlatStyle.Flat
        btnEquals.Font = New Font("Segoe UI Semibold", 22.2F, FontStyle.Bold)
        btnEquals.ForeColor = Color.White
        btnEquals.Location = New Point(403, 423)
        btnEquals.Name = "btnEquals"
        btnEquals.Size = New Size(491, 146)
        btnEquals.TabIndex = 18
        btnEquals.Text = "="
        btnEquals.UseVisualStyleBackColor = False        
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(28, 28, 28)
        ClientSize = New Size(950, 600)
        Controls.Add(lblMode)
        Controls.Add(btnDegRad)
        Controls.Add(txtDisplay)
        Controls.Add(btnOpenBracket)
        Controls.Add(btnCloseBracket)
        Controls.Add(btnSin)
        Controls.Add(btnCos)
        Controls.Add(btnTan)
        Controls.Add(btnSqrt)
        Controls.Add(btnSquare)
        Controls.Add(btnPower)
        Controls.Add(btnLog)
        Controls.Add(btnLn)
        Controls.Add(btnPi)
        Controls.Add(btnE)
        Controls.Add(btnDivide)
        Controls.Add(btnNine)
        Controls.Add(btnMultiply)
        Controls.Add(btnSix)
        Controls.Add(btnMinus)
        Controls.Add(btnThree)
        Controls.Add(btnPlus)
        Controls.Add(btnClear)
        Controls.Add(btnEight)
        Controls.Add(btnSeven)
        Controls.Add(btnFive)
        Controls.Add(btnFour)
        Controls.Add(btnTwo)
        Controls.Add(btnOne)
        Controls.Add(btnDelete)
        Controls.Add(btnEquals)
        Controls.Add(btnZero)
        Controls.Add(btnDecimal)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Scientific Calculator"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnDecimal As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnOne As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnThree As Button
    Friend WithEvents btnFour As Button
    Friend WithEvents btnFive As Button
    Friend WithEvents btnSix As Button
    Friend WithEvents btnSeven As Button
    Friend WithEvents btnEight As Button
    Friend WithEvents btnNine As Button
    Friend WithEvents btnZero As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnEquals As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtDisplay As RichTextBox
    Friend WithEvents btnOpenBracket As Button
    Friend WithEvents btnCloseBracket As Button
    Friend WithEvents btnSin As Button
    Friend WithEvents btnCos As Button
    Friend WithEvents btnTan As Button
    Friend WithEvents btnSqrt As Button
    Friend WithEvents btnSquare As Button
    Friend WithEvents btnPower As Button
    Friend WithEvents btnLog As Button
    Friend WithEvents btnLn As Button
    Friend WithEvents btnPi As Button
    Friend WithEvents btnE As Button
    Friend WithEvents btnDegRad As Button
    Friend WithEvents lblMode As Label

End Class