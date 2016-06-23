Imports MySql.Data

Public Class frmFoodMenu
    Public Sub New()
        InitializeComponent()
        Try
            objForm = Me
            SqlRefresh = "select ifnull(`ItemID`,'')ItemID, ifnull(`Barcode`,'')Barcode,ifnull(`Description`,'')description,ifnull(`Price`,'')Price from `Items` where `itemtype` like 1"
            SqlReFill("Items", ListView1)
        Catch ex As Exception
            MessageBox.Show("Error in establishing connection in category form" & ex.Message.ToString, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs)
    End Sub


End Class