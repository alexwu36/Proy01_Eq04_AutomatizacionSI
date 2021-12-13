﻿Imports System.Data.SqlClient
Public Class funcionSQL


    Public Shared Function LISTARDATOS() As DataTable
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("
Select Estado, comentarios, nombreEvento as Evento, fechaEvento as Fecha, horaInicio as Desde, horaFinal as Hasta, observacion, tabla2.nombreLugar as Lugar, tabla3.nombreFacultad as Facultad, tabla4.nombre from automatizacion.solicitud as tabla1
INNER JOIN
automatizacion.lugar as tabla2
ON tabla1.idLugar=tabla2.idLugar
INNER JOIN
automatizacion.facultad as tabla3
ON tabla1.idFacultad=tabla3.idFacultad
INNER JOIN
automatizacion.usuario as tabla4
ON tabla1.idUsuario=tabla4.id", CN)
                Using TABLA As New DataTable
                    DA.Fill(TABLA)

                    Return TABLA
                End Using
            End Using
        End Using
    End Function

    Public Shared Sub CAMBIAR_COMENT(CODIGO As Integer, COMENTARIO As String)
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("Sp_Actualizar_Coment", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@CODIGO", CODIGO)
                CMD.Parameters.AddWithValue("@COMENTARIO", COMENTARIO)
                CN.Open()
                CMD.ExecuteNonQuery()
                CN.Close()
            End Using
        End Using
    End Sub

    Public Shared Sub RECHAZAR_COMENT(CODIGO As Integer, COMENTARIO As String)
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("Sp_Rechazar_Coment", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@CODIGO", CODIGO)
                CMD.Parameters.AddWithValue("@COMENTARIO", COMENTARIO)
                CN.Open()
                CMD.ExecuteNonQuery()
                CN.Close()
            End Using
        End Using
    End Sub

End Class

