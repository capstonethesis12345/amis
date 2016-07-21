Public Class frmSalesTransaction
    Sub New()
        InitializeComponent()
        getData()
        SqlRefresh = "select description,itemid,price from items where salestatus=1"
        Dim lv As New ListView
        SqlReFill("saledata", lv)
        For i = 0 To ds.Tables("saledata").Rows.Count - 1
            Dim btn As New Button()
            btn.Width = 109
            btn.Height = 73
            btn.Name = itemcount
            btn.Text = ds.Tables("saledata").Rows(i).Item(0).ToString
            itemcount += 1
            FlowLayoutPanel1.Controls.Add(btn)
            AddHandler btn.Click, AddressOf Me.orders_click
        Next
    End Sub
    Sub orders_click(sender As Object, e As EventArgs)
        Dim button As Button = sender
        Dim indexMenu As Integer = 0
        indexMenu = button.Name
        Dim foodMenu As String = button.Text
        '        MessageBox.Show(ds.Tables("saledata").Rows(indexMenu).Item(2).ToString)
        Dim lv As New ListViewItem(ds.Tables("saledata").Rows(indexMenu).Item(0).ToString)
        lv.SubItems.Add(1)
        lv.SubItems.Add(ds.Tables("saledata").Rows(indexMenu).Item(2).ToString)
        ListView1.Items.Add(lv)
    End Sub
    Dim itemcount As String = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ConnDB()
        SqlRefresh = "select description from items where salestatus=1"
        'Dim  As New ListView

        'SqlReFill("sales", ListView1)

        'FlowLayoutPanel1.Controls.Add(btn)
    End Sub

End Class