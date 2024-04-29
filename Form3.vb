Public Class Form3

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click

        Dim newPatient As New Form2.Patient
        newPatient.setPatientCred(txtUser.Text, TxtPass.Text)
        newPatient.setPatientEmail(txtEmail.Text)
        Form2.listPatient.Add(newPatient)

        Me.Close()

    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Form2.Show()
    End Sub


End Class