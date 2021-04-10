Public Class Company
    Dim cdt, idt As New DataTable
    Dim query As String
    Dim fno As Integer = 1
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnsub_Click(sender As Object, e As EventArgs) Handles btnsub.Click
        Dim inv As New Invoice
        Dim dt As New DataTable
        query = "SELECT COMPANY_DETAILS.COMID,INVNO,COMNAME,ADDRESS,INVDATE,SERIAL,LOCATION,CHALANNO FROM COMPANY_DETAILS INNER JOIN INVOICE ON INVOICE.COMID=COMPANY_DETAILS.COMID WHERE COMNAME ='" & Cbcomp.Text & "' AND INVOICE.INVNO=" & cbinvno.Text & ""
        dt = selquery(query)
        inv.txtcomname.Text = Cbcomp.Text
        inv.txtinvno.Text = cbinvno.Text
        inv.txtaddr.Text = dt.Rows(0)("ADDRESS").ToString
        inv.dtpinvdate.Text = dt.Rows(0)("INVDATE").ToString
        inv.txtserial.Text = dt.Rows(0)("SERIAL").ToString
        inv.txtlocation.Text = dt.Rows(0)("LOCATION").ToString
        inv.txtchalanno.Text = dt.Rows(0)("CHALANNO").ToString
        Me.Close()
        inv.Show()
        'Report.UserList.RptEmpSalary ES = New Report.UserList.RptEmpSalary();
        '    ES.MdiParent = this;
        '    ES.Show();
    End Sub

    Private Sub cbinvno_SelectedIndexChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub Cbcomp_KeyDown(sender As Object, e As KeyEventArgs) Handles Cbcomp.KeyDown
        If e.KeyCode = Keys.Enter Then
            query = "SELECT COMID,INVNO FROM INVOICE WHERE COMID=" & Cbcomp.SelectedValue & ""
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
        End If
    End Sub

    Private Sub btndlcan_Click(sender As Object, e As EventArgs) Handles btndlcan.Click
        Me.Close()
    End Sub

    Private Sub btndsub_Click(sender As Object, e As EventArgs) Handles btndsub.Click
        Dim cid, inid, deid As Integer
        Dim dt As New DataTable
        If cmbdelcom.SelectedValue = 0 Then
            If cmbdelin.Text = "" Then
                If cmbdeldid.Text = "" Then
                    cid = 0
                    inid = 0
                    deid = 0
                Else
                    deid = cmbdeldid.Text
                    inid = 0
                    cid = 0
                End If
            Else
                cid = 0
                inid = cmbdelin.Text
                deid = cmbdeldid.Text
            End If
        ElseIf cmbdelin.Text = "" Then
            If cmbdeldid.Text = "" Then
                cid = cmbdelcom.SelectedValue
                inid = 0
                deid = 0
            Else
                deid = cmbdeldid.Text
                inid = 0
                cid = cmbdelcom.SelectedValue
            End If
        ElseIf cmbdeldid.Text = "" Then
            cid = cmbdelcom.SelectedValue
            inid = cmbdelin.Text
            deid = 0
        Else
            cid = cmbdelcom.SelectedValue
            inid = cmbdelin.Text
            deid = cmbdeldid.Text
        End If
        dbconnection()
            If cid > 0 Then
                If inid > 0 Then
                    If deid > 0 Then
                        query = "DELETE FROM INV_DETAILS WHERE DETID=" & deid & ""
                        del(query)
                        Me.Close()
                    Else
                    query = "SELECT COUNT(*) FROM INV_DETAILS WHERE INVNO=" & inid & ""
                    dt = selquery(query)
                        If dt.Rows(0)("COUNT(*)") > 0 Then
                        query = "DELETE FROM INVOICE WHERE COMID =" & cid & "AND INVNO=" & inid & ""
                        del(query)
                            query = "DELETE FROM INV_DETAILS WHERE INVO=" & inid & ""
                            del(query)
                        Else
                        query = "DELETE FROM INVOICE WHERE COMID =" & cid & "AND INVNO=" & inid & ""
                        del(query)
                        End If
                        Me.Close()
                    End If
                Else
                query = "SELECT COUNT(*) FROM INVOICE WHERE COMID =" & cid & ""
                dt = selquery(query)
                    If dt.Rows(0)("COUNT(*)") > 0 Then
                        query = "DELETE FROM COMPANY_DETAILS WHERE COMID =" & cid & ""
                        del(query)
                    query = "DELETE FROM INVOICE WHERE COMID =" & cid & "AND INVNO=" & inid & ""
                    del(query)
                    query = "DELETE FROM INV_DETAILS WHERE INVNO=" & inid & ""
                    del(query)
                    Else
                        query = "DELETE FROM COMPANY_DETAILS WHERE COMID =" & cid & ""
                        del(query)
                    End If
                    Me.Close()
                End If
            Else
                MsgBox("NO RECORDS")
            End If
        query = "COMMIT"
        commitquery(query)
        closeconn()
    End Sub

    Private Sub cmbdelcom_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbdelcom.KeyDown
        If e.KeyCode = Keys.Enter Then
            query = "SELECT COMID,INVNO FROM INVOICE WHERE COMID=" & cmbdelcom.SelectedValue & ""
            idt = selquery(query)
            If idt.Rows.Count = 0 Then
                MsgBox("No records in company")
            Else
                cmbdelin.DataSource = idt
                Dim Irow As DataRow = idt.NewRow()
                Irow(0) = 0
                idt.Rows.InsertAt(Irow, 0)
                cmbdelin.DisplayMember = "INVNO"
                cmbdelin.ValueMember = "COMID"
            End If
        End If
    End Sub

    Private Sub cmbdeldid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdeldid.SelectedIndexChanged
    End Sub

    Private Sub cmbdelin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdelin.SelectedIndexChanged

    End Sub

    Private Sub cmbdelin_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbdelin.KeyDown
        query = "SELECT INVNO,DETID FROM INV_DETAILS WHERE INVNO=" & cmbdelin.Text & ""
        cdt = selquery(query)
        If cdt.Rows.Count = 0 Then
            MsgBox("No records in company")
        Else
            cmbdeldid.DataSource = cdt
            Dim row As DataRow = cdt.NewRow()
            row(0) = 0
            cdt.Rows.InsertAt(row, 0)
            cmbdeldid.DisplayMember = "DETID"
            cmbdeldid.ValueMember = "INVNO"
        End If
    End Sub

    Private Sub cbinvno_KeyDown(sender As Object, e As KeyEventArgs) Handles cbinvno.KeyDown
        btndsub.Focus()
    End Sub

    Private Sub repcmbcom_KeyDown(sender As Object, e As KeyEventArgs) Handles repcmbcom.KeyDown
        If e.KeyCode = Keys.Enter Then
            query = "SELECT COMID,INVNO FROM INVOICE WHERE COMID=" & cmbdelcom.SelectedValue & ""
            idt = selquery(query)
            If idt.Rows.Count = 0 Then
                MsgBox("No records in company")
            Else
                repcmbinv.DataSource = idt
                Dim Irow As DataRow = idt.NewRow()
                Irow(0) = 0
                idt.Rows.InsertAt(Irow, 0)
                repcmbinv.DisplayMember = "INVNO"
                repcmbinv.ValueMember = "COMID"
            End If
        End If
    End Sub

    Private Sub repcmbinv_KeyDown(sender As Object, e As KeyEventArgs) Handles repcmbinv.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnrepsub.Focus()
        End If

    End Sub

    Private Sub btnrepsub_Click(sender As Object, e As EventArgs) Handles btnrepsub.Click
        Dim revi As New repview
        Dim dt As New DataTable
        Dim path As String
        Dim gridvalue As String = ""
        Dim data As String = ""
        If repcmbcom.SelectedValue > 0 Then
            If repcmbinv.SelectedValue > 0 Then
                Dim invname As String = "Invoice Description" & fno.ToString & ""
                path = "E:\DINESHKUMAR B\Ebill\bill report\Invoice\Invoice description\" & invname & ".txt"
                query = "SELECT * FROM INV_DETAILS WHERE INVNO=" & repcmbinv.Text & ""
                dt = selquery(query)
                Dim fwrite As New System.IO.StreamWriter(path)
                fwrite.WriteLine(" ")
                fwrite.WriteLine(" " & Space(50) & "E-BILL SYSTEM " & Space(68) & "DATE : " & DateTime.Now.Date & "")
                fwrite.WriteLine(" " & Space(50) & "-----------------------------------")
                fwrite.WriteLine(" ")
                fwrite.WriteLine(" " & Space(50) & "INVOICE DESCRIPTION FOR INVNO " & repcmbinv.Text & " ")
                fwrite.WriteLine(" ")
                fno += 1
                For Each cell As DataColumn In dt.Columns
                    gridvalue += cell.ToString + vbTab
                    gridvalue += vbTab
                Next
                fwrite.WriteLine("" & Space(5) & " " & gridvalue & "")
                fwrite.WriteLine(" " & Space(65) & "-----------------------------------")
                gridvalue = ""
                For Each row As DataRow In dt.Rows
                    For Each cell As DataColumn In dt.Columns
                        data += row(cell).ToString
                        If Len(data) < 3 Then
                            If Len(gridvalue) > 3 Then
                                gridvalue += data & vbTab & vbTab
                                data = ""
                            Else
                                gridvalue += data & vbTab & vbTab & vbTab
                                data = ""
                            End If
                        Else
                            gridvalue += data + vbTab & vbTab
                            data = ""
                        End If
                        'gridvalue += Space(Len(gridvalue) - 5)
                        '  MsgBox(Len(gridvalue))
                    Next
                    fwrite.WriteLine("" & Space(5) & " " & gridvalue & "")
                    fwrite.WriteLine(" " & Space(65) & "-----------------------------------")
                    gridvalue = ""
                Next
                fwrite.WriteLine(" ")
                fwrite.WriteLine(" " & Space(65) & "-----------------------------------")
                fwrite.Close()
                Dim fread As String
                fread = My.Computer.FileSystem.ReadAllText(path)
                Dim pr As New repview
                revi.txtrep.Text = fread
                Me.Close()
                revi.Show()
            Else
                Dim invname As String = "Invoice details" & fno.ToString & ""
                path = "E:\DINESHKUMAR B\Ebill\bill report\Company\Invoice Report\" & invname & ".txt"
                query = "SELECT * FROM INVOICE WHERE COMID=" & repcmbcom.SelectedValue & ""
                dt = selquery(query)
                Dim fwrite As New System.IO.StreamWriter(path)
                fwrite.WriteLine(" ")
                fwrite.WriteLine(" " & Space(50) & "E-BILL SYSTEM " & Space(68) & "DATE : " & DateTime.Now.Date & "")
                fwrite.WriteLine(" " & Space(50) & "-----------------------------------")
                fwrite.WriteLine(" ")
                fwrite.WriteLine(" " & Space(50) & "INVOICE DETAILS OF " & repcmbcom.Text & " ")
                fwrite.WriteLine(" ")
                fno += 1
                For Each cell As DataColumn In dt.Columns
                    gridvalue += cell.ToString + vbTab
                    gridvalue += vbTab
                Next
                fwrite.WriteLine("" & Space(5) & " " & gridvalue & "")
                fwrite.WriteLine(" " & Space(65) & "-----------------------------------")
                gridvalue = ""
                For Each row As DataRow In dt.Rows
                    For Each cell As DataColumn In dt.Columns
                        data += row(cell).ToString
                        If Len(data) < 3 Then
                            If Len(gridvalue) > 3 Then
                                gridvalue += data & vbTab & vbTab
                                data = ""
                            Else
                                gridvalue += data & vbTab & vbTab & vbTab
                                data = ""
                            End If
                        Else
                            gridvalue += data + vbTab & vbTab
                            data = ""
                        End If
                        'gridvalue += Space(Len(gridvalue) - 5)
                        'MsgBox(Len(gridvalue))
                    Next
                    fwrite.WriteLine("" & Space(5) & " " & gridvalue & "")
                    fwrite.WriteLine(" " & Space(65) & "-----------------------------------")
                    gridvalue = ""
                Next
                fwrite.WriteLine(" ")
                fwrite.WriteLine(" " & Space(65) & "-----------------------------------")
                fwrite.Close()
                Dim fread As String
                fread = My.Computer.FileSystem.ReadAllText(path)
                Dim pr As New repview
                revi.txtrep.Text = fread
                Me.Close()
                revi.Show()
            End If
        Else
            MsgBox("Please Select a company")
            repcmbcom.Focus()
        End If
    End Sub

    Private Sub btnrepcan_Click(sender As Object, e As EventArgs) Handles btnrepcan.Click
        Me.Close()
    End Sub

    Private Sub Company_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cdt As New DataTable
        dbconnection()
        query = "SELECT COMID,COMNAME FROM COMPANY_DETAILS"
        cdt = selquery(query)
        If cdt.Rows.Count = 0 Then
            MsgBox("No records in company")
            Me.Close()
        Else
            Cbcomp.DataSource = cdt
            cmbdelcom.DataSource = cdt
            repcmbcom.DataSource = cdt
            Dim row As DataRow = cdt.NewRow()
            row(0) = 0
            row(1) = "select a company"
            cdt.Rows.InsertAt(row, 0)
            Cbcomp.DisplayMember = "COMNAME"
            Cbcomp.ValueMember = "COMID"
            cmbdelcom.DisplayMember = "COMNAME"
            cmbdelcom.ValueMember = "COMID"
            repcmbcom.DisplayMember = "COMNAME"
            repcmbcom.ValueMember = "COMID"
        End If
        closeconn()
    End Sub
End Class