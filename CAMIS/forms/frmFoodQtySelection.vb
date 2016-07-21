Public Class frmFoodQtySelection
    Dim vunit As String
    Dim vfooditemid As String
    Dim vbuildid As String
    Dim indexSelected As Integer
    Sub New(ByVal unit As String, ByVal fooditemid As String, ByVal itemDescription As String, ByVal ingredientID As String, ByVal buildid As String, ByVal indexItem As Integer)
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
        lblDescription.Text = itemDescription
        lblItemID.Text = ingredientID
        indexSelected = indexItem
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
            Case Is = "PCS"
                Me.cbtype.Items.Add("PCS")
        End Select

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Me.Dispose()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        ''do buildid already availab;e?
        'Dim newBuildid As String = getStrData("SELECT if(count(buildid)=0,MAX(buildid),buildid+1) FROM  `foodingredient` WHERE foodid =@0 ORDER BY ingredientid DESC LIMIT 0,1", "getNewBuild", {lblfootitemid.Text})

        'Dim getExistence As Integer = getIDFunction("select count(ingredientid) from foodingredient where foodid like @0 and itemid like @1", "hasIngredient", {lblfootitemid.Text, lblItemID.Text})
        'If getExistence = 0 Then
        '    Dim tbuildid As New TextBox
        '    tbuildid.Text = newBuildid
        '    itemNew("foodingredient", {"foodid", "itemid", "quantity", "unit", "buildid"}, {lblfootitemid, lblItemID, txtQuantity, cbtype, tbuildid})
        'Else
        '    Dim getIngredientID As Integer = getIDFunction("select ingredientid from foodingredient where foodid like @0 and itemid like @1", "ingredientid", {lblfootitemid.Text, lblItemID.Text})
        '    itemUpdate("foodingredient", {"quantity", "unit"}, {txtQuantity, cbtype}, "ingredientid", getIngredientID)
        'End If
        'frmFood.ListView2.Items.Clear()
        'SqlRefresh = "select f.ingredientid,i.itemid,i.description,f.unit,f.quantity from items i left join foodingredient f on f.itemid=i.itemid where f.foodid like '" & frmFood.lblFoodItemID.Text & "'"
        'SqlReFill("ingredients", frmFood.ListView2)
        'frmFood.ListView1.SelectedItems(0).Remove()
        Dim lv As New ListViewItem("")
        lv.SubItems.Add(lblItemID.Text)
        lv.SubItems.Add(lblDescription.Text)
        lv.SubItems.Add(cbtype.Text)
        lv.SubItems.Add(txtQuantity.Text)
        frmFood.ListView2.Items.Add(lv)
        frmFood.ListView1.Items.RemoveAt(indexSelected)
        Me.Close()

    End Sub
End Class