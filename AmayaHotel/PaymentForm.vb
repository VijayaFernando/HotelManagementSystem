Public Class PaymentForm
    Private SQL As New LoginSQL
    Private RoomSQL As New LoginSQL
    Private ExtraSQL As New LoginSQL

    'For Accept Numbers for TextBoxes 
    Private Sub DiscountTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DiscountTextBox.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub PaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Sql.Das IsNot Nothing Then
            Sql.Das.Clear()
        End If

        SQL.Run("
            SELECT payments.*, guests.first_name, guests.last_name  
            FROM payments, guests
            WHERE payments.guest_id = guests.guest_id;")

        Dim index As Integer
        PaymentTable.Items.Clear()

        For index = 0 To Sql.Das.Tables(0).Rows.Count - 1
            Dim lv As New ListViewItem
            lv.Text = SQL.Das.Tables(0).Rows(index).Item("payment_id")
            lv.SubItems.Add(Sql.Das.Tables(0).Rows(index).Item("first_name"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("last_name"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("discount"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("total_price"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("payment_date"))
            PaymentTable.Items.Add(lv)
        Next
        Sql.Con.Close()
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

        If RoomSQL.Das IsNot Nothing Then
            ExtraSQL.Das.Clear()
        End If

        RoomSQL.Run("SELECT Count(reservation_id) As Count FROM reservations WHERE guest_id = " & GuestIDTextBox.Text)
        SQL.Run("SELECT * FROM reservations WHERE guest_id = " & GuestIDTextBox.Text)

        If RoomSQL.Das.Tables(0).Rows(0).Item("Count") = 0 Then
            MsgBox("Reservations Not Available!", MsgBoxStyle.Critical)

        ElseIf SQL.Das.Tables(0).Rows(0).Item("is_check_in") = 0 Then
            MsgBox("Guest Didn't Checked In Yet!", MsgBoxStyle.Critical)

        Else
            RoomSQL.Das.Clear()
            RoomSQL.Run("SELECT * FROM rooms WHERE room_id = " & SQL.Das.Tables(0).Rows(0).Item("room_id"))

            ExtraSQL.Run("
                SELECT  extra_services_used.*, extra_services.*  
                FROM    extra_services_used, extra_services
                WHERE   extra_services_used.extra_id = extra_services.extra_id AND
                        extra_services_used.guest_id = " & GuestIDTextBox.Text)

            RoomNumberTextBox.Text = RoomSQL.Das.Tables(0).Rows(0).Item("room_number")
            RoomPriceTextBox.Text = RoomSQL.Das.Tables(0).Rows(0).Item("room_price")

            Dim index As Integer
            Dim Price As Double = 0
            ExtraUsedListView.Items.Clear()

            For index = 0 To ExtraSQL.Das.Tables(0).Rows.Count - 1
                Dim lv As New ListViewItem
                lv.Text = ExtraSQL.Das.Tables(0).Rows(index).Item("name")
                lv.SubItems.Add(ExtraSQL.Das.Tables(0).Rows(index).Item("type"))
                lv.SubItems.Add(ExtraSQL.Das.Tables(0).Rows(index).Item("quantity"))
                lv.SubItems.Add(ExtraSQL.Das.Tables(0).Rows(index).Item("extra_used_price"))
                Price = Price + ExtraSQL.Das.Tables(0).Rows(index).Item("extra_used_price")
                ExtraUsedListView.Items.Add(lv)
            Next
            TotalExtraTextBox.Text = Price + RoomPriceTextBox.Text
        End If

        SQL.Con.Close()
        RoomSQL.Con.Close()
        ExtraSQL.Con.Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        ExtraUsedListView.Items.Clear()
        ClearTextBox(Me)
        Me.Close()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ClearTextBox(Me)
    End Sub

    Private Sub AddPaymentButton_Click(sender As Object, e As EventArgs) Handles AddPaymentButton.Click
        If SQL.Das IsNot Nothing Then
            SQL.Das.Clear()
        End If

        SQL.Run("SELECT Count(payment_id) As Count FROM payments WHERE guest_id = " & GuestIDTextBox.Text)

        If Trim(TotalPriceTextBox.Text) = "" Or Trim(RoomNumberTextBox.Text) = "" Then
            MsgBox("Fill All Fields!", MsgBoxStyle.Critical)

        ElseIf SQL.Das.Tables(0).Rows(0).Item("Count") = 0 Then
            SQL.Run("
                INSERT INTO payments(guest_id, payment_date, discount, total_price)
                VALUES(
                    '" + GuestIDTextBox.Text + "',
                    '" + Date.Now() + "',
                    '" + DiscountTextBox.Text + "',                    
                    '" + TotalPriceTextBox.Text + "'
                );
            ")
            SQL.Con.Close()
            ClearTextBox(Me)
            MsgBox("Payment Successfull!", MsgBoxStyle.Information)
            Me.Close()
        Else
            MsgBox("Payment Already Done!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub TotalPriceFillButton_Click(sender As Object, e As EventArgs) Handles TotalPriceFillButton.Click
        If Trim(DiscountTextBox.Text) = "" Then
            MsgBox("Fill Discount Value!", MsgBoxStyle.Critical)
        Else
            TotalPriceTextBox.Text = TotalExtraTextBox.Text - DiscountTextBox.Text
        End If
    End Sub

    Private Sub DiscountTextBox_TextChanged(sender As Object, e As EventArgs) Handles DiscountTextBox.TextChanged
        TotalPriceTextBox.Clear()
    End Sub

    Private Sub TotalExtraTextBox_TextChanged(sender As Object, e As EventArgs) Handles TotalExtraTextBox.TextChanged
        DiscountTextBox.Text = 0
    End Sub

    Private Sub GuestIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles GuestIDTextBox.TextChanged
        RoomNumberTextBox.Clear()
        RoomPriceTextBox.Clear()
        ExtraUsedListView.Items.Clear()
        TotalExtraTextBox.Clear()
    End Sub
End Class