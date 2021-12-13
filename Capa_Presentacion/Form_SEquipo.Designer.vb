<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_SEquipo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_SEquipo))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.mstxtCelular = New System.Windows.Forms.MaskedTextBox()
        Me.mstxtTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.cbUnidad = New System.Windows.Forms.ComboBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtNombreSolicitante = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbMinutos = New System.Windows.Forms.ComboBox()
        Me.cbHora = New System.Windows.Forms.ComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNomActividad2 = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbFacultad = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbLugar2 = New System.Windows.Forms.ComboBox()
        Me.btn_Borrar = New System.Windows.Forms.Button()
        Me.btn_Regresar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_Continuar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbMinutos2 = New System.Windows.Forms.ComboBox()
        Me.cbHora2 = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.btn_Borrar)
        Me.Panel3.Controls.Add(Me.btn_Regresar)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.btn_Continuar)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Location = New System.Drawing.Point(0, -2)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1198, 1244)
        Me.Panel3.TabIndex = 46
        '
        'Panel7
        '
        Me.Panel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel7.BackColor = System.Drawing.Color.DimGray
        Me.Panel7.Controls.Add(Me.Label11)
        Me.Panel7.Location = New System.Drawing.Point(162, 572)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1023, 48)
        Me.Panel7.TabIndex = 125
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(16, 11)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(586, 24)
        Me.Label11.TabIndex = 113
        Me.Label11.Text = "INFORMACIÓN DE LA PERSONA QUE SOLICITA EL EQUIPO"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Panel2.Controls.Add(Me.mstxtCelular)
        Me.Panel2.Controls.Add(Me.mstxtTelefono)
        Me.Panel2.Controls.Add(Me.cbUnidad)
        Me.Panel2.Controls.Add(Me.txtCorreo)
        Me.Panel2.Controls.Add(Me.txtNombreSolicitante)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(162, 572)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1023, 351)
        Me.Panel2.TabIndex = 71
        '
        'mstxtCelular
        '
        Me.mstxtCelular.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mstxtCelular.Location = New System.Drawing.Point(325, 272)
        Me.mstxtCelular.Mask = "0000-0000"
        Me.mstxtCelular.Name = "mstxtCelular"
        Me.mstxtCelular.Size = New System.Drawing.Size(434, 29)
        Me.mstxtCelular.TabIndex = 124
        '
        'mstxtTelefono
        '
        Me.mstxtTelefono.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mstxtTelefono.Location = New System.Drawing.Point(325, 171)
        Me.mstxtTelefono.Mask = "000-0000"
        Me.mstxtTelefono.Name = "mstxtTelefono"
        Me.mstxtTelefono.Size = New System.Drawing.Size(434, 29)
        Me.mstxtTelefono.TabIndex = 123
        '
        'cbUnidad
        '
        Me.cbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbUnidad.FormattingEnabled = True
        Me.cbUnidad.Items.AddRange(New Object() {"Facultad de Ciencias y Tecnología (FCT)", "Facultad de Ingeniería Civíl (FIC)", "Facultad de Ingeniería Eléctrica (FIE)", "Facultad de Ingeniería Industrial (FII)", "Facultad de Ingeniería  Mecánica (FIM)", "Facultad de Ingeniería Sistemas Computacionales (FISC)"})
        Me.cbUnidad.Location = New System.Drawing.Point(325, 119)
        Me.cbUnidad.Name = "cbUnidad"
        Me.cbUnidad.Size = New System.Drawing.Size(434, 28)
        Me.cbUnidad.TabIndex = 102
        '
        'txtCorreo
        '
        Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCorreo.Location = New System.Drawing.Point(325, 218)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(434, 26)
        Me.txtCorreo.TabIndex = 121
        '
        'txtNombreSolicitante
        '
        Me.txtNombreSolicitante.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNombreSolicitante.Location = New System.Drawing.Point(325, 73)
        Me.txtNombreSolicitante.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreSolicitante.Name = "txtNombreSolicitante"
        Me.txtNombreSolicitante.Size = New System.Drawing.Size(434, 26)
        Me.txtNombreSolicitante.TabIndex = 119
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(90, 272)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 20)
        Me.Label16.TabIndex = 118
        Me.Label16.Text = "Celular:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(90, 221)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(163, 20)
        Me.Label15.TabIndex = 117
        Me.Label15.Text = "Correo Electrónico:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label17.Location = New System.Drawing.Point(90, 171)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 20)
        Me.Label17.TabIndex = 116
        Me.Label17.Text = "Teléfono:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(90, 122)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(181, 20)
        Me.Label13.TabIndex = 115
        Me.Label13.Text = "Unidad donde laborá:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(90, 76)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(195, 20)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "Nombre del Solicitante:"
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.txtNomActividad2)
        Me.Panel4.Controls.Add(Me.dtpFecha)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.cbFacultad)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.cbLugar2)
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel4.Location = New System.Drawing.Point(163, 184)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1022, 347)
        Me.Panel4.TabIndex = 67
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.cbMinutos2)
        Me.GroupBox1.Controls.Add(Me.cbHora2)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cbMinutos)
        Me.GroupBox1.Controls.Add(Me.cbHora)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(85, 269)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(846, 62)
        Me.GroupBox1.TabIndex = 103
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Periódo de la Actividad"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(214, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 24)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = ":"
        '
        'cbMinutos
        '
        Me.cbMinutos.AutoCompleteCustomSource.AddRange(New String() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10"})
        Me.cbMinutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMinutos.FormattingEnabled = True
        Me.cbMinutos.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.cbMinutos.Location = New System.Drawing.Point(239, 26)
        Me.cbMinutos.Margin = New System.Windows.Forms.Padding(4)
        Me.cbMinutos.Name = "cbMinutos"
        Me.cbMinutos.Size = New System.Drawing.Size(140, 28)
        Me.cbMinutos.TabIndex = 101
        '
        'cbHora
        '
        Me.cbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbHora.FormattingEnabled = True
        Me.cbHora.Items.AddRange(New Object() {"7", "8", "9", "10", "11", "12", "1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cbHora.Location = New System.Drawing.Point(58, 26)
        Me.cbHora.Margin = New System.Windows.Forms.Padding(4)
        Me.cbHora.Name = "cbHora"
        Me.cbHora.Size = New System.Drawing.Size(140, 28)
        Me.cbHora.TabIndex = 100
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel5.BackColor = System.Drawing.Color.DimGray
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1023, 45)
        Me.Panel5.TabIndex = 102
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(15, 10)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(714, 24)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "INFORMACIÓN DE LA ACTIVIDAD EN LA CUAL SE UTILIZARÁ EL EQUIPO"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(85, 82)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 20)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Nombre de la Actividad:"
        '
        'txtNomActividad2
        '
        Me.txtNomActividad2.Location = New System.Drawing.Point(399, 76)
        Me.txtNomActividad2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNomActividad2.Name = "txtNomActividad2"
        Me.txtNomActividad2.Size = New System.Drawing.Size(532, 26)
        Me.txtNomActividad2.TabIndex = 91
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(399, 177)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(532, 26)
        Me.dtpFecha.TabIndex = 93
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(85, 233)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(202, 20)
        Me.Label9.TabIndex = 98
        Me.Label9.Text = "Unidad que lo Organiza:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(85, 134)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(239, 20)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "Lugar donde se desarrollará:"
        '
        'cbFacultad
        '
        Me.cbFacultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFacultad.FormattingEnabled = True
        Me.cbFacultad.Items.AddRange(New Object() {"Facultad de Ciencias y Tecnología (FCT)", "Facultad de Ingeniería Civíl (FIC)", "Facultad de Ingeniería Eléctrica (FIE)", "Facultad de Ingeniería Industrial (FII)", "Facultad de Ingeniería  Mecánica (FIM)", "Facultad de Ingeniería Sistemas Computacionales (FISC)"})
        Me.cbFacultad.Location = New System.Drawing.Point(399, 225)
        Me.cbFacultad.Margin = New System.Windows.Forms.Padding(4)
        Me.cbFacultad.Name = "cbFacultad"
        Me.cbFacultad.Size = New System.Drawing.Size(532, 28)
        Me.cbFacultad.TabIndex = 97
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(85, 184)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(186, 20)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "Fecha de la Actividad:"
        '
        'cbLugar2
        '
        Me.cbLugar2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLugar2.FormattingEnabled = True
        Me.cbLugar2.Items.AddRange(New Object() {"Auditorio", "Lobby Edifico 3", "Lobby Edificio 1", "Piso FCT", "Piso FIC", "Piso FIE", "Piso FII", "Piso FIM", "Piso Fisc"})
        Me.cbLugar2.Location = New System.Drawing.Point(399, 125)
        Me.cbLugar2.Margin = New System.Windows.Forms.Padding(4)
        Me.cbLugar2.Name = "cbLugar2"
        Me.cbLugar2.Size = New System.Drawing.Size(532, 28)
        Me.cbLugar2.TabIndex = 96
        '
        'btn_Borrar
        '
        Me.btn_Borrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Borrar.BackColor = System.Drawing.Color.DarkMagenta
        Me.btn_Borrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_Borrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Borrar.Location = New System.Drawing.Point(607, 997)
        Me.btn_Borrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Borrar.Name = "btn_Borrar"
        Me.btn_Borrar.Size = New System.Drawing.Size(193, 60)
        Me.btn_Borrar.TabIndex = 70
        Me.btn_Borrar.Text = "Borrar"
        Me.btn_Borrar.UseVisualStyleBackColor = False
        '
        'btn_Regresar
        '
        Me.btn_Regresar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Regresar.BackColor = System.Drawing.Color.DarkMagenta
        Me.btn_Regresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_Regresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Regresar.Location = New System.Drawing.Point(163, 995)
        Me.btn_Regresar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Regresar.Name = "btn_Regresar"
        Me.btn_Regresar.Size = New System.Drawing.Size(193, 60)
        Me.btn_Regresar.TabIndex = 4
        Me.btn_Regresar.Text = "Regresar"
        Me.btn_Regresar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(322, 139)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(677, 25)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "FORMULARIO PARA LA SOLICITUD Y PRÉSTAMO DE EQUIPO"
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.Purple
        Me.Panel6.Controls.Add(Me.PictureBox3)
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Location = New System.Drawing.Point(0, 1120)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1419, 122)
        Me.Panel6.TabIndex = 69
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(160, 116)
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
        Me.Label14.Location = New System.Drawing.Point(409, 4)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(735, 96)
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
        Me.btn_Continuar.Location = New System.Drawing.Point(992, 1003)
        Me.btn_Continuar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Continuar.Name = "btn_Continuar"
        Me.btn_Continuar.Size = New System.Drawing.Size(193, 60)
        Me.btn_Continuar.TabIndex = 68
        Me.btn_Continuar.Text = "Continuar"
        Me.btn_Continuar.UseVisualStyleBackColor = False
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
        Me.Panel1.Location = New System.Drawing.Point(4, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1412, 122)
        Me.Panel1.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(168, 71)
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
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
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
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(414, 34)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(19, 20)
        Me.Label18.TabIndex = 103
        Me.Label18.Text = "a"
        '
        'cbMinutos2
        '
        Me.cbMinutos2.AutoCompleteCustomSource.AddRange(New String() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10"})
        Me.cbMinutos2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMinutos2.FormattingEnabled = True
        Me.cbMinutos2.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.cbMinutos2.Location = New System.Drawing.Point(651, 26)
        Me.cbMinutos2.Margin = New System.Windows.Forms.Padding(4)
        Me.cbMinutos2.Name = "cbMinutos2"
        Me.cbMinutos2.Size = New System.Drawing.Size(140, 28)
        Me.cbMinutos2.TabIndex = 105
        '
        'cbHora2
        '
        Me.cbHora2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbHora2.FormattingEnabled = True
        Me.cbHora2.Items.AddRange(New Object() {"7", "8", "9", "10", "11", "12", "1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cbHora2.Location = New System.Drawing.Point(462, 26)
        Me.cbHora2.Margin = New System.Windows.Forms.Padding(4)
        Me.cbHora2.Name = "cbHora2"
        Me.cbHora2.Size = New System.Drawing.Size(140, 28)
        Me.cbHora2.TabIndex = 104
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label19.Location = New System.Drawing.Point(620, 29)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(16, 24)
        Me.Label19.TabIndex = 106
        Me.Label19.Text = ":"
        '
        'Form_SEquipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1363, 791)
        Me.Controls.Add(Me.Panel3)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form_SEquipo"
        Me.Text = "Form_SEquipo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_Regresar As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btn_Continuar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btn_Borrar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtNombreSolicitante As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNomActividad2 As TextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbFacultad As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbLugar2 As ComboBox
    Friend WithEvents cbUnidad As ComboBox
    Friend WithEvents mstxtCelular As MaskedTextBox
    Friend WithEvents mstxtTelefono As MaskedTextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents cbMinutos As ComboBox
    Friend WithEvents cbHora As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cbMinutos2 As ComboBox
    Friend WithEvents cbHora2 As ComboBox
    Friend WithEvents Label18 As Label
End Class
