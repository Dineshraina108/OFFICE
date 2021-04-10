<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chkboxgrid
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
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewCheckBoxColumn1 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
        Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim SortDescriptor2 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RGVcus = New Telerik.WinControls.UI.RadGridView()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.RGVcusup = New Telerik.WinControls.UI.RadGridView()
        CType(Me.RGVcus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVcus.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVcusup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVcusup.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RGVcus
        '
        Me.RGVcus.BackColor = System.Drawing.SystemColors.Control
        Me.RGVcus.Cursor = System.Windows.Forms.Cursors.Default
        Me.RGVcus.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RGVcus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RGVcus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RGVcus.Location = New System.Drawing.Point(74, 34)
        '
        '
        '
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "CID"
        GridViewTextBoxColumn1.HeaderText = "CID"
        GridViewTextBoxColumn1.Name = "CID"
        GridViewTextBoxColumn1.Width = 57
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "NAME"
        GridViewTextBoxColumn2.HeaderText = "NAME"
        GridViewTextBoxColumn2.Name = "NAME"
        GridViewTextBoxColumn2.Width = 99
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "DOB"
        GridViewTextBoxColumn3.HeaderText = "DOB"
        GridViewTextBoxColumn3.Name = "DOB"
        GridViewTextBoxColumn3.Width = 72
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "MOBNO"
        GridViewTextBoxColumn4.HeaderText = "MOBNO"
        GridViewTextBoxColumn4.Name = "MOBNO"
        GridViewTextBoxColumn4.Width = 133
        GridViewCheckBoxColumn1.EnableExpressionEditor = False
        GridViewCheckBoxColumn1.FieldName = "chkval"
        GridViewCheckBoxColumn1.HeaderText = "chkval"
        GridViewCheckBoxColumn1.MinWidth = 20
        GridViewCheckBoxColumn1.Name = "chkval"
        GridViewCheckBoxColumn1.Width = 60
        Me.RGVcus.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewCheckBoxColumn1})
        SortDescriptor1.PropertyName = "ADDRESS"
        Me.RGVcus.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
        Me.RGVcus.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RGVcus.Name = "RGVcus"
        Me.RGVcus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RGVcus.Size = New System.Drawing.Size(434, 193)
        Me.RGVcus.TabIndex = 0
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(222, 289)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 1
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'RGVcusup
        '
        Me.RGVcusup.BackColor = System.Drawing.SystemColors.Control
        Me.RGVcusup.Cursor = System.Windows.Forms.Cursors.Default
        Me.RGVcusup.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RGVcusup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RGVcusup.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RGVcusup.Location = New System.Drawing.Point(80, 339)
        '
        '
        '
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.FieldName = "CID"
        GridViewTextBoxColumn5.HeaderText = "CID"
        GridViewTextBoxColumn5.Name = "CID"
        GridViewTextBoxColumn5.Width = 57
        GridViewTextBoxColumn6.EnableExpressionEditor = False
        GridViewTextBoxColumn6.FieldName = "NAME"
        GridViewTextBoxColumn6.HeaderText = "NAME"
        GridViewTextBoxColumn6.Name = "NAME"
        GridViewTextBoxColumn6.Width = 99
        GridViewTextBoxColumn7.EnableExpressionEditor = False
        GridViewTextBoxColumn7.FieldName = "DOB"
        GridViewTextBoxColumn7.HeaderText = "DOB"
        GridViewTextBoxColumn7.Name = "DOB"
        GridViewTextBoxColumn7.Width = 72
        GridViewTextBoxColumn8.EnableExpressionEditor = False
        GridViewTextBoxColumn8.FieldName = "MOBNO"
        GridViewTextBoxColumn8.HeaderText = "MOBNO"
        GridViewTextBoxColumn8.Name = "MOBNO"
        GridViewTextBoxColumn8.Width = 133
        Me.RGVcusup.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewTextBoxColumn7, GridViewTextBoxColumn8})
        SortDescriptor2.PropertyName = "ADDRESS"
        Me.RGVcusup.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor2})
        Me.RGVcusup.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.RGVcusup.Name = "RGVcusup"
        Me.RGVcusup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RGVcusup.Size = New System.Drawing.Size(398, 193)
        Me.RGVcusup.TabIndex = 2
        '
        'Chkboxgrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 553)
        Me.Controls.Add(Me.RGVcusup)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.RGVcus)
        Me.Name = "Chkboxgrid"
        Me.Text = "Chkboxgrid"
        CType(Me.RGVcus.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGVcus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGVcusup.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGVcusup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RGVcus As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnupdate As Button
    Friend WithEvents RGVcusup As Telerik.WinControls.UI.RadGridView
End Class
