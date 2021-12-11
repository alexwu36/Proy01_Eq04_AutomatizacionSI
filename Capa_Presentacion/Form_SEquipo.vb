Public Class Form_SEquipo
    Private Sub btn_Regresar_Click(sender As Object, e As EventArgs) Handles btn_Regresar.Click
        Me.Hide()
        PantallaPrincipal_UGeneral.Show()
    End Sub

    Private Sub btn_Continuar_Click(sender As Object, e As EventArgs) Handles btn_Continuar.Click
        Me.Hide()
        Form_SEquipo2.Show()
    End Sub

End Class