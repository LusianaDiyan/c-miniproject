Public Class Form1

    Private Sub ButtonProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonProses.Click
        Dim jari, luas, keliling, phi As Double
        Dim pesan As String
        pesan = ""
        jari = TextBoxJari.Text
        
        phi = 3.14

        luas = phi * (jari * jari)
        keliling = 2 * phi * jari

        TextBoxluas.Text = luas
        TextBoxkeliling.Text = keliling

        pesan = "Keliling Lingkaran : " & TextBoxkeliling.Text & Environment.NewLine
        pesan &= "Luas Lingkaran : " & TextBoxluas.Text

        show_message(pesan)
    End Sub

    Private Sub ButtonHAPUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHAPUS.Click
        TextBoxJari.Text = ""
        TextBoxkeliling.Text = ""
        TextBoxluas.Text = ""
    End Sub

    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        Close()
    End Sub

    Private Sub show_message(ByVal pesan As String)
        MsgBox(pesan, MsgBoxStyle.Information, "Message")
    End Sub
End Class
