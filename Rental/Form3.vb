Public Class Form3

    Private Sub SingkatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SingkatToolStripMenuItem.Click
        ' mendefinisikan variabel x yang bertipe form1
        Dim x As New Form1
        ' menampilkan form1
        x.Show()
    End Sub

    Private Sub LengkapToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LengkapToolStripMenuItem.Click
        ' mendefinisikan variabel x yang bertipe form2
        Dim x As New Form2
        ' menampilkan form2
        x.Show()
    End Sub
End Class