Public Class Form2

  
    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        ' mendefinisikan variabel bertipe string
        Dim s As String

        ' mengisi variabel dengan data
        ' dari form
        s = "No. Induk : " & TxtNoInduk.Text & vbCrLf
        s = s & "Nama : " & TxtNama.Text & vbCrLf
        If RbPria.Checked = True Then
            s = s & "Jenis Kelamin : Pria" & vbCrLf
        ElseIf RbWanita.Checked = True Then
            s = s & "Jenis Kelamin : Wanita" & vbCrLf
        Else
            s = s & "Jenis Kelamin : Tidak jelas" & vbCrLf
        End If
        s = s & vbCrLf
        s = s & "Hobi :" & vbCrLf

        If CbMembaca.Checked = True Then
            s = s & "- Membaca" & vbCrLf
        End If

        If CbOlahraga.Checked = True Then
            s = s & "- Olah Raga" & vbCrLf
        End If

        If CbTidurSiang.Checked = True Then
            s = s & "- Tidur Siang" & vbCrLf
        End If

        ' menampilkan isi variabel di message box
        MsgBox(s, MsgBoxStyle.Information, "Info")

    End Sub
End Class