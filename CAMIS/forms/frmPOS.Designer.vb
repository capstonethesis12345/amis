<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOS
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtItemNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListItems = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SaveTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPaid = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(287, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(253, 192)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(100, 22)
        Me.txtDate.TabIndex = 1
        '
        'txtItemNo
        '
        Me.txtItemNo.Location = New System.Drawing.Point(82, 195)
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.Size = New System.Drawing.Size(100, 22)
        Me.txtItemNo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Item No"
        '
        'ListItems
        '
        Me.ListItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListItems.FullRowSelect = True
        Me.ListItems.GridLines = True
        Me.ListItems.Location = New System.Drawing.Point(230, 251)
        Me.ListItems.Name = "ListItems"
        Me.ListItems.Size = New System.Drawing.Size(325, 264)
        Me.ListItems.TabIndex = 4
        Me.ListItems.UseCompatibleStateImageBehavior = False
        Me.ListItems.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ITEM"
        Me.ColumnHeader1.Width = 69
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Quantity"
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PRICE"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 73
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Amount"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 95
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(82, 223)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(473, 22)
        Me.txtName.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Name"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(82, 262)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtPrice.TabIndex = 8
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Price"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(82, 293)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(100, 22)
        Me.txtQty.TabIndex = 10
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "QTY"
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Location = New System.Drawing.Point(434, 192)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.ReadOnly = True
        Me.txtInvoiceNo.Size = New System.Drawing.Size(100, 22)
        Me.txtInvoiceNo.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(403, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Transaction Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(285, 528)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 27)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "TOTAL"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(388, 520)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(167, 35)
        Me.txtTotal.TabIndex = 14
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveTransactionToolStripMenuItem, Me.CancelTransactionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(654, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'SaveTransactionToolStripMenuItem
        '
        Me.SaveTransactionToolStripMenuItem.Name = "SaveTransactionToolStripMenuItem"
        Me.SaveTransactionToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.SaveTransactionToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.SaveTransactionToolStripMenuItem.Text = "Save Transaction"
        '
        'CancelTransactionToolStripMenuItem
        '
        Me.CancelTransactionToolStripMenuItem.Name = "CancelTransactionToolStripMenuItem"
        Me.CancelTransactionToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.CancelTransactionToolStripMenuItem.Size = New System.Drawing.Size(120, 20)
        Me.CancelTransactionToolStripMenuItem.Text = "Cancel Transaction"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(3, 476)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(187, 38)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Select an item on the list and press Delete button to delete"
        '
        'txtPaid
        '
        Me.txtPaid.Location = New System.Drawing.Point(82, 356)
        Me.txtPaid.Name = "txtPaid"
        Me.txtPaid.Size = New System.Drawing.Size(100, 22)
        Me.txtPaid.TabIndex = 19
        Me.txtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 359)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Paid"
        '
        'txtChange
        '
        Me.txtChange.Location = New System.Drawing.Point(82, 384)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(100, 22)
        Me.txtChange.TabIndex = 21
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 387)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 16)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Change"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(3, 422)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(187, 38)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "F1: Save Transaction" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F3: Cancel Transcation"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.Location = New System.Drawing.Point(-101, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(758, 24)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "____________________________________________________________________"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.SkyBlue
        Me.Label13.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 43)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Payment"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Location = New System.Drawing.Point(-6, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(663, 60)
        Me.Panel1.TabIndex = 24
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(238, 33)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Restaurant Name Here"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label15.Location = New System.Drawing.Point(-9, 136)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(1077, 24)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "_________________________________________________________________________________" &
    "________________"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(452, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Print Reciept"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(654, 559)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtChange)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPaid)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListItems)
        Me.Controls.Add(Me.txtItemNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPOS"
        Me.Text = "Transaction"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents txtItemNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListItems As System.Windows.Forms.ListView
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SaveTransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelTransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPaid As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
