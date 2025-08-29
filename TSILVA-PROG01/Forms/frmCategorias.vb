

Imports System.IO
Imports DevExpress.XtraBars.Ribbon

''' <summary>
'''      Classe frmCategorias- Form da Tabela de Categorias
'''      Gerado em 09/12/2024 14:34:54
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class frmCategorias
    Dim mLista As New List(Of ClsCategorias)

    Dim mPath As String = Application.StartupPath + "\..\..\Images\Categorias\"

    Private Sub frmCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mLista = ClsCategorias.GetCategorias
        mNav = New clsNav(mLista.Count)

        UC_NAV11.mFRM = Me

        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()
        LoadRegistos()

        Me.Text = "Manutenção da Tabela de Categorias"

        '-------------------------------
        'Exemplo de ProgressBar
        '-------------------------------
        'upBar.Maximum = mNav.Max_Registos
        'upBar.Minimum = 1
        'upBar.Value = mNav.RegistoAtual
        '-------------------------------


        '-------------------------------
        'Exemplo de Combo...
        '-------------------------------

        '-----------------
        'ucPaises
        '-----------------
        'ucPaises.DataSource = clsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"

        '----------------------------------------------------------------------------------------------
        ' Como se faz um Filtro da Lista de Clientes?
        ' 
        ' A mLista que contém a lista de Categorias
        ' pode ser filtrada através do método
        ' FiltrarCategorias com o parâmetro da ClsCategorias
        ' 
        ' É preciso criar uma variável do tipo ClsCategorias
        ' e chamar o método FiltrarCategorias com esse parâmetro:
        '
        '   Dim mclsFiltro as New clsCategorias with {.Cod_Categoria=txtCod_Categoria.Text, .Designacao=txtDesignacao.Text}
        '   Dim mListaFiltro = clsCategorias.FiltrarCategorias(mclsFiltro)
        '----------------------------------------------------------------------------------------------

        '-----------------
        'ucPaises
        '-----------------
        'ucPaises.DataSource = clsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"


    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        Me.Cod_CategoriaTextEdit.ReadOnly = True
        If Not pBool Then
            If Me.UC_NAV11.mNovo Then
                Me.Cod_CategoriaTextEdit.Focus()
            Else
                Me.DesignacaoTextEdit.Focus()
            End If
        End If
        DesignacaoTextEdit.ReadOnly = pBool
        Cod_ImagemTextEdit.ReadOnly = pBool
        ContadorTextEdit.ReadOnly = pBool
        cmdCarregar.Enabled = Not pBool
        '------------------------------
        'Exemplo da eventual UltraCmbo 
        '------------------------------
        'Me.PaisUltraCombo.ReadOnly = pBool

    End Sub

    Sub LoadRegistos()
        LimpaTXT()
        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)
                DesignacaoTextEdit.Text = .Designacao
                Cod_ImagemTextEdit.Text = .Cod_Imagem
                ContadorTextEdit.Text = .Contador
                '-------------------------
                ' Cod_Categoria
                '-------------------------
                Cod_CategoriaTextEdit.Text = .Cod_Categoria

                If Trim(.Cod_Imagem) <> "" Then
                    Try
                        PictureBox1.Image = Image.FromFile(mPath + .Cod_Imagem)
                        PictureBox1.Image.Tag = .Cod_Imagem

                    Catch ex As Exception
                        MsgBox("Erro em colocar a imgem na PB1")
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

        DesignacaoTextEdit.Text = ""
        Cod_ImagemTextEdit.Text = ""
        ContadorTextEdit.Text = ""
        '-------------------------------
        Cod_CategoriaTextEdit.Text = ""
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsCategorias
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls
            If pbNovo Then
                '--------------------------------------
                'Método Não criado na CLASSE 
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Categoria = ClsCategorias.GetNovoCodigo
                '--------------------------------------
            Else
                '--------------------------------------
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Categoria = Cod_CategoriaTextEdit.Text
            End If
            '----------------------------------
            'Aqui VERIFICAR Todos os CAMPOS
            '  Não tem por ex. o FLG_Ativo...
            '----------------------------------
            .Designacao = DesignacaoTextEdit.Text


            If .Cod_Imagem <> "" Then
                .Cod_Imagem = Cod_ImagemTextEdit.Text
            Else
                .Cod_Imagem = Me.PictureBox1.Tag
            End If



            .Contador = ContadorTextEdit.Text
        End With

        If pbNovo Then
            mFLG_Gravou = ClsCategorias.GravaCategorias(mCls)
        Else
            mFLG_Gravou = ClsCategorias.ModificaCategorias(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV11.mNovo = False
                mLista = ClsCategorias.GetCategorias
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Categoria = mCls.Cod_Categoria) + 1
                LoadRegistos()

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsCategorias.GetCategorias
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
            ClsCategorias.ApagaCategorias(mLista(mNav.Registo_Atual - 1).Cod_Categoria)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsCategorias.GetCategorias
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub

    Private Sub cmdCarregar_Click(sender As Object, e As EventArgs) Handles cmdCarregar.Click
        Carregar_Imagem()
    End Sub

    Sub Carregar_Imagem()
        Dim mCont As Integer = 0
        Dim mFileDestino As String = mPath + "Default.png"

        OpenFileDialog1.Filter = "JPG|*.jpg|PNG|*.png|Todos os Ficheiros|*.*"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then

            Dim mFileName As String = OpenFileDialog1.SafeFileName.ToString
            Dim mLen As Integer = Len(mFileName)
            Dim mExt As String = mFileName.Substring(mLen - 4, 4)

            mFileDestino += mExt

            If UC_NAV11.mNovo Then
                Cod_CategoriaTextEdit.Text = ClsCategorias.GetNovoCodigo
            End If

            Me.Cod_ImagemTextEdit.Text = Cod_CategoriaTextEdit.Text + mExt
            mFileDestino = mPath + Cod_CategoriaTextEdit.Text + mExt

Cont:
            Try
                File.Copy(OpenFileDialog1.FileName, mFileDestino, True)
            Catch ex As Exception

                If File.Exists(mFileDestino) Then
                    mCont += 1
                    mFileDestino = mPath + Cod_CategoriaTextEdit.Text + mCont.ToString("00") + mExt
                    GoTo Cont
                End If


            End Try
            Me.PictureBox1.Image = Image.FromFile(mFileDestino)

            If mCont > 0 Then
                Me.PictureBox1.Tag = Cod_CategoriaTextEdit.Text + mCont.ToString("00") + mExt
            Else
                Me.PictureBox1.Tag = Cod_CategoriaTextEdit.Text + mExt
            End If

        End If
    End Sub
End Class
