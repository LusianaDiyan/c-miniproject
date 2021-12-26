Public Class FormLooping

    Private Sub ButtonGanjil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGanjil.Click
       Dim isi_text_box As String = ""
        For index As Integer = 1 To 100 Step 2
            isi_text_box &= index & " " & Environment.NewLine

        Next
        RichTextBoxLoop.Text = isi_text_box
    End Sub

    Private Sub ButtonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        RichTextBoxLoop.Text = ""
    End Sub

    Private Sub ButtonGenap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGenap.Click
        Dim isi_text_box As String = ""
        For index As Integer = 2 To 100 Step 2
            isi_text_box &= index & " " & Environment.NewLine

        Next
        RichTextBoxLoop.Text = isi_text_box
    End Sub

    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        Close()
    End Sub
End Class