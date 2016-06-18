
Public Class frmSupplier
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        SqlRefresh = "select  supplierid,company, address, contact from supplier"
        SqlReFill("supplier", ListView1)
        ' Add any initialization after the InitializeComponent() call.

    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtContact.TextChanged, txtSupplier.TextChanged

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        itemNew("Supplier", {"Company", "Address", "Contact"}, {txtSupplier, txtAddress, txtContact})
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Dispose()
    End Sub
End Class