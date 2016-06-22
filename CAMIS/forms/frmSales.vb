
Class frmSales
    Dim lef, top As Integer
    Dim sizeW As Integer
    Dim sizeH As Integer
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        sizeW = Me.Width
        sizeH = Me.Height
        ' Add any initialization after the InitializeComponent() call.
        SqlRefresh = "Select description from items where itemtype != 0"
        itemAutoComplete("items", txtProductName)
    End Sub
    Private Sub frmPOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim orderNUM As String = getIDFunction("select ifnull(max(orderid),1) from `order`", "orderid", Nothing, True)
        txtOrderNum.Text = orderNUM
        Panel2.Left = (sizeW / 2) - (Panel2.Width / 2)
        Panel2.Top = (sizeH / 2) - (Panel2.Height / 2)
        'txtTransNo.Text = objDal.GetSingleField("Select max(transid)+1 from transactions")
    End Sub

    Private Sub txtProduct_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub txtProductName_Leave(sender As Object, e As EventArgs) Handles txtProductName.Leave
        Dim barcode As String = getValue("select ifnull(barcode,0),price from items where description like @0", "saleItems", {txtProductName.Text}, False)
        MessageBox.Show(barcode)
        If barcode = "0" Then
            MessageBox.Show("Item not found")
        Else
            txtBarcode.Text = barcode
            txtPrice.Text = ds.Tables("saleItems").Rows(0).Item("price").ToString
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click
        Try
            ConnDB()
            sqL = "insert into orderline(orderid,itemid,quantity) values(@0,@1,@2)"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(sqL, conn)
            cmd.CommandType = CommandType.Text
            With cmd
                .Parameters.AddWithValue("@0", txtOrderNum.Text)
                .Parameters.AddWithValue("@1", txtBarcode.Text)
                .Parameters.AddWithValue("@2", txtQuantity.Text)
            End With
        Catch ex As Exception
            MessageBox.Show("Error in inserting an order")

        Finally
            DisconnDB()
        End Try
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class