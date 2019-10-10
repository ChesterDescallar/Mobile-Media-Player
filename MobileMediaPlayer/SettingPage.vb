Public Class SettingPage

    'Changes the media player's theme to light
    Private Sub optLight_CheckedChanged(sender As Object, e As EventArgs) Handles optLight.CheckedChanged
        HomePage.BackColor = Color.WhiteSmoke
        PlayPage.BackColor = Color.WhiteSmoke

    End Sub
    'Changes the media player's theme to dark
    Private Sub optDark_CheckedChanged(sender As Object, e As EventArgs) Handles optDark.CheckedChanged
        HomePage.BackColor = Color.DarkGray
        PlayPage.BackColor = Color.DarkGray
    End Sub

    'Opens the help page and hides the setting page
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        HelpPage.Show()
        Me.Hide()
    End Sub
    'Hides the setting page
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles settingsbtnBack.Click
        Me.Hide()
    End Sub



End Class