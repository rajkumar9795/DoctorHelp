Public Class frmSplash
    dim tic as Integer 
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If tic=1
            Me.Hide 
            frmLogin.Show 
        End If
        tic=tic+1
    End Sub

    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tic=1
    End Sub
End Class
