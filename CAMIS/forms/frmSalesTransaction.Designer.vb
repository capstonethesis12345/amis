<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSalesTransaction
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtCash = New MetroFramework.Controls.MetroTextBox()
        Me.lTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New MetroFramework.Controls.MetroTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lTableNum = New System.Windows.Forms.Label()
        Me.tTableNum = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnDeliveies = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lEmpNum = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Location = New System.Drawing.Point(12, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(722, 399)
        Me.Panel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Brown
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(722, 399)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Firebrick
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(740, 75)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(501, 399)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(501, 399)
        Me.Panel3.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ListView1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(501, 343)
        Me.Panel4.TabIndex = 3
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(501, 343)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "DESCRIPTION"
        Me.ColumnHeader1.Width = 352
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "QTY"
        Me.ColumnHeader2.Width = 78
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PRICE"
        Me.ColumnHeader3.Width = 71
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "BuildID"
        Me.ColumnHeader4.Width = 79
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtCash)
        Me.Panel5.Controls.Add(Me.lTotal)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 343)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(501, 56)
        Me.Panel5.TabIndex = 2
        '
        'txtCash
        '
        Me.txtCash.BackColor = System.Drawing.Color.Tomato
        '
        '
        '
        Me.txtCash.CustomButton.Image = Nothing
        Me.txtCash.CustomButton.Location = New System.Drawing.Point(141, 2)
        Me.txtCash.CustomButton.Name = ""
        Me.txtCash.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.txtCash.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCash.CustomButton.TabIndex = 1
        Me.txtCash.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCash.CustomButton.UseSelectable = True
        Me.txtCash.CustomButton.Visible = False
        Me.txtCash.DisplayIcon = True
        Me.txtCash.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtCash.ForeColor = System.Drawing.Color.Maroon
        Me.txtCash.Lines = New String(-1) {}
        Me.txtCash.Location = New System.Drawing.Point(319, 9)
        Me.txtCash.MaxLength = 10000
        Me.txtCash.Name = "txtCash"
        Me.txtCash.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCash.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCash.SelectedText = ""
        Me.txtCash.SelectionLength = 0
        Me.txtCash.SelectionStart = 0
        Me.txtCash.ShowClearButton = True
        Me.txtCash.Size = New System.Drawing.Size(179, 40)
        Me.txtCash.TabIndex = 4
        Me.txtCash.TabStop = False
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCash.UseCustomBackColor = True
        Me.txtCash.UseCustomForeColor = True
        Me.txtCash.UseSelectable = True
        Me.txtCash.UseStyleColors = True
        Me.txtCash.WaterMark = "CASH"
        Me.txtCash.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCash.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lTotal
        '
        Me.lTotal.AutoSize = True
        Me.lTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lTotal.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTotal.ForeColor = System.Drawing.Color.Transparent
        Me.lTotal.Location = New System.Drawing.Point(69, 24)
        Me.lTotal.Name = "lTotal"
        Me.lTotal.Size = New System.Drawing.Size(46, 25)
        Me.lTotal.TabIndex = 3
        Me.lTotal.Text = "0.0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(26, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "TOTAL AMOUNT"
        '
        'txtSearch
        '
        '
        '
        '
        Me.txtSearch.CustomButton.BackColor = System.Drawing.Color.Firebrick
        Me.txtSearch.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtSearch.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtSearch.CustomButton.Image = Nothing
        Me.txtSearch.CustomButton.Location = New System.Drawing.Point(579, 2)
        Me.txtSearch.CustomButton.Margin = New System.Windows.Forms.Padding(0)
        Me.txtSearch.CustomButton.Name = ""
        Me.txtSearch.CustomButton.Size = New System.Drawing.Size(31, 31)
        Me.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Orange
        Me.txtSearch.CustomButton.TabIndex = 1
        Me.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearch.CustomButton.UseCustomBackColor = True
        Me.txtSearch.CustomButton.UseSelectable = True
        Me.txtSearch.CustomButton.UseVisualStyleBackColor = True
        Me.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtSearch.Lines = New String(-1) {}
        Me.txtSearch.Location = New System.Drawing.Point(12, 33)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.ShowButton = True
        Me.txtSearch.ShowClearButton = True
        Me.txtSearch.Size = New System.Drawing.Size(613, 36)
        Me.txtSearch.TabIndex = 2
        Me.txtSearch.UseSelectable = True
        Me.txtSearch.WaterMark = "Search"
        Me.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(846, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TABLE #"
        '
        'lTableNum
        '
        Me.lTableNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lTableNum.AutoSize = True
        Me.lTableNum.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTableNum.ForeColor = System.Drawing.Color.DarkRed
        Me.lTableNum.Location = New System.Drawing.Point(920, 47)
        Me.lTableNum.Name = "lTableNum"
        Me.lTableNum.Size = New System.Drawing.Size(19, 21)
        Me.lTableNum.TabIndex = 3
        Me.lTableNum.Text = "0"
        '
        'tTableNum
        '
        Me.tTableNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tTableNum.Location = New System.Drawing.Point(922, 48)
        Me.tTableNum.Name = "tTableNum"
        Me.tTableNum.Size = New System.Drawing.Size(34, 20)
        Me.tTableNum.TabIndex = 4
        Me.tTableNum.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'btnDeliveies
        '
        Me.btnDeliveies.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeliveies.BackColor = System.Drawing.Color.Tomato
        Me.btnDeliveies.FlatAppearance.BorderSize = 0
        Me.btnDeliveies.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon
        Me.btnDeliveies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSalmon
        Me.btnDeliveies.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeliveies.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeliveies.ForeColor = System.Drawing.Color.Transparent
        Me.btnDeliveies.Location = New System.Drawing.Point(1101, 25)
        Me.btnDeliveies.Name = "btnDeliveies"
        Me.btnDeliveies.Size = New System.Drawing.Size(140, 48)
        Me.btnDeliveies.TabIndex = 0
        Me.btnDeliveies.Text = "DELIVERIES"
        Me.btnDeliveies.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel6.Controls.Add(Me.MetroButton1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1253, 27)
        Me.Panel6.TabIndex = 5
        '
        'MetroButton1
        '
        Me.MetroButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton1.BackColor = System.Drawing.Color.Teal
        Me.MetroButton1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MetroButton1.Location = New System.Drawing.Point(1227, 2)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(25, 23)
        Me.MetroButton1.TabIndex = 6
        Me.MetroButton1.Text = "X"
        Me.MetroButton1.UseCustomBackColor = True
        Me.MetroButton1.UseCustomForeColor = True
        Me.MetroButton1.UseSelectable = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(978, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Emp#"
        '
        'lEmpNum
        '
        Me.lEmpNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lEmpNum.AutoSize = True
        Me.lEmpNum.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lEmpNum.ForeColor = System.Drawing.Color.DarkRed
        Me.lEmpNum.Location = New System.Drawing.Point(1035, 47)
        Me.lEmpNum.Name = "lEmpNum"
        Me.lEmpNum.Size = New System.Drawing.Size(19, 21)
        Me.lEmpNum.TabIndex = 3
        Me.lEmpNum.Text = "0"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Tomato
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSalmon
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(738, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 40)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmSalesTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClientSize = New System.Drawing.Size(1253, 486)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lTableNum)
        Me.Controls.Add(Me.lEmpNum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnDeliveies)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tTableNum)
        Me.Name = "frmSalesTransaction"
        Me.Text = "frmSalesTransaction"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub



    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents txtSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents btn As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lTotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lTableNum As Label
    Friend WithEvents tTableNum As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents txtCash As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnDeliveies As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Label3 As Label
    Friend WithEvents lEmpNum As Label
    Friend WithEvents Button1 As Button

End Class
