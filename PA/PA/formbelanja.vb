Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class FormBelanja
    Private printDocument As New PrintDocument()
    Private printPreviewDialog As New PrintPreviewDialog()

    Private Sub FormBelanja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAvailableItems()
        LoadCartItems()
        DataGridView1.ClearSelection()
        DataGridView2.ClearSelection()
        printDocument.DefaultPageSettings.PaperSize = New PaperSize("Custom Receipt", 310, 500)
        AddHandler printDocument.PrintPage, AddressOf PrintReceipt
        printPreviewDialog.Document = printDocument
    End Sub

    Private Sub LoadAvailableItems()
        Try
            Dim query As String = "SELECT Merk, Harga, Bahan, Ukuran, Kategori, Warna FROM tbtas"
            CMD = New MySqlCommand(query, CONN)
            DA = New MySqlDataAdapter(CMD)
            DS = New DataSet
            DA.Fill(DS, "tbtas")
            DataGridView1.DataSource = DS.Tables("tbtas")
        Catch ex As Exception
            MessageBox.Show("Error loading available items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadCartItems()
        Dim username As String = loginname
        Try
            Dim query As String = "SELECT Merk, Harga, Jumlah FROM keranjang WHERE Username = @Username"
            CMD = New MySqlCommand(query, CONN)
            CMD.Parameters.AddWithValue("@Username", username)
            DA = New MySqlDataAdapter(CMD)
            DS = New DataSet
            DA.Fill(DS, "keranjang")
            DataGridView2.DataSource = DS.Tables("keranjang")
        Catch ex As Exception
            MessageBox.Show("Error loading cart items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        Dim username As String = loginname
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim merk As String = selectedRow.Cells("Merk").Value.ToString()
            Dim harga As Decimal = Decimal.Parse(selectedRow.Cells("Harga").Value.ToString())
            Dim isItemInCart As Boolean = False
            Dim existingItemRowIndex As Integer = -1
            For Each row As DataGridViewRow In DataGridView2.Rows
                If row.Cells("Merk").Value.ToString() = merk Then
                    isItemInCart = True
                    existingItemRowIndex = row.Index
                    Exit For
                End If
            Next
            Try
                If isItemInCart Then
                    Dim jumlah As Integer = Integer.Parse(DataGridView2.Rows(existingItemRowIndex).Cells("Jumlah").Value.ToString()) + 1
                    Dim queryUpdate As String = "UPDATE keranjang SET Jumlah = @Jumlah WHERE Username = @Username AND Merk = @Merk"
                    CMD = New MySqlCommand(queryUpdate, CONN)
                    CMD.Parameters.AddWithValue("@Username", username)
                    CMD.Parameters.AddWithValue("@Merk", merk)
                    CMD.Parameters.AddWithValue("@Jumlah", jumlah)

                    If CMD.ExecuteNonQuery() > 0 Then
                        LoadCartItems()
                    End If
                Else
                    Dim queryInsert As String = "INSERT INTO keranjang (Username, Merk, Harga, Jumlah) VALUES (@Username, @Merk, @Harga, 1)" ' Assuming default quantity is 1
                    CMD = New MySqlCommand(queryInsert, CONN)
                    CMD.Parameters.AddWithValue("@Username", username)
                    CMD.Parameters.AddWithValue("@Merk", merk)
                    CMD.Parameters.AddWithValue("@Harga", harga)

                    If CMD.ExecuteNonQuery() > 0 Then
                        LoadCartItems()
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Error menambah item: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            DataGridView1.ClearSelection()
            DataGridView2.ClearSelection()
        Else
            MessageBox.Show("Pilih item dari barang yang tersedia.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnRemoveFromCart_Click(sender As Object, e As EventArgs) Handles btnRemoveFromCart.Click
        Dim username As String = loginname
        If DataGridView2.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView2.SelectedRows(0)
            Dim merk As String = selectedRow.Cells("Merk").Value.ToString()
            Try
                Dim queryDelete As String = "DELETE FROM keranjang WHERE Username = @Username AND Merk = @Merk"
                CMD = New MySqlCommand(queryDelete, CONN)
                CMD.Parameters.AddWithValue("@Username", username)
                CMD.Parameters.AddWithValue("@Merk", merk)

                If CMD.ExecuteNonQuery() > 0 Then
                    LoadCartItems()
                End If
            Catch ex As Exception
                MessageBox.Show("Error menghapus item: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            DataGridView1.ClearSelection()
            DataGridView2.ClearSelection()
        Else
            MessageBox.Show("Pilih item dari keranjang yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnChangeQuantity_Click(sender As Object, e As EventArgs) Handles btnChangeQuantity.Click
        Dim username As String = loginname
        If DataGridView2.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView2.SelectedRows(0)
            Dim merk As String = selectedRow.Cells("Merk").Value.ToString()
            Dim newQuantity As Integer

            If Integer.TryParse(txtQuantity.Text, newQuantity) AndAlso newQuantity > 0 Then
                Try
                    Dim queryUpdate As String = "UPDATE keranjang SET Jumlah = @Jumlah WHERE Username = @Username AND Merk = @Merk"
                    CMD = New MySqlCommand(queryUpdate, CONN)
                    CMD.Parameters.AddWithValue("@Username", username)
                    CMD.Parameters.AddWithValue("@Merk", merk)
                    CMD.Parameters.AddWithValue("@Jumlah", newQuantity)

                    If CMD.ExecuteNonQuery() > 0 Then
                        LoadCartItems()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error mengubah jumlah item: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                DataGridView1.ClearSelection()
                DataGridView2.ClearSelection()
            End If
        Else
            MessageBox.Show("Pilih item dari keranjang terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        DataGridView2.ClearSelection()
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        DataGridView1.ClearSelection()
    End Sub

    Private Sub PrintReceipt(sender As Object, e As PrintPageEventArgs)
        Dim username As String = loginname
        Dim receiptContent As String = "Thank you for shopping with us, " & username & "!" & vbCrLf
        receiptContent &= "------------------------------------------" & vbCrLf
        receiptContent &= "Item                  Price    Quantity" & vbCrLf
        receiptContent &= "------------------------------------------" & vbCrLf
        For Each row As DataGridViewRow In DataGridView2.Rows
            Dim merk As String = row.Cells("Merk").Value.ToString()
            Dim harga As Decimal = Decimal.Parse(row.Cells("Harga").Value.ToString())
            Dim jumlah As Integer = Integer.Parse(row.Cells("Jumlah").Value.ToString())
            Dim formattedItemName As String = merk.PadRight(20)
            receiptContent &= formattedItemName & " " & harga.ToString("C").PadLeft(8) & " " & jumlah.ToString().PadLeft(9) & vbCrLf
        Next
        Dim totalPrice As Decimal = 0
        For Each row As DataGridViewRow In DataGridView2.Rows
            Dim harga As Decimal = Decimal.Parse(row.Cells("Harga").Value.ToString())
            Dim jumlah As Integer = Integer.Parse(row.Cells("Jumlah").Value.ToString())
            totalPrice += harga * jumlah
        Next
        receiptContent &= "------------------------------------------" & vbCrLf
        receiptContent &= "Total:".PadRight(20) & totalPrice.ToString("C") & vbCrLf
        Dim font As New Font("Courier New", 8)
        Dim brush As New SolidBrush(Color.Black)
        Dim xPos As Single = 10
        Dim yPos As Single = 10
        For Each line As String In receiptContent.Split(vbCrLf)
            e.Graphics.DrawString(line, font, brush, xPos, yPos)
            yPos += font.GetHeight()
        Next
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        printPreviewDialog.ShowDialog()
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        loginstat = ""
        loginname = ""
        formlogin.Show()
        Me.Close()
    End Sub
End Class
