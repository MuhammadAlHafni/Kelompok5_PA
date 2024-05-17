Imports MySql.Data.MySqlClient

Public Class Formregister

    Private Sub Formregister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub Register(username As String, password As String)
        Try
            Dim checkQuery As String = "SELECT * FROM user WHERE username = @username"
            CMD = New MySqlCommand(checkQuery, CONN)
            CMD.Parameters.AddWithValue("@username", username)
            RD = CMD.ExecuteReader()

            If RD.HasRows Then
                RD.Close()
                MessageBox.Show("Username telah ada, mohon pilih username lain.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            RD.Close()

            Dim insertQuery As String = "INSERT INTO user (username, password, status) VALUES (@username, @password, 'user')"
            CMD = New MySqlCommand(insertQuery, CONN)
            CMD.Parameters.AddWithValue("@username", username)
            CMD.Parameters.AddWithValue("@password", password)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Registrasi berhasil.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FormBelanja.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPass.Text.Trim()
        Dim confirmPassword As String = txtConfirm.Text.Trim()

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Username dan password tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If password <> confirmPassword Then
            MessageBox.Show("Password tidak cocok, mohon samakan password pada kedua input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Register(username, password)
    End Sub

    Private Sub btnLupa_Click(sender As Object, e As EventArgs) Handles btnLupa.Click
        Formlupapassword.Show()
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        formlogin.Show()
        Me.Close()
    End Sub
End Class
