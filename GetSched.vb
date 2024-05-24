Imports System.Globalization
Imports System.IO

Public Class GetSched

    Dim appointmentsFilePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Appointments.txt")
    Dim assignedOBFilePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "AssignedOB.txt")

    Structure Appointment
        Public PatientName As String
        Public AppointmentDateTime As DateTime
        Public FollowUpDates As List(Of DateTime)
    End Structure

    Public Appointments As New List(Of Appointment)

    Private ReadOnly OBs As List(Of String) = New List(Of String) From {
        "Dr. Jacob Panesa", "Dr. Gilbert Cura", "Dr. Irish Ramirez",
        "Dr. Jordan Romero", "Dr. Dominic Salta", "Dr. Mary Joy Bondoc"
    }

    Private ReadOnly rnd As New Random()

    Private Sub btnGetSched_Click(sender As Object, e As EventArgs) Handles btnGetSched.Click
        ' Get the patient's name from Form2
        Dim patientName As String = Form2.strCurrentPatient.getPatient()

        Dim appointmentDate As DateTime = GetNextAvailableDate()

        Dim followUpDates As List(Of DateTime) = CalculateFollowUpDates(appointmentDate)

        Dim appointment As New Appointment()
        appointment.PatientName = patientName ' Set the patient's name
        appointment.AppointmentDateTime = appointmentDate
        appointment.FollowUpDates = followUpDates

        Appointments.Add(appointment)

        SaveAppointmentsToFile(appointment)

        Dim assignedOB As String = AssignOB()
        SaveAssignedOBToFile(appointment.PatientName, assignedOB, "Automated")

        DisplayAppointmentAndFollowUps(appointmentDate, followUpDates)
    End Sub


    Private Function GetNextAvailableDate() As DateTime
        Dim currentDate As DateTime = DateTime.Now.Date.AddDays(1)
        Dim maxDate As DateTime = DateTime.Now.Date.AddMonths(9)

        While True

            Dim appointmentTime As DateTime = currentDate.AddHours(9).AddMinutes(0)
            If appointmentTime > DateTime.Now Then
                Return appointmentTime
            End If

            appointmentTime = appointmentTime.AddMinutes(30)

            If appointmentTime.Hour >= 17 Then

                currentDate = currentDate.AddDays(1)
                If currentDate > maxDate Then

                    Return DateTime.Now.Date.AddDays(1)
                End If
                currentDate = New DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 9, 0, 0)
            End If
        End While
    End Function


    Private Function CalculateFollowUpDates(ByVal appointmentDate As DateTime) As List(Of DateTime)
        Dim followUpDates As New List(Of DateTime)()
        Dim gestationalAgeWeeks As Integer = 18 ' Assuming 18 weeks as given

        Dim remainingDays As Integer = (40 - gestationalAgeWeeks) * 7 ' Remaining days in pregnancy

        ' Define the follow-up intervals
        Dim intervals As Integer() = {30, 20, 10}
        Dim currentIntervalIndex As Integer = If(gestationalAgeWeeks <= 12, 0, If(gestationalAgeWeeks <= 24, 1, 2))

        ' Generate follow-up dates based on the intervals
        While remainingDays > 0
            Dim interval As Integer = intervals(currentIntervalIndex)
            If interval > remainingDays Then
                Exit While ' No more follow-up dates possible
            End If

            appointmentDate = appointmentDate.AddDays(interval)
            remainingDays -= interval

            followUpDates.Add(New DateTime(appointmentDate.Year, appointmentDate.Month, appointmentDate.Day, 9, 0, 0))

            ' Adjust interval index based on the gestational age
            If currentIntervalIndex = 0 AndAlso gestationalAgeWeeks + (followUpDates.Count * 4) > 12 Then
                currentIntervalIndex += 1
            ElseIf currentIntervalIndex = 1 AndAlso gestationalAgeWeeks + (followUpDates.Count * 3) > 24 Then
                currentIntervalIndex += 1
            End If
        End While

        Return followUpDates
    End Function




    Private Function AssignOB() As String

        Return OBs(rnd.Next(0, OBs.Count))
    End Function

    Private Sub SaveAppointmentsToFile(ByVal appointment As Appointment)
        Using writer As New StreamWriter(appointmentsFilePath, True)
            ' Write the patient name
            writer.WriteLine(appointment.PatientName)

            ' Write the appointment date
            writer.WriteLine(appointment.AppointmentDateTime.ToString("MM/dd/yyyy hh:mm tt"))

            ' Write up to three follow-up dates
            Dim followUpCount As Integer = Math.Min(appointment.FollowUpDates.Count, 3)
            For i As Integer = 0 To followUpCount - 1
                writer.WriteLine(appointment.FollowUpDates(i).ToString("MM/dd/yyyy hh:mm tt"))
            Next

            writer.WriteLine("---")
        End Using
    End Sub





    Private Sub SaveAssignedOBToFile(patientName As String, assignedOB As String, generatedBy As String)

        Using writer As New StreamWriter(assignedOBFilePath, True)
            writer.WriteLine($"{patientName} - {assignedOB} (Generated by: {generatedBy})")
        End Using
    End Sub

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

        Dim verticalPosition As Integer = 40
        For i As Integer = 0 To Math.Min(followUpDates.Count, 2) ' Show only the first three follow-ups
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

            verticalPosition += 30
        Next

        ' Hide any remaining labels beyond the first three follow-up dates
        For i As Integer = 3 To 8
            Dim lblFollowUp As Label = pnlFollowup.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name = "lblFollowUp" & i)
            If lblFollowUp IsNot Nothing Then
                lblFollowUp.Visible = False
            End If
        Next

        pnlFollowup.Visible = True
    End Sub


    Public strCurrentPatient As Form2.Patient

    ' In GetSched
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim form5 As New Form5()
        form5.strCurrentPatient = strCurrentPatient ' Pass the current patient back
        form5.Show()
        Me.Close()
    End Sub
End Class
