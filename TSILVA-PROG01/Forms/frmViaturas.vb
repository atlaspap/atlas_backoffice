Imports System.IO
Imports DevExpress.Utils.CommonDialogs

''' <summary>
'''      Classe frmViaturas- Form da Tabela de Viaturas
'''      Gerado em 23/01/2025 15:59:30
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Class frmViaturas
    Dim mLista As New List(Of ClsViaturas)
    Dim mLista_Viaturas As New List(Of ClsViaturas)

    Dim mIndex_Viaturas As Integer = 0

    Dim mPath As String = Application.StartupPath + "\..\..\Images\Viaturas\"


    Private Sub frmViaturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mLista = ClsViaturas.GetViaturas
        mNav = New clsNav(mLista.Count)

        UC_NAV11.mFRM = Me

        SetupComps(True)
        UC_NAV11.Load_Status()
        UC_NAV11.SetupNav()
        LoadRegistos()

        Me.Text = "Manutenção da Tabela de Viaturas"

    End Sub


    Sub SetupComps(ByVal pBool As Boolean)
        Me.Cod_ViaturaTextEdit.ReadOnly = True
        If Not pBool Then
            If Me.UC_NAV11.mNovo Then
                Me.Cod_ViaturaTextEdit.Focus()
                PictureBox1.Image = Image.FromFile(mPath + "Default.png")
            Else
                Me.DescritivoTextEdit.Focus()
            End If
        End If

        DescritivoTextEdit.ReadOnly = pBool
        Vel_MediaTextEdit.ReadOnly = pBool
        LugaresTextEdit.ReadOnly = pBool
        Ano_FabricoTextEdit.ReadOnly = pBool
        Cod_ImagemTextEdit.ReadOnly = pBool
        FLG_TomadasCheckEdit.ReadOnly = pBool
        FLG_USBCheckEdit.ReadOnly = pBool
        FLG_WifiCheckEdit.ReadOnly = pBool
        FLG_ACCheckEdit.ReadOnly = pBool
        FLG_WCCheckEdit.ReadOnly = pBool
        cmdCarrega.Enabled = Not pBool
        If Not pBool Then
            cmdCarrega.Cursor = Cursors.Hand
        Else
            cmdCarrega.Cursor = Cursors.Default
        End If

        '------------------------------
        'Exemplo da eventual UltraCmbo 
        '------------------------------
        'Me.PaisUltraCombo.ReadOnly = pBool

    End Sub

    Sub LoadRegistos()
        LimpaTXT()
        If mNav.Registo_Atual > 0 Then
            With mLista(mNav.Registo_Atual - 1)
                DescritivoTextEdit.Text = .Descritivo
                Vel_MediaTextEdit.Text = .Vel_Media
                LugaresTextEdit.Text = .Lugares
                Ano_FabricoTextEdit.Text = .Ano_Fabrico
                Cod_ImagemTextEdit.Text = .Cod_Imagem
                FLG_TomadasCheckEdit.Checked = .FLG_Tomadas
                FLG_USBCheckEdit.Checked = .FLG_USB
                FLG_WifiCheckEdit.Checked = .FLG_Wifi
                FLG_ACCheckEdit.Checked = .FLG_AC
                FLG_WCCheckEdit.Checked = .FLG_WC
                '-------------------------
                ' Cod_Viatura
                '-------------------------
                Cod_ViaturaTextEdit.Text = .Cod_Viatura


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
                'ucPaises.Text = clsPaises.GetPaisbyCod(.Cod_Pais).Pais
            End With
            '-------------------------------
            'upBar.Value = mNav.Registo_Atual
            '-------------------------------

        End If

    End Sub

    Sub LimpaTXT()

        DescritivoTextEdit.Text = ""
        Vel_MediaTextEdit.Text = ""
        LugaresTextEdit.Text = ""
        Ano_FabricoTextEdit.Text = ""
        Cod_ImagemTextEdit.Text = ""
        FLG_TomadasCheckEdit.Text = ""
        FLG_USBCheckEdit.Text = ""
        FLG_WifiCheckEdit.Text = ""
        FLG_ACCheckEdit.Text = ""
        FLG_WCCheckEdit.Text = ""
        '-------------------------------
        Cod_ViaturaTextEdit.Text = ""
    End Sub


    Sub Grava(ByVal pbNovo As Boolean)

        '----------------------------------
        'Exemplo de UltraValidate
        '----------------------------------
        'UltraValidator1.Validate()
        '----------------------------------

        Dim mFLG_Gravou As Boolean = False
        Dim mCls As New ClsViaturas
        Dim mRegisto_Atual As Integer = mNav.Registo_Atual

        With mCls
            If pbNovo Then
                '--------------------------------------
                'Método Não criado na CLASSE 
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Viatura = ClsViaturas.GetNovoCodigo
                '--------------------------------------
            Else
                '--------------------------------------
                ' Se for preciso é preciso criá-lo... 
                '--------------------------------------
                .Cod_Viatura = Cod_ViaturaTextEdit.Text
            End If
            '----------------------------------
            'Aqui VERIFICAR Todos os CAMPOS
            '  Não tem por ex. o FLG_Ativo...
            '----------------------------------
            .Descritivo = DescritivoTextEdit.Text
            .Vel_Media = Vel_MediaTextEdit.Text
            .Fator_Preco = 1
            .Lugares = LugaresTextEdit.Text
            .Ano_Fabrico = Ano_FabricoTextEdit.Text
            .Cod_Imagem = Cod_ImagemTextEdit.Text
            .FLG_Tomadas = FLG_TomadasCheckEdit.Checked
            .FLG_USB = FLG_USBCheckEdit.Checked
            .FLG_Wifi = FLG_WifiCheckEdit.Checked
            .FLG_AC = FLG_ACCheckEdit.Checked
            .FLG_WC = FLG_WCCheckEdit.Checked
        End With

        If pbNovo Then
            mFLG_Gravou = ClsViaturas.GravaViaturas(mCls)
        Else
            mFLG_Gravou = ClsViaturas.ModificaViaturas(mCls)
        End If


        If mFLG_Gravou Then
            If pbNovo Then
                Me.UC_NAV11.mNovo = False
                mLista = ClsViaturas.GetViaturas
                mNav = New clsNav(mLista.Count)
                mNav.Registo_Atual = mLista.FindIndex(Function(x) x.Cod_Viatura = mCls.Cod_Viatura) + 1
                LoadRegistos()

                '---------------------------
                'upBar.Maximum = mNav.Max_Registos
                'upBar.Value = mNav.Registo_Atual
            Else
                mLista = ClsViaturas.GetViaturas
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
            ClsViaturas.ApagaViaturas(mLista(mNav.Registo_Atual - 1).Cod_Viatura)
        Catch ex As Exception
            MsgBox("Erro a Apagar o Registo Atual" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        mLista = ClsViaturas.GetViaturas
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
                Cod_ViaturaTextEdit.Text = ClsViaturas.GetNovoCodigo()

            End If

            Me.Cod_ImagemTextEdit.Text = Cod_ViaturaTextEdit.Text + mExt
            mFileDestino = mPath + Cod_ViaturaTextEdit.Text + mExt
Cont:
            Try
                File.Copy(OpenFileDialog1.FileName, mFileDestino, True)
            Catch ex As Exception

                If File.Exists(mFileDestino) Then
                    mCont += 1
                    mFileDestino = mPath + Cod_ViaturaTextEdit.Text + mCont.ToString("00") + mExt
                    GoTo Cont
                End If


            End Try
            Me.PictureBox1.Image = Image.FromFile(mFileDestino)

            If mCont > 0 Then
                Me.PictureBox1.Tag = Cod_ViaturaTextEdit.Text + mCont.ToString("00") + mExt
            Else
                Me.PictureBox1.Tag = Cod_ViaturaTextEdit.Text + mExt
            End If

        End If
    End Sub


    Private Sub cmdCarrega_Click(sender As Object, e As EventArgs) Handles cmdCarrega.Click
        Carregar_Imagem()
    End Sub

End Class
