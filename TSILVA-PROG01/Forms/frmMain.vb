Imports DevExpress.XtraBars.FluentDesignSystem
Imports DevExpress.XtraRichEdit


Public Enum enMenu

    Init
    Distritos
    Entidades
    Rotas
    Viaturas
    Paragens
    Distancias
    Leitor
    Perfil
    Viagens

End Enum

Public Class frmMain
    Dim mFrm As New Form
    Dim mContentor As New FluentDesignFormContainer


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Load_Main()
    End Sub

    Public Sub Load_Main()

        Dim mPrivilege As String = frmLogin.mFLG_Entidade

        Me.WindowState = FormWindowState.Maximized


        Apply_Privileges(mPrivilege)

            mFrm.Parent = Nothing
        mContentor = Me.FluentDesignFormContainer1
        Load_Menu(enMenu.Init)

    End Sub
    Sub Apply_Privileges(ByVal pPrivilege As String)

        Select Case pPrivilege
            Case "E"
                aceEntidades.Visible = False
                aceLeitor.Visible = False

                aceParagens.Visible = True
                aceRotas.Visible = True
                aceViaturas.Visible = True
                aceDistancias.Visible = True
            Case "A"
                aceEntidades.Visible = True
                aceLeitor.Visible = True

                aceParagens.Visible = True
                aceRotas.Visible = True
                aceViaturas.Visible = True
                aceDistancias.Visible = True
        End Select


    End Sub
    Sub Load_Menu(ByVal pMenu As enMenu)
        Select Case pMenu

            Case enMenu.Entidades
                mFrm = New frmEntidades
            Case enMenu.Init
                mFrm = New frmINIT
            Case enMenu.Distritos
                mFrm = New frmDistritos
            Case enMenu.Rotas
                mFrm = New frmRotas
            Case enMenu.Paragens
                mFrm = New frmParagens
            Case enMenu.Viaturas
                mFrm = New frmViaturas
            Case enMenu.Distancias
                mFrm = New frmDistancias
            Case enMenu.Leitor
                mFrm = New frmLeitor
            Case enMenu.Perfil
                mFrm = New frmPerfil
            Case enMenu.Viagens
                mFrm = New frmViagens
        End Select

        mFrm.Dock = DockStyle.Fill
        mFrm.FormBorderStyle = FormBorderStyle.None
        mFrm.TopLevel = False
        mFrm.Parent = mContentor
        mFrm.WindowState = FormWindowState.Maximized
        mFrm.Show()

    End Sub


    'Private Sub aceFomularios_Click(sender As Object, e As EventArgs) Handles aceFomularios.Click
    '    mFrm.Parent = Nothing
    '    Load_Menu(enMenu.Paises)

    'End Sub

    Private Sub frmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Hide()
        frmLogin.Close()
    End Sub

    Private Sub aceRotas_Click(sender As Object, e As EventArgs) Handles aceRotas.Click
        mFrm.Parent = Nothing
        Load_Menu(enMenu.Rotas)
    End Sub

    Private Sub aceParagens_Click(sender As Object, e As EventArgs) Handles aceParagens.Click
        mFrm.Parent = Nothing
        Load_Menu(enMenu.Paragens)
    End Sub

    Private Sub aceViaturas_Click(sender As Object, e As EventArgs) Handles aceViaturas.Click
        mFrm.Parent = Nothing
        Load_Menu(enMenu.Viaturas)
    End Sub

    Private Sub aceDistancias_Click(sender As Object, e As EventArgs) Handles aceDistancias.Click
        mFrm.Parent = Nothing
        Load_Menu(enMenu.Distancias)
    End Sub

    Private Sub aceTeste_Click(sender As Object, e As EventArgs)
        frmLeitor.Show()
    End Sub

    Private Sub aceEntidades_Click(sender As Object, e As EventArgs) Handles aceEntidades.Click
        mFrm.Parent = Nothing
        Load_Menu(enMenu.Entidades)
    End Sub

    Private Sub cmdLogout_Click(sender As Object, e As EventArgs) Handles cmdLogout.Click
        Me.Hide()
        frmLogin.Show()
        frmLogin.TextEditUsername.Focus()
    End Sub

    Private Sub aceViagens_Click(sender As Object, e As EventArgs) Handles aceViagens.Click
        mFrm.Parent = Nothing
        Load_Menu(enMenu.Viagens)
    End Sub

    Private Sub aceLeitor_Click(sender As Object, e As EventArgs) Handles aceLeitor.Click
        mFrm.Parent = Nothing
        Load_Menu(enMenu.Leitor)
    End Sub

    Private Sub cmdProfile_Click(sender As Object, e As EventArgs) Handles cmdProfile.Click
        mFrm.Parent = Nothing
        Load_Menu(enMenu.Perfil)
    End Sub
End Class