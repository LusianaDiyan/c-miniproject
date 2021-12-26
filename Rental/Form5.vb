Public Class Form5

    Private Sub BtnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHitung.Click
        Dim bil1, bil2 As Integer ' buat var bil1 dan bil 2
        bil1 = CInt(TxtBil1.Text) ' mengkonversi ke int dan menyimpan
        bil2 = CInt(TxtBil2.Text) ' mengkonversi ke int dan menyimpan
        Hitung(bil1, bil2) ' memanggil fungsi
    End Sub

    Private Sub Hitung(ByVal a As Integer, ByVal b As Integer)
        Dim c As Integer ' buat var c bertipe integer
        c = a + b ' menjumlahkan a dan b, hsl disimpan di c
        TxtJumlah.Text = c ' menampilkan var c
        c = a - b ' a dikurangi b, hsl disimpan di c
        TxtSelisih.Text = c ' menampilkan var c
    End Sub

End Class