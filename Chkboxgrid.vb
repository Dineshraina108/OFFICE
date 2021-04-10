Imports Oracle.DataAccess.Client
Imports Telerik.WinControls.UI
Public Class Chkboxgrid
    Dim query As String
    Dim dr As DataRow
    Private Sub Chkboxgrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        dbconnection()
        query = "SELECT * FROM CUST_DETAILS ORDER BY CID"
        dt = Selectqry(query)
        If dt.Rows.Count = 0 Then
            MsgBox("Not Records")
        Else
            RGVcus.DataSource = dt
            Dim chkcol As New GridViewCheckBoxColumn()
            chkcol.HeaderText = "select"
            chkcol.Width = 30
            chkcol.Name = "select"
            RGVcus.MasterTemplate.Columns.Add(chkcol)
            chkcol.EnableHeaderCheckBox = True
        End If
        RGVcusup.Visible = False
        closeconn()
    End Sub
    Public Function GetTable()
        Dim tabl As New DataTable
        tabl.Columns.Add("CID", GetType(Integer))
        tabl.Columns.Add("NAME", GetType(String))
        tabl.Columns.Add("DOB", GetType(String))
        tabl.Columns.Add("MOBNO", GetType(String))
        Return tabl
    End Function

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim dt As DataTable = GetTable()
        'Dim dt1 As DataTable = Getcust()
        dbconnection()
        For Each row As GridViewRowInfo In RGVcus.Rows
            Dim isel As Boolean = Convert.ToBoolean(row.Cells("chkval").Value)
            If isel Then
                dr = dt.NewRow()
                dr("CID") = row.Cells("CID").Value.ToString
                dr("NAME") = row.Cells("NAME").Value.ToString
                dr("DOB") = row.Cells("DOB").Value.ToString
                dr("MOBNO") = row.Cells("MOBNO").Value
                dt.Rows.Add(dr)
                RGVcusup.DataSource = dt
            End If
        Next
        RGVcusup.Visible = True
        closeconn()
    End Sub

    Private Sub MasterTemplate_Click(sender As Object, e As EventArgs) Handles RGVcus.Click

    End Sub

    Private Sub MasterTemplate_ValueChanged(sender As Object, e As EventArgs) Handles RGVcus.ValueChanged
        If TypeOf Me.RGVcus.ActiveEditor Is RadCheckBoxEditor Then
            Console.WriteLine(Me.RGVcus.CurrentCell.RowIndex)
            Console.WriteLine(Me.RGVcus.ActiveEditor.Value)
        End If
    End Sub
End Class