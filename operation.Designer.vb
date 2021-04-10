<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class operation
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
        Me.companel = New System.Windows.Forms.Panel()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btncreate = New System.Windows.Forms.Button()
        Me.txtaddr = New System.Windows.Forms.TextBox()
        Me.txtcomname = New System.Windows.Forms.TextBox()
        Me.lbladdr = New System.Windows.Forms.Label()
        Me.lblcompsny = New System.Windows.Forms.Label()
        Me.invpanel = New System.Windows.Forms.Panel()
        Me.btninvcancel = New System.Windows.Forms.Button()
        Me.btninvcreate = New System.Windows.Forms.Button()
        Me.txtinvno = New System.Windows.Forms.TextBox()
        Me.lblinvno = New System.Windows.Forms.Label()
        Me.txtchalanno = New System.Windows.Forms.TextBox()
        Me.lblchalan = New System.Windows.Forms.Label()
        Me.txtlocation = New System.Windows.Forms.TextBox()
        Me.lbllocation = New System.Windows.Forms.Label()
        Me.txtserial = New System.Windows.Forms.TextBox()
        Me.lblserial = New System.Windows.Forms.Label()
        Me.dtpinvdate = New System.Windows.Forms.DateTimePicker()
        Me.lblinvdate = New System.Windows.Forms.Label()
        Me.invdetpanel = New System.Windows.Forms.Panel()
        Me.txtamt = New System.Windows.Forms.TextBox()
        Me.lblamt = New System.Windows.Forms.Label()
        Me.txtrate = New System.Windows.Forms.TextBox()
        Me.lblrate = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.lblqty = New System.Windows.Forms.Label()
        Me.txtinvdes = New System.Windows.Forms.TextBox()
        Me.lblparticulars = New System.Windows.Forms.Label()
        Me.btninvdetcancel = New System.Windows.Forms.Button()
        Me.btninvdetcreate = New System.Windows.Forms.Button()
        Me.txtactvalue = New System.Windows.Forms.TextBox()
        Me.companel.SuspendLayout()
        Me.invpanel.SuspendLayout()
        Me.invdetpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'companel
        '
        Me.companel.AutoSize = True
        Me.companel.Controls.Add(Me.btncancel)
        Me.companel.Controls.Add(Me.btncreate)
        Me.companel.Controls.Add(Me.txtaddr)
        Me.companel.Controls.Add(Me.txtcomname)
        Me.companel.Controls.Add(Me.lbladdr)
        Me.companel.Controls.Add(Me.lblcompsny)
        Me.companel.Location = New System.Drawing.Point(13, 33)
        Me.companel.Name = "companel"
        Me.companel.Size = New System.Drawing.Size(293, 253)
        Me.companel.TabIndex = 0
        Me.companel.Visible = False
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(156, 193)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 25)
        Me.btncancel.TabIndex = 18
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btncreate
        '
        Me.btncreate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncreate.Location = New System.Drawing.Point(58, 194)
        Me.btncreate.Name = "btncreate"
        Me.btncreate.Size = New System.Drawing.Size(75, 25)
        Me.btncreate.TabIndex = 17
        Me.btncreate.Text = "Create"
        Me.btncreate.UseVisualStyleBackColor = True
        '
        'txtaddr
        '
        Me.txtaddr.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddr.Location = New System.Drawing.Point(126, 108)
        Me.txtaddr.Multiline = True
        Me.txtaddr.Name = "txtaddr"
        Me.txtaddr.Size = New System.Drawing.Size(120, 60)
        Me.txtaddr.TabIndex = 7
        '
        'txtcomname
        '
        Me.txtcomname.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcomname.Location = New System.Drawing.Point(126, 35)
        Me.txtcomname.Name = "txtcomname"
        Me.txtcomname.Size = New System.Drawing.Size(120, 25)
        Me.txtcomname.TabIndex = 6
        '
        'lbladdr
        '
        Me.lbladdr.AutoSize = True
        Me.lbladdr.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdr.Location = New System.Drawing.Point(33, 110)
        Me.lbladdr.Name = "lbladdr"
        Me.lbladdr.Size = New System.Drawing.Size(64, 19)
        Me.lbladdr.TabIndex = 5
        Me.lbladdr.Text = "Address"
        '
        'lblcompsny
        '
        Me.lblcompsny.AutoSize = True
        Me.lblcompsny.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcompsny.Location = New System.Drawing.Point(32, 37)
        Me.lblcompsny.Name = "lblcompsny"
        Me.lblcompsny.Size = New System.Drawing.Size(72, 19)
        Me.lblcompsny.TabIndex = 4
        Me.lblcompsny.Text = "Company"
        '
        'invpanel
        '
        Me.invpanel.AutoSize = True
        Me.invpanel.Controls.Add(Me.btninvcancel)
        Me.invpanel.Controls.Add(Me.btninvcreate)
        Me.invpanel.Controls.Add(Me.txtinvno)
        Me.invpanel.Controls.Add(Me.lblinvno)
        Me.invpanel.Controls.Add(Me.txtchalanno)
        Me.invpanel.Controls.Add(Me.lblchalan)
        Me.invpanel.Controls.Add(Me.txtlocation)
        Me.invpanel.Controls.Add(Me.lbllocation)
        Me.invpanel.Controls.Add(Me.txtserial)
        Me.invpanel.Controls.Add(Me.lblserial)
        Me.invpanel.Controls.Add(Me.dtpinvdate)
        Me.invpanel.Controls.Add(Me.lblinvdate)
        Me.invpanel.Location = New System.Drawing.Point(327, 32)
        Me.invpanel.Name = "invpanel"
        Me.invpanel.Size = New System.Drawing.Size(281, 253)
        Me.invpanel.TabIndex = 1
        Me.invpanel.Visible = False
        '
        'btninvcancel
        '
        Me.btninvcancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninvcancel.Location = New System.Drawing.Point(144, 210)
        Me.btninvcancel.Name = "btninvcancel"
        Me.btninvcancel.Size = New System.Drawing.Size(75, 25)
        Me.btninvcancel.TabIndex = 27
        Me.btninvcancel.Text = "Cancel"
        Me.btninvcancel.UseVisualStyleBackColor = True
        '
        'btninvcreate
        '
        Me.btninvcreate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninvcreate.Location = New System.Drawing.Point(46, 211)
        Me.btninvcreate.Name = "btninvcreate"
        Me.btninvcreate.Size = New System.Drawing.Size(75, 25)
        Me.btninvcreate.TabIndex = 26
        Me.btninvcreate.Text = "Create"
        Me.btninvcreate.UseVisualStyleBackColor = True
        '
        'txtinvno
        '
        Me.txtinvno.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinvno.Location = New System.Drawing.Point(140, 18)
        Me.txtinvno.Name = "txtinvno"
        Me.txtinvno.Size = New System.Drawing.Size(120, 25)
        Me.txtinvno.TabIndex = 25
        '
        'lblinvno
        '
        Me.lblinvno.AutoSize = True
        Me.lblinvno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvno.Location = New System.Drawing.Point(9, 20)
        Me.lblinvno.Name = "lblinvno"
        Me.lblinvno.Size = New System.Drawing.Size(82, 19)
        Me.lblinvno.TabIndex = 24
        Me.lblinvno.Text = "Invoice No"
        '
        'txtchalanno
        '
        Me.txtchalanno.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchalanno.Location = New System.Drawing.Point(140, 168)
        Me.txtchalanno.Name = "txtchalanno"
        Me.txtchalanno.Size = New System.Drawing.Size(120, 25)
        Me.txtchalanno.TabIndex = 23
        '
        'lblchalan
        '
        Me.lblchalan.AutoSize = True
        Me.lblchalan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchalan.Location = New System.Drawing.Point(9, 170)
        Me.lblchalan.Name = "lblchalan"
        Me.lblchalan.Size = New System.Drawing.Size(84, 19)
        Me.lblchalan.TabIndex = 22
        Me.lblchalan.Text = "Chalan  No"
        '
        'txtlocation
        '
        Me.txtlocation.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlocation.Location = New System.Drawing.Point(141, 127)
        Me.txtlocation.Name = "txtlocation"
        Me.txtlocation.Size = New System.Drawing.Size(120, 25)
        Me.txtlocation.TabIndex = 21
        '
        'lbllocation
        '
        Me.lbllocation.AutoSize = True
        Me.lbllocation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllocation.Location = New System.Drawing.Point(10, 129)
        Me.lbllocation.Name = "lbllocation"
        Me.lbllocation.Size = New System.Drawing.Size(67, 19)
        Me.lbllocation.TabIndex = 20
        Me.lbllocation.Text = "Location"
        '
        'txtserial
        '
        Me.txtserial.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtserial.Location = New System.Drawing.Point(141, 90)
        Me.txtserial.Name = "txtserial"
        Me.txtserial.Size = New System.Drawing.Size(120, 25)
        Me.txtserial.TabIndex = 19
        '
        'lblserial
        '
        Me.lblserial.AutoSize = True
        Me.lblserial.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblserial.Location = New System.Drawing.Point(11, 92)
        Me.lblserial.Name = "lblserial"
        Me.lblserial.Size = New System.Drawing.Size(48, 19)
        Me.lblserial.TabIndex = 18
        Me.lblserial.Text = "Serial"
        '
        'dtpinvdate
        '
        Me.dtpinvdate.CalendarFont = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpinvdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpinvdate.Location = New System.Drawing.Point(142, 56)
        Me.dtpinvdate.Name = "dtpinvdate"
        Me.dtpinvdate.Size = New System.Drawing.Size(121, 20)
        Me.dtpinvdate.TabIndex = 15
        '
        'lblinvdate
        '
        Me.lblinvdate.AutoSize = True
        Me.lblinvdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvdate.Location = New System.Drawing.Point(10, 58)
        Me.lblinvdate.Name = "lblinvdate"
        Me.lblinvdate.Size = New System.Drawing.Size(95, 19)
        Me.lblinvdate.TabIndex = 14
        Me.lblinvdate.Text = "Invoice Date"
        '
        'invdetpanel
        '
        Me.invdetpanel.AutoSize = True
        Me.invdetpanel.Controls.Add(Me.txtamt)
        Me.invdetpanel.Controls.Add(Me.lblamt)
        Me.invdetpanel.Controls.Add(Me.txtrate)
        Me.invdetpanel.Controls.Add(Me.lblrate)
        Me.invdetpanel.Controls.Add(Me.txtqty)
        Me.invdetpanel.Controls.Add(Me.lblqty)
        Me.invdetpanel.Controls.Add(Me.txtinvdes)
        Me.invdetpanel.Controls.Add(Me.lblparticulars)
        Me.invdetpanel.Controls.Add(Me.btninvdetcancel)
        Me.invdetpanel.Controls.Add(Me.btninvdetcreate)
        Me.invdetpanel.Location = New System.Drawing.Point(130, 297)
        Me.invdetpanel.Name = "invdetpanel"
        Me.invdetpanel.Size = New System.Drawing.Size(416, 223)
        Me.invdetpanel.TabIndex = 2
        Me.invdetpanel.Visible = False
        '
        'txtamt
        '
        Me.txtamt.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamt.Location = New System.Drawing.Point(196, 135)
        Me.txtamt.Name = "txtamt"
        Me.txtamt.Size = New System.Drawing.Size(120, 25)
        Me.txtamt.TabIndex = 37
        '
        'lblamt
        '
        Me.lblamt.AutoSize = True
        Me.lblamt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamt.Location = New System.Drawing.Point(102, 137)
        Me.lblamt.Name = "lblamt"
        Me.lblamt.Size = New System.Drawing.Size(61, 19)
        Me.lblamt.TabIndex = 36
        Me.lblamt.Text = "Amount"
        '
        'txtrate
        '
        Me.txtrate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrate.Location = New System.Drawing.Point(196, 95)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Size = New System.Drawing.Size(120, 25)
        Me.txtrate.TabIndex = 35
        '
        'lblrate
        '
        Me.lblrate.AutoSize = True
        Me.lblrate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrate.Location = New System.Drawing.Point(102, 97)
        Me.lblrate.Name = "lblrate"
        Me.lblrate.Size = New System.Drawing.Size(42, 19)
        Me.lblrate.TabIndex = 34
        Me.lblrate.Text = "Rate"
        '
        'txtqty
        '
        Me.txtqty.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Location = New System.Drawing.Point(195, 55)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(120, 25)
        Me.txtqty.TabIndex = 33
        '
        'lblqty
        '
        Me.lblqty.AutoSize = True
        Me.lblqty.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqty.Location = New System.Drawing.Point(101, 57)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(67, 19)
        Me.lblqty.TabIndex = 32
        Me.lblqty.Text = "Quantity"
        '
        'txtinvdes
        '
        Me.txtinvdes.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinvdes.Location = New System.Drawing.Point(195, 17)
        Me.txtinvdes.Name = "txtinvdes"
        Me.txtinvdes.Size = New System.Drawing.Size(120, 25)
        Me.txtinvdes.TabIndex = 31
        '
        'lblparticulars
        '
        Me.lblparticulars.AutoSize = True
        Me.lblparticulars.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblparticulars.Location = New System.Drawing.Point(101, 19)
        Me.lblparticulars.Name = "lblparticulars"
        Me.lblparticulars.Size = New System.Drawing.Size(57, 19)
        Me.lblparticulars.TabIndex = 30
        Me.lblparticulars.Text = "Details"
        '
        'btninvdetcancel
        '
        Me.btninvdetcancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninvdetcancel.Location = New System.Drawing.Point(214, 182)
        Me.btninvdetcancel.Name = "btninvdetcancel"
        Me.btninvdetcancel.Size = New System.Drawing.Size(75, 25)
        Me.btninvdetcancel.TabIndex = 29
        Me.btninvdetcancel.Text = "Cancel"
        Me.btninvdetcancel.UseVisualStyleBackColor = True
        '
        'btninvdetcreate
        '
        Me.btninvdetcreate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninvdetcreate.Location = New System.Drawing.Point(116, 183)
        Me.btninvdetcreate.Name = "btninvdetcreate"
        Me.btninvdetcreate.Size = New System.Drawing.Size(75, 25)
        Me.btninvdetcreate.TabIndex = 28
        Me.btninvdetcreate.Text = "Create"
        Me.btninvdetcreate.UseVisualStyleBackColor = True
        '
        'txtactvalue
        '
        Me.txtactvalue.Location = New System.Drawing.Point(13, 312)
        Me.txtactvalue.Name = "txtactvalue"
        Me.txtactvalue.Size = New System.Drawing.Size(100, 20)
        Me.txtactvalue.TabIndex = 3
        Me.txtactvalue.Visible = False
        '
        'operation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(636, 526)
        Me.Controls.Add(Me.txtactvalue)
        Me.Controls.Add(Me.invdetpanel)
        Me.Controls.Add(Me.invpanel)
        Me.Controls.Add(Me.companel)
        Me.Name = "operation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "operation"
        Me.companel.ResumeLayout(False)
        Me.companel.PerformLayout()
        Me.invpanel.ResumeLayout(False)
        Me.invpanel.PerformLayout()
        Me.invdetpanel.ResumeLayout(False)
        Me.invdetpanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents companel As Panel
    Friend WithEvents txtaddr As TextBox
    Friend WithEvents txtcomname As TextBox
    Friend WithEvents lbladdr As Label
    Friend WithEvents lblcompsny As Label
    Friend WithEvents btncancel As Button
    Friend WithEvents btncreate As Button
    Friend WithEvents invpanel As Panel
    Friend WithEvents btninvcancel As Button
    Friend WithEvents btninvcreate As Button
    Friend WithEvents txtinvno As TextBox
    Friend WithEvents lblinvno As Label
    Friend WithEvents txtchalanno As TextBox
    Friend WithEvents lblchalan As Label
    Friend WithEvents txtlocation As TextBox
    Friend WithEvents lbllocation As Label
    Friend WithEvents txtserial As TextBox
    Friend WithEvents lblserial As Label
    Friend WithEvents dtpinvdate As DateTimePicker
    Friend WithEvents lblinvdate As Label
    Friend WithEvents invdetpanel As Panel
    Friend WithEvents txtamt As TextBox
    Public WithEvents lblamt As Label
    Friend WithEvents txtrate As TextBox
    Friend WithEvents lblrate As Label
    Friend WithEvents txtqty As TextBox
    Friend WithEvents lblqty As Label
    Friend WithEvents txtinvdes As TextBox
    Friend WithEvents lblparticulars As Label
    Friend WithEvents btninvdetcancel As Button
    Friend WithEvents btninvdetcreate As Button
    Friend WithEvents txtactvalue As TextBox
End Class
