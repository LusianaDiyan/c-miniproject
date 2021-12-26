Public Class form4
    'variabel module

    Dim username_default As String = "papsi"
    Dim password_default As String = "123"
    Private Sub LinkLABEL1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("www.papsi.its.ac.id")
    End Sub
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        'variabel lokal
        Dim user, pass As String
        user = txtUsername.Text
        pass = txtPassword.Text

        'seleksi kondisi
        'operator perbandingan (kesamaan)
        'operator logika (konjungsi)
        If user = username_default And pass = password_default Then
            MsgBox("selamat datang" & user, MsgBoxStyle.Information)
        Else
            MsgBox("User/Password salah", MsgBoxStyle.Critical)
        End If

    End Sub
End Class

