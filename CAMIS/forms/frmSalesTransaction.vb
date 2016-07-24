Public Class frmSalesTransaction
    Dim lv As New ListView
    Sub New()
        InitializeComponent()
        getData()
        'lOrderNum.Text = getIDFunction("call getorderid()", "orderid")
        SqlRefresh = "call getitems();"
        SqlReFill("fill", lv)
        itemcount = 0
        generateButton()
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.HorizontalScroll.Enabled = False
        FlowLayoutPanel1.HorizontalScroll.Visible = False
        FlowLayoutPanel1.WrapContents = True
        lEmpNum.Text = vEmp
    End Sub
    Public Sub generateButton()
        For i = 0 To ds.Tables("fill").Rows.Count - 1
            Dim btn As New Button()
            btn.Width = 140
            btn.Height = 90
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.ForeColor = Color.Transparent
            btn.Name = itemcount
            btn.Font = New System.Drawing.Font("Verdana", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Dim price As Double = Double.Parse(ds.Tables("fill").Rows(i).Item(2).ToString)
            Dim oprice As New Label
            oprice.Text = price.ToString("C", Globalization.CultureInfo.GetCultureInfo("en-PH"))
            btn.Text = ds.Tables("fill").Rows(i).Item(0).ToString & vbNewLine & oprice.Text
            'total.ToString("C", Globalization.CultureInfo.GetCultureInfo("en-PH"))
            itemcount += 1
            FlowLayoutPanel1.Controls.Add(btn)
            AddHandler btn.Click, AddressOf Me.orders_click
        Next
    End Sub
    Dim description As String = ""
    Dim buildid As String = ""
    Dim itemid As String = ""

    Sub orders_click(sender As Object, e As EventArgs)
        Dim button As Button = sender
        Dim indexMenu As Integer = 0
        indexMenu = button.Name
        Dim foodMenu As String = button.Text
        '        MessageBox.Show(ds.Tables("saledata").Rows(indexMenu).Item(2).ToString)
        Try
            'description = ds.Tables("fill").Rows(indexMenu).Item(0).ToString
            description = ds.Tables("fill").Rows(indexMenu).Item(0).ToString
            buildid = ds.Tables("fill").Rows(indexMenu).Item(3).ToString
            itemid = ds.Tables("fill").Rows(indexMenu).Item(1).ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try


        Dim inList As Boolean = False
        For i = 0 To ListView1.Items.Count - 1
            If description = ListView1.Items(i).Text Then
                ListView1.Items(i).SubItems(1).Text += 1
                ListView1.Items(i).SubItems(3).Text = buildid
                ListView1.Items(i).SubItems(3).Text = itemid
                inList = True
                compute()
                Exit Sub
            End If
        Next
        If inList = False Then
            Dim lv As New ListViewItem(description)
            lv.SubItems.Add(1)
            lv.SubItems.Add(ds.Tables("fill").Rows(indexMenu).Item(2).ToString)
            lv.SubItems.Add(buildid)
            lv.SubItems.Add(itemid)
            ListView1.Items.Add(lv)
            inList = False
            compute()
        End If
        'compute sum


    End Sub
    Dim total As Double = 0.0
    Sub compute()
        total = 0.0
        For i = 0 To ListView1.Items.Count - 1
            total += ListView1.Items(i).SubItems(1).Text * ListView1.Items(i).SubItems(2).Text
        Next
        lTotal.Text = total.ToString("C", Globalization.CultureInfo.GetCultureInfo("en-PH"))
    End Sub
    Dim itemcount As String = 0


    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Label5_MouseClick(sender As Object, e As MouseEventArgs) Handles lTableNum.MouseClick
        tTableNum.Visible = True
        lTableNum.Visible = False
        tTableNum.Focus()
    End Sub

    Private Sub tTableNum_KeyUp(sender As Object, e As KeyEventArgs) Handles tTableNum.KeyUp
        If e.KeyCode = Keys.Enter Then
            lTableNum.Text = tTableNum.Text
            tTableNum.Visible = False
            lTableNum.Visible = True
        End If
        If tTableNum.Text = vbNullString Then
            lTableNum.Text = 0
        End If
    End Sub

    Private Sub tTableNum_Leave(sender As Object, e As EventArgs) Handles tTableNum.Leave
        lTableNum.Text = tTableNum.Text
        tTableNum.Visible = False
        lTableNum.Visible = True
        If tTableNum.Text = vbNullString Then
            lTableNum.Text = 0
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtSearch.Text = ""
        Timer1.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDeliveies.Click
        ' openFull(frmViewDeliveries)
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub DeliveriesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'openFull(frmViewDeliveries)
    End Sub

    Public Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ds.Clear()
        FlowLayoutPanel1.Controls.Clear()
        SqlRefresh = "call getsearchitem(@0)"
        Dim lv As New ListView
        Dim temp As New TextBox
        temp.Text = txtSearch.Text & "%"
        msgShow = True
        SqlFill(SqlRefresh, lv, {temp.Text})
        itemcount = 0
        generateButton()
        If itemcount = 0 Then
            Timer1.Enabled = True
        End If

    End Sub
    Dim tableNum As String
    Private Sub btnTransact_Click_1(sender As Object, e As EventArgs)


    End Sub
    Sub processData()
        Try
            ' Dim cash As Double = Double.Parse(Of Double)
            If total < txtCash.Text Then
                Dim tendered As New frmSalesTransactionTendered()
                tendered.BackColor = Color.Red

                callforms(tendered, Panel1)

                FlowLayoutPanel1.Visible = False


                'FlowLayoutPanel1.Visible = False
                'Dim regDate As DateTime = DateTime.Now
                'Dim strDate As String = regDate.ToString("yyyy-MM-dd HH:mm:ss")
                'Dim orderid, empid, tdatetime, payment As New TextBox
                'orderid.Text = getIDFunction("call getorderid()", "getorderid")
                'empid.Text = vEmp
                'tdatetime.Text = strDate
                'payment.Text = total
                'msgShow = False
                'itemNew("orders", {"orderid", "empid", "tablenum", "orderdate", "paymentamt"}, {orderid, empid, lTableNum, tdatetime, payment})
                'For i = 0 To ListView1.Items.Count - 1
                '    Dim itemid, buildid, quantity, price As New TextBox
                '    itemid.Text = ListView1.Items(i).SubItems(4).Text
                '    buildid.Text = ListView1.Items(i).SubItems(3).Text
                '    quantity.Text = ListView1.Items(i).SubItems(1).Text
                '    price.Text = ListView1.Items(i).SubItems(2).Text
                '    itemNew("orderline", {"orderid", "itemid", "buildid", "quantity", "price"},
                '           {orderid, itemid, buildid, quantity, price})
                '    If i = ListView1.Items.Count - 1 Then
                '        If sqlMessage = "Success" Then
                '            ListView1.Items.Clear()
                '            Dim cmplete As New TextBox
                '            cmplete.Text = 1
                '            If i <> ListView1.Items.Count - 1 Then
                '                msgShow = False
                '            Else
                '                msgShow = True
                '            End If
                '            itemUpdate("orders", {"orderstatus"}, {cmplete}, "orderid", orderid.Text)
                '        End If
                '    End If
                '    If sqlMessage = "Success" Then
                '        Dim tendered As New frmSalesTransactionTendered()
                '        Panel1.Visible = False
                '        callforms(tendered, Panel7)
                '        ' SqlRefresh = "call getitems();"
                '        ' SqlReFill("fill", lv)
                '        ' itemcount = 0
                '        ' generateButton()
                '        ' ListView1.Controls.Clear()
                '        ' FlowLayoutPanel1.Controls.Clear()
                '    End If
                '    sqlMessage = ""
                'Next
            Else
                MessageBox.Show("Cash is below the actual price")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.Dispose()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub txtCash_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCash.KeyUp
        If e.KeyCode = Keys.Enter Then
            If lTableNum.Text = vbNullString Or lTableNum.Text = "0" Then

                lTableNum.Text = InputBox("Table number:")
                If lTableNum.Text = vbNullString Or lTableNum.Text = "0" Then
                    btnTransact_Click_1(sender, e)
                Else
                    processData()
                End If
            Else
                processData()
            End If

        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ListView1.Items.Clear()
    End Sub

    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        txtCash = metrocasenumbers(txtCash)
    End Sub

    Private Sub txtCash_Click(sender As Object, e As EventArgs) Handles txtCash.Click

    End Sub
End Class