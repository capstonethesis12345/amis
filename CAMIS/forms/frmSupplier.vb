
Public Class frmSupplier
    Dim vrefresh As String = "select  supplierid,company, address, contact from supplier"
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        SqlRefresh = vrefresh
        SqlReFill("supplier", ListView1)
        ' Add any initialization after the InitializeComponent() call.

    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtContact.TextChanged, txtSupplier.TextChanged

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' itemNew("Supplier", {"Company", "Address", "Contact"}, {txtSupplier, txtAddress, txtContact})
        Try
            ConnDB()
            cmd = New MySql.Data.MySqlClient.MySqlCommand()
            cmd.Connection = conn
            cmd.CommandText = "insert into supplier values(@0,@1,@2,@3) on duplicate key update company=@1,address=@2,contact=@3"
            cmd.Parameters.AddWithValue("@0", txtSupplierID.Text)
            cmd.Parameters.AddWithValue("@1", txtSupplier.Text)
            cmd.Parameters.AddWithValue("@2", txtAddress.Text)
            cmd.Parameters.AddWithValue("@3", txtContact.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Success")
        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message.ToString)
        Finally
            DisconnDB()
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Dispose()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.MouseDoubleClick
        SqlRefresh = "select supplierid,company,address,contact from supplier where supplierid=@0"
        SqlReFill("supplier", Nothing, "ShowValueInTextbox", {"0"}, {ListView1.SelectedItems(0)}, {txtSupplierID, txtSupplier, txtAddress, txtContact})
    End Sub
End Class