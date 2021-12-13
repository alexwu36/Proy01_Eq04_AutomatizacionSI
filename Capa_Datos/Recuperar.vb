Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class Recuperar
    Public Shared Function ExisteCorreo(correo As String) As Boolean
        Dim oConexion As New SqlConnection(My.Settings.Conexion)
        Dim oDataAdapter As SqlDataAdapter
        Dim oDataSet As New DataSet
        Dim sSql As String
        Dim sw As Boolean

        Dim Smtp_Server As New SmtpClient
        Dim e_mail As New MailMessage

        Dim valor As Integer
        valor = 0
        valor = Int((9999 * Rnd()) + 1000)

        With Smtp_Server
            .Port = 587
            .Host = "smtp.gmail.com"
            .UseDefaultCredentials = False
            .Credentials = New Net.NetworkCredential("eventosfiscutp1@gmail.com", "eventosfisc")
            .EnableSsl = True
        End With

        With e_mail
            .From = New MailAddress("eventosfiscutp1@gmail.com")
            .To.Add(correo)
            .Subject = "Cambio de Contraseña"
            .Body = String.Format("<strong>Su código es:" & valor & "</strong>")
            .IsBodyHtml = True
            .Priority = MailPriority.High
        End With


        Try
            sSql = "SELECT * FROM automatizacion.usuario WHERE email = '" & correo & "'"
            oConexion.Open()
            oDataAdapter = New SqlDataAdapter(sSql, oConexion)
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "usuarios")
            If (oDataSet.Tables("usuarios").Rows.Count() = 0) Then
                sw = False
            Else
                sw = True
                Try
                    Dim consulta As New SqlCommand("UPDATE automatizacion.usuario SET hash = " & valor & " WHERE email = '" & correo & "'", oConexion)
                    consulta.ExecuteNonQuery()
                    Smtp_Server.Send(e_mail)
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Error al enviar correo", MessageBoxButtons.OK)
                End Try

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return (sw)

    End Function

    Public Shared Function VerificarCodigo(correo As String, codigo As String) As Boolean
        Dim oConexion As New SqlConnection(My.Settings.Conexion)
        Dim oDataAdapter As SqlDataAdapter
        Dim oDataSet As New DataSet
        Dim sSql As String
        Dim sw As Boolean
        codigo = CInt(codigo)
        Try
            sSql = "SELECT * FROM automatizacion.usuario WHERE email= '" & correo & "' and hash = " & codigo & ""
            oConexion.Open()
            oDataAdapter = New SqlDataAdapter(sSql, oConexion)
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "usuarios")
            If (oDataSet.Tables("usuarios").Rows.Count() = 0) Then
                sw = False
                MessageBox.Show("El codigo ingresado no es correcto", "Código Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                sw = True
                Dim consulta As New SqlCommand("UPDATE automatizacion.usuario SET hash = NULL WHERE email = '" & correo & "'", oConexion)
                consulta.ExecuteNonQuery()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return (sw)

    End Function

    Public Shared Function CambiarContrasena(correo As String, pass As String) As Boolean
        Dim oConexion As New SqlConnection(My.Settings.Conexion)
        Dim oDataAdapter As SqlDataAdapter
        Dim oDataSet As New DataSet
        Dim sSql As String
        Dim sw As Boolean

        Try
            sSql = "SELECT * FROM automatizacion.usuario WHERE email= '" & correo & "'"
            oConexion.Open()
            oDataAdapter = New SqlDataAdapter(sSql, oConexion)
            oDataSet.Clear()
            oDataAdapter.Fill(oDataSet, "usuarios")
            If (oDataSet.Tables("usuarios").Rows.Count() = 0) Then
                sw = False
                MessageBox.Show("Error al ingresar nueva contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                sw = True
                Dim consulta As New SqlCommand("UPDATE automatizacion.usuario SET password = '" & pass & "' WHERE email = '" & correo & "'", oConexion)
                consulta.ExecuteNonQuery()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return (sw)

    End Function
End Class