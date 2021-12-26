<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.CBKota = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBUniv = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBJurusan = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kota"
        '
        'CBKota
        '
        Me.CBKota.FormattingEnabled = True
        Me.CBKota.Location = New System.Drawing.Point(35, 40)
        Me.CBKota.Name = "CBKota"
        Me.CBKota.Size = New System.Drawing.Size(121, 21)
        Me.CBKota.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Universitas"
        '
        'CBUniv
        '
        Me.CBUniv.FormattingEnabled = True
        Me.CBUniv.Location = New System.Drawing.Point(35, 108)
        Me.CBUniv.Name = "CBUniv"
        Me.CBUniv.Size = New System.Drawing.Size(121, 21)
        Me.CBUniv.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jurusan"
        '
        'CBJurusan
        '
        Me.CBJurusan.FormattingEnabled = True
        Me.CBJurusan.Location = New System.Drawing.Point(35, 178)
        Me.CBJurusan.Name = "CBJurusan"
        Me.CBJurusan.Size = New System.Drawing.Size(121, 21)
        Me.CBJurusan.TabIndex = 5
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.CBJurusan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBUniv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBKota)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form9"
        Me.Text = "Form9"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CBKota As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CBUniv As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CBJurusan As ComboBox
End Class
