Imports System.Globalization
Imports Microsoft.Web.WebView2.Core

Imports DevExpress.Utils.Extensions
Imports Infragistics.Win

Imports Infragistics.Win.UltraWinGrid

''' <summary>
'''      Classe frmDistancias- Form da Tabela de Distancias
'''      Gerado em 17/02/2025 13:35:10
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Class frmDistancias
    Dim mLista As New List(Of ClsDistancias)


    Dim mIndex_CP As Integer = 0

    Public Property rNovo As Boolean = False


    Dim mClasse As New ClsDistancias

    Dim mLista_Paragens As New List(Of ClsParagens)

    Async Sub FRM_LOAD1()
        Await WebView21.EnsureCoreWebView2Async(Nothing)
    End Sub


    Private Sub frmDistancias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FRM_LOAD1()

        mLista_Paragens = ClsParagens.GetParagens

        mLista = ClsDistancias.GetDistancias()


        mNav = New clsNav(mLista.Count)

        With ucParagem1
            .DataSource = mLista_Paragens
            mIndex_CP = If(mIndex_CP < 0, 0, mIndex_CP)

            .Rows(mIndex_CP).Selected = True
        End With

        With ucParagem2
            .DataSource = mLista_Paragens
            mIndex_CP = If(mIndex_CP < 0, 0, mIndex_CP)

            .Rows(mIndex_CP).Selected = True
        End With

        Config_ucParagens()

        UC_NAV11.mFRM = Me

        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()

        LoadRegistos(True)

        Me.Text = "Manutenção da Tabela de Distancias"


        '----------------------------------------------------------------------------------------------
        ' Como se faz um Filtro da Lista de Clientes?
        ' 
        ' A mLista que contém a lista de Distancias
        ' pode ser filtrada através do método
        ' FiltrarDistancias com o parâmetro da ClsDistancias
        ' 
        ' É preciso criar uma variável do tipo ClsDistancias
        ' e chamar o método FiltrarDistancias com esse parâmetro:
        '
        '   Dim mclsFiltro as New clsDistancias with {.Cod_Paragem1=txtCod_Paragem1.Text, .Paragem1=txtParagem1.Text}
        '   Dim mListaFiltro = clsDistancias.FiltrarDistancias(mclsFiltro)
        '----------------------------------------------------------------------------------------------

        '-----------------
        'ucPaises
        '-----------------
        'ucPaises.DataSource = clsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"


    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        Me.Cod_Paragem1TextEdit.ReadOnly = True
        Me.Cod_Paragem2TextEdit.ReadOnly = True
        Me.Coord01TextEdit.ReadOnly = True
        Me.Coord02TextEdit.ReadOnly = True
        Me.Cod_DistanciaTextEdit.ReadOnly = True

        If Not pBool Then
            If Me.UC_NAV11.mNovo Then
                Me.ucParagem1.Focus()
            Else
                Me.ucParagem1.Focus()
            End If
        End If
        ucParagem1.ReadOnly = pBool
        ucParagem2.ReadOnly = pBool
        Me.DistanciaTextEdit.ReadOnly = pBool
        Me.Tempo_MinTextEdit.ReadOnly = pBool

        '------------------------------
        'Exemplo da eventual UltraCmbo 
        '------------------------------
        'Me.PaisUltraCombo.ReadOnly = pBool

    End Sub


    Sub Config_ucParagens()


        With ucParagem1.DisplayLayout.Bands(0)

            .Columns("Cod_Paragem").Hidden = True
            .Columns("Cod_Distrito").Hidden = True
            .Columns("Cod_Concelho").Hidden = True
            .Columns("Cod_Postal").Hidden = True
            .Columns("Endereco").Hidden = True
            .Columns("Loc01").Hidden = True
            .Columns("Loc02").Hidden = True
            .Columns("Selecionado").Hidden = True
            .Columns("FLG_Ativo").Hidden = True


            .Columns("Localidade").Width = 60



        End With

        With ucParagem2.DisplayLayout.Bands(0)

            .Columns("Cod_Paragem").Hidden = True
            .Columns("Cod_Distrito").Hidden = True
            .Columns("Cod_Concelho").Hidden = True
            .Columns("Cod_Postal").Hidden = True
            .Columns("Endereco").Hidden = True
            .Columns("Loc01").Hidden = True
            .Columns("Loc02").Hidden = True
            .Columns("Selecionado").Hidden = True
            .Columns("FLG_Ativo").Hidden = True


            .Columns("Localidade").Width = 60



        End With

    End Sub
    Async Sub LoadRegistos(ByVal Optional pFLG_UM As Boolean = False)
        LimpaTXT()

        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)
                Cod_DistanciaTextEdit.Text = .Cod_Distancia
                ucParagem1.Text = .Paragem1
                Cod_Paragem2TextEdit.Text = .Cod_Paragem2
                ucParagem2.Text = .Paragem2
                DistanciaTextEdit.Text = .Distancia
                Tempo_MinTextEdit.Text = .Tempo_Min
                '-------------------------
                ' Cod_Paragem1
                '-------------------------
                Cod_Paragem1TextEdit.Text = .Cod_Paragem1

                Coord01TextEdit.Text = .Coord01
                Coord02TextEdit.Text = .Coord02

                If Not pFLG_UM Then
                    pbLoading.Visible = False
                    WebView21.CoreWebView2.Navigate(.strGoogle)
                Else
                    Await Task.Delay(1000)

                    If WebView21.CoreWebView2 IsNot Nothing Then
                        WebView21.CoreWebView2.Navigate(.strGoogle)
                        pbLoading.Visible = False
                    Else
                        MessageBox.Show("Erro: CoreWebView2 não foi inicializado.")
                    End If
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
        Cod_DistanciaTextEdit.Text = ""
        ucParagem1.Text = ""
        Cod_Paragem2TextEdit.Text = ""
        ucParagem2.Text = ""
        DistanciaTextEdit.Text = "0"
        Tempo_MinTextEdit.Text = "0"
        '-------------------------------
        Cod_Paragem1TextEdit.Text = ""
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsDistancias
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls

            .Cod_Paragem1 = Cod_Paragem1TextEdit.Text
            .Cod_Paragem2 = Cod_Paragem2TextEdit.Text

            If pbNovo Then
                .Cod_Distancia = ClsDistancias.GetNovoCodigo
            Else
                .Cod_Distancia = Cod_DistanciaTextEdit.Text
            End If

            .Cod_Paragem2 = Cod_Paragem2TextEdit.Text
            .Distancia = DistanciaTextEdit.Text
            .Tempo_Min = Tempo_MinTextEdit.Text
        End With

        If pbNovo Then
            mFLG_Gravou = ClsDistancias.GravaDistancias(mCls)
        Else
            mFLG_Gravou = ClsDistancias.ModificaDistancias(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Dim mRegisto_Anterior = mNav.Registo_Atual
                Me.UC_NAV11.mNovo = False
                mLista = ClsDistancias.GetDistancias
                mNav = New clsNav(mLista.Count)

                mNav.Registo_Atual = mLista.Count
                LoadRegistos()

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                Dim mRegisto_Anterior = mNav.Registo_Atual
                mLista = ClsDistancias.GetDistancias
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mRegisto_Anterior
                LoadRegistos()
            End If
        Else
            MsgBox("Erro na gravação:")
        End If
    End Sub


    Sub Apaga_Registo()
        Try
            ClsDistancias.ApagaDistancias(mLista(mNav.Registo_Atual - 1).Cod_Paragem1)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsDistancias.GetDistancias
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub

    Private Sub ucParagem1_AfterCloseUp(sender As Object, e As EventArgs) Handles ucParagem1.AfterCloseUp
        Dim mIndex As Integer = 0

        If ucParagem1.ActiveRow IsNot Nothing Then
            mIndex = ucParagem1.ActiveRow.Index
        End If

        Me.Cod_Paragem1TextEdit.Text = mLista_Paragens(mIndex).Cod_Paragem
        Me.Coord01TextEdit.Text = mLista_Paragens(mIndex).Localizacao


        Me.ucParagem1.Text = mLista_Paragens(mIndex).Descritivo
    End Sub

    Private Sub ucParagem2_AfterCloseUp(sender As Object, e As EventArgs) Handles ucParagem2.AfterCloseUp
        Dim mIndex As Integer = 0

        If ucParagem2.ActiveRow IsNot Nothing Then
            mIndex = ucParagem2.ActiveRow.Index
        End If

        Me.Cod_Paragem2TextEdit.Text = mLista_Paragens(mIndex).Cod_Paragem

        Me.ucParagem2.Text = mLista_Paragens(mIndex).Descritivo
        Me.Coord02TextEdit.Text = mLista_Paragens(mIndex).Localizacao
    End Sub

End Class
