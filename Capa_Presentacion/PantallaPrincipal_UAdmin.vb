﻿Imports Calendario

Public Class PantallaPrincipal_UAdmin
    Private Sub btn_Inventario_Click(sender As Object, e As EventArgs) Handles btn_Inventario.Click
        Me.Hide()
        Form_Inventario.Show()
    End Sub

    Private Sub btn_Volver_Click(sender As Object, e As EventArgs) Handles btn_Volver.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btn_Solicitud_Eventos_Click(sender As Object, e As EventArgs) Handles btn_Solicitud_Eventos.Click
        Me.Hide()
        Form_Lista_de_Solicitudes.Show()
    End Sub
End Class