Imports Oracle.DataAccess.Client
Imports Telerik.WinControls.UI
Public Class Customer
    Dim cuid As Integer
    Dim cname, cdob As String
    Dim cmobo As String
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtcusid.Focus()
        txtcusid.Text = ""
        txtname.Text = ""
        txtmobno.Text = ""
        cupanel1.Update()

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        cuid = txtcusid.Text
        cname = txtname.Text
        cdob = dtpdob.Value.Date
        cmobo = txtmobno.Text
    End Sub

    Private Sub btnsub_Click(sender As Object, e As EventArgs) Handles btnsub.Click
        txtcusid.Focus()
    End Sub
End Class