

Imports DevExpress.Pdf.Native.BouncyCastle.Utilities

Imports Microsoft.SqlServer

''' <summary>
'''      Classe frmParagens- Form da Tabela de Paragens
'''      Gerado em 30/01/2025 13:40:46
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Class frmParagens
    Dim mLista As New List(Of ClsParagens)

    Public Property rCod_Entidade As String
    Public Property rCod_Endereco As String

    Dim mCod_Postal As String

    Dim mClasse As New ClsEnderecos

    Dim mLista_Cod_Postal As New List(Of String)
    Dim mIndex_CP As Integer = 0

    Dim mListaPT_Enderecos As New List(Of ClsPT_Enderecos)

    Dim mCod_Distrito As Integer
    Dim mCod_Concelho As Integer

    Public Property rNovo As Boolean = False

    Async Sub FRM_LOAD1()
        Await WebView21.EnsureCoreWebView2Async(Nothing)
    End Sub
    Private Sub frmParagens_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FRM_LOAD1()

        mLista = ClsParagens.GetParagens
        mNav = New clsNav(mLista.Count)

        mLista_Cod_Postal = ClsPT_Enderecos.GetCod_Postal

        UC_NAV11.mFRM = Me

        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()
        LoadRegistos(True)

        Me.Text = "Manutenção da Tabela de Paragens"

        With ucCod_Postal
            .DataSource = mLista_Cod_Postal
        End With
    End Sub

    Sub SetupComps(ByVal pBool As Boolean)
        Me.Cod_ParagemTextEdit.ReadOnly = True
        Me.LocalizacaoTextEdit.ReadOnly = True
        If Not pBool Then
            If Me.UC_NAV11.mNovo Then
                Me.Cod_ParagemTextEdit.Focus()
            Else
                Me.DescritivoTextEdit.Focus()
            End If
        End If
        DescritivoTextEdit.ReadOnly = pBool
        ucCod_Postal.ReadOnly = pBool
        EnderecoTextEdit.ReadOnly = pBool
        LocalidadeTextEdit.ReadOnly = pBool
        Loc01TextEdit.ReadOnly = pBool
        Loc02TextEdit.ReadOnly = pBool
    End Sub

    Async Sub LoadRegistos(ByVal Optional pFLG_UM As Boolean = False)
        LimpaTXT()

        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)
                DescritivoTextEdit.Text = .Descritivo
                ucCod_Postal.Text = .Cod_Postal



                LocalidadeTextEdit.Text = .Localidade
                Loc01TextEdit.Text = .Loc01
                Loc02TextEdit.Text = .Loc02
                LocalizacaoTextEdit.Text = .Localizacao
                EnderecoTextEdit.Text = .Endereco
                Cod_ParagemTextEdit.Text = .Cod_Paragem


                Dim strGoogle As String = "https://www.google.com/maps/dir/" & .Localizacao
                pbLoading.Visible = True

                If Not pFLG_UM Then
                    pbLoading.Visible = False
                    WebView21.CoreWebView2.Navigate(strGoogle)
                Else
                    Await Task.Delay(1000)

                    If WebView21.CoreWebView2 IsNot Nothing Then
                        WebView21.CoreWebView2.Navigate(strGoogle)
                        pbLoading.Visible = False
                    Else
                        MessageBox.Show("Erro: CoreWebView2 não foi inicializado.")
                    End If
                End If

            End With
        End If
    End Sub

    Sub LimpaTXT()

        DescritivoTextEdit.Text = ""
        LocalidadeTextEdit.Text = ""
        Loc01TextEdit.Text = ""
        Loc02TextEdit.Text = ""
        ucCod_Postal.Text = ""
        EnderecoTextEdit.Text = ""
        LocalizacaoTextEdit.Text = ""
        Cod_ParagemTextEdit.Text = ""
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsParagens
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls
            If pbNovo Then
                .Cod_Paragem = ClsParagens.GetNovoCodigo
            Else
                .Cod_Paragem = Cod_ParagemTextEdit.Text
            End If

            .Descritivo = DescritivoTextEdit.Text
            .Cod_Distrito = mCod_Distrito
            .Cod_Concelho = mCod_Concelho
            .Cod_Postal = ucCod_Postal.Text
            .Endereco = EnderecoTextEdit.Text
            .Localidade = LocalidadeTextEdit.Text
            .Loc01 = Loc01TextEdit.Text
            .Loc02 = Loc02TextEdit.Text

        End With

        If pbNovo Then
            mFLG_Gravou = ClsParagens.GravaParagens(mCls)
        Else
            mFLG_Gravou = ClsParagens.ModificaParagens(mCls)
        End If

        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV11.mNovo = False
                mLista = ClsParagens.GetParagens
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Paragem = mCls.Cod_Paragem) + 1
                LoadRegistos()

            Else
                mLista = ClsParagens.GetParagens
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
            ClsParagens.ApagaParagens(mLista(mNav.Registo_Atual - 1).Cod_Paragem)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsParagens.GetParagens
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub



    Private Sub ucCod_Postal_AfterCloseUp(sender As Object, e As EventArgs) Handles ucCod_Postal.AfterCloseUp, ucCod_Postal.Leave
        mCod_Postal = ucCod_Postal.Text

        Me.Visible = True

        mListaPT_Enderecos = ClsPT_Enderecos.GetPT_EnderecosByCod_Postal(mCod_Postal)
        If mListaPT_Enderecos.Count > 0 Then
            Dim mIndex As Integer = 0

            Me.Focus()
            mCod_Concelho = mListaPT_Enderecos(mIndex).Cod_Concelho
            mCod_Distrito = mListaPT_Enderecos(mIndex).Cod_Distrito
            LocalidadeTextEdit.Text = mListaPT_Enderecos(mIndex).Localidade
            EnderecoTextEdit.Text = mListaPT_Enderecos(mIndex).Endereco
        Else
            Me.ucCod_Postal.Focus()
        End If
    End Sub

End Class
