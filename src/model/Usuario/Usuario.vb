Public Class Usuario
    Private Property _IdUsuario As Integer
    Private Property _NombreUsuario As String
    Private Property _Contrasenia As String

    Public Sub New()
    End Sub

    Public Sub New(idUsuario As Integer, nombreUsuario As String, contrasenia As String)
        _IdUsuario = idUsuario
        _NombreUsuario = nombreUsuario
        _Contrasenia = contrasenia
    End Sub

    Public Property IdUsuario As Integer
        Get
            Return _IdUsuario
        End Get
        Set(value As Integer)
            _IdUsuario = value
        End Set
    End Property

    Public Property NombreUsuario As String
        Get
            Return _NombreUsuario
        End Get
        Set(value As String)
            _NombreUsuario = value
        End Set
    End Property

    Public Property Contrasenia As String
        Get
            Return _Contrasenia
        End Get
        Set(value As String)
            _Contrasenia = value
        End Set
    End Property
End Class
