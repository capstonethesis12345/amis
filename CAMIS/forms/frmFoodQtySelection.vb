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
        'CHECK IF FOODITEMID AND INGREDIENT ID EXISTED IN FOODINGREDIENT TABLE
        Dim getExistence As Integer = getIDFunction("select count(ingredientid) from foodingredient where foodid like @0 and itemid like @1", "hasIngredient", {lblfootitemid.Text, lblItemID.Text})
        '    MessageBox.Show("existed " & getExistence.ToString)
        If getExistence = 0 Then
            itemNew("foodingredient", {"foodid", "itemid", "quantity"}, {lblfootitemid, lblItemID, txtQuantity})
        Else
            Dim getIngredientID As Integer = getIDFunction("select ingredientid from foodingredient where foodid like @0 and itemid like @1", "ingredientid", {lblfootitemid.Text, lblItemID.Text})
            itemUpdate("foodingredient", {"quantity"}, {txtQuantity}, "ingredientid", getIngredientID)
        End If
    End Sub
End Class