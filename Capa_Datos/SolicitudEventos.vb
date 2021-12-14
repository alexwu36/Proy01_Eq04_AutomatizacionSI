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

            oConexion.Open()

            consulta3.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Function

    Public Function ConseguirIdEvento(evento As String) As Integer
        Using CN As New SqlConnection(My.Settings.Conexion)
            CN.Open()
            Using CMD As New SqlCommand("SELECT idSolicitud FROM automatizacion.solicitud WHERE nombreEvento= '" & evento & "'", CN)
                CMD.CommandType = CommandType.Text
                Dim valor As Int32 = Convert.ToInt32(CMD.ExecuteScalar())
                CN.Close()

                Return valor
            End Using
        End Using

    End Function

    Public Function InsertarPrensa(prensa As Integer)
        Try
            Dim idS As Integer
            Dim oConexion As New SqlConnection(My.Settings.Conexion)
            idS = ConseguirIdEvento(nombreEvento)


            Dim consulta3 As New SqlCommand("INSERT INTO automatizacion.solicitud_prensa(idSolicitud, idPrensa)
            VALUES (" & idS & "," & prensa & ")", oConexion)

            oConexion.Open()
            consulta3.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Function

    Public Function InsertarDiseno(diseno As Integer)
        Try
            Dim idS As Integer
            Dim oConexion As New SqlConnection(My.Settings.Conexion)
            idS = ConseguirIdEvento(nombreEvento)


            Dim consulta3 As New SqlCommand("INSERT INTO automatizacion.solicitud_diseno(idSolicitud, idDiseno, tamano)
            VALUES (" & idS & "," & diseno & ", '1920x1080')", oConexion)

            oConexion.Open()
            consulta3.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Function
End Module
