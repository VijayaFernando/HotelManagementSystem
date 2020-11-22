<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddNewRoomTypeForm
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.AddGuestTabPage = New System.Windows.Forms.TabPage()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.CancelNewGuestButton = New System.Windows.Forms.Button()
        Me.AddRoomButton = New System.Windows.Forms.Button()
        Me.NoOfRoomsTextBox = New System.Windows.Forms.TextBox()
        Me.NoOfRoomsLabel = New System.Windows.Forms.Label()
        Me.FacilitiesTextBox = New System.Windows.Forms.TextBox()
        Me.FacilitiesLabel = New System.Windows.Forms.Label()
        Me.RoomTypeTextBox = New System.Windows.Forms.TextBox()
        Me.RoomTypeLabel = New System.Windows.Forms.Label()
        Me.AddNewRoomTypeLabel = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.RoomTable = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.TabControl1.TabIndex = 3
        '
        'AddGuestTabPage
        '
        Me.AddGuestTabPage.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AddGuestTabPage.Controls.Add(Me.ResetButton)
        Me.AddGuestTabPage.Controls.Add(Me.CancelNewGuestButton)
        Me.AddGuestTabPage.Controls.Add(Me.AddRoomButton)
        Me.AddGuestTabPage.Controls.Add(Me.NoOfRoomsTextBox)
        Me.AddGuestTabPage.Controls.Add(Me.NoOfRoomsLabel)
        Me.AddGuestTabPage.Controls.Add(Me.FacilitiesTextBox)
        Me.AddGuestTabPage.Controls.Add(Me.FacilitiesLabel)
        Me.AddGuestTabPage.Controls.Add(Me.RoomTypeTextBox)
        Me.AddGuestTabPage.Controls.Add(Me.RoomTypeLabel)
        Me.AddGuestTabPage.Controls.Add(Me.AddNewRoomTypeLabel)
        Me.AddGuestTabPage.Controls.Add(Me.ShapeContainer1)
        Me.AddGuestTabPage.Location = New System.Drawing.Point(4, 25)
        Me.AddGuestTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.AddGuestTabPage.Name = "AddGuestTabPage"
        Me.AddGuestTabPage.Padding = New System.Windows.Forms.Padding(4)
        Me.AddGuestTabPage.Size = New System.Drawing.Size(987, 461)
        Me.AddGuestTabPage.TabIndex = 0
        Me.AddGuestTabPage.Text = "Add Room Type"
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
        Me.NoOfRoomsTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.NoOfRoomsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoOfRoomsTextBox.Location = New System.Drawing.Point(675, 113)
        Me.NoOfRoomsTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NoOfRoomsTextBox.Multiline = True
        Me.NoOfRoomsTextBox.Name = "NoOfRoomsTextBox"
        Me.NoOfRoomsTextBox.Size = New System.Drawing.Size(159, 30)
        Me.NoOfRoomsTextBox.TabIndex = 53
        Me.NoOfRoomsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NoOfRoomsLabel
        '
        Me.NoOfRoomsLabel.AutoSize = True
        Me.NoOfRoomsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoOfRoomsLabel.Location = New System.Drawing.Point(550, 120)
        Me.NoOfRoomsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NoOfRoomsLabel.Name = "NoOfRoomsLabel"
        Me.NoOfRoomsLabel.Size = New System.Drawing.Size(111, 20)
        Me.NoOfRoomsLabel.TabIndex = 63
        Me.NoOfRoomsLabel.Text = "No Of Rooms"
        '
        'FacilitiesTextBox
        '
        Me.FacilitiesTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.FacilitiesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FacilitiesTextBox.Location = New System.Drawing.Point(212, 213)
        Me.FacilitiesTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FacilitiesTextBox.Multiline = True
        Me.FacilitiesTextBox.Name = "FacilitiesTextBox"
        Me.FacilitiesTextBox.Size = New System.Drawing.Size(279, 110)
        Me.FacilitiesTextBox.TabIndex = 40
        '
        'FacilitiesLabel
        '
        Me.FacilitiesLabel.AutoSize = True
        Me.FacilitiesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FacilitiesLabel.Location = New System.Drawing.Point(51, 220)
        Me.FacilitiesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FacilitiesLabel.Name = "FacilitiesLabel"
        Me.FacilitiesLabel.Size = New System.Drawing.Size(76, 20)
        Me.FacilitiesLabel.TabIndex = 47
        Me.FacilitiesLabel.Text = "Facilities"
        '
        'RoomTypeTextBox
        '
        Me.RoomTypeTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RoomTypeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomTypeTextBox.Location = New System.Drawing.Point(212, 113)
        Me.RoomTypeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RoomTypeTextBox.Multiline = True
        Me.RoomTypeTextBox.Name = "RoomTypeTextBox"
        Me.RoomTypeTextBox.Size = New System.Drawing.Size(150, 30)
        Me.RoomTypeTextBox.TabIndex = 38
        '
        'RoomTypeLabel
        '
        Me.RoomTypeLabel.AutoSize = True
        Me.RoomTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomTypeLabel.Location = New System.Drawing.Point(51, 120)
        Me.RoomTypeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RoomTypeLabel.Name = "RoomTypeLabel"
        Me.RoomTypeLabel.Size = New System.Drawing.Size(94, 20)
        Me.RoomTypeLabel.TabIndex = 45
        Me.RoomTypeLabel.Text = "Room Type"
        '
        'AddNewRoomTypeLabel
        '
        Me.AddNewRoomTypeLabel.AutoEllipsis = True
        Me.AddNewRoomTypeLabel.AutoSize = True
        Me.AddNewRoomTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewRoomTypeLabel.Location = New System.Drawing.Point(13, 30)
        Me.AddNewRoomTypeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AddNewRoomTypeLabel.Name = "AddNewRoomTypeLabel"
        Me.AddNewRoomTypeLabel.Size = New System.Drawing.Size(329, 29)
        Me.AddNewRoomTypeLabel.TabIndex = 36
        Me.AddNewRoomTypeLabel.Text = "Add New Room Type Form"
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
        Me.TabPage2.Text = "Room Type List"
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
        Me.Label16.Size = New System.Drawing.Size(209, 29)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Rooms Type List"
        '
        'RoomTable
        '
        Me.RoomTable.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
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
        Me.ColumnHeader1.Text = "Room Type ID"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Room Type"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Facilities"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 250
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "No. of Rooms"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'AddNewRoomTypeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 521)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "AddNewRoomTypeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddNewRoomTypeForm"
        Me.TabControl1.ResumeLayout(False)
        Me.AddGuestTabPage.ResumeLayout(False)
        Me.AddGuestTabPage.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents AddGuestTabPage As TabPage
    Friend WithEvents ResetButton As Button
    Friend WithEvents CancelNewGuestButton As Button
    Friend WithEvents AddRoomButton As Button
    Friend WithEvents NoOfRoomsTextBox As TextBox
    Friend WithEvents NoOfRoomsLabel As Label
    Friend WithEvents FacilitiesTextBox As TextBox
    Friend WithEvents FacilitiesLabel As Label
    Friend WithEvents RoomTypeTextBox As TextBox
    Friend WithEvents RoomTypeLabel As Label
    Friend WithEvents AddNewRoomTypeLabel As Label
    Private WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label16 As Label
    Friend WithEvents RoomTable As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
