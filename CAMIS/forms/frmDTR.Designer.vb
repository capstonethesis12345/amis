<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDTR
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtTimeOut = New System.Windows.Forms.Label()
        Me.txtEmpId = New System.Windows.Forms.Label()
        Me.txtTimein = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.r1 = New System.Windows.Forms.RadioButton()
        Me.r3 = New System.Windows.Forms.RadioButton()
        Me.r2 = New System.Windows.Forms.RadioButton()
        Me.MetroTextButton2 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.MetroTextButton1 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnTimeout = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(962, 5)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(24, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Daily time record"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ListView1)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(938, 380)
        Me.Panel2.TabIndex = 2
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(0, 5)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(938, 375)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 52
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "EmpID"
        Me.ColumnHeader2.Width = 94
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Name"
        Me.ColumnHeader3.Width = 203
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "IN"
        Me.ColumnHeader4.Width = 173
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Out"
        Me.ColumnHeader5.Width = 118
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Status"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(938, 5)
        Me.Panel4.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnTimeout)
        Me.Panel3.Controls.Add(Me.txtTimeOut)
        Me.Panel3.Controls.Add(Me.txtEmpId)
        Me.Panel3.Controls.Add(Me.txtTimein)
        Me.Panel3.Controls.Add(Me.lblId)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.MetroTextButton2)
        Me.Panel3.Controls.Add(Me.MetroTextButton1)
        Me.Panel3.Controls.Add(Me.MetroLabel4)
        Me.Panel3.Controls.Add(Me.MetroLabel5)
        Me.Panel3.Controls.Add(Me.MetroLabel2)
        Me.Panel3.Controls.Add(Me.MetroLabel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(694, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(244, 380)
        Me.Panel3.TabIndex = 3
        '
        'txtTimeOut
        '
        Me.txtTimeOut.AutoSize = True
        Me.txtTimeOut.Location = New System.Drawing.Point(56, 179)
        Me.txtTimeOut.Name = "txtTimeOut"
        Me.txtTimeOut.Size = New System.Drawing.Size(0, 13)
        Me.txtTimeOut.TabIndex = 11
        '
        'txtEmpId
        '
        Me.txtEmpId.AutoSize = True
        Me.txtEmpId.Location = New System.Drawing.Point(91, 45)
        Me.txtEmpId.Name = "txtEmpId"
        Me.txtEmpId.Size = New System.Drawing.Size(0, 13)
        Me.txtEmpId.TabIndex = 11
        '
        'txtTimein
        '
        Me.txtTimein.AutoSize = True
        Me.txtTimein.Location = New System.Drawing.Point(52, 114)
        Me.txtTimein.Name = "txtTimein"
        Me.txtTimein.Size = New System.Drawing.Size(0, 13)
        Me.txtTimein.TabIndex = 11
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(56, 14)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(39, 13)
        Me.lblId.TabIndex = 9
        Me.lblId.Text = "Label2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.r1)
        Me.GroupBox1.Controls.Add(Me.r3)
        Me.GroupBox1.Controls.Add(Me.r2)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 208)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(212, 54)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'r1
        '
        Me.r1.AutoSize = True
        Me.r1.Checked = True
        Me.r1.Location = New System.Drawing.Point(6, 19)
        Me.r1.Name = "r1"
        Me.r1.Size = New System.Drawing.Size(64, 17)
        Me.r1.TabIndex = 8
        Me.r1.TabStop = True
        Me.r1.Text = "Pending"
        Me.r1.UseVisualStyleBackColor = True
        '
        'r3
        '
        Me.r3.AutoSize = True
        Me.r3.Location = New System.Drawing.Point(152, 19)
        Me.r3.Name = "r3"
        Me.r3.Size = New System.Drawing.Size(50, 17)
        Me.r3.TabIndex = 7
        Me.r3.Text = "Deny"
        Me.r3.UseVisualStyleBackColor = True
        '
        'r2
        '
        Me.r2.AutoSize = True
        Me.r2.Location = New System.Drawing.Point(81, 19)
        Me.r2.Name = "r2"
        Me.r2.Size = New System.Drawing.Size(60, 17)
        Me.r2.TabIndex = 8
        Me.r2.Text = "Confirm"
        Me.r2.UseVisualStyleBackColor = True
        '
        'MetroTextButton2
        '
        Me.MetroTextButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroTextButton2.Image = Nothing
        Me.MetroTextButton2.Location = New System.Drawing.Point(65, 280)
        Me.MetroTextButton2.Name = "MetroTextButton2"
        Me.MetroTextButton2.Size = New System.Drawing.Size(81, 30)
        Me.MetroTextButton2.TabIndex = 6
        Me.MetroTextButton2.Text = "Close"
        Me.MetroTextButton2.UseSelectable = True
        Me.MetroTextButton2.UseVisualStyleBackColor = True
        '
        'MetroTextButton1
        '
        Me.MetroTextButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroTextButton1.Image = Nothing
        Me.MetroTextButton1.Location = New System.Drawing.Point(152, 280)
        Me.MetroTextButton1.Name = "MetroTextButton1"
        Me.MetroTextButton1.Size = New System.Drawing.Size(81, 30)
        Me.MetroTextButton1.TabIndex = 3
        Me.MetroTextButton1.Text = "Save"
        Me.MetroTextButton1.UseSelectable = True
        Me.MetroTextButton1.UseVisualStyleBackColor = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(21, 148)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel4.TabIndex = 2
        Me.MetroLabel4.Text = "Time Out"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(21, 75)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel5.TabIndex = 2
        Me.MetroLabel5.Text = "Time In"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(21, 8)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(21, 19)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "ID"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(21, 39)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Emp ID"
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Controls.Add(Me.Panel2)
        Me.Panel5.Location = New System.Drawing.Point(12, 64)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(938, 380)
        Me.Panel5.TabIndex = 4
        '
        'btnTimeout
        '
        Me.btnTimeout.BackColor = System.Drawing.Color.DarkCyan
        Me.btnTimeout.FlatAppearance.BorderSize = 0
        Me.btnTimeout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimeout.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeout.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnTimeout.Location = New System.Drawing.Point(87, 179)
        Me.btnTimeout.Name = "btnTimeout"
        Me.btnTimeout.Size = New System.Drawing.Size(75, 23)
        Me.btnTimeout.TabIndex = 12
        Me.btnTimeout.Text = "Time Out"
        Me.btnTimeout.UseVisualStyleBackColor = False
        '
        'frmDTR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 472)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDTR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDTR"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents MetroTextButton1 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextButton2 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents r3 As RadioButton
    Friend WithEvents r2 As RadioButton
    Friend WithEvents r1 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblId As Label
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTimeOut As Label
    Friend WithEvents txtTimein As Label
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtEmpId As Label
    Friend WithEvents btnTimeout As Button
End Class
