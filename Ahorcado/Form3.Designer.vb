<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.boton_min = New System.Windows.Forms.Button()
        Me.boton_cerrar = New System.Windows.Forms.Button()
        Me.boton_volver = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'boton_min
        '
        Me.boton_min.BackColor = System.Drawing.Color.Transparent
        Me.boton_min.BackgroundImage = Global.Ahorcado.My.Resources.Resources.Icono_Minimizar
        Me.boton_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.boton_min.FlatAppearance.BorderSize = 0
        Me.boton_min.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan
        Me.boton_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood
        Me.boton_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.boton_min.Location = New System.Drawing.Point(481, -1)
        Me.boton_min.Name = "boton_min"
        Me.boton_min.Size = New System.Drawing.Size(35, 35)
        Me.boton_min.TabIndex = 1
        Me.boton_min.UseVisualStyleBackColor = False
        '
        'boton_cerrar
        '
        Me.boton_cerrar.BackColor = System.Drawing.Color.Transparent
        Me.boton_cerrar.BackgroundImage = Global.Ahorcado.My.Resources.Resources.Icono_cerrar_FN
        Me.boton_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.boton_cerrar.FlatAppearance.BorderSize = 0
        Me.boton_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.boton_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.boton_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.boton_cerrar.Location = New System.Drawing.Point(516, -1)
        Me.boton_cerrar.Name = "boton_cerrar"
        Me.boton_cerrar.Size = New System.Drawing.Size(35, 35)
        Me.boton_cerrar.TabIndex = 0
        Me.boton_cerrar.UseVisualStyleBackColor = False
        '
        'boton_volver
        '
        Me.boton_volver.BackColor = System.Drawing.Color.Transparent
        Me.boton_volver.BackgroundImage = Global.Ahorcado.My.Resources.Resources._Exit
        Me.boton_volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.boton_volver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.boton_volver.Location = New System.Drawing.Point(12, 678)
        Me.boton_volver.Name = "boton_volver"
        Me.boton_volver.Size = New System.Drawing.Size(40, 40)
        Me.boton_volver.TabIndex = 2
        Me.boton_volver.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Tan
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(550, 1)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Tan
        Me.Panel2.Location = New System.Drawing.Point(0, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 730)
        Me.Panel2.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Tan
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 729)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(550, 1)
        Me.Panel3.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Tan
        Me.Panel4.Location = New System.Drawing.Point(549, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 730)
        Me.Panel4.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(68, 211)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(420, 286)
        Me.DataGridView1.TabIndex = 5
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Ahorcado.My.Resources.Resources.fondo_ranking
        Me.ClientSize = New System.Drawing.Size(550, 730)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.boton_volver)
        Me.Controls.Add(Me.boton_min)
        Me.Controls.Add(Me.boton_cerrar)
        Me.Font = New System.Drawing.Font("Berlin Sans FB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents boton_cerrar As Button
    Friend WithEvents boton_min As Button
    Friend WithEvents boton_volver As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridView1 As DataGridView
End Class
