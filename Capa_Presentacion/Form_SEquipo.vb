Public Class Form_SEquipo
    Private Sub btn_Regresar_Click(sender As Object, e As EventArgs) Handles btn_Regresar.Click
        Me.Hide()
        PantallaPrincipal_UGeneral.Show()
    End Sub

    Private Sub btn_Continuar_Click(sender As Object, e As EventArgs) Handles btn_Continuar.Click

        'Información de la actividad en la cual se utilizará el equipo

        Capa_Datos.nomActividad2 = txtNomActividad2.Text
        Capa_Datos.idLugar = cbLugar2.SelectedIndex + 1
        Capa_Datos.fechaActividad = dtpFecha.Value
        Capa_Datos.horaActividad = dtpHoraAct.Value
        Capa_Datos.idFacultad = cbFacultad.SelectedIndex + 1

        'Información de la persona que solicita el equipo

        Me.Hide()
        Form_SEquipo3.Show()
    End Sub

    Private Sub Form_SEquipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class