Public Class RecuperarContraseña
    Private Sub btn_Volver_Click(sender As Object, e As EventArgs) Handles btn_Volver.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btn_Enviar_Click(sender As Object, e As EventArgs) Handles btn_Enviar.Click
        If (Capa_Datos.Recuperar.ExisteCorreo(txtCorreoE.Text)) Then
            MessageBox.Show("Se le ha enviado un mensaje a su correo", "Correo Enviado", MessageBoxButtons.OK)
            Me.Hide()
            frmRecuperarContraseña2.Show()
        Else
            MessageBox.Show("El correo ingresado no existe en nuestra base", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        frmRegistro.Show()
    End Sub

End Class