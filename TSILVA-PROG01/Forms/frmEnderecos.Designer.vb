<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEnderecos
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
        Me.components = New System.ComponentModel.Container()
        Dim Cod_EntidadeLabel As System.Windows.Forms.Label
        Dim Cod_EnderecoLabel As System.Windows.Forms.Label
        Dim DescritivoLabel As System.Windows.Forms.Label
        Dim Cod_PostalLabel As System.Windows.Forms.Label
        Dim EnderecoLabel As System.Windows.Forms.Label
        Dim LocalidadeLabel As System.Windows.Forms.Label
        Dim Data_RegistoLabel As System.Windows.Forms.Label
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsPT_Enderecos", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Distrito")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Concelho")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Postal")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Endereco")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Localidade")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnderecos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ucEnderecos = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.ucCod_Postal = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Data_RegistoDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LocalidadeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EnderecoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_PostalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DescritivoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_EnderecoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_EntidadeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BarNAV = New DevExpress.XtraBars.Bar()
        Me.Bar4 = New DevExpress.XtraBars.Bar()
        Me.Bar5 = New DevExpress.XtraBars.Bar()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.bbStatus = New DevExpress.XtraBars.BarStaticItem()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.bbNovo = New DevExpress.XtraBars.BarButtonItem()
        Me.bbApaga = New DevExpress.XtraBars.BarButtonItem()
        Me.bbModifica = New DevExpress.XtraBars.BarButtonItem()
        Me.bbSair = New DevExpress.XtraBars.BarButtonItem()
        Me.bbGrava = New DevExpress.XtraBars.BarButtonItem()
        Me.bbCancela = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.bbPrimeiro = New DevExpress.XtraBars.BarButtonItem()
        Me.bbAnterior = New DevExpress.XtraBars.BarButtonItem()
        Me.bbSeguinte = New DevExpress.XtraBars.BarButtonItem()
        Me.bbUltimo = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.ClsPTEnderecosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Cod_EntidadeLabel = New System.Windows.Forms.Label()
        Cod_EnderecoLabel = New System.Windows.Forms.Label()
        DescritivoLabel = New System.Windows.Forms.Label()
        Cod_PostalLabel = New System.Windows.Forms.Label()
        EnderecoLabel = New System.Windows.Forms.Label()
        LocalidadeLabel = New System.Windows.Forms.Label()
        Data_RegistoLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.ucEnderecos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucCod_Postal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_RegistoDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_RegistoDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnderecoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_PostalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescritivoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_EnderecoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_EntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClsPTEnderecosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cod_EntidadeLabel
        '
        Cod_EntidadeLabel.AutoSize = True
        Cod_EntidadeLabel.Location = New System.Drawing.Point(90, 21)
        Cod_EntidadeLabel.Name = "Cod_EntidadeLabel"
        Cod_EntidadeLabel.Size = New System.Drawing.Size(74, 13)
        Cod_EntidadeLabel.TabIndex = 0
        Cod_EntidadeLabel.Text = "Cod Entidade:"
        '
        'Cod_EnderecoLabel
        '
        Cod_EnderecoLabel.AutoSize = True
        Cod_EnderecoLabel.Location = New System.Drawing.Point(90, 45)
        Cod_EnderecoLabel.Name = "Cod_EnderecoLabel"
        Cod_EnderecoLabel.Size = New System.Drawing.Size(78, 13)
        Cod_EnderecoLabel.TabIndex = 2
        Cod_EnderecoLabel.Text = "Cod Endereco:"
        '
        'DescritivoLabel
        '
        DescritivoLabel.AutoSize = True
        DescritivoLabel.Location = New System.Drawing.Point(108, 69)
        DescritivoLabel.Name = "DescritivoLabel"
        DescritivoLabel.Size = New System.Drawing.Size(57, 13)
        DescritivoLabel.TabIndex = 4
        DescritivoLabel.Text = "Descritivo:"
        '
        'Cod_PostalLabel
        '
        Cod_PostalLabel.AutoSize = True
        Cod_PostalLabel.Location = New System.Drawing.Point(102, 125)
        Cod_PostalLabel.Name = "Cod_PostalLabel"
        Cod_PostalLabel.Size = New System.Drawing.Size(61, 13)
        Cod_PostalLabel.TabIndex = 6
        Cod_PostalLabel.Text = "Cod Postal:"
        '
        'EnderecoLabel
        '
        EnderecoLabel.AutoSize = True
        EnderecoLabel.Location = New System.Drawing.Point(108, 152)
        EnderecoLabel.Name = "EnderecoLabel"
        EnderecoLabel.Size = New System.Drawing.Size(56, 13)
        EnderecoLabel.TabIndex = 8
        EnderecoLabel.Text = "Endereco:"
        '
        'LocalidadeLabel
        '
        LocalidadeLabel.AutoSize = True
        LocalidadeLabel.Location = New System.Drawing.Point(246, 125)
        LocalidadeLabel.Name = "LocalidadeLabel"
        LocalidadeLabel.Size = New System.Drawing.Size(62, 13)
        LocalidadeLabel.TabIndex = 10
        LocalidadeLabel.Text = "Localidade:"
        '
        'Data_RegistoLabel
        '
        Data_RegistoLabel.AutoSize = True
        Data_RegistoLabel.Location = New System.Drawing.Point(96, 173)
        Data_RegistoLabel.Name = "Data_RegistoLabel"
        Data_RegistoLabel.Size = New System.Drawing.Size(72, 13)
        Data_RegistoLabel.TabIndex = 12
        Data_RegistoLabel.Text = "Data Registo:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.ucEnderecos)
        Me.Panel1.Controls.Add(Me.ucCod_Postal)
        Me.Panel1.Controls.Add(Data_RegistoLabel)
        Me.Panel1.Controls.Add(Me.Data_RegistoDateEdit)
        Me.Panel1.Controls.Add(LocalidadeLabel)
        Me.Panel1.Controls.Add(Me.LocalidadeTextEdit)
        Me.Panel1.Controls.Add(EnderecoLabel)
        Me.Panel1.Controls.Add(Me.EnderecoTextEdit)
        Me.Panel1.Controls.Add(Cod_PostalLabel)
        Me.Panel1.Controls.Add(Me.Cod_PostalTextEdit)
        Me.Panel1.Controls.Add(DescritivoLabel)
        Me.Panel1.Controls.Add(Me.DescritivoTextEdit)
        Me.Panel1.Controls.Add(Cod_EnderecoLabel)
        Me.Panel1.Controls.Add(Me.Cod_EnderecoTextEdit)
        Me.Panel1.Controls.Add(Cod_EntidadeLabel)
        Me.Panel1.Controls.Add(Me.Cod_EntidadeTextEdit)
        Me.Panel1.Location = New System.Drawing.Point(12, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(648, 276)
        Me.Panel1.TabIndex = 0
        '
        'ucEnderecos
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucEnderecos.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 351
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        Me.ucEnderecos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ucEnderecos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucEnderecos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.ucEnderecos.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucEnderecos.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.ucEnderecos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucEnderecos.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.ucEnderecos.DisplayLayout.MaxColScrollRegions = 1
        Me.ucEnderecos.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucEnderecos.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucEnderecos.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.ucEnderecos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucEnderecos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.ucEnderecos.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucEnderecos.DisplayLayout.Override.CellAppearance = Appearance8
        Me.ucEnderecos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucEnderecos.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.ucEnderecos.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.ucEnderecos.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.ucEnderecos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucEnderecos.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.ucEnderecos.DisplayLayout.Override.RowAppearance = Appearance11
        Me.ucEnderecos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucEnderecos.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.ucEnderecos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucEnderecos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucEnderecos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucEnderecos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucEnderecos.Location = New System.Drawing.Point(174, 92)
        Me.ucEnderecos.Name = "ucEnderecos"
        Me.ucEnderecos.Size = New System.Drawing.Size(390, 22)
        Me.ucEnderecos.TabIndex = 15
        '
        'ucCod_Postal
        '
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucCod_Postal.DisplayLayout.Appearance = Appearance13
        Me.ucCod_Postal.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucCod_Postal.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.ucCod_Postal.DisplayLayout.GroupByBox.Appearance = Appearance14
        Appearance15.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucCod_Postal.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance15
        Me.ucCod_Postal.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance16.BackColor2 = System.Drawing.SystemColors.Control
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucCod_Postal.DisplayLayout.GroupByBox.PromptAppearance = Appearance16
        Me.ucCod_Postal.DisplayLayout.MaxColScrollRegions = 1
        Me.ucCod_Postal.DisplayLayout.MaxRowScrollRegions = 1
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucCod_Postal.DisplayLayout.Override.ActiveCellAppearance = Appearance17
        Appearance18.BackColor = System.Drawing.SystemColors.Highlight
        Appearance18.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucCod_Postal.DisplayLayout.Override.ActiveRowAppearance = Appearance18
        Me.ucCod_Postal.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucCod_Postal.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Me.ucCod_Postal.DisplayLayout.Override.CardAreaAppearance = Appearance19
        Appearance20.BorderColor = System.Drawing.Color.Silver
        Appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucCod_Postal.DisplayLayout.Override.CellAppearance = Appearance20
        Me.ucCod_Postal.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucCod_Postal.DisplayLayout.Override.CellPadding = 0
        Appearance21.BackColor = System.Drawing.SystemColors.Control
        Appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance21.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance21.BorderColor = System.Drawing.SystemColors.Window
        Me.ucCod_Postal.DisplayLayout.Override.GroupByRowAppearance = Appearance21
        Appearance22.TextHAlignAsString = "Left"
        Me.ucCod_Postal.DisplayLayout.Override.HeaderAppearance = Appearance22
        Me.ucCod_Postal.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucCod_Postal.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.BorderColor = System.Drawing.Color.Silver
        Me.ucCod_Postal.DisplayLayout.Override.RowAppearance = Appearance23
        Me.ucCod_Postal.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance24.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucCod_Postal.DisplayLayout.Override.TemplateAddRowAppearance = Appearance24
        Me.ucCod_Postal.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucCod_Postal.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucCod_Postal.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucCod_Postal.Location = New System.Drawing.Point(352, 21)
        Me.ucCod_Postal.Name = "ucCod_Postal"
        Me.ucCod_Postal.Size = New System.Drawing.Size(100, 22)
        Me.ucCod_Postal.TabIndex = 14
        '
        'Data_RegistoDateEdit
        '
        Me.Data_RegistoDateEdit.EditValue = Nothing
        Me.Data_RegistoDateEdit.Location = New System.Drawing.Point(174, 170)
        Me.Data_RegistoDateEdit.Name = "Data_RegistoDateEdit"
        Me.Data_RegistoDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Data_RegistoDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Data_RegistoDateEdit.Size = New System.Drawing.Size(150, 20)
        Me.Data_RegistoDateEdit.TabIndex = 13
        '
        'LocalidadeTextEdit
        '
        Me.LocalidadeTextEdit.Location = New System.Drawing.Point(318, 122)
        Me.LocalidadeTextEdit.Name = "LocalidadeTextEdit"
        Me.LocalidadeTextEdit.Size = New System.Drawing.Size(246, 20)
        Me.LocalidadeTextEdit.TabIndex = 11
        '
        'EnderecoTextEdit
        '
        Me.EnderecoTextEdit.Location = New System.Drawing.Point(174, 146)
        Me.EnderecoTextEdit.Name = "EnderecoTextEdit"
        Me.EnderecoTextEdit.Size = New System.Drawing.Size(390, 20)
        Me.EnderecoTextEdit.TabIndex = 9
        '
        'Cod_PostalTextEdit
        '
        Me.Cod_PostalTextEdit.Location = New System.Drawing.Point(174, 122)
        Me.Cod_PostalTextEdit.Name = "Cod_PostalTextEdit"
        Me.Cod_PostalTextEdit.Size = New System.Drawing.Size(66, 20)
        Me.Cod_PostalTextEdit.TabIndex = 7
        '
        'DescritivoTextEdit
        '
        Me.DescritivoTextEdit.Location = New System.Drawing.Point(174, 66)
        Me.DescritivoTextEdit.Name = "DescritivoTextEdit"
        Me.DescritivoTextEdit.Size = New System.Drawing.Size(390, 20)
        Me.DescritivoTextEdit.TabIndex = 5
        '
        'Cod_EnderecoTextEdit
        '
        Me.Cod_EnderecoTextEdit.Location = New System.Drawing.Point(174, 42)
        Me.Cod_EnderecoTextEdit.Name = "Cod_EnderecoTextEdit"
        Me.Cod_EnderecoTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Cod_EnderecoTextEdit.TabIndex = 3
        '
        'Cod_EntidadeTextEdit
        '
        Me.Cod_EntidadeTextEdit.Location = New System.Drawing.Point(174, 18)
        Me.Cod_EntidadeTextEdit.Name = "Cod_EntidadeTextEdit"
        Me.Cod_EntidadeTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Cod_EntidadeTextEdit.TabIndex = 1
        '
        'BarNAV
        '
        Me.BarNAV.BarName = "Tools"
        Me.BarNAV.DockCol = 0
        Me.BarNAV.DockRow = 0
        Me.BarNAV.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.BarNAV.Text = "Tools"
        '
        'Bar4
        '
        Me.Bar4.BarName = "Custom 5"
        Me.Bar4.DockCol = 1
        Me.Bar4.DockRow = 0
        Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar4.Offset = 227
        Me.Bar4.Text = "Custom 5"
        '
        'Bar5
        '
        Me.Bar5.BarAppearance.Normal.BackColor = System.Drawing.Color.White
        Me.Bar5.BarName = "Custom 5"
        Me.Bar5.DockCol = 1
        Me.Bar5.DockRow = 0
        Me.Bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar5.Offset = 227
        Me.Bar5.Text = "Custom 5"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3, Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbPrimeiro, Me.bbAnterior, Me.bbSeguinte, Me.bbUltimo, Me.bbNovo, Me.bbModifica, Me.bbApaga, Me.bbSair, Me.bbGrava, Me.bbCancela, Me.bbStatus, Me.BarStaticItem1})
        Me.BarManager1.MaxItemId = 15
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarAppearance.Normal.BackColor = System.Drawing.Color.White
        Me.Bar3.BarAppearance.Normal.Options.UseBackColor = True
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbStatus)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'bbStatus
        '
        Me.bbStatus.Caption = "bsStatus"
        Me.bbStatus.Id = 13
        Me.bbStatus.Name = "bbStatus"
        '
        'Bar2
        '
        Me.Bar2.BarAppearance.Normal.BackColor = System.Drawing.Color.White
        Me.Bar2.BarAppearance.Normal.Options.UseBackColor = True
        Me.Bar2.BarName = "Custom 5"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbNovo), New DevExpress.XtraBars.LinkPersistInfo(Me.bbApaga), New DevExpress.XtraBars.LinkPersistInfo(Me.bbModifica), New DevExpress.XtraBars.LinkPersistInfo(Me.bbSair), New DevExpress.XtraBars.LinkPersistInfo(Me.bbGrava), New DevExpress.XtraBars.LinkPersistInfo(Me.bbCancela)})
        Me.Bar2.Offset = 4
        Me.Bar2.Text = "Custom 5"
        '
        'bbNovo
        '
        Me.bbNovo.Caption = "Novo"
        Me.bbNovo.Id = 4
        Me.bbNovo.ImageOptions.Image = Global.DEMO_BACKOFFICE.My.Resources.Resources.CRIAR
        Me.bbNovo.Name = "bbNovo"
        '
        'bbApaga
        '
        Me.bbApaga.Caption = "Apaga"
        Me.bbApaga.Id = 8
        Me.bbApaga.ImageOptions.Image = Global.DEMO_BACKOFFICE.My.Resources.Resources.DELETE1
        Me.bbApaga.Name = "bbApaga"
        '
        'bbModifica
        '
        Me.bbModifica.Caption = "Modifica"
        Me.bbModifica.Id = 5
        Me.bbModifica.ImageOptions.Image = Global.DEMO_BACKOFFICE.My.Resources.Resources.EDIT
        Me.bbModifica.Name = "bbModifica"
        '
        'bbSair
        '
        Me.bbSair.Caption = "Sair"
        Me.bbSair.Id = 9
        Me.bbSair.ImageOptions.Image = Global.DEMO_BACKOFFICE.My.Resources.Resources.HOME
        Me.bbSair.Name = "bbSair"
        '
        'bbGrava
        '
        Me.bbGrava.Caption = "Grava"
        Me.bbGrava.Id = 11
        Me.bbGrava.ImageOptions.Image = Global.DEMO_BACKOFFICE.My.Resources.Resources.save1
        Me.bbGrava.Name = "bbGrava"
        '
        'bbCancela
        '
        Me.bbCancela.Caption = "Cancela"
        Me.bbCancela.Id = 12
        Me.bbCancela.ImageOptions.Image = Global.DEMO_BACKOFFICE.My.Resources.Resources.back1
        Me.bbCancela.Name = "bbCancela"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.Appearance.BackColor = System.Drawing.Color.White
        Me.barDockControlTop.Appearance.Options.UseBackColor = True
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(674, 40)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.Appearance.BackColor = System.Drawing.Color.White
        Me.barDockControlBottom.Appearance.Options.UseBackColor = True
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 316)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(674, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 40)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 276)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(674, 40)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 276)
        '
        'bbPrimeiro
        '
        Me.bbPrimeiro.Caption = "Primeiro"
        Me.bbPrimeiro.Id = 0
        Me.bbPrimeiro.ImageOptions.Image = CType(resources.GetObject("bbPrimeiro.ImageOptions.Image"), System.Drawing.Image)
        Me.bbPrimeiro.Name = "bbPrimeiro"
        '
        'bbAnterior
        '
        Me.bbAnterior.Caption = "Anterior"
        Me.bbAnterior.Id = 1
        Me.bbAnterior.ImageOptions.Image = CType(resources.GetObject("bbAnterior.ImageOptions.Image"), System.Drawing.Image)
        Me.bbAnterior.Name = "bbAnterior"
        '
        'bbSeguinte
        '
        Me.bbSeguinte.Caption = "Seguinte"
        Me.bbSeguinte.Id = 2
        Me.bbSeguinte.ImageOptions.Image = CType(resources.GetObject("bbSeguinte.ImageOptions.Image"), System.Drawing.Image)
        Me.bbSeguinte.Name = "bbSeguinte"
        '
        'bbUltimo
        '
        Me.bbUltimo.Caption = "Ultimo"
        Me.bbUltimo.Id = 3
        Me.bbUltimo.ImageOptions.Image = CType(resources.GetObject("bbUltimo.ImageOptions.Image"), System.Drawing.Image)
        Me.bbUltimo.Name = "bbUltimo"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "BarStaticItem1"
        Me.BarStaticItem1.Id = 14
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.FloatLocation = New System.Drawing.Point(2255, 388)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbPrimeiro), New DevExpress.XtraBars.LinkPersistInfo(Me.bbAnterior), New DevExpress.XtraBars.LinkPersistInfo(Me.bbSeguinte), New DevExpress.XtraBars.LinkPersistInfo(Me.bbUltimo)})
        Me.Bar1.Text = "Tools"
        '
        'ClsPTEnderecosBindingSource
        '
        Me.ClsPTEnderecosBindingSource.DataSource = GetType(DEMO_BACKOFFICE.ClsPT_Enderecos)
        '
        'frmEnderecos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DEMO_BACKOFFICE.My.Resources.Resources.BACKGROUND
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(674, 338)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmEnderecos"
        Me.Text = "frmEnderecos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ucEnderecos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucCod_Postal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_RegistoDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_RegistoDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnderecoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_PostalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescritivoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_EnderecoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_EntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClsPTEnderecosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Data_RegistoDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LocalidadeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EnderecoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_PostalTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescritivoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_EnderecoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_EntidadeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarNAV As DevExpress.XtraBars.Bar
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar5 As DevExpress.XtraBars.Bar
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents bbStatus As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents bbNovo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbModifica As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbApaga As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbSair As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbGrava As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbCancela As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents bbPrimeiro As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbAnterior As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbSeguinte As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbUltimo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents ucCod_Postal As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ucEnderecos As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ClsPTEnderecosBindingSource As BindingSource
End Class
