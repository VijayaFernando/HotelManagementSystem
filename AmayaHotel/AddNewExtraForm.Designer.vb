<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewExtraForm
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
        Me.ExtraTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.CancelNewExtraButton = New System.Windows.Forms.Button()
        Me.AddNewExtraButton = New System.Windows.Forms.Button()
        Me.ExtraTypeLabel = New System.Windows.Forms.Label()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.ExtraNameTextBox = New System.Windows.Forms.TextBox()
        Me.ExtraNameLabel = New System.Windows.Forms.Label()
        Me.AddNewExtraLabel = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ExtraTable = New System.Windows.Forms.ListView()
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
        Me.TabControl1.Location = New System.Drawing.Point(14, 19)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(995, 490)
        Me.TabControl1.TabIndex = 2
        '
        'AddGuestTabPage
        '
        Me.AddGuestTabPage.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AddGuestTabPage.Controls.Add(Me.ExtraTypeComboBox)
        Me.AddGuestTabPage.Controls.Add(Me.ResetButton)
        Me.AddGuestTabPage.Controls.Add(Me.CancelNewExtraButton)
        Me.AddGuestTabPage.Controls.Add(Me.AddNewExtraButton)
        Me.AddGuestTabPage.Controls.Add(Me.ExtraTypeLabel)
        Me.AddGuestTabPage.Controls.Add(Me.PriceTextBox)
        Me.AddGuestTabPage.Controls.Add(Me.PriceLabel)
        Me.AddGuestTabPage.Controls.Add(Me.ExtraNameTextBox)
        Me.AddGuestTabPage.Controls.Add(Me.ExtraNameLabel)
        Me.AddGuestTabPage.Controls.Add(Me.AddNewExtraLabel)
        Me.AddGuestTabPage.Controls.Add(Me.ShapeContainer1)
        Me.AddGuestTabPage.Location = New System.Drawing.Point(4, 25)
        Me.AddGuestTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.AddGuestTabPage.Name = "AddGuestTabPage"
        Me.AddGuestTabPage.Padding = New System.Windows.Forms.Padding(4)
        Me.AddGuestTabPage.Size = New System.Drawing.Size(987, 461)
        Me.AddGuestTabPage.TabIndex = 0
        Me.AddGuestTabPage.Text = "Add Extra"
        '
        'ExtraTypeComboBox
        '
        Me.ExtraTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ExtraTypeComboBox.FormattingEnabled = True
        Me.ExtraTypeComboBox.Items.AddRange(New Object() {"Travel Service", "Health Service", "Amenities", "Restaurent Service"})
        Me.ExtraTypeComboBox.Location = New System.Drawing.Point(212, 187)
        Me.ExtraTypeComboBox.Name = "ExtraTypeComboBox"
        Me.ExtraTypeComboBox.Size = New System.Drawing.Size(159, 24)
        Me.ExtraTypeComboBox.TabIndex = 77
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
        'CancelNewExtraButton
        '
        Me.CancelNewExtraButton.Location = New System.Drawing.Point(785, 383)
        Me.CancelNewExtraButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelNewExtraButton.Name = "CancelNewExtraButton"
        Me.CancelNewExtraButton.Size = New System.Drawing.Size(151, 43)
        Me.CancelNewExtraButton.TabIndex = 65
        Me.CancelNewExtraButton.Text = "Cancel"
        Me.CancelNewExtraButton.UseVisualStyleBackColor = True
        '
        'AddNewExtraButton
        '
        Me.AddNewExtraButton.Location = New System.Drawing.Point(465, 383)
        Me.AddNewExtraButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AddNewExtraButton.Name = "AddNewExtraButton"
        Me.AddNewExtraButton.Size = New System.Drawing.Size(151, 43)
        Me.AddNewExtraButton.TabIndex = 64
        Me.AddNewExtraButton.Text = "Add"
        Me.AddNewExtraButton.UseVisualStyleBackColor = True
        '
        'ExtraTypeLabel
        '
        Me.ExtraTypeLabel.AutoSize = True
        Me.ExtraTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExtraTypeLabel.Location = New System.Drawing.Point(51, 190)
        Me.ExtraTypeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ExtraTypeLabel.Name = "ExtraTypeLabel"
        Me.ExtraTypeLabel.Size = New System.Drawing.Size(89, 20)
        Me.ExtraTypeLabel.TabIndex = 62
        Me.ExtraTypeLabel.Text = "Extra Type"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceTextBox.Location = New System.Drawing.Point(212, 253)
        Me.PriceTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PriceTextBox.Multiline = True
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(200, 30)
        Me.PriceTextBox.TabIndex = 40
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLabel.Location = New System.Drawing.Point(51, 260)
        Me.PriceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(48, 20)
        Me.PriceLabel.TabIndex = 47
        Me.PriceLabel.Text = "Price"
        '
        'ExtraNameTextBox
        '
        Me.ExtraNameTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExtraNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExtraNameTextBox.Location = New System.Drawing.Point(212, 113)
        Me.ExtraNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ExtraNameTextBox.Multiline = True
        Me.ExtraNameTextBox.Name = "ExtraNameTextBox"
        Me.ExtraNameTextBox.Size = New System.Drawing.Size(279, 30)
        Me.ExtraNameTextBox.TabIndex = 35
        '
        'ExtraNameLabel
        '
        Me.ExtraNameLabel.AutoSize = True
        Me.ExtraNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExtraNameLabel.Location = New System.Drawing.Point(51, 120)
        Me.ExtraNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ExtraNameLabel.Name = "ExtraNameLabel"
        Me.ExtraNameLabel.Size = New System.Drawing.Size(97, 20)
        Me.ExtraNameLabel.TabIndex = 41
        Me.ExtraNameLabel.Text = "Extra Name"
        '
        'AddNewExtraLabel
        '
        Me.AddNewExtraLabel.AutoEllipsis = True
        Me.AddNewExtraLabel.AutoSize = True
        Me.AddNewExtraLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewExtraLabel.Location = New System.Drawing.Point(13, 30)
        Me.AddNewExtraLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AddNewExtraLabel.Name = "AddNewExtraLabel"
        Me.AddNewExtraLabel.Size = New System.Drawing.Size(253, 29)
        Me.AddNewExtraLabel.TabIndex = 36
        Me.AddNewExtraLabel.Text = "Add New Extra Form"
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
        Me.TabPage2.Controls.Add(Me.ExtraTable)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(987, 461)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Extra List"
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
        Me.Label16.Size = New System.Drawing.Size(120, 29)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Extra List"
        '
        'ExtraTable
        '
        Me.ExtraTable.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ExtraTable.FullRowSelect = True
        Me.ExtraTable.GridLines = True
        Me.ExtraTable.HideSelection = False
        Me.ExtraTable.Location = New System.Drawing.Point(16, 63)
        Me.ExtraTable.Margin = New System.Windows.Forms.Padding(4)
        Me.ExtraTable.Name = "ExtraTable"
        Me.ExtraTable.Size = New System.Drawing.Size(948, 390)
        Me.ExtraTable.TabIndex = 0
        Me.ExtraTable.UseCompatibleStateImageBehavior = False
        Me.ExtraTable.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Extra ID"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Extra Name"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Extra Type"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Price"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'AddNewExtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 528)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "AddNewExtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Extra Form"
        Me.TabControl1.ResumeLayout(False)
        Me.AddGuestTabPage.ResumeLayout(False)
        Me.AddGuestTabPage.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents AddGuestTabPage As TabPage
    Friend WithEvents ExtraTypeComboBox As ComboBox
    Friend WithEvents ResetButton As Button
    Friend WithEvents CancelNewExtraButton As Button
    Friend WithEvents AddNewExtraButton As Button
    Friend WithEvents ExtraTypeLabel As Label
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents PriceLabel As Label
    Friend WithEvents ExtraNameTextBox As TextBox
    Friend WithEvents ExtraNameLabel As Label
    Friend WithEvents AddNewExtraLabel As Label
    Private WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label16 As Label
    Friend WithEvents ExtraTable As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
