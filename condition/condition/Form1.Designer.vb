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
        Me.ComboBoxAnswer = New System.Windows.Forms.ComboBox()
        Me.Answer = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelPilihan = New System.Windows.Forms.Label()
        Me.NumericUpDownUsia = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Pria = New System.Windows.Forms.RadioButton()
        Me.Wanita = New System.Windows.Forms.RadioButton()
        CType(Me.NumericUpDownUsia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBoxAnswer
        '
        Me.ComboBoxAnswer.FormattingEnabled = True
        Me.ComboBoxAnswer.Items.AddRange(New Object() {"A.", "B.", "C.", "D.", "E."})
        Me.ComboBoxAnswer.Location = New System.Drawing.Point(157, 53)
        Me.ComboBoxAnswer.Name = "ComboBoxAnswer"
        Me.ComboBoxAnswer.Size = New System.Drawing.Size(120, 21)
        Me.ComboBoxAnswer.TabIndex = 0
        '
        'Answer
        '
        Me.Answer.AutoSize = True
        Me.Answer.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Answer.Location = New System.Drawing.Point(59, 56)
        Me.Answer.Name = "Answer"
        Me.Answer.Size = New System.Drawing.Size(92, 18)
        Me.Answer.TabIndex = 1
        Me.Answer.Text = "Pilih Jawaban"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(157, 331)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelPilihan
        '
        Me.LabelPilihan.AutoSize = True
        Me.LabelPilihan.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPilihan.Location = New System.Drawing.Point(59, 91)
        Me.LabelPilihan.Name = "LabelPilihan"
        Me.LabelPilihan.Size = New System.Drawing.Size(70, 18)
        Me.LabelPilihan.TabIndex = 3
        Me.LabelPilihan.Text = "Usia Anda"
        '
        'NumericUpDownUsia
        '
        Me.NumericUpDownUsia.Location = New System.Drawing.Point(157, 92)
        Me.NumericUpDownUsia.Name = "NumericUpDownUsia"
        Me.NumericUpDownUsia.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownUsia.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Wanita)
        Me.GroupBox1.Controls.Add(Me.Pria)
        Me.GroupBox1.Font = New System.Drawing.Font("Stencil", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(157, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 99)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jenis Kelamin"
        '
        'Pria
        '
        Me.Pria.AutoSize = True
        Me.Pria.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pria.Location = New System.Drawing.Point(20, 13)
        Me.Pria.Name = "Pria"
        Me.Pria.Size = New System.Drawing.Size(52, 24)
        Me.Pria.TabIndex = 0
        Me.Pria.TabStop = True
        Me.Pria.Text = "Pria"
        Me.Pria.UseVisualStyleBackColor = True
        '
        'Wanita
        '
        Me.Wanita.AutoSize = True
        Me.Wanita.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wanita.Location = New System.Drawing.Point(20, 39)
        Me.Wanita.Name = "Wanita"
        Me.Wanita.Size = New System.Drawing.Size(76, 24)
        Me.Wanita.TabIndex = 1
        Me.Wanita.TabStop = True
        Me.Wanita.Text = "Wanita"
        Me.Wanita.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 391)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.NumericUpDownUsia)
        Me.Controls.Add(Me.LabelPilihan)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Answer)
        Me.Controls.Add(Me.ComboBoxAnswer)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.NumericUpDownUsia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxAnswer As System.Windows.Forms.ComboBox
    Friend WithEvents Answer As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LabelPilihan As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownUsia As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Wanita As System.Windows.Forms.RadioButton
    Friend WithEvents Pria As System.Windows.Forms.RadioButton

End Class
