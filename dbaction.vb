Imports Oracle.DataAccess.Client
Module dbaction
    Public cuscon As New OracleConnection
    Dim ora_ada As New OracleDataAdapter
    Public Sub dbconnection()
        cuscon.ConnectionString = "Data source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = MOUNTAIN)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = MOUNTAIN)));user id=TESTDB;password=TESTDB;pooling=false"
        cuscon.Open()
    End Sub
    Public Sub closeconn()
        cuscon.Close()
    End Sub
    Public Function selquery(ByRef qry As String)
        Dim dt As New DataTable
        Using cmd As New OracleCommand(qry, cuscon)
            Using ora_ada As New OracleDataAdapter(cmd)
                ora_ada.Fill(dt)
            End Using
        End Using
        Return dt
    End Function
    Public Sub Updatequery(ByRef qry As String)
        Dim Tval As Long = 0
        Using Cmd As New OracleCommand(qry, cuscon)
            Tval = Cmd.ExecuteNonQuery()
        End Using
        If Tval > 0 Then
            MsgBox("updated Successful....!")
        Else
            MsgBox("Failed to update ....!")
        End If
    End Sub
    Public Sub insert(ByRef qry As String)
        Dim Tval As Long = 0
        Using Cmd As New OracleCommand(qry, cuscon)
            Tval = Cmd.ExecuteNonQuery()
        End Using
        If Tval > 0 Then
            MsgBox("inserted Successful....!")
        Else
            MsgBox("Failed to insert ....!")
        End If
    End Sub
    Public Sub del(ByRef qry As String)
        Dim Tval As Long = 0
        Using Cmd As New OracleCommand(qry, cuscon)
            Tval = Cmd.ExecuteNonQuery()
        End Using
        If Tval > 0 Then
            MsgBox("Deleted Successful....!")
        Else
            MsgBox("Failed to deleted ....!")
        End If
    End Sub
    Public Sub commitquery(ByRef qry As String)
        Dim Tval As Long = 0
        Using Cmd As New OracleCommand(qry, cuscon)
            Tval = Cmd.ExecuteNonQuery()
        End Using
        If Tval > 0 Then
            MsgBox("commit Successful....!")
        Else
            MsgBox("Failed to commit ....!")
        End If
    End Sub

End Module
