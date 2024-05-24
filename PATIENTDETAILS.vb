Imports System.IO
Imports System.Text
Public Class PatientDetails
    Public Property Name As String
    Public Property MI As String
    Public Property LastName As String
    Public Property Age As String
    Public Property Baby As String
    Public Property Address As String
    Public Property Gender As String
    Public Property CivilStat As String
    Public Property LMC As String
    Public Property Vitamin As String
    Public Property AssignedOB As String
End Class
Public Class PATIENTDETAILS

    Private ReadOnly OBs As List(Of String) = New List(Of String) From {
    "Dr. Gilbert Cura", "Dr. Jacob Panesa", "Dr. Irish Ramirez",
    "Dr. Mary Bondoc", "Dr. Jordan Romero", "Dr. Dominic Salta", "Dr. Alice Guo"
}
    Private ReadOnly rnd As New Random()

    Private Function AssignOB() As String
        Return OBs(rnd.Next(OBs.Count))
    End Function


    Private Sub LoadPatientNames()
        Try
            Dim filePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PatientDatabase.txt")

            If File.Exists(filePath) Then
                Dim patientNames As New List(Of String)()

                Using reader As New StreamReader(filePath)
                    While Not reader.EndOfStream
                        Dim line As String = reader.ReadLine()
                        If line.StartsWith("Name: ") Then
                            Dim name As String = line.Substring("Name: ".Length)
                            patientNames.Add(name)
                        End If
                    End While
                End Using

                ListBox1.Items.AddRange(patientNames.ToArray())
            Else
                MessageBox.Show("Database file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading patient names: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPatientNames()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If ListBox1.SelectedIndex <> -1 Then
            Dim selectedPatientName As String = ListBox1.SelectedItem.ToString()
            Dim patientDetails As PatientDetails = GetPatientDetails(selectedPatientName)
            DisplayPatientDetails(patientDetails)
        Else
            MessageBox.Show("Please select a patient from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function GetPatientDetails(patientName As String) As PatientDetails
        Try
            Dim filePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PatientDatabase.txt")
            Using reader As New StreamReader(filePath)
                Dim details As PatientDetails = Nothing
                Dim foundPatient As Boolean = False

                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()

                    If line IsNot Nothing AndAlso line.StartsWith("Name: " & patientName) Then
                        foundPatient = True
                        details = New PatientDetails()
                        details.Name = patientName

                        Do
                            line = reader.ReadLine()
                            If line IsNot Nothing AndAlso line.StartsWith("Middle Initial:") Then
                                details.MI = line.Substring("Middle Initial:".Length).Trim()
                            ElseIf line IsNot Nothing AndAlso line.StartsWith("Last Name:") Then
                                details.LastName = line.Substring("Last Name:".Length).Trim()
                            ElseIf line IsNot Nothing AndAlso line.StartsWith("Age:") Then
                                details.Age = line.Substring("Age:".Length).Trim()
                            ElseIf line IsNot Nothing AndAlso line.StartsWith("Baby:") Then
                                details.Baby = line.Substring("Baby:".Length).Trim()
                            ElseIf line IsNot Nothing AndAlso line.StartsWith("Address:") Then
                                details.Address = line.Substring("Address:".Length).Trim()
                            ElseIf line IsNot Nothing AndAlso line.StartsWith("Gender:") Then
                                details.Gender = line.Substring("Gender:".Length).Trim()
                            ElseIf line IsNot Nothing AndAlso line.StartsWith("Civil Status:") Then
                                details.CivilStat = line.Substring("Civil Status:".Length).Trim()
                            ElseIf line IsNot Nothing AndAlso line.StartsWith("LMC:") Then
                                details.LMC = line.Substring("LMC:".Length).Trim()
                            ElseIf line IsNot Nothing AndAlso line.StartsWith("Vitamin:") Then
                                details.Vitamin = line.Substring("Vitamin:".Length).Trim()
                            ElseIf line IsNot Nothing AndAlso line.StartsWith("Assigned OB:") Then
                                details.AssignedOB = line.Substring("Assigned OB:".Length).Trim()
                            ElseIf line.Trim() = "" Then
                                Exit Do
                            End If
                        Loop Until reader.EndOfStream

                        If String.IsNullOrEmpty(details.AssignedOB) Then
                            details.AssignedOB = AssignOB()
                        End If

                        Exit While
                    End If
                End While

                If Not foundPatient Then
                    MessageBox.Show("Patient details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                Return details
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving patient details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return Nothing
    End Function

    Private Sub DisplayPatientDetails(patientDetails As PatientDetails)
        If patientDetails IsNot Nothing Then
            lblName.Text = "Name: " & patientDetails.Name
            lblAge.Text = "Age: " & patientDetails.Age
            lblGender.Text = "Gender: " & patientDetails.Gender
            lblAddress.Text = "Address: " & patientDetails.Address
            lblCivil.Text = "Civil Status: " & patientDetails.CivilStat
            lblBaby.Text = "First Baby: " & patientDetails.Baby
            lblLMC.Text = "Last Menstrual Cycle: " & patientDetails.LMC
            lblVitamin.Text = "List of Vitamins Intake: " & patientDetails.Vitamin

            Dim LMCDate As Date
            If Date.TryParseExact(patientDetails.LMC, "yyyy/MM/dd", Nothing, Globalization.DateTimeStyles.None, LMCDate) Then
                Dim gestationalAge As TimeSpan = Date.Now - LMCDate
                lblGestational.Text = "Gestational Age: " & Math.Floor(gestationalAge.TotalDays / 7).ToString() & " weeks"
            Else
                lblGestational.Text = "Gestational Age: N/A (Invalid LMC date)"
            End If

            lblAssigned.Text = "Assigned OB: " & patientDetails.AssignedOB

            pnlInfo.Visible = True
            SavePatientDetails(patientDetails)
        Else
            MessageBox.Show("Patient details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SavePatientDetails(patientDetails As PatientDetails)
        Try
            Dim filePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PatientDatabase.txt")
            Dim lines As List(Of String) = File.ReadAllLines(filePath).ToList()
            Dim updatedLines As New List(Of String)()
            Dim patientFound As Boolean = False

            For i As Integer = 0 To lines.Count - 1
                Dim line As String = lines(i)
                If line.StartsWith("Name: " & patientDetails.Name) Then
                    patientFound = True

                    updatedLines.Add("Name: " & patientDetails.Name)
                    updatedLines.Add("Middle Initial: " & patientDetails.MI)
                    updatedLines.Add("Last Name: " & patientDetails.LastName)
                    updatedLines.Add("Age: " & patientDetails.Age)
                    updatedLines.Add("Baby: " & patientDetails.Baby)
                    updatedLines.Add("Address: " & patientDetails.Address)
                    updatedLines.Add("Gender: " & patientDetails.Gender)
                    updatedLines.Add("Civil Status: " & patientDetails.CivilStat)
                    updatedLines.Add("LMC: " & patientDetails.LMC)
                    updatedLines.Add("Vitamin: " & patientDetails.Vitamin)
                    updatedLines.Add("Assigned OB: " & patientDetails.AssignedOB)
                    updatedLines.Add("")

                    Do
                        i += 1
                        If i < lines.Count AndAlso lines(i).Trim() = "" Then Exit Do
                    Loop
                Else
                    updatedLines.Add(line)
                End If
            Next

            If Not patientFound Then
                updatedLines.Add("Name: " & patientDetails.Name)
                updatedLines.Add("Middle Initial: " & patientDetails.MI)
                updatedLines.Add("Last Name: " & patientDetails.LastName)
                updatedLines.Add("Age: " & patientDetails.Age)
                updatedLines.Add("Baby: " & patientDetails.Baby)
                updatedLines.Add("Address: " & patientDetails.Address)
                updatedLines.Add("Gender: " & patientDetails.Gender)
                updatedLines.Add("Civil Status: " & patientDetails.CivilStat)
                updatedLines.Add("LMC: " & patientDetails.LMC)
                updatedLines.Add("Vitamin: " & patientDetails.Vitamin)
                updatedLines.Add("Assigned OB: " & patientDetails.AssignedOB)
                updatedLines.Add("")
            End If

            File.WriteAllLines(filePath, updatedLines)
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving patient details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        ADMIN_.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        pnlInfo.Hide()
    End Sub

    Private Sub lblAssigned_Click(sender As Object, e As EventArgs) Handles lblAssigned.Click

    End Sub
End Class
