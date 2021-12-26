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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmdapply = New System.Windows.Forms.Button()
        Me.cmdbaru = New System.Windows.Forms.Button()
        Me.cmdkeluar = New System.Windows.Forms.Button()
        Me.cmdbayar = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.TextBox()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.diskon = New System.Windows.Forms.TextBox()
        Me.total = New System.Windows.Forms.TextBox()
        Me.pembayaran = New System.Windows.Forms.TextBox()
        Me.kembalian = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Toko Mini"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Harga Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah Barang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Diskon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(356, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(292, 320)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Uang Pembayaran"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(302, 355)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Uang Kembalian"
        '
        'cmdapply
        '
        Me.cmdapply.Location = New System.Drawing.Point(305, 61)
        Me.cmdapply.Name = "cmdapply"
        Me.cmdapply.Size = New System.Drawing.Size(82, 26)
        Me.cmdapply.TabIndex = 9
        Me.cmdapply.Text = "Apply"
        Me.cmdapply.UseVisualStyleBackColor = True
        '
        'cmdbaru
        '
        Me.cmdbaru.Location = New System.Drawing.Point(305, 106)
        Me.cmdbaru.Name = "cmdbaru"
        Me.cmdbaru.Size = New System.Drawing.Size(82, 25)
        Me.cmdbaru.TabIndex = 10
        Me.cmdbaru.Text = "Baru"
        Me.cmdbaru.UseVisualStyleBackColor = True
        '
        'cmdkeluar
        '
        Me.cmdkeluar.Location = New System.Drawing.Point(305, 148)
        Me.cmdkeluar.Name = "cmdkeluar"
        Me.cmdkeluar.Size = New System.Drawing.Size(82, 27)
        Me.cmdkeluar.TabIndex = 11
        Me.cmdkeluar.Text = "Keluar"
        Me.cmdkeluar.UseVisualStyleBackColor = True
        '
        'cmdbayar
        '
        Me.cmdbayar.Location = New System.Drawing.Point(570, 271)
        Me.cmdbayar.Name = "cmdbayar"
        Me.cmdbayar.Size = New System.Drawing.Size(82, 30)
        Me.cmdbayar.TabIndex = 8
        Me.cmdbayar.Text = "Bayar"
        Me.cmdbayar.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(106, 61)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(121, 20)
        Me.id.TabIndex = 12
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(106, 111)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(119, 20)
        Me.nama.TabIndex = 13
        '
        'harga
        '
        Me.harga.Location = New System.Drawing.Point(106, 155)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(119, 20)
        Me.harga.TabIndex = 14
        '
        'jumlah
        '
        Me.jumlah.Location = New System.Drawing.Point(106, 204)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(119, 20)
        Me.jumlah.TabIndex = 15
        '
        'diskon
        '
        Me.diskon.Location = New System.Drawing.Point(106, 241)
        Me.diskon.Name = "diskon"
        Me.diskon.Size = New System.Drawing.Size(119, 20)
        Me.diskon.TabIndex = 16
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(421, 281)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(109, 20)
        Me.total.TabIndex = 17
        '
        'pembayaran
        '
        Me.pembayaran.Location = New System.Drawing.Point(421, 313)
        Me.pembayaran.Name = "pembayaran"
        Me.pembayaran.Size = New System.Drawing.Size(109, 20)
        Me.pembayaran.TabIndex = 18
        '
        'kembalian
        '
        Me.kembalian.Location = New System.Drawing.Point(423, 348)
        Me.kembalian.Name = "kembalian"
        Me.kembalian.Size = New System.Drawing.Size(107, 20)
        Me.kembalian.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(84, 158)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Rp"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(400, 284)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(23, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Rp"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(400, 317)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(23, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Rp"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(401, 351)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Rp"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(695, 390)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.kembalian)
        Me.Controls.Add(Me.pembayaran)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.diskon)
        Me.Controls.Add(Me.jumlah)
        Me.Controls.Add(Me.harga)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.cmdbayar)
        Me.Controls.Add(Me.cmdkeluar)
        Me.Controls.Add(Me.cmdbaru)
        Me.Controls.Add(Me.cmdapply)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Tugasku 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdapply As System.Windows.Forms.Button
    Friend WithEvents cmdbaru As System.Windows.Forms.Button
    Friend WithEvents cmdkeluar As System.Windows.Forms.Button
    Friend WithEvents cmdbayar As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents nama As System.Windows.Forms.TextBox
    Friend WithEvents harga As System.Windows.Forms.TextBox
    Friend WithEvents jumlah As System.Windows.Forms.TextBox
    Friend WithEvents diskon As System.Windows.Forms.TextBox
    Friend WithEvents total As System.Windows.Forms.TextBox
    Friend WithEvents pembayaran As System.Windows.Forms.TextBox
    Friend WithEvents kembalian As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label

End Class
