<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDTRsystem
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
        Me.components = New System.ComponentModel.Container()
        Me.lblTImer = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtEmpid = New MetroFramework.Controls.MetroTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblTImer
        '
        Me.lblTImer.AutoSize = True
        Me.lblTImer.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTImer.Location = New System.Drawing.Point(23, 60)
        Me.lblTImer.Name = "lblTImer"
        Me.lblTImer.Size = New System.Drawing.Size(78, 29)
        Me.lblTImer.TabIndex = 0
        Me.lblTImer.Text = "Time"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(184, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Process"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtEmpid
        '
        '
        '
        '
        Me.txtEmpid.CustomButton.Image = Nothing
        Me.txtEmpid.CustomButton.Location = New System.Drawing.Point(158, 1)
        Me.txtEmpid.CustomButton.Name = ""
        Me.txtEmpid.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEmpid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmpid.CustomButton.TabIndex = 1
        Me.txtEmpid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmpid.CustomButton.UseSelectable = True
        Me.txtEmpid.CustomButton.Visible = False
        Me.txtEmpid.Lines = New String(-1) {}
        Me.txtEmpid.Location = New System.Drawing.Point(131, 103)
        Me.txtEmpid.MaxLength = 32767
        Me.txtEmpid.Name = "txtEmpid"
        Me.txtEmpid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmpid.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmpid.SelectedText = ""
        Me.txtEmpid.SelectionLength = 0
        Me.txtEmpid.SelectionStart = 0
        Me.txtEmpid.Size = New System.Drawing.Size(180, 23)
        Me.txtEmpid.TabIndex = 0
        Me.txtEmpid.UseSelectable = True
        Me.txtEmpid.WaterMark = "Employee ID"
        Me.txtEmpid.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmpid.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(312, 108)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(39, 13)
        Me.lblStatus.TabIndex = 2
        Me.lblStatus.Text = "Label1"
        Me.lblStatus.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 800
        '
        'frmDTRsystem
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 162)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtEmpid)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTImer)
        Me.Name = "frmDTRsystem"
        Me.Resizable = False
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Time"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTImer As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtEmpid As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblStatus As Label
    Friend WithEvents Timer2 As Timer
End Class
