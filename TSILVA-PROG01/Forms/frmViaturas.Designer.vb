<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViaturas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViaturas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FLG_WifiCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.FLG_WCCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.FLG_USBCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.FLG_TomadasCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.FLG_ACCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Ano_FabricoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Vel_MediaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_ImagemTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LugaresTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_ViaturaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DescritivoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.UC_NAV11 = New DEMO_BACKOFFICE.UC_NAV1()
        Me.cmdCarrega = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.FLG_WifiCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLG_WCCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLG_USBCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLG_TomadasCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FLG_ACCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ano_FabricoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vel_MediaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_ImagemTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LugaresTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_ViaturaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescritivoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdCarrega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.cmdCarrega)
        Me.Panel1.Controls.Add(Me.FLG_WifiCheckEdit)
        Me.Panel1.Controls.Add(Me.FLG_WCCheckEdit)
        Me.Panel1.Controls.Add(Me.FLG_USBCheckEdit)
        Me.Panel1.Controls.Add(Me.FLG_TomadasCheckEdit)
        Me.Panel1.Controls.Add(Me.FLG_ACCheckEdit)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Ano_FabricoTextEdit)
        Me.Panel1.Controls.Add(Me.Vel_MediaTextEdit)
        Me.Panel1.Controls.Add(Me.Cod_ImagemTextEdit)
        Me.Panel1.Controls.Add(Me.LugaresTextEdit)
        Me.Panel1.Controls.Add(Me.Cod_ViaturaTextEdit)
        Me.Panel1.Controls.Add(Me.DescritivoTextEdit)
        Me.Panel1.Location = New System.Drawing.Point(12, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1158, 664)
        Me.Panel1.TabIndex = 28
        '
        'FLG_WifiCheckEdit
        '
        Me.FLG_WifiCheckEdit.Location = New System.Drawing.Point(390, 211)
        Me.FLG_WifiCheckEdit.Name = "FLG_WifiCheckEdit"
        Me.FLG_WifiCheckEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FLG_WifiCheckEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.FLG_WifiCheckEdit.Properties.Appearance.Options.UseBackColor = True
        Me.FLG_WifiCheckEdit.Properties.Appearance.Options.UseFont = True
        Me.FLG_WifiCheckEdit.Properties.Caption = ""
        Me.FLG_WifiCheckEdit.Size = New System.Drawing.Size(20, 20)
        Me.FLG_WifiCheckEdit.TabIndex = 35
        '
        'FLG_WCCheckEdit
        '
        Me.FLG_WCCheckEdit.Location = New System.Drawing.Point(315, 211)
        Me.FLG_WCCheckEdit.Name = "FLG_WCCheckEdit"
        Me.FLG_WCCheckEdit.Properties.Caption = ""
        Me.FLG_WCCheckEdit.Size = New System.Drawing.Size(20, 20)
        Me.FLG_WCCheckEdit.TabIndex = 34
        '
        'FLG_USBCheckEdit
        '
        Me.FLG_USBCheckEdit.Location = New System.Drawing.Point(245, 211)
        Me.FLG_USBCheckEdit.Name = "FLG_USBCheckEdit"
        Me.FLG_USBCheckEdit.Properties.Caption = ""
        Me.FLG_USBCheckEdit.Size = New System.Drawing.Size(20, 20)
        Me.FLG_USBCheckEdit.TabIndex = 33
        '
        'FLG_TomadasCheckEdit
        '
        Me.FLG_TomadasCheckEdit.Location = New System.Drawing.Point(167, 211)
        Me.FLG_TomadasCheckEdit.Name = "FLG_TomadasCheckEdit"
        Me.FLG_TomadasCheckEdit.Properties.Caption = ""
        Me.FLG_TomadasCheckEdit.Size = New System.Drawing.Size(20, 20)
        Me.FLG_TomadasCheckEdit.TabIndex = 32
        '
        'FLG_ACCheckEdit
        '
        Me.FLG_ACCheckEdit.Location = New System.Drawing.Point(92, 212)
        Me.FLG_ACCheckEdit.Name = "FLG_ACCheckEdit"
        Me.FLG_ACCheckEdit.Properties.Caption = ""
        Me.FLG_ACCheckEdit.Size = New System.Drawing.Size(20, 20)
        Me.FLG_ACCheckEdit.TabIndex = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 299)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(471, 278)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Ano_FabricoTextEdit
        '
        Me.Ano_FabricoTextEdit.Location = New System.Drawing.Point(356, 131)
        Me.Ano_FabricoTextEdit.Name = "Ano_FabricoTextEdit"
        Me.Ano_FabricoTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Ano_FabricoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.Ano_FabricoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Ano_FabricoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Ano_FabricoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Ano_FabricoTextEdit.Size = New System.Drawing.Size(138, 24)
        Me.Ano_FabricoTextEdit.TabIndex = 2
        '
        'Vel_MediaTextEdit
        '
        Me.Vel_MediaTextEdit.Location = New System.Drawing.Point(168, 131)
        Me.Vel_MediaTextEdit.Name = "Vel_MediaTextEdit"
        Me.Vel_MediaTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Vel_MediaTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.Vel_MediaTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Vel_MediaTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Vel_MediaTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Vel_MediaTextEdit.Size = New System.Drawing.Size(137, 24)
        Me.Vel_MediaTextEdit.TabIndex = 26
        '
        'Cod_ImagemTextEdit
        '
        Me.Cod_ImagemTextEdit.Location = New System.Drawing.Point(47, 612)
        Me.Cod_ImagemTextEdit.Name = "Cod_ImagemTextEdit"
        Me.Cod_ImagemTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cod_ImagemTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.Cod_ImagemTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Cod_ImagemTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Cod_ImagemTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.Cod_ImagemTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Cod_ImagemTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Cod_ImagemTextEdit.Size = New System.Drawing.Size(205, 24)
        Me.Cod_ImagemTextEdit.TabIndex = 4
        '
        'LugaresTextEdit
        '
        Me.LugaresTextEdit.Location = New System.Drawing.Point(26, 131)
        Me.LugaresTextEdit.Name = "LugaresTextEdit"
        Me.LugaresTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LugaresTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.LugaresTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.LugaresTextEdit.Properties.Appearance.Options.UseFont = True
        Me.LugaresTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LugaresTextEdit.Size = New System.Drawing.Size(100, 24)
        Me.LugaresTextEdit.TabIndex = 24
        '
        'Cod_ViaturaTextEdit
        '
        Me.Cod_ViaturaTextEdit.Location = New System.Drawing.Point(26, 54)
        Me.Cod_ViaturaTextEdit.Name = "Cod_ViaturaTextEdit"
        Me.Cod_ViaturaTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cod_ViaturaTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.Cod_ViaturaTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Cod_ViaturaTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Cod_ViaturaTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Cod_ViaturaTextEdit.Size = New System.Drawing.Size(100, 24)
        Me.Cod_ViaturaTextEdit.TabIndex = 6
        '
        'DescritivoTextEdit
        '
        Me.DescritivoTextEdit.Location = New System.Drawing.Point(168, 52)
        Me.DescritivoTextEdit.Name = "DescritivoTextEdit"
        Me.DescritivoTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DescritivoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.DescritivoTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.DescritivoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.DescritivoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.DescritivoTextEdit.Size = New System.Drawing.Size(326, 24)
        Me.DescritivoTextEdit.TabIndex = 8
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'UC_NAV11
        '
        Me.UC_NAV11.BackColor = System.Drawing.Color.White
        Me.UC_NAV11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_NAV11.Location = New System.Drawing.Point(0, 0)
        Me.UC_NAV11.mFRM = Nothing
        Me.UC_NAV11.Name = "UC_NAV11"
        Me.UC_NAV11.Size = New System.Drawing.Size(1182, 735)
        Me.UC_NAV11.TabIndex = 27
        '
        'cmdCarrega
        '
        Me.cmdCarrega.Image = Global.DEMO_BACKOFFICE.My.Resources.Resources.upload
        Me.cmdCarrega.Location = New System.Drawing.Point(290, 596)
        Me.cmdCarrega.Name = "cmdCarrega"
        Me.cmdCarrega.Size = New System.Drawing.Size(194, 65)
        Me.cmdCarrega.TabIndex = 36
        Me.cmdCarrega.TabStop = False
        '
        'frmViaturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DEMO_BACKOFFICE.My.Resources.Resources.BACKGROUND_VIATURAS
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1182, 735)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UC_NAV11)
        Me.Name = "frmViaturas"
        Me.Text = "frmViaturas"
        Me.Panel1.ResumeLayout(False)
        CType(Me.FLG_WifiCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLG_WCCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLG_USBCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLG_TomadasCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FLG_ACCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ano_FabricoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vel_MediaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_ImagemTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LugaresTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_ViaturaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescritivoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdCarrega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Cod_ImagemTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescritivoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UC_NAV11 As UC_NAV1
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Ano_FabricoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Vel_MediaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LugaresTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_ViaturaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FLG_WifiCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents FLG_WCCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents FLG_USBCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents FLG_TomadasCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents FLG_ACCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents cmdCarrega As PictureBox
End Class
