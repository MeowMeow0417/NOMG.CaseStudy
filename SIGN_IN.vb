Imports System.Net.Security
Imports NOMG.CaseStudy.SPLASH
Imports System.IO

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

    Dim admin1 As New Admin("Admin", "Admin") 'Admin user and Password'

    ' For the data to be usable in other forms
    Public strCurrentPatient As Patient

    ' List for Patient creds
    Public listPatient As New List(Of Patient)

    Public Sub New() ' Storing data for the Patient's name and password
        InitializeComponent()

        ' Load patients from the text file
        LoadPatientsFromFile("patients.txt")

        ' default patient
        'Dim Patient1 As New Patient("Juana", "1234", "example@gmail.com")
        'listPatient.Add(Patient1)

        SavePatientsToFile("patients.txt")
    End Sub

    Private Sub LoadPatientsFromFile(ByVal filePath As String)
        If File.Exists(filePath) Then
            Dim lines() As String = File.ReadAllLines(filePath)
            For Each line In lines
                Dim parts() As String = line.Split(","c)
                If parts.Length = 3 Then
                    Dim patient As New Patient(parts(0), parts(1), parts(2))
                    listPatient.Add(patient)
                End If
            Next
        End If
    End Sub

    Private Sub SavePatientsToFile(ByVal filePath As String)
        Using writer As New StreamWriter(filePath)
            For Each patient In listPatient
                writer.WriteLine($"{patient.getPatient()},{patient.getPatientPass()},{patient.getPatientEmail()}")
            Next
        End Using
    End Sub

    Public Sub AddPatient(ByVal strTempPatient As String, ByVal strPPass As String, ByVal strPaEmail As String)
        Dim newPatient As New Patient(strTempPatient, strPPass, strPaEmail)
        listPatient.Add(newPatient)
        SavePatientsToFile("patients.txt")
    End Sub

    Public Class Patient ' FOR PATIENT LogIn
        Private strPatient, strPass, strEmail As String

        ' For setting new patients
        Public Sub New(ByVal strTempPatient As String, ByVal strPPass As String)
            strPatient = strTempPatient
            strPass = strPPass
        End Sub

        Public Sub New(ByVal strTempPatient As String, ByVal strPPass As String, ByVal strPaEmail As String)
            strPatient = strTempPatient
            strPass = strPPass
            strEmail = strPaEmail
        End Sub

        Public Sub New()
        End Sub



        ' For returning the patient's username, pass and email
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
            ADMIN_.Show()
            Me.Hide()
        ElseIf isPatientLoggedIn Then
            MsgBox("Login Successful", vbOKOnly, "NOMG Clinic")
            txtUser.Clear()
            txtPass.Clear()
            strCurrentPatient = listPatient(intCount)
            Form5.strCurrentPatient = strCurrentPatient ' Pass current patient to Form5
            Form5.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect Username or Password", vbOKOnly, "NOMG Clinic")
        End If
    End Sub

    'btn for sign-up
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        HomePage.Show()
        Me.Hide()
    End Sub

    Private Sub passwordCheck_CheckedChanged(sender As Object, e As EventArgs) Handles passwordCheck.CheckedChanged
        If passwordCheck.Checked Then
            txtPass.PasswordChar = ""
        Else
            txtPass.PasswordChar = "*" ' You can use any character you prefer for masking
        End If
    End Sub

End Class