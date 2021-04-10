<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Usreg
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
        Me.usregpanel = New System.Windows.Forms.Panel()
        Me.RDN = New System.Windows.Forms.RadioButton()
        Me.RDS = New System.Windows.Forms.RadioButton()
        Me.lblup = New System.Windows.Forms.Label()
        Me.txtusid = New System.Windows.Forms.TextBox()
        Me.lbluserid = New System.Windows.Forms.Label()
        Me.llblallogin = New System.Windows.Forms.LinkLabel()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnreg = New System.Windows.Forms.Button()
        Me.txtmobno = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txturepass = New System.Windows.Forms.TextBox()
        Me.txtupass = New System.Windows.Forms.TextBox()
        Me.txtuname = New System.Windows.Forms.TextBox()
        Me.lablmobno = New System.Windows.Forms.Label()
        Me.lblemal = New System.Windows.Forms.Label()
        Me.lblrepass = New System.Windows.Forms.Label()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.lbluname = New System.Windows.Forms.Label()
        Me.lblusreg = New System.Windows.Forms.Label()
        Me.usregpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'usregpanel
        '
        Me.usregpanel.BackColor = System.Drawing.Color.PapayaWhip
        Me.usregpanel.Controls.Add(Me.RDN)
        Me.usregpanel.Controls.Add(Me.RDS)
        Me.usregpanel.Controls.Add(Me.lblup)
        Me.usregpanel.Controls.Add(Me.txtusid)
        Me.usregpanel.Controls.Add(Me.lbluserid)
        Me.usregpanel.Controls.Add(Me.llblallogin)
        Me.usregpanel.Controls.Add(Me.btnclear)
        Me.usregpanel.Controls.Add(Me.btnreg)
        Me.usregpanel.Controls.Add(Me.txtmobno)
        Me.usregpanel.Controls.Add(Me.txtemail)
        Me.usregpanel.Controls.Add(Me.txturepass)
        Me.usregpanel.Controls.Add(Me.txtupass)
        Me.usregpanel.Controls.Add(Me.txtuname)
        Me.usregpanel.Controls.Add(Me.lablmobno)
        Me.usregpanel.Controls.Add(Me.lblemal)
        Me.usregpanel.Controls.Add(Me.lblrepass)
        Me.usregpanel.Controls.Add(Me.lblpass)
        Me.usregpanel.Controls.Add(Me.lbluname)
        Me.usregpanel.Controls.Add(Me.lblusreg)
        Me.usregpanel.Location = New System.Drawing.Point(14, 33)
        Me.usregpanel.Name = "usregpanel"
        Me.usregpanel.Size = New System.Drawing.Size(373, 384)
        Me.usregpanel.TabIndex = 0
        '
        'RDN
        '
        Me.RDN.AutoSize = True
        Me.RDN.Location = New System.Drawing.Point(273, 267)
        Me.RDN.Name = "RDN"
        Me.RDN.Size = New System.Drawing.Size(41, 17)
        Me.RDN.TabIndex = 18
        Me.RDN.TabStop = True
        Me.RDN.Text = "NO"
        Me.RDN.UseVisualStyleBackColor = True
        '
        'RDS
        '
        Me.RDS.AutoSize = True
        Me.RDS.Location = New System.Drawing.Point(209, 269)
        Me.RDS.Name = "RDS"
        Me.RDS.Size = New System.Drawing.Size(46, 17)
        Me.RDS.TabIndex = 17
        Me.RDS.TabStop = True
        Me.RDS.Text = "YES"
        Me.RDS.UseVisualStyleBackColor = True
        '
        'lblup
        '
        Me.lblup.AutoSize = True
        Me.lblup.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblup.Location = New System.Drawing.Point(35, 267)
        Me.lblup.Name = "lblup"
        Me.lblup.Size = New System.Drawing.Size(143, 18)
        Me.lblup.TabIndex = 16
        Me.lblup.Text = "USER PRIVILAGE"
        '
        'txtusid
        '
        Me.txtusid.Location = New System.Drawing.Point(209, 49)
        Me.txtusid.Name = "txtusid"
        Me.txtusid.Size = New System.Drawing.Size(104, 20)
        Me.txtusid.TabIndex = 15
        '
        'lbluserid
        '
        Me.lbluserid.AutoSize = True
        Me.lbluserid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluserid.Location = New System.Drawing.Point(32, 49)
        Me.lbluserid.Name = "lbluserid"
        Me.lbluserid.Size = New System.Drawing.Size(69, 19)
        Me.lbluserid.TabIndex = 14
        Me.lbluserid.Text = "USERID"
        '
        'llblallogin
        '
        Me.llblallogin.AutoSize = True
        Me.llblallogin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblallogin.Location = New System.Drawing.Point(219, 304)
        Me.llblallogin.Name = "llblallogin"
        Me.llblallogin.Size = New System.Drawing.Size(151, 19)
        Me.llblallogin.TabIndex = 13
        Me.llblallogin.TabStop = True
        Me.llblallogin.Text = "Already hava a account"
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(197, 335)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(83, 28)
        Me.btnclear.TabIndex = 12
        Me.btnclear.Text = "  CLEAR"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnreg
        '
        Me.btnreg.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreg.Location = New System.Drawing.Point(54, 335)
        Me.btnreg.Name = "btnreg"
        Me.btnreg.Size = New System.Drawing.Size(103, 28)
        Me.btnreg.TabIndex = 11
        Me.btnreg.Text = "REGISTER"
        Me.btnreg.UseVisualStyleBackColor = True
        '
        'txtmobno
        '
        Me.txtmobno.Location = New System.Drawing.Point(210, 231)
        Me.txtmobno.Name = "txtmobno"
        Me.txtmobno.Size = New System.Drawing.Size(104, 20)
        Me.txtmobno.TabIndex = 10
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(209, 193)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(104, 20)
        Me.txtemail.TabIndex = 9
        '
        'txturepass
        '
        Me.txturepass.Location = New System.Drawing.Point(209, 159)
        Me.txturepass.Name = "txturepass"
        Me.txturepass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txturepass.Size = New System.Drawing.Size(104, 20)
        Me.txturepass.TabIndex = 8
        '
        'txtupass
        '
        Me.txtupass.Location = New System.Drawing.Point(209, 121)
        Me.txtupass.Name = "txtupass"
        Me.txtupass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtupass.Size = New System.Drawing.Size(104, 20)
        Me.txtupass.TabIndex = 7
        '
        'txtuname
        '
        Me.txtuname.Location = New System.Drawing.Point(210, 84)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(104, 20)
        Me.txtuname.TabIndex = 6
        '
        'lablmobno
        '
        Me.lablmobno.AutoSize = True
        Me.lablmobno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablmobno.Location = New System.Drawing.Point(36, 231)
        Me.lablmobno.Name = "lablmobno"
        Me.lablmobno.Size = New System.Drawing.Size(102, 19)
        Me.lablmobno.TabIndex = 5
        Me.lablmobno.Text = "MOBILE NO"
        '
        'lblemal
        '
        Me.lblemal.AutoSize = True
        Me.lblemal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemal.Location = New System.Drawing.Point(36, 192)
        Me.lblemal.Name = "lblemal"
        Me.lblemal.Size = New System.Drawing.Size(83, 19)
        Me.lblemal.TabIndex = 4
        Me.lblemal.Text = "EMAIL ID"
        '
        'lblrepass
        '
        Me.lblrepass.AutoSize = True
        Me.lblrepass.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrepass.Location = New System.Drawing.Point(33, 158)
        Me.lblrepass.Name = "lblrepass"
        Me.lblrepass.Size = New System.Drawing.Size(124, 19)
        Me.lblrepass.TabIndex = 3
        Me.lblrepass.Text = "RE-PASSWORD"
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpass.Location = New System.Drawing.Point(34, 121)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(97, 19)
        Me.lblpass.TabIndex = 2
        Me.lblpass.Text = "PASSWORD"
        '
        'lbluname
        '
        Me.lbluname.AutoSize = True
        Me.lbluname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluname.Location = New System.Drawing.Point(34, 84)
        Me.lbluname.Name = "lbluname"
        Me.lbluname.Size = New System.Drawing.Size(100, 19)
        Me.lbluname.TabIndex = 1
        Me.lbluname.Text = "USERNAME"
        '
        'lblusreg
        '
        Me.lblusreg.AutoSize = True
        Me.lblusreg.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusreg.Location = New System.Drawing.Point(64, 13)
        Me.lblusreg.Name = "lblusreg"
        Me.lblusreg.Size = New System.Drawing.Size(210, 22)
        Me.lblusreg.TabIndex = 0
        Me.lblusreg.Text = "USER REGISTRATION"
        '
        'Usreg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.ClientSize = New System.Drawing.Size(410, 432)
        Me.Controls.Add(Me.usregpanel)
        Me.Name = "Usreg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usreg"
        Me.usregpanel.ResumeLayout(False)
        Me.usregpanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents usregpanel As Panel
    Friend WithEvents lblusreg As Label
    Friend WithEvents btnclear As Button
    Friend WithEvents btnreg As Button
    Friend WithEvents txtmobno As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txturepass As TextBox
    Friend WithEvents txtupass As TextBox
    Friend WithEvents txtuname As TextBox
    Friend WithEvents lablmobno As Label
    Friend WithEvents lblemal As Label
    Friend WithEvents lblrepass As Label
    Friend WithEvents lblpass As Label
    Friend WithEvents lbluname As Label
    Friend WithEvents llblallogin As LinkLabel
    Friend WithEvents txtusid As TextBox
    Friend WithEvents lbluserid As Label
    Friend WithEvents RDN As RadioButton
    Friend WithEvents RDS As RadioButton
    Friend WithEvents lblup As Label
End Class
