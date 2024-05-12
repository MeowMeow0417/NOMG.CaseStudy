<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Label1 = New Label()
        lblUserName = New Label()
        btnSched = New Button()
        btnPay = New Button()
        btnLogOut = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(14, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 0
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUserName.Location = New Point(14, 12)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(95, 25)
        lblUserName.TabIndex = 2
        lblUserName.Text = "username"
        ' 
        ' btnSched
        ' 
        btnSched.BackColor = Color.HotPink
        btnSched.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSched.ForeColor = Color.Transparent
        btnSched.Location = New Point(235, 520)
        btnSched.Margin = New Padding(3, 4, 3, 4)
        btnSched.Name = "btnSched"
        btnSched.Size = New Size(129, 47)
        btnSched.TabIndex = 3
        btnSched.Text = "Schedule"
        btnSched.UseVisualStyleBackColor = False
        ' 
        ' btnPay
        ' 
        btnPay.BackColor = Color.HotPink
        btnPay.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPay.ForeColor = Color.White
        btnPay.Location = New Point(666, 520)
        btnPay.Margin = New Padding(3, 4, 3, 4)
        btnPay.Name = "btnPay"
        btnPay.Size = New Size(129, 47)
        btnPay.TabIndex = 7
        btnPay.Text = "Payment"
        btnPay.UseVisualStyleBackColor = False
        ' 
        ' btnLogOut
        ' 
        btnLogOut.BackColor = Color.HotPink
        btnLogOut.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogOut.Location = New Point(14, 696)
        btnLogOut.Margin = New Padding(3, 4, 3, 4)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(129, 36)
        btnLogOut.TabIndex = 10
        btnLogOut.Text = "Log Out"
        btnLogOut.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(909, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(102, 102)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(-163, 56)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(1366, 768)
        PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1010, 748)
        Controls.Add(PictureBox1)
        Controls.Add(btnLogOut)
        Controls.Add(btnPay)
        Controls.Add(btnSched)
        Controls.Add(lblUserName)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "Form5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NOMG CLINIC (PATIENTS)"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents btnSched As Button
    Friend WithEvents btnPay As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
