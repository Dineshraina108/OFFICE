Imports Oracle.DataAccess.Client
Imports Telerik.WinControls.UI
Imports System.Globalization
Imports System.Text.RegularExpressions
Public Class Register
    Dim uid As Integer
    Dim uname, pass, repass, emailid As String
    Dim Query As String = String.Empty
    Dim qry As String = String.Empty
    Dim q As String = String.Empty
    Dim Tval As Long = 0
    Dim dt As New DataTable
    Dim emailformat As Regex = New Regex("^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,6}$")
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        closeconn()
        dbconnection()
    End Sub

    Private Sub btnsub_Click(sender As Object, e As EventArgs) Handles btnsub.Click
        uid = txtuid.Text
        uname = txtusername.Text
        pass = txtpassword.Text
        repass = txtrepass.Text
        emailid = txtemail.Text
        'mobno = txtmobno.Text
        Dim dt As New DataTable
        If pass = repass Then
            qry = "SELECT * from CALOGIN where LID=" & uid & "AND USERNAME='" & uname & "'"
            Using cmd As New OracleCommand(qry, cuscon)
                Using ora_ada As New OracleDataAdapter(cmd)
                    ora_ada.Fill(dt)
                End Using
            End Using
            If dt.Rows.Count = 1 Then
                q = "UPDATE CAREG SET PASSWORD='" & pass & "', REPASSWORD='" & repass & "' WHERE USID=" & uid & "AND USERNAME='" & uname & "'"
                Update1(q)
                qry = "UPDATE CALOGIN SET PASSWORD='" & pass & "'WHERE LID=" & uid & "AND USERNAME='" & uname & "'"
                Update1(qry)
            Else
                If emailformat.IsMatch(emailid) Then
                    If Len(txtmobno.Text) > 10 Or Len(txtmobno.Text) < 10 Then
                        MsgBox("INVALID MOBILE NUMBER")
                        txtmobno.Focus()
                    Else
                        Query = "INSERT INTO CAREG VALUES (" & uid & ",'" & uname & "','" & pass & "','" & repass & "','" & emailid & "'," & txtmobno.Text & ")"
                        insert(Query)
                        qry = "INSERT INTO CALOGIN VALUES(" & uid & ",'" & uname & "','" & pass & "')"
                        insert(qry)
                        cuscon.Close()
                        Dim loginobj As New Login
                        loginobj.Show()
                    End If
                Else
                    MsgBox("INVALID EMAIL ID")
                    txtemail.Focus()
                End If
            End If
        Else
            MsgBox("PASSWORD AND REPASSWORD NOT MATCH")
            txtpassword.Focus()
        End If
    End Sub

    Private Sub llblforgetpas_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblforgetpas.LinkClicked
        Dim loginobj As New Login
        loginobj.Show()
    End Sub
End Class