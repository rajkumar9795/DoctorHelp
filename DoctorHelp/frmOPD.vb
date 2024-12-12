Imports System.Data.OleDb
Public Class frmOPD
    Dim bs As New BindingSource
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim dsbook As New DataSet
    Dim recid, tbname As String
    Dim position, rowno,opdid,detectonetime As Integer
    Dim DTForOPDRec As New DataTable
    Public PatientID,formmode As String 

    Private Sub frmOPD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       show_opd_entry
        Me.Size=New System.Drawing.Size(940, 550)
        Me.Location=New Point(210,60)
       fill_combo
        detectonetime=0   ' fill history grid header when 0 
        
        If formmode="read" ' for show history only
            TabControl1.Visible=True 
            Panel1.Visible=False 
            GridOpdHeading
             FillGridHistory
            TabControl1.SelectTab(1)
        End If
    End Sub
    Private sub show_opd_entry
         Dim lc=New Point 
        lc.X=20
        lc.Y=100
        Panel1.Location=lc
    End sub
    private Sub fill_combo()
        com.CommandText = "select ID,DiseaseName from DiseaseMaster"
        Try
           Dim daDisease =New OleDbDataAdapter("select * From DiseaseMaster",con)
            Dim dsDiseas=New DataSet 
            daDisease.Fill(dsDiseas,"DiseaseMaster")
            ComboDisease.DataSource=dsDiseas.Tables("DiseaseMaster")
            ComboDisease.ValueMember="ID"
            ComboDisease.DisplayMember ="DiseaseName"
        Catch ex As Exception
            MsgBox("college fill error " & vbCrLf)
        End Try
    End Sub

   

    Private Sub btnFileBrowse_Click(sender As Object, e As EventArgs) 
        OpenFileDialog1.ShowDialog 
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If lblmode.Text="add"
               Dim ob = New AppClass
         Dim maxid As Integer = ob.GetMaxID("OPD"),parchaid As Integer 
            Try
            If  txtRemark.Text="" And   txtStaffRemark.Text=""
                MsgBox("Please enter A Remark")
            Else
                com.CommandText = "insert into OPD (ID, PID, DisID, Remark,StaffRemark, VisitDate, Amount, CreatedBy, CreatedUserType) values(" & maxid & "," & Convert.ToInt32(PatientID) & "," & Val(ComboDisease.SelectedValue) & ",'" & txtRemark.Text & " ','" & txtStaffRemark.Text & " ',#" & DateTime.Now.ToShortDateString  & "#" & "," & Val(txtAmount.Text) & "," & Convert.ToInt32(MDI.UID) & ",'" & MDI.UserType & "')"
            
            com.ExecuteNonQuery
                MsgBox("Record Save")
            FillGridHistory
            TabControl1.SelectTab(1)
                
            End If
            
            ' Parcha save 
            'If Not OpenFileDialog1.FileName =""
            '     parchaid=ob.GetMaxID("Parcha") 
            '    com.CommandText="insert into Parcha values(" & parchaid & "," & maxid & ")"
            '    com.ExecuteNonQuery 
            '    FileCopy(OpenFileDialog1.FileName, Application.StartupPath & "/Upload/parcha/" & parchaid & ".jpg")
            'End If
           
            
            Catch ex As Exception
                MsgBox(ex.Message )
            End Try
        Else If lblmode.Text="edit"
            com.CommandText="update opd set DisID=" & ComboDisease.SelectedValue & ",Remark='" & txtRemark.Text & "',StaffRemark='" & txtStaffRemark.Text & "',Amount=" & Val(txtAmount.Text ) & " where id=" & opdid 
            com.ExecuteNonQuery ()
            MsgBox("Record Updated")
              FillGridHistory
            TabControl1.SelectTab(1)
        End If
     
            
    End Sub
    Private Sub GridOpdHeading()
        Dim c1 As New DataColumn()
        Try
            If detectonetime =0
                c1.DataType = System.Type.GetType("System.Int32")
                c1.ColumnName = "OPD_ID"
                DTForOPDRec.Columns.Add(c1)

                c1 = New DataColumn
                c1.DataType = System.Type.GetType("System.String")
                c1.ColumnName = "Disease"
                DTForOPDRec.Columns.Add(c1)

                c1 = New DataColumn
                c1.DataType = System.Type.GetType("System.String")
                c1.ColumnName = "Remark"
                DTForOPDRec.Columns.Add(c1)

                  c1 = New DataColumn
                c1.DataType = System.Type.GetType("System.String")
                c1.ColumnName = "StaffRemark"
                DTForOPDRec.Columns.Add(c1)

                 c1 = New DataColumn
                c1.DataType = System.Type.GetType("System.Int32")
                c1.ColumnName = "Amount"
                DTForOPDRec.Columns.Add(c1)
            
                c1 = New DataColumn
                c1.DataType = System.Type.GetType("System.String")
                c1.ColumnName = "Visit Date"
                DTForOPDRec.Columns.Add(c1)

                c1 = New DataColumn
                c1.DataType = System.Type.GetType("System.String")
                c1.ColumnName = "Create By"
                DTForOPDRec.Columns.Add(c1)

                GrdHistory.DataSource = DTForOPDRec
                detectonetime=1
            End If
            
        Catch ex As Exception
            MsgBox("Making Grid Header Er Code !" & vbCrLf & ex.Message)
        End Try
    End Sub
    Private sub FillGridHistory
        Dim sql As String
        Dim amt As Integer =0
        sql="SELECT OPD.ID, OPD.PID, Patient.PName, OPD.DisID, DiseaseMaster.DiseaseName, OPD.Remark, OPD.StaffRemark, OPD.VisitDate, OPD.Amount, OPD.CreatedBy, UserMaster.SName, OPD.CreatedUserType FROM ((OPD INNER JOIN Patient ON OPD.PID = Patient.ID) INNER JOIN DiseaseMaster ON OPD.DisID = DiseaseMaster.ID) LEFT JOIN UserMaster ON OPD.CreatedBy = UserMaster.ID  where OPD.PID=" & Val(PatientID  ) & " order by OPD.ID Desc"
          Try
            DTForOPDRec.Rows.Clear()
            com.CommandText = sql
            Dim dr As OleDbDataReader = com.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    Dim row As DataRow
                    row = DTForOPDRec.NewRow
                    row(0) = dr("ID").ToString
                    row(1) =dr("DiseaseName").ToString
                    row(2) =dr("Remark").ToString
                    row(3) =dr("StaffRemark").ToString
                    row(4) =dr("Amount").ToString
                    row(5) =dr("VisitDate").ToString
                    row(6) =dr("SName").ToString
                    amt=amt + Val(dr("Amount").ToString)
                    DTForOPDRec.Rows.Add(row)
                   
                End While
                dr.Close()
                 GrdHistory.DataSource = DTForOPDRec
                lblAmt.Text=amt
            Else
                
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox("Filling GrdHistory Record Err Code ! " & ex.Message)
        End Try
    End sub

    Private Sub GrdHistory_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles GrdHistory.CellMouseClick

         Try
            If (e.RowIndex >= 0) Then
                With GrdHistory
                     frmParcha.Pid = .Item("opd_id", e.RowIndex).Value
                 opdid=.Item("opd_id", e.RowIndex).Value
                End With
                position = e.RowIndex               
            End If
        Catch ex As Exception
            MsgBox("Fill Error :=>" & ex.Message)
        End Try

      
        frmParcha.MdiParent=MDI
        'frmParcha.Show 
        PanelOption.Location=New Point(0, 50)
        PanelOption.Visible=true
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PanelOption.Visible=False 
    End Sub

    Private Sub btnFileBrowse_Click_1(sender As Object, e As EventArgs) Handles btnFileBrowse.Click
         OpenFileDialog1.ShowDialog
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        if(TabControl1.SelectedIndex =1)
              PanelOption.Visible=False 
        End If
    End Sub

    Private Sub btnParchaSave_Click(sender As Object, e As EventArgs) Handles btnParchaSave.Click
          
        'opdid=.Item("id", e.RowIndex).Value
        SaveParcha("Parcha")
        
    End Sub

    Private Sub btnInvestigate_Click(sender As Object, e As EventArgs) Handles btnInvestigate.Click
        SaveParcha("Investigate")
    End Sub

    Private Sub btnBrowseInvestigate_Click(sender As Object, e As EventArgs) Handles btnBrowseInvestigate.Click
         OpenFileDialog1.ShowDialog
    End Sub

    Private Sub btnShowParcha_Click(sender As Object, e As EventArgs) Handles btnShowParcha.Click
        frmParcha.lblPatientName.Text=lblPatientName.Text 
        frmParcha.lblOPDID.Text=opdid
        frmParcha.Show 
    End Sub

   

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtTestRemark.TextChanged

    End Sub

    Private Sub btnTestMsgSave_Click(sender As Object, e As EventArgs) Handles btnTestMsgSave.Click
        If txtTestName.Text=""
            MsgBox("Please Enter Test Name")
            txtTestName.focus()
        Else If txtTestRemark.Text=""
            MsgBox("Please Enter Test Description")
            txtTestRemark.focus()
        Else
            Dim ob = New AppClass
            dim parchaid As Integer       
            parchaid = ob.GetMaxID("Parcha")
            com.CommandText = "insert into Parcha values(" & parchaid & "," & opdid & ",'Text','" & txtTestName.Text & "','" & txtTestRemark.Text & "')"
            com.ExecuteNonQuery            
            MsgBox("Test Detail Saved Successfully")    
            txtTestName.Text=""
            txtTestRemark.Text=""
        End If
    End Sub

    Private Sub btnShowText_Click(sender As Object, e As EventArgs) Handles btnShowText.Click
          Try
            Dim da1 As OleDb.OleDbDataAdapter
            Dim bs1 As New BindingSource
            Dim ds1 As New DataSet
            da1 = New OleDb.OleDbDataAdapter("select id,test,testremark from Parcha where opdid=" & opdid, con)
            tbname = "TestNote"
            da1.Fill(ds1, tbname)
            
            grdTestNote.DataSource = ds1.Tables(tbname)
            grdTestNote.Columns("id").Visible = False
            
            position = 0
            recid = 0
        Catch ex As Exception
            MsgBox("form load=>" & ex.Message)
        End Try
        PanelTestText.Location=New Point(60, 97)
        PanelTestText.Show 
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PanelTestText.Visible=False 
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        TabControl1.SelectTab(0)
        lblmode.Text="edit"
        com.CommandText="select disid,Remark,StaffRemark,Amount from opd where id=" & opdid 
        Dim dr As  OleDbDataReader
        dr=com.ExecuteReader
        dr.Read 
        txtRemark.Text=dr("Remark")
        txtAmount.Text=dr("Amount")
        txtStaffRemark.Text=dr("StaffRemark")
        ComboDisease.SelectedValue =dr("disid")
        dr.Close 
    End Sub

    Private Sub btnDelHis_Click(sender As Object, e As EventArgs) Handles btnDelHis.Click
        If MsgBox("Are you sure to delete this opd record",MsgBoxStyle.YesNo)=MsgBoxResult.Yes 
            com.CommandText="delete from opd where id=" & opdid 
            com.ExecuteNonQuery 
            FillGridHistory
        End If
    End Sub

    Private Sub btnDocRemark_Click(sender As Object, e As EventArgs) Handles btnDocRemark.Click
        com.CommandText="update opd set Remark='" & txtDocRemark.Text & "' where id=" & opdid
        com.ExecuteNonQuery 

    End Sub

    Private Sub btnShowOpdEntry_Click(sender As Object, e As EventArgs) Handles btnShowOpdEntry.Click
        show_opd_entry
        Panel1.Visible=True 
        TabControl1.Visible=False 
        grdView.DataSource=Nothing 
        txtSearch.Text=""
    End Sub

    Private sub SaveParcha(ptype As string)
        Dim ob = New AppClass
        dim parchaid As Integer
        If Not OpenFileDialog1.FileName = ""
            parchaid = ob.GetMaxID("Parcha")
            com.CommandText = "insert into Parcha (ID,OPDID,DocType) values(" & parchaid & "," & opdid & ",'" & ptype & "')"
            com.ExecuteNonQuery
            If ptype="Parcha"
                FileCopy(OpenFileDialog1.FileName, Application.StartupPath & "/Upload/parcha/" & parchaid & ".jpg")
            Else
                FileCopy(OpenFileDialog1.FileName, Application.StartupPath & "/Upload/investigation/" & parchaid & ".jpg")
            End If
            
            MsgBox("Document Saved Successfully")
        End If
    End sub

    Private Sub grdView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grdView.CellMouseClick
         Try
            If (e.RowIndex >= 0) Then
                With grdView
                    PatientID = .Item("id", e.RowIndex).Value    
                    lblPatientName.Text=.Item("PName", e.RowIndex).Value 
                End With       
                Panel1.Visible=False 
                TabControl1.Visible=True 
                lblmode.Text="add"
                GridOpdHeading
                FillGridHistory
            End If
        Catch ex As Exception
            MsgBox("Fill Error :=>" & ex.Message)
        End Try
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
         Try
                da = New OleDb.OleDbDataAdapter("select * from Patient order by id desc", con)
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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
         grdView.DataSource=Nothing
          if ComboBox1.Text =""
            MsgBox("Please select Search By")
            ComboBox1.focus
          Else If txtSearch.Text=""
             MsgBox("Please enter Search value")
            txtSearch.focus
          Else
            
            Dim sql As String 
            If ComboBox1.Text="Name"
                sql="select * from Patient where PName like '%" & txtSearch.Text & "%'"
            else
                sql="select * from Patient where Phone1 ='" & txtSearch.Text  & "'" 
            End If
            
             Try
                da = New OleDb.OleDbDataAdapter(sql, con)
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
          End If
    End Sub
End Class