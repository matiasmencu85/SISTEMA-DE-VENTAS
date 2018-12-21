<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdetalle_venta
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
        Me.VentasTableAdapter1 = New sisventas.dbventasDataSet5TableAdapters.ventasTableAdapter()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.Datalistado2 = New sisventas.datalistado2()
        Me.cbtipo_documento = New System.Windows.Forms.ComboBox()
        Me.txtfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.txtnum_documento = New System.Windows.Forms.TextBox()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.txtidventa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ClienteBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Datalistado2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter1 = New sisventas.datalistado2TableAdapters.clienteTableAdapter()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasTableAdapter = New sisventas.datalistado2TableAdapters.ventasTableAdapter()
        Me.ClienteBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasTableAdapter2 = New sisventas.datalistado3TableAdapters.ventasTableAdapter()
        Me.ClienteBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtnombre_cliente = New System.Windows.Forms.TextBox()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DbventasDataSet = New sisventas.dbventasDataSet()
        Me.ClienteBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New sisventas.dbventasDataSetTableAdapters.clienteTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.datalistado1 = New System.Windows.Forms.DataGridView()
        Me.iddetalle_venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_unitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MostrardetalleventasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbventasDataSet8 = New sisventas.dbventasDataSet8()
        Me.GenerarcomprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbventasDataSet11 = New sisventas.dbventasDataSet11()
        Me.DbventasDataSet6BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbventasDataSet6 = New sisventas.dbventasDataSet6()
        Me.DetalleventasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Datalistado4 = New sisventas.datalistado4()
        Me.VentasBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Datalistado3 = New sisventas.datalistado3()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.DbventasDataSet5 = New sisventas.dbventasDataSet5()
        Me.VentasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnbuscar_producto = New System.Windows.Forms.Button()
        Me.txtidproducto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnombre_producto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtprecio_unitario = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.NumericUpDown()
        Me.txtstock = New System.Windows.Forms.NumericUpDown()
        Me.Detalle_ventasTableAdapter = New sisventas.datalistado4TableAdapters.detalle_ventasTableAdapter()
        Me.DbventasDataSet7 = New sisventas.dbventasDataSet7()
        Me.MostrardetalleventasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mostrar_detalle_ventasTableAdapter = New sisventas.dbventasDataSet7TableAdapters.mostrar_detalle_ventasTableAdapter()
        Me.Mostrar_detalle_ventasTableAdapter1 = New sisventas.dbventasDataSet8TableAdapters.mostrar_detalle_ventasTableAdapter()
        Me.btnimprimir = New System.Windows.Forms.Button()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UpdateOrderOptionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Generar_comprobanteTableAdapter = New sisventas.dbventasDataSet11TableAdapters.generar_comprobanteTableAdapter()
        CType(Me.Datalistado2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datalistado2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbventasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MostrardetalleventasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbventasDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenerarcomprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbventasDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbventasDataSet6BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbventasDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleventasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datalistado4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datalistado3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbventasDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtstock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbventasDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MostrardetalleventasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpdateOrderOptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VentasTableAdapter1
        '
        Me.VentasTableAdapter1.ClearBeforeFill = True
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(332, 82)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(100, 20)
        Me.txtflag.TabIndex = 55
        Me.txtflag.Text = "0"
        '
        'Datalistado2
        '
        Me.Datalistado2.DataSetName = "datalistado2"
        Me.Datalistado2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbtipo_documento
        '
        Me.cbtipo_documento.Enabled = False
        Me.cbtipo_documento.FormattingEnabled = True
        Me.cbtipo_documento.Items.AddRange(New Object() {"BOLETA", "FACTURA", "PRESUPUESTO"})
        Me.cbtipo_documento.Location = New System.Drawing.Point(104, 186)
        Me.cbtipo_documento.Name = "cbtipo_documento"
        Me.cbtipo_documento.Size = New System.Drawing.Size(121, 21)
        Me.cbtipo_documento.TabIndex = 54
        Me.cbtipo_documento.Text = "FACTURA"
        '
        'txtfecha
        '
        Me.txtfecha.Enabled = False
        Me.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha.Location = New System.Drawing.Point(60, 151)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(200, 20)
        Me.txtfecha.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "ID VENTA"
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(110, 491)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(136, 23)
        Me.btnguardar.TabIndex = 51
        Me.btnguardar.Text = "AGREGAR ARTICULO"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(294, 491)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 50
        Me.btncancelar.Text = "CANCELAR"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(12, 491)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(90, 23)
        Me.btnnuevo.TabIndex = 48
        Me.btnnuevo.Text = "NUEVO"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'txtnum_documento
        '
        Me.txtnum_documento.Enabled = False
        Me.txtnum_documento.Location = New System.Drawing.Point(104, 223)
        Me.txtnum_documento.Name = "txtnum_documento"
        Me.txtnum_documento.Size = New System.Drawing.Size(157, 20)
        Me.txtnum_documento.TabIndex = 46
        '
        'txtidcliente
        '
        Me.txtidcliente.Enabled = False
        Me.txtidcliente.Location = New System.Drawing.Point(104, 118)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.Size = New System.Drawing.Size(56, 20)
        Me.txtidcliente.TabIndex = 45
        '
        'txtidventa
        '
        Me.txtidventa.Enabled = False
        Me.txtidventa.Location = New System.Drawing.Point(104, 89)
        Me.txtidventa.Name = "txtidventa"
        Me.txtidventa.Size = New System.Drawing.Size(157, 20)
        Me.txtidventa.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "CLIENTE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "NUMERO DOC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "TIPO DE DOC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "FECHA"
        '
        'ClienteBindingSource2
        '
        Me.ClienteBindingSource2.DataMember = "cliente"
        Me.ClienteBindingSource2.DataSource = Me.Datalistado2BindingSource
        '
        'Datalistado2BindingSource
        '
        Me.Datalistado2BindingSource.DataSource = Me.Datalistado2
        Me.Datalistado2BindingSource.Position = 0
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
        'VentasTableAdapter2
        '
        Me.VentasTableAdapter2.ClearBeforeFill = True
        '
        'ClienteBindingSource4
        '
        Me.ClienteBindingSource4.DataMember = "cliente"
        Me.ClienteBindingSource4.DataSource = Me.Datalistado2BindingSource
        '
        'txtnombre_cliente
        '
        Me.txtnombre_cliente.Enabled = False
        Me.txtnombre_cliente.Location = New System.Drawing.Point(175, 118)
        Me.txtnombre_cliente.MaxLength = 8
        Me.txtnombre_cliente.Name = "txtnombre_cliente"
        Me.txtnombre_cliente.Size = New System.Drawing.Size(157, 20)
        Me.txtnombre_cliente.TabIndex = 47
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.cbeliminar)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.datalistado1)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(457, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(819, 395)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LISTADO ARTICULOS"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(360, 29)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(116, 20)
        Me.txtbuscar.TabIndex = 67
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(117, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 23)
        Me.Button1.TabIndex = 66
        Me.Button1.Text = "QUITAR ARTICULO"
        Me.Button1.UseVisualStyleBackColor = True
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
        'datalistado1
        '
        Me.datalistado1.AllowUserToAddRows = False
        Me.datalistado1.AllowUserToOrderColumns = True
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
        Me.datalistado1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.iddetalle_venta, Me.nombre, Me.cantidad, Me.precio_unitario, Me.Eliminar})
        Me.datalistado1.DataSource = Me.MostrardetalleventasBindingSource1
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
        'iddetalle_venta
        '
        Me.iddetalle_venta.DataPropertyName = "iddetalle_venta"
        Me.iddetalle_venta.HeaderText = "iddetalle_venta"
        Me.iddetalle_venta.Name = "iddetalle_venta"
        Me.iddetalle_venta.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.DataPropertyName = "cantidad"
        Me.cantidad.HeaderText = "cantidad"
        Me.cantidad.Name = "cantidad"
        '
        'precio_unitario
        '
        Me.precio_unitario.DataPropertyName = "precio_unitario"
        Me.precio_unitario.HeaderText = "precio_unitario"
        Me.precio_unitario.Name = "precio_unitario"
        '
        'Eliminar
        '
        Me.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Eliminar.DataPropertyName = "Eliminar"
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        '
        'MostrardetalleventasBindingSource1
        '
        Me.MostrardetalleventasBindingSource1.DataMember = "mostrar_detalle_ventas"
        Me.MostrardetalleventasBindingSource1.DataSource = Me.DbventasDataSet8
        '
        'DbventasDataSet8
        '
        Me.DbventasDataSet8.DataSetName = "dbventasDataSet8"
        Me.DbventasDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GenerarcomprobanteBindingSource
        '
        Me.GenerarcomprobanteBindingSource.DataMember = "generar_comprobante"
        Me.GenerarcomprobanteBindingSource.DataSource = Me.DbventasDataSet11
        '
        'DbventasDataSet11
        '
        Me.DbventasDataSet11.DataSetName = "dbventasDataSet11"
        Me.DbventasDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DbventasDataSet6BindingSource
        '
        Me.DbventasDataSet6BindingSource.DataSource = Me.DbventasDataSet6
        Me.DbventasDataSet6BindingSource.Position = 0
        '
        'DbventasDataSet6
        '
        Me.DbventasDataSet6.DataSetName = "dbventasDataSet6"
        Me.DbventasDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DetalleventasBindingSource
        '
        Me.DetalleventasBindingSource.DataMember = "detalle_ventas"
        Me.DetalleventasBindingSource.DataSource = Me.Datalistado4
        '
        'Datalistado4
        '
        Me.Datalistado4.DataSetName = "datalistado4"
        Me.Datalistado4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(464, 453)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 2
        Me.btneliminar.Text = "ELIMINAR"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'DbventasDataSet5
        '
        Me.DbventasDataSet5.DataSetName = "dbventasDataSet5"
        Me.DbventasDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentasBindingSource1
        '
        Me.VentasBindingSource1.DataMember = "ventas"
        Me.VentasBindingSource1.DataSource = Me.DbventasDataSet5
        '
        'btnbuscar_producto
        '
        Me.btnbuscar_producto.Location = New System.Drawing.Point(351, 270)
        Me.btnbuscar_producto.Name = "btnbuscar_producto"
        Me.btnbuscar_producto.Size = New System.Drawing.Size(61, 23)
        Me.btnbuscar_producto.TabIndex = 59
        Me.btnbuscar_producto.Text = "......"
        Me.btnbuscar_producto.UseVisualStyleBackColor = True
        '
        'txtidproducto
        '
        Me.txtidproducto.Location = New System.Drawing.Point(107, 270)
        Me.txtidproducto.Name = "txtidproducto"
        Me.txtidproducto.Size = New System.Drawing.Size(56, 20)
        Me.txtidproducto.TabIndex = 57
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "PRODUCTO"
        '
        'txtnombre_producto
        '
        Me.txtnombre_producto.Location = New System.Drawing.Point(178, 270)
        Me.txtnombre_producto.MaxLength = 8
        Me.txtnombre_producto.Name = "txtnombre_producto"
        Me.txtnombre_producto.Size = New System.Drawing.Size(157, 20)
        Me.txtnombre_producto.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 380)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 13)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "PRECIO UNITARIO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(30, 322)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "CANTIDAD"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(203, 322)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "STOCK"
        '
        'txtprecio_unitario
        '
        Me.txtprecio_unitario.Location = New System.Drawing.Point(144, 373)
        Me.txtprecio_unitario.Name = "txtprecio_unitario"
        Me.txtprecio_unitario.Size = New System.Drawing.Size(116, 20)
        Me.txtprecio_unitario.TabIndex = 63
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(110, 320)
        Me.txtcantidad.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(68, 20)
        Me.txtcantidad.TabIndex = 64
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(267, 320)
        Me.txtstock.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtstock.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(78, 20)
        Me.txtstock.TabIndex = 65
        Me.txtstock.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Detalle_ventasTableAdapter
        '
        Me.Detalle_ventasTableAdapter.ClearBeforeFill = True
        '
        'DbventasDataSet7
        '
        Me.DbventasDataSet7.DataSetName = "dbventasDataSet7"
        Me.DbventasDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MostrardetalleventasBindingSource
        '
        Me.MostrardetalleventasBindingSource.DataMember = "mostrar_detalle_ventas"
        Me.MostrardetalleventasBindingSource.DataSource = Me.DbventasDataSet7
        '
        'Mostrar_detalle_ventasTableAdapter
        '
        Me.Mostrar_detalle_ventasTableAdapter.ClearBeforeFill = True
        '
        'Mostrar_detalle_ventasTableAdapter1
        '
        Me.Mostrar_detalle_ventasTableAdapter1.ClearBeforeFill = True
        '
        'btnimprimir
        '
        Me.btnimprimir.BackgroundImage = Global.sisventas.My.Resources.Resources.imprimir
        Me.btnimprimir.Location = New System.Drawing.Point(307, 373)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(105, 103)
        Me.btnimprimir.TabIndex = 66
        Me.btnimprimir.UseVisualStyleBackColor = True
        '
        'UpdateOrderOptionBindingSource
        '
        Me.UpdateOrderOptionBindingSource.DataSource = GetType(sisventas.datalistado5TableAdapters.TableAdapterManager.UpdateOrderOption)
        '
        'Generar_comprobanteTableAdapter
        '
        Me.Generar_comprobanteTableAdapter.ClearBeforeFill = True
        '
        'frmdetalle_venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 546)
        Me.Controls.Add(Me.btnimprimir)
        Me.Controls.Add(Me.txtstock)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.txtprecio_unitario)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnbuscar_producto)
        Me.Controls.Add(Me.txtidproducto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnombre_producto)
        Me.Controls.Add(Me.txtflag)
        Me.Controls.Add(Me.cbtipo_documento)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.txtnum_documento)
        Me.Controls.Add(Me.txtidcliente)
        Me.Controls.Add(Me.txtidventa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnombre_cliente)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmdetalle_venta"
        Me.Text = "listado en detalle de la venta actual"
        CType(Me.Datalistado2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datalistado2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbventasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MostrardetalleventasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbventasDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenerarcomprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbventasDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbventasDataSet6BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbventasDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleventasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datalistado4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datalistado3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbventasDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtstock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbventasDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MostrardetalleventasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpdateOrderOptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VentasTableAdapter1 As sisventas.dbventasDataSet5TableAdapters.ventasTableAdapter
    Friend WithEvents txtflag As System.Windows.Forms.TextBox
    Friend WithEvents Datalistado2 As sisventas.datalistado2
    Friend WithEvents cbtipo_documento As System.Windows.Forms.ComboBox
    Friend WithEvents txtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents txtnum_documento As System.Windows.Forms.TextBox
    Friend WithEvents txtidcliente As System.Windows.Forms.TextBox
    Friend WithEvents txtidventa As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ClienteBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Datalistado2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTableAdapter1 As sisventas.datalistado2TableAdapters.clienteTableAdapter
    Friend WithEvents VentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VentasTableAdapter As sisventas.datalistado2TableAdapters.ventasTableAdapter
    Friend WithEvents ClienteBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents VentasTableAdapter2 As sisventas.datalistado3TableAdapters.ventasTableAdapter
    Friend WithEvents ClienteBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents txtnombre_cliente As System.Windows.Forms.TextBox
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents erroricono As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbeliminar As System.Windows.Forms.CheckBox
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents inexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents datalistado1 As System.Windows.Forms.DataGridView
    Friend WithEvents VentasBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Datalistado3 As sisventas.datalistado3
    Friend WithEvents DbventasDataSet As sisventas.dbventasDataSet
    Friend WithEvents ClienteBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTableAdapter As sisventas.dbventasDataSetTableAdapters.clienteTableAdapter
    Friend WithEvents DbventasDataSet5 As sisventas.dbventasDataSet5
    Friend WithEvents VentasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents txtstock As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtcantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtprecio_unitario As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnbuscar_producto As System.Windows.Forms.Button
    Friend WithEvents txtidproducto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtnombre_producto As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Datalistado4 As sisventas.datalistado4
    Friend WithEvents DetalleventasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Detalle_ventasTableAdapter As sisventas.datalistado4TableAdapters.detalle_ventasTableAdapter
    Friend WithEvents UpdateOrderOptionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DbventasDataSet6BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DbventasDataSet6 As sisventas.dbventasDataSet6
    Friend WithEvents DbventasDataSet7 As sisventas.dbventasDataSet7
    Friend WithEvents MostrardetalleventasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mostrar_detalle_ventasTableAdapter As sisventas.dbventasDataSet7TableAdapters.mostrar_detalle_ventasTableAdapter
    Friend WithEvents DbventasDataSet8 As sisventas.dbventasDataSet8
    Friend WithEvents MostrardetalleventasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Mostrar_detalle_ventasTableAdapter1 As sisventas.dbventasDataSet8TableAdapters.mostrar_detalle_ventasTableAdapter
    Friend WithEvents btnimprimir As System.Windows.Forms.Button
    Friend WithEvents GenerarcomprobanteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DbventasDataSet11 As sisventas.dbventasDataSet11
    Friend WithEvents Generar_comprobanteTableAdapter As sisventas.dbventasDataSet11TableAdapters.generar_comprobanteTableAdapter
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents iddetalle_venta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio_unitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
