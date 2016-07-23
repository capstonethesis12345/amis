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
    Sub refreshlist()
        SqlRefresh = vRefresh
        SqlReFill("Purchases", ListView1)
        lblTotal.Text = computeSum()
    End Sub
    Private Sub frmPurchases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ErrMessageText = "Error on poid getIDFunction lke 26"
        msgShow = False
        poid = getIDFunction("select ifnull(max(poid),(select max(poid)+1 from po)) from po where status=0 and empid='" & vEmp & "'", "poid", Nothing, True).ToString
        lblPONum.Text = poid

        vRefresh = "select polist.polistid,items.barcode,items.description,concat('1 ',items.unittype)unittype,polist.cost,polist.quantity,(polist.cost*polist.quantity)total,if(items.itemtype=0,'Non-Ingredient',if(items.itemtype=1,'Non-Ingredient','Ingredient'))itemtype,(supplier.company)company,supplier.supplierid,polist.postatus from polist
            left join po
            on po.poid=polist.poid
            left join items
            on items.itemid=polist.itemid
inner join supplier
on supplier.supplierid=po.supplierid where po.poid like '" & poid & "' and empid like '" & vEmp & "'"
        msgShow = True
        ErrMessageText = "Error already available"
        Dim checkContent As Integer = Integer.Parse(getIDFunction("SELECT Count(poid) FROM `po` where poid=@0 and empid=@1", "CountPO", {poid, vEmp}), False)
        If checkContent > 0 Then
            refreshlist()
            Try
                lblSupplier.Text = ds.Tables("Purchases").Rows(0).Item("company").ToString
                lblSupplierID.Text = ds.Tables("Purchases").Rows(0).Item("supplierid").ToString
                txtSupplier.Text = lblSupplier.Text

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
            msgShow = False
            ErrMessageText = "Error on itemnew"
            itemNew("po", {"poid", "status", "empid"}, {lblPONum, NewStatus, lblEmpID})
            msgShow = False
            lblPONum.Text = getStrData("select max(poid) from po where empid like @0", "ponum", {lblEmpID.Text})
        End If
        If lblSupplier.Text <> vbNullString Then
            txtSupplier.ReadOnly = True
        End If

        lblTotal.Text = computeSum()
        If lblSupplier.Text = "0" Or lblSupplier.Text = vbNullString Then
            txtSupplier.ReadOnly = False
        Else

            Dim currDate As String = getStrData("select podate from po where poid=@0", "getPODate", {lblPONum.Text})
            Me.podate.MinDate = currDate
            Me.podate.MaxDate = currDate
        End If

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
    Function importantFillup()
        Dim hasError As Boolean = False
        If txtProductName.Text = vbNullString Then
            insertProduct = False
            MessageBox.Show("Product description must be filled up")
            txtProductName.Focus()
            hasError = True

        End If
        If txtCost.Text = vbNullString Then
            insertProduct = False
            MessageBox.Show("Cost amount must be filled up")
            txtCost.Focus()
            hasError = True
        End If
        If txtQuantity.Text = vbNullString Then
            insertProduct = False
            MessageBox.Show("Quantity must be filled up")
            txtQuantity.Focus()
            hasError = True
        End If
        If insertProduct = False Then
            MessageBox.Show("All data must be filled up first")
        End If

        Return hasError
    End Function


    Sub compareID()
        msgShow = False
        Dim currentID As Integer = getIDFunction("select ifnull(max(poid),1) from po", "MaxID")
        If Not Integer.Parse(currentID) = lblPONum.Text Then
            MessageBox.Show("DB max poid is not equal to current poid")
        Else
            MessageBox.Show("Inserting poid")

        End If

    End Sub
    Function getUnitTypeValue() As String
        Dim runittype As String
        If (pcs.Checked = True) Then
            runittype = "pcs"
        ElseIf (kgs.Checked = True) Then
            runittype = "kg"
        ElseIf (g.Checked = True) Then
            runittype = "g"
        ElseIf (mg.Checked = True) Then
            runittype = "mg"
        Else
            runittype = "0"
        End If
        Return runittype
    End Function
    Function insertedItemOrder(ByVal id As String) As Boolean
        Dim inItem As Boolean = False
        If inItem = False Then
            msgShow = False
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
        msgShow = False
        Dim polistid As String = getStrData(SqlRefresh, "itemExisted", {lblPONum.Text, lblItemID.Text})
        'MessageBox.Show("Existed in polistid =" & polistid)
        If polistid = vbNullString Then
            isDupplicatated = False
        Else
            isDupplicatated = True
        End If
        Return isDupplicatated
    End Function
    Sub getSuppierid(ByVal isRequired As Boolean)
        'LOST FOCUS WE WILL GET SUPPLIERID
        Try
            'MessageBox.Show(txtSupplier.Text)
            sqL = "SELECT  `supplierid`,`company` FROM  `supplier` WHERE company LIKE  @0"
            msgShow = False
            lblSupplierID.Text = getStrData(sqL, "supplierid", {txtSupplier.Text})
            If lblSupplierID.Text = "0" Or lblSupplierID.Text = vbNullString Then
                If isRequired = True Then
                    openFull(frmSupplier)

                End If
                If Not txtSupplier.Text = vbNullString Then
                        frmSupplier.txtSupplier.Text = txtSupplier.Text
                    lblSupplier.Text = ds.Tables("supplierid").Rows(0).Item(1).text.ToString
                End If
                End If
        Catch ex As Exception
            lblSupplierID.Text = 0
            lblSupplier.Text = 0
        End Try
    End Sub
    Sub isSupplierExists(ByVal SupplierName As String)
        'sqL = "SELECT  `supplierid` FROM  `supplier` WHERE company LIKE  @0"
        'lblSupplierID.Text = getStrData(sqL, "supplierid", {txtSupplier.Text})
        getSuppierid(False)
    End Sub

    Private Sub txtBarcode_Leave(sender As Object, e As EventArgs) Handles txtBarcode.Leave
        If Not txtBarcode.Text = vbNullString Then
            Dim getBarcode As String
            Try
                msgShow = False
                getBarcode = getStrData("select ifnull(itemid,0)itemid from items where barcode like @0 and itemtype <> 2", "Barcode", {txtBarcode.Text})
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
                    Case Is = "g"
                        g.Checked = True
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
                ' MessageBox.Show("Ingredient type =" & ds.Tables("items").Rows(0).Item("itemtype").ToString)
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


        '   Dim ref As New TextBox
        '  ref.Text = ListView1.SelectedItems(0).Text.ToString
        'SqlRefresh =
        '    "select polist.itemid,
        '   (supplier.company)supplierName,
        '   items.barcode
        '   from                polist 
        '   left join            items
        '   ON polist.itemid=items.itemid
        '    left join           supplier
        '    on supplier.supplierid=items.supplierid
        '   WHERE polist.polistid like  @itemid"
        'SqlReFill("updateitem", Nothing, "ShowValueInTextbox", {"itemid"}, {ref}, {lblItemID, txtSupplier, txtBarcode})
        ''DISABLE SUPPLIER
        '' txtSupplier.ReadOnly = True
        ''txtBarcode.ReadOnly = True
        'btnDelete.Visible = True
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
            Dim ddate As New TextBox
            ddate.Text = Date.Now.ToString("yyyy-MM-dd")
            If (CheckBox1.Checked = True) Then
                For i = 0 To ListView1.Items.Count - 1
                    If ListView1.Items(i).SubItems(7).Text.ToString = "Non-Ingredient" Then
                        msgShow = False
                        itemUpdate("items", {"salestatus"}, {tstatus}, "description", ListView1.Items(i).SubItems(2).Text.ToString)
                    End If
                Next
            End If
            itemUpdate("po", {"Status", "podeliverydate"}, {tstatus, ddate}, "poid", lblPONum.Text)
            SqlRefresh = vRefresh
            '   SqlReFill("po", ListView1)
            SqlRefresh = vRefresh
            SqlReFill("Purchases", ListView1)

        End If
        SqlRefresh = vRefresh
        SqlReFill("Purchases", ListView1)
    End Sub

    Private Sub txtSupplier_TextChanged(sender As Object, e As EventArgs) Handles txtSupplier.TextChanged
        getSuppierid(False)
    End Sub

    Private Sub btnAddUpdate_Click(sender As Object, e As EventArgs) Handles btnAddUpdate.Click

        ' isSupplierExists(txtSupplier.Text)
        getSuppierid(True)
        If lblSupplierID.Text = vbNullString Then
            MessageBox.Show("Add supplier first.")
            openFull(frmSupplier)
            Exit Sub
        End If
        If txtSupplier.Text = vbNullString Then
            MessageBox.Show("Supplier must be filled up first")
            Exit Sub

        ElseIf txtSupplier.Text = vbNullString Then
            MessageBox.Show("Barcode must be filled up first")
            Exit Sub
        ElseIf txtProductName.Text = vbNullString Then
            MessageBox.Show("Description must be filled up first")
            Exit Sub
        ElseIf txtBrand.Text = vbNullString Then
            MessageBox.Show("Brand must be filled up first")
            Exit Sub

        ElseIf txtCost.Text = vbNullString Then
            MessageBox.Show("Cost must be filled up first")
        ElseIf txtQuantity.Text = vbNullString Then
            MessageBox.Show("Quantity must be filled up first")
        Else

            Dim sid As New TextBox
            sid.Text = getStrData("select supplierid from supplier where company like @0", "supplier", {txtSupplier.Text})
            itemUpdate("po", {"supplierid", "podate"}, {sid, podate}, "poid", lblPONum.Text)

            If lblItemID.Text = vbNullString Or lblItemID.Text = "0" Then
                Dim unittype As New TextBox
                unittype.Text = getUnitTypeValue()
                Dim producttype As New TextBox
                producttype.Text = getProductType()
                itemNew("items", {"barcode", "description", "brand", "price", "unittype", "category", "itemtype"}, {txtBarcode, txtProductName, txtBrand, txtCost, unittype, txtcategory, producttype})
            End If


            'add to polist
            'getpoid
            Dim itmId As New TextBox
            msgShow = False
            Dim tid As String = getStrData("select ifnull(itemid,max(itemid)) from items where barcode like @0 and description like @1", "itemsName", {txtBarcode.Text, txtProductName.Text})
            itmId.Text = tid

            itemNew("polist", {"poid", "itemid", "quantity", "cost"}, {lblPONum, itmId, txtQuantity, txtCost})
            'clear textboxes expt supplier

            txtProductName.Text = ""
            txtBarcode.Text = ""
            txtBrand.Text = ""
            txtCost.Text = ""
            txtQuantity.Text = ""
            groupProductType.Enabled = True
            txtcategory.Text = ""
        End If
        refreshlist()


        'If lblSupplierID.Text = vbNullString Then

        'update podate
        '1.get podate string if 0000-00-00 then enable update
        'Dim SDate As String = getStrData("select ifnull(podate,'') from po where poid like @0", "getPODate", {lblPONum.Text}).text.ToString
        'MessageBox.Show(SDate)

        'End If
    End Sub
    Function getProductType()
        Dim type As String = ""
        If nonIngredient.Checked = True Then
            type = "0"
        Else
            type = "1"
        End If
        Return type
    End Function
    Function isItemExisted(ByVal itemid As String) As Boolean
        Dim isErrOccured As Boolean = False
        Dim id As String = getStrData("select ifnull(itemid,max(itemid)) from items where barcode like @0 and description like @1", "itemsName", {txtBarcode.Text, txtProductName.Text})
        If id = vbNullString Then
            If importantFillup() = True Then
                isErrOccured = True
                Exit Function
            Else
                'insert to product


                'transfer txtsuppliername to lblsuppliername
                Return isErrOccured
            End If

        End If
        Return isErrOccured
    End Function
    Private Sub txtBarcode_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBarcode.KeyUp
        If txtBarcode.Text = vbNullString Then
            groupProductType.Enabled = True
            groupUnit.Enabled = True
            With txtProductName
                .ReadOnly = False
                .Text = ""
            End With
            With txtBrand
                .ReadOnly = False
                .Text = ""
            End With

        End If
    End Sub

    Private Sub podate_ValueChanged(sender As Object, e As EventArgs) Handles podate.ValueChanged

    End Sub
    Dim lv2 As New ListView()
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListView2.Visible = True
        ListView2.BringToFront()
        SqlRefresh = "select itemid,description from items where description like @description"
        SqlReFill("searchItem", ListView1, Nothing, {"description"}, {txtProductName})


    End Sub

    Private Sub txtQuantity_KeyUp(sender As Object, e As KeyEventArgs) Handles txtQuantity.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnAddUpdate.Focus()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Dim status As New TextBox
        status.Text = "1"
        itemUpdate("polist", {"postatus"}, {status}, "poid", lblPONum.Text)

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs)

    End Sub

    'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    '    MessageBox.Show(ListView1.SelectedItems(0).SubItems(7).Text.ToString)
    'End Sub
End Class