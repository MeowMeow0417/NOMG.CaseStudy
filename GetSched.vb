Imports System.Globalization
Imports System.IO

Public Class GetSched

    ' File paths for data storage
    Private ReadOnly appointmentsFilePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Appointments.txt")
    Private ReadOnly assignedOBFilePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "AssignedOB.txt")
    Private ReadOnly patientsDatabaseFilePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PatientsDatabase.txt")

    ' Structure to represent an appointment
    Structure Appointment
        Public PatientName As String
        Public AppointmentDateTime As DateTime
        Public FollowUpDates As List(Of DateTime)
    End Structure

    ' List of available OBs
    Private ReadOnly OBs As List(Of String) = New List(Of String) From {
        "Dr. Jacob Panesa", "Dr. Gilbert Cura", "Dr. Irish Ramirez",
        "Dr. Jordan Romero", "Dr. Dominic Salta", "Dr. Mary Joy Bondoc"
    }

    Private ReadOnly rnd As New Random()

    ' Event handler for scheduling an appointment
    Private Sub btnGetSched_Click(sender As Object, e As EventArgs) Handles btnGetSched.Click
        ' Get the patient's name from Form2
        Dim patientName As String = Form2.strCurrentPatient.getPatient()

        ' Get the next available appointment date
        Dim appointmentDate As DateTime = GetNextAvailableDate()

        ' Load the LMC date from PatientsDatabase.txt and calculate gestational age
        Dim lmcDate As DateTime = GetLMCDate(patientName)
        Dim gestationalAgeInMonths As Integer = CalculateGestationalAge(lmcDate)

        ' Calculate follow-up dates based on gestational age
        Dim followUpDates As List(Of DateTime) = CalculateFollowUpDates(appointmentDate, gestationalAgeInMonths)

        ' Create an appointment object
        Dim appointment As New Appointment With {
            .PatientName = patientName,
            .AppointmentDateTime = appointmentDate,
            .FollowUpDates = followUpDates
        }

        ' Save appointment details to files
        SaveAppointmentsToFile(appointment)
        SaveAssignedOBToFile(appointment.PatientName, AssignOB(), "Automated")

        ' Display appointment and follow-up details
        DisplayAppointmentAndFollowUps(appointment.AppointmentDateTime, appointment.FollowUpDates)
    End Sub

    ' Load LMC date from the patients database
    Private Function GetLMCDate(patientName As String) As DateTime
        Dim lmcDate As DateTime = DateTime.MinValue
        Try
            If Not File.Exists(patientsDatabaseFilePath) Then
                Throw New FileNotFoundException("The database file was not found.", patientsDatabaseFilePath)
            End If

            Using reader As New StreamReader(patientsDatabaseFilePath)
                Dim line As String
                While (InlineAssignHelper(line, reader.ReadLine())) IsNot Nothing
                    Dim parts As String() = line.Split(","c)
                    If parts.Length >= 8 AndAlso parts(0).Trim() = "Name:" AndAlso parts(1).Trim() = patientName Then
                        Dim lmcDateStr As String = parts(7).Trim() ' Assuming the LMC Date is in the 8th position (index 7)
                        If DateTime.TryParseExact(lmcDateStr, "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, lmcDate) Then
                            Console.WriteLine($"LMC Date found for {patientName}: {lmcDate}")
                            Return lmcDate
                        End If
                    End If
                End While
            End Using
        Catch ex As Exception
            ' Handle exceptions (log, rethrow, or ignore based on your application's requirements)
            Console.WriteLine($"An error occurred: {ex.Message}")
        End Try

        Return lmcDate ' Return default value if not found
    End Function

    ' Calculate gestational age based on LMC date
    Private Function CalculateGestationalAge(lmcDate As DateTime) As Integer
        Dim today As DateTime = DateTime.Now
        Dim gestationalAgeInDays As Integer = (today - lmcDate).Days
        Dim gestationalAgeInMonths As Integer = gestationalAgeInDays \ 30 ' Approximate to months
        Return gestationalAgeInMonths
    End Function

    ' Get the next available appointment date
    Private Function GetNextAvailableDate() As DateTime
        Dim currentDate As DateTime = DateTime.Now.Date.AddDays(1)
        Dim maxDate As DateTime = DateTime.Now.Date.AddMonths(9)

        While True
            Dim appointmentTime As DateTime = currentDate.AddHours(9).AddMinutes(0)
            If appointmentTime > DateTime.Now Then
                Console.WriteLine($"Next available appointment date: {appointmentTime}")
                Return appointmentTime
            End If

            appointmentTime = appointmentTime.AddMinutes(30)
            If appointmentTime.Hour >= 17 Then
                currentDate = currentDate.AddDays(1)
                If currentDate > maxDate Then
                    Console.WriteLine($"Reached max date, setting to next day")
                    Return DateTime.Now.Date.AddDays(1)
                End If
                currentDate = New DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 9, 0, 0)
            End If
        End While
    End Function

    ' Calculate follow-up dates based on gestational age
    Private Function CalculateFollowUpDates(ByVal appointmentDate As DateTime, ByVal gestationalAgeInMonths As Integer) As List(Of DateTime)
        Dim followUpDates As New List(Of DateTime)()

        ' Determine the increment based on gestational age
        Dim daysIncrement As Integer
        If gestationalAgeInMonths < 3 Then
            daysIncrement = 30
        ElseIf gestationalAgeInMonths < 6 Then
            daysIncrement = 20
        Else
            daysIncrement = 10
        End If

        ' Number of follow-ups
        Dim numberOfFollowUps As Integer = 3

        Console.WriteLine($"Gestational Age: {gestationalAgeInMonths} months, Days Increment: {daysIncrement}")

        For i As Integer = 0 To numberOfFollowUps - 1
            ' Calculate the follow-up date
            Dim followUpDate As DateTime = appointmentDate.AddDays(daysIncrement * (i + 1))

            ' Set the follow-up time to 9:00 AM
            followUpDate = New DateTime(followUpDate.Year, followUpDate.Month, followUpDate.Day, 9, 0, 0)

            ' Debugging output for each follow-up date calculation
            Console.WriteLine($"Follow-Up {i + 1} Date: {followUpDate:dddd, MMM dd yyyy hh:mm tt}")

            followUpDates.Add(followUpDate)
        Next

        Return followUpDates
    End Function

    ' Assign an OB to the patient randomly
    Private Function AssignOB() As String
        Return OBs(rnd.Next(0, OBs.Count))
    End Function

    ' Save appointment details to a file
    Private Sub SaveAppointmentsToFile(ByVal appointment As Appointment)
        Using writer As New StreamWriter(appointmentsFilePath, True)
            ' Write the patient name
            writer.WriteLine(appointment.PatientName)

            ' Write the appointment date
            writer.WriteLine(appointment.AppointmentDateTime.ToString("MM/dd/yyyy hh:mm tt"))

            ' Write follow-up dates
            For Each followUpDate As DateTime In appointment.FollowUpDates
                writer.WriteLine(followUpDate.ToString("MM/dd/yyyy hh:mm tt"))
            Next

            writer.WriteLine("---")
        End Using
    End Sub

    ' Save assigned OB details to a file
    Private Sub SaveAssignedOBToFile(patientName As String, assignedOB As String, generatedBy As String)
        Using writer As New StreamWriter(assignedOBFilePath, True)
            writer.WriteLine($"{patientName} - {assignedOB} (Generated by: {generatedBy})")
        End Using
    End Sub

    ' Display appointment and follow-up details on the form
    Private Sub DisplayAppointmentAndFollowUps(ByVal appointmentDate As DateTime, ByVal followUpDates As List(Of DateTime))
        Dim lblAppointment As Label = pnlFollowup.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name = "lblAppointment")
        If lblAppointment Is Nothing Then
            lblAppointment = New Label()
            lblAppointment.Name = "lblAppointment"
            lblAppointment.AutoSize = True
            lblAppointment.Location = New Point(10, 10)
            pnlFollowup.Controls.Add(lblAppointment)
        End If
        lblAppointment.Font = New Font(lblAppointment.Font.FontFamily, 20)
        lblAppointment.Text = "Appointment Date: " & appointmentDate.ToString("ddd, MMM dd yyyy hh:mm tt")
        Console.WriteLine(lblAppointment.Text)

        Dim verticalPosition As Integer = 40
        For i As Integer = 0 To followUpDates.Count - 1
            Dim followUpLabelText As String = "Follow-Up " & (i + 1) & " Date: " & followUpDates(i).ToString("ddd, MMM dd yyyy hh:mm tt")

            Dim lblFollowUp As Label = pnlFollowup.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name = "lblFollowUp" & i)
            If lblFollowUp Is Nothing Then
                lblFollowUp = New Label()
                lblFollowUp.Name = "lblFollowUp" & i
                lblFollowUp.AutoSize = True
                lblFollowUp.Location = New Point(10, verticalPosition)
                pnlFollowup.Controls.Add(lblFollowUp)
            End If
            lblFollowUp.Font = New Font(lblFollowUp.Font.FontFamily, 20)
            lblFollowUp.Text = followUpLabelText
            Console.WriteLine(lblFollowUp.Text)

            verticalPosition += 30
        Next

        For i As Integer = followUpDates.Count To 3
            Dim lblFollowUp As Label = pnlFollowup.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name = "lblFollowUp" & i)
            If lblFollowUp IsNot Nothing Then
                lblFollowUp.Visible = False
            End If
        Next

        pnlFollowup.Visible = True
    End Sub


    Public strCurrentPatient As Form2.Patient
    ' Event handler for navigating back to the previous form
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim form5 As New Form5()
        form5.strCurrentPatient = strCurrentPatient ' Pass the current patient back
        form5.Show()
        Me.Close()
    End Sub

    ' Helper function to assign the value to a variable and return it in one line
    Private Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function
End Class
