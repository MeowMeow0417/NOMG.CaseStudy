<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BILLING
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
        GroupBox4 = New GroupBox()
        btnCalculate = New Button()
        Label1 = New Label()
        lblTamount = New Label()
        GroupBox3 = New GroupBox()
        Label23 = New Label()
        btnSelect = New Button()
        btnClearAll = New Button()
        lbBill = New ListBox()
        txtInvoice = New TextBox()
        Label21 = New Label()
        Label20 = New Label()
        txtEmail = New TextBox()
        btnSend = New Button()
        Label24 = New Label()
        Label25 = New Label()
        GroupBox2 = New GroupBox()
        Label19 = New Label()
        Label18 = New Label()
        txtCheck2 = New TextBox()
        txtCheck1 = New TextBox()
        Label14 = New Label()
        Label13 = New Label()
        Label8 = New Label()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        Label17 = New Label()
        Label16 = New Label()
        Label15 = New Label()
        Label3 = New Label()
        txtVitamin4 = New TextBox()
        txtVitamin3 = New TextBox()
        txtVitamin2 = New TextBox()
        txtVitamin1 = New TextBox()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        btnBack = New Button()
        Label22 = New Label()
        GroupBox4.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(btnCalculate)
        GroupBox4.Controls.Add(Label1)
        GroupBox4.Controls.Add(lblTamount)
        GroupBox4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        GroupBox4.Location = New Point(21, 411)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(432, 77)
        GroupBox4.TabIndex = 16
        GroupBox4.TabStop = False
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.HotPink
        btnCalculate.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnCalculate.Location = New Point(297, 24)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(121, 36)
        btnCalculate.TabIndex = 17
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 17)
        Label1.TabIndex = 0
        Label1.Text = "Total Amount:"
        ' 
        ' lblTamount
        ' 
        lblTamount.AutoSize = True
        lblTamount.Location = New Point(208, 33)
        lblTamount.Name = "lblTamount"
        lblTamount.Size = New Size(15, 17)
        lblTamount.TabIndex = 2
        lblTamount.Text = "0"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label23)
        GroupBox3.Controls.Add(btnSelect)
        GroupBox3.Controls.Add(btnClearAll)
        GroupBox3.Controls.Add(lbBill)
        GroupBox3.Controls.Add(txtInvoice)
        GroupBox3.Controls.Add(Label21)
        GroupBox3.Controls.Add(Label20)
        GroupBox3.Controls.Add(txtEmail)
        GroupBox3.Controls.Add(btnSend)
        GroupBox3.Controls.Add(Label24)
        GroupBox3.Controls.Add(Label25)
        GroupBox3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        GroupBox3.Location = New Point(513, 54)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(336, 434)
        GroupBox3.TabIndex = 15
        GroupBox3.TabStop = False
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(118, 37)
        Label23.Name = "Label23"
        Label23.Size = New Size(88, 25)
        Label23.TabIndex = 25
        Label23.Text = "INVOICE"
        ' 
        ' btnSelect
        ' 
        btnSelect.BackColor = Color.HotPink
        btnSelect.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnSelect.Location = New Point(183, 153)
        btnSelect.Name = "btnSelect"
        btnSelect.Size = New Size(131, 34)
        btnSelect.TabIndex = 24
        btnSelect.Text = "Select"
        btnSelect.UseVisualStyleBackColor = False
        ' 
        ' btnClearAll
        ' 
        btnClearAll.BackColor = Color.HotPink
        btnClearAll.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnClearAll.Location = New Point(31, 153)
        btnClearAll.Name = "btnClearAll"
        btnClearAll.Size = New Size(131, 34)
        btnClearAll.TabIndex = 18
        btnClearAll.Text = "Clear"
        btnClearAll.UseVisualStyleBackColor = False
        ' 
        ' lbBill
        ' 
        lbBill.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbBill.FormattingEnabled = True
        lbBill.ItemHeight = 17
        lbBill.Location = New Point(31, 101)
        lbBill.Name = "lbBill"
        lbBill.Size = New Size(283, 38)
        lbBill.TabIndex = 23
        ' 
        ' txtInvoice
        ' 
        txtInvoice.Font = New Font("Segoe UI", 9.75F)
        txtInvoice.Location = New Point(31, 290)
        txtInvoice.Name = "txtInvoice"
        txtInvoice.Size = New Size(283, 25)
        txtInvoice.TabIndex = 22
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(31, 272)
        Label21.Name = "Label21"
        Label21.Size = New Size(67, 17)
        Label21.TabIndex = 21
        Label21.Text = "Due Date:"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(31, 82)
        Label20.Name = "Label20"
        Label20.Size = New Size(45, 17)
        Label20.TabIndex = 19
        Label20.Text = "Bill to:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 9.75F)
        txtEmail.Location = New Point(31, 231)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(283, 25)
        txtEmail.TabIndex = 18
        ' 
        ' btnSend
        ' 
        btnSend.BackColor = Color.HotPink
        btnSend.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnSend.Location = New Point(61, 357)
        btnSend.Name = "btnSend"
        btnSend.Size = New Size(213, 50)
        btnSend.TabIndex = 3
        btnSend.Text = "Send Invoice"
        btnSend.UseVisualStyleBackColor = False
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Location = New Point(31, 208)
        Label24.Name = "Label24"
        Label24.Size = New Size(43, 17)
        Label24.TabIndex = 1
        Label24.Text = "Email:"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(20, 48)
        Label25.Name = "Label25"
        Label25.Size = New Size(0, 17)
        Label25.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label19)
        GroupBox2.Controls.Add(Label18)
        GroupBox2.Controls.Add(txtCheck2)
        GroupBox2.Controls.Add(txtCheck1)
        GroupBox2.Controls.Add(Label14)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        GroupBox2.Location = New Point(21, 272)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(432, 130)
        GroupBox2.TabIndex = 14
        GroupBox2.TabStop = False
        GroupBox2.Text = "Check-up Bills"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(350, 80)
        Label19.Name = "Label19"
        Label19.Size = New Size(68, 17)
        Label19.TabIndex = 17
        Label19.Text = "500 pesos"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(350, 48)
        Label18.Name = "Label18"
        Label18.Size = New Size(75, 17)
        Label18.TabIndex = 16
        Label18.Text = "2000 pesos"
        ' 
        ' txtCheck2
        ' 
        txtCheck2.Font = New Font("Segoe UI", 9.75F)
        txtCheck2.Location = New Point(177, 77)
        txtCheck2.Name = "txtCheck2"
        txtCheck2.Size = New Size(164, 25)
        txtCheck2.TabIndex = 14
        ' 
        ' txtCheck1
        ' 
        txtCheck1.Font = New Font("Segoe UI", 9.75F)
        txtCheck1.Location = New Point(177, 45)
        txtCheck1.Name = "txtCheck1"
        txtCheck1.Size = New Size(164, 25)
        txtCheck1.TabIndex = 13
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(164, 80)
        Label14.Name = "Label14"
        Label14.Size = New Size(11, 17)
        Label14.TabIndex = 9
        Label14.Text = ":"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(164, 45)
        Label13.Name = "Label13"
        Label13.Size = New Size(11, 17)
        Label13.TabIndex = 8
        Label13.Text = ":"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(34, 45)
        Label8.Name = "Label8"
        Label8.Size = New Size(101, 17)
        Label8.TabIndex = 4
        Label8.Text = "Initial Check-up"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(34, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 17)
        Label2.TabIndex = 0
        Label2.Text = "Follow-up Check-up"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label17)
        GroupBox1.Controls.Add(Label16)
        GroupBox1.Controls.Add(Label15)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txtVitamin4)
        GroupBox1.Controls.Add(txtVitamin3)
        GroupBox1.Controls.Add(txtVitamin2)
        GroupBox1.Controls.Add(txtVitamin1)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(21, 54)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(432, 212)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        GroupBox1.Text = "Prescription"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(350, 164)
        Label17.Name = "Label17"
        Label17.Size = New Size(73, 17)
        Label17.TabIndex = 15
        Label17.Text = "1500 pesos"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(350, 121)
        Label16.Name = "Label16"
        Label16.Size = New Size(64, 17)
        Label16.TabIndex = 14
        Label16.Text = "20 per pc"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(350, 82)
        Label15.Name = "Label15"
        Label15.Size = New Size(64, 17)
        Label15.TabIndex = 13
        Label15.Text = "25 per pc"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(350, 48)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 17)
        Label3.TabIndex = 3
        Label3.Text = "15 per pc"
        ' 
        ' txtVitamin4
        ' 
        txtVitamin4.Font = New Font("Segoe UI", 9.75F)
        txtVitamin4.Location = New Point(177, 156)
        txtVitamin4.Name = "txtVitamin4"
        txtVitamin4.Size = New Size(164, 25)
        txtVitamin4.TabIndex = 12
        ' 
        ' txtVitamin3
        ' 
        txtVitamin3.Font = New Font("Segoe UI", 9.75F)
        txtVitamin3.Location = New Point(177, 118)
        txtVitamin3.Name = "txtVitamin3"
        txtVitamin3.Size = New Size(164, 25)
        txtVitamin3.TabIndex = 11
        ' 
        ' txtVitamin2
        ' 
        txtVitamin2.Font = New Font("Segoe UI", 9.75F)
        txtVitamin2.Location = New Point(177, 82)
        txtVitamin2.Name = "txtVitamin2"
        txtVitamin2.Size = New Size(164, 25)
        txtVitamin2.TabIndex = 10
        ' 
        ' txtVitamin1
        ' 
        txtVitamin1.Font = New Font("Segoe UI", 9.75F)
        txtVitamin1.Location = New Point(177, 45)
        txtVitamin1.Name = "txtVitamin1"
        txtVitamin1.Size = New Size(164, 25)
        txtVitamin1.TabIndex = 9
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(140, 159)
        Label12.Name = "Label12"
        Label12.Size = New Size(11, 17)
        Label12.TabIndex = 7
        Label12.Text = ":"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(140, 121)
        Label11.Name = "Label11"
        Label11.Size = New Size(11, 17)
        Label11.TabIndex = 6
        Label11.Text = ":"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(140, 82)
        Label10.Name = "Label10"
        Label10.Size = New Size(11, 17)
        Label10.TabIndex = 5
        Label10.Text = ":"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(140, 45)
        Label9.Name = "Label9"
        Label9.Size = New Size(11, 17)
        Label9.TabIndex = 4
        Label9.Text = ":"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(34, 159)
        Label7.Name = "Label7"
        Label7.Size = New Size(50, 17)
        Label7.TabIndex = 3
        Label7.Text = "Flu Vac"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(34, 121)
        Label6.Name = "Label6"
        Label6.Size = New Size(40, 17)
        Label6.TabIndex = 2
        Label6.Text = "DHA "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(34, 82)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 17)
        Label5.TabIndex = 1
        Label5.Text = "B Complex"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(34, 45)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 17)
        Label4.TabIndex = 0
        Label4.Text = "Iron Vitamin"
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.HotPink
        btnBack.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        btnBack.Location = New Point(21, 515)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(106, 34)
        btnBack.TabIndex = 17
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label22.ForeColor = Color.HotPink
        Label22.Location = New Point(21, 9)
        Label22.Name = "Label22"
        Label22.Size = New Size(61, 19)
        Label22.TabIndex = 20
        Label22.Text = "BILLING"
        ' 
        ' BILLING
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(884, 561)
        Controls.Add(Label22)
        Controls.Add(btnBack)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox4)
        Name = "BILLING"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NOMG CLINIC (Billing)"
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTamount As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnSend As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCheck2 As TextBox
    Friend WithEvents txtCheck1 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtVitamin4 As TextBox
    Friend WithEvents txtVitamin3 As TextBox
    Friend WithEvents txtVitamin2 As TextBox
    Friend WithEvents txtVitamin1 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClearAll As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtInvoice As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lbBill As ListBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents btnSelect As Button
End Class
