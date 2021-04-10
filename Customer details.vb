Imports Oracle.DataAccess.Client
Imports Telerik.WinControls.UI

Public Class Customer_details
    Dim ora_ada As New OracleDataAdapter
    Dim dt As New DataTable
    Dim qry, q As String
    Dim delr As String
    Dim f1 As New Form1
    Dim cid, Cname, dob As String
    Dim Mno As String
    Private Sub Customer_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconnection()
        qry = "SELECT * FROM CUST_DETAILS ORDER BY CID"
        Using cmd As New OracleCommand(qry, cuscon)
            Using ora_ada As New OracleDataAdapter(cmd)
                ora_ada.Fill(dt)
            End Using
        End Using
        RGVCusdet.DataSource = dt
        closeconn()
    End Sub

    Private Sub btnupdte_Click(sender As Object, e As EventArgs) Handles btnupdte.Click
        dbconnection()
        cid = RGVCusdet.CurrentRow.Cells("CID").Value
        Cname = RGVCusdet.CurrentRow.Cells("NAME").Value
        dob = RGVCusdet.CurrentRow.Cells("DOB").Value
        Mno = RGVCusdet.CurrentRow.Cells("MOBNO").Value.ToString
        q = "UPDATE CUST_DETAILS SET NAME='" & Cname & "',DOB='" & dob & "',MOBNO=" & Mno & "WHERE CID=" & cid & ""
        Update1(q)
        Dim act As New Action
        act.Show()
        closeconn()
    End Sub

    'Private Sub btnsearch_Click(sender As Object, e As EventArgs)
    '    Dim s As String
    '    s = RGVCusdet.CurrentRow.Cells("CID").Value
    '    qry = "SELECT * FROM CUST_DETAILS ORDER BY CID"
    '    Using cmd As New OracleCommand(qry, cuscon)
    '        Using ora_ada As New OracleDataAdapter(cmd)
    '            ora_ada.Fill(dt)
    '        End Using
    '    End Using
    '    RGVCusdet.DataSource = dt
    'End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        dbconnection()
        delr = RGVCusdet.CurrentRow.Cells("CID").Value
        qry = "DELETE FROM CUST_DETAILS WHERE CID=" & delr & ""
        Delquery(qry)
        Dim act As New Action
        act.Show()
        closeconn()
    End Sub

    Private Sub BTNDIS_Click(sender As Object, e As EventArgs) Handles BTNDIS.Click
        ' Me.Close()
        Dim act As New Action
        act.Show()
    End Sub

    Private Sub btnins_Click(sender As Object, e As EventArgs) Handles btnins.Click
        closeconn()
        f1.Show()
    End Sub
End Class