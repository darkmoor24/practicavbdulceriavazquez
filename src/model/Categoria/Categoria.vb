Public Class Categoria
    Private Property _IdCategoria As Integer
    Private Property _Nombre As String

    Public Sub New()

    End Sub

    Public Sub New(idCategoria As Integer, nombreCategoria As String)
        _IdCategoria = idCategoria
        _Nombre = nombreCategoria
    End Sub

    Public Property IdCategoria As Integer
        Get
            Return _IdCategoria
        End Get
        Set(value As Integer)
            _IdCategoria = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre

        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

End Class
