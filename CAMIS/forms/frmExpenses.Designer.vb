<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmExpenses
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
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rtnotes = New System.Windows.Forms.RichTextBox()
        Me.tdate_created = New System.Windows.Forms.TextBox()
        Me.tbamount = New System.Windows.Forms.TextBox()
        Me.cbTitle = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lID = New System.Windows.Forms.Label()
        Me.lEmpID = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroButton1
        '
        Me.MetroButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton1.Location = New System.Drawing.Point(1151, -1)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(25, 23)
        Me.MetroButton1.TabIndex = 0
        Me.MetroButton1.Text = "x"
        Me.MetroButton1.UseSelectable = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1151, 530)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rtnotes)
        Me.Panel3.Controls.Add(Me.tdate_created)
        Me.Panel3.Controls.Add(Me.tbamount)
        Me.Panel3.Controls.Add(Me.cbTitle)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.lID)
        Me.Panel3.Controls.Add(Me.lEmpID)
        Me.Panel3.Controls.Add(Me.btnClear)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(815, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(336, 530)
        Me.Panel3.TabIndex = 1
        '
        'rtnotes
        '
        Me.rtnotes.Location = New System.Drawing.Point(47, 206)
        Me.rtnotes.Name = "rtnotes"
        Me.rtnotes.Size = New System.Drawing.Size(257, 96)
        Me.rtnotes.TabIndex = 4
        Me.rtnotes.Text = ""
        '
        'tdate_created
        '
        Me.tdate_created.Location = New System.Drawing.Point(47, 333)
        Me.tdate_created.Name = "tdate_created"
        Me.tdate_created.Size = New System.Drawing.Size(257, 20)
        Me.tdate_created.TabIndex = 3
        '
        'tbamount
        '
        Me.tbamount.Location = New System.Drawing.Point(47, 155)
        Me.tbamount.Name = "tbamount"
        Me.tbamount.Size = New System.Drawing.Size(257, 20)
        Me.tbamount.TabIndex = 3
        '
        'cbTitle
        '
        Me.cbTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbTitle.FormattingEnabled = True
        Me.cbTitle.Items.AddRange(New Object() {"Advertising", "Amortization", "Bad Debts", "Bank Charges", "Charitable Contributions", "Commissions", "Contract Labor", "Depreciation", "Dues and Subscriptions", "Employee Benefit Programs", "Insurance ", "Interest", "Legal and Professional Fees", "Licenses and Fees", "Miscellaneous", "Office Expense", "Payroll Taxes", "Postage", "Rent", "Repairs and Maintenance", "Supplies", "Salaries", "Telephone", "Travel", "Utilities", "Vehicle Expenses", "Wages"})
        Me.cbTitle.Location = New System.Drawing.Point(47, 96)
        Me.cbTitle.Name = "cbTitle"
        Me.cbTitle.Size = New System.Drawing.Size(257, 21)
        Me.cbTitle.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Notes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Date time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Amount"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Expense Title"
        '
        'lID
        '
        Me.lID.AutoSize = True
        Me.lID.Location = New System.Drawing.Point(207, 55)
        Me.lID.Name = "lID"
        Me.lID.Size = New System.Drawing.Size(0, 13)
        Me.lID.TabIndex = 1
        '
        'lEmpID
        '
        Me.lEmpID.AutoSize = True
        Me.lEmpID.Location = New System.Drawing.Point(44, 55)
        Me.lEmpID.Name = "lEmpID"
        Me.lEmpID.Size = New System.Drawing.Size(64, 13)
        Me.lEmpID.TabIndex = 1
        Me.lEmpID.Text = "EmployeeID"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(194, 377)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 49)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(194, 432)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 49)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(815, 530)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "TITLE"
        Me.ColumnHeader2.Width = 171
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "AMOUNT"
        Me.ColumnHeader3.Width = 247
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "DATETIME"
        Me.ColumnHeader4.Width = 227
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "NOTES"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ListView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(815, 530)
        Me.Panel2.TabIndex = 2
        '
        'frmExpenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1175, 554)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmExpenses"
        Me.Text = "frmAccounts"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Button2 As Button
    Friend WithEvents tbamount As TextBox
    Friend WithEvents cbTitle As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lEmpID As Label
    Friend WithEvents rtnotes As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents lID As Label
    Friend WithEvents tdate_created As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents Panel2 As Panel
End Class
