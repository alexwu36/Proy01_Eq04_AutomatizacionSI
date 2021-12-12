Public Class Form_SEvento
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub Panel3_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel7.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Panel7.VerticalScroll.Value = e.NewValue
        End If
    End Sub

    Private Sub btn_Regresar_Click(sender As Object, e As EventArgs) Handles btn_Regresar.Click
        Me.Hide()
        PantallaPrincipal_UGeneral.Show()
    End Sub

    Private Sub btn_Continuar_Click(sender As Object, e As EventArgs) Handles btn_Continuar.Click

        Capa_Datos.nombreEvento = txtNomActividad.Text
        Capa_Datos.idFacultad = cbFacultad.SelectedIndex
        Capa_Datos.idLugar = cbLugar.SelectedIndex

        Capa_Datos.fechaEvento = dtpHoraInicio.Value
        Capa_Datos.horaInicio = dtpHoraInicio.Value
        Capa_Datos.horaFinal = dtpHoraFinal.Value

        If rbConferencias.Checked Then
            Capa_Datos.idActividad = 1
        ElseIf rbFerias.Checked Then
            Capa_Datos.idActividad = 2
        ElseIf rbSeminarios.Checked Then
            Capa_Datos.idActividad = 3
        ElseIf rbActos.Checked Then
            Capa_Datos.idActividad = 4
        ElseIf rbInauguraciones.Checked Then
            Capa_Datos.idActividad = 5
        ElseIf rbCongresos.Checked Then
            Capa_Datos.idActividad = 6
        Else
            Capa_Datos.idActividad = 7
        End If

        Me.Hide()
        Form_SEvento2.Show()
    End Sub

End Class