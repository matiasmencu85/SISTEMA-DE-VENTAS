

Imports System.Data.SqlClient

Public Class fventas

    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try

            conectado()
            cmd = New SqlCommand("mostrar_venta")
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


    Public Function insertar(ByVal dts As vventas) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            ' cmd.Parameters.AddWithValue("@idventa", dts.gidventa)
            cmd.Parameters.AddWithValue("@idcliente", dts.gidcliente)
            cmd.Parameters.AddWithValue("@fecha_venta", dts.gfecha_venta)
            cmd.Parameters.AddWithValue("@tipo_documento", dts.gtipo_documento)
            cmd.Parameters.AddWithValue("@num_documento", dts.gnum_documento)


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



    Public Function editar(ByVal dts As vventas) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_ventas")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idventa", dts.gidventa)
            cmd.Parameters.AddWithValue("@idcliente", dts.gidcliente)
            cmd.Parameters.AddWithValue("@fecha_venta", dts.gfecha_venta)
            cmd.Parameters.AddWithValue("@tipo_documento", dts.gtipo_documento)
            cmd.Parameters.AddWithValue("@num_documento", dts.gnum_documento)

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



    Public Function eliminar(ByVal dts As vventas) As Boolean

        Try
            conectado()
            cmd = New SqlCommand("eliminar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.Add("@idventa", SqlDbType.NVarChar, 50).Value = dts.gidventa
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
