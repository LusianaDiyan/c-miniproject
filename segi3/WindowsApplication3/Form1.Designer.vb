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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelA = New System.Windows.Forms.Label()
        Me.LabelB = New System.Windows.Forms.Label()
        Me.LabelC = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Keliling = New System.Windows.Forms.Button()
        Me.Luas = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.reset = New System.Windows.Forms.Button()
        Me.quit = New System.Windows.Forms.Button()
        Me.tinggi = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kalkulator"
        '
        'LabelA
        '
        Me.LabelA.AutoSize = True
        Me.LabelA.Location = New System.Drawing.Point(9, 60)
        Me.LabelA.Name = "LabelA"
        Me.LabelA.Size = New System.Drawing.Size(30, 13)
        Me.LabelA.TabIndex = 1
        Me.LabelA.Text = "SisiA"
        '
        'LabelB
        '
        Me.LabelB.AutoSize = True
        Me.LabelB.Location = New System.Drawing.Point(10, 99)
        Me.LabelB.Name = "LabelB"
        Me.LabelB.Size = New System.Drawing.Size(30, 13)
        Me.LabelB.TabIndex = 2
        Me.LabelB.Text = "SisiB"
        '
        'LabelC
        '
        Me.LabelC.AutoSize = True
        Me.LabelC.Location = New System.Drawing.Point(10, 133)
        Me.LabelC.Name = "LabelC"
        Me.LabelC.Size = New System.Drawing.Size(30, 13)
        Me.LabelC.TabIndex = 3
        Me.LabelC.Text = "SisiC"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(66, 53)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(75, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(66, 92)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(75, 20)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(66, 126)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(75, 20)
        Me.TextBox3.TabIndex = 6
        '
        'Keliling
        '
        Me.Keliling.Location = New System.Drawing.Point(78, 207)
        Me.Keliling.Name = "Keliling"
        Me.Keliling.Size = New System.Drawing.Size(92, 24)
        Me.Keliling.TabIndex = 7
        Me.Keliling.Text = "Keliling"
        Me.Keliling.UseVisualStyleBackColor = True
        '
        'Luas
        '
        Me.Luas.Location = New System.Drawing.Point(78, 252)
        Me.Luas.Name = "Luas"
        Me.Luas.Size = New System.Drawing.Size(91, 25)
        Me.Luas.TabIndex = 8
        Me.Luas.Text = "Luas"
        Me.Luas.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(201, 52)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(39, 17)
        Me.RadioButton1.TabIndex = 9
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "cm"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(201, 75)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(33, 17)
        Me.RadioButton2.TabIndex = 10
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "m"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(201, 99)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(39, 17)
        Me.RadioButton3.TabIndex = 11
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "dm"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'reset
        '
        Me.reset.Location = New System.Drawing.Point(222, 207)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(79, 24)
        Me.reset.TabIndex = 12
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'quit
        '
        Me.quit.Location = New System.Drawing.Point(222, 252)
        Me.quit.Name = "quit"
        Me.quit.Size = New System.Drawing.Size(79, 23)
        Me.quit.TabIndex = 13
        Me.quit.Text = "Quit"
        Me.quit.UseVisualStyleBackColor = True
        '
        'tinggi
        '
        Me.tinggi.AutoSize = True
        Me.tinggi.Location = New System.Drawing.Point(10, 164)
        Me.tinggi.Name = "tinggi"
        Me.tinggi.Size = New System.Drawing.Size(32, 13)
        Me.tinggi.TabIndex = 14
        Me.tinggi.Text = "tinggi"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(66, 161)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(75, 20)
        Me.TextBox4.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 301)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.tinggi)
        Me.Controls.Add(Me.quit)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Luas)
        Me.Controls.Add(Me.Keliling)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LabelC)
        Me.Controls.Add(Me.LabelB)
        Me.Controls.Add(Me.LabelA)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelA As System.Windows.Forms.Label
    Friend WithEvents LabelB As System.Windows.Forms.Label
    Friend WithEvents LabelC As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Keliling As System.Windows.Forms.Button
    Friend WithEvents Luas As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents reset As System.Windows.Forms.Button
    Friend WithEvents quit As System.Windows.Forms.Button
    Friend WithEvents tinggi As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox

End Class
