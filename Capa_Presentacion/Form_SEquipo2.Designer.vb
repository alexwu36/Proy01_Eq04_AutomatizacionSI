<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_SEquipo2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_SEquipo2))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_Borrar = New System.Windows.Forms.Button()
        Me.btn_Regresar = New System.Windows.Forms.Button()
        Me.btn_Continuar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvInfoEquipo = New System.Windows.Forms.DataGridView()
        Me.bnt_ContinuarSE2 = New System.Windows.Forms.Button()
        Me.btn_BorrarSE2 = New System.Windows.Forms.Button()
        Me.btn_Regresar_SE2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvInfoEquipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(226, 3080)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(677, 25)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "FORMULARIO PARA LA SOLICITUD Y PRÉSTAMO DE EQUIPO"
        '
        'btn_Borrar
        '
        Me.btn_Borrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Borrar.BackColor = System.Drawing.Color.DarkMagenta
        Me.btn_Borrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_Borrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Borrar.Location = New System.Drawing.Point(524, 4369)
        Me.btn_Borrar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_Borrar.Name = "btn_Borrar"
        Me.btn_Borrar.Size = New System.Drawing.Size(194, 60)
        Me.btn_Borrar.TabIndex = 74
        Me.btn_Borrar.Text = "Borrar"
        Me.btn_Borrar.UseVisualStyleBackColor = False
        '
        'btn_Regresar
        '
        Me.btn_Regresar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Regresar.BackColor = System.Drawing.Color.DarkMagenta
        Me.btn_Regresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_Regresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Regresar.Location = New System.Drawing.Point(29, 4371)
        Me.btn_Regresar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_Regresar.Name = "btn_Regresar"
        Me.btn_Regresar.Size = New System.Drawing.Size(194, 60)
        Me.btn_Regresar.TabIndex = 72
        Me.btn_Regresar.Text = "Regresar"
        Me.btn_Regresar.UseVisualStyleBackColor = False
        '
        'btn_Continuar
        '
        Me.btn_Continuar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Continuar.BackColor = System.Drawing.Color.DarkMagenta
        Me.btn_Continuar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_Continuar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Continuar.Location = New System.Drawing.Point(988, 4371)
        Me.btn_Continuar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_Continuar.Name = "btn_Continuar"
        Me.btn_Continuar.Size = New System.Drawing.Size(194, 60)
        Me.btn_Continuar.TabIndex = 73
        Me.btn_Continuar.Text = "Continuar"
        Me.btn_Continuar.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.bnt_ContinuarSE2)
        Me.Panel3.Controls.Add(Me.btn_BorrarSE2)
        Me.Panel3.Controls.Add(Me.btn_Regresar_SE2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Location = New System.Drawing.Point(10, -2)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1382, 1244)
        Me.Panel3.TabIndex = 75
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.dgvInfoEquipo)
        Me.Panel5.Location = New System.Drawing.Point(74, 186)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1287, 757)
        Me.Panel5.TabIndex = 73
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(16, 20)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(283, 24)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "INFORMACIÓN DEL EQUIPO"
        '
        'dgvInfoEquipo
        '
        Me.dgvInfoEquipo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvInfoEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInfoEquipo.Location = New System.Drawing.Point(108, 68)
        Me.dgvInfoEquipo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgvInfoEquipo.Name = "dgvInfoEquipo"
        Me.dgvInfoEquipo.Size = New System.Drawing.Size(1078, 647)
        Me.dgvInfoEquipo.TabIndex = 50
        '
        'bnt_ContinuarSE2
        '
        Me.bnt_ContinuarSE2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bnt_ContinuarSE2.BackColor = System.Drawing.Color.DarkMagenta
        Me.bnt_ContinuarSE2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bnt_ContinuarSE2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bnt_ContinuarSE2.Location = New System.Drawing.Point(1104, 997)
        Me.bnt_ContinuarSE2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bnt_ContinuarSE2.Name = "bnt_ContinuarSE2"
        Me.bnt_ContinuarSE2.Size = New System.Drawing.Size(194, 60)
        Me.bnt_ContinuarSE2.TabIndex = 68
        Me.bnt_ContinuarSE2.Text = "Continuar"
        Me.bnt_ContinuarSE2.UseVisualStyleBackColor = False
        '
        'btn_BorrarSE2
        '
        Me.btn_BorrarSE2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_BorrarSE2.BackColor = System.Drawing.Color.DarkMagenta
        Me.btn_BorrarSE2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_BorrarSE2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_BorrarSE2.Location = New System.Drawing.Point(627, 997)
        Me.btn_BorrarSE2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_BorrarSE2.Name = "btn_BorrarSE2"
        Me.btn_BorrarSE2.Size = New System.Drawing.Size(194, 60)
        Me.btn_BorrarSE2.TabIndex = 70
        Me.btn_BorrarSE2.Text = "Borrar"
        Me.btn_BorrarSE2.UseVisualStyleBackColor = False
        '
        'btn_Regresar_SE2
        '
        Me.btn_Regresar_SE2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Regresar_SE2.BackColor = System.Drawing.Color.DarkMagenta
        Me.btn_Regresar_SE2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_Regresar_SE2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Regresar_SE2.Location = New System.Drawing.Point(145, 997)
        Me.btn_Regresar_SE2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_Regresar_SE2.Name = "btn_Regresar_SE2"
        Me.btn_Regresar_SE2.Size = New System.Drawing.Size(194, 60)
        Me.btn_Regresar_SE2.TabIndex = 4
        Me.btn_Regresar_SE2.Text = "Regresar"
        Me.btn_Regresar_SE2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(354, 135)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(677, 25)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "FORMULARIO PARA LA SOLICITUD Y PRÉSTAMO DE EQUIPO"
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.Purple
        Me.Panel6.Controls.Add(Me.PictureBox3)
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Location = New System.Drawing.Point(0, 1120)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1382, 121)
        Me.Panel6.TabIndex = 69
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(160, 115)
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
        Me.Label14.Location = New System.Drawing.Point(302, 5)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(735, 96)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = resources.GetString("Label14.Text")
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Purple
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(4, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1375, 121)
        Me.Panel1.TabIndex = 59
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(167, 9)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(397, 25)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Universidad Tecnológica de Panamá"
        '
        'Form_SEquipo2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1646, 959)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btn_Borrar)
        Me.Controls.Add(Me.btn_Regresar)
        Me.Controls.Add(Me.btn_Continuar)
        Me.Controls.Add(Me.Label4)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form_SEquipo2"
        Me.Text = "Form_SEquipo2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.dgvInfoEquipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents btn_Borrar As Button
    Friend WithEvents btn_Regresar As Button
    Friend WithEvents btn_Continuar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_BorrarSE2 As Button
    Friend WithEvents btn_Regresar_SE2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents bnt_ContinuarSE2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents dgvInfoEquipo As DataGridView
    Friend WithEvents Label6 As Label
End Class
