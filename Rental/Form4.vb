Public Class Form4

    Private Sub BtnPesan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPesan.Click
        With PbPesan
            Dim i As Integer
            For i = 0 To 100
                ' klo gak ada "With", hrs ditulis:
                ' PbPesan.Value = i
                .Value = i

                Threading.Thread.Sleep(50)
            Next
        End With

        MsgBox("Menu yang dipesan telah tersedia")
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SbTanggal.Text = Date.Today

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        SbWaktu.Text = Date.Now.ToLongTimeString
    End Sub
End Class