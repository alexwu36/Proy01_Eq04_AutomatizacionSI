<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PantallaPrincipal_UAdmin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PantallaPrincipal_UAdmin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Volver = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn_Solicitud_Eventos = New System.Windows.Forms.Button()
        Me.btn_Inventario = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UI_Calendario1 = New Calendario.UI_Calendario()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbBienvenida = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Purple
        Me.Panel1.Controls.Add(Me.lbBienvenida)
        Me.Panel1.Controls.Add(Me.btn_Volver)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1622, 121)
        Me.Panel1.TabIndex = 5
        '
        'btn_Volver
        '
        Me.btn_Volver.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Volver.BackColor = System.Drawing.Color.White
        Me.btn_Volver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Volver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_Volver.ForeColor = System.Drawing.Color.Black
        Me.btn_Volver.Location = New System.Drawing.Point(1351, 27)
        Me.btn_Volver.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_Volver.Name = "btn_Volver"
        Me.btn_Volver.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_Volver.Size = New System.Drawing.Size(196, 54)
        Me.btn_Volver.TabIndex = 8
        Me.btn_Volver.Text = "Salir"
        Me.btn_Volver.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(168, 72)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(577, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = """Camino a la excelencia a través del mejoramiento continuo"""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(168, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(481, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Departamento de Protocolo, Ceremonial y Eventos"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(167, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(397, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Universidad Tecnológica de Panamá"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Purple
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(2, 835)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1622, 115)
        Me.Panel2.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(160, 115)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(391, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(735, 96)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = resources.GetString("Label7.Text")
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(237, 272)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(124, 100)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 28
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(237, 438)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(124, 104)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'btn_Solicitud_Eventos
        '
        Me.btn_Solicitud_Eventos.BackColor = System.Drawing.Color.LightGray
        Me.btn_Solicitud_Eventos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_Solicitud_Eventos.Location = New System.Drawing.Point(218, 423)
        Me.btn_Solicitud_Eventos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_Solicitud_Eventos.Name = "btn_Solicitud_Eventos"
        Me.btn_Solicitud_Eventos.Size = New System.Drawing.Size(606, 130)
        Me.btn_Solicitud_Eventos.TabIndex = 23
        Me.btn_Solicitud_Eventos.Text = "Lista de Solicitudes de Eventos"
        Me.btn_Solicitud_Eventos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Solicitud_Eventos.UseVisualStyleBackColor = False
        '
        'btn_Inventario
        '
        Me.btn_Inventario.BackColor = System.Drawing.Color.LightGray
        Me.btn_Inventario.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_Inventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_Inventario.Location = New System.Drawing.Point(218, 258)
        Me.btn_Inventario.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_Inventario.Name = "btn_Inventario"
        Me.btn_Inventario.Size = New System.Drawing.Size(606, 130)
        Me.btn_Inventario.TabIndex = 22
        Me.btn_Inventario.Text = "Inventario de Equipo"
        Me.btn_Inventario.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(169, 155)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 29)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "FORMULARIOS"
        '
        'UI_Calendario1
        '
        Me.UI_Calendario1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UI_Calendario1.BackColor = System.Drawing.Color.DarkGray
        Me.UI_Calendario1.ButtonCollapse = True
        Me.UI_Calendario1.ButtonDay = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UI_Calendario1.ButtonDayFont = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.UI_Calendario1.ButtonDownColor = System.Drawing.Color.WhiteSmoke
        Me.UI_Calendario1.ButtonOverColor = System.Drawing.Color.WhiteSmoke
        Me.UI_Calendario1.ButtonTextFormat = True
        Me.UI_Calendario1.DayFont = New System.Drawing.Font("Arial Rounded MT Bold", 65.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.UI_Calendario1.DayForeColor = System.Drawing.Color.BlueViolet
        Me.UI_Calendario1.DayFormat = Calendario.UI_Calendario.DiaLetra.Abbreviation
        Me.UI_Calendario1.DayMonthFollowForeColor = System.Drawing.Color.Gray
        Me.UI_Calendario1.DayMonthForeColor = System.Drawing.Color.DarkMagenta
        Me.UI_Calendario1.DayMonthPassedForeColor = System.Drawing.Color.Gray
        Me.UI_Calendario1.DaySemanaFont = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.UI_Calendario1.DaysForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UI_Calendario1.DayWeekForeColor = System.Drawing.Color.BlueViolet
        Me.UI_Calendario1.ElipceSize = 5
        Me.UI_Calendario1.HourFont = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.UI_Calendario1.Location = New System.Drawing.Point(988, 155)
        Me.UI_Calendario1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.UI_Calendario1.MonthFont = New System.Drawing.Font("Arial Rounded MT Bold", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.UI_Calendario1.MonthForeColor = System.Drawing.Color.BlueViolet
        Me.UI_Calendario1.MoveCalendar = True
        Me.UI_Calendario1.Name = "UI_Calendario1"
        Me.UI_Calendario1.PanelBottonBackColor = System.Drawing.Color.White
        Me.UI_Calendario1.PanelDateBackColor = System.Drawing.Color.White
        Me.UI_Calendario1.PanelDateHeight = 100
        Me.UI_Calendario1.PanelDayBackColor = System.Drawing.Color.White
        Me.UI_Calendario1.PanelLowerBackColor = System.Drawing.Color.White
        Me.UI_Calendario1.SemanaFont = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.UI_Calendario1.Size = New System.Drawing.Size(506, 612)
        Me.UI_Calendario1.TabIndex = 29
        Me.UI_Calendario1.Text = "UI_Calendario1"
        Me.UI_Calendario1.TimeForeColor = System.Drawing.Color.BlueViolet
        Me.UI_Calendario1.TitleBackColor = System.Drawing.Color.Purple
        Me.UI_Calendario1.TitleFont = New System.Drawing.Font("Arial Rounded MT Bold", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.UI_Calendario1.TitleForeColor = System.Drawing.Color.White
        Me.UI_Calendario1.TitleFormat = Calendario.UI_Calendario.TextHora.Text
        Me.UI_Calendario1.TitleHeight = 35
        Me.UI_Calendario1.TitleText = "Calendario de Eventos"
        Me.UI_Calendario1.TitleVisible = True
        Me.UI_Calendario1.YearFont = New System.Drawing.Font("Arial Rounded MT Bold", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.UI_Calendario1.YearForeColor = System.Drawing.Color.BlueViolet
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(237, 610)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(124, 104)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 31
        Me.PictureBox5.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGray
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(218, 595)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(606, 130)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Lista de Solicitudes de Equipos"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lbBienvenida
        '
        Me.lbBienvenida.AutoSize = True
        Me.lbBienvenida.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbBienvenida.ForeColor = System.Drawing.Color.White
        Me.lbBienvenida.Location = New System.Drawing.Point(1146, 41)
        Me.lbBienvenida.Name = "lbBienvenida"
        Me.lbBienvenida.Size = New System.Drawing.Size(72, 24)
        Me.lbBienvenida.TabIndex = 32
        Me.lbBienvenida.Text = "Label5"
        '
        'PantallaPrincipal_UAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.UI_Calendario1)
        Me.Controls.Add(Me.btn_Solicitud_Eventos)
        Me.Controls.Add(Me.btn_Inventario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "PantallaPrincipal_UAdmin"
        Me.Text = "PantallaPrincipal_UAdmin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Volver As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_Solicitud_Eventos As Button
    Friend WithEvents btn_Inventario As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents UI_Calendario1 As Calendario.UI_Calendario
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lbBienvenida As Label
End Class
