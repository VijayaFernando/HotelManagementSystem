Public NotInheritable Class AmayaSplashScreen

    Private ProgressBarValue As Integer = 0

    Private Sub AmayaSplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ApplicationTitle.Text = "Amaya Hotel System"

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright

        AmayaProgressBar.Minimum = 0
        AmayaProgressBar.Maximum = 1000
        AmayaProgressBar.Value = 0

        SplashTimer.Enabled = True
        SplashTimer.Interval = 200
        SplashTimer.Start()
    End Sub

    Private Sub SplashTimer_Tick(sender As Object, e As EventArgs) Handles SplashTimer.Tick

        ProgressBarValue += 1

        Select Case ProgressBarValue
            Case 1, 3, 5, 7, 9
                AmayaProgressBar.ForeColor = Color.White
                AmayaProgressBar.Value = (ProgressBarValue * 100)
            Case 2, 4, 6, 8, 10
                AmayaProgressBar.Value = (ProgressBarValue * 100)
            Case 13
                SplashTimer.Stop()
                SplashTimer.Enabled = False
                LoginForm.Show()
                Me.Close()
        End Select

    End Sub

End Class
