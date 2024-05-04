<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtUser = New TextBox()
        txtEmail = New TextBox()
        btnSignUp = New Button()
        btnCancel = New Button()
        Label4 = New Label()
        TxtPass = New TextBox()
        Label5 = New Label()
        CheckBox1 = New CheckBox()
        LinkLabel1 = New LinkLabel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(348, 196)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(348, 211)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 15)
        Label2.TabIndex = 17
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(348, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 16
        Label3.Text = "Username"
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(348, 177)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(229, 23)
        txtUser.TabIndex = 15
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(348, 229)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(229, 23)
        txtEmail.TabIndex = 14
        ' 
        ' btnSignUp
        ' 
        btnSignUp.Location = New Point(470, 364)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(107, 35)
        btnSignUp.TabIndex = 13
        btnSignUp.Text = "Sign up"
        btnSignUp.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(348, 364)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(107, 35)
        btnCancel.TabIndex = 12
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(348, 260)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 20
        Label4.Text = "Password"
        ' 
        ' TxtPass
        ' 
        TxtPass.Location = New Point(348, 278)
        TxtPass.Name = "TxtPass"
        TxtPass.Size = New Size(229, 23)
        TxtPass.TabIndex = 19
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(348, 235)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 15)
        Label5.TabIndex = 18
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(348, 319)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(115, 19)
        CheckBox1.TabIndex = 21
        CheckBox1.Text = "Yes I agree to the"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(460, 320)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(117, 15)
        LinkLabel1.TabIndex = 22
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Terms and Condition"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 561)
        Controls.Add(LinkLabel1)
        Controls.Add(CheckBox1)
        Controls.Add(Label4)
        Controls.Add(TxtPass)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(txtUser)
        Controls.Add(txtEmail)
        Controls.Add(btnSignUp)
        Controls.Add(btnCancel)
        Controls.Add(Label1)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NOMG CLINIC (Sign - up)"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnSignUp As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
