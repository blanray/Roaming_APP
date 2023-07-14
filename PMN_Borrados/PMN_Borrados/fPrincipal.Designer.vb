<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fPrincipal
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
        Me.mPrincipal = New System.Windows.Forms.MenuStrip()
        Me.PrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lTipoAcceso = New System.Windows.Forms.Label()
        Me.lTipoAccesoPrincipal = New System.Windows.Forms.Label()
        Me.mPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'mPrincipal
        '
        Me.mPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrincipalToolStripMenuItem, Me.ModificacionToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.mPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mPrincipal.Name = "mPrincipal"
        Me.mPrincipal.Size = New System.Drawing.Size(618, 24)
        Me.mPrincipal.TabIndex = 1
        Me.mPrincipal.Text = "MenuStrip1"
        '
        'PrincipalToolStripMenuItem
        '
        Me.PrincipalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BusquedaToolStripMenuItem})
        Me.PrincipalToolStripMenuItem.Name = "PrincipalToolStripMenuItem"
        Me.PrincipalToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.PrincipalToolStripMenuItem.Text = "Principal"
        '
        'BusquedaToolStripMenuItem
        '
        Me.BusquedaToolStripMenuItem.Name = "BusquedaToolStripMenuItem"
        Me.BusquedaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BusquedaToolStripMenuItem.Text = "Busqueda"
        '
        'ModificacionToolStripMenuItem
        '
        Me.ModificacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMToolStripMenuItem})
        Me.ModificacionToolStripMenuItem.Name = "ModificacionToolStripMenuItem"
        Me.ModificacionToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.ModificacionToolStripMenuItem.Text = "Modificacion"
        '
        'ABMToolStripMenuItem
        '
        Me.ABMToolStripMenuItem.Name = "ABMToolStripMenuItem"
        Me.ABMToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.ABMToolStripMenuItem.Text = "ABM"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'lTipoAcceso
        '
        Me.lTipoAcceso.AutoSize = True
        Me.lTipoAcceso.Location = New System.Drawing.Point(405, 9)
        Me.lTipoAcceso.Name = "lTipoAcceso"
        Me.lTipoAcceso.Size = New System.Drawing.Size(73, 13)
        Me.lTipoAcceso.TabIndex = 3
        Me.lTipoAcceso.Text = "Tipo Acceso: "
        '
        'lTipoAccesoPrincipal
        '
        Me.lTipoAccesoPrincipal.AutoSize = True
        Me.lTipoAccesoPrincipal.Location = New System.Drawing.Point(485, 10)
        Me.lTipoAccesoPrincipal.Name = "lTipoAccesoPrincipal"
        Me.lTipoAccesoPrincipal.Size = New System.Drawing.Size(0, 13)
        Me.lTipoAccesoPrincipal.TabIndex = 4
        '
        'fPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 345)
        Me.ControlBox = False
        Me.Controls.Add(Me.lTipoAccesoPrincipal)
        Me.Controls.Add(Me.lTipoAcceso)
        Me.Controls.Add(Me.mPrincipal)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mPrincipal
        Me.Name = "fPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Roaming Internacional"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mPrincipal.ResumeLayout(False)
        Me.mPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mPrincipal As MenuStrip
    Friend WithEvents PrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BusquedaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lTipoAcceso As Label
    Friend WithEvents lTipoAccesoPrincipal As Label
    Friend WithEvents ModificacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABMToolStripMenuItem As ToolStripMenuItem
End Class
