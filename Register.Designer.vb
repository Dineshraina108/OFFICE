<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.lblreg = New System.Windows.Forms.Label()
        Me.txtrepass = New System.Windows.Forms.TextBox()
        Me.lblrepass = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.txtmobno = New System.Windows.Forms.TextBox()
        Me.lablmono = New System.Windows.Forms.Label()
        Me.btnsub = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.llblforgetpas = New System.Windows.Forms.LinkLabel()
        Me.txtuid = New System.Windows.Forms.TextBox()
        Me.lbluid = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(244, 139)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(100, 22)
        Me.txtpassword.TabIndex = 9
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassword.Location = New System.Drawing.Point(144, 141)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(69, 19)
        Me.lblpassword.TabIndex = 8
        Me.lblpassword.Text = "Password"
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(244, 100)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(100, 22)
        Me.txtusername.TabIndex = 7
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(144, 102)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(70, 19)
        Me.lblusername.TabIndex = 6
        Me.lblusername.Text = "Username"
        '
        'lblreg
        '
        Me.lblreg.AutoSize = True
        Me.lblreg.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreg.Location = New System.Drawing.Point(181, 21)
        Me.lblreg.Name = "lblreg"
        Me.lblreg.Size = New System.Drawing.Size(108, 22)
        Me.lblreg.TabIndex = 5
        Me.lblreg.Text = "REGISTER"
        '
        'txtrepass
        '
        Me.txtrepass.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrepass.Location = New System.Drawing.Point(245, 183)
        Me.txtrepass.Name = "txtrepass"
        Me.txtrepass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtrepass.Size = New System.Drawing.Size(100, 22)
        Me.txtrepass.TabIndex = 11
        '
        'lblrepass
        '
        Me.lblrepass.AutoSize = True
        Me.lblrepass.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrepass.Location = New System.Drawing.Point(144, 185)
        Me.lblrepass.Name = "lblrepass"
        Me.lblrepass.Size = New System.Drawing.Size(85, 19)
        Me.lblrepass.TabIndex = 10
        Me.lblrepass.Text = "Repassword"
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(245, 225)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(100, 22)
        Me.txtemail.TabIndex = 13
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.Location = New System.Drawing.Point(143, 227)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(57, 19)
        Me.lblemail.TabIndex = 12
        Me.lblemail.Text = "Email id"
        '
        'txtmobno
        '
        Me.txtmobno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmobno.Location = New System.Drawing.Point(245, 268)
        Me.txtmobno.Name = "txtmobno"
        Me.txtmobno.Size = New System.Drawing.Size(100, 22)
        Me.txtmobno.TabIndex = 15
        '
        'lablmono
        '
        Me.lablmono.AutoSize = True
        Me.lablmono.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lablmono.Location = New System.Drawing.Point(142, 270)
        Me.lablmono.Name = "lablmono"
        Me.lablmono.Size = New System.Drawing.Size(76, 19)
        Me.lablmono.TabIndex = 14
        Me.lablmono.Text = "Mobile No"
        '
        'btnsub
        '
        Me.btnsub.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsub.Location = New System.Drawing.Point(145, 342)
        Me.btnsub.Name = "btnsub"
        Me.btnsub.Size = New System.Drawing.Size(84, 23)
        Me.btnsub.TabIndex = 16
        Me.btnsub.Text = "SUBMIT"
        Me.btnsub.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(250, 343)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(86, 23)
        Me.btncancel.TabIndex = 17
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'llblforgetpas
        '
        Me.llblforgetpas.AutoSize = True
        Me.llblforgetpas.Location = New System.Drawing.Point(310, 307)
        Me.llblforgetpas.Name = "llblforgetpas"
        Me.llblforgetpas.Size = New System.Drawing.Size(111, 13)
        Me.llblforgetpas.TabIndex = 18
        Me.llblforgetpas.TabStop = True
        Me.llblforgetpas.Text = "Already have account"
        '
        'txtuid
        '
        Me.txtuid.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuid.Location = New System.Drawing.Point(244, 65)
        Me.txtuid.Name = "txtuid"
        Me.txtuid.Size = New System.Drawing.Size(100, 22)
        Me.txtuid.TabIndex = 20
        '
        'lbluid
        '
        Me.lbluid.AutoSize = True
        Me.lbluid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluid.Location = New System.Drawing.Point(144, 67)
        Me.lbluid.Name = "lbluid"
        Me.lbluid.Size = New System.Drawing.Size(53, 19)
        Me.lbluid.TabIndex = 19
        Me.lbluid.Text = "User id"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(466, 379)
        Me.Controls.Add(Me.txtuid)
        Me.Controls.Add(Me.lbluid)
        Me.Controls.Add(Me.llblforgetpas)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsub)
        Me.Controls.Add(Me.txtmobno)
        Me.Controls.Add(Me.lablmono)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.txtrepass)
        Me.Controls.Add(Me.lblrepass)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.lblreg)
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtpassword As TextBox
    Friend WithEvents lblpassword As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents lblusername As Label
    Friend WithEvents lblreg As Label
    Friend WithEvents txtrepass As TextBox
    Friend WithEvents lblrepass As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents lblemail As Label
    Friend WithEvents txtmobno As TextBox
    Friend WithEvents lablmono As Label
    Friend WithEvents btnsub As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents llblforgetpas As LinkLabel
    Friend WithEvents txtuid As TextBox
    Friend WithEvents lbluid As Label
End Class
