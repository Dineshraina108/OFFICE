Imports Oracle.DataAccess.Client
Imports System.Data
Public Class operation
    Dim invact As New Invaction
    Dim query As String
    Dim keyvalue As Integer
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
        invact.Rbcom.Checked = True
        invact.Show()
    End Sub

    Private Sub btninvcancel_Click(sender As Object, e As EventArgs) Handles btninvcancel.Click
        Me.Close()
        invact.Rbcom.Checked = True
        invact.Show()
    End Sub

    Private Sub btninvdetcancel_Click(sender As Object, e As EventArgs) Handles btninvdetcancel.Click
        Me.Close()
        invact.Rbcom.Checked = True
        invact.Show()
    End Sub

    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        Dim id As Integer
        Dim dt As New DataTable
        Dim op As New operation
        dbconnection()
        query = "SELECT COUNT(*) FROM COMPANY_DETAILS"
        dt = selquery(query)
        If dt.Rows(0)("count(*)") = 0 Then
            id = 1
        Else
            id = dt.Rows(0)("count(*)")
            id = id + 1
        End If
        query = "INSERT INTO COMPANY_DETAILS VALUES(" & id & ",'" & txtcomname.Text & "','" & txtaddr.Text & "')"
        insert(query)
        'query = "COMMIT"
        'commitquery(query)
        closeconn()
        Me.Close()
        invact.Rbcom.Checked = True
        invact.Show()
    End Sub

    Private Sub btninvcreate_Click(sender As Object, e As EventArgs) Handles btninvcreate.Click
        Dim dt As New DataTable
        Dim op As New operation
        dbconnection()
        query = "SELECT COUNT(*) FROM COMPANY_DETAILS WHERE COMID=" & txtactvalue.Text & ""
        dt = selquery(query)
        If dt.Rows(0)("count(*)") = 0 Then
            MsgBox("No record In company")
            invact.Rbcom.Checked = True
            invact.Show()
        Else
            query = "INSERT INTO INVOICE VALUES(" & txtactvalue.Text & "," & txtinvno.Text & ",to_date('" & dtpinvdate.Value.Date & "','dd/MM/yyyy'),'" & txtserial.Text & "','" & txtlocation.Text & "'," & txtchalanno.Text & ")"
            insert(query)
            closeconn()
            Me.Close()
            invact.Rbcom.Checked = True
            invact.Show()
        End If
        query = "COMMIT"
        'commitquery(query)
        'closeconn()
    End Sub

    Private Sub btninvdetcreate_Click(sender As Object, e As EventArgs) Handles btninvdetcreate.Click
        Dim id As Integer
        Dim dt As New DataTable
        Dim op As New operation
        dbconnection()
        query = "SELECT COUNT(*) FROM INVOICE WHERE INVNO=" & txtactvalue.Text & ""
        dt = selquery(query)
        If dt.Rows(0)("count(*)") = 0 Then
            MsgBox("no record in invoice")
            invact.Rbcom.Checked = True
            invact.Show()
        Else
            query = "SELECT COUNT(*) FROM INV_DETAILS"
            dt = selquery(query)
            If dt.Rows(0)("count(*)") = 0 Then
                id = 1
            Else
                id = dt.Rows(0)("count(*)")
                id = id + 1
            End If
            query = "INSERT INTO INV_DETAILS VALUES(" & txtactvalue.Text & "," & id & ",'" & txtinvdes.Text & "'," & txtqty.Text & "," & txtrate.Text & "," & txtamt.Text & ")"
            insert(query)
            closeconn()
            Me.Close()
            invact.Show()
        End If
        'query = "COMMIT"
        'commitquery(query)
        closeconn()
    End Sub

    Private Sub operation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconnection()
        closeconn()
    End Sub

    Private Sub txtqty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqty.KeyDown
        If e.KeyCode = e.KeyCode = Keys.Enter Then
            txtrate.Focus()
        End If
    End Sub
    Private Sub txtrate_KeyDown(sender As Object, e As KeyEventArgs) Handles txtrate.KeyDown
        If e.KeyCode = e.KeyCode = Keys.Enter Then
            txtamt.Text = txtqty.Text * txtrate.Text
            txtamt.Focus()
        End If
    End Sub

    Private Sub txtinvdes_KeyDown(sender As Object, e As KeyEventArgs) Handles txtinvdes.KeyDown
        If e.KeyCode = e.KeyCode = Keys.Enter Then
            txtqty.Focus()
        End If
    End Sub

    Private Sub txtrate_TextChanged(sender As Object, e As EventArgs) Handles txtrate.TextChanged
        txtamt.Text = txtqty.Text * txtrate.Text
    End Sub
End Class