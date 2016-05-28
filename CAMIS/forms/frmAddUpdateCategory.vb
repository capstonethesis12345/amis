
Imports MySql.Data.MySqlClient
Public Class frmAddUpdateCategory
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub frmAddUpdateCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objFormUpdateNew = Me
        cmd.Parameters.Clear()
        ds.Clear()
        Select Case StatusSet
            Case Is = "New"
                lblTitle.Text = "Add new data."
            Case Is = "Update"
                lblTitle.Text = "Update existing data."
                Dim r As String = SqlRefresh
                SqlRefresh = "select categoryname,categorydescription from category where categoryid=@categoryid"
                SqlReFill("category", Nothing, "ShowValueInTextbox", {"categoryid"}, {txtCategoryNo}, {txtCatName, txtDescription})
                SqlRefresh = r
        End Select
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        strReferenceID = Me.txtCategoryNo.Text
        strReferenceColumn = "CategoryID"
        SqlUpdateNew("Category", frmCategory.ListView1, {"categoryname", "categorydescription"}, {txtCatName.Text, txtDescription.Text})
        Me.Close()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class