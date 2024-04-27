<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnPatient = New Button()
        btnAdmin = New Button()
        SuspendLayout()
        ' 
        ' btnPatient
        ' 
        btnPatient.Location = New Point(186, 235)
        btnPatient.Name = "btnPatient"
        btnPatient.Size = New Size(122, 52)
        btnPatient.TabIndex = 0
        btnPatient.Text = "Patient"
        btnPatient.UseVisualStyleBackColor = True
        ' 
        ' btnAdmin
        ' 
        btnAdmin.Location = New Point(373, 235)
        btnAdmin.Name = "btnAdmin"
        btnAdmin.Size = New Size(122, 52)
        btnAdmin.TabIndex = 1
        btnAdmin.Text = "Doctor"
        btnAdmin.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(684, 461)
        Controls.Add(btnAdmin)
        Controls.Add(btnPatient)
        Name = "Form1"
        Text = "NOMG "
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnPatient As Button
    Friend WithEvents btnAdmin As Button

End Class
