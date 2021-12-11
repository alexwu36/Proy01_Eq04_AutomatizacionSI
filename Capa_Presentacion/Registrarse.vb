Public Class txtNombres

    Private Sub btn_Inciar_Sesion_Click(sender As Object, e As EventArgs) Handles btn_Inciar_Sesion.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btn_Crear_Cuenta_Click(sender As Object, e As EventArgs) Handles btn_Crear_Cuenta.Click
        Dim nombre, apellido, email, password, telefono, celular As String

        nombre = TextBox1.Text
        apellido = txtApellido.Text
        email = txtCorreo.Text
        password = txtContrasena.Text
        telefono = mtxtTelefono.Text
        celular = mtxtCelular.Text

        Me.Hide()
        Login.Show()
    End Sub

End Class