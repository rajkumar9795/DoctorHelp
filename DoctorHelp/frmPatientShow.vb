Public Class frmPatientShow
     Dim bs As New BindingSource
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim dsbook As New DataSet
    Dim recid, tbname,PatientID As String

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        
        if drpSearch.Text = ""
            MsgBox("Please select Search Criteria")
            drpSearch.focus
        Else If txtSearch.Text = ""
            MsgBox("Please enter Search value")
            txtSearch.focus
        Else 'search

         Dim sql As String="0"
            If drpSearch.Text = "ID"
                sql = "select * from Patient where ID =" & Val(txtSearch.Text) & ""
            else If drpSearch.Text = "Name"
                sql = "select * from Patient where PName like '%" & txtSearch.Text & "%'"
            Else If drpSearch.Text = "Phone"
                sql = "select * from Patient where Phone1 ='" & txtSearch.Text & "'"

            End If
            If not sql = "0"
                grdView.DataSource = Nothing
                Try
                da = New OleDb.OleDbDataAdapter(sql, con)
                tbname = "Patient"
                ds.Clear
                da.Fill(ds, tbname)

                bs.DataSource = ds.Tables(tbname)
                grdView.DataSource = ds.Tables(tbname)
                

                position = 0
                recid = 0
                Catch ex As Exception
                    MsgBox("form load=>" & ex.Message)
                End Try
             Else
                MsgBox("not found=" & sql)
            End If          
            
        End If
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
         grdView.DataSource = Nothing
                Try
                da = New OleDb.OleDbDataAdapter("select * from Patient where id>18000", con)
                tbname = "Patient"
                ds.Clear
                da.Fill(ds, tbname)

                bs.DataSource = ds.Tables(tbname)
                grdView.DataSource = ds.Tables(tbname)
                

                position = 0
                recid = 0
                Catch ex As Exception
                    MsgBox("form load=>" & ex.Message)
                End Try
    End Sub

    Private Sub grdView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grdView.CellMouseClick
        frmOPD.PatientID= grdView.Item("id", e.RowIndex).Value     
        frmOPD.lblPatientName.Text=grdView.Item("PName", e.RowIndex).Value 
        frmOPD.formmode="read"
        frmOPD.Show          
        Me.Close
          
    End Sub

    Dim position, rowno,opdid As Integer
    Private Sub frmPatientShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         Try
                da = New OleDb.OleDbDataAdapter("select * from Patient", con)
                tbname = "Patient"
                 ds.Clear 
                da.Fill(ds, tbname)
               
                bs.DataSource = ds.Tables(tbname)
                grdView.DataSource = ds.Tables(tbname)
                grdView.Columns("id").Visible = False
                
                position = 0
                recid = 0
            Catch ex As Exception
                MsgBox("form load=>" & ex.Message)
            End Try
    End Sub
End Class