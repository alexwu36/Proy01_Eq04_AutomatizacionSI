Public Class Form_SEvento3
    Private Sub btn_Regresar_Click(sender As Object, e As EventArgs) Handles btn_Regresar.Click
        Me.Hide()
        Form_SEvento2.Show()
    End Sub

    Private Sub btn_Enviar_Click(sender As Object, e As EventArgs) Handles btn_Enviar.Click
        Me.Hide()
        PantallaPrincipal_UGeneral.Show()
    End Sub

    Sub Rellenar_Departamento(Departamento As String)

        Dim I As String = Form_SEvento.cbFacultad.SelectedIndex

        If I = "Facultad de Ingeniería en Sistemas Computacionales" Then
            cmbSeccion_departamento.Items.Add("Departamento de Programación")
            cmbSeccion_departamento.Items.Add("Departamento de Redes")
        End If



    End Sub

End Class