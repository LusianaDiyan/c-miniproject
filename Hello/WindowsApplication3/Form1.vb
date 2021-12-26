Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim pesan As String
        Dim nama_mahasiswa As String
        Dim usia As String

        nama_mahasiswa = "LUSIANA DIYAN NINGRUM"
        usia = 18

        pesan = "Nama : " & nama_mahasiswa & Environment.NewLine
        pesan &= "Usia : " & usia

        MsgBox(pesan, MsgBoxStyle.Information, "Hello!")
    End Sub
End Class
