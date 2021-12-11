Public Class Form_SEvento
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel3_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel3.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Panel3.VerticalScroll.Value = e.NewValue
        End If
    End Sub

    Private Sub btn_Regresar_Click(sender As Object, e As EventArgs) Handles btn_Regresar.Click
        Me.Hide()
        PantallaPrincipal_UGeneral.Show()
    End Sub

    Private Sub btn_Continuar_Click(sender As Object, e As EventArgs) Handles btn_Continuar.Click
        Me.Hide()
        Form_SEvento2.Show()
    End Sub

End Class