Public Class LoginForm
    Private SQL As New LoginSQL
    Private AuthUser As String
    Dim m As MainForm



    Private Sub OK_Click(sender As Object, e As EventArgs) Handles SignInButton.Click
        If SQL.HasConnection = True Then
            If Auth() = True Then
                AuthUser = UsernameTextBox.Text
                MsgBox("Login Success!")
                m = New MainForm
                m.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Function Auth() As Boolean
        If SQL.Das IsNot Nothing Then
            SQL.Das.Clear()
        End If

        SQL.Run("SELECT Count(Username) As UserCount " &
                "FROM system_users " &
                "WHERE username ='" & UsernameTextBox.Text & "' " &
                " AND password ='" & PasswordTextBox.Text & "'COLLATE SQL_Latin1_General_CP1_CS_AS ")

        If SQL.Das.Tables(0).Rows(0).Item("UserCount") = 1 Then
            Return True
        End If
        MsgBox("Invalid User Credentials.", MsgBoxStyle.Critical, "Login Failed")
        Return False
    End Function

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
