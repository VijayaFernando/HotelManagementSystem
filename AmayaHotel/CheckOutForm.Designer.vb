<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckOutForm
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CheckOutTabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.FillButton = New System.Windows.Forms.Button()
        Me.GuestIDTextBox = New System.Windows.Forms.TextBox()
        Me.GuestIDLabel = New System.Windows.Forms.Label()
        Me.CheckOutTextBox = New System.Windows.Forms.TextBox()
        Me.SearchGuestButton = New System.Windows.Forms.Button()
        Me.CancelButtonCheckIn = New System.Windows.Forms.Button()
        Me.CheckOutButton = New System.Windows.Forms.Button()
        Me.ReserveDateTextBox = New System.Windows.Forms.TextBox()
        Me.CheckInDateTextBox = New System.Windows.Forms.TextBox()
        Me.NoofPaxTextBox = New System.Windows.Forms.TextBox()
        Me.RoomTypeTextBox = New System.Windows.Forms.TextBox()
        Me.RoomNumberTextBox = New System.Windows.Forms.TextBox()
        Me.GuestNameTextBox = New System.Windows.Forms.TextBox()
        Me.NoofDaysLabel = New System.Windows.Forms.Label()
        Me.CheckOutDateLabel = New System.Windows.Forms.Label()
        Me.CheckInDateLabel = New System.Windows.Forms.Label()
        Me.NoofPaxLabel = New System.Windows.Forms.Label()
        Me.RoomTypeLabel = New System.Windows.Forms.Label()
        Me.RoomNumberLabel = New System.Windows.Forms.Label()
        Me.GuestNameLabel = New System.Windows.Forms.Label()
        Me.NewCheckOutLable = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CheckOutListLabel = New System.Windows.Forms.Label()
        Me.CheckInTable = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CheckOutTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckOutTabControl
        '
        Me.CheckOutTabControl.Controls.Add(Me.TabPage1)
        Me.CheckOutTabControl.Controls.Add(Me.TabPage2)
        Me.CheckOutTabControl.ItemSize = New System.Drawing.Size(97, 21)
        Me.CheckOutTabControl.Location = New System.Drawing.Point(15, 15)
        Me.CheckOutTabControl.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckOutTabControl.Name = "CheckOutTabControl"
        Me.CheckOutTabControl.SelectedIndex = 0
        Me.CheckOutTabControl.Size = New System.Drawing.Size(995, 490)
        Me.CheckOutTabControl.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ResetButton)
        Me.TabPage1.Controls.Add(Me.FillButton)
        Me.TabPage1.Controls.Add(Me.GuestIDTextBox)
        Me.TabPage1.Controls.Add(Me.GuestIDLabel)
        Me.TabPage1.Controls.Add(Me.CheckOutTextBox)
        Me.TabPage1.Controls.Add(Me.SearchGuestButton)
        Me.TabPage1.Controls.Add(Me.CancelButtonCheckIn)
        Me.TabPage1.Controls.Add(Me.CheckOutButton)
        Me.TabPage1.Controls.Add(Me.ReserveDateTextBox)
        Me.TabPage1.Controls.Add(Me.CheckInDateTextBox)
        Me.TabPage1.Controls.Add(Me.NoofPaxTextBox)
        Me.TabPage1.Controls.Add(Me.RoomTypeTextBox)
        Me.TabPage1.Controls.Add(Me.RoomNumberTextBox)
        Me.TabPage1.Controls.Add(Me.GuestNameTextBox)
        Me.TabPage1.Controls.Add(Me.NoofDaysLabel)
        Me.TabPage1.Controls.Add(Me.CheckOutDateLabel)
        Me.TabPage1.Controls.Add(Me.CheckInDateLabel)
        Me.TabPage1.Controls.Add(Me.NoofPaxLabel)
        Me.TabPage1.Controls.Add(Me.RoomTypeLabel)
        Me.TabPage1.Controls.Add(Me.RoomNumberLabel)
        Me.TabPage1.Controls.Add(Me.GuestNameLabel)
        Me.TabPage1.Controls.Add(Me.NewCheckOutLable)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(987, 461)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add Check Out"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(550, 350)
        Me.ResetButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(151, 43)
        Me.ResetButton.TabIndex = 72
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'FillButton
        '
        Me.FillButton.Location = New System.Drawing.Point(400, 166)
        Me.FillButton.Margin = New System.Windows.Forms.Padding(4)
        Me.FillButton.Name = "FillButton"
        Me.FillButton.Size = New System.Drawing.Size(40, 32)
        Me.FillButton.TabIndex = 71
        Me.FillButton.Text = "Fill"
        Me.FillButton.UseVisualStyleBackColor = True
        '
        'GuestIDTextBox
        '
        Me.GuestIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GuestIDTextBox.Location = New System.Drawing.Point(700, 118)
        Me.GuestIDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GuestIDTextBox.Name = "GuestIDTextBox"
        Me.GuestIDTextBox.ReadOnly = True
        Me.GuestIDTextBox.Size = New System.Drawing.Size(166, 26)
        Me.GuestIDTextBox.TabIndex = 70
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
        Me.GuestIDLabel.TabIndex = 69
        Me.GuestIDLabel.Text = "Guest ID"
        '
        'CheckOutTextBox
        '
        Me.CheckOutTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckOutTextBox.Location = New System.Drawing.Point(700, 218)
        Me.CheckOutTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckOutTextBox.Name = "CheckOutTextBox"
        Me.CheckOutTextBox.ReadOnly = True
        Me.CheckOutTextBox.Size = New System.Drawing.Size(166, 26)
        Me.CheckOutTextBox.TabIndex = 68
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
        'CancelButtonCheckIn
        '
        Me.CancelButtonCheckIn.Location = New System.Drawing.Point(750, 350)
        Me.CancelButtonCheckIn.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelButtonCheckIn.Name = "CancelButtonCheckIn"
        Me.CancelButtonCheckIn.Size = New System.Drawing.Size(151, 43)
        Me.CancelButtonCheckIn.TabIndex = 66
        Me.CancelButtonCheckIn.Text = "Cancel"
        Me.CancelButtonCheckIn.UseVisualStyleBackColor = True
        '
        'CheckOutButton
        '
        Me.CheckOutButton.Location = New System.Drawing.Point(350, 350)
        Me.CheckOutButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckOutButton.Name = "CheckOutButton"
        Me.CheckOutButton.Size = New System.Drawing.Size(151, 43)
        Me.CheckOutButton.TabIndex = 65
        Me.CheckOutButton.Text = "Check Out"
        Me.CheckOutButton.UseVisualStyleBackColor = True
        '
        'ReserveDateTextBox
        '
        Me.ReserveDateTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ReserveDateTextBox.Location = New System.Drawing.Point(700, 268)
        Me.ReserveDateTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ReserveDateTextBox.Name = "ReserveDateTextBox"
        Me.ReserveDateTextBox.ReadOnly = True
        Me.ReserveDateTextBox.Size = New System.Drawing.Size(166, 26)
        Me.ReserveDateTextBox.TabIndex = 16
        '
        'CheckInDateTextBox
        '
        Me.CheckInDateTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckInDateTextBox.Location = New System.Drawing.Point(700, 168)
        Me.CheckInDateTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckInDateTextBox.Name = "CheckInDateTextBox"
        Me.CheckInDateTextBox.ReadOnly = True
        Me.CheckInDateTextBox.Size = New System.Drawing.Size(166, 26)
        Me.CheckInDateTextBox.TabIndex = 14
        '
        'NoofPaxTextBox
        '
        Me.NoofPaxTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NoofPaxTextBox.Location = New System.Drawing.Point(212, 268)
        Me.NoofPaxTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NoofPaxTextBox.Name = "NoofPaxTextBox"
        Me.NoofPaxTextBox.ReadOnly = True
        Me.NoofPaxTextBox.Size = New System.Drawing.Size(73, 26)
        Me.NoofPaxTextBox.TabIndex = 12
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
        'NoofDaysLabel
        '
        Me.NoofDaysLabel.AutoSize = True
        Me.NoofDaysLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NoofDaysLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NoofDaysLabel.Location = New System.Drawing.Point(550, 270)
        Me.NoofDaysLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NoofDaysLabel.Name = "NoofDaysLabel"
        Me.NoofDaysLabel.Size = New System.Drawing.Size(112, 20)
        Me.NoofDaysLabel.TabIndex = 8
        Me.NoofDaysLabel.Text = "Reserve Date"
        '
        'CheckOutDateLabel
        '
        Me.CheckOutDateLabel.AutoSize = True
        Me.CheckOutDateLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckOutDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CheckOutDateLabel.Location = New System.Drawing.Point(550, 220)
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
        Me.CheckInDateLabel.Location = New System.Drawing.Point(550, 170)
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
        Me.NoofPaxLabel.Location = New System.Drawing.Point(51, 270)
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
        'NewCheckOutLable
        '
        Me.NewCheckOutLable.AutoSize = True
        Me.NewCheckOutLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.NewCheckOutLable.Location = New System.Drawing.Point(36, 34)
        Me.NewCheckOutLable.Name = "NewCheckOutLable"
        Me.NewCheckOutLable.Size = New System.Drawing.Size(189, 29)
        Me.NewCheckOutLable.TabIndex = 0
        Me.NewCheckOutLable.Text = "New Check Out"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CheckOutListLabel)
        Me.TabPage2.Controls.Add(Me.CheckInTable)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(987, 461)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Check Out List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CheckOutListLabel
        '
        Me.CheckOutListLabel.AutoEllipsis = True
        Me.CheckOutListLabel.AutoSize = True
        Me.CheckOutListLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckOutListLabel.Location = New System.Drawing.Point(13, 30)
        Me.CheckOutListLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CheckOutListLabel.Name = "CheckOutListLabel"
        Me.CheckOutListLabel.Size = New System.Drawing.Size(182, 29)
        Me.CheckOutListLabel.TabIndex = 41
        Me.CheckOutListLabel.Text = "Check Out List"
        '
        'CheckInTable
        '
        Me.CheckInTable.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.CheckInTable.FullRowSelect = True
        Me.CheckInTable.GridLines = True
        Me.CheckInTable.HideSelection = False
        Me.CheckInTable.Location = New System.Drawing.Point(19, 65)
        Me.CheckInTable.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckInTable.Name = "CheckInTable"
        Me.CheckInTable.Size = New System.Drawing.Size(948, 337)
        Me.CheckInTable.TabIndex = 1
        Me.CheckInTable.UseCompatibleStateImageBehavior = False
        Me.CheckInTable.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Reserve ID"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Guest Name"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 200
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
        Me.ColumnHeader6.Text = "No. of Pax"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 100
        '
        'CheckOutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 521)
        Me.Controls.Add(Me.CheckOutTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "CheckOutForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check Out Form"
        Me.CheckOutTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CheckOutTabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ResetButton As Button
    Friend WithEvents FillButton As Button
    Friend WithEvents GuestIDTextBox As TextBox
    Friend WithEvents GuestIDLabel As Label
    Friend WithEvents CheckOutTextBox As TextBox
    Friend WithEvents SearchGuestButton As Button
    Friend WithEvents CancelButtonCheckIn As Button
    Friend WithEvents CheckOutButton As Button
    Friend WithEvents ReserveDateTextBox As TextBox
    Friend WithEvents CheckInDateTextBox As TextBox
    Friend WithEvents NoofPaxTextBox As TextBox
    Friend WithEvents RoomTypeTextBox As TextBox
    Friend WithEvents RoomNumberTextBox As TextBox
    Friend WithEvents GuestNameTextBox As TextBox
    Friend WithEvents NoofDaysLabel As Label
    Friend WithEvents CheckOutDateLabel As Label
    Friend WithEvents CheckInDateLabel As Label
    Friend WithEvents NoofPaxLabel As Label
    Friend WithEvents RoomTypeLabel As Label
    Friend WithEvents RoomNumberLabel As Label
    Friend WithEvents GuestNameLabel As Label
    Friend WithEvents NewCheckOutLable As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents CheckOutListLabel As Label
    Friend WithEvents CheckInTable As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
End Class
