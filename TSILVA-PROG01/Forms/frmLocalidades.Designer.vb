<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocalidades
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
        Dim LocalidadeLabel As System.Windows.Forms.Label
        Dim Cod_LocalidadeLabel As System.Windows.Forms.Label
        Me.UC_NAV11 = New DEMO_BACKOFFICE.UC_NAV1()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Cod_LocalidadeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LocalidadeTextEdit = New DevExpress.XtraEditors.TextEdit()
        LocalidadeLabel = New System.Windows.Forms.Label()
        Cod_LocalidadeLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Cod_LocalidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LocalidadeLabel
        '
        LocalidadeLabel.AutoSize = True
        LocalidadeLabel.Location = New System.Drawing.Point(188, 58)
        LocalidadeLabel.Name = "LocalidadeLabel"
        LocalidadeLabel.Size = New System.Drawing.Size(62, 13)
        LocalidadeLabel.TabIndex = 2
        LocalidadeLabel.Text = "Localidade:"
        '
        'Cod_LocalidadeLabel
        '
        Cod_LocalidadeLabel.AutoSize = True
        Cod_LocalidadeLabel.Location = New System.Drawing.Point(166, 32)
        Cod_LocalidadeLabel.Name = "Cod_LocalidadeLabel"
        Cod_LocalidadeLabel.Size = New System.Drawing.Size(84, 13)
        Cod_LocalidadeLabel.TabIndex = 3
        Cod_LocalidadeLabel.Text = "Cod Localidade:"
        '
        'UC_NAV11
        '
        Me.UC_NAV11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_NAV11.Location = New System.Drawing.Point(0, 0)
        Me.UC_NAV11.mFRM = Nothing
        Me.UC_NAV11.Name = "UC_NAV11"
        Me.UC_NAV11.Size = New System.Drawing.Size(885, 489)
        Me.UC_NAV11.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Cod_LocalidadeLabel)
        Me.Panel1.Controls.Add(Me.Cod_LocalidadeTextEdit)
        Me.Panel1.Controls.Add(LocalidadeLabel)
        Me.Panel1.Controls.Add(Me.LocalidadeTextEdit)
        Me.Panel1.Location = New System.Drawing.Point(13, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(860, 420)
        Me.Panel1.TabIndex = 1
        '
        'Cod_LocalidadeTextEdit
        '
        Me.Cod_LocalidadeTextEdit.Location = New System.Drawing.Point(256, 29)
        Me.Cod_LocalidadeTextEdit.Name = "Cod_LocalidadeTextEdit"
        Me.Cod_LocalidadeTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Cod_LocalidadeTextEdit.TabIndex = 4
        '
        'LocalidadeTextEdit
        '
        Me.LocalidadeTextEdit.Location = New System.Drawing.Point(256, 55)
        Me.LocalidadeTextEdit.Name = "LocalidadeTextEdit"
        Me.LocalidadeTextEdit.Size = New System.Drawing.Size(479, 20)
        Me.LocalidadeTextEdit.TabIndex = 3
        '
        'frmLocalidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 489)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UC_NAV11)
        Me.Name = "frmLocalidades"
        Me.Text = "frmLocalidades"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Cod_LocalidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalidadeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UC_NAV11 As UC_NAV1
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Cod_LocalidadeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LocalidadeTextEdit As DevExpress.XtraEditors.TextEdit
End Class
