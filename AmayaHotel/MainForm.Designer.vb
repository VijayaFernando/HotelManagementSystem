<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewCheckInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewGuestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewRoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewRoomTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonitoringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservedListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckedInListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckedOutListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomsListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomTypeListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UseExtraServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewExtraSeviceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiscountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.CheckInToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CheckOutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.RoomsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.GuestsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReserveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogoutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.CancelToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MonitoringToolStripMenuItem, Me.ExtraToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1344, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewReservationToolStripMenuItem, Me.NewCheckInToolStripMenuItem, Me.CheckOutToolStripMenuItem, Me.ToolStripSeparator1, Me.NewGuestToolStripMenuItem, Me.AddNewRoomToolStripMenuItem, Me.AddNewRoomTypeToolStripMenuItem, Me.ToolStripSeparator9, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.FileToolStripMenuItem.Text = "New"
        '
        'NewReservationToolStripMenuItem
        '
        Me.NewReservationToolStripMenuItem.Name = "NewReservationToolStripMenuItem"
        Me.NewReservationToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.NewReservationToolStripMenuItem.Text = "New Reservation"
        '
        'NewCheckInToolStripMenuItem
        '
        Me.NewCheckInToolStripMenuItem.Name = "NewCheckInToolStripMenuItem"
        Me.NewCheckInToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.NewCheckInToolStripMenuItem.Text = "Check In"
        '
        'CheckOutToolStripMenuItem
        '
        Me.CheckOutToolStripMenuItem.Name = "CheckOutToolStripMenuItem"
        Me.CheckOutToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.CheckOutToolStripMenuItem.Text = "Check Out"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(222, 6)
        '
        'NewGuestToolStripMenuItem
        '
        Me.NewGuestToolStripMenuItem.Name = "NewGuestToolStripMenuItem"
        Me.NewGuestToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.NewGuestToolStripMenuItem.Text = "Add New Guest"
        '
        'AddNewRoomToolStripMenuItem
        '
        Me.AddNewRoomToolStripMenuItem.Name = "AddNewRoomToolStripMenuItem"
        Me.AddNewRoomToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.AddNewRoomToolStripMenuItem.Text = "Add New Room"
        '
        'AddNewRoomTypeToolStripMenuItem
        '
        Me.AddNewRoomTypeToolStripMenuItem.Name = "AddNewRoomTypeToolStripMenuItem"
        Me.AddNewRoomTypeToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.AddNewRoomTypeToolStripMenuItem.Text = "Add New Room Type"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(222, 6)
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MonitoringToolStripMenuItem
        '
        Me.MonitoringToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReservedListToolStripMenuItem, Me.CheckedInListToolStripMenuItem, Me.CheckedOutListToolStripMenuItem, Me.ToolStripSeparator2, Me.ToolStripMenuItem3, Me.RoomsListToolStripMenuItem, Me.RoomTypeListToolStripMenuItem})
        Me.MonitoringToolStripMenuItem.Name = "MonitoringToolStripMenuItem"
        Me.MonitoringToolStripMenuItem.Size = New System.Drawing.Size(95, 24)
        Me.MonitoringToolStripMenuItem.Text = "Monitoring"
        '
        'ReservedListToolStripMenuItem
        '
        Me.ReservedListToolStripMenuItem.Name = "ReservedListToolStripMenuItem"
        Me.ReservedListToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.ReservedListToolStripMenuItem.Text = "Reserved List"
        '
        'CheckedInListToolStripMenuItem
        '
        Me.CheckedInListToolStripMenuItem.Name = "CheckedInListToolStripMenuItem"
        Me.CheckedInListToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.CheckedInListToolStripMenuItem.Text = "Checked In List"
        '
        'CheckedOutListToolStripMenuItem
        '
        Me.CheckedOutListToolStripMenuItem.Name = "CheckedOutListToolStripMenuItem"
        Me.CheckedOutListToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.CheckedOutListToolStripMenuItem.Text = "Checked Out List"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(191, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(194, 26)
        Me.ToolStripMenuItem3.Text = "Guest List"
        '
        'RoomsListToolStripMenuItem
        '
        Me.RoomsListToolStripMenuItem.Name = "RoomsListToolStripMenuItem"
        Me.RoomsListToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.RoomsListToolStripMenuItem.Text = "Rooms List"
        '
        'RoomTypeListToolStripMenuItem
        '
        Me.RoomTypeListToolStripMenuItem.Name = "RoomTypeListToolStripMenuItem"
        Me.RoomTypeListToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.RoomTypeListToolStripMenuItem.Text = "Room Type List"
        '
        'ExtraToolStripMenuItem
        '
        Me.ExtraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UseExtraServicesToolStripMenuItem, Me.AddNewExtraSeviceToolStripMenuItem})
        Me.ExtraToolStripMenuItem.Name = "ExtraToolStripMenuItem"
        Me.ExtraToolStripMenuItem.Size = New System.Drawing.Size(54, 24)
        Me.ExtraToolStripMenuItem.Text = "Extra"
        '
        'UseExtraServicesToolStripMenuItem
        '
        Me.UseExtraServicesToolStripMenuItem.Name = "UseExtraServicesToolStripMenuItem"
        Me.UseExtraServicesToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.UseExtraServicesToolStripMenuItem.Text = "Use Extra Services"
        '
        'AddNewExtraSeviceToolStripMenuItem
        '
        Me.AddNewExtraSeviceToolStripMenuItem.Name = "AddNewExtraSeviceToolStripMenuItem"
        Me.AddNewExtraSeviceToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.AddNewExtraSeviceToolStripMenuItem.Text = "Add New Extra Sevice"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DiscountToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.SettingsToolStripMenuItem.Text = "Payments"
        '
        'DiscountToolStripMenuItem
        '
        Me.DiscountToolStripMenuItem.Name = "DiscountToolStripMenuItem"
        Me.DiscountToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.DiscountToolStripMenuItem.Text = "Payment"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.DodgerBlue
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckInToolStripButton, Me.ToolStripSeparator3, Me.CheckOutToolStripButton, Me.ToolStripSeparator4, Me.RoomsToolStripButton, Me.ToolStripSeparator5, Me.GuestsToolStripButton, Me.ToolStripSeparator6, Me.ReserveToolStripButton, Me.ToolStripSeparator7, Me.LogoutToolStripButton, Me.ToolStripSeparator8, Me.CancelToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1344, 50)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'CheckInToolStripButton
        '
        Me.CheckInToolStripButton.AutoSize = False
        Me.CheckInToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CheckInToolStripButton.Image = Global.AmayaHotel.My.Resources.Resources.check_in
        Me.CheckInToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CheckInToolStripButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckInToolStripButton.Name = "CheckInToolStripButton"
        Me.CheckInToolStripButton.Size = New System.Drawing.Size(47, 47)
        Me.CheckInToolStripButton.Text = "Check In"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 50)
        '
        'CheckOutToolStripButton
        '
        Me.CheckOutToolStripButton.AutoSize = False
        Me.CheckOutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CheckOutToolStripButton.Image = Global.AmayaHotel.My.Resources.Resources.check_out
        Me.CheckOutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CheckOutToolStripButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckOutToolStripButton.Name = "CheckOutToolStripButton"
        Me.CheckOutToolStripButton.Size = New System.Drawing.Size(47, 47)
        Me.CheckOutToolStripButton.Text = "Check Out"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 50)
        '
        'RoomsToolStripButton
        '
        Me.RoomsToolStripButton.AutoSize = False
        Me.RoomsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RoomsToolStripButton.Image = Global.AmayaHotel.My.Resources.Resources.room_key
        Me.RoomsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RoomsToolStripButton.Margin = New System.Windows.Forms.Padding(0)
        Me.RoomsToolStripButton.Name = "RoomsToolStripButton"
        Me.RoomsToolStripButton.Size = New System.Drawing.Size(47, 47)
        Me.RoomsToolStripButton.Text = "Rooms"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 50)
        '
        'GuestsToolStripButton
        '
        Me.GuestsToolStripButton.AutoSize = False
        Me.GuestsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GuestsToolStripButton.Image = Global.AmayaHotel.My.Resources.Resources.guest
        Me.GuestsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuestsToolStripButton.Margin = New System.Windows.Forms.Padding(0)
        Me.GuestsToolStripButton.Name = "GuestsToolStripButton"
        Me.GuestsToolStripButton.Size = New System.Drawing.Size(47, 47)
        Me.GuestsToolStripButton.Text = "Guests"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 50)
        '
        'ReserveToolStripButton
        '
        Me.ReserveToolStripButton.AutoSize = False
        Me.ReserveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ReserveToolStripButton.Image = Global.AmayaHotel.My.Resources.Resources.pencil
        Me.ReserveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ReserveToolStripButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ReserveToolStripButton.Name = "ReserveToolStripButton"
        Me.ReserveToolStripButton.Size = New System.Drawing.Size(47, 47)
        Me.ReserveToolStripButton.Text = "Reserve"
        Me.ReserveToolStripButton.ToolTipText = "Reservation"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 50)
        '
        'LogoutToolStripButton
        '
        Me.LogoutToolStripButton.AutoSize = False
        Me.LogoutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LogoutToolStripButton.Image = Global.AmayaHotel.My.Resources.Resources.Logout
        Me.LogoutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LogoutToolStripButton.Margin = New System.Windows.Forms.Padding(0)
        Me.LogoutToolStripButton.Name = "LogoutToolStripButton"
        Me.LogoutToolStripButton.Size = New System.Drawing.Size(47, 47)
        Me.LogoutToolStripButton.Text = "LogOut"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 50)
        '
        'CancelToolStripButton
        '
        Me.CancelToolStripButton.AutoSize = False
        Me.CancelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CancelToolStripButton.Image = Global.AmayaHotel.My.Resources.Resources.cancel
        Me.CancelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelToolStripButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CancelToolStripButton.Name = "CancelToolStripButton"
        Me.CancelToolStripButton.Size = New System.Drawing.Size(47, 47)
        Me.CancelToolStripButton.Text = "Cancel"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.AmayaHotel.My.Resources.Resources.BackgroundImage02
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1344, 788)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Amaya Hotel Management System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewCheckInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewReservationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonitoringToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckedInListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReservedListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckedOutListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents DiscountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents CheckInToolStripButton As ToolStripButton
    Friend WithEvents CheckOutToolStripButton As ToolStripButton
    Friend WithEvents RoomsToolStripButton As ToolStripButton
    Friend WithEvents GuestsToolStripButton As ToolStripButton
    Friend WithEvents ReserveToolStripButton As ToolStripButton
    Friend WithEvents LogoutToolStripButton As ToolStripButton
    Friend WithEvents CancelToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents NewGuestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewRoomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents CheckOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewRoomTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RoomsListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RoomTypeListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExtraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UseExtraServicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewExtraSeviceToolStripMenuItem As ToolStripMenuItem
End Class
