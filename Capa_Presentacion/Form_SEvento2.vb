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
        Dim prensa(8) As Integer
        Dim diseno(9) As Integer
        Dim i, j As Integer

        Capa_Datos.observacion2 = txtObservacion.Text
        Capa_Datos.SolicitudEventos.InsertarEvento()

        Try
            If ckbCobertura.Checked Then
                Capa_Datos.InsertarPrensa(1)
            End If

            If ckbFoto.Checked Then
                Capa_Datos.InsertarPrensa(2)
            End If

            If cbkFilmacion.Checked Then
                Capa_Datos.InsertarPrensa(3)
            End If

            If ckbDivulgacion.Checked Then
                Capa_Datos.InsertarPrensa(4)
            End If

            If ckbSonido.Checked Then
                Capa_Datos.InsertarPrensa(5)
            End If

            If ckbEntrevista.Checked Then
                Capa_Datos.InsertarPrensa(6)
            End If

            If ckbPublicar.Checked Then
                Capa_Datos.InsertarPrensa(7)
            End If

            If ckbVideoc.Checked Then
                Capa_Datos.InsertarPrensa(8)
            End If

            If cbkStreaming.Checked Then
                Capa_Datos.InsertarPrensa(9)
            End If


            If ckbAfiche.Checked Then
                Capa_Datos.InsertarDiseno(1)
            End If

            If ckbAficheW.Checked Then
                Capa_Datos.InsertarDiseno(2)
            End If

            If ckbBrochure.Checked Then
                Capa_Datos.InsertarDiseno(3)
            End If

            If ckbVolante.Checked Then
                Capa_Datos.InsertarDiseno(4)
            End If

            If ckbPagPrensa.Checked Then
                Capa_Datos.InsertarDiseno(5)
            End If
            If ckbSeparadores.Checked Then
                Capa_Datos.InsertarDiseno(6)
            End If

            If ckbLogos.Checked Then
                Capa_Datos.InsertarDiseno(7)
            End If

            If ckbTarjetas.Checked Then
                Capa_Datos.InsertarDiseno(8)
            End If

            If ckbCertificados.Checked Then
                Capa_Datos.InsertarDiseno(9)
            End If

            If ckbBoletines.Checked Then
                Capa_Datos.InsertarDiseno(10)
            End If

        Catch ex As Exception
            Me.Hide()
            Form_SEvento3.Show()
        End Try

        Me.Hide()
        Form_SEvento3.Show()
    End Sub

End Class