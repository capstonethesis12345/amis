<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCash = New System.Windows.Forms.MaskedTextBox()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(-2, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(349, 52)
        Me.Panel1.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 42)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Payment"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCash)
        Me.GroupBox1.Controls.Add(Me.txtChange)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtTA)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 143)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'txtCash
        '
        Me.txtCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.Location = New System.Drawing.Point(142, 61)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(173, 31)
        Me.txtCash.TabIndex = 11
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtChange
        '
        Me.txtChange.BackColor = System.Drawing.Color.White
        Me.txtChange.Enabled = False
        Me.txtChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.Location = New System.Drawing.Point(142, 96)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(173, 38)
        Me.txtChange.TabIndex = 13
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Change :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cash :"
        '
        'txtTA
        '
        Me.txtTA.BackColor = System.Drawing.Color.White
        Me.txtTA.Enabled = False
        Me.txtTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTA.Location = New System.Drawing.Point(142, 26)
        Me.txtTA.Name = "txtTA"
        Me.txtTA.Size = New System.Drawing.Size(173, 31)
        Me.txtTA.TabIndex = 9
        Me.txtTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Total Amount :"
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(336, 199)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPayment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCash As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
