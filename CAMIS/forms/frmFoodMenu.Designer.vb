<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFoodMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFoodMenu))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBcode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.available = New System.Windows.Forms.RadioButton()
        Me.outofstock = New System.Windows.Forms.RadioButton()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.itemID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader3})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(678, 446)
        Me.ListView1.TabIndex = 27
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 93
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Barcode"
        Me.ColumnHeader2.Width = 102
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Menu Name"
        Me.ColumnHeader4.Width = 284
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Price"
        Me.ColumnHeader5.Width = 97
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Available"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.LightGray
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripButton2, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1108, 40)
        Me.ToolStrip1.TabIndex = 26
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 37)
        Me.ToolStripLabel1.Text = "   "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Barcode"
        '
        'txtBcode
        '
        Me.txtBcode.Location = New System.Drawing.Point(105, 87)
        Me.txtBcode.Name = "txtBcode"
        Me.txtBcode.Size = New System.Drawing.Size(274, 20)
        Me.txtBcode.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Menu Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(105, 122)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(274, 20)
        Me.txtName.TabIndex = 33
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.lblStatus)
        Me.Panel1.Controls.Add(Me.itemID)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtPrice)
        Me.Panel1.Controls.Add(Me.txtBcode)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(678, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(430, 446)
        Me.Panel1.TabIndex = 37
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(304, 263)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.available)
        Me.GroupBox1.Controls.Add(Me.outofstock)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 201)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 44)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Availability"
        '
        'available
        '
        Me.available.AutoSize = True
        Me.available.Checked = True
        Me.available.Location = New System.Drawing.Point(67, 19)
        Me.available.Name = "available"
        Me.available.Size = New System.Drawing.Size(82, 17)
        Me.available.TabIndex = 0
        Me.available.TabStop = True
        Me.available.Text = "AVAILABLE"
        Me.available.UseVisualStyleBackColor = True
        '
        'outofstock
        '
        Me.outofstock.AutoSize = True
        Me.outofstock.Location = New System.Drawing.Point(187, 19)
        Me.outofstock.Name = "outofstock"
        Me.outofstock.Size = New System.Drawing.Size(104, 17)
        Me.outofstock.TabIndex = 0
        Me.outofstock.TabStop = True
        Me.outofstock.Text = "OUT OF STOCK"
        Me.outofstock.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Gray
        Me.lblStatus.Location = New System.Drawing.Point(31, 5)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(197, 42)
        Me.lblStatus.TabIndex = 2
        Me.lblStatus.Text = "FOOD MENU'S"
        '
        'itemID
        '
        Me.itemID.AutoSize = True
        Me.itemID.Location = New System.Drawing.Point(102, 57)
        Me.itemID.Name = "itemID"
        Me.itemID.Size = New System.Drawing.Size(44, 13)
        Me.itemID.TabIndex = 32
        Me.itemID.Text = "ITEMID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "ItemID"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(105, 160)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(274, 20)
        Me.txtPrice.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Price"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ListView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(678, 446)
        Me.Panel2.TabIndex = 38
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.AutoSize = False
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(65, 40)
        Me.ToolStripButton2.Text = "&Search"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(65, 40)
        Me.ToolStripButton1.Text = "Clos&e"
        '
        'frmFoodMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 486)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFoodMenu"
        Me.Text = "Category"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBcode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblStatus As Label
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents available As RadioButton
    Friend WithEvents outofstock As RadioButton
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents itemID As Label
    Friend WithEvents Label3 As Label
End Class
