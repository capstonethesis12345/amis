<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDTRsystem
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTImer = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtEmpid = New MetroFramework.Controls.MetroTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Time"
        '
        'lblTImer
        '
        Me.lblTImer.AutoSize = True
        Me.lblTImer.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTImer.Location = New System.Drawing.Point(86, 20)
        Me.lblTImer.Name = "lblTImer"
        Me.lblTImer.Size = New System.Drawing.Size(78, 29)
        Me.lblTImer.TabIndex = 0
        Me.lblTImer.Text = "Time"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(103, 81)
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
        Me.txtEmpid.Location = New System.Drawing.Point(65, 52)
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
        'frmDTRsystem
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 109)
        Me.Controls.Add(Me.txtEmpid)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTImer)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDTRsystem"
        Me.Text = "frmDTRsystem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblTImer As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtEmpid As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Timer1 As Timer
End Class
