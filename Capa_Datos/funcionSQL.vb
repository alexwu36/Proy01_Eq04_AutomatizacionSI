Imports System.Data.SqlClient
Public Class funcionSQL


    Public Shared Function LISTARDATOS() As DataTable
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("
Select Estado, comentarios, nombreEvento as Evento, fechaEvento as Fecha, horaInicio as Desde, horaFinal as Hasta, observacion, tabla2.nombreLugar as Lugar, tabla3.nombreFacultad as Facultad, tabla4.nombre, tabla5.nombreActividad as Actividad from automatizacion.solicitud as tabla1
INNER JOIN
automatizacion.lugar as tabla2
ON tabla1.idLugar=tabla2.idLugar
INNER JOIN
automatizacion.facultad as tabla3
ON tabla1.idFacultad=tabla3.idFacultad
INNER JOIN
automatizacion.usuario as tabla4
ON tabla1.idUsuario=tabla4.id
INNER JOIN
automatizacion.actividad as tabla5
ON tabla1.idActividad=tabla5.idActividad", CN)
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





    Public Shared Function LISTARDATOSORDEN() As DataTable
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("
Select observacion as Estado, comentarios, nomActividad2 as Evento, fechaActividad as Fecha, horaActividad as Hora, fechaDevolucion as Fecha_de_Devolucion, tabla2.nombreLugar as Lugar, tabla3.nombreFacultad as Facultad, tabla4.nombre as Solicitante from automatizacion.orden as tabla1
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

    Public Shared Sub Aceptar_Orden_Estado(CODIGO As Integer, COMENTARIO As String)
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("Aceptar_Orden_Estado", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@CODIGO", CODIGO)
                CMD.Parameters.AddWithValue("@COMENTARIO", COMENTARIO)
                CN.Open()
                CMD.ExecuteNonQuery()
                CN.Close()
            End Using
        End Using
    End Sub

    Public Shared Sub Rechazar_Orden_Estado(CODIGO As Integer, COMENTARIO As String)
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("Rechazar_Orden_Estado", CN)
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

