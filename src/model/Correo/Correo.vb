Public Class Correo
    Private Property _IdCorreo As Integer
    Private Property _Correo As String

    Public Sub New()

    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        If TypeOf obj Is Correo Then
            Dim other As Correo = CType(obj, Correo)
            Return Me.Correo = other.Correo
        End If
        Return False
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return Correo.GetHashCode()
    End Function

    Public Sub New(idCorreo As Integer, correo As String)
        _IdCorreo = idCorreo
        _Correo = correo
    End Sub

    Public Property IdCorreo As Integer
        Get
            Return _IdCorreo
        End Get
        Set(value As Integer)
            _IdCorreo = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _Correo
        End Get
        Set(value As String)
            _Correo = value
        End Set
    End Property
End Class
