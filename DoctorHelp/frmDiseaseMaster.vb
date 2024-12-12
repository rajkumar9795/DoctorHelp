Public Class frmDiseaseMaster
     Dim bs As New BindingSource
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim tbname As String
    Dim position, recid As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        MsgBox(MDI.UserType )
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtDideaseName.Text = ""
            MsgBox("Please Enter Disease Name")
            txtDideaseName.focus()
       
       
        Else
            save()

        End If
    End Sub
    private Sub save()
        Try
            Dim cb As New OleDb.OleDbCommandBuilder(da)
            Dim dsNewRow As DataRow
            dsNewRow = ds.Tables("DiseaseMaster").NewRow()
            dsNewRow.Item("DiseaseName") = txtDideaseName   .Text
            dsNewRow.Item("Description") = txtDescription.Text
          
            ds.Tables("DiseaseMaster").Rows.Add(dsNewRow)
            da.Update(ds, "DiseaseMaster")
            recid = 0
            MsgBox("Saved")
            grdView.DataSource = ds.Tables(tbname)
            lblQty.Text = grdView.RowCount
            'clearform()
        Catch ex As Exception
            MsgBox("--->" & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
         If recid = 0 Then
            MsgBox("Please select a row from grid")
        Else
            Dim cb As New OleDb.OleDbCommandBuilder(da)
            ds.Tables(tbname).Rows(position).Item("DiseaseName") = txtDideaseName.Text
            ds.Tables(tbname).Rows(position).Item("Description") = txtDescription.Text
            
            da.Update(ds, tbname)
            grdView.DataSource = ds.Tables(tbname)
            MsgBox("Record Updated")
        End If
    End Sub

    Private Sub grdView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grdView.CellMouseClick
         Try
            If (e.RowIndex >= 0) Then
                With grdView
                    recid = .Item("id", e.RowIndex).Value
                    txtDideaseName.Text = .Item("DiseaseName", e.RowIndex).Value
                    txtDescription.Text = .Item("Description", e.RowIndex).Value
                  

                End With
                position = e.RowIndex               
            End If
        Catch ex As Exception
            MsgBox("Fill Error :=>" & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub frmDiseaseMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            da = New OleDb.OleDbDataAdapter("select * from DiseaseMaster", con)
            tbname = "DiseaseMaster"
            da.Fill(ds, tbname)
            bs.DataSource = ds.Tables(tbname)
            grdView.DataSource = ds.Tables(tbname)
            grdView.Columns("id").Visible = False
            lblQty.Text = grdView.RowCount
            position = 0
            recid = 0
        Catch ex As Exception
            MsgBox("form load=>" & ex.Message)
        End Try
    End Sub
End Class