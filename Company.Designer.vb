<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Company
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
        Me.delpanel = New System.Windows.Forms.Panel()
        Me.cmbdeldid = New System.Windows.Forms.ComboBox()
        Me.lbldeetid = New System.Windows.Forms.Label()
        Me.btndlcan = New System.Windows.Forms.Button()
        Me.btndsub = New System.Windows.Forms.Button()
        Me.cmbdelin = New System.Windows.Forms.ComboBox()
        Me.lbldelin = New System.Windows.Forms.Label()
        Me.cmbdelcom = New System.Windows.Forms.ComboBox()
        Me.lbldcom = New System.Windows.Forms.Label()
        Me.selpanel = New System.Windows.Forms.Panel()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsub = New System.Windows.Forms.Button()
        Me.cbinvno = New System.Windows.Forms.ComboBox()
        Me.lblinvno = New System.Windows.Forms.Label()
        Me.Cbcomp = New System.Windows.Forms.ComboBox()
        Me.lblcomp = New System.Windows.Forms.Label()
        Me.reppanel = New System.Windows.Forms.Panel()
        Me.btnrepcan = New System.Windows.Forms.Button()
        Me.btnrepsub = New System.Windows.Forms.Button()
        Me.repcmbinv = New System.Windows.Forms.ComboBox()
        Me.lblrepinv = New System.Windows.Forms.Label()
        Me.repcmbcom = New System.Windows.Forms.ComboBox()
        Me.lblrecom = New System.Windows.Forms.Label()
        Me.delpanel.SuspendLayout()
        Me.selpanel.SuspendLayout()
        Me.reppanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'delpanel
        '
        Me.delpanel.Controls.Add(Me.cmbdeldid)
        Me.delpanel.Controls.Add(Me.lbldeetid)
        Me.delpanel.Controls.Add(Me.btndlcan)
        Me.delpanel.Controls.Add(Me.btndsub)
        Me.delpanel.Controls.Add(Me.cmbdelin)
        Me.delpanel.Controls.Add(Me.lbldelin)
        Me.delpanel.Controls.Add(Me.cmbdelcom)
        Me.delpanel.Controls.Add(Me.lbldcom)
        Me.delpanel.Location = New System.Drawing.Point(177, 241)
        Me.delpanel.Name = "delpanel"
        Me.delpanel.Size = New System.Drawing.Size(277, 231)
        Me.delpanel.TabIndex = 19
        '
        'cmbdeldid
        '
        Me.cmbdeldid.FormattingEnabled = True
        Me.cmbdeldid.Location = New System.Drawing.Point(117, 124)
        Me.cmbdeldid.Name = "cmbdeldid"
        Me.cmbdeldid.Size = New System.Drawing.Size(121, 21)
        Me.cmbdeldid.TabIndex = 46
        '
        'lbldeetid
        '
        Me.lbldeetid.AutoSize = True
        Me.lbldeetid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldeetid.Location = New System.Drawing.Point(26, 125)
        Me.lbldeetid.Name = "lbldeetid"
        Me.lbldeetid.Size = New System.Drawing.Size(50, 19)
        Me.lbldeetid.TabIndex = 45
        Me.lbldeetid.Text = "Det id"
        '
        'btndlcan
        '
        Me.btndlcan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndlcan.Location = New System.Drawing.Point(149, 183)
        Me.btndlcan.Name = "btndlcan"
        Me.btndlcan.Size = New System.Drawing.Size(75, 25)
        Me.btndlcan.TabIndex = 24
        Me.btndlcan.Text = "Cancel"
        Me.btndlcan.UseVisualStyleBackColor = True
        '
        'btndsub
        '
        Me.btndsub.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndsub.Location = New System.Drawing.Point(41, 183)
        Me.btndsub.Name = "btndsub"
        Me.btndsub.Size = New System.Drawing.Size(75, 25)
        Me.btndsub.TabIndex = 23
        Me.btndsub.Text = "Submit"
        Me.btndsub.UseVisualStyleBackColor = True
        '
        'cmbdelin
        '
        Me.cmbdelin.FormattingEnabled = True
        Me.cmbdelin.Location = New System.Drawing.Point(117, 75)
        Me.cmbdelin.Name = "cmbdelin"
        Me.cmbdelin.Size = New System.Drawing.Size(121, 21)
        Me.cmbdelin.TabIndex = 22
        '
        'lbldelin
        '
        Me.lbldelin.AutoSize = True
        Me.lbldelin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldelin.Location = New System.Drawing.Point(22, 78)
        Me.lbldelin.Name = "lbldelin"
        Me.lbldelin.Size = New System.Drawing.Size(82, 19)
        Me.lbldelin.TabIndex = 21
        Me.lbldelin.Text = "Invoice No"
        '
        'cmbdelcom
        '
        Me.cmbdelcom.FormattingEnabled = True
        Me.cmbdelcom.Location = New System.Drawing.Point(119, 23)
        Me.cmbdelcom.Name = "cmbdelcom"
        Me.cmbdelcom.Size = New System.Drawing.Size(121, 21)
        Me.cmbdelcom.TabIndex = 20
        '
        'lbldcom
        '
        Me.lbldcom.AutoSize = True
        Me.lbldcom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldcom.Location = New System.Drawing.Point(24, 26)
        Me.lbldcom.Name = "lbldcom"
        Me.lbldcom.Size = New System.Drawing.Size(72, 19)
        Me.lbldcom.TabIndex = 19
        Me.lbldcom.Text = "Company"
        '
        'selpanel
        '
        Me.selpanel.Controls.Add(Me.btncancel)
        Me.selpanel.Controls.Add(Me.btnsub)
        Me.selpanel.Controls.Add(Me.cbinvno)
        Me.selpanel.Controls.Add(Me.lblinvno)
        Me.selpanel.Controls.Add(Me.Cbcomp)
        Me.selpanel.Controls.Add(Me.lblcomp)
        Me.selpanel.Location = New System.Drawing.Point(18, 39)
        Me.selpanel.Name = "selpanel"
        Me.selpanel.Size = New System.Drawing.Size(277, 182)
        Me.selpanel.TabIndex = 20
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(156, 136)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 25)
        Me.btncancel.TabIndex = 24
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsub
        '
        Me.btnsub.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsub.Location = New System.Drawing.Point(48, 136)
        Me.btnsub.Name = "btnsub"
        Me.btnsub.Size = New System.Drawing.Size(75, 25)
        Me.btnsub.TabIndex = 23
        Me.btnsub.Text = "Submit"
        Me.btnsub.UseVisualStyleBackColor = True
        '
        'cbinvno
        '
        Me.cbinvno.FormattingEnabled = True
        Me.cbinvno.Location = New System.Drawing.Point(124, 74)
        Me.cbinvno.Name = "cbinvno"
        Me.cbinvno.Size = New System.Drawing.Size(121, 21)
        Me.cbinvno.TabIndex = 22
        '
        'lblinvno
        '
        Me.lblinvno.AutoSize = True
        Me.lblinvno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvno.Location = New System.Drawing.Point(29, 77)
        Me.lblinvno.Name = "lblinvno"
        Me.lblinvno.Size = New System.Drawing.Size(82, 19)
        Me.lblinvno.TabIndex = 21
        Me.lblinvno.Text = "Invoice No"
        '
        'Cbcomp
        '
        Me.Cbcomp.FormattingEnabled = True
        Me.Cbcomp.Location = New System.Drawing.Point(126, 22)
        Me.Cbcomp.Name = "Cbcomp"
        Me.Cbcomp.Size = New System.Drawing.Size(121, 21)
        Me.Cbcomp.TabIndex = 20
        '
        'lblcomp
        '
        Me.lblcomp.AutoSize = True
        Me.lblcomp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcomp.Location = New System.Drawing.Point(31, 25)
        Me.lblcomp.Name = "lblcomp"
        Me.lblcomp.Size = New System.Drawing.Size(72, 19)
        Me.lblcomp.TabIndex = 19
        Me.lblcomp.Text = "Company"
        '
        'reppanel
        '
        Me.reppanel.Controls.Add(Me.btnrepcan)
        Me.reppanel.Controls.Add(Me.btnrepsub)
        Me.reppanel.Controls.Add(Me.repcmbinv)
        Me.reppanel.Controls.Add(Me.lblrepinv)
        Me.reppanel.Controls.Add(Me.repcmbcom)
        Me.reppanel.Controls.Add(Me.lblrecom)
        Me.reppanel.Location = New System.Drawing.Point(316, 39)
        Me.reppanel.Name = "reppanel"
        Me.reppanel.Size = New System.Drawing.Size(277, 182)
        Me.reppanel.TabIndex = 21
        '
        'btnrepcan
        '
        Me.btnrepcan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrepcan.Location = New System.Drawing.Point(156, 136)
        Me.btnrepcan.Name = "btnrepcan"
        Me.btnrepcan.Size = New System.Drawing.Size(75, 25)
        Me.btnrepcan.TabIndex = 24
        Me.btnrepcan.Text = "Cancel"
        Me.btnrepcan.UseVisualStyleBackColor = True
        '
        'btnrepsub
        '
        Me.btnrepsub.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrepsub.Location = New System.Drawing.Point(48, 136)
        Me.btnrepsub.Name = "btnrepsub"
        Me.btnrepsub.Size = New System.Drawing.Size(75, 25)
        Me.btnrepsub.TabIndex = 23
        Me.btnrepsub.Text = "Submit"
        Me.btnrepsub.UseVisualStyleBackColor = True
        '
        'repcmbinv
        '
        Me.repcmbinv.FormattingEnabled = True
        Me.repcmbinv.Location = New System.Drawing.Point(124, 74)
        Me.repcmbinv.Name = "repcmbinv"
        Me.repcmbinv.Size = New System.Drawing.Size(121, 21)
        Me.repcmbinv.TabIndex = 22
        '
        'lblrepinv
        '
        Me.lblrepinv.AutoSize = True
        Me.lblrepinv.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrepinv.Location = New System.Drawing.Point(29, 77)
        Me.lblrepinv.Name = "lblrepinv"
        Me.lblrepinv.Size = New System.Drawing.Size(82, 19)
        Me.lblrepinv.TabIndex = 21
        Me.lblrepinv.Text = "Invoice No"
        '
        'repcmbcom
        '
        Me.repcmbcom.FormattingEnabled = True
        Me.repcmbcom.Location = New System.Drawing.Point(126, 22)
        Me.repcmbcom.Name = "repcmbcom"
        Me.repcmbcom.Size = New System.Drawing.Size(121, 21)
        Me.repcmbcom.TabIndex = 20
        '
        'lblrecom
        '
        Me.lblrecom.AutoSize = True
        Me.lblrecom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrecom.Location = New System.Drawing.Point(31, 25)
        Me.lblrecom.Name = "lblrecom"
        Me.lblrecom.Size = New System.Drawing.Size(72, 19)
        Me.lblrecom.TabIndex = 19
        Me.lblrecom.Text = "Company"
        '
        'Company
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(605, 505)
        Me.Controls.Add(Me.reppanel)
        Me.Controls.Add(Me.selpanel)
        Me.Controls.Add(Me.delpanel)
        Me.Name = "Company"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Company"
        Me.delpanel.ResumeLayout(False)
        Me.delpanel.PerformLayout()
        Me.selpanel.ResumeLayout(False)
        Me.selpanel.PerformLayout()
        Me.reppanel.ResumeLayout(False)
        Me.reppanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents delpanel As Panel
    Friend WithEvents btndlcan As Button
    Friend WithEvents btndsub As Button
    Friend WithEvents cmbdelin As ComboBox
    Friend WithEvents lbldelin As Label
    Friend WithEvents cmbdelcom As ComboBox
    Friend WithEvents lbldcom As Label
    Friend WithEvents selpanel As Panel
    Friend WithEvents btncancel As Button
    Friend WithEvents btnsub As Button
    Friend WithEvents cbinvno As ComboBox
    Friend WithEvents lblinvno As Label
    Friend WithEvents Cbcomp As ComboBox
    Friend WithEvents lblcomp As Label
    Friend WithEvents cmbdeldid As ComboBox
    Friend WithEvents lbldeetid As Label
    Friend WithEvents reppanel As Panel
    Friend WithEvents btnrepcan As Button
    Friend WithEvents btnrepsub As Button
    Friend WithEvents repcmbinv As ComboBox
    Friend WithEvents lblrepinv As Label
    Friend WithEvents repcmbcom As ComboBox
    Friend WithEvents lblrecom As Label
End Class
