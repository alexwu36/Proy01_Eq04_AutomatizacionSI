<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PantallaPrincipal_UGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PantallaPrincipal_UGeneral))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_Form_SEvento = New System.Windows.Forms.Button()
        Me.btn_FormSEquipo = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btn_Estado_Solicitud = New System.Windows.Forms.Button()
        Me.UI_Calendario1 = New Calendario.UI_Calendario()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Purple
        Me.Panel1.Controls.Add(Me.btn_Salir)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1390, 105)
        Me.Panel1.TabIndex = 4
        '
        'btn_Salir
        '
        Me.btn_Salir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_Salir.BackColor = System.Drawing.Color.White
        Me.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Salir.ForeColor = System.Drawing.Color.Black
        Me.btn_Salir.Location = New System.Drawing.Point(1176, 23)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_Salir.Size = New System.Drawing.Size(168, 47)
        Me.btn_Salir.TabIndex = 8
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(144, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(577, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = """Camino a la excelencia a través del mejoramiento continuo"""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(144, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(481, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Departamento de Protocolo, Ceremonial y Eventos"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proy01_Eq04_AutomatizacionSI.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(137, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(143, 8)
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
        Me.Panel2.Location = New System.Drawing.Point(2, 724)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1390, 100)
        Me.Panel2.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Proy01_Eq04_AutomatizacionSI.My.Resources.Resources.logo_footer
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(137, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(335, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(736, 96)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = resources.GetString("Label7.Text")
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(144, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(225, 31)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "FORMULARIOS"
        '
        'btn_Form_SEvento
        '
        Me.btn_Form_SEvento.BackColor = System.Drawing.Color.LightGray
        Me.btn_Form_SEvento.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_Form_SEvento.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Form_SEvento.Location = New System.Drawing.Point(194, 221)
        Me.btn_Form_SEvento.Name = "btn_Form_SEvento"
        Me.btn_Form_SEvento.Size = New System.Drawing.Size(515, 113)
        Me.btn_Form_SEvento.TabIndex = 9
        Me.btn_Form_SEvento.Text = "Formulario de Solicitud de Eventos"
        Me.btn_Form_SEvento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Form_SEvento.UseVisualStyleBackColor = False
        '
        'btn_FormSEquipo
        '
        Me.btn_FormSEquipo.BackColor = System.Drawing.Color.LightGray
        Me.btn_FormSEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_FormSEquipo.Location = New System.Drawing.Point(194, 393)
        Me.btn_FormSEquipo.Name = "btn_FormSEquipo"
        Me.btn_FormSEquipo.Size = New System.Drawing.Size(515, 113)
        Me.btn_FormSEquipo.TabIndex = 10
        Me.btn_FormSEquipo.Text = "Formulario de Solicitud de Equipos"
        Me.btn_FormSEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_FormSEquipo.UseVisualStyleBackColor = False
        '
        'btn_Estado_Solicitud
        '
        Me.btn_Estado_Solicitud.BackColor = System.Drawing.Color.LightGray
        Me.btn_Estado_Solicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Estado_Solicitud.Location = New System.Drawing.Point(194, 567)
        Me.btn_Estado_Solicitud.Name = "btn_Estado_Solicitud"
        Me.btn_Estado_Solicitud.Size = New System.Drawing.Size(515, 113)
        Me.btn_Estado_Solicitud.TabIndex = 17
        Me.btn_Estado_Solicitud.Text = "Estado de la Solicitud"
        Me.btn_Estado_Solicitud.UseVisualStyleBackColor = False
        '
        'UI_Calendario1
        '
        Me.UI_Calendario1.Anchor = System.Windows.Forms.AnchorStyles.Top
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
        Me.UI_Calendario1.Location = New System.Drawing.Point(829, 128)
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
        Me.UI_Calendario1.Size = New System.Drawing.Size(454, 575)
        Me.UI_Calendario1.TabIndex = 21
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
        Me.PictureBox5.Image = Global.Proy01_Eq04_AutomatizacionSI.My.Resources.Resources.reloj
        Me.PictureBox5.Location = New System.Drawing.Point(212, 580)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(106, 85)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 20
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox4.Image = Global.Proy01_Eq04_AutomatizacionSI.My.Resources.Resources.formulario1
        Me.PictureBox4.Location = New System.Drawing.Point(212, 405)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(106, 87)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 19
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox3.Image = Global.Proy01_Eq04_AutomatizacionSI.My.Resources.Resources.caja1
        Me.PictureBox3.Location = New System.Drawing.Point(212, 233)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(106, 87)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 29
        Me.PictureBox3.TabStop = False
        '
        'PantallaPrincipal_UGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1392, 824)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.UI_Calendario1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.btn_Estado_Solicitud)
        Me.Controls.Add(Me.btn_FormSEquipo)
        Me.Controls.Add(Me.btn_Form_SEvento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PantallaPrincipal_UGeneral"
        Me.Text = "PantallaPrincipal_UGeneral"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Salir As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_Form_SEvento As Button
    Friend WithEvents btn_FormSEquipo As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_Estado_Solicitud As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents UI_Calendario1 As Calendario.UI_Calendario
    Friend WithEvents PictureBox3 As PictureBox
End Class
