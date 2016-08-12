
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
        sqlList.Add("drop database if exists " & dbname & ";")
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
        sqlList.Add("CREATE TABLE IF NOT EXISTS `customers` (" _
  & " `CustomerID` int(11) NOT NULL AUTO_INCREMENT," _
  & " `CustomerName` varchar(100) NOT NULL," _
 & "  PRIMARY KEY (`CustomerID`) " _
& " ) ENGINE=InnoDB  Default CHARSET=latin1 AUTO_INCREMENT=1 ;")

        sqlList.Add("CREATE TABLE IF NOT EXISTS `employees` ( " _
  & " `EmpID` int(30) Not NULL AUTO_INCREMENT, " _
  & " `NameFirst` varchar(45) NOT NULL, " _
  & " `NameMiddle` varchar(45) Not NULL, " _
  & " `NameLast` varchar(45) NOT NULL, " _
  & " `Gender` Char(1) Default NULL, " _
  & " `BirthDate` date DEFAULT NULL, " _
  & " `BirthAddress` varchar(100) Default NULL, " _
  & " `MaritalStatus` VARCHAR(100) DEFAULT NULL, " _
  & " `AddressStreet` varchar(45) Default NULL, " _
  & " `AddressBarangay` varchar(45) DEFAULT NULL, " _
  & " `AddressMunCity` varchar(45) Default NULL, " _
  & " `AddressProvince` varchar(45) DEFAULT NULL, " _
  & " `AddressZip` varchar(5) Default NULL, " _
  & " `Contact` varchar(15) DEFAULT NULL, " _
  & " `EmploymentStatus` tinyint(4) Not NULL, " _
  & " `EmpImage` longblob, " _
  & " `deleted` tinyint(1) Not NULL Default '0', " _
  & " `EmploymentStarted` date  DEFAULT NULL, " _
  & " PRIMARY KEY (`EmpID`) " _
& " ) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;")

        sqlList.Add("CREATE TABLE `dbamis`.`expenses` ( " _
              & " `expense_id` Integer UNSIGNED Not NULL AUTO_INCREMENT, " _
              & " `title` VARCHAR(100) Not NULL DEFAULT '', " _
              & " `amount` Double Not NULL Default 0, " _
              & " `date_created` DATETIME, " _
              & " `notes` VARCHAR(45) Not NULL Default '', " _
              & " `empid` INTEGER UNSIGNED Not NULL DEFAULT 0, " _
              & " PRIMARY KEY(`expense_id`) " _
            & " ) ENGINE = InnoDB;")
        '3
        sqlList.Add("CREATE TABLE `foodingredient` ( " _
               & " `ingredientid` int(30) Not NULL auto_increment, " _
               & " `foodid` int(30) NOT NULL, " _
               & " `itemid` int(20) Not NULL, " _
               & " `buildID` int(255) default NULL, " _
               & " `unit` varchar(7) Default NULL, " _
               & " `quantity` double(12,3) default NULL, " _
               & " PRIMARY KEY  (`ingredientid`) " _
             & " ) ENGINE=InnoDB DEFAULT CHARSET=latin1;")

        'INSERT INITIAL VALUE
        '2 tables must always be linked by not all employees have the access to the program
        'each user must have employee record. need only once.
        '4
        sqlList.Add("insert into employees(`empid`,`namefirst`,`namemiddle`,`namelast`,`employmentstatus`) values('1','Administrator','Administrator','Administrator',1) on duplicate key update namefirst='Administrator'")
        '5



        'THIS WILL CREATE A PURCHASE ORDERLIST VIEW
        'SELECT DATE_FORMAT( NOW( ) ,  '%Y-%m-%d' ) DATE
        'THIS WILL CREAE PO TABLE FOR SUMMARY OF PURCHASE ORDER LISTS
        '6



        'sqlList.Add("CREATE TABLE IF NOT EXISTS `polist` (
        '      `POListID` int(11) NOT NULL AUTO_INCREMENT,
        '      `POID` int(11) NOT NULL,
        '      `ItemID` int(11) NOT NULL,
        '      `Quantity` double(10,2) NOT NULL,
        '      `Cost` double NOT NULL DEFAULT '0',
        '      PRIMARY KEY (`POListID`)
        '    )")


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

        sqlList.Add("CREATE TABLE `items` ( " _
              & " `ItemID` int(11) Not NULL auto_increment, " _
              & " `Barcode` varchar(50) default NULL, " _
              & " `Description` varchar(45) Default NULL, " _
              & " `Brand` varchar(45) default NULL, " _
              & " `Price` Double(12,4) Default NULL, " _
              & " `UnitValue` varchar(20) default NULL, " _
              & " `UnitType` varchar(10) Default NULL, " _
              & " `Category` varchar(45) default NULL, " _
              & " `ItemType` tinyint(1) Default NULL, " _
              & " `InitialQuantity` double(5,2) default '0.00', " _
              & " `SaleStatus` tinyint(1) Default '0', " _
              & " `image` blob, " _
              & " PRIMARY KEY  (`ItemID`), " _
              & " UNIQUE KEY `Description` (`Description`) " _
            & " ) ENGINE=InnoDB DEFAULT CHARSET=latin1;")

        ''9
        sqlList.Add("CREATE TABLE `job` ( " _
              & " `JobGradeID` int(10) Not NULL auto_increment, " _
              & " `JobDescription` varchar(30) NOT NULL, " _
              & " `Salary` Double(10,2) Not NULL Default '0.00', " _
              & " PRIMARY KEY(`JobGradeID`) " _
            & " ) ENGINE=InnoDB DEFAULT CHARSET=latin1;")
        '10
        sqlList.Add("CREATE TABLE if not exists `jobdtr` ( " _
                  & " `DTRID` bigint(20) Not NULL auto_increment, " _
                  & " `EmpID` int(11) NOT NULL, " _
                  & " `dateTimeIn` datetime Default NULL, " _
                  & " `dateTimeOut` datetime default NULL, " _
                  & " `DTRStatus` int(1) Not NULL Default '0' COMMENT '0=Pending;1=Accepted;2=Deny', " _
                  & " PRIMARY KEY(`DTRID`), " _
                  & " KEY `EmpID` (`EmpID`) " _
                & " ) ENGINE=InnoDB DEFAULT CHARSET=latin1;")
        'sqlList.Add("CREATE TABLE IF NOT EXISTS `jobdtr` (
        '      `DTRID` bigint(20) NOT NULL AUTO_INCREMENT,
        '      `dateTimeIn` datetime NOT NULL,
        '      `dateTimeOut` datetime NOT NULL,
        '      `EmpID` int(11) NOT NULL,
        '      PRIMARY KEY (`DTRID`),
        '      KEY `EmpID` (`EmpID`)
        '    )")

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
        sqlList.Add("CREATE TABLE if not exists `orders` ( " _
                  & " `OrderID` int(30) Not NULL auto_increment, " _
                  & " `CustomerID` int(30) default NULL, " _
                  & " `tableNum` int(30) Not NULL Default '0', " _
                  & " `OrderDate` datetime default NULL, " _
                  & " `Discount` float default '0', " _
                  & " `PaymentAmt` double(11,2) Not NULL default '0.00', " _
                  & " `EmpID` int(30) default NULL, " _
                  & " `OrderStatus` tinyint(4) NOT NULL default '0' COMMENT '0=pending;1=completed', " _
                  & " PRIMARY KEY  (`OrderID`), " _
                  & " KEY `OrderID` (`OrderID`) " _
                & " ) ENGINE=InnoDB DEFAULT CHARSET=latin1;")
        '12

        sqlList.Add("CREATE TABLE if not exists`po` ( " _
              & " `POID` int(11) Not NULL auto_increment, " _
              & " `SupplierID` int(11) NOT NULL, " _
              & " `EmpID` int(11) Not NULL, " _
              & " `PODate` date NOT NULL, " _
              & " `TotalCost` Double Not NULL Default '0', " _
              & " `Status` tinyint(4) Not NULL, " _
              & " `PODeliveryDate` date default NULL, " _
              & " PRIMARY KEY  (`POID`), " _
              & " KEY `SupplierID` (`SupplierID`) " _
            & " ) ENGINE=InnoDB DEFAULT CHARSET=latin1;")
        sqlList.Add(" CREATE TABLE `polist` ( " _
                  & " `POListID` int(11) Not NULL auto_increment, " _
                  & " `POID` int(11) NOT NULL, " _
                  & " `ItemID` int(11) Not NULL, " _
                  & " `Quantity` double(10,2) NOT NULL, " _
                  & " `Cost` Double Not NULL Default '0', " _
                  & " `postatus` int(11) Not NULL, " _
                  & " `QuantityDelivery` int(11) default NULL, " _
                  & " `DeliveryDate` date default NULL, " _
                  & " PRIMARY KEY  (`POListID`) " _
                & " ) ENGINE=InnoDB DEFAULT CHARSET=latin1;")
        sqlList.Add("CREATE TABLE `supplier` ( " _
             & "  `SupplierID` int(11) Not NULL auto_increment, " _
              & " `Company` varchar(45) NOT NULL, " _
             & "  `Address` varchar(45) Not NULL, " _
             & "  `Contact` varchar(45) default NULL, " _
             & "  PRIMARY KEY  (`SupplierID`) " _
            & " ) ENGINE=InnoDB DEFAULT CHARSET=latin1;")
        sqlList.Add("CREATE TABLE if not exists`users` ( " _
  & " `UserID` int(30) Not NULL auto_increment, " _
  & " `EmpID` int(30) NOT NULL, " _
  & " `Username` varchar(20) Not NULL, " _
  & " `Password` varchar(50) NOT NULL, " _
  & " `Function` Enum('Admin','Cashier','Manager') NOT NULL, " _
  & " PRIMARY KEY(`UserID`), " _
 & "  UNIQUE KEY `Username_UNIQUE` (`Username`) " _
& " ) ENGINE=InnoDB DEFAULT CHARSET=latin1;")

        sqlList.Add("insert into users(`userid`,`Empid`,`username`,`password`,`function`) values(1,1,'Admin','Admin','Admin') on duplicate key update `username`='Admin',`password`='Admin'")

        'sqlList.Add("CREATE TABLE IF NOT EXISTS `orderline` (
        '      `orderlineID` int(30) NOT NULL,
        '      `orderid` int(30) NOT NULL,
        '      `ItemID` int(30) NOT NULL,
        '      `quantity` double(12,2) NOT NULL
        '    )")
        sqlList.Add("CREATE TABLE `orderline` ( " _
              & " `orderlineID` int(30) Not NULL auto_increment, " _
              & " `orderid` int(30) default NULL, " _
              & " `ItemID` int(30) Default NULL, " _
              & " `buildid` int(11) default NULL, " _
              & " `quantity` Double(12,2) Default NULL, " _
              & " `price` double(11,2) default NULL, " _
              & " `status` tinyint(4) Default '0' COMMENT '0=Pending 1=Given', " _
              & " PRIMARY KEY(`orderlineID`) " _
            & " ) ENGINE=InnoDB DEFAULT CHARSET=latin1;")
        '13

        '14
        sqlList.Add("CREATE TABLE IF NOT EXISTS `jobdtr` (
              `DTRID` bigint(20) NOT NULL AUTO_INCREMENT,
              `dateTimeIn` datetime NOT NULL,
              `dateTimeOut` datetime NOT NULL,
              `EmpID` int(11) NOT NULL,
              PRIMARY KEY (`DTRID`),
              KEY `EmpID` (`EmpID`)
            )")


        sqlList.Add("DROP TABLE If EXISTS `vstockin`;")
        sqlList.Add("CREATE ALGORITHM = UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vstockin` As (Select `po`.`POID` As `POID`,`polist`.`ItemID` As `itemid`,`items`.`Barcode` As `barcode`,`items`.`Description` As `description`,`items`.`Price` As `price`,`items`.`Category` As `category`,`po`.`SupplierID` As `supllierid`,`po`.`EmpID` As `empid`,`po`.`PODate` As `podate`,`po`.`Status` As `status`,`po`.`PODeliveryDate` As `podeliverydate`,`polist`.`POListID` As `polistid`,`items`.`UnitType` As `unittype`,`polist`.`Quantity` As `quantity`,`polist`.`Cost` As `cost` from ((`po` join `polist` On((`po`.`POID` = `polist`.`POID`))) left join `items` On((`items`.`ItemID` = `polist`.`ItemID`))));")



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
