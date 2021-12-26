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
        Me.RichTextBoxLoop = New System.Windows.Forms.RichTextBox()
        Me.ButtonWhile = New System.Windows.Forms.Button()
        Me.Buttonexit = New System.Windows.Forms.Button()
        Me.ButtonFor = New System.Windows.Forms.Button()
        Me.ButtonForContinue = New System.Windows.Forms.Button()
        Me.ButtonDoWhile = New System.Windows.Forms.Button()
        Me.ButtonDoUntil = New System.Windows.Forms.Button()
        Me.ButtonDoWhileEnd = New System.Windows.Forms.Button()
        Me.ButtonDoUntilEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RichTextBoxLoop
        '
        Me.RichTextBoxLoop.Location = New System.Drawing.Point(35, 12)
        Me.RichTextBoxLoop.Name = "RichTextBoxLoop"
        Me.RichTextBoxLoop.Size = New System.Drawing.Size(730, 96)
        Me.RichTextBoxLoop.TabIndex = 0
        Me.RichTextBoxLoop.Text = ""
        '
        'ButtonWhile
        '
        Me.ButtonWhile.Location = New System.Drawing.Point(91, 130)
        Me.ButtonWhile.Name = "ButtonWhile"
        Me.ButtonWhile.Size = New System.Drawing.Size(75, 23)
        Me.ButtonWhile.TabIndex = 1
        Me.ButtonWhile.Text = "While"
        Me.ButtonWhile.UseVisualStyleBackColor = True
        '
        'Buttonexit
        '
        Me.Buttonexit.Location = New System.Drawing.Point(199, 130)
        Me.Buttonexit.Name = "Buttonexit"
        Me.Buttonexit.Size = New System.Drawing.Size(159, 23)
        Me.Buttonexit.TabIndex = 2
        Me.Buttonexit.Text = "While Continue/Exit"
        Me.Buttonexit.UseVisualStyleBackColor = True
        '
        'ButtonFor
        '
        Me.ButtonFor.Location = New System.Drawing.Point(91, 184)
        Me.ButtonFor.Name = "ButtonFor"
        Me.ButtonFor.Size = New System.Drawing.Size(75, 23)
        Me.ButtonFor.TabIndex = 3
        Me.ButtonFor.Text = "For"
        Me.ButtonFor.UseVisualStyleBackColor = True
        '
        'ButtonForContinue
        '
        Me.ButtonForContinue.Location = New System.Drawing.Point(199, 183)
        Me.ButtonForContinue.Name = "ButtonForContinue"
        Me.ButtonForContinue.Size = New System.Drawing.Size(159, 23)
        Me.ButtonForContinue.TabIndex = 4
        Me.ButtonForContinue.Text = "For Continue/Exit"
        Me.ButtonForContinue.UseVisualStyleBackColor = True
        '
        'ButtonDoWhile
        '
        Me.ButtonDoWhile.Location = New System.Drawing.Point(411, 130)
        Me.ButtonDoWhile.Name = "ButtonDoWhile"
        Me.ButtonDoWhile.Size = New System.Drawing.Size(102, 23)
        Me.ButtonDoWhile.TabIndex = 5
        Me.ButtonDoWhile.Text = "Do While First"
        Me.ButtonDoWhile.UseVisualStyleBackColor = True
        '
        'ButtonDoUntil
        '
        Me.ButtonDoUntil.Location = New System.Drawing.Point(556, 130)
        Me.ButtonDoUntil.Name = "ButtonDoUntil"
        Me.ButtonDoUntil.Size = New System.Drawing.Size(159, 23)
        Me.ButtonDoUntil.TabIndex = 6
        Me.ButtonDoUntil.Text = "Do Until Fisrt"
        Me.ButtonDoUntil.UseVisualStyleBackColor = True
        '
        'ButtonDoWhileEnd
        '
        Me.ButtonDoWhileEnd.Location = New System.Drawing.Point(411, 183)
        Me.ButtonDoWhileEnd.Name = "ButtonDoWhileEnd"
        Me.ButtonDoWhileEnd.Size = New System.Drawing.Size(102, 23)
        Me.ButtonDoWhileEnd.TabIndex = 7
        Me.ButtonDoWhileEnd.Text = "Do While End"
        Me.ButtonDoWhileEnd.UseVisualStyleBackColor = True
        '
        'ButtonDoUntilEnd
        '
        Me.ButtonDoUntilEnd.Location = New System.Drawing.Point(556, 184)
        Me.ButtonDoUntilEnd.Name = "ButtonDoUntilEnd"
        Me.ButtonDoUntilEnd.Size = New System.Drawing.Size(159, 23)
        Me.ButtonDoUntilEnd.TabIndex = 8
        Me.ButtonDoUntilEnd.Text = "Do Until End"
        Me.ButtonDoUntilEnd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 356)
        Me.Controls.Add(Me.ButtonDoUntilEnd)
        Me.Controls.Add(Me.ButtonDoWhileEnd)
        Me.Controls.Add(Me.ButtonDoUntil)
        Me.Controls.Add(Me.ButtonDoWhile)
        Me.Controls.Add(Me.ButtonForContinue)
        Me.Controls.Add(Me.ButtonFor)
        Me.Controls.Add(Me.Buttonexit)
        Me.Controls.Add(Me.ButtonWhile)
        Me.Controls.Add(Me.RichTextBoxLoop)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBoxLoop As System.Windows.Forms.RichTextBox
    Friend WithEvents ButtonWhile As System.Windows.Forms.Button
    Friend WithEvents Buttonexit As System.Windows.Forms.Button
    Friend WithEvents ButtonFor As System.Windows.Forms.Button
    Friend WithEvents ButtonForContinue As System.Windows.Forms.Button
    Friend WithEvents ButtonDoWhile As System.Windows.Forms.Button
    Friend WithEvents ButtonDoUntil As System.Windows.Forms.Button
    Friend WithEvents ButtonDoWhileEnd As System.Windows.Forms.Button
    Friend WithEvents ButtonDoUntilEnd As System.Windows.Forms.Button

End Class
