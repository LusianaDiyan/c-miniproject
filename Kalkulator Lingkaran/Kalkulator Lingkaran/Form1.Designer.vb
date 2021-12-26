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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxJari = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxluas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxkeliling = New System.Windows.Forms.TextBox()
        Me.ButtonProses = New System.Windows.Forms.Button()
        Me.ButtonHAPUS = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Ravie", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(17, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KALKULATOR LINGKARAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jari-jari"
        '
        'TextBoxJari
        '
        Me.TextBoxJari.Location = New System.Drawing.Point(106, 68)
        Me.TextBoxJari.Name = "TextBoxJari"
        Me.TextBoxJari.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxJari.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Luas"
        '
        'TextBoxluas
        '
        Me.TextBoxluas.Location = New System.Drawing.Point(106, 102)
        Me.TextBoxluas.Name = "TextBoxluas"
        Me.TextBoxluas.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxluas.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Keliling"
        '
        'TextBoxkeliling
        '
        Me.TextBoxkeliling.Location = New System.Drawing.Point(106, 139)
        Me.TextBoxkeliling.Name = "TextBoxkeliling"
        Me.TextBoxkeliling.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxkeliling.TabIndex = 6
        '
        'ButtonProses
        '
        Me.ButtonProses.Location = New System.Drawing.Point(41, 227)
        Me.ButtonProses.Name = "ButtonProses"
        Me.ButtonProses.Size = New System.Drawing.Size(75, 23)
        Me.ButtonProses.TabIndex = 7
        Me.ButtonProses.Text = "PROSES"
        Me.ButtonProses.UseVisualStyleBackColor = True
        '
        'ButtonHAPUS
        '
        Me.ButtonHAPUS.Location = New System.Drawing.Point(162, 227)
        Me.ButtonHAPUS.Name = "ButtonHAPUS"
        Me.ButtonHAPUS.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHAPUS.TabIndex = 8
        Me.ButtonHAPUS.Text = "HAPUS"
        Me.ButtonHAPUS.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(268, 226)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonExit.TabIndex = 9
        Me.ButtonExit.Text = "EXIT"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(411, 301)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonHAPUS)
        Me.Controls.Add(Me.ButtonProses)
        Me.Controls.Add(Me.TextBoxkeliling)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxluas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxJari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxJari As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxluas As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxkeliling As System.Windows.Forms.TextBox
    Friend WithEvents ButtonProses As System.Windows.Forms.Button
    Friend WithEvents ButtonHAPUS As System.Windows.Forms.Button
    Friend WithEvents ButtonExit As System.Windows.Forms.Button

End Class
