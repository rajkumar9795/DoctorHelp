Imports System.Data.OleDb

Module mdlConnection
    Public con As New OleDbConnection
    Public com As New OleDbCommand
    Public Sub OpenCon()
        Try
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "/patient.accdb;Jet OLEDB:Database Password=access2007"
            con.Open()
            com.Connection = con
        Catch ex As Exception
            MsgBox("Global Con Open Error")
        End Try
    End Sub
    Public Function getCon() As String
        Return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "/patient.accdb;Jet OLEDB:Database Password=access2007"
    End Function
End Module
