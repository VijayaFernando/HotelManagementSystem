<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.RoomPriceTextBox = New System.Windows.Forms.TextBox()
        Me.RoomPriceLabel = New System.Windows.Forms.Label()
        Me.RoomIDTextBox = New System.Windows.Forms.TextBox()
        Me.RoomIDLabel = New System.Windows.Forms.Label()
        Me.GusetIDTextBox = New System.Windows.Forms.TextBox()
        Me.GuestIDLabel = New System.Windows.Forms.Label()
        Me.CheckInDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AddPaxButton = New System.Windows.Forms.Button()
        Me.SubPaxButton = New System.Windows.Forms.Button()
        Me.SearchRoomButton = New System.Windows.Forms.Button()
        Me.SearchGuestButton = New System.Windows.Forms.Button()
        Me.CancelReserveButton = New System.Windows.Forms.Button()
        Me.ReserveButton = New System.Windows.Forms.Button()
        Me.CheckOutDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NoofPaxTextBox = New System.Windows.Forms.TextBox()
        Me.RoomTypeTextBox = New System.Windows.Forms.TextBox()
        Me.RoomNumberTextBox = New System.Windows.Forms.TextBox()
        Me.GuestNameTextBox = New System.Windows.Forms.TextBox()
        Me.CheckOutDateLabel = New System.Windows.Forms.Label()
        Me.CheckInDateLabel = New System.Windows.Forms.Label()
        Me.NoofPaxLabel = New System.Windows.Forms.Label()
        Me.RoomTypeLabel = New System.Windows.Forms.Label()
        Me.RoomNumberLabel = New System.Windows.Forms.Label()
        Me.GuestNameLabel = New System.Windows.Forms.Label()
        Me.NewCheckInLable = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ReservationListLabel = New System.Windows.Forms.Label()
        Me.ReservationTable = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.ReserveTabControl.Location = New System.Drawing.Point(13, 13)
        Me.ReserveTabControl.Margin = New System.Windows.Forms.Padding(4)
        Me.ReserveTabControl.Name = "ReserveTabControl"
        Me.ReserveTabControl.SelectedIndex = 0
        Me.ReserveTabControl.Size = New System.Drawing.Size(995, 490)
        Me.ReserveTabControl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ResetButton)
        Me.TabPage1.Controls.Add(Me.RoomPriceTextBox)
        Me.TabPage1.Controls.Add(Me.RoomPriceLabel)
        Me.TabPage1.Controls.Add(Me.RoomIDTextBox)
        Me.TabPage1.Controls.Add(Me.RoomIDLabel)
        Me.TabPage1.Controls.Add(Me.GusetIDTextBox)
        Me.TabPage1.Controls.Add(Me.GuestIDLabel)
        Me.TabPage1.Controls.Add(Me.CheckInDateTimePicker)
        Me.TabPage1.Controls.Add(Me.AddPaxButton)
        Me.TabPage1.Controls.Add(Me.SubPaxButton)
        Me.TabPage1.Controls.Add(Me.SearchRoomButton)
        Me.TabPage1.Controls.Add(Me.SearchGuestButton)
        Me.TabPage1.Controls.Add(Me.CancelReserveButton)
        Me.TabPage1.Controls.Add(Me.ReserveButton)
        Me.TabPage1.Controls.Add(Me.CheckOutDateTimePicker)
        Me.TabPage1.Controls.Add(Me.NoofPaxTextBox)
        Me.TabPage1.Controls.Add(Me.RoomTypeTextBox)
        Me.TabPage1.Controls.Add(Me.RoomNumberTextBox)
        Me.TabPage1.Controls.Add(Me.GuestNameTextBox)
        Me.TabPage1.Controls.Add(Me.CheckOutDateLabel)
        Me.TabPage1.Controls.Add(Me.CheckInDateLabel)
        Me.TabPage1.Controls.Add(Me.NoofPaxLabel)
        Me.TabPage1.Controls.Add(Me.RoomTypeLabel)
        Me.TabPage1.Controls.Add(Me.RoomNumberLabel)
        Me.TabPage1.Controls.Add(Me.GuestNameLabel)
        Me.TabPage1.Controls.Add(Me.NewCheckInLable)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(987, 461)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add Reservation"
        Me.TabPage1.UseVisualStyleBackColor = True
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
        'RoomPriceTextBox
        '
        Me.RoomPriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RoomPriceTextBox.Location = New System.Drawing.Point(212, 268)
        Me.RoomPriceTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RoomPriceTextBox.Name = "RoomPriceTextBox"
        Me.RoomPriceTextBox.ReadOnly = True
        Me.RoomPriceTextBox.Size = New System.Drawing.Size(166, 26)
        Me.RoomPriceTextBox.TabIndex = 80
        '
        'RoomPriceLabel
        '
        Me.RoomPriceLabel.AutoSize = True
        Me.RoomPriceLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RoomPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RoomPriceLabel.Location = New System.Drawing.Point(51, 270)
        Me.RoomPriceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RoomPriceLabel.Name = "RoomPriceLabel"
        Me.RoomPriceLabel.Size = New System.Drawing.Size(97, 20)
        Me.RoomPriceLabel.TabIndex = 79
        Me.RoomPriceLabel.Text = "Room Price"
        '
        'RoomIDTextBox
        '
        Me.RoomIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RoomIDTextBox.Location = New System.Drawing.Point(700, 170)
        Me.RoomIDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RoomIDTextBox.Name = "RoomIDTextBox"
        Me.RoomIDTextBox.ReadOnly = True
        Me.RoomIDTextBox.Size = New System.Drawing.Size(166, 26)
        Me.RoomIDTextBox.TabIndex = 78
        '
        'RoomIDLabel
        '
        Me.RoomIDLabel.AutoSize = True
        Me.RoomIDLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RoomIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RoomIDLabel.Location = New System.Drawing.Point(550, 170)
        Me.RoomIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RoomIDLabel.Name = "RoomIDLabel"
        Me.RoomIDLabel.Size = New System.Drawing.Size(75, 20)
        Me.RoomIDLabel.TabIndex = 77
        Me.RoomIDLabel.Text = "Room ID"
        '
        'GusetIDTextBox
        '
        Me.GusetIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GusetIDTextBox.Location = New System.Drawing.Point(700, 120)
        Me.GusetIDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GusetIDTextBox.Name = "GusetIDTextBox"
        Me.GusetIDTextBox.ReadOnly = True
        Me.GusetIDTextBox.Size = New System.Drawing.Size(166, 26)
        Me.GusetIDTextBox.TabIndex = 76
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
        'CheckInDateTimePicker
        '
        Me.CheckInDateTimePicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckInDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckInDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.CheckInDateTimePicker.Location = New System.Drawing.Point(700, 220)
        Me.CheckInDateTimePicker.Name = "CheckInDateTimePicker"
        Me.CheckInDateTimePicker.Size = New System.Drawing.Size(166, 26)
        Me.CheckInDateTimePicker.TabIndex = 74
        '
        'AddPaxButton
        '
        Me.AddPaxButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddPaxButton.Location = New System.Drawing.Point(340, 315)
        Me.AddPaxButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AddPaxButton.Name = "AddPaxButton"
        Me.AddPaxButton.Size = New System.Drawing.Size(31, 31)
        Me.AddPaxButton.TabIndex = 73
        Me.AddPaxButton.Text = ">"
        Me.AddPaxButton.UseVisualStyleBackColor = True
        '
        'SubPaxButton
        '
        Me.SubPaxButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubPaxButton.Location = New System.Drawing.Point(300, 315)
        Me.SubPaxButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SubPaxButton.Name = "SubPaxButton"
        Me.SubPaxButton.Size = New System.Drawing.Size(31, 31)
        Me.SubPaxButton.TabIndex = 71
        Me.SubPaxButton.Text = "<"
        Me.SubPaxButton.UseVisualStyleBackColor = True
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
        'CancelReserveButton
        '
        Me.CancelReserveButton.Location = New System.Drawing.Point(759, 370)
        Me.CancelReserveButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelReserveButton.Name = "CancelReserveButton"
        Me.CancelReserveButton.Size = New System.Drawing.Size(151, 43)
        Me.CancelReserveButton.TabIndex = 66
        Me.CancelReserveButton.Text = "Cancel"
        Me.CancelReserveButton.UseVisualStyleBackColor = True
        '
        'ReserveButton
        '
        Me.ReserveButton.Location = New System.Drawing.Point(350, 370)
        Me.ReserveButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ReserveButton.Name = "ReserveButton"
        Me.ReserveButton.Size = New System.Drawing.Size(151, 43)
        Me.ReserveButton.TabIndex = 65
        Me.ReserveButton.Text = "Reserve"
        Me.ReserveButton.UseVisualStyleBackColor = True
        '
        'CheckOutDateTimePicker
        '
        Me.CheckOutDateTimePicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckOutDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckOutDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.CheckOutDateTimePicker.Location = New System.Drawing.Point(700, 270)
        Me.CheckOutDateTimePicker.Name = "CheckOutDateTimePicker"
        Me.CheckOutDateTimePicker.Size = New System.Drawing.Size(166, 26)
        Me.CheckOutDateTimePicker.TabIndex = 17
        '
        'NoofPaxTextBox
        '
        Me.NoofPaxTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NoofPaxTextBox.Location = New System.Drawing.Point(212, 318)
        Me.NoofPaxTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NoofPaxTextBox.Name = "NoofPaxTextBox"
        Me.NoofPaxTextBox.ReadOnly = True
        Me.NoofPaxTextBox.Size = New System.Drawing.Size(73, 26)
        Me.NoofPaxTextBox.TabIndex = 12
        Me.NoofPaxTextBox.Text = "0"
        '
        'RoomTypeTextBox
        '
        Me.RoomTypeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RoomTypeTextBox.Location = New System.Drawing.Point(212, 218)
        Me.RoomTypeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RoomTypeTextBox.Name = "RoomTypeTextBox"
        Me.RoomTypeTextBox.ReadOnly = True
        Me.RoomTypeTextBox.Size = New System.Drawing.Size(245, 26)
        Me.RoomTypeTextBox.TabIndex = 11
        '
        'RoomNumberTextBox
        '
        Me.RoomNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RoomNumberTextBox.Location = New System.Drawing.Point(212, 168)
        Me.RoomNumberTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RoomNumberTextBox.Name = "RoomNumberTextBox"
        Me.RoomNumberTextBox.ReadOnly = True
        Me.RoomNumberTextBox.Size = New System.Drawing.Size(166, 26)
        Me.RoomNumberTextBox.TabIndex = 10
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
        'CheckOutDateLabel
        '
        Me.CheckOutDateLabel.AutoSize = True
        Me.CheckOutDateLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckOutDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckOutDateLabel.Location = New System.Drawing.Point(550, 270)
        Me.CheckOutDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CheckOutDateLabel.Name = "CheckOutDateLabel"
        Me.CheckOutDateLabel.Size = New System.Drawing.Size(129, 20)
        Me.CheckOutDateLabel.TabIndex = 7
        Me.CheckOutDateLabel.Text = "Check Out Date"
        '
        'CheckInDateLabel
        '
        Me.CheckInDateLabel.AutoSize = True
        Me.CheckInDateLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckInDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckInDateLabel.Location = New System.Drawing.Point(550, 220)
        Me.CheckInDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CheckInDateLabel.Name = "CheckInDateLabel"
        Me.CheckInDateLabel.Size = New System.Drawing.Size(115, 20)
        Me.CheckInDateLabel.TabIndex = 6
        Me.CheckInDateLabel.Text = "Check In Date"
        '
        'NoofPaxLabel
        '
        Me.NoofPaxLabel.AutoSize = True
        Me.NoofPaxLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NoofPaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NoofPaxLabel.Location = New System.Drawing.Point(51, 320)
        Me.NoofPaxLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NoofPaxLabel.Name = "NoofPaxLabel"
        Me.NoofPaxLabel.Size = New System.Drawing.Size(82, 20)
        Me.NoofPaxLabel.TabIndex = 4
        Me.NoofPaxLabel.Text = "No of Pax"
        '
        'RoomTypeLabel
        '
        Me.RoomTypeLabel.AutoSize = True
        Me.RoomTypeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RoomTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RoomTypeLabel.Location = New System.Drawing.Point(51, 220)
        Me.RoomTypeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RoomTypeLabel.Name = "RoomTypeLabel"
        Me.RoomTypeLabel.Size = New System.Drawing.Size(94, 20)
        Me.RoomTypeLabel.TabIndex = 3
        Me.RoomTypeLabel.Text = "Room Type"
        '
        'RoomNumberLabel
        '
        Me.RoomNumberLabel.AutoSize = True
        Me.RoomNumberLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RoomNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RoomNumberLabel.Location = New System.Drawing.Point(51, 170)
        Me.RoomNumberLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RoomNumberLabel.Name = "RoomNumberLabel"
        Me.RoomNumberLabel.Size = New System.Drawing.Size(117, 20)
        Me.RoomNumberLabel.TabIndex = 2
        Me.RoomNumberLabel.Text = "Room Number"
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
        Me.NewCheckInLable.Size = New System.Drawing.Size(205, 29)
        Me.NewCheckInLable.TabIndex = 0
        Me.NewCheckInLable.Text = "New Reservation"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReservationListLabel)
        Me.TabPage2.Controls.Add(Me.ReservationTable)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(987, 461)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Resevation List"
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
        'ReservationTable
        '
        Me.ReservationTable.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader9, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ReservationTable.FullRowSelect = True
        Me.ReservationTable.GridLines = True
        Me.ReservationTable.HideSelection = False
        Me.ReservationTable.Location = New System.Drawing.Point(19, 65)
        Me.ReservationTable.Margin = New System.Windows.Forms.Padding(4)
        Me.ReservationTable.Name = "ReservationTable"
        Me.ReservationTable.Size = New System.Drawing.Size(948, 378)
        Me.ReservationTable.TabIndex = 1
        Me.ReservationTable.UseCompatibleStateImageBehavior = False
        Me.ReservationTable.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Reserve ID"
        Me.ColumnHeader1.Width = 70
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Guest First Name"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Guest Last Name"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Room #"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Checkin Date"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Checkout Date"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "No of Pax"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 70
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Reserve Date"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Reserved By"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 100
        '
        'ReservationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 521)
        Me.Controls.Add(Me.ReserveTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ReservationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservations"
        Me.ReserveTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReserveTabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents NewCheckInLable As Label
    Friend WithEvents GuestNameLabel As Label
    Friend WithEvents RoomNumberLabel As Label
    Friend WithEvents NoofPaxTextBox As TextBox
    Friend WithEvents RoomTypeTextBox As TextBox
    Friend WithEvents RoomNumberTextBox As TextBox
    Friend WithEvents GuestNameTextBox As TextBox
    Friend WithEvents CheckOutDateLabel As Label
    Friend WithEvents CheckInDateLabel As Label
    Friend WithEvents NoofPaxLabel As Label
    Friend WithEvents RoomTypeLabel As Label
    Friend WithEvents CancelReserveButton As Button
    Friend WithEvents ReserveButton As Button
    Friend WithEvents CheckOutDateTimePicker As DateTimePicker
    Friend WithEvents AddPaxButton As Button
    Friend WithEvents SubPaxButton As Button
    Friend WithEvents SearchRoomButton As Button
    Friend WithEvents SearchGuestButton As Button
    Friend WithEvents ReservationTable As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ReservationListLabel As Label
    Friend WithEvents GusetIDTextBox As TextBox
    Friend WithEvents GuestIDLabel As Label
    Friend WithEvents CheckInDateTimePicker As DateTimePicker
    Friend WithEvents RoomIDTextBox As TextBox
    Friend WithEvents RoomIDLabel As Label
    Friend WithEvents RoomPriceTextBox As TextBox
    Friend WithEvents RoomPriceLabel As Label
    Friend WithEvents ResetButton As Button
    Friend WithEvents ColumnHeader9 As ColumnHeader
End Class
