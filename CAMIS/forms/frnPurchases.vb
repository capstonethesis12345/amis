Imports MySql.Data

Public Class frmPurchases
    Private poid As String
    Public Sub New()
        InitializeComponent()
        'poid = getID("")
        SqlRefresh = "SELECT company FROM  `supplier` "
        itemAutoComplete("Supplier", txtSupplier)
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        StatusSet = "New"
        Dim sNew As New frmAddUpdateCategory()
        sNew.ShowDialog()
        sNew = Nothing
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lblSupplierID.Text = vbNullString Then
            openFull(frmSupplier)
        Else
            sqL = "SELECT  `Supplierid` FROM  `supplier` WHERE Company LIKE  @0"
            If getIDFunction(sqL, "SupplierID", {txtSupplier.Text}) = 0 Then    'is supplier is still not present repeat txtsupplier_leave
                txtSupplier_Leave(Button1, e)
            Else
                Dim itemID As Integer = Integer.Parse(getIDFunction("SELECT count(itemid)
                                                        FROM Items
                                                        WHERE supplierid LIKE @0 
                                                        AND barcode LIKE @1 
                                                        AND ItemDescription LIKE  @2
                                                        AND itembrand LIKE  @3
                                                        AND cost LIKE @4 ", "Items",
                                                    {lblSupplierID.Text, txtBarcode.Text, txtProductName.Text, txtBrand.Text, txtCost.Text}))
                If itemID = 0 Then
                    'insert all values to ITEM table'
                    itemNew("Items", {"SupplierID", "Barcode", "ItemDescription", "ItemBrand", "Cost"}, {lblSupplierID, txtBarcode, txtProductName, txtBrand, txtCost})
                Else
                    Dim currentPOID As String = getIDFunction("select max")

                    itemNew("polist", {"POID", "ItemID", "Quantity"}, {})
                    MessageBox.Show("Item existed inert to POList")
                    'get the current POID
                    'insert only the ITEMID to POLIST table and quatity
                End If

            End If

        End If

    End Sub

    Private Sub txtSupplier_Leave(sender As Object, e As EventArgs) Handles txtSupplier.Leave
        'LOST FOCUS WE WILL GET SUPPLIERID
        Try
            MessageBox.Show(txtSupplier.Text)
            sqL = "SELECT  `Supplierid` FROM  `supplier` WHERE Company LIKE  @0"
            lblSupplierID.Text = getIDFunction(sqL, "SupplierID", {txtSupplier.Text})

        Catch ex As Exception
            MessageBox.Show("error")
        End Try

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click, Label4.Click, Label6.Click, Label5.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBarcode.TextChanged, txtProductName.TextChanged, txtBrand.TextChanged, txtCost.TextChanged

    End Sub
End Class