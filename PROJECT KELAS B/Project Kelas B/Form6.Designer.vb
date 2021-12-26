<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMasukkanNilai = New System.Windows.Forms.TextBox()
        Me.rbFtoC = New System.Windows.Forms.RadioButton()
        Me.rbCtoF = New System.Windows.Forms.RadioButton()
        Me.btnKonvert = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SandyBrown
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-4, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Konverter Suhu"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Masukkan Nilai"
        '
        'txtMasukkanNilai
        '
        Me.txtMasukkanNilai.Location = New System.Drawing.Point(122, 78)
        Me.txtMasukkanNilai.Name = "txtMasukkanNilai"
        Me.txtMasukkanNilai.Size = New System.Drawing.Size(100, 20)
        Me.txtMasukkanNilai.TabIndex = 2
        '
        'rbFtoC
        '
        Me.rbFtoC.AutoSize = True
        Me.rbFtoC.Location = New System.Drawing.Point(122, 104)
        Me.rbFtoC.Name = "rbFtoC"
        Me.rbFtoC.Size = New System.Drawing.Size(53, 17)
        Me.rbFtoC.TabIndex = 3
        Me.rbFtoC.TabStop = True
        Me.rbFtoC.Text = "F to C"
        Me.rbFtoC.UseVisualStyleBackColor = True
        '
        'rbCtoF
        '
        Me.rbCtoF.AutoSize = True
        Me.rbCtoF.Location = New System.Drawing.Point(181, 104)
        Me.rbCtoF.Name = "rbCtoF"
        Me.rbCtoF.Size = New System.Drawing.Size(53, 17)
        Me.rbCtoF.TabIndex = 4
        Me.rbCtoF.TabStop = True
        Me.rbCtoF.Text = "C to F"
        Me.rbCtoF.UseVisualStyleBackColor = True
        '
        'btnKonvert
        '
        Me.btnKonvert.Location = New System.Drawing.Point(97, 145)
        Me.btnKonvert.Name = "btnKonvert"
        Me.btnKonvert.Size = New System.Drawing.Size(148, 30)
        Me.btnKonvert.TabIndex = 5
        Me.btnKonvert.Text = "Konvert"
        Me.btnKonvert.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightCoral
        Me.Label3.Location = New System.Drawing.Point(64, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 54)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Hasil"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 262)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnKonvert)
        Me.Controls.Add(Me.rbCtoF)
        Me.Controls.Add(Me.rbFtoC)
        Me.Controls.Add(Me.txtMasukkanNilai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMasukkanNilai As System.Windows.Forms.TextBox
    Friend WithEvents rbFtoC As System.Windows.Forms.RadioButton
    Friend WithEvents rbCtoF As System.Windows.Forms.RadioButton
    Friend WithEvents btnKonvert As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
