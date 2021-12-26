Public Class FormBiodata

    Private Sub FormBiodata_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBoxTGL.Text = "Tgl"
        ComboBoxBULAN.Text = "Bulan"
        ComboBoxTAHUN.Text = "Tahun"
        ComboBoxAGAMA.Text = "Agama"
    End Sub

    Private Sub ComboBoxTGL_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxTGL.SelectedIndexChanged

    End Sub

    Private Sub ButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click
        Label8.Text = TextBoxNAMA.Text
        Label9.Text = TextBoxPANGGILAN.Text
        Label10.Text = TextBoxTTL.Text & ", " & ComboBoxTGL.Text & " " & ComboBoxBULAN.Text & " " & ComboBoxTAHUN.Text
        Label11.Text = ComboBoxAGAMA.Text
        Label12.Text = TextBoxALAMAT.Text

        If RadioButtonLAKI.Checked Then
            Label13.Text = "LAKI-LAKI"
        ElseIf RadioButtonPEREMPUAN.Checked Then
            Label13.Text = "PEREMPUAN"
        End If

        If CheckBox1.Checked Then
            ListBoxMATKUL.Items.Add("MS OFFICE TERINTEGRASI")
        End If

        If CheckBox2.Checked Then
            ListBoxMATKUL.Items.Add("SISTEM BASIS DATA DENGAN MS ACCESS")
        End If

        If CheckBox3.Checked Then
            ListBoxMATKUL.Items.Add("SISTEM BASIS DATA DENGAN SQL SERVER")
        End If

        If CheckBox4.Checked Then
            ListBoxMATKUL.Items.Add("PEMROGRAMAN WEB DENGAN PHP DAN MYSQL")
        End If

        If CheckBox5.Checked Then
            ListBoxMATKUL.Items.Add("PEMROGRAMAN VISUAL BASIC.NET")
        End If
    End Sub

    Private Sub ButtonHPS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHPS.Click
        TextBoxNAMA.Text = ""
        TextBoxPANGGILAN.Text = ""
        TextBoxTTL.Text = ""
        ComboBoxTGL.Text = ""
        ComboBoxBULAN.Text = ""
        ComboBoxTAHUN.Text = ""
        ComboBoxAGAMA.Text = ""
        TextBoxALAMAT.Text = ""
        RadioButtonLAKI.Checked = False
        RadioButtonPEREMPUAN.Checked = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
    End Sub

    Private Sub ButtonEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEXT.Click
        End
    End Sub
End Class
