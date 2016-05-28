<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatabase
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.txtServerHost = New System.Windows.Forms.TextBox()
        Me.cmdTest = New System.Windows.Forms.Button()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(7, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(344, 379)
        Me.Panel2.TabIndex = 27
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(344, 56)
        Me.Panel1.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(44, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(266, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Database Configuration"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.txtServerHost)
        Me.GroupBox1.Controls.Add(Me.cmdTest)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPort)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtDatabase)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 286)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connect to MySQL Server"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(206, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 35)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "CreateDB"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSave.Location = New System.Drawing.Point(121, 197)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 35)
        Me.cmdSave.TabIndex = 22
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'txtServerHost
        '
        Me.txtServerHost.BackColor = System.Drawing.SystemColors.Info
        Me.txtServerHost.Location = New System.Drawing.Point(109, 32)
        Me.txtServerHost.Name = "txtServerHost"
        Me.txtServerHost.Size = New System.Drawing.Size(174, 21)
        Me.txtServerHost.TabIndex = 0
        '
        'cmdTest
        '
        Me.cmdTest.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cmdTest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdTest.Location = New System.Drawing.Point(36, 197)
        Me.cmdTest.Name = "cmdTest"
        Me.cmdTest.Size = New System.Drawing.Size(80, 35)
        Me.cmdTest.TabIndex = 21
        Me.cmdTest.Text = "&Test"
        Me.cmdTest.UseVisualStyleBackColor = False
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.SystemColors.Info
        Me.txtUserName.Location = New System.Drawing.Point(109, 84)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(174, 21)
        Me.txtUserName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Username :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Database :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Port :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Password :"
        '
        'txtPort
        '
        Me.txtPort.BackColor = System.Drawing.SystemColors.Info
        Me.txtPort.Location = New System.Drawing.Point(109, 58)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(174, 21)
        Me.txtPort.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Info
        Me.txtPassword.Location = New System.Drawing.Point(109, 110)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(174, 21)
        Me.txtPassword.TabIndex = 3
        '
        'txtDatabase
        '
        Me.txtDatabase.BackColor = System.Drawing.SystemColors.Info
        Me.txtDatabase.Location = New System.Drawing.Point(109, 137)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(174, 21)
        Me.txtDatabase.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Server Host :"
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.Brown
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.SystemColors.Control
        Me.cmdClose.Location = New System.Drawing.Point(324, -3)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(27, 21)
        Me.cmdClose.TabIndex = 23
        Me.cmdClose.Text = "X"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 260)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(305, 23)
        Me.ProgressBar1.TabIndex = 24
        '
        'frmDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(358, 410)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmdClose)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database"
        Me.TopMost = True
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents txtServerHost As System.Windows.Forms.TextBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdTest As System.Windows.Forms.Button
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtDatabase As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
