Imports System.Data.SqlClient
Public Class Usuario
    Public Shared Function EstadoEvento() As DataTable
        Dim oConexion As New SqlConnection(My.Settings.Conexion)
        Dim oDataAdapter As SqlDataAdapter
        Dim oDataSet As New DataSet
        Dim sSql As String

        Dim solicitudes As New DataTable

        Try
            sSql = "SELECT nombreEvento, observacion FROM automatizacion.solicitud WHERE idUsuario = " & UsuarioActivo.idUser
            oConexion.Open()
            oDataAdapter = New SqlDataAdapter(sSql, oConexion)
            oDataSet.Clear()
            oDataAdapter.Fill(solicitudes)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return solicitudes
    End Function

    Public Shared Function EstadoEquipo() As DataTable
        Dim oConexion As New SqlConnection(My.Settings.Conexion)
        Dim oDataAdapter As SqlDataAdapter
        Dim oDataSet As New DataSet
        Dim sSql As String

        Dim solicitudes As New DataTable

        Try
            sSql = "SELECT nomActividad2, observacion FROM automatizacion.orden WHERE idUsuario = " & UsuarioActivo.idUser
            oConexion.Open()
            oDataAdapter = New SqlDataAdapter(sSql, oConexion)
            oDataSet.Clear()
            oDataAdapter.Fill(solicitudes)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return solicitudes
    End Function

End Class
