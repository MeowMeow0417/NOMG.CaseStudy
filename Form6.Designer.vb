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
        btnNext = New Button()
        Label1 = New Label()
        btnCancel = New Button()
        Label6 = New Label()
        txtAddress = New TextBox()
        txtGender = New TextBox()
        Label5 = New Label()
        GroupBox2 = New GroupBox()
        Label9 = New Label()
        txtCivil = New TextBox()
        txtAge = New TextBox()
        Label4 = New Label()
        Label8 = New Label()
        GroupBox3 = New GroupBox()
        Label10 = New Label()
        txtBaby = New TextBox()
        txtLastName = New TextBox()
        Label3 = New Label()
        Label11 = New Label()
        Label7 = New Label()
        txtMI = New TextBox()
        txtName = New TextBox()
        txtVitamin = New TextBox()
        Label2 = New Label()
        gbInfo = New GroupBox()
        txtLMC = New TextBox()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        gbInfo.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(446, 504)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(90, 27)
        btnNext.TabIndex = 1
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(793, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 3
        Label1.Text = "NOMG LOGO"
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(299, 504)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(90, 27)
        btnCancel.TabIndex = 4
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F)
        Label6.Location = New Point(39, 204)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 17)
        Label6.TabIndex = 4
        Label6.Text = "Address:"
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(104, 204)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(300, 23)
        txtAddress.TabIndex = 20
        ' 
        ' txtGender
        ' 
        txtGender.Location = New Point(279, 156)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(125, 23)
        txtGender.TabIndex = 19
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F)
        Label5.Location = New Point(39, 253)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 17)
        Label5.TabIndex = 3
        Label5.Text = "Civil Status:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtLMC)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Location = New Point(39, 368)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(385, 45)
        GroupBox2.TabIndex = 10
        GroupBox2.TabStop = False
        GroupBox2.Text = "State as yyyy/mm/dd"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(11, 19)
        Label9.Name = "Label9"
        Label9.Size = New Size(160, 15)
        Label9.TabIndex = 9
        Label9.Text = "Date of Last Menstrual Cycle:"
        ' 
        ' txtCivil
        ' 
        txtCivil.Location = New Point(118, 250)
        txtCivil.Name = "txtCivil"
        txtCivil.Size = New Size(286, 23)
        txtCivil.TabIndex = 21
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(79, 155)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(125, 23)
        txtAge.TabIndex = 18
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F)
        Label4.Location = New Point(219, 159)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 17)
        Label4.TabIndex = 2
        Label4.Text = "Gender:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F)
        Label8.Location = New Point(226, 75)
        Label8.Name = "Label8"
        Label8.Size = New Size(32, 17)
        Label8.TabIndex = 11
        Label8.Text = "M.I.:"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(txtBaby)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Location = New Point(39, 302)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(365, 45)
        GroupBox3.TabIndex = 23
        GroupBox3.TabStop = False
        GroupBox3.Text = "state if, yes or no"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(11, 19)
        Label10.Name = "Label10"
        Label10.Size = New Size(61, 15)
        Label10.TabIndex = 9
        Label10.Text = "First Baby:"
        ' 
        ' txtBaby
        ' 
        txtBaby.Location = New Point(78, 16)
        txtBaby.Name = "txtBaby"
        txtBaby.Size = New Size(281, 23)
        txtBaby.TabIndex = 22
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(112, 109)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(292, 23)
        txtLastName.TabIndex = 17
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F)
        Label3.Location = New Point(39, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(34, 17)
        Label3.TabIndex = 1
        Label3.Text = "Age:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9.75F)
        Label11.Location = New Point(39, 110)
        Label11.Name = "Label11"
        Label11.Size = New Size(73, 17)
        Label11.TabIndex = 14
        Label11.Text = "Last Name:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F)
        Label7.Location = New Point(410, 50)
        Label7.Name = "Label7"
        Label7.Size = New Size(98, 19)
        Label7.TabIndex = 25
        Label7.Text = "Vitamin Intake"
        ' 
        ' txtMI
        ' 
        txtMI.Location = New Point(264, 72)
        txtMI.Name = "txtMI"
        txtMI.Size = New Size(140, 23)
        txtMI.TabIndex = 16
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(85, 72)
        txtName.Name = "txtName"
        txtName.Size = New Size(135, 23)
        txtName.TabIndex = 15
        ' 
        ' txtVitamin
        ' 
        txtVitamin.Location = New Point(410, 72)
        txtVitamin.Multiline = True
        txtVitamin.Name = "txtVitamin"
        txtVitamin.Size = New Size(209, 117)
        txtVitamin.TabIndex = 26
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F)
        Label2.Location = New Point(39, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 17)
        Label2.TabIndex = 0
        Label2.Text = "Name:"
        ' 
        ' gbInfo
        ' 
        gbInfo.Controls.Add(Label2)
        gbInfo.Controls.Add(txtVitamin)
        gbInfo.Controls.Add(txtName)
        gbInfo.Controls.Add(txtMI)
        gbInfo.Controls.Add(Label7)
        gbInfo.Controls.Add(Label11)
        gbInfo.Controls.Add(Label3)
        gbInfo.Controls.Add(txtLastName)
        gbInfo.Controls.Add(GroupBox3)
        gbInfo.Controls.Add(Label8)
        gbInfo.Controls.Add(Label4)
        gbInfo.Controls.Add(txtAge)
        gbInfo.Controls.Add(txtCivil)
        gbInfo.Controls.Add(GroupBox2)
        gbInfo.Controls.Add(Label5)
        gbInfo.Controls.Add(txtGender)
        gbInfo.Controls.Add(txtAddress)
        gbInfo.Controls.Add(Label6)
        gbInfo.Location = New Point(151, 12)
        gbInfo.Name = "gbInfo"
        gbInfo.Size = New Size(636, 488)
        gbInfo.TabIndex = 2
        gbInfo.TabStop = False
        gbInfo.Text = "Patients Info:"
        ' 
        ' txtLMC
        ' 
        txtLMC.Location = New Point(177, 16)
        txtLMC.Name = "txtLMC"
        txtLMC.Size = New Size(188, 23)
        txtLMC.TabIndex = 10
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 561)
        Controls.Add(btnCancel)
        Controls.Add(Label1)
        Controls.Add(gbInfo)
        Controls.Add(btnNext)
        Name = "Form6"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NOMG CLINIC (PATIENTS DETAILS)"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        gbInfo.ResumeLayout(False)
        gbInfo.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnNext As Button
    Friend WithEvents Label1 As Label
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
End Class
