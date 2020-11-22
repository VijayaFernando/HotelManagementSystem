<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewGuestForm
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
        Me.SexComboBox = New System.Windows.Forms.ComboBox()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.CancelGuestButton = New System.Windows.Forms.Button()
        Me.AddNewGuestButton = New System.Windows.Forms.Button()
        Me.TelephoneTextBox = New System.Windows.Forms.TextBox()
        Me.TelLabel = New System.Windows.Forms.Label()
        Me.SexLabel = New System.Windows.Forms.Label()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GuestTable = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.TabControl1.TabIndex = 1
        '
        'AddGuestTabPage
        '
        Me.AddGuestTabPage.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AddGuestTabPage.Controls.Add(Me.SexComboBox)
        Me.AddGuestTabPage.Controls.Add(Me.ResetButton)
        Me.AddGuestTabPage.Controls.Add(Me.CancelGuestButton)
        Me.AddGuestTabPage.Controls.Add(Me.AddNewGuestButton)
        Me.AddGuestTabPage.Controls.Add(Me.TelephoneTextBox)
        Me.AddGuestTabPage.Controls.Add(Me.TelLabel)
        Me.AddGuestTabPage.Controls.Add(Me.SexLabel)
        Me.AddGuestTabPage.Controls.Add(Me.AgeTextBox)
        Me.AddGuestTabPage.Controls.Add(Me.AgeLabel)
        Me.AddGuestTabPage.Controls.Add(Me.AddressTextBox)
        Me.AddGuestTabPage.Controls.Add(Me.AddressLabel)
        Me.AddGuestTabPage.Controls.Add(Me.LastNameTextBox)
        Me.AddGuestTabPage.Controls.Add(Me.LastNameLabel)
        Me.AddGuestTabPage.Controls.Add(Me.FirstNameTextBox)
        Me.AddGuestTabPage.Controls.Add(Me.FirstNameLabel)
        Me.AddGuestTabPage.Controls.Add(Me.Label1)
        Me.AddGuestTabPage.Controls.Add(Me.ShapeContainer1)
        Me.AddGuestTabPage.Location = New System.Drawing.Point(4, 25)
        Me.AddGuestTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.AddGuestTabPage.Name = "AddGuestTabPage"
        Me.AddGuestTabPage.Padding = New System.Windows.Forms.Padding(4)
        Me.AddGuestTabPage.Size = New System.Drawing.Size(987, 461)
        Me.AddGuestTabPage.TabIndex = 0
        Me.AddGuestTabPage.Text = "Add Guest"
        '
        'SexComboBox
        '
        Me.SexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SexComboBox.FormattingEnabled = True
        Me.SexComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.SexComboBox.Location = New System.Drawing.Point(650, 187)
        Me.SexComboBox.Name = "SexComboBox"
        Me.SexComboBox.Size = New System.Drawing.Size(159, 24)
        Me.SexComboBox.TabIndex = 77
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
        'CancelGuestButton
        '
        Me.CancelGuestButton.Location = New System.Drawing.Point(785, 383)
        Me.CancelGuestButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelGuestButton.Name = "CancelGuestButton"
        Me.CancelGuestButton.Size = New System.Drawing.Size(151, 43)
        Me.CancelGuestButton.TabIndex = 65
        Me.CancelGuestButton.Text = "Cancel"
        Me.CancelGuestButton.UseVisualStyleBackColor = True
        '
        'AddNewGuestButton
        '
        Me.AddNewGuestButton.Location = New System.Drawing.Point(465, 383)
        Me.AddNewGuestButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AddNewGuestButton.Name = "AddNewGuestButton"
        Me.AddNewGuestButton.Size = New System.Drawing.Size(151, 43)
        Me.AddNewGuestButton.TabIndex = 64
        Me.AddNewGuestButton.Text = "Add"
        Me.AddNewGuestButton.UseVisualStyleBackColor = True
        '
        'TelephoneTextBox
        '
        Me.TelephoneTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TelephoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelephoneTextBox.Location = New System.Drawing.Point(650, 253)
        Me.TelephoneTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TelephoneTextBox.Multiline = True
        Me.TelephoneTextBox.Name = "TelephoneTextBox"
        Me.TelephoneTextBox.Size = New System.Drawing.Size(159, 30)
        Me.TelephoneTextBox.TabIndex = 53
        '
        'TelLabel
        '
        Me.TelLabel.AutoSize = True
        Me.TelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelLabel.Location = New System.Drawing.Point(550, 260)
        Me.TelLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TelLabel.Name = "TelLabel"
        Me.TelLabel.Size = New System.Drawing.Size(36, 20)
        Me.TelLabel.TabIndex = 63
        Me.TelLabel.Text = "Tel."
        '
        'SexLabel
        '
        Me.SexLabel.AutoSize = True
        Me.SexLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SexLabel.Location = New System.Drawing.Point(550, 190)
        Me.SexLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SexLabel.Name = "SexLabel"
        Me.SexLabel.Size = New System.Drawing.Size(37, 20)
        Me.SexLabel.TabIndex = 62
        Me.SexLabel.Text = "Sex"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.AgeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeTextBox.Location = New System.Drawing.Point(650, 113)
        Me.AgeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AgeTextBox.Multiline = True
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(159, 30)
        Me.AgeTextBox.TabIndex = 49
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeLabel.Location = New System.Drawing.Point(550, 120)
        Me.AgeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(38, 20)
        Me.AgeLabel.TabIndex = 59
        Me.AgeLabel.Text = "Age"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.AddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(212, 253)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(279, 90)
        Me.AddressTextBox.TabIndex = 40
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressLabel.Location = New System.Drawing.Point(51, 260)
        Me.AddressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(71, 20)
        Me.AddressLabel.TabIndex = 47
        Me.AddressLabel.Text = "Address"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LastNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTextBox.Location = New System.Drawing.Point(212, 183)
        Me.LastNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LastNameTextBox.Multiline = True
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(279, 30)
        Me.LastNameTextBox.TabIndex = 38
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameLabel.Location = New System.Drawing.Point(51, 190)
        Me.LastNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(91, 20)
        Me.LastNameLabel.TabIndex = 45
        Me.LastNameLabel.Text = "Last Name"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(212, 113)
        Me.FirstNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FirstNameTextBox.Multiline = True
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(279, 30)
        Me.FirstNameTextBox.TabIndex = 35
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameLabel.Location = New System.Drawing.Point(51, 120)
        Me.FirstNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(92, 20)
        Me.FirstNameLabel.TabIndex = 41
        Me.FirstNameLabel.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 29)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Add New Guest Form"
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
        Me.TabPage2.Controls.Add(Me.GuestTable)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(987, 461)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Guest List"
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
        Me.Label16.Size = New System.Drawing.Size(129, 29)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Guest List"
        '
        'GuestTable
        '
        Me.GuestTable.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.GuestTable.FullRowSelect = True
        Me.GuestTable.GridLines = True
        Me.GuestTable.HideSelection = False
        Me.GuestTable.Location = New System.Drawing.Point(16, 63)
        Me.GuestTable.Margin = New System.Windows.Forms.Padding(4)
        Me.GuestTable.Name = "GuestTable"
        Me.GuestTable.Size = New System.Drawing.Size(948, 390)
        Me.GuestTable.TabIndex = 0
        Me.GuestTable.UseCompatibleStateImageBehavior = False
        Me.GuestTable.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Guest ID"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "First Name"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Last Name"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Address"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 200
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Age"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Sex"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 80
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Tel"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 100
        '
        'AddNewGuestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 521)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "AddNewGuestForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Guest Form"
        Me.TabControl1.ResumeLayout(False)
        Me.AddGuestTabPage.ResumeLayout(False)
        Me.AddGuestTabPage.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents AddGuestTabPage As TabPage
    Friend WithEvents CancelGuestButton As Button
    Friend WithEvents AddNewGuestButton As Button
    Friend WithEvents TelephoneTextBox As TextBox
    Friend WithEvents TelLabel As Label
    Friend WithEvents SexLabel As Label
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents AgeLabel As Label
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents AddressLabel As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents Label1 As Label
    Private WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label16 As Label
    Friend WithEvents GuestTable As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ResetButton As Button
    Friend WithEvents SexComboBox As ComboBox
End Class
