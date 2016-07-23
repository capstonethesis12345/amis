
Public Class frmDatabase
    Private TstServerMySQL As String
    Private TstPortMySQL As String
    Private TstUserNameMySQL As String
    Private TstPwdMySQL As String
    Private TstDBNameMySQL As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Call getData()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cmdTest_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdTest.Click
        'Test database connection

        TstServerMySQL = txtServerHost.Text
        TstPortMySQL = txtPort.Text
        TstUserNameMySQL = txtUserName.Text
        TstPwdMySQL = txtPassword.Text
        TstDBNameMySQL = txtDatabase.Text
        Try
            conn.ConnectionString = "Server = '" & TstServerMySQL & "';  " _
                                         & "Port = '" & TstPortMySQL & "'; " _
                                         & "Database = '" & TstDBNameMySQL & "'; " _
                                         & "user id = '" & TstUserNameMySQL & "'; " _
                                         & "password = '" & TstPwdMySQL & "'"


            conn.Open()
            MsgBox("Test connection successful", MsgBoxStyle.Information, "Database Settings")

        Catch ex As Exception
            MsgBox("The system failed to establish a connection", MsgBoxStyle.Information, "Database Settings")

        End Try
        Call DisconnDB()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdSave.Click
        Try
            ServerMySQL = txtServerHost.Text
            PortMySQL = txtPort.Text
            UserNameMySQL = txtUserName.Text
            PwdMySQL = txtPassword.Text
            DBNameMySQL = txtDatabase.Text
            conn.ConnectionString = "server=" & txtServerHost.Text & ";port=" & txtPort.Text & ";uid=" & txtUserName.Text & ";password=" & txtPassword.Text
            conn.Open()
            Call SaveData()


            'Me.Close()
            Button1.Enabled = True
        Catch ex As Exception
            MsgBox("The system failed to establish a connection", MsgBoxStyle.Information, "Database Settings")
        End Try
        Call DisconnDB()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmDatabase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0
        'Me.Location = New Point(1433)
        txtServerHost.Text = ServerMySQL
        txtPort.Text = PortMySQL
        txtUserName.Text = UserNameMySQL
        txtPassword.Text = PwdMySQL
        txtDatabase.Text = DBNameMySQL
        'Call getData()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub cmdClose_Click_1(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        generateDB(DBNameMySQL, UserNameMySQL, PwdMySQL)
        txtUserName.Text = UserNameMySQL
        txtPassword.Text = PwdMySQL
        txtDatabase.Text = DBNameMySQL
        Call SaveData()
        'RESET LOGIN DATA TO SECONDARY USER FUNCTION.
        Try
            ConnDB()
            '  cmd.ExecuteNonQuery()
            Try
                cmd.CommandText = "CREATE DEFINER=`root`@`localhost` PROCEDURE `getItems`()" _
                       & "    NO SQL" _
                       & " SELECT description, itemid, price, ifnull(( SELECT buildid FROM foodingredient WHERE foodingredient.foodid = items.itemid ORDER BY buildid DESC  LIMIT 0 , 1 ),0)buildid FROM items WHERE salestatus =1 LIMIT 0 , 30"
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try
            Try
                cmd.CommandText = "CREATE DEFINER=`root`@`localhost` PROCEDURE `getOrderID`()" _
            & " NO SQL" _
            & " select if(orderstatus=1,max(orderid)+1,(select orderid from orders)) from orders order by orderid desc limit 0,1"
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try
            Try
                cmd.CommandText = "CREATE DEFINER=`root`@`localhost` PROCEDURE `getOrders`()" _
                            & " BEGIN select orderid,customerid,ifnull(tablenum,0)tablenum,orderdate,ifnull(discount,0)discount,ifnull(paymentAmt,0),empid,orderstatus from orders; END"
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try
            Try
                cmd.CommandText = "CREATE DEFINER=`root`@`localhost` PROCEDURE `getSearchItem`(IN `itemname` VARCHAR(200))" _
                & " NO SQL " _
            & " SELECT description, itemid, price, ifnull(( SELECT buildid FROM foodingredient WHERE foodingredient.foodid = items.itemid ORDER BY buildid DESC  LIMIT 0 , 1 ),0)buildid FROM items WHERE salestatus =1 and items.description like itemname LIMIT 0 , 30"
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try
            Try
                cmd.CommandText = "CREATE DEFINER=`root`@`localhost` PROCEDURE `printOrderList`(IN `customerOrder` INT(30)) " _
                     & " SELECT *  FROM  `orders` , orderline,items" _
                     & " WHERE orders.orderid = orderline.orderid and orderline.itemid=items.itemid And orders.orderid =customerOrder ORDER BY orders.orderid, orderline.orderlineid"
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

End Class