Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'menambah data di combobox
        CBKota.Items.Add("Surabaya")
        CBKota.Items.Add("Malang")
        CBKota.Items.Add("Jember")
    End Sub

    Private Sub CBKota_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBKota.SelectedIndexChanged
        Dim kota As String = CBKota.SelectedItem

        'menghapus data combobox
        CBUniv.Items.Clear()
        CBJurusan.Items.Clear()

        'cek kota yang dipilih
        If kota = "Surabaya" Then
            CBUniv.Items.Add("ITS")
            CBUniv.Items.Add("UNESA")
            CBUniv.Items.Add("UNAIR")
        ElseIf kota = "Malang" Then
            CBUniv.Items.Add("UNIBRA")
            CBUniv.Items.Add("UM")
            CBUniv.Items.Add("UIN")
        ElseIf kota = "Jember" Then
            CBUniv.Items.Add("UNEJ")
            CBUniv.Items.Add("POLIJE")
        End If

    End Sub

    Private Sub CBUniv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBUniv.SelectedIndexChanged
        Dim univ As String = CBUniv.SelectedItem

        'menghapus data combobox
        CBJurusan.Items.Clear()
        If univ = "ITS" Then
            CBJurusan.Items.Add("Teknik Informatika")
            CBJurusan.Items.Add("Teknik Sipil")
            CBJurusan.Items.Add("Teknik Industri")
            CBJurusan.Items.Add("Teknik Elektro")
            CBJurusan.Items.Add("Teknik Mesin")
            CBJurusan.Items.Add("Geomatika")
        ElseIf univ = "UNESA" Then
            CBJurusan.Items.Add("Sistem Informasi")
            CBJurusan.Items.Add("Biologi")
            CBJurusan.Items.Add("Pendidikan Guru SD")
            CBJurusan.Items.Add("Teknik Elektro")
            CBJurusan.Items.Add("Teknik Mesin")
            CBJurusan.Items.Add("Sejarah")
        ElseIf univ = "UNAIR" Then
            CBJurusan.Items.Add("Pendidikan Dokter")
            CBJurusan.Items.Add("Biologi")
            CBJurusan.Items.Add("Psikologi")
            CBJurusan.Items.Add("Administrasi Negara")
            CBJurusan.Items.Add("Pendidikan Apoteker")
            CBJurusan.Items.Add("Sejarah")
        ElseIf univ = "UNIBRA" Then
            CBJurusan.Items.Add("Kedokteran Hewan")
            CBJurusan.Items.Add("Teknik Pertanian")
            CBJurusan.Items.Add("Sastra Inggris")
            CBJurusan.Items.Add("Budidaya Perairan")
            CBJurusan.Items.Add("Farmasi")
            CBJurusan.Items.Add("Ilmu Komputer")
        ElseIf univ = "UM" Then
            CBJurusan.Items.Add("Kedokteran Hewan")
            CBJurusan.Items.Add("Teknik Pertanian")
            CBJurusan.Items.Add("Sastra Inggris")
            CBJurusan.Items.Add("Budidaya Perairan")
            CBJurusan.Items.Add("Farmasi")
            CBJurusan.Items.Add("Ilmu Komputer")
        ElseIf univ = "UIN" Then
            CBJurusan.Items.Add("Kedokteran Hewan")
            CBJurusan.Items.Add("Teknik Pertanian")
            CBJurusan.Items.Add("Sastra Inggris")
            CBJurusan.Items.Add("Budidaya Perairan")
            CBJurusan.Items.Add("Farmasi")
            CBJurusan.Items.Add("Ilmu Komputer")
        ElseIf univ = "UNEJ" Then
            CBJurusan.Items.Add("Kedokteran Hewan")
            CBJurusan.Items.Add("Teknik Pertanian")
            CBJurusan.Items.Add("Sastra Inggris")
            CBJurusan.Items.Add("Budidaya Perairan")
            CBJurusan.Items.Add("Farmasi")
            CBJurusan.Items.Add("Ilmu Komputer")
        ElseIf univ = "POLIJE" Then
            CBJurusan.Items.Add("Kedokteran Hewan")
            CBJurusan.Items.Add("Teknik Pertanian")
            CBJurusan.Items.Add("Sastra Inggris")
            CBJurusan.Items.Add("Budidaya Perairan")
            CBJurusan.Items.Add("Farmasi")
            CBJurusan.Items.Add("Ilmu Komputer")
        End If
    End Sub
End Class