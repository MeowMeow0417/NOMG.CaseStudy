<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        btnNext = New Button()
        btnCancel = New Button()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtName = New TextBox()
        txtLastName = New TextBox()
        txtMI = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        txtAge = New TextBox()
        txtGender = New TextBox()
        txtAddress = New TextBox()
        txtCivil = New TextBox()
        txtBaby = New TextBox()
        Label10 = New Label()
        txtLMC = New TextBox()
        Label11 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.HotPink
        btnNext.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNext.Location = New Point(497, 351)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(90, 34)
        btnNext.TabIndex = 1
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.HotPink
        btnCancel.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.Location = New Point(296, 351)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(94, 34)
        btnCancel.TabIndex = 4
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(781, -1)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(102, 102)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(283, 104)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 19)
        Label1.TabIndex = 13
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(283, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 19)
        Label2.TabIndex = 14
        Label2.Text = "Last Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(487, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(34, 19)
        Label3.TabIndex = 15
        Label3.Text = "M.I:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(283, 157)
        Label4.Name = "Label4"
        Label4.Size = New Size(40, 19)
        Label4.TabIndex = 16
        Label4.Text = "Age:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(427, 160)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 19)
        Label5.TabIndex = 17
        Label5.Text = "Gender:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(283, 218)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 19)
        Label6.TabIndex = 18
        Label6.Text = "Civil Status:"
        ' 
        ' txtName
        ' 
        txtName.BackColor = SystemColors.ScrollBar
        txtName.Location = New Point(342, 103)
        txtName.Margin = New Padding(3, 2, 3, 2)
        txtName.Name = "txtName"
        txtName.Size = New Size(140, 23)
        txtName.TabIndex = 19
        ' 
        ' txtLastName
        ' 
        txtLastName.BackColor = SystemColors.ScrollBar
        txtLastName.Location = New Point(366, 127)
        txtLastName.Margin = New Padding(3, 2, 3, 2)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(225, 23)
        txtLastName.TabIndex = 20
        ' 
        ' txtMI
        ' 
        txtMI.BackColor = SystemColors.ScrollBar
        txtMI.Location = New Point(528, 104)
        txtMI.Margin = New Padding(3, 2, 3, 2)
        txtMI.Name = "txtMI"
        txtMI.Size = New Size(63, 23)
        txtMI.TabIndex = 21
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(283, 189)
        Label7.Name = "Label7"
        Label7.Size = New Size(67, 19)
        Label7.TabIndex = 22
        Label7.Text = "Address:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(286, 260)
        Label8.Name = "Label8"
        Label8.Size = New Size(79, 19)
        Label8.TabIndex = 23
        Label8.Text = "First Baby:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(286, 248)
        Label9.Name = "Label9"
        Label9.Size = New Size(102, 13)
        Label9.TabIndex = 24
        Label9.Text = "(State if, yes or no)"
        ' 
        ' txtAge
        ' 
        txtAge.BackColor = SystemColors.ScrollBar
        txtAge.Location = New Point(329, 157)
        txtAge.Margin = New Padding(3, 2, 3, 2)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(93, 23)
        txtAge.TabIndex = 25
        ' 
        ' txtGender
        ' 
        txtGender.BackColor = SystemColors.ScrollBar
        txtGender.Location = New Point(497, 156)
        txtGender.Margin = New Padding(3, 2, 3, 2)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(94, 23)
        txtGender.TabIndex = 26
        ' 
        ' txtAddress
        ' 
        txtAddress.BackColor = SystemColors.ScrollBar
        txtAddress.Location = New Point(357, 186)
        txtAddress.Margin = New Padding(3, 2, 3, 2)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(234, 23)
        txtAddress.TabIndex = 27
        ' 
        ' txtCivil
        ' 
        txtCivil.BackColor = SystemColors.ScrollBar
        txtCivil.Location = New Point(380, 214)
        txtCivil.Margin = New Padding(3, 2, 3, 2)
        txtCivil.Name = "txtCivil"
        txtCivil.Size = New Size(211, 23)
        txtCivil.TabIndex = 28
        ' 
        ' txtBaby
        ' 
        txtBaby.BackColor = SystemColors.ScrollBar
        txtBaby.Location = New Point(380, 262)
        txtBaby.Margin = New Padding(3, 2, 3, 2)
        txtBaby.Name = "txtBaby"
        txtBaby.Size = New Size(211, 23)
        txtBaby.TabIndex = 29
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(159, 295)
        Label10.Name = "Label10"
        Label10.Size = New Size(199, 19)
        Label10.TabIndex = 30
        Label10.Text = "Date of last Menstrual Cycle:"
        ' 
        ' txtLMC
        ' 
        txtLMC.BackColor = SystemColors.ScrollBar
        txtLMC.Location = New Point(374, 292)
        txtLMC.Margin = New Padding(3, 2, 3, 2)
        txtLMC.Name = "txtLMC"
        txtLMC.Size = New Size(217, 23)
        txtLMC.TabIndex = 31
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(168, 282)
        Label11.Name = "Label11"
        Label11.Size = New Size(195, 13)
        Label11.TabIndex = 32
        Label11.Text = "State this in weeks (Just the number)"
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(884, 561)
        Controls.Add(Label11)
        Controls.Add(txtLMC)
        Controls.Add(Label10)
        Controls.Add(txtBaby)
        Controls.Add(txtCivil)
        Controls.Add(txtAddress)
        Controls.Add(txtGender)
        Controls.Add(txtAge)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(txtMI)
        Controls.Add(txtLastName)
        Controls.Add(txtName)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(btnCancel)
        Controls.Add(btnNext)
        Name = "Form6"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NOMG CLINIC (PATIENTS DETAILS)"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnNext As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtMI As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCivil As TextBox
    Friend WithEvents txtBaby As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtLMC As TextBox
    Friend WithEvents Label11 As Label
End Class
