Public Class frmFood
    Dim siRefresh As String = "select barcode,description,price from items where itemtype like 2"
    Sub New()

        ' This call is required by the designer.
        getData()
        InitializeComponent()
        filldata()
    End Sub

    Sub filldata()
        SqlRefresh = siRefresh
        SqlReFill("foodingredient", ListView3)
        ' Add any initialization after the InitializeComponent() call.
        SqlRefresh = "select itemid, description from items where itemtype=0"
        SqlReFill("Ingredient", ListView1)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtMenuName.Text = vbNullString Then
            MessageBox.Show("Provide product name")
            Exit Sub
        End If
        SqlRefresh = siRefresh
            Dim t As New TextBox
            t.Text = 2
            SqlRefresh = siRefresh

        itemNew("items", {"Barcode", "Description", "Price", "ItemType"}, {txtBarcode, txtMenuName, txtPrice, t})
        SqlRefresh = "select barcode,description,price from items where itemtype=1"
        SqlReFill("items", ListView3)
        Dim fid As New TextBox
        fid.Text = getStrData("select ItemID from items where description like @0", "txtMenuName", {txtMenuName.Text})

        If ListView2.Items.Count > 0 Then
            For i As Integer = 0 To ListView2.Items.Count - 1

                Dim ing As New TextBox
                ing.Text = ListView2.Items(i).SubItems(1).Text
                Dim txt As New TextBox
                txt.Text = ListView2.Items(i).SubItems(2).Text


                itemNew("foodingredient", {"foodid", "itemd", "quantity"}, {fid, ing, txt})
            Next
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'get data list view2
        ' For Each r In ListView2.Items
        Dim quantity As Integer = InputBox("Enter Quantity")
        Dim idSelected As String = ListView1.SelectedItems(0).Text.ToString
        Dim description As String = ListView1.SelectedItems(0).SubItems(1).Text.ToString

        Dim lv As New ListViewItem(idSelected.ToString)
        lv.SubItems.Add(description)
        lv.SubItems.Add(quantity)
        ListView2.Items.Add(lv)


        ListView1.SelectedItems(0).Remove()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
    End Sub

    Private Sub ListView3_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView3.MouseDoubleClick
        SqlRefresh = siRefresh
        Dim itemid, idsc As New TextBox
        itemid.Text = ListView3.SelectedItems(0).ToString
        idsc.Text = ListView3.SelectedItems(0).ToString

        SqlReFill("FoodMenu", Nothing, "ShowValueInTextbox", {"Barcode", "Description", "Price"}, {itemid, idsc}, {txtBarcode, txtMenuName, txtPrice})
    End Sub


End Class