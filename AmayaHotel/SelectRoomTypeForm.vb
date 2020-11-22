Public Class SelectRoomTypeForm
    Private SQL As New LoginSQL

    Private Sub SelectRoomTypeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayRooms()
    End Sub

    Private Sub DisplayRooms()
        If Sql.Das IsNot Nothing Then
            Sql.Das.Clear()
        End If

        SQL.Run("SELECT * FROM room_type")
        Dim index As Integer
        RoomTypeTable.Items.Clear()

        For index = 0 To SQL.Das.Tables(0).Rows.Count - 1
            Dim lv As New ListViewItem
            lv.Text = SQL.Das.Tables(0).Rows(index).Item("room_type_id")
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("room_type_name"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("facilities"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("no_of_rooms"))
            RoomTypeTable.Items.Add(lv)
        Next
        SQL.Con.Close()
    End Sub

    Private Sub RoomTypeTable_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles RoomTypeTable.DoubleClick
        AddNewRoomForm.RoomTypeIDTextBox.Text = RoomTypeTable.SelectedItems(0).Text
        AddNewRoomForm.RoomTypeTextBox.Text = RoomTypeTable.SelectedItems(0).SubItems(1).Text
        AddNewRoomForm.FacilitiesTextBox.Text = RoomTypeTable.SelectedItems(0).SubItems(2).Text
        AddNewRoomForm.NoOfRoomsTextBox.Text = RoomTypeTable.SelectedItems(0).SubItems(3).Text
        Me.Close()
    End Sub
End Class