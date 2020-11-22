Public Class ReservationForm
    Private SQL As New LoginSQL

    Private Sub SearchGuestButton_Click(sender As Object, e As EventArgs) Handles SearchGuestButton.Click
        SelectGuestForm.ShowDialog()
    End Sub

    Private Sub SearchRoomButton_Click(sender As Object, e As EventArgs) Handles SearchRoomButton.Click
        SelectRoomForm.ShowDialog()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelReserveButton.Click
        ClearTextBox(Me)
        Me.Close()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ClearTextBox(Me)
    End Sub

    Private Sub ReserveButton_Click(sender As Object, e As EventArgs) Handles ReserveButton.Click
        If SQL.Das IsNot Nothing Then
            SQL.Das.Clear()
        End If

        SQL.Run("SELECT COUNT(guest_id) As Count FROM reservations WHERE guest_id = " & GusetIDTextBox.Text)

        If SQL.Das.Tables(0).Rows(0).Item("Count") = 1 Then
            MsgBox("Guest Already Reserved!")
        Else
            SQL.Run(
            "INSERT INTO reservations(
	            room_id,
	            guest_id,
	            arrival_date,
	            diparture_date,
	            no_of_pax,
	            is_check_in,
	            is_check_out,
	            is_cancel,
	            reservation_date,
	            system_user_id
            )
            VALUES(" &
                RoomIDTextBox.Text & "," &
                GusetIDTextBox.Text & ", '" + CheckInDateTimePicker.Value.ToString("yyyy-MM-dd") + "' ," &
                " '" + CheckOutDateTimePicker.Value.ToString("yyyy-MM-dd") + "' ," &
                NoofPaxTextBox.Text & "," &
                "0 ,
                0 ,
                0 ,
                '" + Date.Now() + "' ," &
                "1 
            );"
            )

            SQL.Con.Close()
            MsgBox("Reservation Success!")
            ClearTextBox(Me)
            Me.Close()
        End If
        ClearTextBox(Me)
    End Sub

    Public Sub ClearTextBox(parent As Control)

        For Each child As Control In parent.Controls
            ClearTextBox(child)
        Next

        If TryCast(parent, TextBox) IsNot Nothing Then
            TryCast(parent, TextBox).Text = [String].Empty
        End If

    End Sub

    Private Sub ReservationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SQL.Das IsNot Nothing Then
            SQL.Das.Clear()
        End If

        SQL.Run("
            SELECT  reservations.*, rooms.room_number, guests.first_name, guests.last_name,system_users.username  
            FROM    reservations, rooms, guests, system_users
            WHERE   reservations.is_check_in = 0 AND reservations.is_cancel=0 AND
                    reservations.guest_id = guests.guest_id AND
                    reservations.room_id = rooms.room_id AND
                    reservations.system_user_id=system_users.system_user_id;")

        Dim index As Integer
        ReservationTable.Items.Clear()

        For index = 0 To SQL.Das.Tables(0).Rows.Count - 1
            Dim lv As New ListViewItem
            lv.Text = SQL.Das.Tables(0).Rows(index).Item("reservation_id")
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("first_name"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("last_name"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("room_number"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("arrival_date"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("diparture_date"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("no_of_pax"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("reservation_date"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("username"))
            ReservationTable.Items.Add(lv)
        Next
        SQL.Con.Close()
        ClearTextBox(Me)
    End Sub

    Private Sub SubPaxButton_Click(sender As Object, e As EventArgs) Handles SubPaxButton.Click
        If Val(NoofPaxTextBox.Text) = 0 Then
            NoofPaxTextBox.Text = Val(NoofPaxTextBox.Text)
        Else
            NoofPaxTextBox.Text = Val(NoofPaxTextBox.Text) - 1
        End If
    End Sub

    Private Sub AddPaxButton_Click(sender As Object, e As EventArgs) Handles AddPaxButton.Click
        NoofPaxTextBox.Text = Val(NoofPaxTextBox.Text) + 1
    End Sub
End Class