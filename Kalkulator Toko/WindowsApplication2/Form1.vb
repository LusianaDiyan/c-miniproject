Public Class Form1


    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbayar.Click
        Dim apply As Integer
        apply = (harga.Text * jumlah.Text - ((harga.Text * jumlah.Text) * diskon.Text / 100))
        kembalian.Text = pembayaran.Text - apply
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jumlah.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles diskon.TextChanged

    End Sub

    Private Sub cmdapply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdapply.Click
        Dim apply As Integer
        apply = (harga.Text * jumlah.Text - ((harga.Text * jumlah.Text) * diskon.Text / 100))
        total.Text = apply
    End Sub

    Private Sub cmdbaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdbaru.Click
        id.Text = ""
        nama.Text = ""
        jumlah.Text = ""
        harga.Text = "0"
        diskon.Text = ""
        total.Text = "0"
        pembayaran.Text = "0"
        kembalian.Text = "0"
    End Sub

    Private Sub cmdkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdkeluar.Click
        Close()
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub
End Class
