<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customer_details
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
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.lblCusdetails = New System.Windows.Forms.Label()
        Me.btnins = New System.Windows.Forms.Button()
        Me.btnupdte = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.BTNDIS = New System.Windows.Forms.Button()
        Me.RGVCusdet = New Telerik.WinControls.UI.RadGridView()
        CType(Me.RGVCusdet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVCusdet.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCusdetails
        '
        Me.lblCusdetails.AutoSize = True
        Me.lblCusdetails.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCusdetails.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblCusdetails.Location = New System.Drawing.Point(25, 25)
        Me.lblCusdetails.Name = "lblCusdetails"
        Me.lblCusdetails.Size = New System.Drawing.Size(160, 19)
        Me.lblCusdetails.TabIndex = 1
        Me.lblCusdetails.Text = "Customer details are..."
        '
        'btnins
        '
        Me.btnins.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnins.Location = New System.Drawing.Point(97, 302)
        Me.btnins.Name = "btnins"
        Me.btnins.Size = New System.Drawing.Size(75, 23)
        Me.btnins.TabIndex = 2
        Me.btnins.Text = "INSERT"
        Me.btnins.UseVisualStyleBackColor = True
        '
        'btnupdte
        '
        Me.btnupdte.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdte.Location = New System.Drawing.Point(197, 301)
        Me.btnupdte.Name = "btnupdte"
        Me.btnupdte.Size = New System.Drawing.Size(81, 23)
        Me.btnupdte.TabIndex = 3
        Me.btnupdte.Text = "UPDATE"
        Me.btnupdte.UseVisualStyleBackColor = True
        '
        'btndel
        '
        Me.btndel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.Location = New System.Drawing.Point(301, 300)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(81, 23)
        Me.btndel.TabIndex = 4
        Me.btndel.Text = "DELETE"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'BTNDIS
        '
        Me.BTNDIS.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNDIS.Location = New System.Drawing.Point(407, 299)
        Me.BTNDIS.Name = "BTNDIS"
        Me.BTNDIS.Size = New System.Drawing.Size(86, 23)
        Me.BTNDIS.TabIndex = 5
        Me.BTNDIS.Text = "DISPLAY"
        Me.BTNDIS.UseVisualStyleBackColor = True
        '
        'RGVCusdet
        '
        Me.RGVCusdet.BackColor = System.Drawing.SystemColors.Control
        Me.RGVCusdet.Cursor = System.Windows.Forms.Cursors.Default
        Me.RGVCusdet.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RGVCusdet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RGVCusdet.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RGVCusdet.Location = New System.Drawing.Point(134, 47)
        '
        '
        '
        Me.RGVCusdet.MasterTemplate.AllowColumnReorder = False
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "CID"
        GridViewTextBoxColumn1.HeaderText = "CID"
        GridViewTextBoxColumn1.Name = "CID"
        GridViewTextBoxColumn1.Width = 59
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "NAME"
        GridViewTextBoxColumn2.HeaderText = "NAME"
        GridViewTextBoxColumn2.Name = "NAME"
        GridViewTextBoxColumn2.Width = 69
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "DOB"
        GridViewTextBoxColumn3.HeaderText = "DOB"
        GridViewTextBoxColumn3.Name = "DOB"
        GridViewTextBoxColumn3.Width = 79
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "MOBNO"
        GridViewTextBoxColumn4.HeaderText = "MOBILE NUMBER"
        GridViewTextBoxColumn4.Name = "MOBNO"
        GridViewTextBoxColumn4.Width = 126
        Me.RGVCusdet.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4})
        Me.RGVCusdet.MasterTemplate.EnableFiltering = True
        SortDescriptor1.PropertyName = "column1"
        Me.RGVCusdet.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
        Me.RGVCusdet.MasterTemplate.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow
        Me.RGVCusdet.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RGVCusdet.Name = "RGVCusdet"
        Me.RGVCusdet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RGVCusdet.Size = New System.Drawing.Size(351, 246)
        Me.RGVCusdet.TabIndex = 6
        '
        'Customer_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(595, 401)
        Me.Controls.Add(Me.RGVCusdet)
        Me.Controls.Add(Me.BTNDIS)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.btnupdte)
        Me.Controls.Add(Me.btnins)
        Me.Controls.Add(Me.lblCusdetails)
        Me.Name = "Customer_details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer_details"
        CType(Me.RGVCusdet.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGVCusdet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCusdetails As Label
    Friend WithEvents btnins As Button
    Friend WithEvents btnupdte As Button
    Friend WithEvents btndel As Button
    Friend WithEvents BTNDIS As Button
    Friend WithEvents RGVCusdet As Telerik.WinControls.UI.RadGridView
End Class
