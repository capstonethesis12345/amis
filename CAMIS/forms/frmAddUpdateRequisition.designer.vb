<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddUpdateRequisition
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtRequisitionNo = New System.Windows.Forms.Label()
        Me.txtPurpose = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(616, 66)
        Me.Panel1.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(3, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(270, 42)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Adding New Request"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtRequisitionNo)
        Me.GroupBox1.Controls.Add(Me.txtPurpose)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.txtStatus)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(586, 264)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Requst Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 217)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(586, 50)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.AccountManagementIS.My.Resources.Resources.print20x20
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(414, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "&Print"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.AccountManagementIS.My.Resources.Resources.Button2_Image
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(495, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 33)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "&Cancel"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.AccountManagementIS.My.Resources.Resources.btnSave_Image
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(331, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 33)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Request"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtRequisitionNo
        '
        Me.txtRequisitionNo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtRequisitionNo.Location = New System.Drawing.Point(130, 43)
        Me.txtRequisitionNo.Name = "txtRequisitionNo"
        Me.txtRequisitionNo.Size = New System.Drawing.Size(156, 22)
        Me.txtRequisitionNo.TabIndex = 0
        Me.txtRequisitionNo.Text = " "
        '
        'txtPurpose
        '
        Me.txtPurpose.BackColor = System.Drawing.Color.White
        Me.txtPurpose.Location = New System.Drawing.Point(130, 126)
        Me.txtPurpose.Multiline = True
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(156, 83)
        Me.txtPurpose.TabIndex = 2
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.White
        Me.txtDescription.Location = New System.Drawing.Point(130, 79)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(156, 41)
        Me.txtDescription.TabIndex = 1
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.White
        Me.txtStatus.Location = New System.Drawing.Point(414, 71)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(156, 23)
        Me.txtStatus.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Purpose/Remarks"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(300, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(301, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 15)
        Me.Label5.TabIndex = 4
        '
        'txtAmount
        '
        Me.txtAmount.BackColor = System.Drawing.Color.White
        Me.txtAmount.Location = New System.Drawing.Point(414, 44)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(156, 23)
        Me.txtAmount.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(300, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Requisition No."
        '
        'frmAddUpdateRequisition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(610, 357)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddUpdateRequisition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtRequisitionNo As System.Windows.Forms.Label
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPurpose As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
