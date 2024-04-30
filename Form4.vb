Public Class Form4
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