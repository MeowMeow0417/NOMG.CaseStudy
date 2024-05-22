Imports System.IO
Imports System.Globalization

Public Class ADMIN_

    Public Property Appointments As List(Of GetSched.Appointment)
    Public Property strCurrentPatient As Form2.Patient

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim result As MsgBoxResult
        result = MsgBox("Are you sure you want to Log-Out?", vbOKCancel, "NOMG CLINIC")
        If result = MsgBoxResult.Ok Then
            MessageBox.Show("Logging-Out")
            Form2.Show()
            Me.Close()
        ElseIf result = MsgBoxResult.Cancel Then

        End If
    End Sub

    Private Sub btnPatientInfo_Click(sender As Object, e As EventArgs) Handles btnPatientInfo.Click
        PATIENTDETAILS.Show()
        Me.Close()
    End Sub

    Private Sub btnBill_Click(sender As Object, e As EventArgs) Handles btnBill.Click
        Dim form13 As New BILLING(strCurrentPatient)
        form13.Show()
        Me.Close()
    End Sub

    Private Sub UpdateTextFields()
        If Appointments IsNot Nothing AndAlso Appointments.Count > 0 Then
            Dim textBoxes() As TextBox = {txtPatient1, txtPatient2, txtPatient3, txtPatient4, txtPatient5, txtPatient6, txtPatient7, txtPatient8}


            Dim monospaceFont As New Font("Courier New", 10)

            Dim index As Integer = 0

            For Each appointment In Appointments

                While index < textBoxes.Length AndAlso Not String.IsNullOrEmpty(textBoxes(index).Text)
                    index += 1
                End While

                If index >= textBoxes.Length Then Exit For

                Dim followUpDates = String.Join(", ", appointment.FollowUpDates.Select(Function(d) d.ToString("MM/dd/yyyy HH:mm")))


                Dim patientLength As Integer = 20
                Dim appointmentDateLength As Integer = 20


                Dim patientText = appointment.PatientName.PadRight(patientLength)
                Dim appointmentDateText = appointment.AppointmentDateTime.ToString("MM/dd/yyyy HH:mm").PadRight(appointmentDateLength)
                Dim followUpText = followUpDates


                Dim combinedText = $"{patientText}{appointmentDateText}{followUpText}"

                textBoxes(index).Font = monospaceFont


                textBoxes(index).Text = combinedText


                index += 1
            Next
        End If
    End Sub



    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Appointments = LoadAppointmentsFromFile()


        UpdateTextFields()
    End Sub

    Private Function LoadAppointmentsFromFile() As List(Of GetSched.Appointment)
        Dim appointments As New List(Of GetSched.Appointment)()

        Dim filePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Appointments.txt")

        If File.Exists(filePath) Then
            Dim lines As String() = File.ReadAllLines(filePath)
            Dim currentAppointment As New GetSched.Appointment() With {.FollowUpDates = New List(Of DateTime)}

            For Each line As String In lines
                If line <> "---" Then
                    If String.IsNullOrEmpty(currentAppointment.PatientName) Then
                        currentAppointment.PatientName = line
                    ElseIf currentAppointment.AppointmentDateTime = DateTime.MinValue Then
                        currentAppointment.AppointmentDateTime = DateTime.ParseExact(line, "MM/dd/yyyy hh:mm tt", CultureInfo.InvariantCulture)
                    Else
                        currentAppointment.FollowUpDates.Add(DateTime.ParseExact(line, "MM/dd/yyyy hh:mm tt", CultureInfo.InvariantCulture))
                    End If
                Else
                    If Not String.IsNullOrEmpty(currentAppointment.PatientName) Then
                        appointments.Add(currentAppointment)
                        currentAppointment = New GetSched.Appointment() With {.FollowUpDates = New List(Of DateTime)}
                    End If
                End If
            Next

            If Not String.IsNullOrEmpty(currentAppointment.PatientName) Then
                appointments.Add(currentAppointment)
            End If
        End If

        Return appointments
    End Function

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        pnlAppointments.Visible = True
        PictureBox1.Visible = False
        btnView.Visible = False
        btnBack.Visible = True
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        pnlAppointments.Visible = False
        PictureBox1.Visible = True
        btnView.Visible = True
        btnBack.Visible = False
    End Sub


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