Imports System.IO
Imports System.Globalization

Public Class Form4
    Public Property Appointments As List(Of Form9.Appointment)

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim result As MsgBoxResult
        result = MsgBox("Are you sure you want to Log-Out?", vbOKCancel, "NOMG CLINIC")
        If result = MsgBoxResult.Ok Then
            MessageBox.Show("Logging-Out")
            Form2.Show()
            Me.Close()
        ElseIf result = MsgBoxResult.Cancel Then
            'No function
        End If
    End Sub

    Private Sub btnPatientInfo_Click(sender As Object, e As EventArgs) Handles btnPatientInfo.Click
        Form12.Show()
    End Sub

    Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click
        Form13.Show()
    End Sub

    Private Sub UpdateTextFields()
        If Appointments IsNot Nothing AndAlso Appointments.Count > 0 Then
            Dim textBoxes() As TextBox = {txtPatient1, txtPatient2, txtPatient3, txtPatient4, txtPatient5, txtPatient6, txtPatient7, txtPatient8}

            ' Use a monospaced font for better alignment
            Dim monospaceFont As New Font("Courier New", 10)

            Dim index As Integer = 0

            For Each appointment In Appointments
                ' Find the next empty text box
                While index < textBoxes.Length AndAlso Not String.IsNullOrEmpty(textBoxes(index).Text)
                    index += 1
                End While

                ' If there are no more empty text boxes, exit the loop
                If index >= textBoxes.Length Then Exit For

                Dim followUpDates = String.Join(", ", appointment.FollowUpDates.Select(Function(d) d.ToString("MM/dd/yyyy HH:mm")))

                ' Define lengths for padding
                Dim patientLength As Integer = 20
                Dim appointmentDateLength As Integer = 20

                ' Get the text with padding
                Dim patientText = appointment.PatientName.PadRight(patientLength)
                Dim appointmentDateText = appointment.AppointmentDateTime.ToString("MM/dd/yyyy HH:mm").PadRight(appointmentDateLength)
                Dim followUpText = followUpDates

                ' Combine text with padding for alignment
                Dim combinedText = $"{patientText}{appointmentDateText}{followUpText}"

                ' Set the text box font to a monospaced font
                textBoxes(index).Font = monospaceFont

                ' Set the combined text to the text box
                textBoxes(index).Text = combinedText

                ' Move to the next text box
                index += 1
            Next
        End If
    End Sub



    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Read appointments from the file and assign them to the Appointments property
        Appointments = LoadAppointmentsFromFile()

        ' Call UpdateTextFields when the form loads to populate the text boxes with appointment information
        UpdateTextFields()
    End Sub

    Private Function LoadAppointmentsFromFile() As List(Of Form9.Appointment)
        Dim appointments As New List(Of Form9.Appointment)()

        ' Define the path to the text file
        Dim filePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Appointments.txt")

        ' Read the appointments from the file
        If File.Exists(filePath) Then
            Dim lines As String() = File.ReadAllLines(filePath)
            Dim currentAppointment As New Form9.Appointment() With {.FollowUpDates = New List(Of DateTime)}

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
                        currentAppointment = New Form9.Appointment() With {.FollowUpDates = New List(Of DateTime)}
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnlAppointments.Visible = True
    End Sub

    ' Other text changed handlers...
    Private Sub txtPatient2_TextChanged(sender As Object, e As EventArgs) Handles txtPatient2.TextChanged
    End Sub

    Private Sub txtPatient3_TextChanged(sender As Object, e As EventArgs) Handles txtPatient3.TextChanged
    End Sub

    Private Sub txtPatient4_TextChanged(sender As Object, e As EventArgs) Handles txtPatient4.TextChanged
    End Sub

    Private Sub txtPatient5_TextChanged(sender As Object, e As EventArgs) Handles txtPatient5.TextChanged
    End Sub

    Private Sub txtPatient6_TextChanged(sender As Object, e As EventArgs) Handles txtPatient6.TextChanged
    End Sub

    Private Sub txtPatient7_TextChanged(sender As Object, e As EventArgs) Handles txtPatient7.TextChanged
    End Sub

    Private Sub txtPatient8_TextChanged(sender As Object, e As EventArgs) Handles txtPatient8.TextChanged
    End Sub
End Class
