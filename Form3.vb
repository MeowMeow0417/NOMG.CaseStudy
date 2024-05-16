Public Class Form3
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click

        'checks if the checkbox is checked
        If CheckBox1.Checked Then
            Dim newPatient As New Form2.Patient
            'checks if the user has inputted all the required details. if, not then shows the Msgbox on "else".
            If txtUser.Text <> "" AndAlso TxtPass.Text <> "" AndAlso txtEmail.Text <> "" Then
                'Adds the credentials and email of the new patient
                newPatient.setPatientCred(txtUser.Text, TxtPass.Text, txtEmail.Text)
                Form2.listPatient.Add(newPatient)

                MsgBox("Your credentials have been set. Press 'OK' to finish the sign-up process.", vbOKOnly, "NOMG CLINIC")
                Me.Close()
                Form6.Show()

            Else
                MsgBox("Please, do enter all the required details", vbOKOnly, "NOMG CLINIC")
            End If
        Else
            ' Display a prompt to check the checkbox
            MsgBox("Please check the checkbox to proceed with the signup process.", vbOKOnly, "NOMG CLINIC")
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked 'decide if going to use a panel or not.
        MsgBox("TERMS AND CONDITIONS." & vbCrLf & "Line 2" & vbCrLf & "Line 3", vbOKOnly, "NOMG CLINIC")

    End Sub

    'btn for cancel
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Form7.Show()
    End Sub


End Class