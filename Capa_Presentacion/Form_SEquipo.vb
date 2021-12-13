Imports System.Data.SqlClient

Public Class Form_SEquipo
    Private Sub btn_Regresar_Click(sender As Object, e As EventArgs) Handles btn_Regresar.Click
        Me.Hide()
        PantallaPrincipal_UGeneral.Show()
    End Sub

    Private Sub btn_Continuar_Click(sender As Object, e As EventArgs) Handles btn_Continuar.Click

        'Información de la actividad en la cual se utilizará el equipo

        Capa_Datos.nombreActividad = txtNomActividad2.Text
        Capa_Datos.idLugar2 = cbLugar2.SelectedIndex
        Capa_Datos.fechaActividad = dtpFecha.Value
        Capa_Datos.horaInicio = cbHora.SelectedIndex
        Capa_Datos.minutoInicio = cbMinutos.SelectedIndex
        Capa_Datos.horaFinal = cbHora2.SelectedIndex
        Capa_Datos.minutoFinal = cbMinutos2.SelectedIndex

        'Información de la persona que solicita el equipo

        Capa_Datos.nomSolicitante = txtNombreSolicitante.Text
        Capa_Datos.unidad = cbUnidad.SelectedIndex
        Capa_Datos.telefono = mstxtTelefono.Text
        Capa_Datos.correo = txtCorreo.Text
        Capa_Datos.celular = mstxtCelular.Text

        Me.Hide()
        Form_SEquipo2.Show()
    End Sub

End Class