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
        Label1 = New Label()
        lblUserName = New Label()
        btnSched = New Button()
        Label2 = New Label()
        btnRem = New Button()
        btnPay = New Button()
        btnLogOut = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 0
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Location = New Point(12, 9)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(59, 15)
        lblUserName.TabIndex = 2
        lblUserName.Text = "username"
        ' 
        ' btnSched
        ' 
        btnSched.BackColor = Color.White
        btnSched.Location = New Point(146, 449)
        btnSched.Name = "btnSched"
        btnSched.Size = New Size(113, 35)
        btnSched.TabIndex = 3
        btnSched.Text = "Schedule"
        btnSched.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(742, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 25)
        Label2.TabIndex = 4
        Label2.Text = "NOMG LOGO"
        ' 
        ' btnRem
        ' 
        btnRem.Location = New Point(394, 449)
        btnRem.Name = "btnRem"
        btnRem.Size = New Size(113, 35)
        btnRem.TabIndex = 6
        btnRem.Text = "Reminders"
        btnRem.UseVisualStyleBackColor = True
        ' 
        ' btnPay
        ' 
        btnPay.Location = New Point(646, 449)
        btnPay.Name = "btnPay"
        btnPay.Size = New Size(113, 35)
        btnPay.TabIndex = 7
        btnPay.Text = "Payment"
        btnPay.UseVisualStyleBackColor = True
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Location = New Point(12, 522)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(113, 27)
        btnLogOut.TabIndex = 10
        btnLogOut.Text = "Log Out"
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 561)
        Controls.Add(btnLogOut)
        Controls.Add(btnPay)
        Controls.Add(btnRem)
        Controls.Add(Label2)
        Controls.Add(btnSched)
        Controls.Add(lblUserName)
        Controls.Add(Label1)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "Form5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PATIENTS DASHBOARD"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents btnSched As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRem As Button
    Friend WithEvents btnPay As Button
    Friend WithEvents btnLogOut As Button
End Class
