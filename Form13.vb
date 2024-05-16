Public Class Form13
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private V1, V2, V3, V4, V5, C1, C2 As Integer


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'reading the inputs
        C1 = If(Integer.TryParse(txtCheck1.Text, C1), C1, 0)
        C2 = If(Integer.TryParse(txtCheck2.Text, C2), C2, 0)
        V1 = If(Integer.TryParse(txtVitamin1.Text, V1), V1, 0)
        V2 = If(Integer.TryParse(txtVitamin2.Text, V2), V2, 0)
        V3 = If(Integer.TryParse(txtVitamin3.Text, V3), V3, 0)
        V4 = If(Integer.TryParse(txtVitamin4.Text, V4), V4, 0)

        'calcualtes the input
        lblTamount.Text = (V1 * 15) + (V2 * 25) + (V3 * 20) + (V4 * 1500) + (C1 * 2000) + (C2 * 500)


    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        txtEmail.Clear()
        txtInvoice.Clear()
        txtBill.Clear()
        txtCheck1.Clear()
        txtCheck2.Clear()
        txtVitamin1.Clear()
        txtVitamin2.Clear()
        txtVitamin3.Clear()
        txtVitamin4.Clear()
        lblTamount.Text = "0"

    End Sub


    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim newPayment As New Form11.Billing
        newPayment.setPay(Val(txtVitamin1.Text), Val(txtVitamin2.Text), Val(txtVitamin3.Text), Val(txtVitamin4.Text), Val(txtCheck1.Text), Val(txtCheck2.Text))
        newPayment.setDetails(txtEmail.Text, txtBill.Text, txtInvoice.Text)

        ' Pass the newPayment instance to Form11
        Form11.listCard.Add(newPayment)
        Form11.strCurrentCard = newPayment

        ' Check if the data has been added
        If Form11.listCard.Contains(newPayment) Then
            MessageBox.Show("Data added successfully.")
        Else
            MessageBox.Show("Failed to add data.")
        End If
    End Sub
End Class