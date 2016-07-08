<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.ListItems = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOrderNum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPaid = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnOrderItem = New System.Windows.Forms.Button()
        Me.cbCustomer = New System.Windows.Forms.ComboBox()
        Me.txtProductName = New System.Windows.Forms.ComboBox()
        Me.txtQuantity = New MetroFramework.Controls.MetroTextBox()
        Me.txtBarcode = New MetroFramework.Controls.MetroTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblBuildID = New System.Windows.Forms.Label()
        Me.lblItemid = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(177, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date"
        Me.Label1.Visible = False
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(223, 8)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(100, 22)
        Me.txtDate.TabIndex = 1
        Me.txtDate.Visible = False
        '
        'ListItems
        '
        Me.ListItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListItems.FullRowSelect = True
        Me.ListItems.GridLines = True
        Me.ListItems.Location = New System.Drawing.Point(6, 3)
        Me.ListItems.Name = "ListItems"
        Me.ListItems.Size = New System.Drawing.Size(496, 366)
        Me.ListItems.TabIndex = 4
        Me.ListItems.UseCompatibleStateImageBehavior = False
        Me.ListItems.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ITEM"
        Me.ColumnHeader1.Width = 222
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "QUANTITY"
        Me.ColumnHeader2.Width = 83
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PRICE"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 87
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Amount"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 83
        '
        'txtPrice
        '
        Me.txtPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrice.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(89, 148)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(124, 19)
        Me.txtPrice.TabIndex = 8
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Price"
        '
        'txtOrderNum
        '
        Me.txtOrderNum.Location = New System.Drawing.Point(409, 8)
        Me.txtOrderNum.Name = "txtOrderNum"
        Me.txtOrderNum.ReadOnly = True
        Me.txtOrderNum.Size = New System.Drawing.Size(139, 22)
        Me.txtOrderNum.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(339, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Order #"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(231, 383)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 27)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "TOTAL"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(334, 375)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(167, 35)
        Me.txtTotal.TabIndex = 14
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(19, 422)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(187, 38)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Select an item on the list and press Delete button to delete"
        '
        'txtPaid
        '
        Me.txtPaid.Location = New System.Drawing.Point(380, 493)
        Me.txtPaid.Name = "txtPaid"
        Me.txtPaid.Size = New System.Drawing.Size(219, 22)
        Me.txtPaid.TabIndex = 19
        Me.txtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(454, 463)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 27)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Cash"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(19, 362)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(187, 51)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "F1: Save Transaction" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F3: Cancel Transcation Alt+F4: Close"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.txtTotal)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.ListItems)
        Me.Panel1.Location = New System.Drawing.Point(223, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(506, 424)
        Me.Panel1.TabIndex = 29
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.btnLogout)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.txtOrderNum)
        Me.Panel2.Controls.Add(Me.txtPaid)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.btnOrderItem)
        Me.Panel2.Controls.Add(Me.txtDate)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.cbCustomer)
        Me.Panel2.Controls.Add(Me.txtProductName)
        Me.Panel2.Controls.Add(Me.txtQuantity)
        Me.Panel2.Controls.Add(Me.txtBarcode)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.txtPrice)
        Me.Panel2.Location = New System.Drawing.Point(93, 112)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(740, 534)
        Me.Panel2.TabIndex = 30
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(649, 7)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 15
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(572, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(605, 463)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 52)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Transact"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnOrderItem
        '
        Me.btnOrderItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOrderItem.Location = New System.Drawing.Point(89, 205)
        Me.btnOrderItem.Name = "btnOrderItem"
        Me.btnOrderItem.Size = New System.Drawing.Size(124, 23)
        Me.btnOrderItem.TabIndex = 33
        Me.btnOrderItem.Text = "Add"
        Me.btnOrderItem.UseVisualStyleBackColor = True
        '
        'cbCustomer
        '
        Me.cbCustomer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cbCustomer.FormattingEnabled = True
        Me.cbCustomer.Location = New System.Drawing.Point(9, 39)
        Me.cbCustomer.Name = "cbCustomer"
        Me.cbCustomer.Size = New System.Drawing.Size(204, 24)
        Me.cbCustomer.TabIndex = 32
        Me.cbCustomer.Text = "Walk-IN"
        '
        'txtProductName
        '
        Me.txtProductName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtProductName.FormattingEnabled = True
        Me.txtProductName.Location = New System.Drawing.Point(9, 85)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(204, 24)
        Me.txtProductName.TabIndex = 32
        '
        'txtQuantity
        '
        Me.txtQuantity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtQuantity.CustomButton.Image = Nothing
        Me.txtQuantity.CustomButton.Location = New System.Drawing.Point(102, 1)
        Me.txtQuantity.CustomButton.Name = ""
        Me.txtQuantity.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtQuantity.CustomButton.TabIndex = 1
        Me.txtQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtQuantity.CustomButton.UseSelectable = True
        Me.txtQuantity.CustomButton.Visible = False
        Me.txtQuantity.Lines = New String(-1) {}
        Me.txtQuantity.Location = New System.Drawing.Point(89, 176)
        Me.txtQuantity.MaxLength = 32767
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtQuantity.SelectedText = ""
        Me.txtQuantity.SelectionLength = 0
        Me.txtQuantity.SelectionStart = 0
        Me.txtQuantity.Size = New System.Drawing.Size(124, 23)
        Me.txtQuantity.TabIndex = 31
        Me.txtQuantity.UseSelectable = True
        Me.txtQuantity.WaterMark = "Quantity"
        Me.txtQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtQuantity.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtBarcode
        '
        Me.txtBarcode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtBarcode.CustomButton.Image = Nothing
        Me.txtBarcode.CustomButton.Location = New System.Drawing.Point(182, 1)
        Me.txtBarcode.CustomButton.Name = ""
        Me.txtBarcode.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBarcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBarcode.CustomButton.TabIndex = 1
        Me.txtBarcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBarcode.CustomButton.UseSelectable = True
        Me.txtBarcode.CustomButton.Visible = False
        Me.txtBarcode.FontWeight = MetroFramework.MetroTextBoxWeight.Light
        Me.txtBarcode.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtBarcode.Lines = New String(-1) {}
        Me.txtBarcode.Location = New System.Drawing.Point(9, 119)
        Me.txtBarcode.MaxLength = 100
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBarcode.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBarcode.SelectedText = ""
        Me.txtBarcode.SelectionLength = 0
        Me.txtBarcode.SelectionStart = 0
        Me.txtBarcode.Size = New System.Drawing.Size(204, 23)
        Me.txtBarcode.TabIndex = 30
        Me.txtBarcode.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBarcode.UseSelectable = True
        Me.txtBarcode.WaterMark = "Barcode"
        Me.txtBarcode.WaterMarkColor = System.Drawing.Color.SlateGray
        Me.txtBarcode.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Customer"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Product Name"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tax"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(89, 234)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(124, 19)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblBuildID
        '
        Me.lblBuildID.AutoSize = True
        Me.lblBuildID.Location = New System.Drawing.Point(31, 201)
        Me.lblBuildID.Name = "lblBuildID"
        Me.lblBuildID.Size = New System.Drawing.Size(64, 16)
        Me.lblBuildID.TabIndex = 7
        Me.lblBuildID.Text = "BUILDID"
        '
        'lblItemid
        '
        Me.lblItemid.AutoSize = True
        Me.lblItemid.Location = New System.Drawing.Point(31, 217)
        Me.lblItemid.Name = "lblItemid"
        Me.lblItemid.Size = New System.Drawing.Size(56, 16)
        Me.lblItemid.TabIndex = 7
        Me.lblItemid.Text = "ITEMID"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 178)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Customer"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.AccountManagementIS.My.Resources.Resources.lineSalesbar
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(-7, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1926, 13)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.SteelBlue
        Me.PictureBox2.Location = New System.Drawing.Point(605, 511)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(123, 5)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(923, 669)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblItemid)
        Me.Controls.Add(Me.lblBuildID)
        Me.Controls.Add(Me.Label11)
        Me.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Movable = False
        Me.Name = "frmSales"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Transaction"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents ListItems As System.Windows.Forms.ListView
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtOrderNum As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPaid As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtQuantity As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBarcode As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtProductName As ComboBox
    Friend WithEvents btnOrderItem As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblBuildID As Label
    Friend WithEvents lblItemid As Label
    Friend WithEvents cbCustomer As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
