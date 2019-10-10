Public Class HomePage
    Dim userSearch As String

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        userSearch = txtSearch.Text
        If userSearch = "Play" Then
            Me.Hide()
            PlayPage.Show()
        End If
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        SettingPage.Show()
    End Sub
End Class
