<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label2 = New Label()
        Label1 = New Label()
        txtUser = New TextBox()
        txtPass = New TextBox()
        btnCancel = New Button()
        btnSignIn = New Button()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(409, 235)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 11
        Label2.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(407, 178)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 10
        Label1.Text = "Username"
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(358, 196)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(158, 23)
        txtUser.TabIndex = 9
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(358, 253)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(158, 23)
        txtPass.TabIndex = 8
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(387, 335)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(107, 35)
        btnCancel.TabIndex = 7
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnSignIn
        ' 
        btnSignIn.Location = New Point(387, 294)
        btnSignIn.Name = "btnSignIn"
        btnSignIn.Size = New Size(107, 35)
        btnSignIn.TabIndex = 6
        btnSignIn.Text = "Sign In"
        btnSignIn.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 561)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtUser)
        Controls.Add(txtPass)
        Controls.Add(btnCancel)
        Controls.Add(btnSignIn)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Start Screen"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSignIn As Button
End Class
