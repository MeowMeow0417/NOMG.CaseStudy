Imports System.Net.Security
Imports NOMG.CaseStudy.Form1

Public Class Form2

    Class Admin 'FOR ADMIN Login
        Private strAdmin, strAdminPass As String


        'for setting new admins
        Public Sub New(ByVal strTempAdmin As String, ByVal strTempAdminPass As String)
            strAdmin = strTempAdmin
            strAdminPass = strTempAdminPass
        End Sub
        Public Sub New()

        End Sub

        'method for setting admins creds
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

    'for the data to be usable in other forms
    Public strCurrentPatient As Patient

    'list for Patient creds
    Public listPatient As New List(Of Patient)



    Public Sub New() 'storing data for the Patien/s name and password
        InitializeComponent()
        Dim Patient1 As New Patient("Juana", "1234")
        listPatient.Add(Patient1)
    End Sub

    Class Patient 'FOR PATIENT LogIn
        Private strPatient, strPass, strEmail As String

        'for setting new patients
        Public Sub New(ByVal strTempPatient As String, ByVal strPPass As String)
            strPatient = strTempPatient
            strPass = strPPass
        End Sub
        Public Sub New()

        End Sub

        'method for setting patients creds
        Public Sub setPatientCred(ByVal strTempPatient As String, ByVal strPPass As String, ByVal strPaEmail As String)
            strPatient = strTempPatient
            strPass = strPPass
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


    Dim admin1 As New Admin("Admin", "Admin") 'Admin user and Password'

    Dim form5Instance As New Form5
    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Dim isAdminLoggedIn As Boolean = False
        Dim isPatientLoggedIn As Boolean = False

        ' Check if admin is logging in
        If txtUser.Text = admin1.getAdminUser AndAlso txtPass.Text = admin1.getAdminPass Then
            isAdminLoggedIn = True
        End If

        ' Check if patient is logging in
        Dim intCount = 0
        For Each patient As Patient In listPatient
            If txtUser.Text = patient.getPatient AndAlso txtPass.Text = patient.getPatientPass Then
                isPatientLoggedIn = True
                strCurrentPatient = listPatient(intCount)
                Exit For ' Exit the loop once a match is found
            End If
            intCount += 1
        Next

        ' Check login status and show appropriate message and form
        If isAdminLoggedIn Then
            MsgBox("Successfully Log-In as the Admin", vbOKOnly, "NOMG Clinic")
            txtUser.Clear()
            txtPass.Clear()
            Form4.Show()
            Me.Hide()
        ElseIf isPatientLoggedIn Then
            txtUser.Clear()
            txtPass.Clear()
            Form5.Show()
            form5Instance.lblUserName.Text = txtUser.Text 'fix this, it's for showing who is the user
            Me.Hide()
        Else
            MsgBox("Invalid username or password", vbOKOnly, "NOMG Clinic")
        End If

    End Sub

    'btn for sign-up
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Form7.Show()
        Me.Hide()
    End Sub

    'list for Patient details
    Public listDetails As New List(Of PatientDetails)

    Class PatientDetails

        Private Name, MI, LastName, Age, Baby, Address, Gender, CivilStat, LMC As String

        'for setting new data
        Public Sub New(ByVal tempName As String, ByVal tempMI As String, ByVal tempLast As String, ByVal tempAdd As String, ByVal tempAge As String, ByVal tempBaby As String, ByVal tempGender As String, ByVal tempCivil As String, ByVal tempLMC As String)
            Name = tempName
            MI = tempMI
            LastName = tempLast
            Age = tempAge
            Baby = tempBaby
            Gender = tempGender
            Address = tempAdd
            CivilStat = tempCivil
            LMC = tempLMC
        End Sub
        Public Sub New()

        End Sub

        'for setting details
        Public Sub setDetails1(ByVal tempName As String, ByVal tempMI As String, ByVal tempLast As String, ByVal tempAge As String)
            Name = tempName
            MI = tempMI
            LastName = tempLast
            Age = tempAge

        End Sub

        Public Sub setDetails2(ByVal tempBaby As String, ByVal tempGender As String, ByVal tempAdd As String, ByVal tempCivil As String, ByVal tempLMC As String)
            Baby = tempBaby
            Gender = tempGender
            CivilStat = tempCivil
            Address = tempAdd
            LMC = tempLMC
        End Sub


        'for setting new data

    End Class

End Class