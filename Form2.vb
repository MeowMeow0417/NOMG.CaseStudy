Imports System.IO
Imports System.Net.Security
Imports NOMG.CaseStudy.Form1
Imports NOMG.CaseStudy.Form3

Public Class Form2
    ' Declare a variable to hold the instance of Form2
    Public Shared Form2Instance As Form2
    Public Shared Form6Instance As Form6

    ' Initialize the list of patients with a default patient
    Private Sub InitializePatients()
        Dim Patient1 As New Patient("Juana", "1234")
        listPatient.Add(Patient1)
    End Sub

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
        If Not isAdminLoggedIn Then
            Dim userManager As New UserManager()
            If userManager.AuthenticateUser(txtUser.Text, txtPass.Text) Then
                isPatientLoggedIn = True
                Form9.PatientName = txtUser.Text
                ' Save user information to a text file
                SaveUserInformation()
            End If
        End If

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

    Private Sub SaveUserInformation()
        ' Generate a unique file name for the user
        Dim fileName As String = "UserInfo_" & DateTime.Now.ToString("yyyyMMddHHmmss") & ".txt"

        Try
            ' Get the path to the folder where user information will be saved
            Dim folderPath As String = Path.Combine(Application.StartupPath, "UserInformation")

            ' Create the folder if it does not exist
            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
            End If

            ' Combine folder path with file name to get full file path
            Dim filePath As String = Path.Combine(folderPath, fileName)

            ' Create or overwrite the text file with user information
            Using writer As New StreamWriter(filePath)
                ' Write user information to the file

                If Form6Instance IsNot Nothing Then
                    writer.WriteLine("Last Name: " & Form6Instance.txtLastName.Text)
                    writer.WriteLine("Age: " & Form6Instance.txtAge.Text)
                    ' Add other fields as needed
                End If
            End Using

            ' Display a success message
            MessageBox.Show("User information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ' Display an error message if saving fails
            MessageBox.Show("An error occurred while saving user information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'btn for sign-up
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Form7.Show()
        Me.Hide()
    End Sub

    'list for Patient details
    Public listDetails As New List(Of PatientDetails)

    Class PatientDetails
        Public Name, MI, LastName, Age, Baby, Address, Gender, CivilStat, LMC, Vitamin As String

        ' Constructor with parameters to set all details including Vitamin
        Public Sub New(ByVal tempName As String, ByVal tempMI As String, ByVal tempLast As String, ByVal tempAdd As String, ByVal tempAge As String, ByVal tempBaby As String, ByVal tempGender As String, ByVal tempCivil As String, ByVal tempLMC As String, ByVal tempVitamin As String)
            Name = tempName
            MI = tempMI
            LastName = tempLast
            Age = tempAge
            Baby = tempBaby
            Gender = tempGender
            Address = tempAdd
            CivilStat = tempCivil
            LMC = tempLMC
            Vitamin = tempVitamin ' Set Vitamin
        End Sub

        ' Method to set details
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
    End Class

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    ' Method to get a list of patient names
    Public Shared Function GetPatientNames(ByVal listDetails As List(Of PatientDetails)) As List(Of String)
        Dim patientNames As New List(Of String)

        For Each patientDetail As PatientDetails In listDetails
            ' Add the name of each patient to the list
            patientNames.Add(patientDetail.Name)
        Next

        Return patientNames
    End Function

End Class