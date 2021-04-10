<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.lblcusdet = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lbldob = New System.Windows.Forms.Label()
        Me.lblmobno = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtdob = New System.Windows.Forms.TextBox()
        Me.txtmobno = New System.Windows.Forms.TextBox()
        Me.btnsub = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.lblclustid = New System.Windows.Forms.Label()
        Me.txtcusid = New System.Windows.Forms.TextBox()
        Me.RGVcusdet = New Telerik.WinControls.UI.RadGridView()
        Me.btnupd = New System.Windows.Forms.Button()
        Me.btndele = New System.Windows.Forms.Button()
        Me.btndisp = New System.Windows.Forms.Button()
        CType(Me.RGVcusdet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVcusdet.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblcusdet
        '
        Me.lblcusdet.AutoSize = True
        Me.lblcusdet.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusdet.Location = New System.Drawing.Point(101, 19)
        Me.lblcusdet.Name = "lblcusdet"
        Me.lblcusdet.Size = New System.Drawing.Size(167, 22)
        Me.lblcusdet.TabIndex = 0
        Me.lblcusdet.Text = "Customer details"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(60, 105)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(44, 17)
        Me.lblname.TabIndex = 1
        Me.lblname.Text = "Name"
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldob.Location = New System.Drawing.Point(59, 146)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(40, 17)
        Me.lbldob.TabIndex = 2
        Me.lbldob.Text = "DOB"
        '
        'lblmobno
        '
        Me.lblmobno.AutoSize = True
        Me.lblmobno.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmobno.Location = New System.Drawing.Point(57, 186)
        Me.lblmobno.Name = "lblmobno"
        Me.lblmobno.Size = New System.Drawing.Size(66, 17)
        Me.lblmobno.TabIndex = 3
        Me.lblmobno.Text = "Mobile no"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(171, 103)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 22)
        Me.txtname.TabIndex = 4
        '
        'txtdob
        '
        Me.txtdob.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdob.Location = New System.Drawing.Point(171, 142)
        Me.txtdob.Name = "txtdob"
        Me.txtdob.Size = New System.Drawing.Size(100, 22)
        Me.txtdob.TabIndex = 5
        '
        'txtmobno
        '
        Me.txtmobno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmobno.Location = New System.Drawing.Point(172, 180)
        Me.txtmobno.Name = "txtmobno"
        Me.txtmobno.Size = New System.Drawing.Size(100, 22)
        Me.txtmobno.TabIndex = 6
        '
        'btnsub
        '
        Me.btnsub.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsub.Location = New System.Drawing.Point(119, 229)
        Me.btnsub.Name = "btnsub"
        Me.btnsub.Size = New System.Drawing.Size(75, 23)
        Me.btnsub.TabIndex = 7
        Me.btnsub.Text = "SUBMIT"
        Me.btnsub.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(219, 229)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 8
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'lblclustid
        '
        Me.lblclustid.AutoSize = True
        Me.lblclustid.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclustid.Location = New System.Drawing.Point(59, 64)
        Me.lblclustid.Name = "lblclustid"
        Me.lblclustid.Size = New System.Drawing.Size(79, 17)
        Me.lblclustid.TabIndex = 9
        Me.lblclustid.Text = "Customer id"
        '
        'txtcusid
        '
        Me.txtcusid.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcusid.Location = New System.Drawing.Point(171, 61)
        Me.txtcusid.Name = "txtcusid"
        Me.txtcusid.Size = New System.Drawing.Size(100, 22)
        Me.txtcusid.TabIndex = 10
        '
        'RGVcusdet
        '
        Me.RGVcusdet.AutoSize = True
        Me.RGVcusdet.BackColor = System.Drawing.SystemColors.Control
        Me.RGVcusdet.Cursor = System.Windows.Forms.Cursors.Default
        Me.RGVcusdet.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RGVcusdet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RGVcusdet.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RGVcusdet.Location = New System.Drawing.Point(355, 37)
        '
        '
        '
        Me.RGVcusdet.MasterTemplate.AllowColumnReorder = False
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "CID"
        GridViewTextBoxColumn1.HeaderText = "CID"
        GridViewTextBoxColumn1.Name = "CID"
        GridViewTextBoxColumn1.Width = 75
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "NAME"
        GridViewTextBoxColumn2.HeaderText = "NAME"
        GridViewTextBoxColumn2.Name = "NAME"
        GridViewTextBoxColumn2.Width = 75
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "DOB"
        GridViewTextBoxColumn3.HeaderText = "DOB"
        GridViewTextBoxColumn3.Name = "DOB"
        GridViewTextBoxColumn3.Width = 75
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "MOBNO"
        GridViewTextBoxColumn4.HeaderText = "MOBILE NUMBER"
        GridViewTextBoxColumn4.Name = "MOBNO"
        GridViewTextBoxColumn4.Width = 96
        Me.RGVcusdet.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4})
        SortDescriptor1.PropertyName = "column1"
        Me.RGVcusdet.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
        Me.RGVcusdet.MasterTemplate.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow
        Me.RGVcusdet.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RGVcusdet.Name = "RGVcusdet"
        Me.RGVcusdet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RGVcusdet.Size = New System.Drawing.Size(339, 78)
        Me.RGVcusdet.TabIndex = 11
        Me.RGVcusdet.UseScrollbarsInHierarchy = True
        '
        'btnupd
        '
        Me.btnupd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupd.Location = New System.Drawing.Point(74, 268)
        Me.btnupd.Name = "btnupd"
        Me.btnupd.Size = New System.Drawing.Size(75, 23)
        Me.btnupd.TabIndex = 12
        Me.btnupd.Text = "UPDATE"
        Me.btnupd.UseVisualStyleBackColor = True
        '
        'btndele
        '
        Me.btndele.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndele.Location = New System.Drawing.Point(172, 268)
        Me.btndele.Name = "btndele"
        Me.btndele.Size = New System.Drawing.Size(75, 23)
        Me.btndele.TabIndex = 13
        Me.btndele.Text = "DELETE"
        Me.btndele.UseVisualStyleBackColor = True
        '
        'btndisp
        '
        Me.btndisp.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndisp.Location = New System.Drawing.Point(270, 268)
        Me.btndisp.Name = "btndisp"
        Me.btndisp.Size = New System.Drawing.Size(75, 23)
        Me.btndisp.TabIndex = 14
        Me.btndisp.Text = "DISPLAY"
        Me.btndisp.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(712, 345)
        Me.Controls.Add(Me.btndisp)
        Me.Controls.Add(Me.btndele)
        Me.Controls.Add(Me.btnupd)
        Me.Controls.Add(Me.RGVcusdet)
        Me.Controls.Add(Me.txtcusid)
        Me.Controls.Add(Me.lblclustid)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnsub)
        Me.Controls.Add(Me.txtmobno)
        Me.Controls.Add(Me.txtdob)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.lblmobno)
        Me.Controls.Add(Me.lbldob)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lblcusdet)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.RGVcusdet.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGVcusdet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblcusdet As Label
    Friend WithEvents lblname As Label
    Friend WithEvents lbldob As Label
    Friend WithEvents lblmobno As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtdob As TextBox
    Friend WithEvents txtmobno As TextBox
    Friend WithEvents btnsub As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents lblclustid As Label
    Friend WithEvents txtcusid As TextBox
    Friend WithEvents RGVcusdet As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnupd As Button
    Friend WithEvents btndele As Button
    Friend WithEvents btndisp As Button
End Class
