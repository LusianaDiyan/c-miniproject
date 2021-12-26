<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSegi4
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxPanjang = New System.Windows.Forms.TextBox()
        Me.TextBoxLebar = New System.Windows.Forms.TextBox()
        Me.ButtonProses = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxLuas = New System.Windows.Forms.TextBox()
        Me.TextBoxKeliling = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kalkulator Segi Empat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Panjang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Lebar"
        '
        'TextBoxPanjang
        '
        Me.TextBoxPanjang.Location = New System.Drawing.Point(126, 78)
        Me.TextBoxPanjang.Name = "TextBoxPanjang"
        Me.TextBoxPanjang.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPanjang.TabIndex = 3
        '
        'TextBoxLebar
        '
        Me.TextBoxLebar.Location = New System.Drawing.Point(126, 130)
        Me.TextBoxLebar.Name = "TextBoxLebar"
        Me.TextBoxLebar.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxLebar.TabIndex = 4
        '
        'ButtonProses
        '
        Me.ButtonProses.Location = New System.Drawing.Point(92, 171)
        Me.ButtonProses.Name = "ButtonProses"
        Me.ButtonProses.Size = New System.Drawing.Size(75, 23)
        Me.ButtonProses.TabIndex = 5
        Me.ButtonProses.Text = "HITUNG"
        Me.ButtonProses.UseVisualStyleBackColor = True
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(151, 315)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHapus.TabIndex = 6
        Me.ButtonHapus.Text = "HAPUS"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(25, 315)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonExit.TabIndex = 7
        Me.ButtonExit.Text = "EXIT"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Luas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Keliling"
        '
        'TextBoxLuas
        '
        Me.TextBoxLuas.Location = New System.Drawing.Point(126, 216)
        Me.TextBoxLuas.Name = "TextBoxLuas"
        Me.TextBoxLuas.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxLuas.TabIndex = 10
        '
        'TextBoxKeliling
        '
        Me.TextBoxKeliling.Location = New System.Drawing.Point(126, 262)
        Me.TextBoxKeliling.Name = "TextBoxKeliling"
        Me.TextBoxKeliling.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxKeliling.TabIndex = 11
        '
        'FormSegi4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 364)
        Me.Controls.Add(Me.TextBoxKeliling)
        Me.Controls.Add(Me.TextBoxLuas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.ButtonProses)
        Me.Controls.Add(Me.TextBoxLebar)
        Me.Controls.Add(Me.TextBoxPanjang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormSegi4"
        Me.Text = "Form Segi Empat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPanjang As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLebar As System.Windows.Forms.TextBox
    Friend WithEvents ButtonProses As System.Windows.Forms.Button
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxLuas As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxKeliling As System.Windows.Forms.TextBox

End Class
