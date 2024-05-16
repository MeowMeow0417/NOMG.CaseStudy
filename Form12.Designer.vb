<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
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
<<<<<<< HEAD
        SuspendLayout()
        ' 
=======
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
        pnlInfo.SuspendLayout()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(27, 28)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(176, 19)
        ListBox1.TabIndex = 0
        ' 
        ' btnEnter
        ' 
        btnEnter.Location = New Point(27, 53)
        btnEnter.Name = "btnEnter"
        btnEnter.Size = New Size(85, 38)
        btnEnter.TabIndex = 1
        btnEnter.Text = "Enter"
        btnEnter.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(118, 53)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(85, 38)
        btnClear.TabIndex = 2
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(18, 512)
        Button3.Name = "Button3"
        Button3.Size = New Size(109, 37)
        Button3.TabIndex = 3
        Button3.Text = "Back"
        Button3.UseVisualStyleBackColor = True
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
        pnlInfo.Location = New Point(261, 28)
        pnlInfo.Name = "pnlInfo"
        pnlInfo.Size = New Size(551, 470)
        pnlInfo.TabIndex = 4
        pnlInfo.Visible = False
        ' 
        ' lblAssigned
        ' 
        lblAssigned.AutoSize = True
        lblAssigned.Font = New Font("Segoe UI", 15.0F)
        lblAssigned.Location = New Point(12, 350)
        lblAssigned.Name = "lblAssigned"
        lblAssigned.Size = New Size(126, 28)
        lblAssigned.TabIndex = 10
        lblAssigned.Text = "Assigned OB:"
        ' 
        ' lblVitamin
        ' 
        lblVitamin.AutoSize = True
        lblVitamin.Font = New Font("Segoe UI", 15.0F)
        lblVitamin.Location = New Point(269, 11)
        lblVitamin.Name = "lblVitamin"
        lblVitamin.Size = New Size(206, 28)
        lblVitamin.TabIndex = 9
        lblVitamin.Text = "List of Vitamins Intake:"
        ' 
        ' lblGestational
        ' 
        lblGestational.AutoSize = True
        lblGestational.Font = New Font("Segoe UI", 15.0F)
        lblGestational.Location = New Point(12, 303)
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
>>>>>>> SCHED,DATABASES
        ' Form12
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 561)
        Name = "Form12"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form12"
        ResumeLayout(False)
    End Sub
End Class
