Public Class Form9

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim IPK As Double
        Dim MS As Integer
        IPK = TextBox1.Text
        MS = TextBox3.Text

        If IPK > 0 And IPK <= 2 Then
            TextBox2.Text = "Tidak Memuaskan"
        ElseIf IPK > 2 And IPK <= 3 Then
            TextBox2.Text = "Memuaskan"
        ElseIf IPK > 3 And IPK <= 3.5 Then
            TextBox2.Text = "Sangat Memuaskan"
        Else
            TextBox2.Text = "tidak ada"
        End If

        If IPK > 3.5 And IPK <= 4 And MS < 8 Then
            TextBox2.Text = "Cumlaude"
        ElseIf IPK > 3.5 And IPK <= 4 And MS >= 8 Then
            TextBox2.Text = "Sangat Memuaskan"
        End If

    End Sub
End Class