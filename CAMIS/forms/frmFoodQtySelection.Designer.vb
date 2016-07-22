<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFoodQtySelection
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
        Me.txtQuantity = New MetroFramework.Controls.MetroTextBox()
        Me.btnSet = New MetroFramework.Controls.MetroButton()
        Me.lblItemID = New MetroFramework.Controls.MetroLabel()
        Me.lblDescription = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.cbtype = New System.Windows.Forms.ComboBox()
        Me.lblType = New MetroFramework.Controls.MetroLabel()
        Me.lblfootitemid = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'txtQuantity
        '
        '
        '
        '
        Me.txtQuantity.CustomButton.Image = Nothing
        Me.txtQuantity.CustomButton.Location = New System.Drawing.Point(279, 1)
        Me.txtQuantity.CustomButton.Name = ""
        Me.txtQuantity.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtQuantity.CustomButton.TabIndex = 1
        Me.txtQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtQuantity.CustomButton.UseSelectable = True
        Me.txtQuantity.CustomButton.Visible = False
        Me.txtQuantity.Lines = New String(-1) {}
        Me.txtQuantity.Location = New System.Drawing.Point(58, 137)
        Me.txtQuantity.MaxLength = 32767
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtQuantity.SelectedText = ""
        Me.txtQuantity.SelectionLength = 0
        Me.txtQuantity.SelectionStart = 0
        Me.txtQuantity.Size = New System.Drawing.Size(301, 23)
        Me.txtQuantity.TabIndex = 0
        Me.txtQuantity.UseSelectable = True
        Me.txtQuantity.WaterMark = "Quantity"
        Me.txtQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtQuantity.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnSet
        '
        Me.btnSet.Location = New System.Drawing.Point(119, 166)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(75, 23)
        Me.btnSet.TabIndex = 2
        Me.btnSet.Text = "SET"
        Me.btnSet.UseSelectable = True
        '
        'lblItemID
        '
        Me.lblItemID.AutoSize = True
        Me.lblItemID.Location = New System.Drawing.Point(23, 29)
        Me.lblItemID.Name = "lblItemID"
        Me.lblItemID.Size = New System.Drawing.Size(20, 19)
        Me.lblItemID.TabIndex = 4
        Me.lblItemID.Text = "id"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(23, 60)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(42, 19)
        Me.lblDescription.TabIndex = 4
        Me.lblDescription.Text = "name"
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(225, 166)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton2.TabIndex = 2
        Me.MetroButton2.Text = "CANCEL"
        Me.MetroButton2.UseSelectable = True
        '
        'cbtype
        '
        Me.cbtype.FormattingEnabled = True
        Me.cbtype.Location = New System.Drawing.Point(71, 101)
        Me.cbtype.Name = "cbtype"
        Me.cbtype.Size = New System.Drawing.Size(288, 21)
        Me.cbtype.TabIndex = 5
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(23, 101)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(51, 19)
        Me.lblType.TabIndex = 4
        Me.lblType.Text = "unitype"
        '
        'lblfootitemid
        '
        Me.lblfootitemid.AutoSize = True
        Me.lblfootitemid.Location = New System.Drawing.Point(229, 29)
        Me.lblfootitemid.Name = "lblfootitemid"
        Me.lblfootitemid.Size = New System.Drawing.Size(46, 19)
        Me.lblfootitemid.TabIndex = 4
        Me.lblfootitemid.Text = "itemid"
        '
        'frmFoodQtySelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.Controls.Add(Me.cbtype)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblfootitemid)
        Me.Controls.Add(Me.lblItemID)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.txtQuantity)
        Me.Name = "frmFoodQtySelection"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtQuantity As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnSet As MetroFramework.Controls.MetroButton
    Friend WithEvents lblItemID As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblDescription As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents cbtype As ComboBox
    Friend WithEvents lblType As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblfootitemid As MetroFramework.Controls.MetroLabel
End Class
