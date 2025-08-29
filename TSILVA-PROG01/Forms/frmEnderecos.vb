Imports DevExpress.XtraBars.BarItemVisibility
Imports DevExpress.XtraEditors

Public Class frmEnderecos
    Public Property rCod_Entidade As String
    Public Property rCod_Endereco As String
    Public Property rNovo As Boolean = False

    Dim mClasse As New ClsEnderecos

    Dim mCod_Postal As String

    Dim mLista_Cod_Postal As New List(Of String)
    Dim mIndex_CP As Integer = 0

    Dim mListaPT_Enderecos As New List(Of ClsPT_Enderecos)


    Private Sub frmEnderecos_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedDialog

        mLista_Cod_Postal = ClsPT_Enderecos.GetCod_Postal


        If Not rNovo Then
            mClasse = ClsEnderecos.GetEnderecosByCod(rCod_Entidade, rCod_Endereco)
            SetupComps(False)
            SetupBotoes(False)
            LoadRegistos()

            Me.DescritivoTextEdit.Focus()
            Me.bbStatus.Caption = "Estou a Modificar Registo"
        Else
            '
            SetupComps(False)
            SetupBotoes(False)
            Me.Cod_EntidadeTextEdit.Text = rCod_Entidade
            Me.Cod_EnderecoTextEdit.Text = rCod_Endereco
            Me.DescritivoTextEdit.Focus()

            Me.bbStatus.Caption = "Estou a Criar um Novo Registo"
        End If

        ' ---------------------
        ' ucCod_Postal
        '----------------------
        With ucCod_Postal
            .DataSource = mLista_Cod_Postal
            mIndex_CP = If(mIndex_CP < 0, 0, mIndex_CP)

            .Rows(mIndex_CP).Selected = True
        End With

    End Sub


    Sub SetupBotoes(pBool As Boolean)

        Me.bbNovo.Visibility = If(Not pBool, Never, Always)
        Me.bbModifica.Visibility = If(Not pBool, Never, Always)
        Me.bbApaga.Visibility = If(Not pBool, Never, Always)
        Me.bbSair.Visibility = If(Not pBool, Never, Always)
        Me.bbGrava.Visibility = If(pBool, Never, Always)
        Me.bbCancela.Visibility = If(pBool, Never, Always)

        'If mNovo Then bbStatus.Caption = ""


    End Sub
    Sub LimpaTXT()

        Cod_EnderecoTextEdit.Text = ""
        DescritivoTextEdit.Text = ""
        EnderecoTextEdit.Text = ""
        Cod_PostalTextEdit.Text = ""
        LocalidadeTextEdit.Text = ""
        Data_RegistoDateEdit.Text = ""
        '-------------------------------
        Cod_EntidadeTextEdit.Text = ""
    End Sub

    Friend Function Find_Index() As Integer
        Dim mReturn As Integer = 0
        Dim mI As Integer = 0
        For Each mS As String In mLista_Cod_Postal
            If mS = mCod_Postal Then
                mReturn = mI
                Exit For
            End If
            mI += 1
        Next

        Return mReturn
    End Function
    Sub LoadRegistos()
        LimpaTXT()

        With mClasse
            If rNovo Then
                Data_RegistoDateEdit.Text = Date.Now
            Else
                Data_RegistoDateEdit.Text = FormatDateTime(.Data_Registo, DateFormat.ShortDate)
                mCod_Postal = .Cod_Postal
                mIndex_CP = mLista_Cod_Postal.FindIndex(Function(x) x = mCod_Postal)
                'mIndex_CP = Find_Index()
            End If

            Cod_EntidadeTextEdit.Text = .Cod_Entidade
            Cod_EnderecoTextEdit.Text = .Cod_Endereco

            DescritivoTextEdit.Text = .Descritivo
            EnderecoTextEdit.Text = .Endereco
            Cod_PostalTextEdit.Text = .Cod_Postal
            LocalidadeTextEdit.Text = .Localidade


        End With
        '-------------------------------
        'upBar.Value = mNav.Registo_Atual
        '-------------------------------



    End Sub


    Sub SetupComps(ByVal pBool As Boolean)

        Me.Cod_EntidadeTextEdit.ReadOnly = True
        Me.Cod_EnderecoTextEdit.ReadOnly = True

        DescritivoTextEdit.ReadOnly = pBool
        EnderecoTextEdit.ReadOnly = pBool
        Cod_PostalTextEdit.ReadOnly = pBool
        LocalidadeTextEdit.ReadOnly = pBool

        Data_RegistoDateEdit.ReadOnly = True


    End Sub

    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsEnderecos


        With mCls

            .Cod_Entidade = Cod_EntidadeTextEdit.Text
            .Cod_Endereco = Cod_EnderecoTextEdit.Text
            '----------------------------------
            'Aqui VERIFICAR Todos os CAMPOS
            '  Não tem por ex. o FLG_Ativo...
            '----------------------------------

            .Descritivo = DescritivoTextEdit.Text
            If DescritivoTextEdit.Text = "" Then .Descritivo = "Endereço " & .Cod_Endereco.Substring(1, 2)
            .Endereco = EnderecoTextEdit.Text
            .Cod_Postal = Cod_PostalTextEdit.Text
            .Localidade = LocalidadeTextEdit.Text

            .Data_Registo = If(pbNovo, Date.Now, Data_RegistoDateEdit.Text)

        End With

        If pbNovo Then
            mFLG_Gravou = ClsEnderecos.GravaEnderecos(mCls)
        Else
            mFLG_Gravou = ClsEnderecos.ModificaEnderecos(mCls)
        End If


        If mFLG_Gravou Then
            rNovo = False
        Else
            MsgBox("Erro na gravação:")
        End If
    End Sub


    Private Sub bbNovo_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbNovo.ItemClick
        SetupComps(False)
        SetupBotoes(False)
    End Sub

    Private Sub bbModifica_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbModifica.ItemClick
        SetupComps(False)
        SetupBotoes(False)
    End Sub

    Private Sub bbGrava_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbGrava.ItemClick
        Grava(rNovo)
        Close()
    End Sub

    Private Sub bbCancela_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbCancela.ItemClick
        Close()
    End Sub

    Private Sub ucCod_Postal_AfterCloseUp(sender As Object, e As EventArgs) Handles ucCod_Postal.AfterCloseUp, ucCod_Postal.Leave
        mCod_Postal = ucCod_Postal.Text

        Me.ucEnderecos.Visible = True
        '----------------
        ' ucEnderecos
        '-----------------
        mListaPT_Enderecos = ClsPT_Enderecos.GetPT_EnderecosByCod_Postal(mCod_Postal)
        If mListaPT_Enderecos.Count > 0 Then


            With ucEnderecos
                .DisplayMember = "Endereco"
                .DataSource = mListaPT_Enderecos
                .Rows(0).Selected = True

            End With
            Me.ucEnderecos.Focus()

        Else
            Me.ucCod_Postal.Focus()
        End If
    End Sub

    Private Sub ucEnderecos_AfterCloseUp(sender As Object, e As EventArgs) Handles ucEnderecos.AfterCloseUp, ucEnderecos.Leave
        ' Dim mEndereco As String = ucEnderecos.Text
        Dim mIndex As Integer = 0

        If ucEnderecos.ActiveRow IsNot Nothing Then
            mIndex = ucEnderecos.ActiveRow.Index
        End If

        Me.EnderecoTextEdit.Text = mListaPT_Enderecos(mIndex).Endereco
        Me.Cod_PostalTextEdit.Text = mListaPT_Enderecos(mIndex).Cod_Postal
        Me.LocalidadeTextEdit.Text = mListaPT_Enderecos(mIndex).Localidade

    End Sub
End Class