Imports System.Data.OleDb

Public Class frmParcha
    Public Pid As Integer
    Dim CRowParcha As Integer=0,CRowInveti As Integer=0
    dim bsParcha As New BindingSource
    dim bsInvesti As New BindingSource
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim dt As new DataTable 

    Private Sub btnParchaPre_Click(sender As Object, e As EventArgs) Handles btnParchaPre.Click
         Dim row As DataRowView
        row = bsParcha.Current
        PictureParcha.ImageLocation = Application.StartupPath & "/Upload/parcha/" & row(0).ToString & ".jpg"
        
        If bsParcha.Position =0
            'MsgBox("First Record")
            
        Else
            bsParcha.MovePrevious

        End If
    End Sub

    Private Sub btnParchaNext_Click(sender As Object, e As EventArgs) Handles btnParchaNext.Click
        
        Dim row As DataRowView
        row = bsParcha.Current
        PictureParcha.ImageLocation = Application.StartupPath & "\Upload\parcha\" & row(0).ToString & ".jpg"
                 
        If bsParcha.Position = bsParcha.Count - 1
            'MsgBox("End of record")
        Else
            bsParcha.MoveNext
        End If

    End Sub

    Private Sub btnInvestiNext_Click(sender As Object, e As EventArgs) Handles btnInvestiNext.Click
        Dim row As DataRowView
        row = bsInvesti.Current
        PictureInvestigation.ImageLocation = Application.StartupPath & "\Upload\investigation\" & row(0).ToString & ".jpg"
        
        If bsInvesti.Position = bsInvesti.Count - 1
            'MsgBox("End of record")
        Else
            bsInvesti.MoveNext
        End If
    End Sub

    Private Sub btnInvestiPre_Click(sender As Object, e As EventArgs) Handles btnInvestiPre.Click
           Dim row As DataRowView
        row = bsInvesti.Current
        PictureInvestigation.ImageLocation = Application.StartupPath & "\Upload\investigation\" & row(0).ToString & ".jpg"
       
        If bsInvesti.Position = 0
            'MsgBox("End of record")
        Else
            bsInvesti.MovePrevious 
        End If
    End Sub

    Private Sub PictureParcha_Click(sender As Object, e As EventArgs) Handles PictureParcha.Click
         Clipboard.SetImage(PictureParcha.Image)
       MsgBox("Image Copied to Clipboard")
    End Sub

    Private Sub PictureInvestigation_Click(sender As Object, e As EventArgs) Handles PictureInvestigation.Click
         Clipboard.SetImage(PictureInvestigation.Image)
        MsgBox("Image Copied to Clipboard")
    End Sub

    Private Sub frmParcha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim sql As String="select ID from Parcha where PID=" & Convert.ToInt32(lblOPDID.Text) & " and DocType='Parcha'"
        Dim sql As String="select * from Parcha where DocType='Parcha' and OPDID=" & lblOPDID.Text 
        
        da=New OleDbDataAdapter( sql,con )
        da.Fill(ds,"tblPacha")
        bsParcha.DataSource=ds.Tables("tblPacha")
        'da.Fill(dt)

        sql ="select * from Parcha where DocType='Investigate' and OPDID=" & lblOPDID.Text
        da=New OleDbDataAdapter( sql,con )
        da.Fill(ds,"tblInvesti")
        bsInvesti.DataSource=ds.Tables("tblInvesti")

        PictureParcha.SizeMode=PictureBoxSizeMode.StretchImage
        PictureInvestigation.SizeMode=PictureBoxSizeMode.StretchImage
        'da.Fill(dt)
        'com.CommandText = "select id from Parcha where pid=" & Val(Pid)
        'Dim imgid As Integer 
        'Dim dr As OleDbDataReader = com.ExecuteReader
        'If dr.HasRows Then
        '    While dr.Read
        '       imgid=Convert.ToInt32(dr("id").ToString )
        '       Exit While 
        '    End While
        '    dr.Close()

        'Else

        '    dr.Close()
        'End If
        'Try
        '    PictureBox1.Image = Image.FromFile(Application.StartupPath & "\Upload\parcha\" & imgid & ".jpg")
        'Catch ex As Exception
        '    MsgBox(ex.Message )
        'End Try
        
    End Sub
End Class