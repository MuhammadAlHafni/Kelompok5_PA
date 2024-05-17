Imports MySql.Data.MySqlClient

Public Class formlogin

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPass.Text

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Username dan password tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Login(username, password)
    End Sub

    Private Sub btnRegis_Click(sender As Object, e As EventArgs) Handles btnRegis.Click
        Formregister.Show()
        Me.Close()
    End Sub

    Private Sub Login(username As String, password As String)
        Try
            Dim query As String = "SELECT * FROM user WHERE username = @username AND password = @password"
            CMD = New MySqlCommand(query, CONN)
            CMD.Parameters.AddWithValue("@username", username)
            CMD.Parameters.AddWithValue("@password", password)
            RD = CMD.ExecuteReader()

            If RD.HasRows Then
                RD.Read()
                Dim status As String = RD("status").ToString()
                RD.Close()

                If status = "admin" Then
                    Module1.loginstat = "admin"
                    formmanajemen.Show()
                Else
                    Module1.loginstat = "user"
                    Module1.loginname = txtUsername.Text
                    FormBelanja.Show()
                End If
                Me.Close()
            Else
                MessageBox.Show("Username atau password salah.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            RD.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
