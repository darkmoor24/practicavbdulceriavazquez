Public Class Correo
    Private Property _IdCorreo As Integer
    Private Property _Correo As Integer

    Public Property IdCorreo As Integer
        Get
            Return _IdCorreo
        End Get
        Set(value As Integer)
            _IdCorreo = value
        End Set
    End Property

    Public Property Correo As Integer
        Get
            Return _Correo
        End Get
        Set(value As Integer)
            _Correo = value
        End Set
    End Property
End Class
