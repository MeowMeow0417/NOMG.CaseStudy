Public Class Form5


    Private Sub btnSched_Click(sender As Object, e As EventArgs) Handles btnSched.Click

        lblUserName.Text = Form2.strCurrentPatient.getPatient

    End Sub

    Private Sub btnRem_Click(sender As Object, e As EventArgs) Handles btnRem.Click



    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim result As MsgBoxResult
        result = MsgBox("Are you sure, you want to Log-Out?", vbOKCancel, "NOMG CLINIC")
        If result = MsgBoxResult.Ok Then
            MessageBox.Show("Logging-Out")
            Form1.Close()
            Form2.Close()
        ElseIf result = MsgBoxResult.Cancel Then
            'No function
        End If
    End Sub


End Class