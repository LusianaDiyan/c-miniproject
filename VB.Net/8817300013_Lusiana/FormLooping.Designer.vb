<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLooping
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
        Me.RichTextBoxLoop = New System.Windows.Forms.RichTextBox()
        Me.ButtonGanjil = New System.Windows.Forms.Button()
        Me.ButtonGenap = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RichTextBoxLoop
        '
        Me.RichTextBoxLoop.Location = New System.Drawing.Point(25, 24)
        Me.RichTextBoxLoop.Name = "RichTextBoxLoop"
        Me.RichTextBoxLoop.Size = New System.Drawing.Size(146, 296)
        Me.RichTextBoxLoop.TabIndex = 0
        Me.RichTextBoxLoop.Text = ""
        '
        'ButtonGanjil
        '
        Me.ButtonGanjil.Location = New System.Drawing.Point(248, 68)
        Me.ButtonGanjil.Name = "ButtonGanjil"
        Me.ButtonGanjil.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGanjil.TabIndex = 1
        Me.ButtonGanjil.Text = "GANJIL"
        Me.ButtonGanjil.UseVisualStyleBackColor = True
        '
        'ButtonGenap
        '
        Me.ButtonGenap.Location = New System.Drawing.Point(248, 127)
        Me.ButtonGenap.Name = "ButtonGenap"
        Me.ButtonGenap.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGenap.TabIndex = 2
        Me.ButtonGenap.Text = "GENAP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ButtonGenap.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(248, 197)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClear.TabIndex = 4
        Me.ButtonClear.Text = "CLEAR"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(248, 265)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonExit.TabIndex = 5
        Me.ButtonExit.Text = "EXIT"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'FormLooping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 349)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonGenap)
        Me.Controls.Add(Me.ButtonGanjil)
        Me.Controls.Add(Me.RichTextBoxLoop)
        Me.Name = "FormLooping"
        Me.Text = "FormLooping"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBoxLoop As System.Windows.Forms.RichTextBox
    Friend WithEvents ButtonGanjil As System.Windows.Forms.Button
    Friend WithEvents ButtonGenap As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
End Class
