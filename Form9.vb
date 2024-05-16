Imports System.IO
Imports System.Globalization

Public Class Form9
    ' Define the path to the text file
    Dim filePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Appointments.txt")
    Public Shared PatientName As String
    Structure Appointment
        Public PatientName As String
        Public AppointmentDateTime As DateTime
        Public FollowUpDates As List(Of DateTime)
    End Structure

    Public Appointments As New List(Of Appointment)
    Dim appointmentDate As DateTime
    Dim followUpDates As List(Of DateTime)

    Private Sub btnGetSched_Click(sender As Object, e As EventArgs) Handles btnGetSched.Click
        Dim monthsPregnant As Integer = 0

        Dim input As String = InputBox("Enter the number of months pregnant:", "Number of Months Pregnant")
        If Not Integer.TryParse(input, monthsPregnant) OrElse monthsPregnant <= 0 OrElse monthsPregnant > 9 Then
            MessageBox.Show("Please enter a valid number of months pregnant (1-9).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
            Me.Show()
        End If

        ' Get next available appointment date within clinic hours
        appointmentDate = GetNextAvailableDate()

        ' If appointmentDate is DateTime.MinValue, it means no available slots were found
        If appointmentDate = DateTime.MinValue Then
            MessageBox.Show("No available appointment slots within clinic hours.", "No Availability", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Calculate follow-up dates based on the appointment date
        followUpDates = CalculateFollowUpDates(monthsPregnant, appointmentDate)

        ' Display appointment and follow-up dates
        DisplayAppointmentAndFollowUps(appointmentDate, followUpDates)

        ' Store the appointment information
        Dim appointment As New Appointment()
        appointment.PatientName = Form9.PatientName ' Use the patient name obtained from Form2
        appointment.AppointmentDateTime = appointmentDate
        appointment.FollowUpDates = followUpDates

        Appointments.Add(appointment)

        ' Save the appointment to the text file
        SaveAppointmentsToFile()

        ' Pass the appointments list to Form4
        Form4.Appointments = Appointments

    End Sub

    Private Function GetNextAvailableDate() As DateTime
        Dim currentDate As DateTime = DateTime.Today
        Dim maxDate As DateTime = currentDate.AddDays(30) ' Limit appointment dates to 30 days from today
        Dim clinicStartTime As New TimeSpan(9, 0, 0) ' Clinic opening time
        Dim clinicEndTime As New TimeSpan(17, 0, 0) ' Clinic closing time
        Dim random As New Random()

        ' Start from a random time within the 30-day period
        Dim currentDateTime As DateTime = currentDate.AddDays(random.Next(1, 30)).AddHours(random.Next(9, 17)).AddMinutes(random.Next(0, 60))

        ' Loop until a valid appointment time is found or we reach the max date
        While currentDateTime <= maxDate
            ' Check if the current time is within clinic hours
            If currentDateTime.TimeOfDay >= clinicStartTime AndAlso currentDateTime.TimeOfDay <= clinicEndTime Then
                ' Check if there are no appointments already scheduled at this time
                If Not Appointments.Any(Function(appointment) _
                currentDateTime >= appointment.AppointmentDateTime AndAlso
                currentDateTime < appointment.AppointmentDateTime.AddMinutes(15)) Then
                    ' Found an available time slot
                    Return currentDateTime
                End If
            End If

            ' Move to the next random time within the 30-day period
            currentDateTime = currentDate.AddDays(random.Next(1, 30)).AddHours(random.Next(9, 17)).AddMinutes(random.Next(0, 60))
        End While

        ' No available slots within clinic hours found
        Return DateTime.MinValue
    End Function

    Private Function CalculateFollowUpDates(ByVal monthsPregnant As Integer, ByVal appointmentDate As DateTime) As List(Of DateTime)
        Dim random As New Random()
        Dim followUpDates As New List(Of DateTime)()

        ' Generate follow-up dates based on the appointment date
        Dim currentFollowUpDate As DateTime = appointmentDate ' Start with the appointment date
        For i As Integer = 1 To 3 ' Calculate follow-ups for the next 3 months
            ' Start from a random time within 30 days after the current follow-up date
            Dim followUpDate As DateTime = currentFollowUpDate.AddDays(random.Next(1, 30)).AddHours(random.Next(9, 17)).AddMinutes(random.Next(0, 60))

            ' Ensure the follow-up date doesn't overlap with existing appointments
            While Appointments.Any(Function(appointment) _
            followUpDate >= appointment.AppointmentDateTime AndAlso
            followUpDate < appointment.AppointmentDateTime.AddMinutes(15))
                ' If overlap, generate a new random time within 30 days
                followUpDate = currentFollowUpDate.AddDays(random.Next(1, 30)).AddHours(random.Next(9, 17)).AddMinutes(random.Next(0, 60))
            End While

            ' Add the follow-up date to the list
            followUpDates.Add(followUpDate)

            ' Update the current follow-up date for the next iteration
            currentFollowUpDate = followUpDate
        Next

        ' Sort follow-up dates in ascending order
        followUpDates.Sort()

        Return followUpDates
    End Function

    Private Sub DisplayAppointmentAndFollowUps(ByVal appointmentDate As DateTime, ByVal followUpDates As List(Of DateTime))
        ' Clear previous content in pnlFollowup
        pnlFollowup.Controls.Clear()

        ' Create label for appointment date
        Dim appointmentLabel As New Label()
        With appointmentLabel
            .Text = "Appointment Date: " & appointmentDate.ToShortDateString() & " " & appointmentDate.ToShortTimeString()
            .Font = New Font(Font.FontFamily, 25)
            .AutoSize = True
        End With

        pnlFollowup.Controls.Add(appointmentLabel)

        ' Calculate vertical gap
        Dim verticalGap As Integer = 20 ' Adjust this value as needed

        ' Position the appointment label
        appointmentLabel.Top = 0

        ' Position follow-up labels with vertical gap
        For i As Integer = 0 To followUpDates.Count - 1
            Dim followUpLabel As New Label()
            With followUpLabel
                .Text = "Follow-Up " & (i + 1) & " Date: " & followUpDates(i).ToShortDateString() & " " & followUpDates(i).ToShortTimeString()
                .Font = New Font(Font.FontFamily, 25)
                .AutoSize = True
                .Top = appointmentLabel.Bottom + (i * followUpLabel.Height) + (i * verticalGap) ' Add vertical gap
            End With

            pnlFollowup.Controls.Add(followUpLabel)
            pnlFollowup.Visible = True
            Form5.Show()
        Next

    End Sub

    Private Sub SaveAppointmentsToFile()
        ' Append appointments to the text file
        Using writer As New StreamWriter(filePath, True)
            ' Write each appointment to the text file
            For Each appointment As Appointment In Appointments
                writer.WriteLine(appointment.PatientName)
                writer.WriteLine(appointment.AppointmentDateTime.ToString("MM/dd/yyyy HH:mm")) ' Include time in the format
                For Each followUpDate As DateTime In appointment.FollowUpDates
                    writer.WriteLine(followUpDate.ToString("MM/dd/yyyy HH:mm")) ' Include time in the format
                Next
                writer.WriteLine("---") ' Separate appointments by a line
            Next
        End Using
    End Sub

    Private Function LoadAppointmentsFromFile() As List(Of Appointment)
        Dim appointments As New List(Of Appointment)()

        ' Read the appointments from the file
        If File.Exists(filePath) Then
            Dim lines As String() = File.ReadAllLines(filePath)
            Dim currentAppointment As New Appointment() With {.FollowUpDates = New List(Of DateTime)}

            For Each line As String In lines
                If line <> "---" Then
                    If String.IsNullOrEmpty(currentAppointment.PatientName) Then
                        currentAppointment.PatientName = line
                    ElseIf currentAppointment.AppointmentDateTime = DateTime.MinValue Then
                        currentAppointment.AppointmentDateTime = DateTime.ParseExact(line, "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture)
                    Else
                        currentAppointment.FollowUpDates.Add(DateTime.ParseExact(line, "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture))
                    End If
                Else
                    ' Add the completed appointment to the list
                    If Not String.IsNullOrEmpty(currentAppointment.PatientName) Then
                        appointments.Add(currentAppointment)
                        currentAppointment = New Appointment() With {.FollowUpDates = New List(Of DateTime)}
                    End If
                End If
            Next

            ' Add the last appointment if not already added
            If Not String.IsNullOrEmpty(currentAppointment.PatientName) Then
                appointments.Add(currentAppointment)
            End If
        End If

        Return appointments
    End Function

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        pnlFollowup.Visible = False
        Me.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form5.Show()
        Me.Close()
    End Sub
End Class

