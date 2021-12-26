Public Class Form6

    Private Sub BtnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHitung.Click
        Dim bil1, bil2, hsl As Integer
        bil1 = CInt(TxtBil1.Text)
        bil2 = CInt(TxtBil2.Text)
        hsl = Jumlah(bil1, bil2)
        TxtJumlah.Text = hsl
        hsl = Selisih(bil1, bil2)
        TxtSelisih.Text = hsl
    End Sub

    Private Function Jumlah(ByVal a As Integer, ByVal b As Integer)
        Dim c As Integer
        c = a + b
        Jumlah = c
    End Function

    Private Function Selisih(ByVal a As Integer, ByVal b As Integer)
        Dim c As Integer
        c = a - b
        Selisih = c
    End Function

End Class