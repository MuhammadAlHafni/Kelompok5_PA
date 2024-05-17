<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formmanajemen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbBahan = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbhijau = New System.Windows.Forms.CheckBox()
        Me.cbkuning = New System.Windows.Forms.CheckBox()
        Me.cbMerah = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbhandbag = New System.Windows.Forms.RadioButton()
        Me.rbtasselempang = New System.Windows.Forms.RadioButton()
        Me.rbransel = New System.Windows.Forms.RadioButton()
        Me.cbUkuran = New System.Windows.Forms.ComboBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtMerk = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManajemenTasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeranjangPelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(270, 333)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Cari"
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.Transparent
        Me.btnBatal.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(619, 269)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 27)
        Me.btnBatal.TabIndex = 32
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.Transparent
        Me.btnHapus.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(533, 269)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 27)
        Me.btnHapus.TabIndex = 31
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(449, 269)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 27)
        Me.btnEdit.TabIndex = 30
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.Transparent
        Me.btnSimpan.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(361, 269)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 27)
        Me.btnSimpan.TabIndex = 29
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(310, 336)
        Me.txtCari.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCari.Multiline = True
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(372, 17)
        Me.txtCari.TabIndex = 28
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(144, 369)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(641, 157)
        Me.DataGridView1.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(140, 228)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Ukuran"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(140, 176)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Bahan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(140, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Harga"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Merk"
        '
        'cbBahan
        '
        Me.cbBahan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBahan.FormattingEnabled = True
        Me.cbBahan.Items.AddRange(New Object() {"Kulit", "Kanvas", "Sintetis"})
        Me.cbBahan.Location = New System.Drawing.Point(199, 175)
        Me.cbBahan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbBahan.Name = "cbBahan"
        Me.cbBahan.Size = New System.Drawing.Size(92, 21)
        Me.cbBahan.TabIndex = 22
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Premium_Photo___Filled_miniature_cart_with_paper_shopping_bags_in_front_of_pink_background
        Me.GroupBox2.Controls.Add(Me.cbhijau)
        Me.GroupBox2.Controls.Add(Me.cbkuning)
        Me.GroupBox2.Controls.Add(Me.cbMerah)
        Me.GroupBox2.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(364, 155)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(290, 73)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Warna"
        '
        'cbhijau
        '
        Me.cbhijau.AutoSize = True
        Me.cbhijau.Location = New System.Drawing.Point(204, 33)
        Me.cbhijau.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbhijau.Name = "cbhijau"
        Me.cbhijau.Size = New System.Drawing.Size(61, 24)
        Me.cbhijau.TabIndex = 2
        Me.cbhijau.Text = "Hijau"
        Me.cbhijau.UseVisualStyleBackColor = True
        '
        'cbkuning
        '
        Me.cbkuning.AutoSize = True
        Me.cbkuning.Location = New System.Drawing.Point(104, 33)
        Me.cbkuning.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbkuning.Name = "cbkuning"
        Me.cbkuning.Size = New System.Drawing.Size(73, 24)
        Me.cbkuning.TabIndex = 1
        Me.cbkuning.Text = "Kuning"
        Me.cbkuning.UseVisualStyleBackColor = True
        '
        'cbMerah
        '
        Me.cbMerah.AutoSize = True
        Me.cbMerah.Location = New System.Drawing.Point(18, 33)
        Me.cbMerah.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbMerah.Name = "cbMerah"
        Me.cbMerah.Size = New System.Drawing.Size(69, 24)
        Me.cbMerah.TabIndex = 0
        Me.cbMerah.Text = "Merah"
        Me.cbMerah.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Premium_Photo___Filled_miniature_cart_with_paper_shopping_bags_in_front_of_pink_background
        Me.GroupBox1.Controls.Add(Me.rbhandbag)
        Me.GroupBox1.Controls.Add(Me.rbtasselempang)
        Me.GroupBox1.Controls.Add(Me.rbransel)
        Me.GroupBox1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(364, 35)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(330, 80)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kategori"
        '
        'rbhandbag
        '
        Me.rbhandbag.AutoSize = True
        Me.rbhandbag.Location = New System.Drawing.Point(104, 32)
        Me.rbhandbag.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbhandbag.Name = "rbhandbag"
        Me.rbhandbag.Size = New System.Drawing.Size(98, 24)
        Me.rbhandbag.TabIndex = 4
        Me.rbhandbag.TabStop = True
        Me.rbhandbag.Text = "Tas Tangan"
        Me.rbhandbag.UseVisualStyleBackColor = True
        '
        'rbtasselempang
        '
        Me.rbtasselempang.AutoSize = True
        Me.rbtasselempang.Location = New System.Drawing.Point(204, 32)
        Me.rbtasselempang.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtasselempang.Name = "rbtasselempang"
        Me.rbtasselempang.Size = New System.Drawing.Size(124, 24)
        Me.rbtasselempang.TabIndex = 5
        Me.rbtasselempang.TabStop = True
        Me.rbtasselempang.Text = "Tas Selempang"
        Me.rbtasselempang.UseVisualStyleBackColor = True
        '
        'rbransel
        '
        Me.rbransel.AutoSize = True
        Me.rbransel.Location = New System.Drawing.Point(16, 32)
        Me.rbransel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbransel.Name = "rbransel"
        Me.rbransel.Size = New System.Drawing.Size(72, 24)
        Me.rbransel.TabIndex = 0
        Me.rbransel.TabStop = True
        Me.rbransel.Text = "Ransel"
        Me.rbransel.UseVisualStyleBackColor = True
        '
        'cbUkuran
        '
        Me.cbUkuran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUkuran.FormattingEnabled = True
        Me.cbUkuran.Items.AddRange(New Object() {"Panjang", "Lebar", "Tinggi"})
        Me.cbUkuran.Location = New System.Drawing.Point(199, 227)
        Me.cbUkuran.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbUkuran.Name = "cbUkuran"
        Me.cbUkuran.Size = New System.Drawing.Size(92, 21)
        Me.cbUkuran.TabIndex = 19
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(199, 111)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(94, 20)
        Me.txtHarga.TabIndex = 18
        '
        'txtMerk
        '
        Me.txtMerk.Location = New System.Drawing.Point(199, 54)
        Me.txtMerk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMerk.Name = "txtMerk"
        Me.txtMerk.Size = New System.Drawing.Size(92, 20)
        Me.txtMerk.TabIndex = 17
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(848, 24)
        Me.MenuStrip1.TabIndex = 35
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(57, 20)
        Me.ToolStripMenuItem1.Text = "Logout"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManajemenTasToolStripMenuItem, Me.KeranjangPelangganToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(89, 20)
        Me.ToolStripMenuItem2.Text = "Menu Admin"
        '
        'ManajemenTasToolStripMenuItem
        '
        Me.ManajemenTasToolStripMenuItem.Name = "ManajemenTasToolStripMenuItem"
        Me.ManajemenTasToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ManajemenTasToolStripMenuItem.Text = "Manajemen Tas"
        '
        'KeranjangPelangganToolStripMenuItem
        '
        Me.KeranjangPelangganToolStripMenuItem.Name = "KeranjangPelangganToolStripMenuItem"
        Me.KeranjangPelangganToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.KeranjangPelangganToolStripMenuItem.Text = "Keranjang Pelanggan"
        '
        'formmanajemen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Premium_Photo___Filled_miniature_cart_with_paper_shopping_bags_in_front_of_pink_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(848, 558)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbBahan)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbUkuran)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtMerk)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "formmanajemen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manajemen Penjualan Tas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbBahan As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbhijau As System.Windows.Forms.CheckBox
    Friend WithEvents cbkuning As System.Windows.Forms.CheckBox
    Friend WithEvents cbMerah As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbhandbag As System.Windows.Forms.RadioButton
    Friend WithEvents rbtasselempang As System.Windows.Forms.RadioButton
    Friend WithEvents rbransel As System.Windows.Forms.RadioButton
    Friend WithEvents cbUkuran As System.Windows.Forms.ComboBox
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents txtMerk As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManajemenTasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeranjangPelangganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
