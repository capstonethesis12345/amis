Imports MySql.Data

Public Class frmPurchases
    Private poid As String
    Private vItemid As String
    Private vRefresh As String = "Select 
                    l.polistid,
                    i.barcode,
                    i.description,
                    concat(i.unitvalue,' ',i.unittype)Unit,
                    l.cost,
                    l.quantity,
                    If (i.itemtype = 1,'Ingredient','NonIngredient')
                    from polist l left join items i
                    On l.itemid=i.itemid
                    where poid = 1"
    Public Sub New()
        InitializeComponent()
        'poid = getID("")
        lblEmpID.Text = vEmp
        SqlRefresh = "SELECT company FROM  `supplier` "
        itemAutoComplete("Supplier", txtSupplier)
        SqlRefresh = "select barcode from items group by itemid"
        itemAutoComplete("AutoDescription", txtBarcode)
        SqlRefresh = vRefresh
        SqlReFill("polist", ListView1)
        'get current po
        Dim poid As String = getIDFunction("select ifnull(max(poid),1) from po", "purchaseorder", Nothing)
        lblPONum.Text = poid
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs)
        StatusSet = "New"
        Dim sNew As New frmAddUpdateCategory()
        sNew.ShowDialog()
        sNew = Nothing
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
        If ListView1.SelectedItems.Count = 0 Then
            MessageBox.Show("Select item first", "Selection not identified", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Else
            StatusSet = "Update"
            Dim update As New frmAddUpdateCategory()
            update.txtCategoryNo.Text = ListView1.FocusedItem.Text
            update.ShowDialog()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub frmPurchases_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddUpdate.Click
        If lblSupplierID.Text = vbNullString Then
            openFull(frmSupplier)
        Else
            sqL = "SELECT  `Supplierid` FROM  `supplier` WHERE Company LIKE  @0"
            If getIDFunction(sqL, "SupplierID", {txtSupplier.Text}) = 0 Then    'is supplier is still not present repeat txtsupplier_leave
                txtSupplier_Leave(btnAddUpdate, e)
            Else

                'MessageBox.Show(vItemid)
                SqlRefresh = vRefresh
                itemNew("POList", {"POID", "ItemID", "Quantity", "Cost"}, {lblPONum, lblItemID, txtQuantity, txtCost}, ListView1)
                MessageBox.Show("Success")
            End If

        End If
        'COMPUTE SUM AMOUNT
        computeSum()
        'clear text
        Dim txtboxes As Object() = {lblSupplierID, txtSupplier, lblItemID, txtBarcode, txtProductName, txtBrand, txtCost, txtQuantity}
        ' ClearTextBoxes(txtboxes)
        clearField(txtboxes)
    End Sub

    Private Sub txtSupplier_Leave(sender As Object, e As EventArgs) Handles txtSupplier.Leave
        'LOST FOCUS WE WILL GET SUPPLIERID
        Try
            'MessageBox.Show(txtSupplier.Text)
            sqL = "SELECT  `Supplierid` FROM  `supplier` WHERE Company LIKE  @0"
            msgShow = False
            lblSupplierID.Text = getIDFunction(sqL, "SupplierID", {txtSupplier.Text})
            If lblSupplierID.Text = 0 Then
                openFull(frmSupplier)
                If Not txtSupplier.Text = vbNullString Then
                    frmSupplier.txtSupplier.Text = txtSupplier.Text
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("error")
        End Try

    End Sub


    Private Sub txtBarcode_Leave(sender As Object, e As EventArgs) Handles txtBarcode.Leave
        Try
            'MessageBox.Show(txtSupplier.Text)
            sqL = "SELECT  `itemid` FROM  `items` WHERE barcode LIKE  @0"
            msgShow = False
            vItemid = getIDFunction(sqL, "items", {txtBarcode.Text})
            lblItemID.Text = vItemid
            If vItemid = 0 Then
                openFull(frmProduct)
            End If
        Catch ex As Exception
            MessageBox.Show("error")
        End Try
    End Sub

    Private Sub lblItemID_TextChanged(sender As Object, e As EventArgs) Handles lblItemID.TextChanged
        Try
            If Not lblItemID.Text = 0 Or lblItemID.Text IsNot vbNullString Then
                SqlRefresh = "select description,brand from items where itemid like @itemid"
                msgShow = False
                SqlReFill("items", Nothing, "ShowValueInTextbox", {"itemid"}, {lblItemID}, {txtProductName, txtBrand})
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Function computeSum()
        Dim total As Double = 0.0
        For Each row In ListView1.Items
            total += Double.Parse(row.subitems(4).text) * Double.Parse(row.subitems(5).text)
        Next
        Return total
    End Function

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick


        Dim ref As New TextBox
        ref.Text = ListView1.SelectedItems(0).Text.ToString
        SqlRefresh =
            "select polist.itemid,
           (supplier.company)supplierName,
           items.barcode
           from                polist 
           left join            items
           ON polist.itemid=items.itemid
            left join           supplier
            on supplier.supplierid=items.supplierid
           WHERE polist.polistid like  @itemid"
        SqlReFill("updateitem", Nothing, "ShowValueInTextbox", {"itemid"}, {ref}, {lblItemID, txtSupplier, txtBarcode})
        'DISABLE SUPPLIER
        txtSupplier.ReadOnly = True
        txtBarcode.ReadOnly = True
        btnDelete.Visible = True
    End Sub

    Private Sub txtProductName_Leave(sender As Object, e As EventArgs) Handles txtProductName.Leave
        Try
            'MessageBox.Show(txtSupplier.Text)
            sqL = "SELECT  `itemid` FROM  `items` WHERE barcode LIKE  @0 and description like @1"
            msgShow = False
            vItemid = getIDFunction(sqL, "items", {txtBarcode.Text, txtProductName.Text})
            lblItemID.Text = vItemid

        Catch ex As Exception
            MessageBox.Show("error")
        End Try
    End Sub

    Private Sub txtBrand_Leave(sender As Object, e As EventArgs) Handles txtBrand.Leave
        Try
            'MessageBox.Show(txtSupplier.Text)
            sqL = "SELECT  `itemid` FROM  `items` WHERE barcode LIKE  @0 and description like @1 and brand like @2"
            msgShow = False
            vItemid = getIDFunction(sqL, "items", {txtBarcode.Text, txtProductName.Text, txtBrand.Text})
            lblItemID.Text = vItemid
            If vItemid = 0 Then
                openFull(frmProduct)
            End If
        Catch ex As Exception
            MessageBox.Show("error")
        End Try
    End Sub
End Class