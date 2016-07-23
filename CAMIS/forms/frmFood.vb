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
        lblFoodBuildID.Text = ""
    End Sub

    Sub filldata()
        SqlRefresh = sqlFoodName
        SqlReFill("sqlFoodName", ListView3)
        ' Add any initialization after the InitializeComponent() call.
        SqlRefresh = sqlFoodIngredient
        SqlReFill("Ingredient", ListView1)
    End Sub

    Private Sub dataClear() Handles btnClear.Click
        If lblFoodBuildID.Text = vbNullString Then
            If MessageBox.Show("Build ingredient was not yet save, Are you sure?", "Notice", MessageBoxButtons.YesNo) = DialogResult.OK Then
                txtBarcode.Text = ""
                txtMenuName.Text = ""
                txtPrice.Text = ""
                lblFoodItemID.Text = ""
                ListView2.Items.Clear()
                lblFoodBuildID.Text = ""
            End If
        End If

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
        Dim maxBuildid As New TextBox

        If Not getIDFunction("select count(buildid) from foodingredient", "isBuildEmpty") = "0" Then
            maxBuildid.Text = getIDFunction("SELECT IFNULL( MAX( buildid ) +1, 1 ) FROM foodingredient", "maxBuild")
        Else
            maxBuildid.Text = "1"
        End If
        For i = 0 To cIngredient - 1
            Dim fid As New TextBox
            msgShow = False
            Dim ing As New TextBox
            ing.Text = ListView2.Items(i).SubItems(1).Text
            Dim qty As New TextBox
            qty.Text = ListView2.Items(i).SubItems(4).Text
            Dim tunit As New TextBox
            tunit.Text = ListView2.Items(i).SubItems(3).Text
            fid.Text = getStrData("SELECT itemid FROM items where description like @0", "foodIngredientList", {txtMenuName.Text})

            itemNew("foodingredient", {"foodid", "itemid", "unit", "quantity", "buildid"}, {fid, ing, tunit, qty, maxBuildid})
            MessageBox.Show("Saved.")
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'get data list view2
        ' For Each r In ListView2.Items
        Try
            Dim idSelected As String = ListView1.SelectedItems(0).Text.ToString
            Dim description As String = ListView1.SelectedItems(0).SubItems(1).Text.ToString
            Dim quantity As Double = 0.0
            Try
                Dim unit As String = getStrData("select unittype from items where itemid like @0", "unittype", {idSelected})
                Dim addIngredient As New frmFoodQtySelection(unit, lblFoodItemID.Text, description, idSelected, lblFoodBuildID.Text, ListView1.SelectedIndices(0))
                addIngredient.ShowDialog()
                'quantity = InputBox("Enter Quantity")
            Catch ex As Exception
                MessageBox.Show("Please input quantity")
                Exit Sub
            End Try
        Catch ex As Exception

        End Try









        ' ListView1.SelectedItems(0).Remove()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim idSelected As String = ListView2.SelectedItems(0).SubItems(1).Text.ToString
            Dim description As String = ListView2.SelectedItems(0).SubItems(2).Text.ToString

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

        Dim buildid As String = ""
        buildid = getStrData("SELECT if(count(buildid)=0,'',max(buildid))buildid FROM `foodingredient` where foodid=@0 order by ingredientid desc limit 0,1", "buildid", {lblFoodItemID.Text})
        If buildid = "0" Then
            buildid = ""
        End If
        lblFoodBuildID.Text = buildid

        SqlRefresh = "select f.ingredientid,i.itemid,i.description,f.unit,f.quantity from items i left join foodingredient f on f.itemid=i.itemid where f.foodid like '" & lblFoodItemID.Text & "' and buildid like '" & lblFoodBuildID.Text & "'"
        SqlReFill("ingredients", ListView2)

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
    Public index As Integer = 0

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        'MessageBox.Show(ListView1.SelectedIndices(0).ToString)
        If lblFoodItemID.Text = "" Or lblFoodItemID.Text = vbNullString Then
            txtBarcode.Focus()
            lblStatus.Text = "You need to save or select food menu first"
            Exit Sub

        Else
            Dim ingredientid As String = ListView1.SelectedItems(0).Text.ToString
            Dim itemdescription As String = ListView1.FocusedItem.SubItems(1).Text.ToString
            Dim unittype As String = getStrData("select unittype from items where itemid like @0", "unittype", {ListView1.SelectedItems(0).Text})
            Dim selectQty As New frmFoodQtySelection(unittype, lblFoodItemID.Text, itemdescription, ingredientid, lblFoodBuildID.Text, ListView1.SelectedIndices(0))
            ' selectQty.lblItemID.Text = 
            ' selectQty.lblDescription.Text = ListView1.FocusedItem.SubItems(1).Text.ToString
            'selectQty.lblunit.Text = unittype

            selectQty.ShowDialog()
        End If

    End Sub

    Private Sub ListView2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView2.MouseDoubleClick
        Dim unit As String = ListView2.SelectedItems(0).SubItems(3).Text.ToString
        MessageBox.Show(unit)
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        txtPrice = metrocasenumbers(txtPrice)
    End Sub
End Class