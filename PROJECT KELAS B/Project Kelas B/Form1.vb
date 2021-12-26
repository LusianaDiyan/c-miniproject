Public Class FormUtama
    
    Private Sub FormUtama_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        MsgBox("anda yakin akan hapus data ini?", MsgBoxStyle.YesNo, "HAPUS DATA")
    End Sub

    Private Sub FormUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("Hello World")
        Dim usia As String
        usia = "30"
        MsgBox(Nama)
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        'pendeklarasian variabel lokal
        Dim gaji As Decimal
        gaji = 3000000
        MsgBox("Nama saya: " & txtnama.Text & vbCrLf & "Alamat: " & txtalamat.Text & vbCrLf & "usia: " & Txtusia.Text, MsgBoxStyle.Information, "BIODATA")
    End Sub

    Private Sub txtnama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnama.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtalamat.TextChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtusia.TextChanged

    End Sub
End Class
