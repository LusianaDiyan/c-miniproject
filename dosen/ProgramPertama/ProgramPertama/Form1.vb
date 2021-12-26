Public Class FormUtama

    Private Sub FormUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Kode di bawah ini untuk menampilkan message box
        'MsgBox("Hello World", MsgBoxStyle.Information, "Halo")
    End Sub

    Private Sub ButtonLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLogin.Click
        MsgBox("Selamat Datang " & TextBoxName.Text, MsgBoxStyle.Information, "Halo")
    End Sub
End Class
