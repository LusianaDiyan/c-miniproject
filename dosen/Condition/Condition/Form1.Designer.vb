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
        Me.ComboBoxOpsi = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonProses = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonPria = New System.Windows.Forms.RadioButton()
        Me.RadioButtonWanita = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBoxOpsi
        '
        Me.ComboBoxOpsi.FormattingEnabled = True
        Me.ComboBoxOpsi.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.ComboBoxOpsi.Location = New System.Drawing.Point(118, 28)
        Me.ComboBoxOpsi.Name = "ComboBoxOpsi"
        Me.ComboBoxOpsi.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxOpsi.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Silahkan Pilih"
        '
        'ButtonProses
        '
        Me.ButtonProses.Location = New System.Drawing.Point(118, 155)
        Me.ButtonProses.Name = "ButtonProses"
        Me.ButtonProses.Size = New System.Drawing.Size(75, 23)
        Me.ButtonProses.TabIndex = 2
        Me.ButtonProses.Text = "PROSES"
        Me.ButtonProses.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonWanita)
        Me.GroupBox1.Controls.Add(Me.RadioButtonPria)
        Me.GroupBox1.Location = New System.Drawing.Point(118, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(121, 85)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jenis Kelamin"
        '
        'RadioButtonPria
        '
        Me.RadioButtonPria.AutoSize = True
        Me.RadioButtonPria.Location = New System.Drawing.Point(18, 28)
        Me.RadioButtonPria.Name = "RadioButtonPria"
        Me.RadioButtonPria.Size = New System.Drawing.Size(43, 17)
        Me.RadioButtonPria.TabIndex = 0
        Me.RadioButtonPria.TabStop = True
        Me.RadioButtonPria.Text = "Pria"
        Me.RadioButtonPria.UseVisualStyleBackColor = True
        '
        'RadioButtonWanita
        '
        Me.RadioButtonWanita.AutoSize = True
        Me.RadioButtonWanita.Location = New System.Drawing.Point(18, 51)
        Me.RadioButtonWanita.Name = "RadioButtonWanita"
        Me.RadioButtonWanita.Size = New System.Drawing.Size(59, 17)
        Me.RadioButtonWanita.TabIndex = 1
        Me.RadioButtonWanita.TabStop = True
        Me.RadioButtonWanita.Text = "Wanita"
        Me.RadioButtonWanita.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 381)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonProses)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxOpsi)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxOpsi As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonProses As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonWanita As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonPria As System.Windows.Forms.RadioButton

End Class
