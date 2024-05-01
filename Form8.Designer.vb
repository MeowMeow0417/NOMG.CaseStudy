<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        btnSignUp = New Button()
        btnHome = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(125, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 6
        Label1.Text = "CONTACT"
        ' 
        ' btnSignUp
        ' 
        btnSignUp.Location = New Point(216, 16)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(75, 23)
        btnSignUp.TabIndex = 5
        btnSignUp.Text = "Sign Up"
        btnSignUp.UseVisualStyleBackColor = True
        ' 
        ' btnHome
        ' 
        btnHome.Location = New Point(29, 16)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(75, 23)
        btnHome.TabIndex = 4
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 561)
        Controls.Add(Label1)
        Controls.Add(btnSignUp)
        Controls.Add(btnHome)
        Name = "Form8"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NOMG CLINIC (CONTACTS)"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnSignUp As Button
    Friend WithEvents btnHome As Button
End Class
