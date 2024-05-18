Public Class Form13
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form4.Show()
        Me.Close()
    End Sub

    Public strCurrentPatient As Form2.Patient

    ' Constructor to accept the current patient
    Public Sub New(ByVal currentPatient As Form2.Patient)
        InitializeComponent()
        strCurrentPatient = currentPatient
    End Sub

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load patient usernames into the ListBox
        lbBill.Items.Clear()
        For Each patient As Form2.Patient In Form2.listPatient
            lbBill.Items.Add(patient.getPatient())
        Next
    End Sub

    Private V1, V2, V3, V4, V5, C1, C2 As Integer

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Reading the inputs
        C1 = If(Integer.TryParse(txtCheck1.Text, C1), C1, 0)
        C2 = If(Integer.TryParse(txtCheck2.Text, C2), C2, 0)
        V1 = If(Integer.TryParse(txtVitamin1.Text, V1), V1, 0)
        V2 = If(Integer.TryParse(txtVitamin2.Text, V2), V2, 0)
        V3 = If(Integer.TryParse(txtVitamin3.Text, V3), V3, 0)
        V4 = If(Integer.TryParse(txtVitamin4.Text, V4), V4, 0)

        ' Calculates the input
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

    ' Handle the btnSend_Click to send billing details to Form11
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        ' Ensure the current patient's email matches before adding to Form11
        If strCurrentPatient.getPatientEmail() = txtEmail.Text Then
            Dim newPayment As New Form11.Billing
            newPayment.setPay(Val(txtVitamin1.Text), Val(txtVitamin2.Text), Val(txtVitamin3.Text), Val(txtVitamin4.Text), Val(txtCheck1.Text), Val(txtCheck2.Text))
            newPayment.setDetails(txtEmail.Text, strCurrentPatient.getPatient(), txtInvoice.Text)

            ' Ensure Form11.listCard is initialized
            If Form11.listCard Is Nothing Then
                Form11.listCard = New List(Of Form11.Billing)
            End If

            ' Pass the newPayment instance to Form11
            Form11.listCard.Add(newPayment)
            Form11.strCurrentCard = newPayment

            ' Check if the data has been added
            If Form11.listCard.Contains(newPayment) Then
                MessageBox.Show("Invoice successfully sent to patient.", "NOMG CLINIC", MessageBoxButtons.OK)
                btnClearAll_Click(sender, e) ' Clear the form
            Else
                MessageBox.Show("Error on sending Invoice.")
            End If
        Else
            MessageBox.Show("Invalid patient details.")
        End If
    End Sub

    ' Handle the btnSelect click to populate email for the selected patient
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        ' Check if an item is selected in the ListBox
        If lbBill.SelectedItem IsNot Nothing Then
            ' Get the selected username
            Dim selectedUsername As String = lbBill.SelectedItem.ToString()

            ' Find the patient with the selected username
            For Each patient As Form2.Patient In Form2.listPatient
                If patient.getPatient() = selectedUsername Then
                    ' Output the email associated with the selected username
                    txtEmail.Text = patient.getPatientEmail()
                    Exit For
                End If
            Next
        Else
            MessageBox.Show("Please select a username from the list.")
        End If
    End Sub
End Class
