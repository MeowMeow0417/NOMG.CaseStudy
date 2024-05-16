Imports System.IO

Public Class Form3
    Public Shared RegisteredUsernames As New List(Of String)
    Public Class UserManager
        Private Const credentialsFilePath As String = "credentials.txt"

        Public Sub SaveCredentials(username As String, password As String)
            ' Encrypt the password before saving (you should use a secure encryption algorithm)
            Dim encryptedPassword As String = EncryptPassword(password)

            ' Append credentials to the file
            Using writer As New StreamWriter(credentialsFilePath, True)
                writer.WriteLine(username)
                writer.WriteLine(encryptedPassword)
            End Using
        End Sub

        Public Function AuthenticateUser(username As String, password As String) As Boolean
            If File.Exists(credentialsFilePath) Then
                ' Read credentials from the file
                Dim lines As String() = File.ReadAllLines(credentialsFilePath)
                For i As Integer = 0 To lines.Length - 2 Step 2 ' Step 2 to read each pair of lines
                    If lines(i) = username Then
                        ' Decrypt the stored password and compare it with the provided password
                        Dim storedPassword As String = lines(i + 1)
                        Dim decryptedPassword As String = DecryptPassword(storedPassword)
                        If decryptedPassword = password Then
                            Return True
                        End If
                    End If
                Next
            End If
            Return False
        End Function

        Private Function EncryptPassword(password As String) As String
            ' Implement password encryption (e.g., using bcrypt or PBKDF2)
            ' Return the encrypted password
            Return password
        End Function

        Private Function DecryptPassword(encryptedPassword As String) As String
            ' Implement password decryption
            ' Return the decrypted password
            Return encryptedPassword
        End Function
    End Class

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        'checks if the checkbox is checked
        If CheckBox1.Checked Then
            ' Validate input fields
            If txtUser.Text <> "" AndAlso TxtPass.Text <> "" AndAlso txtEmail.Text <> "" Then
                ' Save credentials
                Dim userManager As New UserManager()
                userManager.SaveCredentials(txtUser.Text, TxtPass.Text)

                MsgBox("Your credentials have been set. Press 'OK' to finish the sign-up process.", vbOKOnly, "NOMG CLINIC")
                Me.Close()
                Form6.Show()
            Else
                MsgBox("Please enter all the required details", vbOKOnly, "NOMG CLINIC")
            End If
        Else
            ' Display a prompt to check the checkbox
            MsgBox("Please check the checkbox to proceed with the signup process.", vbOKOnly, "NOMG CLINIC")
        End If
        If txtUser.Text <> "" Then
            ' Save username to the list of registered usernames
            RegisteredUsernames.Add(txtUser.Text)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("TERMS AND CONDITIONS." & vbCrLf & "Line 2" & vbCrLf & "Line 3", vbOKOnly, "NOMG CLINIC")
    End Sub

    'btn for cancel
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Form7.Show()
    End Sub
End Class