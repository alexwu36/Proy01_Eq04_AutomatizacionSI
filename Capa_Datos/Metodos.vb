Imports System.Data.SqlClient
Public Class Metodos
    Public Shared Function BUSCAREQUIPO()
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("select nombreEquipo as Equipo, cantDispo as Cantidad from automatizacion.equipo;", CN)
                CMD.CommandType = CommandType.Text
                Using DA As New SqlDataAdapter(CMD)
                    Using TABLA As New DataTable
                        DA.Fill(TABLA)

                        Return TABLA
                    End Using
                End Using
            End Using
        End Using

    End Function

    Public Shared Function TipoUsuario(usuario As String) As Integer
        Using CN As New SqlConnection(My.Settings.Conexion)
            CN.Open()
            Using CMD As New SqlCommand("SELECT TipoUsuario FROM automatizacion.usuario WHERE email= '" & usuario & "'", CN)
                CMD.CommandType = CommandType.Text
                Dim valor As Int32 = Convert.ToInt32(CMD.ExecuteScalar())
                CN.Close()

                Return valor
            End Using
        End Using

    End Function



End Class

