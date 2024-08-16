Public Class DatosProveedor
    Private Property _IdDatosProveedor As Integer
    Private Property _Descripcion As String
    Private Property _RegimenFiscal As String
    Private Property _FechaEntregaInmediata As String

    Public Sub New()
    End Sub

    Public Sub New(idDatosProveedor As Integer, descripcion As String, regimenFiscal As String, fechaEntregaInmediata As String)
        _IdDatosProveedor = idDatosProveedor
        _Descripcion = descripcion
        _RegimenFiscal = regimenFiscal
        _FechaEntregaInmediata = fechaEntregaInmediata
    End Sub

    Public Property IdDatosProveedor As Integer
        Get
            Return _IdDatosProveedor
        End Get
        Set(value As Integer)
            _IdDatosProveedor = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _Descripcion
        End Get
        Set(value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property RegimenFiscal As String
        Get
            Return _RegimenFiscal
        End Get
        Set(value As String)
            _RegimenFiscal = value
        End Set
    End Property

    Public Property FechaEntregaInmediata As String
        Get
            Return _FechaEntregaInmediata
        End Get
        Set(value As String)
            _FechaEntregaInmediata = value
        End Set
    End Property
End Class
