Public Class Komik
    Public ReadOnly Property Id() As Integer
    Public ReadOnly Property Title() As String
    Public ReadOnly Property Genre() As String
    Public ReadOnly Property Author() As String
    Public ReadOnly Property Stock() As Integer
    Public ReadOnly Property Price() As Integer
    Public Sub New(builder As Builder)
        Id = builder.getId()
        Title = builder.getTitle()
        Genre = builder.getGenre()
        Author = builder.getAuthor()
        Stock = builder.getStock()
        Price = builder.getPrice()
    End Sub

    Class Builder
        Private id As Integer = 0
        Private title As String = "untitled"
        Private genre As String = "-"
        Private author As String = "-"
        Private stock As Integer = 0
        Private harga As Integer = 0

        Public Function getId() As Integer
            Return id
        End Function
        Public Function setId(value As Integer) As Builder
            id = value
            Return Me
        End Function

        Public Function getTitle() As String
            Return title
        End Function
        Public Function setTitle(value As String) As Builder
            title = value
            Return Me
        End Function

        Public Function getGenre() As String
            Return genre
        End Function
        Public Function setGenre(value As String) As Builder
            genre = value
            Return Me
        End Function

        Public Function getAuthor() As String
            Return author
        End Function
        Public Function setAuthor(value As String) As Builder
            author = value
            Return Me
        End Function

        Public Function getStock() As Integer
            Return stock
        End Function
        Public Function setStock(value As Integer) As Builder
            stock = value
            Return Me
        End Function

        Public Function getPrice() As Integer
            Return harga
        End Function
        Public Function setPrice(value As Integer) As Builder
            harga = value
            Return Me
        End Function

        Public Function build() As Komik
            Return New Komik(Me)
        End Function
    End Class
End Class
