Imports MySql.Data

Public Class frmCategory
    Private textboxes As Object() = {txtCategoryName, txtDescription}
    Public Sub New()
        InitializeComponent()
        Try
            objForm = Me
            SqlRefresh = "SELECT categoryid, categoryname, categorydescription FROM category"
            SqlReFill("Category", ListView1, Nothing)
        Catch ex As Exception
            MessageBox.Show("Error in establishing connection in category form" & ex.Message.ToString, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SqlRefresh = "select categoryid,categoryname,categorydescription from category"
        If txtCategoryId.Text = vbNullString Then
            StatusSet = "New"

        Else
            StatusSet = "Update"
            strReferenceColumn = "categoryid"
            'strReferenceID = txtCategoryId.Text
        End If
        SqlUpdateNew("Category", ListView1, {"Categoryname", "categorydescription"}, {txtCategoryName, txtDescription})
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearField(textboxes)
    End Sub
    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        textboxes = {txtCategoryId, txtCategoryName, txtDescription}
        clearField(textboxes)
        Try
            txtCategoryId.Text = ListView1.SelectedItems(0).Text.ToString
            StatusSet = ""
            SqlRefresh = "SELECT categoryid, categoryname, categorydescription FROM category where categoryid=@categoryid"
            SqlReFill("category", Nothing, "ShowValueInTextbox", {"categoryid"}, {txtCategoryId}, textboxes)
            If Not txtCategoryId.Text = vbNullString Then
                lblStatus.Text = "Updating existed employee"
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class