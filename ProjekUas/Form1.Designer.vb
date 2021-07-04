<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbTitle = New System.Windows.Forms.TextBox()
        Me.tbGenre = New System.Windows.Forms.TextBox()
        Me.tbAuthor = New System.Windows.Forms.TextBox()
        Me.tbStock = New System.Windows.Forms.TextBox()
        Me.statusResponse = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvStorage = New System.Windows.Forms.DataGridView()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.storagePanel = New System.Windows.Forms.Panel()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnUpdateComic = New System.Windows.Forms.Button()
        Me.btnCancelComic = New System.Windows.Forms.Button()
        Me.btnDeleteComic = New System.Windows.Forms.Button()
        Me.btnAddComic = New System.Windows.Forms.Button()
        Me.statusStrip = New System.Windows.Forms.Label()
        Me.menuStorage = New System.Windows.Forms.Label()
        Me.menuTransaction = New System.Windows.Forms.Label()
        Me.menuReport = New System.Windows.Forms.Label()
        Me.menuExit = New System.Windows.Forms.Label()
        Me.transactionPanel = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tbMoney = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.tbResponseTransaction = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvDetailComic = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbQty = New System.Windows.Forms.TextBox()
        Me.tbSearchById = New System.Windows.Forms.TextBox()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.storagePanel.SuspendLayout()
        Me.transactionPanel.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDetailComic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Judul"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(206, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Genre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(473, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Stok"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(323, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Pencipta"
        '
        'tbTitle
        '
        Me.tbTitle.Location = New System.Drawing.Point(36, 59)
        Me.tbTitle.Name = "tbTitle"
        Me.tbTitle.Size = New System.Drawing.Size(100, 20)
        Me.tbTitle.TabIndex = 16
        '
        'tbGenre
        '
        Me.tbGenre.Location = New System.Drawing.Point(170, 59)
        Me.tbGenre.Name = "tbGenre"
        Me.tbGenre.Size = New System.Drawing.Size(100, 20)
        Me.tbGenre.TabIndex = 17
        '
        'tbAuthor
        '
        Me.tbAuthor.Location = New System.Drawing.Point(301, 59)
        Me.tbAuthor.Name = "tbAuthor"
        Me.tbAuthor.Size = New System.Drawing.Size(100, 20)
        Me.tbAuthor.TabIndex = 18
        '
        'tbStock
        '
        Me.tbStock.Location = New System.Drawing.Point(439, 59)
        Me.tbStock.Name = "tbStock"
        Me.tbStock.Size = New System.Drawing.Size(100, 20)
        Me.tbStock.TabIndex = 19
        '
        'statusResponse
        '
        Me.statusResponse.Enabled = False
        Me.statusResponse.Location = New System.Drawing.Point(36, 177)
        Me.statusResponse.Name = "statusResponse"
        Me.statusResponse.Size = New System.Drawing.Size(677, 20)
        Me.statusResponse.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvStorage)
        Me.GroupBox1.Controls.Add(Me.tbSearch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 227)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(677, 304)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Komik"
        '
        'dgvStorage
        '
        Me.dgvStorage.AllowUserToAddRows = False
        Me.dgvStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStorage.Location = New System.Drawing.Point(18, 58)
        Me.dgvStorage.Name = "dgvStorage"
        Me.dgvStorage.Size = New System.Drawing.Size(624, 224)
        Me.dgvStorage.TabIndex = 8
        '
        'tbSearch
        '
        Me.tbSearch.Location = New System.Drawing.Point(290, 19)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(136, 20)
        Me.tbSearch.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(211, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cari Komik"
        '
        'storagePanel
        '
        Me.storagePanel.BackColor = System.Drawing.SystemColors.Highlight
        Me.storagePanel.Controls.Add(Me.tbPrice)
        Me.storagePanel.Controls.Add(Me.Label6)
        Me.storagePanel.Controls.Add(Me.btnUpdateComic)
        Me.storagePanel.Controls.Add(Me.btnCancelComic)
        Me.storagePanel.Controls.Add(Me.btnDeleteComic)
        Me.storagePanel.Controls.Add(Me.btnAddComic)
        Me.storagePanel.Controls.Add(Me.GroupBox1)
        Me.storagePanel.Controls.Add(Me.statusResponse)
        Me.storagePanel.Controls.Add(Me.tbStock)
        Me.storagePanel.Controls.Add(Me.tbAuthor)
        Me.storagePanel.Controls.Add(Me.tbGenre)
        Me.storagePanel.Controls.Add(Me.tbTitle)
        Me.storagePanel.Controls.Add(Me.Label5)
        Me.storagePanel.Controls.Add(Me.Label4)
        Me.storagePanel.Controls.Add(Me.Label3)
        Me.storagePanel.Controls.Add(Me.Label2)
        Me.storagePanel.Location = New System.Drawing.Point(0, 36)
        Me.storagePanel.Name = "storagePanel"
        Me.storagePanel.Size = New System.Drawing.Size(748, 534)
        Me.storagePanel.TabIndex = 0
        '
        'tbPrice
        '
        Me.tbPrice.Location = New System.Drawing.Point(578, 59)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(100, 20)
        Me.tbPrice.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(612, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Harga"
        '
        'btnUpdateComic
        '
        Me.btnUpdateComic.Enabled = False
        Me.btnUpdateComic.Location = New System.Drawing.Point(326, 122)
        Me.btnUpdateComic.Name = "btnUpdateComic"
        Me.btnUpdateComic.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateComic.TabIndex = 26
        Me.btnUpdateComic.Text = "Ubah"
        Me.btnUpdateComic.UseVisualStyleBackColor = True
        '
        'btnCancelComic
        '
        Me.btnCancelComic.Location = New System.Drawing.Point(554, 122)
        Me.btnCancelComic.Name = "btnCancelComic"
        Me.btnCancelComic.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelComic.TabIndex = 24
        Me.btnCancelComic.Text = "Cancel"
        Me.btnCancelComic.UseVisualStyleBackColor = True
        '
        'btnDeleteComic
        '
        Me.btnDeleteComic.Enabled = False
        Me.btnDeleteComic.Location = New System.Drawing.Point(437, 122)
        Me.btnDeleteComic.Name = "btnDeleteComic"
        Me.btnDeleteComic.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteComic.TabIndex = 23
        Me.btnDeleteComic.Text = "Hapus"
        Me.btnDeleteComic.UseVisualStyleBackColor = True
        '
        'btnAddComic
        '
        Me.btnAddComic.Location = New System.Drawing.Point(71, 122)
        Me.btnAddComic.Name = "btnAddComic"
        Me.btnAddComic.Size = New System.Drawing.Size(201, 23)
        Me.btnAddComic.TabIndex = 22
        Me.btnAddComic.Text = "Tambahkan Ke Gudang"
        Me.btnAddComic.UseVisualStyleBackColor = True
        '
        'statusStrip
        '
        Me.statusStrip.AutoSize = True
        Me.statusStrip.Location = New System.Drawing.Point(12, 573)
        Me.statusStrip.Name = "statusStrip"
        Me.statusStrip.Size = New System.Drawing.Size(65, 13)
        Me.statusStrip.TabIndex = 1
        Me.statusStrip.Text = "Data Master"
        '
        'menuStorage
        '
        Me.menuStorage.AutoSize = True
        Me.menuStorage.Location = New System.Drawing.Point(15, 13)
        Me.menuStorage.Name = "menuStorage"
        Me.menuStorage.Size = New System.Drawing.Size(65, 13)
        Me.menuStorage.TabIndex = 2
        Me.menuStorage.Text = "Data Master"
        '
        'menuTransaction
        '
        Me.menuTransaction.AutoSize = True
        Me.menuTransaction.Location = New System.Drawing.Point(101, 13)
        Me.menuTransaction.Name = "menuTransaction"
        Me.menuTransaction.Size = New System.Drawing.Size(53, 13)
        Me.menuTransaction.TabIndex = 3
        Me.menuTransaction.Text = "Transaksi"
        '
        'menuReport
        '
        Me.menuReport.AutoSize = True
        Me.menuReport.Location = New System.Drawing.Point(181, 13)
        Me.menuReport.Name = "menuReport"
        Me.menuReport.Size = New System.Drawing.Size(46, 13)
        Me.menuReport.TabIndex = 4
        Me.menuReport.Text = "Laporan"
        '
        'menuExit
        '
        Me.menuExit.AutoSize = True
        Me.menuExit.Location = New System.Drawing.Point(259, 13)
        Me.menuExit.Name = "menuExit"
        Me.menuExit.Size = New System.Drawing.Size(37, 13)
        Me.menuExit.TabIndex = 5
        Me.menuExit.Text = "Keluar"
        '
        'transactionPanel
        '
        Me.transactionPanel.BackColor = System.Drawing.SystemColors.Highlight
        Me.transactionPanel.Controls.Add(Me.GroupBox4)
        Me.transactionPanel.Controls.Add(Me.GroupBox3)
        Me.transactionPanel.Controls.Add(Me.GroupBox2)
        Me.transactionPanel.Location = New System.Drawing.Point(0, 36)
        Me.transactionPanel.Name = "transactionPanel"
        Me.transactionPanel.Size = New System.Drawing.Size(748, 534)
        Me.transactionPanel.TabIndex = 29
        Me.transactionPanel.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnPay)
        Me.GroupBox4.Controls.Add(Me.tbMoney)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.lblTotal)
        Me.GroupBox4.Controls.Add(Me.tbResponseTransaction)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 246)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(717, 261)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detail Transaksi"
        '
        'tbMoney
        '
        Me.tbMoney.Enabled = False
        Me.tbMoney.Location = New System.Drawing.Point(80, 86)
        Me.tbMoney.Name = "tbMoney"
        Me.tbMoney.Size = New System.Drawing.Size(166, 20)
        Me.tbMoney.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Uang"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(21, 39)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(63, 13)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "Total : Rp.0"
        '
        'tbResponseTransaction
        '
        Me.tbResponseTransaction.Enabled = False
        Me.tbResponseTransaction.Location = New System.Drawing.Point(348, 26)
        Me.tbResponseTransaction.Multiline = True
        Me.tbResponseTransaction.Name = "tbResponseTransaction"
        Me.tbResponseTransaction.Size = New System.Drawing.Size(331, 210)
        Me.tbResponseTransaction.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvDetailComic)
        Me.GroupBox3.Location = New System.Drawing.Point(320, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(415, 205)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detail Komik"
        '
        'dgvDetailComic
        '
        Me.dgvDetailComic.AllowUserToAddRows = False
        Me.dgvDetailComic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetailComic.Location = New System.Drawing.Point(12, 31)
        Me.dgvDetailComic.Name = "dgvDetailComic"
        Me.dgvDetailComic.Size = New System.Drawing.Size(381, 150)
        Me.dgvDetailComic.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbQty)
        Me.GroupBox2.Controls.Add(Me.tbSearchById)
        Me.GroupBox2.Controls.Add(Me.tbName)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(286, 205)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Pembeli"
        '
        'tbQty
        '
        Me.tbQty.Enabled = False
        Me.tbQty.Location = New System.Drawing.Point(88, 135)
        Me.tbQty.Name = "tbQty"
        Me.tbQty.Size = New System.Drawing.Size(166, 20)
        Me.tbQty.TabIndex = 5
        '
        'tbSearchById
        '
        Me.tbSearchById.Location = New System.Drawing.Point(88, 87)
        Me.tbSearchById.Name = "tbSearchById"
        Me.tbSearchById.Size = New System.Drawing.Size(166, 20)
        Me.tbSearchById.TabIndex = 4
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(86, 40)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(166, 20)
        Me.tbName.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Jumlah"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "ID Komik"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Nama"
        '
        'btnPay
        '
        Me.btnPay.Enabled = False
        Me.btnPay.Location = New System.Drawing.Point(33, 133)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(256, 23)
        Me.btnPay.TabIndex = 7
        Me.btnPay.Text = "Bayar"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(747, 595)
        Me.Controls.Add(Me.transactionPanel)
        Me.Controls.Add(Me.menuExit)
        Me.Controls.Add(Me.menuReport)
        Me.Controls.Add(Me.menuTransaction)
        Me.Controls.Add(Me.menuStorage)
        Me.Controls.Add(Me.statusStrip)
        Me.Controls.Add(Me.storagePanel)
        Me.Name = "Form1"
        Me.Text = "Toko Komik"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvStorage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.storagePanel.ResumeLayout(False)
        Me.storagePanel.PerformLayout()
        Me.transactionPanel.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvDetailComic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbTitle As TextBox
    Friend WithEvents tbGenre As TextBox
    Friend WithEvents tbAuthor As TextBox
    Friend WithEvents tbStock As TextBox
    Friend WithEvents statusResponse As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents storagePanel As Panel
    Friend WithEvents btnDeleteComic As Button
    Friend WithEvents btnAddComic As Button
    Friend WithEvents btnCancelComic As Button
    Friend WithEvents dgvStorage As DataGridView
    Friend WithEvents btnUpdateComic As Button
    Friend WithEvents statusStrip As Label
    Friend WithEvents menuStorage As Label
    Friend WithEvents menuTransaction As Label
    Friend WithEvents menuReport As Label
    Friend WithEvents menuExit As Label
    Friend WithEvents tbPrice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents transactionPanel As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbResponseTransaction As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents tbMoney As TextBox
    Friend WithEvents dgvDetailComic As DataGridView
    Friend WithEvents tbQty As TextBox
    Friend WithEvents tbSearchById As TextBox
    Friend WithEvents tbName As TextBox
    Friend WithEvents btnPay As Button
End Class
