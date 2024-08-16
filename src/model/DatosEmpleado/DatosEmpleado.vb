Public Class DatosEmpleado
    Private Property _IdDatosEmpleado As Integer
    Private Property _Curp As String
    Private Property _Puesto As String
    Private Property _Sueldo As Decimal

    Public Sub New()
    End Sub

    Public Sub New(idDatosEmpleado As Integer, curp As String, puesto As String, sueldo As Decimal)
        _IdDatosEmpleado = idDatosEmpleado
        _Curp = curp
        _Puesto = puesto
        _Sueldo = sueldo
    End Sub

    Public Property IdDatosEmpleado As Integer
        Get
            Return _IdDatosEmpleado
        End Get
        Set(value As Integer)
            _IdDatosEmpleado = value
        End Set
    End Property

    Public Property Curp As String
        Get
            Return _Curp
        End Get
        Set(value As String)
            _Curp = value
        End Set
    End Property

    Public Property Puesto As String
        Get
            Return _Puesto
        End Get
        Set(value As String)
            _Puesto = value
        End Set
    End Property

    Public Property Sueldo As Decimal
        Get
            Return _Sueldo
        End Get
        Set(value As Decimal)
            _Sueldo = value
        End Set
    End Property
End Class
