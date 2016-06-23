
Public Class frmProduct
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        SqlRefresh = "select itemid,barcode,description,category,price from items"
        SqlReFill("items", ListView1)
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tx As New TextBox
        If txtTaxable.Checked = True Then
            tx.Text = 1
        End If
        Dim ing As New TextBox
        If rni.Checked = True Then
            ing.Text = 0
        ElseIf (ri.Checked = True) Then
            ing.Text = 1

        End If
        SqlRefresh = "select itemid,barcode,description,category,price from items"
        'check barcode if already on the list except empty
        Dim bcode As Integer = Integer.Parse(getIDFunction("select ifnull(barcode,0)barcode,ifnull(description,'')description,ifnull(Brand,'')Brand,ifnull(Price,'')Price from items where barcode like @0 or description like @1", "itemBarcode", {txtBarcode.Text, txtDescription.Text}))
        MessageBox.Show(bcode.ToString)
        If bcode = 0 Then
            itemNew("items", {"Barcode", "Description", "Brand", "Price", "UnitType", "Category", "Taxable", "ItemType"},
                {txtBarcode, txtDescription, txtBrand, txtPrice, txtUnit, txtCategory, tx, ing}, ListView1)
        Else
            txtDescription.Text = ds.Tables("itemBarcode").Rows(0).Item("description").ToString
        End If
    End Sub
End Class