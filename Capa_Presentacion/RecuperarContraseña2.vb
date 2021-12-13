Public Class frmRecuperarContraseña2
    Private Sub frmRecuperarContraseña2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCorreoUser.Text = RecuperarContraseña.txtCorreoE.Text
    End Sub

    Private Sub btnVerificarCodigo_Click(sender As Object, e As EventArgs) Handles btnVerificarCodigo.Click
        If (Capa_Datos.Recuperar.VerificarCodigo(txtCorreoUser.Text, txtCodigo.Text)) Then
            pnIngreso.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            txtContrasenaNueva.Visible = True
            txtContrasenaNuevaRep.Visible = True
            btnNuevaContra.Visible = True
        End If
    End Sub

    Private Sub btnNuevaContra_Click(sender As Object, e As EventArgs) Handles btnNuevaContra.Click
        If (txtContrasenaNueva.Text = txtContrasenaNuevaRep.Text) Then
            If (Capa_Datos.Recuperar.CambiarContrasena(txtCorreoUser.Text, txtContrasenaNueva.Text)) Then
                MessageBox.Show("Su contraseña ha sido cambiada con éxito", "Hecho", MessageBoxButtons.OK)
                Me.Close()
                Login.Show()
            End If
        End If
    End Sub
End Class