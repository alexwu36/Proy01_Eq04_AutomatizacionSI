Public Class Form_SEvento2
    Private Sub Form_SEvento2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim aux(,) As Integer
        Dim Filas, Cols As Integer
        Filas = -1
        Cols = Filas
        ReDim aux(Filas, Cols)
    End Sub

    Private Sub btn_Regresar_Click(sender As Object, e As EventArgs) Handles btn_Regresar.Click
        Me.Hide()
        Form_SEvento.Show()
    End Sub

    Private Sub btn_Continuar_Click(sender As Object, e As EventArgs) Handles btn_Continuar.Click
        Dim prensa() As Integer
        Dim i As Integer

        i = 0
        If ckbCobertura.Checked Then
            prensa(i) = 1
            i = i + 1
        ElseIf ckbFoto.Checked Then
            prensa(i) = 2
            i = i + 1
        ElseIf cbkFilmacion.Checked Then
            prensa(i) = 3
            i = i + 1
        ElseIf ckbDivulgacion.Checked Then
            prensa(i) = 4
            i = i + 1
        ElseIf ckbSonido.Checked Then
            prensa(i) = 5
            i = i + 1
        ElseIf ckbEntrevista.Checked Then
            prensa(i) = 6
            i = i + 1
        ElseIf ckbPublicar.Checked Then
            prensa(i) = 7
            i = i + 1
        ElseIf ckbVideoc.Checked Then
            prensa(i) = 8
            i = i + 1
        ElseIf cbkStreaming.Checked Then
            prensa(i) = 9
            i = i + 1
        End If

        Capa_Datos.observacion2 = txtObservacion.Text

        Me.Hide()
        Form_SEvento3.Show()
    End Sub

End Class