Public Class Form1
    Const A As Decimal = 4
    Const AB As Decimal = 3.5
    Const B As Decimal = 3
    Const BC As Decimal = 2.5
    Const C As Decimal = 2
    Const D As Decimal = 1
    Const E As Decimal = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub ContohProcedure()
        MsgBox("Panggilan Procedure", MsgBoxStyle.Information, "Procedure")
    End Sub

    Private Sub ButtonProsedur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonProsedur.Click
        ContohProcedure()
    End Sub

    Private Sub NilaiIPK(ByVal p_nama As String, ByVal p_usia As Integer)
        Dim IPK As Decimal
        Dim pesan, nama_mahasiswa As String
        Dim usia As Integer

        nama_mahasiswa = p_nama
        usia = p_usia
        IPK = HitungNilaiIPK()

        pesan = "Nama: " & nama_mahasiswa & Environment.NewLine
        pesan &= "Usia: " & usia & Environment.NewLine
        pesan &= "IPK: " & IPK

        MsgBox(pesan, MsgBoxStyle.Information, "Hello")
    End Sub

    Private Sub ButtonIPK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonIPK.Click
        Dim nama As String
        Dim usia As Integer

        nama = TextBoxNama.Text
        usia = TextBoxUsia.Text

        NilaiIPK(nama, usia)
    End Sub

    Private Function HitungNilaiIPK() As Decimal
        'DECLARATION
        Dim jumlah_sks As Integer
        Dim IPK, total_nilai_angka As Decimal
        'Dim sks_MK_A, sks_MK_B, sks_MK_C, sks_MK_D As Integer
        'Dim val_MK_A, val_MK_B, val_MK_C, val_MK_D As Decimal
        Dim sks_MK(4) As Integer
        Dim val_MK(4) As Decimal

        'INITIATION

        'sks_MK_A = 3
        'sks_MK_B = 2
        'sks_MK_C = 4
        'sks_MK_D = 3
        'jumlah_sks = sks_MK_A + sks_MK_B + sks_MK_C + sks_MK_D
        sks_MK = {3, 2, 4, 3}
        jumlah_sks = sks_MK(0) + sks_MK(1) + sks_MK(2) + sks_MK(3)

        'val_MK_A = AB * sks_MK_A
        'val_MK_B = D * sks_MK_B
        'val_MK_C = BC * sks_MK_C
        'val_MK_D = B * sks_MK_D
        'total_nilai_angka = val_MK_A + val_MK_B + val_MK_C + val_MK_D
        val_MK = {AB * sks_MK(0), A * sks_MK(1), A * sks_MK(2), AB * sks_MK(3)}
        total_nilai_angka = val_MK(0) + val_MK(1) + val_MK(2) + val_MK(3)

        IPK = total_nilai_angka / jumlah_sks

        HitungNilaiIPK = IPK
    End Function

   
End Class
