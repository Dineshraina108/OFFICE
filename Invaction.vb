Public Class Invaction

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
        'Dim inv As New Invoice
        'inv.Show()
    End Sub

    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        Dim op As New operation
        If Rbcom.Checked = True Then
            op.companel.Visible = True
            op.Width = op.companel.Width
            op.Height = op.companel.Height
            op.companel.Location = New Point(Convert.ToInt32(op.ClientSize.Width / 2 - op.companel.Width / 2), Convert.ToInt32(op.ClientSize.Height / 2 - op.companel.Height / 2))
            op.Show()
        ElseIf rbinv.Checked = True Then
            If txtcomid.Text = "0" Or txtcomid.Text = "" Then
                MsgBox("enter company id")
                lblcomid.Visible = True
                txtcomid.Visible = True
                txtcomid.Focus()
            Else
                op.txtactvalue.Text = txtcomid.Text
                op.invpanel.Visible = True
                op.Width = op.invpanel.Width
                op.Height = op.invpanel.Height
                op.invpanel.Location = New Point(Convert.ToInt32(op.ClientSize.Width / 2 - op.invpanel.Width / 2), Convert.ToInt32(op.ClientSize.Height / 2 - op.invpanel.Height / 2))
                op.Show()
            End If
        ElseIf rbinvdet.Checked = True Then
            If txtinvno.Text = "0" Or txtinvno.Text = "" Then
                MsgBox("enter Invno")
                lblinvno.Visible = True
                txtinvno.Visible = True
                txtinvno.Focus()
            Else
                op.txtactvalue.Text = txtinvno.Text
                op.invdetpanel.Visible = True
                op.Width = op.invdetpanel.Width
                op.Height = op.invdetpanel.Height
                op.invdetpanel.Location = New Point(Convert.ToInt32(op.ClientSize.Width / 2 - op.invdetpanel.Width / 2), Convert.ToInt32(op.ClientSize.Height / 2 - op.invdetpanel.Height / 2))
                op.Show()
            End If
        Else
            MsgBox("select any one")
            Rbcom .Focus ()
        End If

    End Sub

    Private Sub Invaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconnection()
        lblcomid.Visible = False
        lblinvno.Visible = False
        txtcomid.Visible = False
        txtinvno.Visible = False
        closeconn()
    End Sub

    Private Sub rbinv_CheckedChanged(sender As Object, e As EventArgs) Handles rbinv.CheckedChanged
        If rbinv.Checked = True Then
            lblcomid.Visible = True
            txtcomid.Visible = True
        Else
            lblcomid.Visible = False
            txtcomid.Visible = False
        End If
    End Sub

    Private Sub rbinvdet_CheckedChanged(sender As Object, e As EventArgs) Handles rbinvdet.CheckedChanged
        If rbinvdet.Checked = True Then
            lblinvno.Visible = True
            txtinvno.Visible = True
        Else
            lblinvno.Visible = False
            txtinvno.Visible = False
        End If
    End Sub

    Private Sub Rbcom_CheckedChanged(sender As Object, e As EventArgs) Handles Rbcom.CheckedChanged
        lblcomid.Visible = False
        lblinvno.Visible = False
        txtcomid.Visible = False
        txtinvno.Visible = False
    End Sub
End Class