
Public Class Form1
    Property controller As FormInterface = New Controller()
    Dim PanelStorage As PanelStorage = New PanelStorage(Me)
    Dim PanelTransaction As PanelTransaction = New PanelTransaction(Me)

    '=============================== PANEL STORAGE EVENT HANDLER =====================================================
    Private Sub dgvStorage_SelectionChanged(sender As Object, e As EventArgs) Handles dgvStorage.SelectionChanged
        PanelStorage.dataGridViewSlectionChanged()
    End Sub

    Private Sub btnCancelComic_Click(sender As Object, e As EventArgs) Handles btnCancelComic.Click
        PanelStorage.resetForm()
    End Sub

    Private Sub btnUpdateComic_Click(sender As Object, e As EventArgs) Handles btnUpdateComic.Click
        PanelStorage.updateComic()
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        PanelStorage.searchComic()
    End Sub
    Private Sub tbStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbStock.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPrice.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnAddComic_Click(sender As Object, e As EventArgs) Handles btnAddComic.Click
        PanelStorage.createComic()
    End Sub

    Private Sub btnDeleteComic_Click(sender As Object, e As EventArgs) Handles btnDeleteComic.Click
        PanelStorage.deleteComic()
    End Sub

    '=================================================================================================================

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        PanelStorage.isVisible(True)

    End Sub

    Public Sub initGridStoragePanel(dgv As DataGridView)
        For index As Integer = 0 To dgv.Columns.Count - 1
            dgv.Columns(index).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next

        dgv.Columns(0).HeaderText = "Id"
        dgv.Columns(1).HeaderText = "Judul"
        dgv.Columns(2).HeaderText = "Genre"
        dgv.Columns(3).HeaderText = "Pencipta"
        dgv.Columns(4).HeaderText = "Stok"
        dgv.Columns(5).HeaderText = "Harga"
    End Sub

    Private Sub menuStorage_Click(sender As Object, e As EventArgs) Handles menuStorage.Click
        'NON AKTIF ELSE PANEL STORAGE
        PanelStorage.isVisible(True)
        transactionPanel.Visible = False
        statusStrip.Text = menuStorage.Text
    End Sub

    Private Sub menuTransaction_Click(sender As Object, e As EventArgs) Handles menuTransaction.Click
        'SET VISIBILITY PANEL TRANSACTION
        transactionPanel.Visible = True
        storagePanel.Visible = False
        statusStrip.Text = menuTransaction.Text
    End Sub

    Private Sub menuExit_Click(sender As Object, e As EventArgs) Handles menuExit.Click
        If MessageBox.Show("Anda yakin ingin keluar?", "Keluar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub menuReport_Click(sender As Object, e As EventArgs) Handles menuReport.Click
        LaporanTransaksi.Show()
    End Sub

    Private Sub tbSearchById_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSearchById.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbSearchById_TextChanged(sender As Object, e As EventArgs) Handles tbSearchById.TextChanged
        PanelTransaction.searchByIdComic()
    End Sub

    Private Sub tbQty_TextChanged(sender As Object, e As EventArgs) Handles tbQty.TextChanged
        PanelTransaction.updateTotal()
    End Sub

    Private Sub tbQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbQty.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        PanelTransaction.Pay()
    End Sub
End Class
