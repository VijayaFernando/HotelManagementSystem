Public Class AddNewGuestForm
    Private SQL As New LoginSQL

    'For Accept Numbers for TextBoxes 
    Private Sub AgeTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AgeTextBox.KeyPress

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
    Private Sub TelephoneTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TelephoneTextBox.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub AddNewGuestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SQL.Das IsNot Nothing Then
            SQL.Das.Clear()
        End If

        SQL.Run("SELECT * FROM guests")

        Dim index As Integer
        GuestTable.Items.Clear()

        For index = 0 To SQL.Das.Tables(0).Rows.Count - 1
            Dim lv As New ListViewItem
            lv.Text = SQL.Das.Tables(0).Rows(index).Item("guest_id")
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("first_name"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("last_name"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("address"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("age"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("sex"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("phone_number"))
            GuestTable.Items.Add(lv)
        Next
        SQL.Con.Close()
        ClearTextBox(Me)
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelGuestButton.Click
        ClearTextBox(Me)
        Me.Close()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ClearTextBox(Me)
    End Sub

    Private Sub AddNewGuestButton_Click(sender As Object, e As EventArgs) Handles AddNewGuestButton.Click
        If Trim(FirstNameTextBox.Text) = "" Then
            MsgBox("Enter Guests' Name!", MsgBoxStyle.Critical)
        Else
            SQL.Run("
                INSERT INTO guests(
	                first_name,
	                last_name,
	                address,
	                age,
	                sex,
	                phone_number)
                VALUES(
                    '" + FirstNameTextBox.Text + "',  
                    '" + LastNameTextBox.Text + "' ,
                    '" + AddressTextBox.Text + "' ,
                    '" + AgeTextBox.Text + "' ,
                    '" + SexComboBox.Text + "' ,
                    '" + TelephoneTextBox.Text + "');"
            )

            SQL.Con.Close()
            MsgBox("New Guest Added", MsgBoxStyle.Information)
            ClearTextBox(Me)
            Me.Close()
        End If
    End Sub

    Public Sub ClearTextBox(parent As Control)
        For Each child As Control In parent.Controls
            ClearTextBox(child)
        Next

        If TryCast(parent, TextBox) IsNot Nothing Then
            TryCast(parent, TextBox).Text = [String].Empty
        End If
    End Sub

End Class