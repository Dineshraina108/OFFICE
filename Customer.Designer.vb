<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Me.cupanel1 = New System.Windows.Forms.Panel()
        Me.dtpdob = New System.Windows.Forms.DateTimePicker()
        Me.btnsub = New System.Windows.Forms.Button()
        Me.btndisp = New System.Windows.Forms.Button()
        Me.btndele = New System.Windows.Forms.Button()
        Me.btnupd = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.txtcusid = New System.Windows.Forms.TextBox()
        Me.lblclustid = New System.Windows.Forms.Label()
        Me.txtmobno = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.lblmobno = New System.Windows.Forms.Label()
        Me.lbldob = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.cupanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cupanel1
        '
        Me.cupanel1.BackColor = System.Drawing.Color.LightGray
        Me.cupanel1.Controls.Add(Me.btnadd)
        Me.cupanel1.Controls.Add(Me.dtpdob)
        Me.cupanel1.Controls.Add(Me.btnsub)
        Me.cupanel1.Controls.Add(Me.btndisp)
        Me.cupanel1.Controls.Add(Me.btndele)
        Me.cupanel1.Controls.Add(Me.btnupd)
        Me.cupanel1.Controls.Add(Me.btnexit)
        Me.cupanel1.Controls.Add(Me.txtcusid)
        Me.cupanel1.Controls.Add(Me.lblclustid)
        Me.cupanel1.Controls.Add(Me.txtmobno)
        Me.cupanel1.Controls.Add(Me.txtname)
        Me.cupanel1.Controls.Add(Me.lblmobno)
        Me.cupanel1.Controls.Add(Me.lbldob)
        Me.cupanel1.Controls.Add(Me.lblname)
        Me.cupanel1.Location = New System.Drawing.Point(48, 46)
        Me.cupanel1.Name = "cupanel1"
        Me.cupanel1.Size = New System.Drawing.Size(566, 285)
        Me.cupanel1.TabIndex = 0
        '
        'dtpdob
        '
        Me.dtpdob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdob.Location = New System.Drawing.Point(292, 111)
        Me.dtpdob.Name = "dtpdob"
        Me.dtpdob.Size = New System.Drawing.Size(101, 20)
        Me.dtpdob.TabIndex = 25
        '
        'btnsub
        '
        Me.btnsub.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsub.Location = New System.Drawing.Point(52, 191)
        Me.btnsub.Name = "btnsub"
        Me.btnsub.Size = New System.Drawing.Size(75, 23)
        Me.btnsub.TabIndex = 24
        Me.btnsub.Text = "NEW"
        Me.btnsub.UseVisualStyleBackColor = True
        '
        'btndisp
        '
        Me.btndisp.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndisp.Location = New System.Drawing.Point(307, 192)
        Me.btndisp.Name = "btndisp"
        Me.btndisp.Size = New System.Drawing.Size(75, 23)
        Me.btndisp.TabIndex = 23
        Me.btndisp.Text = "VIEW"
        Me.btndisp.UseVisualStyleBackColor = True
        '
        'btndele
        '
        Me.btndele.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndele.Location = New System.Drawing.Point(223, 192)
        Me.btndele.Name = "btndele"
        Me.btndele.Size = New System.Drawing.Size(75, 23)
        Me.btndele.TabIndex = 22
        Me.btndele.Text = "DELETE"
        Me.btndele.UseVisualStyleBackColor = True
        '
        'btnupd
        '
        Me.btnupd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupd.Location = New System.Drawing.Point(138, 192)
        Me.btnupd.Name = "btnupd"
        Me.btnupd.Size = New System.Drawing.Size(75, 23)
        Me.btnupd.TabIndex = 21
        Me.btnupd.Text = "UPDATE"
        Me.btnupd.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(474, 191)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 20
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'txtcusid
        '
        Me.txtcusid.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcusid.Location = New System.Drawing.Point(292, 26)
        Me.txtcusid.Name = "txtcusid"
        Me.txtcusid.Size = New System.Drawing.Size(100, 22)
        Me.txtcusid.TabIndex = 18
        '
        'lblclustid
        '
        Me.lblclustid.AutoSize = True
        Me.lblclustid.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclustid.Location = New System.Drawing.Point(180, 29)
        Me.lblclustid.Name = "lblclustid"
        Me.lblclustid.Size = New System.Drawing.Size(66, 17)
        Me.lblclustid.TabIndex = 17
        Me.lblclustid.Text = "CUST ID"
        '
        'txtmobno
        '
        Me.txtmobno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmobno.Location = New System.Drawing.Point(292, 145)
        Me.txtmobno.Name = "txtmobno"
        Me.txtmobno.Size = New System.Drawing.Size(100, 22)
        Me.txtmobno.TabIndex = 16
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(292, 68)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 22)
        Me.txtname.TabIndex = 14
        '
        'lblmobno
        '
        Me.lblmobno.AutoSize = True
        Me.lblmobno.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmobno.Location = New System.Drawing.Point(178, 151)
        Me.lblmobno.Name = "lblmobno"
        Me.lblmobno.Size = New System.Drawing.Size(91, 17)
        Me.lblmobno.TabIndex = 13
        Me.lblmobno.Text = "MOBILE NO"
        '
        'lbldob
        '
        Me.lbldob.AutoSize = True
        Me.lbldob.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldob.Location = New System.Drawing.Point(180, 111)
        Me.lbldob.Name = "lbldob"
        Me.lbldob.Size = New System.Drawing.Size(40, 17)
        Me.lbldob.TabIndex = 12
        Me.lbldob.Text = "DOB"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(181, 70)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(52, 17)
        Me.lblname.TabIndex = 11
        Me.lblname.Text = "NAME"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.Location = New System.Drawing.Point(194, 1)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(247, 29)
        Me.lbltitle.TabIndex = 2
        Me.lbltitle.Text = "CUTOMER ENQUIRY"
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(391, 192)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 26
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(681, 390)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.cupanel1)
        Me.Name = "Customer"
        Me.Text = "Customer"
        Me.cupanel1.ResumeLayout(False)
        Me.cupanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cupanel1 As Panel
    Friend WithEvents lbltitle As Label
    Friend WithEvents txtcusid As TextBox
    Friend WithEvents lblclustid As Label
    Friend WithEvents txtmobno As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents lblmobno As Label
    Friend WithEvents lbldob As Label
    Friend WithEvents lblname As Label
    Friend WithEvents btnexit As Button
    Friend WithEvents btndisp As Button
    Friend WithEvents btndele As Button
    Friend WithEvents btnupd As Button
    Friend WithEvents btnsub As Button
    Friend WithEvents dtpdob As DateTimePicker
    Friend WithEvents btnadd As Button
End Class
