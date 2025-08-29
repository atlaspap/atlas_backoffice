Imports System.IO

Imports DevExpress.Utils.CommonDialogs
Imports Infragistics.Win.UltraWinListView

''' <summary>
'''      Classe frmSub_Categorias- Form da Tabela de Sub_Categorias
'''      Gerado em 09/12/2024 14:34:57
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class frmSub_Categorias
    Dim mLista As New List(Of ClsSub_Categorias)
    Dim mLista_Categorias As New List(Of ClsCategorias)

    Dim mIndex_Categoria As Integer = 0

    Dim mPath As String = Application.StartupPath + "\..\..\Images\Sub_Categorias\"
    Dim mPath_Categorias As String = Application.StartupPath + "\..\..\Images\Categorias\"

    Sub Init_Categorias()

        Dim mCod_Categoria As String
        If mLista_Categorias.Count > 0 Then
            mCod_Categoria = mLista_Categorias(0).Cod_Categoria

            mLista = ClsSub_Categorias.GetSub_Categorias(mCod_Categoria)
        End If



    End Sub


    Private Sub frmSub_Categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mLista_Categorias = ClsCategorias.GetCategorias

        Init_Categorias()


        mNav = New clsNav(mLista.Count)

        UC_NAV11.mFRM = Me

        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()
        LoadRegistos()

        Me.Text = "Manutenção da Tabela de Sub_Categorias"

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
        ' A mLista que contém a lista de Sub_Categorias
        ' pode ser filtrada através do método
        ' FiltrarSub_Categorias com o parâmetro da ClsSub_Categorias
        ' 
        ' É preciso criar uma variável do tipo ClsSub_Categorias
        ' e chamar o método FiltrarSub_Categorias com esse parâmetro:
        '
        '   Dim mclsFiltro as New clsSub_Categorias with {.Cod_Sub_Categoria=txtCod_Sub_Categoria.Text, .Cod_Categoria=txtCod_Categoria.Text}
        '   Dim mListaFiltro = clsSub_Categorias.FiltrarSub_Categorias(mclsFiltro)
        '----------------------------------------------------------------------------------------------

        '-----------------
        'ucCategorias
        '-----------------
        ucCategorias.DataSource = ClsCategorias.GetCategorias
        ucCategorias.DisplayMember = "Designacao"
        ucCategorias.ValueMember = "Cod_Categoria"


        Load_ListView1()


        ucCategorias.SelectedRow = ucCategorias.Rows(0)

        Get_Imagem_Categoria()
    End Sub

    Sub Load_ListView1()
        For Each pCat As ClsCategorias In mLista_Categorias
            With ListView1
                .Items.Add(pCat.Designacao)
            End With
        Next
    End Sub



    Sub SetupComps(ByVal pBool As Boolean)
        Me.Cod_Sub_CategoriaTextEdit.ReadOnly = True
        If Not pBool Then
            If Me.UC_NAV11.mNovo Then
                Cod_CategoriaTextEdit.Text = mLista_Categorias(mIndex_Categoria).Cod_Categoria
                Cod_Sub_CategoriaTextEdit.Text = ClsSub_Categorias.GetNovoCodigo(mLista_Categorias(mIndex_Categoria))
                Me.DesignacaoTextEdit.Focus()
            Else
                Me.DesignacaoTextEdit.Focus()
            End If
        End If
        Cod_CategoriaTextEdit.ReadOnly = pBool
        DesignacaoTextEdit.ReadOnly = pBool
        Cod_ImagemTextEdit.ReadOnly = pBool

        '------------------------------
        'Exemplo da eventual UltraCmbo 
        '------------------------------
        'Me.PaisUltraCombo.ReadOnly = pBool

    End Sub

    Sub LoadRegistos()
        LimpaTXT()
        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)
                Cod_CategoriaTextEdit.Text = .Cod_Categoria
                DesignacaoTextEdit.Text = .Designacao
                Cod_ImagemTextEdit.Text = .Cod_Imagem
                '-------------------------
                ' Cod_Sub_Categoria
                '-------------------------
                Cod_Sub_CategoriaTextEdit.Text = .Cod_Sub_Categoria

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
                ucCategorias.Text = ClsCategorias.GetCategoriasByCod(.Cod_Categoria).Designacao

                'ucPaises.Text = clsPaises.GetPaisbyCod(.Cod_Pais).Pais
            End With
            '-------------------------------
            'upBar.Value = mNav.Registo_Atual
            '-------------------------------

        End If

    End Sub

    Sub LimpaTXT()

        Cod_CategoriaTextEdit.Text = ""
        DesignacaoTextEdit.Text = ""
        Cod_ImagemTextEdit.Text = ""
        '-------------------------------
        Cod_Sub_CategoriaTextEdit.Text = ""
        PictureBox1.Image = Nothing
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsSub_Categorias
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls
            If pbNovo Then
                '--------------------------------------
                'Método Não criado na CLASSE 
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------

                .Cod_Sub_Categoria = Cod_Sub_CategoriaTextEdit.Text
                '--------------------------------------
            Else
                '--------------------------------------
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Sub_Categoria = Cod_Sub_CategoriaTextEdit.Text
            End If
            '----------------------------------
            'Aqui VERIFICAR Todos os CAMPOS
            '  Não tem por ex. o FLG_Ativo...
            '----------------------------------
            .Cod_Categoria = mLista_Categorias(mIndex_Categoria).Cod_Categoria
            .Designacao = DesignacaoTextEdit.Text
            .Cod_Imagem = Cod_ImagemTextEdit.Text
        End With

        If pbNovo Then
            mFLG_Gravou = ClsSub_Categorias.GravaSub_Categorias(mCls)
        Else
            mFLG_Gravou = ClsSub_Categorias.ModificaSub_Categorias(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV11.mNovo = False
                mLista_Categorias = ClsCategorias.GetCategorias
                mLista = ClsSub_Categorias.GetSub_Categorias(mLista_Categorias(mIndex_Categoria).Cod_Categoria)
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Sub_Categoria = mCls.Cod_Sub_Categoria) + 1
                LoadRegistos()

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsSub_Categorias.GetSub_Categorias(mLista_Categorias(mIndex_Categoria).Cod_Categoria)
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
            ClsSub_Categorias.ApagaSub_Categorias(mLista(mNav.Registo_Atual - 1).Cod_Sub_Categoria)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsSub_Categorias.GetSub_Categorias(mLista_Categorias(mIndex_Categoria).Cod_Categoria)
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
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
                Cod_Sub_CategoriaTextEdit.Text = ClsSub_Categorias.GetNovoCodigo(mLista_Categorias(mIndex_Categoria))

            End If

            Me.Cod_ImagemTextEdit.Text = Cod_Sub_CategoriaTextEdit.Text + mExt
            mFileDestino = mPath + Cod_Sub_CategoriaTextEdit.Text + mExt
Cont:
            Try
                File.Copy(OpenFileDialog1.FileName, mFileDestino, True)
            Catch ex As Exception

                If File.Exists(mFileDestino) Then
                    mCont += 1
                    mFileDestino = mPath + Cod_Sub_CategoriaTextEdit.Text + mCont.ToString("00") + mExt
                    GoTo Cont
                End If


            End Try
            Me.PictureBox1.Image = Image.FromFile(mFileDestino)

            If mCont > 0 Then
                Me.PictureBox1.Tag = Cod_Sub_CategoriaTextEdit.Text + mCont.ToString("00") + mExt
            Else
                Me.PictureBox1.Tag = Cod_Sub_CategoriaTextEdit.Text + mExt
            End If

        End If
    End Sub

    Private Sub cmdCarrega_Click(sender As Object, e As EventArgs) Handles cmdCarrega.Click
        Carregar_Imagem()
    End Sub

    Sub Get_Imagem_Categoria()

        mIndex_Categoria = ucCategorias.ActiveRow.Index

        Dim mCategoria As New ClsCategorias
        mCategoria = mLista_Categorias(mIndex_Categoria)

        With mCategoria

            If Trim(.Cod_Imagem) <> "" Then
                Try
                    PictureBox2.Image = Image.FromFile(mPath_Categorias + .Cod_Imagem)
                    PictureBox2.Image.Tag = .Cod_Imagem

                Catch ex As Exception
                    PictureBox2.Image = Image.FromFile(mPath_Categorias + "Default.png")
                    PictureBox2.Image.Tag = .Cod_Imagem
                    'MsgBox("Erro em colocar a imgem na PB1")
                End Try
            Else
                PictureBox2.Image = Image.FromFile(mPath_Categorias + "Default.png")
                PictureBox2.Image.Tag = .Cod_Imagem

            End If
            Me.Cod_CategoriaTextEdit.Text = .Cod_Categoria
        End With


    End Sub

    Private Sub ucCategorias_AfterCloseUp(sender As Object, e As EventArgs) Handles ucCategorias.AfterCloseUp, ucCategorias.Leave

        Get_Imagem_Categoria()

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        mIndex_Categoria = ListView1.Items(0).Index
        Init_Categorias()
        LoadRegistos()

    End Sub
    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        mIndex_Categoria = ListView1.SelectedItems(0).Index
    End Sub
End Class
