Imports System.Data.SqlClient

Public Class ContactoController

    Private Property DatabaseController As DatabaseController
    Private Property DireccionController As DireccionController
    Private Property CorreoController As CorreoController
    Private Property NumeroTelefonoController As NumeroTelefonoController

    Public Sub New()
        DatabaseController = New DatabaseController()

        DireccionController = New DireccionController()

        CorreoController = New CorreoController()

        NumeroTelefonoController = New NumeroTelefonoController()
    End Sub

    Public Function AddNuevoContacto(contacto As Contacto) As Boolean
        Dim contactoRegistrado As Boolean = False

        Try
            Dim spParameters As Dictionary(Of String, SqlParameter) = LlenarDiccionarioParametrosInsertarContacto(contacto)

            Dim resultado As SqlDataReader = DatabaseController.ExecuteStoredProcedure("SpInsertarContacto", spParameters)


        Catch ex As Exception
            Console.WriteLine(ex.Message)

            contactoRegistrado = False
        End Try

        Return contactoRegistrado

    End Function

    Public Function GetContactosByIdUsuario(idUsuario As Integer)
        Try
            Dim contactos As New ArrayList()

            Dim sqlQuery As String = $"SELECT * FROM ViewContactos WHERE IdUsuario = {idUsuario};"

            Dim queryResults As SqlDataReader = DatabaseController.ExecuteQuery(sqlQuery)

            If queryResults Is Nothing Then
                DatabaseController.CloseConnection()

                Return contactos

                Exit Function
            End If

            While queryResults.Read()
                Dim contacto As Contacto = LlenarContacto(queryResults)

                contactos.Add(contacto)
            End While

            DatabaseController.CloseConnection()

            Return contactos

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function DeleteContactoById(idContacto As Integer) As Boolean
        Try
            Dim contactoEliminado As Boolean = False

            Dim spParameters As New Dictionary(Of String, SqlParameter) From {
                {"@IdContacto", New SqlParameter("@IdContacto", SqlDbType.Int) With {.Value = idContacto}}
            }

            DatabaseController.ExecuteStoredProcedure("SpEliminarContacto", spParameters)

            contactoEliminado = True

            DatabaseController.CloseConnection()

            Return contactoEliminado
        Catch ex As Exception
            Console.WriteLine(ex.Message)

            Return Nothing
        End Try
    End Function

    Private Function LlenarContacto(queryResults As SqlDataReader)
        Dim contacto As New Contacto()

        'Datos de contacto
        Dim idContacto As Integer = queryResults("IdContacto")

        Dim idDireccion As Integer = queryResults("IdDireccion")

        Dim idCategoria As Integer = queryResults("IdCategoria")

        Dim nombreCategoria As String = queryResults("NombreCategoria")

        Dim nombreCompleto As String = queryResults("NombreCompleto")

        Dim apellidos As String = queryResults("Apellidos")

        Dim fechaRegistro As DateTime = queryResults("FechaRegistro")

        Dim fechaModificacion As DateTime = queryResults("FechaModificacion")

        'Llenado de Objetos Inherentes
        Dim direccion As Direccion = DireccionController.GetDireccionContacto(idDireccion)

        Dim categoria As New Categoria(idCategoria, nombreCategoria)

        Dim usuarioCreador As Usuario = DatosGlobales.UsuarioIngresado

        'Llenado de arreglos de correos y números de teléfono
        Dim listaCorreos As ArrayList = CorreoController.GetCorreosContacto(idContacto)

        Dim listaNumerosTelefono As ArrayList = NumeroTelefonoController.GetNumerosTelefonoContacto(idContacto)

        'Llenado de objetos opcionales
        Select Case categoria.Nombre
            Case "Empleado"
                Dim idDatosEmpleado As Integer = queryResults("IdDatosEmpleado")

                Dim curp As String = queryResults("Curp")

                Dim puesto As String = queryResults("Puesto")

                Dim sueldo As Decimal = queryResults("Sueldo")

                Dim datosEmpleado As New DatosEmpleado(idDatosEmpleado, curp, puesto, sueldo)

                contacto = New Contacto(idContacto, nombreCompleto, apellidos, direccion, categoria, fechaRegistro, fechaModificacion, usuarioCreador, datosEmpleado, listaNumerosTelefono, listaCorreos)

            Case "Cliente"
                Dim idDatosCliente As Integer = queryResults("IdDatosCliente")

                Dim montoCredito As Decimal = queryResults("MontoCredito")

                Dim diasCredito As Integer = queryResults("DiasCredito")

                Dim regimenFiscal As String = queryResults("RegimenFiscalCliente")

                Dim datosCliente As New DatosCliente(idDatosCliente, montoCredito, diasCredito, regimenFiscal)

                contacto = New Contacto(idContacto, nombreCompleto, apellidos, direccion, categoria, fechaRegistro, fechaModificacion, usuarioCreador, datosCliente, listaNumerosTelefono, listaCorreos)

            Case "Proveedor"
                Dim idDatosProveedor As Integer = queryResults("IdDatosProveedor")

                Dim descripcion As String = queryResults("Descripcion")

                Dim fechaEntregaMercancia As String = queryResults("FechaEntregaMercancia")

                Dim regimenFiscal As String = queryResults("RegimenFiscalProveedor")

                Dim datosProveedor As New DatosProveedor(idDatosProveedor, descripcion, regimenFiscal, fechaEntregaMercancia)

                contacto = New Contacto(idContacto, nombreCompleto, apellidos, direccion, categoria, fechaRegistro, fechaModificacion, usuarioCreador, datosProveedor, listaNumerosTelefono, listaCorreos)

        End Select

        Return contacto
    End Function


    Private Function LlenarDiccionarioParametrosInsertarContacto(contacto As Contacto) As Dictionary(Of String, SqlParameter)
        Dim spParameters As New Dictionary(Of String, SqlParameter) From {
                {"@Calle", New SqlParameter("@Calle", SqlDbType.NVarChar) With {.Value = contacto.Direccion.Calle}},
                {"@NumeroExterior", New SqlParameter("@NumeroExterior", SqlDbType.NVarChar) With {.Value = contacto.Direccion.NumeroExterior}},
                {"@NumeroInterior", New SqlParameter("@NumeroInterior", SqlDbType.NVarChar) With {.Value = contacto.Direccion.NumeroInterior}},
                {"@Colonia", New SqlParameter("@Colonia", SqlDbType.NVarChar) With {.Value = contacto.Direccion.Colonia}},
                {"@Localidad", New SqlParameter("@Localidad", SqlDbType.NVarChar) With {.Value = contacto.Direccion.Localidad}},
                {"@Municipio", New SqlParameter("@Municipio", SqlDbType.NVarChar) With {.Value = contacto.Direccion.Municipio}},
                {"@Estado", New SqlParameter("@Estado", SqlDbType.NVarChar) With {.Value = contacto.Direccion.Estado}},
                {"@CodigoPostal", New SqlParameter("@CodigoPostal", SqlDbType.NVarChar) With {.Value = contacto.Direccion.CodigoPostal}},
                {"@TipoDireccion", New SqlParameter("@TipoDireccion", SqlDbType.NVarChar) With {.Value = contacto.Direccion.Tipo}},
                {"@NombreCompleto", New SqlParameter("@NombreCompleto", SqlDbType.NVarChar) With {.Value = contacto.NombreCompleto}},
                {"@Apellidos", New SqlParameter("@Apellidos", SqlDbType.NVarChar) With {.Value = contacto.Apellidos}},
                {"@IdCategoria", New SqlParameter("@IdCategoria", SqlDbType.NVarChar) With {.Value = contacto.Categoria.IdCategoria}},
                {"@IdUsuarioCreador", New SqlParameter("@IdUsuarioCreador", SqlDbType.NVarChar) With {.Value = DatosGlobales.UsuarioIngresado.IdUsuario}}
            }

        If Not String.IsNullOrEmpty(contacto.DatosEmpleado.Curp) Then
            spParameters.Add("@Curp", New SqlParameter("@Curp", SqlDbType.NVarChar) With {.Value = contacto.DatosEmpleado.Curp})
        End If

        If Not String.IsNullOrEmpty(contacto.DatosEmpleado.Puesto) Then
            spParameters.Add("@Puesto", New SqlParameter("@Puesto", SqlDbType.NVarChar) With {.Value = contacto.DatosEmpleado.Puesto})
        End If

        If contacto.DatosEmpleado.Sueldo <> 0 Then
            spParameters.Add("@Sueldo", New SqlParameter("@Sueldo", SqlDbType.Decimal) With {.Value = contacto.DatosEmpleado.Sueldo})
        End If

        ' Parámetros opcionales de DatosCliente
        If contacto.DatosCliente.MontoCredito <> 0 Then
            spParameters.Add("@MontoCredito", New SqlParameter("@MontoCredito", SqlDbType.Decimal) With {.Value = contacto.DatosCliente.MontoCredito})
        End If

        If contacto.DatosCliente.DiasCredito <> 0 Then
            spParameters.Add("@DiasCredito", New SqlParameter("@DiasCredito", SqlDbType.Int) With {.Value = contacto.DatosCliente.DiasCredito})
        End If

        If Not String.IsNullOrEmpty(contacto.DatosCliente.RegimenFiscal) Then
            spParameters.Add("@RegimenFiscalCliente", New SqlParameter("@RegimenFiscalCliente", SqlDbType.NVarChar) With {.Value = contacto.DatosCliente.RegimenFiscal})
        End If

        ' Parámetros opcionales de DatosProveedor
        If Not String.IsNullOrEmpty(contacto.DatosProveedor.Descripcion) Then
            spParameters.Add("@Descripcion", New SqlParameter("@Descripcion", SqlDbType.NVarChar) With {.Value = contacto.DatosProveedor.Descripcion})
        End If

        If Not String.IsNullOrEmpty(contacto.DatosProveedor.RegimenFiscal) Then
            spParameters.Add("@RegimenFiscalProveedor", New SqlParameter("@RegimenFiscalProveedor", SqlDbType.NVarChar) With {.Value = contacto.DatosProveedor.RegimenFiscal})
        End If

        If Not String.IsNullOrEmpty(contacto.DatosProveedor.FechaEntregaMercancia) Then
            spParameters.Add("@FechaEntregaMercancia", New SqlParameter("@FechaEntregaMercancia", SqlDbType.NVarChar) With {.Value = contacto.DatosProveedor.FechaEntregaMercancia})
        End If

        ' Parámetro de salida
        spParameters.Add("@IdContacto", New SqlParameter("@IdContacto", SqlDbType.Int) With {.Direction = ParameterDirection.Output})

        Return spParameters
    End Function
End Class
