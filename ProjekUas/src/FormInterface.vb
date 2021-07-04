Public Interface FormInterface
    Function createComic(comic As Komik) As Boolean
    Function updateComic(comic As Komik) As Boolean
    Function deleteComic(comic As Komik) As Boolean

    Sub searchComic(dgv As DataGridView, clue As Object)
    Sub readComics(dgv As DataGridView)

    Sub minusStockComic(idComic As Integer, stockWasBuyed As Integer)

    Function createTransaction(transaction As Transaction) As Boolean
End Interface
