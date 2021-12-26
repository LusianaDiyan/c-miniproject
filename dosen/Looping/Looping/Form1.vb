Public Class Form1
    Private pesan As String = ""

    Private Sub example_while()
        Dim index As Integer = 0
        While index < 100
            pesan &= "."
            index += 1
        End While
    End Sub

    Private Sub example_do()
        Dim index As Integer = 0
        Do
            pesan &= "."
            index += 1
        Loop While index < 100
    End Sub

    Private Sub example_for()
        For index As Integer = 1 To 100
            pesan &= "."
        Next
    End Sub

    Private Sub ButtonWhile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonWhile.Click
        example_while()
        RichTextBoxWhile.Text = pesan
        pesan = ""
    End Sub

    Private Sub ButtonDo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDo.Click
        example_do()
        RichTextBoxDo.Text = pesan
        pesan = ""
    End Sub

    Private Sub ButtonFor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFor.Click
        example_for()
        RichTextBoxDo.Text = pesan
        pesan = ""
    End Sub

    Private Sub ButtonForEach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonForEach.Click
        Dim numbers() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
        For Each item As Integer In numbers
            pesan &= item & ","
        Next
        RichTextBoxDo.Text = pesan
    End Sub
End Class
