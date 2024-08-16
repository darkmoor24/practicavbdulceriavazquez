<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Contactos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contactos))
        Me.DTContactos = New System.Windows.Forms.DataGridView()
        Me.IdContacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaModificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroInterior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroExterior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colonia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Municipio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoPostal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDireccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoCredito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasCredito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegimenFiscalCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Curp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Puesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sueldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegimenFiscalProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEntregaMercancia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCalle = New System.Windows.Forms.TextBox()
        Me.TxtLocalidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtMunicipio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtEstado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtColonia = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtNumeroExterior = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNumeroInterior = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtCodigoPostal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RBtnDireccionFiscal = New System.Windows.Forms.RadioButton()
        Me.RBtnDireccionReal = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CboCategoria = New System.Windows.Forms.ComboBox()
        Me.TxtCurp = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtMontoCredito = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtFechaEntregaMercancia = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxtDiasCredito = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtPuesto = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TxtRegimenFiscalProveedor = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TxtRegimenFiscalCliente = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TxtSueldo = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.BtnAgregarContacto = New System.Windows.Forms.Button()
        Me.BtnModificarContacto = New System.Windows.Forms.Button()
        Me.BtnEliminarContacto = New System.Windows.Forms.Button()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TxtNombreCompleto = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TxtNumeroTelefono = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.CboTipoTelefono = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.BtnAgregarNumeroTelefono = New System.Windows.Forms.Button()
        Me.BtnAgregarCorreo = New System.Windows.Forms.Button()
        Me.DTNumerosTelefono = New System.Windows.Forms.DataGridView()
        Me.NumeroTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTCorreos = New System.Windows.Forms.DataGridView()
        Me.Correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnEliminarCorreo = New System.Windows.Forms.Button()
        Me.BtnEliminarNumeroTelefono = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnLimpiarCampos = New System.Windows.Forms.Button()
        CType(Me.DTContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTNumerosTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTCorreos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTContactos
        '
        Me.DTContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTContactos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdContacto, Me.NombreCompleto, Me.Apellidos, Me.FechaRegistro, Me.FechaModificacion, Me.NombreCategoria, Me.Calle, Me.NumeroInterior, Me.NumeroExterior, Me.Colonia, Me.Localidad, Me.Municipio, Me.Estado, Me.CodigoPostal, Me.TipoDireccion, Me.MontoCredito, Me.DiasCredito, Me.RegimenFiscalCliente, Me.Curp, Me.Puesto, Me.Sueldo, Me.Descripcion, Me.RegimenFiscalProveedor, Me.FechaEntregaMercancia})
        Me.DTContactos.Location = New System.Drawing.Point(11, 540)
        Me.DTContactos.Name = "DTContactos"
        Me.DTContactos.Size = New System.Drawing.Size(1281, 309)
        Me.DTContactos.TabIndex = 0
        '
        'IdContacto
        '
        Me.IdContacto.HeaderText = "ID"
        Me.IdContacto.Name = "IdContacto"
        '
        'NombreCompleto
        '
        Me.NombreCompleto.HeaderText = "Nombre(s)"
        Me.NombreCompleto.Name = "NombreCompleto"
        '
        'Apellidos
        '
        Me.Apellidos.HeaderText = "Apellidos"
        Me.Apellidos.Name = "Apellidos"
        '
        'FechaRegistro
        '
        Me.FechaRegistro.HeaderText = "Fecha de Registro"
        Me.FechaRegistro.Name = "FechaRegistro"
        '
        'FechaModificacion
        '
        Me.FechaModificacion.HeaderText = "Fecha de Modificación"
        Me.FechaModificacion.Name = "FechaModificacion"
        '
        'NombreCategoria
        '
        Me.NombreCategoria.HeaderText = "Tipo de Contacto"
        Me.NombreCategoria.Name = "NombreCategoria"
        '
        'Calle
        '
        Me.Calle.HeaderText = "Calle"
        Me.Calle.Name = "Calle"
        '
        'NumeroInterior
        '
        Me.NumeroInterior.HeaderText = "Número interior"
        Me.NumeroInterior.Name = "NumeroInterior"
        '
        'NumeroExterior
        '
        Me.NumeroExterior.HeaderText = "Número exterior"
        Me.NumeroExterior.Name = "NumeroExterior"
        '
        'Colonia
        '
        Me.Colonia.HeaderText = "Colonia"
        Me.Colonia.Name = "Colonia"
        '
        'Localidad
        '
        Me.Localidad.HeaderText = "Localidad"
        Me.Localidad.Name = "Localidad"
        '
        'Municipio
        '
        Me.Municipio.HeaderText = "Municipio"
        Me.Municipio.Name = "Municipio"
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        '
        'CodigoPostal
        '
        Me.CodigoPostal.HeaderText = "Código Postal"
        Me.CodigoPostal.Name = "CodigoPostal"
        '
        'TipoDireccion
        '
        Me.TipoDireccion.HeaderText = "Tipo de Dirección"
        Me.TipoDireccion.Name = "TipoDireccion"
        '
        'MontoCredito
        '
        Me.MontoCredito.HeaderText = "Monto del crédito"
        Me.MontoCredito.Name = "MontoCredito"
        '
        'DiasCredito
        '
        Me.DiasCredito.HeaderText = "DiasCredito"
        Me.DiasCredito.Name = "DiasCredito"
        '
        'RegimenFiscalCliente
        '
        Me.RegimenFiscalCliente.HeaderText = "Régimen Fiscal de Cliente"
        Me.RegimenFiscalCliente.Name = "RegimenFiscalCliente"
        '
        'Curp
        '
        Me.Curp.HeaderText = "CURP"
        Me.Curp.Name = "Curp"
        '
        'Puesto
        '
        Me.Puesto.HeaderText = "Puesto"
        Me.Puesto.Name = "Puesto"
        '
        'Sueldo
        '
        Me.Sueldo.HeaderText = "Sueldo"
        Me.Sueldo.Name = "Sueldo"
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción Proveedor"
        Me.Descripcion.Name = "Descripcion"
        '
        'RegimenFiscalProveedor
        '
        Me.RegimenFiscalProveedor.HeaderText = "Régimen Fiscal de Proveedor"
        Me.RegimenFiscalProveedor.Name = "RegimenFiscalProveedor"
        '
        'FechaEntregaMercancia
        '
        Me.FechaEntregaMercancia.HeaderText = "Fecha de entrega de mercancía"
        Me.FechaEntregaMercancia.Name = "FechaEntregaMercancia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bienvenido(a) a tu Agenda de Contactos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(462, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(569, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Puedes agregar más de un número de teléfono y correo electrónico para cada contac" &
    "to."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Datos de Domicilio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Calle"
        '
        'TxtCalle
        '
        Me.TxtCalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCalle.Location = New System.Drawing.Point(37, 91)
        Me.TxtCalle.Name = "TxtCalle"
        Me.TxtCalle.Size = New System.Drawing.Size(189, 23)
        Me.TxtCalle.TabIndex = 1
        '
        'TxtLocalidad
        '
        Me.TxtLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLocalidad.Location = New System.Drawing.Point(245, 91)
        Me.TxtLocalidad.Name = "TxtLocalidad"
        Me.TxtLocalidad.Size = New System.Drawing.Size(189, 23)
        Me.TxtLocalidad.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(242, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Localidad"
        '
        'TxtMunicipio
        '
        Me.TxtMunicipio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMunicipio.Location = New System.Drawing.Point(245, 137)
        Me.TxtMunicipio.Name = "TxtMunicipio"
        Me.TxtMunicipio.Size = New System.Drawing.Size(189, 23)
        Me.TxtMunicipio.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(242, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Municipio"
        '
        'TxtEstado
        '
        Me.TxtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEstado.Location = New System.Drawing.Point(245, 183)
        Me.TxtEstado.Name = "TxtEstado"
        Me.TxtEstado.Size = New System.Drawing.Size(189, 23)
        Me.TxtEstado.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(242, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Estado"
        '
        'TxtColonia
        '
        Me.TxtColonia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtColonia.Location = New System.Drawing.Point(37, 183)
        Me.TxtColonia.Name = "TxtColonia"
        Me.TxtColonia.Size = New System.Drawing.Size(189, 23)
        Me.TxtColonia.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Colonia"
        '
        'TxtNumeroExterior
        '
        Me.TxtNumeroExterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumeroExterior.Location = New System.Drawing.Point(37, 137)
        Me.TxtNumeroExterior.Name = "TxtNumeroExterior"
        Me.TxtNumeroExterior.Size = New System.Drawing.Size(90, 23)
        Me.TxtNumeroExterior.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(34, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Número ext."
        '
        'TxtNumeroInterior
        '
        Me.TxtNumeroInterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumeroInterior.Location = New System.Drawing.Point(136, 137)
        Me.TxtNumeroInterior.Name = "TxtNumeroInterior"
        Me.TxtNumeroInterior.Size = New System.Drawing.Size(90, 23)
        Me.TxtNumeroInterior.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(133, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Número int."
        '
        'TxtCodigoPostal
        '
        Me.TxtCodigoPostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigoPostal.Location = New System.Drawing.Point(37, 229)
        Me.TxtCodigoPostal.MaxLength = 5
        Me.TxtCodigoPostal.Name = "TxtCodigoPostal"
        Me.TxtCodigoPostal.Size = New System.Drawing.Size(189, 23)
        Me.TxtCodigoPostal.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(34, 209)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 16)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Código Postal"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(242, 209)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 16)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Tipo de Dirección"
        '
        'RBtnDireccionFiscal
        '
        Me.RBtnDireccionFiscal.AutoSize = True
        Me.RBtnDireccionFiscal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtnDireccionFiscal.Location = New System.Drawing.Point(245, 230)
        Me.RBtnDireccionFiscal.Name = "RBtnDireccionFiscal"
        Me.RBtnDireccionFiscal.Size = New System.Drawing.Size(62, 21)
        Me.RBtnDireccionFiscal.TabIndex = 9
        Me.RBtnDireccionFiscal.TabStop = True
        Me.RBtnDireccionFiscal.Text = "Fiscal"
        Me.RBtnDireccionFiscal.UseVisualStyleBackColor = True
        '
        'RBtnDireccionReal
        '
        Me.RBtnDireccionReal.AutoSize = True
        Me.RBtnDireccionReal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtnDireccionReal.Location = New System.Drawing.Point(312, 230)
        Me.RBtnDireccionReal.Name = "RBtnDireccionReal"
        Me.RBtnDireccionReal.Size = New System.Drawing.Size(55, 21)
        Me.RBtnDireccionReal.TabIndex = 21
        Me.RBtnDireccionReal.TabStop = True
        Me.RBtnDireccionReal.Text = "Real"
        Me.RBtnDireccionReal.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(34, 294)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 16)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Categoría"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 267)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(146, 20)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Tipo de Contacto"
        '
        'CboCategoria
        '
        Me.CboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCategoria.FormattingEnabled = True
        Me.CboCategoria.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CboCategoria.Location = New System.Drawing.Point(37, 314)
        Me.CboCategoria.Name = "CboCategoria"
        Me.CboCategoria.Size = New System.Drawing.Size(189, 24)
        Me.CboCategoria.TabIndex = 24
        '
        'TxtCurp
        '
        Me.TxtCurp.Enabled = False
        Me.TxtCurp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCurp.Location = New System.Drawing.Point(38, 399)
        Me.TxtCurp.Name = "TxtCurp"
        Me.TxtCurp.Size = New System.Drawing.Size(189, 23)
        Me.TxtCurp.TabIndex = 25
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(35, 379)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 16)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "CURP"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(13, 352)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 20)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Empleado"
        '
        'TxtMontoCredito
        '
        Me.TxtMontoCredito.Enabled = False
        Me.TxtMontoCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMontoCredito.Location = New System.Drawing.Point(245, 399)
        Me.TxtMontoCredito.Name = "TxtMontoCredito"
        Me.TxtMontoCredito.Size = New System.Drawing.Size(189, 23)
        Me.TxtMontoCredito.TabIndex = 28
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(242, 379)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(125, 16)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Monto de Crédito"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Enabled = False
        Me.TxtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(455, 399)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(189, 23)
        Me.TxtDescripcion.TabIndex = 30
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(452, 379)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 16)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Descripción"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(217, 352)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 20)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Cliente"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(427, 352)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(90, 20)
        Me.Label20.TabIndex = 33
        Me.Label20.Text = "Proveedor"
        '
        'TxtFechaEntregaMercancia
        '
        Me.TxtFechaEntregaMercancia.Enabled = False
        Me.TxtFechaEntregaMercancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaEntregaMercancia.Location = New System.Drawing.Point(455, 445)
        Me.TxtFechaEntregaMercancia.Name = "TxtFechaEntregaMercancia"
        Me.TxtFechaEntregaMercancia.Size = New System.Drawing.Size(189, 23)
        Me.TxtFechaEntregaMercancia.TabIndex = 38
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(452, 425)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(190, 13)
        Me.Label21.TabIndex = 39
        Me.Label21.Text = "Fecha de Entrega de mercancía"
        '
        'TxtDiasCredito
        '
        Me.TxtDiasCredito.Enabled = False
        Me.TxtDiasCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiasCredito.Location = New System.Drawing.Point(245, 445)
        Me.TxtDiasCredito.Name = "TxtDiasCredito"
        Me.TxtDiasCredito.Size = New System.Drawing.Size(189, 23)
        Me.TxtDiasCredito.TabIndex = 36
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(242, 425)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(115, 16)
        Me.Label22.TabIndex = 37
        Me.Label22.Text = "Días de Crédito"
        '
        'TxtPuesto
        '
        Me.TxtPuesto.Enabled = False
        Me.TxtPuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPuesto.Location = New System.Drawing.Point(38, 445)
        Me.TxtPuesto.Name = "TxtPuesto"
        Me.TxtPuesto.Size = New System.Drawing.Size(189, 23)
        Me.TxtPuesto.TabIndex = 34
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(35, 425)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(55, 16)
        Me.Label23.TabIndex = 35
        Me.Label23.Text = "Puesto"
        '
        'TxtRegimenFiscalProveedor
        '
        Me.TxtRegimenFiscalProveedor.Enabled = False
        Me.TxtRegimenFiscalProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRegimenFiscalProveedor.Location = New System.Drawing.Point(454, 491)
        Me.TxtRegimenFiscalProveedor.Name = "TxtRegimenFiscalProveedor"
        Me.TxtRegimenFiscalProveedor.Size = New System.Drawing.Size(189, 23)
        Me.TxtRegimenFiscalProveedor.TabIndex = 44
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(451, 471)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(115, 16)
        Me.Label24.TabIndex = 45
        Me.Label24.Text = "Régimen Fiscal"
        '
        'TxtRegimenFiscalCliente
        '
        Me.TxtRegimenFiscalCliente.Enabled = False
        Me.TxtRegimenFiscalCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRegimenFiscalCliente.Location = New System.Drawing.Point(244, 491)
        Me.TxtRegimenFiscalCliente.Name = "TxtRegimenFiscalCliente"
        Me.TxtRegimenFiscalCliente.Size = New System.Drawing.Size(189, 23)
        Me.TxtRegimenFiscalCliente.TabIndex = 42
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(241, 471)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(115, 16)
        Me.Label25.TabIndex = 43
        Me.Label25.Text = "Régimen Fiscal"
        '
        'TxtSueldo
        '
        Me.TxtSueldo.Enabled = False
        Me.TxtSueldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSueldo.Location = New System.Drawing.Point(37, 491)
        Me.TxtSueldo.Name = "TxtSueldo"
        Me.TxtSueldo.Size = New System.Drawing.Size(189, 23)
        Me.TxtSueldo.TabIndex = 40
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(34, 471)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(56, 16)
        Me.Label26.TabIndex = 41
        Me.Label26.Text = "Sueldo"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(681, 352)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(82, 20)
        Me.Label27.TabIndex = 46
        Me.Label27.Text = "Acciones"
        '
        'BtnAgregarContacto
        '
        Me.BtnAgregarContacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnAgregarContacto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnAgregarContacto.FlatAppearance.BorderSize = 0
        Me.BtnAgregarContacto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAgregarContacto.ForeColor = System.Drawing.Color.White
        Me.BtnAgregarContacto.Location = New System.Drawing.Point(682, 379)
        Me.BtnAgregarContacto.Name = "BtnAgregarContacto"
        Me.BtnAgregarContacto.Size = New System.Drawing.Size(610, 25)
        Me.BtnAgregarContacto.TabIndex = 47
        Me.BtnAgregarContacto.Text = "Agregar Contacto"
        Me.BtnAgregarContacto.UseVisualStyleBackColor = False
        '
        'BtnModificarContacto
        '
        Me.BtnModificarContacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnModificarContacto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnModificarContacto.ForeColor = System.Drawing.Color.White
        Me.BtnModificarContacto.Location = New System.Drawing.Point(682, 416)
        Me.BtnModificarContacto.Name = "BtnModificarContacto"
        Me.BtnModificarContacto.Size = New System.Drawing.Size(610, 25)
        Me.BtnModificarContacto.TabIndex = 48
        Me.BtnModificarContacto.Text = "Modificar Contacto"
        Me.BtnModificarContacto.UseVisualStyleBackColor = False
        '
        'BtnEliminarContacto
        '
        Me.BtnEliminarContacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnEliminarContacto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnEliminarContacto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEliminarContacto.ForeColor = System.Drawing.Color.White
        Me.BtnEliminarContacto.Location = New System.Drawing.Point(682, 452)
        Me.BtnEliminarContacto.Name = "BtnEliminarContacto"
        Me.BtnEliminarContacto.Size = New System.Drawing.Size(610, 25)
        Me.BtnEliminarContacto.TabIndex = 49
        Me.BtnEliminarContacto.Text = "Eliminar Contacto"
        Me.BtnEliminarContacto.UseVisualStyleBackColor = False
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellidos.Location = New System.Drawing.Point(694, 91)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(189, 23)
        Me.TxtApellidos.TabIndex = 53
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(691, 71)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(73, 16)
        Me.Label28.TabIndex = 54
        Me.Label28.Text = "Apellidos"
        '
        'TxtNombreCompleto
        '
        Me.TxtNombreCompleto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreCompleto.Location = New System.Drawing.Point(486, 91)
        Me.TxtNombreCompleto.Name = "TxtNombreCompleto"
        Me.TxtNombreCompleto.Size = New System.Drawing.Size(189, 23)
        Me.TxtNombreCompleto.TabIndex = 50
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(483, 71)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(80, 16)
        Me.Label29.TabIndex = 52
        Me.Label29.Text = "Nombre(s)"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(461, 44)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(151, 20)
        Me.Label30.TabIndex = 51
        Me.Label30.Text = "Datos Personales"
        '
        'TxtNumeroTelefono
        '
        Me.TxtNumeroTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumeroTelefono.Location = New System.Drawing.Point(489, 137)
        Me.TxtNumeroTelefono.Name = "TxtNumeroTelefono"
        Me.TxtNumeroTelefono.Size = New System.Drawing.Size(186, 23)
        Me.TxtNumeroTelefono.TabIndex = 55
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(486, 117)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(149, 16)
        Me.Label31.TabIndex = 56
        Me.Label31.Text = "Número de Teléfono"
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCorreo.Location = New System.Drawing.Point(489, 183)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(394, 23)
        Me.TxtCorreo.TabIndex = 57
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(486, 163)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(135, 16)
        Me.Label32.TabIndex = 58
        Me.Label32.Text = "Correo electrónico"
        '
        'CboTipoTelefono
        '
        Me.CboTipoTelefono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipoTelefono.FormattingEnabled = True
        Me.CboTipoTelefono.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CboTipoTelefono.Location = New System.Drawing.Point(694, 137)
        Me.CboTipoTelefono.Name = "CboTipoTelefono"
        Me.CboTipoTelefono.Size = New System.Drawing.Size(189, 24)
        Me.CboTipoTelefono.TabIndex = 60
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(691, 117)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(127, 16)
        Me.Label33.TabIndex = 59
        Me.Label33.Text = "Tipo de Teléfono"
        '
        'BtnAgregarNumeroTelefono
        '
        Me.BtnAgregarNumeroTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnAgregarNumeroTelefono.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnAgregarNumeroTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAgregarNumeroTelefono.Location = New System.Drawing.Point(899, 137)
        Me.BtnAgregarNumeroTelefono.Name = "BtnAgregarNumeroTelefono"
        Me.BtnAgregarNumeroTelefono.Size = New System.Drawing.Size(175, 25)
        Me.BtnAgregarNumeroTelefono.TabIndex = 61
        Me.BtnAgregarNumeroTelefono.Text = "Agregar Número"
        Me.BtnAgregarNumeroTelefono.UseVisualStyleBackColor = False
        '
        'BtnAgregarCorreo
        '
        Me.BtnAgregarCorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnAgregarCorreo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnAgregarCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAgregarCorreo.Location = New System.Drawing.Point(899, 183)
        Me.BtnAgregarCorreo.Name = "BtnAgregarCorreo"
        Me.BtnAgregarCorreo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnAgregarCorreo.Size = New System.Drawing.Size(175, 25)
        Me.BtnAgregarCorreo.TabIndex = 62
        Me.BtnAgregarCorreo.Text = "Agregar Correo"
        Me.BtnAgregarCorreo.UseVisualStyleBackColor = False
        '
        'DTNumerosTelefono
        '
        Me.DTNumerosTelefono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTNumerosTelefono.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroTelefono})
        Me.DTNumerosTelefono.Location = New System.Drawing.Point(489, 229)
        Me.DTNumerosTelefono.Name = "DTNumerosTelefono"
        Me.DTNumerosTelefono.Size = New System.Drawing.Size(186, 109)
        Me.DTNumerosTelefono.TabIndex = 63
        '
        'NumeroTelefono
        '
        Me.NumeroTelefono.HeaderText = "Número de Teléfono"
        Me.NumeroTelefono.Name = "NumeroTelefono"
        Me.NumeroTelefono.Width = 140
        '
        'DTCorreos
        '
        Me.DTCorreos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTCorreos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Correo})
        Me.DTCorreos.Location = New System.Drawing.Point(694, 229)
        Me.DTCorreos.Name = "DTCorreos"
        Me.DTCorreos.Size = New System.Drawing.Size(189, 109)
        Me.DTCorreos.TabIndex = 64
        '
        'Correo
        '
        Me.Correo.HeaderText = "Correo"
        Me.Correo.Name = "Correo"
        Me.Correo.Width = 140
        '
        'BtnEliminarCorreo
        '
        Me.BtnEliminarCorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnEliminarCorreo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnEliminarCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEliminarCorreo.ForeColor = System.Drawing.Color.White
        Me.BtnEliminarCorreo.Location = New System.Drawing.Point(899, 313)
        Me.BtnEliminarCorreo.Name = "BtnEliminarCorreo"
        Me.BtnEliminarCorreo.Size = New System.Drawing.Size(175, 25)
        Me.BtnEliminarCorreo.TabIndex = 66
        Me.BtnEliminarCorreo.Text = "Eliminar Correo"
        Me.BtnEliminarCorreo.UseVisualStyleBackColor = False
        '
        'BtnEliminarNumeroTelefono
        '
        Me.BtnEliminarNumeroTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnEliminarNumeroTelefono.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnEliminarNumeroTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEliminarNumeroTelefono.ForeColor = System.Drawing.Color.White
        Me.BtnEliminarNumeroTelefono.Location = New System.Drawing.Point(899, 267)
        Me.BtnEliminarNumeroTelefono.Name = "BtnEliminarNumeroTelefono"
        Me.BtnEliminarNumeroTelefono.Size = New System.Drawing.Size(175, 25)
        Me.BtnEliminarNumeroTelefono.TabIndex = 65
        Me.BtnEliminarNumeroTelefono.Text = "Eliminar Número"
        Me.BtnEliminarNumeroTelefono.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Location = New System.Drawing.Point(1217, 16)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 67
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1096, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 117)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 68
        Me.PictureBox1.TabStop = False
        '
        'BtnLimpiarCampos
        '
        Me.BtnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.BtnLimpiarCampos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLimpiarCampos.ForeColor = System.Drawing.Color.White
        Me.BtnLimpiarCampos.Location = New System.Drawing.Point(682, 489)
        Me.BtnLimpiarCampos.Name = "BtnLimpiarCampos"
        Me.BtnLimpiarCampos.Size = New System.Drawing.Size(610, 25)
        Me.BtnLimpiarCampos.TabIndex = 69
        Me.BtnLimpiarCampos.Text = "Limpiar Campos"
        Me.BtnLimpiarCampos.UseVisualStyleBackColor = False
        '
        'Contactos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(1304, 861)
        Me.Controls.Add(Me.BtnLimpiarCampos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEliminarCorreo)
        Me.Controls.Add(Me.BtnEliminarNumeroTelefono)
        Me.Controls.Add(Me.DTCorreos)
        Me.Controls.Add(Me.DTNumerosTelefono)
        Me.Controls.Add(Me.BtnAgregarCorreo)
        Me.Controls.Add(Me.BtnAgregarNumeroTelefono)
        Me.Controls.Add(Me.CboTipoTelefono)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.TxtCorreo)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.TxtNumeroTelefono)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.TxtApellidos)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.TxtNombreCompleto)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.BtnEliminarContacto)
        Me.Controls.Add(Me.BtnModificarContacto)
        Me.Controls.Add(Me.BtnAgregarContacto)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.TxtRegimenFiscalProveedor)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.TxtRegimenFiscalCliente)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.TxtSueldo)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.TxtFechaEntregaMercancia)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.TxtDiasCredito)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.TxtPuesto)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TxtMontoCredito)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TxtCurp)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.CboCategoria)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.RBtnDireccionReal)
        Me.Controls.Add(Me.RBtnDireccionFiscal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtCodigoPostal)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtNumeroInterior)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtNumeroExterior)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtColonia)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtEstado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtMunicipio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtLocalidad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtCalle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTContactos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Contactos"
        Me.Text = "Gestión de Contactos"
        CType(Me.DTContactos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTNumerosTelefono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTCorreos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DTContactos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCalle As TextBox
    Friend WithEvents IdContacto As DataGridViewTextBoxColumn
    Friend WithEvents NombreCompleto As DataGridViewTextBoxColumn
    Friend WithEvents Apellidos As DataGridViewTextBoxColumn
    Friend WithEvents FechaRegistro As DataGridViewTextBoxColumn
    Friend WithEvents FechaModificacion As DataGridViewTextBoxColumn
    Friend WithEvents NombreCategoria As DataGridViewTextBoxColumn
    Friend WithEvents Calle As DataGridViewTextBoxColumn
    Friend WithEvents NumeroInterior As DataGridViewTextBoxColumn
    Friend WithEvents NumeroExterior As DataGridViewTextBoxColumn
    Friend WithEvents Colonia As DataGridViewTextBoxColumn
    Friend WithEvents Localidad As DataGridViewTextBoxColumn
    Friend WithEvents Municipio As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents CodigoPostal As DataGridViewTextBoxColumn
    Friend WithEvents TipoDireccion As DataGridViewTextBoxColumn
    Friend WithEvents MontoCredito As DataGridViewTextBoxColumn
    Friend WithEvents DiasCredito As DataGridViewTextBoxColumn
    Friend WithEvents RegimenFiscalCliente As DataGridViewTextBoxColumn
    Friend WithEvents Curp As DataGridViewTextBoxColumn
    Friend WithEvents Puesto As DataGridViewTextBoxColumn
    Friend WithEvents Sueldo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents RegimenFiscalProveedor As DataGridViewTextBoxColumn
    Friend WithEvents FechaEntregaMercancia As DataGridViewTextBoxColumn
    Friend WithEvents TxtLocalidad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtMunicipio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtEstado As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtColonia As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtNumeroExterior As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtNumeroInterior As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtCodigoPostal As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents RBtnDireccionFiscal As RadioButton
    Friend WithEvents RBtnDireccionReal As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents CboCategoria As ComboBox
    Friend WithEvents TxtCurp As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtMontoCredito As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtFechaEntregaMercancia As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TxtDiasCredito As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TxtPuesto As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TxtRegimenFiscalProveedor As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TxtRegimenFiscalCliente As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents TxtSueldo As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents BtnAgregarContacto As Button
    Friend WithEvents BtnModificarContacto As Button
    Friend WithEvents BtnEliminarContacto As Button
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents TxtNombreCompleto As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents TxtNumeroTelefono As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents CboTipoTelefono As ComboBox
    Friend WithEvents Label33 As Label
    Friend WithEvents BtnAgregarNumeroTelefono As Button
    Friend WithEvents BtnAgregarCorreo As Button
    Friend WithEvents DTNumerosTelefono As DataGridView
    Friend WithEvents DTCorreos As DataGridView
    Friend WithEvents BtnEliminarCorreo As Button
    Friend WithEvents BtnEliminarNumeroTelefono As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NumeroTelefono As DataGridViewTextBoxColumn
    Friend WithEvents Correo As DataGridViewTextBoxColumn
    Friend WithEvents BtnLimpiarCampos As Button
End Class
