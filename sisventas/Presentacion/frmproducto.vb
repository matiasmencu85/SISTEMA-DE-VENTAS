Imports System.Data.SqlClient

Imports System.Data
Public Class frmproducto
    Private dt As New DataTable
    Private dv As New DataView
    Private Sub frmproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbventasDataSet4.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter2.Fill(Me.DbventasDataSet4.producto)
        'TODO: esta línea de código carga datos en la tabla 'Datalistado1.producto' Puede moverla o quitarla según sea necesario.
        '  Me.ProductoTableAdapter.Fill(Me.DbventasDataSet3.producto)
        'TODO: esta línea de código carga datos en la tabla 'DbventasDataSet2.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.DbventasDataSet2.producto)
        txtidcategoria.Visible = False

    End Sub

    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtnombre.Text = ""
        txtidcategoria.Text = ""
        txtnom_categoria.Text = ""
        txtdescripcion.Text = ""
        txtstock.Text = "0"
        txtprecio_compra.Text = "0"
        txtprecio_venta.Text = "0"
        txtidproducto.Text = ""
        imagen.Image = Nothing
        imagen.BackgroundImage = My.Resources.blanco

        imagen.SizeMode = PictureBoxSizeMode.StretchImage



    End Sub


    Private Sub mostrar()
        Try
            Dim func As New fproducto
            dt = func.mostrar
            datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False


            Else
                datalistado.DataSource = Nothing
                txtbuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True

            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        btnnuevo.Visible = True
        btneditar.Visible = False

        buscar()
    End Sub


    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = cbocampo.Text & " like'" & txtbuscar.Text & " %' "

            If dv.Count <> 0 Then

                inexistente.Visible = False
                datalistado.DataSource = dv
                ocultar_columnas()

            Else
                inexistente.Visible = True
                datalistado.DataSource = Nothing

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
        datalistado.Columns(2).Visible = False

    End Sub



    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtidcategoria.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese nombre de producto por favor, campo obligatorio")

        End If


    End Sub







    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        Me.ProductoTableAdapter.Fill(Me.DbventasDataSet2.producto)
        ' mostrar()

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Me.ProductoTableAdapter.Fill(Me.DbventasDataSet2.producto)
        If Me.ValidateChildren = True And txtidcategoria.Text <> ""and txtnombre.Text <> ""And txtdescripcion.Text <> "" And txtstock.Text <> "" And txtprecio_compra.Text <> "" And txtprecio_venta.Text <> "" Then
            Try
                Dim dts As New vproducto
                Dim func As New fproducto


                dts.gnombre = txtnombre.Text
                dts.gidcategoria = txtidcategoria.Text

                dts.gdescripcion = txtdescripcion.Text
                dts.gstock = txtstock.Text
                dts.gprecio_compra = txtprecio_compra.Text
                dts.gprecio_venta = txtprecio_venta.Text
                dts.gfecha_vencimiento = txtfecha_vencimiento.Text


                Dim ms As New IO.MemoryStream()

                If Not imagen.Image Is Nothing Then
                    imagen.Image.Save(ms, imagen.Image.RawFormat)
                Else
                    imagen.Image = My.Resources.blanco
                    imagen.Image.Save(ms, imagen.Image.RawFormat)

                End If

                dts.gimagen = ms.GetBuffer




                If func.insertar(dts) Then
                    MessageBox.Show("producto registrado correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.ProductoTableAdapter.Fill(Me.DbventasDataSet2.producto)
                    '  mostrar()
                    '  limpiar()
                Else
                    MessageBox.Show("producto no registrado intente de nuevo", "registro no guardado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MessageBox.Show("FALTAN INGRESAR ALGUNOS DATOS", "registro no guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If


    End Sub


    Private Sub datalistado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentDoubleClick


        If e.ColumnIndex = Me.datalistado.Columns.Item("eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value

            ' End If








            '  If txtflag.Text = "1" Then


            txtidproducto.Text = datalistado.SelectedCells.Item(1).Value
            txtnombre.Text = datalistado.SelectedCells.Item(2).Value
            txtdescripcion.Text = datalistado.SelectedCells.Item(3).Value
            txtstock.Text = datalistado.SelectedCells.Item(4).Value
            txtprecio_compra.Text = datalistado.SelectedCells.Item(5).Value
            txtprecio_venta.Text = datalistado.SelectedCells.Item(6).Value
            txtfecha_vencimiento.Text = datalistado.SelectedCells.Item(7).Value
            ' txtidcategoria.Text = datalistado.SelectedCells.Item(8).Value
            ' txtnom_categoria.Text = datalistado.SelectedCells.Item(8).Value
            imagen.BackgroundImage = Nothing
            Dim b() As Byte = datalistado.SelectedCells.Item(8).Value
            Dim ms As New IO.MemoryStream(b)

            imagen.Image = Image.FromStream(ms)

            imagen.SizeMode = PictureBoxSizeMode.StretchImage


        End If
    End Sub






    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

        '  If e.ColumnIndex = Me.datalistado.Columns.Item("eliminar").Index Then
        ' Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
        ' chkcell.Value = Not chkcell.Value

        'End If 
        btneditar.Visible = True
        If txtflag.Text = "1" Then
            frmcategoria.txtidcategoria.Text = datalistado.SelectedCells.Item(3).Value
            frmcategoria.txtnombre.Text = datalistado.SelectedCells.Item(5).Value
            frmdetalle_venta.txtidproducto.Text = datalistado.SelectedCells.Item(1).Value
            frmdetalle_venta.txtnombre_producto.Text = datalistado.SelectedCells.Item(2).Value
            frmdetalle_venta.txtstock.Text = datalistado.SelectedCells.Item(4).Value
            frmdetalle_venta.txtprecio_unitario.Text = datalistado.SelectedCells.Item(6).Value

            Me.Close()

        End If



    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click

        Dim result As DialogResult
        result = MessageBox.Show("realmente desea editar los datos del producto?", "modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)


        If result = DialogResult.OK Then



            If Me.ValidateChildren = True And txtidcategoria.Text <> "" And txtnom_categoria.Text <> "" And txtdescripcion.Text <> "" And txtstock.Text <> "" And txtprecio_compra.Text <> "" And txtprecio_venta.Text <> "" And txtidproducto.Text <> "" Then
                Try
                    Dim dts As New vproducto
                    Dim func As New fproducto

                    dts.gidproducto = txtidproducto.Text
                    dts.gnombre = txtnombre.Text
                    dts.gidcategoria = txtidcategoria.Text
                    dts.gnom_categoria = txtnom_categoria.Text
                    dts.gdescripcion = txtdescripcion.Text
                    dts.gstock = txtstock.Text
                    dts.gprecio_compra = txtprecio_compra.Text
                    dts.gprecio_venta = txtprecio_venta.Text
                    dts.gfecha_vencimiento = txtfecha_vencimiento.Text


                    Dim ms As New IO.MemoryStream()

                    If Not imagen.Image Is Nothing Then
                        imagen.Image.Save(ms, imagen.Image.RawFormat)
                    Else
                        imagen.Image = My.Resources.blanco
                        imagen.Image.Save(ms, imagen.Image.RawFormat)

                    End If

                    dts.gimagen = ms.GetBuffer
                    If func.editar(dts) Then
                        MessageBox.Show("producto modificado correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.ProductoTableAdapter2.Fill(Me.DbventasDataSet4.producto)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("producto no modificado intente de nuevo", "registro no guardado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
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

    Private Sub cbeliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistado.Columns.Item("Eliminar").Visible = True
        Else
            datalistado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click

        Dim result As DialogResult

        result = MessageBox.Show("REALMENTE DESEA ELIMINAR LOS PRODUCTOS SELECCIONADOS?", "ELIMINANDO REGISTROS", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("eliminar").Value)


                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idproducto").Value)
                        Dim vdb As New vproducto
                        Dim func As New fproducto
                        vdb.gidproducto = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("PRODUCTO NO FUE ELIMINADO", "ELIMINANDO REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If



                    End If


                Next
                Me.ProductoTableAdapter2.Fill(Me.DbventasDataSet4.producto)
                ' Call mostrar()

            Catch ex As Exception
                MsgBox(ex.Message)


            End Try
        Else
            MessageBox.Show("CANCELANDO ELIMINACION", "ELIMINANDO REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()

        End If

        Call limpiar()

    End Sub






    Private Sub btncargar_Click(sender As Object, e As EventArgs) Handles btncargar.Click

        If dlg.ShowDialog() = DialogResult.OK Then
            imagen.BackgroundImage = Nothing
            imagen.Image = New Bitmap(dlg.FileName)
            imagen.SizeMode = PictureBoxSizeMode.StretchImage

        End If





    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click

        imagen.Image = Nothing
        imagen.BackgroundImage = My.Resources.blanco

        imagen.SizeMode = PictureBoxSizeMode.StretchImage



    End Sub

    Private Sub btnbuscarcategoria_Click(sender As Object, e As EventArgs) Handles btnbuscarcategoria.Click
        frmcategoria.txtflag.Text = "1"
        frmcategoria.ShowDialog()
    End Sub

    


    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Dim cnn = New SqlConnection("data source=(local);initial catalog=dbventas;integrated security=true")

        Dim da As New SqlDataAdapter("SELECT * FROM producto", cnn)
        Dim ds As New DataSet
        da.Fill(ds)
        dv.Table = ds.Tables(0)
        datalistado.DataSource = dv


        dv.RowFilter = String.Format("nombre like'%{0}%'", txtbuscar.Text)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Close()
    End Sub
End Class