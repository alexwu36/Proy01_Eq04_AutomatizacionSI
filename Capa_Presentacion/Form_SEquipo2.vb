Public Class Form_SEquipo2

    Private Sub btn_Regresar_SE2_Click(sender As Object, e As EventArgs) Handles btn_Regresar_SE2.Click
        Me.Hide()
        Form_SEquipo.Show()
    End Sub

    Private Sub bnt_ContinuarSE2_Click(sender As Object, e As EventArgs) Handles bnt_ContinuarSE2.Click
        Me.Hide()
        Form_SEquipo3.Show()
    End Sub

    Private Sub Form_SEquipo2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvInfoEquipo.DataSource = Capa_Datos.CargarEquipo.CargarEquipo()
    End Sub
End Class