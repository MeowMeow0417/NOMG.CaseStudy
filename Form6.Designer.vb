<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        btnSave = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(782, 522)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(90, 27)
        btnSave.TabIndex = 0
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(686, 522)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(90, 27)
        btnCancel.TabIndex = 1
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 561)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Name = "Form6"
        Text = "PATIENTS DETAILS"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
