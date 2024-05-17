Imports MySql.Data.MySqlClient
Module Module1
    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public STR As String
    Public loginstat As String
    Public loginname As String

    Public Sub koneksi()
        Try
            STR = "server=localhost;userid=root;password=;database=dbtas"
            CONN = New MySqlConnection(STR)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Public Sub LoadDataGridView(ByVal DataGridView1 As DataGridView)
    '    Try
    '        Dim query As String = "SELECT * FROM tbTas"
    '        DA = New MySqlDataAdapter(query, CONN)
    '        DS = New DataSet
    '        DA.Fill(DS, "tbTas")
    '        DataGridView1.DataSource = DS.Tables("tbTas")
    '    Catch ex As Exception
    '        MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
End Module

