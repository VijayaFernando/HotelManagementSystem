Public Class SelectExtraForm
    Private SQL As New LoginSQL
    Private Sub SelectExtraForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayGuest()
    End Sub

    Private Sub DisplayGuest()
        If SQL.Das IsNot Nothing Then
            SQL.Das.Clear()
        End If

        SQL.Run("SELECT * FROM extra_services;")
        Dim index As Integer
        ExtraTable.Items.Clear()

        For index = 0 To SQL.Das.Tables(0).Rows.Count - 1
            Dim lv As New ListViewItem
            lv.Text = SQL.Das.Tables(0).Rows(index).Item("extra_id")
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("name"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("type"))
            lv.SubItems.Add(SQL.Das.Tables(0).Rows(index).Item("extra_price"))
            ExtraTable.Items.Add(lv)
        Next
        SQL.Con.Close()
    End Sub

    Private Sub ExtraTable_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExtraTable.DoubleClick
        UseExtraForm.ServiceIDTextBox.Text = ExtraTable.SelectedItems(0).Text
        UseExtraForm.ServiceNameTextBox.Text = ExtraTable.SelectedItems(0).SubItems(1).Text
        UseExtraForm.ServiceTypeTextBox.Text = ExtraTable.SelectedItems(0).SubItems(2).Text
        UseExtraForm.ServicePriceTextBox.Text = ExtraTable.SelectedItems(0).SubItems(3).Text
        Me.Close()
    End Sub
End Class