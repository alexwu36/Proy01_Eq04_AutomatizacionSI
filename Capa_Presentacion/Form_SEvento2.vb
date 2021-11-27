Public Class Form_SEvento2
    Private Sub Form_SEvento2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim aux(,) As Integer
        Dim Filas, Cols As Integer
        Filas = -1
        Cols = Filas
        ReDim aux(Filas, Cols)
        dgvServicios_Diseño_Grafico.RowCount = Filas + 2
        'dgvServicios_Diseño_Grafico.ColumnCount = Cols + 1
        dgvServicios_Diseño_Grafico.Rows(Cols + 1).Cells(0).Value = "1."
        dgvServicios_Diseño_Grafico.Rows(Filas + 1).Cells(1).Value = "Afiche Full Color"
        dgvServicios_Diseño_Grafico.Rows(Filas + 1).Cells(2).Value = CheckBox10
        If CheckBox10.CheckState = CheckState.Checked Then CheckBox10.CheckState = CheckState.Unchecked
        dgvServicios_Diseño_Grafico.Rows(Filas + 1).Cells(1).Value = "2."
    End Sub

    Private Sub btn_Regresar_Click(sender As Object, e As EventArgs) Handles btn_Regresar.Click
        Me.Hide()
        Form_SEvento.Show()
    End Sub

    Private Sub btn_Continuar_Click(sender As Object, e As EventArgs) Handles btn_Continuar.Click
        Me.Hide()
        Form_SEvento3.Show()
    End Sub

End Class