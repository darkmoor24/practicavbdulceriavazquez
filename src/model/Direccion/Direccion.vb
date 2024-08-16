Public Class Direccion
    Private Property _IdDireccion As Integer
    Private Property _Calle As String
    Private Property _NumeroInterior As String
    Private Property _NumeroExterior As String
    Private Property _Colonia As String
    Private Property _Localidad As String
    Private Property _Municipio As String
    Private Property _Estado As String
    Private Property _CodigoPostal As String
    Private Property _Tipo As String

    Public Sub New()
    End Sub

    Public Sub New(idDireccion As Integer, calle As String, numeroInterior As String, numeroExterior As String, colonia As String, localidad As String, municipio As String, estado As String, codigoPostal As String, tipo As String)
        _IdDireccion = idDireccion
        _Calle = calle
        _NumeroInterior = numeroInterior
        _NumeroExterior = numeroExterior
        _Colonia = colonia
        _Localidad = localidad
        _Municipio = municipio
        _Estado = estado
        _CodigoPostal = codigoPostal
        _Tipo = tipo
    End Sub

    Public Property IdDireccion As Integer
        Get
            Return _IdDireccion
        End Get
        Set(value As Integer)
            _IdDireccion = value
        End Set
    End Property

    Public Property Calle As String
        Get
            Return _Calle
        End Get
        Set(value As String)
            _Calle = value
        End Set
    End Property

    Public Property NumeroInterior As String
        Get
            Return _NumeroInterior
        End Get
        Set(value As String)
            _NumeroInterior = value
        End Set
    End Property

    Public Property NumeroExterior As String
        Get
            Return _NumeroExterior
        End Get
        Set(value As String)
            _NumeroExterior = value
        End Set
    End Property

    Public Property Colonia As String
        Get
            Return _Colonia
        End Get
        Set(value As String)
            _Colonia = value
        End Set
    End Property

    Public Property Localidad As String
        Get
            Return _Localidad
        End Get
        Set(value As String)
            _Localidad = value
        End Set
    End Property

    Public Property Municipio As String
        Get
            Return _Municipio
        End Get
        Set(value As String)
            _Municipio = value
        End Set
    End Property

    Public Property Estado As String
        Get
            Return _Estado
        End Get
        Set(value As String)
            _Estado = value
        End Set
    End Property

    Public Property CodigoPostal As String
        Get
            Return _CodigoPostal
        End Get
        Set(value As String)
            _CodigoPostal = value
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
