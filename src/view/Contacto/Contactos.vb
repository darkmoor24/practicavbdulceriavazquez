﻿Imports System.Runtime.Remoting.Proxies
Imports System.Text.RegularExpressions

Public Class Contactos

    Private Property CategoriaController As CategoriaController
    Private Property ContactoController As ContactoController
    Private Property contactos As ArrayList
    Private Property categoriasContacto As ArrayList
    Private Property tiposTelefono As ArrayList
    Private Property nuevosNumerosTelefonoContacto As New ArrayList()
    Private Property nuevosCorreosContacto As New ArrayList()
    Private Property editandoContacto As Boolean = False
    Private Property editandoNumeroTelefonoContacto As Boolean = False
    Private Property editandoCorreoContacto As Boolean = False
    Private Property idContactoEnEdicion As Integer
    Private Property numeroTelefonoEnEdicion As NumeroTelefono
    Private Property correoEnEdicion As Correo

    Private Sub Contactos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitControllers()

        InitFormulario()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dim ViewLogin As New Login()

        DatosGlobales.UsuarioIngresado = Nothing

        ViewLogin.Show()

        Close()
    End Sub

    Private Sub BtnAgregarNumeroTelefono_Click(sender As Object, e As EventArgs) Handles BtnAgregarNumeroTelefono.Click
        If Not editandoContacto Then
            MessageBox.Show("Para agregar un número de teléfono primero debes agregar un nuevo contacto.")

            Exit Sub
        End If

        If TxtNumeroTelefono.Text = "" Then
            MessageBox.Show("No se puede agregar un número de teléfono en blanco.")

            Exit Sub
        End If

        If TxtNumeroTelefono.Text.Length < 10 Then
            MessageBox.Show("Ingresa un número de teléfono de 10 dígitos.")

            Exit Sub
        End If

        If CboTipoTelefono.SelectedIndex = -1 Then
            MessageBox.Show("Selecciona un tipo de número de teléfono.")

            Exit Sub
        End If

        Dim nuevoNumeroTelefono As New NumeroTelefono(0, TxtNumeroTelefono.Text, CboTipoTelefono.SelectedItem)

        If nuevosNumerosTelefonoContacto.Contains(nuevoNumeroTelefono) Then
            MessageBox.Show("El número de teléfono ya existe, ingresa uno distinto.")

            Exit Sub
        End If

        Dim lastItemInArrayNumerosTelefono As NumeroTelefono = nuevosNumerosTelefonoContacto(nuevosNumerosTelefonoContacto.Count - 1)

        nuevoNumeroTelefono.IdNumeroTelefono = lastItemInArrayNumerosTelefono.IdNumeroTelefono + 1

        nuevosNumerosTelefonoContacto.Add(nuevoNumeroTelefono)

        ActualizarDataTableNumerosTelefono()

        TxtNumeroTelefono.Text = ""

        CboTipoTelefono.SelectedIndex = -1

        If editandoNumeroTelefonoContacto Then
            editandoNumeroTelefonoContacto = False
        End If
    End Sub

    Private Sub BtnEliminarNumeroTelefono_Click(sender As Object, e As EventArgs) Handles BtnEliminarNumeroTelefono.Click

        If Not editandoContacto Then
            MessageBox.Show("Para eliminar un número de teléfono primero debes elegir un contacto.")

            Exit Sub
        End If

        If Not editandoNumeroTelefonoContacto Then
            MessageBox.Show("Para eliminar un número de teléfono primero debes elegir uno de la lista.")

            Exit Sub

        End If

        Dim mensaje As String = "¿Estás seguro de que deseas eliminar este número de teléfono?"

        Dim resultado As DialogResult = MessageBox.Show(mensaje, "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            nuevosNumerosTelefonoContacto.Remove(numeroTelefonoEnEdicion)

            ActualizarDataTableNumerosTelefono()

            numeroTelefonoEnEdicion = Nothing

            editandoNumeroTelefonoContacto = False
        Else
            MessageBox.Show("No se eliminó el número de teléfono.")
        End If

    End Sub

    Private Sub BtnModificarNumeroTelefono_Click(sender As Object, e As EventArgs) Handles BtnModificarNumeroTelefono.Click
        If Not editandoContacto Then
            MessageBox.Show("Para modificar un número de teléfono primero debes elegir un contacto.")

            Exit Sub
        End If

        If Not editandoNumeroTelefonoContacto Then
            MessageBox.Show("Para modificar un número de teléfono primero debes elegir uno de la lista.")

            Exit Sub

        End If

        If TxtNumeroTelefono.Text = "" Then
            MessageBox.Show("No se puede agregar un número de teléfono en blanco.")

            Exit Sub
        End If

        If TxtNumeroTelefono.Text.Length < 10 Then
            MessageBox.Show("Ingresa un número de teléfono de 10 dígitos.")

            Exit Sub
        End If

        If CboTipoTelefono.SelectedIndex = -1 Then
            MessageBox.Show("Selecciona un tipo de número de teléfono.")

            Exit Sub
        End If

        For Each numero As NumeroTelefono In nuevosNumerosTelefonoContacto
            If numero.Equals(numeroTelefonoEnEdicion) Then
                numero.NumeroTelefono = TxtNumeroTelefono.Text

                numero.Tipo = CboTipoTelefono.SelectedItem.ToString()
            End If
        Next

        ActualizarDataTableNumerosTelefono()

        MessageBox.Show("Número de teléfono modificado exitosamente.")
    End Sub

    Private Sub BtnAgregarCorreo_Click(sender As Object, e As EventArgs) Handles BtnAgregarCorreo.Click
        If Not editandoContacto Then
            MessageBox.Show("Para agregar un correo primero debes elegir un contacto.")

            Exit Sub
        End If

        If TxtCorreo.Text = "" Then
            MessageBox.Show("Ingresa un correo electrónico.")

            Exit Sub
        End If

        If Not EsCorreoValido(TxtCorreo.Text) Then
            MessageBox.Show("Ingresa un correo electrónico válido.")

            Exit Sub
        End If

        Dim nuevoCorreo As New Correo(0, TxtCorreo.Text)

        If nuevosCorreosContacto.Contains(nuevoCorreo) Then
            MessageBox.Show("El correo ya existe, ingresa uno distinto.")

            Exit Sub
        End If

        Dim lastItemInArrayCorreos As Correo = nuevosCorreosContacto(nuevosCorreosContacto.Count - 1)

        nuevoCorreo.IdCorreo = lastItemInArrayCorreos.IdCorreo + 1

        nuevosCorreosContacto.Add(nuevoCorreo)

        ActualizarDataTableCorreos()

        TxtCorreo.Text = ""

        If editandoCorreoContacto Then
            editandoCorreoContacto = False
        End If
    End Sub

    Private Sub BtnEliminarCorreo_Click(sender As Object, e As EventArgs) Handles BtnEliminarCorreo.Click
        If Not editandoContacto Then
            MessageBox.Show("Para eliminar un correo primero debes elegir un contacto.")

            Exit Sub
        End If

        If Not editandoCorreoContacto Then
            MessageBox.Show("Para eliminar un correo primero debes elegir uno de la lista.")

            Exit Sub

        End If

        Dim mensaje As String = "¿Estás seguro de que deseas eliminar este correo?"

        Dim resultado As DialogResult = MessageBox.Show(mensaje, "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            nuevosCorreosContacto.Remove(correoEnEdicion)

            ActualizarDataTableCorreos()

            correoEnEdicion = Nothing

            editandoCorreoContacto = False
        Else
            MessageBox.Show("No se eliminó el correo.")
        End If
    End Sub

    Private Sub BtnModificarCorreo_Click(sender As Object, e As EventArgs) Handles BtnModificarCorreo.Click
        If Not editandoContacto Then
            MessageBox.Show("Para modificar un número de teléfono primero debes elegir un contacto.")

            Exit Sub
        End If

        If Not editandoCorreoContacto Then
            MessageBox.Show("Para modificar un número de teléfono primero debes elegir uno de la lista.")

            Exit Sub

        End If

        If TxtCorreo.Text = "" Then
            MessageBox.Show("Ingresa un correo electrónico.")

            Exit Sub
        End If

        If Not EsCorreoValido(TxtCorreo.Text) Then
            MessageBox.Show("Ingresa un correo electrónico válido.")

            Exit Sub
        End If

        For Each correo As Correo In nuevosCorreosContacto
            If correo.Equals(correoEnEdicion) Then
                correo.Correo = TxtCorreo.Text
            End If
        Next

            ActualizarDataTableCorreos()

            MessageBox.Show("Correo modificado exitosamente.")
    End Sub

    Private Sub BtnAgregarContacto_Click(sender As Object, e As EventArgs) Handles BtnAgregarContacto.Click
        If editandoContacto Then
            MessageBox.Show("No se puede agregar mientras se está editando un producto existente")

            Exit Sub
        End If

        Dim camposVacios As Boolean = ValidarCamposVacios()

        If camposVacios Then
            MessageBox.Show("Por favor, llena todos los campos.")

            Exit Sub
        End If

        Dim nuevoContacto As Contacto = LlenarNuevoContacto()

        Dim contactoRegistrado As Boolean = ContactoController.AddNuevoContacto(nuevoContacto)

        Console.WriteLine(contactoRegistrado)

    End Sub

    Private Sub BtnModificarContacto_Click(sender As Object, e As EventArgs) Handles BtnModificarContacto.Click
        If Not editandoContacto Then
            MessageBox.Show("No se puede modificar si no has seleccionado un contacto")

            Exit Sub
        End If

        If editandoNumeroTelefonoContacto OrElse editandoCorreoContacto Then
            MessageBox.Show("No se puede modificar el contacto si estás editando un número de teléfono o correo electrónico")

            Exit Sub
        End If

    End Sub

    Private Sub BtnEliminarContacto_Click(sender As Object, e As EventArgs) Handles BtnEliminarContacto.Click
        If Not editandoContacto Then
            MessageBox.Show("No se puede eliminar si no has seleccionado un contacto")

            Exit Sub
        End If

        If editandoNumeroTelefonoContacto OrElse editandoCorreoContacto Then
            MessageBox.Show("No se puede modificar el contacto si estás editando un número de teléfono o correo electrónico")

            Exit Sub
        End If

        Dim mensaje As String = "¿Estás seguro de que deseas eliminar este contacto?" & vbCrLf & vbCrLf &
                        "Al continuar los datos se eliminaran de forma permanente"

        Dim resultado As DialogResult = MessageBox.Show(mensaje, "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then

            Dim eliminado As Boolean = ContactoController.DeleteContactoById(idContactoEnEdicion)

            If eliminado Then
                MessageBox.Show("Contacto eliminado con éxito")

                RefetchContactos()

                LimpiarCampos()
            Else
                MessageBox.Show("No se eliminó el contacto")
            End If
        End If

    End Sub

    Private Sub BtnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles BtnLimpiarCampos.Click
        LimpiarCampos()
    End Sub

    Private Sub CboCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCategoria.SelectedIndexChanged
        Select Case CboCategoria.SelectedItem
            Case "Empleado"
                'Habilitar
                TxtCurp.Enabled = True
                TxtPuesto.Enabled = True
                TxtSueldo.Enabled = True

                'Deshabilitar
                TxtMontoCredito.Enabled = False
                TxtMontoCredito.Text = ""

                TxtDiasCredito.Enabled = False
                TxtDiasCredito.Text = ""

                TxtRegimenFiscalCliente.Enabled = False
                TxtRegimenFiscalCliente.Text = ""

                TxtDescripcion.Enabled = False
                TxtDescripcion.Text = ""

                TxtFechaEntregaMercancia.Enabled = False
                TxtFechaEntregaMercancia.Text = ""

                TxtRegimenFiscalProveedor.Enabled = False
                TxtRegimenFiscalProveedor.Text = ""

            Case "Cliente"
                'Habilitar
                TxtMontoCredito.Enabled = True
                TxtDiasCredito.Enabled = True
                TxtRegimenFiscalCliente.Enabled = True

                'Deshabilitar
                TxtCurp.Enabled = False
                TxtCurp.Text = ""
                TxtPuesto.Enabled = False
                TxtPuesto.Text = ""

                TxtSueldo.Enabled = False
                TxtSueldo.Text = ""

                TxtDescripcion.Enabled = False
                TxtDescripcion.Text = ""

                TxtFechaEntregaMercancia.Enabled = False
                TxtFechaEntregaMercancia.Text = ""

                TxtRegimenFiscalProveedor.Enabled = False
                TxtRegimenFiscalProveedor.Text = ""

            Case "Proveedor"
                'Habilitar
                TxtDescripcion.Enabled = True
                TxtRegimenFiscalProveedor.Enabled = True
                TxtFechaEntregaMercancia.Enabled = True

                'Deshabilitar
                TxtCurp.Enabled = False
                TxtCurp.Text = ""

                TxtPuesto.Enabled = False
                TxtPuesto.Text = ""

                TxtSueldo.Enabled = False
                TxtSueldo.Text = ""

                TxtMontoCredito.Enabled = False
                TxtMontoCredito.Text = ""

                TxtDiasCredito.Enabled = False
                TxtDiasCredito.Text = ""

                TxtRegimenFiscalCliente.Enabled = False
                TxtRegimenFiscalCliente.Text = ""
        End Select
    End Sub

    Private Sub DTContactos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTContactos.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = -1 Then

            Dim fila As DataGridViewRow = DTContactos.Rows(e.RowIndex)

            If fila.Cells("IdContacto").Value Is Nothing Then
                MessageBox.Show("No hay datos para mostrar en esta fila")

                Exit Sub
            End If

            editandoContacto = True

            Dim idContacto As Integer = fila.Cells("IdContacto").Value.ToString()

            idContactoEnEdicion = idContacto

            'Domicilio
            TxtCalle.Text = fila.Cells("Calle").Value.ToString()
            TxtNumeroExterior.Text = fila.Cells("NumeroExterior").Value.ToString()
            TxtNumeroInterior.Text = fila.Cells("NumeroInterior").Value.ToString()
            TxtColonia.Text = fila.Cells("Colonia").Value.ToString()
            TxtCodigoPostal.Text = fila.Cells("CodigoPostal").Value.ToString()
            TxtLocalidad.Text = fila.Cells("Localidad").Value.ToString()
            TxtMunicipio.Text = fila.Cells("Municipio").Value.ToString()
            TxtEstado.Text = fila.Cells("Estado").Value.ToString()

            Dim tipoDireccion As String = fila.Cells("TipoDireccion").Value.ToString()

            If tipoDireccion = "Fiscal" Then
                RBtnDireccionFiscal.Checked = True
            ElseIf tipoDireccion = "Real" Then
                RBtnDireccionReal.Checked = True
            End If

            'Personales
            TxtNombreCompleto.Text = fila.Cells("NombreCompleto").Value.ToString()
            TxtApellidos.Text = fila.Cells("Apellidos").Value.ToString()

            Dim contactoElegido As Contacto = GetContactoElegido(idContacto)

            nuevosNumerosTelefonoContacto = contactoElegido.ListaNumerosTelefono

            nuevosCorreosContacto = contactoElegido.ListaCorreos

            ActualizarDataTableNumerosTelefono()

            ActualizarDataTableCorreos()

            'Categoria
            Dim categoriaContactoElegido As String = fila.Cells("NombreCategoria").Value.ToString()

            CboCategoria.SelectedItem = categoriaContactoElegido

            Select Case categoriaContactoElegido
                Case "Empleado"
                    'Habilitar
                    TxtCurp.Enabled = True
                    TxtCurp.Text = fila.Cells("Curp").Value.ToString()

                    TxtPuesto.Enabled = True
                    TxtPuesto.Text = fila.Cells("Puesto").Value.ToString()

                    TxtSueldo.Enabled = True
                    TxtSueldo.Text = fila.Cells("Sueldo").Value.ToString()

                    'Deshabilitar
                    TxtMontoCredito.Enabled = False
                    TxtMontoCredito.Text = ""

                    TxtDiasCredito.Enabled = False
                    TxtDiasCredito.Text = ""

                    TxtRegimenFiscalCliente.Enabled = False
                    TxtRegimenFiscalCliente.Text = ""

                    TxtDescripcion.Enabled = False
                    TxtDescripcion.Text = ""

                    TxtFechaEntregaMercancia.Enabled = False
                    TxtFechaEntregaMercancia.Text = ""

                    TxtRegimenFiscalProveedor.Enabled = False
                    TxtRegimenFiscalProveedor.Text = ""

                Case "Cliente"
                    'Habilitar
                    TxtMontoCredito.Enabled = True
                    TxtMontoCredito.Text = fila.Cells("MontoCredito").Value.ToString()

                    TxtDiasCredito.Enabled = True
                    TxtDiasCredito.Text = fila.Cells("DiasCredito").Value.ToString()

                    TxtRegimenFiscalCliente.Enabled = True
                    TxtRegimenFiscalCliente.Text = fila.Cells("RegimenFiscalCliente").Value.ToString()

                    'Deshabilitar
                    TxtCurp.Enabled = False
                    TxtCurp.Text = ""

                    TxtPuesto.Enabled = False
                    TxtPuesto.Text = ""

                    TxtSueldo.Enabled = False
                    TxtSueldo.Text = ""

                    TxtDescripcion.Enabled = False
                    TxtDescripcion.Text = ""

                    TxtFechaEntregaMercancia.Enabled = False
                    TxtFechaEntregaMercancia.Text = ""

                    TxtRegimenFiscalProveedor.Enabled = False
                    TxtRegimenFiscalProveedor.Text = ""

                Case "Proveedor"
                    'Habilitar
                    TxtDescripcion.Enabled = True
                    TxtDescripcion.Text = fila.Cells("Descripcion").Value.ToString()

                    TxtRegimenFiscalProveedor.Enabled = True
                    TxtRegimenFiscalProveedor.Text = fila.Cells("RegimenFiscalProveedor").Value.ToString()

                    TxtFechaEntregaMercancia.Enabled = True
                    TxtFechaEntregaMercancia.Text = fila.Cells("FechaEntregaMercancia").Value.ToString()

                    'Deshabilitar
                    TxtCurp.Enabled = False
                    TxtCurp.Text = ""

                    TxtPuesto.Enabled = False
                    TxtPuesto.Text = ""

                    TxtSueldo.Enabled = False
                    TxtSueldo.Text = ""

                    TxtMontoCredito.Enabled = False
                    TxtMontoCredito.Text = ""

                    TxtDiasCredito.Enabled = False
                    TxtDiasCredito.Text = ""

                    TxtRegimenFiscalCliente.Enabled = False
                    TxtRegimenFiscalCliente.Text = ""

            End Select


        End If
    End Sub

    Private Sub DTContactos_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DTContactos.CellMouseEnter
        ' Verifica si el mouse está sobre la última columna
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = -1 Then
            DTContactos.Cursor = Cursors.Hand ' Cambia el cursor a mano
        End If
    End Sub

    Private Sub DTContactos_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DTContactos.CellMouseLeave
        ' Verifica si el mouse sale de la última columna
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = -1 Then
            DTContactos.Cursor = Cursors.Default ' Restaura el cursor por defecto
        End If
    End Sub

    Private Sub DTNumerosTelefono_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTNumerosTelefono.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = -1 Then
            Dim fila As DataGridViewRow = DTNumerosTelefono.Rows(e.RowIndex)

            If fila.Cells("NumeroTelefono").Value Is Nothing Then
                MessageBox.Show("No hay datos para mostrar en esta fila")

                Exit Sub
            End If

            editandoNumeroTelefonoContacto = True

            Dim numeroTelefono As String = fila.Cells("NumeroTelefono").Value.ToString()

            Dim numeroTelefonoElegido As NumeroTelefono = GetNumeroTelefonoElegido(numeroTelefono)

            numeroTelefonoEnEdicion = numeroTelefonoElegido

            TxtNumeroTelefono.Text = numeroTelefonoElegido.NumeroTelefono

            CboTipoTelefono.SelectedItem = numeroTelefonoElegido.Tipo

        End If
    End Sub

    Private Sub DTNumerosTelefono_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DTNumerosTelefono.CellMouseEnter
        ' Verifica si el mouse está sobre la última columna
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = -1 Then
            DTNumerosTelefono.Cursor = Cursors.Hand ' Cambia el cursor a mano
        End If
    End Sub

    Private Sub DTNumerosTelefono_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DTNumerosTelefono.CellMouseLeave
        ' Verifica si el mouse sale de la última columna
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = -1 Then
            DTNumerosTelefono.Cursor = Cursors.Default ' Restaura el cursor por defecto
        End If
    End Sub

    Private Sub DTCorreos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTCorreos.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = -1 Then
            Dim fila As DataGridViewRow = DTCorreos.Rows(e.RowIndex)

            If fila.Cells("Correo").Value Is Nothing Then
                MessageBox.Show("No hay datos para mostrar en esta fila")

                Exit Sub
            End If

            Dim correo As String = fila.Cells("Correo").Value.ToString()

            Dim correoElegido As Correo = GetCorreoElegido(correo)

            correoEnEdicion = correoElegido

            TxtCorreo.Text = correoElegido.Correo

            editandoCorreoContacto = True
        End If
    End Sub

    Private Sub DTCorreos_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DTCorreos.CellMouseEnter
        ' Verifica si el mouse está sobre la última columna
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = -1 Then
            DTCorreos.Cursor = Cursors.Hand ' Cambia el cursor a mano
        End If
    End Sub

    Private Sub DTCorreos_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DTCorreos.CellMouseLeave
        ' Verifica si el mouse sale de la última columna
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = -1 Then
            DTCorreos.Cursor = Cursors.Default ' Restaura el cursor por defecto
        End If
    End Sub

    Private Sub InitControllers()
        CategoriaController = New CategoriaController()

        ContactoController = New ContactoController()


    End Sub

    Private Sub InitFormulario()
        contactos = ContactoController.GetContactosByIdUsuario(DatosGlobales.UsuarioIngresado.IdUsuario)

        categoriasContacto = CategoriaController.GetCategoriasContacto()

        tiposTelefono = New ArrayList() From {"Casa", "Celular", "WhatsApp", "Emergencia"}

        LblBienvenida.Text = $"¡Hola, { DatosGlobales.UsuarioIngresado.NombreUsuario }! Bienvenido(a) a tu Agenda de Contactos"

        LlenarDatosEstaticosFormulario()
    End Sub

    Private Sub LlenarDatosEstaticosFormulario()
        If categoriasContacto.Count > 0 Then
            LlenarCboCategoriasContacto()
        End If

        If tiposTelefono.Count > 0 Then
            LlenarCboTiposNumeroTelefono()
        End If

        'If contactos.Count > 0 Then
        LlenarDataTableContactos()
        'End If
    End Sub

    Private Sub LlenarCboCategoriasContacto()
        For Each categoria As Categoria In categoriasContacto
            CboCategoria.Items.Add(categoria.Nombre)
        Next
    End Sub

    Private Sub LlenarCboTiposNumeroTelefono()
        For Each tipoTelefono As String In tiposTelefono
            CboTipoTelefono.Items.Add(tipoTelefono)
        Next
    End Sub

    Private Sub LlenarDataTableContactos()
        If contactos.Count > 0 Then
            For Each contacto As Contacto In contactos
                DTContactos.Rows.Add(
                contacto.IdContacto,
                contacto.NombreCompleto,
                contacto.Apellidos,
                contacto.FechaRegistro,
                contacto.FechaModificacion,
                contacto.Categoria.Nombre,
                contacto.Direccion.Calle,
                If(contacto.Direccion.NumeroInterior <> "", contacto.Direccion.NumeroInterior, "S/N"),
                If(contacto.Direccion.NumeroExterior <> "", contacto.Direccion.NumeroExterior, "S/N"),
                contacto.Direccion.Colonia,
                contacto.Direccion.Localidad,
                contacto.Direccion.Municipio,
                contacto.Direccion.Estado,
                contacto.Direccion.CodigoPostal,
                contacto.Direccion.Tipo,
                If(contacto.DatosCliente.MontoCredito <> 0, contacto.DatosCliente.MontoCredito, "N/A"),
                If(contacto.DatosCliente.DiasCredito <> 0, contacto.DatosCliente.DiasCredito, "N/A"),
                If(contacto.DatosCliente.RegimenFiscal <> "", contacto.DatosCliente.RegimenFiscal, "N/A"),
                If(contacto.DatosEmpleado.Curp <> "", contacto.DatosEmpleado.Curp, "N/A"),
                If(contacto.DatosEmpleado.Puesto <> "", contacto.DatosEmpleado.Puesto, "N/A"),
                If(contacto.DatosEmpleado.Sueldo <> 0, contacto.DatosEmpleado.Sueldo, "N/A"),
                If(contacto.DatosProveedor.Descripcion <> "", contacto.DatosProveedor.Descripcion, "N/A"),
                If(contacto.DatosProveedor.RegimenFiscal <> "", contacto.DatosProveedor.RegimenFiscal, "N/A"),
                If(contacto.DatosProveedor.FechaEntregaMercancia <> "", contacto.DatosProveedor.FechaEntregaMercancia, "N/A")
            )
            Next

            DTContactos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Else
            MessageBox.Show("No se encontraron contactos para este usuario")

            If DTContactos.RowCount > 0 Then
                DTContactos.Rows.Clear()
            End If

        End If
    End Sub

    Private Function GetContactoElegido(idContacto As Integer)
        For Each contacto As Contacto In contactos
            If contacto.IdContacto = idContacto Then
                Return contacto

                Exit Function
            End If
        Next

        Return Nothing ' Si no se encuentra el contacto, se devuelve Nothing
    End Function

    Private Function GetNumeroTelefonoElegido(numeroTelefonoBuscado As String) As NumeroTelefono
        For Each numeroTelefono As NumeroTelefono In nuevosNumerosTelefonoContacto
            If numeroTelefono.NumeroTelefono = numeroTelefonoBuscado Then

                Return numeroTelefono
            End If
        Next

        Return Nothing
    End Function

    Private Function GetCorreoElegido(correoBuscado As String) As Correo
        For Each contacto As Contacto In contactos
            For Each correo As Correo In contacto.ListaCorreos
                If correo.Correo = correoBuscado Then
                    Return correo
                End If
            Next
        Next

        Return Nothing
    End Function

    Private Sub LimpiarCampos()
        editandoContacto = False

        editandoCorreoContacto = False

        editandoNumeroTelefonoContacto = False

        idContactoEnEdicion = 0

        correoEnEdicion = Nothing

        numeroTelefonoEnEdicion = Nothing

        TxtCalle.Text = ""

        TxtNumeroExterior.Text = ""

        TxtNumeroInterior.Text = ""

        TxtColonia.Text = ""

        TxtCodigoPostal.Text = ""

        TxtLocalidad.Text = ""

        TxtMunicipio.Text = ""

        TxtEstado.Text = ""

        TxtNombreCompleto.Text = ""

        TxtApellidos.Text = ""

        TxtCorreo.Text = ""

        TxtCurp.Text = ""
        TxtCurp.Enabled = False

        TxtPuesto.Text = ""
        TxtPuesto.Enabled = False

        TxtSueldo.Text = ""
        TxtSueldo.Enabled = False

        TxtMontoCredito.Text = ""
        TxtMontoCredito.Enabled = False

        TxtDiasCredito.Text = ""
        TxtDiasCredito.Enabled = False

        TxtRegimenFiscalCliente.Text = ""
        TxtRegimenFiscalCliente.Enabled = False

        TxtDescripcion.Text = ""
        TxtDescripcion.Enabled = False

        TxtFechaEntregaMercancia.Text = ""
        TxtFechaEntregaMercancia.Enabled = False

        TxtRegimenFiscalProveedor.Text = ""
        TxtRegimenFiscalProveedor.Enabled = False

        RBtnDireccionFiscal.Checked = False

        RBtnDireccionReal.Checked = False

        CboCategoria.SelectedIndex = -1

        CboTipoTelefono.SelectedIndex = -1

        DTNumerosTelefono.Rows.Clear()

        DTCorreos.Rows.Clear()
    End Sub

    Private Sub RefetchContactos()
        contactos = ContactoController.GetContactosByIdUsuario(DatosGlobales.UsuarioIngresado.IdUsuario)

        LlenarDataTableContactos()
    End Sub

    Private Sub ActualizarDataTableNumerosTelefono()
        DTNumerosTelefono.Rows.Clear()

        For Each numeroTelefono As NumeroTelefono In nuevosNumerosTelefonoContacto
            DTNumerosTelefono.Rows.Add(numeroTelefono.IdNumeroTelefono, numeroTelefono.NumeroTelefono)
        Next

        DTNumerosTelefono.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        DTNumerosTelefono.ScrollBars = ScrollBars.Vertical
    End Sub

    Private Sub ActualizarDataTableCorreos()
        DTCorreos.Rows.Clear()

        For Each correo As Correo In nuevosCorreosContacto
            DTCorreos.Rows.Add(correo.IdCorreo, correo.Correo)
        Next

        DTCorreos.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        DTCorreos.ScrollBars = ScrollBars.Vertical
    End Sub

    Private Function EsCorreoValido(correo As String) As Boolean

        Dim patronCorreo As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"

        Dim regex As New Regex(patronCorreo)

        Return regex.IsMatch(correo)
    End Function

    Private Function ValidarCamposVacios() As Boolean
        Dim camposVacios As Boolean = False

        If TxtCalle.Text = "" OrElse
           TxtLocalidad.Text = "" OrElse
           TxtNumeroExterior.Text = "" OrElse
           TxtMunicipio.Text = "" OrElse
           TxtColonia.Text = "" OrElse
           TxtEstado.Text = "" OrElse
           TxtCodigoPostal.Text = "" OrElse
           TxtNombreCompleto.Text = "" OrElse
           TxtApellidos.Text = "" Then
            camposVacios = True
        End If

        If Not RBtnDireccionFiscal.Checked AndAlso Not RBtnDireccionReal.Checked Then
            camposVacios = True
        End If

        If CboCategoria.SelectedIndex = -1 Then
            Console.WriteLine("cbo cat")
            camposVacios = True
        End If

        If TxtCurp.Enabled AndAlso TxtCurp.Text = "" Then
            camposVacios = True
        End If

        If TxtPuesto.Enabled AndAlso TxtPuesto.Text = "" Then
            camposVacios = True
        End If

        If TxtSueldo.Enabled AndAlso TxtSueldo.Text = "" Then
            camposVacios = True
        End If

        If TxtMontoCredito.Enabled AndAlso TxtMontoCredito.Text = "" Then
            camposVacios = True
        End If

        If TxtDiasCredito.Enabled AndAlso TxtDiasCredito.Text = "" Then
            camposVacios = True
        End If

        If TxtRegimenFiscalCliente.Enabled AndAlso TxtRegimenFiscalCliente.Text = "" Then
            camposVacios = True
        End If

        If TxtRegimenFiscalProveedor.Enabled AndAlso TxtRegimenFiscalProveedor.Text = "" Then
            camposVacios = True
        End If

        If TxtFechaEntregaMercancia.Enabled AndAlso TxtFechaEntregaMercancia.Text = "" Then
            camposVacios = True
        End If

        If TxtDescripcion.Enabled AndAlso TxtDescripcion.Text = "" Then
            camposVacios = True
        End If

        Return camposVacios

    End Function

    Private Function LlenarNuevoContacto()
        Dim contacto As New Contacto()

        'Datos de contacto
        Dim idContacto As Integer = 0

        Dim idDireccion As Integer = 0

        Dim nombreCategoria As String = CboCategoria.SelectedItem

        Dim idCategoria As Integer

        For Each categ As Categoria In categoriasContacto
            If categ.Nombre = nombreCategoria Then
                idCategoria = categ.IdCategoria
            End If
        Next

        Dim nombreCompleto As String = TxtNombreCompleto.Text

        Dim apellidos As String = TxtApellidos.Text

        'Llenado de Objetos Inherentes
        Dim direccion As New Direccion(idDireccion, TxtCalle.Text, TxtNumeroInterior.Text, TxtNumeroExterior.Text, TxtColonia.Text, TxtLocalidad.Text, TxtMunicipio.Text, TxtEstado.Text, TxtCodigoPostal.Text, If(RBtnDireccionFiscal.Checked, "Fiscal", "Real"))

        Dim categoria As New Categoria(idCategoria, nombreCategoria)

        Dim usuarioCreador As Usuario = DatosGlobales.UsuarioIngresado

        'Llenado de arreglos de correos y números de teléfono
        Dim listaCorreos As New ArrayList()

        Dim listaNumerosTelefono As New ArrayList()

        'Llenado de objetos opcionales
        Select Case categoria.Nombre
            Case "Empleado"
                Dim idDatosEmpleado As Integer = 0

                Dim curp As String = TxtCurp.Text

                Dim puesto As String = TxtPuesto.Text

                Dim sueldo As Decimal = If(Decimal.TryParse(TxtSueldo.Text, sueldo), sueldo, 0D)

                Dim datosEmpleado As New DatosEmpleado(idDatosEmpleado, curp, puesto, sueldo)

                contacto = New Contacto(idContacto, nombreCompleto, apellidos, direccion, categoria, DateTime.Now, DateTime.Now, usuarioCreador, datosEmpleado, listaNumerosTelefono, listaCorreos)

            Case "Cliente"
                Dim idDatosCliente As Integer = 0

                Dim montoCredito As Decimal = CType(TxtMontoCredito.Text, Decimal)

                Dim diasCredito As Integer = CInt(TxtDiasCredito.Text)

                Dim regimenFiscal As String = TxtRegimenFiscalCliente.Text

                Dim datosCliente As New DatosCliente(idDatosCliente, montoCredito, diasCredito, regimenFiscal)

                contacto = New Contacto(idContacto, nombreCompleto, apellidos, direccion, categoria, DateTime.Now, DateTime.Now, usuarioCreador, datosCliente, listaNumerosTelefono, listaCorreos)

            Case "Proveedor"
                Dim idDatosProveedor As Integer = 0

                Dim descripcion As String = TxtDescripcion.Text

                Dim fechaEntregaMercancia As String = TxtFechaEntregaMercancia.Text

                Dim regimenFiscal As String = TxtRegimenFiscalProveedor.Text

                Dim datosProveedor As New DatosProveedor(idDatosProveedor, descripcion, regimenFiscal, fechaEntregaMercancia)

                contacto = New Contacto(idContacto, nombreCompleto, apellidos, direccion, categoria, DateTime.Now, DateTime.Now, usuarioCreador, datosProveedor, listaNumerosTelefono, listaCorreos)

        End Select

        Return contacto
    End Function
End Class