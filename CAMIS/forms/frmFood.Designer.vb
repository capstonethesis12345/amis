<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFood
    Inherits MetroFramework.Forms.MetroForm

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
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.Quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox3 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox4 = New MetroFramework.Controls.MetroTextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.Location = New System.Drawing.Point(33, 123)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(230, 330)
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
        Me.ListView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ItemID, Me.Description, Me.Quantity})
        Me.ListView2.Location = New System.Drawing.Point(344, 126)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(289, 330)
        Me.ListView2.TabIndex = 1
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ItemID
        '
        Me.ItemID.Text = "ItemID"
        '
        'Description
        '
        Me.Description.Text = "Description"
        Me.Description.Width = 135
        '
        'ListView3
        '
        Me.ListView3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView3.Location = New System.Drawing.Point(827, 126)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(298, 327)
        Me.ListView3.TabIndex = 2
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ingredient List"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(410, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contains"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(824, 110)
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
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(122, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(33, 69)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.Size = New System.Drawing.Size(144, 23)
        Me.MetroTextBox1.TabIndex = 17
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMark = "Search Item"
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Quantity
        '
        Me.Quantity.Text = "Quantity"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(269, 126)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(62, 100)
        Me.Panel1.TabIndex = 18
        '
        'MetroTextBox2
        '
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = Nothing
        Me.MetroTextBox2.CustomButton.Location = New System.Drawing.Point(214, 1)
        Me.MetroTextBox2.CustomButton.Name = ""
        Me.MetroTextBox2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox2.CustomButton.TabIndex = 1
        Me.MetroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox2.CustomButton.UseSelectable = True
        Me.MetroTextBox2.CustomButton.Visible = False
        Me.MetroTextBox2.Lines = New String(-1) {}
        Me.MetroTextBox2.Location = New System.Drawing.Point(639, 126)
        Me.MetroTextBox2.MaxLength = 32767
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.SelectionLength = 0
        Me.MetroTextBox2.SelectionStart = 0
        Me.MetroTextBox2.Size = New System.Drawing.Size(182, 23)
        Me.MetroTextBox2.TabIndex = 17
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMark = "Barcode"
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTextBox3
        '
        '
        '
        '
        Me.MetroTextBox3.CustomButton.Image = Nothing
        Me.MetroTextBox3.CustomButton.Location = New System.Drawing.Point(214, 1)
        Me.MetroTextBox3.CustomButton.Name = ""
        Me.MetroTextBox3.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox3.CustomButton.TabIndex = 1
        Me.MetroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox3.CustomButton.UseSelectable = True
        Me.MetroTextBox3.CustomButton.Visible = False
        Me.MetroTextBox3.Lines = New String(-1) {}
        Me.MetroTextBox3.Location = New System.Drawing.Point(639, 155)
        Me.MetroTextBox3.MaxLength = 32767
        Me.MetroTextBox3.Name = "MetroTextBox3"
        Me.MetroTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox3.SelectedText = ""
        Me.MetroTextBox3.SelectionLength = 0
        Me.MetroTextBox3.SelectionStart = 0
        Me.MetroTextBox3.Size = New System.Drawing.Size(182, 23)
        Me.MetroTextBox3.TabIndex = 17
        Me.MetroTextBox3.UseSelectable = True
        Me.MetroTextBox3.WaterMark = "Menu Name"
        Me.MetroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTextBox4
        '
        '
        '
        '
        Me.MetroTextBox4.CustomButton.Image = Nothing
        Me.MetroTextBox4.CustomButton.Location = New System.Drawing.Point(214, 1)
        Me.MetroTextBox4.CustomButton.Name = ""
        Me.MetroTextBox4.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox4.CustomButton.TabIndex = 1
        Me.MetroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox4.CustomButton.UseSelectable = True
        Me.MetroTextBox4.CustomButton.Visible = False
        Me.MetroTextBox4.Lines = New String(-1) {}
        Me.MetroTextBox4.Location = New System.Drawing.Point(639, 184)
        Me.MetroTextBox4.MaxLength = 32767
        Me.MetroTextBox4.Name = "MetroTextBox4"
        Me.MetroTextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox4.SelectedText = ""
        Me.MetroTextBox4.SelectionLength = 0
        Me.MetroTextBox4.SelectionStart = 0
        Me.MetroTextBox4.Size = New System.Drawing.Size(182, 23)
        Me.MetroTextBox4.TabIndex = 17
        Me.MetroTextBox4.UseSelectable = True
        Me.MetroTextBox4.WaterMark = "Price"
        Me.MetroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox4.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightSlateGray
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button3.Location = New System.Drawing.Point(746, 225)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 63)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Barcode"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Description"
        Me.ColumnHeader4.Width = 118
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Price"
        Me.ColumnHeader5.Width = 114
        '
        'frmFood
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1137, 465)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroTextBox4)
        Me.Controls.Add(Me.MetroTextBox3)
        Me.Controls.Add(Me.MetroTextBox2)
        Me.Controls.Add(Me.MetroTextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView3)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "frmFood"
        Me.Text = "Food Set-up"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Quantity As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox4 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
End Class
