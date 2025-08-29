<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDistritos
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
        Dim Cod_DistritoLabel As System.Windows.Forms.Label
        Dim DistritoLabel As System.Windows.Forms.Label
        Me.UC_NAV11 = New DEMO_BACKOFFICE.UC_NAV1()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DistritoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Cod_DistritoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Cod_DistritoLabel = New System.Windows.Forms.Label()
        DistritoLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DistritoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cod_DistritoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cod_DistritoLabel
        '
        Cod_DistritoLabel.AutoSize = True
        Cod_DistritoLabel.BackColor = System.Drawing.Color.Transparent
        Cod_DistritoLabel.Location = New System.Drawing.Point(17, 22)
        Cod_DistritoLabel.Name = "Cod_DistritoLabel"
        Cod_DistritoLabel.Size = New System.Drawing.Size(64, 13)
        Cod_DistritoLabel.TabIndex = 0
        Cod_DistritoLabel.Text = "Cod Distrito:"
        '
        'DistritoLabel
        '
        DistritoLabel.AutoSize = True
        DistritoLabel.BackColor = System.Drawing.Color.Transparent
        DistritoLabel.Location = New System.Drawing.Point(39, 48)
        DistritoLabel.Name = "DistritoLabel"
        DistritoLabel.Size = New System.Drawing.Size(42, 13)
        DistritoLabel.TabIndex = 2
        DistritoLabel.Text = "Distrito:"
        '
        'UC_NAV11
        '
        Me.UC_NAV11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_NAV11.Location = New System.Drawing.Point(0, 0)
        Me.UC_NAV11.mFRM = Nothing
        Me.UC_NAV11.Name = "UC_NAV11"
        Me.UC_NAV11.Size = New System.Drawing.Size(802, 443)
        Me.UC_NAV11.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.BackgroundImage = Global.DEMO_BACKOFFICE.My.Resources.Resources.BACKGROUND
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(DistritoLabel)
        Me.Panel1.Controls.Add(Me.DistritoTextEdit)
        Me.Panel1.Controls.Add(Cod_DistritoLabel)
        Me.Panel1.Controls.Add(Me.Cod_DistritoTextEdit)
        Me.Panel1.Location = New System.Drawing.Point(13, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(775, 387)
        Me.Panel1.TabIndex = 1
        '
        'DistritoTextEdit
        '
        Me.DistritoTextEdit.Location = New System.Drawing.Point(87, 45)
        Me.DistritoTextEdit.Name = "DistritoTextEdit"
        Me.DistritoTextEdit.Size = New System.Drawing.Size(313, 20)
        Me.DistritoTextEdit.TabIndex = 3
        '
        'Cod_DistritoTextEdit
        '
        Me.Cod_DistritoTextEdit.Location = New System.Drawing.Point(87, 19)
        Me.Cod_DistritoTextEdit.Name = "Cod_DistritoTextEdit"
        Me.Cod_DistritoTextEdit.Size = New System.Drawing.Size(74, 20)
        Me.Cod_DistritoTextEdit.TabIndex = 1
        '
        'frmDistritos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 443)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UC_NAV11)
        Me.Name = "frmDistritos"
        Me.Text = "frmDistritos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DistritoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cod_DistritoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UC_NAV11 As UC_NAV1
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Cod_DistritoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DistritoTextEdit As DevExpress.XtraEditors.TextEdit
End Class
