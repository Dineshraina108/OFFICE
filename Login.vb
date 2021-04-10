Imports Oracle.DataAccess.Client
Imports Telerik.WinControls.UI
Imports System.Globalization
Public Class Login
    Dim qry As String = String.Empty
    Dim Tval1 As Long = 0
    Dim dt As New DataTable
    Dim f1 As New Form1
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnsign_Click(sender As Object, e As EventArgs) Handles btnsign.Click
        dbconnection()
        If txtusername.Text = "" Or txtpassword.Text = "" Then
            MsgBox("ENTER USER NAME AND PASSWORD")
        Else
            qry = "SELECT * from CALOGIN where USERNAME ='" & txtusername.Text & "'AND PASSWORD ='" & txtpassword.Text & "'"
            Using cmd As New OracleCommand(qry, cuscon)
                Using ora_ada As New OracleDataAdapter(cmd)
                    ora_ada.Fill(dt)
                End Using
            End Using
            If dt.Rows.Count = 1 Then
                closeconn()
                f1.Show()
            Else
                MsgBox("INVALID USER")
                txtusername.Focus()
            End If
        End If
        closeconn()
    End Sub

    Private Sub llblforgetpas_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblforgetpas.LinkClicked
        closeconn()
        Dim re As New Register
        re.txtemail.Visible = False
        re.txtmobno.Visible = False
        re.lablmono.Visible = False
        re.lblemail.Visible = False
        re.Show()
    End Sub

    Private Sub btnsignup_Click(sender As Object, e As EventArgs) Handles btnsignup.Click
        closeconn()
        Dim re As New Register
        re.Show()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class