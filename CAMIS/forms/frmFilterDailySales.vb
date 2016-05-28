Public Class frmFilterDailySales

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        frmReportDailySales.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmFilterDailySales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class