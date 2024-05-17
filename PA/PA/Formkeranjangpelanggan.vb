Imports MySql.Data.MySqlClient
Public Class Formkeranjangpelanggan

    Private Sub Formkeranjangpelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        LoadCartItems()
    End Sub

    Private Sub LoadCartItems()
        Dim username As String = loginname
        Try
            Dim query As String = "SELECT Username, Merk, Harga, Jumlah FROM keranjang"
            CMD = New MySqlCommand(query, CONN)
            DA = New MySqlDataAdapter(CMD)
            DS = New DataSet
            DA.Fill(DS, "keranjang")
            DataGridView1.DataSource = DS.Tables("keranjang")
        Catch ex As Exception
            MessageBox.Show("Error loading cart items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ManajemenTasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManajemenTasToolStripMenuItem.Click
        formmanajemen.Show()
        Me.Close()
    End Sub

    Private Sub KeranjangPelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeranjangPelangganToolStripMenuItem.Click

    End Sub
End Class