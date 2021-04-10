<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Invoice
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
        Dim GridViewBrowseColumn1 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn2 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn3 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn4 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim GridViewBrowseColumn5 As Telerik.WinControls.UI.GridViewBrowseColumn = New Telerik.WinControls.UI.GridViewBrowseColumn()
        Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.invpanel1 = New System.Windows.Forms.Panel()
        Me.btngetbill = New System.Windows.Forms.Button()
        Me.txtchalanno = New System.Windows.Forms.TextBox()
        Me.lblchalan = New System.Windows.Forms.Label()
        Me.txtlocation = New System.Windows.Forms.TextBox()
        Me.lbllocation = New System.Windows.Forms.Label()
        Me.txtserial = New System.Windows.Forms.TextBox()
        Me.lblserial = New System.Windows.Forms.Label()
        Me.txtinvno = New System.Windows.Forms.TextBox()
        Me.lblinvno = New System.Windows.Forms.Label()
        Me.dtpinvdate = New System.Windows.Forms.DateTimePicker()
        Me.lblinvdate = New System.Windows.Forms.Label()
        Me.txtaddr = New System.Windows.Forms.TextBox()
        Me.txtcomname = New System.Windows.Forms.TextBox()
        Me.lbladdr = New System.Windows.Forms.Label()
        Me.lblcompsny = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.invpanel2 = New System.Windows.Forms.Panel()
        Me.lblamt = New System.Windows.Forms.Label()
        Me.lbltotalamout = New System.Windows.Forms.Label()
        Me.lblamoutinwords = New System.Windows.Forms.Label()
        Me.RGVinvdeatils = New Telerik.WinControls.UI.RadGridView()
        Me.Chksave = New System.Windows.Forms.CheckBox()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.lblusernane = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.invpanel1.SuspendLayout()
        Me.invpanel2.SuspendLayout()
        CType(Me.RGVinvdeatils, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGVinvdeatils.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'invpanel1
        '
        Me.invpanel1.AutoSize = True
        Me.invpanel1.Controls.Add(Me.btngetbill)
        Me.invpanel1.Controls.Add(Me.txtchalanno)
        Me.invpanel1.Controls.Add(Me.lblchalan)
        Me.invpanel1.Controls.Add(Me.txtlocation)
        Me.invpanel1.Controls.Add(Me.lbllocation)
        Me.invpanel1.Controls.Add(Me.txtserial)
        Me.invpanel1.Controls.Add(Me.lblserial)
        Me.invpanel1.Controls.Add(Me.txtinvno)
        Me.invpanel1.Controls.Add(Me.lblinvno)
        Me.invpanel1.Controls.Add(Me.dtpinvdate)
        Me.invpanel1.Controls.Add(Me.lblinvdate)
        Me.invpanel1.Controls.Add(Me.txtaddr)
        Me.invpanel1.Controls.Add(Me.txtcomname)
        Me.invpanel1.Controls.Add(Me.lbladdr)
        Me.invpanel1.Controls.Add(Me.lblcompsny)
        Me.invpanel1.Location = New System.Drawing.Point(9, 83)
        Me.invpanel1.Name = "invpanel1"
        Me.invpanel1.Size = New System.Drawing.Size(634, 241)
        Me.invpanel1.TabIndex = 0
        '
        'btngetbill
        '
        Me.btngetbill.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngetbill.Location = New System.Drawing.Point(523, 201)
        Me.btngetbill.Name = "btngetbill"
        Me.btngetbill.Size = New System.Drawing.Size(75, 25)
        Me.btngetbill.TabIndex = 14
        Me.btngetbill.Text = "Get Bill"
        Me.btngetbill.UseVisualStyleBackColor = True
        '
        'txtchalanno
        '
        Me.txtchalanno.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchalanno.Location = New System.Drawing.Point(444, 164)
        Me.txtchalanno.Name = "txtchalanno"
        Me.txtchalanno.Size = New System.Drawing.Size(120, 25)
        Me.txtchalanno.TabIndex = 13
        '
        'lblchalan
        '
        Me.lblchalan.AutoSize = True
        Me.lblchalan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchalan.Location = New System.Drawing.Point(313, 166)
        Me.lblchalan.Name = "lblchalan"
        Me.lblchalan.Size = New System.Drawing.Size(84, 19)
        Me.lblchalan.TabIndex = 12
        Me.lblchalan.Text = "Chalan  No"
        '
        'txtlocation
        '
        Me.txtlocation.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlocation.Location = New System.Drawing.Point(445, 123)
        Me.txtlocation.Name = "txtlocation"
        Me.txtlocation.Size = New System.Drawing.Size(120, 25)
        Me.txtlocation.TabIndex = 11
        '
        'lbllocation
        '
        Me.lbllocation.AutoSize = True
        Me.lbllocation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllocation.Location = New System.Drawing.Point(314, 125)
        Me.lbllocation.Name = "lbllocation"
        Me.lbllocation.Size = New System.Drawing.Size(67, 19)
        Me.lbllocation.TabIndex = 10
        Me.lbllocation.Text = "Location"
        '
        'txtserial
        '
        Me.txtserial.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtserial.Location = New System.Drawing.Point(445, 86)
        Me.txtserial.Name = "txtserial"
        Me.txtserial.Size = New System.Drawing.Size(120, 25)
        Me.txtserial.TabIndex = 9
        '
        'lblserial
        '
        Me.lblserial.AutoSize = True
        Me.lblserial.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblserial.Location = New System.Drawing.Point(315, 88)
        Me.lblserial.Name = "lblserial"
        Me.lblserial.Size = New System.Drawing.Size(48, 19)
        Me.lblserial.TabIndex = 8
        Me.lblserial.Text = "Serial"
        '
        'txtinvno
        '
        Me.txtinvno.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinvno.Location = New System.Drawing.Point(445, 47)
        Me.txtinvno.Name = "txtinvno"
        Me.txtinvno.Size = New System.Drawing.Size(120, 25)
        Me.txtinvno.TabIndex = 7
        '
        'lblinvno
        '
        Me.lblinvno.AutoSize = True
        Me.lblinvno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvno.Location = New System.Drawing.Point(314, 49)
        Me.lblinvno.Name = "lblinvno"
        Me.lblinvno.Size = New System.Drawing.Size(82, 19)
        Me.lblinvno.TabIndex = 6
        Me.lblinvno.Text = "Invoice No"
        '
        'dtpinvdate
        '
        Me.dtpinvdate.CalendarFont = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpinvdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpinvdate.Location = New System.Drawing.Point(446, 15)
        Me.dtpinvdate.Name = "dtpinvdate"
        Me.dtpinvdate.Size = New System.Drawing.Size(121, 20)
        Me.dtpinvdate.TabIndex = 5
        '
        'lblinvdate
        '
        Me.lblinvdate.AutoSize = True
        Me.lblinvdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvdate.Location = New System.Drawing.Point(314, 17)
        Me.lblinvdate.Name = "lblinvdate"
        Me.lblinvdate.Size = New System.Drawing.Size(95, 19)
        Me.lblinvdate.TabIndex = 4
        Me.lblinvdate.Text = "Invoice Date"
        '
        'txtaddr
        '
        Me.txtaddr.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddr.Location = New System.Drawing.Point(99, 101)
        Me.txtaddr.Multiline = True
        Me.txtaddr.Name = "txtaddr"
        Me.txtaddr.Size = New System.Drawing.Size(120, 60)
        Me.txtaddr.TabIndex = 3
        '
        'txtcomname
        '
        Me.txtcomname.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcomname.Location = New System.Drawing.Point(99, 28)
        Me.txtcomname.Name = "txtcomname"
        Me.txtcomname.Size = New System.Drawing.Size(120, 25)
        Me.txtcomname.TabIndex = 2
        '
        'lbladdr
        '
        Me.lbladdr.AutoSize = True
        Me.lbladdr.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdr.Location = New System.Drawing.Point(6, 103)
        Me.lbladdr.Name = "lbladdr"
        Me.lbladdr.Size = New System.Drawing.Size(64, 19)
        Me.lbladdr.TabIndex = 1
        Me.lbladdr.Text = "Address"
        '
        'lblcompsny
        '
        Me.lblcompsny.AutoSize = True
        Me.lblcompsny.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcompsny.Location = New System.Drawing.Point(5, 30)
        Me.lblcompsny.Name = "lblcompsny"
        Me.lblcompsny.Size = New System.Drawing.Size(72, 19)
        Me.lblcompsny.TabIndex = 0
        Me.lblcompsny.Text = "Company"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 607)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'invpanel2
        '
        Me.invpanel2.AutoSize = True
        Me.invpanel2.Controls.Add(Me.lblamt)
        Me.invpanel2.Controls.Add(Me.lbltotalamout)
        Me.invpanel2.Controls.Add(Me.lblamoutinwords)
        Me.invpanel2.Controls.Add(Me.RGVinvdeatils)
        Me.invpanel2.Location = New System.Drawing.Point(10, 337)
        Me.invpanel2.Name = "invpanel2"
        Me.invpanel2.Size = New System.Drawing.Size(639, 222)
        Me.invpanel2.TabIndex = 2
        '
        'lblamt
        '
        Me.lblamt.AutoSize = True
        Me.lblamt.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamt.Location = New System.Drawing.Point(501, 197)
        Me.lblamt.Name = "lblamt"
        Me.lblamt.Size = New System.Drawing.Size(28, 13)
        Me.lblamt.TabIndex = 3
        Me.lblamt.Text = "0.00"
        '
        'lbltotalamout
        '
        Me.lbltotalamout.AutoSize = True
        Me.lbltotalamout.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalamout.Location = New System.Drawing.Point(388, 196)
        Me.lbltotalamout.Name = "lbltotalamout"
        Me.lbltotalamout.Size = New System.Drawing.Size(76, 13)
        Me.lbltotalamout.TabIndex = 2
        Me.lbltotalamout.Text = "Total Amount"
        '
        'lblamoutinwords
        '
        Me.lblamoutinwords.AutoSize = True
        Me.lblamoutinwords.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamoutinwords.Location = New System.Drawing.Point(9, 197)
        Me.lblamoutinwords.Name = "lblamoutinwords"
        Me.lblamoutinwords.Size = New System.Drawing.Size(94, 13)
        Me.lblamoutinwords.TabIndex = 1
        Me.lblamoutinwords.Text = "amount in words"
        '
        'RGVinvdeatils
        '
        Me.RGVinvdeatils.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.RGVinvdeatils.Cursor = System.Windows.Forms.Cursors.Default
        Me.RGVinvdeatils.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RGVinvdeatils.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RGVinvdeatils.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RGVinvdeatils.Location = New System.Drawing.Point(5, 10)
        '
        '
        '
        GridViewBrowseColumn1.EnableExpressionEditor = False
        GridViewBrowseColumn1.FieldName = "DETID"
        GridViewBrowseColumn1.HeaderText = "SNO"
        GridViewBrowseColumn1.Name = "SNo"
        GridViewBrowseColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
        GridViewBrowseColumn1.Width = 55
        GridViewBrowseColumn2.EnableExpressionEditor = False
        GridViewBrowseColumn2.FieldName = "PARTICULARS"
        GridViewBrowseColumn2.HeaderText = "Particulars"
        GridViewBrowseColumn2.Name = "Particulars"
        GridViewBrowseColumn2.Width = 259
        GridViewBrowseColumn3.EnableExpressionEditor = False
        GridViewBrowseColumn3.FieldName = "QUANTITY"
        GridViewBrowseColumn3.HeaderText = "Quantity"
        GridViewBrowseColumn3.Name = "Quantity"
        GridViewBrowseColumn3.Width = 70
        GridViewBrowseColumn4.EnableExpressionEditor = False
        GridViewBrowseColumn4.FieldName = "RATE"
        GridViewBrowseColumn4.HeaderText = "Rate"
        GridViewBrowseColumn4.Name = "Rate"
        GridViewBrowseColumn4.Width = 90
        GridViewBrowseColumn5.EnableExpressionEditor = False
        GridViewBrowseColumn5.FieldName = "AMOUNT"
        GridViewBrowseColumn5.HeaderText = "Amount"
        GridViewBrowseColumn5.Name = "Amount"
        GridViewBrowseColumn5.Width = 100
        Me.RGVinvdeatils.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewBrowseColumn1, GridViewBrowseColumn2, GridViewBrowseColumn3, GridViewBrowseColumn4, GridViewBrowseColumn5})
        SortDescriptor1.PropertyName = "SNo"
        Me.RGVinvdeatils.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
        Me.RGVinvdeatils.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RGVinvdeatils.Name = "RGVinvdeatils"
        Me.RGVinvdeatils.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RGVinvdeatils.Size = New System.Drawing.Size(588, 180)
        Me.RGVinvdeatils.TabIndex = 0
        '
        'Chksave
        '
        Me.Chksave.AutoSize = True
        Me.Chksave.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chksave.Location = New System.Drawing.Point(12, 566)
        Me.Chksave.Name = "Chksave"
        Me.Chksave.Size = New System.Drawing.Size(99, 18)
        Me.Chksave.TabIndex = 3
        Me.Chksave.Text = "Print after Save"
        Me.Chksave.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.Location = New System.Drawing.Point(215, 565)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(67, 27)
        Me.btnnew.TabIndex = 15
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(303, 566)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(67, 27)
        Me.btnsave.TabIndex = 16
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(393, 566)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(67, 27)
        Me.btnprint.TabIndex = 17
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(480, 566)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(67, 27)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(567, 566)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(67, 27)
        Me.btncancel.TabIndex = 19
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'lblusernane
        '
        Me.lblusernane.AutoSize = True
        Me.lblusernane.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusernane.Location = New System.Drawing.Point(569, 43)
        Me.lblusernane.Name = "lblusernane"
        Me.lblusernane.Size = New System.Drawing.Size(50, 16)
        Me.lblusernane.TabIndex = 20
        Me.lblusernane.Text = "Welcome"
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.Location = New System.Drawing.Point(620, 41)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(38, 19)
        Me.lbluser.TabIndex = 21
        Me.lbluser.Text = "user"
        '
        'Invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(723, 607)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.lblusernane)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.Chksave)
        Me.Controls.Add(Me.invpanel2)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.invpanel1)
        Me.Name = "Invoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice"
        Me.invpanel1.ResumeLayout(False)
        Me.invpanel1.PerformLayout()
        Me.invpanel2.ResumeLayout(False)
        Me.invpanel2.PerformLayout()
        CType(Me.RGVinvdeatils.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGVinvdeatils, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents invpanel1 As Panel
    Friend WithEvents txtcomname As TextBox
    Friend WithEvents lbladdr As Label
    Friend WithEvents lblcompsny As Label
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents txtlocation As TextBox
    Friend WithEvents lbllocation As Label
    Friend WithEvents txtserial As TextBox
    Friend WithEvents lblserial As Label
    Friend WithEvents txtinvno As TextBox
    Friend WithEvents lblinvno As Label
    Friend WithEvents dtpinvdate As DateTimePicker
    Friend WithEvents lblinvdate As Label
    Friend WithEvents txtaddr As TextBox
    Friend WithEvents txtchalanno As TextBox
    Friend WithEvents lblchalan As Label
    Friend WithEvents btngetbill As Button
    Friend WithEvents invpanel2 As Panel
    Friend WithEvents lblamt As Label
    Friend WithEvents lbltotalamout As Label
    Friend WithEvents lblamoutinwords As Label
    Friend WithEvents RGVinvdeatils As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Chksave As CheckBox
    Friend WithEvents btnnew As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnprint As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents lblusernane As Label
    Friend WithEvents lbluser As Label
End Class
