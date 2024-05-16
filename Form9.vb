Public Class Form9

    Structure Appointment
        Public PatientName As String
        Public AppointmentDateTime As DateTime
        Public FollowUpDates As List(Of DateTime)
    End Structure

    Dim Appointments As New List(Of Appointment)
    Dim appointmentDate As DateTime
    Dim followUpDates As List(Of DateTime)

    Private Sub btnGetSched_Click(sender As Object, e As EventArgs) Handles btnGetSched.Click
        Dim monthsPregnant As Integer = 0

        Dim input As String = InputBox("Enter the number of months pregnant:", "Number of Months Pregnant")
        If Not Integer.TryParse(input, monthsPregnant) OrElse monthsPregnant <= 0 Then
            MessageBox.Show("Please enter a valid number of months pregnant.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Get next available appointment date
        appointmentDate = GetNextAvailableDate()

        ' Calculate follow-up dates based on the appointment date
        followUpDates = CalculateFollowUpDates(monthsPregnant, appointmentDate)

        ' Display appointment and follow-up dates
        DisplayAppointmentAndFollowUps(appointmentDate, followUpDates)
    End Sub

    Private Function GetNextAvailableDate() As DateTime
        Dim currentDate As DateTime = DateTime.Now.Date.AddDays(1)
        Dim maxDate As DateTime = DateTime.Now.Date.AddMonths(9)
        Dim attempts As Integer = 0

        Dim random As New Random()

        ' Randomize the time of the appointment within the clinic hours
        Dim randomHour As Integer = random.Next(9, 17) ' Random hour between 9 AM and 5 PM
        Dim randomMinute As Integer = random.Next(0, 60) ' Random minute between 0 and 59
        Dim randomSecond As Integer = random.Next(0, 60) ' Random second between 0 and 59

        While currentDate.DayOfWeek = DayOfWeek.Sunday OrElse currentDate > maxDate
            attempts += 1

            If attempts > 365 Then
                ' Return the current date when no available appointment date is found within a year
                Return DateTime.Now.Date.AddDays(1)
            End If

            ' Randomize the appointment time
            currentDate = currentDate.AddHours(randomHour).AddMinutes(randomMinute).AddSeconds(randomSecond)
            ' Ensure the appointment time is within clinic hours
            If currentDate.Hour < 9 OrElse currentDate.Hour >= 17 Then
                ' Move to the next day
                currentDate = currentDate.AddDays(1).Date.AddHours(randomHour).AddMinutes(randomMinute).AddSeconds(randomSecond)
            End If

            ' Check if there is an existing appointment at the same date and time
            If Appointments.Any(Function(appointment) appointment.AppointmentDateTime = currentDate) Then
                ' Move to the next available date and reset time
                currentDate = currentDate.AddDays(1).Date.AddHours(randomHour).AddMinutes(randomMinute).AddSeconds(randomSecond)
            End If
        End While

        Return currentDate
    End Function

    Private Function CalculateFollowUpDates(ByVal monthsPregnant As Integer, ByVal appointmentDate As DateTime) As List(Of DateTime)
        ' Define typical follow-up intervals for each trimester
        Dim followUpIntervals As Dictionary(Of Integer, Integer()) = New Dictionary(Of Integer, Integer()) From {
            {1, {1, 2, 3}},  ' First trimester follow-up intervals in months
            {2, {1, 2, 3}},  ' Second trimester follow-up intervals in months
            {3, {1, 2, 3}}   ' Third trimester follow-up intervals in months
        }

        Dim followUpDates As New List(Of DateTime)()
        Dim intervals As Integer() = followUpIntervals((monthsPregnant + 2) \ 3) ' Determine trimester and get follow-up intervals

        ' Calculate follow-up dates based on follow-up intervals
        Dim currentDate As DateTime = appointmentDate
        For Each interval As Integer In intervals
            currentDate = currentDate.AddMonths(interval)
            ' Skip Sundays
            If currentDate.DayOfWeek = DayOfWeek.Sunday Then
                currentDate = currentDate.AddDays(2)
            End If
            followUpDates.Add(currentDate)
        Next

        Return followUpDates
    End Function

    Private Sub DisplayAppointmentAndFollowUps(ByVal appointmentDate As DateTime, ByVal followUpDates As List(Of DateTime))
        ' Display appointment date
        Dim lblAppointment As Label = pnlFollowup.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name = "lblAppointment")
        If lblAppointment Is Nothing Then
            lblAppointment = New Label()
            lblAppointment.Name = "lblAppointment"
            lblAppointment.AutoSize = True
            lblAppointment.Location = New Point(10, 10)
            pnlFollowup.Controls.Add(lblAppointment)
        End If
        lblAppointment.Font = New Font(lblAppointment.Font.FontFamily, 20)
        lblAppointment.Text = "Appointment Date: " & appointmentDate.ToString("ddd, MMM dd yyyy")

        ' Display follow-up dates with day and time
        Dim verticalPosition As Integer = 40
        For i As Integer = 0 To followUpDates.Count - 1
            Dim followUpLabelText As String = "Follow-Up " & (i + 1) & " Date: " & followUpDates(i).ToString("ddd, MMM dd yyyy")
            ' Skip Sundays
            If followUpDates(i).DayOfWeek = DayOfWeek.Sunday Then
                followUpDates(i) = followUpDates(i).AddDays(1)
            End If
            followUpLabelText &= " " & followUpDates(i).ToString("hh:mm tt")

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

            verticalPosition += 30 ' Increase vertical position by 30 pixels for the next label
        Next

        ' Hide extra follow-up labels if there are any
        For i As Integer = followUpDates.Count To 3
            Dim lblFollowUp As Label = pnlFollowup.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name = "lblFollowUp" & i)
            If lblFollowUp IsNot Nothing Then
                lblFollowUp.Visible = False
            End If
        Next

        ' Display the panel
        pnlFollowup.Visible = True
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form5.Show()
        Me.Close()

    End Sub
End Class
