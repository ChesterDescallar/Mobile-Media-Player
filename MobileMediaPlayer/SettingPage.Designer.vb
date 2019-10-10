<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingPage))
        Me.lblTheme = New System.Windows.Forms.Label()
        Me.optLight = New System.Windows.Forms.RadioButton()
        Me.optDark = New System.Windows.Forms.RadioButton()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.settingsbtnBack = New System.Windows.Forms.PictureBox()
        Me.HiddenButton = New System.Windows.Forms.RadioButton()
        CType(Me.settingsbtnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTheme
        '
        Me.lblTheme.AutoSize = True
        Me.lblTheme.Location = New System.Drawing.Point(12, 52)
        Me.lblTheme.Name = "lblTheme"
        Me.lblTheme.Size = New System.Drawing.Size(48, 13)
        Me.lblTheme.TabIndex = 0
        Me.lblTheme.Text = "Themes:"
        '
        'optLight
        '
        Me.optLight.AutoSize = True
        Me.optLight.Location = New System.Drawing.Point(15, 68)
        Me.optLight.Name = "optLight"
        Me.optLight.Size = New System.Drawing.Size(48, 17)
        Me.optLight.TabIndex = 5
        Me.optLight.TabStop = True
        Me.optLight.Text = "Light"
        Me.optLight.UseVisualStyleBackColor = True
        '
        'optDark
        '
        Me.optDark.AutoSize = True
        Me.optDark.Location = New System.Drawing.Point(15, 91)
        Me.optDark.Name = "optDark"
        Me.optDark.Size = New System.Drawing.Size(48, 17)
        Me.optDark.TabIndex = 6
        Me.optDark.TabStop = True
        Me.optDark.Text = "Dark"
        Me.optDark.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Location = New System.Drawing.Point(129, 7)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(53, 25)
        Me.btnHelp.TabIndex = 7
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'settingsbtnBack
        '
        Me.settingsbtnBack.Image = CType(resources.GetObject("settingsbtnBack.Image"), System.Drawing.Image)
        Me.settingsbtnBack.Location = New System.Drawing.Point(12, 7)
        Me.settingsbtnBack.Name = "settingsbtnBack"
        Me.settingsbtnBack.Size = New System.Drawing.Size(30, 30)
        Me.settingsbtnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.settingsbtnBack.TabIndex = 25
        Me.settingsbtnBack.TabStop = False
        '
        'HiddenButton
        '
        Me.HiddenButton.AutoSize = True
        Me.HiddenButton.Location = New System.Drawing.Point(90, 68)
        Me.HiddenButton.Name = "HiddenButton"
        Me.HiddenButton.Size = New System.Drawing.Size(14, 13)
        Me.HiddenButton.TabIndex = 26
        Me.HiddenButton.TabStop = True
        Me.HiddenButton.UseVisualStyleBackColor = True
        Me.HiddenButton.Visible = False
        '
        'SettingPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(194, 120)
        Me.Controls.Add(Me.HiddenButton)
        Me.Controls.Add(Me.settingsbtnBack)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.optDark)
        Me.Controls.Add(Me.optLight)
        Me.Controls.Add(Me.lblTheme)
        Me.Name = "SettingPage"
        Me.Text = "SettingPage"
        CType(Me.settingsbtnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTheme As System.Windows.Forms.Label
    Friend WithEvents optLight As System.Windows.Forms.RadioButton
    Friend WithEvents optDark As System.Windows.Forms.RadioButton
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents settingsbtnBack As System.Windows.Forms.PictureBox
    Friend WithEvents HiddenButton As System.Windows.Forms.RadioButton
End Class
