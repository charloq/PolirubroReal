<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCargarCliente
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
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim DomicilioLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PolirubroRealDBDataSet1 = New PolirubroReal.PolirubroRealDBDataSet()
        Me.ClientesTableAdapter = New PolirubroReal.PolirubroRealDBDataSetTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New PolirubroReal.PolirubroRealDBDataSetTableAdapters.TableAdapterManager()
        Me.ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.DomicilioTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        IdLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        DomicilioLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PolirubroRealDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(73, 24)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(166, 20)
        Me.txtNombre.TabIndex = 1
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(123, 114)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(116, 23)
        Me.btnCargar.TabIndex = 2
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnCargar)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDomicilio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 166)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Domicilio:"
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Location = New System.Drawing.Point(73, 50)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(166, 20)
        Me.txtDomicilio.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Teléfono:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(123, 76)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(116, 20)
        Me.txtTelefono.TabIndex = 5
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.PolirubroRealDBDataSet1
        '
        'PolirubroRealDBDataSet1
        '
        Me.PolirubroRealDBDataSet1.DataSetName = "PolirubroRealDBDataSet"
        Me.PolirubroRealDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.UpdateOrder = PolirubroReal.PolirubroRealDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClientesDataGridView
        '
        Me.ClientesDataGridView.AutoGenerateColumns = False
        Me.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ClientesDataGridView.DataSource = Me.ClientesBindingSource
        Me.ClientesDataGridView.Location = New System.Drawing.Point(567, 64)
        Me.ClientesDataGridView.Name = "ClientesDataGridView"
        Me.ClientesDataGridView.Size = New System.Drawing.Size(316, 220)
        Me.ClientesDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "domicilio"
        Me.DataGridViewTextBoxColumn3.HeaderText = "domicilio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn4.HeaderText = "telefono"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(384, 69)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 3
        IdLabel.Text = "Id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(440, 66)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 4
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(384, 95)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(45, 13)
        NombreLabel.TabIndex = 5
        NombreLabel.Text = "nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(440, 92)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 6
        '
        'DomicilioLabel
        '
        DomicilioLabel.AutoSize = True
        DomicilioLabel.Location = New System.Drawing.Point(384, 121)
        DomicilioLabel.Name = "DomicilioLabel"
        DomicilioLabel.Size = New System.Drawing.Size(50, 13)
        DomicilioLabel.TabIndex = 7
        DomicilioLabel.Text = "domicilio:"
        '
        'DomicilioTextBox
        '
        Me.DomicilioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "domicilio", True))
        Me.DomicilioTextBox.Location = New System.Drawing.Point(440, 118)
        Me.DomicilioTextBox.Name = "DomicilioTextBox"
        Me.DomicilioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DomicilioTextBox.TabIndex = 8
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(384, 147)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(48, 13)
        TelefonoLabel.TabIndex = 9
        TelefonoLabel.Text = "telefono:"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(440, 144)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 10
        '
        'frmCargarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 304)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(DomicilioLabel)
        Me.Controls.Add(Me.DomicilioTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(Me.ClientesDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCargarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargar cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PolirubroRealDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnCargar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents PolirubroRealDBDataSet1 As PolirubroRealDBDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As PolirubroRealDBDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As PolirubroRealDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents DomicilioTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
End Class
