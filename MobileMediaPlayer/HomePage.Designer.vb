<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomePage
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomePage))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.openFile = New System.Windows.Forms.OpenFileDialog()
        Me.musicBox = New System.Windows.Forms.ListBox()
        Me.HomeNowPlaying = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnAddSong = New System.Windows.Forms.PictureBox()
        Me.btnSettings = New System.Windows.Forms.PictureBox()
        CType(Me.btnAddSong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bauhaus 93", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 42)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(266, 28)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "UNIVERSAL Media Player"
        '
        'musicBox
        '
        Me.musicBox.BackColor = System.Drawing.SystemColors.Window
        Me.musicBox.FormattingEnabled = True
        Me.musicBox.Location = New System.Drawing.Point(44, 259)
        Me.musicBox.Name = "musicBox"
        Me.musicBox.Size = New System.Drawing.Size(203, 95)
        Me.musicBox.TabIndex = 6
        '
        'HomeNowPlaying
        '
        Me.HomeNowPlaying.AutoSize = True
        Me.HomeNowPlaying.Location = New System.Drawing.Point(10, 390)
        Me.HomeNowPlaying.Name = "HomeNowPlaying"
        Me.HomeNowPlaying.Size = New System.Drawing.Size(0, 13)
        Me.HomeNowPlaying.TabIndex = 7
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'btnAddSong
        '
        Me.btnAddSong.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddSong.Image = CType(resources.GetObject("btnAddSong.Image"), System.Drawing.Image)
        Me.btnAddSong.Location = New System.Drawing.Point(118, 176)
        Me.btnAddSong.Name = "btnAddSong"
        Me.btnAddSong.Size = New System.Drawing.Size(50, 47)
        Me.btnAddSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAddSong.TabIndex = 5
        Me.btnAddSong.TabStop = False
        '
        'btnSettings
        '
        Me.btnSettings.Image = Global.MobileMediaPlayer.My.Resources.Resources.SettingsIcon
        Me.btnSettings.Location = New System.Drawing.Point(0, -1)
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
        Me.ClientSize = New System.Drawing.Size(289, 422)
        Me.Controls.Add(Me.HomeNowPlaying)
        Me.Controls.Add(Me.musicBox)
        Me.Controls.Add(Me.btnAddSong)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnSettings)
        Me.Name = "HomePage"
        Me.Text = "Crunch"
        CType(Me.btnAddSong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSettings As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents openFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnAddSong As System.Windows.Forms.PictureBox
    Friend WithEvents musicBox As ListBox
    Friend WithEvents HomeNowPlaying As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
