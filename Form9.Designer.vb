<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        btnBack = New Button()
        btnGetSched = New Button()
        pnlFollowup = New Panel()
        lblFollow4 = New Label()
        lblFollow3 = New Label()
        lblFollow2 = New Label()
        lblFollow1 = New Label()
        lblAppoint = New Label()
        pnlFollowup.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(658, 526)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 23)
        btnBack.TabIndex = 0
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnGetSched
        ' 
        btnGetSched.Location = New Point(739, 526)
        btnGetSched.Name = "btnGetSched"
        btnGetSched.Size = New Size(133, 23)
        btnGetSched.TabIndex = 1
        btnGetSched.Text = "Get Schedule"
        btnGetSched.UseVisualStyleBackColor = True
        ' 
        ' pnlFollowup
        ' 
        pnlFollowup.Controls.Add(lblFollow4)
        pnlFollowup.Controls.Add(lblFollow3)
        pnlFollowup.Controls.Add(lblFollow2)
        pnlFollowup.Controls.Add(lblFollow1)
        pnlFollowup.Controls.Add(lblAppoint)
        pnlFollowup.Location = New Point(12, 12)
        pnlFollowup.Name = "pnlFollowup"
        pnlFollowup.Size = New Size(860, 508)
        pnlFollowup.TabIndex = 3
        ' 
        ' lblFollow4
        ' 
        lblFollow4.AutoSize = True
        lblFollow4.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblFollow4.Location = New Point(52, 417)
        lblFollow4.Name = "lblFollow4"
        lblFollow4.Size = New Size(0, 37)
        lblFollow4.TabIndex = 4
        ' 
        ' lblFollow3
        ' 
        lblFollow3.AutoSize = True
        lblFollow3.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblFollow3.Location = New Point(52, 315)
        lblFollow3.Name = "lblFollow3"
        lblFollow3.Size = New Size(0, 37)
        lblFollow3.TabIndex = 3
        ' 
        ' lblFollow2
        ' 
        lblFollow2.AutoSize = True
        lblFollow2.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblFollow2.Location = New Point(52, 219)
        lblFollow2.Name = "lblFollow2"
        lblFollow2.Size = New Size(0, 37)
        lblFollow2.TabIndex = 2
        ' 
        ' lblFollow1
        ' 
        lblFollow1.AutoSize = True
        lblFollow1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblFollow1.Location = New Point(52, 115)
        lblFollow1.Name = "lblFollow1"
        lblFollow1.Size = New Size(0, 37)
        lblFollow1.TabIndex = 1
        ' 
        ' lblAppoint
        ' 
        lblAppoint.AutoSize = True
        lblAppoint.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblAppoint.Location = New Point(52, 21)
        lblAppoint.Name = "lblAppoint"
        lblAppoint.Size = New Size(0, 37)
        lblAppoint.TabIndex = 0
        ' 
        ' Form9
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 561)
        Controls.Add(pnlFollowup)
        Controls.Add(btnGetSched)
        Controls.Add(btnBack)
        Name = "Form9"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NOMG CLINIC (Schedule)"
        pnlFollowup.ResumeLayout(False)
        pnlFollowup.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnGetSched As Button
    Friend WithEvents pnlFollowup As Panel
    Friend WithEvents lblFollow4 As Label
    Friend WithEvents lblFollow3 As Label
    Friend WithEvents lblFollow2 As Label
    Friend WithEvents lblFollow1 As Label
    Friend WithEvents lblAppoint As Label
End Class
