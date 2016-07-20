Public Class frmSalesTransaction
    Sub New()
        InitializeComponent()
        getData()
        SqlRefresh = "select description,itemid from items where salestatus=1"
        Dim lv As New ListView
        SqlReFill("saledata", lv)
        For i = 0 To ds.Tables("saledata").Rows.Count - 1
            Dim btn As New Button
            btn.Width = 109
            btn.Height = 73
            btn.Name = ds.Tables("saledata").Rows(i).Item(1).ToString
            btn.Text = ds.Tables("saledata").Rows(i).Item(0).ToString
            itemcount += 1
            FlowLayoutPanel1.Controls.Add(btn)
            Dim arrData(5) As String
            arrData()
            AddHandler btn.Click, AddressOf Me.Button_Click
        Next
    End Sub
    Sub Button_Click(sender As Object, e As EventArgs)

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