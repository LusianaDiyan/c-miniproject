Public Class Form1

    Private Sub OpenMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenMenuItem.Click
        DisplayMessage("event click Menu Open")
    End Sub


    Private Sub DisplayMessage(ByVal pesan As String)
        MsgBox(pesan, MsgBoxStyle.Information, "Message")
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DisplayMessage("event click ToolStripButton1")
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        DisplayMessage("event click Klik Kanan Refresh")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub ButtonProgressBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonProgressBar.Click
        With ProgressBarSimulation
            Dim i As Integer
            For i = 0 To 10000000
                .Value = i
            Next
        End With
    End Sub

    
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        StatusLabelProgress.Text = Date.Now.ToLongTimeString
    End Sub
End Class
