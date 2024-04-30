Public Class Form3
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim newPatient As New Form2.Patient
        'checks if the user has inputted all the required details. if, not then shows the Msgbox on "else".
        If txtUser.Text <> "" AndAlso TxtPass.Text <> "" AndAlso txtEmail.Text <> "" Then
            'Adds the credentials and email of the new patient
            newPatient.setPatientCred(txtUser.Text, TxtPass.Text)
            newPatient.setPatientEmail(txtEmail.Text)
            Form2.listPatient.Add(newPatient)

            MsgBox("You're now signed up to NOMG Clinic, press 'OK' to proceed", vbOKOnly, "NOMG CLINIC")
            Me.Close()
            Form2.Show()

        Else
            MsgBox("Please, do enter all the required details", vbOKOnly, "NOMG CLINIC")
        End If
    End Sub

    'btn for cancel
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Form2.Show()
    End Sub
End Class