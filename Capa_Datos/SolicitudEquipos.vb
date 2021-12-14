Imports System.Data.SqlClient
Public Module SolicitudEquipos
    Public nomActividad2 As String
    Public fechaActividad, horaActividad, fechaRetiro, fechaDevolucion, observacion, comentarios As String
    Public idLugar, idFacultad, idUsuario As Integer

    Sub Main()

        'Form_SEquipo
        nomActividad2 = ""
        fechaActividad = ""
        horaActividad = ""
        fechaRetiro = ""
        fechaDevolucion = ""
        observacion = "Pendiente"
        comentarios = ""

        idLugar = 0
        idFacultad = 0
        idUsuario = 0

    End Sub


    Public Function InsertarEquipo()
        Dim oConexion As New SqlConnection(My.Settings.Conexion)
        Try
            Dim consulta3 As New SqlCommand("INSERT INTO automatizacion.orden(fechaActividad, horaActividad, fechaRetiro, fechaDevolucion, observacion, idLugar, idFacultad, nomActividad2, comentarios, idUsuario)
            VALUES ('" & fechaActividad & "','" & horaActividad & "','" & fechaRetiro & "','" & fechaDevolucion & "','" & observacion & "'," & idLugar & "," & idFacultad & ",'" & nomActividad2 & "','Pendiente'," & Did & ")", oConexion)

            oConexion.Open()

            consulta3.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Function

    Public Function ConseguirIdEquipo(evento As String) As Integer
        Using CN As New SqlConnection(My.Settings.Conexion)
            CN.Open()
            Using CMD As New SqlCommand("SELECT idOrden FROM automatizacion.orden WHERE nomActividad2= '" & evento & "'", CN)
                CMD.CommandType = CommandType.Text
                Dim valor As Int32 = Convert.ToInt32(CMD.ExecuteScalar())
                CN.Close()

                Return valor
            End Using
        End Using

    End Function

    Public Function InsertarOrdenE(equipo As Integer)
        Try
            Dim idO As Integer
            Dim oConexion As New SqlConnection(My.Settings.Conexion)
            idO = ConseguirIdEquipo(nomActividad2)


            Dim consulta3 As New SqlCommand("INSERT INTO automatizacion.orden_equipo(idOrden, idEquipo)
            VALUES (" & idO & "," & equipo & ")", oConexion)

            oConexion.Open()
            consulta3.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Function

End Module
