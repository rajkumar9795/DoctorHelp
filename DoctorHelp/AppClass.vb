Public Class AppClass
    Public Function CurrentDatetoNo() As Integer 
        dim str As String  
        str=DateTime.Now.Year.ToString()
        If DateTime.Now.Month<10
            str =str & "0" & DateTime.Now.Month.ToString 
        else
            str =str &  DateTime.Now.Month.ToString 
        End If
         If DateTime.Now.Day<10
            str =str & "0" & DateTime.Now.Day.ToString 
        else
            str =str &  DateTime.Now.Day.ToString 
        End If
        Return Convert.ToInt32(str)
    End Function
    Public Function GetMaxID(tbl As String ) As Integer 
        dim maxid As Integer   
        com.CommandText="select max(id) from " & tbl
        Try
            maxid=Convert.ToInt32(com.ExecuteScalar.ToString)
           maxid =maxid+1
        Catch ex As Exception
            maxid=1
        End Try
        Return maxid
    End Function
     Public Function GetSingleValue(sql As String ) As String  
        dim val As string=""   
        com.CommandText=sql
        Try
            val=com.ExecuteScalar.ToString
           
        Catch ex As Exception
            
        End Try
        Return val
    End Function
End Class
