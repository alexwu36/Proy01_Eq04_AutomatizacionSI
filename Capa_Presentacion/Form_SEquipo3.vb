Public Class Form_SEquipo3
    Private Sub btn_Regresar_Click(sender As Object, e As EventArgs) Handles btn_Regresar.Click
        Me.Hide()
        Form_SEquipo2.Show()
    End Sub

    Private Sub btn_Borrar_Click(sender As Object, e As EventArgs) Handles btn_Borrar.Click

    End Sub

    Private Sub btn_Enviar_Click(sender As Object, e As EventArgs) Handles btn_Enviar.Click

        'Información del Día de Retiro
        Capa_Datos.fechaRetiro = dtpFechaRetiro.Value
        Capa_Datos.nombreRetiro = txtNomRetiro.Text
        Capa_Datos.nombreEntrega = txtNomEntrega.Text

        'Información del Día de Devolución

        Capa_Datos.fechaDevolucion = dtpFechaDevolucion.Value
        Capa_Datos.nombreDevuelve = txtNomDvuelve.Text
        Capa_Datos.nombreRecibe = txtNomRecibe.Text

        Me.Hide()
        PantallaPrincipal_UGeneral.Show()
    End Sub

End Class