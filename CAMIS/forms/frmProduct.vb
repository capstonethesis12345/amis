
Public Class frmProduct
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        SqlRefresh = "select itemid,barcode,description,category,price from items where itemtype <> 2"
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
        Dim txtboxes() As Object = {txtbarcode, txtDescription, txtBrand, txtPrice, txtUnitValue, txtUnitType, txtCategory, ing, txtInitialStock}
        If txtItemid.Text = "0" Or txtItemid.Text = vbNullString Then
            If bcode = 0 Then
                msgShow = True
                SqlRefresh = "select itemid,barcode,description,category,price from items where itemtype <> 2"
                itemNew("items", {"barcode", "description", "brand", "price", "unitvalue", "unittype", "category", "itemtype", "initialquantity"},
                   txtboxes, ListView1)
                lblSaveStatus.Text = "SUCCESS"
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
            itemUpdate("items", {"barcode", "description", "brand", "price", "unitvalue", "unittype", "category", "itemtype", "initialquantity"},
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
        getDSData("select barcode,description,brand,unitvalue,unittype,category,price,itemtype from items where itemid like @0", "products", {txtItemid.Text})
        If hasError = False Then
            Try
                txtbarcode.Text = ds.Tables("products").Rows(0).Item("barcode").ToString
                txtDescription.Text = ds.Tables("products").Rows(0).Item(1).ToString
                txtBrand.Text = ds.Tables("products").Rows(0).Item(2).ToString
                txtUnitValue.Text = ds.Tables("products").Rows(0).Item(3).ToString
                txtUnitType.Text = ds.Tables("products").Rows(0).Item(4).ToString
                txtCategory.Text = ds.Tables("products").Rows(0).Item(5).ToString
                txtPrice.Text = ds.Tables("products").Rows(0).Item(6).ToString
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
End Class