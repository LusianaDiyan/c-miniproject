Public Class Form8

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim pilihan As Integer
        pilihan = CInt(TextBox1.Text)

        Select Case pilihan
            Case 1
                TextBox2.Text = "Rp. 5000,-"
            Case 2
                TextBox2.Text = "Rp. 3000,-"
            Case 3
                TextBox2.Text = "Rp. 4000,-"
            Case Else
                TextBox2.Text = "Tidak ada Pilihan"
        End Select
    End Sub
End Class