
'Imports System.Collections

Public Class createDB
    Private dbname As String
    Private vUSER As String
    Private vPASS As String
    Public Sub New(ByVal Database As String, ByVal User As String, ByVal Pass As String)
        dbname = Database
        vUSER = User
        vPASS = Pass
    End Sub

    Public Function createDB() As String()
        Dim dbUser = vUSER, dbPass = vPASS, dbTBCreate() As String
        Dim sqlList As New List(Of String)
        '0
        sqlList.Add("CREATE DATABASE IF NOT EXISTS `" & dbname & "` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;")
        '1
        sqlList.Add("USE `" & dbname & "`;")


        ' sqlList.Add("GRANT USAGE On *.* To 'dbamis'@'%' IDENTIFIED BY PASSWORD '*782549B9754817AA3E7BF376341B7E3095896546';")
        ' sqlList.Add("GRANT ALL PRIVILEGES ON `dbamis`.* TO 'dbamis'@'%';")
        ' sqlList.Add("GRANT SELECT, INSERT, UPDATE, DELETE, DROP, REFERENCES, INDEX, ALTER, CREATE TEMPORARY TABLES, LOCK TABLES, EXECUTE, CREATE VIEW, SHOW VIEW, CREATE ROUTINE, ALTER ROUTINE, EVENT, TRIGGER ON `dbamis\_%`.* TO 'dbamis'@'%';")
        ' sqlList.Add("GRANT Select, INSERT, UPDATE, DELETE, FILE On *.* To 'dbamis'@'localhost' IDENTIFIED BY PASSWORD '*304B05346FD9C1EB06294BC2678C85AFBD3C4BF0';")
        ' sqlList.Add("GRANT ALL PRIVILEGES ON `dbamis\_%`.* TO 'dbamis'@'localhost';")
        'REVOKE ALL PRIVILEGES ON `dbamis\_%`.* FROM 'dbamis'@'localhost'; GRANT SELECT, INSERT, UPDATE, DELETE, DROP, REFERENCES, INDEX, ALTER, CREATE TEMPORARY TABLES, LOCK TABLES, CREATE VIEW, EVENT, TRIGGER, SHOW VIEW, CREATE ROUTINE, ALTER ROUTINE, EXECUTE ON `dbamis\_%`.* TO 'dbamis'@'localhost';

        'sqlList.Add("set password for 'root'@'localhost'=PASSWORD('admin456')")
        'sqlList.Add("CREATE USER '" & dbUser & "'@'localhost' IDENTIFIED BY '" & dbPass & "'")
        'sqlList.Add("GRANT ALL PRIVILEGES ON `" & dbname & "\_%`.* TO '" & dbUser & "'@'localhost'")
        'EMPLOYEE TABLE
        '2
        sqlList.Add("CREATE TABLE IF NOT EXISTS `employees` ( " _
  & " `EmpID` int(30) Not NULL AUTO_INCREMENT, " _
  & " `NameFirst` varchar(45) NOT NULL, " _
 & "  `NameMiddle` varchar(45) Not NULL, " _
  & " `NameLast` varchar(45) NOT NULL, " _
  & " `Gender` Char(1) Default NULL, " _
  & " `BirthDate` date DEFAULT NULL, " _
  & " `BirthAddress` varchar(100) Default NULL, " _
  & " `MaritalStatus` tinyint(1) DEFAULT NULL, " _
  & " `AddressStreet` varchar(45) Default NULL, " _
  & " `AddressBarangay` varchar(45) DEFAULT NULL, " _
  & " `AddressMunCity` varchar(45) Default NULL, " _
  & " `AddressProvince` varchar(45) DEFAULT NULL, " _
 & "  `AddressZip` varchar(5) Default NULL, " _
 & "  `Contact` varchar(15) DEFAULT NULL, " _
 & "  `EmploymentStatus` tinyint(4) Not NULL, " _
& "   `EmpImage` longblob, " _
& "   `deleted` tinyint(1) Not NULL Default '0', " _
& "   `EmploymentStarted` date Not NULL, " _
& "   PRIMARY KEY (`EmpID`) " _
& " ) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ; ")
        '3
        sqlList.Add("CREATE TABLE IF Not EXISTS `users` (
              `UserID` int(30) NOT NULL AUTO_INCREMENT,
              `EmpID` int(30) NOT NULL,
              `Username` varchar(20) NOT NULL,
              `Password` varchar(50) NOT NULL,
              `Function` enum('Admin','Cashier','Manager') NOT NULL,
              PRIMARY KEY (`UserID`),
              UNIQUE KEY `Username_UNIQUE` (`Username`)
            )")
        'INSERT INITIAL VALUE
        '2 tables must always be linked by not all employees have the access to the program
        'each user must have employee record. need only once.
        '4
        sqlList.Add("insert into employees(`empid`,`namefirst`,`namemiddle`,`namelast`,`employmentstatus`) values('1','Administrator','Administrator','Administrator',1) on duplicate key update namefirst='Administrator'")
        '5
        sqlList.Add("insert into users(`userid`,`Empid`,`username`,`password`,`function`) values(1,1,'Admin','Admin','Admin') on duplicate key update `username`='Admin',`password`='Admin'")


        'THIS WILL CREATE A PURCHASE ORDERLIST VIEW
        'SELECT DATE_FORMAT( NOW( ) ,  '%Y-%m-%d' ) DATE
        'THIS WILL CREAE PO TABLE FOR SUMMARY OF PURCHASE ORDER LISTS
        '6

        sqlList.Add("CREATE TABLE IF NOT EXISTS `customers` (" _
  & " `CustomerID` int(11) NOT NULL AUTO_INCREMENT," _
  & " `CustomerName` varchar(100) NOT NULL," _
 & "  PRIMARY KEY (`CustomerID`) " _
& " ) ENGINE=InnoDB  Default CHARSET=latin1 AUTO_INCREMENT=2 ;")
        sqlList.Add("CREATE TABLE If Not EXISTS `po` (
  `POID` int(11) NOT NULL AUTO_INCREMENT,
  `SupplierID` int(11) NOT NULL,
  `EmpID` int(11) NOT NULL,
  `PODate` date NOT NULL,
  `TotalCost` double NOT NULL DEFAULT '0',
  `Status` tinyint(4) NOT NULL,
  `PODeliveryDate` date DEFAULT NULL,
  PRIMARY KEY (`POID`),
  KEY `SupplierID` (`SupplierID`)
)")
        sqlList.Add("CREATE TABLE IF Not EXISTS `po` ( " _
  & " `POID` int(11) Not NULL AUTO_INCREMENT," _
 & "  `SupplierID` int(11) Not NULL," _
  & " `EmpID` int(11) Not NULL," _
  & " `PODate` date Not NULL," _
  & " `Status` tinyint(4) Not NULL," _
  & " `PODeliveryDate` date DEFAULT NULL," _
  & " PRIMARY KEY(`POID`)," _
  & " KEY `SupplierID` (`SupplierID`)" _
& " ) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=13 ;")
        '7
        'sqlList.Add("CREATE TABLE IF NOT EXISTS `polist` (
        '      `POListID` int(11) NOT NULL AUTO_INCREMENT,
        '      `POID` int(11) NOT NULL,
        '      `ItemID` int(11) NOT NULL,
        '      `Quantity` double(10,2) NOT NULL,
        '      `Cost` double NOT NULL DEFAULT '0',
        '      PRIMARY KEY (`POListID`)
        '    )")

        sqlList.Add(" CREATE TABLE IF Not EXISTS `polist` ( " _
                  & " `POListID` int(11) Not NULL AUTO_INCREMENT, " _
                  & " `POID` int(11) Not NULL, " _
                  & " `ItemID` int(11) Not NULL, " _
                  & " `Quantity` double(10,2) Not NULL, " _
                  & " `Cost` Double Not NULL Default '0', " _
                  & " `postatus` int(11) Not NULL, " _
                  & " `QuantityDelivery` int(11) DEFAULT NULL, " _
                  & " `DeliveryDate` date DEFAULT NULL, " _
                  & " PRIMARY KEY(`POListID`) " _
                  & " ) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ; ")
        '8
        'THIS WILL CREATE ITEMS FOR SUMMARY OF ITEMS BEING PURCHASED
        'sqlList.Add("
        '    CREATE TABLE IF NOT EXISTS `items` (
        '      `ItemID` int(11) NOT NULL AUTO_INCREMENT,
        '      `Barcode` varchar(50) DEFAULT NULL,
        '      `Description` varchar(45) NOT NULL,
        '      `Brand` varchar(45) DEFAULT NULL,
        '      `Price` double(12,4) DEFAULT NULL,
        '      `UnitValue` varchar(20) NOT NULL,
        '      `UnitType` varchar(10) NOT NULL,
        '      `Category` varchar(45) NOT NULL,
        '      `ItemType` tinyint(1) NOT NULL,
        '      `InitialQuantity` double(5,2) NOT NULL,
        '      `SaleStatus` tinyint(4) NOT NULL,
        '      PRIMARY KEY (`ItemID`),
        '      UNIQUE KEY `Description` (`Description`)
        '    )")

        sqlList.Add("        CREATE TABLE IF Not EXISTS `items` ( " _
                & "   `ItemID` int(11) Not NULL AUTO_INCREMENT, " _
                & "   `Barcode` varchar(50) DEFAULT NULL, " _
                & "   `Description` varchar(45) Not NULL, " _
                & "   `Brand` varchar(45) DEFAULT NULL, " _
                & "   `Price` Double(12,4) Default NULL, " _
                & "   `UnitValue` varchar(20) Not NULL, " _
                 & "  `UnitType` varchar(10) Not NULL, " _
                  & " `Category` varchar(45) Not NULL, " _
                  & " `ItemType` tinyint(1) Not NULL," _
                  & " `InitialQuantity` double(5,2) Not NULL, " _
                  & " `SaleStatus` tinyint(1) Not NULL, " _
                  & " `image` blob, " _
                  & " PRIMARY KEY(`ItemID`), " _
                  & " UNIQUE KEY `Description` (`Description`) " _
                & " ) ENGINE= InnoDB  Default CHARSET=latin1 AUTO_INCREMENT=35 ; ")

        ''9
        sqlList.Add("CREATE TABLE If Not EXISTS `job` (
              `JobGradeID` int(10) NOT NULL AUTO_INCREMENT,
              `JobDescription` varchar(30) NOT NULL,
              `Salary` double(10,2) NOT NULL DEFAULT '0.00',
              PRIMARY KEY (`JobGradeID`)
            )")
        '10
        'sqlList.Add("CREATE TABLE IF NOT EXISTS `jobdtr` (
        '      `DTRID` bigint(20) NOT NULL AUTO_INCREMENT,
        '      `dateTimeIn` datetime NOT NULL,
        '      `dateTimeOut` datetime NOT NULL,
        '      `EmpID` int(11) NOT NULL,
        '      PRIMARY KEY (`DTRID`),
        '      KEY `EmpID` (`EmpID`)
        '    )")
        sqlList.Add("   CREATE TABLE IF Not EXISTS `jobdtr` ( " _
 & "  `DTRID` bigint(20) Not NULL AUTO_INCREMENT, " _
 & " `EmpID` int(11) Not NULL, " _
 & "  `dateTimeIn` datetime Default NULL, " _
 & "  `dateTimeOut` datetime DEFAULT NULL, " _
 & "  `DTRStatus` int(1) Not NULL Default '0' COMMENT '0=Pending;1=Accepted;2=Deny', " _
 & "  PRIMARY KEY(`DTRID`), " _
 & "  KEY `EmpID` (`EmpID`) " _
& " ) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=20 ;")
        '11
        'sqlList.Add("CREATE TABLE If Not EXISTS `orders` (
        '      `OrderID` int(30) NOT NULL AUTO_INCREMENT,
        '      `ItemID` int(30) NOT NULL,
        '      `CustomerID` int(30) NOT NULL,
        '      `Total` double(12,2) NOT NULL,
        '      `OrderDate` date NOT NULL,
        '      `EmpID` int(30) NOT NULL,
        '      `OrderStatus` tinyint(4) NOT NULL COMMENT '0=pending;1=completed',
        '      PRIMARY KEY (`OrderID`)
        '    )")
        sqlList.Add("   CREATE TABLE IF Not EXISTS `orders` ( " _
                  & " `OrderID` int(30) Not NULL AUTO_INCREMENT, " _
                  & " `CustomerID` int(30) DEFAULT NULL, " _
                  & " `tableNum` int(30) Not NULL Default '0', " _
                  & " `OrderDate` datetime DEFAULT NULL, " _
                  & " `Discount` float DEFAULT '0', " _
                  & " `PaymentAmt` double(11,2) Not NULL DEFAULT '0.00', " _
                  & " `EmpID` int(30) DEFAULT NULL, " _
                  & " `OrderStatus` tinyint(4) Not NULL DEFAULT '0' COMMENT '0=pending;1=completed', " _
                  & " PRIMARY KEY(`OrderID`) " _
                & " ) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;   ")
        '12
        'sqlList.Add("CREATE TABLE IF NOT EXISTS `orderline` (
        '      `orderlineID` int(30) NOT NULL,
        '      `orderid` int(30) NOT NULL,
        '      `ItemID` int(30) NOT NULL,
        '      `quantity` double(12,2) NOT NULL
        '    )")
        sqlList.Add("CREATE TABLE IF Not EXISTS `orderline` ( " _
& "  `orderlineID` int(30) Not NULL AUTO_INCREMENT, " _
& "  `orderid` int(30) DEFAULT NULL, " _
& "  `ItemID` int(30) DEFAULT NULL, " _
& "  `buildid` int(11) DEFAULT NULL, " _
& "  `quantity` double(12,2) DEFAULT NULL, " _
& "  `price` int(11) Not NULL, " _
& "  `status` tinyint(4) DEFAULT '0' COMMENT '0=Pending 1=Given', " _
& "  PRIMARY KEY (`orderlineID`) " _
& ") ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;")
        '13
        sqlList.Add("CREATE TABLE IF NOT EXISTS `supplier` (
              `SupplierID` int(11) NOT NULL AUTO_INCREMENT,
              `Company` varchar(45) NOT NULL,
              `Address` varchar(45) NOT NULL,
              `Contact` varchar(45) DEFAULT NULL,
              PRIMARY KEY (`SupplierID`)
            )")
        '14
        sqlList.Add("CREATE TABLE IF NOT EXISTS `jobdtr` (
              `DTRID` bigint(20) NOT NULL AUTO_INCREMENT,
              `dateTimeIn` datetime NOT NULL,
              `dateTimeOut` datetime NOT NULL,
              `EmpID` int(11) NOT NULL,
              PRIMARY KEY (`DTRID`),
              KEY `EmpID` (`EmpID`)
            )")
        sqlList.Add("CREATE TABLE IF NOT EXISTS `foodingredient` (
  `ingredientid` int(30) NOT NULL AUTO_INCREMENT,
  `foodid` int(30) NOT NULL,
  `itemid` int(20) NOT NULL,
  `buildID` int(255) DEFAULT NULL,
  `unit` varchar(7) DEFAULT NULL,
  `quantity` double(12,3) DEFAULT NULL,
  PRIMARY KEY (`ingredientid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;
")
        sqlList.Add("DROP TABLE IF EXISTS `vstockin`;")
        sqlList.Add("CREATE ALGORITHM = UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vstockin` As (Select `po`.`POID` As `POID`,`polist`.`ItemID` AS `itemid`,`items`.`Barcode` AS `barcode`,`items`.`Description` AS `description`,`items`.`Price` AS `price`,`items`.`Category` AS `category`,`po`.`SupplierID` AS `supllierid`,`po`.`EmpID` AS `empid`,`po`.`PODate` AS `podate`,`po`.`Status` AS `status`,`po`.`PODeliveryDate` AS `podeliverydate`,`polist`.`POListID` AS `polistid`,`items`.`UnitType` AS `unittype`,`polist`.`Quantity` AS `quantity`,`polist`.`Cost` AS `cost` from ((`po` join `polist` on((`po`.`POID` = `polist`.`POID`))) left join `items` on((`items`.`ItemID` = `polist`.`ItemID`))));")



        '15

        '    sqlList.Add("call AddColumnUnlessExists(Database(), 'dbamis', 'category', 'varchar(32) null');")

        ''ADD HERE ADDITIONAL UPDATES ON TABLE IF EXISTED
        'THIS THE the way to insert column in a table for update without changing its content
        '10


        '11
        'sqlList.Add("CALL Alter_Table_Insert_DELETED_column()") 'EXECUTE THE ALTERATION
        'sqlList.Add("DROP PROCEDURE If EXISTS Alter_Table_Insert_DELETED_column()")

        'CREATE USER ON DATABASE PHPMYADMIN
        'sqlList.Add("GRANT ALL PRIVILEGES On  `" & dbname & "` . * To  '" & dbUser & "'@'localhost' WITH GRANT OPTION")
        dbTBCreate = sqlList.ToArray()

        '        dbTBCreate(3) = "CREATE TABLE IF NOT EXISTS `category` (" &
        '                          "`CategoryID` int(11) NOT NULL AUTO_INCREMENT," &
        '                          "`CategoryName` varchar(150) NOT NULL," &
        '                          "`CategoryDescription` varchar(240) NOT NULL," &
        '                          "PRIMARY KEY (`CategoryID`)" &
        '                          ") ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=1;"


        '
        '        dbTBCreate(5) = "CREATE TABLE IF NOT EXISTS `requisition` (
        '                       `PRNum` int(11) Not NULL AUTO_INCREMENT,
        '                      `Description` varchar(240) Not NULL,
        '                      `Amount` varchar(240) Not NULL,
        '                      `Purpose` varchar(240) Not NULL,
        '                      `Status` varchar(50) Not NULL,
        '                      `DateTime` varchar(30) Not NULL,
        '        PRIMARY KEY (`PRNum`)
        '                      ) ENGINE=InnoDB  Default CHARSET=latin1 AUTO_INCREMENT=1;"
        '        dbTBCreate(6) = "CREATE TABLE If Not EXISTS `purchase` (
        '                     `PurchaseORNum` int(20) Not NULL AUTO_INCREMENT,
        '                     `PRNum` int(20) Not NULL,
        '                    `SupplierID` int(20) Not NULL,
        '                    `TotalCost` float(20,4) Not NULL,
        '                    `Date` varchar(20) Not NULL,
        '                    `Remarks` text Not NULL,
        '        PRIMARY KEY(`PurchaseORNum`)
        '                    ) ENGINE=InnoDB Default CHARSET=latin1 AUTO_INCREMENT=1 ;"
        '        dbTBCreate(7) = "CREATE TABLE If Not EXISTS `purchaselist` (" &
        '                      "`PurchaseORNum` int(20) Not NULL," &
        '                      "`ProductID` int(20) Not NULL," &
        '                      "`CategoryID` int(20) Not NULL," &
        '                      "`UnitOfMeasure` varchar(20) Not NULL," &
        '                      "`UnitCost` float(12,4) Not NULL," &
        '                      "`Quantity` float(12,4) Not NULL" &
        '                    ") ENGINE=InnoDB Default CHARSET=latin1;"
        '        dbTBCreate(8) = "CREATE TABLE If Not EXISTS `supplier` (" &
        '                      "`SupplierID` int(20) Not NULL AUTO_INCREMENT," &
        '                      "`Company` int(200) Not NULL," &
        '                      "`AddressStreet` varchar(200) Not NULL," &
        '                      "`AddressCity` varchar(200) Not NULL," &
        '                      "`AddressZip` int(6) Not NULL," &
        '                      "`PhoneNum` int(20) Not NULL," &
        '                      "PRIMARY KEY(`SupplierID`)" &
        ''                      ") ENGINE=InnoDB Default CHARSET=latin1 AUTO_INCREMENT=1 ;"
        '       dbTBCreate(9) = "CREATE TABLE If Not EXISTS `products` (" &
        '                      "`ProductID` int(20) Not NULL AUTO_INCREMENT," &
        '                      "`CategoryID` int(20) Not NULL," &
        '                      "`Description` varchar(150) Not NULL," &
        '                      "`Price` float(12,4) Not NULL," &
        '                      "`Stocks` int(20) Not NULL," &
        '                      "`ReorderLevel` int(20) Not NULL," &
        '                      " PRIMARY KEY(`ProductID`), " &
        '                     " UNIQUE KEY `ProductID` (`ProductID`)" &
        '                    ") ENGINE=InnoDB Default CHARSET=latin1 AUTO_INCREMENT=1 ;"
        '        dbTBCreate(10) = "CREATE TABLE If Not EXISTS `orders` (" &
        '                      "`OrderNum` int(20) Not NULL AUTO_INCREMENT," &
        '                      "`CustomerNum` int(20) Not NULL," &
        '                      "`EmpID` int(20) Not NULL," &
        '                      "`QoutedPrice` float(4,4) Not NULL," &
        '                      "`Discount` float(4,2) Not NULL," &
        '                      "`OrderTime` varchar(10) Not NULL," &
        '                      "`OrderDate` varchar(25) Not NULL," &
        '                      "PRIMARY KEY (`OrderNum`)" &
        '                    ") ENGINE=InnoDB Default CHARSET=latin1 AUTO_INCREMENT=1 ;"
        '        dbTBCreate(11) = "CREATE TABLE If Not EXISTS `orderlist` (" &
        '                      "`OrderNum` int(20) Not NULL," &
        '                      "`ProductID` int(20) Not NULL," &
        '                      "`UnitPrice` float(10,2) Not NULL," &
        '                      "`Quantity` float(10,2) Not NULL" &
        '                    ") ENGINE=InnoDB Default CHARSET=latin1;"
        '        dbTBCreate(12) = "CREATE TABLE If Not EXISTS `customer` (" &
        '                      "`CustomerNum` int(30) Not NULL AUTO_INCREMENT," &
        '                      "`CitizenID` int(30) Not NULL," &
        '                      "`EmpID` varchar(200) Not NULL," &
        '                      "`NameFirst` varchar(200) Not NULL," &
        '                      "`NameMiddle` varchar(200) Not NULL," &
        '                      "`NameLast` varchar(200) Not NULL," &
        '                      "`AddressStreet` varchar(200) Not NULL," &
        '                      "`AddressBarangay` varchar(200) Not NULL," &
        '                      "`AddressMunCity` varchar(200) Not NULL," &
        '                      "`AddressProvince` varchar(200) Not NULL," &
        '                      "`Contact` varchar(200) Not NULL," &
        '                      "PRIMARY KEY (`CustomerNum`)," &
        '                      "UNIQUE KEY `CitizenID` (`CitizenID`)" &
        '                    ") ENGINE=InnoDB Default CHARSET=latin1 AUTO_INCREMENT=1 ;"
        '        dbTBCreate(13) = "CREATE TABLE If Not EXISTS `foodlist` (
        '  `ProductID` int(30) NOT NULL AUTO_INCREMENT,
        '  `CategoryID` int(30) NOT NULL,
        '  `Description` varchar(200) NOT NULL,
        '  `UnitPrice` double(12,2) NOT NULL,
        '  `Availability` varchar(15) NOT NULL,
        '        PRIMARY KEY (`ProductID`),
        '        UNIQUE KEY `ProductID` (`ProductID`)
        ') ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1;"
        '        dbTBCreate(14) = "CREATE USER '" & dbUser & "'@'localhost' IDENTIFIED BY '" & dbPass & "';"
        '        dbTBCreate(15) = "GRANT ALL PRIVILEGES ON `" & dbname & "\_%`.* TO '" & dbUser & "'@'localhost';"
        '        dbTBCreate(16) = "GRANT ALL PRIVILEGES ON  `" & dbname & "` . * TO  '" & dbUser & "'@'localhost' WITH GRANT OPTION;"
        Return dbTBCreate
    End Function
End Class
