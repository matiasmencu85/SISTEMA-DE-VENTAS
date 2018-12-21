
Imports System.Data.SqlClient

Imports System.Data

Public Class frmcliente
    Private dt As New DataTable

    Private dv As New DataView


    Private Sub frmcliente_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbventasDataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.DbventasDataSet.cliente)
        'TODO: esta línea de código carga datos en la tabla 'DbventasDataSet.cliente' Puede moverla o quitarla según sea necesario.


        'TODO: esta línea de código carga datos en la tabla 'DbventasDataSet.cliente' Puede moverla o quitarla según sea necesario.
        txtidcliente.Visible = False
        ' mostrar()


    End Sub


    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtidcliente.Visible = False
        txtnombre.Text = ""
        txtapellidos.Text = ""
        txtdireccion.Text = ""
        txttelefono.Text = ""
        txtdni.Text = ""
        txtidcliente.Text = ""


    End Sub


    Private Sub mostrar()
        Try
            Dim func As New fcliente
            dt = func.mostrar
            datalistado1.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado1.DataSource = dt
                txtbuscar.Enabled = True
                datalistado1.ColumnHeadersVisible = True
                inexistente.Visible = False


            Else
                datalistado1.DataSource = Nothing
                txtbuscar.Enabled = False
                datalistado1.ColumnHeadersVisible = False
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

    End Sub



    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese nombre del cliente por favor, campo obligatorio")

        End If


    End Sub

    Private Sub txtapellidos_TextValidating(sender As Object, e As EventArgs) Handles txtapellidos.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "ingrese apellido del cliente por favor, campo obligatorio")

        End If
    End Sub

    ' Private Sub txtdireccion_TextValidating(sender As Object, e As EventArgs) Handles txtdireccion.TextChanged
    '    If DirectCast(sender, TextBox).Text.Length > 0 Then
    '       Me.erroricono.SetError(sender, "")
    '   Else
    '      Me.erroricono.SetError(sender, "ingrese direccion del cliente por favor, campo obligatorio")

    '    End If
    'End Sub

    'Private Sub txtdni_TextValidating(sender As Object, e As EventArgs) Handles txtdni.TextChanged
    '   If DirectCast(sender, TextBox).Text.Length > 0 Then
    '      Me.erroricono.SetError(sender, "")
    ' Else
    '    Me.erroricono.SetError(sender, "ingrese dni del cliente por favor, campo obligatorio")

    '    End If
    'End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        If Me.ValidateChildren = True And txtnombre.Text <> "" And txtapellidos.Text <> "" Then
            Try
                Dim dts As New vcliente
                Dim func As New fcliente


                dts.gnombres = txtnombre.Text
                dts.gapellido = txtapellidos.Text
                dts.gdireccion = txtdireccion.Text
                dts.gtelefono = txttelefono.Text
                dts.gdni = txtdni.Text

                If func.insertar(dts) Then
                    MessageBox.Show("cliente registrado correctamente", "guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.ClienteTableAdapter.Fill(Me.DbventasDataSet.cliente)
                    '  mostrar()
                    '  limpiar()
                Else
                    MessageBox.Show("cliente no registrado intente de nuevo", "registro no guardado", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado1.CellClick
        txtidcliente.Visible = False

        txtidcliente.Text = datalistado1.SelectedCells.Item(0).Value
        txtnombre.Text = datalistado1.SelectedCells.Item(1).Value
        txtapellidos.Text = datalistado1.SelectedCells.Item(2).Value
        txtdireccion.Text = datalistado1.SelectedCells.Item(3).Value
        txttelefono.Text = datalistado1.SelectedCells.Item(4).Value
        txtdni.Text = datalistado1.SelectedCells.Item(5).Value

        btneditar.Visible = True
        btnguardar.Visible = False


    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado1.CellContentClick

        If e.ColumnIndex = Me.datalistado1.Columns.Item("eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado1.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value

        End If




    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click

        Dim result As DialogResult
        result = MessageBox.Show("realmente desea editar los datos del cliente?", "modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)


        If result = DialogResult.OK Then



            If Me.ValidateChildren = True And txtnombre.Text <> "" And txtapellidos.Text <> "" And txtdireccion.Text <> "" And txttelefono.Text <> "" And txtdni.Text <> "" And txtidcliente.Text <> "" Then
                Try
                    Dim dts As New vcliente
                    Dim func As New fcliente

                    dts.gidcliente = txtidcliente.Text
                    dts.gnombres = txtnombre.Text
                    dts.gapellido = txtapellidos.Text
                    dts.gdireccion = txtdireccion.Text
                    dts.gtelefono = txttelefono.Text
                    dts.gdni = txtdni.Text

                    If func.editar(dts) Then
                        MessageBox.Show("cliente modificado correctamente", "modificando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.ClienteTableAdapter.Fill(Me.DbventasDataSet.cliente)
                        '  mostrar()
                        '  limpiar()
                    Else
                        MessageBox.Show("cliente no modificado intente de nuevo", "registro no modificado", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            datalistado1.Columns.Item("Eliminar").Visible = True
        Else
            datalistado1.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click

        Dim result As DialogResult

        result = MessageBox.Show("REALMENTE DESEA ELIMINAR LOS CLIENTE SELECCIONADOS?", "ELIMINANDO REGISTROS", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            Try
                For Each row As DataGridViewRow In datalistado1.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("eliminar").Value)


                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idcliente").Value)
                        Dim vdb As New vcliente
                        Dim func As New fcliente
                        vdb.gidcliente = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("CLIENTE NO FUE ELIMINADO", "ELIMINANDO REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            Call mostrar()

        End If

        Call limpiar()

    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Dim cnn = New SqlConnection("data source=(local);initial catalog=dbventas;integrated security=true")

        Dim da As New SqlDataAdapter("SELECT * FROM cliente", cnn)
        Dim ds As New DataSet
        da.Fill(ds)
        dv.Table = ds.Tables(0)
        datalistado1.DataSource = dv


        dv.RowFilter = String.Format("nombre like'%{0}%'", txtbuscar.Text)
    End Sub


    Private Sub txtbuscadni_TextChanged(sender As Object, e As EventArgs) Handles txtbuscadni.TextChanged
        Dim cnn = New SqlConnection("data source=(local);initial catalog=dbventas;integrated security=true")

        Dim da As New SqlDataAdapter("SELECT * FROM cliente", cnn)
        Dim ds As New DataSet
        da.Fill(ds)
        dv.Table = ds.Tables(0)
        datalistado1.DataSource = dv


        dv.RowFilter = String.Format("dni like'%{0}%'", txtbuscadni.Text)
    End Sub


    Private Sub datalistado1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado1.CellDoubleClick
        If txtflag.Text Then
            frmventa.txtidcliente.Text = datalistado1.SelectedCells.Item(0).Value
            frmventa.txtnombre_cliente.Text = datalistado1.SelectedCells.Item(2).Value
            Me.Close()
        End If
    End Sub
End Class