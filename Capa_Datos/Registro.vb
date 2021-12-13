Imports System.Data.SqlClient
Public Class Registro
    Public Shared Function NuevoUsuario(nombre As String, apellido As String, email As String, pass As String, celular As String, tel As String)
        Dim oConexion As New SqlConnection(My.Settings.Conexion)
        Try
            Dim consulta As New SqlCommand("INSERT INTO automatizacion.usuario(nombre,apellido,email,password,tipoUsuario) values ('" & nombre & "', '" & apellido & "', '" & email & "', '" & pass & "', " & 1 & ")", oConexion)
            oConexion.Open()
            consulta.ExecuteNonQuery()
            MessageBox.Show("Se ha registrado con éxito", "Mensaje")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Function

End Class
