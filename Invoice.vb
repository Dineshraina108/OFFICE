Imports System.IO.StreamWriter
Public Class Invoice
    Dim query As String
    Dim dt As New DataTable
    Dim amt As Integer = 0
    Dim gridvalue As String = ""
    Dim billno As Integer = 1
    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        'Dim invact As New Invaction
        'query = "SELECT USERPRIVILLAGE FROM UREG WHERE USERNAME='" & lbluser.Text & "'"
        'dt = selquery(query)
        'If dt.Rows(0)("USERPRIVILLAGE").ToString = "YES " Then
        '    invact.Rbcom.Visible = True
        '    invact.Rbcom.Checked = True
        'Else
        '    invact.Rbcom.Visible = False
        '    invact.rbinv.Checked = True
        'End If
        'Me.Close()
        'invact.Show()
        txtcomname.Text = ""
        txtaddr.Text = ""
        txtinvno.Text = ""
        txtserial.Text = ""
        txtlocation.Text = ""
        txtchalanno.Text = ""
        Me.Close()
        Dim de As New Company
        de.selpanel.Visible = True
        de.delpanel.Visible = False
        de.Width = de.delpanel.Width
        de.Height = de.delpanel.Height
        de.selpanel.Location = New Point(Convert.ToInt32(de.ClientSize.Width / 2 - de.selpanel.Width / 2), Convert.ToInt32(de.ClientSize.Height / 2 - de.selpanel.Height / 2))
        de.Show()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconnection()
        lbluser.Text = Login.uname
        closeconn()
    End Sub

    Private Sub btngetbill_Click(sender As Object, e As EventArgs) Handles btngetbill.Click
        query = "SELECT DETID,PARTICULARS,QUANTITY,RATE,AMOUNT FROM INV_DETAILS WHERE INVNO=" & txtinvno.Text & ""
        dt = selquery(query)
        RGVinvdeatils.DataSource = dt
        lblamoutinwords.Visible = True
        lblamt.Visible = True
        For Each amtrow As DataRow In dt.Rows
            amt = amt + amtrow.Item("AMOUNT")
        Next
        lblamt.Text = amt
        lblamoutinwords.Text = NumberToText(amt)
    End Sub
    Function NumberToText(ByVal n As Integer) As String

        Select Case n
            Case 0
                Return ""

            Case 1 To 19
                Dim arr() As String = {"One", "Two", "Three", "Four", "Five", "Six", "Seven",
                  "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
                    "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                Return arr(n - 1) & " "

            Case 20 To 99
                Dim arr() As String = {"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}
                Return arr(n \ 10 - 2) & " " & NumberToText(n Mod 10)

            Case 100 To 199
                Return "One Hundred " & NumberToText(n Mod 100)

            Case 200 To 999
                Return NumberToText(n \ 100) & "Hundreds " & NumberToText(n Mod 100)

            Case 1000 To 1999
                Return "One Thousand " & NumberToText(n Mod 1000)

            Case 2000 To 999999
                Return NumberToText(n \ 1000) & "Thousands " & NumberToText(n Mod 1000)

            Case 1000000 To 1999999
                Return "One Million " & NumberToText(n Mod 1000000)

            Case 1000000 To 999999999
                Return NumberToText(n \ 1000000) & "Millions " & NumberToText(n Mod 1000000)

            Case 1000000000 To 1999999999
                Return "One Billion " & NumberToText(n Mod 1000000000)

            Case Else
                Return NumberToText(n \ 1000000000) & "Billion " _
                  & NumberToText(n Mod 1000000000)
        End Select
    End Function

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Dim billname As String = "Bill" & billno.ToString & ""
        Dim dt As New DataTable
        Dim path As String
        path = "E:\DINESHKUMAR B\Ebill\bill report\" & billname & ".txt"
        '  p = "E:\DINESHKUMAR B\Ebill\bill report\Bill.txt"
        dt = RGVinvdeatils.DataSource
        If Chksave.Checked = True Then
            Dim fwrite As New System.IO.StreamWriter(path)
            fwrite.WriteLine(" ")
            fwrite.WriteLine(" " & Space(5) & "BILL NO :  " & billno & " " & Space(50) & "E-BILL SYSTEM " & Space(68) & "BILL DATE : " & DateTime.Now.Date & "")
            fwrite.WriteLine(" " & Space(80) & "-----------------------------------")
            fwrite.WriteLine(" ")
            fwrite.WriteLine(" " & Space(5) & "COMPANY NAME : " & txtcomname.Text & " " & Space(80) & "INVO :  " & txtinvno.Text & "")
            fwrite.WriteLine(" " & Space(5) & "COMPANY ADDRESS : " & txtaddr.Text & " " & Space(67) & " INVOICE DATE : " & dtpinvdate.Value.Date & "")
            fwrite.WriteLine(" " & Space(154) & " SERIAL : " & txtserial.Text & "")
            fwrite.WriteLine(" " & Space(154) & " LOCATION : " & txtlocation.Text & "")
            fwrite.WriteLine(" " & Space(154) & " CHALAN NO : " & txtchalanno.Text & "")
            fwrite.WriteLine(" " & Space(65) & "-----------------------------------")
            fwrite.WriteLine(" ")
            ' fwrite.Close()
            'datatablewrite(dt, p)
            For Each cell As DataColumn In dt.Columns
                gridvalue += cell.ToString + vbTab & vbTab
                'gridvalue += vbTab
            Next
            fwrite.WriteLine("" & Space(5) & " " & gridvalue & "")
            gridvalue = ""
            'gridvalue += vbCr & vbLf
            For Each row As DataRow In dt.Rows
                For Each cell As DataColumn In dt.Columns
                    gridvalue += row(cell).ToString + vbTab & vbTab
                    gridvalue += vbTab
                Next
                fwrite.WriteLine("" & Space(5) & " " & gridvalue & "")
                gridvalue = ""
                'gridvalue += vbCr & vbLf
            Next
            fwrite.WriteLine(" ")
            fwrite.WriteLine(" " & Space(65) & "-----------------------------------")
            fwrite.WriteLine(" ")
            fwrite.WriteLine(" " & Space(5) & " " & lblamoutinwords.Text & "" & Space(110) & " TOTAL AMOUNT : " & lblamt.Text & "")
            fwrite.WriteLine(" ")
            fwrite.WriteLine(" " & Space(65) & "-----------------------------------")
            fwrite.Close()
            billno += 1
        End If
        Dim fread As String
        fread = My.Computer.FileSystem.ReadAllText("E:\DINESHKUMAR B\Ebill\bill report\Bill1.txt")
        Dim pr As New repview
        pr.txtrep.Text = fread
        pr.Show()
    End Sub

    Private Sub lblamt_Click(sender As Object, e As EventArgs) Handles lblamt.Click

    End Sub
    'Public Sub datatablewrite(ByVal table As DataTable, ByRef path As String)
    '    If table.Columns.Count < 0 Or table.Rows.Count < 0 Then
    '        Exit Sub
    '    End If
    '    Using sw As IO.StreamWriter = New IO.StreamWriter(path)
    '        '
    '        For row As Integer = 0 To table.Rows.Count - 2
    '            For col As Integer = 0 To table.Columns.Count - 2
    '                sw.Write(table.Rows(row).Item(col).ToString)
    '            Next
    '            sw.Write(table.Rows(row).Item(table.Columns.Count - 1).ToString & Environment.NewLine)
    '        Next
    '        For col As Integer = 0 To table.Columns.Count - 2
    '            sw.Write(table.Rows(table.Rows.Count - 1).Item(col).ToString)
    '        Next
    '        sw.Write(table.Rows(table.Rows.Count - 1).Item(table.Columns.Count - 1).ToString)
    '    End Using
    'End Sub
End Class
