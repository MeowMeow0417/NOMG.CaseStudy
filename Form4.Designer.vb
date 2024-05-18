<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        btnLogOut = New Button()
        btnPatientInfo = New Button()
        btnBill = New Button()
        btnView = New Button()
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
        PictureBox1 = New PictureBox()
        btnBack = New Button()
        PictureBox2 = New PictureBox()
        Label6 = New Label()
        pnlAppointments.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnLogOut
        ' 
        btnLogOut.BackColor = Color.HotPink
        btnLogOut.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnLogOut.Location = New Point(12, 518)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(113, 31)
        btnLogOut.TabIndex = 11
        btnLogOut.Text = "Log Out"
        btnLogOut.UseVisualStyleBackColor = False
        ' 
        ' btnPatientInfo
        ' 
        btnPatientInfo.BackColor = Color.HotPink
        btnPatientInfo.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnPatientInfo.Location = New Point(393, 380)
        btnPatientInfo.Name = "btnPatientInfo"
        btnPatientInfo.Size = New Size(136, 58)
        btnPatientInfo.TabIndex = 13
        btnPatientInfo.Text = "Patient's Details"
        btnPatientInfo.UseVisualStyleBackColor = False
        ' 
        ' btnBill
        ' 
        btnBill.BackColor = Color.HotPink
        btnBill.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnBill.Location = New Point(661, 380)
        btnBill.Name = "btnBill"
        btnBill.Size = New Size(124, 58)
        btnBill.TabIndex = 14
        btnBill.Text = "Billing"
        btnBill.UseVisualStyleBackColor = False
        ' 
        ' btnView
        ' 
        btnView.BackColor = Color.HotPink
        btnView.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnView.Location = New Point(111, 380)
        btnView.Name = "btnView"
        btnView.Size = New Size(138, 58)
        btnView.TabIndex = 16
        btnView.Text = "View Appointments"
        btnView.UseVisualStyleBackColor = False
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
        pnlAppointments.TabIndex = 2
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
        txtPatient1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label2.ForeColor = Color.HotPink
        Label2.Location = New Point(533, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 19)
        Label2.TabIndex = 19
        Label2.Text = "Follow Up Date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label3.ForeColor = Color.HotPink
        Label3.Location = New Point(211, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 19)
        Label3.TabIndex = 20
        Label3.Text = "Appointment Date"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label1.ForeColor = Color.HotPink
        Label1.Location = New Point(41, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 19)
        Label1.TabIndex = 18
        Label1.Text = "Patient"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(770, 1)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(102, 102)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.HotPink
        btnBack.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnBack.Location = New Point(12, 507)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(138, 42)
        btnBack.TabIndex = 19
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        btnBack.Visible = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(1, 108)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(970, 335)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 20
        PictureBox2.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.HotPink
        Label6.Location = New Point(12, 31)
        Label6.Name = "Label6"
        Label6.Size = New Size(218, 25)
        Label6.TabIndex = 21
        Label6.Text = "ADMIN'S DASHBOARD"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(884, 561)
        Controls.Add(btnBack)
        Controls.Add(pnlAppointments)
        Controls.Add(btnView)
        Controls.Add(btnBill)
        Controls.Add(btnPatientInfo)
        Controls.Add(btnLogOut)
        Controls.Add(PictureBox2)
        Controls.Add(Label6)
        Controls.Add(PictureBox1)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NOMG CLINIC (ADMIN)"
        pnlAppointments.ResumeLayout(False)
        pnlAppointments.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogOut As Button
    Friend WithEvents pnlAppoint As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnPatientInfo As Button
    Friend WithEvents btnBill As Button
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
    Friend WithEvents btnView As Button
    Friend WithEvents pnlAppointments As Panel
    Friend WithEvents txtPatient8 As TextBox
    Friend WithEvents txtPatient7 As TextBox
    Friend WithEvents txtPatient6 As TextBox
    Friend WithEvents txtPatient5 As TextBox
    Friend WithEvents txtPatient4 As TextBox
    Friend WithEvents txtPatient3 As TextBox
    Friend WithEvents txtPatient2 As TextBox
    Friend WithEvents txtPatient1 As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents Label6 As Label
End Class
