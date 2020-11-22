Public Class AddNewRoomForm
    Private SQL As New LoginSQL

    'For Accept Numbers for TextBoxes  
    Private Sub RoomNumberTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RoomNumberTextBox.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    'For Accept Numbers for TextBoxes 
    Private Sub PriceTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PriceTextBox.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub AddNewRoomForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub CancelNewGuestButton_Click(sender As Object, e As EventArgs) Handles CancelNewGuestButton.Click
        ClearTextBox(Me)
        Me.Close()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ClearTextBox(Me)
    End Sub

    Private Sub SearchRoomTypeButton_Click(sender As Object, e As EventArgs) Handles SearchRoomTypeButton.Click
        SelectRoomTypeForm.ShowDialog()
    End Sub

    Private Sub AddRoomButton_Click(sender As Object, e As EventArgs) Handles AddRoomButton.Click
        If Trim(RoomNumberTextBox.Text) = "" Or Trim(PriceTextBox.Text) = "" Or Trim(RoomTypeTextBox.Text) = "" Then
            MsgBox("Please Fill all Fields!", MsgBoxStyle.Critical)
        Else
            SQL.Run("
            INSERT INTO rooms(
	            room_type_id,
	            room_number,
	            room_price)
            VALUES(
	        '" + RoomTypeIDTextBox.Text + "',
	        '" + RoomNumberTextBox.Text + "',
	        '" + PriceTextBox.Text + "'
            );
            ")
            SQL.Con.Close()
            Dim r As New Integer
            MsgBox("New Room Added", MsgBoxStyle.Information)
            ClearTextBox(Me)
            Me.Close()
        End If
    End Sub
End Class