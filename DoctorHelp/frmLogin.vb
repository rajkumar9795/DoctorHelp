Imports System.Data.OleDb

Public Class frmLogin
    Dim SType,UID As String 
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit 
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUserName.Text=""
            lblMsg.Text="Please Enter Username"
            txtUserName.focus
        Else  If txtPassword.Text=""
            lblMsg.Text="Please Enter Password"
            txtPassword.focus
        Else
            If(RadioButton1.Checked=true )
                SType="Admin"
            Else
                SType="User"
            End If

            Login
        End If
    End Sub

    Private sub Login
        
        Dim con As New OleDbConnection(mdlConnection.getCon)
        Dim com As New OleDbCommand
        Try
            com.Connection = con
            con.Open()
            com.CommandText = "select count(*) from usermaster where username='" & txtUserName.Text & "' and password='" & txtPassword.Text & "' and SType='" &  SType & "'"
            If com.ExecuteScalar.ToString = "0" Then
                lblMsg.Text="Invalid  user name or password"
                txtUserName.Text = ""
                txtPassword.Text = ""
                txtUserName.Focus()
            Else
                If SType="User"
                       com.CommandText = "select id from usermaster where username='" & txtUserName.Text & "' and password='" & txtPassword.Text & "' and SType='" &  SType & "'"
                    UID=com.ExecuteScalar.ToString()
                Else
                    UID="0"
                End If
                con.Close()
                Me.Hide()
                MDI.UserType=SType
                MDI.UID=UID
                MDI.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End sub
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMsg.Text=""
        txtUserName.focus
    End Sub

    Private Sub txtUserName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtUserName.KeyUp
        If e.KeyCode = Keys.Enter Then
            If Not txtUserName.Text = "" Then
                txtPassword.Focus()
            End If
        End If
    End Sub

    

    Private Sub txtPassword_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyUp
          If e.KeyCode = Keys.Enter Then
            If Not txtPassword.Text = "" Then
                Login 
            End If
        End If
    End Sub
End Class