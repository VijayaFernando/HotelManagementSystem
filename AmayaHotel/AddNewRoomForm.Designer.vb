<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewRoomForm
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.AddGuestTabPage = New System.Windows.Forms.TabPage()
        Me.SearchRoomTypeButton = New System.Windows.Forms.Button()
        Me.RoomTypeIDTextBox = New System.Windows.Forms.TextBox()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.CancelNewGuestButton = New System.Windows.Forms.Button()
        Me.AddRoomButton = New System.Windows.Forms.Button()
        Me.NoOfRoomsTextBox = New System.Windows.Forms.TextBox()
        Me.NoOfRoomsLabel = New System.Windows.Forms.Label()
        Me.TypeIDLabel = New System.Windows.Forms.Label()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.FacilitiesTextBox = New System.Windows.Forms.TextBox()
        Me.FacilitiesLabel = New System.Windows.Forms.Label()
        Me.RoomTypeTextBox = New System.Windows.Forms.TextBox()
        Me.RoomTypeLabel = New System.Windows.Forms.Label()
        Me.RoomNumberTextBox = New System.Windows.Forms.TextBox()
        Me.RoomNumberLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.RoomTable = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabControl1.SuspendLayout()
        Me.AddGuestTabPage.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.AddGuestTabPage)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(15, 15)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(995, 490)
        Me.TabControl1.TabIndex = 2
        '
        'AddGuestTabPage
        '
        Me.AddGuestTabPage.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AddGuestTabPage.Controls.Add(Me.SearchRoomTypeButton)
        Me.AddGuestTabPage.Controls.Add(Me.RoomTypeIDTextBox)
        Me.AddGuestTabPage.Controls.Add(Me.ResetButton)
        Me.AddGuestTabPage.Controls.Add(Me.CancelNewGuestButton)
        Me.AddGuestTabPage.Controls.Add(Me.AddRoomButton)
        Me.AddGuestTabPage.Controls.Add(Me.NoOfRoomsTextBox)
        Me.AddGuestTabPage.Controls.Add(Me.NoOfRoomsLabel)
        Me.AddGuestTabPage.Controls.Add(Me.TypeIDLabel)
        Me.AddGuestTabPage.Controls.Add(Me.PriceTextBox)
        Me.AddGuestTabPage.Controls.Add(Me.PriceLabel)
        Me.AddGuestTabPage.Controls.Add(Me.FacilitiesTextBox)
        Me.AddGuestTabPage.Controls.Add(Me.FacilitiesLabel)
        Me.AddGuestTabPage.Controls.Add(Me.RoomTypeTextBox)
        Me.AddGuestTabPage.Controls.Add(Me.RoomTypeLabel)
        Me.AddGuestTabPage.Controls.Add(Me.RoomNumberTextBox)
        Me.AddGuestTabPage.Controls.Add(Me.RoomNumberLabel)
        Me.AddGuestTabPage.Controls.Add(Me.Label1)
        Me.AddGuestTabPage.Controls.Add(Me.ShapeContainer1)
        Me.AddGuestTabPage.Location = New System.Drawing.Point(4, 25)
        Me.AddGuestTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.AddGuestTabPage.Name = "AddGuestTabPage"
        Me.AddGuestTabPage.Padding = New System.Windows.Forms.Padding(4)
        Me.AddGuestTabPage.Size = New System.Drawing.Size(987, 461)
        Me.AddGuestTabPage.TabIndex = 0
        Me.AddGuestTabPage.Text = "Add Room"
        '
        'SearchRoomTypeButton
        '
        Me.SearchRoomTypeButton.Location = New System.Drawing.Point(380, 183)
        Me.SearchRoomTypeButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchRoomTypeButton.Name = "SearchRoomTypeButton"
        Me.SearchRoomTypeButton.Size = New System.Drawing.Size(40, 32)
        Me.SearchRoomTypeButton.TabIndex = 78
        Me.SearchRoomTypeButton.Text = "..."
        Me.SearchRoomTypeButton.UseVisualStyleBackColor = True
        '
        'RoomTypeIDTextBox
        '
        Me.RoomTypeIDTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.RoomTypeIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomTypeIDTextBox.Location = New System.Drawing.Point(675, 187)
        Me.RoomTypeIDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RoomTypeIDTextBox.Multiline = True
        Me.RoomTypeIDTextBox.Name = "RoomTypeIDTextBox"
        Me.RoomTypeIDTextBox.ReadOnly = True
        Me.RoomTypeIDTextBox.Size = New System.Drawing.Size(159, 30)
        Me.RoomTypeIDTextBox.TabIndex = 77
        Me.RoomTypeIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(625, 383)
        Me.ResetButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(151, 43)
        Me.ResetButton.TabIndex = 76
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'CancelNewGuestButton
        '
        Me.CancelNewGuestButton.Location = New System.Drawing.Point(785, 383)
        Me.CancelNewGuestButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelNewGuestButton.Name = "CancelNewGuestButton"
        Me.CancelNewGuestButton.Size = New System.Drawing.Size(151, 43)
        Me.CancelNewGuestButton.TabIndex = 65
        Me.CancelNewGuestButton.Text = "Cancel"
        Me.CancelNewGuestButton.UseVisualStyleBackColor = True
        '
        'AddRoomButton
        '
        Me.AddRoomButton.Location = New System.Drawing.Point(465, 383)
        Me.AddRoomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AddRoomButton.Name = "AddRoomButton"
        Me.AddRoomButton.Size = New System.Drawing.Size(151, 43)
        Me.AddRoomButton.TabIndex = 64
        Me.AddRoomButton.Text = "Add"
        Me.AddRoomButton.UseVisualStyleBackColor = True
        '
        'NoOfRoomsTextBox
        '
        Me.NoOfRoomsTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.NoOfRoomsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoOfRoomsTextBox.Location = New System.Drawing.Point(675, 253)
        Me.NoOfRoomsTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NoOfRoomsTextBox.Multiline = True
        Me.NoOfRoomsTextBox.Name = "NoOfRoomsTextBox"
        Me.NoOfRoomsTextBox.ReadOnly = True
        Me.NoOfRoomsTextBox.Size = New System.Drawing.Size(159, 30)
        Me.NoOfRoomsTextBox.TabIndex = 53
        Me.NoOfRoomsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NoOfRoomsLabel
        '
        Me.NoOfRoomsLabel.AutoSize = True
        Me.NoOfRoomsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoOfRoomsLabel.Location = New System.Drawing.Point(550, 260)
        Me.NoOfRoomsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NoOfRoomsLabel.Name = "NoOfRoomsLabel"
        Me.NoOfRoomsLabel.Size = New System.Drawing.Size(111, 20)
        Me.NoOfRoomsLabel.TabIndex = 63
        Me.NoOfRoomsLabel.Text = "No Of Rooms"
        '
        'TypeIDLabel
        '
        Me.TypeIDLabel.AutoSize = True
        Me.TypeIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeIDLabel.Location = New System.Drawing.Point(550, 190)
        Me.TypeIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TypeIDLabel.Name = "TypeIDLabel"
        Me.TypeIDLabel.Size = New System.Drawing.Size(67, 20)
        Me.TypeIDLabel.TabIndex = 62
        Me.TypeIDLabel.Text = "Type ID"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceTextBox.Location = New System.Drawing.Point(675, 113)
        Me.PriceTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PriceTextBox.Multiline = True
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(159, 30)
        Me.PriceTextBox.TabIndex = 49
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLabel.Location = New System.Drawing.Point(550, 120)
        Me.PriceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(48, 20)
        Me.PriceLabel.TabIndex = 59
        Me.PriceLabel.Text = "Price"
        '
        'FacilitiesTextBox
        '
        Me.FacilitiesTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.FacilitiesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FacilitiesTextBox.Location = New System.Drawing.Point(212, 253)
        Me.FacilitiesTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FacilitiesTextBox.Multiline = True
        Me.FacilitiesTextBox.Name = "FacilitiesTextBox"
        Me.FacilitiesTextBox.ReadOnly = True
        Me.FacilitiesTextBox.Size = New System.Drawing.Size(279, 90)
        Me.FacilitiesTextBox.TabIndex = 40
        '
        'FacilitiesLabel
        '
        Me.FacilitiesLabel.AutoSize = True
        Me.FacilitiesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FacilitiesLabel.Location = New System.Drawing.Point(51, 260)
        Me.FacilitiesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FacilitiesLabel.Name = "FacilitiesLabel"
        Me.FacilitiesLabel.Size = New System.Drawing.Size(76, 20)
        Me.FacilitiesLabel.TabIndex = 47
        Me.FacilitiesLabel.Text = "Facilities"
        '
        'RoomTypeTextBox
        '
        Me.RoomTypeTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.RoomTypeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomTypeTextBox.Location = New System.Drawing.Point(212, 183)
        Me.RoomTypeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RoomTypeTextBox.Multiline = True
        Me.RoomTypeTextBox.Name = "RoomTypeTextBox"
        Me.RoomTypeTextBox.ReadOnly = True
        Me.RoomTypeTextBox.Size = New System.Drawing.Size(150, 30)
        Me.RoomTypeTextBox.TabIndex = 38
        '
        'RoomTypeLabel
        '
        Me.RoomTypeLabel.AutoSize = True
        Me.RoomTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomTypeLabel.Location = New System.Drawing.Point(51, 190)
        Me.RoomTypeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RoomTypeLabel.Name = "RoomTypeLabel"
        Me.RoomTypeLabel.Size = New System.Drawing.Size(94, 20)
        Me.RoomTypeLabel.TabIndex = 45
        Me.RoomTypeLabel.Text = "Room Type"
        '
        'RoomNumberTextBox
        '
        Me.RoomNumberTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RoomNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomNumberTextBox.Location = New System.Drawing.Point(212, 113)
        Me.RoomNumberTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RoomNumberTextBox.Multiline = True
        Me.RoomNumberTextBox.Name = "RoomNumberTextBox"
        Me.RoomNumberTextBox.Size = New System.Drawing.Size(150, 30)
        Me.RoomNumberTextBox.TabIndex = 35
        '
        'RoomNumberLabel
        '
        Me.RoomNumberLabel.AutoSize = True
        Me.RoomNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomNumberLabel.Location = New System.Drawing.Point(51, 120)
        Me.RoomNumberLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RoomNumberLabel.Name = "RoomNumberLabel"
        Me.RoomNumberLabel.Size = New System.Drawing.Size(117, 20)
        Me.RoomNumberLabel.TabIndex = 41
        Me.RoomNumberLabel.Text = "Room Number"
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 29)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Add New Room Form"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(4, 4)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Size = New System.Drawing.Size(979, 453)
        Me.ShapeContainer1.TabIndex = 75
        Me.ShapeContainer1.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.RoomTable)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(987, 461)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Room List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoEllipsis = True
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(13, 30)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(143, 29)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Rooms List"
        '
        'RoomTable
        '
        Me.RoomTable.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.RoomTable.FullRowSelect = True
        Me.RoomTable.GridLines = True
        Me.RoomTable.HideSelection = False
        Me.RoomTable.Location = New System.Drawing.Point(16, 63)
        Me.RoomTable.Margin = New System.Windows.Forms.Padding(4)
        Me.RoomTable.Name = "RoomTable"
        Me.RoomTable.Size = New System.Drawing.Size(948, 390)
        Me.RoomTable.TabIndex = 0
        Me.RoomTable.UseCompatibleStateImageBehavior = False
        Me.RoomTable.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Room ID"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Room No."
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Room Type"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Facilities"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 250
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Price"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 100
        '
        'AddNewRoomForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 521)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "AddNewRoomForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Room Form"
        Me.TabControl1.ResumeLayout(False)
        Me.AddGuestTabPage.ResumeLayout(False)
        Me.AddGuestTabPage.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents AddGuestTabPage As TabPage
    Friend WithEvents RoomTypeIDTextBox As TextBox
    Friend WithEvents ResetButton As Button
    Friend WithEvents CancelNewGuestButton As Button
    Friend WithEvents AddRoomButton As Button
    Friend WithEvents NoOfRoomsTextBox As TextBox
    Friend WithEvents NoOfRoomsLabel As Label
    Friend WithEvents TypeIDLabel As Label
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents PriceLabel As Label
    Friend WithEvents FacilitiesTextBox As TextBox
    Friend WithEvents FacilitiesLabel As Label
    Friend WithEvents RoomTypeTextBox As TextBox
    Friend WithEvents RoomTypeLabel As Label
    Friend WithEvents RoomNumberTextBox As TextBox
    Friend WithEvents RoomNumberLabel As Label
    Friend WithEvents Label1 As Label
    Private WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label16 As Label
    Friend WithEvents RoomTable As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents SearchRoomTypeButton As Button
End Class
