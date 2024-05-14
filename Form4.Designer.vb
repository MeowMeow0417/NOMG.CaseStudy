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
        btnBill = New Button()
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
        ' btnBill
        ' 
        btnBill.Location = New Point(602, 464)
        btnBill.Name = "btnBill"
        btnBill.Size = New Size(105, 35)
        btnBill.TabIndex = 12
        btnBill.Text = "Billing"
        btnBill.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 561)
        Controls.Add(btnBill)
        Controls.Add(btnLogOut)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NOMG CLINIC (ADMIN)"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnBill As Button
End Class
