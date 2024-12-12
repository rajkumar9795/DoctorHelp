Public Class frmCustomer
     Dim bs As New BindingSource
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim tbname As String
    Public mode As String 
    Dim position, recid As Integer

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If ValidateForm 
            SaveP
        End If
    End Sub
    Private function ValidateForm() As Boolean 
        Dim flag As Boolean=True 
        If txtPatientName.Text=""
            MsgBox("Please enter patient Name")
            txtPatientName.focus
            flag=False 
        Else If txtPhone1.Text=""
             MsgBox("Please enter patient phone 1")
            txtPhone1.focus
            flag=False 
        Else If txtPhone1.Text.Length <10
             MsgBox("Phone 1 Must have 10 digit")
            txtPhone1.focus
            flag=False 
        Else If txtAddress.Text=""
             MsgBox("Please enter patient address")
            txtAddress.focus
            flag=False 
         Else If drpGender.Text=""
             MsgBox("Please select Gender")
            drpGender.focus
            flag=False 
        End If
        If Not txtPhone2.Text="" And  txtPhone2.Text.Length <10
             MsgBox("Phone 2 Must have 10 digit")
            txtPhone2.focus
              flag=False                     
        End If
        Return flag 
    End function
    Private sub SaveP
        Try
            Dim dd = New AppClass 
            Dim phonetest As String=""
            
          
                Dim cb As New OleDb.OleDbCommandBuilder(da)
                Dim dsNewRow As DataRow
                dsNewRow = ds.Tables("Patient").NewRow()
                dsNewRow.Item("ID") = lblPID.Text
                dsNewRow.Item("PName") = txtPatientName.Text
                dsNewRow.Item("Phone1") = txtPhone1.Text
                dsNewRow.Item("Phone2") = txtPhone2.Text                 
                dsNewRow.Item("Address") = txtAddress.Text
                dsNewRow.Item("Age") = Val(txtAge.Text)
                dsNewRow.Item("Gender") =  drpGender.Text 
                dsNewRow.Item("GuardianName") = txtGuardianName.Text 
                dsNewRow.Item("Relation") = drpRelation.Text 
                dsNewRow.Item("ReferFrom") = txtReferFrom.Text  
                dsNewRow.Item("CreatedBy") = Convert.ToInt32(MDI.UID)
                dsNewRow.Item("CreateUserType") = MDI.UserType
                dsNewRow.Item("CreatedDate") = DateTime.Today.ToShortDateString
                dsNewRow.Item("CreatedBy") = MDI.UID
                dsNewRow.Item("CreateUserType") = MDI.UserType
                ds.Tables("Patient").Rows.Add(dsNewRow)
                da.Update(ds, "Patient")
                recid = 0
                ClearForm
                MsgBox("Saved")

            clearform()


        Catch ex As Exception
            MsgBox("--->" & ex.Message)
        End Try
    End sub
    Private sub ClearForm
         txtPatientName.Text=""           
         txtPhone1.Text=""
         txtPhone2.Text=""
         
         txtAddress.Text="" 
        txtGuardianName.Text=""
        drpRelation.Text=""
        txtReferFrom.Text=""
        txtAge.Text=""
        lblPID.Text="-"
    End sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
         If recid = 0 Then
            MsgBox("Please select a row from GridView")
        Else
             If ValidateForm 
                 Dim cb As New OleDb.OleDbCommandBuilder(da)
                ds.Tables(tbname).Rows(position).Item("PName") =  txtPatientName.Text
                ds.Tables(tbname).Rows(position).Item("Phone1") = txtPhone1.Text
                ds.Tables(tbname).Rows(position).Item("Phone2") = txtPhone2.Text
                
                ds.Tables(tbname).Rows(position).Item("Address") = txtAddress.Text
                'ds.Tables(tbname).Rows(position).Item("DOB") = DateTimePicker1.Value.ToShortDateString 
                da.Update(ds, tbname)
                
                recid=0
                 btnSave.Enabled=True 
                ClearForm
                MsgBox("Record Updated")
            End If
           
        End If

         
    End Sub

    

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If recid = 0 Then
            MsgBox("Please select a row from GridView")
        Else
             If MsgBox("Are you sure to delete this record",MsgBoxStyle.YesNo )=MsgBoxResult.Yes 
                Try
                    Dim cb As New OleDb.OleDbCommandBuilder(da)
                    ds.Tables(tbname).Rows(position).Delete()
                    da.Update(ds, tbname)
                    If position = bs.Count - 1 Then
                        position = 0
                    Else
                        position = position + 1
                    End If
                    MsgBox("Record Deleted")
                    recid = 0
                    clearform()
                    
                Catch ex As Exception
                    MsgBox("del err=>" & ex.Message)
                End Try
            End If
        End if
       
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) 

    End Sub

    Private function dropDD() As String 
           Try
            Dim dd As String 
            
            Dim dob as Date=CDate(dd)
            Return dob
        Catch ex As Exception
            MsgBox(ex.Message )
            Return "0"
        End Try
    End function
    Private Sub Button1_Click(sender As Object, e As EventArgs) 
     

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) 
       
    End Sub

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
        mode="edit"
       ButtonChange(mode)
         Try
            If (e.RowIndex >= 0) Then
                With grdView
                    recid = .Item("id", e.RowIndex).Value
                    txtPatientName.Text= .Item("PName", e.RowIndex).Value
                    txtPhone1.Text = .Item("Phone1", e.RowIndex).Value
                    txtPhone2.Text = .Item("Phone2", e.RowIndex).Value
                    txtAddress.Text = .Item("Address", e.RowIndex).Value
                    txtAge.Text = .Item("Age", e.RowIndex).Value
                    txtAge.Text = .Item("Age", e.RowIndex).Value                    
                    drpGender.SelectedItem= .Item("Gender", e.RowIndex).Value
                    txtGuardianName.Text=.Item("GuardianName", e.RowIndex).Value
                    drpRelation.SelectedItem=.Item("Relation", e.RowIndex).Value
                    txtReferFrom.Text=.Item("ReferFrom", e.RowIndex).Value
                End With
                position = e.RowIndex               
            End If
        Catch ex As Exception
            MsgBox("Fill Error :=>" & ex.Message)
        End Try
    End Sub


    'Sub fill_grid(ByVal sql As String)

    '    Try
    '        da.Fill(ds, "My_table_temp_name")
    '        DataGridView1.DataSource = ds.Tables("My_table_temp_name")
    '        lblTotalRecod.Text = DataGridView1.RowCount - 1 & " Records"
    '    Catch ex As Exception
    '        MsgBox("Grid Filling Error " & vbCrLf & ex.Message)
    '    End Try

    'End Sub
    Private sub ButtonChange(op As String )
        If op="add"
            btnSave.Text="Add"
        Else
            btnSave.Text="Update"
        End If
    End sub
    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    
        
         Try
            da = New OleDb.OleDbDataAdapter("SELECT top 100 * from Patient;", con)
            tbname = "Patient"
            da.Fill(ds, tbname)
            bs.DataSource = ds.Tables(tbname)
            grdView.DataSource=ds.Tables(tbname)
            position = 0
            recid = 0
            ' Get max patient id
            Dim ob=New AppClass 
            lblPID.Text=ob.GetMaxID("Patient")
            
           
        Catch ex As Exception
            MsgBox("form load=>" & ex.Message)
        End Try
    End Sub
End Class