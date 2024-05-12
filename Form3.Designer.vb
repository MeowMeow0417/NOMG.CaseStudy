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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
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
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(398, 261)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(398, 281)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 25)
        Label2.TabIndex = 17
        Label2.Text = "Email:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(398, 212)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 25)
        Label3.TabIndex = 16
        Label3.Text = "User Name:"
        ' 
        ' txtUser
        ' 
        txtUser.BackColor = SystemColors.ActiveBorder
        txtUser.ForeColor = SystemColors.InactiveBorder
        txtUser.Location = New Point(398, 236)
        txtUser.Margin = New Padding(3, 4, 3, 4)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(261, 27)
        txtUser.TabIndex = 15
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.ActiveBorder
        txtEmail.Location = New Point(398, 305)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(261, 27)
        txtEmail.TabIndex = 14
        ' 
        ' btnSignUp
        ' 
        btnSignUp.BackColor = Color.HotPink
        btnSignUp.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignUp.Location = New Point(537, 485)
        btnSignUp.Margin = New Padding(3, 4, 3, 4)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(122, 47)
        btnSignUp.TabIndex = 13
        btnSignUp.Text = "Sign up"
        btnSignUp.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.HotPink
        btnCancel.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.Location = New Point(398, 485)
        btnCancel.Margin = New Padding(3, 4, 3, 4)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(122, 47)
        btnCancel.TabIndex = 12
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(398, 347)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 25)
        Label4.TabIndex = 20
        Label4.Text = "Password:"
        ' 
        ' TxtPass
        ' 
        TxtPass.BackColor = SystemColors.ActiveBorder
        TxtPass.Location = New Point(398, 371)
        TxtPass.Margin = New Padding(3, 4, 3, 4)
        TxtPass.Name = "TxtPass"
        TxtPass.Size = New Size(261, 27)
        TxtPass.TabIndex = 19
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(398, 313)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 20)
        Label5.TabIndex = 18
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(388, 426)
        CheckBox1.Margin = New Padding(3, 4, 3, 4)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(145, 24)
        CheckBox1.TabIndex = 21
        CheckBox1.Text = "Yes I agree to the"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(526, 427)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(146, 20)
        LinkLabel1.TabIndex = 22
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Terms and Condition"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(908, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(102, 102)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 23
        PictureBox1.TabStop = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1010, 748)
        Controls.Add(PictureBox1)
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
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NOMG CLINIC (Sign - up)"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
End Class
