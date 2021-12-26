Public Class Form1

    Private Sub ButtonWhile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonWhile.Click
        Dim isi_text_box As String = ""
        Dim index As Integer = 0
        While index <= 100
            isi_text_box &= index & " "
            index += 1
        End While

        RichTextBoxLoop.Text = isi_text_box
    End Sub

    Private Sub Buttonexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonexit.Click
        Dim isi_text_box As String = ""
        Dim index As Integer = 0
        While index <= 100
            index += 1

            If index >= 10 And index <= 20 Then
                Continue While
            End If

            isi_text_box &= index & " "

            If index = 50 Then
                Exit While
            End If
        End While

        RichTextBoxLoop.Text = isi_text_box
    End Sub

    Private Sub ButtonFor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFor.Click
        Dim isi_text_box As String = ""
        For index As Integer = 100 To 200
            isi_text_box &= index & " "
        Next
        RichTextBoxLoop.Text = isi_text_box
    End Sub

    Private Sub ButtonForContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonForContinue.Click
        Dim isi_text_box As String = ""
        For index As Integer = 100 To 200
            If index >= 120 And index <= 130 Then
                Continue For
            End If

            isi_text_box &= index & " "

            If index = 160 Then
                Exit For
            End If
        Next
        RichTextBoxLoop.Text = isi_text_box
    End Sub

    Private Sub ButtonDoWhile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDoWhile.Click
        Dim isi_text_box As String = ""
        Dim index As Integer = 0
        Do While index < 100
            index += 1
            isi_text_box &= index & " "
        Loop
        RichTextBoxLoop.Text = isi_text_box
    End Sub

    Private Sub ButtonDoUntil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDoUntil.Click
        Dim isi_text_box As String = ""
        Dim index As Integer = 0
        Do Until index > 100
            index += 1
            isi_text_box &= index & " "
        Loop
        RichTextBoxLoop.Text = isi_text_box
    End Sub

    Private Sub ButtonDoWhileEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDoWhileEnd.Click
        Dim isi_text_box As String = ""
        Dim index As Integer = 0
        Do
            index += 1
            isi_text_box &= index & " "
        Loop While index < 100
        RichTextBoxLoop.Text = isi_text_box
    End Sub

    Private Sub ButtonDoUntilEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDoUntilEnd.Click
        Dim isi_text_box As String = ""
        Dim index As Integer = 0
        Do
            index += 1
            isi_text_box &= index & " "
        Loop Until index > 100
        RichTextBoxLoop.Text = isi_text_box
    End Sub
End Class
