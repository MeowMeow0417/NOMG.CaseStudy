Public Class BILLING
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ADMIN_.Show()
        Me.Close()
    End Sub

    Public strCurrentPatient As Form2.Patient

    Public Sub New(ByVal currentPatient As Form2.Patient)
        InitializeComponent()
        strCurrentPatient = currentPatient
    End Sub

    Private Sub BILLING_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set ListBox to multi-select mode
        lbBill.SelectionMode = SelectionMode.MultiExtended

        ' Load patient usernames into the ListBox
        LoadPatientUsernames()
    End Sub

    Private Sub LoadPatientUsernames()
        lbBill.Items.Clear()
        For Each patient As Form2.Patient In Form2.listPatient
            lbBill.Items.Add(patient.getPatient())
        Next
    End Sub

    Private V1, V2, V3, V4, V5, C1, C2 As Integer

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        C1 = If(Integer.TryParse(txtCheck1.Text, C1), C1, 0)
        C2 = If(Integer.TryParse(txtCheck2.Text, C2), C2, 0)
        V1 = If(Integer.TryParse(txtVitamin1.Text, V1), V1, 0)
        V2 = If(Integer.TryParse(txtVitamin2.Text, V2), V2, 0)
        V3 = If(Integer.TryParse(txtVitamin3.Text, V3), V3, 0)
        V4 = If(Integer.TryParse(txtVitamin4.Text, V4), V4, 0)
        lblTamount.Text = (V1 * 15) + (V2 * 25) + (V3 * 20) + (V4 * 1500) + (C1 * 2000) + (C2 * 500)
    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        txtEmail.Clear()
        txtInvoice.Clear()
        txtCheck1.Clear()
        txtCheck2.Clear()
        txtVitamin1.Clear()
        txtVitamin2.Clear()
        txtVitamin3.Clear()
        txtVitamin4.Clear()
        lblTamount.Text = "0"
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If lbBill.SelectedItems.Count > 0 Then
            For Each selectedUsername In lbBill.SelectedItems
                Dim selectedPatient As Form2.Patient = Form2.listPatient.Find(Function(p) p.getPatient() = selectedUsername.ToString())

                If selectedPatient IsNot Nothing Then
                    ' Remove existing billing for the same patient
                    PAYMENT.listCard.RemoveAll(Function(b) b.getEmail() = selectedPatient.getPatientEmail())

                    ' Create and add new billing
                    Dim newPayment As New PAYMENT.Billing()
                    newPayment.setPay(Val(txtVitamin1.Text), Val(txtVitamin2.Text), Val(txtVitamin3.Text), Val(txtVitamin4.Text), Val(txtCheck1.Text), Val(txtCheck2.Text))
                    newPayment.setDetails(txtEmail.Text, selectedPatient.getPatient(), txtInvoice.Text)
                    PAYMENT.listCard.Add(newPayment)

                    ' Save the updated billing data to the file
                    PAYMENT.SaveBillingData()
                    PAYMENT.strCurrentCard = newPayment
                    PAYMENT.strCurrentCard = newPayment

                    If result = MsgBoxResult.Ok Then
                        btnClearAll_Click(sender, e)
                        If PAYMENT.listCard.Contains(newPayment) Then
                            result = MsgBox("Invoice has been successfully sent.", vbOKOnly, "NOMG CLINIC")
                            If PAYMENT.listCard.Contains(newPayment) Then
                                result = MsgBox("Invoice has been successfully sent.", vbOKOnly, "NOMG CLINIC")
                                result = MsgBox("Invoice has been successfully sent.", vbOKOnly, "NOMG CLINIC")
                                result = MsgBox("Invoice has been successfully sent.", vbOKOnly, "NOMG CLINIC")
                            End If
                        Else
                            MessageBox.Show("Selected patient not found.")
                        End If
            Next
        Else
            MessageBox.Show("Please select at least one patient from the list.")
        End If
    End Sub

    ' Handle the btnSelect click to populate email for the selected patient

    If lbBill.SelectedItem IsNot Nothing Then

    Dim selectedUsername As String = lbBill.SelectedItem.ToString()


    For Each patient As Form2.Patient In Form2.listPatient
    If patient.getPatient() = selectedUsername Then

                    txtEmail.Text = patient.getPatientEmail()
                    Exit For
    End If
    Next
    Else
            MessageBox.Show("Please select a username from the list.")
        End If

End Class
End Class
