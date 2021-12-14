Public Class Form_EstadoSolicitud

    Private Sub btn_Regresar_Click(sender As Object, e As EventArgs) Handles btn_Regresar.Click
        Me.Hide()
        PantallaPrincipal_UGeneral.Show()
    End Sub

    Private Sub Form_EstadoSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvEstadoEvento.DataSource = Capa_Datos.Usuario.EstadoEvento()
        dgvEstadoEvento.Columns(0).Width = 550
        dgvEstadoEvento.Columns(0).HeaderText = "Evento"
        dgvEstadoEvento.Columns(1).Width = 550
        dgvEstadoEvento.Columns(1).HeaderText = "Estado"

        dgvEstadoEquipo.DataSource = Capa_Datos.Usuario.EstadoEquipo()
        dgvEstadoEquipo.Columns(0).Width = 550
        dgvEstadoEquipo.Columns(0).HeaderText = "Equipo"
        dgvEstadoEquipo.Columns(1).Width = 550
        dgvEstadoEquipo.Columns(1).HeaderText = "Estado"

    End Sub
End Class