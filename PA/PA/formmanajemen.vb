Imports MySql.Data.MySqlClient

Public Class formmanajemen
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        LoadDataGridView(DataGridView1)
    End Sub

    Private Sub LoadDataGridView(dataGridView As DataGridView)
        Try
            Dim query As String = "SELECT Merk, Harga, Bahan, Ukuran, Kategori, Warna FROM tbtas"
            CMD = New MySqlCommand(query, CONN)
            DA = New MySqlDataAdapter(CMD)
            DS = New DataSet
            DA.Fill(DS, "tbtas")
            DataGridView1.DataSource = DS.Tables("tbTas")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtMerk.Text = row.Cells("Merk").Value.ToString()
            txtHarga.Text = row.Cells("Harga").Value.ToString()
            cbBahan.Text = row.Cells("Bahan").Value.ToString()
            cbUkuran.Text = row.Cells("Ukuran").Value.ToString()
            SelectCategory(row.Cells("Kategori").Value.ToString())
            SelectColors(row.Cells("Warna").Value.ToString())
        End If
    End Sub


    Private Sub DataGridView1_TextChanged(sender As Object, e As EventArgs) Handles DataGridView1.TextChanged
        Try
            Dim query As String = "SELECT * FROM tbTas WHERE Merk LIKE %@Merk%"
            CMD = New MySqlCommand(query, CONN)
            CMD.Parameters.AddWithValue("@Merk", "%" & DataGridView1.CurrentCell.Value.ToString() & "%")
            DA = New MySqlDataAdapter(CMD)
            DS = New DataSet
            DA.Fill(DS, "tbTas")
            DataGridView1.DataSource = DS.Tables("tbTas")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If ValidateInput() Then
            Try
                Dim query As String = "INSERT INTO tbTas (Merk, Harga, Bahan, Ukuran, Kategori, Warna) VALUES (@Merk, @Harga, @Bahan, @Ukuran, @Kategori, @Warna)"
                CMD = New MySqlCommand(query, CONN)
                CMD.Parameters.AddWithValue("@Merk", txtMerk.Text)
                CMD.Parameters.AddWithValue("@Harga", txtHarga.Text)
                CMD.Parameters.AddWithValue("@Bahan", cbBahan.Text)
                CMD.Parameters.AddWithValue("@Ukuran", cbUkuran.Text)
                CMD.Parameters.AddWithValue("@Kategori", GetSelectedCategory())
                CMD.Parameters.AddWithValue("@Warna", GetSelectedColors())

                If CMD.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Data berhasil ditambahkan.")
                    LoadDataGridView(DataGridView1)
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If ValidateInput() Then
            Try
                Dim query As String = "UPDATE tbTas SET Merk=@Merk, Harga=@Harga, Bahan=@Bahan, Ukuran=@Ukuran, Kategori=@Kategori, Warna=@Warna WHERE Merk=@Merk"
                CMD = New MySqlCommand(query, CONN)
                CMD.Parameters.AddWithValue("@Merk", txtMerk.Text)
                CMD.Parameters.AddWithValue("@Harga", txtHarga.Text)
                CMD.Parameters.AddWithValue("@Bahan", cbBahan.Text)
                CMD.Parameters.AddWithValue("@Ukuran", cbUkuran.Text)
                CMD.Parameters.AddWithValue("@Kategori", GetSelectedCategory())
                CMD.Parameters.AddWithValue("@Warna", GetSelectedColors())

                If CMD.ExecuteNonQuery() > 0 Then
                    MessageBox.Show("Data berhasil diubah.")
                    LoadDataGridView(DataGridView1)
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Try
            Dim query As String = "DELETE FROM tbTas WHERE Merk=@Merk"
            CMD = New MySqlCommand(query, CONN)
            CMD.Parameters.AddWithValue("@Merk", txtMerk.Text)

            If CMD.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Data berhasil dihapus.")
                LoadDataGridView(DataGridView1)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetSelectedCategory() As String
        If rbransel.Checked Then
            Return "Ransel"
        ElseIf rbhandbag.Checked Then
            Return "Handbag"
        ElseIf rbtasselempang.Checked Then
            Return "Sling"
        Else
            Return String.Empty
        End If
    End Function

    Private Function GetSelectedColors() As String
        Dim colors As New List(Of String)
        If cbMerah.Checked Then colors.Add("Merah")
        If cbkuning.Checked Then colors.Add("Kuning")
        If cbhijau.Checked Then colors.Add("Hijau")
        Return String.Join(", ", colors)
    End Function

    Private Sub SelectCategory(category As String)
        rbransel.Checked = category = "Ransel"
        rbhandbag.Checked = category = "Handbag"
        rbtasselempang.Checked = category = "Tasselempang"
    End Sub

    Private Sub SelectColors(colors As String)
        Dim colorArray As String() = colors.Split(", ")
        cbMerah.Checked = colorArray.Contains("Merah")
        cbkuning.Checked = colorArray.Contains("Kuning")
        cbhijau.Checked = colorArray.Contains("Hijau")
    End Sub

    Private Function ValidateInput() As Boolean
        If String.IsNullOrWhiteSpace(txtMerk.Text) Then
            MessageBox.Show("Merk tas harus diisi.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtHarga.Text) Then
            MessageBox.Show("Harga tas harus diisi.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(cbBahan.Text) Then
            MessageBox.Show("Bahan harus diisi.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(cbUkuran.Text) Then
            MessageBox.Show("Ukuran harus diisi.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(GetSelectedCategory()) Then
            MessageBox.Show("Kategori harus dipilih.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(GetSelectedColors()) Then
            MessageBox.Show("Setidaknya satu warna harus dipilih.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        txtMerk.Text = String.Empty
        txtHarga.Text = String.Empty
        cbBahan.SelectedIndex = -1
        cbUkuran.SelectedIndex = -1
        rbransel.Checked = False
        rbhandbag.Checked = False
        rbtasselempang.Checked = False
        cbMerah.Checked = False
        cbkuning.Checked = False
        cbhijau.Checked = False
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Try
            Dim query As String = "SELECT * FROM tbTas WHERE Merk LIKE @Merk"
            CMD = New MySqlCommand(query, CONN)
            CMD.Parameters.AddWithValue("@Merk", "%" & txtCari.Text & "%")
            DA = New MySqlDataAdapter(CMD)
            DS = New DataSet
            DA.Fill(DS, "tbtas")
            DataGridView1.DataSource = DS.Tables("tbtas")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtMerk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMerk.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        loginname = ""
        loginstat = ""
        RD.Close()
        formlogin.Show()
        Me.Close()
    End Sub

    Private Sub ManajemenTasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManajemenTasToolStripMenuItem.Click

    End Sub

    Private Sub KeranjangPelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeranjangPelangganToolStripMenuItem.Click
        Formkeranjangpelanggan.Show()
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)

    End Sub
End Class
