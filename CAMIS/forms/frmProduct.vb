
Public Class frmProduct
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        'SqlRefresh = "SELECT i.itemid, i.barcode, i.description, i.category, i.price, (select sum(quantity) from polist where polist.itemid=i.itemid and polist.postatus=1)FROM ITEMS i LEFT JOIN POLIST l ON i.itemid = l.itemid where i.itemtype<>2 GROUP BY i.description LIMIT 0 , 30"
        SqlRefresh = "select i.itemid,i.barcode,i.description,i.category, i.price,i.unittype,sum(i.quantity+items.initialquantity) as onhand from vstockin i left join items on items.itemid=i.itemid group by i.itemid"
        SqlReFill("items", ListView1)
        ' Add any initialization after the InitializeComponent() call.
        txtItemid.Text = ""
        lblSaveStatus.Text = ""
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ing As New TextBox
        If nonIncredient.Checked = True Then
            ing.Text = 0
        ElseIf (ingredient.Checked = True) Then
            ing.Text = 1

        End If
        SqlRefresh = "select itemid,barcode,description,category,price from items"
        'check barcode if already on the list except empty
        msgShow = False
        Dim bcode As Integer = Integer.Parse(getIDFunction("select ifnull(barcode,0)barcode,ifnull(description,'')description,ifnull(Brand,'')Brand,ifnull(Price,'')Price from items where barcode like @0 or description like @1", "itemBarcode", {txtbarcode.Text, txtDescription.Text}))
        'MessageBox.Show(bcode.ToString)
        Dim avaiablility As New TextBox
        If CheckBox1.Checked = True Then
            avaiablility.Text = "1"
        Else
            avaiablility.Text = "0"
        End If
        Dim txtboxes() As Object = {txtbarcode, txtDescription, txtBrand, txtPrice, txtUnitValue, txtUnitType, txtCategory, ing, txtInitialStock, avaiablility}
        If txtItemid.Text = "0" Or txtItemid.Text = vbNullString Then
            If bcode = 0 Then
                msgShow = True
                SqlRefresh = "select itemid,barcode,description,category,price from items where itemtype <> 2"
                itemNew("items", {"barcode", "description", "brand", "price", "unitvalue", "unittype", "category", "itemtype", "initialquantity", "salestatus"},
                   txtboxes, ListView1)
                lblSaveStatus.Text = "SUCCESS"
                txtbarcode.Text = ""
                txtDescription.Text = ""
                txtBrand.Text = ""
                txtPrice.Text = ""
                txtUnitValue.Text = ""
                txtUnitType.Text = ""
                txtCategory.Text = ""
                ing.Text = ""
                txtInitialStock.Text = ""
                avaiablility.Text = ""
                Timer1.Start()
                For Each t In txtboxes
                    t.text = ""
                Next
                txtItemid.Text = ""
            Else
                MessageBox.Show("Barcode already available")
            End If
        Else


            SqlRefresh = "select itemid,barcode,description,category,price from items where itemtype <> 2"
            itemUpdate("items", {"barcode", "description", "brand", "price", "unitvalue", "unittype", "category", "itemtype", "initialquantity", "salestatus"},
                       txtboxes, "itemid", txtItemid.Text, ListView1)
            lblSaveStatus.Text = "SAVED"
            Timer1.Start()
            'itemUpdate()
            'txtDescription.Text = ds.Tables("itemBarcode").Rows(0).Item("description").ToString
        End If


    End Sub


    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        txtItemid.Text = ListView1.SelectedItems(0).SubItems(0).Text.ToString
    End Sub

    Private Sub txtItemid_TextChanged(sender As Object, e As EventArgs) Handles txtItemid.TextChanged
        'SqlRefresh = "select ifnull(barcode,''),ifnull(description,''),ifnull(brand,''),ifnull(price,'0.0'),ifnull(unittype,''),ifnull(category,''),ifnull(initialquantity,'') from items where items.itemid like @itemid"
        'SqlReFill("products", Nothing, "ShowValueInTextbox", {"itemid"}, {txtItemid}, {txtbarcode, txtDescription, txtBrand, txtPrice, txtUnitType, txtCategory, txtInitialStock})
        msgShow = False
        getDSData("select barcode,description,brand,unitvalue,unittype,category,price,itemtype,salestatus from items where itemid like @0", "products", {txtItemid.Text})
        If hasError = False Then
            Try
                txtbarcode.Text = ds.Tables("products").Rows(0).Item("barcode").ToString
                txtDescription.Text = ds.Tables("products").Rows(0).Item(1).ToString
                txtBrand.Text = ds.Tables("products").Rows(0).Item(2).ToString
                txtUnitValue.Text = ds.Tables("products").Rows(0).Item(3).ToString
                txtUnitType.Text = ds.Tables("products").Rows(0).Item(4).ToString
                txtCategory.Text = ds.Tables("products").Rows(0).Item(5).ToString
                txtPrice.Text = ds.Tables("products").Rows(0).Item(6).ToString
                If ds.Tables("products").Rows(0).Item(6).ToString = "2" Then
                    CheckBox1.Checked = False
                    GroupBox4.Enabled = False
                Else
                    CheckBox1.Checked = True
                    GroupBox4.Enabled = True
                    If ds.Tables("products").Rows(0).Item(8).ToString = "0" Then
                        CheckBox1.Checked = False
                    Else
                        CheckBox1.Checked = True
                    End If
                End If
                ''MessageBox.Show(ds.Tables("products").Rows(0).Item(7).ToString)
                If ds.Tables("products").Rows(0).Item(7).ToString = False Then
                    nonIncredient.Checked = True
                Else
                    ingredient.Checked = True

                End If
            Catch ex As Exception

            End Try

        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblSaveStatus.Text = ""
        Timer1.Stop()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
    Dim sortColumn As Integer = -1
    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView1.ColumnClick
        If e.Column <> sortColumn Then
            ' Set the sort column to the new column.
            sortColumn = e.Column
            ' Set the sort order to ascending by default.
            ListView1.Sorting = SortOrder.Ascending
        Else
            ' Determine what the last sort order was and change it.
            If ListView1.Sorting = SortOrder.Ascending Then
                ListView1.Sorting = SortOrder.Descending
            Else
                ListView1.Sorting = SortOrder.Ascending
            End If
        End If
        ' Call the sort method to manually sort.
        ListView1.Sort()
        ' Set the ListViewItemSorter property to a new ListViewItemComparer
        ' object.
        ListView1.ListViewItemSorter = New ListViewItemComparer(e.Column, ListView1.Sorting)
    End Sub

    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles Me.Load
        If status = "Cook" Then
            txtPrice.Enabled = False
            txtInitialStock.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtbarcode.Text = ""
        txtDescription.Text = ""
        txtBrand.Text = ""
        txtPrice.Text = ""
        txtUnitValue.Text = ""
        txtUnitType.Text = ""
        txtCategory.Text = ""
        txtInitialStock.Text = ""

    End Sub

    Private Sub txtCategory_TextChanged(sender As Object, e As EventArgs) Handles txtCategory.KeyUp
        itemAutoComplete("categories", txtCategory)
    End Sub

    Private Sub txtUnitValue_TextChanged(sender As Object, e As EventArgs) Handles txtUnitValue.TextChanged
        txtUnitValue = casenumbers(txtUnitValue)
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        txtPrice = casenumbers(txtPrice)
    End Sub

    Private Sub txtInitialStock_TextChanged(sender As Object, e As EventArgs) Handles txtInitialStock.TextChanged
        txtInitialStock = casenumbers(txtInitialStock)
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class