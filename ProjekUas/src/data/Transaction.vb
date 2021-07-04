Public Class Transaction
    Public ReadOnly Property Id() As Integer
    Public ReadOnly Property NameBuyyer() As String
    Public ReadOnly Property IdComic() As Integer
    Public ReadOnly Property Qty() As Integer
    Public ReadOnly Property Total() As Integer
    Public ReadOnly Property DateTransaction() As String
    Public Sub New(builder As Builder)
        Id = builder.getId()
        NameBuyyer = builder.getNameBuyyer()
        IdComic = builder.getIdComic()
        Qty = builder.getQty()
        Total = builder.getTotal()
        DateTransaction = builder.getDateTransaction()
    End Sub

    Class Builder
        Private id As Integer = 0
        Private nameBuyyer As String = ""
        Private idComic As Integer = 0
        Private qty As Integer = 0
        Private total As Integer = 0
        Private dateTransaction As String = ""

        Public Function getId() As Integer
            Return id
        End Function
        Public Function setId(value As Integer) As Builder
            id = value
            Return Me
        End Function

        Public Function getNameBuyyer() As String
            Return nameBuyyer
        End Function
        Public Function setNameBuyyer(value As String) As Builder
            nameBuyyer = value
            Return Me
        End Function

        Public Function getIdComic() As Integer
            Return idComic
        End Function
        Public Function setIdComic(value As Integer) As Builder
            idComic = value
            Return Me
        End Function

        Public Function getQty() As Integer
            Return qty
        End Function
        Public Function setQty(value As Integer) As Builder
            qty = value
            Return Me
        End Function

        Public Function getTotal() As Integer
            Return total
        End Function
        Public Function setTotal(value As Integer) As Builder
            total = value
            Return Me
        End Function

        Public Function getDateTransaction() As String
            Return dateTransaction
        End Function
        Public Function setDateTransaction(value As String) As Builder
            dateTransaction = value
            Return Me
        End Function

        Public Function build() As Transaction
            Return New Transaction(Me)
        End Function
    End Class
End Class
