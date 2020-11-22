Public Class SelectGuestForm
    Private SQL As New LoginSQL

    Private Sub SelectGuestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayGuest()
    End Sub

    Private Sub DisplayGuest()
        If SQL.Das IsNot Nothing Then
            SQL.Das.Clear()
        End If

        SQL.Run("SELECT * FROM guests;")
        Dim index As Integer
        GuestTable.Items.Clear()

        For index = 0 To SQL.Das.Tables(0).Rows.Count - 1
            Dim lv As New ListViewItem
            lv.Text = SQL.Das.Tables(0).Rows(index).Item("guest_id")
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("first_name"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("last_name"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("sex"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("age"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("phone_number"))
            GuestTable.Items.Add(lv)
        Next
        SQL.Con.Close()
    End Sub

    Private Sub GuestTable_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GuestTable.DoubleClick
        CheckInForm.GuestIDTextBox.Text = GuestTable.SelectedItems(0).Text
        CheckInForm.GuestNameTextBox.Text = GuestTable.SelectedItems(0).SubItems(1).Text & " " & GuestTable.SelectedItems(0).SubItems(2).Text

        ReservationForm.GusetIDTextBox.Text = GuestTable.SelectedItems(0).Text
        ReservationForm.GuestNameTextBox.Text = GuestTable.SelectedItems(0).SubItems(1).Text & " " & GuestTable.SelectedItems(0).SubItems(2).Text

        CheckOutForm.GuestIDTextBox.Text = GuestTable.SelectedItems(0).Text
        CheckOutForm.GuestNameTextBox.Text = GuestTable.SelectedItems(0).SubItems(1).Text & " " & GuestTable.SelectedItems(0).SubItems(2).Text

        UseExtraForm.GuestIDTextBox.Text = GuestTable.SelectedItems(0).Text
        UseExtraForm.GuestNameTextBox.Text = GuestTable.SelectedItems(0).SubItems(1).Text & " " & GuestTable.SelectedItems(0).SubItems(2).Text

        PaymentForm.GuestIDTextBox.Text = GuestTable.SelectedItems(0).Text
        PaymentForm.GuestNameTextBox.Text = GuestTable.SelectedItems(0).SubItems(1).Text & " " & GuestTable.SelectedItems(0).SubItems(2).Text
        Me.Close()
    End Sub
End Class