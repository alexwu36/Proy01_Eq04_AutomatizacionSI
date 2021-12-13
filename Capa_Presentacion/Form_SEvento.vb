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
        Capa_Datos.idFacultad2 = cbFacultad.SelectedIndex
        Capa_Datos.idLugar2 = cbLugar.SelectedIndex

        Capa_Datos.fechaEvento = dtpHoraInicio.Value
        Capa_Datos.horaInicio2 = dtpHoraInicio.Value
        Capa_Datos.horaFinal2 = dtpHoraFinal.Value

        If rbConferencias.Checked Then
            Capa_Datos.idActividad2 = 1
        ElseIf rbFerias.Checked Then
            Capa_Datos.idActividad2 = 2
        ElseIf rbSeminarios.Checked Then
            Capa_Datos.idActividad2 = 3
        ElseIf rbActos.Checked Then
            Capa_Datos.idActividad2 = 4
        ElseIf rbInauguraciones.Checked Then
            Capa_Datos.idActividad2 = 5
        ElseIf rbCongresos.Checked Then
            Capa_Datos.idActividad2 = 6
        Else
            Capa_Datos.idActividad2 = 7
        End If

        Me.Hide()
        Form_SEvento2.Show()
    End Sub

    Private Sub Form_SEvento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class