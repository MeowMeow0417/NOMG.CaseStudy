Imports System.ComponentModel.DataAnnotations
Imports System.Drawing.Text
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports NOMG.CaseStudy.Form2

Public Class Form11
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click

        Dim ifRight As Boolean = False
        Dim intCount = 0

        If txtEmail.Text <> "" AndAlso txtMY.Text <> "" AndAlso txtCVC.Text <> "" AndAlso txtCardNum.Text <> "" Then
            For Each cred As CredCard In listCard
                If txtMY.Text = cred.getMY() AndAlso txtCVC.Text = cred.getCVC() AndAlso txtCardNum.Text = cred.getCardNum() Then
                    strCurrentCard = listCard(intCount)
                    ifRight = True
                    txtMY.Clear()
                    txtEmail.Clear()
                    txtCVC.Clear()
                    txtCardNum.Clear()
                    MsgBox("Your payment has been proccessed", vbOKOnly, "NOMG Clinic")
                    Exit For ' Exit loop since a matching card is found
                End If
                intCount += 1
            Next

            ' Check if a matching card is found
            If Not ifRight Then
                MsgBox("None of the credentials match", vbOKOnly, "NOMG Clinic")
                txtMY.Clear()
                txtEmail.Clear()
                txtCVC.Clear()
                txtCardNum.Clear()
            End If
        Else
            MsgBox("Please enter all the required details", vbOKOnly, "NOMG CLINIC")
        End If
    End Sub

    Class CredCard

        Private CVC, MY, CardNum As String

        Public Sub New(ByVal tempCVC As String, ByVal tempMY As String, ByVal tempCard As String)
            CVC = tempCVC
            MY = tempMY
            CardNum = tempCard
        End Sub

        Public Sub New()

        End Sub

        Public Sub CardDetails(ByVal tempCVC As String, ByVal tempMY As String, ByVal tempCard As String)
            CVC = tempCVC
            MY = tempMY
            CardNum = tempCard
        End Sub

        Public Function getCVC() As String
            Return CVC
        End Function
        Public Function getMY() As String
            Return MY
        End Function
        Public Function getCardNum() As String
            Return CardNum
        End Function
    End Class

    Public strCurrentCard As CredCard

    'set for 'temp' data storing
    Public listCard As New List(Of CredCard)

    Sub main()
        Dim Cred1 As New CredCard("123", "06/2025", "1234 5678 9012 3456")
        Dim Cred2 As New CredCard("789", "12/2023", "9876 5432 1098 7654")
        Dim Cred3 As New CredCard("246", "09/2024", "4567 8901 2345 6789")
        Dim Cred4 As New CredCard("555", "03/2026", "7890 1234 5678 9012")
        Dim Cred5 As New CredCard("333", "11/2022", "3210 9876 5432 1098")

        listCard.Add(Cred1)
        listCard.Add(Cred2)
        listCard.Add(Cred3)
        listCard.Add(Cred4)
        listCard.Add(Cred5)
    End Sub
End Class