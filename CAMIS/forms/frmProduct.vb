
Imports MySql.Data.MySqlClient

Public Class frmProduct

    Public adding As Boolean
    Public updating As Boolean
    Public Sub New()
        InitializeComponent()
        Try
            objForm = Me
            SqlRefresh = "SELECT categoryid, categoryname, categorydescription FROM category"
            SqlReFill("Category", ListView1)
        Catch ex As Exception
            MessageBox.Show("Error in establishing connection " & ex.Message.ToString, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub LoadProducts()
        Try
            ' sqL = "SELECT ProductNo, ProductCOde, P.Description, Barcode, UnitPrice, StocksOnHand, ReorderLevel, CategoryName FROM Product as P, Category as C WHERE C.CategoryNo = P.CategoryNo AND P.Description LIKE '" & lblSearch.Text & "%'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader()

            Dim x As ListViewItem
            ListView1.Items.Clear()
            Do While dr.Read = True
                x = New ListViewItem(dr("ProductNo").ToString)
                x.SubItems.Add(dr("ProductCode"))
                x.SubItems.Add(dr("Description"))
                x.SubItems.Add(dr("Barcode"))
                x.SubItems.Add(dr("CategoryName"))
                x.SubItems.Add(Format(dr("UnitPrice"), "#,##0.00"))
                x.SubItems.Add(dr("StocksOnHand"))
                x.SubItems.Add(dr("ReOrderLevel"))
                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub frmProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Me.WindowState = FormWindowState.Maximized
        'Try
        'sqL = "SELECT ProductNo, ProductCode, P.Description, Barcode, UnitPrice, StocksOnHand, ReorderLevel, CategoryName FROM Product as P, Category as C WHERE C.CategoryNo = P.CategoryNo"
        'ConnDB()
        'cmd = New MySqlCommand(sqL, conn)
        'dr = cmd.ExecuteReader()
        '
        '       Dim x As ListViewItem
        '       ListView1.Items.Clear()
        '

        'Do While dr.Read = True
        ' x = New ListViewItem(dr("ProductNo").ToString)
        ' '  x.SubItems.Add(dr("ProductNo"))
        ' x.SubItems.Add(dr("ProductCode"))
        ' x.SubItems.Add(dr("Description"))
        ' x.SubItems.Add(dr("Barcode"))
        ' x.SubItems.Add(dr("CategoryName"))
        ' x.SubItems.Add(Format(dr("UnitPrice"), "#,##0.00"))
        ' x.SubItems.Add(dr("StocksOnHand"))
        ' x.SubItems.Add(dr("ReorderLevel"))

        '        ListView1.Items.Add(x)
        '        Loop
        '        Catch ex As Exception
        ' MsgBox(ex.ToString)
        'Finally
        'cmd.Dispose()
        'conn.Close()
        'End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        ' adding = True
        ' updating = False
        StatusSet = "New"

        ' frmAddUpdateProduct.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        ' If ListView1.Items.Count = 0 Then
        ' MsgBox("Please select record to update", MsgBoxStyle.Exclamation, "Update")
        ' Exit Sub
        ' End If
        ' Try
        ' If ListView1.FocusedItem.Text = "" Then
        '
        '        Else
        '       adding = False
        '      updating = True
        '     frmAddUpdateProduct.ShowDialog()
        '    End If
        '
        'Catch ex As Exception

        '        End Try


    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        '  lblSearch.Text = InputBox("Enter Product Decription :", "Product Search")
        '  LoadProducts()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        ' If ListView1.Items.Count = 0 Then
        '' MsgBox("Please select product or item to add stocks.", MsgBoxStyle.Exclamation, "Add Stocks")
        'Exit Sub
        'End If

        '        Try
        ' frmStockIn.ShowDialog()
        ' Catch ex As Exception

        '        End Try

    End Sub


End Class