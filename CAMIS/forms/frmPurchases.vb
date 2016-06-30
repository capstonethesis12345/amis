Imports MetroFramework
Imports MySql.Data

Public Class frmPurchases
    Private insertProduct As Boolean = True
    Private poid As String
    Private vItemid As String = 0
    Private vRefresh As String

    Public Sub New()
        InitializeComponent()

        'poid = getID("")
        lblEmpID.Text = vEmp
        objAutoComplete()
        'SqlRefresh = vRefresh
        'SqlReFill("polist", ListView1)
        'Dim poid As String = getIDFunction("select ifnull(max(poid),1) from po where status <>1", "purchaseorder", Nothing)


        lblTotal.Text = String.Format(Globalization.CultureInfo.GetCultureInfo("en-PH"), computeSum())

    End Sub

    Private Sub frmPurchases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ErrMessageText = "Error on poid getIDFunction lke 54"
        poid = getIDFunction("select ifnull(max(poid),(select max(poid)+1 from po)) from po where status=0 and empid='" & vEmp & "'", "poid", Nothing, True).ToString
        lblPONum.Text = poid

        vRefresh = "select polist.polistid,items.barcode,items.description,concat('1 ',items.unittype)unittype,polist.cost,polist.quantity,(polist.cost*polist.quantity)total,if(items.itemtype=0,'Non-Ingredient',if(items.itemtype=1,'Ingredient','Nonspecified'))itemtype,(supplier.company)company,supplier.supplierid,supplier.company from polist
            left join po
            on po.poid=polist.poid
            left join items
            on items.itemid=polist.itemid
