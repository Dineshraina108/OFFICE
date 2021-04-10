Imports Oracle.DataAccess.Client
Module cusdtconnection
    Public cuscon As New OracleConnection
    Dim ora_ada As New OracleDataAdapter
    Dim dt As New DataTable
    Dim Tval As Long = 0
    Public Sub dbconnection()
        cuscon.ConnectionString = "Data source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = MOUNTAIN)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = MOUNTAIN)));user id=TESTDB;password=TESTDB;pooling=false"
        cuscon.Open()
    End Sub
    Public Sub insert(ByRef qry As String)
        Using Cmd As New OracleCommand(qry, cuscon)
            Tval = Cmd.ExecuteNonQuery()
        End Using
        If Tval > 0 Then
            MsgBox("inserted Successful....!")
        Else
            MsgBox("Failed to insert ....!")
        End If
    End Sub
    Public Sub Update1(ByRef qry As String)
        Using Cmd As New OracleCommand(qry, cuscon)
            Tval = Cmd.ExecuteNonQuery()
        End Using
        If Tval > 0 Then
            MsgBox("updated Successful....!")
        Else
            MsgBox("Failed to update ....!")
        End If
    End Sub
    Public Sub Delquery(ByRef qry As String)
        Using Cmd As New OracleCommand(qry, cuscon)
            Tval = Cmd.ExecuteNonQuery()
        End Using
        If Tval > 0 Then
            MsgBox("Deleted Successful....!")
        Else
            MsgBox("Failed to Delete ....!")
        End If
    End Sub
    Public Function Selectqry(ByRef qry As String)
        Using cmd As New OracleCommand(qry, cuscon)
            Using ora_ada As New OracleDataAdapter(cmd)
                ora_ada.Fill(dt)
            End Using
        End Using
        Return dt
    End Function
    Public Sub closeconn()
        cuscon.Close()
    End Sub
End Module
