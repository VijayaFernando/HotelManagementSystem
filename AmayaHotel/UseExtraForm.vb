Public Class UseExtraForm
    Private SQL As New LoginSQL

    Private Sub UseExtraForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SQL.Das IsNot Nothing Then
            SQL.Das.Clear()
        End If

        SQL.Run("
            SELECT  extra_services_used.*, guests.first_name, guests.last_name, extra_services.name, extra_services.type  
            FROM    extra_services_used, extra_services, guests
            WHERE   extra_services_used.guest_id = guests.guest_id AND
                    extra_services_used.extra_id = extra_services.extra_id;
        ")

        Dim index As Integer
        UseExtraTable.Items.Clear()

        For index = 0 To SQL.Das.Tables(0).Rows.Count - 1
            Dim lv As New ListViewItem
            lv.Text = SQL.Das.Tables(0).Rows(index).Item("extra_id")
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("first_name"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("last_name"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("name"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("type"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("quantity"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("extra_used_price"))
            UseExtraTable.Items.Add(lv)
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

    Private Sub SearchGuestButton_Click(sender As Object, e As EventArgs) Handles SearchGuestButton.Click
        SelectGuestForm.ShowDialog()
    End Sub

    Private Sub SearchRoomButton_Click(sender As Object, e As EventArgs) Handles SearchRoomButton.Click
        SelectExtraForm.ShowDialog()
    End Sub

    Private Sub SubQuantityButton_Click(sender As Object, e As EventArgs) Handles SubQuantityButton.Click
        If Val(QuantityTextBox.Text) = 1 Then
            QuantityTextBox.Text = Val(QuantityTextBox.Text)
        Else
            QuantityTextBox.Text = Val(QuantityTextBox.Text) - 1
            TotalPriceTextBox.Text = ServicePriceTextBox.Text * QuantityTextBox.Text
        End If
    End Sub

    Private Sub AddQuantityButton_Click(sender As Object, e As EventArgs) Handles AddQuantityButton.Click
        QuantityTextBox.Text = Val(QuantityTextBox.Text) + 1
        TotalPriceTextBox.Text = ServicePriceTextBox.Text * QuantityTextBox.Text
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        ClearTextBox(Me)
        Me.Close()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ClearTextBox(Me)
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If GuestNameTextBox.Text = "" Or ServiceNameTextBox.Text = "" Or QuantityTextBox.Text = "" Then
            MsgBox("Fill All Fields!", MsgBoxStyle.Critical)

        Else
            SQL.Run("
                INSERT INTO extra_services_used(extra_id, guest_id, quantity, extra_used_price)
                VALUES(
                    '" + ServiceIDTextBox.Text + "',
                    '" + GuestIDTextBox.Text + "',
                    '" + QuantityTextBox.Text + "',
                    '" + TotalPriceTextBox.Text + "'
                );
            ")
            MsgBox("Adding Successfull!", MsgBoxStyle.Information)
            SQL.Con.Close()
            ClearTextBox(Me)
            Me.Close()
        End If
    End Sub
End Class