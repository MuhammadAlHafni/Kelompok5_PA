Imports MySql.Data.MySqlClient

Public Class Formlupapassword

    Private Sub Formlupapassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim newPassword As String = txtPass.Text.Trim()
        Dim confirmPassword As String = txtConfirm.Text.Trim()
        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(newPassword) OrElse String.IsNullOrWhiteSpace(confirmPassword) Then
            MessageBox.Show("username dan password tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If newPassword <> confirmPassword Then
            MessageBox.Show("Password tidak cocok, mohon masukkan password yang sama.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        ChangePassword(username, newPassword)
        formlogin.Show()
        Me.Close()
    End Sub

    Private Sub ChangePassword(username As String, newPassword As String)
        Try
            Dim updateQuery As String = "UPDATE user SET password = @password WHERE username = @username"
            CMD = New MySqlCommand(updateQuery, CONN)
            CMD.Parameters.AddWithValue("@username", username)
            CMD.Parameters.AddWithValue("@password", newPassword)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Password telah diganti.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        formlogin.Show()
        Me.Close()
    End Sub
End Class
