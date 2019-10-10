<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlayPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlayPage))
        Me.VolumeSlider = New System.Windows.Forms.TrackBar()
        Me.MediaPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.txtVolume = New System.Windows.Forms.TextBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.btnBack = New System.Windows.Forms.PictureBox()
        Me.imgSpeaker = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.PictureBox()
        Me.btnPrevious = New System.Windows.Forms.PictureBox()
        Me.btnPlay = New System.Windows.Forms.PictureBox()
        Me.PlayNowPlaying = New System.Windows.Forms.Label()
        Me.lblEndPlaylist = New System.Windows.Forms.Label()
        CType(Me.VolumeSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSpeaker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPrevious, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VolumeSlider
        '
        Me.VolumeSlider.BackColor = System.Drawing.Color.WhiteSmoke
        Me.VolumeSlider.Location = New System.Drawing.Point(45, 397)
        Me.VolumeSlider.Maximum = 100
        Me.VolumeSlider.Name = "VolumeSlider"
        Me.VolumeSlider.Size = New System.Drawing.Size(192, 45)
        Me.VolumeSlider.TabIndex = 1
        Me.VolumeSlider.TickFrequency = 0
        Me.VolumeSlider.Value = 20
        '
        'MediaPlayer
        '
        Me.MediaPlayer.Enabled = True
        Me.MediaPlayer.Location = New System.Drawing.Point(22, 59)
        Me.MediaPlayer.Name = "MediaPlayer"
        Me.MediaPlayer.OcxState = CType(resources.GetObject("MediaPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MediaPlayer.Size = New System.Drawing.Size(239, 183)
        Me.MediaPlayer.TabIndex = 21
        '
        'txtVolume
        '
        Me.txtVolume.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtVolume.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVolume.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolume.Location = New System.Drawing.Point(234, 397)
        Me.txtVolume.Multiline = True
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(27, 20)
        Me.txtVolume.TabIndex = 26
        Me.txtVolume.Text = "20"
        '
        'Timer
        '
        '
        'btnBack
        '
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(2, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(30, 30)
        Me.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnBack.TabIndex = 24
        Me.btnBack.TabStop = False
        '
        'imgSpeaker
        '
        Me.imgSpeaker.Image = Global.MobileMediaPlayer.My.Resources.Resources.volume_low2
        Me.imgSpeaker.Location = New System.Drawing.Point(12, 390)
        Me.imgSpeaker.Name = "imgSpeaker"
        Me.imgSpeaker.Size = New System.Drawing.Size(32, 27)
        Me.imgSpeaker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSpeaker.TabIndex = 20
        Me.imgSpeaker.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.Location = New System.Drawing.Point(209, 334)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(40, 40)
        Me.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnNext.TabIndex = 19
        Me.btnNext.TabStop = False
        '
        'btnPrevious
        '
        Me.btnPrevious.Image = CType(resources.GetObject("btnPrevious.Image"), System.Drawing.Image)
        Me.btnPrevious.Location = New System.Drawing.Point(45, 334)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(40, 40)
        Me.btnPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnPrevious.TabIndex = 18
        Me.btnPrevious.TabStop = False
        '
        'btnPlay
        '
        Me.btnPlay.Image = CType(resources.GetObject("btnPlay.Image"), System.Drawing.Image)
        Me.btnPlay.Location = New System.Drawing.Point(115, 323)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(60, 60)
        Me.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnPlay.TabIndex = 17
        Me.btnPlay.TabStop = False
        '
        'PlayNowPlaying
        '
        Me.PlayNowPlaying.AutoSize = True
        Me.PlayNowPlaying.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayNowPlaying.Location = New System.Drawing.Point(19, 297)
        Me.PlayNowPlaying.Name = "PlayNowPlaying"
        Me.PlayNowPlaying.Size = New System.Drawing.Size(112, 16)
        Me.PlayNowPlaying.TabIndex = 29
        Me.PlayNowPlaying.Text = "Now Playing :"
        '
        'lblEndPlaylist
        '
        Me.lblEndPlaylist.AutoSize = True
        Me.lblEndPlaylist.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndPlaylist.Location = New System.Drawing.Point(41, 292)
        Me.lblEndPlaylist.Name = "lblEndPlaylist"
        Me.lblEndPlaylist.Size = New System.Drawing.Size(175, 21)
        Me.lblEndPlaylist.TabIndex = 30
        Me.lblEndPlaylist.Text = "END OF PLAYLIST"
        '
        'PlayPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(289, 422)
        Me.Controls.Add(Me.lblEndPlaylist)
        Me.Controls.Add(Me.PlayNowPlaying)
        Me.Controls.Add(Me.txtVolume)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.MediaPlayer)
        Me.Controls.Add(Me.imgSpeaker)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.VolumeSlider)
        Me.Controls.Add(Me.btnPlay)
        Me.Name = "PlayPage"
        Me.Text = "PlayPage"
        CType(Me.VolumeSlider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSpeaker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPrevious, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPlay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VolumeSlider As System.Windows.Forms.TrackBar
    Friend WithEvents btnPlay As PictureBox
    Friend WithEvents btnPrevious As PictureBox
    Friend WithEvents btnNext As PictureBox
    Friend WithEvents imgSpeaker As PictureBox
    Friend WithEvents btnBack As System.Windows.Forms.PictureBox
    Friend WithEvents txtVolume As System.Windows.Forms.TextBox
    Friend WithEvents Timer As Timer
    Friend WithEvents MediaPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents PlayNowPlaying As System.Windows.Forms.Label
    Friend WithEvents lblEndPlaylist As System.Windows.Forms.Label
End Class
