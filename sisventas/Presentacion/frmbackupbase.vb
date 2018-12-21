Public Class frmbackupbase

    Private Sub btnbackup_Click(sender As Object, e As EventArgs) Handles btnbackup.Click

        Try
            Dim func As New fbackup

            If func.backupbase Then
                MessageBox.Show("Backup Generado Satisfactoriamente", "BAckupBD", MessageBoxButtons.OK, MessageBoxIcon.Information)

            else
            MessageBox.Show("Backup NO PUEDE SER Generado ", "BAckupBD", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End if

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub
End Class