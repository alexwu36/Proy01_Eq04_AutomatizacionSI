Imports System.Data.SqlClient
Public Class Form_Inventario
    Private Sub btn_Regresar_Click(sender As Object, e As EventArgs) Handles btn_Regresar.Click
        Me.Hide()
        PantallaPrincipal_UAdmin.Show()
    End Sub

    Private Sub Form_Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvInventario.DataSource = Capa_Datos.Inventario.CargarInventario()
    End Sub
End Class