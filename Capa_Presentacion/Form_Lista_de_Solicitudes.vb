Public Class Form_Lista_de_Solicitudes
    Private Sub btn_Regresar_Click(sender As Object, e As EventArgs) Handles btn_Regresar.Click
        Me.Hide()
        PantallaPrincipal_UAdmin.Show()
    End Sub

    Private Sub Form_Lista_de_Solicitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BindDataGrid()
    End Sub


    Private Sub BindDataGrid()

        DGV_Solicitud.Columns.Clear()
        DGV_Solicitud.DataSource = Nothing
        DGV_Solicitud.DataSource = Capa_Datos.funcionSQL.LISTARDATOS

        Dim btn As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        btn.HeaderText = "Click Aqui"
        btn.Name = "btn"
        btn.Text = "Aprobar"
        btn.UseColumnTextForButtonValue = True
        DGV_Solicitud.Columns.Insert(9, btn)

    End Sub

    Private Sub DGV_Solicitud_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Solicitud.CellContentClick
        Dim comentarios = txtComentarios.Text
        If e.ColumnIndex = 9 Then
            'MessageBox.Show("Le distes click al boton numero =  " + e.RowIndex.ToString())

            Dim confirmMsg = MessageBox.Show("Deseas Aprobar el evento?", "Aprobar", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then

                'FUNCION PARA COMENTARIOS
                Dim selectedrowindex = Convert.ToInt32(e.RowIndex.ToString()) + 1
                Dim id As Integer = selectedrowindex
                Capa_Datos.funcionSQL.CAMBIAR_COMENT(id, comentarios)
                comentarios = "Comentarios para el solicitante..."

                txtComentarios.Text = comentarios
            End If
        End If
        Me.BindDataGrid()
    End Sub

    Private Sub DGV_Solicitud_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Solicitud.CellClick

    End Sub
End Class