inner join supplier
on supplier.supplierid=po.supplierid where po.poid like '" & poid & "' and empid like '" & vEmp & "' "
        msgShow = True
        ErrMessageText = "Error already available"
        Dim checkContent As Integer = Integer.Parse(getIDFunction("SELECT Count(poid) FROM `po` where poid=@0 and empid=@1", "CountPO", {poid, vEmp}), False)
        If checkContent > 0 Then
            SqlRefresh = vRefresh
            SqlReFill("Purchases", ListView1)
            Try
                lblSupplier.Text = ds.Tables("Purchases").Rows(0).Item("company").ToString
                lblSupplierID.Text = ds.Tables("Purchases").Rows(0).Item("supplierid").ToString
                txtSupplier.Text = lblSupplier.Text
                txtSupplier.ReadOnly = True
            Catch ex As Exception
                'txtSupplier.ReadOnly = False
                If lblSupplierID.Text = vbNullString Then
                    txtSupplier.ReadOnly = False
                Else
                    txtSupplier.ReadOnly = True
                End If
            End Try


        ElseIf (checkContent = 0) Then
            Dim NewStatus As New TextBox
            NewStatus.Text = "0"
            msgShow = True
            ErrMessageText = "Error on itemnew"
            itemNew("po", {"poid", "status", "empid"}, {lblPONum, NewStatus, lblEmpID})

        End If

        lblTotal.Text = computeSum()


    End Sub
    Sub objAutoComplete()
        SqlRefresh = "SELECT company FROM  `supplier` "
        itemAutoComplete("Supplier", txtSupplier)
        SqlRefresh = "SELECT `barcode` FROM `items` where itemtype like 0 or itemtype like 1"
        itemAutoComplete("AutoDescription", txtBarcode)
        SqlRefresh = "select category from items where category <> null"
        itemAutoComplete("category", txtcategory)
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
    Sub importantFillup()
        If txtProductName.Text = vbNullString Then
            insertProduct = False
            MessageBox.Show("Product description must be filled up")
            txtProductName.Focus()
            Exit Sub
        End If
        If txtCost.Text = vbNullString Then
            insertProduct = False
            MessageBox.Show("Cost amount must be filled up")
            txtCost.Focus()
            Exit Sub
        End If
        If txtQuantity.Text = vbNullString Then
            insertProduct = False
            MessageBox.Show("Quantity must be filled up")
            txtQuantity.Focus()
            Exit Sub
        End If
        If insertProduct = False Then
            MessageBox.Show("All data must be filled up first")
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddUpdate.Click
        Dim tvsupplier As New TextBox
        'txtSupplier_Leave(btnAddUpdate, e)
        'importantFillup()


        If Not txtSupplier.Text = vbNullString Then
            'MessageBox.Show("txtsupplier are filled up")
            'update suppler on PO table
            itemUpdate("po", {"supplierid"}, {lblSupplierID}, "poid", lblPONum.Text)
            '  MessageBox.Show("Line 128: Disabling Supplier input")
            txtSupplier.ReadOnly = True
        Else
            MessageBox.Show("Supplier name must be filled up first")
            insertProduct = False
            Exit Sub
        End If



        'CHECK IF BARCODE AND DESCRIPTION ARE ALREADY ON THE ITEMLIST and update
        If insertProduct = True Then
            If checkItemDuplicate() = True Then
                MessageBox.Show("Item already on the list, update table purchase list")
            Else
                'if item already exists in items table get itemid
                Dim id As String
                id = vInsertedItem()
                Dim itemid As String = getStrData("select itemid from items where barcode like @0 and description like @1", "isExisted", {txtBarcode.Text, txtProductName.Text})
                'Else add a new item product
                insertedItemOrder(itemid)

                ' If insertedItemOrder() = True Then
                ' MessageBox.Show("Success")
                ' End If


            End If
        End If
        'get max poid' and compare to currect potext




        'DO NOT UPDATE BELOW
        '------------------------------------------
        'COMPUTE SUM AMOUNT
        lblTotal.Text = computeSum()
        If insertProduct = True Then
            'CLEAR TEXTBOXEX
            Dim txtboxes As Object() = {lblItemID, txtBarcode, txtProductName, txtBrand, txtCost, txtQuantity}
            clearField(txtboxes)
            '----------------------------------------------
        End If
        'REFRESH INSERTION ITEM
        insertProduct = True
        SqlRefresh = vRefresh
        SqlReFill("Purchases", ListView1)
    End Sub
    Sub compareID()
        Dim currentID As Integer = getIDFunction("select ifnull(max(poid),0) from po", "MaxID")
        If Not Integer.Parse(currentID) = lblPONum.Text Then
            MessageBox.Show("DB max poid is not equal to current poid")
        Else
            MessageBox.Show("Inserting poid")

        End If

    End Sub
    Function vInsertedItem() As String
        Dim inItem As String = "0"
        Dim runittype As New TextBox
        Dim itemKind As New TextBox
        If (pcs.Checked = True) Then
            runittype.Text = "pcs"
        ElseIf (lbs.Checked = True) Then
            runittype.Text = "lbs"
        Else
            runittype.Text = "kgs"
        End If
        If nonIngredient.Checked = True Then
            itemKind.Text = "0"
        Else
            itemKind.Text = "2"
        End If
        importantFillup()
        itemNew("items", {"Barcode", "Description", "Brand", "UnitType", "ItemType"}, {txtBarcode, txtProductName, txtBrand, runittype, itemKind})
        inItem = getStrData("select itemid from items where barcode like @0 and description like @1", "items", {txtBarcode.Text, txtProductName.Text})
        Return inItem
    End Function
    Function insertedItemOrder(ByVal id As String) As Boolean
        Dim inItem As Boolean = False
        If inItem = False Then
            lblItemID.Text = id
            SqlRefresh = vRefresh
            itemNew("polist", {"POID", "ItemID", "Quantity", "Cost"}, {lblPONum, lblItemID, txtQuantity, txtCost}, ListView1)
            inItem = True

        End If
        Return inItem
    End Function
    Function checkItemDuplicate() As Boolean
        'this method will be used for duplicated item that needs for an update'
        Dim isDupplicatated As Boolean = False
        SqlRefresh = "select poid,itemid from polist where poid like @0 and itemid like @1"
        Dim polistid As String = getStrData(SqlRefresh, "itemExisted", {lblPONum.Text, lblItemID.Text})
        'MessageBox.Show("Existed in polistid =" & polistid)
        If polistid = vbNullString Then
            isDupplicatated = False
        Else
            isDupplicatated = True
        End If
        Return isDupplicatated
    End Function
    Private Sub txtSupplier_Leave(sender As Object, e As EventArgs) Handles txtSupplier.Leave
        'LOST FOCUS WE WILL GET SUPPLIERID
        Try
            'MessageBox.Show(txtSupplier.Text)
            sqL = "SELECT  `supplierid` FROM  `supplier` WHERE company LIKE  @0"
            msgShow = False
            lblSupplierID.Text = getStrData(sqL, "supplierid", {txtSupplier.Text})
            If lblSupplierID.Text = "0" Or lblSupplierID.Text = vbNullString Then
                openFull(frmSupplier)
                If Not txtSupplier.Text = vbNullString Then
                    frmSupplier.txtSupplier.Text = txtSupplier.Text
                    lblSupplier.Text = txtSupplier.Text
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("error")
        End Try

    End Sub


    Private Sub txtBarcode_Leave(sender As Object, e As EventArgs) Handles txtBarcode.Leave
        If Not txtBarcode.Text = vbNullString Then
            Dim getBarcode As String
            Try
                msgShow = False
                getBarcode = getStrData("select ifnull(itemid,0)itemid from items where barcode like @0 and itemtype = 0 or itemtype = 1", "Barcode", {txtBarcode.Text})
                If getBarcode = 0 Then
                    insertProduct = True
                    Exit Sub
                Else
                    lblItemID.Text = getBarcode

                End If
            Catch ex As Exception
                getBarcode = 0
            End Try

        Else
            'MessageBox.Show("txtbarcode empty")
            lblItemID.Text = 0
            txtProductName.ReadOnly = False
            txtProductName.Text = ""
            txtBrand.ReadOnly = False
            txtBrand.Text = ""


        End If
    End Sub

    Private Sub lblItemID_TextChanged(sender As Object, e As EventArgs) Handles lblItemID.TextChanged
        Try
            If Not lblItemID.Text = 0 Or lblItemID.Text IsNot vbNullString Then
                SqlRefresh = "select description,ifnull(brand,'')brand,ifnull(barcode,'')barcode,unittype,itemtype from items where itemid like @itemid"
                msgShow = False
                SqlReFill("items", Nothing, "ShowValueInTextbox", {"itemid"}, {lblItemID}, {txtProductName, txtBrand, txtBarcode})
                Select Case ds.Tables("items").Rows(0).Item("unittype").ToString
                    Case Is = "pcs"
                        pcs.Checked = True
                        Exit Select
                    Case Is = "lbs"
                        lbs.Checked = True
                        Exit Select
                    Case Is = "kgs"
                        kgs.Checked = True
                        Exit Select
                End Select
                groupProductType.Enabled = False
                Select Case ds.Tables("items").Rows(0).Item("itemtype").ToString
                    Case Is = False
                        nonIngredient.Checked = True
                        ingredient.Checked = False
                        Exit Select
                    Case Is = True
                        nonIngredient.Checked = False
                        ingredient.Checked = True
                        Exit Select
                End Select
                MessageBox.Show("Ingredient type =" & ds.Tables("items").Rows(0).Item("itemtype").ToString)
                ' MessageBox.Show("Enable readonly to txtproduct and txtbrand")
                txtProductName.ReadOnly = True
                txtBrand.ReadOnly = True
                groupUnit.Enabled = False
            Else
                txtProductName.ReadOnly = False
                txtBrand.ReadOnly = False
                txtProductName.Text = ""
                txtBrand.Text = ""
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Function computeSum()
        Dim total As Double = 0.0
        For Each row In ListView1.Items
            total += Double.Parse(row.subitems(4).text) * Double.Parse(row.subitems(5).text)
        Next

        Return total.ToString("C", Globalization.CultureInfo.GetCultureInfo("en-PH"))
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
        '   If txtProductName.Text = vbNullString Then
        '   Exit Sub
        '   End If
        '
        '       Try
        '
        '        'MessageBox.Show(txtSupplier.Text)
        '
        ''       msgShow = False
        '       If txtBarcode.Text = vbNullString Then
        '
        ' If Not txtProductName.Text = vbNullString Then

        ''        sqL = "SELECT  ifnull(`itemid`,0)  FROM  `items` WHERE  description LIKE  @0"
        '        If IsError(getStrData(sqL, "items", {txtProductName.Text})) = True Then
        '       vItemid = 0
        ''       Else
        '       vItemid = getStrData(sqL, "items", {txtProductName.Text})
        '      End If
        ''
        ''End If
        ' MessageBox.Show("barcode empty " & vItemid)
        '  Else
        '  MessageBox.Show("barcode NOT empty ")
        ' If Not txtProductName.Text = vbNullString Then
        '' sqL = "SELECT  `itemid`  FROM  `items` WHERE barcode like @0 description LIKE  @1"
        ' vItemid = getStrData(sqL, "items", {txtBarcode.Text, txtProductName.Text})
        ''End If
        '
        ''End If
        'If vItemid = vbNullString Then
        ''vItemid = "0"
        'End If
        ''lblItemID.Text = vItemid
        '
        ''Catch ex As Exception
        'MessageBox.Show("error identifying products")
        ''End Try
        '

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SqlRefresh = vRefresh
        Dim tstatus As New TextBox
        If MessageBox.Show("Are you sure this transaction is complete?", "Notice", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            tstatus.Text = 1
            itemUpdate("po", {"Status"}, {tstatus}, "poid", lblPONum.Text)
            SqlRefresh = vRefresh
            SqlReFill("po", ListView1)
        End If
        SqlRefresh = vRefresh
        SqlReFill("Purchases", ListView1)
    End Sub

    Private Sub txtSupplier_TextChanged(sender As Object, e As EventArgs) Handles txtSupplier.TextChanged

    End Sub
End Class