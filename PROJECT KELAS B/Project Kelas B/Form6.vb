Public Class Form6

    Private Sub btnKonvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKonvert.Click
        Dim s As String
        If IsNumeric(txtMasukkanNilai.Text) Then
            If rbFtoC.Checked = True Then
                'f to c
                s = (txtMasukkanNilai.Text - 32) * 9 / 5
                Label3.Text = txtMasukkanNilai.Text & " celcius " & s & " Fahrenheit "
            ElseIf rbCtoF.Checked = True Then
                'c to f
                s = (5 / 9 * txtMasukkanNilai.Text) + 32
                Label3.Text = txtMasukkanNilai.Text & " Fahrenheit " & s & " celcius "
            Else
                MsgBox("Masukkan Angka")
            End If
        End If
    End Sub
End Class