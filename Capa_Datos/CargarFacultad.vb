﻿Imports System.Data.SqlClient

Public Module CargarFacultad
    Public Function CargarFacultad() As DataTable
        Dim oConexion As New SqlConnection(My.Settings.Conexion)
        Dim oDataAdapter As SqlDataAdapter
        Dim oDataSet As New DataSet
        Dim oDataTable As New DataTable
        Dim sSql As String

        Try
            sSql = "Select nombreFacultad from automatizacion.facultad"
            oConexion.Open()
            oDataAdapter = New SqlDataAdapter(sSql, oConexion)
            oDataSet.Clear()
            oDataAdapter.Fill(oDataTable)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return (oDataTable)

    End Function
End Module
