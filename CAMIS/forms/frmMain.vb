Imports MySql.Data.MySqlClient
Public Class frmMain
    Private AppName As String = Application.ProductName
    Private vfunction As String = ""
    Public Sub New(ByVal f As String)

        ' This call is required by the designer.
        InitializeComponent()
        vfunction = f
        ' Add any initialization after the InitializeComponent() call.
        'Dim aEmp As Int32 = vEmp
        'vEmp.ToString("D5")
        tsslUser.Text = String.Format("{0:D5}", vEmp)
        tUser.Text = vUser
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
        If vfunction = "Cook" Then
            ConfigurationToolStripMenuItem.Enabled = False
            StaffToolStripMenuItem.Enabled = False
            SuppliersToolStripMenuItem.Enabled = False
            JobsToolStripMenuItem.Enabled = False
            TransactionToolStripMenuItem.Enabled = False
            ReportToolStripMenuItem.Enabled = False
            AboutToolStripMenuItem.Enabled = False
            ToolStripButton1.Enabled = False
            ToolStripButton2.Enabled = False
            ToolStripButton4.Enabled = False
            ToolStripButton5.Enabled = False
            ToolStripButton6.Enabled = False
            ToolStripButton7.Enabled = False
            frmProduct.txtPrice.Enabled = False
            frmProduct.txtInitialStock.Enabled = False


        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        openFull(frmProduct)
    End Sub
    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        ' frmSales.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTimer.Text = Date.Now.ToString("H:mm:ss")
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
        Dim fpurchase As New frmPurchases
        openFull(fpurchase)
    End Sub

    Private Sub POSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles POSToolStripMenuItem.Click

        Dim sales As New frmSalesTransaction()
        openFull(sales)


    End Sub

    Private Sub SuppliersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuppliersToolStripMenuItem.Click
        openFull(frmSupplier)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim log As New fMainForm()
        log.Show()
        fMainForm.tUsername.Text = ""
        fMainForm.tPassword.Text = ""
        fMainForm.tUsername.Focus()
        vEmp = ""
        status = ""
        vfunction = ""

    End Sub

    Private Sub ViewMenusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewMenusToolStripMenuItem.Click
        openFull(frmFoodMenu)
    End Sub

    Private Sub SetupMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetupMenuToolStripMenuItem.Click
        openFull(frmFood)
    End Sub

    Private Sub JobsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JobsToolStripMenuItem.Click
        Try
            frmJob.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DTRToolStripMenuItem_Click(sender As Object, e As EventArgs)
        openFull(frmDTR)
    End Sub

    Private Sub DTRToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DTRToolStripMenuItem.Click
        frmDTR.ShowDialog()
    End Sub

    Private Sub AccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountToolStripMenuItem.Click
        openFull(frmAccounts)
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub DeliveriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeliveriesToolStripMenuItem.Click
        'callform(frmDeliveries, Panel2)
        openFull(frmDeliveries)
    End Sub

    Private Sub FinancialStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinancialStatusToolStripMenuItem.Click

    End Sub

    Private Sub SoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoldToolStripMenuItem.Click
        frmFilterDailySales.ShowDialog()
    End Sub
End Class
