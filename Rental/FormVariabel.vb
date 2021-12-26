Public Class FormVariabel

    Private Sub BtnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProses.Click
        'Deklarasi Variabel
        Dim nama As String

        'ambil data dan simpan ke variabel
        nama = TxtNama.Text

        'tampilkan data ke messagebox
        'MsgBox(nama, MsgBoxStyle.Information, "Informasi")

        'tampilkan data ke label
        'LblNama.Text = nama

        'ARRAY
        Dim data(3) As String

        data(1) = "Bhara"
        data(2) = "Maulana"
        data(3) = "absen"

        LblNama.Text = data(1) + " " + data(2) + " " + data(3)
    End Sub

    Private Sub FormVariabel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim data(3) As String

        data(1) = "Bhara"
        data(2) = "Maulana"
        data(3) = "absen"

        LblNama.Text = data(1) + " " + data(2) + " " + data(3)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim xfrm As New Form1
        xfrm.MdiParent = Me
        xfrm.Show()
    End Sub
End Class