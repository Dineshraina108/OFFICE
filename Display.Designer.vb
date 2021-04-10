<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Display
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TableViewDefinition5 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim GridViewBrowseColumn16 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn17 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn18 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn19 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn20 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn21 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim TableViewDefinition6 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim GridViewBrowseColumn22 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn23 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn24 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn25 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn26 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn27 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim TableViewDefinition7 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim GridViewBrowseColumn28 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn29 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn30 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim SortDescriptor2 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim TableViewDefinition8 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.Rgvdisp = New Telerik.WinControls.UI.RadGridView()
        Me.Rgvinvoice = New Telerik.WinControls.UI.RadGridView()
        Me.rgvinvdes = New Telerik.WinControls.UI.RadGridView()
        Me.Rgvcompany = New Telerik.WinControls.UI.RadGridView()
        CType(Me.Rgvdisp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rgvdisp.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rgvinvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rgvinvoice.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvinvdes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgvinvdes.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rgvcompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rgvcompany.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Rgvdisp
        '
        Me.Rgvdisp.Location = New System.Drawing.Point(26, 12)
        '
        '
        '
        Me.Rgvdisp.MasterTemplate.ViewDefinition = TableViewDefinition5
        Me.Rgvdisp.Name = "Rgvdisp"
        Me.Rgvdisp.Size = New System.Drawing.Size(2, 3)
        Me.Rgvdisp.TabIndex = 0
        '
        'Rgvinvoice
        '
        Me.Rgvinvoice.AutoSize = True
        Me.Rgvinvoice.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Rgvinvoice.Cursor = System.Windows.Forms.Cursors.Default
        Me.Rgvinvoice.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Rgvinvoice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Rgvinvoice.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Rgvinvoice.Location = New System.Drawing.Point(39, 7)
        '
        '
        '
        Me.Rgvinvoice.MasterTemplate.AllowAddNewRow = False
        GridViewBrowseColumn16.EnableExpressionEditor = False
        GridViewBrowseColumn16.FieldName = "COMID"
        GridViewBrowseColumn16.HeaderText = "COMID"
        GridViewBrowseColumn16.Name = "COMID"
        GridViewBrowseColumn17.EnableExpressionEditor = False
        GridViewBrowseColumn17.FieldName = "INVNO"
        GridViewBrowseColumn17.HeaderText = "INVNO"
        GridViewBrowseColumn17.Name = "INVNO"
        GridViewBrowseColumn17.Width = 62
        GridViewBrowseColumn18.EnableExpressionEditor = False
        GridViewBrowseColumn18.FieldName = "INVDATE"
        GridViewBrowseColumn18.HeaderText = " INVDATE"
        GridViewBrowseColumn18.Name = "INVDATE"
        GridViewBrowseColumn18.Width = 78
        GridViewBrowseColumn19.EnableExpressionEditor = False
        GridViewBrowseColumn19.FieldName = "SERIAL"
        GridViewBrowseColumn19.HeaderText = "SERIAL"
        GridViewBrowseColumn19.Name = "SERIAL"
        GridViewBrowseColumn19.Width = 58
        GridViewBrowseColumn20.EnableExpressionEditor = False
        GridViewBrowseColumn20.FieldName = "LOCATION"
        GridViewBrowseColumn20.HeaderText = "LOCATION"
        GridViewBrowseColumn20.Name = "LOCATION"
        GridViewBrowseColumn20.Width = 81
        GridViewBrowseColumn21.EnableExpressionEditor = False
        GridViewBrowseColumn21.FieldName = "CHALANNO"
        GridViewBrowseColumn21.HeaderText = "CHALAN NO"
        GridViewBrowseColumn21.Name = "CHALANNO"
        GridViewBrowseColumn21.Width = 81
        Me.Rgvinvoice.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewBrowseColumn16, GridViewBrowseColumn17, GridViewBrowseColumn18, GridViewBrowseColumn19, GridViewBrowseColumn20, GridViewBrowseColumn21})
        Me.Rgvinvoice.MasterTemplate.ViewDefinition = TableViewDefinition6
        Me.Rgvinvoice.Name = "Rgvinvoice"
        Me.Rgvinvoice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Rgvinvoice.Size = New System.Drawing.Size(426, 54)
        Me.Rgvinvoice.TabIndex = 1
        '
        'rgvinvdes
        '
        Me.rgvinvdes.AutoScroll = True
        Me.rgvinvdes.AutoSize = True
        Me.rgvinvdes.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.rgvinvdes.Cursor = System.Windows.Forms.Cursors.Default
        Me.rgvinvdes.EnableFastScrolling = True
        Me.rgvinvdes.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.rgvinvdes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rgvinvdes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rgvinvdes.Location = New System.Drawing.Point(26, 20)
        '
        '
        '
        Me.rgvinvdes.MasterTemplate.AllowColumnReorder = False
        GridViewBrowseColumn22.EnableExpressionEditor = False
        GridViewBrowseColumn22.FieldName = "INVNO"
        GridViewBrowseColumn22.HeaderText = "INVNO"
        GridViewBrowseColumn22.Name = "INVNO"
        GridViewBrowseColumn22.Width = 56
        GridViewBrowseColumn23.EnableExpressionEditor = False
        GridViewBrowseColumn23.FieldName = "DETID"
        GridViewBrowseColumn23.HeaderText = "DETID"
        GridViewBrowseColumn23.Name = "DETID"
        GridViewBrowseColumn24.EnableExpressionEditor = False
        GridViewBrowseColumn24.FieldName = "PARTICULARS"
        GridViewBrowseColumn24.HeaderText = "PARTICULARS"
        GridViewBrowseColumn24.Name = "PARTICULARS"
        GridViewBrowseColumn24.Width = 140
        GridViewBrowseColumn25.EnableExpressionEditor = False
        GridViewBrowseColumn25.FieldName = "QUANTITY"
        GridViewBrowseColumn25.HeaderText = "QUANTITY"
        GridViewBrowseColumn25.Name = "QUANTITY"
        GridViewBrowseColumn25.Width = 80
        GridViewBrowseColumn26.EnableExpressionEditor = False
        GridViewBrowseColumn26.FieldName = "RATE"
        GridViewBrowseColumn26.HeaderText = "RATE"
        GridViewBrowseColumn26.Name = "RATE"
        GridViewBrowseColumn27.EnableExpressionEditor = False
        GridViewBrowseColumn27.FieldName = "AMOUNT"
        GridViewBrowseColumn27.HeaderText = "AMOUNT"
        GridViewBrowseColumn27.Name = "AMOUNT"
        GridViewBrowseColumn27.Width = 75
        Me.rgvinvdes.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewBrowseColumn22, GridViewBrowseColumn23, GridViewBrowseColumn24, GridViewBrowseColumn25, GridViewBrowseColumn26, GridViewBrowseColumn27})
        Me.rgvinvdes.MasterTemplate.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow
        Me.rgvinvdes.MasterTemplate.ViewDefinition = TableViewDefinition7
        Me.rgvinvdes.Name = "rgvinvdes"
        Me.rgvinvdes.ReadOnly = True
        Me.rgvinvdes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rgvinvdes.Size = New System.Drawing.Size(467, 54)
        Me.rgvinvdes.TabIndex = 2
        '
        'Rgvcompany
        '
        Me.Rgvcompany.AutoSize = True
        Me.Rgvcompany.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Rgvcompany.Cursor = System.Windows.Forms.Cursors.Default
        Me.Rgvcompany.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Rgvcompany.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Rgvcompany.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Rgvcompany.Location = New System.Drawing.Point(90, 13)
        '
        '
        '
        Me.Rgvcompany.MasterTemplate.AllowColumnReorder = False
        GridViewBrowseColumn28.EnableExpressionEditor = False
        GridViewBrowseColumn28.FieldName = "COMID"
        GridViewBrowseColumn28.HeaderText = "COMID"
        GridViewBrowseColumn28.Name = "COMID"
        GridViewBrowseColumn29.EnableExpressionEditor = False
        GridViewBrowseColumn29.FieldName = "COMNAME"
        GridViewBrowseColumn29.HeaderText = "COMPANY NAME"
        GridViewBrowseColumn29.Name = "COMNAME"
        GridViewBrowseColumn29.Width = 140
        GridViewBrowseColumn30.EnableExpressionEditor = False
        GridViewBrowseColumn30.FieldName = "ADDRESS"
        GridViewBrowseColumn30.HeaderText = "COMPANY ADDRESS"
        GridViewBrowseColumn30.Name = "ADDRESS"
        GridViewBrowseColumn30.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
        GridViewBrowseColumn30.Width = 166
        Me.Rgvcompany.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewBrowseColumn28, GridViewBrowseColumn29, GridViewBrowseColumn30})
        SortDescriptor2.PropertyName = "ADDRESS"
        Me.Rgvcompany.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor2})
        Me.Rgvcompany.MasterTemplate.ViewDefinition = TableViewDefinition8
        Me.Rgvcompany.Name = "Rgvcompany"
        Me.Rgvcompany.ReadOnly = True
        Me.Rgvcompany.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Rgvcompany.Size = New System.Drawing.Size(375, 54)
        Me.Rgvcompany.TabIndex = 3
        '
        'Display
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(530, 424)
        Me.Controls.Add(Me.Rgvcompany)
        Me.Controls.Add(Me.rgvinvdes)
        Me.Controls.Add(Me.Rgvinvoice)
        Me.Controls.Add(Me.Rgvdisp)
        Me.Name = "Display"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Display"
        CType(Me.Rgvdisp.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rgvdisp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rgvinvoice.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rgvinvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvinvdes.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgvinvdes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rgvcompany.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rgvcompany, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Rgvdisp As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Rgvinvoice As Telerik.WinControls.UI.RadGridView
    Friend WithEvents rgvinvdes As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Rgvcompany As Telerik.WinControls.UI.RadGridView
End Class
