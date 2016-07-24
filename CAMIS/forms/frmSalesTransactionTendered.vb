Public Class frmSalesTransactionTendered
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        'Panel3.Left = ((Me.Width / 2) - (Panel3.Width / 2))
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) 
        frmSalesTransaction.TenderedPanel.Visible = False
        Me.Close()
    End Sub

    Private Sub frmSalesTransactionTendered_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmSalesTransaction.TenderedPanel.Visible = False
    End Sub
End Class