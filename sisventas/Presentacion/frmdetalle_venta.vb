

Imports System.Data.SqlClient

Imports System.Data





Public Class frmdetalle_venta

    Private dt As New DataTable
    Dim txtflag1 As Object
    Private dv As New DataView
    ' Private dv As New DataView
    Public Sub frmventadetalle_venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbventasDataSet8.mostrar_detalle_ventas' Puede moverla o quitarla según sea necesario.
        Me.Mostrar_detalle_ventasTableAdapter1.Fill(Me.DbventasDataSet8.mostrar_detalle_ventas)
        'TODO: esta línea de código carga datos en la tabla 'DbventasDataSet7.mostrar_detalle_ventas' Puede moverla o quitarla según sea necesario.
        ' Me.Mostrar_detalle_ventasTableAdapter.Fill(Me.DbventasDataSet7.mostrar_detalle_ventas)
        'TODO: esta línea de código carga datos en la tabla 'Datalistado4.detalle_ventas' Puede moverla o quitarla según sea necesario.
        ' Me.Detalle_ventasTableAdapter.Fill(Me.Datalistado4.detalle_ventas)
        'TODO: esta línea de código carga datos en la tabla 'Datalistado3.ventas' Puede moverla o quitarla según sea necesario.
        ' Me.VentasTableAdapter2.Fill(Me.Datalistado3.ventas)
        'TODO: esta línea de código carga datos en la tabla 'DbventasDataSet5.ventas' Puede moverla o quitarla según sea necesario.
        '  Me.VentasTableAdapter1.Fill(Me.DbventasDataSet5.ventas)
        'TODO: esta línea de código carga datos en la tabla 'Datalistado2.ventas' Puede moverla o quitarla según sea necesario.
        ' Me.VentasTableAdapter.Fill(Me.Datalistado2.ventas)
        'TODO: esta línea de código carga datos en la tabla 'Datalistado2.cliente' Puede moverla o quitarla según sea necesario.
        ' Me.ClienteTableAdapter1.Fill(Me.Datalistado2.cliente)



        txtidventa.Text = Module1.idventa
        txtidcliente.Text = Module1.idcliente
        txtnum_documento.Text = Module1.num_documento
        cbtipo_documento.Text = Module1.tipo_documento
        txtfecha.Text = Module1.fecha_venta
        txtnombre_cliente.Text = Module1.nombre_cliente





    End Sub


    Public Sub limpiar()
        btnguardar.Visible = True


        txtidproducto.Text = ""
        txtnombre_producto.Text = ""
        txtprecio_unitario.Text = ""
        txtcantidad.Text = 0
        txtstock.Text = 1


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
                ocultar_columnas()

            Else
                inexistente.Visible = True
                datalistado1.DataSource = Nothing

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub ocultar_columnas()
        datalistado1.Columns(1).Visible = False
        datalistado1.Columns(2).Visible = False
        ' datalistado1.Columns(4).Visible = False
    End Sub







    Private Sub btnnuevo_Click(sender As Object, e As EventArgs)
        limpiar()
        '  mostrar()

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
        If Me.ValidateChildren = True And txtidproducto.Text <> "" And txtcantidad.Text <> "" And txtprecio_unitario.Text <> "" Then
            Try
                Dim dts As New vdetalle_venta
                Dim func As New fdetalle_venta

                dts.gidventa = txtidventa.Text
                dts.gidproducto = txtidproducto.Text
                dts.gcantidad = txtcantidad.Text
                dts.gprecio_unitario = txtprecio_unitario.Text
                ' ocultar_columnas()



                If func.insertar(dts) Then
                    If func.disminuir_stock(dts) Then

                    End If
                    MessageBox.Show("Articulo fue registrado correctamente AGREGUE PRODUCTOS AL CARRITO", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Me.VentasTableAdapter.Fill(Me.Datalistado2.ventas)
                    'TODO: esta línea de código carga datos en la tabla 'Datalistado2.cliente' Puede moverla o quitarla según sea necesario.
                    '  Me.ClienteTableAdapter1.Fill(Me.Datalistado2.cliente)
                    '   Me.ClienteTableAdapter1.Fill(Me.Datalistado2.cliente)
                    '  mostrar()
                    '  Me.VentasTableAdapter2.Fill(Me.Datalistado3.ventas)
                    '  Me.Mostrar_detalle_ventasTableAdapter.Fill(Me.DbventasDataSet7.mostrar_detalle_ventas)

                    Me.Mostrar_detalle_ventasTableAdapter1.Fill(Me.DbventasDataSet8.mostrar_detalle_ventas)
                    limpiar()


                Else
                    MessageBox.Show("articulo no registrado intente de nuevo", "registro no guardado", MessageBoxButtons.OK, MessageBoxIcon.Error)
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





    Private Sub btnbuscar_producto_Click(sender As Object, e As EventArgs) Handles btnbuscar_producto.Click
        frmproducto.txtflag.Text = "1"
        frmproducto.ShowDialog()

    End Sub



    Private Sub txtcantidad_ValueChanged(sender As Object, e As EventArgs) Handles txtcantidad.ValueChanged
        Dim cant As Double
        cant = txtcantidad.Value

        If txtcantidad.Value > txtstock.Value Then

            MessageBox.Show("la cantidad que intenta vender supera stock", "error al vender producto", MessageBoxButtons.OK, MessageBoxIcon.Information)

            btnguardar.Visible = 0
            txtcantidad.Value = txtstock.Value
        Else
            btnguardar.Visible = 1
        End If


        If txtcantidad.Value = 0 Then
            btnguardar.Visible = 0
        Else
            btnguardar.Visible = 1
        End If





    End Sub










    Private Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click
        frmreportecomprobante.txtidventa.Text = Me.txtidventa.Text
        frmreportecomprobante.ShowDialog()
    End Sub


    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Dim cnn = New SqlConnection("data source=(local);initial catalog=dbventas;integrated security=true")

        Dim da As New SqlDataAdapter("SELECT * FROM detalle_ventas ", cnn)
        Dim ds As New DataSet
        da.Fill(ds)
        dv.Table = ds.Tables(0)
        datalistado1.DataSource = dv


        dv.RowFilter = String.Format("idventa like'%{0}%'", txtbuscar.Text)
    End Sub

    Private Sub datalistado1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado1.CellDoubleClick

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim result As DialogResult

        result = MessageBox.Show("REALMENTE DESEA ELIMINAR ARTICULOS DE LA VENTA?", "ELIMINANDO REGISTROS", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            Try
                For Each row As DataGridViewRow In datalistado1.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("eliminar").Value)


                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("iddetalle_venta").Value)
                        Dim dts As New vdetalle_venta
                        Dim func As New fdetalle_venta
                        dts.giddetalle_venta = onekey

                        dts.gidproducto = datalistado1.SelectedCells.Item(3).Value
                        dts.gidventa = datalistado1.SelectedCells.Item(2).Value
                        dts.gcantidad = datalistado1.SelectedCells.Item(5).Value


                        If func.eliminar(dts) Then
                            func.aumentar_stock(dts)
                            MessageBox.Show("articulo fue quitado de la venta", "ELIMINANDO REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Information)


                        Else



                        End If



                    End If


                Next
                '  Me.ClienteTableAdapter.Fill(Me.DbventasDataSet.cliente)
                ' Call mostrar()
                Me.Mostrar_detalle_ventasTableAdapter1.Fill(Me.DbventasDataSet8.mostrar_detalle_ventas)
            Catch ex As Exception
                MsgBox(ex.Message)


            End Try
        Else
            MessageBox.Show("CANCELANDO ELIMINACION", "ELIMINANDO REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '  Call mostrar()

        End If

        Call limpiar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim result As DialogResult

        result = MessageBox.Show("REALMENTE DESEA ELIMINAR ARTICULOS SELECCIONADOS?", "ELIMINANDO REGISTROS", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            Try
                For Each row As DataGridViewRow In datalistado1.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("eliminar").Value)


                    If marcado Then
                        
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("iddetalle_venta").Value)
                        Dim dts As New vdetalle_venta
                        Dim func As New fdetalle_venta
                        If func.aumentar_stock(dts) Then

                        End If
                        dts.giddetalle_venta = onekey
                        dts.gidproducto = datalistado1.SelectedCells.Item(3).Value
                        dts.gidventa = datalistado1.SelectedCells.Item(2).Value
                        dts.gcantidad = datalistado1.SelectedCells.Item(5).Value


                        If func.eliminar(dts) Then
                            If func.aumentar_stock(dts) Then

                            End If
                        Else
                            MessageBox.Show("ARTICULO FUE ELIMINADO", "ELIMINANDO REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If



                    End If


                Next
                Me.ClienteTableAdapter.Fill(Me.DbventasDataSet.cliente)
                ' Call mostrar()

            Catch ex As Exception
                MsgBox(ex.Message)


            End Try
        Else
            MessageBox.Show("CANCELANDO ELIMINACION", "ELIMINANDO REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '  Call mostrar()

        End If

        Call limpiar()
    End Sub

End Class