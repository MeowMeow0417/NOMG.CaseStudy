Public Class Form1
    Private Sub btnPatient_Click(sender As Object, e As EventArgs) Handles btnPatient.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Form3.Show()
        Me.Hide()

    End Sub
End Class
