Imports Oracle.DataAccess.Client
Imports Telerik.WinControls.UI
Public Class Action
    Dim ora_ada As New OracleDataAdapter
    Dim dt As New DataTable
    Dim qry As String
    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        closeconn()
        Me.Close()
    End Sub

    Private Sub btnmodtify_Click(sender As Object, e As EventArgs) Handles btnmodtify.Click
        Me.Close()
        closeconn()
        Dim cus As New Customer_details
        cus.Show()
    End Sub

    Private Sub Action_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        qry = "SELECT * FROM CUST_DETAILS ORDER BY CID"
        Using cmd As New OracleCommand(qry, cuscon)
            Using ora_ada As New OracleDataAdapter(cmd)
                ora_ada.Fill(dt)
            End Using
        End Using
        RGVact.DataSource = dt
    End Sub
End Class