Imports System.IO

Public Class PatientInput
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PatientDatabase.txt")
        If File.Exists(filePath) Then
            Dim patientDetails As String() = File.ReadAllLines(filePath)
            For Each detail As String In patientDetails
                ' Process each detail if necessary
            Next
        End If
    End Sub

    Private Function AllFieldsFilled() As Boolean
        If txtName.Text = "" OrElse txtMI.Text = "" OrElse txtLastName.Text = "" OrElse txtAge.Text = "" OrElse
           txtBaby.Text = "" OrElse txtGender.Text = "" OrElse txtCivil.Text = "" OrElse txtAddress.Text = "" OrElse
           txtLMC.Text = "" OrElse txtVitamin.Text = "" Then
            Return False
        End If
        Return True
    End Function

    Public Class PatientDetails
        Public Property Name As String
        Public Property MI As String
        Public Property LastName As String
        Public Property Age As String
        Public Property Baby As String
        Public Property Gender As String
        Public Property CivilStat As String
        Public Property Address As String
        Public Property LMC As String
        Public Property Vitamin As String
        Public Property AssignedOB As String
        Public Property GestationalAgeWeeks As Integer

        Public Sub New()
        End Sub

        Public Sub New(name As String, mi As String, lastName As String, age As String, baby As String, gender As String, civilStat As String, address As String, lmc As String, vitamin As String)
            Me.Name = name
            Me.MI = mi
            Me.LastName = lastName
            Me.Age = age
            Me.Baby = baby
            Me.Gender = gender
            Me.CivilStat = civilStat
            Me.Address = address
            Me.LMC = lmc
            Me.Vitamin = vitamin
            Me.AssignedOB = AssignOB()
            Me.GestationalAgeWeeks = CalculateGestationalAgeWeeks(lmc)
        End Sub

        Private Function AssignOB() As String
            Dim OBs As List(Of String) = New List(Of String) From {
                "Dr. Jacob Panesa", "Dr. Gilbert Cura", "Dr. Irish Ramirez",
                "Dr. Jordan Romero", "Dr. Dominic Salta", "Dr. Mary Joy Bondoc"
            }
            Dim rnd As New Random()
            Return OBs(rnd.Next(0, OBs.Count))
        End Function

        Private Function CalculateGestationalAgeWeeks(lmc As String) As Integer
            Dim lmcDate As DateTime
            If DateTime.TryParse(lmc, lmcDate) Then
                Dim today As DateTime = DateTime.Now
                Dim gestationalAge As TimeSpan = today.Subtract(lmcDate)
                Return CInt(Math.Floor(gestationalAge.TotalDays / 7))
            Else
                Return -1 ' Invalid LMC date
            End If
        End Function
    End Class

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Check if all fields have values
        If Not AllFieldsFilled() Then
            MsgBox("Please enter all the required details", vbOKOnly, "NOMG CLINIC")
            Return
        End If

        Dim newDetails As New PatientDetails(txtName.Text, txtMI.Text, txtLastName.Text, txtAge.Text, txtBaby.Text, txtGender.Text, txtCivil.Text, txtAddress.Text, txtLMC.Text, txtVitamin.Text)
        If newDetails.GestationalAgeWeeks = -1 Then
            MsgBox("Invalid LMC date provided", vbOKOnly, "NOMG CLINIC")
            Return
        End If

        SavePatientDetails(newDetails)

        MsgBox("Your account is now all set", vbOKOnly, "NOMG CLINIC")

        Form2.Show()
        Me.Close()
    End Sub

    Private Sub SavePatientDetails(newDetails As PatientDetails)
        Try
            Dim filePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PatientDatabase.txt")
            Dim gestationalAgeFilePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "GestationalAge.txt")

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
                writer.WriteLine("Vitamin: " & newDetails.Vitamin)
                writer.WriteLine("Assigned OB: " & newDetails.AssignedOB)
                writer.WriteLine()
            End Using

            Using gestationalAgeWriter As New StreamWriter(gestationalAgeFilePath, True)
                gestationalAgeWriter.WriteLine("Name: " & newDetails.Name)
                gestationalAgeWriter.WriteLine("Gestational Age: " & newDetails.GestationalAgeWeeks & " weeks")
                gestationalAgeWriter.WriteLine()
            End Using

            MessageBox.Show("Patient details saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving patient details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub txtBaby_TextChanged(sender As Object, e As EventArgs) Handles txtBaby.TextChanged
        ' Handle text change event if necessary
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Form3.Show()

    End Sub
End Class
