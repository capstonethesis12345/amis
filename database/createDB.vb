
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
        sqlList.Add("CREATE DATABASE IF NOT EXISTS `" & dbname & "` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;")
        sqlList.Add("USE `" & dbname & "`;")
        sqlList.Add("set password for 'root'@'localhost'=PASSWORD('admin456')")
        'EMPLOYEE TABLE
        sqlList.Add("CREATE TABLE IF NOT EXISTS `employees` (
            `EmpID` int(30) Not NULL AUTO_INCREMENT,
            `NameFirst` varchar(30) Not NULL,
            `NameMiddle` varchar(30) Not NULL,
            `NameLast` varchar(30) Not NULL,
            `Gender` varchar(5) Not NULL,
            `BirthDate` varchar(50) Not NULL,
            `BirthAddress` varchar(100) Not NULL,
            `MaritalStatus` varchar(15) Not NULL,
            `AddressStreet` varchar(30) Not NULL,
            `AddressBarangay` varchar(30) Not NULL,
            `AddressMunCity` varchar(30) Not NULL,
            `AddressProvince` varchar(30) Not NULL,
            `AddressZip` varchar(30) Not NULL,
            `Contact` varchar(30) Not NULL,
            `EmploymentStatus` varchar(25) Not NULL,
            `EmpImage` longblob Not NULL,
            PRIMARY KEY(`EmpID`)
        ) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;")
        sqlList.Add("CREATE TABLE IF NOT EXISTS `Users`(
           `UserID` int(30) Not NULL AUTO_INCREMENT,
           `EmpID` int(30) Not NULL,
            `Username` varchar(20) Not NULL,
            `Password` varchar(50) Not NULL,
            `Function` ENUM('Admin','Cashier','Manager') Not NULL,
            PRIMARY KEY(`UserID`) 
           )")
        'CREATE USER ON DATABASE PHPMYADMIN
        sqlList.Add("CREATE USER '" & dbUser & "'@'localhost' IDENTIFIED BY '" & dbPass & "'")
        sqlList.Add("GRANT ALL PRIVILEGES ON `" & dbname & "\_%`.* TO '" & dbUser & "'@'localhost'")
        sqlList.Add("GRANT ALL PRIVILEGES ON  `" & dbname & "` . * TO  '" & dbUser & "'@'localhost' WITH GRANT OPTION")
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
