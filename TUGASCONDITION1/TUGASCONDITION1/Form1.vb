Public Class Form1

    Private Sub ButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click
        Dim nama_lengkap As String
        Dim pesan As String
        nama_lengkap = TextBoxNama.Text
        pesan = ""

        pesan &= Environment.NewLine
        Dim kelas As String
        kelas = ComboBoxKelas.Text

            Select Case kelas
                Case "A"
                pesan = nama_lengkap & " memilih kelas A (Pagi)"
                Case "B"
                pesan = nama_lengkap & "Anda memilih kelas B (Siang)"
                Case "C"
                pesan = nama_lengkap & "Anda memilih kelas C (Siang)"
                Case "D"
                pesan = nama_lengkap & "Anda memilih kelas D (Sore)"
                Case "E"
                pesan = nama_lengkap & "Anda memilih kelas E (Malam)"
                Case Else
                pesan = nama_lengkap & "Anda belum memilih kelas"
            End Select

            pesan &= Environment.NewLine
            Dim usia As Integer
            usia = CInt(NumericUpDownUsia.Value)

            If usia >= 0 And usia <= 4 Then
                pesan &= "Usia Anda saat ini belum cukup untuk menempuh pendidikan formal"
            ElseIf usia >= 5 And usia <= 6 Then
                pesan &= "Usia Anda saat ini masuk dalam jenjang TK"
            ElseIf usia >= 7 And usia <= 12 Then
                pesan &= "Usia Anda saat ini masuk dalam jenjang SD"
            ElseIf usia >= 13 And usia <= 15 Then
                pesan &= "Usia Anda saat ini masuk dalam jenjang SMP"
            ElseIf usia >= 15 And usia <= 18 Then
                pesan &= "Usia Anda saat ini masuk dalam jenjang SMA"
            ElseIf usia >= 19 And usia <= 22 Then
                pesan &= "Usia Anda saat ini masuk dalam jenjang PT"
            Else
                pesan &= "Anda sudah tua"
            End If

            pesan &= Environment.NewLine

            If RadioButton1.Checked = True Then
                pesan &= "Jenis Kelamin Anda Laki-laki"
            ElseIf RadioButtonWanita.Checked = True Then
                pesan &= "Jenis Kelamin Anda Perempuan"
            Else
                pesan &= "Anda belum memilih jenis kelamin"
            End If

            pesan &= Environment.NewLine
            Dim alamat, keterangan As String
            alamat = RichTextBoxAlamat.Text
        pesan &= "Alamat Anda : " & alamat

        pesan &= Environment.NewLine
        Dim nrp, semester As String
        nrp = TextBoxNRP.Text
        pesan &= "NRP Anda : " & nrp & Environment.NewLine

        semester = TextBoxSemester.Text
        pesan &= "Anda sekarang berada pada semester " & semester

        pesan &= Environment.NewLine
        Dim ipk As Decimal
        ipk = TextBoxIPK.Text
        pesan &= "IPK Anda : " & ipk

        pesan &= Environment.NewLine
        keterangan = RichTextBoxKet.Text
        pesan &= keterangan

        show_message(pesan)
    End Sub

    Private Sub show_message(ByVal pesan As String)
        MsgBox(pesan, MsgBoxStyle.Information, "Message")
    End Sub

    Private Sub ButtonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        TextBoxNama.Text = ""
        TextBoxNRP.Text = ""
        NumericUpDownUsia.Value = "0"
        RichTextBoxAlamat.Text = ""
        ComboBoxKelas.Text = ""
        TextBoxSemester.Text = ""
        TextBoxIPK.Text = ""
        RichTextBoxKet.Text = ""
        RadioButton1.Checked = False
        RadioButtonWanita.Checked = False
        CheckedListBoxMatkul.CheckOnClick = False

    End Sub

    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        Close()
    End Sub

End Class
