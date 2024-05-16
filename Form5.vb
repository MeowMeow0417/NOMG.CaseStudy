Public Class Form5


    Private Sub btnSched_Click(sender As Object, e As EventArgs) Handles btnSched.Click
        Form9.Show()
        Me.Close()
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click

        Form11.Show()
        Me.Close()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim result As MsgBoxResult
        result = MsgBox("Are you sure, you want to Log-Out?", vbOKCancel, "NOMG CLINIC")
        If result = MsgBoxResult.Ok Then
            MessageBox.Show("Logging-Out")
            Form2.Show()
            Me.Close()
        ElseIf result = MsgBoxResult.Cancel Then
            'simply returns the user back to dashboard
        End If
    End Sub

    Private Sub lblUserName_Click(sender As Object, e As EventArgs) Handles lblUserName.Click
        lblUserName.Text = Form2.txtUser.Text
    End Sub
End Class