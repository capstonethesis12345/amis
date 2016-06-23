<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fMainForm
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tUsername = New System.Windows.Forms.TextBox()
        Me.tPassword = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtFunction = New System.Windows.Forms.TextBox()
        Me.erTextboxUser = New System.Windows.Forms.PictureBox()
        Me.erTextboxPass = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.erTextboxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erTextboxPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.AccountManagementIS.My.Resources.Resources.loginForm
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(26, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(349, 244)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'tUsername
        '
        Me.tUsername.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tUsername.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUsername.Location = New System.Drawing.Point(121, 95)
        Me.tUsername.Name = "tUsername"
        Me.tUsername.Size = New System.Drawing.Size(242, 20)
        Me.tUsername.TabIndex = 0
        '
        'tPassword
        '
        Me.tPassword.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tPassword.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPassword.Location = New System.Drawing.Point(121, 140)
        Me.tPassword.Name = "tPassword"
        Me.tPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tPassword.Size = New System.Drawing.Size(242, 20)
        Me.tPassword.TabIndex = 1
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSubmit.BackgroundImage = Global.AccountManagementIS.My.Resources.Resources.btnSubmit
        Me.btnSubmit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSubmit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.btnSubmit.Location = New System.Drawing.Point(33, 221)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(336, 41)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.MetroLabel1)
        Me.Panel1.Controls.Add(Me.txtFunction)
        Me.Panel1.Controls.Add(Me.btnSubmit)
        Me.Panel1.Controls.Add(Me.tUsername)
        Me.Panel1.Controls.Add(Me.tPassword)
        Me.Panel1.Controls.Add(Me.erTextboxUser)
        Me.Panel1.Controls.Add(Me.erTextboxPass)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(406, 292)
        Me.Panel1.TabIndex = 0
        '
        'txtFunction
        '
        Me.txtFunction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFunction.Location = New System.Drawing.Point(47, 175)
        Me.txtFunction.Name = "txtFunction"
        Me.txtFunction.Size = New System.Drawing.Size(100, 13)
        Me.txtFunction.TabIndex = 5
        Me.txtFunction.Visible = False
        '
        'erTextboxUser
        '
        Me.erTextboxUser.Location = New System.Drawing.Point(118, 91)
        Me.erTextboxUser.Name = "erTextboxUser"
        Me.erTextboxUser.Size = New System.Drawing.Size(248, 28)
        Me.erTextboxUser.TabIndex = 3
        Me.erTextboxUser.TabStop = False
        Me.erTextboxUser.Visible = False
        '
        'erTextboxPass
        '
        Me.erTextboxPass.Location = New System.Drawing.Point(118, 136)
        Me.erTextboxPass.Name = "erTextboxPass"
        Me.erTextboxPass.Size = New System.Drawing.Size(248, 28)
        Me.erTextboxPass.TabIndex = 4
        Me.erTextboxPass.TabStop = False
        Me.erTextboxPass.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.AccountManagementIS.My.Resources.Resources._720
        Me.PictureBox2.Location = New System.Drawing.Point(166, 170)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 18)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.ForeColor = System.Drawing.Color.DarkRed
        Me.MetroLabel1.Location = New System.Drawing.Point(134, 170)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(219, 19)
        Me.MetroLabel1.TabIndex = 7
        Me.MetroLabel1.Text = "Username and Password is incorrect"
        Me.MetroLabel1.Visible = False
        '
        'fMainForm
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AccountManagementIS.My.Resources.Resources.bgWallpaper
        Me.ClientSize = New System.Drawing.Size(436, 321)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fMainForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.erTextboxUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erTextboxPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tUsername As TextBox
    Friend WithEvents tPassword As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents erTextboxUser As PictureBox
    Friend WithEvents erTextboxPass As PictureBox
    Friend WithEvents txtFunction As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
