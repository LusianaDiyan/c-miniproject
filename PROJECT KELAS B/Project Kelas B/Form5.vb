Public Class Form5

    Private Sub btnDaftar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDaftar.Click
        Dim nrp, nama, jk, s As String
        nrp = txtNRP.Text
        nama = txtNama.Text

        If rbLaki.checked = True Then
            jk = "Jenis Kelamin: Laki-Laki"
        ElseIf rbPerempuan.Checked = True Then
            jk = "jenis kelamin: Perempuan"
        Else
            jk = "jenis kelamin: ???"
        End If
        s = "NRP: " & nrp & vbCrLf
        s = s & "Nama: " & nama & vbCrLf
        s = s & jk

        MsgBox(s, MsgBoxStyle.Information, "DATA MAHASISWA")
    End Sub
End Class