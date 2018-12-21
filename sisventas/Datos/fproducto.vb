
Imports System.Data.SqlClient

Public Class fproducto

    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try

            conectado()
            cmd = New SqlCommand("mostrar_producto")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            desconectado()
        End Try




    End Function


    Public Function insertar(ByVal dts As vproducto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idcategoria", dts.gidcategoria)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@descripcion", dts.gdescripcion)
            cmd.Parameters.AddWithValue("@stock", dts.gstock)
            cmd.Parameters.AddWithValue("@precio_compra", dts.gprecio_compra)
            cmd.Parameters.AddWithValue("@precio_venta", dts.gprecio_venta)
            cmd.Parameters.AddWithValue("@fecha_vencimiento", dts.gfecha_vencimiento)
            cmd.Parameters.AddWithValue("@imagen", dts.gimagen)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If


        Catch ex As Exception

            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()




        End Try



    End Function



    Public Function editar(ByVal dts As vproducto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idproducto", dts.gidproducto)
            cmd.Parameters.AddWithValue("@idcategoria", dts.gidcategoria)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@descripcion", dts.gdescripcion)
            cmd.Parameters.AddWithValue("@stock", dts.gstock)
            cmd.Parameters.AddWithValue("@precio_compra", dts.gprecio_compra)
            cmd.Parameters.AddWithValue("@precio_venta", dts.gprecio_venta)
            cmd.Parameters.AddWithValue("@fecha_vencimiento", dts.gfecha_vencimiento)
            cmd.Parameters.AddWithValue("@imagen", dts.gimagen)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If


        Catch ex As Exception

            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()




        End Try



    End Function



    Public Function eliminar(ByVal dts As vproducto) As Boolean

        Try
            conectado()
            cmd = New SqlCommand("eliminar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.Add("@idproducto", SqlDbType.NVarChar, 50).Value = dts.gidproducto
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False


            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try




    End Function






End Class
