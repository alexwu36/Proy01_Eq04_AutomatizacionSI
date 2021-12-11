Public Class RecuperarContraseña
    Private Sub btn_Volver_Click(sender As Object, e As EventArgs) Handles btn_Volver.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btn_Enviar_Click(sender As Object, e As EventArgs) Handles btn_Enviar.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        frmRegistro.Show()
    End Sub
End Class