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

    Public Function GetContactosByIdUsuario(idUsuario As Integer)
        Try
            Dim contactos As New ArrayList()

            Dim sqlQuery As String = $"SELECT * FROM ViewContactos WHERE IdUsuario = {idUsuario};"

            Dim queryResults As SqlDataReader = DatabaseController.ExecuteQuery(sqlQuery)

            While queryResults.Read()
                Dim contacto As Contacto = LlenarContacto(queryResults)

                contactos.Add(contacto)
            End While

            Return contactos

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function LlenarContacto(queryResults As SqlDataReader)
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

End Class
