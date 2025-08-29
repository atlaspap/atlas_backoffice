<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRotas
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsRota_Paragens", -1)
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Rota", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Paragem")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ordem")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dist_Km")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tempo_Min")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Paragem_Descritivo")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Paragem_Localidade")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Paragem_Endereco")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
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
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsParagens", -1)
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Paragem")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descritivo")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Distrito")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Concelho")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Postal")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Endereco")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Localidade")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loc01", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Loc02")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextEditParagens = New DevExpress.XtraEditors.TextEdit()
        Me.pbLoading = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ugRotas = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Tempo_TotalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Distancia_TotalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ugParagens = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.Num_ParagensTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DescritivoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_RotaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.cms01 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsUp = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsDown = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.UC_NAV11 = New DEMO_BACKOFFICE.UC_NAV1()
        Me.ClsRotaParagensBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.TextEditParagens.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ugRotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tempo_TotalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Distancia_TotalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.ugParagens, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num_ParagensTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescritivoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_RotaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms01.SuspendLayout()
        CType(Me.ClsRotaParagensBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.TextEditParagens)
        Me.Panel1.Controls.Add(Me.pbLoading)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Tempo_TotalTextEdit)
        Me.Panel1.Controls.Add(Me.Distancia_TotalTextEdit)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.WebView21)
        Me.Panel1.Controls.Add(Me.Num_ParagensTextEdit)
        Me.Panel1.Controls.Add(Me.DescritivoTextEdit)
        Me.Panel1.Controls.Add(Me.Cod_RotaTextEdit)
        Me.Panel1.Location = New System.Drawing.Point(13, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1760, 791)
        Me.Panel1.TabIndex = 1
        '
        'TextEditParagens
        '
        Me.TextEditParagens.Location = New System.Drawing.Point(31, 193)
        Me.TextEditParagens.Name = "TextEditParagens"
        Me.TextEditParagens.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextEditParagens.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.TextEditParagens.Properties.Appearance.Options.UseBackColor = True
        Me.TextEditParagens.Properties.Appearance.Options.UseFont = True
        Me.TextEditParagens.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEditParagens.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEditParagens.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEditParagens.Size = New System.Drawing.Size(504, 24)
        Me.TextEditParagens.TabIndex = 15
        '
        'pbLoading
        '
        Me.pbLoading.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbLoading.Image = Global.DEMO_BACKOFFICE.My.Resources.Resources.loading
        Me.pbLoading.Location = New System.Drawing.Point(0, 0)
        Me.pbLoading.Name = "pbLoading"
        Me.pbLoading.Size = New System.Drawing.Size(1760, 791)
        Me.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbLoading.TabIndex = 14
        Me.pbLoading.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.ugRotas)
        Me.Panel2.Location = New System.Drawing.Point(12, 287)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(798, 331)
        Me.Panel2.TabIndex = 6
        '
        'ugRotas
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugRotas.DisplayLayout.Appearance = Appearance1
        UltraGridColumn39.Header.VisiblePosition = 0
        UltraGridColumn40.Header.VisiblePosition = 1
        UltraGridColumn41.Header.VisiblePosition = 2
        UltraGridColumn42.Header.VisiblePosition = 7
        UltraGridColumn43.Header.VisiblePosition = 8
        UltraGridColumn44.Header.VisiblePosition = 3
        UltraGridColumn45.Header.VisiblePosition = 5
        UltraGridColumn46.Header.VisiblePosition = 6
        UltraGridColumn47.Header.VisiblePosition = 4
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47})
        Me.ugRotas.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ugRotas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugRotas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ugRotas.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.ugRotas.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugRotas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.ugRotas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugRotas.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.ugRotas.DisplayLayout.MaxColScrollRegions = 1
        Me.ugRotas.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugRotas.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugRotas.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.ugRotas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugRotas.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.ugRotas.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugRotas.DisplayLayout.Override.CellAppearance = Appearance8
        Me.ugRotas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugRotas.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.ugRotas.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.ugRotas.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.ugRotas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugRotas.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.ugRotas.DisplayLayout.Override.RowAppearance = Appearance11
        Me.ugRotas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugRotas.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.ugRotas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugRotas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugRotas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugRotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugRotas.Location = New System.Drawing.Point(0, 0)
        Me.ugRotas.Name = "ugRotas"
        Me.ugRotas.Size = New System.Drawing.Size(798, 331)
        Me.ugRotas.TabIndex = 0
        Me.ugRotas.Text = "UltraGrid1"
        '
        'Tempo_TotalTextEdit
        '
        Me.Tempo_TotalTextEdit.EditValue = ""
        Me.Tempo_TotalTextEdit.Location = New System.Drawing.Point(397, 124)
        Me.Tempo_TotalTextEdit.Name = "Tempo_TotalTextEdit"
        Me.Tempo_TotalTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Tempo_TotalTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.Tempo_TotalTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Tempo_TotalTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Tempo_TotalTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Tempo_TotalTextEdit.Size = New System.Drawing.Size(138, 24)
        Me.Tempo_TotalTextEdit.TabIndex = 13
        '
        'Distancia_TotalTextEdit
        '
        Me.Distancia_TotalTextEdit.EditValue = ""
        Me.Distancia_TotalTextEdit.Location = New System.Drawing.Point(214, 123)
        Me.Distancia_TotalTextEdit.Name = "Distancia_TotalTextEdit"
        Me.Distancia_TotalTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Distancia_TotalTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.Distancia_TotalTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Distancia_TotalTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Distancia_TotalTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Distancia_TotalTextEdit.Size = New System.Drawing.Size(144, 24)
        Me.Distancia_TotalTextEdit.TabIndex = 11
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ugParagens)
        Me.Panel3.Location = New System.Drawing.Point(816, 174)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(797, 550)
        Me.Panel3.TabIndex = 9
        '
        'ugParagens
        '
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugParagens.DisplayLayout.Appearance = Appearance13
        UltraGridColumn48.Header.VisiblePosition = 0
        UltraGridColumn49.Header.VisiblePosition = 1
        UltraGridColumn50.Header.VisiblePosition = 2
        UltraGridColumn51.Header.VisiblePosition = 3
        UltraGridColumn52.Header.VisiblePosition = 4
        UltraGridColumn53.Header.VisiblePosition = 5
        UltraGridColumn54.Header.VisiblePosition = 6
        UltraGridColumn55.Header.VisiblePosition = 7
        UltraGridColumn56.Header.VisiblePosition = 8
        UltraGridColumn57.Header.VisiblePosition = 9
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57})
        Me.ugParagens.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ugParagens.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugParagens.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ugParagens.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.ugParagens.DisplayLayout.GroupByBox.Appearance = Appearance14
        Appearance15.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugParagens.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance15
        Me.ugParagens.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance16.BackColor2 = System.Drawing.SystemColors.Control
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugParagens.DisplayLayout.GroupByBox.PromptAppearance = Appearance16
        Me.ugParagens.DisplayLayout.MaxColScrollRegions = 1
        Me.ugParagens.DisplayLayout.MaxRowScrollRegions = 1
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugParagens.DisplayLayout.Override.ActiveCellAppearance = Appearance17
        Appearance18.BackColor = System.Drawing.SystemColors.Highlight
        Appearance18.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugParagens.DisplayLayout.Override.ActiveRowAppearance = Appearance18
        Me.ugParagens.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugParagens.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Me.ugParagens.DisplayLayout.Override.CardAreaAppearance = Appearance19
        Appearance20.BorderColor = System.Drawing.Color.Silver
        Appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugParagens.DisplayLayout.Override.CellAppearance = Appearance20
        Me.ugParagens.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugParagens.DisplayLayout.Override.CellPadding = 0
        Appearance21.BackColor = System.Drawing.SystemColors.Control
        Appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance21.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance21.BorderColor = System.Drawing.SystemColors.Window
        Me.ugParagens.DisplayLayout.Override.GroupByRowAppearance = Appearance21
        Appearance22.TextHAlignAsString = "Left"
        Me.ugParagens.DisplayLayout.Override.HeaderAppearance = Appearance22
        Me.ugParagens.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugParagens.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.BorderColor = System.Drawing.Color.Silver
        Me.ugParagens.DisplayLayout.Override.RowAppearance = Appearance23
        Me.ugParagens.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance24.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugParagens.DisplayLayout.Override.TemplateAddRowAppearance = Appearance24
        Me.ugParagens.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugParagens.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugParagens.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugParagens.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugParagens.Location = New System.Drawing.Point(0, 0)
        Me.ugParagens.Name = "ugParagens"
        Me.ugParagens.Size = New System.Drawing.Size(797, 550)
        Me.ugParagens.TabIndex = 2
        Me.ugParagens.Text = "UltraGrid1"
        '
        'WebView21
        '
        Me.WebView21.AllowExternalDrop = True
        Me.WebView21.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebView21.CreationProperties = Nothing
        Me.WebView21.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView21.Location = New System.Drawing.Point(847, 21)
        Me.WebView21.Name = "WebView21"
        Me.WebView21.Size = New System.Drawing.Size(899, 770)
        Me.WebView21.TabIndex = 8
        Me.WebView21.ZoomFactor = 1.0R
        '
        'Num_ParagensTextEdit
        '
        Me.Num_ParagensTextEdit.Location = New System.Drawing.Point(31, 123)
        Me.Num_ParagensTextEdit.Name = "Num_ParagensTextEdit"
        Me.Num_ParagensTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Num_ParagensTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.Num_ParagensTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Num_ParagensTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Num_ParagensTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Num_ParagensTextEdit.Size = New System.Drawing.Size(142, 24)
        Me.Num_ParagensTextEdit.TabIndex = 5
        '
        'DescritivoTextEdit
        '
        Me.DescritivoTextEdit.Location = New System.Drawing.Point(218, 45)
        Me.DescritivoTextEdit.Name = "DescritivoTextEdit"
        Me.DescritivoTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DescritivoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.DescritivoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.DescritivoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.DescritivoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.DescritivoTextEdit.Size = New System.Drawing.Size(293, 24)
        Me.DescritivoTextEdit.TabIndex = 3
        '
        'Cod_RotaTextEdit
        '
        Me.Cod_RotaTextEdit.Location = New System.Drawing.Point(31, 47)
        Me.Cod_RotaTextEdit.Name = "Cod_RotaTextEdit"
        Me.Cod_RotaTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cod_RotaTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.Cod_RotaTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Cod_RotaTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Cod_RotaTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Cod_RotaTextEdit.Size = New System.Drawing.Size(142, 24)
        Me.Cod_RotaTextEdit.TabIndex = 1
        '
        'cms01
        '
        Me.cms01.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsUp, Me.cmsDown, Me.cmsRemove})
        Me.cms01.Name = "ContextMenuStrip1"
        Me.cms01.Size = New System.Drawing.Size(160, 70)
        '
        'cmsUp
        '
        Me.cmsUp.Image = Global.DEMO_BACKOFFICE.My.Resources.Resources.up
        Me.cmsUp.Name = "cmsUp"
        Me.cmsUp.Size = New System.Drawing.Size(159, 22)
        Me.cmsUp.Text = "Subir Paragem"
        '
        'cmsDown
        '
        Me.cmsDown.Image = Global.DEMO_BACKOFFICE.My.Resources.Resources.down
        Me.cmsDown.Name = "cmsDown"
        Me.cmsDown.Size = New System.Drawing.Size(159, 22)
        Me.cmsDown.Text = "Descer Paragem"
        '
        'cmsRemove
        '
        Me.cmsRemove.Image = Global.DEMO_BACKOFFICE.My.Resources.Resources.Delete_Ico
        Me.cmsRemove.Name = "cmsRemove"
        Me.cmsRemove.Size = New System.Drawing.Size(159, 22)
        Me.cmsRemove.Text = "Apagar"
        '
        'UC_NAV11
        '
        Me.UC_NAV11.BackColor = System.Drawing.Color.Transparent
        Me.UC_NAV11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_NAV11.Location = New System.Drawing.Point(0, 0)
        Me.UC_NAV11.mFRM = Nothing
        Me.UC_NAV11.Name = "UC_NAV11"
        Me.UC_NAV11.Size = New System.Drawing.Size(1785, 865)
        Me.UC_NAV11.TabIndex = 0
        '
        'ClsRotaParagensBindingSource
        '
        Me.ClsRotaParagensBindingSource.DataSource = GetType(DEMO_BACKOFFICE.ClsRota_Paragens)
        '
        'frmRotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DEMO_BACKOFFICE.My.Resources.Resources.BACKGROUND_ROTAS
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1785, 865)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UC_NAV11)
        Me.DoubleBuffered = True
        Me.Name = "frmRotas"
        Me.Text = "frmRotas"
        Me.Panel1.ResumeLayout(False)
        CType(Me.TextEditParagens.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.ugRotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tempo_TotalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Distancia_TotalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.ugParagens, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WebView21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num_ParagensTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescritivoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_RotaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms01.ResumeLayout(False)
        CType(Me.ClsRotaParagensBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UC_NAV11 As UC_NAV1
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Num_ParagensTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescritivoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_RotaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ugRotas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ugParagens As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cms01 As ContextMenuStrip
    Friend WithEvents cmsRemove As ToolStripMenuItem
    Friend WithEvents cmsUp As ToolStripMenuItem
    Friend WithEvents cmsDown As ToolStripMenuItem
    Friend WithEvents ClsRotaParagensBindingSource As BindingSource
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Distancia_TotalTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Tempo_TotalTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pbLoading As PictureBox
    Friend WithEvents TextEditParagens As DevExpress.XtraEditors.TextEdit
End Class
