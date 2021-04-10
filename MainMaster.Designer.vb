<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMaster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMaster))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceDescriptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompanyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceDescriptionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompanyToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceDescriptionToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompanyToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompanyDetailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceDetailsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceDetailsToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceDescriptionToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthlyInvoiceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaywiseInvoiceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthlyInvoiceAndInvdesriptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaywiseInvoiceAndInvoiceDescriptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceDescriptionToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceDescriptionToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthlyInvoiceDescriptionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaywiseInvoiceDescriptionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExciseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintPreviewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.EditMenu, Me.ViewMenu, Me.ReportsToolStripMenuItem1, Me.ExciseToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(37, 20)
        Me.FileMenu.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyToolStripMenuItem, Me.InvoiceToolStripMenuItem, Me.InvoiceDescriptionToolStripMenuItem})
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'CompanyToolStripMenuItem
        '
        Me.CompanyToolStripMenuItem.Name = "CompanyToolStripMenuItem"
        Me.CompanyToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CompanyToolStripMenuItem.Text = "Company"
        '
        'InvoiceToolStripMenuItem
        '
        Me.InvoiceToolStripMenuItem.Name = "InvoiceToolStripMenuItem"
        Me.InvoiceToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.InvoiceToolStripMenuItem.Text = "Invoice"
        '
        'InvoiceDescriptionToolStripMenuItem
        '
        Me.InvoiceDescriptionToolStripMenuItem.Name = "InvoiceDescriptionToolStripMenuItem"
        Me.InvoiceDescriptionToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.InvoiceDescriptionToolStripMenuItem.Text = "Invoice Description"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyToolStripMenuItem1, Me.InvoiceToolStripMenuItem1, Me.InvoiceDescriptionToolStripMenuItem1})
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(39, 20)
        Me.EditMenu.Text = "&Edit"
        '
        'CompanyToolStripMenuItem1
        '
        Me.CompanyToolStripMenuItem1.Name = "CompanyToolStripMenuItem1"
        Me.CompanyToolStripMenuItem1.Size = New System.Drawing.Size(175, 22)
        Me.CompanyToolStripMenuItem1.Text = "Company"
        '
        'InvoiceToolStripMenuItem1
        '
        Me.InvoiceToolStripMenuItem1.Name = "InvoiceToolStripMenuItem1"
        Me.InvoiceToolStripMenuItem1.Size = New System.Drawing.Size(175, 22)
        Me.InvoiceToolStripMenuItem1.Text = "Invoice"
        '
        'InvoiceDescriptionToolStripMenuItem1
        '
        Me.InvoiceDescriptionToolStripMenuItem1.Name = "InvoiceDescriptionToolStripMenuItem1"
        Me.InvoiceDescriptionToolStripMenuItem1.Size = New System.Drawing.Size(175, 22)
        Me.InvoiceDescriptionToolStripMenuItem1.Text = "Invoice Description"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyToolStripMenuItem2, Me.InvoiceToolStripMenuItem2, Me.InvoiceDescriptionToolStripMenuItem2})
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(44, 20)
        Me.ViewMenu.Text = "&View"
        '
        'CompanyToolStripMenuItem2
        '
        Me.CompanyToolStripMenuItem2.Name = "CompanyToolStripMenuItem2"
        Me.CompanyToolStripMenuItem2.Size = New System.Drawing.Size(175, 22)
        Me.CompanyToolStripMenuItem2.Text = "Company"
        '
        'InvoiceToolStripMenuItem2
        '
        Me.InvoiceToolStripMenuItem2.Name = "InvoiceToolStripMenuItem2"
        Me.InvoiceToolStripMenuItem2.Size = New System.Drawing.Size(175, 22)
        Me.InvoiceToolStripMenuItem2.Text = "Invoice"
        '
        'InvoiceDescriptionToolStripMenuItem2
        '
        Me.InvoiceDescriptionToolStripMenuItem2.Name = "InvoiceDescriptionToolStripMenuItem2"
        Me.InvoiceDescriptionToolStripMenuItem2.Size = New System.Drawing.Size(175, 22)
        Me.InvoiceDescriptionToolStripMenuItem2.Text = "Invoice Description"
        '
        'ReportsToolStripMenuItem1
        '
        Me.ReportsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyToolStripMenuItem3, Me.InvoiceToolStripMenuItem3, Me.InvoiceDescriptionToolStripMenuItem5})
        Me.ReportsToolStripMenuItem1.Name = "ReportsToolStripMenuItem1"
        Me.ReportsToolStripMenuItem1.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem1.Text = "Reports"
        '
        'CompanyToolStripMenuItem3
        '
        Me.CompanyToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompanyDetailsToolStripMenuItem1, Me.InvoiceDetailsToolStripMenuItem2})
        Me.CompanyToolStripMenuItem3.Name = "CompanyToolStripMenuItem3"
        Me.CompanyToolStripMenuItem3.Size = New System.Drawing.Size(175, 22)
        Me.CompanyToolStripMenuItem3.Text = "Company"
        '
        'CompanyDetailsToolStripMenuItem1
        '
        Me.CompanyDetailsToolStripMenuItem1.Name = "CompanyDetailsToolStripMenuItem1"
        Me.CompanyDetailsToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.CompanyDetailsToolStripMenuItem1.Text = "Company Details"
        '
        'InvoiceDetailsToolStripMenuItem2
        '
        Me.InvoiceDetailsToolStripMenuItem2.Name = "InvoiceDetailsToolStripMenuItem2"
        Me.InvoiceDetailsToolStripMenuItem2.Size = New System.Drawing.Size(164, 22)
        Me.InvoiceDetailsToolStripMenuItem2.Text = "Invoice Details"
        '
        'InvoiceToolStripMenuItem3
        '
        Me.InvoiceToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InvoiceDetailsToolStripMenuItem3, Me.InvoiceDescriptionToolStripMenuItem6, Me.MonthlyInvoiceToolStripMenuItem1, Me.DaywiseInvoiceToolStripMenuItem1, Me.MonthlyInvoiceAndInvdesriptionToolStripMenuItem, Me.DaywiseInvoiceAndInvoiceDescriptionToolStripMenuItem})
        Me.InvoiceToolStripMenuItem3.Name = "InvoiceToolStripMenuItem3"
        Me.InvoiceToolStripMenuItem3.Size = New System.Drawing.Size(175, 22)
        Me.InvoiceToolStripMenuItem3.Text = "Invoice"
        '
        'InvoiceDetailsToolStripMenuItem3
        '
        Me.InvoiceDetailsToolStripMenuItem3.Name = "InvoiceDetailsToolStripMenuItem3"
        Me.InvoiceDetailsToolStripMenuItem3.Size = New System.Drawing.Size(285, 22)
        Me.InvoiceDetailsToolStripMenuItem3.Text = "Invoice Details"
        '
        'InvoiceDescriptionToolStripMenuItem6
        '
        Me.InvoiceDescriptionToolStripMenuItem6.Name = "InvoiceDescriptionToolStripMenuItem6"
        Me.InvoiceDescriptionToolStripMenuItem6.Size = New System.Drawing.Size(285, 22)
        Me.InvoiceDescriptionToolStripMenuItem6.Text = "Invoice Description"
        '
        'MonthlyInvoiceToolStripMenuItem1
        '
        Me.MonthlyInvoiceToolStripMenuItem1.Name = "MonthlyInvoiceToolStripMenuItem1"
        Me.MonthlyInvoiceToolStripMenuItem1.Size = New System.Drawing.Size(285, 22)
        Me.MonthlyInvoiceToolStripMenuItem1.Text = "Monthly Invoice"
        '
        'DaywiseInvoiceToolStripMenuItem1
        '
        Me.DaywiseInvoiceToolStripMenuItem1.Name = "DaywiseInvoiceToolStripMenuItem1"
        Me.DaywiseInvoiceToolStripMenuItem1.Size = New System.Drawing.Size(285, 22)
        Me.DaywiseInvoiceToolStripMenuItem1.Text = "Daywise Invoice"
        '
        'MonthlyInvoiceAndInvdesriptionToolStripMenuItem
        '
        Me.MonthlyInvoiceAndInvdesriptionToolStripMenuItem.Name = "MonthlyInvoiceAndInvdesriptionToolStripMenuItem"
        Me.MonthlyInvoiceAndInvdesriptionToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.MonthlyInvoiceAndInvdesriptionToolStripMenuItem.Text = "Monthly invoice and Invdesription"
        '
        'DaywiseInvoiceAndInvoiceDescriptionToolStripMenuItem
        '
        Me.DaywiseInvoiceAndInvoiceDescriptionToolStripMenuItem.Name = "DaywiseInvoiceAndInvoiceDescriptionToolStripMenuItem"
        Me.DaywiseInvoiceAndInvoiceDescriptionToolStripMenuItem.Size = New System.Drawing.Size(285, 22)
        Me.DaywiseInvoiceAndInvoiceDescriptionToolStripMenuItem.Text = "Daywise Invoice and Invoice Description"
        '
        'InvoiceDescriptionToolStripMenuItem5
        '
        Me.InvoiceDescriptionToolStripMenuItem5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InvoiceDescriptionToolStripMenuItem7, Me.MonthlyInvoiceDescriptionToolStripMenuItem1, Me.DaywiseInvoiceDescriptionToolStripMenuItem1})
        Me.InvoiceDescriptionToolStripMenuItem5.Name = "InvoiceDescriptionToolStripMenuItem5"
        Me.InvoiceDescriptionToolStripMenuItem5.Size = New System.Drawing.Size(175, 22)
        Me.InvoiceDescriptionToolStripMenuItem5.Text = "Invoice Description"
        '
        'InvoiceDescriptionToolStripMenuItem7
        '
        Me.InvoiceDescriptionToolStripMenuItem7.Name = "InvoiceDescriptionToolStripMenuItem7"
        Me.InvoiceDescriptionToolStripMenuItem7.Size = New System.Drawing.Size(223, 22)
        Me.InvoiceDescriptionToolStripMenuItem7.Text = "Invoice Description"
        '
        'MonthlyInvoiceDescriptionToolStripMenuItem1
        '
        Me.MonthlyInvoiceDescriptionToolStripMenuItem1.Name = "MonthlyInvoiceDescriptionToolStripMenuItem1"
        Me.MonthlyInvoiceDescriptionToolStripMenuItem1.Size = New System.Drawing.Size(223, 22)
        Me.MonthlyInvoiceDescriptionToolStripMenuItem1.Text = "Monthly Invoice Description"
        '
        'DaywiseInvoiceDescriptionToolStripMenuItem1
        '
        Me.DaywiseInvoiceDescriptionToolStripMenuItem1.Name = "DaywiseInvoiceDescriptionToolStripMenuItem1"
        Me.DaywiseInvoiceDescriptionToolStripMenuItem1.Size = New System.Drawing.Size(223, 22)
        Me.DaywiseInvoiceDescriptionToolStripMenuItem1.Text = "Daywise Invoice Description"
        '
        'ExciseToolStripMenuItem
        '
        Me.ExciseToolStripMenuItem.Name = "ExciseToolStripMenuItem"
        Me.ExciseToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.ExciseToolStripMenuItem.Text = "Excise"
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.ToolStripSeparator1, Me.PrintToolStripButton, Me.PrintPreviewToolStripButton, Me.ToolStripSeparator2, Me.HelpToolStripButton})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(784, 25)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "Save"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolStripButton.Text = "Print"
        '
        'PrintPreviewToolStripButton
        '
        Me.PrintPreviewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintPreviewToolStripButton.Image = CType(resources.GetObject("PrintPreviewToolStripButton.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintPreviewToolStripButton.Name = "PrintPreviewToolStripButton"
        Me.PrintPreviewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintPreviewToolStripButton.Text = "Print Preview"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "Help"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(684, 9)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(30, 15)
        Me.lblUsername.TabIndex = 9
        Me.lblUsername.Text = "User"
        '
        'MainMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MainMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMaster"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintPreviewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents PrintToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileMenu As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompanyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvoiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditMenu As ToolStripMenuItem
    Friend WithEvents ViewMenu As ToolStripMenuItem
    Friend WithEvents InvoiceDescriptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompanyToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InvoiceToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InvoiceDescriptionToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CompanyToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents InvoiceToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents InvoiceDescriptionToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CompanyToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents CompanyDetailsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InvoiceDetailsToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents InvoiceToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents InvoiceDescriptionToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents InvoiceDetailsToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents InvoiceDescriptionToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents MonthlyInvoiceToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DaywiseInvoiceToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MonthlyInvoiceAndInvdesriptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaywiseInvoiceAndInvoiceDescriptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvoiceDescriptionToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents MonthlyInvoiceDescriptionToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DaywiseInvoiceDescriptionToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents lblUsername As Label
    Friend WithEvents ExciseToolStripMenuItem As ToolStripMenuItem
End Class
