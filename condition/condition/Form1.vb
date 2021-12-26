Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim pilihan, pesan As String
        pilihan = ComboBoxAnswer.Text
        pesan = ""

        Select Case pilihan
            Case "A."
                pesan = "Anda memilih jawaban A."
            Case "B."
                pesan = "Anda memilih jawaban B."
            Case "C."
                pesan = "Anda memilih jawaban C."
            Case "D."
                pesan = "Anda memilih jawaban D."
            Case "E."
                pesan = "Anda memilih jawaban E."
            Case Else
                pesan = "Anda belum memilih jawaban"
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

        If Pria.Checked = True Then
            pesan &= "Jenis Kelamin Anda Laki-laki"
        ElseIf Wanita.Checked = True Then
            pesan &= "Jenis Kelamin Anda Perempuan"
        Else
            pesan &= "Anda belum memilih jenis kelamin"
        End If

        show_message(pesan)
    End Sub

    Private Sub show_message(ByVal msg As String)
        MsgBox(msg, MsgBoxStyle.Information, "Message")
    End Sub

End Class
