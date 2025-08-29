Public Class frmLeitor

    'Dim mPath As String = My.Settings.IMAGES_PATH + "\Entidades\"


    Dim mPath As String = Application.StartupPath + "\..\..\Images\Entidades\"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        TextEdit1.Focus()

        NomeTextEdit.ReadOnly = True
        Num_TelefoneTextEdit.ReadOnly = True
        Num_TelemovelTextEdit.ReadOnly = True
        EmailTextEdit.ReadOnly = True
        Cod_ImagemTextEdit.ReadOnly = True



    End Sub

    Private Sub TextEdit1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextEdit1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            Load_Info()
            e.Handled = True
            TextEdit1.Focus()
        End If
    End Sub

    Sub Load_Info()
        Dim mLista As New ClsEntidades

        mLista = ClsEntidades.GetEntidadesByCard(TextEdit1.Text)

        With mLista
            NomeTextEdit.Text = .Nome
            Num_TelefoneTextEdit.Text = .Num_Telefone
            Num_TelemovelTextEdit.Text = .Num_Telemovel
            EmailTextEdit.Text = .Email
            Cod_ImagemTextEdit.Text = .Cod_Imagem

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




            TextEdit1.Focus()

        End With


    End Sub

    Private Sub cmdClear(sender As Object, e As EventArgs) Handles cmdLim.Click
        TextEdit1.Focus()

        TextEdit1.Text = ""
        NomeTextEdit.Text = ""
        Num_TelefoneTextEdit.Text = ""
        Num_TelemovelTextEdit.Text = ""
        EmailTextEdit.Text = ""
        Cod_ImagemTextEdit.Text = ""

        PictureBox1.Image = Image.FromFile(mPath + "Default.png")
        PictureBox1.Image.Tag = "Default"
    End Sub
End Class