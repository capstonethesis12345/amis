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
        SqlRefresh = "select itemid, description from items where itemtype=2"
        SqlReFill("Ingredient", ListView1)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SqlRefresh = siRefresh
        Dim t As New TextBox
        t.Text = 2
        itemNew("items", {"Barcode", "Description", "Price", "ItemType"}, {txtBarcode, txtMenuName, txtPrice, t})
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'get data list view2
        ' For Each r In ListView2.Items
        Dim idSelected As String = ListView1.SelectedItems(0).Text.ToString
        ListView2.Items.Add(idSelected.ToString)
        ListView1.SelectedItems(0).Remove()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each item As ListViewItem In ListView2.SelectedItems
            item.Remove()
        Next
        If ListView2.Items.Count > 0 Then

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