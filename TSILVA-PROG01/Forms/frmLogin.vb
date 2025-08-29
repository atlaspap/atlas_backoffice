Public Class frmLogin

    Public mFLG_Entidade As String = "C"
    Public mCard_Entidade As String
    Private Sub picLogin_Click(sender As Object, e As EventArgs) Handles picLogin.Click
        cmdLogin()
    End Sub
    Sub cmdLogin()
        If TextEditUsername.Text <> "" And TextEditPassword.Text <> "" Then
            Dim mLogins As ClsLogins = ClsLogins.GetLoginByUsername(TextEditUsername.Text)

            If mLogins.Login Is Nothing Then
                MsgBox("Nome de Utilizador ou Palavra-Passe incorretos.")
            Else
                If mLogins.Password = TextEditPassword.Text Then

                    mFLG_Entidade = mLogins.FLG_Entidade
                    mCard_Entidade = mLogins.Num_Cartao

                    If mFLG_Entidade = "E" Or mFLG_Entidade = "A" Then
                        frmMain.Show()
                        frmMain.Load_Main()
                        Me.Hide()

                        TextEditPassword.Text = ""
                        TextEditUsername.Text = ""
                    Else
                        MsgBox("Não tem permissões suficientes para aceder à aplicação.", vbExclamation, "Acesso Negado")
                    End If
                Else
                    MsgBox("Nome de Utilizador ou Palavra-Passe incorretos.", vbCritical, "Erro de Login")
                End If

            End If
        End If
    End Sub

    Private Sub cbPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbPassword.CheckedChanged
        If cbPassword.Checked Then
            TextEditPassword.Properties.PasswordChar = ""
        Else
            TextEditPassword.Properties.PasswordChar = "*"
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextEditUsername.Focus()
    End Sub

    Private Sub TextEditPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextEditPassword.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
            cmdLogin()
        End If
    End Sub
End Class