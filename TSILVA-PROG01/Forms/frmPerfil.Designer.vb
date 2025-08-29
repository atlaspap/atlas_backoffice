<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPerfil
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
        Me.Cod_EntidadeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NomeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LoginTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PasswordTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EmailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_ImagemTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdUpload = New System.Windows.Forms.PictureBox()
        Me.cmdShow_Password = New System.Windows.Forms.PictureBox()
        Me.ClsEntidadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.Cod_EntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NomeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_ImagemTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdUpload, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdShow_Password, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClsEntidadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cod_EntidadeTextEdit
        '
        Me.Cod_EntidadeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClsEntidadesBindingSource, "Cod_Entidade", True))
        Me.Cod_EntidadeTextEdit.Location = New System.Drawing.Point(40, 95)
        Me.Cod_EntidadeTextEdit.Name = "Cod_EntidadeTextEdit"
        Me.Cod_EntidadeTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cod_EntidadeTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.Cod_EntidadeTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.Cod_EntidadeTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Cod_EntidadeTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Cod_EntidadeTextEdit.Size = New System.Drawing.Size(142, 24)
        Me.Cod_EntidadeTextEdit.TabIndex = 2
        '
        'NomeTextEdit
        '
        Me.NomeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClsEntidadesBindingSource, "Nome", True))
        Me.NomeTextEdit.Location = New System.Drawing.Point(229, 93)
        Me.NomeTextEdit.Name = "NomeTextEdit"
        Me.NomeTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NomeTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.NomeTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.NomeTextEdit.Properties.Appearance.Options.UseFont = True
        Me.NomeTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.NomeTextEdit.Size = New System.Drawing.Size(609, 24)
        Me.NomeTextEdit.TabIndex = 3
        '
        'LoginTextEdit
        '
        Me.LoginTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClsEntidadesBindingSource, "Login", True))
        Me.LoginTextEdit.Location = New System.Drawing.Point(40, 171)
        Me.LoginTextEdit.Name = "LoginTextEdit"
        Me.LoginTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LoginTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.LoginTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.LoginTextEdit.Properties.Appearance.Options.UseFont = True
        Me.LoginTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.LoginTextEdit.Size = New System.Drawing.Size(142, 24)
        Me.LoginTextEdit.TabIndex = 4
        '
        'PasswordTextEdit
        '
        Me.PasswordTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClsEntidadesBindingSource, "Password", True))
        Me.PasswordTextEdit.Location = New System.Drawing.Point(229, 171)
        Me.PasswordTextEdit.Name = "PasswordTextEdit"
        Me.PasswordTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.PasswordTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.PasswordTextEdit.Properties.Appearance.Options.UseFont = True
        Me.PasswordTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PasswordTextEdit.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextEdit.Size = New System.Drawing.Size(319, 24)
        Me.PasswordTextEdit.TabIndex = 5
        '
        'EmailTextEdit
        '
        Me.EmailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClsEntidadesBindingSource, "Email", True))
        Me.EmailTextEdit.Location = New System.Drawing.Point(40, 258)
        Me.EmailTextEdit.Name = "EmailTextEdit"
        Me.EmailTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmailTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.EmailTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.EmailTextEdit.Properties.Appearance.Options.UseFont = True
        Me.EmailTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.EmailTextEdit.Size = New System.Drawing.Size(490, 24)
        Me.EmailTextEdit.TabIndex = 6
        '
        'Cod_ImagemTextEdit
        '
        Me.Cod_ImagemTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClsEntidadesBindingSource, "Cod_Imagem", True))
        Me.Cod_ImagemTextEdit.Location = New System.Drawing.Point(1195, 35)
        Me.Cod_ImagemTextEdit.Name = "Cod_ImagemTextEdit"
        Me.Cod_ImagemTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Cod_ImagemTextEdit.TabIndex = 7
        Me.Cod_ImagemTextEdit.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DEMO_BACKOFFICE.My.Resources.Resources._Default
        Me.PictureBox1.Location = New System.Drawing.Point(1126, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(238, 241)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'cmdUpload
        '
        Me.cmdUpload.BackColor = System.Drawing.Color.Transparent
        Me.cmdUpload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdUpload.Image = Global.DEMO_BACKOFFICE.My.Resources.Resources.upload
        Me.cmdUpload.Location = New System.Drawing.Point(1153, 324)
        Me.cmdUpload.Name = "cmdUpload"
        Me.cmdUpload.Size = New System.Drawing.Size(197, 59)
        Me.cmdUpload.TabIndex = 9
        Me.cmdUpload.TabStop = False
        '
        'cmdShow_Password
        '
        Me.cmdShow_Password.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdShow_Password.Image = Global.DEMO_BACKOFFICE.My.Resources.Resources.eye_show
        Me.cmdShow_Password.Location = New System.Drawing.Point(525, 172)
        Me.cmdShow_Password.Name = "cmdShow_Password"
        Me.cmdShow_Password.Size = New System.Drawing.Size(29, 28)
        Me.cmdShow_Password.TabIndex = 10
        Me.cmdShow_Password.TabStop = False
        '
        'ClsEntidadesBindingSource
        '
        Me.ClsEntidadesBindingSource.DataSource = GetType(DEMO_BACKOFFICE.ClsEntidades)
        '
        'frmPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DEMO_BACKOFFICE.My.Resources.Resources.BACKGROUND_PERFIL
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1434, 832)
        Me.Controls.Add(Me.cmdShow_Password)
        Me.Controls.Add(Me.cmdUpload)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Cod_ImagemTextEdit)
        Me.Controls.Add(Me.EmailTextEdit)
        Me.Controls.Add(Me.PasswordTextEdit)
        Me.Controls.Add(Me.LoginTextEdit)
        Me.Controls.Add(Me.NomeTextEdit)
        Me.Controls.Add(Me.Cod_EntidadeTextEdit)
        Me.Name = "frmPerfil"
        Me.Text = "frmPerfil"
        CType(Me.Cod_EntidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NomeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasswordTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_ImagemTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdUpload, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdShow_Password, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClsEntidadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ClsEntidadesBindingSource As BindingSource
    Friend WithEvents Cod_EntidadeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NomeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LoginTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PasswordTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_ImagemTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmdUpload As PictureBox
    Friend WithEvents cmdShow_Password As PictureBox
End Class
