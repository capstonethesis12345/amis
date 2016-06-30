Imports MySql.Data

Public Class frmFoodMenu
    Public Sub New()
        InitializeComponent()
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
        If r1.Checked = True Then
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
        Dim mid As String = ListView1.SelectedItems(0).Text.ToString
        SqlRefresh = "select itemid,barcode,description,price from `items` where itemtype=0"
        SqlReFill("FMenu", Nothing, "ShowValueInTextbox", {"itemid"}, {itemID}, {itemID, txtBcode, txtName, txtPrice})
    End Sub
End Class