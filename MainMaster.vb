Imports System.Windows.Forms
Imports System.IO
Imports Oracle.DataAccess.Client

Public Class MainMaster
    Dim fno As Integer = 1
    Dim query As String
    Public Shared menuname As String
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me
        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber
        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub
    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub
    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer
    Private Sub CompanyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompanyToolStripMenuItem.Click
        Dim invact As New Invaction
        Dim query As String
        Dim dt As New DataTable
        query = "SELECT USERPRIVILLAGE FROM UREG WHERE USERNAME= '" & Login.uname & "'"
        dt = selquery(query)
        If dt.Rows(0)("USERPRIVILLAGE").ToString = "YES " Then
            invact.Rbcom.Visible = True
            invact.Rbcom.Checked = True
            invact.rbinv.Visible = False
            invact.rbinvdet.Visible = False
        Else
            invact.Rbcom.Visible = False
            invact.rbinv.Checked = True
        End If
        invact.Show()
    End Sub

    Private Sub MainMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconnection()
        lblUsername.Text = "Welcome " + Login.uname
        closeconn()
        Form1.MdiParent = Me
        Form1.Show()
    End Sub

    Private Sub DaywiseInvoiceDescriptionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DaywiseInvoiceDescriptionToolStripMenuItem1.Click
        repact.MdiParent = Me
        repact.Show()
    End Sub

    Private Sub MonthlyInvoiceDescriptionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MonthlyInvoiceDescriptionToolStripMenuItem1.Click
        repact.MdiParent = Me
        repact.Show()
    End Sub

    Private Sub InvoiceDescriptionToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles InvoiceDescriptionToolStripMenuItem7.Click
        Dim comname As String = "Invoice Description" & fno.ToString & ""
        Dim dt As New DataTable
        Dim path As String
        Dim gridvalue As String = ""
        Dim data As String = ""
        repview.MdiParent = Me
        path = "E:\DINESHKUMAR B\Ebill\bill report\Invdescription\Invdescription\" & comname & ".txt"
        query = "SELECT * FROM INV_DETAILS ORDER BY INVNO"
        dt = selquery(query)
        Dim fwrite As New System.IO.StreamWriter(path)
        fwrite.WriteLine(" ")
        fwrite.WriteLine(" " & Space(50) & "E-BILL SYSTEM " & Space(68) & "DATE : " & DateTime.Now.Date & "" & Space(20) & "")
        fwrite.WriteLine(" " & Space(50) & "-----------------------------------")
        fwrite.WriteLine(" ")
        fwrite.WriteLine(" " & Space(50) & "INVOICE DESCRIPTION  DETAILS")
        fwrite.WriteLine(" ")
        fno += 1
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
        repview.txtrep.Text = fread
        repview.Show()
    End Sub

    Private Sub DaywiseInvoiceAndInvoiceDescriptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaywiseInvoiceAndInvoiceDescriptionToolStripMenuItem.Click
        repact.MdiParent = Me
        menuname = "Daywise invoice and invdescription"
        repact.Show()
    End Sub

    Private Sub MonthlyInvoiceAndInvdesriptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonthlyInvoiceAndInvdesriptionToolStripMenuItem.Click
        repact.MdiParent = Me
        repact.lblfromdate.Text = "Start Month"
        repact.lbltodate.Text = "To Month"
        menuname = "Monthly invoice and invdescription"
        repact.Show()
    End Sub

    Private Sub DaywiseInvoiceToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DaywiseInvoiceToolStripMenuItem1.Click
        repact.MdiParent = Me
        repact.Show()
    End Sub

    Private Sub MonthlyInvoiceToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MonthlyInvoiceToolStripMenuItem1.Click
        repact.MdiParent = Me
        repact.lblfromdate.Text = "Start Month"
        repact.lbltodate.Text = "To Month"
        menuname = "Monthly invoice"
        repact.Show()
    End Sub

    Private Sub InvoiceDescriptionToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles InvoiceDescriptionToolStripMenuItem6.Click
        Company.MdiParent = Me
        Company.selpanel.Visible = False
        Company.delpanel.Visible = False
        Company.reppanel.Visible = True
        Company.Width = Company.reppanel.Width
        Company.Height = Company.reppanel.Height
        Company.reppanel.Location = New Point(Convert.ToInt32(Company.ClientSize.Width / 2 - Company.reppanel.Width / 2), Convert.ToInt32(Company.ClientSize.Height / 2 - Company.reppanel.Height / 2))
        Company.Show()
    End Sub

    Private Sub InvoiceDetailsToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles InvoiceDetailsToolStripMenuItem3.Click
        'repact.MdiParent = Me
        'repact.Show()
        Dim comname As String = "Invoice details" & fno.ToString & ""
        Dim dt As New DataTable
        Dim path As String
        Dim gridvalue As String = ""
        Dim data As String = ""
        repview.MdiParent = Me
        path = "E:\DINESHKUMAR B\Ebill\bill report\Invoice\Invoice details\" & comname & ".txt"
        query = "SELECT * FROM INVOICE ORDER BY COMID"
        dt = selquery(query)
        Dim fwrite As New System.IO.StreamWriter(path)
        fwrite.WriteLine(" ")
        fwrite.WriteLine(" " & Space(50) & "E-BILL SYSTEM " & Space(68) & "DATE : " & DateTime.Now.Date & "" & Space(20) & "")
        fwrite.WriteLine(" " & Space(50) & "-----------------------------------")
        fwrite.WriteLine(" ")
        fwrite.WriteLine(" " & Space(50) & "INVOICE DETAILS")
        fwrite.WriteLine(" ")
        fno += 1
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
        repview.txtrep.Text = fread
        repview.Show()
    End Sub

    Private Sub InvoiceDetailsToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles InvoiceDetailsToolStripMenuItem2.Click
        Company.MdiParent = Me
        Company.selpanel.Visible = False
        Company.delpanel.Visible = False
        Company.reppanel.Visible = True
        Company.lblrepinv.Visible = False
        Company.repcmbinv.Visible = False
        Company.Width = Company.reppanel.Width
        Company.Height = Company.reppanel.Height
        Company.reppanel.Location = New Point(Convert.ToInt32(Company.ClientSize.Width / 2 - Company.reppanel.Width / 2), Convert.ToInt32(Company.ClientSize.Height / 2 - Company.reppanel.Height / 2))
        Company.Show()
    End Sub

    Private Sub CompanyDetailsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CompanyDetailsToolStripMenuItem1.Click
        Dim comname As String = "Compnay details" & fno.ToString & ""
        Dim dt As New DataTable
        Dim path As String
        Dim gridvalue As String = ""
        repview.MdiParent = Me
        path = "E:\DINESHKUMAR B\Ebill\bill report\Company\Company Report\" & comname & ".txt"
        query = "SELECT * FROM COMPANY_DETAILS ORDER BY COMID"
        dt = selquery(query)
        Dim fwrite As New System.IO.StreamWriter(path)
        fwrite.WriteLine(" ")
        fwrite.WriteLine(" " & Space(50) & "E-BILL SYSTEM " & Space(68) & "DATE : " & DateTime.Now.Date & "")
        fwrite.WriteLine(" " & Space(50) & "-----------------------------------")
        fwrite.WriteLine(" ")
        fwrite.WriteLine(" " & Space(50) & "COMPANY DETAILS")
        fwrite.WriteLine(" ")
        fno += 1
        For Each cell As DataColumn In dt.Columns
            gridvalue += cell.ToString + vbTab & vbTab
        Next
        fwrite.WriteLine("" & Space(5) & " " & gridvalue & "" & vbTab & "")
        gridvalue = ""
        For Each row As DataRow In dt.Rows
            For Each cell As DataColumn In dt.Columns
                gridvalue += row(cell).ToString + vbTab & vbTab
                gridvalue += vbTab
            Next
            fwrite.WriteLine("" & Space(5) & " " & gridvalue & "" & vbTab & "")
            gridvalue = ""
        Next
        fwrite.WriteLine(" ")
        fwrite.WriteLine(" " & Space(65) & "-----------------------------------")
        fwrite.Close()
        Dim fread As String
        fread = My.Computer.FileSystem.ReadAllText(path)
        Dim pr As New repview
        repview.txtrep.Text = fread
        repview.Show()
    End Sub

    Private Sub InvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoiceToolStripMenuItem.Click
        Dim invact As New Invaction
        invact.Rbcom.Visible = False
        invact.rbinv.Checked = True
        invact.rbinv.Visible = True
        invact.rbinvdet.Visible = False
        invact.Show()
    End Sub

    Private Sub InvoiceDescriptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoiceDescriptionToolStripMenuItem.Click
        Dim invact As New Invaction
        invact.Rbcom.Visible = False
        invact.rbinvdet.Checked = True
        invact.rbinv.Visible = False
        invact.rbinvdet.Visible = True
        invact.Show()
    End Sub

    Private Sub CompanyToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CompanyToolStripMenuItem2.Click
        Dim query As String
        Dim dt As New DataTable
        Dim dis As New Display
        query = "SELECT * FROM COMPANY_DETAILS ORDER BY COMID"
        dt = selquery(query)
        dis.Rgvcompany.DataSource = dt
        dis.Rgvdisp.Visible = False
        dis.Rgvinvoice.Visible = False
        dis.rgvinvdes.Visible = False
        dis.Rgvcompany.Location = New Point(Convert.ToInt32(dis.ClientSize.Width / 2 - dis.Rgvcompany.Width / 2), Convert.ToInt32(dis.ClientSize.Height / 2 - dis.Rgvcompany.Height / 2))
        dis.Show()
    End Sub

    Private Sub InvoiceToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles InvoiceToolStripMenuItem2.Click
        Dim query As String
        Dim dt As New DataTable
        Dim dis As New Display
        query = "SELECT * FROM INVOICE ORDER BY COMID"
        dt = selquery(query)
        dis.Rgvinvoice.DataSource = dt
        dis.Rgvdisp.Visible = False
        dis.Rgvcompany.Visible = False
        dis.rgvinvdes.Visible = False
        dis.Rgvinvoice.Location = New Point(Convert.ToInt32(dis.ClientSize.Width / 2 - dis.Rgvinvoice.Width / 2), Convert.ToInt32(dis.ClientSize.Height / 2 - dis.Rgvinvoice.Height / 2))
        dis.Show()
    End Sub

    Private Sub InvoiceDescriptionToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles InvoiceDescriptionToolStripMenuItem2.Click
        Dim query As String
        Dim dt As New DataTable
        Dim dis As New Display
        query = "SELECT * FROM INV_DETAILS ORDER BY INVNO "
        dt = selquery(query)
        dis.rgvinvdes.DataSource = dt
        dis.Rgvdisp.Visible = False
        dis.Rgvcompany.Visible = False
        dis.Rgvinvoice.Visible = False
        'dis.rgvinvdes.Location = New Point(Convert.ToInt32(dis.ClientSize.Width / 2 - dis.rgvinvdes.Width / 2), Convert.ToInt32(dis.ClientSize.Height / 2 - dis.rgvinvdes.Height / 2))
        dis.Show()
    End Sub

    Private Sub CompanyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CompanyToolStripMenuItem1.Click
        Dim upd As New edit
        upd.invpanel.Visible = False
        upd.invdetpanel.Visible = False
        upd.Width = upd.ecompanel.Width
        upd.Height = upd.ecompanel.Height
        upd.ecompanel.Location = New Point(Convert.ToInt32(upd.ClientSize.Width / 2 - upd.ecompanel.Width / 2), Convert.ToInt32(upd.ClientSize.Height / 2 - upd.ecompanel.Height / 2))
        upd.Show()
    End Sub

    Private Sub InvoiceToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InvoiceToolStripMenuItem1.Click
        Dim upd As New edit
        upd.invpanel.Visible = True
        upd.ecompanel.Visible = False
        upd.invdetpanel.Visible = False
        upd.Width = upd.invpanel.Width
        upd.Height = upd.invpanel.Height
        upd.invpanel.Location = New Point(Convert.ToInt32(upd.ClientSize.Width / 2 - upd.invpanel.Width / 2), Convert.ToInt32(upd.ClientSize.Height / 2 - upd.invpanel.Height / 2))
        upd.Show()
    End Sub

    Private Sub InvoiceDescriptionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InvoiceDescriptionToolStripMenuItem1.Click
        Dim upd As New edit
        upd.invpanel.Visible = False
        upd.ecompanel.Visible = False
        upd.invdetpanel.Visible = True
        upd.Width = upd.invdetpanel.Width
        upd.Height = upd.invdetpanel.Height
        upd.invdetpanel.Location = New Point(Convert.ToInt32(upd.ClientSize.Width / 2 - upd.invdetpanel.Width / 2), Convert.ToInt32(upd.ClientSize.Height / 2 - upd.invdetpanel.Height / 2))
        upd.Show()
    End Sub

    'Private Sub ExciseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExciseToolStripMenuItem.Click

    'End Sub
    Private Sub ExciseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExciseToolStripMenuItem.Click
        Dim de As New Company
        de.selpanel.Visible = False
        de.delpanel.Visible = True
        de.reppanel.Visible = False
        de.Width = de.delpanel.Width
        de.Height = de.delpanel.Height
        de.delpanel.Location = New Point(Convert.ToInt32(de.ClientSize.Width / 2 - de.delpanel.Width / 2), Convert.ToInt32(de.ClientSize.Height / 2 - de.delpanel.Height / 2))
        de.Show()
    End Sub

    Private Sub lblUsername_Click(sender As Object, e As EventArgs) Handles lblUsername.Click
        Me.Close()
    End Sub

    Private Sub CompanyToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CompanyToolStripMenuItem3.Click

    End Sub
End Class
