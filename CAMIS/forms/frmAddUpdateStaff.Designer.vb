<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddUpdateStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddUpdateStaff))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtContractNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtRole = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtAssigned = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtConfirmPWD = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtRequisitionNo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtMI = New System.Windows.Forms.TextBox()
        Me.txtCommision = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtBarangay = New System.Windows.Forms.TextBox()
        Me.txtProvince = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(3, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(236, 42)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Adding New Staff"
        '
        'txtContractNo
        '
        Me.txtContractNo.BackColor = System.Drawing.Color.White
        Me.txtContractNo.Location = New System.Drawing.Point(101, 195)
        Me.txtContractNo.Name = "txtContractNo"
        Me.txtContractNo.Size = New System.Drawing.Size(165, 23)
        Me.txtContractNo.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Contact No. :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtRole)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtRequisitionNo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtContractNo)
        Me.GroupBox1.Controls.Add(Me.txtZip)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCity)
        Me.GroupBox1.Controls.Add(Me.txtMI)
        Me.GroupBox1.Controls.Add(Me.txtCommision)
        Me.GroupBox1.Controls.Add(Me.txtRate)
        Me.GroupBox1.Controls.Add(Me.txtBarangay)
        Me.GroupBox1.Controls.Add(Me.txtProvince)
        Me.GroupBox1.Controls.Add(Me.txtStreet)
        Me.GroupBox1.Controls.Add(Me.txtFirstname)
        Me.GroupBox1.Controls.Add(Me.txtLastname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(40, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(637, 417)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Staff Information"
        '
        'txtRole
        '
        Me.txtRole.FormattingEnabled = True
        Me.txtRole.Items.AddRange(New Object() {"Admin", "Cashier"})
        Me.txtRole.Location = New System.Drawing.Point(101, 236)
        Me.txtRole.Name = "txtRole"
        Me.txtRole.Size = New System.Drawing.Size(165, 23)
        Me.txtRole.TabIndex = 9
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtAssigned)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txtConfirmPWD)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtPassword)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtUsername)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 265)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(635, 90)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "User Information"
        '
        'txtAssigned
        '
        Me.txtAssigned.BackColor = System.Drawing.Color.White
        Me.txtAssigned.Location = New System.Drawing.Point(110, 61)
        Me.txtAssigned.Name = "txtAssigned"
        Me.txtAssigned.Size = New System.Drawing.Size(165, 23)
        Me.txtAssigned.TabIndex = 13
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(25, 64)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(55, 15)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "Assigned"
        '
        'txtConfirmPWD
        '
        Me.txtConfirmPWD.BackColor = System.Drawing.Color.White
        Me.txtConfirmPWD.Location = New System.Drawing.Point(444, 55)
        Me.txtConfirmPWD.Name = "txtConfirmPWD"
        Me.txtConfirmPWD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPWD.Size = New System.Drawing.Size(165, 23)
        Me.txtConfirmPWD.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(330, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 15)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Confirm Password :"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.Location = New System.Drawing.Point(444, 27)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(165, 23)
        Me.txtPassword.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(330, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 15)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Password :"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.Location = New System.Drawing.Point(110, 27)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(165, 23)
        Me.txtUsername.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Username :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(443, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 12)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Zip"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Role :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(443, 112)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 12)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "City"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(443, 71)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 12)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "MI"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(443, 221)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 12)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "Commission"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(99, 221)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 12)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Position"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(273, 221)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(28, 12)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Rate"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(270, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 12)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Barangay"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(270, 71)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 12)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Firstname"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(99, 151)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 12)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Province"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(99, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 12)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Street"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(99, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 12)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Lastname"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Location = New System.Drawing.Point(1, 355)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(626, 68)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(545, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 33)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "&Cancel"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(464, 22)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 33)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save "
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtRequisitionNo
        '
        Me.txtRequisitionNo.BackColor = System.Drawing.Color.Lavender
        Me.txtRequisitionNo.Location = New System.Drawing.Point(101, 43)
        Me.txtRequisitionNo.Name = "txtRequisitionNo"
        Me.txtRequisitionNo.Size = New System.Drawing.Size(165, 22)
        Me.txtRequisitionNo.TabIndex = 0
        Me.txtRequisitionNo.Text = " "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Address :"
        '
        'txtZip
        '
        Me.txtZip.BackColor = System.Drawing.Color.White
        Me.txtZip.Location = New System.Drawing.Point(443, 166)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(166, 23)
        Me.txtZip.TabIndex = 7
        '
        'txtCity
        '
        Me.txtCity.BackColor = System.Drawing.Color.White
        Me.txtCity.Location = New System.Drawing.Point(443, 127)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(166, 23)
        Me.txtCity.TabIndex = 5
        '
        'txtMI
        '
        Me.txtMI.BackColor = System.Drawing.Color.White
        Me.txtMI.Location = New System.Drawing.Point(443, 86)
        Me.txtMI.Name = "txtMI"
        Me.txtMI.Size = New System.Drawing.Size(39, 23)
        Me.txtMI.TabIndex = 2
        '
        'txtCommision
        '
        Me.txtCommision.BackColor = System.Drawing.Color.White
        Me.txtCommision.Location = New System.Drawing.Point(444, 236)
        Me.txtCommision.Name = "txtCommision"
        Me.txtCommision.Size = New System.Drawing.Size(165, 23)
        Me.txtCommision.TabIndex = 11
        '
        'txtRate
        '
        Me.txtRate.BackColor = System.Drawing.Color.White
        Me.txtRate.Location = New System.Drawing.Point(272, 236)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(165, 23)
        Me.txtRate.TabIndex = 10
        '
        'txtBarangay
        '
        Me.txtBarangay.BackColor = System.Drawing.Color.White
        Me.txtBarangay.Location = New System.Drawing.Point(272, 127)
        Me.txtBarangay.Name = "txtBarangay"
        Me.txtBarangay.Size = New System.Drawing.Size(165, 23)
        Me.txtBarangay.TabIndex = 4
        '
        'txtProvince
        '
        Me.txtProvince.BackColor = System.Drawing.Color.White
        Me.txtProvince.Location = New System.Drawing.Point(101, 166)
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(336, 23)
        Me.txtProvince.TabIndex = 6
        '
        'txtStreet
        '
        Me.txtStreet.BackColor = System.Drawing.Color.White
        Me.txtStreet.Location = New System.Drawing.Point(101, 127)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(165, 23)
        Me.txtStreet.TabIndex = 3
        '
        'txtFirstname
        '
        Me.txtFirstname.BackColor = System.Drawing.Color.White
        Me.txtFirstname.Location = New System.Drawing.Point(272, 86)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(165, 23)
        Me.txtFirstname.TabIndex = 1
        '
        'txtLastname
        '
        Me.txtLastname.BackColor = System.Drawing.Color.White
        Me.txtLastname.Location = New System.Drawing.Point(101, 86)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(165, 23)
        Me.txtLastname.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Employee No"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(661, 66)
        Me.Panel1.TabIndex = 5
        '
        'frmAddUpdateStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(650, 524)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddUpdateStaff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtContractNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtRequisitionNo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLastname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtMI As System.Windows.Forms.TextBox
    Friend WithEvents txtBarangay As System.Windows.Forms.TextBox
    Friend WithEvents txtProvince As System.Windows.Forms.TextBox
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtConfirmPWD As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRole As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtCommision As System.Windows.Forms.TextBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAssigned As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
End Class
