
Class frmSales
    'Dim lef, top As Integer
    Dim sizeW As Integer
    Dim sizeH As Integer
    Dim orderNUM As String
    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        SqlRefresh = "select * from items where salestatus=1"
        itemAutoComplete("items", txtProductName)
        If status = "Cashier" Then
            btnLogout.Visible = True
        Else
            btnLogout.Visible = False
        End If
        SqlRefresh = "select customername from customers"
        SqlReFill("customers", cbCustomer, "ShowValueInComboBox")

    End Sub
    Private Sub frmPOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'orderNUM = getIDFunction("select ifnull(max(orderid),1) from `order` where orderstatus=0 where empid='" & vEmp & "'", "orders")
        'txtOrderNum.Text = orderNUM
        ' SqlRefresh = "select customername from customers"
        ' SqlReFill("Customers", cbCustomer, "ShowValueInComboBox")
        sizeW = Me.Width
        sizeH = Me.Height
        Panel2.Left = (sizeW / 2) - (Panel2.Width / 2)
        Panel2.Top = (sizeH / 2) - (Panel2.Height / 2)
        'txtTransNo.Text = objDal.GetSingleField("Select max(transid)+1 from transactions")
        'MessageBox.Show(vEmp)
        txtOrderNum.Text = getIDFunction("select ifnull(orderid,ifnull(max(orderid),0)) from `order` where empid=@0 and orderstatus=0", "orders", {vEmp})
        If txtOrderNum.Text = "0" Then
            'Dim GetMaxOrderID As String = getIDFunction("select ifnull(orderid,ifnull(max(orderid),1)) from `order` where empid=@0 and orderstatus=1", "orders", {vEmp})
            'MessageBox.Show("Insert new")
            Dim oEmp As New TextBox
            oEmp.Text = vEmp
            Dim oId As New TextBox
            oId.Text = "0"
            msgShow = False
            itemNew("`order`", {"empid", "orderstatus"}, {oEmp, oId})
        End If
        txtOrderNum.Text = getIDFunction("select ifnull(orderid,ifnull(max(orderid),0)) from `order` where empid=@0 and orderstatus=0", "orders", {vEmp})
        txtProductName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        SqlRefresh = "select description from items where salestatus=1"
        itemAutoComplete("products", txtProductName)
        Label11.Text = getIDFunction("select customerid from customers where customername like @0", "customerid", {cbCustomer.Text})
        SqlRefresh = "SELECT i.description,o.quantity,i.price,(o.quantity*i.price)totalamnt FROM `orderline` o left join items i on i.itemid=o.itemid where o.orderid='" & txtOrderNum.Text & "'"
        SqlReFill("orders", ListItems)
        txtTotal.Text = computeSum()
    End Sub

    Private Sub txtProduct_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub txtProductName_Leave(sender As Object, e As EventArgs) Handles txtProductName.Leave

        Try
            Dim barcode As String = getValue("SELECT IFNULL( i.barcode, 0 ) , i.price, i.itemid, f.buildid, i.description FROM items i LEFT JOIN foodingredient f ON i.itemid = f.foodid WHERE description LIKE  @0 LIMIT 0 , 1", "saleItems", {txtProductName.Text}, False)

            If barcode = "0" Then
                MessageBox.Show("Item not found")
            Else
                txtBarcode.Text = barcode
                txtPrice.Text = ds.Tables("saleItems").Rows(0).Item("price").ToString
                lblItemid.Text = ds.Tables("saleItems").Rows(0).Item("itemid").ToString
                lblBuildID.Text = ds.Tables("saleItems").Rows(0).Item("buildid").ToString
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim log As New fMainForm()
        log.Show()
        Me.Close()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub frmSales_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Close()
    End Sub

    Private Sub btnOrderItem_Click(sender As Object, e As EventArgs) Handles btnOrderItem.Click
        SqlRefresh = "SELECT i.description,o.quantity,i.price,(o.quantity*i.price)totalamnt FROM `orderline` o left join items i on i.itemid=o.itemid where o.orderid='" & txtOrderNum.Text & "'"
        ErrMessageText = "Error"
        Dim d As New TextBox
        d.Text = ""
        itemNew("orderline", {"orderid", "itemid", "buildid", "quantity"}, {txtOrderNum, lblItemid, lblBuildID, txtQuantity}, ListItems)
        txtTotal.Text = computeSum()
    End Sub
    Public total As Double = 0.0
    Private Function computeSum()
        total = 0.0
        For Each row In ListItems.Items
            total += Double.Parse(row.subitems(3).text)
        Next
        Return total.ToString("C", Globalization.CultureInfo.GetCultureInfo("en-PH"))
    End Function
    Private Sub ListItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListItems.SelectedIndexChanged

    End Sub


    Private Sub cbCustomer_TextChanged(sender As Object, e As EventArgs) Handles cbCustomer.TextChanged
        msgShow = False
        Label1.Text = getStrData("select customerid from customers where customername like @0", "customers", {cbCustomer.Text})
    End Sub
    Public transact As Boolean = False
    Dim totalAmount As Double = 0.0
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtPaid.Text = vbNullString Then
            MessageBox.Show("Cash amount required.")
            Exit Sub
        End If

        Dim total As Double = 0.0
        For Each row In ListItems.Items
            total += Double.Parse(row.subitems(3).text)
        Next
        Dim totalAmt As New TextBox
        totalAmt.Text = total.ToString
        totalAmount = Convert.ToDouble(totalAmt.Text)

        If txtPaid.Text >= totalAmount Then

            Dim change As Double = Convert.ToDouble(txtPaid.Text) - totalAmount
            change.ToString("C", Globalization.CultureInfo.GetCultureInfo("en-PH"))
            MessageBox.Show("Total change: " & change.ToString)

            'frmSaleTransaction.ShowDialog()



            Dim regDate As DateTime = DateTime.Now
            Dim strDate As String = regDate.ToString("yyyy-MM-dd HH:mm:ss")
            Dim ostrDate As New TextBox
            ostrDate.Text = strDate
            Dim orderStatus As New TextBox
            orderStatus.Text = "1"
            itemUpdate("`order`", {"customerid", "total", "orderdate", "orderstatus"}, {Label11, totalAmt, ostrDate, orderStatus}, "orderid", txtOrderNum.Text)
            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            frmPOS_Load(e, e) 'Load everything in your form load event again


        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class