<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.RichTextBoxWhile = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.ButtonStop = New System.Windows.Forms.Button()
        Me.RichTextBoxDo = New System.Windows.Forms.RichTextBox()
        Me.ButtonWhile = New System.Windows.Forms.Button()
        Me.ButtonDo = New System.Windows.Forms.Button()
        Me.ButtonFor = New System.Windows.Forms.Button()
        Me.ButtonForEach = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RichTextBoxWhile
        '
        Me.RichTextBoxWhile.Location = New System.Drawing.Point(90, 27)
        Me.RichTextBoxWhile.Name = "RichTextBoxWhile"
        Me.RichTextBoxWhile.Size = New System.Drawing.Size(387, 61)
        Me.RichTextBoxWhile.TabIndex = 0
        Me.RichTextBoxWhile.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hasil Loop"
        '
        'ButtonStart
        '
        Me.ButtonStart.Location = New System.Drawing.Point(89, 316)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(75, 23)
        Me.ButtonStart.TabIndex = 2
        Me.ButtonStart.Text = "Start"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'ButtonStop
        '
        Me.ButtonStop.Location = New System.Drawing.Point(170, 316)
        Me.ButtonStop.Name = "ButtonStop"
        Me.ButtonStop.Size = New System.Drawing.Size(75, 23)
        Me.ButtonStop.TabIndex = 3
        Me.ButtonStop.Text = "Stop"
        Me.ButtonStop.UseVisualStyleBackColor = True
        '
        'RichTextBoxDo
        '
        Me.RichTextBoxDo.Location = New System.Drawing.Point(90, 94)
        Me.RichTextBoxDo.Name = "RichTextBoxDo"
        Me.RichTextBoxDo.Size = New System.Drawing.Size(387, 61)
        Me.RichTextBoxDo.TabIndex = 4
        Me.RichTextBoxDo.Text = ""
        '
        'ButtonWhile
        '
        Me.ButtonWhile.Location = New System.Drawing.Point(90, 286)
        Me.ButtonWhile.Name = "ButtonWhile"
        Me.ButtonWhile.Size = New System.Drawing.Size(75, 23)
        Me.ButtonWhile.TabIndex = 5
        Me.ButtonWhile.Text = "while"
        Me.ButtonWhile.UseVisualStyleBackColor = True
        '
        'ButtonDo
        '
        Me.ButtonDo.Location = New System.Drawing.Point(171, 286)
        Me.ButtonDo.Name = "ButtonDo"
        Me.ButtonDo.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDo.TabIndex = 6
        Me.ButtonDo.Text = "do"
        Me.ButtonDo.UseVisualStyleBackColor = True
        '
        'ButtonFor
        '
        Me.ButtonFor.Location = New System.Drawing.Point(252, 286)
        Me.ButtonFor.Name = "ButtonFor"
        Me.ButtonFor.Size = New System.Drawing.Size(75, 23)
        Me.ButtonFor.TabIndex = 7
        Me.ButtonFor.Text = "for"
        Me.ButtonFor.UseVisualStyleBackColor = True
        '
        'ButtonForEach
        '
        Me.ButtonForEach.Location = New System.Drawing.Point(333, 286)
        Me.ButtonForEach.Name = "ButtonForEach"
        Me.ButtonForEach.Size = New System.Drawing.Size(75, 23)
        Me.ButtonForEach.TabIndex = 8
        Me.ButtonForEach.Text = "for each"
        Me.ButtonForEach.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 375)
        Me.Controls.Add(Me.ButtonForEach)
        Me.Controls.Add(Me.ButtonFor)
        Me.Controls.Add(Me.ButtonDo)
        Me.Controls.Add(Me.ButtonWhile)
        Me.Controls.Add(Me.RichTextBoxDo)
        Me.Controls.Add(Me.ButtonStop)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBoxWhile)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBoxWhile As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonStart As System.Windows.Forms.Button
    Friend WithEvents ButtonStop As System.Windows.Forms.Button
    Friend WithEvents RichTextBoxDo As System.Windows.Forms.RichTextBox
    Friend WithEvents ButtonWhile As System.Windows.Forms.Button
    Friend WithEvents ButtonDo As System.Windows.Forms.Button
    Friend WithEvents ButtonFor As System.Windows.Forms.Button
    Friend WithEvents ButtonForEach As System.Windows.Forms.Button

End Class
