Imports System.Runtime.Remoting.Proxies

Public Class Contactos

    Private Property CategoriaController As CategoriaController
    Private Property ContactoController As ContactoController
    Private Property contactos As ArrayList
    Private Property categoriasContacto As ArrayList
    Private Property tiposTelefono As ArrayList
    Private Property editandoContacto As Boolean = False

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

    End Sub

    Private Sub BtnAgregarCorreo_Click(sender As Object, e As EventArgs) Handles BtnAgregarCorreo.Click

    End Sub

    Private Sub BtnEliminarNumeroTelefono_Click(sender As Object, e As EventArgs) Handles BtnEliminarNumeroTelefono.Click

    End Sub

    Private Sub BtnEliminarCorreo_Click(sender As Object, e As EventArgs) Handles BtnEliminarCorreo.Click

    End Sub

    Private Sub BtnAgregarContacto_Click(sender As Object, e As EventArgs) Handles BtnAgregarContacto.Click
        If editandoContacto Then
            MessageBox.Show("No se puede agregar mientras se está editando un producto existente")

            Exit Sub
        End If


    End Sub

    Private Sub BtnModificarContacto_Click(sender As Object, e As EventArgs) Handles BtnModificarContacto.Click
        If Not editandoContacto Then
            MessageBox.Show("No se puede modificar si no has seleccionado un contacto")

            Exit Sub
        End If
    End Sub

    Private Sub BtnEliminarContacto_Click(sender As Object, e As EventArgs) Handles BtnEliminarContacto.Click
        If Not editandoContacto Then
            MessageBox.Show("No se puede eliminar si no has seleccionado un contacto")

            Exit Sub
        End If
    End Sub

    Private Sub BtnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles BtnLimpiarCampos.Click
        editandoContacto = False


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
        If e.RowIndex = 0 AndAlso e.ColumnIndex = -1 Then
            editandoContacto = True

            Dim fila As DataGridViewRow = DTContactos.Rows(e.RowIndex)

            Dim idContacto As Integer = fila.Cells("IdContacto").Value.ToString()

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

            Dim listaNumerosTelefonoContactoElegido As ArrayList = contactoElegido.ListaNumerosTelefono

            Dim listaCorreosContactoElegido As ArrayList = contactoElegido.ListaCorreos

            DTNumerosTelefono.Rows.Clear()

            For Each numeroTelefono As NumeroTelefono In listaNumerosTelefonoContactoElegido
                DTNumerosTelefono.Rows.Add(numeroTelefono.NumeroTelefono)
            Next

            DTCorreos.Rows.Clear()

            For Each correo As Correo In listaCorreosContactoElegido
                DTCorreos.Rows.Add(correo.Correo)
            Next

            DTNumerosTelefono.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            DTCorreos.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

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

    Private Sub DTNumerosTelefono_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTNumerosTelefono.CellClick
        If e.RowIndex = 0 AndAlso e.ColumnIndex = -1 Then
            Dim fila As DataGridViewRow = DTContactos.Rows(e.RowIndex)

            Dim numeroTelefono As Integer = fila.Cells("NumeroTelefono").Value.ToString()


        End If
    End Sub

    Private Sub DTCorreos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTCorreos.CellClick
        If e.RowIndex = 0 AndAlso e.ColumnIndex = -1 Then

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

        LlenarDatosEstaticosFormulario()
    End Sub

    Private Sub LlenarDatosEstaticosFormulario()
        If categoriasContacto.Count > 0 Then
            LlenarCboCategoriasContacto()
        End If

        If tiposTelefono.Count > 0 Then
            LlenarCboTiposNumeroTelefono()
        End If

        If contactos.Count > 0 Then
            LlenarDataTableContactos()
        End If
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
End Class