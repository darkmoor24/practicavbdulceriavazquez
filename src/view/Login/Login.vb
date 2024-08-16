Public Class Login
    Private Property LoginController As LoginController

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginController = New LoginController()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtNombreUsuario.Text = "" Then
            MessageBox.Show("Ingresa un nombre de usuario")

            Exit Sub
        End If

        If TxtContrasenia.Text = "" Then
            MessageBox.Show("Ingresa tu contraseña")

            Exit Sub
        End If

        Try
            Dim nombreUsuario As String = TxtNombreUsuario.Text

            Dim contrasenia As String = TxtContrasenia.Text

            Console.WriteLine("Usuario ingresado: " & nombreUsuario)
            Console.WriteLine("Contraseña ingresada: " & contrasenia)

            Dim resultadoValidacion As String = LoginController.ValidarCredenciales(nombreUsuario, contrasenia)

            Select Case resultadoValidacion
                Case "unknown_user", "wrong_password", "unknown_error"
                    Dim message As String = "Ocurrió un error desconocido, vuelve a intentar"

                    Select Case resultadoValidacion
                        Case "unknown_user"
                            message = "El usuario ingresado no existe"

                        Case "wrong_password"
                            message = "La contraseña es incorrecta"

                        Case "unknown_error"
                            message = "Algo sucedió al buscar el usuario, vuelve a intentar"

                    End Select

                    MessageBox.Show(message)

                    Exit Sub
                Case "access_granted"
                    Dim ViewContactos As New Contactos()

                    ViewContactos.Show()

                    Close()
            End Select


        Catch ex As Exception
            Console.WriteLine(ex.Message)

            MessageBox.Show("No se pudo iniciar sesión, vuelve a intentar")
        End Try
    End Sub
End Class
