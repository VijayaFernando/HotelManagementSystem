<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentForm
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
        Me.PaymentTabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TotalPriceFillButton = New System.Windows.Forms.Button()
        Me.DiscountTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountLabel = New System.Windows.Forms.Label()
        Me.FillButton = New System.Windows.Forms.Button()
        Me.RoomPriceTextBox = New System.Windows.Forms.TextBox()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.RoomNumberTextBox = New System.Windows.Forms.TextBox()
        Me.RoomNumberLabel = New System.Windows.Forms.Label()
        Me.ExtraUsedListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.GuestIDTextBox = New System.Windows.Forms.TextBox()
        Me.GuestIDLabel = New System.Windows.Forms.Label()
        Me.SearchGuestButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.AddPaymentButton = New System.Windows.Forms.Button()
        Me.TotalPriceTextBox = New System.Windows.Forms.TextBox()
        Me.TotalExtraTextBox = New System.Windows.Forms.TextBox()
        Me.GuestNameTextBox = New System.Windows.Forms.TextBox()
        Me.TotalPriceLabel = New System.Windows.Forms.Label()
        Me.TotalExtraLabel = New System.Windows.Forms.Label()
        Me.GuestNameLabel = New System.Windows.Forms.Label()
        Me.NewCheckInLable = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PaymentListLabel = New System.Windows.Forms.Label()
        Me.PaymentTable = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PaymentTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PaymentTabControl
        '
        Me.PaymentTabControl.Controls.Add(Me.TabPage1)
        Me.PaymentTabControl.Controls.Add(Me.TabPage2)
        Me.PaymentTabControl.ItemSize = New System.Drawing.Size(97, 21)
        Me.PaymentTabControl.Location = New System.Drawing.Point(15, 15)
        Me.PaymentTabControl.Margin = New System.Windows.Forms.Padding(4)
        Me.PaymentTabControl.Name = "PaymentTabControl"
        Me.PaymentTabControl.SelectedIndex = 0
        Me.PaymentTabControl.Size = New System.Drawing.Size(995, 490)
        Me.PaymentTabControl.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TotalPriceFillButton)
        Me.TabPage1.Controls.Add(Me.DiscountTextBox)
        Me.TabPage1.Controls.Add(Me.DiscountLabel)
        Me.TabPage1.Controls.Add(Me.FillButton)
        Me.TabPage1.Controls.Add(Me.RoomPriceTextBox)
        Me.TabPage1.Controls.Add(Me.PriceLabel)
        Me.TabPage1.Controls.Add(Me.RoomNumberTextBox)
        Me.TabPage1.Controls.Add(Me.RoomNumberLabel)
        Me.TabPage1.Controls.Add(Me.ExtraUsedListView)
        Me.TabPage1.Controls.Add(Me.ResetButton)
        Me.TabPage1.Controls.Add(Me.GuestIDTextBox)
        Me.TabPage1.Controls.Add(Me.GuestIDLabel)
        Me.TabPage1.Controls.Add(Me.SearchGuestButton)
        Me.TabPage1.Controls.Add(Me.CancelButton)
        Me.TabPage1.Controls.Add(Me.AddPaymentButton)
        Me.TabPage1.Controls.Add(Me.TotalPriceTextBox)
        Me.TabPage1.Controls.Add(Me.TotalExtraTextBox)
        Me.TabPage1.Controls.Add(Me.GuestNameTextBox)
        Me.TabPage1.Controls.Add(Me.TotalPriceLabel)
        Me.TabPage1.Controls.Add(Me.TotalExtraLabel)
        Me.TabPage1.Controls.Add(Me.GuestNameLabel)
        Me.TabPage1.Controls.Add(Me.NewCheckInLable)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(987, 461)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "New Payment"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TotalPriceFillButton
        '
        Me.TotalPriceFillButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.TotalPriceFillButton.Location = New System.Drawing.Point(830, 345)
        Me.TotalPriceFillButton.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalPriceFillButton.Name = "TotalPriceFillButton"
        Me.TotalPriceFillButton.Size = New System.Drawing.Size(40, 32)
        Me.TotalPriceFillButton.TabIndex = 81
        Me.TotalPriceFillButton.Text = "Fill"
        Me.TotalPriceFillButton.UseVisualStyleBackColor = False
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DiscountTextBox.Location = New System.Drawing.Point(430, 348)
        Me.DiscountTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.Size = New System.Drawing.Size(100, 26)
        Me.DiscountTextBox.TabIndex = 80
        Me.DiscountTextBox.Text = "0"
        '
        'DiscountLabel
        '
        Me.DiscountLabel.AutoSize = True
        Me.DiscountLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DiscountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DiscountLabel.Location = New System.Drawing.Point(330, 350)
        Me.DiscountLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DiscountLabel.Name = "DiscountLabel"
        Me.DiscountLabel.Size = New System.Drawing.Size(76, 20)
        Me.DiscountLabel.TabIndex = 79
        Me.DiscountLabel.Text = "Discount"
        '
        'FillButton
        '
        Me.FillButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.FillButton.Location = New System.Drawing.Point(320, 125)
        Me.FillButton.Margin = New System.Windows.Forms.Padding(4)
        Me.FillButton.Name = "FillButton"
        Me.FillButton.Size = New System.Drawing.Size(40, 32)
        Me.FillButton.TabIndex = 78
        Me.FillButton.Text = "Fill"
        Me.FillButton.UseVisualStyleBackColor = False
        '
        'RoomPriceTextBox
        '
        Me.RoomPriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RoomPriceTextBox.Location = New System.Drawing.Point(700, 128)
        Me.RoomPriceTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RoomPriceTextBox.Name = "RoomPriceTextBox"
        Me.RoomPriceTextBox.ReadOnly = True
        Me.RoomPriceTextBox.Size = New System.Drawing.Size(166, 26)
        Me.RoomPriceTextBox.TabIndex = 77
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PriceLabel.Location = New System.Drawing.Point(550, 130)
        Me.PriceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(97, 20)
        Me.PriceLabel.TabIndex = 76
        Me.PriceLabel.Text = "Room Price"
        '
        'RoomNumberTextBox
        '
        Me.RoomNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RoomNumberTextBox.Location = New System.Drawing.Point(212, 128)
        Me.RoomNumberTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RoomNumberTextBox.Name = "RoomNumberTextBox"
        Me.RoomNumberTextBox.ReadOnly = True
        Me.RoomNumberTextBox.Size = New System.Drawing.Size(100, 26)
        Me.RoomNumberTextBox.TabIndex = 75
        '
        'RoomNumberLabel
        '
        Me.RoomNumberLabel.AutoSize = True
        Me.RoomNumberLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RoomNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RoomNumberLabel.Location = New System.Drawing.Point(51, 130)
        Me.RoomNumberLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RoomNumberLabel.Name = "RoomNumberLabel"
        Me.RoomNumberLabel.Size = New System.Drawing.Size(83, 20)
        Me.RoomNumberLabel.TabIndex = 74
        Me.RoomNumberLabel.Text = "Room No."
        '
        'ExtraUsedListView
        '
        Me.ExtraUsedListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ExtraUsedListView.FullRowSelect = True
        Me.ExtraUsedListView.GridLines = True
        Me.ExtraUsedListView.HideSelection = False
        Me.ExtraUsedListView.Location = New System.Drawing.Point(55, 185)
        Me.ExtraUsedListView.Margin = New System.Windows.Forms.Padding(4)
        Me.ExtraUsedListView.Name = "ExtraUsedListView"
        Me.ExtraUsedListView.Size = New System.Drawing.Size(811, 155)
        Me.ExtraUsedListView.TabIndex = 73
        Me.ExtraUsedListView.UseCompatibleStateImageBehavior = False
        Me.ExtraUsedListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Service Name"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Service Type"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 150
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Quantity"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 150
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Price"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 100
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(550, 400)
        Me.ResetButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(151, 43)
        Me.ResetButton.TabIndex = 72
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'GuestIDTextBox
        '
        Me.GuestIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GuestIDTextBox.Location = New System.Drawing.Point(700, 78)
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
        Me.GuestIDLabel.Location = New System.Drawing.Point(550, 80)
        Me.GuestIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GuestIDLabel.Name = "GuestIDLabel"
        Me.GuestIDLabel.Size = New System.Drawing.Size(76, 20)
        Me.GuestIDLabel.TabIndex = 69
        Me.GuestIDLabel.Text = "Guest ID"
        '
        'SearchGuestButton
        '
        Me.SearchGuestButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.SearchGuestButton.Location = New System.Drawing.Point(464, 75)
        Me.SearchGuestButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchGuestButton.Name = "SearchGuestButton"
        Me.SearchGuestButton.Size = New System.Drawing.Size(40, 32)
        Me.SearchGuestButton.TabIndex = 67
        Me.SearchGuestButton.Text = "..."
        Me.SearchGuestButton.UseVisualStyleBackColor = False
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(750, 400)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(151, 43)
        Me.CancelButton.TabIndex = 66
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'AddPaymentButton
        '
        Me.AddPaymentButton.Location = New System.Drawing.Point(350, 400)
        Me.AddPaymentButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AddPaymentButton.Name = "AddPaymentButton"
        Me.AddPaymentButton.Size = New System.Drawing.Size(151, 43)
        Me.AddPaymentButton.TabIndex = 65
        Me.AddPaymentButton.Text = "Add Payment"
        Me.AddPaymentButton.UseVisualStyleBackColor = True
        '
        'TotalPriceTextBox
        '
        Me.TotalPriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TotalPriceTextBox.Location = New System.Drawing.Point(720, 348)
        Me.TotalPriceTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalPriceTextBox.Name = "TotalPriceTextBox"
        Me.TotalPriceTextBox.ReadOnly = True
        Me.TotalPriceTextBox.Size = New System.Drawing.Size(100, 26)
        Me.TotalPriceTextBox.TabIndex = 16
        '
        'TotalExtraTextBox
        '
        Me.TotalExtraTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TotalExtraTextBox.Location = New System.Drawing.Point(150, 348)
        Me.TotalExtraTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalExtraTextBox.Name = "TotalExtraTextBox"
        Me.TotalExtraTextBox.ReadOnly = True
        Me.TotalExtraTextBox.Size = New System.Drawing.Size(100, 26)
        Me.TotalExtraTextBox.TabIndex = 12
        '
        'GuestNameTextBox
        '
        Me.GuestNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GuestNameTextBox.Location = New System.Drawing.Point(212, 78)
        Me.GuestNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GuestNameTextBox.Name = "GuestNameTextBox"
        Me.GuestNameTextBox.ReadOnly = True
        Me.GuestNameTextBox.Size = New System.Drawing.Size(245, 26)
        Me.GuestNameTextBox.TabIndex = 9
        '
        'TotalPriceLabel
        '
        Me.TotalPriceLabel.AutoSize = True
        Me.TotalPriceLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TotalPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TotalPriceLabel.Location = New System.Drawing.Point(600, 350)
        Me.TotalPriceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalPriceLabel.Name = "TotalPriceLabel"
        Me.TotalPriceLabel.Size = New System.Drawing.Size(90, 20)
        Me.TotalPriceLabel.TabIndex = 8
        Me.TotalPriceLabel.Text = "Total Price"
        '
        'TotalExtraLabel
        '
        Me.TotalExtraLabel.AutoSize = True
        Me.TotalExtraLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TotalExtraLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TotalExtraLabel.Location = New System.Drawing.Point(51, 350)
        Me.TotalExtraLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalExtraLabel.Name = "TotalExtraLabel"
        Me.TotalExtraLabel.Size = New System.Drawing.Size(90, 20)
        Me.TotalExtraLabel.TabIndex = 4
        Me.TotalExtraLabel.Text = "Total Extra"
        '
        'GuestNameLabel
        '
        Me.GuestNameLabel.AutoSize = True
        Me.GuestNameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GuestNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GuestNameLabel.Location = New System.Drawing.Point(51, 80)
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
        Me.NewCheckInLable.Location = New System.Drawing.Point(36, 25)
        Me.NewCheckInLable.Name = "NewCheckInLable"
        Me.NewCheckInLable.Size = New System.Drawing.Size(171, 29)
        Me.NewCheckInLable.TabIndex = 0
        Me.NewCheckInLable.Text = "New Payment"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PaymentListLabel)
        Me.TabPage2.Controls.Add(Me.PaymentTable)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(987, 461)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Payment List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PaymentListLabel
        '
        Me.PaymentListLabel.AutoEllipsis = True
        Me.PaymentListLabel.AutoSize = True
        Me.PaymentListLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentListLabel.Location = New System.Drawing.Point(13, 30)
        Me.PaymentListLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PaymentListLabel.Name = "PaymentListLabel"
        Me.PaymentListLabel.Size = New System.Drawing.Size(161, 29)
        Me.PaymentListLabel.TabIndex = 41
        Me.PaymentListLabel.Text = "Payment List"
        '
        'PaymentTable
        '
        Me.PaymentTable.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.PaymentTable.FullRowSelect = True
        Me.PaymentTable.GridLines = True
        Me.PaymentTable.HideSelection = False
        Me.PaymentTable.Location = New System.Drawing.Point(19, 65)
        Me.PaymentTable.Margin = New System.Windows.Forms.Padding(4)
        Me.PaymentTable.Name = "PaymentTable"
        Me.PaymentTable.Size = New System.Drawing.Size(948, 337)
        Me.PaymentTable.TabIndex = 1
        Me.PaymentTable.UseCompatibleStateImageBehavior = False
        Me.PaymentTable.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Payment ID"
        Me.ColumnHeader1.Width = 90
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Guest First Name"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Guest Last Name"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Discount"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Total Price"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Payment Date"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 100
        '
        'PaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 521)
        Me.Controls.Add(Me.PaymentTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "PaymentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Form"
        Me.PaymentTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PaymentTabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ResetButton As Button
    Friend WithEvents GuestIDTextBox As TextBox
    Friend WithEvents GuestIDLabel As Label
    Friend WithEvents SearchGuestButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents AddPaymentButton As Button
    Friend WithEvents TotalPriceTextBox As TextBox
    Friend WithEvents TotalExtraTextBox As TextBox
    Friend WithEvents GuestNameTextBox As TextBox
    Friend WithEvents TotalPriceLabel As Label
    Friend WithEvents TotalExtraLabel As Label
    Friend WithEvents GuestNameLabel As Label
    Friend WithEvents NewCheckInLable As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PaymentListLabel As Label
    Friend WithEvents PaymentTable As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents RoomPriceTextBox As TextBox
    Friend WithEvents PriceLabel As Label
    Friend WithEvents RoomNumberTextBox As TextBox
    Friend WithEvents RoomNumberLabel As Label
    Friend WithEvents ExtraUsedListView As ListView
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents FillButton As Button
    Friend WithEvents DiscountTextBox As TextBox
    Friend WithEvents DiscountLabel As Label
    Friend WithEvents TotalPriceFillButton As Button
End Class
