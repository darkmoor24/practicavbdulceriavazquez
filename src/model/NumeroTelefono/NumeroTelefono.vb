Public Class NumeroTelefono
    Private Property _IdNumeroTelefono As Integer
    Private Property _NumeroTelefono As String
    Private Property _Tipo As String

    Public Sub New()
    End Sub

    Public Sub New(idNumeroTelefono As Integer, numeroTelefono As String, tipo As String)
        _IdNumeroTelefono = idNumeroTelefono
        _NumeroTelefono = numeroTelefono
        _Tipo = tipo
    End Sub

    Public Property IdNumeroTelefono As Integer
        Get
            Return _IdNumeroTelefono
        End Get
        Set(value As Integer)
            _IdNumeroTelefono = value
        End Set
    End Property

    Public Property NumeroTelefono As String
        Get
            Return _NumeroTelefono
        End Get
        Set(value As String)
            _NumeroTelefono = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return _Tipo
        End Get
        Set(value As String)
            _Tipo = value
        End Set
    End Property
End Class
