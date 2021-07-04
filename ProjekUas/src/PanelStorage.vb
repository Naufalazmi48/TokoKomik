Public Class PanelStorage

    Dim selectedIndex As Integer = -1
    Dim parent As Form1

    Public Sub New(parent As Form1)
        Me.parent = parent
    End Sub

    Protected Sub showAllComics()
        parent.controller.readComics(parent.dgvStorage)
    End Sub

    Public Sub createComic()
        If Not isValidForm() Then Return
        Dim komik As Komik = getForm()
        If parent.controller.createComic(komik) Then
            parent.statusResponse.Text = "Berhasil menambahkan komik"
            showAllComics()
        Else
            parent.statusResponse.Text = "Gagal menambahkan komik"
        End If
        resetForm()
    End Sub

    Public Sub updateComic()
        If Not isValidForm() Then Return
        Dim komik As Komik = getForm(selectedIndex)
        If parent.controller.updateComic(komik) Then
            parent.statusResponse.Text = "Berhasil mengubah komik"
            showAllComics()
        Else
            parent.statusResponse.Text = "Gagal mengubah komik"
        End If
        resetForm()
    End Sub
    Public Sub deleteComic()
        If Not isValidForm() Then Return
        Dim komik As Komik = getForm(selectedIndex)
        If parent.controller.deleteComic(komik) Then
            parent.statusResponse.Text = "Berhasil menghapus komik"
            showAllComics()
        Else
            parent.statusResponse.Text = "Gagal menghapus komik"
        End If
        resetForm()

    End Sub

    Private Function isValidForm() As Boolean
        If String.IsNullOrEmpty(parent.tbAuthor.Text) Or
            String.IsNullOrEmpty(parent.tbGenre.Text) Or
            String.IsNullOrEmpty(parent.tbPrice.Text) Or
            String.IsNullOrEmpty(parent.tbStock.Text) Or
            String.IsNullOrEmpty(parent.tbTitle.Text) Then
            MsgBox("Pastikan tidak ada form yang kosong")
            Return False
        End If
        Return True
    End Function
    Public Sub resetForm()
        parent.tbTitle.ResetText()
        parent.tbAuthor.ResetText()
        parent.tbGenre.ResetText()
        parent.tbStock.ResetText()
        parent.tbPrice.ResetText()
        parent.dgvStorage.ClearSelection()
        selectedIndex = -1
        updateForm()
    End Sub

    Private Sub updateForm()
        'If Selectedindex = -1 then Create Mode else Update, delete mode
        If selectedIndex <> -1 Then
            parent.btnUpdateComic.Enabled = True
            parent.btnDeleteComic.Enabled = True
            parent.btnAddComic.Enabled = False
        Else
            parent.btnUpdateComic.Enabled = False
            parent.btnDeleteComic.Enabled = False
            parent.btnAddComic.Enabled = True
        End If
    End Sub

    Private Function getForm(Optional id As Integer = 0) As Komik
        Dim komik = New Komik.Builder().
        setId(id).
        setTitle(parent.tbTitle.Text).
        setGenre(parent.tbGenre.Text).
        setAuthor(parent.tbAuthor.Text).
        setStock(Convert.ToInt32(parent.tbStock.Text)).
        setPrice(Convert.ToInt32(parent.tbPrice.Text)).
        build()

        Return komik
    End Function

    Public Sub dataGridViewSlectionChanged()
        Try
            For Each row As DataGridViewRow In parent.dgvStorage.SelectedRows
                If row.Cells.Item(0).Value > 0 Then
                    selectedIndex = row.Cells.Item(0).Value
                    parent.tbTitle.Text = row.Cells.Item(1).Value
                    parent.tbGenre.Text = row.Cells.Item(2).Value
                    parent.tbAuthor.Text = row.Cells.Item(3).Value
                    parent.tbStock.Text = row.Cells.Item(4).Value
                    parent.tbPrice.Text = row.Cells.Item(5).Value
                    updateForm()
                End If
            Next
        Catch ex As InvalidCastException

        End Try

    End Sub

    Public Sub searchComic()
        If String.IsNullOrEmpty(parent.tbSearch.Text) Then
            showAllComics()
        Else
            parent.controller.searchComic(parent.dgvStorage, parent.tbSearch.Text)
        End If
    End Sub

    Public Sub isVisible(value As Boolean)
        If value Then
            showAllComics()
            parent.initGridStoragePanel(parent.dgvStorage)
        End If
        parent.storagePanel.Visible = value
    End Sub
End Class
