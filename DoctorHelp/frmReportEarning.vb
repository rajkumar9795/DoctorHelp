Public Class frmReportEarning
      Dim bs As New BindingSource
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim tbname As string
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            da = New OleDb.OleDbDataAdapter("select * from Patient where createddate between #" & dtFrom.Value.ToShortDateString() & "# and #" & dtTo.Value.ToShortDateString & "#", con)
            tbname = "Patient"
            ds.Clear
            da.Fill(ds, tbname)

            bs.DataSource = ds.Tables(tbname)
            grdView.DataSource = ds.Tables(tbname)
            grdView.Columns("id").Visible = False


        Catch ex As Exception
            MsgBox("form load=>" & ex.Message)
        End Try
    End Sub
End Class