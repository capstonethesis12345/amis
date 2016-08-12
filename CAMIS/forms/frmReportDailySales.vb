
Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient
Public Class frmReportDailySales

    'Private fileCount As Integer = 0 '// Index Of the current file/Image
    'Private currPage As Integer = 0 '// Current Page In the current file/Image
    'Private pCount As Integer = 0 '// PageCount In the current file/Image
    'Private currImage As Image '// My Current Image


    Dim strMonthNo As String
    Dim y As Integer
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub frmReportDailySales_Load(sender As Object, e As EventArgs) Handles Me.Load
        dgw.Rows.Clear()
        Dim totalStockOut As Double = 0.0
        Dim totSales As Double = 0.0
        Dim d As Date = frmFilterDailySales.DateTimePicker1.Text
        lbldate.Text = d.ToString("yyyy-MM-dd")
        'Date.Now.ToString("MMMM dd, yyyy")
        SqlRefresh = "CALL `getSold` (@0 , @1);"
        Dim filterdate As String = lbldate.Text & "%"
        Dim solds As String = getStrData(SqlRefresh, "solds", {filterdate, filterdate})
        For i = 0 To ds.Tables("solds").Rows.Count - 1
            dgw.Rows.Add(ds.Tables("solds").Rows(i).Item(2).ToString, ds.Tables("solds").Rows(i).Item(3).ToString, ds.Tables("solds").Rows(i).Item(4).ToString, ds.Tables("solds").Rows(i).Item(5).ToString, ds.Tables("solds").Rows(i).Item(6).ToString)
            y += 17
            totalStockOut += ds.Tables("solds").Rows(i).Item(4).ToString
            totSales += ds.Tables("solds").Rows(i).Item(6).ToString
        Next
        lblTotalStocksIn.Text = totalStockOut
        lblSales.Text = Format(totSales, "#,##0.00")
        '  dgw.Height += y


        'dgw.AutoGenerateColumns = True
        '    dgw.DataSource = ds
        'dgw.DataMember = "solds"
        'Me.ReportViewer1.RefreshReport
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub dgw_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentClick

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub


    'Private Sub LoadStocksOutReport()

    '    Dim totStockOut As Double
    '    Dim totSales As Double
    '    Try

    '        sqL = "SELECT ProductCode, P.Description, T
    ', SUM(TD.Quantity) as totalQuantity, TD.ItemPrice FROM Product as P, Transactions as T, TransactionDetails as TD WHERE P.ProductNo = TD.ProductNo AND TD.InvoiceNo = T.InvoiceNo AND  TDate LIKE '" & frmFilterDailySales.DateTimePicker1.Value.ToString("MM/dd/yyyy") & "' GROUP BY P.ProductNo, TDate ORDER By TDate"


    '        ConnDB()
    '        cmd = New MySqlCommand(sqL, conn)
    '        dr = cmd.ExecuteReader

    '        dgw.Rows.Clear()
    '        totStockOut = 0.0
    '        totSales = 0.0
    '        y = 0
    '        Do While dr.Read = True
    '            dgw.Rows.Add(dr("ProductCode"), dr("Description"), dr("TDate"), dr("totalQuantity"), Format(dr("ItemPrice"), "#,##0.00"), Format((dr("ItemPrice") * dr("TotalQuantity")), "#,##0.00"))
    '            y += 17
    '            totStockOut += dr("totalQuantity")
    '            totSales += (dr("ItemPrice") * dr("TotalQuantity"))
    '        Loop
    '        dgw.Height += y
    '        lblTotalStocksIn.Text = totStockOut
    '        lblSales.Text = Format(totSales, "#,##0.00")
    '        Panel3.Location = New Point(Me.Panel3.Location.X, Me.Panel3.Location.Y + y)
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    Finally
    '        cmd.Dispose()
    '        conn.Close()
    '    End Try
    'End Sub

    'Private Sub frmReportStockOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    '    lblCollections.Text = " Sales of " & frmFilterDailySales.DateTimePicker1.Value.ToString("MMMM dd, yyyy")

    '    LoadStocksOutReport()
    '    lbldate.Text = Date.Now.ToString("MMMM dd, yyyy")
    'End Sub
    Dim PageNumber As Integer = 0
    'Private Sub docPrintPage(sender As Object, e As PrintPageEventArgs)

    '    currImage.SelectActiveFrame(FrameDimension.Page, currPage) 'Set the Active Frame of your image to that of the following frame that needs to printed.

    '    Using st As MemoryStream = New MemoryStream() 'We use a memory stream to print Images in order to avoid a bug inside the e.graphics.

    '        currImage.Save(st, ImageFormat.Bmp)
    '        Dim bmp As Bitmap = CType(Image.FromStream(st), Bitmap)
    '        e.Graphics.DrawImage(bmp, 0, 0)
    '        bmp.Dispose()

    '    End Using

    '    currPage += 1 'Current page is printed, increase index with 1

    '    If currPage < pCount Then 'Are there any further pages in the current image?
    '        e.HasMorePages = True 'yes continue printing
    '    Else 'no 
    '        If fileCount = (fileN.Count - 1) Then 'Hase the list anymore files?
    '            e.HasMorePages = False 'No - stop printing all together
    '        Else 'yes
    '            currPage = 0 'Set your index for the current page back to first
    '            fileCount += 1 'Increase the index of the current file
    '            currImage = Image.FromFile(fileN.Item(fileCount)) 'Load the next image (Perhaps if-statements is desired to avoid Null-Reference)
    '            pCount = currImage.GetFrameCount(FrameDimension.Page) 'Load the pagecount of the current image

    '            e.HasMorePages = True 'continue printing
    '        End If
    '    End If
    'End Sub
    'Private Sub docBeginprint(sender As Object, e As PrintEventArgs)

    '    If fileN.Count > 0 Then
    '        currPage = 0
    '        currImage = Image.FromFile(fileN.Item(0))
    '        pCount = currImage.GetFrameCount(FrameDimension.Page)
    '    End If

    'End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)

        Panel1.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))
        e.Graphics.DrawImage(bm, 0, 40)
        '        Dim aPS As New PageSetupDialog
        'aPS.Document = PrintDocument1
        Dim vPrintDoc As New PrintDocument
        vPrintDoc.DefaultPageSettings.Landscape = False

        'AddHandler vPrintDoc.PrintPage, AddressOf docPrintPage
        'AddHandler vPrintDoc.BeginPrint, AddressOf docBeginprint

        Dim i As PrintPreviewDialog = New PrintPreviewDialog
        i.Document = vPrintDoc
        i.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Panel1.Height += y
        dgw.Height += y
        Panel3.Location = New Point(Me.Panel3.Location.X, Me.Panel3.Location.Y + y)
        dgw.ScrollBars = ScrollBars.None
        frmPrintDialogSales.PrintPreviewControl1.Document = Me.PrintDocument1
        frmPrintDialogSales.ShowDialog()
        Me.Close()
        'PrintDialog1.Document = Me.PrintDocument1

        'Dim ButtonPressed As DialogResult = PrintDialog1.ShowDialog()
        'If (ButtonPressed = DialogResult.OK) Then
        '    Panel1.Height += y
        '    dgw.Height += y
        '    Panel3.Location = New Point(Me.Panel3.Location.X, Me.Panel3.Location.Y + y)
        '    dgw.ScrollBars = ScrollBars.None
        '    PrintDocument1.Print()
        '    Me.Close()
        'End If

    End Sub
    'Sub PrintIt(ByVal e As System.Drawing.Printing.PrintPageEventArgs, ByVal nRow As Integer, ByVal nY As Integer)

    '    Dim data As String = dgw.SelectedRows(nRow).Cells(1).Value
    '    Dim data2 As String = dgw.SelectedRows(nRow).Cells(12).Value

    '    e.Graphics.DrawString(data, drawfont, (e.Graphics.pagebound.width / 2 - e.Graphics.MeasureString(data, drawfont).Width / 2), 25 + nY)
    '    e.Graphics.DrawString(data2, drawfont, (e.Graphics.pagebound.width / 2 - e.Graphics.MeasureString(data2, drawfont).Width / 2), 50 + nY)

    'End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '    Me.Close()
    'End Sub

End Class