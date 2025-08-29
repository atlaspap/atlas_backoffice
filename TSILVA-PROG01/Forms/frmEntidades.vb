

Imports System.IO

''' <summary>
'''      Classe frmEntidades- Form da Tabela de Entidades
'''      Gerado em 23/01/2025 15:59:29
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Class frmEntidades
    Dim mLista As New List(Of ClsEntidades)
    Dim mListaPT_Enderecos As New List(Of ClsPT_Enderecos)
    Dim mLista_CodPostal As New List(Of String)
    Dim mFLG_Password As Boolean = False

    Dim mCod_Postal As String

    Dim mPath As String = Application.StartupPath + "\..\..\Images\Entidades\"
    Private Sub frmEntidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mLista = ClsEntidades.GetEntidades

        mLista_CodPostal = ClsPT_Enderecos.GetCod_Postal

        mNav = New clsNav(mLista.Count)

        UC_NAV11.mFRM = Me

        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()

        LoadRegistos()

        Me.Text = "Manutenção da Tabela de Entidades"

        With ucCod_Postal
            .DataSource = mLista_CodPostal
        End With

    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        Me.Cod_EntidadeTextEdit.ReadOnly = True
        If Not pBool Then
            If Me.UC_NAV11.mNovo Then
                Me.Cod_EntidadeTextEdit.Focus()
                Data_RegistoDateEdit.Text = Date.Now.ToString()
            Else
                Me.FLG_EntidadeTextEdit.Focus()
            End If
        End If
        FLG_EntidadeTextEdit.ReadOnly = pBool
        Num_CartaoTextEdit.ReadOnly = pBool
        LoginTextEdit.ReadOnly = pBool
        PasswordTextEdit.ReadOnly = pBool
        NomeTextEdit.ReadOnly = pBool
        Cod_ImagemTextEdit.ReadOnly = pBool
        LocalidadeTextEdit.ReadOnly = pBool
        ucCod_Postal.ReadOnly = pBool
        EnderecoTextEdit.ReadOnly = pBool
        Num_TelefoneTextEdit.ReadOnly = pBool
        Num_TelemovelTextEdit.ReadOnly = pBool
        EmailTextEdit.ReadOnly = pBool
        NIFTextEdit.ReadOnly = pBool
        Data_RegistoDateEdit.ReadOnly = Enabled
        cmdImage.Enabled = Not pBool
        If cmdImage.Enabled Then
            cmdImage.Cursor = Cursors.Hand
        Else
            cmdImage.Cursor = Cursors.Default
        End If

        '------------------------------
        'Exemplo da eventual UltraCmbo 
        '------------------------------
        'Me.PaisUltraCombo.ReadOnly = pBool

    End Sub

    Sub LoadRegistos()
        LimpaTXT()
        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)
                FLG_EntidadeTextEdit.Text = .FLG_Entidade
                Num_CartaoTextEdit.Text = .Num_Cartao
                LoginTextEdit.Text = .Login

                PasswordTextEdit.Properties.PasswordChar = "*"
                PasswordTextEdit.Text = .Password

                NomeTextEdit.Text = .Nome
                Cod_ImagemTextEdit.Text = .Cod_Imagem
                LocalidadeTextEdit.Text = .Localidade
                EnderecoTextEdit.Text = .Endereco
                ucCod_Postal.Text = .Cod_Postal
                Num_TelefoneTextEdit.Text = .Num_Telefone
                Num_TelemovelTextEdit.Text = .Num_Telemovel
                EmailTextEdit.Text = .Email
                NIFTextEdit.Text = .NIF
                Data_RegistoDateEdit.Text = .Data_Registo
                '-------------------------
                ' Cod_Entidade
                '-------------------------
                Cod_EntidadeTextEdit.Text = .Cod_Entidade

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

                '-------------------------------
                'Exemplo para as Combos...
                '-------------------------------
                'ucPaises.Text = clsPaises.GetPaisbyCod(.Cod_Pais).Pais
            End With
            '-------------------------------
            'upBar.Value = mNav.Registo_Atual
            '-------------------------------

        End If

    End Sub

    Sub LimpaTXT()

        FLG_EntidadeTextEdit.Text = ""
        Num_CartaoTextEdit.Text = ""
        LoginTextEdit.Text = ""
        PasswordTextEdit.Text = ""
        NomeTextEdit.Text = ""
        Cod_ImagemTextEdit.Text = ""
        LocalidadeTextEdit.Text = ""
        ucCod_Postal.Text = ""
        EnderecoTextEdit.Text = ""
        Num_TelefoneTextEdit.Text = ""
        Num_TelemovelTextEdit.Text = ""
        EmailTextEdit.Text = ""
        NIFTextEdit.Text = ""
        Data_RegistoDateEdit.Text = ""
        '-------------------------------
        Cod_EntidadeTextEdit.Text = ""

        PictureBox1.Image = Image.FromFile(mPath + "Default.png")
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsEntidades
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        Dim mClsEnderecos As New ClsEnderecos

        With mCls
            If pbNovo Then
                '--------------------------------------
                'Método Não criado na CLASSE 
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Entidade = ClsEntidades.GetNovoCodigo(FLG_EntidadeTextEdit.Text)
                Data_RegistoDateEdit.Text = Date.Now



                '--------------------------------------
            Else
                .Cod_Entidade = Cod_EntidadeTextEdit.Text
            End If
            '----------------------------------
            'Aqui VERIFICAR Todos os CAMPOS
            '  Não tem por ex. o FLG_Ativo...
            '----------------------------------
            .FLG_Entidade = FLG_EntidadeTextEdit.Text
            .Num_Cartao = Num_CartaoTextEdit.Text

            Dim mLogin As String
            Dim mAtualUser As String

            mLogin = ClsLogins.GetLoginByUsername(LoginTextEdit.Text).Login
            mAtualUser = ClsEntidades.GetEntidadesByCod(Cod_EntidadeTextEdit.Text).Login


            If mAtualUser <> LoginTextEdit.Text Then
                If mLogin <> Nothing Then
                    MsgBox("Esse nome de utilizador já está a ser utilizado.", vbCritical, "Nome de utilizador duplicado.")
                    Exit Sub
                Else
                    .Login = LoginTextEdit.Text
                End If
            Else
                .Login = LoginTextEdit.Text
            End If

            .Password = PasswordTextEdit.Text
            .Nome = NomeTextEdit.Text
            .Cod_Imagem = Cod_ImagemTextEdit.Text
            .Num_Telefone = Num_TelefoneTextEdit.Text
            .Num_Telemovel = Num_TelemovelTextEdit.Text
            .Email = EmailTextEdit.Text
            .NIF = NIFTextEdit.Text
            .Data_Registo = Data_RegistoDateEdit.Text
        End With

        With mClsEnderecos
            If pbNovo Then
                .Cod_Endereco = "E01"
            Else
                .Cod_Endereco = "E01"
            End If

            .Cod_Entidade = mCls.Cod_Entidade
            .Cod_Postal = ucCod_Postal.Text
            .Data_Registo = Data_RegistoDateEdit.Text
            .Descritivo = "Endereço de " & NomeTextEdit.Text & " [" & Cod_EntidadeTextEdit.Text & "]"
            .Endereco = EnderecoTextEdit.Text
            .Localidade = LocalidadeTextEdit.Text
        End With

        Dim mFLG_Enderecos As Boolean = False

        If pbNovo Then
            mFLG_Gravou = ClsEntidades.GravaEntidades(mCls)
            ClsEnderecos.GravaEnderecos(mClsEnderecos)
        Else
            If ClsEnderecos.GetEnderecosByCod(Cod_EntidadeTextEdit.Text, "E01").Endereco Is Nothing Then
                mFLG_Enderecos = ClsEnderecos.GravaEnderecos(mClsEnderecos)
            Else
                mFLG_Enderecos = ClsEnderecos.ModificaEnderecos(mClsEnderecos)
            End If

            mFLG_Gravou = ClsEntidades.ModificaEntidades(mCls) And mFLG_Enderecos

        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV11.mNovo = False
                mLista = ClsEntidades.GetEntidades
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Entidade = mCls.Cod_Entidade) + 1
                LoadRegistos()

            Else
                mLista = ClsEntidades.GetEntidades
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mRegisto_Atual
                LoadRegistos()
            End If
        Else
            MsgBox("Erro na gravação:")
        End If
    End Sub


    Sub Apaga_Registo()
        Try
            ClsEntidades.ApagaEntidades(mLista(mNav.Registo_Atual - 1).Cod_Entidade)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsEntidades.GetEntidades
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
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

            If UC_NAV11.mNovo Then
                Cod_EntidadeTextEdit.Text = ClsEntidades.GetNovoCodigo(FLG_EntidadeTextEdit.Text)
            End If

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

        End If
    End Sub

    Private Sub cmdImg_Click(sender As Object, e As EventArgs) Handles cmdImage.Click
        Load_Image()
    End Sub

    Private Sub ucCod_Postal_AfterCloseUp(sender As Object, e As EventArgs) Handles ucCod_Postal.AfterCloseUp
        mCod_Postal = ucCod_Postal.Text

        mListaPT_Enderecos = ClsPT_Enderecos.GetPT_EnderecosByCod_Postal(mCod_Postal)
        If mListaPT_Enderecos.Count > 0 Then
            Dim mIndex As Integer = 0

            LocalidadeTextEdit.Text = mListaPT_Enderecos(mIndex).Localidade
            EnderecoTextEdit.Text = mListaPT_Enderecos(mIndex).Endereco
        Else
            Me.ucCod_Postal.Focus()
        End If
    End Sub

    Private Sub pbPassword_Click(sender As Object, e As EventArgs) Handles pbPassword.Click
        SoH_Password()
    End Sub

    Sub SoH_Password()
        If mFLG_Password = False Then
            pbPassword.Image = My.Resources.eye_hide
            PasswordTextEdit.Properties.PasswordChar = ""
            mFLG_Password = True
        Else
            pbPassword.Image = My.Resources.eye_show
            PasswordTextEdit.Properties.PasswordChar = "*"
            mFLG_Password = False
        End If
    End Sub
End Class
