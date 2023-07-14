<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fIngreso
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbTipoAcceso = New System.Windows.Forms.GroupBox()
        Me.rbConsulta = New System.Windows.Forms.RadioButton()
        Me.rbModificacion = New System.Windows.Forms.RadioButton()
        Me.tbModificacion = New System.Windows.Forms.TextBox()
        Me.lModificacion = New System.Windows.Forms.Label()
        Me.bAceptarIngreso = New System.Windows.Forms.Button()
        Me.bCancelarIngreso = New System.Windows.Forms.Button()
        Me.gbTipoAcceso.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbTipoAcceso
        '
        Me.gbTipoAcceso.Controls.Add(Me.rbModificacion)
        Me.gbTipoAcceso.Controls.Add(Me.rbConsulta)
        Me.gbTipoAcceso.Location = New System.Drawing.Point(64, 23)
        Me.gbTipoAcceso.Name = "gbTipoAcceso"
        Me.gbTipoAcceso.Size = New System.Drawing.Size(298, 74)
        Me.gbTipoAcceso.TabIndex = 0
        Me.gbTipoAcceso.TabStop = False
        Me.gbTipoAcceso.Text = "Tipo de Acceso"
        '
        'rbConsulta
        '
        Me.rbConsulta.AutoSize = True
        Me.rbConsulta.Location = New System.Drawing.Point(58, 32)
        Me.rbConsulta.Name = "rbConsulta"
        Me.rbConsulta.Size = New System.Drawing.Size(66, 17)
        Me.rbConsulta.TabIndex = 0
        Me.rbConsulta.TabStop = True
        Me.rbConsulta.Text = "Consulta"
        Me.rbConsulta.UseVisualStyleBackColor = True
        '
        'rbModificacion
        '
        Me.rbModificacion.AutoSize = True
        Me.rbModificacion.Location = New System.Drawing.Point(164, 32)
        Me.rbModificacion.Name = "rbModificacion"
        Me.rbModificacion.Size = New System.Drawing.Size(85, 17)
        Me.rbModificacion.TabIndex = 1
        Me.rbModificacion.TabStop = True
        Me.rbModificacion.Text = "Modificacion"
        Me.rbModificacion.UseVisualStyleBackColor = True
        '
        'tbModificacion
        '
        Me.tbModificacion.Location = New System.Drawing.Point(262, 103)
        Me.tbModificacion.Name = "tbModificacion"
        Me.tbModificacion.Size = New System.Drawing.Size(100, 20)
        Me.tbModificacion.TabIndex = 1
        Me.tbModificacion.UseSystemPasswordChar = True
        '
        'lModificacion
        '
        Me.lModificacion.AutoSize = True
        Me.lModificacion.Location = New System.Drawing.Point(190, 106)
        Me.lModificacion.Name = "lModificacion"
        Me.lModificacion.Size = New System.Drawing.Size(66, 13)
        Me.lModificacion.TabIndex = 2
        Me.lModificacion.Text = "Constraseña"
        '
        'bAceptarIngreso
        '
        Me.bAceptarIngreso.Location = New System.Drawing.Point(64, 156)
        Me.bAceptarIngreso.Name = "bAceptarIngreso"
        Me.bAceptarIngreso.Size = New System.Drawing.Size(75, 23)
        Me.bAceptarIngreso.TabIndex = 3
        Me.bAceptarIngreso.Text = "Aceptar"
        Me.bAceptarIngreso.UseVisualStyleBackColor = True
        '
        'bCancelarIngreso
        '
        Me.bCancelarIngreso.Location = New System.Drawing.Point(262, 156)
        Me.bCancelarIngreso.Name = "bCancelarIngreso"
        Me.bCancelarIngreso.Size = New System.Drawing.Size(75, 23)
        Me.bCancelarIngreso.TabIndex = 4
        Me.bCancelarIngreso.Text = "Cancelar"
        Me.bCancelarIngreso.UseVisualStyleBackColor = True
        '
        'fIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(499, 250)
        Me.Controls.Add(Me.bCancelarIngreso)
        Me.Controls.Add(Me.bAceptarIngreso)
        Me.Controls.Add(Me.lModificacion)
        Me.Controls.Add(Me.tbModificacion)
        Me.Controls.Add(Me.gbTipoAcceso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fIngreso"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso al Sistema"
        Me.gbTipoAcceso.ResumeLayout(False)
        Me.gbTipoAcceso.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbTipoAcceso As GroupBox
    Friend WithEvents rbModificacion As RadioButton
    Friend WithEvents rbConsulta As RadioButton
    Friend WithEvents tbModificacion As TextBox
    Friend WithEvents lModificacion As Label
    Friend WithEvents bAceptarIngreso As Button
    Friend WithEvents bCancelarIngreso As Button
End Class
