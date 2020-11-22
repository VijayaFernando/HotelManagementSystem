Public Class AddNewRoomTypeForm
    Private SQL As New LoginSQL

    'For Accept Numbers for TextBoxes  
    Private Sub NoOfRoomsTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NoOfRoomsTextBox.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub AddNewRoomTypeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayRoomTypes()
    End Sub

    Private Sub DisplayRoomTypes()
        If SQL.Das IsNot Nothing Then
            SQL.Das.Clear()
        End If

        SQL.Run("SELECT *  FROM room_type")
        Dim index As Integer
        RoomTable.Items.Clear()

        For index = 0 To SQL.Das.Tables(0).Rows.Count - 1
            Dim lv As New ListViewItem
            lv.Text = SQL.Das.Tables(0).Rows(index).Item("room_type_id")
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("room_type_name"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("facilities"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("no_of_rooms"))
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

    Private Sub AddRoomButton_Click(sender As Object, e As EventArgs) Handles AddRoomButton.Click
        If SQL.Das IsNot Nothing Then
            SQL.Das.Clear()
        End If

        SQL.Run("SELECT Count(room_type_id) As Count FROM room_type WHERE room_type_name =  '" + RoomTypeTextBox.Text + "' ;")

        If Trim(RoomTypeTextBox.Text) = "" Or Trim(NoOfRoomsTextBox.Text) = "" Or Trim(FacilitiesTextBox.Text) = "" Then
            MsgBox("Fill All Fields!", MsgBoxStyle.Critical)

        ElseIf SQL.Das.Tables(0).Rows(0).Item("Count") = 0 Then
            SQL.Run("
               INSERT INTO  room_type(
                    facilities,
	                room_type_name,
	                no_of_rooms
                )
                VALUES(
                    '" + FacilitiesTextBox.Text + "',
                    '" + RoomTypeTextBox.Text + "',
                    '" + NoOfRoomsTextBox.Text + "'
                );
            ")
            MsgBox("New Room Type Added!", MsgBoxStyle.Information)
            SQL.Con.Close()
            ClearTextBox(Me)
            Me.Close()
        Else
            MsgBox("Room Type Already Exists!", MsgBoxStyle.Critical)
        End If
        SQL.Con.Close()
    End Sub
End Class