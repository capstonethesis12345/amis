<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategory))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCategoryName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCategoryId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(561, 446)
        Me.ListView1.TabIndex = 27
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Category No."
        Me.ColumnHeader1.Width = 93
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Category Name"
        Me.ColumnHeader2.Width = 194
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Description"
        Me.ColumnHeader3.Width = 311
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.LightGray
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripButton2, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(958, 40)
        Me.ToolStrip1.TabIndex = 26
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 37)
        Me.ToolStripLabel1.Text = "   "
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ListView1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(561, 446)
        Me.Panel1.TabIndex = 32
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.lblStatus)
        Me.Panel2.Controls.Add(Me.txtDescription)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtCategoryName)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtCategoryId)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(561, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(397, 446)
        Me.Panel2.TabIndex = 33
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = Global.AccountManagementIS.My.Resources.Resources.clear_icon16x16
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(296, 254)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 33)
        Me.btnClear.TabIndex = 38
        Me.btnClear.Text = "&Clear"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(296, 200)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 33)
        Me.btnSave.TabIndex = 37
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Gray
        Me.lblStatus.Location = New System.Drawing.Point(19, 20)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(286, 42)
        Me.lblStatus.TabIndex = 2
        Me.lblStatus.Text = "Adding New Category"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(151, 151)
        Me.txtDescription.MaxLength = 245
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(220, 20)
        Me.txtDescription.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Category Description"
        '
        'txtCategoryName
        '
        Me.txtCategoryName.Location = New System.Drawing.Point(127, 113)
        Me.txtCategoryName.MaxLength = 245
        Me.txtCategoryName.Name = "txtCategoryName"
        Me.txtCategoryName.Size = New System.Drawing.Size(244, 20)
        Me.txtCategoryName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Category Name"
        '
        'txtCategoryId
        '
        Me.txtCategoryId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCategoryId.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoryId.Location = New System.Drawing.Point(127, 75)
        Me.txtCategoryId.Name = "txtCategoryId"
        Me.txtCategoryId.ReadOnly = True
        Me.txtCategoryId.Size = New System.Drawing.Size(178, 16)
        Me.txtCategoryId.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Category ID"
        '
        'frmCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 486)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCategory"
        Me.Text = "Category"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCategoryName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCategoryId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
End Class
