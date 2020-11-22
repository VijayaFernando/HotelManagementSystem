Public Class AddNewExtraForm
    Private SQL As New LoginSQL

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

    Private Sub AddNewExtraForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SQL.Das IsNot Nothing Then
            SQL.Das.Clear()
        End If

        SQL.Run("SELECT * FROM extra_services;")

        Dim index As Integer
        ExtraTable.Items.Clear()

        For index = 0 To Sql.Das.Tables(0).Rows.Count - 1
            Dim lv As New ListViewItem
            lv.Text = SQL.Das.Tables(0).Rows(index).Item("extra_id")
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("name"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("type"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("extra_price"))
            ExtraTable.Items.Add(lv)
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

    Private Sub CancelNewExtraButton_Click(sender As Object, e As EventArgs) Handles CancelNewExtraButton.Click
        ClearTextBox(Me)
        Me.Close()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ClearTextBox(Me)
    End Sub

    Private Sub AddNewExtraButton_Click(sender As Object, e As EventArgs) Handles AddNewExtraButton.Click
        SQL.Run("
            INSERT INTO extra_services(name, type, extra_price)
            VALUES(
                '" + ExtraNameTextBox.Text + "',
                '" + ExtraTypeComboBox.Text + "',
                '" + PriceTextBox.Text + "'
            );
        ")
        SQL.Con.Close()
        MsgBox("New Extra Service Added!", MsgBoxStyle.Information)
        ClearTextBox(Me)
        Me.Close()
    End Sub
End Class