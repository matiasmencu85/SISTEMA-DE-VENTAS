Public Class frmreportecomprobante

    Private Sub frmreportecomprobante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbventasDataSet10.generar_comprobante' Puede moverla o quitarla según sea necesario.

        Try
            Me.generar_comprobanteTableAdapter.Fill(Me.dbventasDataSet10.generar_comprobante, idventa:=txtidventa.Text)

            Me.ReportViewer1.RefreshReport()


        Catch ex As Exception
            Me.ReportViewer1.RefreshReport()
        End Try



      
    End Sub

   
End Class