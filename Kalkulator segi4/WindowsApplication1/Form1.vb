Public Class Calculator

    Private Sub Message(ByVal pesan As String)
        MsgBox(pesan, MsgBoxStyle.Information, "Message")
    End Sub

    Private Function LuasSegiEmpat(ByVal a As Integer, ByVal b As Integer)
        Dim c As Integer
        c = a * b
        Return c
    End Function

    Private Sub Luas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Luas.Click
        Dim a, b, luas As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        luas = LuasSegiEmpat(a, b)
        Message(luas)
    End Sub

    Private Function KelilingSegiEmpat(ByVal a As Integer, ByVal b As Integer)
        Dim c As Integer
        c = 2 * (a + b)
        Return c
    End Function


    Private Sub Keliling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Keliling.Click
        Dim a, b, keliling As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        keliling = KelilingSegiEmpat(a, b)
        Message(keliling)
    End Sub
End Class
