Imports System.Data.SqlClient

Imports System.Data



Public Class frmcategoria
    Private dt As New DataTable


    Private dv As New DataView

    Private Sub frmcategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbventasDataSet1.categoria' Puede moverla o quitarla según sea necesario.
        Me.CategoriaTableAdapter.Fill(Me.DbventasDataSet1.categoria)



    End Sub

    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = True
        txtnombre.Text = ""
        txtidcategoria.Text = ""



    End Sub


    Private Sub mostrar()
        Try
            Dim func As New fcategoria
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


            dv.RowFilter = cbocampo.Text & " like'" & txtbuscar.Text & " %'"

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

    End Sub



    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged


        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese nombre de la categoria por favor, campo obligatorio")

        End If


    End Sub



    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click


        limpiar()
        ' mostrar()
        txtidcategoria.Visible = False
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        If Me.ValidateChildren = True And txtnombre.Text <> "" Then
            Try
                Dim dts As New vcategoria
                Dim func As New fcategoria


                dts.gnombre_categoria = txtnombre.Text


                If func.insertar(dts) Then
                    MessageBox.Show("categoria registrada correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Me.CategoriaTableAdapter.Fill(Me.DbventasDataSet1.categoria)

                    mostrar()
                    '  limpiar()
                Else
                    MessageBox.Show("categoria no registrado intente de nuevo", "registro no guardado", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    '   Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick

    '        txtidcategoria.Text = datalistado.SelectedCells.Item(1).Value
    '       txtnombre.Text = datalistado.SelectedCells.Item(2).Value


    '    btneditar.Visible = True
    '   btnguardar.Visible = False


    'End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

        If e.ColumnIndex = Me.datalistado.Columns.Item("eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value

        End If




    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click

        Dim result As DialogResult
        result = MessageBox.Show("realmente desea editar los datos de la categoria?", "modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)


        If result = DialogResult.OK Then



            If Me.ValidateChildren = True And txtnombre.Text <> "" And txtidcategoria.Text <> "" Then
                Try
                    Dim dts As New vcategoria
                    Dim func As New fcategoria

                    dts.gidcategoria = txtidcategoria.Text
                    dts.gnombre_categoria = txtnombre.Text


                    If func.editar(dts) Then
                        MessageBox.Show("categoria a sido modificada correctamente", "modificando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Me.CategoriaTableAdapter.Fill(Me.DbventasDataSet1.categoria)
                        '  mostrar()
                        '  limpiar()
                    Else
                        MessageBox.Show("categoria no modificado intente de nuevo", "registro no modificado", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

        result = MessageBox.Show("REALMENTE DESEA ELIMINAR LAS CATEGORIAS SELECCIONADAS?", "ELIMINANDO REGISTROS", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("eliminar").Value)


                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idcategoria").Value)
                        Dim vdb As New vcategoria
                        Dim func As New fcategoria
                        vdb.gidcategoria = onekey

                        If func.eliminar(vdb) Then

                        Else
                            MessageBox.Show("CATEGORIA NO FUE ELIMINADO", "ELIMINANDO REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If



                    End If


                Next
                Me.CategoriaTableAdapter.Fill(Me.DbventasDataSet1.categoria)
                ' Call mostrar()

            Catch ex As Exception
                MsgBox(ex.Message)


            End Try
        Else
            MessageBox.Show("CANCELANDO ELIMINACION", "ELIMINANDO REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Call mostrar()
            Me.CategoriaTableAdapter.Fill(Me.DbventasDataSet1.categoria)
        End If

        Call limpiar()

    End Sub






    Private Sub datalistado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentDoubleClick
        If txtflag.Text = "1" Then
            frmproducto.txtidcategoria.Text = datalistado.SelectedCells.Item(1).Value
            frmproducto.txtnom_categoria.Text = datalistado.SelectedCells.Item(2).Value
            Me.Close()
        End If
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged

        Dim cnn = New SqlConnection("data source=(local);initial catalog=dbventas;integrated security=true")

        Dim da As New SqlDataAdapter("SELECT * FROM categoria", cnn)
        Dim ds As New DataSet
        da.Fill(ds)
        dv.Table = ds.Tables(0)
        datalistado.DataSource = dv


        dv.RowFilter = String.Format("nombre_categoria like'%{0}%'", txtbuscar.Text)





    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Close()

    End Sub
End Class