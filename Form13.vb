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
        lblTamount.Text = (C1 * 2000) + (C2 * 500) + (V1 * 15) + (V2 * 25) + (V3 * 20) + (V4 * 1500)


    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        txtCheck1.Clear()
        txtCheck2.Clear()
        txtVitamin1.Clear()
        txtVitamin2.Clear()
        txtVitamin3.Clear()
        txtVitamin4.Clear()
        lblTamount.Text = "0.00"

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click


    End Sub


    Class Payment

        Private V1, V2, V3, V4, V5, C1, C2 As Integer

        Public Sub setPayment(ByVal tempC1 As Integer, ByVal tempC2 As Integer, ByVal tempV1 As Integer, ByVal tempV2 As Integer, ByVal tempV3 As Integer, ByVal tempV4 As Integer)
            C1 = tempC1
            C2 = tempC2
            V1 = tempV1
            V2 = tempV2
            V3 = tempV3
            V4 = tempV4
        End Sub

        Public Sub New(ByVal tempC1 As Integer, ByVal tempC2 As Integer, ByVal tempV1 As Integer, ByVal tempV2 As Integer, ByVal tempV3 As Integer, ByVal tempV4 As Integer)
            C1 = tempC1
            C2 = tempC2
            V1 = tempV1
            V2 = tempV2
            V3 = tempV3
            V4 = tempV4
        End Sub

        Public Sub New()

        End Sub

        Public Function getPayment() As String
            Return C1
            Return C2
            Return V1
            Return V2
            Return V3
            Return V4
        End Function
    End Class


End Class