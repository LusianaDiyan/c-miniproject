Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' menampilkan message box yang berisi nama dan alamat yang telah diketik di text box
        ' vbCrLf untuk ganti baris
        ' Trim untuk menghapus spasi di depan dan di belakang
        ' & untuk menggabungkan string, baik yang diketik sendiri maupun yang dibaca dari form
        MsgBox("Selamat datang " & TxtNama.Text.Trim & vbCrLf & "di " & TxtAlamat.Text.Trim & " !", MsgBoxStyle.Information, "Salam")
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ' membuka website ITS
        System.Diagnostics.Process.Start("www.its.ac.id")
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        ' membuka website PAPSI
        System.Diagnostics.Process.Start("www.papsi.its.ac.id")
    End Sub
End Class
