<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNovaViagem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim Data_ViagemLabel As System.Windows.Forms.Label
        Dim Cod_RotaLabel As System.Windows.Forms.Label
        Dim Tipo_ViagemLabel As System.Windows.Forms.Label
        Dim Cod_MotoristaLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Cod_ViaturaLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsViaturas", -1)
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Viatura")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descritivo")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vel_Media")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fator_Preco")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Lugares")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ano_Fabrico")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Imagem")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Tomadas")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_USB")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Wifi")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_AC")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_WC")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsEntidades", -1)
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Entidade")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Entidade")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Num_Cartao")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Login")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Password")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nome")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Imagem")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Num_Telefone")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Num_Telemovel")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Email")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NIF")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Data_Registo")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsRotas", -1)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Rota")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descritivo")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Num_Paragens")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Lista_Paragens")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Lista_Paragens", 0)
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Rota")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Paragem")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ordem")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tempo_Min")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Paragem_Descritivo")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Paragem_Localidade")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Paragem_Endereco")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dist_Km")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsTipos_Viagem", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo_VIagem")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SIGLA")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descrtivo")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsViagens", -1)
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Viagem")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descritivo")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo_Viagem")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SIGLA_Tipo_Viagem")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DESC_Tipo_Viagem")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Viatura")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viatura")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Rota")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Data_Viagem")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia_Semana")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ETD")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ATD")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Motorista")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nome_Motorista")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Num_Paragens")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Estado")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Lista_VParagens")
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Lista_VParagens", 0)
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Viagem")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Paragem")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ordem")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descritivo")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ETD")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ATD")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loc01")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loc02")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Localizacao")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.WizardControl1 = New DevExpress.XtraWizard.WizardControl()
        Me.WelcomeWizardPage1 = New DevExpress.XtraWizard.WelcomeWizardPage()
        Me.WizardPage1 = New DevExpress.XtraWizard.WizardPage()
        Me.ucViaturas = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Cod_ViaturaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ucMotoristas = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.ucRotas = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.ucTipos_Viagem = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Cod_MotoristaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Tipo_ViagemTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_RotaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Data_ViagemDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.CompletionWizardPage1 = New DevExpress.XtraWizard.CompletionWizardPage()
        Me.WizardPage2 = New DevExpress.XtraWizard.WizardPage()
        Me.ugViagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Data_ViagemLabel = New System.Windows.Forms.Label()
        Cod_RotaLabel = New System.Windows.Forms.Label()
        Tipo_ViagemLabel = New System.Windows.Forms.Label()
        Cod_MotoristaLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Cod_ViaturaLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.WizardControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WizardControl1.SuspendLayout()
        Me.WizardPage1.SuspendLayout()
        CType(Me.ucViaturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_ViaturaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucMotoristas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucRotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucTipos_Viagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_MotoristaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tipo_ViagemTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_RotaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_ViagemDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_ViagemDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WizardPage2.SuspendLayout()
        CType(Me.ugViagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Data_ViagemLabel
        '
        Data_ViagemLabel.AutoSize = True
        Data_ViagemLabel.Location = New System.Drawing.Point(150, 131)
        Data_ViagemLabel.Name = "Data_ViagemLabel"
        Data_ViagemLabel.Size = New System.Drawing.Size(71, 13)
        Data_ViagemLabel.TabIndex = 0
        Data_ViagemLabel.Text = "Data Viagem:"
        '
        'Cod_RotaLabel
        '
        Cod_RotaLabel.AutoSize = True
        Cod_RotaLabel.Location = New System.Drawing.Point(603, 161)
        Cod_RotaLabel.Name = "Cod_RotaLabel"
        Cod_RotaLabel.Size = New System.Drawing.Size(55, 13)
        Cod_RotaLabel.TabIndex = 2
        Cod_RotaLabel.Text = "Cod Rota:"
        '
        'Tipo_ViagemLabel
        '
        Tipo_ViagemLabel.AutoSize = True
        Tipo_ViagemLabel.Location = New System.Drawing.Point(589, 135)
        Tipo_ViagemLabel.Name = "Tipo_ViagemLabel"
        Tipo_ViagemLabel.Size = New System.Drawing.Size(69, 13)
        Tipo_ViagemLabel.TabIndex = 4
        Tipo_ViagemLabel.Text = "Tipo Viagem:"
        '
        'Cod_MotoristaLabel
        '
        Cod_MotoristaLabel.AutoSize = True
        Cod_MotoristaLabel.Location = New System.Drawing.Point(583, 187)
        Cod_MotoristaLabel.Name = "Cod_MotoristaLabel"
        Cod_MotoristaLabel.Size = New System.Drawing.Size(75, 13)
        Cod_MotoristaLabel.TabIndex = 6
        Cod_MotoristaLabel.Text = "Cod Motorista:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(150, 160)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(69, 13)
        Label1.TabIndex = 9
        Label1.Text = "Tipo Viagem:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(184, 186)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(33, 13)
        Label2.TabIndex = 10
        Label2.Text = "Rota:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(164, 215)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(53, 13)
        Label3.TabIndex = 11
        Label3.Text = "Motorista:"
        '
        'Cod_ViaturaLabel
        '
        Cod_ViaturaLabel.AutoSize = True
        Cod_ViaturaLabel.Location = New System.Drawing.Point(593, 213)
        Cod_ViaturaLabel.Name = "Cod_ViaturaLabel"
        Cod_ViaturaLabel.Size = New System.Drawing.Size(65, 13)
        Cod_ViaturaLabel.TabIndex = 14
        Cod_ViaturaLabel.Text = "Cod Viatura:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(174, 240)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(43, 13)
        Label4.TabIndex = 16
        Label4.Text = "Viatura:"
        '
        'WizardControl1
        '
        Me.WizardControl1.Controls.Add(Me.WelcomeWizardPage1)
        Me.WizardControl1.Controls.Add(Me.WizardPage1)
        Me.WizardControl1.Controls.Add(Me.CompletionWizardPage1)
        Me.WizardControl1.Controls.Add(Me.WizardPage2)
        Me.WizardControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WizardControl1.ImageOptions.Image = Global.DEMO_BACKOFFICE.My.Resources.Resources.ATLAS
        Me.WizardControl1.ImageOptions.Layout = System.Windows.Forms.ImageLayout.Zoom
        Me.WizardControl1.Name = "WizardControl1"
        Me.WizardControl1.Pages.AddRange(New DevExpress.XtraWizard.BaseWizardPage() {Me.WelcomeWizardPage1, Me.WizardPage1, Me.WizardPage2, Me.CompletionWizardPage1})
        Me.WizardControl1.Size = New System.Drawing.Size(1165, 675)
        Me.WizardControl1.Text = "WIzard de Viagens"
        '
        'WelcomeWizardPage1
        '
        Me.WelcomeWizardPage1.IntroductionText = ""
        Me.WelcomeWizardPage1.Name = "WelcomeWizardPage1"
        Me.WelcomeWizardPage1.ProceedText = "Pressione ""Enter"" ou clique ""Next""."
        Me.WelcomeWizardPage1.Size = New System.Drawing.Size(948, 543)
        Me.WelcomeWizardPage1.Text = "CRIAR VIAGEM"
        '
        'WizardPage1
        '
        Me.WizardPage1.Controls.Add(Me.ucViaturas)
        Me.WizardPage1.Controls.Add(Label4)
        Me.WizardPage1.Controls.Add(Cod_ViaturaLabel)
        Me.WizardPage1.Controls.Add(Me.Cod_ViaturaTextEdit)
        Me.WizardPage1.Controls.Add(Me.ucMotoristas)
        Me.WizardPage1.Controls.Add(Me.ucRotas)
        Me.WizardPage1.Controls.Add(Label3)
        Me.WizardPage1.Controls.Add(Label2)
        Me.WizardPage1.Controls.Add(Label1)
        Me.WizardPage1.Controls.Add(Me.ucTipos_Viagem)
        Me.WizardPage1.Controls.Add(Cod_MotoristaLabel)
        Me.WizardPage1.Controls.Add(Me.Cod_MotoristaTextEdit)
        Me.WizardPage1.Controls.Add(Tipo_ViagemLabel)
        Me.WizardPage1.Controls.Add(Me.Tipo_ViagemTextEdit)
        Me.WizardPage1.Controls.Add(Cod_RotaLabel)
        Me.WizardPage1.Controls.Add(Me.Cod_RotaTextEdit)
        Me.WizardPage1.Controls.Add(Data_ViagemLabel)
        Me.WizardPage1.Controls.Add(Me.Data_ViagemDateEdit)
        Me.WizardPage1.DescriptionText = "Defina as propriedades da viagem."
        Me.WizardPage1.Name = "WizardPage1"
        Me.WizardPage1.Size = New System.Drawing.Size(1133, 532)
        Me.WizardPage1.Text = "PROPRIEDADES DA VIAGEM"
        '
        'ucViaturas
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucViaturas.DisplayLayout.Appearance = Appearance1
        UltraGridColumn32.Header.VisiblePosition = 0
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 1
        UltraGridColumn33.Width = 267
        UltraGridColumn34.Header.VisiblePosition = 2
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 3
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.Header.VisiblePosition = 4
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.Header.VisiblePosition = 5
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.Header.VisiblePosition = 6
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.VisiblePosition = 7
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.Header.VisiblePosition = 8
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.Header.VisiblePosition = 9
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.Header.VisiblePosition = 10
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.Header.VisiblePosition = 11
        UltraGridColumn43.Hidden = True
        UltraGridColumn44.Header.VisiblePosition = 12
        UltraGridColumn44.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44})
        Me.ucViaturas.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ucViaturas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucViaturas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ucViaturas.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.ucViaturas.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucViaturas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.ucViaturas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucViaturas.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.ucViaturas.DisplayLayout.MaxColScrollRegions = 1
        Me.ucViaturas.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucViaturas.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucViaturas.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.ucViaturas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucViaturas.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.ucViaturas.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucViaturas.DisplayLayout.Override.CellAppearance = Appearance8
        Me.ucViaturas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucViaturas.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.ucViaturas.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.ucViaturas.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.ucViaturas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucViaturas.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.ucViaturas.DisplayLayout.Override.RowAppearance = Appearance11
        Me.ucViaturas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucViaturas.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.ucViaturas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucViaturas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucViaturas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucViaturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucViaturas.Location = New System.Drawing.Point(227, 240)
        Me.ucViaturas.Name = "ucViaturas"
        Me.ucViaturas.Size = New System.Drawing.Size(174, 22)
        Me.ucViaturas.TabIndex = 17
        '
        'Cod_ViaturaTextEdit
        '
        Me.Cod_ViaturaTextEdit.Location = New System.Drawing.Point(664, 210)
        Me.Cod_ViaturaTextEdit.Name = "Cod_ViaturaTextEdit"
        Me.Cod_ViaturaTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Cod_ViaturaTextEdit.TabIndex = 15
        '
        'ucMotoristas
        '
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucMotoristas.DisplayLayout.Appearance = Appearance13
        UltraGridColumn19.Header.VisiblePosition = 0
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 1
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 2
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 3
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 4
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 5
        UltraGridColumn24.Width = 302
        UltraGridColumn25.Header.VisiblePosition = 6
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 7
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 8
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 9
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 10
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 11
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.Header.VisiblePosition = 12
        UltraGridColumn31.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31})
        Me.ucMotoristas.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ucMotoristas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucMotoristas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ucMotoristas.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.ucMotoristas.DisplayLayout.GroupByBox.Appearance = Appearance14
        Appearance15.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucMotoristas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance15
        Me.ucMotoristas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance16.BackColor2 = System.Drawing.SystemColors.Control
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucMotoristas.DisplayLayout.GroupByBox.PromptAppearance = Appearance16
        Me.ucMotoristas.DisplayLayout.MaxColScrollRegions = 1
        Me.ucMotoristas.DisplayLayout.MaxRowScrollRegions = 1
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucMotoristas.DisplayLayout.Override.ActiveCellAppearance = Appearance17
        Appearance18.BackColor = System.Drawing.SystemColors.Highlight
        Appearance18.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucMotoristas.DisplayLayout.Override.ActiveRowAppearance = Appearance18
        Me.ucMotoristas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucMotoristas.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Me.ucMotoristas.DisplayLayout.Override.CardAreaAppearance = Appearance19
        Appearance20.BorderColor = System.Drawing.Color.Silver
        Appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucMotoristas.DisplayLayout.Override.CellAppearance = Appearance20
        Me.ucMotoristas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucMotoristas.DisplayLayout.Override.CellPadding = 0
        Appearance21.BackColor = System.Drawing.SystemColors.Control
        Appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance21.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance21.BorderColor = System.Drawing.SystemColors.Window
        Me.ucMotoristas.DisplayLayout.Override.GroupByRowAppearance = Appearance21
        Appearance22.TextHAlignAsString = "Left"
        Me.ucMotoristas.DisplayLayout.Override.HeaderAppearance = Appearance22
        Me.ucMotoristas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucMotoristas.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.BorderColor = System.Drawing.Color.Silver
        Me.ucMotoristas.DisplayLayout.Override.RowAppearance = Appearance23
        Me.ucMotoristas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance24.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucMotoristas.DisplayLayout.Override.TemplateAddRowAppearance = Appearance24
        Me.ucMotoristas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucMotoristas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucMotoristas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucMotoristas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucMotoristas.Location = New System.Drawing.Point(227, 211)
        Me.ucMotoristas.Name = "ucMotoristas"
        Me.ucMotoristas.Size = New System.Drawing.Size(174, 22)
        Me.ucMotoristas.TabIndex = 13
        '
        'ucRotas
        '
        Appearance25.BackColor = System.Drawing.SystemColors.Window
        Appearance25.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucRotas.DisplayLayout.Appearance = Appearance25
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 1
        UltraGridColumn6.Width = 231
        UltraGridColumn7.Header.VisiblePosition = 2
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 3
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 4
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9})
        UltraGridColumn10.Header.VisiblePosition = 0
        UltraGridColumn11.Header.VisiblePosition = 1
        UltraGridColumn11.Width = 231
        UltraGridColumn12.Header.VisiblePosition = 2
        UltraGridColumn13.Header.VisiblePosition = 3
        UltraGridColumn14.Header.VisiblePosition = 4
        UltraGridColumn15.Header.VisiblePosition = 5
        UltraGridColumn16.Header.VisiblePosition = 6
        UltraGridColumn17.Header.VisiblePosition = 7
        UltraGridColumn18.Header.VisiblePosition = 8
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18})
        Me.ucRotas.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.ucRotas.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.ucRotas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucRotas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ucRotas.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance26.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance26.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance26.BorderColor = System.Drawing.SystemColors.Window
        Me.ucRotas.DisplayLayout.GroupByBox.Appearance = Appearance26
        Appearance27.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucRotas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance27
        Me.ucRotas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance28.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance28.BackColor2 = System.Drawing.SystemColors.Control
        Appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance28.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucRotas.DisplayLayout.GroupByBox.PromptAppearance = Appearance28
        Me.ucRotas.DisplayLayout.MaxColScrollRegions = 1
        Me.ucRotas.DisplayLayout.MaxRowScrollRegions = 1
        Appearance29.BackColor = System.Drawing.SystemColors.Window
        Appearance29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucRotas.DisplayLayout.Override.ActiveCellAppearance = Appearance29
        Appearance30.BackColor = System.Drawing.SystemColors.Highlight
        Appearance30.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucRotas.DisplayLayout.Override.ActiveRowAppearance = Appearance30
        Me.ucRotas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucRotas.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance31.BackColor = System.Drawing.SystemColors.Window
        Me.ucRotas.DisplayLayout.Override.CardAreaAppearance = Appearance31
        Appearance32.BorderColor = System.Drawing.Color.Silver
        Appearance32.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucRotas.DisplayLayout.Override.CellAppearance = Appearance32
        Me.ucRotas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucRotas.DisplayLayout.Override.CellPadding = 0
        Appearance33.BackColor = System.Drawing.SystemColors.Control
        Appearance33.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance33.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance33.BorderColor = System.Drawing.SystemColors.Window
        Me.ucRotas.DisplayLayout.Override.GroupByRowAppearance = Appearance33
        Appearance34.TextHAlignAsString = "Left"
        Me.ucRotas.DisplayLayout.Override.HeaderAppearance = Appearance34
        Me.ucRotas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucRotas.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance35.BackColor = System.Drawing.SystemColors.Window
        Appearance35.BorderColor = System.Drawing.Color.Silver
        Me.ucRotas.DisplayLayout.Override.RowAppearance = Appearance35
        Me.ucRotas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance36.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucRotas.DisplayLayout.Override.TemplateAddRowAppearance = Appearance36
        Me.ucRotas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucRotas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucRotas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucRotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucRotas.Location = New System.Drawing.Point(227, 183)
        Me.ucRotas.Name = "ucRotas"
        Me.ucRotas.Size = New System.Drawing.Size(174, 22)
        Me.ucRotas.TabIndex = 12
        '
        'ucTipos_Viagem
        '
        Appearance37.BackColor = System.Drawing.SystemColors.Window
        Appearance37.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucTipos_Viagem.DisplayLayout.Appearance = Appearance37
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 207
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4})
        Me.ucTipos_Viagem.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.ucTipos_Viagem.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucTipos_Viagem.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ucTipos_Viagem.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance38.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance38.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance38.BorderColor = System.Drawing.SystemColors.Window
        Me.ucTipos_Viagem.DisplayLayout.GroupByBox.Appearance = Appearance38
        Appearance39.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucTipos_Viagem.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance39
        Me.ucTipos_Viagem.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance40.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance40.BackColor2 = System.Drawing.SystemColors.Control
        Appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance40.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucTipos_Viagem.DisplayLayout.GroupByBox.PromptAppearance = Appearance40
        Me.ucTipos_Viagem.DisplayLayout.MaxColScrollRegions = 1
        Me.ucTipos_Viagem.DisplayLayout.MaxRowScrollRegions = 1
        Appearance41.BackColor = System.Drawing.SystemColors.Window
        Appearance41.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucTipos_Viagem.DisplayLayout.Override.ActiveCellAppearance = Appearance41
        Appearance42.BackColor = System.Drawing.SystemColors.Highlight
        Appearance42.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucTipos_Viagem.DisplayLayout.Override.ActiveRowAppearance = Appearance42
        Me.ucTipos_Viagem.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucTipos_Viagem.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance43.BackColor = System.Drawing.SystemColors.Window
        Me.ucTipos_Viagem.DisplayLayout.Override.CardAreaAppearance = Appearance43
        Appearance44.BorderColor = System.Drawing.Color.Silver
        Appearance44.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucTipos_Viagem.DisplayLayout.Override.CellAppearance = Appearance44
        Me.ucTipos_Viagem.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucTipos_Viagem.DisplayLayout.Override.CellPadding = 0
        Appearance45.BackColor = System.Drawing.SystemColors.Control
        Appearance45.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance45.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance45.BorderColor = System.Drawing.SystemColors.Window
        Me.ucTipos_Viagem.DisplayLayout.Override.GroupByRowAppearance = Appearance45
        Appearance46.TextHAlignAsString = "Left"
        Me.ucTipos_Viagem.DisplayLayout.Override.HeaderAppearance = Appearance46
        Me.ucTipos_Viagem.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucTipos_Viagem.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance47.BackColor = System.Drawing.SystemColors.Window
        Appearance47.BorderColor = System.Drawing.Color.Silver
        Me.ucTipos_Viagem.DisplayLayout.Override.RowAppearance = Appearance47
        Me.ucTipos_Viagem.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance48.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucTipos_Viagem.DisplayLayout.Override.TemplateAddRowAppearance = Appearance48
        Me.ucTipos_Viagem.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucTipos_Viagem.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucTipos_Viagem.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucTipos_Viagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucTipos_Viagem.Location = New System.Drawing.Point(227, 155)
        Me.ucTipos_Viagem.Name = "ucTipos_Viagem"
        Me.ucTipos_Viagem.Size = New System.Drawing.Size(174, 22)
        Me.ucTipos_Viagem.TabIndex = 8
        '
        'Cod_MotoristaTextEdit
        '
        Me.Cod_MotoristaTextEdit.Location = New System.Drawing.Point(664, 184)
        Me.Cod_MotoristaTextEdit.Name = "Cod_MotoristaTextEdit"
        Me.Cod_MotoristaTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Cod_MotoristaTextEdit.TabIndex = 7
        '
        'Tipo_ViagemTextEdit
        '
        Me.Tipo_ViagemTextEdit.Location = New System.Drawing.Point(664, 132)
        Me.Tipo_ViagemTextEdit.Name = "Tipo_ViagemTextEdit"
        Me.Tipo_ViagemTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Tipo_ViagemTextEdit.TabIndex = 5
        '
        'Cod_RotaTextEdit
        '
        Me.Cod_RotaTextEdit.Location = New System.Drawing.Point(664, 158)
        Me.Cod_RotaTextEdit.Name = "Cod_RotaTextEdit"
        Me.Cod_RotaTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Cod_RotaTextEdit.TabIndex = 3
        '
        'Data_ViagemDateEdit
        '
        Me.Data_ViagemDateEdit.EditValue = Nothing
        Me.Data_ViagemDateEdit.Location = New System.Drawing.Point(227, 128)
        Me.Data_ViagemDateEdit.Name = "Data_ViagemDateEdit"
        Me.Data_ViagemDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Data_ViagemDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Data_ViagemDateEdit.Properties.DisplayFormat.FormatString = ""
        Me.Data_ViagemDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Data_ViagemDateEdit.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.Data_ViagemDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Data_ViagemDateEdit.Properties.MaskSettings.Set("mask", "T")
        Me.Data_ViagemDateEdit.Size = New System.Drawing.Size(174, 20)
        Me.Data_ViagemDateEdit.TabIndex = 1
        '
        'CompletionWizardPage1
        '
        Me.CompletionWizardPage1.AllowFinish = False
        Me.CompletionWizardPage1.FinishText = ""
        Me.CompletionWizardPage1.Name = "CompletionWizardPage1"
        Me.CompletionWizardPage1.ProceedText = "Clique em qualquer parte do ecrã para confirmar a viagem."
        Me.CompletionWizardPage1.Size = New System.Drawing.Size(948, 543)
        Me.CompletionWizardPage1.Text = "VIAGEM QUASE CRIADA"
        '
        'WizardPage2
        '
        Me.WizardPage2.Controls.Add(Me.ugViagem)
        Me.WizardPage2.DescriptionText = "Escolher Gravar a Viagem?"
        Me.WizardPage2.Name = "WizardPage2"
        Me.WizardPage2.Size = New System.Drawing.Size(1133, 532)
        Me.WizardPage2.Text = "Wizard - Viagem Criada"
        '
        'ugViagem
        '
        Appearance49.BackColor = System.Drawing.SystemColors.Window
        Appearance49.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugViagem.DisplayLayout.Appearance = Appearance49
        UltraGridColumn45.Header.VisiblePosition = 0
        UltraGridColumn45.Width = 74
        UltraGridColumn46.Header.VisiblePosition = 1
        UltraGridColumn46.Width = 307
        UltraGridColumn47.Header.VisiblePosition = 2
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.Header.VisiblePosition = 3
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.Header.VisiblePosition = 4
        UltraGridColumn49.Width = 124
        UltraGridColumn50.Header.VisiblePosition = 5
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Header.VisiblePosition = 6
        UltraGridColumn51.Width = 101
        UltraGridColumn52.Header.VisiblePosition = 7
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.Format = "dd/MM/yyyy HH:mm"
        UltraGridColumn53.Header.VisiblePosition = 8
        UltraGridColumn54.Header.VisiblePosition = 9
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 10
        UltraGridColumn55.Width = 87
        UltraGridColumn56.Format = "HH:mm"
        UltraGridColumn56.Header.VisiblePosition = 11
        UltraGridColumn56.Width = 86
        UltraGridColumn57.Header.VisiblePosition = 12
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.Header.VisiblePosition = 13
        UltraGridColumn58.Width = 151
        UltraGridColumn59.Header.VisiblePosition = 14
        UltraGridColumn59.Width = 87
        UltraGridColumn60.Header.VisiblePosition = 15
        UltraGridColumn60.Hidden = True
        UltraGridColumn61.Header.VisiblePosition = 16
        UltraGridColumn61.Hidden = True
        UltraGridColumn62.Header.VisiblePosition = 17
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62})
        UltraGridColumn63.Header.VisiblePosition = 0
        UltraGridColumn63.Hidden = True
        UltraGridColumn64.Header.VisiblePosition = 1
        UltraGridColumn64.Hidden = True
        UltraGridColumn64.Width = 143
        UltraGridColumn65.Header.VisiblePosition = 2
        UltraGridColumn65.Width = 55
        UltraGridColumn66.Header.VisiblePosition = 3
        UltraGridColumn66.Width = 307
        UltraGridColumn67.Format = "dd/MM/yyyy HH:mm"
        UltraGridColumn67.Header.VisiblePosition = 4
        UltraGridColumn67.Width = 124
        UltraGridColumn68.Format = "dd/MM/yyyy HH:mm"
        UltraGridColumn68.Header.VisiblePosition = 5
        UltraGridColumn68.MaskInput = "{date} {time}"
        UltraGridColumn68.Width = 101
        UltraGridColumn69.Header.VisiblePosition = 6
        UltraGridColumn69.Hidden = True
        UltraGridColumn70.Header.VisiblePosition = 7
        UltraGridColumn70.Hidden = True
        UltraGridColumn71.Header.VisiblePosition = 8
        UltraGridColumn71.Hidden = True
        UltraGridColumn72.Header.VisiblePosition = 9
        UltraGridColumn72.Hidden = True
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72})
        Me.ugViagem.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.ugViagem.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.ugViagem.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugViagem.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ugViagem.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance50.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance50.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance50.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance50.BorderColor = System.Drawing.SystemColors.Window
        Me.ugViagem.DisplayLayout.GroupByBox.Appearance = Appearance50
        Appearance51.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugViagem.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance51
        Me.ugViagem.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance52.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance52.BackColor2 = System.Drawing.SystemColors.Control
        Appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance52.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugViagem.DisplayLayout.GroupByBox.PromptAppearance = Appearance52
        Me.ugViagem.DisplayLayout.MaxColScrollRegions = 1
        Me.ugViagem.DisplayLayout.MaxRowScrollRegions = 1
        Appearance53.BackColor = System.Drawing.SystemColors.Window
        Appearance53.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugViagem.DisplayLayout.Override.ActiveCellAppearance = Appearance53
        Appearance54.BackColor = System.Drawing.SystemColors.Highlight
        Appearance54.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugViagem.DisplayLayout.Override.ActiveRowAppearance = Appearance54
        Me.ugViagem.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugViagem.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance55.BackColor = System.Drawing.SystemColors.Window
        Me.ugViagem.DisplayLayout.Override.CardAreaAppearance = Appearance55
        Appearance56.BorderColor = System.Drawing.Color.Silver
        Appearance56.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugViagem.DisplayLayout.Override.CellAppearance = Appearance56
        Me.ugViagem.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugViagem.DisplayLayout.Override.CellPadding = 0
        Appearance57.BackColor = System.Drawing.SystemColors.Control
        Appearance57.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance57.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance57.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance57.BorderColor = System.Drawing.SystemColors.Window
        Me.ugViagem.DisplayLayout.Override.GroupByRowAppearance = Appearance57
        Appearance58.TextHAlignAsString = "Left"
        Me.ugViagem.DisplayLayout.Override.HeaderAppearance = Appearance58
        Me.ugViagem.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugViagem.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance59.BackColor = System.Drawing.SystemColors.Window
        Appearance59.BorderColor = System.Drawing.Color.Silver
        Me.ugViagem.DisplayLayout.Override.RowAppearance = Appearance59
        Me.ugViagem.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance60.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugViagem.DisplayLayout.Override.TemplateAddRowAppearance = Appearance60
        Me.ugViagem.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugViagem.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugViagem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugViagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugViagem.Location = New System.Drawing.Point(0, 0)
        Me.ugViagem.Name = "ugViagem"
        Me.ugViagem.Size = New System.Drawing.Size(1133, 532)
        Me.ugViagem.TabIndex = 0
        Me.ugViagem.Text = "UltraGrid1"
        '
        'frmNovaViagem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 675)
        Me.Controls.Add(Me.WizardControl1)
        Me.Name = "frmNovaViagem"
        Me.Text = "frmNovaViagem"
        CType(Me.WizardControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WizardControl1.ResumeLayout(False)
        Me.WizardPage1.ResumeLayout(False)
        Me.WizardPage1.PerformLayout()
        CType(Me.ucViaturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_ViaturaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucMotoristas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucRotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucTipos_Viagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_MotoristaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tipo_ViagemTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_RotaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_ViagemDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_ViagemDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WizardPage2.ResumeLayout(False)
        CType(Me.ugViagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WizardControl1 As DevExpress.XtraWizard.WizardControl
    Friend WithEvents WelcomeWizardPage1 As DevExpress.XtraWizard.WelcomeWizardPage
    Friend WithEvents WizardPage1 As DevExpress.XtraWizard.WizardPage
    Friend WithEvents CompletionWizardPage1 As DevExpress.XtraWizard.CompletionWizardPage
    Friend WithEvents Cod_RotaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ucTipos_Viagem As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Cod_MotoristaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Tipo_ViagemTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ucMotoristas As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ucRotas As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ucViaturas As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Cod_ViaturaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WizardPage2 As DevExpress.XtraWizard.WizardPage
    Friend WithEvents ugViagem As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Data_ViagemDateEdit As DevExpress.XtraEditors.DateEdit
End Class
