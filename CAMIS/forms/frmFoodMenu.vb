Imports MySql.Data

Public Class frmFoodMenu
    Public Sub New()
        InitializeComponent()
        itemID.Text = ""
        Try
            objForm = Me
            SqlRefresh = "select itemid, ifnull(`Barcode`,'')Barcode,ifnull(`Description`,'')description,price from `items` where `itemtype` like 2"
            SqlReFill("itemsDetails", ListView1)
        Catch ex As Exception
            MessageBox.Show("Error in establishing connection in category form" & ex.Message.ToString, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtBcode.Text = vbNullString And txtName.Text = vbNullString Then
            MessageBox.Show("Food menu and barcode required.")
            Exit Sub
        End If
        SqlRefresh = "select ifnull(`itemid`,'')itemid, ifnull(`barcode`,'')barcode,ifnull(`description`,'')description,ifnull(`price`,'')price from `items` where `itemtype` like 2"
        Dim status, itemtype As New TextBox
        itemtype.Text = "2"
        If available.Checked = True Then
            status.Text = "1"
        Else

            status.Text = "0"
        End If
        'check if barcode and description already exists
        If getStrData("select count(barcode) from items where barcode like @0 or description like @1", "checkFoodExistence", {txtBcode.Text, txtName.Text}) > 0 Then
            Dim id As String = getStrData("select barcode,description from items where barcode like @0 or description like @1", "checkFoodExistence", {txtBcode.Text, txtName.Text})
            txtBcode.Text = ds.Tables("checkFoodExistence").Rows(0).Item("barcode").ToString
            txtName.Text = ds.Tables("checkFoodExistence").Rows(0).Item("description").ToString
        Else
            itemNew("items", {"barcode", "description", "price", "salestatus", "itemtype"}, {txtBcode, txtName, txtPrice, status, itemtype}, ListView1)

        End If





    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        Dim menuid As String = ListView1.SelectedItems(0).Text.ToString
        itemID.Text = menuid
        'SqlRefresh = "select barcode,description,price from `items` where itemid like @itemid"
        'SqlReFill("FoodMenu", Nothing, "ShowValueInTextbox", {"itemid"}, {itemID}, {txtBcode, txtName, txtPrice})
        getDSData("select barcode,description,price,salestatus from items where itemid like @0", "foodmenu", {ListView1.SelectedItems(0).Text.ToString})
        txtBcode.Text = ds.Tables("foodmenu").Rows(0).Item(0).ToString
        txtName.Text = ds.Tables("foodmenu").Rows(0).Item(1).ToString
        txtPrice.Text = ds.Tables("foodmenu").Rows(0).Item(2).ToString
        Select Case ds.Tables("foodmenu").Rows(0).Item(3).ToString
            Case Is = "0"
                available.Checked = False
                avalablenot.Checked = True
            Case Is = "1"
                available.Checked = True
                Exit Select
        End Select
    End Sub
End Class