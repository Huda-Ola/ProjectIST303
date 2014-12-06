<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RanchServicesForm
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(28, 126)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 45)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Massage"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 45)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Trail Riding"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(164, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 45)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Guided Hiking"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(164, 126)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(92, 45)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Lassoing Classes"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'RanchServicesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 211)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Name = "RanchServicesForm"
        Me.Text = "Ranch Services"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
