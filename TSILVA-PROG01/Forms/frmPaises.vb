

''' <summary>
'''      Classe frmPaises- Form da Tabela de Paises
'''      Gerado em 08/10/2024 13:36:11
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class frmPaises
    Dim mLista As New List(Of ClsPaises)

    Private Sub frmPaises_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mLista = ClsPaises.GetPaises
        mNav = New clsNav(mLista.Count)

        UC_NAV11.mFRM = Me

        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()
        LoadRegistos()

        Me.Text = "Manutenção da Tabela de Paises"

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
        ' A mLista que contém a lista de Paises
        ' pode ser filtrada através do método
        ' FiltrarPaises com o parâmetro da ClsPaises
        ' 
        ' É preciso criar uma variável do tipo ClsPaises
        ' e chamar o método FiltrarPaises com esse parâmetro:
        '
        '   Dim mclsFiltro as New clsPaises with {.Cod_Pais=txtCod_Pais.Text, .Pais=txtPais.Text}
        '   Dim mListaFiltro = clsPaises.FiltrarPaises(mclsFiltro)
        '----------------------------------------------------------------------------------------------

        '-----------------
        'ucPaises
        '-----------------
        'ucPaises.DataSource = clsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"


    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        Me.Cod_PaisTextEdit.ReadOnly = True
        If Not pBool Then
            If Me.UC_NAV11.mNovo Then
                Me.Cod_PaisTextEdit.Focus()
            Else
                Me.PaisTextEdit.Focus()
            End If
        End If
        PaisTextEdit.ReadOnly = pBool

        '------------------------------
        'Exemplo da eventual UltraCmbo 
        '------------------------------
        'Me.PaisUltraCombo.ReadOnly = pBool

    End Sub

    Sub LoadRegistos()
        LimpaTXT()
        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)
                PaisTextEdit.Text = .Pais
                '-------------------------
                ' Cod_Pais
                '-------------------------
                Cod_PaisTextEdit.Text = .Cod_Pais

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

        PaisTextEdit.Text = ""
        '-------------------------------
        Cod_PaisTextEdit.Text = ""
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsPaises
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls
            If pbNovo Then
                '--------------------------------------
                'Método Não criado na CLASSE 
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                '.Cod_Pais = ClsPaises.GetNovoCodigo
                '--------------------------------------
            Else
                '--------------------------------------
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Pais = Cod_PaisTextEdit.Text
            End If
            '----------------------------------
            'Aqui VERIFICAR Todos os CAMPOS
            '  Não tem por ex. o FLG_Ativo...
            '----------------------------------
            .Pais = PaisTextEdit.Text
        End With

        If pbNovo Then
            mFLG_Gravou = ClsPaises.GravaPaises(mCls)
        Else
            mFLG_Gravou = ClsPaises.ModificaPaises(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV11.mNovo = False
                mLista = ClsPaises.GetPaises
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Pais = mCls.Cod_Pais) + 1
                LoadRegistos()

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsPaises.GetPaises
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
            ClsPaises.ApagaPaises(mLista(mNav.Registo_Atual - 1).Cod_Pais)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsPaises.GetPaises
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub

    Private Sub frmPaises_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmMain.Load_Menu(enMenu.Init)
    End Sub
End Class
