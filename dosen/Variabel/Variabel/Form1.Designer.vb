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
        Me.ButtonIPK = New System.Windows.Forms.Button()
        Me.ButtonProsedur = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.TextBoxUsia = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtonIPK
        '
        Me.ButtonIPK.Location = New System.Drawing.Point(117, 98)
        Me.ButtonIPK.Name = "ButtonIPK"
        Me.ButtonIPK.Size = New System.Drawing.Size(89, 23)
        Me.ButtonIPK.TabIndex = 0
        Me.ButtonIPK.Text = "IPK"
        Me.ButtonIPK.UseVisualStyleBackColor = True
        '
        'ButtonProsedur
        '
        Me.ButtonProsedur.Location = New System.Drawing.Point(117, 127)
        Me.ButtonProsedur.Name = "ButtonProsedur"
        Me.ButtonProsedur.Size = New System.Drawing.Size(89, 23)
        Me.ButtonProsedur.TabIndex = 1
        Me.ButtonProsedur.Text = "PROCEDURE"
        Me.ButtonProsedur.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Usia"
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(86, 28)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(120, 20)
        Me.TextBoxNama.TabIndex = 4
        '
        'TextBoxUsia
        '
        Me.TextBoxUsia.Location = New System.Drawing.Point(86, 58)
        Me.TextBoxUsia.Name = "TextBoxUsia"
        Me.TextBoxUsia.Size = New System.Drawing.Size(120, 20)
        Me.TextBoxUsia.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 414)
        Me.Controls.Add(Me.TextBoxUsia)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonProsedur)
        Me.Controls.Add(Me.ButtonIPK)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonIPK As System.Windows.Forms.Button
    Friend WithEvents ButtonProsedur As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNama As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUsia As System.Windows.Forms.TextBox

End Class
