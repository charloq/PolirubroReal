<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sistema
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.VentasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoClienteToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.EditarToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'NuevoClienteToolStripMenuItem
        '
        Me.NuevoClienteToolStripMenuItem.Name = "NuevoClienteToolStripMenuItem"
        Me.NuevoClienteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NuevoClienteToolStripMenuItem.Text = "Cargar cliente"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BuscarToolStripMenuItem.Text = "Buscar cliente"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Sistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Sistema"
        Me.Text = "Polirubro Real"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
