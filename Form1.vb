Imports System.Web

Public Class Form1

    'write the code for the splash/loading screen
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Form2.Show()
        Me.Hide()

    End Sub

    'its a progress bar, what else?
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class
