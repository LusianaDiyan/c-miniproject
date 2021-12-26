Public Class frmLogin

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim UserName, Password As String

        UserName = txtUser.Text
        Password = txtPassword.Text

        If UserName = "Papsi" And Password = "Papsi123" Then
            MsgBox("Login Sukses", MsgBoxStyle.Information, "Info")
        Else
            MsgBox("Login Gagal", MsgBoxStyle.Critical, "Info")

            txtUser.Text = ""
            txtPassword.Text = ""

        End If

    End Sub

    Private Sub ckPassword_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckPassword.CheckedChanged

        If ckPassword.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If

    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUser.Focus()
    End Sub
End Class
