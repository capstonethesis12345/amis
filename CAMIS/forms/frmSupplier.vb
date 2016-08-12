
Public Class frmSupplier
    Dim vrefresh As String = "select  supplierid,company, address, contact from supplier"
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        SqlRefresh = vrefresh
        SqlReFill("supplier", ListView1)
        ' Add any initialization after the InitializeComponent() call.
        lStatus.Text = ""
        lStatus.Visible = False
    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtContact.TextChanged, txtSupplier.TextChanged

    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Dispose()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.MouseDoubleClick
        SqlRefresh = "select supplierid,company,address,contact from supplier where supplierid=@0"
        SqlReFill("supplier", Nothing, "ShowValueInTextbox", {"0"}, {ListView1.SelectedItems(0)}, {txtSupplierID, txtSupplier, txtAddress, txtContact})
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click, btnSave.Click
        SqlRefresh = "select * from supplier"
        Dim suppliername As Integer = getIDFunction("select count(company) from supplier where company like @0", "supplier", {txtSupplier.Text})
        If suppliername = 0 Then
            itemNew("supplier", {"company", "address", "contact"}, {txtSupplier, txtAddress, txtContact}, ListView1)
        Else
            Timer1.Start()
            lStatus.Visible = True
            txtSupplier.Focus()
            lStatus.Text = "Supplier existed already."


        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lStatus.Visible = False
        Timer1.Stop()
    End Sub

    Private Sub txtSupplier_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSupplier.KeyUp
        Me.AcceptButton = btnSave
    End Sub
End Class