Public Class Form6
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim newDetails As New Form2.PatientDetails
        newDetails.setDetails1(txtName.Text, txtMI.Text, txtLastName.Text, txtAge.Text)
        newDetails.setDetails2(txtBaby.Text, txtGender.Text, txtCivil.Text, txtAddress.Text, txtLMC.Text)
        Form2.listDetails.Add(newDetails)

        Dim userInput As String = txtBaby.Text.ToLower()

        If txtName.Text <> "" AndAlso txtMI.Text <> "" AndAlso txtLastName.Text <> "" AndAlso txtAge.Text <> "" AndAlso txtBaby.Text <> "" AndAlso txtGender.Text <> "" AndAlso txtCivil.Text <> "" AndAlso txtAddress.Text <> "" AndAlso txtLMC.Text <> "" Then
            'checks if the input is yes/no
            If userInput = "yes" Then
                'data is already stored as yes
            ElseIf userInput = "no" Then
                'data is already stored as no
            Else
                MsgBox("Only input 'yes' or 'no'", MsgBoxStyle.Exclamation, "Error")
            End If

            'line of code. so, it doesn't unless the needed info are correct
            If userInput = "yes" Or userInput = "no" Then
                MsgBox("You're Account is now all set", vbOKOnly, "NOMG CLINIC")

                Form5.Show()
                Me.Close()
            End If

        Else
            MsgBox("Please, do enter all the required details", vbOKOnly, "NOMG CLINIC")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Form3.Show()
        Me.Close()

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtGender.TextChanged

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)

    End Sub
End Class