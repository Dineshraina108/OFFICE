<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Invaction
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
        Me.Rbcom = New System.Windows.Forms.RadioButton()
        Me.rbinv = New System.Windows.Forms.RadioButton()
        Me.rbinvdet = New System.Windows.Forms.RadioButton()
        Me.btncreate = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.lblcomid = New System.Windows.Forms.Label()
        Me.txtcomid = New System.Windows.Forms.TextBox()
        Me.txtinvno = New System.Windows.Forms.TextBox()
        Me.lblinvno = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Rbcom
        '
        Me.Rbcom.AutoSize = True
        Me.Rbcom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbcom.Location = New System.Drawing.Point(67, 45)
        Me.Rbcom.Name = "Rbcom"
        Me.Rbcom.Size = New System.Drawing.Size(133, 23)
        Me.Rbcom.TabIndex = 0
        Me.Rbcom.Text = "Add a Company"
        Me.Rbcom.UseVisualStyleBackColor = True
        '
        'rbinv
        '
        Me.rbinv.AutoSize = True
        Me.rbinv.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbinv.Location = New System.Drawing.Point(67, 84)
        Me.rbinv.Name = "rbinv"
        Me.rbinv.Size = New System.Drawing.Size(123, 23)
        Me.rbinv.TabIndex = 1
        Me.rbinv.Text = "Add a Iinvoice"
        Me.rbinv.UseVisualStyleBackColor = True
        '
        'rbinvdet
        '
        Me.rbinvdet.AutoSize = True
        Me.rbinvdet.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbinvdet.Location = New System.Drawing.Point(67, 119)
        Me.rbinvdet.Name = "rbinvdet"
        Me.rbinvdet.Size = New System.Drawing.Size(171, 23)
        Me.rbinvdet.TabIndex = 2
        Me.rbinvdet.Text = "Add a Invoice Details"
        Me.rbinvdet.UseVisualStyleBackColor = True
        '
        'btncreate
        '
        Me.btncreate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncreate.Location = New System.Drawing.Point(179, 164)
        Me.btncreate.Name = "btncreate"
        Me.btncreate.Size = New System.Drawing.Size(75, 25)
        Me.btncreate.TabIndex = 15
        Me.btncreate.Text = "Create"
        Me.btncreate.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(287, 164)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 25)
        Me.btncancel.TabIndex = 16
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'lblcomid
        '
        Me.lblcomid.AutoSize = True
        Me.lblcomid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcomid.Location = New System.Drawing.Point(253, 85)
        Me.lblcomid.Name = "lblcomid"
        Me.lblcomid.Size = New System.Drawing.Size(56, 16)
        Me.lblcomid.TabIndex = 17
        Me.lblcomid.Text = "COMID"
        '
        'txtcomid
        '
        Me.txtcomid.Location = New System.Drawing.Point(333, 83)
        Me.txtcomid.Name = "txtcomid"
        Me.txtcomid.Size = New System.Drawing.Size(100, 20)
        Me.txtcomid.TabIndex = 18
        '
        'txtinvno
        '
        Me.txtinvno.Location = New System.Drawing.Point(333, 120)
        Me.txtinvno.Name = "txtinvno"
        Me.txtinvno.Size = New System.Drawing.Size(100, 20)
        Me.txtinvno.TabIndex = 20
        '
        'lblinvno
        '
        Me.lblinvno.AutoSize = True
        Me.lblinvno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvno.Location = New System.Drawing.Point(252, 122)
        Me.lblinvno.Name = "lblinvno"
        Me.lblinvno.Size = New System.Drawing.Size(55, 16)
        Me.lblinvno.TabIndex = 19
        Me.lblinvno.Text = "INVNO"
        '
        'Invaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(498, 242)
        Me.Controls.Add(Me.txtinvno)
        Me.Controls.Add(Me.lblinvno)
        Me.Controls.Add(Me.txtcomid)
        Me.Controls.Add(Me.lblcomid)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btncreate)
        Me.Controls.Add(Me.rbinvdet)
        Me.Controls.Add(Me.rbinv)
        Me.Controls.Add(Me.Rbcom)
        Me.Name = "Invaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invaction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Rbcom As RadioButton
    Friend WithEvents rbinv As RadioButton
    Friend WithEvents rbinvdet As RadioButton
    Friend WithEvents btncreate As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents lblcomid As Label
    Friend WithEvents txtcomid As TextBox
    Friend WithEvents txtinvno As TextBox
    Friend WithEvents lblinvno As Label
End Class
