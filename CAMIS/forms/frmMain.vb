Imports MySql.Data.MySqlClient
Public Class frmMain
    Private AppName As String = Application.ProductName
    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getData()

        ' Public ServerMySQL As String
        ' Public PortMySQL As String
        ' Public UserNameMySQL As String
        ' Public PwdMySQL As String
        ' Public DBNameMySQL As String
        lblDate.Text = Date.Now.ToString("MM/dd/yyyy")
        formMain(Me)
        Dim w, h As Integer
        w = Panel2.Width
        h = Panel2.Height
        Panel2.Left = (Me.Width / 2) - (Panel2.Width / 2)
        Panel2.Top = (Me.Height / 2) - (Panel2.Height / 2)
        Try
            Remember = GetSetting(AppName, "DBSection", "LogUser", "")
        Catch ex As Exception

        End Try
        txtLogUser.Text = Remember
        showHolder(txtLogUser, lblUserHolder)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        frmProduct.MdiParent = Me
        frmProduct.Show()
    End Sub
    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        frmPOS.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTimer.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub VatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VatToolStripMenuItem.Click
        frmDatabase.ShowDialog()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        frmFilterStockIn.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        frmFilterStockOut.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub StaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffToolStripMenuItem.Click, ToolStripButton4.Click
        openFull(frmStaff)
    End Sub
    Private Sub CategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryToolStripMenuItem.Click
        openFull(frmCategory)
    End Sub
    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem.Click
        openFull(frmProduct)
    End Sub
    Private Sub StocksInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StocksInToolStripMenuItem.Click
        frmFilterStockIn.ShowDialog()
    End Sub

    Private Sub StocksOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StocksOutToolStripMenuItem.Click
        frmFilterStockOut.ShowDialog()
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        Shell("Calc.exe")
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotepadToolStripMenuItem.Click
        Shell("Notepad.exe")
    End Sub
    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        frmFilterDailySales.ShowDialog()
    End Sub

    Private Sub RequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestToolStripMenuItem.Click
        openFull(frmRequest)
    End Sub

    Private Sub txtLogUser_KeyUp(sender As Object, e As KeyEventArgs) Handles txtLogUser.KeyUp
        showHolder(txtLogUser, lblUserHolder)
    End Sub

    Private Sub txtLogPass_KeyUp(sender As Object, e As KeyEventArgs) Handles txtLogPass.KeyUp
        showHolder(txtLogPass, lblPassHolder)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtLogPass.TextChanged

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If cbRemember.Checked = True Then
            SaveSetting(AppName, "DBSection", "LogUser", txtLogUser.Text)
        Else
            SaveSetting(AppName, "DBSection", "LogUser", "")
        End If
        sqL = "select username from employees where username='" & txtLogUser.Text & "' and password='" & txtLogPass.Text & "'"
        ' SqlLoad(sqL)
        If (logged = True) Then
            MessageBox.Show("Accepted")
        Else
            MessageBox.Show("Invalid")
        End If

    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        openFull(frmFoodMenu)
    End Sub
End Class
