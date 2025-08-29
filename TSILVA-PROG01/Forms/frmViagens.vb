

Imports Infragistics.Win.UltraWinGrid

''' <summary>
'''      Classe frmViagens- Form da Tabela de Viagens
'''      Gerado em 23/04/2025 11:25:26
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Class frmViagens
    Dim mLista As New List(Of ClsViagens)

    Sub Load_Lista()
        mLista = ClsViagens.GetViagens
        mNav = New clsNav(mLista.Count)

    End Sub
    Private Sub frmViagens_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Load_Lista()

        ugViagens.ContextMenuStrip = cmsViagens

        Config_ugViagens()
        LoadRegistos()

        Me.Text = "Viagens Programadas"

    End Sub


    Sub LoadRegistos()

        Me.ugViagens.DataSource = mLista

    End Sub

    Sub Config_ugViagens()
        With ugViagens.DisplayLayout.Bands(0)

            .Override.HeaderClickAction = HeaderClickAction.Select

            .Columns("SIGLA_Tipo_Viagem").Hidden = True
            .Columns("Tipo_Viagem").Hidden = True
            .Columns("FLG_Ativo").Hidden = True
            .Columns("Cod_Viatura").Hidden = True
            .Columns("FLG_Estado").Hidden = True
            .Columns("Cod_Motorista").Hidden = True
            .Columns("Num_KM").Hidden = True
            .Columns("Num_Paragens").Hidden = True

            .Columns("Cod_Viagem").Header.Caption = "Cod. Viagem"
            .Columns("Cod_Viagem").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Cod_Viagem").Width = 25
            .Columns("Cod_Viagem").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Cod_Viagem").CellActivation = Activation.NoEdit

            .Columns("Descritivo").Header.Caption = "Descritivo Viagem"
            .Columns("Descritivo").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Descritivo").Width = 270
            .Columns("Descritivo").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Descritivo").CellActivation = Activation.NoEdit

            .Columns("DESC_Tipo_Viagem").Header.Caption = "Tipo de Viagem"
            .Columns("DESC_Tipo_Viagem").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("DESC_Tipo_Viagem").Width = 130
            .Columns("DESC_Tipo_Viagem").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("DESC_Tipo_Viagem").CellActivation = Activation.NoEdit

            .Columns("Viatura").Header.Caption = "Viatura"
            .Columns("Viatura").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Viatura").Width = 182
            .Columns("Viatura").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Viatura").CellActivation = Activation.NoEdit

            .Columns("Cod_Rota").Header.Caption = "Cod. Rota"
            .Columns("Cod_Rota").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Cod_Rota").Width = 25
            .Columns("Cod_Rota").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Cod_Rota").CellActivation = Activation.NoEdit

            .Columns("Nome_Motorista").Header.Caption = "Motorista"
            .Columns("Nome_Motorista").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Nome_Motorista").Width = 150
            .Columns("Nome_Motorista").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Nome_Motorista").CellActivation = Activation.NoEdit

            .Columns("Dia_Semana").Header.Caption = "Dia da Semana"
            .Columns("Dia_Semana").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Dia_Semana").Width = 30
            .Columns("Dia_Semana").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Dia_Semana").CellActivation = Activation.NoEdit

            .Columns("Data_Viagem").Header.Caption = "Data da Viagem"
            .Columns("Data_Viagem").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Data_Viagem").Width = 120
            .Columns("Data_Viagem").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("Data_Viagem").CellActivation = Activation.NoEdit

            .Columns("ETD").Header.Caption = "ETD"
            .Columns("ETD").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("ETD").Width = 70
            .Columns("ETD").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("ETD").CellActivation = Activation.NoEdit

            .Columns("ATD").Header.Caption = "ATD"
            .Columns("ATD").Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("ATD").Width = 70
            .Columns("ATD").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Center
            .Columns("ATD").CellActivation = Activation.NoEdit
        End With
    End Sub

    Private Sub btnCriar_Viagem_Click(sender As Object, e As EventArgs) Handles btnCriar_Viagem.Click
        frmNovaViagem.Show()
        frmNovaViagem.Load_NovaViagem()
    End Sub

    Private Sub cmsApagar_Click(sender As Object, e As EventArgs) Handles cmsApagar.Click
        Apagar_Viagem()
    End Sub

    Sub Apagar_Viagem()
        Dim mViagem = ugViagens.Rows(ugViagens.ActiveRow.Index).GetCellValue("Cod_Viagem")
        Dim mResposta As MsgBoxResult = MsgBoxResult.No

        mResposta = MsgBox("Deseja mesmo apagar a viagem " & mViagem & "?", MsgBoxStyle.YesNo, "ATLAS - APAGAR VIAGEM")

        If mResposta = MsgBoxResult.Yes Then
            ClsViagens.ApagaViagens(mViagem)

            Load_Lista()

            ugViagens.DataSource = Nothing
            ugViagens.DataSource = mLista
            ugViagens.Refresh()
        End If
    End Sub
End Class
