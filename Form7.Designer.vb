<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        btnSignIn = New Button()
        btnContact = New Button()
        btnSignUp = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnSignIn
        ' 
        btnSignIn.Location = New Point(72, 484)
        btnSignIn.Name = "btnSignIn"
        btnSignIn.Size = New Size(75, 23)
        btnSignIn.TabIndex = 0
        btnSignIn.Text = "Sign-In"
        btnSignIn.UseVisualStyleBackColor = True
        ' 
        ' btnContact
        ' 
        btnContact.Location = New Point(107, 21)
        btnContact.Name = "btnContact"
        btnContact.Size = New Size(75, 23)
        btnContact.TabIndex = 1
        btnContact.Text = "Contact"
        btnContact.UseVisualStyleBackColor = True
        ' 
        ' btnSignUp
        ' 
        btnSignUp.Location = New Point(211, 21)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(75, 23)
        btnSignUp.TabIndex = 2
        btnSignUp.Text = "Sign Up"
        btnSignUp.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 15)
        Label1.TabIndex = 3
        Label1.Text = "HOME"
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 561)
        Controls.Add(Label1)
        Controls.Add(btnSignUp)
        Controls.Add(btnContact)
        Controls.Add(btnSignIn)
        Name = "Form7"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NOMG CLINIC (HOME PAGE)"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSignIn As Button
    Friend WithEvents btnContact As Button
    Friend WithEvents btnSignUp As Button
    Friend WithEvents Label1 As Label
End Class
