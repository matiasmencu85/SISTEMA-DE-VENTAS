<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmventa
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DbventasDataSet = New sisventas.dbventasDataSet()
        Me.ClienteBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New sisventas.dbventasDataSetTableAdapters.clienteTableAdapter()
        Me.txtbuscartipo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.datalistado1 = New System.Windows.Forms.DataGridView()
        Me.Idventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Idcliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MostrarventaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbventasDataSet9 = New sisventas.dbventasDataSet9()
        Me.VentasBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Datalistado3 = New sisventas.datalistado3()
        Me.VentasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbventasDataSet5 = New sisventas.dbventasDataSet5()
        Me.ClienteBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Datalistado2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Datalistado2 = New sisventas.datalistado2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.txtnombre_cliente = New System.Windows.Forms.TextBox()
        Me.txtnum_documento = New System.Windows.Forms.TextBox()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.txtidventa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnbuscar_cliente = New System.Windows.Forms.Button()
        Me.txtfecha = New System.Windows.Forms.DateTimePicker()
        Me.cbtipo_documento = New System.Windows.Forms.ComboBox()
        Me.ClienteBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter1 = New sisventas.datalistado2TableAdapters.clienteTableAdapter()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasTableAdapter = New sisventas.datalistado2TableAdapters.ventasTableAdapter()
        Me.ClienteBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.VentasTableAdapter1 = New sisventas.dbventasDataSet5TableAdapters.ventasTableAdapter()
        Me.VentasTableAdapter2 = New sisventas.datalistado3TableAdapters.ventasTableAdapter()
        Me.btnguardar1 = New System.Windows.Forms.Button()
        Me.Mostrar_ventaTableAdapter = New sisventas.dbventasDataSet9TableAdapters.mostrar_ventaTableAdapter()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbventasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MostrarventaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbventasDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datalistado3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbventasDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datalistado2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datalistado2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'DbventasDataSet
        '
        Me.DbventasDataSet.DataSetName = "dbventasDataSet"
        Me.DbventasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteBindingSource1
        '
        Me.ClienteBindingSource1.DataMember = "cliente"
        Me.ClienteBindingSource1.DataSource = Me.DbventasDataSet
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'txtbuscartipo
        '
        Me.txtbuscartipo.Location = New System.Drawing.Point(274, 19)
        Me.txtbuscartipo.Name = "txtbuscartipo"
        Me.txtbuscartipo.Size = New System.Drawing.Size(128, 20)
        Me.txtbuscartipo.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtbuscartipo)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cbeliminar)
        Me.GroupBox2.Controls.Add(Me.btneliminar)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.datalistado1)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(468, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(819, 395)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LISTADO DE CLIENTES"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label8.Location = New System.Drawing.Point(60, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(181, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "BUSCAR POR TIPO DOC"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(429, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(197, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "BUSCADOR POR NOMBRE"
        '
        'cbeliminar
        '
        Me.cbeliminar.AutoSize = True
        Me.cbeliminar.Location = New System.Drawing.Point(20, 47)
        Me.cbeliminar.Name = "cbeliminar"
        Me.cbeliminar.Size = New System.Drawing.Size(62, 17)
        Me.cbeliminar.TabIndex = 4
        Me.cbeliminar.Text = "Eliminar"
        Me.cbeliminar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(6, 366)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 2
        Me.btneliminar.Text = "ELIMINAR"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(212, 227)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(91, 13)
        Me.inexistente.TabIndex = 3
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "datos inexistentes"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(632, 19)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(116, 20)
        Me.txtbuscar.TabIndex = 2
        '
        'datalistado1
        '
        Me.datalistado1.AllowUserToAddRows = False
        Me.datalistado1.AllowUserToDeleteRows = False
        Me.datalistado1.AutoGenerateColumns = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.datalistado1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Idventa, Me.Idcliente, Me.apellidos, Me.fecha_venta, Me.tipo_documento, Me.num_documento, Me.Eliminar})
        Me.datalistado1.DataSource = Me.MostrarventaBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datalistado1.DefaultCellStyle = DataGridViewCellStyle5
        Me.datalistado1.Location = New System.Drawing.Point(0, 70)
        Me.datalistado1.Name = "datalistado1"
        Me.datalistado1.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistado1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.datalistado1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado1.Size = New System.Drawing.Size(813, 298)
        Me.datalistado1.TabIndex = 0
        '
        'Idventa
        '
        Me.Idventa.DataPropertyName = "idventa"
        Me.Idventa.HeaderText = "idventa"
        Me.Idventa.Name = "Idventa"
        Me.Idventa.ReadOnly = True
        '
        'Idcliente
        '
        Me.Idcliente.DataPropertyName = "idcliente"
        Me.Idcliente.HeaderText = "idcliente"
        Me.Idcliente.Name = "Idcliente"
        Me.Idcliente.ReadOnly = True
        '
        'apellidos
        '
        Me.apellidos.DataPropertyName = "apellidos"
        Me.apellidos.HeaderText = "apellidos"
        Me.apellidos.Name = "apellidos"
        Me.apellidos.ReadOnly = True
        '
        'fecha_venta
        '
        Me.fecha_venta.DataPropertyName = "fecha_venta"
        Me.fecha_venta.HeaderText = "fecha_venta"
        Me.fecha_venta.Name = "fecha_venta"
        Me.fecha_venta.ReadOnly = True
        '
        'tipo_documento
        '
        Me.tipo_documento.DataPropertyName = "tipo_documento"
        Me.tipo_documento.HeaderText = "tipo_documento"
        Me.tipo_documento.Name = "tipo_documento"
        Me.tipo_documento.ReadOnly = True
        '
        'num_documento
        '
        Me.num_documento.DataPropertyName = "num_documento"
        Me.num_documento.HeaderText = "num_documento"
        Me.num_documento.Name = "num_documento"
        Me.num_documento.ReadOnly = True
        '
        'Eliminar
        '
        Me.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Eliminar.DataPropertyName = "Eliminar"
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'MostrarventaBindingSource
        '
        Me.MostrarventaBindingSource.DataMember = "mostrar_venta"
        Me.MostrarventaBindingSource.DataSource = Me.DbventasDataSet9
        '
        'DbventasDataSet9
        '
        Me.DbventasDataSet9.DataSetName = "dbventasDataSet9"
        Me.DbventasDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentasBindingSource2
        '
        Me.VentasBindingSource2.DataMember = "ventas"
        Me.VentasBindingSource2.DataSource = Me.Datalistado3
        '
        'Datalistado3
        '
        Me.Datalistado3.DataSetName = "datalistado3"
        Me.Datalistado3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentasBindingSource1
        '
        Me.VentasBindingSource1.DataMember = "ventas"
        Me.VentasBindingSource1.DataSource = Me.DbventasDataSet5
        '
        'DbventasDataSet5
        '
        Me.DbventasDataSet5.DataSetName = "dbventasDataSet5"
        Me.DbventasDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteBindingSource4
        '
        Me.ClienteBindingSource4.DataMember = "cliente"
        Me.ClienteBindingSource4.DataSource = Me.Datalistado2BindingSource
        '
        'Datalistado2BindingSource
        '
        Me.Datalistado2BindingSource.DataSource = Me.Datalistado2
        Me.Datalistado2BindingSource.Position = 0
        '
        'Datalistado2
        '
        Me.Datalistado2.DataSetName = "datalistado2"
        Me.Datalistado2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "ID VENTA"
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(115, 259)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(91, 23)
        Me.btnguardar.TabIndex = 32
        Me.btnguardar.Text = "GUARDAR"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(224, 288)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 31
        Me.btncancelar.Text = "CANCELAR"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.Location = New System.Drawing.Point(115, 288)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(75, 23)
        Me.btneditar.TabIndex = 30
        Me.btneditar.Text = "EDITAR"
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(3, 288)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(90, 23)
        Me.btnnuevo.TabIndex = 29
        Me.btnnuevo.Text = "NUEVO"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'txtnombre_cliente
        '
        Me.txtnombre_cliente.Location = New System.Drawing.Point(186, 72)
        Me.txtnombre_cliente.MaxLength = 8
        Me.txtnombre_cliente.Name = "txtnombre_cliente"
        Me.txtnombre_cliente.Size = New System.Drawing.Size(157, 20)
        Me.txtnombre_cliente.TabIndex = 28
        '
        'txtnum_documento
        '
        Me.txtnum_documento.Location = New System.Drawing.Point(115, 177)
        Me.txtnum_documento.Name = "txtnum_documento"
        Me.txtnum_documento.Size = New System.Drawing.Size(157, 20)
        Me.txtnum_documento.TabIndex = 27
        '
        'txtidcliente
        '
        Me.txtidcliente.Location = New System.Drawing.Point(115, 72)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.Size = New System.Drawing.Size(56, 20)
        Me.txtidcliente.TabIndex = 24
        '
        'txtidventa
        '
        Me.txtidventa.Location = New System.Drawing.Point(115, 43)
        Me.txtidventa.Name = "txtidventa"
        Me.txtidventa.Size = New System.Drawing.Size(91, 20)
        Me.txtidventa.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "CLIENTE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "NUMERO DOC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "TIPO DE DOC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "FECHA"
        '
        'btnbuscar_cliente
        '
        Me.btnbuscar_cliente.Location = New System.Drawing.Point(359, 72)
        Me.btnbuscar_cliente.Name = "btnbuscar_cliente"
        Me.btnbuscar_cliente.Size = New System.Drawing.Size(61, 23)
        Me.btnbuscar_cliente.TabIndex = 34
        Me.btnbuscar_cliente.Text = "......"
        Me.btnbuscar_cliente.UseVisualStyleBackColor = True
        '
        'txtfecha
        '
        Me.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha.Location = New System.Drawing.Point(71, 105)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(200, 20)
        Me.txtfecha.TabIndex = 35
        '
        'cbtipo_documento
        '
        Me.cbtipo_documento.FormattingEnabled = True
        Me.cbtipo_documento.Items.AddRange(New Object() {"BOLETA", "FACTURA", "PRESUPUESTO"})
        Me.cbtipo_documento.Location = New System.Drawing.Point(115, 140)
        Me.cbtipo_documento.Name = "cbtipo_documento"
        Me.cbtipo_documento.Size = New System.Drawing.Size(121, 21)
        Me.cbtipo_documento.TabIndex = 36
        Me.cbtipo_documento.Text = "FACTURA"
        '
        'ClienteBindingSource2
        '
        Me.ClienteBindingSource2.DataMember = "cliente"
        Me.ClienteBindingSource2.DataSource = Me.Datalistado2BindingSource
        '
        'ClienteTableAdapter1
        '
        Me.ClienteTableAdapter1.ClearBeforeFill = True
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "ventas"
        Me.VentasBindingSource.DataSource = Me.Datalistado2BindingSource
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'ClienteBindingSource3
        '
        Me.ClienteBindingSource3.DataMember = "cliente"
        Me.ClienteBindingSource3.DataSource = Me.Datalistado2BindingSource
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(343, 36)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(100, 20)
        Me.txtflag.TabIndex = 37
        Me.txtflag.Text = "0"
        '
        'VentasTableAdapter1
        '
        Me.VentasTableAdapter1.ClearBeforeFill = True
        '
        'VentasTableAdapter2
        '
        Me.VentasTableAdapter2.ClearBeforeFill = True
        '
        'btnguardar1
        '
        Me.btnguardar1.Location = New System.Drawing.Point(309, 246)
        Me.btnguardar1.Name = "btnguardar1"
        Me.btnguardar1.Size = New System.Drawing.Size(153, 27)
        Me.btnguardar1.TabIndex = 38
        Me.btnguardar1.Text = "AGREGAR AL CARRITO"
        Me.btnguardar1.UseVisualStyleBackColor = True
        '
        'Mostrar_ventaTableAdapter
        '
        Me.Mostrar_ventaTableAdapter.ClearBeforeFill = True
        '
        'frmventa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1312, 433)
        Me.Controls.Add(Me.btnguardar1)
        Me.Controls.Add(Me.txtflag)
        Me.Controls.Add(Me.cbtipo_documento)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.btnbuscar_cliente)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btneditar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.txtnombre_cliente)
        Me.Controls.Add(Me.txtnum_documento)
        Me.Controls.Add(Me.txtidcliente)
        Me.Controls.Add(Me.txtidventa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmventa"
        Me.Text = "LISTADO DE VENTAS"
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbventasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MostrarventaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbventasDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datalistado3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbventasDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datalistado2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datalistado2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents erroricono As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnbuscar_cliente As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbuscartipo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbeliminar As System.Windows.Forms.CheckBox
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents inexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents datalistado1 As System.Windows.Forms.DataGridView
    Friend WithEvents ClienteBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DbventasDataSet As sisventas.dbventasDataSet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btneditar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents txtnombre_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txtnum_documento As System.Windows.Forms.TextBox
    Friend WithEvents txtidcliente As System.Windows.Forms.TextBox
    Friend WithEvents txtidventa As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ClienteTableAdapter As sisventas.dbventasDataSetTableAdapters.clienteTableAdapter
    Friend WithEvents cbtipo_documento As System.Windows.Forms.ComboBox
    Friend WithEvents txtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Datalistado2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Datalistado2 As sisventas.datalistado2
    Friend WithEvents ClienteBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTableAdapter1 As sisventas.datalistado2TableAdapters.clienteTableAdapter
    Friend WithEvents VentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VentasTableAdapter As sisventas.datalistado2TableAdapters.ventasTableAdapter
    Friend WithEvents ClienteBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents txtflag As System.Windows.Forms.TextBox
    Friend WithEvents DbventasDataSet5 As sisventas.dbventasDataSet5
    Friend WithEvents VentasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents VentasTableAdapter1 As sisventas.dbventasDataSet5TableAdapters.ventasTableAdapter
    Friend WithEvents Datalistado3 As sisventas.datalistado3
    Friend WithEvents VentasBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents VentasTableAdapter2 As sisventas.datalistado3TableAdapters.ventasTableAdapter
    Friend WithEvents btnguardar1 As System.Windows.Forms.Button
    Friend WithEvents DbventasDataSet9 As sisventas.dbventasDataSet9
    Friend WithEvents MostrarventaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mostrar_ventaTableAdapter As sisventas.dbventasDataSet9TableAdapters.mostrar_ventaTableAdapter
    Friend WithEvents Idventa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Idcliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_venta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents num_documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
