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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        btnSignIn = New Button()
        btnContact = New Button()
        btnSignUp = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnSignIn
        ' 
        btnSignIn.BackColor = Color.HotPink
        btnSignIn.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignIn.ForeColor = Color.Black
        btnSignIn.Location = New Point(12, 695)
        btnSignIn.Margin = New Padding(3, 4, 3, 4)
        btnSignIn.Name = "btnSignIn"
        btnSignIn.Size = New Size(86, 40)
        btnSignIn.TabIndex = 0
        btnSignIn.Text = "Sign-In"
        btnSignIn.UseVisualStyleBackColor = False
        ' 
        ' btnContact
        ' 
        btnContact.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnContact.Location = New Point(122, 28)
        btnContact.Margin = New Padding(3, 4, 3, 4)
        btnContact.Name = "btnContact"
        btnContact.Size = New Size(86, 31)
        btnContact.TabIndex = 1
        btnContact.Text = "Contact"
        btnContact.UseVisualStyleBackColor = True
        ' 
        ' btnSignUp
        ' 
        btnSignUp.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignUp.Location = New Point(241, 28)
        btnSignUp.Margin = New Padding(3, 4, 3, 4)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(86, 31)
        btnSignUp.TabIndex = 2
        btnSignUp.Text = "Sign Up"
        btnSignUp.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.HotPink
        Label1.Location = New Point(31, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 25)
        Label1.TabIndex = 3
        Label1.Text = "HOME"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-2, 66)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1280, 613)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1010, 748)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(btnSignUp)
        Controls.Add(btnContact)
        Controls.Add(btnSignIn)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form7"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NOMG CLINIC (HOME PAGE)"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSignIn As Button
    Friend WithEvents btnContact As Button
    Friend WithEvents btnSignUp As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
