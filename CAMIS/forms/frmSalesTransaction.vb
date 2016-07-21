Public Class frmSalesTransaction
    Sub New()
        InitializeComponent()
        getData()
        SqlRefresh = "select description,itemid,price from items where salestatus=1"
        Dim lv As New ListView
        SqlReFill("saledata", lv)
        For i = 0 To ds.Tables("saledata").Rows.Count - 1
            Dim btn As New Button()
            btn.Width = 140
            btn.Height = 90
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
        Dim description As String = ds.Tables("saledata").Rows(indexMenu).Item(0).ToString
        Dim inList As Boolean = False
        For i = 0 To ListView1.Items.Count - 1
            If description = ListView1.Items(i).Text Then
                ListView1.Items(i).SubItems(1).Text += 1
                inList = True
                compute()
                Exit Sub
            End If
        Next
        If inList = False Then
            Dim lv As New ListViewItem(description)
            lv.SubItems.Add(1)
            lv.SubItems.Add(ds.Tables("saledata").Rows(indexMenu).Item(2).ToString)
            ListView1.Items.Add(lv)
            inList = False
            compute()
        End If
        'compute sum


    End Sub
    Sub compute()
        Dim total As Double = 0.0
        For i = 0 To ListView1.Items.Count - 1
            total += Double.Parse(ListView1.Items(i).SubItems(1).Text * ListView1.Items(i).SubItems(2).Text)
        Next
        lTotal.Text = total.ToString("C", Globalization.CultureInfo.GetCultureInfo("en-PH"))
    End Sub
    Dim itemcount As String = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ConnDB()
        SqlRefresh = "select description from items where salestatus=1"
        'Dim  As New ListView

        'SqlReFill("sales", ListView1)

        'FlowLayoutPanel1.Controls.Add(btn)
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub
End Class