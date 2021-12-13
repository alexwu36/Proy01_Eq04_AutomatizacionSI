Imports System.Data.SqlClient
Public Module SolicitudEventos
    Public nombreEvento As String
    Public fechaEvento, horaInicio2, horaFinal2, observacion2 As String
    Public idLugar2, idFacultad2, idActividad2, idUsuario2 As Integer

    Sub Main()
        nombreEvento = ""
        fechaEvento = ""
        horaInicio2 = ""
        horaFinal2 = ""
        observacion2 = ""
        idLugar = 0
        idFacultad = 0
        idActividad = 0
        idUsuario = 0
    End Sub

    Public Function InsertarEvento()
        Dim oConexion As New SqlConnection(My.Settings.Conexion)
        Try
            Dim consulta3 As New SqlCommand("INSERT INTO automatizacion.solicitud(nombreEvento,fechaEvento,horaInicio,horaFinal,observacion,idLugar,idFacultad,idActividad,idUsuario,Estado,comentarios)
            VALUES ('" & nombreEvento & "','" & fechaEvento & "','" & horaInicio2 & "','" & horaFinal2 & "','" & observacion2 & "'," & idLugar2 & "," & idFacultad2 & "," & idActividad2 & "," & Did & ",'Pendiente','Pendiente')", oConexion)
            consulta3.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Function
End Module
