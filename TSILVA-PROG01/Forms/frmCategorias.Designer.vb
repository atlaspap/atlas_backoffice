<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCategorias
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
        Dim Cod_CategoriaLabel As System.Windows.Forms.Label
        Dim DesignacaoLabel As System.Windows.Forms.Label
        Dim ContadorLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdCarregar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ContadorTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_ImagemTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DesignacaoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_CategoriaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UC_NAV11 = New DEMO_BACKOFFICE.UC_NAV1()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Cod_CategoriaLabel = New System.Windows.Forms.Label()
        DesignacaoLabel = New System.Windows.Forms.Label()
        ContadorLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContadorTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_ImagemTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DesignacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_CategoriaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cod_CategoriaLabel
        '
        Cod_CategoriaLabel.AutoSize = True
        Cod_CategoriaLabel.Location = New System.Drawing.Point(46, 39)
        Cod_CategoriaLabel.Name = "Cod_CategoriaLabel"
        Cod_CategoriaLabel.Size = New System.Drawing.Size(77, 13)
        Cod_CategoriaLabel.TabIndex = 0
        Cod_CategoriaLabel.Text = "Cod Categoria:"
        '
        'DesignacaoLabel
        '
        DesignacaoLabel.AutoSize = True
        DesignacaoLabel.Location = New System.Drawing.Point(56, 65)
        DesignacaoLabel.Name = "DesignacaoLabel"
        DesignacaoLabel.Size = New System.Drawing.Size(67, 13)
        DesignacaoLabel.TabIndex = 2
        DesignacaoLabel.Text = "Designacao:"
        '
        'ContadorLabel
        '
        ContadorLabel.AutoSize = True
        ContadorLabel.Location = New System.Drawing.Point(70, 91)
        ContadorLabel.Name = "ContadorLabel"
        ContadorLabel.Size = New System.Drawing.Size(53, 13)
        ContadorLabel.TabIndex = 6
        ContadorLabel.Text = "Contador:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.cmdCarregar)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(ContadorLabel)
        Me.Panel1.Controls.Add(Me.ContadorTextEdit)
        Me.Panel1.Controls.Add(Me.Cod_ImagemTextEdit)
        Me.Panel1.Controls.Add(DesignacaoLabel)
        Me.Panel1.Controls.Add(Me.DesignacaoTextEdit)
        Me.Panel1.Controls.Add(Cod_CategoriaLabel)
        Me.Panel1.Controls.Add(Me.Cod_CategoriaTextEdit)
        Me.Panel1.Location = New System.Drawing.Point(13, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(807, 446)
        Me.Panel1.TabIndex = 1
        '
        'cmdCarregar
        '
        Me.cmdCarregar.Location = New System.Drawing.Point(478, 323)
        Me.cmdCarregar.Name = "cmdCarregar"
        Me.cmdCarregar.Size = New System.Drawing.Size(227, 23)
        Me.cmdCarregar.TabIndex = 9
        Me.cmdCarregar.Text = "Carregar Imagem"
        Me.cmdCarregar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(478, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(227, 252)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'ContadorTextEdit
        '
        Me.ContadorTextEdit.Location = New System.Drawing.Point(129, 88)
        Me.ContadorTextEdit.Name = "ContadorTextEdit"
        Me.ContadorTextEdit.Size = New System.Drawing.Size(63, 20)
        Me.ContadorTextEdit.TabIndex = 7
        '
        'Cod_ImagemTextEdit
        '
        Me.Cod_ImagemTextEdit.Location = New System.Drawing.Point(478, 32)
        Me.Cod_ImagemTextEdit.Name = "Cod_ImagemTextEdit"
        Me.Cod_ImagemTextEdit.Size = New System.Drawing.Size(227, 20)
        Me.Cod_ImagemTextEdit.TabIndex = 5
        '
        'DesignacaoTextEdit
        '
        Me.DesignacaoTextEdit.Location = New System.Drawing.Point(129, 62)
        Me.DesignacaoTextEdit.Name = "DesignacaoTextEdit"
        Me.DesignacaoTextEdit.Size = New System.Drawing.Size(221, 20)
        Me.DesignacaoTextEdit.TabIndex = 3
        '
        'Cod_CategoriaTextEdit
        '
        Me.Cod_CategoriaTextEdit.Location = New System.Drawing.Point(129, 36)
        Me.Cod_CategoriaTextEdit.Name = "Cod_CategoriaTextEdit"
        Me.Cod_CategoriaTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Cod_CategoriaTextEdit.TabIndex = 1
        '
        'UC_NAV11
        '
        Me.UC_NAV11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_NAV11.Location = New System.Drawing.Point(0, 0)
        Me.UC_NAV11.mFRM = Nothing
        Me.UC_NAV11.Name = "UC_NAV11"
        Me.UC_NAV11.Size = New System.Drawing.Size(841, 511)
        Me.UC_NAV11.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 511)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UC_NAV11)
        Me.Name = "frmCategorias"
        Me.Text = "frmCategorias"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContadorTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_ImagemTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DesignacaoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_CategoriaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UC_NAV11 As UC_NAV1
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Cod_ImagemTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DesignacaoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Cod_CategoriaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContadorTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents cmdCarregar As Button
End Class
