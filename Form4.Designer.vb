<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        btnLogOut = New Button()
        btnPatientInfo = New Button()
        btnBilling = New Button()
        Button3 = New Button()
        Button1 = New Button()
        pnlAppointments = New Panel()
        txtPatient8 = New TextBox()
        txtPatient7 = New TextBox()
        txtPatient6 = New TextBox()
        txtPatient5 = New TextBox()
        txtPatient4 = New TextBox()
        txtPatient3 = New TextBox()
        txtPatient2 = New TextBox()
        txtPatient1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        pnlAppointments.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Location = New Point(12, 522)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(113, 27)
        btnLogOut.TabIndex = 11
        btnLogOut.Text = "Log Out"
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' btnPatientInfo
        ' 
        btnPatientInfo.Location = New Point(168, 491)
        btnPatientInfo.Name = "btnPatientInfo"
        btnPatientInfo.Size = New Size(116, 58)
        btnPatientInfo.TabIndex = 13
        btnPatientInfo.Text = "Patient's Details"
        btnPatientInfo.UseVisualStyleBackColor = True
        ' 
        ' btnBilling
        ' 
        btnBilling.Location = New Point(334, 491)
        btnBilling.Name = "btnBilling"
        btnBilling.Size = New Size(116, 58)
        btnBilling.TabIndex = 14
        btnBilling.Text = "Billing"
        btnBilling.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(505, 491)
        Button3.Name = "Button3"
        Button3.Size = New Size(116, 58)
        Button3.TabIndex = 15
        Button3.Text = "Conflict Checking"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(677, 491)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 58)
        Button1.TabIndex = 16
        Button1.Text = "View Appointments"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' pnlAppointments
        ' 
        pnlAppointments.Controls.Add(txtPatient8)
        pnlAppointments.Controls.Add(txtPatient7)
        pnlAppointments.Controls.Add(txtPatient6)
        pnlAppointments.Controls.Add(txtPatient5)
        pnlAppointments.Controls.Add(txtPatient4)
        pnlAppointments.Controls.Add(txtPatient3)
        pnlAppointments.Controls.Add(txtPatient2)
        pnlAppointments.Controls.Add(txtPatient1)
        pnlAppointments.Controls.Add(Label2)
        pnlAppointments.Controls.Add(Label3)
        pnlAppointments.Controls.Add(Label1)
        pnlAppointments.Location = New Point(12, 12)
        pnlAppointments.Name = "pnlAppointments"
        pnlAppointments.Size = New Size(860, 473)
        pnlAppointments.TabIndex = 17
        pnlAppointments.Visible = False
        ' 
        ' txtPatient8
        ' 
        txtPatient8.Location = New Point(41, 358)
        txtPatient8.Multiline = True
        txtPatient8.Name = "txtPatient8"
        txtPatient8.ReadOnly = True
        txtPatient8.Size = New Size(788, 49)
        txtPatient8.TabIndex = 28
        ' 
        ' txtPatient7
        ' 
        txtPatient7.Location = New Point(41, 413)
        txtPatient7.Multiline = True
        txtPatient7.Name = "txtPatient7"
        txtPatient7.ReadOnly = True
        txtPatient7.Size = New Size(788, 48)
        txtPatient7.TabIndex = 27
        ' 
        ' txtPatient6
        ' 
        txtPatient6.Location = New Point(41, 306)
        txtPatient6.Multiline = True
        txtPatient6.Name = "txtPatient6"
        txtPatient6.ReadOnly = True
        txtPatient6.Size = New Size(788, 46)
        txtPatient6.TabIndex = 26
        ' 
        ' txtPatient5
        ' 
        txtPatient5.Location = New Point(41, 252)
        txtPatient5.Multiline = True
        txtPatient5.Name = "txtPatient5"
        txtPatient5.ReadOnly = True
        txtPatient5.Size = New Size(788, 48)
        txtPatient5.TabIndex = 25
        ' 
        ' txtPatient4
        ' 
        txtPatient4.Location = New Point(41, 201)
        txtPatient4.Multiline = True
        txtPatient4.Name = "txtPatient4"
        txtPatient4.ReadOnly = True
        txtPatient4.Size = New Size(788, 45)
        txtPatient4.TabIndex = 24
        ' 
        ' txtPatient3
        ' 
        txtPatient3.Location = New Point(41, 157)
        txtPatient3.Multiline = True
        txtPatient3.Name = "txtPatient3"
        txtPatient3.ReadOnly = True
        txtPatient3.Size = New Size(788, 43)
        txtPatient3.TabIndex = 23
        ' 
        ' txtPatient2
        ' 
        txtPatient2.Location = New Point(41, 105)
        txtPatient2.Multiline = True
        txtPatient2.Name = "txtPatient2"
        txtPatient2.ReadOnly = True
        txtPatient2.Size = New Size(788, 46)
        txtPatient2.TabIndex = 22
        ' 
        ' txtPatient1
        ' 
        txtPatient1.Location = New Point(41, 50)
        txtPatient1.Multiline = True
        txtPatient1.Name = "txtPatient1"
        txtPatient1.ReadOnly = True
        txtPatient1.Size = New Size(788, 49)
        txtPatient1.TabIndex = 21
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.0F)
        Label2.Location = New Point(533, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 28)
        Label2.TabIndex = 19
        Label2.Text = "Follow Up Date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.0F)
        Label3.Location = New Point(211, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(175, 28)
        Label3.TabIndex = 20
        Label3.Text = "Appointment Date"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.0F)
        Label1.Location = New Point(41, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 28)
        Label1.TabIndex = 18
        Label1.Text = "Patient"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 561)
        Controls.Add(pnlAppointments)
        Controls.Add(Button1)
        Controls.Add(Button3)
        Controls.Add(btnBilling)
        Controls.Add(btnPatientInfo)
        Controls.Add(btnLogOut)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NOMG CLINIC (ADMIN)"
        pnlAppointments.ResumeLayout(False)
        pnlAppointments.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnLogOut As Button
    Friend WithEvents pnlAppoint As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnPatientInfo As Button
    Friend WithEvents btnBilling As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPatient5 As Label
    Friend WithEvents lblPatient4 As Label
    Friend WithEvents lblPatient3 As Label
    Friend WithEvents lblPatient2 As Label
    Friend WithEvents lblPatient1 As Label
    Friend WithEvents lblFollow5 As Label
    Friend WithEvents lblFollow4 As Label
    Friend WithEvents lblFollow3 As Label
    Friend WithEvents lblFollow2 As Label
    Friend WithEvents lblFollow1 As Label
    Friend WithEvents lblAppoint5 As Label
    Friend WithEvents lblAppoint4 As Label
    Friend WithEvents lblAppoint3 As Label
    Friend WithEvents lblAppoint2 As Label
    Friend WithEvents lblAppoint1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents pnlAppointments As Panel
    Friend WithEvents txtPatient8 As TextBox
    Friend WithEvents txtPatient7 As TextBox
    Friend WithEvents txtPatient6 As TextBox
    Friend WithEvents txtPatient5 As TextBox
    Friend WithEvents txtPatient4 As TextBox
    Friend WithEvents txtPatient3 As TextBox
    Friend WithEvents txtPatient2 As TextBox
    Friend WithEvents txtPatient1 As TextBox
End Class
