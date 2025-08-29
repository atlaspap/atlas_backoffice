Imports DevExpress.Utils.CommonDialogs
Imports System.IO

Public Class frmPerfil
    Dim mCard As String = frmLogin.mCard_Entidade
    Dim mEntidade As New ClsEntidades
    Dim mFLG_Password As Boolean = False

    Dim mPath As String = Application.StartupPath + "\..\..\Images\Entidades\"

    Private Sub frmPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mEntidade = ClsEntidades.GetEntidadesByCard(mCard)

        Setup_Comps()
        Load_Registos()
    End Sub

    Sub Setup_Comps()

        Cod_EntidadeTextEdit.ReadOnly = True
        NomeTextEdit.ReadOnly = True
        LoginTextEdit.ReadOnly = True
        PasswordTextEdit.ReadOnly = True
        EmailTextEdit.ReadOnly = True

    End Sub

    Sub Load_Registos()

        With mEntidade
            Cod_EntidadeTextEdit.Text = .Cod_Entidade
            NomeTextEdit.Text = .Nome
            LoginTextEdit.Text = .Login
            PasswordTextEdit.Text = .Password
            EmailTextEdit.Text = .Email

            If Trim(.Cod_Imagem) <> "" Then
                Try
                    PictureBox1.Image = Image.FromFile(mPath + .Cod_Imagem)
                    PictureBox1.Image.Tag = .Cod_Imagem
                Catch ex As Exception
                    MsgBox("Erro em colocar a imagem na PB1")
                End Try
            Else
                PictureBox1.Image = Image.FromFile(mPath + "Default.png")
                PictureBox1.Image.Tag = .Cod_Imagem
            End If
        End With

    End Sub

    Sub Load_Image()
        Dim mCont As Integer = 0
        Dim mFileDestiny As String = mPath + "Default.png"

        OpenFileDialog1.Filter = "JPG|*.jpg|PNG|*.png|Todos os Ficheiros|*.*"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim mFileName As String = OpenFileDialog1.SafeFileName.ToString
            Dim mLen As Integer = Len(mFileName)
            Dim mExt As String = mFileName.Substring(mLen - 4, 4)

            mFileDestiny += mExt

            Me.Cod_ImagemTextEdit.Text = Cod_EntidadeTextEdit.Text + mExt
            mFileDestiny = mPath + Cod_EntidadeTextEdit.Text + mExt
Cont:
            Try
                File.Copy(OpenFileDialog1.FileName, mFileDestiny, True)
            Catch ex As Exception

                If File.Exists(mFileDestiny) Then
                    mCont += 1
                    mFileDestiny = mPath + Cod_EntidadeTextEdit.Text + mCont.ToString("00") + mExt
                    GoTo Cont
                End If
            End Try
            Me.PictureBox1.Image = Image.FromFile(mFileDestiny)

            If mCont > 0 Then
                Me.PictureBox1.Tag = Cod_EntidadeTextEdit.Text + mCont.ToString("00") + mExt
            Else
                Me.PictureBox1.Tag = Cod_EntidadeTextEdit.Text + mExt
            End If

            With mEntidade
                .Cod_Imagem = Me.PictureBox1.Tag
            End With

            ClsEntidades.ModificaEntidades(mEntidade)

        End If
    End Sub

    Sub SoH_Password()
        If mFLG_Password = False Then
            cmdShow_Password.Image = My.Resources.eye_hide
            PasswordTextEdit.Properties.PasswordChar = ""
            mFLG_Password = True
        Else
            cmdShow_Password.Image = My.Resources.eye_show
            PasswordTextEdit.Properties.PasswordChar = "*"
            mFLG_Password = False
        End If
    End Sub

    Private Sub cmdShow_Password_Click(sender As Object, e As EventArgs) Handles cmdShow_Password.Click
        SoH_Password()
    End Sub

    Private Sub cmdUpload_Click(sender As Object, e As EventArgs) Handles cmdUpload.Click
        Load_Image()
    End Sub
End Class