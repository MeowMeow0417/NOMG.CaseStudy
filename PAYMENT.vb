Imports System.ComponentModel.DataAnnotations
Imports System.Drawing.Text
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports NOMG.CaseStudy.Form2

Public Class PAYMENT

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form5.Show()
        Me.Close()
    End Sub

    Public strCurrentCard As Billing
    Public listCard As New List(Of Billing)


    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form2.strCurrentPatient Is Nothing Then
            MessageBox.Show("You must be logged in to access this page.")
            Me.Close()
            Form2.Show()
        Else

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


            lbl1.Text = check(0)
            lbl2.Text = check(1)
            lbl3.Text = check(2)
            lbl4.Text = check(3)
            lbl5.Text = check(4)
            lbl6.Text = check(5)

            t1.Text = (check(0) * 15)
            t2.Text = (check(1) * 25)
            t3.Text = (check(2) * 20)
            t4.Text = (check(3) * 1500)
            t5.Text = (check(4) * 2000)
            t6.Text = (check(5) * 500)

            lblTamount.Text = Val(t1.Text) + Val(t2.Text) + Val(t3.Text) + Val(t4.Text) + Val(t5.Text) + Val(t6.Text)
        Else

            Dim result As MsgBoxResult

            result = MsgBox("There are currently no invoice.", vbOKOnly, "NOMG CLINIC")
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


    ' Define the Billing class
    Public Class Billing
        Private C1, C2, V1, V2, V3, V4 As Integer
        Private Email, Bill, Invoice As String

        Public Sub New(ByVal tempC1 As Integer, ByVal tempC2 As Integer, ByVal tempV1 As Integer, ByVal tempV2 As Integer, ByVal tempV3 As Integer, ByVal tempV4 As Integer, ByVal tempE As String, ByVal tempB As String, ByVal tempI As String)
            C1 = tempC1
            C2 = tempC2
            V1 = tempV1
            V2 = tempV2
            V3 = tempV3
            V4 = tempV4
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

        Public Function getCheckUp() As Array
            Dim ACheck(5) As Double
            ACheck(0) = V1
            ACheck(1) = V2
            ACheck(2) = V3
            ACheck(3) = V4
            ACheck(4) = C1
            ACheck(5) = C2
            Return ACheck
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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class