Public Class repact
    Dim stdate, todate As Date
    Dim stmonth, tomonth As Integer
    Dim strstmonth, strtomonth As String
    Dim menuname As String = "Monthly invoice and invdescription"
    Dim FNO As Integer = 1
    Private Sub btnsub_Click(sender As Object, e As EventArgs) Handles btnsub.Click
        Dim query As String
        Dim dt As New DataTable
        If lblfromdate.Text = "From Date" Then
            If lbltodate.Text = "To Date" Then
                stdate = dtfromdate.Text
                todate = dttodate.Text
                If MainMaster.menuname = "Daywise invoice and invdescription" Then
                    query = "SELECT COMID,INVOICE.INVNO,INVDATE,DETID,PARTICULARS,QUANTITY,RATE,AMOUNT FROM INVOICE,INV_DETAILS WHERE INVDATE BETWEEN to_date('" & dtfromdate.Value.Date & "','dd/MM/yyyy') AND  to_date('" & dttodate.Value.Date & "','dd/MM/yyyy') AND INVOICE.INVNO=INV_DETAILS.INVNO ORDER BY COMID"
                    dt = selquery(query)
                    If dt.Rows.Count > 0 Then
                        Dim comname As String = "Daywise Invoice and ivdescription" & FNO.ToString & ""
                        Dim path As String
                        Dim gridvalue As String = ""
                        Dim data As String = ""
                        path = "E:\DINESHKUMAR B\Ebill\bill report\Invoice\Daywise Invoice and ivdescription\" & comname & ".txt"
                        Dim fwrite As New System.IO.StreamWriter(path)
                        fwrite.WriteLine(" ")
                        fwrite.WriteLine(" " & Space(100) & "E-BILL SYSTEM " & Space(120) & "DATE : " & DateTime.Now.Date & "" & Space(70) & "")
                        fwrite.WriteLine(" " & Space(100) & "-----------------------------------")
                        fwrite.WriteLine(" ")
                        fwrite.WriteLine(" " & Space(50) & "DAYWISE INVOICE AND INVOICE DESCRIPTION ")
                        fwrite.WriteLine(" ")
                        FNO += 1
                        For Each cell As DataColumn In dt.Columns
                            gridvalue += cell.ToString + vbTab & vbTab
                        Next
                        fwrite.WriteLine("" & Space(5) & " " & gridvalue & "" & vbTab & "")
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
                                ' MsgBox(Len(gridvalue))
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
                        pr.txtrep.Text = fread
                        pr.Show()
                    Else
                        MsgBox("NO RECORDS FOUND")
                        dtfromdate.Focus()
                    End If
                Else
                    query = "SELECT * FROM INVOICE WHERE INVDATE BETWEEN to_date('" & dtfromdate.Value.Date & "','dd/MM/yyyy') AND  to_date('" & dttodate.Value.Date & "','dd/MM/yyyy')"
                    dt = selquery(query)
                    If dt.Rows.Count > 0 Then
                        Dim comname As String = "Invoice details" & FNO.ToString & ""
                        Dim path As String
                        Dim gridvalue As String = ""
                        Dim data As String = ""
                        path = "E:\DINESHKUMAR B\Ebill\bill report\Invoice\Daywise Invoice\" & comname & ".txt"
                        Dim fwrite As New System.IO.StreamWriter(path)
                        fwrite.WriteLine(" ")
                        fwrite.WriteLine(" " & Space(50) & "E-BILL SYSTEM " & Space(68) & "DATE : " & DateTime.Now.Date & "" & Space(20) & "")
                        fwrite.WriteLine(" " & Space(50) & "-----------------------------------")
                        fwrite.WriteLine(" ")
                        fwrite.WriteLine(" " & Space(50) & "DAYWISE INVOICE DETAILS ")
                        fwrite.WriteLine(" ")
                        FNO += 1
                        For Each cell As DataColumn In dt.Columns
                            gridvalue += cell.ToString + vbTab & vbTab
                        Next
                        fwrite.WriteLine("" & Space(5) & " " & gridvalue & "" & vbTab & "")
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
                                ' MsgBox(Len(gridvalue))
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
                        pr.txtrep.Text = fread
                        pr.Show()
                    Else
                        MsgBox("NO RECORDS")
                    End If
                End If
            End If
        Else
            stmonth = Month(dtfromdate.Text)
            strstmonth = NumberToText(stmonth)
            tomonth = Month(dttodate.Text)
            strtomonth = NumberToText(tomonth)
            If menuname = MainMaster.menuname Then
                query = "SELECT COMID,INVOICE.INVNO,INVDATE,DETID,PARTICULARS,QUANTITY,RATE,AMOUNT FROM INVOICE,INV_DETAILS WHERE INVDATE BETWEEN to_date('" & dtfromdate.Value.Date & "','dd/MM/yyyy') AND  to_date('" & dttodate.Value.Date & "','dd/MM/yyyy') AND INVOICE.INVNO=INV_DETAILS.INVNO ORDER BY COMID"
                dt = selquery(query)
                If dt.Rows.Count > 0 Then
                    Dim comname As String = "Month;y Invoice and ivdescription" & FNO.ToString & ""
                    Dim path As String
                    Dim gridvalue As String = ""
                    Dim data As String = ""
                    path = "E:\DINESHKUMAR B\Ebill\bill report\Invoice\Monthly Invoice and ivdescription\" & comname & ".txt"
                    Dim fwrite As New System.IO.StreamWriter(path)
                    fwrite.WriteLine(" ")
                    fwrite.WriteLine(" " & Space(100) & "E-BILL SYSTEM " & Space(120) & "DATE : " & DateTime.Now.Date & "" & Space(70) & "")
                    fwrite.WriteLine(" " & Space(100) & "-----------------------------------")
                    fwrite.WriteLine(" ")
                    fwrite.WriteLine(" " & Space(50) & "INVOICE AND INVOICE DESCRIPTION FOR MONTH " & strstmonth)
                    fwrite.WriteLine(" ")
                    FNO += 1
                    For Each cell As DataColumn In dt.Columns
                        gridvalue += cell.ToString + vbTab & vbTab
                    Next
                    fwrite.WriteLine("" & Space(5) & " " & gridvalue & "" & vbTab & "")
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
                            ' MsgBox(Len(gridvalue))
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
                    pr.txtrep.Text = fread
                    pr.Show()
                Else
                    MsgBox("NO RECORDS FOUND")
                    dtfromdate.Focus()
                End If
            Else
                query = "SELECT * FROM INVOICE WHERE INVDATE BETWEEN to_date('" & dtfromdate.Value.Date & "','dd/MM/yyyy') AND  to_date('" & dttodate.Value.Date & "','dd/MM/yyyy')"
                dt = selquery(query)
                If dt.Rows.Count > 0 Then
                    Dim comname As String = "Invoice details" & FNO.ToString & ""
                    Dim path As String
                    Dim gridvalue As String = ""
                    Dim data As String = ""
                    path = "E:\DINESHKUMAR B\Ebill\bill report\Invoice\Monthly Invoice\" & comname & ".txt"
                    Dim fwrite As New System.IO.StreamWriter(path)
                    fwrite.WriteLine(" ")
                    fwrite.WriteLine(" " & Space(50) & "E-BILL SYSTEM " & Space(68) & "DATE : " & DateTime.Now.Date & "" & Space(20) & "")
                    fwrite.WriteLine(" " & Space(50) & "-----------------------------------")
                    fwrite.WriteLine(" ")
                    fwrite.WriteLine(" " & Space(50) & "INVOICE DETAILS OF MONTH " & strstmonth)
                    fwrite.WriteLine(" ")
                    FNO += 1
                    For Each cell As DataColumn In dt.Columns
                        gridvalue += cell.ToString + vbTab & vbTab
                    Next
                    fwrite.WriteLine("" & Space(5) & " " & gridvalue & "" & vbTab & "")
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
                            ' MsgBox(Len(gridvalue))
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
                    pr.txtrep.Text = fread
                    pr.Show()
                Else
                    MsgBox("NO RECORDS FOUND")
                    dtfromdate.Focus()
                End If
            End If

        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
    Function NumberToText(ByVal n As Integer) As String

        Select Case n
            Case 0
                Return ""
            Case 1
                Return "JANUARY "
            Case 2
                Return "FEBRUARY"
            Case 3
                Return "MARCH "
            Case 4
                Return "APRIL"
            Case 5
                Return "MAY"
            Case 6
                Return "JUNE"
            Case 7
                Return "JULY"
            Case 8
                Return "AUGUST"
            Case 9
                Return "SEPTEMBER"
            Case 10
                Return "OCTOBER"
            Case 11
                Return "NOVEMBER"
            Case 12
                Return "DECEMBER"
            Case Else
                Return ""
        End Select
    End Function
End Class