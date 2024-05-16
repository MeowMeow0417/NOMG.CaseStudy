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
        GroupBox1 = New GroupBox()
        GroupBox3 = New GroupBox()
        txtBaby = New TextBox()
        Label10 = New Label()
        txtCivil = New TextBox()
        txtAddress = New TextBox()
        txtGender = New TextBox()
        txtAge = New TextBox()
        txtLastName = New TextBox()
        txtMI = New TextBox()
        txtName = New TextBox()
        Label11 = New Label()
        Label8 = New Label()
        GroupBox2 = New GroupBox()
        txtLMC = New TextBox()
        Label9 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnCancel = New Button()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(464, 504)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(90, 27)
        btnNext.TabIndex = 1
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(GroupBox3)
        GroupBox1.Controls.Add(txtCivil)
        GroupBox1.Controls.Add(txtAddress)
        GroupBox1.Controls.Add(txtGender)
        GroupBox1.Controls.Add(txtAge)
        GroupBox1.Controls.Add(txtLastName)
        GroupBox1.Controls.Add(txtMI)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(203, 50)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(483, 423)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Patients Info:"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(txtBaby)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Location = New Point(55, 272)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(365, 45)
        GroupBox3.TabIndex = 23
        GroupBox3.TabStop = False
        GroupBox3.Text = "state if, yes or no"
        ' 
        ' txtBaby
        ' 
        txtBaby.Location = New Point(78, 16)
        txtBaby.Name = "txtBaby"
        txtBaby.Size = New Size(281, 23)
        txtBaby.TabIndex = 22
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
        ' txtCivil
        ' 
        txtCivil.Location = New Point(134, 220)
        txtCivil.Name = "txtCivil"
        txtCivil.Size = New Size(286, 23)
        txtCivil.TabIndex = 21
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(120, 174)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(300, 23)
        txtAddress.TabIndex = 20
        ' 
        ' txtGender
        ' 
        txtGender.Location = New Point(295, 126)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(125, 23)
        txtGender.TabIndex = 19
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(95, 125)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(125, 23)
        txtAge.TabIndex = 18
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(128, 79)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(292, 23)
        txtLastName.TabIndex = 17
        ' 
        ' txtMI
        ' 
        txtMI.Location = New Point(280, 42)
        txtMI.Name = "txtMI"
        txtMI.Size = New Size(140, 23)
        txtMI.TabIndex = 16
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(101, 42)
        txtName.Name = "txtName"
        txtName.Size = New Size(135, 23)
        txtName.TabIndex = 15
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9.75F)
        Label11.Location = New Point(55, 80)
        Label11.Name = "Label11"
        Label11.Size = New Size(73, 17)
        Label11.TabIndex = 14
        Label11.Text = "Last Name:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F)
        Label8.Location = New Point(242, 45)
        Label8.Name = "Label8"
        Label8.Size = New Size(32, 17)
        Label8.TabIndex = 11
        Label8.Text = "M.I.:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtLMC)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Location = New Point(55, 338)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(365, 45)
        GroupBox2.TabIndex = 10
        GroupBox2.TabStop = False
        GroupBox2.Text = "state this in weeks (just the number)"
        ' 
        ' txtLMC
        ' 
        txtLMC.Location = New Point(177, 16)
        txtLMC.Name = "txtLMC"
        txtLMC.Size = New Size(182, 23)
        txtLMC.TabIndex = 22
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
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F)
        Label6.Location = New Point(55, 174)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 17)
        Label6.TabIndex = 4
        Label6.Text = "Address:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F)
        Label5.Location = New Point(55, 223)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 17)
        Label5.TabIndex = 3
        Label5.Text = "Civil Status:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F)
        Label4.Location = New Point(235, 129)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 17)
        Label4.TabIndex = 2
        Label4.Text = "Gender:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F)
        Label3.Location = New Point(55, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(34, 17)
        Label3.TabIndex = 1
        Label3.Text = "Age:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F)
        Label2.Location = New Point(55, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 17)
        Label2.TabIndex = 0
        Label2.Text = "Name:"
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
        btnCancel.Location = New Point(309, 504)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(90, 27)
        btnCancel.TabIndex = 4
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 561)
        Controls.Add(btnCancel)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Controls.Add(btnNext)
        Name = "Form6"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NOMG CLINIC (PATIENTS DETAILS)"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnNext As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtMI As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCivil As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtLMC As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtBaby As TextBox
    Friend WithEvents Label10 As Label
End Class
