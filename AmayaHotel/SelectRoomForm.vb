Public Class SelectRoomForm
    Private SQL As New LoginSQL

    Private Sub SelectRoomForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayRooms()
    End Sub

    Private Sub DisplayRooms()
        If SQL.Das IsNot Nothing Then
            SQL.Das.Clear()
        End If

        SQL.Run("SELECT rooms.*, room_type.*  FROM rooms,room_type WHERE rooms.room_type_id = room_type.room_type_id")
        Dim index As Integer
        RoomTable.Items.Clear()

        For index = 0 To SQL.Das.Tables(0).Rows.Count - 1
            Dim lv As New ListViewItem
            lv.Text = SQL.Das.Tables(0).Rows(index).Item("room_id")
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("room_number"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("room_type_name"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("facilities"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("room_price"))
            RoomTable.Items.Add(lv)
        Next
        SQL.Con.Close()

    End Sub

    Private Sub RoomTable_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles RoomTable.DoubleClick
        ReservationForm.RoomIDTextBox.Text = RoomTable.SelectedItems(0).Text
        ReservationForm.RoomNumberTextBox.Text = RoomTable.SelectedItems(0).SubItems(1).Text
        ReservationForm.RoomTypeTextBox.Text = RoomTable.SelectedItems(0).SubItems(2).Text
        ReservationForm.RoomPriceTextBox.Text = RoomTable.SelectedItems(0).SubItems(4).Text
        Me.Close()
    End Sub
End Class