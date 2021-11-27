Imports Calendario

Public Class PantallaPrincipal_UGeneral
    Private Sub btn_btn_Form_SEvento(sender As Object, e As EventArgs) Handles btn_Form_SEvento.Click
        Me.Hide()
        Form_SEvento.Show()
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btn_FormSEquipo_Click(sender As Object, e As EventArgs) Handles btn_FormSEquipo.Click
        Me.Hide()
        Form_SEquipo.Show()
    End Sub

    Private Sub btn_Estado_Solicitud_Click(sender As Object, e As EventArgs) Handles btn_Estado_Solicitud.Click
        Me.Hide()
        Form_EstadoSolicitud.Show()
    End Sub
End Class