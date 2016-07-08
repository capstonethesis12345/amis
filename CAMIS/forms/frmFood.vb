Public Class frmFood
    Dim sqlFoodName As String = "select barcode,description,price from items where itemtype like 2"
    Dim sqlFoodIngredient As String = "select itemid, description from items where itemtype=1"
    Sub New()

        ' This call is required by the designer.
        getData()
        InitializeComponent()
        filldata()
        lblFoodItemID.Text = ""
        lblStatus.Text = ""
    End Sub

    Sub filldata()
        SqlRefresh = sqlFoodName
        SqlReFill("sqlFoodName", ListView3)
        ' Add any initialization after the InitializeComponent() call.
        SqlRefresh = sqlFoodIngredient
        SqlReFill("Ingredient", ListView1)
    End Sub

    Private Sub dataClear() Handles btnClear.Click
        txtBarcode.Text = ""
        txtMenuName.Text = ""
        txtPrice.Text = ""
        lblFoodItemID.Text = ""
    End Sub
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        '   If txtMenuName.Text = vbNullString Then
        '   MessageBox.Show("Provide product name")
        '   Exit Sub
        '   End If
        '  SqlRefresh = sqlFoodName
        '  Dim type As New TextBox
        '   Type.Text = 2
        '  Dim isItemIDExists As Integer = getIDFunction("select count(itemid) from items where itemid like @0", "itemid", {lblFoodItemID.Text})
        ''
        'If isItemIDExists = 0 Then
        'itemNew("items", {"Barcode", "Description", "Price", "ItemType"}, {txtBarcode, txtMenuName, txtPrice, type})
        ''Else
        '
        '       End If
        ''       Dim fid As New TextBox
        '       msgShow = False
        '      fid.Text = getStrData("SELECT itemid FROM items where description like @0", "foodIngredientList", {txtMenuName.Text})
        ''
        'If ListView2.Items.Count > 0 Then
        ' For i As Integer = 0 To ListView2.Items.Count - 1
        '
        'Dim ing As New TextBox
        ' ing.Text = ListView2.Items(i).SubItems(0).Text
        'Dim txt As New TextBox
        'txt.Text = ListView2.Items(i).SubItems(2).Text
        '
        ''       msgShow = False
        '       itemNew("foodingredient", {"foodid", "itemid", "quantity"}, {fid, ing, txt})
        '
        ''Next
        'End If

        'SqlRefresh = sqlFoodName
        'SqlReFill("items", ListView3)
        Dim cIngredient As Integer = 0
        cIngredient = ListView2.Items.Count
        For i = 0 To cIngredient - 1
            Dim fid As New TextBox
            msgShow = False
            Dim ing As New TextBox
            ing.Text = ListView2.Items(i).SubItems(0).Text
            Dim txt As New TextBox
            txt.Text = ListView2.Items(i).SubItems(2).Text

            fid.Text = getStrData("SELECT itemid FROM items where description like @0", "foodIngredientList", {txtMenuName.Text})
            itemNew("foodingredient", {"foodid", "itemid", "quantity"}, {fid, ing, txt})

        Next


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'get data list view2
        ' For Each r In ListView2.Items
        Dim quantity As Integer
        Try
            quantity = InputBox("Enter Quantity")
        Catch ex As Exception
            MessageBox.Show("Please input quantity")
            Exit Sub
        End Try


        Dim idSelected As String = ListView1.SelectedItems(0).Text.ToString
        Dim description As String = ListView1.SelectedItems(0).SubItems(1).Text.ToString

        Dim lv As New ListViewItem(idSelected.ToString)
        lv.SubItems.Add(description)
        lv.SubItems.Add(quantity)
        ListView2.Items.Add(lv)


        ListView1.SelectedItems(0).Remove()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim idSelected As String = ListView2.SelectedItems(0).Text.ToString
            Dim description As String = ListView2.SelectedItems(0).SubItems(1).Text.ToString

            Dim lv As New ListViewItem(idSelected.ToString)
            lv.SubItems.Add(description)
            ListView1.Items.Add(lv)

            For Each item As ListViewItem In ListView2.SelectedItems
                item.Remove()
            Next
            If ListView2.Items.Count > 1 Then

                ListView2.Items(ListView2.Items.Count - 1).Selected = True
            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub ListView3_DoubleClick(sender As Object, e As EventArgs) Handles ListView3.DoubleClick
        Dim selected As String = ListView3.SelectedItems(0).SubItems(0).Text
        Dim barcode As New TextBox
        barcode.Text = selected
        SqlRefresh = "select itemid,barcode,description,price from items where barcode like @barcode"
        SqlReFill("items", Nothing, "ShowValueInTextbox", {"barcode"}, {barcode}, {lblFoodItemID, txtBarcode, txtMenuName, txtPrice})
        SqlRefresh = "select f.ingredientid,i.itemid,i.description,f.unit,f.quantity from items i left join foodingredient f on f.itemid=i.itemid where f.foodid like '" & lblFoodItemID.Text & "'"
        SqlReFill("ingredients", ListView2)
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
    Public index As Integer = 0

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        If lblFoodItemID.Text = "" Or lblFoodItemID.Text = vbNullString Then
            txtBarcode.Focus()
            lblStatus.Text = "You need to save or select food menu first"
            Exit Sub
        Else
            Dim unittype As String = getStrData("select unittype from items where itemid like @0", "unittype", {ListView1.SelectedItems(0).Text})
            Dim selectQty As New frmFoodQtySelection(unittype, lblFoodItemID.Text)
            selectQty.lblItemID.Text = ListView1.SelectedItems(0).Text
            selectQty.lblDescription.Text = ListView1.FocusedItem.SubItems(1).Text.ToString
            'selectQty.lblunit.Text = unittype

            selectQty.ShowDialog()
        End If

    End Sub

    Private Sub ListView3_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView3.MouseDoubleClick

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub
End Class