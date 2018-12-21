

Imports System.Data.SqlClient

Imports System.Data


Public Class frmventa
    Private dt As New DataTable

    Private dv As New DataView
    Private Sub frmventa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbventasDataSet9.mostrar_venta' Puede moverla o quitarla según sea necesario.
        Me.Mostrar_ventaTableAdapter.Fill(Me.DbventasDataSet9.mostrar_venta)
        'TODO: esta línea de código carga datos en la tabla 'Datalistado3.ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter2.Fill(Me.Datalistado3.ventas)
        'TODO: esta línea de código carga datos en la tabla 'DbventasDataSet5.ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter1.Fill(Me.DbventasDataSet5.ventas)
        'TODO: esta línea de código carga datos en la tabla 'Datalistado2.ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.Datalistado2.ventas)
        'TODO: esta línea de código carga datos en la tabla 'Datalistado2.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter1.Fill(Me.Datalistado2.cliente)

    End Sub



    ' Private Sub mostrar()
    '      Try
    ' Dim func As New fventas
    '        dt = func.mostrar
    '       Datalistado2.Columns.Item("Eliminar").Visible = False
    '
    ''       If dt.Rows.Count <> 0 Then
    '         Datalistado2.DataSource = dt
    '        txtbuscar.Enabled = True
    '       Datalistado2.ColumnHeadersVisible = True
    '      inexistente.Visible = False
    '

    '       Else
    '          Datalistado2.DataSource = Nothing
    '         txtbuscar.Enabled = False
    '        Datalistado2.ColumnHeadersVisible = False
    '       inexistente.Visible = True
    '
    '       End If



    '   Catch ex As Exception
    '        MsgBox(ex.Message)
    '  End Try
    ' btnnuevo.Visible = True
    'btneditar.Visible = False

    '    buscar()
    'End Sub

    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = True
        txtidcliente.Visible = True

        txtidcliente.Text = ""
        txtnum_documento.Text = ""
        txtnombre_cliente.Text = ""
        txtidventa.Text = ""


    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            '    dv.RowFilter = cbocampo.Text & " like'" & txtbuscar.Text & " %'"

            If dv.Count <> 0 Then

                inexistente.Visible = False
                datalistado1.DataSource = dv
                '  ocultar_columnas()

            Else
                inexistente.Visible = True
                datalistado1.DataSource = Nothing

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub ocultar_columnas()
        datalistado1.Columns(1).Visible =  False 
        datalistado1.Columns(2).Visible = False

    End Sub








   

    Private Sub datalistado1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado1.CellClick
        txtidcliente.Visible = True
        txtidventa.Visible = True


        txtidventa.Text = datalistado1.SelectedCells.Item(0).Value
        txtidcliente.Text = datalistado1.SelectedCells.Item(1).Value
        txtnombre_cliente.Text = datalistado1.SelectedCells.Item(2).Value
        txtfecha.Text = datalistado1.SelectedCells.Item(3).Value
        cbtipo_documento.Text = datalistado1.SelectedCells.Item(4).Value
        txtnum_documento.Text = datalistado1.SelectedCells.Item(5).Value

        btneditar.Visible = True
        btnguardar.Visible = True


    End Sub

    
    
    ' Private Sub datalistado1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick

    '   If txtflag.Text = "1" Then
    '            frmventa.txtidcliente.Text =  datalistado1 .SelectedCells.Items(1)Value
    '            frmventa.txtnombre_cliente.Text = datalistado1.SelectedCells.Items(2)Value
    ' Me.Close()




    '  End If


    'End Sub

   





    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs)
        Dim cnn = New SqlConnection("data source=(local);initial catalog=dbventas;integrated security=true")

        Dim da As New SqlDataAdapter("SELECT * FROM cliente", cnn)
        Dim ds As New DataSet
        da.Fill(ds)
        dv.Table = ds.Tables(0)
        datalistado1.DataSource = dv


        dv.RowFilter = String.Format("nombre like'%{0}%'", txtbuscar.Text)
    End Sub




    Public Sub cargar_detalle()

        frmdetalle_venta.txtidventa.Text = datalistado1.SelectedCells.Item(0).Value
        frmdetalle_venta.txtidcliente.Text = datalistado1.SelectedCells.Item(1).Value
        ' frmdetalle_venta.txtnombre_cliente = datalistado1.SelectedCells.Item(2).Value
        frmdetalle_venta.txtfecha.Text = datalistado1.SelectedCells.Item(3).Value
        frmdetalle_venta.cbtipo_documento.Text = datalistado1.SelectedCells.Item(4).Value
        frmdetalle_venta.txtnum_documento.Text = datalistado1.SelectedCells.Item(5).Value

        ' Me.VentasTableAdapter1.Fill(Me.DbventasDataSet5.ventas)
        frmdetalle_venta.ShowDialog()





    End Sub









    Private Sub datalistado1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado1.CellDoubleClick


        cargar_detalle()


    End Sub

    Private Sub btnbuscar_cliente_Click(sender As Object, e As EventArgs) Handles btnbuscar_cliente.Click
        frmcliente.txtflag.Text = "1"
        frmcliente.ShowDialog()


    End Sub

    Private Sub cbeliminar_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistado1.Columns.Item("Eliminar").Visible = True
        Else
            datalistado1.Columns.Item("Eliminar").Visible = False
        End If
       
    End Sub


    

   
    
    Private Sub datalistado1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado1.CellContentClick

        If e.ColumnIndex = Me.datalistado1.Columns.Item("eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado1.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value

        End If





    End Sub

    Private Sub btnguardar_Click_1(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtidcliente.Text <> "" And txtnombre_cliente.Text <> "" And txtnum_documento.Text <> "" Then
            Try
                Dim dts As New vventas
                Dim func As New fventas

                dts.gidventa = txtidventa.Text
                dts.gidcliente = txtidcliente.Text
                dts.gfecha_venta = txtfecha.Text
                dts.gtipo_documento = cbtipo_documento.Text
                dts.gnum_documento = txtnum_documento.Text

                




                If func.insertar(dts) Then
                    MessageBox.Show("venta registrada correctamente AGREGUE PRODUCTOS AL CARRITO", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Mostrar_ventaTableAdapter.Fill(Me.DbventasDataSet9.mostrar_venta)
                   

                Else
                    MessageBox.Show("venta no registrada intente de nuevo", "registro no guardado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ' mostrar()
                    limpiar()
                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MessageBox.Show("FALTAN INGRESAR ALGUNOS DATOS", "registro no guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If
    End Sub

    Private Sub txtbuscartipo_TextChanged_1(sender As Object, e As EventArgs) Handles txtbuscartipo.TextChanged
        Dim cnn = New SqlConnection("data source=(local);initial catalog=dbventas;integrated security=true")

        Dim da As New SqlDataAdapter("SELECT * FROM ventas ", cnn)
        Dim ds As New DataSet
        da.Fill(ds)
        dv.Table = ds.Tables(0)
        datalistado1.DataSource = dv


        dv.RowFilter = String.Format("tipo_documento like'%{0}%'", txtbuscartipo.Text)
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("realmente desea editar los datos de la venta?", "modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)


        If result = DialogResult.OK Then



            If Me.ValidateChildren = True And txtidcliente.Text <> "" And txtnum_documento.Text <> "" And txtidventa.Text <> "" Then
                Try
                    Dim dts As New vventas
                    Dim func As New fventas

                    dts.gidventa = txtidventa.Text
                    dts.gidcliente = txtidcliente.Text
                    ' dts.gnombre_cliente = txtnombre_cliente.Text
                    dts.gfecha_venta = txtfecha.Text
                    dts.gtipo_documento = cbtipo_documento.Text
                    dts.gnum_documento = txtnum_documento.Text


                    If func.editar(dts) Then
                        MessageBox.Show("venta modificado correctamente", "modificando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Me.VentasTableAdapter.Fill(Me.Datalistado2.ventas)
                        'TODO: esta línea de código carga datos en la tabla 'Datalistado2.cliente' Puede moverla o quitarla según sea necesario.
                        Me.ClienteTableAdapter1.Fill(Me.Datalistado2.cliente)

                        '  mostrar()
                        '  limpiar()
                    Else
                        MessageBox.Show("venta no modificado intente de nuevo", "registro no modificado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ' mostrar()
                        limpiar()
                    End If


                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Else
                MessageBox.Show("FALTAN INGRESAR ALGUNOS DATOS", "registro no guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnguardar1.Click

        Module1.idventa = txtidventa.Text
        Module1.idcliente = txtidcliente.Text
        Module1.nombre_cliente = txtnombre_cliente.Text
        Module1.fecha_venta = txtfecha.Text
        Module1.tipo_documento = cbtipo_documento.Text
        Module1.num_documento = txtnum_documento.Text

        frmdetalle_venta.ShowDialog()




    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click

    End Sub

    Private Sub btnnuevo_Click_1(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub

    Private Sub txtbuscar_TextChanged_1(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged

    End Sub
End Class