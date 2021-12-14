Imports System.Data.SqlClient
Public Class ExisteUsuario
    Public Shared Function Login(usuario As String, password As String, nop As Integer) As Boolean
        Dim oConexion As New SqlConnection(My.Settings.Conexion)
        Dim oDataAdapter As SqlDataAdapter
        Dim oDataSet As New DataSet
        Dim sSql As String
        Dim sw As Boolean

        Try
            sSql = "SELECT * FROM automatizacion.usuario WHERE email= '" & usuario & "' and password = '" & password & "'"
            oConexion.Open()
            oDataAdapter = New SqlDataAdapter(sSql, oConexion)
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "usuarios")
            If oDataSet.Tables("usuarios").Rows.Count() = 0 Then
                If nop = 2 Then
                    MessageBox.Show("Numero de Intentos Alcanzados. No puede ingresar al sistema", "Sistema")
                Else
                    MessageBox.Show("Usuario y/o password no validos", "Sistema")

                End If
                sw = False
            Else
                UsuarioActivo.idUser = oDataSet.Tables("usuarios")(0)(0)
                UsuarioActivo.firstName = oDataSet.Tables("usuarios")(0)(1)
                UsuarioActivo.lastName = oDataSet.Tables("usuarios")(0)(2)
                UsuarioActivo.email = oDataSet.Tables("usuarios")(0)(3)
                UsuarioActivo.password = oDataSet.Tables("usuarios")(0)(4)
                UsuarioActivo.type = oDataSet.Tables("usuarios")(0)(5)
                sw = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return (sw)
    End Function
End Class

