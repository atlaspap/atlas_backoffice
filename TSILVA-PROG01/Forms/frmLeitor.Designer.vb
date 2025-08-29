<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLeitor
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLeitor))
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_ImagemTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ClsEntidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NomeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Num_TelemovelTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Num_TelefoneTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EmailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cmdLim = New System.Windows.Forms.PictureBox()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_ImagemTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClsEntidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NomeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num_TelemovelTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num_TelefoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdLim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(117, 159)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.TextEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit1.Size = New System.Drawing.Size(248, 24)
        Me.TextEdit1.TabIndex = 0
        '
        'Cod_ImagemTextEdit
        '
        Me.Cod_ImagemTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClsEntidadesBindingSource, "Cod_Imagem", True))
        Me.Cod_ImagemTextEdit.Location = New System.Drawing.Point(749, 423)
        Me.Cod_ImagemTextEdit.Name = "Cod_ImagemTextEdit"
        Me.Cod_ImagemTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cod_ImagemTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.Cod_ImagemTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Cod_ImagemTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Cod_ImagemTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Cod_ImagemTextEdit.Size = New System.Drawing.Size(216, 24)
        Me.Cod_ImagemTextEdit.TabIndex = 4
        '
        'ClsEntidadesBindingSource
        '
        Me.ClsEntidadesBindingSource.DataSource = GetType(DEMO_BACKOFFICE.ClsEntidades)
        '
        'NomeTextEdit
        '
        Me.NomeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClsEntidadesBindingSource, "Nome", True))
        Me.NomeTextEdit.Location = New System.Drawing.Point(117, 254)
        Me.NomeTextEdit.Name = "NomeTextEdit"
        Me.NomeTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NomeTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.NomeTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.NomeTextEdit.Properties.Appearance.Options.UseFont = True
        Me.NomeTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.NomeTextEdit.Size = New System.Drawing.Size(502, 24)
        Me.NomeTextEdit.TabIndex = 5
        '
        'Num_TelemovelTextEdit
        '
        Me.Num_TelemovelTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClsEntidadesBindingSource, "Num_Telemovel", True))
        Me.Num_TelemovelTextEdit.Location = New System.Drawing.Point(117, 344)
        Me.Num_TelemovelTextEdit.Name = "Num_TelemovelTextEdit"
        Me.Num_TelemovelTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Num_TelemovelTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.Num_TelemovelTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Num_TelemovelTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Num_TelemovelTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Num_TelemovelTextEdit.Size = New System.Drawing.Size(216, 24)
        Me.Num_TelemovelTextEdit.TabIndex = 7
        '
        'Num_TelefoneTextEdit
        '
        Me.Num_TelefoneTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClsEntidadesBindingSource, "Num_Telefone", True))
        Me.Num_TelefoneTextEdit.Location = New System.Drawing.Point(402, 344)
        Me.Num_TelefoneTextEdit.Name = "Num_TelefoneTextEdit"
        Me.Num_TelefoneTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Num_TelefoneTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.Num_TelefoneTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Num_TelefoneTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Num_TelefoneTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Num_TelefoneTextEdit.Size = New System.Drawing.Size(217, 24)
        Me.Num_TelefoneTextEdit.TabIndex = 9
        '
        'EmailTextEdit
        '
        Me.EmailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClsEntidadesBindingSource, "Email", True))
        Me.EmailTextEdit.Location = New System.Drawing.Point(117, 438)
        Me.EmailTextEdit.Name = "EmailTextEdit"
        Me.EmailTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmailTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.EmailTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.EmailTextEdit.Properties.Appearance.Options.UseFont = True
        Me.EmailTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.EmailTextEdit.Size = New System.Drawing.Size(502, 24)
        Me.EmailTextEdit.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DEMO_BACKOFFICE.My.Resources.Resources._Default
        Me.PictureBox1.Location = New System.Drawing.Point(748, 151)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(229, 229)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.DEMO_BACKOFFICE.My.Resources.Resources.logo_white_no
        Me.PictureBox2.Location = New System.Drawing.Point(511, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'cmdLim
        '
        Me.cmdLim.BackColor = System.Drawing.Color.Transparent
        Me.cmdLim.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdLim.Image = Global.DEMO_BACKOFFICE.My.Resources.Resources.clear_btn
        Me.cmdLim.Location = New System.Drawing.Point(400, 149)
        Me.cmdLim.Name = "cmdLim"
        Me.cmdLim.Size = New System.Drawing.Size(100, 50)
        Me.cmdLim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.cmdLim.TabIndex = 15
        Me.cmdLim.TabStop = False
        '
        'frmLeitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DEMO_BACKOFFICE.My.Resources.Resources.BACKGROUND_LEITOR
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1112, 637)
        Me.Controls.Add(Me.cmdLim)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.EmailTextEdit)
        Me.Controls.Add(Me.Num_TelefoneTextEdit)
        Me.Controls.Add(Me.Num_TelemovelTextEdit)
        Me.Controls.Add(Me.NomeTextEdit)
        Me.Controls.Add(Me.Cod_ImagemTextEdit)
        Me.Controls.Add(Me.TextEdit1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLeitor"
        Me.Text = "ATLAS - Leitor de Cartões"
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_ImagemTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClsEntidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NomeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num_TelemovelTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num_TelefoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdLim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ClsEntidadesBindingSource As BindingSource
    Friend WithEvents Cod_ImagemTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NomeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Num_TelemovelTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Num_TelefoneTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cmdLim As PictureBox
End Class
