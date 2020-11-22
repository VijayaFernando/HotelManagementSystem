<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UseExtraForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ReserveTabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TotalPriceTextBox = New System.Windows.Forms.TextBox()
        Me.TotalPriceLabel = New System.Windows.Forms.Label()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.ServicePriceTextBox = New System.Windows.Forms.TextBox()
        Me.ServicePriceLabel = New System.Windows.Forms.Label()
        Me.ServiceTypeTextBox = New System.Windows.Forms.TextBox()
        Me.ServiceTypeLabel = New System.Windows.Forms.Label()
        Me.GuestIDTextBox = New System.Windows.Forms.TextBox()
        Me.GuestIDLabel = New System.Windows.Forms.Label()
        Me.AddQuantityButton = New System.Windows.Forms.Button()
        Me.SubQuantityButton = New System.Windows.Forms.Button()
        Me.SearchRoomButton = New System.Windows.Forms.Button()
        Me.SearchGuestButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.ServiceNameTextBox = New System.Windows.Forms.TextBox()
        Me.GuestNameTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityLabel = New System.Windows.Forms.Label()
        Me.ServiceNameLabel = New System.Windows.Forms.Label()
        Me.GuestNameLabel = New System.Windows.Forms.Label()
        Me.NewCheckInLable = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ReservationListLabel = New System.Windows.Forms.Label()
        Me.UseExtraTable = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ServiceIDLabel = New System.Windows.Forms.Label()
        Me.ServiceIDTextBox = New System.Windows.Forms.TextBox()
        Me.ReserveTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReserveTabControl
        '
        Me.ReserveTabControl.Controls.Add(Me.TabPage1)
        Me.ReserveTabControl.Controls.Add(Me.TabPage2)
        Me.ReserveTabControl.ItemSize = New System.Drawing.Size(97, 21)
        Me.ReserveTabControl.Location = New System.Drawing.Point(14, 19)
        Me.ReserveTabControl.Margin = New System.Windows.Forms.Padding(4)
        Me.ReserveTabControl.Name = "ReserveTabControl"
        Me.ReserveTabControl.SelectedIndex = 0
        Me.ReserveTabControl.Size = New System.Drawing.Size(995, 490)
        Me.ReserveTabControl.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ServiceIDTextBox)
        Me.TabPage1.Controls.Add(Me.ServiceIDLabel)
        Me.TabPage1.Controls.Add(Me.TotalPriceTextBox)
        Me.TabPage1.Controls.Add(Me.TotalPriceLabel)
        Me.TabPage1.Controls.Add(Me.ResetButton)
        Me.TabPage1.Controls.Add(Me.ServicePriceTextBox)
        Me.TabPage1.Controls.Add(Me.ServicePriceLabel)
        Me.TabPage1.Controls.Add(Me.ServiceTypeTextBox)
        Me.TabPage1.Controls.Add(Me.ServiceTypeLabel)
        Me.TabPage1.Controls.Add(Me.GuestIDTextBox)
        Me.TabPage1.Controls.Add(Me.GuestIDLabel)
        Me.TabPage1.Controls.Add(Me.AddQuantityButton)
        Me.TabPage1.Controls.Add(Me.SubQuantityButton)
        Me.TabPage1.Controls.Add(Me.SearchRoomButton)
        Me.TabPage1.Controls.Add(Me.SearchGuestButton)
        Me.TabPage1.Controls.Add(Me.CancelButton)
        Me.TabPage1.Controls.Add(Me.AddButton)
        Me.TabPage1.Controls.Add(Me.QuantityTextBox)
        Me.TabPage1.Controls.Add(Me.ServiceNameTextBox)
        Me.TabPage1.Controls.Add(Me.GuestNameTextBox)
        Me.TabPage1.Controls.Add(Me.QuantityLabel)
        Me.TabPage1.Controls.Add(Me.ServiceNameLabel)
        Me.TabPage1.Controls.Add(Me.GuestNameLabel)
        Me.TabPage1.Controls.Add(Me.NewCheckInLable)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(987, 461)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Use Extra"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TotalPriceTextBox
        '
        Me.TotalPriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TotalPriceTextBox.Location = New System.Drawing.Point(700, 288)
        Me.TotalPriceTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalPriceTextBox.Name = "TotalPriceTextBox"
        Me.TotalPriceTextBox.ReadOnly = True
        Me.TotalPriceTextBox.Size = New System.Drawing.Size(166, 26)
        Me.TotalPriceTextBox.TabIndex = 83
        '
        'TotalPriceLabel
        '
        Me.TotalPriceLabel.AutoSize = True
        Me.TotalPriceLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TotalPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TotalPriceLabel.Location = New System.Drawing.Point(550, 290)
        Me.TotalPriceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalPriceLabel.Name = "TotalPriceLabel"
        Me.TotalPriceLabel.Size = New System.Drawing.Size(90, 20)
        Me.TotalPriceLabel.TabIndex = 82
        Me.TotalPriceLabel.Text = "Total Price"
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(550, 370)
        Me.ResetButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(151, 43)
        Me.ResetButton.TabIndex = 81
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'ServicePriceTextBox
        '
        Me.ServicePriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ServicePriceTextBox.Location = New System.Drawing.Point(212, 218)
        Me.ServicePriceTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ServicePriceTextBox.Name = "ServicePriceTextBox"
        Me.ServicePriceTextBox.ReadOnly = True
        Me.ServicePriceTextBox.Size = New System.Drawing.Size(166, 26)
        Me.ServicePriceTextBox.TabIndex = 80
        '
        'ServicePriceLabel
        '
        Me.ServicePriceLabel.AutoSize = True
        Me.ServicePriceLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ServicePriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ServicePriceLabel.Location = New System.Drawing.Point(51, 220)
        Me.ServicePriceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ServicePriceLabel.Name = "ServicePriceLabel"
        Me.ServicePriceLabel.Size = New System.Drawing.Size(109, 20)
        Me.ServicePriceLabel.TabIndex = 79
        Me.ServicePriceLabel.Text = "Service Price"
        '
        'ServiceTypeTextBox
        '
        Me.ServiceTypeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ServiceTypeTextBox.Location = New System.Drawing.Point(700, 167)
        Me.ServiceTypeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ServiceTypeTextBox.Name = "ServiceTypeTextBox"
        Me.ServiceTypeTextBox.ReadOnly = True
        Me.ServiceTypeTextBox.Size = New System.Drawing.Size(166, 26)
        Me.ServiceTypeTextBox.TabIndex = 78
        '
        'ServiceTypeLabel
        '
        Me.ServiceTypeLabel.AutoSize = True
        Me.ServiceTypeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ServiceTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ServiceTypeLabel.Location = New System.Drawing.Point(550, 170)
        Me.ServiceTypeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ServiceTypeLabel.Name = "ServiceTypeLabel"
        Me.ServiceTypeLabel.Size = New System.Drawing.Size(106, 20)
        Me.ServiceTypeLabel.TabIndex = 77
        Me.ServiceTypeLabel.Text = "Service Type"
        '
        'GuestIDTextBox
        '
        Me.GuestIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GuestIDTextBox.Location = New System.Drawing.Point(700, 120)
        Me.GuestIDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GuestIDTextBox.Name = "GuestIDTextBox"
        Me.GuestIDTextBox.ReadOnly = True
        Me.GuestIDTextBox.Size = New System.Drawing.Size(166, 26)
        Me.GuestIDTextBox.TabIndex = 76
        '
        'GuestIDLabel
        '
        Me.GuestIDLabel.AutoSize = True
        Me.GuestIDLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GuestIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GuestIDLabel.Location = New System.Drawing.Point(550, 120)
        Me.GuestIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GuestIDLabel.Name = "GuestIDLabel"
        Me.GuestIDLabel.Size = New System.Drawing.Size(76, 20)
        Me.GuestIDLabel.TabIndex = 75
        Me.GuestIDLabel.Text = "Guest ID"
        '
        'AddQuantityButton
        '
        Me.AddQuantityButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddQuantityButton.Location = New System.Drawing.Point(340, 285)
        Me.AddQuantityButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AddQuantityButton.Name = "AddQuantityButton"
        Me.AddQuantityButton.Size = New System.Drawing.Size(31, 31)
        Me.AddQuantityButton.TabIndex = 73
        Me.AddQuantityButton.Text = ">"
        Me.AddQuantityButton.UseVisualStyleBackColor = True
        '
        'SubQuantityButton
        '
        Me.SubQuantityButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubQuantityButton.Location = New System.Drawing.Point(300, 285)
        Me.SubQuantityButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SubQuantityButton.Name = "SubQuantityButton"
        Me.SubQuantityButton.Size = New System.Drawing.Size(31, 31)
        Me.SubQuantityButton.TabIndex = 71
        Me.SubQuantityButton.Text = "<"
        Me.SubQuantityButton.UseVisualStyleBackColor = True
        '
        'SearchRoomButton
        '
        Me.SearchRoomButton.Location = New System.Drawing.Point(390, 164)
        Me.SearchRoomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchRoomButton.Name = "SearchRoomButton"
        Me.SearchRoomButton.Size = New System.Drawing.Size(40, 32)
        Me.SearchRoomButton.TabIndex = 68
        Me.SearchRoomButton.Text = "..."
        Me.SearchRoomButton.UseVisualStyleBackColor = True
        '
        'SearchGuestButton
        '
        Me.SearchGuestButton.Location = New System.Drawing.Point(464, 115)
        Me.SearchGuestButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchGuestButton.Name = "SearchGuestButton"
        Me.SearchGuestButton.Size = New System.Drawing.Size(40, 32)
        Me.SearchGuestButton.TabIndex = 67
        Me.SearchGuestButton.Text = "..."
        Me.SearchGuestButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(759, 370)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(151, 43)
        Me.CancelButton.TabIndex = 66
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(350, 370)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(151, 43)
        Me.AddButton.TabIndex = 65
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.QuantityTextBox.Location = New System.Drawing.Point(212, 288)
        Me.QuantityTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.ReadOnly = True
        Me.QuantityTextBox.Size = New System.Drawing.Size(73, 26)
        Me.QuantityTextBox.TabIndex = 12
        Me.QuantityTextBox.Text = "1"
        '
        'ServiceNameTextBox
        '
        Me.ServiceNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ServiceNameTextBox.Location = New System.Drawing.Point(212, 168)
        Me.ServiceNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ServiceNameTextBox.Name = "ServiceNameTextBox"
        Me.ServiceNameTextBox.ReadOnly = True
        Me.ServiceNameTextBox.Size = New System.Drawing.Size(166, 26)
        Me.ServiceNameTextBox.TabIndex = 10
        '
        'GuestNameTextBox
        '
        Me.GuestNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GuestNameTextBox.Location = New System.Drawing.Point(212, 118)
        Me.GuestNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GuestNameTextBox.Name = "GuestNameTextBox"
        Me.GuestNameTextBox.ReadOnly = True
        Me.GuestNameTextBox.Size = New System.Drawing.Size(245, 26)
        Me.GuestNameTextBox.TabIndex = 9
        '
        'QuantityLabel
        '
        Me.QuantityLabel.AutoSize = True
        Me.QuantityLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.QuantityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.QuantityLabel.Location = New System.Drawing.Point(51, 290)
        Me.QuantityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.QuantityLabel.Name = "QuantityLabel"
        Me.QuantityLabel.Size = New System.Drawing.Size(71, 20)
        Me.QuantityLabel.TabIndex = 4
        Me.QuantityLabel.Text = "Quantity"
        '
        'ServiceNameLabel
        '
        Me.ServiceNameLabel.AutoSize = True
        Me.ServiceNameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ServiceNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ServiceNameLabel.Location = New System.Drawing.Point(51, 170)
        Me.ServiceNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ServiceNameLabel.Name = "ServiceNameLabel"
        Me.ServiceNameLabel.Size = New System.Drawing.Size(114, 20)
        Me.ServiceNameLabel.TabIndex = 2
        Me.ServiceNameLabel.Text = "Service Name"
        '
        'GuestNameLabel
        '
        Me.GuestNameLabel.AutoSize = True
        Me.GuestNameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GuestNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GuestNameLabel.Location = New System.Drawing.Point(51, 120)
        Me.GuestNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GuestNameLabel.Name = "GuestNameLabel"
        Me.GuestNameLabel.Size = New System.Drawing.Size(103, 20)
        Me.GuestNameLabel.TabIndex = 1
        Me.GuestNameLabel.Text = "Guest Name"
        '
        'NewCheckInLable
        '
        Me.NewCheckInLable.AutoSize = True
        Me.NewCheckInLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.NewCheckInLable.Location = New System.Drawing.Point(36, 34)
        Me.NewCheckInLable.Name = "NewCheckInLable"
        Me.NewCheckInLable.Size = New System.Drawing.Size(215, 29)
        Me.NewCheckInLable.TabIndex = 0
        Me.NewCheckInLable.Text = "Use Extra Service"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReservationListLabel)
        Me.TabPage2.Controls.Add(Me.UseExtraTable)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(987, 461)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Use Extra List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ReservationListLabel
        '
        Me.ReservationListLabel.AutoEllipsis = True
        Me.ReservationListLabel.AutoSize = True
        Me.ReservationListLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReservationListLabel.Location = New System.Drawing.Point(13, 30)
        Me.ReservationListLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ReservationListLabel.Name = "ReservationListLabel"
        Me.ReservationListLabel.Size = New System.Drawing.Size(200, 29)
        Me.ReservationListLabel.TabIndex = 41
        Me.ReservationListLabel.Text = "Reservation List"
        '
        'UseExtraTable
        '
        Me.UseExtraTable.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader9, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.UseExtraTable.FullRowSelect = True
        Me.UseExtraTable.GridLines = True
        Me.UseExtraTable.HideSelection = False
        Me.UseExtraTable.Location = New System.Drawing.Point(19, 65)
        Me.UseExtraTable.Margin = New System.Windows.Forms.Padding(4)
        Me.UseExtraTable.Name = "UseExtraTable"
        Me.UseExtraTable.Size = New System.Drawing.Size(948, 378)
        Me.UseExtraTable.TabIndex = 1
        Me.UseExtraTable.UseCompatibleStateImageBehavior = False
        Me.UseExtraTable.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 50
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "First Name"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Last Name"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Service Name"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Service Type"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Quantity"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Price"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ServiceIDLabel
        '
        Me.ServiceIDLabel.AutoSize = True
        Me.ServiceIDLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ServiceIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ServiceIDLabel.Location = New System.Drawing.Point(550, 220)
        Me.ServiceIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ServiceIDLabel.Name = "ServiceIDLabel"
        Me.ServiceIDLabel.Size = New System.Drawing.Size(87, 20)
        Me.ServiceIDLabel.TabIndex = 84
        Me.ServiceIDLabel.Text = "Service ID"
        '
        'ServiceIDTextBox
        '
        Me.ServiceIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ServiceIDTextBox.Location = New System.Drawing.Point(700, 220)
        Me.ServiceIDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ServiceIDTextBox.Name = "ServiceIDTextBox"
        Me.ServiceIDTextBox.ReadOnly = True
        Me.ServiceIDTextBox.Size = New System.Drawing.Size(166, 26)
        Me.ServiceIDTextBox.TabIndex = 85
        '
        'UseExtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 528)
        Me.Controls.Add(Me.ReserveTabControl)
        Me.Name = "UseExtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Use Extra Services Form"
        Me.ReserveTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReserveTabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ResetButton As Button
    Friend WithEvents ServicePriceTextBox As TextBox
    Friend WithEvents ServicePriceLabel As Label
    Friend WithEvents ServiceTypeTextBox As TextBox
    Friend WithEvents ServiceTypeLabel As Label
    Friend WithEvents GuestIDTextBox As TextBox
    Friend WithEvents GuestIDLabel As Label
    Friend WithEvents AddQuantityButton As Button
    Friend WithEvents SubQuantityButton As Button
    Friend WithEvents SearchRoomButton As Button
    Friend WithEvents SearchGuestButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents ServiceNameTextBox As TextBox
    Friend WithEvents GuestNameTextBox As TextBox
    Friend WithEvents QuantityLabel As Label
    Friend WithEvents ServiceNameLabel As Label
    Friend WithEvents GuestNameLabel As Label
    Friend WithEvents NewCheckInLable As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ReservationListLabel As Label
    Friend WithEvents UseExtraTable As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents TotalPriceTextBox As TextBox
    Friend WithEvents TotalPriceLabel As Label
    Friend WithEvents ServiceIDTextBox As TextBox
    Friend WithEvents ServiceIDLabel As Label
End Class
