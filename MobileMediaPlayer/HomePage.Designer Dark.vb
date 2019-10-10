<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GenreChoice = New System.Windows.Forms.ComboBox()
        Me.btnSettings = New System.Windows.Forms.PictureBox()
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(25, 30)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(252, 28)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "CRUNCH Media Player"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.DarkGray
        Me.txtSearch.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(12, 83)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(276, 27)
        Me.txtSearch.TabIndex = 2
        Me.txtSearch.Text = "Search"
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GenreChoice
        '
        Me.GenreChoice.BackColor = System.Drawing.Color.Silver
        Me.GenreChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenreChoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GenreChoice.FormattingEnabled = True
        Me.GenreChoice.Items.AddRange(New Object() {"Pop", "Blues", "Classical", "Country", "Folk", "Electronic", "Jazz", "Reggae", "Rock", "Anime"})
        Me.GenreChoice.Location = New System.Drawing.Point(48, 163)
        Me.GenreChoice.Name = "GenreChoice"
        Me.GenreChoice.Size = New System.Drawing.Size(201, 21)
        Me.GenreChoice.TabIndex = 3
        Me.GenreChoice.UseWaitCursor = True
        '
        'btnSettings
        '
        Me.btnSettings.Image = Global.MobileMediaPlayer.My.Resources.Resources.SettingsIcon
        Me.btnSettings.Location = New System.Drawing.Point(0, 0)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(28, 28)
        Me.btnSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnSettings.TabIndex = 0
        Me.btnSettings.TabStop = False
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(300, 333)
        Me.Controls.Add(Me.GenreChoice)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnSettings)
        Me.Name = "HomePage"
        Me.Text = "Crunch"
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSettings As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents GenreChoice As System.Windows.Forms.ComboBox

End Class
