Public Class Form5
    Public strCurrentPatient As Form2.Patient

    Private Sub ShowForm13()
        Dim form13 As New BILLING(strCurrentPatient) ' Pass current patient to Form13 via constructor
        form13.Show()
        Me.Hide()
    End Sub

    Private Sub btnSched_Click(sender As Object, e As EventArgs) Handles btnSched.Click
        GetSched.Show()
        Me.Close()
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        ' Check if there are billing details for the current patient before showing Form11
        Dim patientBilling As PAYMENT.Billing = PAYMENT.listCard.Find(Function(b) b.getEmail() = strCurrentPatient.getPatientEmail())

        If patientBilling IsNot Nothing Then
            ' If there are billing details, show Form11
            PAYMENT.strCurrentCard = patientBilling
            PAYMENT.LoadBillingDetails(strCurrentPatient)
            PAYMENT.Show()
            Me.Hide()
        Else
            ' If there are no billing details, show a message and stay on Form5
            MsgBox("There are currently no invoices.", vbOKOnly, "NOMG CLINIC")
        End If
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