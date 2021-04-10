<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class repview
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
        Me.txtrep = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtrep
        '
        Me.txtrep.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtrep.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtrep.Location = New System.Drawing.Point(30, 21)
        Me.txtrep.Multiline = True
        Me.txtrep.Name = "txtrep"
        Me.txtrep.ReadOnly = True
        Me.txtrep.Size = New System.Drawing.Size(809, 438)
        Me.txtrep.TabIndex = 1
        '
        'repview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(867, 482)
        Me.Controls.Add(Me.txtrep)
        Me.Name = "repview"
        Me.Text = "repview"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtrep As TextBox
End Class
