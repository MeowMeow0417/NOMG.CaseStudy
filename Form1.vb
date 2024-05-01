Imports System.Web
Public Class Form1
    'splash screen code
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        lblPercent.Text = ProgressBar1.Value & "%"

        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Timer2.Start()

            Form7.Show()
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


End Class