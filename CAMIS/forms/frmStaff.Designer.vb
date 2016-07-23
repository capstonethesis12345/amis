<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStaff))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtJobs = New System.Windows.Forms.ComboBox()
        Me.txtMaritalStatus = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnOpenImage = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtEmpStarted = New System.Windows.Forms.DateTimePicker()
        Me.txtBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.txtGender = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtBirthAddress = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtEmployStatus = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtConfirmPWD = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFunction = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEmployeeNo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtContractNo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtMI = New System.Windows.Forms.TextBox()
        Me.txtBarangay = New System.Windows.Forms.TextBox()
        Me.txtProvince = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtSearch, Me.ToolStripLabel1, Me.ToolStripButton2, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(980, 40)
        Me.ToolStrip1.TabIndex = 28
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'txtSearch
        '
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(300, 40)
        Me.txtSearch.Visible = False
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
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(252, 578)
        Me.ListView1.TabIndex = 29
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "StaffID"
        Me.ColumnHeader1.Width = 75
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 360
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(252, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(728, 578)
        Me.Panel1.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtJobs)
        Me.GroupBox1.Controls.Add(Me.txtMaritalStatus)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnOpenImage)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txtEmpStarted)
        Me.GroupBox1.Controls.Add(Me.txtBirthDate)
        Me.GroupBox1.Controls.Add(Me.txtGender)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtBirthAddress)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.txtEmployStatus)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtEmployeeNo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtContractNo)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.txtZip)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCity)
        Me.GroupBox1.Controls.Add(Me.txtMI)
        Me.GroupBox1.Controls.Add(Me.txtBarangay)
        Me.GroupBox1.Controls.Add(Me.txtProvince)
        Me.GroupBox1.Controls.Add(Me.txtStreet)
        Me.GroupBox1.Controls.Add(Me.txtFirstname)
        Me.GroupBox1.Controls.Add(Me.txtLastname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(728, 578)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Staff Information"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(224, 348)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtJobs
        '
        Me.txtJobs.FormattingEnabled = True
        Me.txtJobs.Location = New System.Drawing.Point(131, 349)
        Me.txtJobs.Name = "txtJobs"
        Me.txtJobs.Size = New System.Drawing.Size(86, 23)
        Me.txtJobs.TabIndex = 21
        '
        'txtMaritalStatus
        '
        Me.txtMaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtMaritalStatus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.txtMaritalStatus.FormattingEnabled = True
        Me.txtMaritalStatus.Items.AddRange(New Object() {"Single", "Married", "Widow"})
        Me.txtMaritalStatus.Location = New System.Drawing.Point(104, 140)
        Me.txtMaritalStatus.MaxLength = 8
        Me.txtMaritalStatus.Name = "txtMaritalStatus"
        Me.txtMaritalStatus.Size = New System.Drawing.Size(161, 23)
        Me.txtMaritalStatus.TabIndex = 5
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(88, 393)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(210, 19)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "ENABLE ACCESS TO APPLICATION"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(527, 533)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(99, 33)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "&Clear/New"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnOpenImage
        '
        Me.btnOpenImage.Location = New System.Drawing.Point(513, 135)
        Me.btnOpenImage.Name = "btnOpenImage"
        Me.btnOpenImage.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenImage.TabIndex = 4
        Me.btnOpenImage.Text = "Image"
        Me.btnOpenImage.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(527, 479)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(99, 33)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(490, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'txtEmpStarted
        '
        Me.txtEmpStarted.CustomFormat = "yyyy-MM-dd"
        Me.txtEmpStarted.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtEmpStarted.Location = New System.Drawing.Point(397, 316)
        Me.txtEmpStarted.Name = "txtEmpStarted"
        Me.txtEmpStarted.Size = New System.Drawing.Size(165, 23)
        Me.txtEmpStarted.TabIndex = 7
        '
        'txtBirthDate
        '
        Me.txtBirthDate.CustomFormat = "yyyy-MM-dd"
        Me.txtBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtBirthDate.Location = New System.Drawing.Point(100, 166)
        Me.txtBirthDate.Name = "txtBirthDate"
        Me.txtBirthDate.Size = New System.Drawing.Size(165, 23)
        Me.txtBirthDate.TabIndex = 7
        '
        'txtGender
        '
        Me.txtGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtGender.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.txtGender.FormattingEnabled = True
        Me.txtGender.Items.AddRange(New Object() {"M", "F"})
        Me.txtGender.Location = New System.Drawing.Point(361, 135)
        Me.txtGender.MaxLength = 1
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(108, 23)
        Me.txtGender.TabIndex = 6
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(308, 140)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 15)
        Me.Label22.TabIndex = 15
        Me.Label22.Text = "Gender"
        '
        'txtBirthAddress
        '
        Me.txtBirthAddress.BackColor = System.Drawing.Color.White
        Me.txtBirthAddress.Location = New System.Drawing.Point(361, 166)
        Me.txtBirthAddress.Name = "txtBirthAddress"
        Me.txtBirthAddress.Size = New System.Drawing.Size(248, 23)
        Me.txtBirthAddress.TabIndex = 8
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(276, 168)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(77, 15)
        Me.Label24.TabIndex = 15
        Me.Label24.Text = "Birth Address"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(15, 168)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(56, 15)
        Me.Label23.TabIndex = 15
        Me.Label23.Text = "BirthDate"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(15, 138)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(79, 15)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "Marital Status"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Gray
        Me.lblStatus.Location = New System.Drawing.Point(12, 19)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(294, 42)
        Me.lblStatus.TabIndex = 14
        Me.lblStatus.Text = "Adding New Employee"
        '
        'txtEmployStatus
        '
        Me.txtEmployStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtEmployStatus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.txtEmployStatus.FormattingEnabled = True
        Me.txtEmployStatus.Items.AddRange(New Object() {"Regular", "Job Order", "Provisionary", "Contractual", "InActive"})
        Me.txtEmployStatus.Location = New System.Drawing.Point(131, 313)
        Me.txtEmployStatus.Name = "txtEmployStatus"
        Me.txtEmployStatus.Size = New System.Drawing.Size(136, 23)
        Me.txtEmployStatus.TabIndex = 15
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtConfirmPWD)
        Me.GroupBox3.Controls.Add(Me.txtPassword)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtUsername)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtFunction)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 418)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(508, 148)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "User Information"
        '
        'txtConfirmPWD
        '
        Me.txtConfirmPWD.BackColor = System.Drawing.Color.White
        Me.txtConfirmPWD.Location = New System.Drawing.Point(130, 113)
        Me.txtConfirmPWD.Name = "txtConfirmPWD"
        Me.txtConfirmPWD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPWD.Size = New System.Drawing.Size(362, 23)
        Me.txtConfirmPWD.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.Location = New System.Drawing.Point(130, 85)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(362, 23)
        Me.txtPassword.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(49, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 15)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Confirm:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(43, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 15)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Password :"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.Location = New System.Drawing.Point(130, 48)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(362, 23)
        Me.txtUsername.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Username :"
        '
        'txtFunction
        '
        Me.txtFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFunction.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.txtFunction.FormattingEnabled = True
        Me.txtFunction.Items.AddRange(New Object() {"Admin", "Manager", "Cashier", "Cook"})
        Me.txtFunction.Location = New System.Drawing.Point(130, 19)
        Me.txtFunction.Name = "txtFunction"
        Me.txtFunction.Size = New System.Drawing.Size(165, 23)
        Me.txtFunction.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(70, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Role :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(443, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 12)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Zip"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(443, 192)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 12)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "City"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(443, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 12)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "MI"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(270, 192)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 12)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Barangay"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(270, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 12)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Firstname"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(99, 231)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 12)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Province"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(99, 192)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 12)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Street"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(99, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 12)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Lastname"
        '
        'txtEmployeeNo
        '
        Me.txtEmployeeNo.BackColor = System.Drawing.Color.Lavender
        Me.txtEmployeeNo.Location = New System.Drawing.Point(101, 63)
        Me.txtEmployeeNo.Name = "txtEmployeeNo"
        Me.txtEmployeeNo.Size = New System.Drawing.Size(165, 22)
        Me.txtEmployeeNo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Address :"
        '
        'txtContractNo
        '
        Me.txtContractNo.BackColor = System.Drawing.Color.White
        Me.txtContractNo.Location = New System.Drawing.Point(102, 275)
        Me.txtContractNo.Name = "txtContractNo"
        Me.txtContractNo.Size = New System.Drawing.Size(165, 23)
        Me.txtContractNo.TabIndex = 14
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(15, 349)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 15)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Job Type"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(276, 321)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(115, 15)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Employment Started"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(15, 316)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(110, 15)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "Employment Status"
        '
        'txtZip
        '
        Me.txtZip.BackColor = System.Drawing.Color.White
        Me.txtZip.Location = New System.Drawing.Point(443, 246)
        Me.txtZip.MaxLength = 5
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(166, 23)
        Me.txtZip.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Contact No. :"
        '
        'txtCity
        '
        Me.txtCity.BackColor = System.Drawing.Color.White
        Me.txtCity.Location = New System.Drawing.Point(443, 207)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(166, 23)
        Me.txtCity.TabIndex = 11
        '
        'txtMI
        '
        Me.txtMI.BackColor = System.Drawing.Color.White
        Me.txtMI.Location = New System.Drawing.Point(443, 106)
        Me.txtMI.Name = "txtMI"
        Me.txtMI.Size = New System.Drawing.Size(39, 23)
        Me.txtMI.TabIndex = 3
        '
        'txtBarangay
        '
        Me.txtBarangay.BackColor = System.Drawing.Color.White
        Me.txtBarangay.Location = New System.Drawing.Point(272, 207)
        Me.txtBarangay.Name = "txtBarangay"
        Me.txtBarangay.Size = New System.Drawing.Size(165, 23)
        Me.txtBarangay.TabIndex = 10
        '
        'txtProvince
        '
        Me.txtProvince.BackColor = System.Drawing.Color.White
        Me.txtProvince.Location = New System.Drawing.Point(101, 246)
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(336, 23)
        Me.txtProvince.TabIndex = 12
        '
        'txtStreet
        '
        Me.txtStreet.BackColor = System.Drawing.Color.White
        Me.txtStreet.Location = New System.Drawing.Point(101, 207)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(165, 23)
        Me.txtStreet.TabIndex = 9
        '
        'txtFirstname
        '
        Me.txtFirstname.BackColor = System.Drawing.Color.White
        Me.txtFirstname.Location = New System.Drawing.Point(272, 106)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(165, 23)
        Me.txtFirstname.TabIndex = 2
        '
        'txtLastname
        '
        Me.txtLastname.BackColor = System.Drawing.Color.White
        Me.txtLastname.Location = New System.Drawing.Point(101, 106)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(165, 23)
        Me.txtLastname.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Employee No"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ListView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(252, 578)
        Me.Panel2.TabIndex = 31
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 618)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStaff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtFunction As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtConfirmPWD As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtEmployeeNo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtContractNo As TextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtMI As TextBox
    Friend WithEvents txtBarangay As TextBox
    Friend WithEvents txtProvince As TextBox
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtGender As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtBirthAddress As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtBirthDate As DateTimePicker
    Private WithEvents txtEmployStatus As ComboBox
    Friend WithEvents btnOpenImage As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtSearch As ToolStripTextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtMaritalStatus As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtJobs As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtEmpStarted As DateTimePicker
    Friend WithEvents Label18 As Label
End Class
