Public Class Form10

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ListBox1.Items.Clear()

        Dim Bil, i As Integer

        Bil = CInt(TextBox1.Text)

        For i = 1 To Bil

            If Bil Mod i = 0 Then
                ListBox1.Items.Add(i)

            End If
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Bil, i As Integer

        Bil = CInt(TextBox1.Text)

        i = 2

        Do Until Bil Mod i = 0
            i = i + 1

        Loop

        If i = Bil Then
            MsgBox(Bil & "Adalah Bilangan prima")
        Else
            MsgBox(Bil & "Bukan Bilangan prima")

        End If
    End Sub
End Class