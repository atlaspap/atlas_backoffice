

Imports System.ComponentModel
Imports System.Reflection.Emit
Imports DevExpress.Utils.DirectXPaint
Imports DevExpress.XtraEditors.Design
Imports Infragistics.Win.UltraWinGrid

''' <summary>
'''      Classe frmRotas- Form da Tabela de Rotas
'''      Gerado em 23/01/2025 13:57:14
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Class frmRotas
    Dim mLista As New List(Of ClsRotas)

    Dim mDistancia_Final As Integer
    Dim mTempo_Total As Integer

    Dim mFator_Tempo As Integer = 1 ' --> Tempo em que o autocarro para por paragem 

    Public mLista_RotasP As New List(Of ClsRota_Paragens)

    Dim mFLG_Edicao As Boolean = True
    Dim mFLG_Novo As Boolean = False
    Async Sub FRM_LOAD1()
        Await WebView21.EnsureCoreWebView2Async(Nothing)
    End Sub
    Private Sub frmRotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FRM_LOAD1()

        mLista = ClsRotas.GetRotas
        mNav = New clsNav(mLista.Count)

        UC_NAV11.mFRM = Me

        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()

        LoadRegistos(True)


        Me.Text = "Manutenção da Tabela de Rotas"

    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        Me.Cod_RotaTextEdit.ReadOnly = True
        Num_ParagensTextEdit.ReadOnly = True
        Distancia_TotalTextEdit.ReadOnly = True
        Tempo_TotalTextEdit.ReadOnly = True
        If Not pBool Then
            If Me.UC_NAV11.mNovo Then
                Me.DescritivoTextEdit.Focus()

                Me.ugRotas.DataSource = Nothing
                Me.ugRotas.Refresh()
            Else
                Me.DescritivoTextEdit.Focus()
                Me.ugRotas.ContextMenuStrip = cms01
            End If

            TextEditParagens.Visible = False
            ugRotas.Location = New Drawing.Point(12, 250)
            Panel2.Location = New Drawing.Point(12, 250)
            Panel3.Show()
            ugParagens.Show()
            ugParagens.Enabled = True

            WebView21.Hide()
            WebView21.Enabled = False

        End If
        If pBool = True Then
            ugRotas.ContextMenuStrip = Nothing

            TextEditParagens.Visible = True
            ugRotas.Location = New Drawing.Point(12, 250)
            Panel2.Location = New Drawing.Point(12, 250)

            ugParagens.Enabled = False
            ugParagens.Hide()
            Panel3.Hide()

            WebView21.Show()
            WebView21.Enabled = True
            WebView21.Location = New Drawing.Point(841, 15)
        End If
        mFLG_Edicao = Not pBool
        DescritivoTextEdit.ReadOnly = pBool
        'ugRotas.Enabled = Not pBool

    End Sub

    Async Sub LoadRegistos(ByVal Optional pFLG_UM As Boolean = False)
        LimpaTXT()
        Dim mLista_Paragens As New List(Of ClsParagens)
        mLista_Paragens = ClsParagens.GetParagens()
        Me.ugParagens.DataSource = mLista_Paragens
        Load_ugParagens()
        Me.ugParagens.Refresh()
        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)
                DescritivoTextEdit.Text = .Descritivo
                Num_ParagensTextEdit.Text = .Num_Paragens
                '-------------------------
                ' Cod_Rota
                '-------------------------
                Cod_RotaTextEdit.Text = .Cod_Rota
                TextEditParagens.Text = "PARAGENS DA ROTA: " & .Descritivo
                Dim mLista_RotasP As New List(Of ClsRota_Paragens)

                ' mLista_RotasP = ClsRota_Paragens.FiltrarRota_Paragens(.Cod_Rota)

                mLista_RotasP = .Lista_Paragens

                Me.ugRotas.DataSource = mLista_RotasP
                Load_ugRotas()
                Me.ugRotas.Refresh()

                Dim strGoogle As String = "https://www.google.com/maps/dir/"

                mDistancia_Final = 0
                mTempo_Total = 0

                Dim mMax As Integer = ugRotas.Rows.Count
                For i = 0 To mMax - 1
                    Dim mLoc As String = ClsParagens.GetParagensByCod(ugRotas.Rows(i).Cells("Cod_Paragem").Value).Localizacao
                    strGoogle += mLoc & "/"
                    mDistancia_Final += ugRotas.Rows(i).Cells("Dist_Km").Value
                    mTempo_Total += ugRotas.Rows(i).Cells("Tempo_Min").Value
                Next

                Distancia_TotalTextEdit.Text = (mDistancia_Final / 1000) & " km"
                Tempo_TotalTextEdit.Text = mTempo_Total & " minutos"



                ' If Not pFLG_UM Then WebView21.CoreWebView2.Navigate(strGoogle)

                pbLoading.Visible = True



                If Not pFLG_UM Then
                    pbLoading.Visible = False
                    WebView21.CoreWebView2.Navigate(strGoogle)
                Else
                    Await Task.Delay(1300)

                    If WebView21.CoreWebView2 IsNot Nothing Then
                        WebView21.CoreWebView2.Navigate(strGoogle)
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

    Sub Load_ugRotas()

        Distancia_TotalTextEdit.Text = mDistancia_Final & " km"

        With ugRotas.DisplayLayout.Bands(0)
            .Override.HeaderClickAction = HeaderClickAction.Select

            .Columns("Cod_Rota").Hidden = True
            .Columns("Cod_Paragem").Hidden = True
            .Columns("FLG_Ativo").Hidden = True

            .Columns("Dist_Km").Header.Caption = "Distância (M)"
            .Columns("Dist_Km").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Dist_Km").Width = 85
            .Columns("Dist_Km").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Dist_Km").CellActivation = Activation.NoEdit

            .Columns("Tempo_Min").Header.Caption = "Tempo (Min)"
            .Columns("Tempo_Min").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Tempo_Min").Width = 75
            .Columns("Tempo_Min").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Tempo_Min").CellActivation = Activation.NoEdit

            .Columns("Ordem").Header.Caption = "Ordem"
            .Columns("Ordem").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Ordem").Width = 55
            .Columns("Ordem").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Ordem").CellActivation = Activation.NoEdit

            .Columns("Cod_Paragem").Header.Caption = "Paragem"
            .Columns("Cod_Paragem").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Cod_Paragem").Width = 60
            .Columns("Cod_Paragem").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Cod_Paragem").CellActivation = Activation.NoEdit

            .Columns("Paragem_Descritivo").Header.Caption = "Descritivo"
            .Columns("Paragem_Descritivo").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Paragem_Descritivo").Width = 190
            .Columns("Paragem_Descritivo").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Paragem_Descritivo").CellActivation = Activation.NoEdit

            .Columns("Paragem_Localidade").Header.Caption = "Localidade"
            .Columns("Paragem_Localidade").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Paragem_Localidade").Width = 120
            .Columns("Paragem_Localidade").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Paragem_Localidade").CellActivation = Activation.NoEdit

            .Columns("Paragem_Endereco").Header.Caption = "Endereço"
            .Columns("Paragem_Endereco").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Paragem_Endereco").Width = 260
            .Columns("Paragem_Endereco").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Paragem_Endereco").CellActivation = Activation.NoEdit
        End With
    End Sub
    Sub LimpaTXT()

        ' strGoogle = ""
        Distancia_TotalTextEdit.Text = ""
        DescritivoTextEdit.Text = ""
        Num_ParagensTextEdit.Text = ""
        '-------------------------------
        Cod_RotaTextEdit.Text = ""

    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsRotas
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls
            If pbNovo Then
                '--------------------------------------
                'Método Não criado na CLASSE 
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Rota = ClsRotas.GetNovoCodigo
                .Lista_Paragens = mLista_RotasP
                '--------------------------------------
            Else
                '--------------------------------------
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Rota = Cod_RotaTextEdit.Text
                .Lista_Paragens = mLista_RotasP
            End If
            '----------------------------------
            'Aqui VERIFICAR Todos os CAMPOS
            '  Não tem por ex. o FLG_Ativo...
            '----------------------------------
            .Descritivo = DescritivoTextEdit.Text
            .Num_Paragens = ugRotas.Rows.Count

        End With

        If pbNovo Then
            mFLG_Gravou = ClsRotas.GravaRotas(mCls)
            mFLG_Gravou = ClsRota_Paragens.Grava_Lista_Paragens(mLista_RotasP)
        Else
            mFLG_Gravou = ClsRotas.ModificaRotas(mCls)
            mFLG_Gravou = ClsRotas.Apaga_Paragens(mCls.Cod_Rota)
            mFLG_Gravou = ClsRota_Paragens.Grava_Lista_Paragens(mLista_RotasP)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV11.mNovo = False
                mLista = ClsRotas.GetRotas
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Rota = mCls.Cod_Rota) + 1
                LoadRegistos()

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsRotas.GetRotas
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mRegisto_Atual
                LoadRegistos()
            End If
            mFLG_Edicao = False
        Else
            MsgBox("Erro na gravação:")
        End If
    End Sub

    Sub Apaga_Registo()
        Try
            ClsRotas.ApagaRotas(mLista(mNav.Registo_Atual - 1).Cod_Rota)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsRotas.GetRotas
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub

    Sub Load_ugParagens()

        With ugParagens.DisplayLayout.Bands(0)
            .Override.HeaderClickAction = HeaderClickAction.Select
            .SortedColumns.Clear()

            .Columns("Cod_Distrito").Hidden = True
            .Columns("Cod_Concelho").Hidden = True
            .Columns("Loc01").Hidden = True
            .Columns("Loc02").Hidden = True
            .Columns("Localizacao").Hidden = True
            .Columns("Selecionado").Hidden = True
            .Columns("FLG_Ativo").Hidden = True

            .Columns("Cod_Paragem").Header.Caption = "Paragem"
            .Columns("Cod_Paragem").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Cod_Paragem").Width = 60
            .Columns("Cod_Paragem").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Cod_Paragem").CellActivation = Activation.NoEdit

            .Columns("Descritivo").Header.Caption = "Descritivo"
            .Columns("Descritivo").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Descritivo").Width = 140
            .Columns("Descritivo").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Descritivo").CellActivation = Activation.NoEdit

            .Columns("Cod_Postal").Header.Caption = "Código Postal"
            .Columns("Cod_Postal").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Cod_Postal").Width = 120
            .Columns("Cod_Postal").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Cod_Postal").CellActivation = Activation.NoEdit

            .Columns("Endereco").Header.Caption = "Endereço"
            .Columns("Endereco").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Endereco").Width = 320
            .Columns("Endereco").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Endereco").CellActivation = Activation.NoEdit

            .Columns("Localidade").Header.Caption = "Localidade"
            .Columns("Localidade").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Localidade").Width = 175
            .Columns("Localidade").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Localidade").CellActivation = Activation.NoEdit

        End With
    End Sub

    Private Function Testa_Repetida(ByVal pCod_Paragem As String) As Boolean
        Dim mReturn As Boolean = True


        mLista_RotasP = mLista(mNav.Registo_Atual - 1).Lista_Paragens

        mReturn = mLista_RotasP.FindAll(Function(x) x.Cod_Paragem = pCod_Paragem).Count > 0

        Return mReturn
    End Function


    Private Sub ugParagens_DoubleClickCell(sender As Object, e As DoubleClickCellEventArgs) Handles ugParagens.DoubleClickCell
        Dim mCod_Paragem As String = ugParagens.ActiveRow.Cells("Cod_Paragem").Value

        If mFLG_Edicao = False Then
            MsgBox("Você só pode adicionar paragens caso esteja a criar ou a editar uma rota.")
        Else
            If Not UC_NAV11.mNovo Then
                If Not Testa_Repetida(mCod_Paragem) Then
                    ADD_RP()
                End If
            Else
                If Not ugParagens.ActiveRow.Cells("Selecionado").Value = True Then
                    ADD_RP()
                    ugParagens.ActiveRow.Cells("Selecionado").Value = True
                End If
            End If

        End If
    End Sub
    Private Sub ADD_RP()
        Dim mParagem As New ClsParagens

        Dim mCod_Rota As String = ""
        If UC_NAV11.mNovo = True Then
            mCod_Rota = ClsRotas.GetNovoCodigo

        Else
            mCod_Rota = Cod_RotaTextEdit.Text
            mLista_RotasP = mLista(mNav.Registo_Atual - 1).Lista_Paragens
        End If
        Dim mIndex As Integer = ugParagens.ActiveRow.Index

        mParagem = ugParagens.DataSource(mIndex)

        Dim mDistancia As Integer
        Dim mTempo_Min As Integer

        If Not ugRotas.Rows.Count = 0 Then
            Dim mLastIndex As Integer = ugRotas.Rows.Count - 1
            Dim mCParagem As String = ugRotas.Rows(mLastIndex).Cells("Cod_Paragem").Value
            mDistancia = ClsDistancias.GetDistanciasByCod(mCParagem, mParagem.Cod_Paragem).Distancia
            mTempo_Min = ClsDistancias.GetDistanciasByCod(mCParagem, mParagem.Cod_Paragem).Tempo_Min + mFator_Tempo
            If mDistancia = Nothing Then
                mDistancia = ClsDistancias.GetDistanciasByCod(mParagem.Cod_Paragem, mCParagem).Distancia
                mTempo_Min = ClsDistancias.GetDistanciasByCod(mParagem.Cod_Paragem, mCParagem).Tempo_Min + mFator_Tempo
                If mDistancia = Nothing Then
                    Dim mDParagem As String = ugRotas.Rows(mLastIndex).Cells("Paragem_Descritivo").Value
                    MsgBox("A paragem " & mDParagem & " não tem uma distancia gravada para a paragem " & mParagem.Descritivo & ".")
                    Exit Sub
                End If
            End If
        Else
            mDistancia = 0
            mTempo_Min = 0
        End If

        Dim mRP As New ClsRota_Paragens(mCod_Rota, mParagem.Cod_Paragem, mLista_RotasP.Count + 1, mDistancia, mTempo_Min)
        mDistancia_Final += (mDistancia / 1000)
        mLista_RotasP.Add(mRP)

        ugRotas.DataSource = Nothing
        ugRotas.DataSource = mLista_RotasP
        Load_ugRotas()
        ugRotas.Refresh()

    End Sub

    Private Sub cmsRemove_Click(sender As Object, e As EventArgs) Handles cmsRemove.Click
        Remove_RP()
    End Sub

    Sub Remove_RP()
        Dim mParagem = ugRotas.Rows(ugRotas.ActiveRow.Index).GetCellValue("Paragem_Descritivo")
        Dim mCod_Paragem = ugRotas.Rows(ugRotas.ActiveRow.Index).GetCellValue("Cod_Paragem")
        Dim mResposta As MsgBoxResult = MsgBoxResult.No
        mResposta = MsgBox("Quer remover a paragem " & mParagem & "?", MsgBoxStyle.YesNo, "ATLAS - ROTAS")

        If mResposta = MsgBoxResult.Yes Then
            ClsRota_Paragens.ApagaRota_Paragens(Cod_RotaTextEdit.Text, mCod_Paragem)
            ugRotas.DataSource = Nothing
            mLista_RotasP = ClsRota_Paragens.GetRota_Paragens(Cod_RotaTextEdit.Text)
            mLista(mNav.Registo_Atual - 1).Lista_Paragens = mLista_RotasP

            ugRotas.DataSource = mLista_RotasP
            Load_ugRotas()
            ugRotas.Refresh()
        End If

    End Sub

    Private Sub btnCima_Click(sender As Object, e As EventArgs) Handles cmsUp.Click

        Dim mIndex_Atual As Integer = ugRotas.ActiveRow.Index
        Dim mIndex_Destino As Integer = 0

        If mIndex_Atual > 0 Then
            mIndex_Destino = mIndex_Atual - 1
        Else
            Exit Sub
        End If

        Dim mLista_RP As New List(Of ClsRota_Paragens)
        Dim mLista_RP_FInal As New List(Of ClsRota_Paragens)

        mLista_RP = mLista(mNav.Registo_Atual - 1).Lista_Paragens

        For n As Integer = 0 To mLista_RP.Count - 1

            Select Case n
                Case < mIndex_Destino
                    mLista_RP_FInal.Add(mLista_RP(n))
                Case = mIndex_Destino
                    mLista_RP_FInal.Add(mLista_RP(mIndex_Atual))
                Case = mIndex_Atual
                    mLista_RP_FInal.Add(mLista_RP(mIndex_Destino))
                Case Else
                    mLista_RP_FInal.Add(mLista_RP(n))
            End Select
            mLista_RP(n).Ordem = n + 1

        Next

        mLista(mNav.Registo_Atual - 1).Lista_Paragens = mLista_RP_FInal
        mLista_RotasP = mLista_RP_FInal

        ugRotas.DataSource = Nothing
        ugRotas.DataSource = mLista_RP_FInal
        Load_ugRotas()
        ugRotas.ActiveRow = ugRotas.Rows(mIndex_Destino)
        ugRotas.Refresh()
    End Sub

    Private Sub btnBaixo_Click(sender As Object, e As EventArgs) Handles cmsDown.Click

        Dim mIndex_Atual As Integer = ugRotas.ActiveRow.Index
        Dim mIndex_Destino As Integer = 0

        If mIndex_Atual < ugRotas.Rows.Count - 1 Then
            mIndex_Destino = mIndex_Atual + 1
        Else
            Exit Sub
        End If

        Dim mLista_RP As New List(Of ClsRota_Paragens)
        Dim mLista_RP_FInal As New List(Of ClsRota_Paragens)

        mLista_RP = mLista(mNav.Registo_Atual - 1).Lista_Paragens

        For n As Integer = 0 To mLista_RP.Count - 1

            Select Case n
                Case > mIndex_Destino
                    mLista_RP_FInal.Add(mLista_RP(n))
                Case = mIndex_Destino
                    mLista_RP_FInal.Add(mLista_RP(mIndex_Atual))
                Case = mIndex_Atual
                    mLista_RP_FInal.Add(mLista_RP(mIndex_Destino))
                Case Else
                    mLista_RP_FInal.Add(mLista_RP(n))
            End Select
            mLista_RP(n).Ordem = n + 1

        Next

        mLista(mNav.Registo_Atual - 1).Lista_Paragens = mLista_RP_FInal
        mLista_RotasP = mLista_RP_FInal

        ugRotas.DataSource = Nothing
        ugRotas.DataSource = mLista_RP_FInal
        Load_ugRotas()
        ugRotas.ActiveRow = ugRotas.Rows(mIndex_Destino)
        ugRotas.Refresh()

    End Sub
End Class
