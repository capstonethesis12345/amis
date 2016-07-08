Public Class frmFoodQtySelection
    Dim vunit As String
    Dim vfooditemid As String
    Sub New(ByVal unit As String, ByVal fooditemid As String)
        vunit = unit
        vfooditemid = fooditemid
        ' This call is required by the designer.
        InitializeComponent()
        Me.ControlBox = False
        ' Add any initialization after the InitializeComponent() call.
        lblType.Text = vunit
        cbtype.FlatStyle = FlatStyle.System
        cbtype.DropDownStyle = ComboBoxStyle.DropDownList
        lblfootitemid.Text = vfooditemid
    End Sub
    Private Sub frmFoodQtySelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case vunit
            Case Is = "MG", "G", "KG"
                Me.cbtype.Items.Add("KG")
                Me.cbtype.Items.Add("G")
                Me.cbtype.Items.Add("MG")
                Me.cbtype.Items.Add("TBSP")
                Me.cbtype.Items.Add("TSP")
            Case Is = "SLICE"
                Me.cbtype.Items.Add("SLICE")
        End Select
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Me.Dispose()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        Dim getExistence As Integer = getIDFunction("select count(ingredientid) from foodingredient where foodid like @0 and itemid like @1", "hasIngredient", {lblfootitemid.Text, lblItemID.Text})
        If getExistence = 0 Then
            itemNew("foodingredient", {"foodid", "itemid", "quantity", "unit"}, {lblfootitemid, lblItemID, txtQuantity, cbtype})
        Else
            Dim getIngredientID As Integer = getIDFunction("select ingredientid from foodingredient where foodid like @0 and itemid like @1", "ingredientid", {lblfootitemid.Text, lblItemID.Text})
            itemUpdate("foodingredient", {"quantity", "unit"}, {txtQuantity, cbtype}, "ingredientid", getIngredientID)
        End If
        frmFood.ListView2.Items.Clear()
        SqlRefresh = "select f.ingredientid,i.itemid,i.description,f.unit,f.quantity from items i left join foodingredient f on f.itemid=i.itemid where f.foodid like '" & frmFood.lblFoodItemID.Text & "'"
        SqlReFill("ingredients", frmFood.ListView2)
        'frmFood.ListView1.SelectedItems(0).Remove()
    End Sub
End Class