Imports System.Data.SqlClient
Public Class Registro
    Public Shared Function NuevoUsuario(nombre As String, apellido As String, email As String, pass As String, celular As String, tel As String)
        Dim oConexion As New SqlConnection(My.Settings.Conexion)
        Dim id As Integer

        Try
            Dim consulta As New SqlCommand("INSERT INTO automatizacion.usuario(nombre,apellido,email,password,tipoUsuario) values ('" & nombre & "', '" & apellido & "', '" & email & "', '" & pass & "', " & 1 & ")", oConexion)
            oConexion.Open()
            consulta.ExecuteNonQuery()

            id = DatosUsuario.ConseguirId(email)

            Dim consulta2 As New SqlCommand("INSERT INTO automatizacion.celular(celular, idUsuario) values ('" & celular & "', " & id & ")", oConexion)
            consulta2.ExecuteNonQuery()

            Dim consulta3 As New SqlCommand("INSERT INTO automatizacion.telefono(telefono, idUsuario) values ('" & tel & "', " & id & ")", oConexion)
            consulta3.ExecuteNonQuery()

            MessageBox.Show("Se ha registrado con éxito", "Mensaje")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Function

End Class
