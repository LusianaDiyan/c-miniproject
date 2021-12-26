Public Class Form1

    Private Sub Message(ByVal pesan As String)
        MsgBox(pesan, MsgBoxStyle.Information, "Message")
    End Sub

    Private Function KelilingSegitiga(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer)
        Dim d As Integer
        d = a + b + c
        Return d
    End Function


    Private Sub Keliling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Keliling.Click
        Dim a, b, c, keliling As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text
        keliling = KelilingSegitiga(a, b, c)
        Message(keliling)
    End Sub

    Private Function LuasSegitiga(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer, ByVal t As Integer)
        Dim d As Integer
        d = (t * a) / 2
        Return d
    End Function

    Private Sub Luas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Luas.Click
        Dim a, b, c, t, luas As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text
        t = TextBox4.Text
        luas = LuasSegitiga(a, t)
        Message(luas)
    End Sub

    Private Sub reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.Click
        sisiA.Text = ""
        sisiB.Text = ""
        sisiC.Text = ""
        tinggi.Text = ""
    End Sub

    Private Sub quit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quit.Click
        Close()
    End Sub
End Class
