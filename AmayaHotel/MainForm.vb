Public Class MainForm
    Private SQL As New LoginSQL

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Dim exit_app As String = MsgBox("Exit application?", vbQuestion + vbYesNo, "Exit")
        If exit_app = vbNo Then
            e.Cancel = True
        Else
            End
        End If
    End Sub

    Private Sub NewCheckInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCheckInToolStripMenuItem.Click
        CheckInForm.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim out_app As String = MsgBox("logout from the application?", vbQuestion + vbYesNo, "Logout")
        If out_app = vbYes Then
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LogoutToolStripButton_Click(sender As Object, e As EventArgs) Handles LogoutToolStripButton.Click
        Dim out_app As String = MsgBox("Logout from the application?", vbQuestion + vbYesNo, "Logout")
        If out_app = vbYes Then
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        Dim exit_app As String = MsgBox("Exit application?", vbQuestion + vbYesNo, "Exit")
        If exit_app = vbYes Then
            End
        End If
    End Sub

    Private Sub NewReservationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewReservationToolStripMenuItem.Click
        ReservationForm.ShowDialog()
    End Sub

    Private Sub NewGuestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGuestToolStripMenuItem.Click
        AddNewGuestForm.ShowDialog()
    End Sub

    Private Sub CheckInToolStripButton_Click(sender As Object, e As EventArgs) Handles CheckInToolStripButton.Click
        CheckInForm.ShowDialog()
    End Sub

    Private Sub GuestsToolStripButton_Click(sender As Object, e As EventArgs) Handles GuestsToolStripButton.Click
        AddNewGuestForm.ShowDialog()
    End Sub

    Private Sub ReserveToolStripButton_Click(sender As Object, e As EventArgs) Handles ReserveToolStripButton.Click
        ReservationForm.ShowDialog()
    End Sub

    Private Sub CheckOutToolStripButton_Click(sender As Object, e As EventArgs) Handles CheckOutToolStripButton.Click
        CheckOutForm.ShowDialog()
    End Sub

    Private Sub RoomsToolStripButton_Click(sender As Object, e As EventArgs) Handles RoomsToolStripButton.Click
        SelectRoomForm.ShowDialog()
    End Sub

    Private Sub CheckOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckOutToolStripMenuItem.Click
        CheckOutForm.ShowDialog()
    End Sub

    Private Sub AddNewRoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewRoomToolStripMenuItem.Click
        AddNewRoomForm.ShowDialog()
    End Sub

    Private Sub AddNewRoomTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewRoomTypeToolStripMenuItem.Click
        AddNewRoomTypeForm.ShowDialog()
    End Sub

    Private Sub CheckedInListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckedInListToolStripMenuItem.Click
        Dim f As New CheckInForm()
        f.CheckInTabControl.SelectedIndex = 1
        f.ShowDialog()
    End Sub

    Private Sub ReservedListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservedListToolStripMenuItem.Click
        Dim f As New ReservationForm()
        f.ReserveTabControl.SelectedIndex = 1
        f.ShowDialog()
    End Sub

    Private Sub CheckedOutListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckedOutListToolStripMenuItem.Click
        Dim f As New CheckOutForm()
        f.CheckOutTabControl.SelectedIndex = 1
        f.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        SelectGuestForm.ShowDialog()
    End Sub

    Private Sub RoomsListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomsListToolStripMenuItem.Click
        SelectRoomForm.ShowDialog()
    End Sub

    Private Sub RoomTypeListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomTypeListToolStripMenuItem.Click
        SelectRoomTypeForm.ShowDialog()
    End Sub

    Private Sub AddNewExtraSeviceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewExtraSeviceToolStripMenuItem.Click
        AddNewExtraForm.ShowDialog()
    End Sub

    Private Sub UseExtraServicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UseExtraServicesToolStripMenuItem.Click
        UseExtraForm.ShowDialog()
    End Sub

    Private Sub DiscountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscountToolStripMenuItem.Click
        PaymentForm.ShowDialog()
    End Sub
End Class