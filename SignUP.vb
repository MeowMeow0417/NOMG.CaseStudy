Public Class Form3
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        ' Checks if the checkbox is checked
        If CheckBox1.Checked Then
            ' Checks if the user has inputted all the required details. If not, then shows the Msgbox on "else".
            If txtUser.Text <> "" AndAlso TxtPass.Text <> "" AndAlso txtEmail.Text <> "" Then
                ' Adds the credentials and email of the new patient
                Form2.AddPatient(txtUser.Text, TxtPass.Text, txtEmail.Text)

                MsgBox("Your credentials have been set. Press 'OK' to finish the sign-up process.", vbOKOnly, "NOMG CLINIC")
                Me.Close()
                PatientInput.Show()
            Else
                MsgBox("Please enter all the required details", vbOKOnly, "NOMG CLINIC")
            End If
        Else
            ' Display a prompt to check the checkbox
            MsgBox("Please check the checkbox to proceed with the signup process.", vbOKOnly, "NOMG CLINIC")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        TaC.Show()
    End Sub

    ' Button for cancel
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        HomePage.Show()
    End Sub
End Class
