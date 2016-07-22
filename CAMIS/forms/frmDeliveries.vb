Public Class frmDeliveries
    Private Sub frmDeliveries_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SqlFill("select poid from polist where poid like @0", ListView1, {txtPOID.Text})
    End Sub
End Class