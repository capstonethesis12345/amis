Imports MySql.Data.MySqlClient
Public Class frmMain
    Private AppName As String = Application.ProductName
    Private vfunction As String = ""
    Public Sub New(ByVal f As String)

        ' This call is required by the designer.
        InitializeComponent()
        vfunction = f
        ' Add any initialization after the InitializeComponent() call.

    End Sub
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
        'MessageBox.Show("Greetings " & vfunction, "Welcome")
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        openFull(frmProduct)
    End Sub
    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        frmSales.ShowDialog()
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
    Private Sub CategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub RequestToolStripMenuItem_Click(sender As Object, e As EventArgs)
        openFull(frmRequest)
    End Sub



    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click

    End Sub

    Private Sub PurchasesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchasesToolStripMenuItem.Click
        openFull(frmPurchases)
    End Sub

    Private Sub POSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles POSToolStripMenuItem.Click

        Dim sales As New frmSales()
        sales.Show()


    End Sub

    Private Sub SuppliersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuppliersToolStripMenuItem.Click
        openFull(frmSupplier)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim login As New fMainForm()
        login.Show()
        Me.Hide()

    End Sub

    Private Sub ViewMenusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewMenusToolStripMenuItem.Click
        openFull(frmFoodMenu)
    End Sub
End Class
