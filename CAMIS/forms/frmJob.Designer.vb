<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJob
    Inherits MetroFramework.Forms.MetroForm

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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.jobid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroTextButton1 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.txtDescription = New MetroFramework.Controls.MetroTextBox()
        Me.txtSalary = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtID = New MetroFramework.Controls.MetroLabel()
        Me.btnClose = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.jobid, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.Location = New System.Drawing.Point(2, 63)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(378, 212)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'jobid
        '
        Me.jobid.Text = "Job ID"
        Me.jobid.Width = 75
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Job Description"
        Me.ColumnHeader1.Width = 185
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Salary/Hr"
        Me.ColumnHeader2.Width = 110
        '
        'MetroTextButton1
        '
        Me.MetroTextButton1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroTextButton1.Image = Nothing
        Me.MetroTextButton1.Location = New System.Drawing.Point(403, 187)
        Me.MetroTextButton1.Name = "MetroTextButton1"
        Me.MetroTextButton1.Size = New System.Drawing.Size(121, 49)
        Me.MetroTextButton1.TabIndex = 1
        Me.MetroTextButton1.Text = "Save"
        Me.MetroTextButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.MetroTextButton1.UseSelectable = True
        Me.MetroTextButton1.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        '
        '
        '
        Me.txtDescription.CustomButton.Image = Nothing
        Me.txtDescription.CustomButton.Location = New System.Drawing.Point(129, 1)
        Me.txtDescription.CustomButton.Name = ""
        Me.txtDescription.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDescription.CustomButton.TabIndex = 1
        Me.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDescription.CustomButton.UseSelectable = True
        Me.txtDescription.CustomButton.Visible = False
        Me.txtDescription.Lines = New String(-1) {}
        Me.txtDescription.Location = New System.Drawing.Point(387, 117)
        Me.txtDescription.MaxLength = 32767
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescription.SelectedText = ""
        Me.txtDescription.SelectionLength = 0
        Me.txtDescription.SelectionStart = 0
        Me.txtDescription.Size = New System.Drawing.Size(151, 23)
        Me.txtDescription.TabIndex = 2
        Me.txtDescription.UseSelectable = True
        Me.txtDescription.WaterMark = "Job description"
        Me.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDescription.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSalary
        '
        '
        '
        '
        Me.txtSalary.CustomButton.Image = Nothing
        Me.txtSalary.CustomButton.Location = New System.Drawing.Point(129, 1)
        Me.txtSalary.CustomButton.Name = ""
        Me.txtSalary.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSalary.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSalary.CustomButton.TabIndex = 1
        Me.txtSalary.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSalary.CustomButton.UseSelectable = True
        Me.txtSalary.CustomButton.Visible = False
        Me.txtSalary.Lines = New String(-1) {}
        Me.txtSalary.Location = New System.Drawing.Point(387, 146)
        Me.txtSalary.MaxLength = 32767
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSalary.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSalary.SelectedText = ""
        Me.txtSalary.SelectionLength = 0
        Me.txtSalary.SelectionStart = 0
        Me.txtSalary.Size = New System.Drawing.Size(151, 23)
        Me.txtSalary.TabIndex = 2
        Me.txtSalary.UseSelectable = True
        Me.txtSalary.WaterMark = "Salary"
        Me.txtSalary.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSalary.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(387, 85)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "Job ID"
        '
        'txtID
        '
        Me.txtID.AutoSize = True
        Me.txtID.Location = New System.Drawing.Point(439, 85)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(46, 19)
        Me.txtID.TabIndex = 3
        Me.txtID.Text = "Job ID"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = Nothing
        Me.btnClose.Location = New System.Drawing.Point(403, 242)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(121, 49)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnClose.UseSelectable = True
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmJob
        '
        Me.AcceptButton = Me.MetroTextButton1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 302)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.MetroTextButton1)
        Me.Controls.Add(Me.ListView1)
        Me.Movable = False
        Me.Name = "frmJob"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Job"
        Me.TransparencyKey = System.Drawing.Color.Empty
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents MetroTextButton1 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents jobid As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents txtDescription As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSalary As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtID As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnClose As MetroFramework.Controls.MetroTextBox.MetroTextButton
End Class
