<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PATIENTDETAILS
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
        ListBox1 = New ListBox()
        btnEnter = New Button()
        btnClear = New Button()
        Button3 = New Button()
        pnlInfo = New Panel()
        lblAssigned = New Label()
        lblVitamin = New Label()
        lblGestational = New Label()
        lblLMC = New Label()
        lblBaby = New Label()
        lblCivil = New Label()
        lblAddress = New Label()
        lblGender = New Label()
        lblAge = New Label()
        lblName = New Label()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        pnlInfo.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(27, 85)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(176, 19)
        ListBox1.TabIndex = 0
        ' 
        ' btnEnter
        ' 
        btnEnter.BackColor = Color.HotPink
        btnEnter.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnEnter.Location = New Point(27, 132)
        btnEnter.Name = "btnEnter"
        btnEnter.Size = New Size(176, 38)
        btnEnter.TabIndex = 1
        btnEnter.Text = "Enter"
        btnEnter.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.HotPink
        btnClear.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnClear.Location = New Point(27, 176)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(176, 38)
        btnClear.TabIndex = 2
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.HotPink
        Button3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Button3.Location = New Point(18, 512)
        Button3.Name = "Button3"
        Button3.Size = New Size(109, 37)
        Button3.TabIndex = 3
        Button3.Text = "Back"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' pnlInfo
        ' 
        pnlInfo.Controls.Add(lblAssigned)
        pnlInfo.Controls.Add(lblVitamin)
        pnlInfo.Controls.Add(lblGestational)
        pnlInfo.Controls.Add(lblLMC)
        pnlInfo.Controls.Add(lblBaby)
        pnlInfo.Controls.Add(lblCivil)
        pnlInfo.Controls.Add(lblAddress)
        pnlInfo.Controls.Add(lblGender)
        pnlInfo.Controls.Add(lblAge)
        pnlInfo.Controls.Add(lblName)
        pnlInfo.Font = New Font("Segoe UI", 9.75F)
        pnlInfo.Location = New Point(16, 22)
        pnlInfo.Name = "pnlInfo"
        pnlInfo.Size = New Size(630, 470)
        pnlInfo.TabIndex = 4
        pnlInfo.Visible = False
        ' 
        ' lblAssigned
        ' 
        lblAssigned.AutoSize = True
        lblAssigned.Font = New Font("Segoe UI", 15.0F)
        lblAssigned.Location = New Point(12, 334)
        lblAssigned.Name = "lblAssigned"
        lblAssigned.Size = New Size(126, 28)
        lblAssigned.TabIndex = 10
        lblAssigned.Text = "Assigned OB:"
        ' 
        ' lblVitamin
        ' 
        lblVitamin.AutoSize = True
        lblVitamin.Font = New Font("Segoe UI", 15.0F)
        lblVitamin.Location = New Point(281, 11)
        lblVitamin.Name = "lblVitamin"
        lblVitamin.Size = New Size(206, 28)
        lblVitamin.TabIndex = 9
        lblVitamin.Text = "List of Vitamins Intake:"
        ' 
        ' lblGestational
        ' 
        lblGestational.AutoSize = True
        lblGestational.Font = New Font("Segoe UI", 15.0F)
        lblGestational.Location = New Point(12, 295)
        lblGestational.Name = "lblGestational"
        lblGestational.Size = New Size(155, 28)
        lblGestational.TabIndex = 8
        lblGestational.Text = "Gestational Age:"
        ' 
        ' lblLMC
        ' 
        lblLMC.AutoSize = True
        lblLMC.Font = New Font("Segoe UI", 15.0F)
        lblLMC.Location = New Point(12, 252)
        lblLMC.Name = "lblLMC"
        lblLMC.Size = New Size(193, 28)
        lblLMC.TabIndex = 6
        lblLMC.Text = "Last Menstrual Cycle:"
        ' 
        ' lblBaby
        ' 
        lblBaby.AutoSize = True
        lblBaby.Font = New Font("Segoe UI", 15.0F)
        lblBaby.Location = New Point(12, 208)
        lblBaby.Name = "lblBaby"
        lblBaby.Size = New Size(101, 28)
        lblBaby.TabIndex = 5
        lblBaby.Text = "First Baby:"
        ' 
        ' lblCivil
        ' 
        lblCivil.AutoSize = True
        lblCivil.Font = New Font("Segoe UI", 15.0F)
        lblCivil.Location = New Point(12, 169)
        lblCivil.Name = "lblCivil"
        lblCivil.Size = New Size(111, 28)
        lblCivil.TabIndex = 4
        lblCivil.Text = "Civil Status:"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Segoe UI", 15.0F)
        lblAddress.Location = New Point(12, 127)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(82, 28)
        lblAddress.TabIndex = 3
        lblAddress.Text = "Address"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Font = New Font("Segoe UI", 15.0F)
        lblGender.Location = New Point(12, 88)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(76, 28)
        lblGender.TabIndex = 2
        lblGender.Text = "Gender"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Font = New Font("Segoe UI", 15.0F)
        lblAge.Location = New Point(12, 48)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(47, 28)
        lblAge.TabIndex = 1
        lblAge.Text = "Age"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 15.0F)
        lblName.Location = New Point(12, 11)
        lblName.Name = "lblName"
        lblName.Size = New Size(64, 28)
        lblName.TabIndex = 0
        lblName.Text = "Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label1.ForeColor = Color.HotPink
        Label1.Location = New Point(27, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 19)
        Label1.TabIndex = 11
        Label1.Text = "VIEW PATIENT DETAILS"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(pnlInfo)
        GroupBox1.Location = New Point(209, 46)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(663, 503)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        ' 
        ' PATIENTDETAILS
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(884, 561)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(btnClear)
        Controls.Add(btnEnter)
        Controls.Add(ListBox1)
        Name = "PATIENTDETAILS"
        Text = "NOMG CLINIC (VIEW PATIENT DETAILS)"
        pnlInfo.ResumeLayout(False)
        pnlInfo.PerformLayout()
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents pnlInfo As Panel
    Friend WithEvents lblAssigned As Label
    Friend WithEvents lblVitamin As Label
    Friend WithEvents lblGestational As Label
    Friend WithEvents lblCheckup As Label
    Friend WithEvents lblLMC As Label
    Friend WithEvents lblBaby As Label
    Friend WithEvents lblCivil As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtVitamins As TextBox
End Class
