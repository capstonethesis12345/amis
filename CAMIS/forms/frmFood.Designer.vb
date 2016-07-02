<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFood
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ItemID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtBarcode = New MetroFramework.Controls.MetroTextBox()
        Me.txtMenuName = New MetroFramework.Controls.MetroTextBox()
        Me.txtPrice = New MetroFramework.Controls.MetroTextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(0, 32)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(251, 470)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ItemID"
        Me.ColumnHeader1.Width = 63
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Description"
        Me.ColumnHeader2.Width = 162
        '
        'ListView2
        '
        Me.ListView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ItemID, Me.Description, Me.Quantity, Me.ColumnHeader3})
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(0, 30)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(411, 465)
        Me.ListView2.TabIndex = 1
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ItemID
        '
        Me.ItemID.Text = "ItemID"
        Me.ItemID.Width = 79
        '
        'Description
        '
        Me.Description.Text = "Description"
        Me.Description.Width = 140
        '
        'Quantity
        '
        Me.Quantity.Text = "Unit"
        Me.Quantity.Width = 67
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Qty"
        '
        'ListView3
        '
        Me.ListView3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView3.FullRowSelect = True
        Me.ListView3.Location = New System.Drawing.Point(55, 38)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(403, 378)
        Me.ListView3.TabIndex = 2
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Barcode"
        Me.ColumnHeader4.Width = 99
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Food Name"
        Me.ColumnHeader5.Width = 114
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Price"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(72, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ingredient List"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(119, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contains"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Menu"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.Location = New System.Drawing.Point(9, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = ">>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button2.Location = New System.Drawing.Point(9, 50)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "<<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(257, 239)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(62, 100)
        Me.Panel1.TabIndex = 18
        '
        'txtBarcode
        '
        Me.txtBarcode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtBarcode.CustomButton.Image = Nothing
        Me.txtBarcode.CustomButton.Location = New System.Drawing.Point(457, 1)
        Me.txtBarcode.CustomButton.Name = ""
        Me.txtBarcode.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBarcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBarcode.CustomButton.TabIndex = 1
        Me.txtBarcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBarcode.CustomButton.UseSelectable = True
        Me.txtBarcode.CustomButton.Visible = False
        Me.txtBarcode.Lines = New String(-1) {}
        Me.txtBarcode.Location = New System.Drawing.Point(17, 19)
        Me.txtBarcode.MaxLength = 32767
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBarcode.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBarcode.SelectedText = ""
        Me.txtBarcode.SelectionLength = 0
        Me.txtBarcode.SelectionStart = 0
        Me.txtBarcode.Size = New System.Drawing.Size(479, 23)
        Me.txtBarcode.TabIndex = 17
        Me.txtBarcode.UseSelectable = True
        Me.txtBarcode.WaterMark = "Barcode"
        Me.txtBarcode.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBarcode.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtMenuName
        '
        Me.txtMenuName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtMenuName.CustomButton.Image = Nothing
        Me.txtMenuName.CustomButton.Location = New System.Drawing.Point(457, 1)
        Me.txtMenuName.CustomButton.Name = ""
        Me.txtMenuName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtMenuName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMenuName.CustomButton.TabIndex = 1
        Me.txtMenuName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMenuName.CustomButton.UseSelectable = True
        Me.txtMenuName.CustomButton.Visible = False
        Me.txtMenuName.Lines = New String(-1) {}
        Me.txtMenuName.Location = New System.Drawing.Point(17, 48)
        Me.txtMenuName.MaxLength = 32767
        Me.txtMenuName.Name = "txtMenuName"
        Me.txtMenuName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMenuName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMenuName.SelectedText = ""
        Me.txtMenuName.SelectionLength = 0
        Me.txtMenuName.SelectionStart = 0
        Me.txtMenuName.Size = New System.Drawing.Size(479, 23)
        Me.txtMenuName.TabIndex = 17
        Me.txtMenuName.UseSelectable = True
        Me.txtMenuName.WaterMark = "Menu Name"
        Me.txtMenuName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMenuName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPrice
        '
        Me.txtPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtPrice.CustomButton.Image = Nothing
        Me.txtPrice.CustomButton.Location = New System.Drawing.Point(457, 1)
        Me.txtPrice.CustomButton.Name = ""
        Me.txtPrice.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrice.CustomButton.TabIndex = 1
        Me.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrice.CustomButton.UseSelectable = True
        Me.txtPrice.CustomButton.Visible = False
        Me.txtPrice.Lines = New String(-1) {}
        Me.txtPrice.Location = New System.Drawing.Point(17, 77)
        Me.txtPrice.MaxLength = 32767
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrice.SelectedText = ""
        Me.txtPrice.SelectionLength = 0
        Me.txtPrice.SelectionStart = 0
        Me.txtPrice.ShowClearButton = True
        Me.txtPrice.Size = New System.Drawing.Size(479, 23)
        Me.txtPrice.TabIndex = 17
        Me.txtPrice.UseSelectable = True
        Me.txtPrice.WaterMark = "Price"
        Me.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPrice.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnSave.Location = New System.Drawing.Point(421, 106)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 44)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1271, 7)
        Me.Panel2.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(3, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(327, 40)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Food - Ingredient Settings"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.PowderBlue
        Me.Panel3.Controls.Add(Me.ListView2)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(323, 89)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(411, 495)
        Me.Panel3.TabIndex = 22
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.PowderBlue
        Me.Panel4.Controls.Add(Me.ListView1)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(3, 87)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(251, 502)
        Me.Panel4.TabIndex = 23
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.SkyBlue
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button4.Location = New System.Drawing.Point(340, 106)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 44)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Controls.Add(Me.Panel1)
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 7)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(757, 601)
        Me.Panel5.TabIndex = 24
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnSave)
        Me.Panel6.Controls.Add(Me.txtBarcode)
        Me.Panel6.Controls.Add(Me.txtMenuName)
        Me.Panel6.Controls.Add(Me.Button4)
        Me.Panel6.Controls.Add(Me.txtPrice)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(757, 7)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(514, 163)
        Me.Panel6.TabIndex = 25
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.ListView3)
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(757, 170)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(514, 438)
        Me.Panel7.TabIndex = 26
        '
        'frmFood
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1271, 608)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFood"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Food Set-up"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ListView3 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ItemID As ColumnHeader
    Friend WithEvents Description As ColumnHeader
    Friend WithEvents Quantity As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtBarcode As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMenuName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPrice As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents ColumnHeader3 As ColumnHeader
End Class
