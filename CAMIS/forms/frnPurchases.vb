Imports MySql.Data

Public Class frmPurchases
    Public Sub New()
        InitializeComponent()
        Try
            objForm = Me
            SqlRefresh = "SELECT categoryid, categoryname, categorydescription FROM category"
            SqlReFill("Category", ListView1)
        Catch ex As Exception
            MessageBox.Show("Error in establishing connection " & ex.Message.ToString, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        StatusSet = "New"
        Dim sNew As New frmAddUpdateCategory()
        sNew.ShowDialog()
        sNew = Nothing
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If ListView1.SelectedItems.Count = 0 Then
            MessageBox.Show("Select item first", "Selection not identified", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Else
            StatusSet = "Update"
            Dim update As New frmAddUpdateCategory()
            update.txtCategoryNo.Text = ListView1.FocusedItem.Text
            update.ShowDialog()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class