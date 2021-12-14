<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_SEvento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_SEvento))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btn_Regresar = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_Continuar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpHoraFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbOtros = New System.Windows.Forms.RadioButton()
        Me.rbCongresos = New System.Windows.Forms.RadioButton()
        Me.rbInauguraciones = New System.Windows.Forms.RadioButton()
        Me.rbActos = New System.Windows.Forms.RadioButton()
        Me.rbSeminarios = New System.Windows.Forms.RadioButton()
        Me.rbFerias = New System.Windows.Forms.RadioButton()
        Me.rbConferencias = New System.Windows.Forms.RadioButton()
        Me.cbLugar = New System.Windows.Forms.ComboBox()
        Me.cbFacultad = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNomActividad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Purple
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(-5, 32767)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(734, 155)
        Me.Panel2.TabIndex = 8
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(183, 155)
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
        Me.Label7.Location = New System.Drawing.Point(-650, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(916, 120)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = resources.GetString("Label7.Text")
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.Controls.Add(Me.btn_Regresar)
        Me.Panel7.Controls.Add(Me.Panel6)
        Me.Panel7.Controls.Add(Me.btn_Continuar)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.Panel1)
        Me.Panel7.Controls.Add(Me.Panel4)
        Me.Panel7.Location = New System.Drawing.Point(-5, -3)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1409, 2091)
        Me.Panel7.TabIndex = 45
        '
        'btn_Regresar
        '
        Me.btn_Regresar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Regresar.BackColor = System.Drawing.Color.DarkMagenta
        Me.btn_Regresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_Regresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Regresar.Location = New System.Drawing.Point(80, 1265)
        Me.btn_Regresar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_Regresar.Name = "btn_Regresar"
        Me.btn_Regresar.Size = New System.Drawing.Size(221, 80)
        Me.btn_Regresar.TabIndex = 4
        Me.btn_Regresar.Text = "Regresar"
        Me.btn_Regresar.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.Purple
        Me.Panel6.Controls.Add(Me.PictureBox3)
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Location = New System.Drawing.Point(0, 1469)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1432, 163)
        Me.Panel6.TabIndex = 69
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(183, 155)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(271, 5)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(916, 120)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = resources.GetString("Label14.Text")
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Continuar
        '
        Me.btn_Continuar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Continuar.BackColor = System.Drawing.Color.DarkMagenta
        Me.btn_Continuar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_Continuar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Continuar.Location = New System.Drawing.Point(1176, 1264)
        Me.btn_Continuar.Margin = New System.Windows.Forms.Padding(5)
        Me.btn_Continuar.Name = "btn_Continuar"
        Me.btn_Continuar.Size = New System.Drawing.Size(221, 80)
        Me.btn_Continuar.TabIndex = 68
        Me.btn_Continuar.Text = "Continuar"
        Me.btn_Continuar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(449, 245)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(611, 31)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "FORMULARIO DE SOLICITUD DE EVENTOS"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Purple
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(5, 3)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1424, 163)
        Me.Panel1.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(192, 95)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(716, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = """Camino a la excelencia a través del mejoramiento continuo"""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(192, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(602, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Departamento de Protocolo, Ceremonial y Eventos"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 157)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(191, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(489, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Universidad Tecnológica de Panamá"
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Panel4.Controls.Add(Me.GroupBox2)
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Controls.Add(Me.cbLugar)
        Me.Panel4.Controls.Add(Me.cbFacultad)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.txtNomActividad)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel4.Location = New System.Drawing.Point(80, 301)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1317, 899)
        Me.Panel4.TabIndex = 67
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpHoraFinal)
        Me.GroupBox2.Controls.Add(Me.dtpHoraInicio)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(111, 373)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(621, 129)
        Me.GroupBox2.TabIndex = 103
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Periodo Cubierto"
        '
        'dtpHoraFinal
        '
        Me.dtpHoraFinal.Location = New System.Drawing.Point(341, 45)
        Me.dtpHoraFinal.Name = "dtpHoraFinal"
        Me.dtpHoraFinal.Size = New System.Drawing.Size(250, 30)
        Me.dtpHoraFinal.TabIndex = 102
        '
        'dtpHoraInicio
        '
        Me.dtpHoraInicio.Location = New System.Drawing.Point(53, 45)
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.Size = New System.Drawing.Size(250, 30)
        Me.dtpHoraInicio.TabIndex = 101
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(310, 51)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 25)
        Me.Label10.TabIndex = 86
        Me.Label10.Text = "a"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbOtros)
        Me.GroupBox1.Controls.Add(Me.rbCongresos)
        Me.GroupBox1.Controls.Add(Me.rbInauguraciones)
        Me.GroupBox1.Controls.Add(Me.rbActos)
        Me.GroupBox1.Controls.Add(Me.rbSeminarios)
        Me.GroupBox1.Controls.Add(Me.rbFerias)
        Me.GroupBox1.Controls.Add(Me.rbConferencias)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(105, 552)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(882, 260)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Actividad"
        '
        'rbOtros
        '
        Me.rbOtros.AutoSize = True
        Me.rbOtros.Location = New System.Drawing.Point(59, 201)
        Me.rbOtros.Name = "rbOtros"
        Me.rbOtros.Size = New System.Drawing.Size(81, 29)
        Me.rbOtros.TabIndex = 106
        Me.rbOtros.TabStop = True
        Me.rbOtros.Text = "Otros"
        Me.rbOtros.UseVisualStyleBackColor = True
        '
        'rbCongresos
        '
        Me.rbCongresos.AutoSize = True
        Me.rbCongresos.Location = New System.Drawing.Point(518, 139)
        Me.rbCongresos.Name = "rbCongresos"
        Me.rbCongresos.Size = New System.Drawing.Size(129, 29)
        Me.rbCongresos.TabIndex = 105
        Me.rbCongresos.TabStop = True
        Me.rbCongresos.Text = "Congresos"
        Me.rbCongresos.UseVisualStyleBackColor = True
        '
        'rbInauguraciones
        '
        Me.rbInauguraciones.AutoSize = True
        Me.rbInauguraciones.Location = New System.Drawing.Point(315, 139)
        Me.rbInauguraciones.Name = "rbInauguraciones"
        Me.rbInauguraciones.Size = New System.Drawing.Size(167, 29)
        Me.rbInauguraciones.TabIndex = 104
        Me.rbInauguraciones.TabStop = True
        Me.rbInauguraciones.Text = "Inauguraciones"
        Me.rbInauguraciones.UseVisualStyleBackColor = True
        '
        'rbActos
        '
        Me.rbActos.AutoSize = True
        Me.rbActos.Location = New System.Drawing.Point(59, 139)
        Me.rbActos.Name = "rbActos"
        Me.rbActos.Size = New System.Drawing.Size(176, 29)
        Me.rbActos.TabIndex = 3
        Me.rbActos.TabStop = True
        Me.rbActos.Text = "Actos Culturales"
        Me.rbActos.UseVisualStyleBackColor = True
        '
        'rbSeminarios
        '
        Me.rbSeminarios.AutoSize = True
        Me.rbSeminarios.Location = New System.Drawing.Point(518, 75)
        Me.rbSeminarios.Name = "rbSeminarios"
        Me.rbSeminarios.Size = New System.Drawing.Size(131, 29)
        Me.rbSeminarios.TabIndex = 2
        Me.rbSeminarios.TabStop = True
        Me.rbSeminarios.Text = "Seminarios"
        Me.rbSeminarios.UseVisualStyleBackColor = True
        '
        'rbFerias
        '
        Me.rbFerias.AutoSize = True
        Me.rbFerias.Location = New System.Drawing.Point(315, 75)
        Me.rbFerias.Name = "rbFerias"
        Me.rbFerias.Size = New System.Drawing.Size(87, 29)
        Me.rbFerias.TabIndex = 1
        Me.rbFerias.TabStop = True
        Me.rbFerias.Text = "Ferias"
        Me.rbFerias.UseVisualStyleBackColor = True
        '
        'rbConferencias
        '
        Me.rbConferencias.AutoSize = True
        Me.rbConferencias.Location = New System.Drawing.Point(59, 75)
        Me.rbConferencias.Name = "rbConferencias"
        Me.rbConferencias.Size = New System.Drawing.Size(149, 29)
        Me.rbConferencias.TabIndex = 0
        Me.rbConferencias.TabStop = True
        Me.rbConferencias.Text = "Conferencias"
        Me.rbConferencias.UseVisualStyleBackColor = True
        '
        'cbLugar
        '
        Me.cbLugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLugar.FormattingEnabled = True
        Me.cbLugar.Items.AddRange(New Object() {"Auditorio", "Lobby Edificio 3", "Lobby Edificio 1", "Piso FCT", "Piso FIC", "Piso FIEE", "Piso FII", "Piso FIM", "Piso FIM"})
        Me.cbLugar.Location = New System.Drawing.Point(511, 312)
        Me.cbLugar.Margin = New System.Windows.Forms.Padding(5)
        Me.cbLugar.Name = "cbLugar"
        Me.cbLugar.Size = New System.Drawing.Size(513, 33)
        Me.cbLugar.TabIndex = 96
        '
        'cbFacultad
        '
        Me.cbFacultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFacultad.FormattingEnabled = True
        Me.cbFacultad.Items.AddRange(New Object() {"Facultad de Ciencias y Tecnología (FCT)", "Facultad de Ingeniería Civil (FIC)", "Facultad de Ingeniería Eléctrica (FIE)", "Facultad de Ingeniería Industrial (FII)", "Facultad de Ingeniería Mecánica (FIM)", "Facultad de Ingeniería en Sistemas Computacionales (FISC)"})
        Me.cbFacultad.Location = New System.Drawing.Point(511, 232)
        Me.cbFacultad.Margin = New System.Windows.Forms.Padding(5)
        Me.cbFacultad.Name = "cbFacultad"
        Me.cbFacultad.Size = New System.Drawing.Size(625, 33)
        Me.cbFacultad.TabIndex = 82
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(105, 183)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(332, 25)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Nombre completo de la actividad:"
        '
        'txtNomActividad
        '
        Me.txtNomActividad.Location = New System.Drawing.Point(511, 173)
        Me.txtNomActividad.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNomActividad.Name = "txtNomActividad"
        Me.txtNomActividad.Size = New System.Drawing.Size(607, 30)
        Me.txtNomActividad.TabIndex = 78
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(111, 245)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(345, 25)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Facultad o unidad que lo organiza:"
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(111, 315)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(258, 25)
        Me.Label11.TabIndex = 87
        Me.Label11.Text = "Lugar donde se realizará:"
        '
        'Label18
        '
        Me.Label18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label18.Location = New System.Drawing.Point(53, 108)
        Me.Label18.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(1103, 25)
        Me.Label18.TabIndex = 76
        Me.Label18.Text = "Por este medio se presenta solicitud formal de los servicios detallados para el d" &
    "esarrollo de la siguiente actividad:"
        '
        'Label17
        '
        Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label17.Location = New System.Drawing.Point(59, 55)
        Me.Label17.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(362, 24)
        Me.Label17.TabIndex = 75
        Me.Label17.Text = "Director de Comunicación Estratégica"
        '
        'Label16
        '
        Me.Label16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(53, 21)
        Me.Label16.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(229, 29)
        Me.Label16.TabIndex = 74
        Me.Label16.Text = "Licdo. Danilo Toro"
        '
        'Form_SEvento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1904, 795)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form_SEvento"
        Me.Text = "Form_SEvento"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btn_Regresar As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btn_Continuar As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cbLugar As ComboBox
    Friend WithEvents cbFacultad As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNomActividad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpHoraFinal As DateTimePicker
    Friend WithEvents dtpHoraInicio As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbOtros As RadioButton
    Friend WithEvents rbCongresos As RadioButton
    Friend WithEvents rbInauguraciones As RadioButton
    Friend WithEvents rbActos As RadioButton
    Friend WithEvents rbSeminarios As RadioButton
    Friend WithEvents rbFerias As RadioButton
    Friend WithEvents rbConferencias As RadioButton
End Class
