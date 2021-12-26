Public Class Form8

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LBBarang.Items.Add("Printer Brother T300")
        LBBarang.Items.Add("Printer Canon MX397")
        LBBarang.Items.Add("LCD Infocus N211")

        'menghitung jumlah data list box
        'ditampilkan di label3
        Label2.Text = LBBarang.Items.Count

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesan.Click
        Dim data As String
        data = LBBarang.SelectedItem

        If data = "" Then
            MsgBox("pilih barang dulu")
        Else
            'menghapus data listbox pd lbbarang
            LBBarang.Items.Remove(data)
            'menambah data listbox pada lbpesanan
            LBPesanan.Items.Add(data)

            'update jumlah data pd listbox
            Label2.Text = LBBarang.Items.Count
            Label7.Text = LBPesanan.items.count
        End If
    End Sub
End Class