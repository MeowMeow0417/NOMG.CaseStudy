Imports System.Net.Security
Imports NOMG.CaseStudy.Form1

Public Class Form2

    'FOR ADMIN Login
    Class Admin
        Private strAdmin As String
        Private strAdminPass As String

        'for setting new admins in the future
        Public Sub New(ByVal strTempAdmin As String, ByVal strTempAdminPass As String)
            strAdmin = strTempAdmin
            strAdminPass = strTempAdminPass
        End Sub
        Public Sub New()

        End Sub

        'method for getting admins creds
        Public Sub setAdminCred(ByVal strTempName As String, ByVal strTempPass As String)
            strAdmin = strTempName
            strAdminPass = strTempPass
        End Sub

        'for returning the admins username and pass
        Public Function getAdminUser() As String
            Return strAdmin
        End Function
        Public Function getAdminPass() As String
            Return strAdminPass
        End Function

    End Class


    'list for Patient creds
    Public listPatient As New List(Of Patient)

    'FOR Patient Login
    Class Patient
        Private strPatient As String
        Private strPass As String
        Private strEmail As String


        Public Sub New(ByVal strTempPatient As String, ByVal strPPass As String)
            strPatient = strTempPatient
            strPass = strPPass
        End Sub
        Public Sub New()

        End Sub

        'method for getting patients creds
        Public Sub setPatientCred(ByVal strTempPatient As String, ByVal strPPass As String)
            strPatient = strTempPatient
            strPass = strPPass
        End Sub

        Public Sub setPatientEmail(ByVal strPaEmail As String)
            strEmail = strPaEmail
        End Sub

        'for returning the admins username, pass and email
        Public Function getPatient() As String
            Return strPatient
        End Function
        Public Function getPatientPass() As String
            Return strPass
        End Function
        Public Function getPatientEmail() As String
            Return strEmail
        End Function

    End Class

    Public Sub New()
        InitializeComponent()
        Dim Patient1 As New Patient("Juana", "1234")
        listPatient.Add(Patient1)

    End Sub

    Dim admin1 As New Admin("Admin", "Admin")

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        If txtUser.Text = admin1.getAdminUser And txtPass.Text = admin1.getAdminPass Then
            MsgBox("LogIn success as admin", vbOKOnly, "NOMG Clinic")

            Form4.Show()
            Me.Hide()


        Else 'add an elif function here 


            For Each Patient In listPatient
                If txtUser.Text = Patient.getPatient And txtPass.Text = Patient.getPatientPass Then
                    MsgBox("LogIn success as Patient", vbOKOnly, "NOMG Clinic")

                    Me.Hide()

                End If
            Next


        End If
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs)
        Form3.Show()
        Me.Hide()

    End Sub
End Class