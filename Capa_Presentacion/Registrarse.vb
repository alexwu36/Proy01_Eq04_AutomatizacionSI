Public Class frmRegistro

    Private Sub btn_Crear_Cuenta_Click(sender As Object, e As EventArgs) Handles btn_Crear_Cuenta.Click
        Dim nombre, apellido, email, password, telefono, celular As String

        nombre = txtNombre.Text
        apellido = txtApellido.Text
        email = txtCorreo.Text
        password = txtContrasena.Text
        telefono = mtxtTelefono.Text
        celular = mtxtCelular.Text

        Me.Hide()
        Login.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Login.Show()
    End Sub

End Class