Public Class CheckOutForm
    Private SQL As New LoginSQL
    Private RoomSQL As New LoginSQL
    Private RoomTypeSQL As New LoginSQL

    Private Sub CancelButtonCheckIn_Click(sender As Object, e As EventArgs) Handles CancelButtonCheckIn.Click
        ClearTextBox(Me)
        Me.Close()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ClearTextBox(Me)
    End Sub

    Private Sub CheckOutButton_Click(sender As Object, e As EventArgs) Handles CheckOutButton.Click
        If Trim(RoomNumberTextBox.Text) = "" Then
            MsgBox("Please Select a Room", MsgBoxStyle.Critical)
        Else
            SQL.Run("UPDATE reservations SET is_check_out = REPLACE(is_check_out, 0,1)")
            SQL.Con.Close()
            MsgBox("Checked Out Success!", MsgBoxStyle.Information)
            SQL.Con.Close()
            ClearTextBox(Me)
            Me.Close()
        End If
    End Sub

    Private Sub SearchGuestButton_Click(sender As Object, e As EventArgs) Handles SearchGuestButton.Click
        SelectGuestForm.ShowDialog()
    End Sub

    Private Sub FillButton_Click(sender As Object, e As EventArgs) Handles FillButton.Click
        If Trim(GuestNameTextBox.Text) = "" Then
            MsgBox("Please Select a Guest!", MsgBoxStyle.Critical)
        Else
            DisplayRooms()
        End If
    End Sub

    Private Sub DisplayRooms()
        If SQL.Das IsNot Nothing Then
            SQL.Das.Clear()
        End If

        If RoomSQL.Das IsNot Nothing Then
            RoomSQL.Das.Clear()
        End If

        If RoomTypeSQL.Das IsNot Nothing Then
            RoomTypeSQL.Das.Clear()
        End If

        RoomSQL.Run("SELECT Count(reservation_id) As Count FROM reservations WHERE guest_id = " & GuestIDTextBox.Text)
        SQL.Run("SELECT * FROM reservations WHERE guest_id = " & GuestIDTextBox.Text)

        If RoomSQL.Das.Tables(0).Rows(0).Item("Count") = 0 Then
            MsgBox("Reservations Not Available!", MsgBoxStyle.Information)

        ElseIf SQL.Das.Tables(0).Rows(0).Item("is_check_in") = 0 Then
            MsgBox("Guest Did not Check In!", MsgBoxStyle.Critical)

        ElseIf SQL.Das.Tables(0).Rows(0).Item("is_check_out") = 1 Then
            MsgBox("Guest Already Checked Out!", MsgBoxStyle.Critical)

        Else
            RoomSQL.Das.Clear()
            RoomSQL.Run("SELECT * FROM rooms WHERE room_id =" & SQL.Das.Tables(0).Rows(0).Item("room_id"))
            RoomTypeSQL.Run("SELECT * FROM room_type WHERE room_type_id =" & RoomSQL.Das.Tables(0).Rows(0).Item("room_type_id"))

            RoomNumberTextBox.Text = RoomSQL.Das.Tables(0).Rows(0).Item("room_number")
            RoomTypeTextBox.Text = RoomTypeSQL.Das.Tables(0).Rows(0).Item("room_type_name")
            NoofPaxTextBox.Text = SQL.Das.Tables(0).Rows(0).Item("no_of_pax")
            CheckInDateTextBox.Text = SQL.Das.Tables(0).Rows(0).Item("arrival_date")
            CheckOutTextBox.Text = SQL.Das.Tables(0).Rows(0).Item("diparture_date")
            ReserveDateTextBox.Text = SQL.Das.Tables(0).Rows(0).Item("reservation_date")

        End If
        RoomSQL.Con.Close()
        RoomTypeSQL.Con.Close()
        SQL.Con.Close()
    End Sub

    Public Sub ClearTextBox(parent As Control)

        For Each child As Control In parent.Controls
            ClearTextBox(child)
        Next

        If TryCast(parent, TextBox) IsNot Nothing Then
            TryCast(parent, TextBox).Text = [String].Empty
        End If

    End Sub

    Private Sub CheckOutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SQL.Das IsNot Nothing Then
            SQL.Das.Clear()
        End If

        SQL.Run("
            SELECT  reservations.*, guests.first_name, rooms.room_number 
            FROM    reservations, guests, rooms 
            WHERE   reservations.is_check_out = 1 AND
                    reservations.guest_id = guests.guest_id AND
                    reservations.room_id = rooms.room_id
        ")

        Dim index As Integer
        CheckInTable.Items.Clear()

        For index = 0 To SQL.Das.Tables(0).Rows.Count - 1
            Dim lv As New ListViewItem
            lv.Text = SQL.Das.Tables(0).Rows(index).Item("reservation_id")
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("first_name"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("room_number"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("arrival_date"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("diparture_date"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("no_of_pax"))
            CheckInTable.Items.Add(lv)
        Next
        SQL.Con.Close()
        ClearTextBox(Me)
    End Sub
End Class