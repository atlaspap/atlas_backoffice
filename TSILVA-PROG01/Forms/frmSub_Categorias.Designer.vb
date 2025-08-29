<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSub_Categorias
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
        Dim Cod_Sub_CategoriaLabel As System.Windows.Forms.Label
        Dim DesignacaoLabel As System.Windows.Forms.Label
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Cod_CategoriaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ucCategorias = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cmdCarrega = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Cod_ImagemTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DesignacaoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_Sub_CategoriaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.UC_NAV11 = New DEMO_BACKOFFICE.UC_NAV1()
        Cod_Sub_CategoriaLabel = New System.Windows.Forms.Label()
        DesignacaoLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Cod_CategoriaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_ImagemTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DesignacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_Sub_CategoriaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cod_Sub_CategoriaLabel
        '
        Cod_Sub_CategoriaLabel.AutoSize = True
        Cod_Sub_CategoriaLabel.Location = New System.Drawing.Point(281, 85)
        Cod_Sub_CategoriaLabel.Name = "Cod_Sub_CategoriaLabel"
        Cod_Sub_CategoriaLabel.Size = New System.Drawing.Size(99, 13)
        Cod_Sub_CategoriaLabel.TabIndex = 2
        Cod_Sub_CategoriaLabel.Text = "Cod Sub Categoria:"
        '
        'DesignacaoLabel
        '
        DesignacaoLabel.AutoSize = True
        DesignacaoLabel.Location = New System.Drawing.Point(313, 111)
        DesignacaoLabel.Name = "DesignacaoLabel"
        DesignacaoLabel.Size = New System.Drawing.Size(67, 13)
        DesignacaoLabel.TabIndex = 4
        DesignacaoLabel.Text = "Designacao:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.ListView1)
        Me.Panel1.Controls.Add(Me.Cod_CategoriaTextEdit)
        Me.Panel1.Controls.Add(Me.ucCategorias)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.cmdCarrega)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Cod_ImagemTextEdit)
        Me.Panel1.Controls.Add(DesignacaoLabel)
        Me.Panel1.Controls.Add(Me.DesignacaoTextEdit)
        Me.Panel1.Controls.Add(Cod_Sub_CategoriaLabel)
        Me.Panel1.Controls.Add(Me.Cod_Sub_CategoriaTextEdit)
        Me.Panel1.Location = New System.Drawing.Point(13, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(920, 443)
        Me.Panel1.TabIndex = 1
        '
        'Cod_CategoriaTextEdit
        '
        Me.Cod_CategoriaTextEdit.Location = New System.Drawing.Point(430, 379)
        Me.Cod_CategoriaTextEdit.Name = "Cod_CategoriaTextEdit"
        Me.Cod_CategoriaTextEdit.Size = New System.Drawing.Size(160, 20)
        Me.Cod_CategoriaTextEdit.TabIndex = 12
        '
        'ucCategorias
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucCategorias.DisplayLayout.Appearance = Appearance1
        Me.ucCategorias.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucCategorias.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.ucCategorias.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucCategorias.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.ucCategorias.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucCategorias.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.ucCategorias.DisplayLayout.MaxColScrollRegions = 1
        Me.ucCategorias.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucCategorias.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucCategorias.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.ucCategorias.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucCategorias.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.ucCategorias.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucCategorias.DisplayLayout.Override.CellAppearance = Appearance8
        Me.ucCategorias.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucCategorias.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.ucCategorias.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.ucCategorias.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.ucCategorias.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucCategorias.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.ucCategorias.DisplayLayout.Override.RowAppearance = Appearance11
        Me.ucCategorias.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucCategorias.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.ucCategorias.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucCategorias.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucCategorias.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucCategorias.Location = New System.Drawing.Point(430, 404)
        Me.ucCategorias.Name = "ucCategorias"
        Me.ucCategorias.Size = New System.Drawing.Size(111, 22)
        Me.ucCategorias.TabIndex = 11
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(430, 195)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(135, 164)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'cmdCarrega
        '
        Me.cmdCarrega.Location = New System.Drawing.Point(639, 290)
        Me.cmdCarrega.Name = "cmdCarrega"
        Me.cmdCarrega.Size = New System.Drawing.Size(204, 23)
        Me.cmdCarrega.TabIndex = 9
        Me.cmdCarrega.Text = "Carregar Imagem"
        Me.cmdCarrega.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(639, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 237)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Cod_ImagemTextEdit
        '
        Me.Cod_ImagemTextEdit.Location = New System.Drawing.Point(639, 25)
        Me.Cod_ImagemTextEdit.Name = "Cod_ImagemTextEdit"
        Me.Cod_ImagemTextEdit.Size = New System.Drawing.Size(204, 20)
        Me.Cod_ImagemTextEdit.TabIndex = 7
        '
        'DesignacaoTextEdit
        '
        Me.DesignacaoTextEdit.Location = New System.Drawing.Point(386, 108)
        Me.DesignacaoTextEdit.Name = "DesignacaoTextEdit"
        Me.DesignacaoTextEdit.Size = New System.Drawing.Size(236, 20)
        Me.DesignacaoTextEdit.TabIndex = 5
        '
        'Cod_Sub_CategoriaTextEdit
        '
        Me.Cod_Sub_CategoriaTextEdit.Location = New System.Drawing.Point(386, 82)
        Me.Cod_Sub_CategoriaTextEdit.Name = "Cod_Sub_CategoriaTextEdit"
        Me.Cod_Sub_CategoriaTextEdit.Size = New System.Drawing.Size(111, 20)
        Me.Cod_Sub_CategoriaTextEdit.TabIndex = 3
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(15, 14)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(190, 412)
        Me.ListView1.TabIndex = 13
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'UC_NAV11
        '
        Me.UC_NAV11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_NAV11.Location = New System.Drawing.Point(0, 0)
        Me.UC_NAV11.mFRM = Nothing
        Me.UC_NAV11.Name = "UC_NAV11"
        Me.UC_NAV11.Size = New System.Drawing.Size(945, 514)
        Me.UC_NAV11.TabIndex = 0
        '
        'frmSub_Categorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 514)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UC_NAV11)
        Me.Name = "frmSub_Categorias"
        Me.Text = "frmSub_Categorias"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Cod_CategoriaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_ImagemTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DesignacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_Sub_CategoriaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UC_NAV11 As UC_NAV1
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Cod_Sub_CategoriaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cmdCarrega As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Cod_ImagemTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DesignacaoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ucCategorias As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Cod_CategoriaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ListView1 As ListView
End Class
