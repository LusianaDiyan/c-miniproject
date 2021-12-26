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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonBuku = New System.Windows.Forms.Button()
        Me.ButtonCari = New System.Windows.Forms.Button()
        Me.ButtonRak = New System.Windows.Forms.Button()
        Me.ButtonKeluar = New System.Windows.Forms.Button()
        Me.Buttonpinjam = New System.Windows.Forms.Button()
        Me.Buttonpinjaman = New System.Windows.Forms.Button()
        Me.Buttonkembali = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Labeldate = New System.Windows.Forms.Label()
        Me.Labeljam = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bradley Hand ITC", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(165, -12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(491, 120)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome !!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tempus Sans ITC", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(284, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Glad You're Here"
        '
        'ButtonBuku
        '
        Me.ButtonBuku.Location = New System.Drawing.Point(42, 244)
        Me.ButtonBuku.Name = "ButtonBuku"
        Me.ButtonBuku.Size = New System.Drawing.Size(115, 33)
        Me.ButtonBuku.TabIndex = 2
        Me.ButtonBuku.Text = "Buku "
        Me.ButtonBuku.UseVisualStyleBackColor = True
        '
        'ButtonCari
        '
        Me.ButtonCari.Location = New System.Drawing.Point(42, 295)
        Me.ButtonCari.Name = "ButtonCari"
        Me.ButtonCari.Size = New System.Drawing.Size(115, 35)
        Me.ButtonCari.TabIndex = 3
        Me.ButtonCari.Text = "Cari Buku"
        Me.ButtonCari.UseVisualStyleBackColor = True
        '
        'ButtonRak
        '
        Me.ButtonRak.Location = New System.Drawing.Point(42, 351)
        Me.ButtonRak.Name = "ButtonRak"
        Me.ButtonRak.Size = New System.Drawing.Size(115, 36)
        Me.ButtonRak.TabIndex = 4
        Me.ButtonRak.Text = "Rak Buku"
        Me.ButtonRak.UseVisualStyleBackColor = True
        '
        'ButtonKeluar
        '
        Me.ButtonKeluar.Location = New System.Drawing.Point(42, 399)
        Me.ButtonKeluar.Name = "ButtonKeluar"
        Me.ButtonKeluar.Size = New System.Drawing.Size(115, 34)
        Me.ButtonKeluar.TabIndex = 5
        Me.ButtonKeluar.Text = "Keluar"
        Me.ButtonKeluar.UseVisualStyleBackColor = True
        '
        'Buttonpinjam
        '
        Me.Buttonpinjam.Location = New System.Drawing.Point(680, 245)
        Me.Buttonpinjam.Name = "Buttonpinjam"
        Me.Buttonpinjam.Size = New System.Drawing.Size(129, 32)
        Me.Buttonpinjam.TabIndex = 6
        Me.Buttonpinjam.Text = "Peminjaman"
        Me.Buttonpinjam.UseVisualStyleBackColor = True
        '
        'Buttonpinjaman
        '
        Me.Buttonpinjaman.Location = New System.Drawing.Point(680, 295)
        Me.Buttonpinjaman.Name = "Buttonpinjaman"
        Me.Buttonpinjaman.Size = New System.Drawing.Size(129, 35)
        Me.Buttonpinjaman.TabIndex = 7
        Me.Buttonpinjaman.Text = "Peminjaman"
        Me.Buttonpinjaman.UseVisualStyleBackColor = True
        '
        'Buttonkembali
        '
        Me.Buttonkembali.Location = New System.Drawing.Point(680, 351)
        Me.Buttonkembali.Name = "Buttonkembali"
        Me.Buttonkembali.Size = New System.Drawing.Size(129, 36)
        Me.Buttonkembali.TabIndex = 8
        Me.Buttonkembali.Text = "Pengembalian"
        Me.Buttonkembali.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Labeldate
        '
        Me.Labeldate.AutoSize = True
        Me.Labeldate.Location = New System.Drawing.Point(436, 205)
        Me.Labeldate.Name = "Labeldate"
        Me.Labeldate.Size = New System.Drawing.Size(72, 13)
        Me.Labeldate.TabIndex = 9
        Me.Labeldate.Text = "LabelTanggal"
        '
        'Labeljam
        '
        Me.Labeljam.AutoSize = True
        Me.Labeljam.Location = New System.Drawing.Point(356, 205)
        Me.Labeljam.Name = "Labeljam"
        Me.Labeljam.Size = New System.Drawing.Size(61, 13)
        Me.Labeljam.TabIndex = 10
        Me.Labeljam.Text = "Label12jam"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(855, 437)
        Me.Controls.Add(Me.Labeljam)
        Me.Controls.Add(Me.Labeldate)
        Me.Controls.Add(Me.Buttonkembali)
        Me.Controls.Add(Me.Buttonpinjaman)
        Me.Controls.Add(Me.Buttonpinjam)
        Me.Controls.Add(Me.ButtonKeluar)
        Me.Controls.Add(Me.ButtonRak)
        Me.Controls.Add(Me.ButtonCari)
        Me.Controls.Add(Me.ButtonBuku)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonBuku As System.Windows.Forms.Button
    Friend WithEvents ButtonCari As System.Windows.Forms.Button
    Friend WithEvents ButtonRak As System.Windows.Forms.Button
    Friend WithEvents ButtonKeluar As System.Windows.Forms.Button
    Friend WithEvents Buttonpinjam As System.Windows.Forms.Button
    Friend WithEvents Buttonpinjaman As System.Windows.Forms.Button
    Friend WithEvents Buttonkembali As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Labeldate As System.Windows.Forms.Label
    Friend WithEvents Labeljam As System.Windows.Forms.Label

End Class
