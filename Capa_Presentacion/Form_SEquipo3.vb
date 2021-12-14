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

        'Información del Día de Devolución

        Capa_Datos.fechaDevolucion = dtpFechaDevolucion.Value

        Capa_Datos.SolicitudEquipos.InsertarEquipo()

        Me.Hide()
        Form_SEquipo2.Show()
    End Sub

    Private Sub Form_SEquipo3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNomRetiro.Text = Capa_Datos.UsuarioActivo.firstName
    End Sub
End Class