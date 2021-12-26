Public Class FormSegi4

    Private Sub ButtonProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonProses.Click
        Dim panjang, lebar, Luas, Keliling As Integer
        Dim pesan As String
        pesan = ""

        panjang = TextBoxPanjang.Text
        lebar = TextBoxLebar.Text

        Luas = panjang * lebar
        Keliling = 2 * (panjang + lebar)

        TextBoxLuas.Text = Luas
        TextBoxKeliling.Text = Keliling

        pesan = "Keliling Segiempat : " & Luas & Environment.NewLine
        pesan &= "Luas Segiempat : " & Keliling

        show_message(pesan)

    End Sub

    Private Sub show_message(ByVal pesan As String)
        MsgBox(pesan, MsgBoxStyle.Information, "Message")
    End Sub

    Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        TextBoxPanjang.Text = ""
        TextBoxLebar.Text = ""
    End Sub

    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        Close()
    End Sub
End Class
