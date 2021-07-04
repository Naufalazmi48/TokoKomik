
Public Class Form1
    Property controller As FormInterface = New Controller()
    Dim PanelStorage As PanelStorage = New PanelStorage(Me)

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

    Private Sub menuStorage_Click(sender As Object, e As EventArgs) Handles menuStorage.Click
        'NON AKTIF ELSE PANEL STORAGE
        PanelStorage.isVisible(True)
        statusStrip.Text = menuStorage.Text
    End Sub

    Private Sub menuTransaction_Click(sender As Object, e As EventArgs) Handles menuTransaction.Click
        'SET VISIBILITY PANEL TRANSACTION
        storagePanel.Visible = False
        statusStrip.Text = menuTransaction.Text
    End Sub

    Private Sub menuExit_Click(sender As Object, e As EventArgs) Handles menuExit.Click
        If MessageBox.Show("Anda yakin ingin keluar?", "Keluar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class
