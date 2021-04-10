<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit
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
        Me.Editpanel1 = New System.Windows.Forms.Panel()
        Me.invdetpanel = New System.Windows.Forms.Panel()
        Me.cmbdid = New System.Windows.Forms.ComboBox()
        Me.lbldeetid = New System.Windows.Forms.Label()
        Me.cmbcom = New System.Windows.Forms.ComboBox()
        Me.lblinco = New System.Windows.Forms.Label()
        Me.btninvdesup = New System.Windows.Forms.Button()
        Me.cmbinv = New System.Windows.Forms.ComboBox()
        Me.lblindinvo = New System.Windows.Forms.Label()
        Me.txtamt = New System.Windows.Forms.TextBox()
        Me.lblamt = New System.Windows.Forms.Label()
        Me.txtrate = New System.Windows.Forms.TextBox()
        Me.lblrate = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.lblqty = New System.Windows.Forms.Label()
        Me.txtinvdes = New System.Windows.Forms.TextBox()
        Me.lblparticulars = New System.Windows.Forms.Label()
        Me.btninvdetcancel = New System.Windows.Forms.Button()
        Me.invpanel = New System.Windows.Forms.Panel()
        Me.btninvup = New System.Windows.Forms.Button()
        Me.cbinvno = New System.Windows.Forms.ComboBox()
        Me.Cbcom = New System.Windows.Forms.ComboBox()
        Me.lblicom = New System.Windows.Forms.Label()
        Me.btninvcancel = New System.Windows.Forms.Button()
        Me.lblinvno = New System.Windows.Forms.Label()
        Me.txtchalanno = New System.Windows.Forms.TextBox()
        Me.lblchalan = New System.Windows.Forms.Label()
        Me.txtlocation = New System.Windows.Forms.TextBox()
        Me.lbllocation = New System.Windows.Forms.Label()
        Me.txtserial = New System.Windows.Forms.TextBox()
        Me.lblserial = New System.Windows.Forms.Label()
        Me.dtpinvdate = New System.Windows.Forms.DateTimePicker()
        Me.lblinvdate = New System.Windows.Forms.Label()
        Me.ecompanel = New System.Windows.Forms.Panel()
        Me.Cbcomp = New System.Windows.Forms.ComboBox()
        Me.lblcomp = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.txtaddr = New System.Windows.Forms.TextBox()
        Me.txtcomname = New System.Windows.Forms.TextBox()
        Me.lbladdr = New System.Windows.Forms.Label()
        Me.lblcompsny = New System.Windows.Forms.Label()
        Me.Editpanel1.SuspendLayout()
        Me.invdetpanel.SuspendLayout()
        Me.invpanel.SuspendLayout()
        Me.ecompanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Editpanel1
        '
        Me.Editpanel1.Controls.Add(Me.invdetpanel)
        Me.Editpanel1.Controls.Add(Me.invpanel)
        Me.Editpanel1.Controls.Add(Me.ecompanel)
        Me.Editpanel1.Location = New System.Drawing.Point(13, 13)
        Me.Editpanel1.Name = "Editpanel1"
        Me.Editpanel1.Size = New System.Drawing.Size(879, 724)
        Me.Editpanel1.TabIndex = 0
        '
        'invdetpanel
        '
        Me.invdetpanel.Controls.Add(Me.cmbdid)
        Me.invdetpanel.Controls.Add(Me.lbldeetid)
        Me.invdetpanel.Controls.Add(Me.cmbcom)
        Me.invdetpanel.Controls.Add(Me.lblinco)
        Me.invdetpanel.Controls.Add(Me.btninvdesup)
        Me.invdetpanel.Controls.Add(Me.cmbinv)
        Me.invdetpanel.Controls.Add(Me.lblindinvo)
        Me.invdetpanel.Controls.Add(Me.txtamt)
        Me.invdetpanel.Controls.Add(Me.lblamt)
        Me.invdetpanel.Controls.Add(Me.txtrate)
        Me.invdetpanel.Controls.Add(Me.lblrate)
        Me.invdetpanel.Controls.Add(Me.txtqty)
        Me.invdetpanel.Controls.Add(Me.lblqty)
        Me.invdetpanel.Controls.Add(Me.txtinvdes)
        Me.invdetpanel.Controls.Add(Me.lblparticulars)
        Me.invdetpanel.Controls.Add(Me.btninvdetcancel)
        Me.invdetpanel.Location = New System.Drawing.Point(145, 350)
        Me.invdetpanel.Name = "invdetpanel"
        Me.invdetpanel.Size = New System.Drawing.Size(453, 371)
        Me.invdetpanel.TabIndex = 3
        Me.invdetpanel.Visible = False
        '
        'cmbdid
        '
        Me.cmbdid.FormattingEnabled = True
        Me.cmbdid.Location = New System.Drawing.Point(224, 104)
        Me.cmbdid.Name = "cmbdid"
        Me.cmbdid.Size = New System.Drawing.Size(121, 21)
        Me.cmbdid.TabIndex = 44
        '
        'lbldeetid
        '
        Me.lbldeetid.AutoSize = True
        Me.lbldeetid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldeetid.Location = New System.Drawing.Point(113, 106)
        Me.lbldeetid.Name = "lbldeetid"
        Me.lbldeetid.Size = New System.Drawing.Size(50, 19)
        Me.lbldeetid.TabIndex = 43
        Me.lbldeetid.Text = "Det id"
        '
        'cmbcom
        '
        Me.cmbcom.FormattingEnabled = True
        Me.cmbcom.Location = New System.Drawing.Point(223, 40)
        Me.cmbcom.Name = "cmbcom"
        Me.cmbcom.Size = New System.Drawing.Size(121, 21)
        Me.cmbcom.TabIndex = 42
        '
        'lblinco
        '
        Me.lblinco.AutoSize = True
        Me.lblinco.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinco.Location = New System.Drawing.Point(113, 43)
        Me.lblinco.Name = "lblinco"
        Me.lblinco.Size = New System.Drawing.Size(56, 19)
        Me.lblinco.TabIndex = 41
        Me.lblinco.Text = "Com id"
        '
        'btninvdesup
        '
        Me.btninvdesup.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninvdesup.Location = New System.Drawing.Point(115, 303)
        Me.btninvdesup.Name = "btninvdesup"
        Me.btninvdesup.Size = New System.Drawing.Size(75, 25)
        Me.btninvdesup.TabIndex = 40
        Me.btninvdesup.Text = "Update"
        Me.btninvdesup.UseVisualStyleBackColor = True
        '
        'cmbinv
        '
        Me.cmbinv.FormattingEnabled = True
        Me.cmbinv.Location = New System.Drawing.Point(225, 75)
        Me.cmbinv.Name = "cmbinv"
        Me.cmbinv.Size = New System.Drawing.Size(121, 21)
        Me.cmbinv.TabIndex = 39
        '
        'lblindinvo
        '
        Me.lblindinvo.AutoSize = True
        Me.lblindinvo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblindinvo.Location = New System.Drawing.Point(114, 78)
        Me.lblindinvo.Name = "lblindinvo"
        Me.lblindinvo.Size = New System.Drawing.Size(82, 19)
        Me.lblindinvo.TabIndex = 38
        Me.lblindinvo.Text = "Invoice No"
        '
        'txtamt
        '
        Me.txtamt.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamt.Location = New System.Drawing.Point(227, 255)
        Me.txtamt.Name = "txtamt"
        Me.txtamt.Size = New System.Drawing.Size(120, 25)
        Me.txtamt.TabIndex = 37
        '
        'lblamt
        '
        Me.lblamt.AutoSize = True
        Me.lblamt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamt.Location = New System.Drawing.Point(115, 257)
        Me.lblamt.Name = "lblamt"
        Me.lblamt.Size = New System.Drawing.Size(61, 19)
        Me.lblamt.TabIndex = 36
        Me.lblamt.Text = "Amount"
        '
        'txtrate
        '
        Me.txtrate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrate.Location = New System.Drawing.Point(227, 215)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Size = New System.Drawing.Size(120, 25)
        Me.txtrate.TabIndex = 35
        '
        'lblrate
        '
        Me.lblrate.AutoSize = True
        Me.lblrate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrate.Location = New System.Drawing.Point(115, 217)
        Me.lblrate.Name = "lblrate"
        Me.lblrate.Size = New System.Drawing.Size(42, 19)
        Me.lblrate.TabIndex = 34
        Me.lblrate.Text = "Rate"
        '
        'txtqty
        '
        Me.txtqty.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Location = New System.Drawing.Point(226, 175)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(120, 25)
        Me.txtqty.TabIndex = 33
        '
        'lblqty
        '
        Me.lblqty.AutoSize = True
        Me.lblqty.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqty.Location = New System.Drawing.Point(114, 177)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(67, 19)
        Me.lblqty.TabIndex = 32
        Me.lblqty.Text = "Quantity"
        '
        'txtinvdes
        '
        Me.txtinvdes.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinvdes.Location = New System.Drawing.Point(226, 137)
        Me.txtinvdes.Name = "txtinvdes"
        Me.txtinvdes.Size = New System.Drawing.Size(120, 25)
        Me.txtinvdes.TabIndex = 31
        '
        'lblparticulars
        '
        Me.lblparticulars.AutoSize = True
        Me.lblparticulars.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblparticulars.Location = New System.Drawing.Point(114, 139)
        Me.lblparticulars.Name = "lblparticulars"
        Me.lblparticulars.Size = New System.Drawing.Size(57, 19)
        Me.lblparticulars.TabIndex = 30
        Me.lblparticulars.Text = "Details"
        '
        'btninvdetcancel
        '
        Me.btninvdetcancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninvdetcancel.Location = New System.Drawing.Point(227, 302)
        Me.btninvdetcancel.Name = "btninvdetcancel"
        Me.btninvdetcancel.Size = New System.Drawing.Size(75, 25)
        Me.btninvdetcancel.TabIndex = 29
        Me.btninvdetcancel.Text = "Cancel"
        Me.btninvdetcancel.UseVisualStyleBackColor = True
        '
        'invpanel
        '
        Me.invpanel.Controls.Add(Me.btninvup)
        Me.invpanel.Controls.Add(Me.cbinvno)
        Me.invpanel.Controls.Add(Me.Cbcom)
        Me.invpanel.Controls.Add(Me.lblicom)
        Me.invpanel.Controls.Add(Me.btninvcancel)
        Me.invpanel.Controls.Add(Me.lblinvno)
        Me.invpanel.Controls.Add(Me.txtchalanno)
        Me.invpanel.Controls.Add(Me.lblchalan)
        Me.invpanel.Controls.Add(Me.txtlocation)
        Me.invpanel.Controls.Add(Me.lbllocation)
        Me.invpanel.Controls.Add(Me.txtserial)
        Me.invpanel.Controls.Add(Me.lblserial)
        Me.invpanel.Controls.Add(Me.dtpinvdate)
        Me.invpanel.Controls.Add(Me.lblinvdate)
        Me.invpanel.Location = New System.Drawing.Point(428, 17)
        Me.invpanel.Name = "invpanel"
        Me.invpanel.Size = New System.Drawing.Size(298, 322)
        Me.invpanel.TabIndex = 2
        Me.invpanel.Visible = False
        '
        'btninvup
        '
        Me.btninvup.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninvup.Location = New System.Drawing.Point(49, 256)
        Me.btninvup.Name = "btninvup"
        Me.btninvup.Size = New System.Drawing.Size(75, 25)
        Me.btninvup.TabIndex = 31
        Me.btninvup.Text = "Update"
        Me.btninvup.UseVisualStyleBackColor = True
        '
        'cbinvno
        '
        Me.cbinvno.FormattingEnabled = True
        Me.cbinvno.Location = New System.Drawing.Point(141, 63)
        Me.cbinvno.Name = "cbinvno"
        Me.cbinvno.Size = New System.Drawing.Size(121, 21)
        Me.cbinvno.TabIndex = 30
        '
        'Cbcom
        '
        Me.Cbcom.FormattingEnabled = True
        Me.Cbcom.Location = New System.Drawing.Point(141, 28)
        Me.Cbcom.Name = "Cbcom"
        Me.Cbcom.Size = New System.Drawing.Size(121, 21)
        Me.Cbcom.TabIndex = 29
        '
        'lblicom
        '
        Me.lblicom.AutoSize = True
        Me.lblicom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblicom.Location = New System.Drawing.Point(13, 31)
        Me.lblicom.Name = "lblicom"
        Me.lblicom.Size = New System.Drawing.Size(56, 19)
        Me.lblicom.TabIndex = 28
        Me.lblicom.Text = "Com id"
        '
        'btninvcancel
        '
        Me.btninvcancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninvcancel.Location = New System.Drawing.Point(146, 256)
        Me.btninvcancel.Name = "btninvcancel"
        Me.btninvcancel.Size = New System.Drawing.Size(75, 25)
        Me.btninvcancel.TabIndex = 27
        Me.btninvcancel.Text = "Cancel"
        Me.btninvcancel.UseVisualStyleBackColor = True
        '
        'lblinvno
        '
        Me.lblinvno.AutoSize = True
        Me.lblinvno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvno.Location = New System.Drawing.Point(11, 66)
        Me.lblinvno.Name = "lblinvno"
        Me.lblinvno.Size = New System.Drawing.Size(82, 19)
        Me.lblinvno.TabIndex = 24
        Me.lblinvno.Text = "Invoice No"
        '
        'txtchalanno
        '
        Me.txtchalanno.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchalanno.Location = New System.Drawing.Point(142, 214)
        Me.txtchalanno.Name = "txtchalanno"
        Me.txtchalanno.Size = New System.Drawing.Size(120, 25)
        Me.txtchalanno.TabIndex = 23
        '
        'lblchalan
        '
        Me.lblchalan.AutoSize = True
        Me.lblchalan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchalan.Location = New System.Drawing.Point(11, 216)
        Me.lblchalan.Name = "lblchalan"
        Me.lblchalan.Size = New System.Drawing.Size(84, 19)
        Me.lblchalan.TabIndex = 22
        Me.lblchalan.Text = "Chalan  No"
        '
        'txtlocation
        '
        Me.txtlocation.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlocation.Location = New System.Drawing.Point(143, 173)
        Me.txtlocation.Name = "txtlocation"
        Me.txtlocation.Size = New System.Drawing.Size(120, 25)
        Me.txtlocation.TabIndex = 21
        '
        'lbllocation
        '
        Me.lbllocation.AutoSize = True
        Me.lbllocation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllocation.Location = New System.Drawing.Point(12, 175)
        Me.lbllocation.Name = "lbllocation"
        Me.lbllocation.Size = New System.Drawing.Size(67, 19)
        Me.lbllocation.TabIndex = 20
        Me.lbllocation.Text = "Location"
        '
        'txtserial
        '
        Me.txtserial.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtserial.Location = New System.Drawing.Point(143, 136)
        Me.txtserial.Name = "txtserial"
        Me.txtserial.Size = New System.Drawing.Size(120, 25)
        Me.txtserial.TabIndex = 19
        '
        'lblserial
        '
        Me.lblserial.AutoSize = True
        Me.lblserial.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblserial.Location = New System.Drawing.Point(13, 138)
        Me.lblserial.Name = "lblserial"
        Me.lblserial.Size = New System.Drawing.Size(48, 19)
        Me.lblserial.TabIndex = 18
        Me.lblserial.Text = "Serial"
        '
        'dtpinvdate
        '
        Me.dtpinvdate.CalendarFont = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpinvdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpinvdate.Location = New System.Drawing.Point(144, 102)
        Me.dtpinvdate.Name = "dtpinvdate"
        Me.dtpinvdate.Size = New System.Drawing.Size(121, 20)
        Me.dtpinvdate.TabIndex = 15
        '
        'lblinvdate
        '
        Me.lblinvdate.AutoSize = True
        Me.lblinvdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvdate.Location = New System.Drawing.Point(12, 104)
        Me.lblinvdate.Name = "lblinvdate"
        Me.lblinvdate.Size = New System.Drawing.Size(95, 19)
        Me.lblinvdate.TabIndex = 14
        Me.lblinvdate.Text = "Invoice Date"
        '
        'ecompanel
        '
        Me.ecompanel.Controls.Add(Me.Cbcomp)
        Me.ecompanel.Controls.Add(Me.lblcomp)
        Me.ecompanel.Controls.Add(Me.btncancel)
        Me.ecompanel.Controls.Add(Me.btnupdate)
        Me.ecompanel.Controls.Add(Me.txtaddr)
        Me.ecompanel.Controls.Add(Me.txtcomname)
        Me.ecompanel.Controls.Add(Me.lbladdr)
        Me.ecompanel.Controls.Add(Me.lblcompsny)
        Me.ecompanel.Location = New System.Drawing.Point(43, 36)
        Me.ecompanel.Name = "ecompanel"
        Me.ecompanel.Size = New System.Drawing.Size(259, 276)
        Me.ecompanel.TabIndex = 0
        '
        'Cbcomp
        '
        Me.Cbcomp.FormattingEnabled = True
        Me.Cbcomp.Location = New System.Drawing.Point(101, 22)
        Me.Cbcomp.Name = "Cbcomp"
        Me.Cbcomp.Size = New System.Drawing.Size(121, 21)
        Me.Cbcomp.TabIndex = 26
        '
        'lblcomp
        '
        Me.lblcomp.AutoSize = True
        Me.lblcomp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcomp.Location = New System.Drawing.Point(6, 25)
        Me.lblcomp.Name = "lblcomp"
        Me.lblcomp.Size = New System.Drawing.Size(56, 19)
        Me.lblcomp.TabIndex = 25
        Me.lblcomp.Text = "Com id"
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(131, 205)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 25)
        Me.btncancel.TabIndex = 24
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(33, 206)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 25)
        Me.btnupdate.TabIndex = 23
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'txtaddr
        '
        Me.txtaddr.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddr.Location = New System.Drawing.Point(101, 126)
        Me.txtaddr.Multiline = True
        Me.txtaddr.Name = "txtaddr"
        Me.txtaddr.Size = New System.Drawing.Size(120, 60)
        Me.txtaddr.TabIndex = 22
        '
        'txtcomname
        '
        Me.txtcomname.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcomname.Location = New System.Drawing.Point(101, 70)
        Me.txtcomname.Name = "txtcomname"
        Me.txtcomname.Size = New System.Drawing.Size(120, 25)
        Me.txtcomname.TabIndex = 21
        Me.txtcomname.Text = "         "
        '
        'lbladdr
        '
        Me.lbladdr.AutoSize = True
        Me.lbladdr.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdr.Location = New System.Drawing.Point(8, 128)
        Me.lbladdr.Name = "lbladdr"
        Me.lbladdr.Size = New System.Drawing.Size(64, 19)
        Me.lbladdr.TabIndex = 20
        Me.lbladdr.Text = "Address"
        '
        'lblcompsny
        '
        Me.lblcompsny.AutoSize = True
        Me.lblcompsny.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcompsny.Location = New System.Drawing.Point(8, 76)
        Me.lblcompsny.Name = "lblcompsny"
        Me.lblcompsny.Size = New System.Drawing.Size(72, 19)
        Me.lblcompsny.TabIndex = 19
        Me.lblcompsny.Text = "Company"
        '
        'edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(908, 749)
        Me.Controls.Add(Me.Editpanel1)
        Me.Name = "edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "edit"
        Me.Editpanel1.ResumeLayout(False)
        Me.invdetpanel.ResumeLayout(False)
        Me.invdetpanel.PerformLayout()
        Me.invpanel.ResumeLayout(False)
        Me.invpanel.PerformLayout()
        Me.ecompanel.ResumeLayout(False)
        Me.ecompanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Editpanel1 As Panel
    Friend WithEvents ecompanel As Panel
    Friend WithEvents btncancel As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents txtaddr As TextBox
    Friend WithEvents txtcomname As TextBox
    Friend WithEvents lbladdr As Label
    Friend WithEvents lblcompsny As Label
    Friend WithEvents Cbcomp As ComboBox
    Friend WithEvents lblcomp As Label
    Friend WithEvents invpanel As Panel
    Friend WithEvents Cbcom As ComboBox
    Friend WithEvents lblicom As Label
    Friend WithEvents btninvcancel As Button
    Friend WithEvents lblinvno As Label
    Friend WithEvents txtchalanno As TextBox
    Friend WithEvents lblchalan As Label
    Friend WithEvents txtlocation As TextBox
    Friend WithEvents lbllocation As Label
    Friend WithEvents txtserial As TextBox
    Friend WithEvents lblserial As Label
    Friend WithEvents dtpinvdate As DateTimePicker
    Friend WithEvents lblinvdate As Label
    Friend WithEvents btninvup As Button
    Friend WithEvents cbinvno As ComboBox
    Friend WithEvents invdetpanel As Panel
    Friend WithEvents btninvdesup As Button
    Friend WithEvents cmbinv As ComboBox
    Friend WithEvents lblindinvo As Label
    Friend WithEvents txtamt As TextBox
    Public WithEvents lblamt As Label
    Friend WithEvents txtrate As TextBox
    Friend WithEvents lblrate As Label
    Friend WithEvents txtqty As TextBox
    Friend WithEvents lblqty As Label
    Friend WithEvents txtinvdes As TextBox
    Friend WithEvents lblparticulars As Label
    Friend WithEvents btninvdetcancel As Button
    Friend WithEvents cmbcom As ComboBox
    Friend WithEvents lblinco As Label
    Friend WithEvents cmbdid As ComboBox
    Friend WithEvents lbldeetid As Label
End Class
