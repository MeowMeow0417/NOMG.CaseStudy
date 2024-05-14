<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TaC))
        btnBack = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(395, 481)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(97, 40)
        btnBack.TabIndex = 1
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(167, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(583, 51)
        Label1.TabIndex = 0
        Label1.Text = resources.GetString("Label1.Text")
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(167, 156)
        Label2.Name = "Label2"
        Label2.Size = New Size(583, 51)
        Label2.TabIndex = 2
        Label2.Text = resources.GetString("Label2.Text")
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(167, 232)
        Label3.Name = "Label3"
        Label3.Size = New Size(583, 51)
        Label3.TabIndex = 3
        Label3.Text = resources.GetString("Label3.Text")
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(167, 313)
        Label4.Name = "Label4"
        Label4.Size = New Size(583, 51)
        Label4.TabIndex = 4
        Label4.Text = resources.GetString("Label4.Text")
        ' 
        ' Label5
        ' 
        Label5.Location = New Point(167, 380)
        Label5.Name = "Label5"
        Label5.Size = New Size(583, 87)
        Label5.TabIndex = 5
        Label5.Text = resources.GetString("Label5.Text")
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(381, 25)
        Label6.Name = "Label6"
        Label6.Size = New Size(124, 15)
        Label6.TabIndex = 6
        Label6.Text = "Terms And Conditions"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(167, 141)
        Label7.Name = "Label7"
        Label7.Size = New Size(128, 15)
        Label7.TabIndex = 7
        Label7.Text = "Patient Responsibilities"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(167, 217)
        Label8.Name = "Label8"
        Label8.Size = New Size(149, 15)
        Label8.TabIndex = 8
        Label8.Text = "Confidentiality and Privacy"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(167, 298)
        Label9.Name = "Label9"
        Label9.Size = New Size(144, 15)
        Label9.TabIndex = 9
        Label9.Text = "Feedback and Complaints"
        ' 
        ' TaC
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 561)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnBack)
        Controls.Add(Label1)
        Name = "TaC"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NOMG Clinic (Terms and Conditions)"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
