Public Class PlayPage
    Public songName As String

    'Plays and pauses the current song playing in the media player
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        If MediaPlayer.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            MediaPlayer.Ctlcontrols.pause()

            ElseIf MediaPlayer.playState = WMPLib.WMPPlayState.wmppsPaused Then
                MediaPlayer.Ctlcontrols.play()
            End If

    End Sub

    'Skips to the previous song (previous item in the list box) and also loops the song around to the last song if it is the first item in the list box
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If HomePage.musicBox.SelectedIndex < HomePage.musicBox.Items.Count Then
            HomePage.musicBox.SelectedIndex = HomePage.musicBox.SelectedIndex - 1
            MediaPlayer.URL = songName
            MediaPlayer.Ctlcontrols.play()
        End If


        If HomePage.musicBox.SelectedIndex < HomePage.musicBox.TopIndex Then
            HomePage.musicBox.SelectedIndex = HomePage.musicBox.Items.Count - 1
        End If

    End Sub
    'Skips to the next song (nextitem in the list box) and also loops the song around to the first song if it is the last item in the list box
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If HomePage.musicBox.SelectedIndex < HomePage.musicBox.Items.Count - 1 Then
            HomePage.musicBox.SelectedIndex = HomePage.musicBox.SelectedIndex + 1
            MediaPlayer.URL = songName
            MediaPlayer.Ctlcontrols.play()

        ElseIf HomePage.musicBox.SelectedIndex = HomePage.musicBox.Items.Count - 1 Then
            HomePage.musicBox.SelectedIndex = HomePage.musicBox.TopIndex
        End If

    End Sub

    'Chanes the value of the media player as well is displaying the value
    Private Sub VolumeSlider_Scroll(sender As Object, e As EventArgs) Handles VolumeSlider.Scroll
        MediaPlayer.settings.volume = VolumeSlider.Value
        txtVolume.Text = VolumeSlider.Value
        'Changes the image of the picture box depending on the value of the trackbar
        If VolumeSlider.Value < 50 Then
            imgSpeaker.Image = My.Resources.volume_low2

        ElseIf VolumeSlider.Value > 50 Or VolumeSlider.Value = 50 Then
            imgSpeaker.Image = My.Resources.volume_high2
        End If
        If VolumeSlider.Value = 0 Then
            imgSpeaker.Image = My.Resources.MuteIcon
        End If
    End Sub
    'Goes back to the home page'
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        HomePage.Show()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        'Changes the image of the play/pause button depending on whether a song is playing or not'
        If MediaPlayer.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            btnPlay.Image = My.Resources.pause_2
        ElseIf MediaPlayer.playState = WMPLib.WMPPlayState.wmppsPaused Then
            btnPlay.Image = My.Resources.play_2
        End If

        'Makes the label into a scrolling text that keeps going around'
        PlayNowPlaying.Left = PlayNowPlaying.Left - 3
        If PlayNowPlaying.Left < 0 - PlayNowPlaying.Width Then
            PlayNowPlaying.Left = 575
        End If

        'Goes to the next song as soon as the current track is finished'
        If MediaPlayer.playState = WMPLib.WMPPlayState.wmppsStopped Then
            If HomePage.musicBox.SelectedIndex = HomePage.musicBox.Items.Count - 1 Then
                lblEndPlaylist.Show()
                PlayNowPlaying.Hide()
            End If
            HomePage.musicBox.SelectedIndex = HomePage.musicBox.SelectedIndex + 1
            MediaPlayer.URL = HomePage.musicBox.SelectedItem
            MediaPlayer.Ctlcontrols.play()
        End If


    End Sub

    'Starts the timer which'
    Private Sub PlayPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Start()
        HomePage.Timer1.Start()
        lblEndPlaylist.Hide()
    End Sub



End Class