Imports System.Data.SqlClient

Public Module DatosUsuario
    Public Dusuario As String
    Public Dnombre As String
    Public Dapellido As String
    Public Dtipo As Integer
    Public Did As Integer

    Sub Main()
        Dnombre = ""
        Dapellido = ""
        Dusuario = ""
        Dtipo = 1
    End Sub

    Public Function ConseguirNombre(usuario As String) As String
        Using CN As New SqlConnection(My.Settings.Conexion)
            CN.Open()
            Using CMD As New SqlCommand("SELECT nombre FROM automatizacion.usuario WHERE email= '" & usuario & "'", CN)
                CMD.CommandType = CommandType.Text
                Dim n As String = (CMD.ExecuteScalar())
                CN.Close()
                Return n
            End Using
        End Using

    End Function

    Public Function ConseguirApellido(usuario As String) As String
        Using CN As New SqlConnection(My.Settings.Conexion)
            CN.Open()
            Using CMD As New SqlCommand("SELECT apellido FROM automatizacion.usuario WHERE email= '" & usuario & "'", CN)
                CMD.CommandType = CommandType.Text
                Dim n As String = (CMD.ExecuteScalar())
                CN.Close()
                Return n
            End Using
        End Using

    End Function

    Public Function ConseguirEmail(usuario As String) As String
        Using CN As New SqlConnection(My.Settings.Conexion)
            CN.Open()
            Using CMD As New SqlCommand("SELECT email FROM automatizacion.usuario WHERE email= '" & usuario & "'", CN)
                CMD.CommandType = CommandType.Text
                Dim n As String = (CMD.ExecuteScalar())
                CN.Close()
                Return n
            End Using
        End Using

    End Function

    Public Function ConseguirId(usuario As String) As Integer
        Using CN As New SqlConnection(My.Settings.Conexion)
            CN.Open()
            Using CMD As New SqlCommand("SELECT id FROM automatizacion.usuario WHERE email= '" & usuario & "'", CN)
                CMD.CommandType = CommandType.Text
                Dim valor As Int32 = Convert.ToInt32(CMD.ExecuteScalar())
                CN.Close()

                Return valor
            End Using
        End Using

    End Function

End Module
