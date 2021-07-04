Public Class PanelTransaction
    Dim parent As Form1
    Dim total As Integer

    Public Sub New(parent As Form1)
        Me.parent = parent
    End Sub

    Public Sub searchByIdComic()
        If String.IsNullOrEmpty(parent.tbSearchById.Text) Then
            updateUITransaction(False)
            Return
        End If
        parent.controller.searchComic(parent.dgvDetailComic, parent.tbSearchById.Text)
        If parent.dgvDetailComic.RowCount > 0 Then
            parent.initGridStoragePanel(parent.dgvDetailComic)
            updateUITransaction(True)
        Else
            updateUITransaction(False)
        End If
    End Sub

    Private Sub updateUITransaction(bool As Boolean)
        If bool Then
            parent.tbQty.Enabled = True
            parent.tbMoney.Enabled = True
            parent.btnPay.Enabled = True
        Else
            parent.tbQty.ResetText()
            parent.tbMoney.ResetText()
            parent.tbQty.Enabled = False
            parent.tbMoney.Enabled = False
            parent.btnPay.Enabled = False
            parent.dgvDetailComic.DataSource = Nothing
        End If
    End Sub

    Public Sub updateTotal()
        Try
            If Convert.ToInt32(parent.tbQty.Text) > parent.dgvDetailComic.Rows.Item(0).Cells.Item(4).Value Then
                MsgBox("Maaf jumlah komik kurang dari yang anda inginkan")
                parent.tbQty.ResetText()
                Return
            End If
            total = Convert.ToInt32(parent.tbQty.Text) * parent.dgvDetailComic.Rows.Item(0).Cells.Item(5).Value
            parent.lblTotal.Text = "Total : Rp." & total
        Catch ex As Exception
            total = 0
            parent.lblTotal.Text = "Total : Rp.0"
        End Try
    End Sub

    Private Function isValidForm() As Boolean
        If String.IsNullOrEmpty(parent.tbName.Text) Or
            String.IsNullOrEmpty(parent.tbQty.Text) Or
            String.IsNullOrEmpty(parent.tbSearchById.Text) Or
            String.IsNullOrEmpty(parent.tbMoney.Text) Then
            MsgBox("Pastikan tidak ada form yang kosong")
            Return False
        End If
        Return True
    End Function

    Private Sub resetForm()
        parent.tbName.ResetText()
        parent.tbSearchById.ResetText()
        updateUITransaction(False)
    End Sub

    Private Function isEnoughMoney() As Boolean
        If total > Convert.ToInt32(parent.tbMoney.Text) Then
            MsgBox("Maaf uang anda tidak cukup")
            Return False
        End If
        Return True
    End Function

    Private Sub showStruct()
        Dim response As String = "============================================" &
            Environment.NewLine & "Nama                         : " & parent.tbName.Text &
            Environment.NewLine & "Komik                        : " & parent.dgvDetailComic.Rows.Item(0).Cells.Item(1).Value &
            Environment.NewLine & "Qty                          : " & parent.tbQty.Text &
            Environment.NewLine & Environment.NewLine & "Total                        : Rp." & total &
            Environment.NewLine & "Uang                         : Rp." & parent.tbMoney.Text &
            Environment.NewLine & "Kembalian                    : Rp." & (Convert.ToInt32(parent.tbMoney.Text) - total) &
            Environment.NewLine & "Status Pembayaran            : Sukses" &
            Environment.NewLine & "============================================"

        parent.tbResponseTransaction.Text = response
    End Sub

    Private Function getForm() As Transaction
        Dim transaction = New Transaction.Builder().
            setNameBuyyer(parent.tbName.Text).
        setIdComic(Convert.ToInt32(parent.tbSearchById.Text)).
        setQty(Convert.ToInt32(parent.tbQty.Text)).
        setTotal(total).
        setDateTransaction(String.Format("{0:dd/MM/yyyy}", DateTime.Now)).
        build()

        Return transaction
    End Function

    Public Sub Pay()
        If Not isValidForm() Then Return
        If Not isEnoughMoney() Then Return
        If parent.controller.createTransaction(getForm()) Then
            Dim stock As Integer = parent.dgvDetailComic.Rows.Item(0).Cells(4).Value - Convert.ToInt32(parent.tbQty.Text)
            parent.controller.minusStockComic(Convert.ToInt32(parent.tbSearchById.Text), stock)
        Else
            MsgBox("Maaf terjadi kesalahan")
            Return
        End If
        showStruct()
        resetForm()
    End Sub
End Class
