<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fConsulta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.bVolverConsulta = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbGrupo = New System.Windows.Forms.ComboBox()
        Me.tbPLMN = New System.Windows.Forms.TextBox()
        Me.tbMNC = New System.Windows.Forms.TextBox()
        Me.tbMCC = New System.Windows.Forms.TextBox()
        Me.cbPais = New System.Windows.Forms.ComboBox()
        Me.rbGrupo = New System.Windows.Forms.RadioButton()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.rbPLMN = New System.Windows.Forms.RadioButton()
        Me.rbMNC = New System.Windows.Forms.RadioButton()
        Me.rbPais = New System.Windows.Forms.RadioButton()
        Me.dgbOperadoresPais = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvArgemtinaInbound = New System.Windows.Forms.DataGridView()
        Me.dgvUruguayInbound = New System.Windows.Forms.DataGridView()
        Me.dgvParaguayInbound = New System.Windows.Forms.DataGridView()
        Me.dgvParaguayOutbound = New System.Windows.Forms.DataGridView()
        Me.dgvUruguayOutbound = New System.Windows.Forms.DataGridView()
        Me.dgvArgentinaOutbound = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lIOT = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgbOperadoresPais, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvArgemtinaInbound, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUruguayInbound, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvParaguayInbound, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvParaguayOutbound, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUruguayOutbound, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvArgentinaOutbound, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bVolverConsulta
        '
        Me.bVolverConsulta.Location = New System.Drawing.Point(992, 698)
        Me.bVolverConsulta.Name = "bVolverConsulta"
        Me.bVolverConsulta.Size = New System.Drawing.Size(76, 29)
        Me.bVolverConsulta.TabIndex = 0
        Me.bVolverConsulta.Text = "Volver"
        Me.bVolverConsulta.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbGrupo)
        Me.GroupBox1.Controls.Add(Me.tbPLMN)
        Me.GroupBox1.Controls.Add(Me.tbMNC)
        Me.GroupBox1.Controls.Add(Me.tbMCC)
        Me.GroupBox1.Controls.Add(Me.cbPais)
        Me.GroupBox1.Controls.Add(Me.rbGrupo)
        Me.GroupBox1.Controls.Add(Me.bBuscar)
        Me.GroupBox1.Controls.Add(Me.rbPLMN)
        Me.GroupBox1.Controls.Add(Me.rbMNC)
        Me.GroupBox1.Controls.Add(Me.rbPais)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(658, 97)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Busqueda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(253, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Vacio para todos los operadores del MCC"
        '
        'cbGrupo
        '
        Me.cbGrupo.FormattingEnabled = True
        Me.cbGrupo.Location = New System.Drawing.Point(411, 51)
        Me.cbGrupo.Name = "cbGrupo"
        Me.cbGrupo.Size = New System.Drawing.Size(121, 21)
        Me.cbGrupo.TabIndex = 9
        '
        'tbPLMN
        '
        Me.tbPLMN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbPLMN.Location = New System.Drawing.Point(319, 53)
        Me.tbPLMN.MaxLength = 5
        Me.tbPLMN.Name = "tbPLMN"
        Me.tbPLMN.Size = New System.Drawing.Size(77, 20)
        Me.tbPLMN.TabIndex = 8
        '
        'tbMNC
        '
        Me.tbMNC.Location = New System.Drawing.Point(253, 53)
        Me.tbMNC.MaxLength = 3
        Me.tbMNC.Name = "tbMNC"
        Me.tbMNC.Size = New System.Drawing.Size(49, 20)
        Me.tbMNC.TabIndex = 7
        '
        'tbMCC
        '
        Me.tbMCC.Location = New System.Drawing.Point(198, 53)
        Me.tbMCC.MaxLength = 3
        Me.tbMCC.Name = "tbMCC"
        Me.tbMCC.Size = New System.Drawing.Size(49, 20)
        Me.tbMCC.TabIndex = 6
        '
        'cbPais
        '
        Me.cbPais.FormattingEnabled = True
        Me.cbPais.Location = New System.Drawing.Point(104, 53)
        Me.cbPais.Name = "cbPais"
        Me.cbPais.Size = New System.Drawing.Size(121, 21)
        Me.cbPais.TabIndex = 5
        '
        'rbGrupo
        '
        Me.rbGrupo.AutoSize = True
        Me.rbGrupo.Location = New System.Drawing.Point(411, 20)
        Me.rbGrupo.Name = "rbGrupo"
        Me.rbGrupo.Size = New System.Drawing.Size(54, 17)
        Me.rbGrupo.TabIndex = 4
        Me.rbGrupo.TabStop = True
        Me.rbGrupo.Text = "Grupo"
        Me.rbGrupo.UseVisualStyleBackColor = True
        '
        'bBuscar
        '
        Me.bBuscar.Location = New System.Drawing.Point(556, 10)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(96, 34)
        Me.bBuscar.TabIndex = 3
        Me.bBuscar.Text = "Buscar"
        Me.bBuscar.UseVisualStyleBackColor = True
        '
        'rbPLMN
        '
        Me.rbPLMN.AutoSize = True
        Me.rbPLMN.Location = New System.Drawing.Point(319, 19)
        Me.rbPLMN.Name = "rbPLMN"
        Me.rbPLMN.Size = New System.Drawing.Size(55, 17)
        Me.rbPLMN.TabIndex = 2
        Me.rbPLMN.TabStop = True
        Me.rbPLMN.Text = "PLMN"
        Me.rbPLMN.UseVisualStyleBackColor = True
        '
        'rbMNC
        '
        Me.rbMNC.AutoSize = True
        Me.rbMNC.Location = New System.Drawing.Point(198, 19)
        Me.rbMNC.Name = "rbMNC"
        Me.rbMNC.Size = New System.Drawing.Size(75, 17)
        Me.rbMNC.TabIndex = 1
        Me.rbMNC.TabStop = True
        Me.rbMNC.Text = "MCC-MNC"
        Me.rbMNC.UseVisualStyleBackColor = True
        '
        'rbPais
        '
        Me.rbPais.AutoSize = True
        Me.rbPais.Location = New System.Drawing.Point(104, 19)
        Me.rbPais.Name = "rbPais"
        Me.rbPais.Size = New System.Drawing.Size(45, 17)
        Me.rbPais.TabIndex = 0
        Me.rbPais.TabStop = True
        Me.rbPais.Text = "Pais"
        Me.rbPais.UseVisualStyleBackColor = True
        '
        'dgbOperadoresPais
        '
        Me.dgbOperadoresPais.AllowUserToAddRows = False
        Me.dgbOperadoresPais.AllowUserToDeleteRows = False
        Me.dgbOperadoresPais.AllowUserToResizeColumns = False
        Me.dgbOperadoresPais.AllowUserToResizeRows = False
        Me.dgbOperadoresPais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgbOperadoresPais.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgbOperadoresPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbOperadoresPais.Location = New System.Drawing.Point(13, 148)
        Me.dgbOperadoresPais.MultiSelect = False
        Me.dgbOperadoresPais.Name = "dgbOperadoresPais"
        Me.dgbOperadoresPais.ReadOnly = True
        Me.dgbOperadoresPais.RowHeadersVisible = False
        Me.dgbOperadoresPais.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgbOperadoresPais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgbOperadoresPais.ShowEditingIcon = False
        Me.dgbOperadoresPais.Size = New System.Drawing.Size(658, 150)
        Me.dgbOperadoresPais.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Operadores en el Pais"
        '
        'dgvArgemtinaInbound
        '
        Me.dgvArgemtinaInbound.AllowUserToAddRows = False
        Me.dgvArgemtinaInbound.AllowUserToDeleteRows = False
        Me.dgvArgemtinaInbound.AllowUserToResizeColumns = False
        Me.dgvArgemtinaInbound.AllowUserToResizeRows = False
        Me.dgvArgemtinaInbound.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvArgemtinaInbound.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvArgemtinaInbound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArgemtinaInbound.Enabled = False
        Me.dgvArgemtinaInbound.Location = New System.Drawing.Point(105, 346)
        Me.dgvArgemtinaInbound.MultiSelect = False
        Me.dgvArgemtinaInbound.Name = "dgvArgemtinaInbound"
        Me.dgvArgemtinaInbound.ReadOnly = True
        Me.dgvArgemtinaInbound.RowHeadersVisible = False
        Me.dgvArgemtinaInbound.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgvArgemtinaInbound.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvArgemtinaInbound.ShowEditingIcon = False
        Me.dgvArgemtinaInbound.Size = New System.Drawing.Size(187, 156)
        Me.dgvArgemtinaInbound.TabIndex = 4
        '
        'dgvUruguayInbound
        '
        Me.dgvUruguayInbound.AllowUserToAddRows = False
        Me.dgvUruguayInbound.AllowUserToDeleteRows = False
        Me.dgvUruguayInbound.AllowUserToResizeColumns = False
        Me.dgvUruguayInbound.AllowUserToResizeRows = False
        Me.dgvUruguayInbound.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvUruguayInbound.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvUruguayInbound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUruguayInbound.Enabled = False
        Me.dgvUruguayInbound.Location = New System.Drawing.Point(302, 346)
        Me.dgvUruguayInbound.MultiSelect = False
        Me.dgvUruguayInbound.Name = "dgvUruguayInbound"
        Me.dgvUruguayInbound.ReadOnly = True
        Me.dgvUruguayInbound.RowHeadersVisible = False
        Me.dgvUruguayInbound.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgvUruguayInbound.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUruguayInbound.ShowEditingIcon = False
        Me.dgvUruguayInbound.Size = New System.Drawing.Size(187, 156)
        Me.dgvUruguayInbound.TabIndex = 5
        '
        'dgvParaguayInbound
        '
        Me.dgvParaguayInbound.AllowUserToAddRows = False
        Me.dgvParaguayInbound.AllowUserToDeleteRows = False
        Me.dgvParaguayInbound.AllowUserToResizeColumns = False
        Me.dgvParaguayInbound.AllowUserToResizeRows = False
        Me.dgvParaguayInbound.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvParaguayInbound.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvParaguayInbound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParaguayInbound.Enabled = False
        Me.dgvParaguayInbound.Location = New System.Drawing.Point(500, 346)
        Me.dgvParaguayInbound.MultiSelect = False
        Me.dgvParaguayInbound.Name = "dgvParaguayInbound"
        Me.dgvParaguayInbound.ReadOnly = True
        Me.dgvParaguayInbound.RowHeadersVisible = False
        Me.dgvParaguayInbound.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgvParaguayInbound.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvParaguayInbound.ShowEditingIcon = False
        Me.dgvParaguayInbound.Size = New System.Drawing.Size(187, 156)
        Me.dgvParaguayInbound.TabIndex = 6
        '
        'dgvParaguayOutbound
        '
        Me.dgvParaguayOutbound.AllowUserToAddRows = False
        Me.dgvParaguayOutbound.AllowUserToDeleteRows = False
        Me.dgvParaguayOutbound.AllowUserToResizeColumns = False
        Me.dgvParaguayOutbound.AllowUserToResizeRows = False
        Me.dgvParaguayOutbound.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvParaguayOutbound.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvParaguayOutbound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParaguayOutbound.Enabled = False
        Me.dgvParaguayOutbound.Location = New System.Drawing.Point(500, 549)
        Me.dgvParaguayOutbound.MultiSelect = False
        Me.dgvParaguayOutbound.Name = "dgvParaguayOutbound"
        Me.dgvParaguayOutbound.ReadOnly = True
        Me.dgvParaguayOutbound.RowHeadersVisible = False
        Me.dgvParaguayOutbound.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgvParaguayOutbound.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvParaguayOutbound.ShowEditingIcon = False
        Me.dgvParaguayOutbound.Size = New System.Drawing.Size(187, 156)
        Me.dgvParaguayOutbound.TabIndex = 9
        '
        'dgvUruguayOutbound
        '
        Me.dgvUruguayOutbound.AllowUserToAddRows = False
        Me.dgvUruguayOutbound.AllowUserToDeleteRows = False
        Me.dgvUruguayOutbound.AllowUserToResizeColumns = False
        Me.dgvUruguayOutbound.AllowUserToResizeRows = False
        Me.dgvUruguayOutbound.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvUruguayOutbound.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvUruguayOutbound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUruguayOutbound.Enabled = False
        Me.dgvUruguayOutbound.Location = New System.Drawing.Point(302, 549)
        Me.dgvUruguayOutbound.MultiSelect = False
        Me.dgvUruguayOutbound.Name = "dgvUruguayOutbound"
        Me.dgvUruguayOutbound.ReadOnly = True
        Me.dgvUruguayOutbound.RowHeadersVisible = False
        Me.dgvUruguayOutbound.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgvUruguayOutbound.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUruguayOutbound.ShowEditingIcon = False
        Me.dgvUruguayOutbound.Size = New System.Drawing.Size(187, 156)
        Me.dgvUruguayOutbound.TabIndex = 8
        '
        'dgvArgentinaOutbound
        '
        Me.dgvArgentinaOutbound.AllowUserToAddRows = False
        Me.dgvArgentinaOutbound.AllowUserToDeleteRows = False
        Me.dgvArgentinaOutbound.AllowUserToResizeColumns = False
        Me.dgvArgentinaOutbound.AllowUserToResizeRows = False
        Me.dgvArgentinaOutbound.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvArgentinaOutbound.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvArgentinaOutbound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArgentinaOutbound.Enabled = False
        Me.dgvArgentinaOutbound.Location = New System.Drawing.Point(105, 549)
        Me.dgvArgentinaOutbound.MultiSelect = False
        Me.dgvArgentinaOutbound.Name = "dgvArgentinaOutbound"
        Me.dgvArgentinaOutbound.ReadOnly = True
        Me.dgvArgentinaOutbound.RowHeadersVisible = False
        Me.dgvArgentinaOutbound.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgvArgentinaOutbound.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvArgentinaOutbound.ShowEditingIcon = False
        Me.dgvArgentinaOutbound.Size = New System.Drawing.Size(187, 156)
        Me.dgvArgentinaOutbound.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 389)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Inbound"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 630)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Outbound"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(130, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Argentina"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(362, 320)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Uruguay"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(575, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Paraguay"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(702, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "IOT Vigente: "
        '
        'lIOT
        '
        Me.lIOT.AutoSize = True
        Me.lIOT.Location = New System.Drawing.Point(778, 148)
        Me.lIOT.Name = "lIOT"
        Me.lIOT.Size = New System.Drawing.Size(43, 13)
        Me.lIOT.TabIndex = 16
        Me.lIOT.Text = "Sin IOT"
        '
        'fConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1080, 739)
        Me.Controls.Add(Me.lIOT)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvParaguayOutbound)
        Me.Controls.Add(Me.dgvUruguayOutbound)
        Me.Controls.Add(Me.dgvArgentinaOutbound)
        Me.Controls.Add(Me.dgvParaguayInbound)
        Me.Controls.Add(Me.dgvUruguayInbound)
        Me.Controls.Add(Me.dgvArgemtinaInbound)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgbOperadoresPais)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bVolverConsulta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "fConsulta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgbOperadoresPais, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvArgemtinaInbound, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUruguayInbound, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvParaguayInbound, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvParaguayOutbound, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUruguayOutbound, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvArgentinaOutbound, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bVolverConsulta As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbPLMN As RadioButton
    Friend WithEvents rbMNC As RadioButton
    Friend WithEvents rbPais As RadioButton
    Friend WithEvents dgbOperadoresPais As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents bBuscar As Button
    Friend WithEvents rbGrupo As RadioButton
    Friend WithEvents cbGrupo As ComboBox
    Friend WithEvents tbPLMN As TextBox
    Friend WithEvents tbMNC As TextBox
    Friend WithEvents tbMCC As TextBox
    Friend WithEvents cbPais As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvArgemtinaInbound As DataGridView
    Friend WithEvents dgvUruguayInbound As DataGridView
    Friend WithEvents dgvParaguayInbound As DataGridView
    Friend WithEvents dgvParaguayOutbound As DataGridView
    Friend WithEvents dgvUruguayOutbound As DataGridView
    Friend WithEvents dgvArgentinaOutbound As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lIOT As Label
End Class
