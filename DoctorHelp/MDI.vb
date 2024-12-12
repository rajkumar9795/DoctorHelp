Public Class MDI
    public Dim  UserType,UID As String 
    Private Sub MDI_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit 
    End Sub

    Private Sub MDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        If UserType="Admin"
            MasterToolStripMenuItem.Enabled=True 
        Else
            MasterToolStripMenuItem.Enabled=False  
        End If
        OpenCon
    End Sub

    Private Sub DiseaseMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiseaseMasterToolStripMenuItem.Click
        frmDiseaseMaster.MdiParent =Me
        frmDiseaseMaster.Show 
    End Sub

    Private Sub OPDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPDToolStripMenuItem.Click
        frmOPD.MdiParent=Me
        frmOPD.Show 
    End Sub

    Private Sub PatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientToolStripMenuItem.Click
        frmReportPatient.MdiParent=Me
        frmReportPatient.Show 
    End Sub

    Private Sub CollectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollectionToolStripMenuItem.Click
        frmReportEarning.MdiParent=Me
        frmReportEarning.Show 
    End Sub

    Private Sub BackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupToolStripMenuItem.Click
          Try
            Dim newname As String 
            newname=DateTime.Now.Day & "-" & DateTime.Now.Month & "-" & DateTime.Now.Year 
            System.IO.File.Copy(Application.StartupPath & "\patient.accdb", Application.StartupPath & "\backup\" & newname & ".accdb")
            MsgBox("Backup Completed")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        frmCustomer.mode="add"
         frmCustomer.MdiParent=me
        frmCustomer.Show 
    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        frmPatientShow.MdiParent=Me
        frmPatientShow.Show 
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
       
    End Sub
End Class