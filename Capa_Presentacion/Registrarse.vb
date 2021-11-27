Public Class Registrarse

    Private Sub btn_Inciar_Sesion_Click(sender As Object, e As EventArgs) Handles btn_Inciar_Sesion.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btn_Crear_Cuenta_Click(sender As Object, e As EventArgs) Handles btn_Crear_Cuenta.Click
        Me.Hide()
        Login.Show()
    End Sub

End Class