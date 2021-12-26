Public Class Form2

    Private Sub btnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHitung.Click
        'deklarasi variabel
        Dim tgl, nama As String
        Dim harga, diskon, potongan, totalBayar As Decimal

        'pemberian nilai variabel
        'menampung nilai dari textbox
        tgl = txttransaksi.Text
        nama = txtnama.Text
        harga = txtharga.Text
        diskon = txtdiskon.Text

        'penghitungan total bayar
        potongan = (harga * diskon) / 100
        totalBayar = harga - potongan

        MsgBox("tgl transaksi: " & tgl & vbCrLf & "Nama Member: " & nama & vbCrLf & "Harga: " & harga & vbCrLf & "Diskon: " & diskon & vbCrLf & "Total Bayar: " & totalBayar, MsgBoxStyle.Information, "TRANSAKSI")
    End Sub

End Class
