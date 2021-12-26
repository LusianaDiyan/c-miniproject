Public Class Form1

    Private Sub ButtonProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonProses.Click
        Dim opsi_str, pesan As String
        Dim opsi_int As Integer

        pesan = "Opsi yang anda pilih tidak dapat diproses"
        opsi_str = ComboBoxOpsi.Text

        If opsi_str = "" Then
            pesan = "Anda belum memilih opsi"
        Else
            opsi_int = CInt(opsi_str)

            If opsi_int >= 1 And opsi_int <= 4 Then
                pesan = "Anda belum memasuki usia sekolah"
            ElseIf opsi_int >= 5 And opsi_int <= 6 Then
                pesan = "Anda mengenyam pendidikan TK"
            ElseIf opsi_int >= 7 And opsi_int <= 11 Then
                pesan = "Anda mengenyam pendidikan SD"
            End If

        End If

        Dim jenis_kelamin As String
        jenis_kelamin = ""
        If RadioButtonPria.Checked = True Then
            jenis_kelamin = "PRIA"
        ElseIf RadioButtonWanita.Checked = True Then
            jenis_kelamin = "WANITA"
        End If

        Select Case jenis_kelamin
            Case "PRIA"
                pesan &= Environment.NewLine
                pesan &= "Anda seorang pria"
            Case "WANITA"
                pesan &= Environment.NewLine
                pesan &= "Anda seorang wanita"
            Case Else
                pesan &= Environment.NewLine
                pesan &= "Anda belum memilih jenis kelamin"
        End Select

        ShowMessage(pesan)
    End Sub

    Private Sub ShowMessage(ByVal message As String)
        MsgBox(message, MsgBoxStyle.Information, "Message")
    End Sub
End Class
