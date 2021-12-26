<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.TxtNoInduk = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.RbPria = New System.Windows.Forms.RadioButton()
        Me.RbWanita = New System.Windows.Forms.RadioButton()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbMembaca = New System.Windows.Forms.CheckBox()
        Me.CbOlahraga = New System.Windows.Forms.CheckBox()
        Me.CbTidurSiang = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NO. INDUK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAMA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "JENIS KELAMIN"
        '
        'TxtNoInduk
        '
        Me.TxtNoInduk.Location = New System.Drawing.Point(117, 5)
        Me.TxtNoInduk.Name = "TxtNoInduk"
        Me.TxtNoInduk.Size = New System.Drawing.Size(155, 20)
        Me.TxtNoInduk.TabIndex = 3
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(117, 33)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(155, 20)
        Me.TxtNama.TabIndex = 4
        '
        'RbPria
        '
        Me.RbPria.AutoSize = True
        Me.RbPria.Location = New System.Drawing.Point(6, 19)
        Me.RbPria.Name = "RbPria"
        Me.RbPria.Size = New System.Drawing.Size(43, 17)
        Me.RbPria.TabIndex = 5
        Me.RbPria.TabStop = True
        Me.RbPria.Text = "Pria"
        Me.RbPria.UseVisualStyleBackColor = True
        '
        'RbWanita
        '
        Me.RbWanita.AutoSize = True
        Me.RbWanita.Location = New System.Drawing.Point(55, 19)
        Me.RbWanita.Name = "RbWanita"
        Me.RbWanita.Size = New System.Drawing.Size(59, 17)
        Me.RbWanita.TabIndex = 6
        Me.RbWanita.TabStop = True
        Me.RbWanita.Text = "Wanita"
        Me.RbWanita.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(197, 226)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(75, 23)
        Me.BtnOK.TabIndex = 7
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "HOBI"
        '
        'CbMembaca
        '
        Me.CbMembaca.AutoSize = True
        Me.CbMembaca.Location = New System.Drawing.Point(114, 125)
        Me.CbMembaca.Name = "CbMembaca"
        Me.CbMembaca.Size = New System.Drawing.Size(73, 17)
        Me.CbMembaca.TabIndex = 9
        Me.CbMembaca.Text = "Membaca"
        Me.CbMembaca.UseVisualStyleBackColor = True
        '
        'CbOlahraga
        '
        Me.CbOlahraga.AutoSize = True
        Me.CbOlahraga.Location = New System.Drawing.Point(114, 149)
        Me.CbOlahraga.Name = "CbOlahraga"
        Me.CbOlahraga.Size = New System.Drawing.Size(77, 17)
        Me.CbOlahraga.TabIndex = 10
        Me.CbOlahraga.Text = "Olah Raga"
        Me.CbOlahraga.UseVisualStyleBackColor = True
        '
        'CbTidurSiang
        '
        Me.CbTidurSiang.AutoSize = True
        Me.CbTidurSiang.Location = New System.Drawing.Point(114, 173)
        Me.CbTidurSiang.Name = "CbTidurSiang"
        Me.CbTidurSiang.Size = New System.Drawing.Size(80, 17)
        Me.CbTidurSiang.TabIndex = 11
        Me.CbTidurSiang.Text = "Tidur Siang"
        Me.CbTidurSiang.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbPria)
        Me.GroupBox1.Controls.Add(Me.RbWanita)
        Me.GroupBox1.Location = New System.Drawing.Point(114, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 41)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CbTidurSiang)
        Me.Controls.Add(Me.CbOlahraga)
        Me.Controls.Add(Me.CbMembaca)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.TxtNoInduk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNoInduk As System.Windows.Forms.TextBox
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents RbPria As System.Windows.Forms.RadioButton
    Friend WithEvents RbWanita As System.Windows.Forms.RadioButton
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CbMembaca As System.Windows.Forms.CheckBox
    Friend WithEvents CbOlahraga As System.Windows.Forms.CheckBox
    Friend WithEvents CbTidurSiang As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
