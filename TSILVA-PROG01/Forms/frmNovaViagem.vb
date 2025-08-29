Imports DevExpress.Data.Async
Imports DevExpress.XtraReports.Wizards.Presenters

Public Class frmNovaViagem

    Public Property Cod_Rota As String
    Public Property Tipo_Viagem As Integer
    Public Property Cod_Viatura As String
    Public Property Cod_Motorista As String


    Public mLista_Viaturas As New List(Of ClsViaturas)

    Public mLista_Motoristas As New List(Of ClsEntidades)

    Public mLista_TV As New List(Of ClsTipos_Viagem)

    Public mlista_Rotas As New List(Of ClsRotas)

    Dim mViagem As New ClsViagens

    Dim mGravou As Boolean = False

    Public Sub Load_NovaViagem()

        WizardControl1.SelectedPage = WelcomeWizardPage1

        mLista_TV = ClsTipos_Viagem.GetTipos_Viagem
        mlista_Rotas = ClsRotas.GetRotas
        mLista_Viaturas = ClsViaturas.GetViaturas
        mLista_Motoristas = ClsEntidades.GetEntidadesByFLG("M")

        '----------------
        ' uc_Tipos_Viagem
        '----------------
        ucTipos_Viagem.DataSource = mLista_TV
        ucTipos_Viagem.DisplayMember = "Descrtivo"
        ucTipos_Viagem.Value = "Tipo_Viagem"
        ucTipos_Viagem.Rows(0).Selected = True

        '----------------
        ' uc_Rotas
        '----------------
        ucRotas.DataSource = mlista_Rotas
        ucRotas.DisplayMember = "Descritivo"
        ucRotas.Value = "Cod_Rota"
        ucRotas.Rows(0).Selected = True

        '----------------
        ' uc_Motoristas
        '----------------
        ucMotoristas.DataSource = mLista_Motoristas
        ucMotoristas.DisplayMember = "Nome"
        ucMotoristas.Value = "Cod_Entidade"
        ucMotoristas.Rows(0).Selected = True

        '----------------
        ' uc_Viaturas
        '----------------
        ucViaturas.DataSource = mLista_Viaturas
        ucViaturas.DisplayMember = "Descritivo"
        ucViaturas.Value = "Cod_Rota"
        ucViaturas.Rows(0).Selected = True

    End Sub
    Private Sub frmNovaViagem_Load(sender As Object, e As EventArgs) Handles Me.Load

        Load_NovaViagem()

    End Sub

    Private Sub ucMotoristas_AfterCloseUp(sender As Object, e As EventArgs) Handles ucMotoristas.AfterCloseUp, ucMotoristas.Leave
        Me.Cod_MotoristaTextEdit.Text = ucMotoristas.ActiveRow.Cells("Cod_Entidade").Text
        Me.ucViaturas.Focus()
    End Sub


    Private Sub Data_ViagemDateEdit_Leave(sender As Object, e As EventArgs) Handles Data_ViagemDateEdit.Leave
        Me.ucTipos_Viagem.Focus()
    End Sub

    Private Sub ucTipos_Viagem_AfterCloseUp(sender As Object, e As EventArgs) Handles ucTipos_Viagem.AfterCloseUp, ucTipos_Viagem.Leave
        Me.Tipo_ViagemTextEdit.Text = ucTipos_Viagem.ActiveRow.Cells("Tipo_Viagem").Text
        Me.ucRotas.Focus()
    End Sub

    Private Sub ucRotas_AfterCloseUp(sender As Object, e As EventArgs) Handles ucRotas.AfterCloseUp, ucRotas.Leave
        Me.Cod_RotaTextEdit.Text = ucRotas.ActiveRow.Cells("Cod_Rota").Text
        Me.ucMotoristas.Focus()
    End Sub

    Private Sub ucViaturas_AfterCloseUp(sender As Object, e As EventArgs) Handles ucViaturas.AfterCloseUp, ucViaturas.Leave
        Me.Cod_ViaturaTextEdit.Text = ucViaturas.ActiveRow.Cells("Cod_Viatura").Text

    End Sub

    Sub Grava_Viagens()
        Dim mResult As New MsgBoxResult

        mResult = MsgBox("Quer gravar a Viagem " & mViagem.Cod_Viagem & "? ", MsgBoxStyle.YesNo)

        If mResult = MsgBoxResult.Yes Then
            ClsViagens.GravaViagens(mViagem)
            mGravou = True
            frmViagens.ugViagens.Refresh()
            Me.Hide()
        Else
            mGravou = False
        End If

    End Sub

    Private Sub WizardPage2_GotFocus(sender As Object, e As EventArgs) Handles WizardPage2.Enter

        Dim mTipo_Viagem As Integer = CInt(Tipo_ViagemTextEdit.Text)
        Dim mData As DateTime = Data_ViagemDateEdit.Text
        Dim mCod_Motorista As String = Cod_MotoristaTextEdit.Text
        Dim mCod_Rota As String = Cod_RotaTextEdit.Text
        Dim mCod_Viatura As String = Cod_ViaturaTextEdit.Text


        Dim mLista As New List(Of ClsViagens)

        mViagem = Cria_Viagem(mData, mTipo_Viagem, mCod_Rota, mCod_Motorista, mCod_Viatura)
        mLista.Add(mViagem)
        Me.ugViagem.DataSource = mLista
        Me.ugViagem.Refresh()


    End Sub

    Friend Shared Function Cria_Viagem(ByVal pData_Viagem As DateTime, ByVal pTipo_Viagem As Integer, pCod_Rota As String, pCod_Motorista As String, pCod_Viatura As String) As ClsViagens
        Dim mReturn As ClsViagens

        mReturn = New ClsViagens(pTipo_Viagem, pCod_Viatura, pCod_Motorista, pCod_Rota, pData_Viagem)

        Return mReturn
    End Function

    Private Sub CompletionWizardPage1_Click(sender As Object, e As EventArgs) Handles CompletionWizardPage1.Click
        If Not mGravou Then
            Grava_Viagens()
        End If
    End Sub
End Class