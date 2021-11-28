Imports System.Data.SqlClient
Public Class ExisteUsuario
    Public Shared Function ExisteUsuario(usuario As String, password As String, nop As Integer) As Boolean
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
            If (oDataSet.Tables("usuarios").Rows.Count() = 0) Then
                If nop = 2 Then
                    MessageBox.Show("Numero de Intentos Alcanzados. No puede ingresar al sistema", "Sistema")
                Else
                    MessageBox.Show("Usuario y/o password no validos", "Sistema")

                End If
                sw = False
            Else
                MessageBox.Show("Bienvenido al Sistema", "Sistema")
                sw = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return (sw)

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

