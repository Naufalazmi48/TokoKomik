Imports System.Data.OleDb
Public Class Controller
    Implements FormInterface

    Public Sub readComics(dgv As DataGridView) Implements FormInterface.readComics
        da = New OleDbDataAdapter("SELECT * FROM storage", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "storage")
        dgv.DataSource = ds.Tables("storage")
        dgv.Refresh()
    End Sub


    Public Function createComic(comic As Komik) As Boolean Implements FormInterface.createComic
        Try
            Dim create As String = "INSERT INTO storage(Judul, Genre, Pencipta, Stok, Harga) VALUES('" &
            comic.Title & "','" &
            comic.Genre & "','" &
            comic.Author & "'," &
            comic.Stock & "," &
            comic.Price & ")"

            cmd = New OleDbCommand(create, Conn)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Public Function updateComic(comic As Komik) As Boolean Implements FormInterface.updateComic
        Try
            Dim update As String = "UPDATE storage SET " &
            "Judul = '" & comic.Title & "'," &
            "Genre = '" & comic.Genre & "'," &
            "Pencipta = '" & comic.Author & "'," &
            "Stok = " & comic.Stock & "," &
            "Harga = " & comic.Price &
            " WHERE Id = " & comic.Id

            cmd = New OleDbCommand(update, Conn)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function deleteComic(comic As Komik) As Boolean Implements FormInterface.deleteComic
        Try
            Dim delete As String = "DELETE FROM storage WHERE Id = " & comic.Id

            cmd = New OleDbCommand(delete, Conn)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub searchComic(dgv As DataGridView, clue As Object) Implements FormInterface.searchComic
        Dim query As String = "SELECT * FROM storage "
        Try
            Convert.ToInt32(clue)
            'Search using id comic
            query += "WHERE Id = " & clue
        Catch ex As Exception
            If ex.GetType = GetType(FormatException) Then
                'Search using title
                query += "WHERE Judul LIKE '" & clue & "%'"
            End If
        Finally
            da = New OleDbDataAdapter(query, Conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "storage")
            dgv.DataSource = ds.Tables("storage")
            dgv.Refresh()
        End Try
    End Sub

    Public Function createTransaction(transaction As Transaction) As Boolean Implements FormInterface.createTransaction
        Try
            Dim create As String = "INSERT INTO [transaction] (Nama_Pembeli, Id_Komik, Qty, Total_Pembayaran, Tanggal) VALUES('" &
            transaction.NameBuyyer & "'," &
            transaction.IdComic & "," &
            transaction.Qty & "," &
            transaction.Total & ",'" &
            transaction.DateTransaction & "')"

            cmd = New OleDbCommand(create, Conn)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Public Sub minusStockComic(idComic As Integer, stockWasBuyed As Integer) Implements FormInterface.minusStockComic
        Try
            Dim update As String = "UPDATE storage SET " &
            "Stok = " & stockWasBuyed &
            " WHERE Id = " & idComic

            cmd = New OleDbCommand(update, Conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
