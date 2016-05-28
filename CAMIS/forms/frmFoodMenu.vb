Imports MySql.Data

Public Class frmFoodMenu
    Public Sub New()
        InitializeComponent()
        Try
            objForm = Me
            SqlRefresh = "select f.productid,f.description,c.categoryname,f.unitprice,f.availability from foodlist f,category c where c.categoryid=f.categoryid"
            SqlReFill("foodlist", ListView1)
            SqlRefresh = "select categoryname from category"
            SqlReFill("category", txtFoodCategory, "ShowValueInComboBox")
        Catch ex As Exception
            MessageBox.Show("Error in establishing connection in category form" & ex.Message.ToString, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SqlRefresh = "select f.productid,c.categoryname,f.description,f.unitprice,f.availability from foodlist f,category c where c.categoryid=f.categoryid"
        If txtProductID.Text = vbNullString Then
            StatusSet = "New"
        Else
            StatusSet = "Update"
            strReferenceColumn = "productid"
            strReferenceID = txtProductID.Text
        End If
        SqlUpdateNew("foodlist", ListView1, {"categoryid", "description", "unitprice", "Availability"}, {lblCategoryID, txtMenuName, txtPrice, cbAvailable})
    End Sub
    Private Sub txtFoodCategory_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtFoodCategory.SelectedValueChanged
        SqlRefresh = "select categoryid from category where categoryname=@categoryname"
        SqlReFill("cateogry", Nothing, "ShowValueInTextbox", {"categoryname"}, {txtFoodCategory}, {lblCategoryID})
    End Sub

End Class