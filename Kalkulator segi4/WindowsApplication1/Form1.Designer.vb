<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculator))
        Me.SisiA = New System.Windows.Forms.Label()
        Me.SisiB = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Luas = New System.Windows.Forms.Button()
        Me.Keliling = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SisiA
        '
        Me.SisiA.AutoSize = True
        Me.SisiA.Location = New System.Drawing.Point(27, 80)
        Me.SisiA.Name = "SisiA"
        Me.SisiA.Size = New System.Drawing.Size(33, 13)
        Me.SisiA.TabIndex = 0
        Me.SisiA.Text = "Sisi A"
        '
        'SisiB
        '
        Me.SisiB.AutoSize = True
        Me.SisiB.Location = New System.Drawing.Point(27, 119)
        Me.SisiB.Name = "SisiB"
        Me.SisiB.Size = New System.Drawing.Size(33, 13)
        Me.SisiB.TabIndex = 1
        Me.SisiB.Text = "Sisi B"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(88, 73)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(102, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(88, 112)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(102, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Luas
        '
        Me.Luas.Location = New System.Drawing.Point(137, 167)
        Me.Luas.Name = "Luas"
        Me.Luas.Size = New System.Drawing.Size(93, 26)
        Me.Luas.TabIndex = 4
        Me.Luas.Text = "Luas"
        Me.Luas.UseVisualStyleBackColor = True
        '
        'Keliling
        '
        Me.Keliling.Location = New System.Drawing.Point(137, 215)
        Me.Keliling.Name = "Keliling"
        Me.Keliling.Size = New System.Drawing.Size(93, 25)
        Me.Keliling.TabIndex = 5
        Me.Keliling.Text = "Keliling"
        Me.Keliling.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Kalkulator Segi Empat"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(379, 336)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Keliling)
        Me.Controls.Add(Me.Luas)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SisiB)
        Me.Controls.Add(Me.SisiA)
        Me.Name = "Calculator"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SisiA As System.Windows.Forms.Label
    Friend WithEvents SisiB As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Luas As System.Windows.Forms.Button
    Friend WithEvents Keliling As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
