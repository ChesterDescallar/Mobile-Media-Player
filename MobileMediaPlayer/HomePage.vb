Imports System.IO
Public Class HomePage
    'Variable where the song is assigned so that it is displayed to the user
    Public displaySong As String


    'Sets the default theme of the media player to the 'light' theme
    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.WhiteSmoke
    End Sub


    'Loads the setting page & makes sure that no option is chosen between the themes
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        SettingPage.Show()
        SettingPage.HiddenButton.Checked = True
    End Sub

    'Opens a file directory and allows the user to add songs to the list box
    Private Sub btnAddSong_Click(sender As Object, e As EventArgs) Handles btnAddSong.Click
        With openFile
            .Filter = "All Files |*.mp3"
            .Multiselect = True
            .ShowDialog()
        End With
        If System.Windows.Forms.DialogResult.OK Then
            For Each song As String In openFile.FileNames
                musicBox.Items.Add(song)
            Next
        End If

    End Sub

    'Plays the song that that is selected in the music box & also displays the song name in the home page and the play page
    Private Sub musicBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles musicBox.SelectedIndexChanged
        PlayPage.songName = musicBox.SelectedItem
        displaySong = musicBox.SelectedItem
        displaySong = (Path.GetFileNameWithoutExtension(displaySong))
        PlayPage.MediaPlayer.URL = musicBox.SelectedItem
        Me.Hide()
        PlayPage.Show()

        PlayPage.PlayNowPlaying.Text = "Now Playing :" + displaySong
        HomeNowPlaying.Text = "Now Playing :" + displaySong
        PlayPage.PlayNowPlaying.Location = New Point(19, 297)


    End Sub

    'Sends user back to play page on click
    Private Sub HomeNowPlaying_Click(sender As Object, e As EventArgs) Handles HomeNowPlaying.Click
        Me.Hide()
        PlayPage.Show()
    End Sub


End Class
