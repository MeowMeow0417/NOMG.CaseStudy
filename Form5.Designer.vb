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
        Button2 = New Button()
        btnRem = New Button()
        btnPay = New Button()
        pnSched = New Panel()
        pnRem = New Panel()
        pnPayment = New Panel()
        btnLogOut = New Button()
        pnSched.SuspendLayout()
        pnRem.SuspendLayout()
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
        lblUserName.Location = New Point(813, 9)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(59, 15)
        lblUserName.TabIndex = 2
        lblUserName.Text = "username"
        ' 
        ' btnSched
        ' 
        btnSched.BackColor = Color.White
        btnSched.Location = New Point(12, 103)
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
        Label2.Location = New Point(12, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 25)
        Label2.TabIndex = 4
        Label2.Text = "NOMG CLINIC"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(562, 471)
        Button2.Name = "Button2"
        Button2.Size = New Size(163, 27)
        Button2.TabIndex = 5
        Button2.Text = "Schedule an Appointment"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btnRem
        ' 
        btnRem.Location = New Point(12, 163)
        btnRem.Name = "btnRem"
        btnRem.Size = New Size(113, 35)
        btnRem.TabIndex = 6
        btnRem.Text = "Reminders"
        btnRem.UseVisualStyleBackColor = True
        ' 
        ' btnPay
        ' 
        btnPay.Location = New Point(12, 225)
        btnPay.Name = "btnPay"
        btnPay.Size = New Size(113, 35)
        btnPay.TabIndex = 7
        btnPay.Text = "Payment"
        btnPay.UseVisualStyleBackColor = True
        ' 
        ' pnSched
        ' 
        pnSched.BackColor = Color.MistyRose
        pnSched.Controls.Add(Button2)
        pnSched.Location = New Point(144, 51)
        pnSched.Name = "pnSched"
        pnSched.Size = New Size(728, 498)
        pnSched.TabIndex = 8
        ' 
        ' pnRem
        ' 
        pnRem.BackColor = Color.RosyBrown
        pnRem.Controls.Add(pnPayment)
        pnRem.Location = New Point(144, 54)
        pnRem.Name = "pnRem"
        pnRem.Size = New Size(728, 495)
        pnRem.TabIndex = 9
        pnRem.Visible = False
        ' 
        ' pnPayment
        ' 
        pnPayment.BackColor = Color.DarkKhaki
        pnPayment.Location = New Point(0, -3)
        pnPayment.Name = "pnPayment"
        pnPayment.Size = New Size(728, 504)
        pnPayment.TabIndex = 10
        pnPayment.Visible = False
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
        Controls.Add(pnRem)
        Controls.Add(pnSched)
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
        pnSched.ResumeLayout(False)
        pnRem.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents btnSched As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnRem As Button
    Friend WithEvents btnPay As Button
    Friend WithEvents pnSched As Panel
    Friend WithEvents pnRem As Panel
    Friend WithEvents pnPayment As Panel
    Friend WithEvents btnLogOut As Button
End Class
