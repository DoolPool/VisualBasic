Public Class Report
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Sub LoadReport()
        Try
            cn.Open()
            Dim ds As New DataSet1
            Dim da As New OleDbDataAdapter
            da.SelectComand = New OleDbCommand("")

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class