

''' <summary>
'''      Classe frmLocalidades- Form da Tabela de Localidades
'''      Gerado em 08/10/2024 13:36:11
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class frmLocalidades
    Dim mLista As New List(Of ClsLocalidades)

    Private Sub frmLocalidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mLista = ClsLocalidades.GetLocalidades
        mNav = New clsNav(mLista.Count)

        UC_NAV11.mFRM = Me

        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()
        LoadRegistos()

        Me.Text = "Manutenção da Tabela de Localidades"

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


        '-----------------
        'ucPaises
        '-----------------
        'ucPaises.DataSource = clsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"


    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        Me.Cod_LocalidadeTextEdit.ReadOnly = True
        If Not pBool Then
            If Me.UC_NAV11.mNovo Then
                Me.Cod_LocalidadeTextEdit.Focus()
            Else
                Me.LocalidadeTextEdit.Focus()
            End If
        End If
        LocalidadeTextEdit.ReadOnly = pBool

        '------------------------------
        'Exemplo da eventual UltraCmbo 
        '------------------------------
        'Me.PaisUltraCombo.ReadOnly = pBool

    End Sub

    Sub LoadRegistos()
        LimpaTXT()
        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)
                LocalidadeTextEdit.Text = .Localidade
                '-------------------------
                ' Cod_Localidade
                '-------------------------
                Cod_LocalidadeTextEdit.Text = .Cod_Localidade

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

        LocalidadeTextEdit.Text = ""
        '-------------------------------
        Cod_LocalidadeTextEdit.Text = ""
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsLocalidades
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls
            If pbNovo Then
                '--------------------------------------
                'Método Não criado na CLASSE 
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                '.Cod_Localidade = ClsLocalidades.GetNovoCodigo
                '--------------------------------------
            Else
                '--------------------------------------
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Localidade = Cod_LocalidadeTextEdit.Text
            End If
            '----------------------------------
            'Aqui VERIFICAR Todos os CAMPOS
            '  Não tem por ex. o FLG_Ativo...
            '----------------------------------
            .Localidade = LocalidadeTextEdit.Text
        End With

        If pbNovo Then
            mFLG_Gravou = ClsLocalidades.GravaLocalidades(mCls)
        Else
            mFLG_Gravou = ClsLocalidades.ModificaLocalidades(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV11.mNovo = False
                mLista = ClsLocalidades.GetLocalidades
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Localidade = mCls.Cod_Localidade) + 1
                LoadRegistos()

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsLocalidades.GetLocalidades
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
            ClsLocalidades.ApagaLocalidades(mLista(mNav.Registo_Atual - 1).Cod_Localidade)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsLocalidades.GetLocalidades
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub

    Private Sub frmLocalidades_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmMain.Load_Menu(enMenu.Init)
    End Sub
End Class
