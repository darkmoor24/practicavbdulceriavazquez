Public Class DatosCliente
    Private Property _IdDatosCliente As Integer
    Private Property _MontoCredito As Decimal
    Private Property _DiasCredito As Integer
    Private Property _RegimenFiscal As String

    Public Sub New()
    End Sub

    Public Sub New(idDatosCliente As Integer, montoCredito As Decimal, diasCredito As Integer, regimenFiscal As String)
        _IdDatosCliente = idDatosCliente
        _MontoCredito = montoCredito
        _DiasCredito = diasCredito
        _RegimenFiscal = regimenFiscal
    End Sub

    Public Property IdDatosCliente As Integer
        Get
            Return _IdDatosCliente
        End Get
        Set(value As Integer)
            _IdDatosCliente = value
        End Set
    End Property

    Public Property MontoCredito As Decimal
        Get
            Return _MontoCredito
        End Get
        Set(value As Decimal)
            _MontoCredito = value
        End Set
    End Property

    Public Property DiasCredito As Integer
        Get
            Return _DiasCredito
        End Get
        Set(value As Integer)
            _DiasCredito = value
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
End Class
