Public Class Contacto
    Private Property _IdContacto As Integer
    Private Property _NombreCompleto As String
    Private Property _Apellidos As String
    Private Property _Direccion As Direccion
    Private Property _Categoria As Categoria
    Private Property _FechaRegistro As DateTime
    Private Property _FechaModificacion As DateTime
    Private Property _UsuarioCreador As Usuario
    Private Property _ListaCorreos As ArrayList
    Private Property _ListaNumerosTelefono As ArrayList
    Private Property _DatosCliente As DatosCliente
    Private Property _DatosEmpleado As DatosEmpleado
    Private Property _DatosProveedor As DatosProveedor


    Public Sub New()
    End Sub

    Public Sub New(idContacto As Integer, nombreCompleto As String, apellidos As String, direccion As Direccion, categoria As Categoria, fechaRegistro As DateTime, fechaModificacion As DateTime, usuarioCreador As Usuario)
        _IdContacto = idContacto
        _NombreCompleto = nombreCompleto
        _Apellidos = apellidos
        _Direccion = direccion
        _Categoria = categoria
        _FechaRegistro = fechaRegistro
        _FechaModificacion = fechaModificacion
        _UsuarioCreador = usuarioCreador
    End Sub

    Public Sub New(idContacto As Integer, nombreCompleto As String, apellidos As String, direccion As Direccion, categoria As Categoria, fechaRegistro As DateTime, fechaModificacion As DateTime, usuarioCreador As Usuario, datosCliente As DatosCliente)
        _IdContacto = idContacto
        _NombreCompleto = nombreCompleto
        _Apellidos = apellidos
        _Direccion = direccion
        _Categoria = categoria
        _FechaRegistro = fechaRegistro
        _FechaModificacion = fechaModificacion
        _UsuarioCreador = usuarioCreador
        _DatosCliente = datosCliente
        _DatosEmpleado = New DatosEmpleado()
        _DatosProveedor = New DatosProveedor()
    End Sub

    Public Sub New(idContacto As Integer, nombreCompleto As String, apellidos As String, direccion As Direccion, categoria As Categoria, fechaRegistro As DateTime, fechaModificacion As DateTime, usuarioCreador As Usuario, datosEmpleado As DatosEmpleado)
        _IdContacto = idContacto
        _NombreCompleto = nombreCompleto
        _Apellidos = apellidos
        _Direccion = direccion
        _Categoria = categoria
        _FechaRegistro = fechaRegistro
        _FechaModificacion = fechaModificacion
        _UsuarioCreador = usuarioCreador
        _DatosEmpleado = datosEmpleado
        _DatosCliente = New DatosCliente()
        _DatosProveedor = New DatosProveedor()
    End Sub

    Public Sub New(idContacto As Integer, nombreCompleto As String, apellidos As String, direccion As Direccion, categoria As Categoria, fechaRegistro As DateTime, fechaModificacion As DateTime, usuarioCreador As Usuario, datosProveedor As DatosProveedor)
        _IdContacto = idContacto
        _NombreCompleto = nombreCompleto
        _Apellidos = apellidos
        _Direccion = direccion
        _Categoria = categoria
        _FechaRegistro = fechaRegistro
        _FechaModificacion = fechaModificacion
        _UsuarioCreador = usuarioCreador
        _DatosProveedor = datosProveedor
        _DatosCliente = New DatosCliente()
        _DatosProveedor = New DatosProveedor()
    End Sub


    Public Property IdContacto As Integer
        Get
            Return _IdContacto
        End Get
        Set(value As Integer)
            _IdContacto = value
        End Set
    End Property

    Public Property NombreCompleto As String
        Get
            Return _NombreCompleto
        End Get
        Set(value As String)
            _NombreCompleto = value
        End Set
    End Property

    Public Property Apellidos As String
        Get
            Return _Apellidos
        End Get
        Set(value As String)
            _Apellidos = value
        End Set
    End Property

    Public Property Direccion As Direccion
        Get
            Return _Direccion
        End Get
        Set(value As Direccion)
            _Direccion = value
        End Set
    End Property

    Public Property Categoria As Categoria
        Get
            Return _Categoria
        End Get
        Set(value As Categoria)
            _Categoria = value
        End Set
    End Property

    Public Property FechaRegistro As DateTime
        Get
            Return _FechaRegistro
        End Get
        Set(value As DateTime)
            _FechaRegistro = value
        End Set
    End Property

    Public Property FechaModificacion As DateTime
        Get
            Return _FechaModificacion
        End Get
        Set(value As DateTime)
            _FechaModificacion = value
        End Set
    End Property

    Public Property UsuarioCreador As Usuario
        Get
            Return _UsuarioCreador
        End Get
        Set(value As Usuario)
            _UsuarioCreador = value
        End Set
    End Property

    Public Property ListaCorreos As ArrayList
        Get
            Return _ListaCorreos
        End Get
        Set(value As ArrayList)
            _ListaCorreos = value
        End Set
    End Property

    Public Property ListaNumerosTelefono As ArrayList
        Get
            Return _ListaNumerosTelefono
        End Get
        Set(value As ArrayList)
            _ListaNumerosTelefono = value
        End Set
    End Property

    Public Property DatosCliente As DatosCliente
        Get
            Return _DatosCliente
        End Get
        Set(value As DatosCliente)
            _DatosCliente = value
        End Set
    End Property

    Public Property DatosEmpleado As DatosEmpleado
        Get
            Return _DatosEmpleado
        End Get
        Set(value As DatosEmpleado)
            _DatosEmpleado = value
        End Set
    End Property

    Public Property DatosProveedor As DatosProveedor
        Get
            Return _DatosProveedor
        End Get
        Set(value As DatosProveedor)
            _DatosProveedor = value
        End Set
    End Property
End Class
