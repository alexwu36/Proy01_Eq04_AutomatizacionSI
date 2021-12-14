Public Class Form_SEquipo2

    Private Sub btn_Regresar_SE2_Click(sender As Object, e As EventArgs) Handles btn_Regresar_SE2.Click
        Me.Hide()
        Form_SEquipo3.Show()
    End Sub

    Private Sub bnt_ContinuarSE2_Click(sender As Object, e As EventArgs) Handles bnt_ContinuarSE2.Click

        Try
            If ckbPantalla.Checked Then
                Capa_Datos.InsertarOrdenE(1)
            End If

            If ckbBanderas.Checked Then
                Capa_Datos.InsertarOrdenE(2)
            End If

            If ckbEstandarte.Checked Then
                Capa_Datos.InsertarOrdenE(3)
            End If

            If ckbAstas.Checked Then
                Capa_Datos.InsertarOrdenE(4)
            End If

            If ckbSoporte.Checked Then
                Capa_Datos.InsertarOrdenE(5)
            End If

            If ckbFlores.Checked Then
                Capa_Datos.InsertarOrdenE(6)
            End If

            If ckbHabladores.Checked Then
                Capa_Datos.InsertarOrdenE(7)
            End If

            If ckbGlobos.Checked Then
                Capa_Datos.InsertarOrdenE(8)
            End If

            If ckbTablero.Checked Then
                Capa_Datos.InsertarOrdenE(9)
            End If


            If ckbKaraoke.Checked Then
                Capa_Datos.InsertarOrdenE(10)
            End If

            If ckbRadio.Checked Then
                Capa_Datos.InsertarOrdenE(11)
            End If

            If ckbEngra.Checked Then
                Capa_Datos.InsertarOrdenE(12)
            End If

        Catch ex As Exception
            Me.Hide()
            Form_SEvento3.Show()
        End Try

        Me.Hide()
        PantallaPrincipal_UGeneral.Show()
    End Sub

    Private Sub Form_SEquipo2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

End Class