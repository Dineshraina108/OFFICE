Imports Oracle.DataAccess.Client
Imports System.Text.RegularExpressions
Public Class Usreg
    Dim uid As Integer
    Dim uname, pass, repass, emailid, mobileno, usrivillage As String
    Dim Query As String = String.Empty
    Dim qry As String = String.Empty
    Dim q As String = String.Empty
    Dim Tval As Long = 0
    Dim emailformat As Regex = New Regex("^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,6}$")
    Private Sub llblallogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblallogin.LinkClicked
        Dim log As New Login
        log.Show()
    End Sub

    Private Sub RDS_CheckedChanged(sender As Object, e As EventArgs) Handles RDS.CheckedChanged
        If RDS.Checked = True Then
            RDN.Checked = False
            usrivillage = RDS.Text
        End If
    End Sub

    'Private Sub lblup_Click(sender As Object, e As EventArgs) Handles lblup.Click

    'End Sub

    'Private Sub txtusid_TextChanged(sender As Object, e As EventArgs) Handles txtusid.TextChanged

    'End Sub

    'Private Sub lbluserid_Click(sender As Object, e As EventArgs) Handles lbluserid.Click

    'End Sub

    'Private Sub txtmobno_TextChanged(sender As Object, e As EventArgs) Handles txtmobno.TextChanged

    'End Sub

    'Private Sub txtemail_TextChanged(sender As Object, e As EventArgs) Handles txtemail.TextChanged

    'End Sub

    'Private Sub txturepass_TextChanged(sender As Object, e As EventArgs) Handles txturepass.TextChanged

    'End Sub

    'Private Sub txtupass_TextChanged(sender As Object, e As EventArgs) Handles txtupass.TextChanged

    'End Sub

    'Private Sub txtuname_TextChanged(sender As Object, e As EventArgs) Handles txtuname.TextChanged

    'End Sub

    'Private Sub lablmobno_Click(sender As Object, e As EventArgs) Handles lablmobno.Click

    'End Sub

    'Private Sub lblemal_Click(sender As Object, e As EventArgs) Handles lblemal.Click

    'End Sub

    'Private Sub lblrepass_Click(sender As Object, e As EventArgs) Handles lblrepass.Click

    'End Sub

    'Private Sub lblpass_Click(sender As Object, e As EventArgs) Handles lblpass.Click

    'End Sub

    'Private Sub lbluname_Click(sender As Object, e As EventArgs) Handles lbluname.Click

    'End Sub

    'Private Sub lblusreg_Click(sender As Object, e As EventArgs) Handles lblusreg.Click

    'End Sub

    Private Sub RDN_CheckedChanged(sender As Object, e As EventArgs) Handles RDN.CheckedChanged
        If RDN.Checked = True Then
            RDS.Checked = False
            usrivillage = RDN.Text
        End If
    End Sub

    Private Sub Usreg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconnection()
        RDN.Checked = True
    End Sub
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Clear()
    End Sub

    Private Sub btnreg_Click(sender As Object, e As EventArgs) Handles btnreg.Click

        uid = txtusid.Text
        uname = txtuname.Text
        pass = txtupass.Text
        repass = txturepass.Text
        emailid = txtemail.Text
        mobileno = txtmobno.Text

        Dim dt As New DataTable
        If pass = repass Then
            qry = "SELECT count(*) from ureg where userid=" & uid & "AND USERNAME='" & uname & "'"
            dt = selquery(qry)
            cuscon.Close()
            If dt.Rows(0)("count(*)").ToString = "1" Then
                q = "UPDATE ureg SET UPASS='" & pass & "', REPASS='" & repass & "' WHERE USERID=" & uid & "AND USERNAME='" & uname & "'"
                Updatequery(q)
            Else
                If emailformat.IsMatch(emailid) Then
                    If Len(txtmobno.Text) > 10 Or Len(txtmobno.Text) < 10 Then
                        MsgBox("INVALID MOBILE NUMBER")
                        Clear()
                    Else
                        dbconnection()
                        Query = "INSERT INTO UREG VALUES (" & uid & ",'" & uname & "','" & pass & "','" & repass & "','" & emailid & "'," & txtmobno.Text & ",'" & usrivillage & "')"
                        insert(Query)
                        cuscon.Close()
                        Dim loginobj As New Login
                        loginobj.Show()
                    End If
                Else
                    MsgBox("INVALID EMAIL ID")
                    Clear()
                End If
            End If
        Else
            MsgBox("PASSWORD AND REPASSWORD NOT MATCH")
            'Clear()
        End If

    End Sub
    Public Sub Clear()
        txtusid.Text = ""
        txtuname.Text = ""
        txtupass.Text = ""
        txturepass.Text = ""
        txtemail.Text = ""
        txtmobno.Text = ""
        usregpanel.Update()
        txtusid.Focus()
    End Sub
End Class