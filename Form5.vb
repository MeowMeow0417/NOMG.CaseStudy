Public Class Form5


    Private Sub btnSched_Click(sender As Object, e As EventArgs) Handles btnSched.Click

        lblUserName.Text = Form2.strCurrentPatient.getPatient
        pnSched.Visible = True
        pnRem.Visible = False
        pnPayment.Visible = False
    End Sub

    Private Sub btnRem_Click(sender As Object, e As EventArgs) Handles btnRem.Click

        pnSched.Visible = False
        pnRem.Visible = True
        pnPayment.Visible = False

    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        pnSched.Visible = False
        pnRem.Visible = False
        pnPayment.Visible = True
    End Sub
End Class