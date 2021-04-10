Imports Oracle.DataAccess.Client
Imports Telerik.WinControls.UI
Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class Form1
    Dim Query As String = String.Empty
    Dim ora_ada As New OracleDataAdapter
    Dim dt As New DataTable
    Dim qry, q As String
    Dim Tval As Long = 0
    Dim dtformat As Regex = New Regex("(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[1-2])\/([1-9]|[0-2]))$")
    Dim cid, Cname, dob As String
    Dim Mno As String
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
    Private Sub btnsub_Click(sender As Object, e As EventArgs) Handles btnsub.Click
        'dbconnection()
        If Len(txtmobno.Text) > 10 Or Len(txtmobno.Text) < 10 Then
            MsgBox("INVALID MOBILE NUMBER")
            txtmobno.Focus()
        Else
            Query = "INSERT INTO CUST_DETAILS VALUES (" & txtcusid.Text & ",'" & txtname.Text & "','" & txtdob.Text & "'," & txtmobno.Text & ")"
            insert(Query)
            'selection()
            Dim FM As New Customer_details
            FM.Show()
        End If
        closeconn()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        txtcusid.Focus()
        dbconnection()
        Query = "SELECT * FROM CUST_DETAILS ORDER BY CID"
        dt = Selectqry(Query)
        'txtcusid.Text = dt.Rows(0)("CID")
        'txtname.Text = dt.Rows(0)("NAME")
        'txtdob.Text = dt.Rows(0)("DOB")
        'txtmobno.Text = dt.Rows(0)("MOBNO")
        RGVcusdet.DataSource = dt
        RGVcusdet.Visible = False
        closeconn()
    End Sub
    Private Sub btndisp_Click(sender As Object, e As EventArgs) Handles btndisp.Click
        'RGVcusdet.Visible = True
        Dim act As New Action
        act.Show()
    End Sub

    Private Sub btndele_Click(sender As Object, e As EventArgs) Handles btndele.Click
        dbconnection()
        cid = RGVcusdet.CurrentRow.Cells("CID").Value
        qry = "DELETE FROM CUST_DETAILS WHERE CID=" & cid & ""
        Delquery(qry)
        Dim act As New Action
        act.Show()
        closeconn()
        'Dim FM As New Customer_details
        'FM.Show()
    End Sub

    Private Sub btnupd_Click(sender As Object, e As EventArgs) Handles btnupd.Click
        Dim dt As New DataTable
        dbconnection()
        cid = RGVcusdet.CurrentRow.Cells("CID").Value
        Cname = RGVcusdet.CurrentRow.Cells("NAME").Value
        dob = RGVcusdet.CurrentRow.Cells("DOB").Value
        Mno = RGVcusdet.CurrentRow.Cells("MOBNO").Value.ToString
        q = "UPDATE CUST_DETAILS SET NAME='" & Cname & "',DOB='" & dob & "',MOBNO=" & Mno & "WHERE CID=" & cid & ""
        Update1(q)
        Dim act As New Action
        act.Show()
        'Query = "SELECT * FROM CUST_DETAILS ORDER BY CID"
        'dt = Selectqry(Query)
        'RGVcusdet.DataSource = dt
        closeconn()
        ' Dim FM As New Customer_details
        ' FM.Show()
    End Sub
    Public Sub selection()
        Query = "SELECT * FROM CUST_DETAILS ORDER BY CID"
        dt = Selectqry(Query)
        RGVcusdet.DataSource = dt
    End Sub
End Class
