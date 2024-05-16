Imports System.ComponentModel.DataAnnotations
Imports System.Drawing.Text
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports NOMG.CaseStudy.Form2

Public Class Form11
    Public strCurrentCard As Billing

    ' Set for 'temp' data storing
    Public listCard As New List(Of Billing)

    Public Sub New() ' Storing temporary data for billing
        InitializeComponent()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub btnInvoice_Click(sender As Object, e As EventArgs) Handles btnInvoice.Click
        ' Check if strCurrentCard is not Nothing before accessing its properties
        If Me.strCurrentCard IsNot Nothing Then
            ' Retrieve the checkup data
            Dim check() As Double = Me.strCurrentCard.getCheckUp()

            ' Set the text boxes with actual data
            TxtBill.Text = Me.strCurrentCard.getBill()
            TxtEmail.Text = Me.strCurrentCard.getEmail()
            TxtInvoice.Text = Me.strCurrentCard.getInvoice()

            ' Display checkup data
            lbl1.Text = check(0)
            lbl2.Text = check(1)
            lbl3.Text = check(2)
            lbl4.Text = check(3)
            lbl5.Text = check(4)
            lbl6.Text = check(5)

            t1.Text = (check(0) * 2000)
            t2.Text = (check(1) * 500)
            t3.Text = (check(2) * 15)
            t4.Text = (check(3) * 25)
            t5.Text = (check(4) * 20)
            t6.Text = (check(5) * 1500)

            lblTamount.Text = Val(t1.Text) + Val(t2.Text) + Val(t3.Text) + Val(t4.Text) + Val(t5.Text) + Val(t6.Text)
        Else
            ' Handle the case where strCurrentCard is null
            TxtBill.Text = "n/a"
            TxtEmail.Text = "n/a"
            TxtInvoice.Text = "n/a"

            ' Display default values for checkup data
            lbl1.Text = "0"
            lbl2.Text = "0"
            lbl3.Text = "0"
            lbl4.Text = "0"
            lbl5.Text = "0"
            lbl6.Text = "0"

            t1.Text = "0"
            t2.Text = "0"
            t3.Text = "0"
            t4.Text = "0"
            t5.Text = "0"
            t6.Text = "0"

            lblTamount.Text = "0"
        End If

        ' Make text boxes and labels visible
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

        Public Sub setPay(ByVal tempC1 As Integer, ByVal tempC2 As Integer, ByVal tempV1 As Integer, ByVal tempV2 As Integer, ByVal tempV3 As Integer, ByVal tempV4 As Integer)
            C1 = tempC1
            C2 = tempC2
            V1 = tempV1
            V2 = tempV2
            V3 = tempV3
            V4 = tempV4
        End Sub

        Public Function getCheckUp() As Array
            Dim ACheck(5) As Double
            ACheck(0) = C1
            ACheck(1) = C2
            ACheck(2) = V1
            ACheck(3) = V2
            ACheck(4) = V3
            ACheck(5) = V4
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
End Class
