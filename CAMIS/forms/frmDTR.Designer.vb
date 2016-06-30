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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MetroTextButton2 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.txtEmpNum = New MetroFramework.Controls.MetroComboBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.MetroTextButton1 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtEmpID = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtDateTime = New MetroFramework.Controls.MetroDateTime()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
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
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "EmpID"
        Me.ColumnHeader2.Width = 94
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Name"
        Me.ColumnHeader3.Width = 211
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "IN"
        Me.ColumnHeader4.Width = 173
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Out"
        Me.ColumnHeader5.Width = 132
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
        Me.Panel3.Controls.Add(Me.MetroTextButton2)
        Me.Panel3.Controls.Add(Me.txtEmpNum)
        Me.Panel3.Controls.Add(Me.RadioButton2)
        Me.Panel3.Controls.Add(Me.RadioButton1)
        Me.Panel3.Controls.Add(Me.MetroTextButton1)
        Me.Panel3.Controls.Add(Me.MetroLabel3)
        Me.Panel3.Controls.Add(Me.txtEmpID)
        Me.Panel3.Controls.Add(Me.MetroLabel2)
        Me.Panel3.Controls.Add(Me.MetroLabel1)
        Me.Panel3.Controls.Add(Me.txtDateTime)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(694, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(244, 380)
        Me.Panel3.TabIndex = 3
        '
        'MetroTextButton2
        '
        Me.MetroTextButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroTextButton2.Image = Nothing
        Me.MetroTextButton2.Location = New System.Drawing.Point(65, 198)
        Me.MetroTextButton2.Name = "MetroTextButton2"
        Me.MetroTextButton2.Size = New System.Drawing.Size(81, 30)
        Me.MetroTextButton2.TabIndex = 6
        Me.MetroTextButton2.Text = "Close"
        Me.MetroTextButton2.UseSelectable = True
        Me.MetroTextButton2.UseVisualStyleBackColor = True
        '
        'txtEmpNum
        '
        Me.txtEmpNum.FormattingEnabled = True
        Me.txtEmpNum.ItemHeight = 23
        Me.txtEmpNum.Location = New System.Drawing.Point(21, 83)
        Me.txtEmpNum.Name = "txtEmpNum"
        Me.txtEmpNum.Size = New System.Drawing.Size(212, 29)
        Me.txtEmpNum.TabIndex = 5
        Me.txtEmpNum.UseSelectable = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(158, 122)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.Text = "OUT"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(37, 122)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(36, 17)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "IN"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'MetroTextButton1
        '
        Me.MetroTextButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroTextButton1.Image = Nothing
        Me.MetroTextButton1.Location = New System.Drawing.Point(152, 198)
        Me.MetroTextButton1.Name = "MetroTextButton1"
        Me.MetroTextButton1.Size = New System.Drawing.Size(81, 30)
        Me.MetroTextButton1.TabIndex = 3
        Me.MetroTextButton1.Text = "Save"
        Me.MetroTextButton1.UseSelectable = True
        Me.MetroTextButton1.UseVisualStyleBackColor = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(48, 8)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(16, 19)
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "0"
        Me.MetroLabel3.Visible = False
        '
        'txtEmpID
        '
        Me.txtEmpID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmpID.AutoSize = True
        Me.txtEmpID.Location = New System.Drawing.Point(156, 8)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(16, 19)
        Me.txtEmpID.TabIndex = 2
        Me.txtEmpID.Text = "0"
        Me.txtEmpID.Visible = False
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
        Me.MetroLabel2.Visible = False
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(98, 8)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Emp ID"
        Me.MetroLabel1.Visible = False
        '
        'txtDateTime
        '
        Me.txtDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDateTime.Location = New System.Drawing.Point(21, 154)
        Me.txtDateTime.MinimumSize = New System.Drawing.Size(0, 29)
        Me.txtDateTime.Name = "txtDateTime"
        Me.txtDateTime.Size = New System.Drawing.Size(212, 29)
        Me.txtDateTime.TabIndex = 1
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
    Friend WithEvents txtEmpID As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDateTime As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtEmpNum As MetroFramework.Controls.MetroComboBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextButton2 As MetroFramework.Controls.MetroTextBox.MetroTextButton
End Class
