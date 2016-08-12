
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
                cmd.CommandText = "CREATE DEFINER=`root`@`localhost` PROCEDURE `getOrderID`() " _
                        & " select if(count(orderid)=0,1,max(orderid))from orders;"
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
            Try
                cmd.CommandText = "CREATE DEFINER=`root`@`localhost` PROCEDURE `getEmployeeInfo`(IN `employeeINID` INT(30)) " _
                     & "    SELECT  e.Empid, e.NameFirst, e.NameMiddle,e.NameLast, IFNULL( IF( e.gender =  'M', 0, IF( e.gender =  'F', 1 , -1 ) ) , -1 ) gender,ifnull(e.BirthDate,'')BirthDate,ifnull(e.BirthAddress,'')BirthAddress,ifnull(e.AddressStreet,'')AddressStreet,ifnull(e.AddressBarangay,'')AddressBarangay,ifnull(e.AddressMunCity,'')AddressMunCity,ifnull(e.AddressProvince,'')AddressProvince,ifnull(e.AddressZip,'')AddressZip,ifnull(e.Contact,'')Contact,ifnull(e.EmpImage,'')EmpImage,if(employmentstarted='0000-00-00',curdate(),employmentstarted)employmentstarted,ifnull(e.employmentstatus,-1)employmentstatus,ifnull(e.maritalstatus,0)maritalstatus,ifnull(u.Username,''),ifnull(`u`.`Function`,'')role,ifnull(`u`.`Password`,'')Ucode,ifnull(`u`.`Username`,'')Uname,empImage from `employees` e  LEFT JOIN `users` u ON u.EmpID=e.Empid where e.empid=employeeINID;"
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try
            Try
                cmd.CommandText = "CREATE DEFINER=`root`@`localhost` PROCEDURE `getsuppliers`() " _
                     & "select company from supplier group by company;"
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try
            Try
                cmd.CommandText = "create procedure getProductList() " _
                    & " Select itemid,barcode,description,category,price,unittype,initialquantity from items where itemtype <> 2;"
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try
            Try
                cmd.CommandText = " create procedure getdtrlist() " _
& " Select d.dtrid,d.empid,concat(e.namelast,', ',e.namefirst)empName,d.datetimein,d.datetimeout,If(d.dtrstatus=0,'Pending','Accepted')dtrstatus from jobdtr d,employees e " _
& " where e.empid = d.empid order by d.empid;"
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try
            Try
                cmd.CommandText = "create procedure getitemid(in prdBarcode varchar(100),in prdDescption varchar(100))
select itemid from items where description=prdDescption and barcode=prdBarcode;"
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try
            Try
                cmd.CommandText = " create procedure getPurchaseList(In inPrdID Integer,in inEmpID integer) " _
                    & " Select p.polistid,i.barcode,i.description,i.unittype,p.cost,p.quantity,(p.cost*p.quantity)total from polist p, po, items i Where po.poid = p.poid And  po.empid = inEmpID And po.poid = inPrdID;"
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        DisconnDB()
    End Sub

End Class