<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rule_choice
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
        Me.New_rb = New System.Windows.Forms.RadioButton()
        Me.Edit_rb = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'New_rb
        '
        Me.New_rb.AutoSize = True
        Me.New_rb.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.New_rb.Location = New System.Drawing.Point(88, 18)
        Me.New_rb.Name = "New_rb"
        Me.New_rb.Size = New System.Drawing.Size(140, 33)
        Me.New_rb.TabIndex = 0
        Me.New_rb.TabStop = True
        Me.New_rb.Text = "New Rule"
        Me.New_rb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.New_rb.UseVisualStyleBackColor = True
        '
        'Edit_rb
        '
        Me.Edit_rb.AutoSize = True
        Me.Edit_rb.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit_rb.Location = New System.Drawing.Point(88, 57)
        Me.Edit_rb.Name = "Edit_rb"
        Me.Edit_rb.Size = New System.Drawing.Size(132, 33)
        Me.Edit_rb.TabIndex = 1
        Me.Edit_rb.TabStop = True
        Me.Edit_rb.Text = "Edit Rule"
        Me.Edit_rb.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(68, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 91)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Select"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Rule_choice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 243)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Edit_rb)
        Me.Controls.Add(Me.New_rb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Rule_choice"
        Me.Text = "Snort Rule Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents New_rb As System.Windows.Forms.RadioButton
    Friend WithEvents Edit_rb As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
