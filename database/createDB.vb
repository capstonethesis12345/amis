﻿
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
        'sqlList.Add("set password for 'root'@'localhost'=PASSWORD('admin456')")
        'sqlList.Add("CREATE USER '" & dbUser & "'@'localhost' IDENTIFIED BY '" & dbPass & "'")
        'sqlList.Add("GRANT ALL PRIVILEGES ON `" & dbname & "\_%`.* TO '" & dbUser & "'@'localhost'")
        'EMPLOYEE TABLE
        '2
        sqlList.Add("CREATE TABLE IF NOT EXISTS `employees` (
  `EmpID` int(30) NOT NULL AUTO_INCREMENT,
  `NameFirst` varchar(45) NOT NULL,
  `NameMiddle` varchar(45) NOT NULL,
  `NameLast` varchar(45) NOT NULL,
  `Gender` char(1) DEFAULT NULL,
  `BirthDate` date DEFAULT NULL,
  `BirthAddress` varchar(100) DEFAULT NULL,
  `MaritalStatus` tinyint(1) DEFAULT NULL,
  `AddressStreet` varchar(45) DEFAULT NULL,
  `AddressBarangay` varchar(45) DEFAULT NULL,
  `AddressMunCity` varchar(45) DEFAULT NULL,
  `AddressProvince` varchar(45) DEFAULT NULL,
  `AddressZip` varchar(5) DEFAULT NULL,
  `Contact` varchar(15) DEFAULT NULL,
  `EmploymentStatus` tinyint(4) NOT NULL,
  `EmpImage` longblob,
  `deleted` tinyint(1) NOT NULL DEFAULT '0',
  `EmploymentStarted` date NOT NULL,
  PRIMARY KEY (`EmpID`)
) ")
        '3
        sqlList.Add("CREATE TABLE IF NOT EXISTS `Users`(
           `UserID` int(30) Not NULL AUTO_INCREMENT,
           `EmpID` int(30) Not NULL,
            `Username` varchar(20) Not NULL,
            `Password` varchar(50) Not NULL,
            `Function` ENUM('Admin','Cashier','Manager') Not NULL,
            PRIMARY KEY(`UserID`),
            UNIQUE KEY `Username_UNIQUE` (`Username`)
           )")
        'INSERT INITIAL VALUE
        '2 tables must always be linked by not all employees have the access to the program
        'each user must have employee record. need only once.
        '4
        sqlList.Add("insert into employees(`empid`,`namefirst`,`namemiddle`,`namelast`,`employmentstatus`) values('1','Administrator','Administrator','Administrator',1) on duplicate key update namefirst='Administrator'")
        '5
        sqlList.Add("insert into Users(`userid`,`Empid`,`username`,`password`,`function`) values(1,1,'Admin','Admin','Admin') on duplicate key update `username`='Admin',`password`='Admin'")


        'THIS WILL CREATE A PURCHASE ORDERLIST VIEW
        'SELECT DATE_FORMAT( NOW( ) ,  '%Y-%m-%d' ) DATE
        'THIS WILL CREAE PO TABLE FOR SUMMARY OF PURCHASE ORDER LISTS
        '6
        sqlList.Add("CREATE TABLE IF NOT EXISTS `po` (
  `POID` int(11) NOT NULL AUTO_INCREMENT,
  `SupplierID` int(11) NOT NULL,
  `EmpID` int(11) NOT NULL,
  `PODate` date NOT NULL,
  `TotalCost` double NOT NULL DEFAULT '0',
  `Status` tinyint(4) NOT NULL,
  PRIMARY KEY (`POID`)
) ")
        '7
        sqlList.Add("CREATE TABLE IF NOT EXISTS POList(
            POListID INT NOT NULL AUTO_INCREMENT ,
            POID INT NOT NULL ,
            ItemID INT NOT NULL,
            Quantity DOUBLE( 10, 2 ) NOT NULL ,
            Cost double not null default 0.0,
            PRIMARY KEY ( POListID )
            )")
        '8
        'THIS WILL CREATE ITEMS FOR SUMMARY OF ITEMS BEING PURCHASED
        sqlList.Add("CREATE TABLE IF NOT EXISTS ITEMS(
                ItemID INT NOT NULL AUTO_INCREMENT ,
                Barcode INT(30) NOT NULL ,
                Description VARCHAR( 45 ) NOT NULL ,
                Brand VARCHAR( 45 ) ,
                `Price` double(12,4) NOT NULL,
                UnitType VARCHAR( 10 ) NOT NULL ,
                Category VARCHAR( 45 ) NOT NULL ,
                `taxable` tinyint(1) NOT NULL,
                ItemType VARCHAR( 15 ) NOT NULL ,
                `InitialQuantity` double(5,2),
                PRIMARY KEY ( ItemID )
                )")
        '9
        sqlList.Add("CREATE TABLE IF NOT EXISTS `jobgrade` (
              `JobGradeID` int(10) NOT NULL AUTO_INCREMENT,
              `JobDescription` varchar(30) NOT NULL,
              `Salary` double(10,2) NOT NULL DEFAULT '0.00',
              PRIMARY KEY (`JobGradeID`)
            ) ")
        '10
        sqlList.Add("create table if not exists JobGrade(
            JobGradeID int(10) not null auto_increment,
            JobDescription varchar(30) not null,
            Salary double(10,2) not null default 0.0,
            Primary key(JobGradeID)
            );")
        '11
        sqlList.Add("CREATE TABLE IF NOT EXISTS `order` (
          `OrderID` int(30) NOT NULL AUTO_INCREMENT,
          `ItemID` int(30) NOT NULL,
          `CustomerID` int(30) NOT NULL,
          `Total` double(12,2) NOT NULL,
          `OrderDate` date NOT NULL,
          `EmpID` int(30) NOT NULL,
          PRIMARY KEY (`OrderID`)
        )")
        sqlList.Add("CREATE TABLE IF NOT EXISTS `orderline` (
          `orderlineID` int(30) NOT NULL,
          `orderid` int(30) NOT NULL,
          `itemid` int(30) NOT NULL,
          `quantity` double(12,2) NOT NULL
        )")
        sqlList.Add("CREATE TABLE IF NOT EXISTS `supplier` (
              `SupplierID` int(11) NOT NULL AUTO_INCREMENT,
              `Company` varchar(45) NOT NULL,
              `Address` varchar(45) NOT NULL,
              `Contact` varchar(45) DEFAULT NULL,
              PRIMARY KEY (`SupplierID`)
            )")
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
