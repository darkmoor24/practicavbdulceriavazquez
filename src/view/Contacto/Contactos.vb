Public Class Contactos

    Private Property CategoriaController As CategoriaController
    Private Property contactos As ArrayList
    Private Property categoriasContacto As ArrayList
    Private Property tiposTelefono As ArrayList

    Private Sub Contactos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitControllers()

        InitFormulario()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

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

    End Sub

    Private Sub BtnModificarContacto_Click(sender As Object, e As EventArgs) Handles BtnModificarContacto.Click

    End Sub

    Private Sub BtnEliminarContacto_Click(sender As Object, e As EventArgs) Handles BtnEliminarContacto.Click

    End Sub

    Private Sub CboCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCategoria.SelectedIndexChanged

    End Sub

    Private Sub DTContactos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTContactos.CellContentClick

    End Sub

    Private Sub DTNumerosTelefono_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTNumerosTelefono.CellContentClick

    End Sub

    Private Sub DTCorreos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTCorreos.CellContentClick

    End Sub

    Private Sub InitControllers()
        CategoriaController = New CategoriaController()


    End Sub

    Private Sub InitFormulario()
        'contactos = ContactoController

        categoriasContacto = CategoriaController.GetCategoriasContacto()

        tiposTelefono = New ArrayList() From {"Casa", "Celular", "WhatsApp", "Emergencia"}

        LlenarDatosEstaticosFormulario()
    End Sub

    Private Sub LlenarDatosEstaticosFormulario()

    End Sub
End Class