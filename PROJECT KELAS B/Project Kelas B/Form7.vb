Public Class Form7

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim s As String
        s = "No Induk : " & txtNoinduk.Text & vbCrLf
        s = s & "Nama : " & txtNama.Text & vbCrLf
        If rbPria.Checked = True Then
            s = s & "kelamin : pria"
        ElseIf rbWanita.Checked = True Then
            s = s & "Kelamin : Wanita"
        Else
            s = s & "kelamin : Tidak Jelas"
        End If
        s = s & vbCrLf
        s = s & "Hoby : " & vbCrLf

        If CheckBox1.Checked = True Then
            s = s & " - Membaca" & vbCrLf
        End If

        If CheckBox2.Checked = True Then
            s = s & " - Olah Raga" & vbCrLf
        End If

        If CheckBox3.Checked = True Then
            s = s & " - Tidur Siang" & vbCrLf
        End If
        MsgBox(s, MsgBoxStyle.Information, "Info")
    End Sub
End Class