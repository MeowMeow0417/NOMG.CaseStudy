Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Runtime.Serialization
Imports System.Security.Cryptography.Xml

Public Class PatientInput
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PatientDatabase.txt")
        If File.Exists(filePath) Then
            Dim patientDetails As String() = File.ReadAllLines(filePath)
            For Each detail As String In patientDetails

            Next
        End If
    End Sub
    Private Function AllFieldsFilled() As Boolean

        If txtName.Text = "" OrElse
           txtMI.Text = "" OrElse
           txtLastName.Text = "" OrElse
           txtAge.Text = "" OrElse
           txtBaby.Text = "" OrElse
           txtGender.Text = "" OrElse
           txtCivil.Text = "" OrElse
           txtAddress.Text = "" OrElse
           txtLMC.Text = "" OrElse
           txtVitamin.Text = "" Then
            Return False
        End If
        Return True
    End Function

    Public Class PatientDetails
        <DataMember>
        Public Property Name As String
        <DataMember>
        Public Property MI As String
        <DataMember>
        Public Property LastName As String
        <DataMember>
        Public Property Age As String
        <DataMember>
        Public Property Baby As String
        <DataMember>
        Public Property Address As String
        <DataMember>
        Public Property Gender As String
        <DataMember>
        Public Property CivilStat As String
        <DataMember>
        Public Property LMC As String
        <DataMember>
        Public Property Vitamin As String
        <DataMember>
        Public Property NextCheckup As DateTime

        Public Sub New()
        End Sub

        Public Sub New(ByVal tempName As String, ByVal tempMI As String, ByVal tempLastName As String, ByVal tempAge As String, ByVal tempBaby As String, ByVal tempAddress As String, ByVal tempGender As String, ByVal tempCivilStat As String, ByVal tempLMC As String, ByVal tempVitamin As String)
            Name = tempName
            MI = tempMI
            LastName = tempLastName
            Age = tempAge
            Baby = tempBaby
            Address = tempAddress
            Gender = tempGender
            CivilStat = tempCivilStat
            LMC = tempLMC
            Vitamin = tempVitamin
        End Sub
    End Class

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Check if all fields have values
        If Not AllFieldsFilled() Then
            MsgBox("Please enter all the required details", vbOKOnly, "NOMG CLINIC")
            Return
        End If



        Dim newDetails As New PatientDetails(txtName.Text, txtMI.Text, txtLastName.Text, txtAge.Text, txtBaby.Text, txtAddress.Text, txtGender.Text, txtCivil.Text, txtLMC.Text, txtVitamin.Text)

        SavePatientDetails(newDetails)


        MsgBox("Your account is now all set", vbOKOnly, "NOMG CLINIC")

        Form2.Show()
        Me.Close()
    End Sub

    Private Sub SavePatientDetails(newDetails As PatientDetails)
        Try
            Dim filePath As String = Path.Combine(Application.StartupPath, "PatientDatabase.txt")

            Using writer As New StreamWriter(filePath, True)
                writer.WriteLine("Name: " & newDetails.Name)
                writer.WriteLine("Middle Initial: " & newDetails.MI)
                writer.WriteLine("Last Name: " & newDetails.LastName)
                writer.WriteLine("Age: " & newDetails.Age)
                writer.WriteLine("Baby: " & newDetails.Baby)
                writer.WriteLine("Gender: " & newDetails.Gender)
                writer.WriteLine("Civil Status: " & newDetails.CivilStat)
                writer.WriteLine("Address: " & newDetails.Address)
                writer.WriteLine("LMC: " & newDetails.LMC)
                writer.WriteLine("Vitamin: ")

                For Each line As String In newDetails.Vitamin.Split(New String() {Environment.NewLine}, StringSplitOptions.None)
                    writer.WriteLine("    " & line)
                Next

                writer.WriteLine()
            End Using

            MessageBox.Show("Patient details saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving patient details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub txtBaby_TextChanged(sender As Object, e As EventArgs) Handles txtBaby.TextChanged

    End Sub
End Class