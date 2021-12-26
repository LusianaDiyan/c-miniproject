Public Class Form1
    Const A As Decimal = 4
    Const AB As Decimal = 3.75
    Const B As Decimal = 3.5
    Const BC As Decimal = 3
    Const C As Decimal = 2.5
    Const CD As Decimal = 2
    Const D As Decimal = 1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'DEKLARASI VARIABEL
        Dim pesan As String
        Dim nama_mahasiswa As String
        Dim usia, total_sks As Integer
        Dim IPK, total_nilai As Decimal
        Dim sks_MK_A, sks_MK_B, sks_MK_C, sks_MK_D As Integer
        Dim val_MK_A, val_MK_B, val_MK_C, val_MK_D As Decimal
        'VARIABEL ARRAY
        Dim sks_MK(4) As Integer
        Dim val_MK(4) As Decimal

        'INISIASI VARIABEL
        nama_mahasiswa = "Lusiana Diyan Ningrum"
        usia = 18
        'sks_MK_A = 3 '3 SKS
        'sks_MK_B = 4 '4 SKS
        'sks_MK_C = 5 '5 SKS
        'sks_MK_D = 6 '6 SKS
        'INISIASI ARRAY
        sks_MK = {3, 4, 5, 6}

        'val_MK_A = A * sks_MK_A
        'val_MK_B = AB * sks_MK_B
        'val_MK_C = A * sks_MK_C
        'val_MK_D = A * sks_MK_D
        'INISIASI ARRAY
        val_MK = {A * sks_MK(0), AB * sks_MK(1), A * sks_MK(2), A * sks_MK(3)}

        'total_nilai = val_MK_A + val_MK_B + val_MK_C + val_MK_D
        'total_sks = sks_MK_A + sks_MK_B + sks_MK_C + sks_MK_D
        total_nilai = val_MK(0) + val_MK(1) + val_MK(2) + val_MK(3)
        total_sks = sks_MK(0) + sks_MK(1) + sks_MK(2) + sks_MK(3)
        IPK = total_nilai / total_sks
        pesan = "Nama : " & nama_mahasiswa & Environment.NewLine
        pesan &= "Usia : " & usia & Environment.NewLine
        pesan &= "IPK : " & IPK

        MsgBox(pesan, MsgBoxStyle.Information, "Congratulation")
    End Sub
End Class
