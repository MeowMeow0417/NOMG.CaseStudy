Imports System.ComponentModel.DataAnnotations
Imports System.Drawing.Text
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports NOMG.CaseStudy.Form2
Imports System.IO

Public Class PAYMENT
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form5.Show()
        Me.Close()
    End Sub

    Public strCurrentCard As Billing
    Public Shared listCard As New List(Of Billing)

    Private Const BillingDataFile As String = "billingData.txt"

    Public Sub New() ' Storing temporary data for billing
        InitializeComponent()
        LoadBillingData()
    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form2.strCurrentPatient Is Nothing Then
            MessageBox.Show("You must be logged in to access this page.")
            Me.Close()
            Form2.Show()
        Else
            LoadBillingDetails(Form2.strCurrentPatient)
        End If
    End Sub

    Public Sub LoadBillingDetails(currentPatient As Form2.Patient)
        Dim patientBilling As Billing = listCard.Find(Function(b) b.getEmail() = currentPatient.getPatientEmail())

        If patientBilling IsNot Nothing Then
            strCurrentCard = patientBilling
            Dim check() As Double = strCurrentCard.getCheckUp()

            TxtBill.Text = strCurrentCard.getBill()
            TxtEmail.Text = strCurrentCard.getEmail()
            TxtInvoice.Text = strCurrentCard.getInvoice()

            ' Display checkup data
            lbl1.Text = check(0).ToString()
            lbl2.Text = check(1).ToString()
            lbl3.Text = check(2).ToString()
            lbl4.Text = check(3).ToString()
            lbl5.Text = check(4).ToString()
            lbl6.Text = check(5).ToString()

            t1.Text = (check(0) * 15).ToString()
            t2.Text = (check(1) * 25).ToString()
            t3.Text = (check(2) * 20).ToString()
            t4.Text = (check(3) * 1500).ToString()
            t5.Text = (check(4) * 2000).ToString()
            t6.Text = (check(5) * 500).ToString()

            lblTamount.Text = (Val(t1.Text) + Val(t2.Text) + Val(t3.Text) + Val(t4.Text) + Val(t5.Text) + Val(t6.Text)).ToString()
        Else
            Dim result As MsgBoxResult = MsgBox("There are currently no invoice.", vbOKOnly, "NOMG CLINIC")
            If result = MsgBoxResult.Ok Then
                Form5.Show()
                Me.Hide()
            Else
                Form5.Show()
                Me.Hide()
            End If
        End If


        TxtBill.Visible = True
        TxtEmail.Visible = True
        TxtInvoice.Visible = True
        lbl1.Visible = True
        lbl2.Visible = True
        lbl3.Visible = True
        lbl4.Visible = True
        lbl5.Visible = True
        lbl6.Visible = True
        t1.Visible = True
        t2.Visible = True
        t3.Visible = True
        t4.Visible = True
        t5.Visible = True
        t6.Visible = True
    End Sub

    ' Save billing data to a file
    Public Shared Sub SaveBillingData()
        ' Remove existing billing data for the same email before saving
        listCard = listCard.GroupBy(Function(b) b.getEmail()).Select(Function(g) g.Last()).ToList()

        Using writer As New StreamWriter(BillingDataFile, False)
            For Each billing In listCard
                ' Write data in correct order
                writer.WriteLine($"{billing.getEmail()},{billing.getBill()},{billing.getInvoice()},{billing.getCheckUp()(0)},{billing.getCheckUp()(1)},{billing.getCheckUp()(2)},{billing.getCheckUp()(3)},{billing.getCheckUp()(4)},{billing.getCheckUp()(5)}")
            Next
        End Using
    End Sub

    ' Load billing data from a file
    Public Sub LoadBillingData()
        If File.Exists(BillingDataFile) Then
            listCard.Clear()
            Using reader As New StreamReader(BillingDataFile)
                Dim line As String
                While (InlineAssignHelper(line, reader.ReadLine())) IsNot Nothing
                    Dim parts() As String = line.Split(","c)
                    If parts.Length = 9 Then
                        Dim billing As New Billing(CInt(parts(3)), CInt(parts(4)), CInt(parts(5)), CInt(parts(6)), CInt(parts(7)), CInt(parts(8)), parts(0), parts(1), parts(2))
                        listCard.Add(billing)
                    End If
                End While
            End Using
        End If
    End Sub

    ' Helper method to allow inline assignment in While loop
    Private Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function

    ' Billing class definition
    Public Class Billing
        Private C1, C2, V1, V2, V3, V4 As Integer
        Private Email, Bill, Invoice As String

        Public Sub New(ByVal tempV1 As Integer, ByVal tempV2 As Integer, ByVal tempV3 As Integer, ByVal tempV4 As Integer, ByVal tempC1 As Integer, ByVal tempC2 As Integer, ByVal tempE As String, ByVal tempB As String, ByVal tempI As String)
            V1 = tempV1
            V2 = tempV2
            V3 = tempV3
            V4 = tempV4
            C1 = tempC1
            C2 = tempC2
            Email = tempE
            Bill = tempB
            Invoice = tempI
        End Sub

        Public Sub New()
        End Sub

        Public Sub setDetails(ByVal tempE As String, ByVal tempB As String, ByVal tempI As String)
            Email = tempE
            Bill = tempB
            Invoice = tempI
        End Sub

        Public Sub setPay(ByVal tempV1 As Integer, ByVal tempV2 As Integer, ByVal tempV3 As Integer, ByVal tempV4 As Integer, ByVal tempC1 As Integer, ByVal tempC2 As Integer)
            V1 = tempV1
            V2 = tempV2
            V3 = tempV3
            V4 = tempV4
            C1 = tempC1
            C2 = tempC2
        End Sub

        Public Function getCheckUp() As Double()
            Return {V1, V2, V3, V4, C1, C2}
        End Function

        Public Function getEmail() As String
            Return Email
        End Function

        Public Function getBill() As String
            Return Bill
        End Function

        Public Function getInvoice() As String
            Return Invoice
        End Function
    End Class
End Class
