

''' <summary>
'''      Classe frmDistritos- Form da Tabela de Distritos
'''      Gerado em 08/10/2024 13:36:10
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class frmDistritos
    Dim mLista As New List(Of ClsDistritos)

    Private Sub frmDistritos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mLista = ClsDistritos.GetDistritos
        mNav = New clsNav(mLista.Count)

        UC_NAV11.mFRM = Me

        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()
        LoadRegistos()

        Me.Text = "Manutenção da Tabela de Distritos"

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
        ' A mLista que contém a lista de Distritos
        ' pode ser filtrada através do método
        ' FiltrarDistritos com o parâmetro da ClsDistritos
        ' 
        ' É preciso criar uma variável do tipo ClsDistritos
        ' e chamar o método FiltrarDistritos com esse parâmetro:
        '
        '   Dim mclsFiltro as New clsDistritos with {.Cod_Distrito=txtCod_Distrito.Text, .Distrito=txtDistrito.Text}
        '   Dim mListaFiltro = clsDistritos.FiltrarDistritos(mclsFiltro)
        '----------------------------------------------------------------------------------------------

        '-----------------
        'ucPaises
        '-----------------
        'ucPaises.DataSource = clsPaises.GetPaises
        'ucPaises.DisplayMember = "Pais"
        'ucPaises.ValueMember = "Cod_Pais"


    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        Me.Cod_DistritoTextEdit.ReadOnly = True
        If Not pBool Then
            If Me.UC_NAV11.mNovo Then
                Me.Cod_DistritoTextEdit.Focus()
            Else
                Me.DistritoTextEdit.Focus()
            End If
        End If
        DistritoTextEdit.ReadOnly = pBool

        '------------------------------
        'Exemplo da eventual UltraCmbo 
        '------------------------------
        'Me.PaisUltraCombo.ReadOnly = pBool

    End Sub

    Sub LoadRegistos()
        LimpaTXT()
        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)
                DistritoTextEdit.Text = .Distrito
                '-------------------------
                ' Cod_Distrito
                '-------------------------
                Cod_DistritoTextEdit.Text = .Cod_Distrito

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

        DistritoTextEdit.Text = ""
        '-------------------------------
        Cod_DistritoTextEdit.Text = ""
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsDistritos
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls
            If pbNovo Then
                '--------------------------------------
                'Método Não criado na CLASSE 
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                '.Cod_Distrito = ClsDistritos.GetNovoCodigo
                '--------------------------------------
            Else
                '--------------------------------------
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Distrito = Cod_DistritoTextEdit.Text
            End If
            '----------------------------------
            'Aqui VERIFICAR Todos os CAMPOS
            '  Não tem por ex. o FLG_Ativo...
            '----------------------------------
            .Distrito = DistritoTextEdit.Text
        End With

        If pbNovo Then
            mFLG_Gravou = ClsDistritos.GravaDistritos(mCls)
        Else
            mFLG_Gravou = ClsDistritos.ModificaDistritos(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV11.mNovo = False
                mLista = ClsDistritos.GetDistritos
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Distrito = mCls.Cod_Distrito) + 1
                LoadRegistos()

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsDistritos.GetDistritos
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
            ClsDistritos.ApagaDistritos(mLista(mNav.Registo_Atual - 1).Cod_Distrito)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsDistritos.GetDistritos
        mNav = New clsNav(mLista.Count)
        LoadRegistos()
    End Sub

    Private Sub frmDistritos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmMain.Load_Menu(enMenu.Init)
    End Sub
End Class
