Imports System.Web
Public Class SPLASH
    'splash screen code
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 10
        lblPercent.Text = ProgressBar1.Value & "%"

        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Timer2.Start()

            HomePage.Show()
            Me.Hide()
        End If
    End Sub

    'function for the progress bar
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0
        Timer1.Start()
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class