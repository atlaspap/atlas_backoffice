<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaises
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
        Dim Cod_PaisLabel As System.Windows.Forms.Label
        Dim PaisLabel As System.Windows.Forms.Label
        Me.UC_NAV11 = New DEMO_BACKOFFICE.UC_NAV1()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ClsPaisesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cod_PaisTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PaisTextEdit = New DevExpress.XtraEditors.TextEdit()
        Cod_PaisLabel = New System.Windows.Forms.Label()
        PaisLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.ClsPaisesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_PaisTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaisTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UC_NAV11
        '
        Me.UC_NAV11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_NAV11.Location = New System.Drawing.Point(0, 0)
        Me.UC_NAV11.mFRM = Nothing
        Me.UC_NAV11.Name = "UC_NAV11"
        Me.UC_NAV11.Size = New System.Drawing.Size(993, 541)
        Me.UC_NAV11.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(PaisLabel)
        Me.Panel1.Controls.Add(Me.PaisTextEdit)
        Me.Panel1.Controls.Add(Cod_PaisLabel)
        Me.Panel1.Controls.Add(Me.Cod_PaisTextEdit)
        Me.Panel1.Location = New System.Drawing.Point(13, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(968, 474)
        Me.Panel1.TabIndex = 1
        '
        'ClsPaisesBindingSource
        '
        Me.ClsPaisesBindingSource.DataSource = GetType(DEMO_BACKOFFICE.ClsPaises)
        '
        'Cod_PaisLabel
        '
        Cod_PaisLabel.AutoSize = True
        Cod_PaisLabel.Location = New System.Drawing.Point(74, 54)
        Cod_PaisLabel.Name = "Cod_PaisLabel"
        Cod_PaisLabel.Size = New System.Drawing.Size(52, 13)
        Cod_PaisLabel.TabIndex = 0
        Cod_PaisLabel.Text = "Cod Pais:"
        '
        'Cod_PaisTextEdit
        '
        Me.Cod_PaisTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClsPaisesBindingSource, "Cod_Pais", True))
        Me.Cod_PaisTextEdit.Location = New System.Drawing.Point(132, 51)
        Me.Cod_PaisTextEdit.Name = "Cod_PaisTextEdit"
        Me.Cod_PaisTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.Cod_PaisTextEdit.TabIndex = 1
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.Location = New System.Drawing.Point(96, 80)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(30, 13)
        PaisLabel.TabIndex = 2
        PaisLabel.Text = "Pais:"
        '
        'PaisTextEdit
        '
        Me.PaisTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClsPaisesBindingSource, "Pais", True))
        Me.PaisTextEdit.Location = New System.Drawing.Point(132, 77)
        Me.PaisTextEdit.Name = "PaisTextEdit"
        Me.PaisTextEdit.Size = New System.Drawing.Size(375, 20)
        Me.PaisTextEdit.TabIndex = 3
        '
        'frmPaises
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 541)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UC_NAV11)
        Me.Name = "frmPaises"
        Me.Text = "frmPaises"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ClsPaisesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_PaisTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaisTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UC_NAV11 As UC_NAV1
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PaisTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ClsPaisesBindingSource As BindingSource
    Friend WithEvents Cod_PaisTextEdit As DevExpress.XtraEditors.TextEdit
End Class
