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

        Dim btn_aprobar As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        btn_aprobar.HeaderText = "Click Aqui"
        btn_aprobar.Name = "btn1"
        btn_aprobar.Text = "Aprobar"
        btn_aprobar.UseColumnTextForButtonValue = True
        DGV_Solicitud.Columns.Insert(0, btn_aprobar)

        Dim btn_rechazar As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        btn_rechazar.HeaderText = "Click Aqui"
        btn_rechazar.Name = "btn2"
        btn_rechazar.Text = "Rechazar"
        btn_rechazar.UseColumnTextForButtonValue = True
        DGV_Solicitud.Columns.Insert(1, btn_rechazar)

    End Sub

    Private Sub DGV_Solicitud_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Solicitud.CellContentClick
        Dim comentarios = txtComentarios.Text
        If e.ColumnIndex = 0 Then
            'MessageBox.Show("Le distes click al boton numero =  " + e.RowIndex.ToString())

            Dim confirmMsg = MessageBox.Show("Deseas Aprobar el evento?", "Aprobar", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then

                'FUNCION PARA COMENTARIOS
                Dim selectedrowindex = Convert.ToInt32(e.RowIndex.ToString()) + 4
                Dim id As Integer = selectedrowindex
                Capa_Datos.funcionSQL.CAMBIAR_COMENT(id, comentarios)
                comentarios = "Comentarios para el solicitante..."

                txtComentarios.Text = comentarios
            End If

        ElseIf e.ColumnIndex = 1 Then
            'MessageBox.Show("Le distes click al boton numero =  " + e.RowIndex.ToString())

            Dim confirmMsg = MessageBox.Show("Deseas Rechazar el evento?", "Rechazar", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then

                'FUNCION PARA COMENTARIOS
                Dim selectedrowindex = Convert.ToInt32(e.RowIndex.ToString()) + 4
                Dim id As Integer = selectedrowindex
                Capa_Datos.funcionSQL.RECHAZAR_COMENT(id, comentarios)
                comentarios = "Comentarios para el solicitante..."

                    txtComentarios.Text = comentarios
                End If
            End If
        Me.BindDataGrid()
    End Sub

    Private Sub DGV_Solicitud_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Solicitud.CellClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DGV_Solicitud.Rows(e.RowIndex)
            If row.Cells(2).Value.ToString = "Aprobado" Then
                txtEstado.BackColor = Color.Green
            Else
                txtEstado.BackColor = Color.Red
            End If
            txtEstado.Text = row.Cells(2).Value.ToString
            txtNombre.Text = row.Cells(4).Value.ToString
            txtFecha.Text = row.Cells(5).Value.ToString
            txtHora.Text = row.Cells(6).Value.ToString
            txtHoraFinal.Text = row.Cells(7).Value.ToString
            txtObservacion.Text = row.Cells(8).Value.ToString
            txtLugar.Text = row.Cells(9).Value.ToString
            txtFacultad.Text = row.Cells(10).Value.ToString
            txtSolicitante.Text = row.Cells(11).Value.ToString

        End If
    End Sub


End Class