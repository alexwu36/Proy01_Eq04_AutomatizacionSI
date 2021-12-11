Public Class Login
    Public nop As Integer = 0
    ''' <summary>
    ''' el variable nop sirve para verificar la cantidad de intentos login
    ''' </summary>

    Private Sub btn_Registrarse_Click(sender As Object, e As EventArgs) Handles btn_Registrarse.Click
        Me.Hide()
        frmRegistro.Show()
    End Sub

    Private Sub btn_Olvidar_Contraseña_Click(sender As Object, e As EventArgs) Handles btn_Olvidar_Contraseña.Click
        Me.Hide()
        RecuperarContraseña.Show()
    End Sub

    Private Sub txtRegistrate_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmRegistro.Show()
    End Sub

    Private Sub btn_Iniciar_Sesion_Click(sender As Object, e As EventArgs) Handles btn_Iniciar_Sesion.Click
        Dim tipo As Integer

        If (Capa_Datos.ExisteUsuario.ExisteUsuario(txtCorreo.Text, txtPassword.Text, nop)) Then
            tipo = Capa_Datos.ExisteUsuario.TipoUsuario(txtCorreo.Text)

            If (tipo = 2) Then
                MessageBox.Show("Bienvenido al Sistema, su tipo de usuario es= " & tipo, "Sistema")
                Me.Hide()
                PantallaPrincipal_UAdmin.Show()
                nop = 0
            ElseIf (tipo = 1) Then
                MessageBox.Show("Bienvenido al Sistema, su tipo de usuario es= " & tipo, "Sistema")
                Me.Hide()
                PantallaPrincipal_UGeneral.Show()
                nop = 0
            Else
                Me.Close()
            End If

        ElseIf (nop >= 0 And nop <= 1) Then
            nop = nop + 1
            txtCorreo.Text = ""
            txtPassword.Text = ""
            txtCorreo.Focus()
        Else
            Me.Close()
        End If

    End Sub

    Private Sub btn_Iniciar_Sesion_Admin_Click(sender As Object, e As EventArgs)
        Me.Hide()
        PantallaPrincipal_UAdmin.Show()
    End Sub


    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles txtCorreo.Enter
        If (txtCorreo.Text = "Correo") Then
            txtCorreo.Text = ""
            txtCorreo.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles txtCorreo.Leave
        If (txtCorreo.Text = "") Then
            txtCorreo.Text = "Correo"
            txtCorreo.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If (txtPassword.Text = "Contraseña") Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If (txtPassword.Text = "") Then
            txtPassword.Text = "Contraseña"
            txtPassword.ForeColor = Color.Silver
        End If
    End Sub

End Class
