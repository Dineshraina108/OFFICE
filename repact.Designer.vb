<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class repact
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
        Me.lblfromdate = New System.Windows.Forms.Label()
        Me.lbltodate = New System.Windows.Forms.Label()
        Me.dtfromdate = New System.Windows.Forms.DateTimePicker()
        Me.dttodate = New System.Windows.Forms.DateTimePicker()
        Me.btnsub = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblfromdate
        '
        Me.lblfromdate.AutoSize = True
        Me.lblfromdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfromdate.Location = New System.Drawing.Point(29, 60)
        Me.lblfromdate.Name = "lblfromdate"
        Me.lblfromdate.Size = New System.Drawing.Size(81, 19)
        Me.lblfromdate.TabIndex = 0
        Me.lblfromdate.Text = "From Date"
        '
        'lbltodate
        '
        Me.lbltodate.AutoSize = True
        Me.lbltodate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltodate.Location = New System.Drawing.Point(28, 100)
        Me.lbltodate.Name = "lbltodate"
        Me.lbltodate.Size = New System.Drawing.Size(63, 19)
        Me.lbltodate.TabIndex = 1
        Me.lbltodate.Text = "To Date"
        '
        'dtfromdate
        '
        Me.dtfromdate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfromdate.Location = New System.Drawing.Point(130, 58)
        Me.dtfromdate.Name = "dtfromdate"
        Me.dtfromdate.Size = New System.Drawing.Size(84, 22)
        Me.dtfromdate.TabIndex = 2
        '
        'dttodate
        '
        Me.dttodate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dttodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dttodate.Location = New System.Drawing.Point(129, 100)
        Me.dttodate.Name = "dttodate"
        Me.dttodate.Size = New System.Drawing.Size(84, 22)
        Me.dttodate.TabIndex = 3
        '
        'btnsub
        '
        Me.btnsub.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsub.Location = New System.Drawing.Point(48, 144)
        Me.btnsub.Name = "btnsub"
        Me.btnsub.Size = New System.Drawing.Size(85, 28)
        Me.btnsub.TabIndex = 4
        Me.btnsub.Text = "SUBMIT"
        Me.btnsub.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(148, 144)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(85, 28)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'repact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsub)
        Me.Controls.Add(Me.dttodate)
        Me.Controls.Add(Me.dtfromdate)
        Me.Controls.Add(Me.lbltodate)
        Me.Controls.Add(Me.lblfromdate)
        Me.DoubleBuffered = True
        Me.Name = "repact"
        Me.Text = "repact"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblfromdate As Label
    Friend WithEvents lbltodate As Label
    Friend WithEvents dtfromdate As DateTimePicker
    Friend WithEvents dttodate As DateTimePicker
    Friend WithEvents btnsub As Button
    Friend WithEvents btncancel As Button
End Class
