Public Class Form1

    Private Sub ButtonBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuku.Click

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Labeljam.Text = Format(Now, "hh:mm:ss tt")
        Labeldate.Text = Format(Now, "dddd, dd MMMM yyyy")
    End Sub
End Class
