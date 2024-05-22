<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientInput
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientInput))
        btnNext = New Button()
        btnCancel = New Button()
        Label6 = New Label()
        txtAddress = New TextBox()
        txtGender = New TextBox()
        Label5 = New Label()
        GroupBox2 = New GroupBox()
        txtLMC = New TextBox()
        Label9 = New Label()
        txtCivil = New TextBox()
        txtAge = New TextBox()
        Label4 = New Label()
        Label8 = New Label()
        GroupBox3 = New GroupBox()
        txtBaby = New TextBox()
        Label10 = New Label()
        txtLastName = New TextBox()
        Label3 = New Label()
        Label11 = New Label()
        Label7 = New Label()
        txtMI = New TextBox()
        txtName = New TextBox()
        txtVitamin = New TextBox()
        Label2 = New Label()
        gbInfo = New GroupBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        PictureBox1 = New PictureBox()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        gbInfo.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.HotPink
        btnNext.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnNext.Location = New Point(433, 508)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(114, 43)
        btnNext.TabIndex = 1
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.HotPink
        btnCancel.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnCancel.Location = New Point(274, 508)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(115, 43)
        btnCancel.TabIndex = 4
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label6.Location = New Point(13, 123)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 17)
        Label6.TabIndex = 4
        Label6.Text = "Address:"
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(79, 126)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(309, 25)
        txtAddress.TabIndex = 20
        ' 
        ' txtGender
        ' 
        txtGender.Location = New Point(247, 95)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(141, 25)
        txtGender.TabIndex = 19
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label5.Location = New Point(13, 154)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 17)
        Label5.TabIndex = 3
        Label5.Text = "Civil Status:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtLMC)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Location = New Point(13, 244)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(375, 50)
        GroupBox2.TabIndex = 10
        GroupBox2.TabStop = False
        GroupBox2.Text = "State as yyyy/mm/dd"
        ' 
        ' txtLMC
        ' 
        txtLMC.Location = New Point(200, 16)
        txtLMC.Name = "txtLMC"
        txtLMC.Size = New Size(166, 25)
        txtLMC.TabIndex = 10
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(11, 19)
        Label9.Name = "Label9"
        Label9.Size = New Size(183, 17)
        Label9.TabIndex = 9
        Label9.Text = "Date of Last Menstrual Cycle:"
        ' 
        ' txtCivil
        ' 
        txtCivil.Location = New Point(96, 157)
        txtCivil.Name = "txtCivil"
        txtCivil.Size = New Size(292, 25)
        txtCivil.TabIndex = 21
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(54, 95)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(125, 25)
        txtAge.TabIndex = 18
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(185, 92)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 17)
        Label4.TabIndex = 2
        Label4.Text = "Gender:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label8.Location = New Point(207, 30)
        Label8.Name = "Label8"
        Label8.Size = New Size(33, 17)
        Label8.TabIndex = 11
        Label8.Text = "M.I.:"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(txtBaby)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Location = New Point(13, 188)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(375, 50)
        GroupBox3.TabIndex = 23
        GroupBox3.TabStop = False
        GroupBox3.Text = "state if, yes or no"
        ' 
        ' txtBaby
        ' 
        txtBaby.Location = New Point(88, 19)
        txtBaby.Name = "txtBaby"
        txtBaby.Size = New Size(281, 25)
        txtBaby.TabIndex = 22
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(11, 19)
        Label10.Name = "Label10"
        Label10.Size = New Size(71, 17)
        Label10.TabIndex = 9
        Label10.Text = "First Baby:"
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(94, 64)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(294, 25)
        txtLastName.TabIndex = 17
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(13, 92)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 17)
        Label3.TabIndex = 1
        Label3.Text = "Age:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label11.Location = New Point(13, 61)
        Label11.Name = "Label11"
        Label11.Size = New Size(75, 17)
        Label11.TabIndex = 14
        Label11.Text = "Last Name:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label7.Location = New Point(13, 297)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 17)
        Label7.TabIndex = 25
        Label7.Text = "Vitamin Intake:"
        ' 
        ' txtMI
        ' 
        txtMI.Location = New Point(246, 33)
        txtMI.Name = "txtMI"
        txtMI.Size = New Size(142, 25)
        txtMI.TabIndex = 16
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(66, 33)
        txtName.Name = "txtName"
        txtName.Size = New Size(135, 25)
        txtName.TabIndex = 15
        ' 
        ' txtVitamin
        ' 
        txtVitamin.HideSelection = False
        txtVitamin.Location = New Point(118, 300)
        txtVitamin.Multiline = True
        txtVitamin.Name = "txtVitamin"
        txtVitamin.Size = New Size(221, 143)
        txtVitamin.TabIndex = 26
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(13, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 17)
        Label2.TabIndex = 0
        Label2.Text = "Name:"
        ' 
        ' gbInfo
        ' 
        gbInfo.Controls.Add(FlowLayoutPanel1)
        gbInfo.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        gbInfo.Location = New Point(217, 12)
        gbInfo.Name = "gbInfo"
        gbInfo.Size = New Size(420, 490)
        gbInfo.TabIndex = 2
        gbInfo.TabStop = False
        gbInfo.Text = "Patients Info:"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(Label2)
        FlowLayoutPanel1.Controls.Add(txtName)
        FlowLayoutPanel1.Controls.Add(Label8)
        FlowLayoutPanel1.Controls.Add(txtMI)
        FlowLayoutPanel1.Controls.Add(Label11)
        FlowLayoutPanel1.Controls.Add(txtLastName)
        FlowLayoutPanel1.Controls.Add(Label3)
        FlowLayoutPanel1.Controls.Add(txtAge)
        FlowLayoutPanel1.Controls.Add(Label4)
        FlowLayoutPanel1.Controls.Add(txtGender)
        FlowLayoutPanel1.Controls.Add(Label6)
        FlowLayoutPanel1.Controls.Add(txtAddress)
        FlowLayoutPanel1.Controls.Add(Label5)
        FlowLayoutPanel1.Controls.Add(txtCivil)
        FlowLayoutPanel1.Controls.Add(GroupBox3)
        FlowLayoutPanel1.Controls.Add(GroupBox2)
        FlowLayoutPanel1.Controls.Add(Label7)
        FlowLayoutPanel1.Controls.Add(txtVitamin)
        FlowLayoutPanel1.Dock = DockStyle.Fill
        FlowLayoutPanel1.Location = New Point(3, 21)
        FlowLayoutPanel1.Margin = New Padding(10)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(10, 30, 10, 10)
        FlowLayoutPanel1.Size = New Size(414, 466)
        FlowLayoutPanel1.TabIndex = 27
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(785, 2)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(102, 102)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' PatientInput
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(884, 561)
        Controls.Add(PictureBox1)
        Controls.Add(btnCancel)
        Controls.Add(gbInfo)
        Controls.Add(btnNext)
        Name = "PatientInput"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NOMG CLINIC (PATIENTS DETAILS)"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        gbInfo.ResumeLayout(False)
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnNext As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtLMC As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCivil As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtBaby As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMI As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtVitamin As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents gbInfo As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
