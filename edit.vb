Public Class edit
    Dim cdt, idt As New DataTable
    Dim query As String

    Private Sub Cbcom_KeyDown(sender As Object, e As KeyEventArgs) Handles Cbcom.KeyDown
        query = "SELECT COMID,INVNO FROM INVOICE WHERE COMID=" & Cbcom.SelectedValue & ""
        idt = selquery(query)
        If idt.Rows.Count = 0 Then
            MsgBox("No records in company")
        Else
            cbinvno.DataSource = idt
            Dim Irow As DataRow = idt.NewRow()
            Irow(0) = 0
            idt.Rows.InsertAt(Irow, 0)
            cbinvno.DisplayMember = "INVNO"
            cbinvno.ValueMember = "COMID"
        End If
    End Sub

    Private Sub cmbcom_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbcom.KeyDown
        query = "SELECT COMID,INVNO FROM INVOICE WHERE COMID=" & cmbcom.SelectedValue & ""
        idt = selquery(query)
        If idt.Rows.Count = 0 Then
            MsgBox("No records in company")
        Else
            cmbinv.DataSource = idt
            Dim Irow As DataRow = idt.NewRow()
            Irow(0) = 0
            idt.Rows.InsertAt(Irow, 0)
            cmbinv.DisplayMember = "INVNO"
            cmbinv.ValueMember = "COMID"
        End If
    End Sub

    Private Sub cmbinv_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbinv.KeyDown
        query = "SELECT INVNO,DETID FROM INV_DETAILS WHERE INVNO=" & cmbinv.SelectedValue & ""
        cdt = selquery(query)
        If cdt.Rows.Count = 0 Then
            MsgBox("No records in company")
        Else
            cmbdid.DataSource = cdt
            Dim row As DataRow = cdt.NewRow()
            row(0) = 0
            cdt.Rows.InsertAt(row, 0)
            cmbdid.DisplayMember = "DETID"
            cmbdid.ValueMember = "INVNO"
        End If
    End Sub

    Private Sub Cbcomp_KeyDown(sender As Object, e As KeyEventArgs) Handles Cbcomp.KeyDown
        Dim cdt As New DataTable
        query = "SELECT COMNAME,ADDRESS FROM COMPANY_DETAILS WHERE COMID=" & Cbcomp.SelectedValue & ""
        cdt = selquery(query)
        If cdt.Rows.Count = 0 Then
            MsgBox("No records in company")
        Else
            txtcomname.Text = cdt.Rows(0)("COMNAME").ToString
            txtaddr.Text = cdt.Rows(0)("ADDRESS").ToString
        End If
    End Sub

    Private Sub cbinvno_KeyDown(sender As Object, e As KeyEventArgs) Handles cbinvno.KeyDown
        Dim cdt As New DataTable
        query = "SELECT INVDATE,SERIAL,LOCATION,CHALANNO FROM INVOICE WHERE INVNO=" & cbinvno.SelectedValue & ""
        cdt = selquery(query)
        If cdt.Rows.Count = 0 Then
            MsgBox("No records in invoice")
        Else
            dtpinvdate.Text = cdt.Rows(0)("INVDATE").ToString
            txtserial.Text = cdt.Rows(0)("SERIAL").ToString
            txtlocation.Text = cdt.Rows(0)("LOCATION").ToString
            txtchalanno.Text = cdt.Rows(0)("CHALANNO").ToString
        End If
    End Sub

    Private Sub cmbdid_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbdid.KeyDown
        Dim cdt As New DataTable
        query = "SELECT PARTICULARS,QUANTITY,RATE,AMOUNT FROM INV_DETAILS WHERE INVNO=" & cmbdid.SelectedValue & ""
        cdt = selquery(query)
        If cdt.Rows.Count = 0 Then
            MsgBox("No records in company")
        Else
            txtinvdes.Text = cdt.Rows(0)("PARTICULARS").ToString
            txtqty.Text = cdt.Rows(0)("QUANTITY").ToString
            txtrate.Text = cdt.Rows(0)("RATE").ToString
            txtamt.Text = txtqty.Text * txtrate.Text
        End If

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btninvcancel_Click(sender As Object, e As EventArgs) Handles btninvcancel.Click
        Me.Close()
    End Sub

    Private Sub btninvdetcancel_Click(sender As Object, e As EventArgs) Handles btninvdetcancel.Click
        Me.Close()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        dbconnection()
        query = "Update COMPANY_DETAILS Set comname='" & txtcomname.Text & "',address='" & txtaddr.Text & "' where COMID=" & Cbcomp.SelectedValue & ""
        Updatequery(query)
        closeconn()
    End Sub

    Private Sub btninvup_Click(sender As Object, e As EventArgs) Handles btninvup.Click
        dbconnection()
        query = "Update INVOICE Set INVDATE='" & dtpinvdate.Text & "',SERIAL=" & txtserial.Text & ",LOCATION='" & txtlocation.Text & "',CHALANNO=" & txtchalanno.Text & " where COMID=" & Cbcom.SelectedValue & "AND INVNO=" & cbinvno.SelectedValue & ""
        Updatequery(query)
        closeconn()
    End Sub

    Private Sub btninvdesup_Click(sender As Object, e As EventArgs) Handles btninvdesup.Click
        dbconnection()
        query = "Update INV_DETAILS Set PARTICULARS='" & txtinvdes.Text & "',QUANTITY=" & txtqty.Text & ",RATE=" & txtrate.Text & ",AMOUNT=" & txtamt.Text & " where INVNO=" & cmbinv.SelectedValue & "AND DETID=" & cmbdid.SelectedValue & ""
        Updatequery(query)
        closeconn()
    End Sub

    Private Sub cbinvno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbinvno.SelectedIndexChanged

    End Sub

    Private Sub edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cdt As New DataTable
        dbconnection()
        query = "SELECT COMID FROM COMPANY_DETAILS"
        cdt = selquery(query)
        If cdt.Rows.Count = 0 Then
            MsgBox("No records in company")
        Else
            Cbcomp.DataSource = cdt
            Cbcom.DataSource = cdt
            cmbcom.DataSource = cdt
            Dim row As DataRow = cdt.NewRow()
            row(0) = 0
            cdt.Rows.InsertAt(row, 0)
            Cbcomp.DisplayMember = "COMID"
            Cbcomp.ValueMember = "COMID"
            Cbcom.DisplayMember = "COMID"
            Cbcom.ValueMember = "COMID"
            cmbcom.DisplayMember = "COMID"
            cmbcom.ValueMember = "COMID"
        End If
        closeconn()
    End Sub
End Class

