
Public Class createDB
    Public Sub New()

    End Sub
    Public Function createDB(ByVal dbname As String) As String()
        Dim dbUser = "amis", dbPass = "amis", dbTBCreate(17) As String
        dbTBCreate(0) = "CREATE DATABASE IF NOT EXISTS `" & dbname & "` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;"
        dbTBCreate(1) = "USE `" & dbname & "`;"
        dbTBCreate(2) = "set password for 'root'@'localhost'=PASSWORD('admin456');"
        dbTBCreate(3) = "CREATE TABLE IF NOT EXISTS `category` (" &
                          "`CategoryID` int(11) NOT NULL AUTO_INCREMENT," &
                          "`CategoryName` varchar(150) NOT NULL," &
                          "`CategoryDescription` varchar(240) NOT NULL," &
                          "PRIMARY KEY (`CategoryID`)" &
                          ") ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=1"
        dbTBCreate(4) = "CREATE TABLE IF NOT EXISTS `employees` (
  `EmpID` int(30) NOT NULL AUTO_INCREMENT,
  `UserName` varchar(60) NOT NULL,
  `Password` varchar(60) NOT NULL,
  `NameFirst` varchar(30) NOT NULL,
  `NameMiddle` varchar(30) NOT NULL,
  `NameLast` varchar(30) NOT NULL,
  `Gender` varchar(5) NOT NULL,
  `BirthDate` varchar(50) NOT NULL,
  `BirthAddress` varchar(100) NOT NULL,
  `MaritalStatus` varchar(15) NOT NULL,
  `AddressStreet` varchar(30) NOT NULL,
  `AddressBarangay` varchar(30) NOT NULL,
  `AddressMunCity` varchar(30) NOT NULL,
  `AddressProvince` varchar(30) NOT NULL,
  `AddressZip` varchar(30) NOT NULL,
  `Contact` varchar(30) NOT NULL,
  `EmploymentStatus` varchar(25) NOT NULL,
  `EmpImage` longblob NOT NULL,
  PRIMARY KEY (`EmpID`),
  UNIQUE KEY `UserName` (`UserName`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;"
        'done edited employees information
        'this will link to DTR and JobTypes

        dbTBCreate(5) = "CREATE TABLE IF NOT EXISTS `requisition` (" &
                       "`PRNum` int(11) NOT NULL AUTO_INCREMENT," &
                      "`Description` varchar(240) NOT NULL," &
                      "`Amount` varchar(240) NOT NULL," &
                      "`Purpose` varchar(240) NOT NULL," &
                      "`Status` varchar(50) NOT NULL," &
                      "`DateTime` varchar(30) NOT NULL," &
                      "PRIMARY KEY (`PRNum`)" &
                      ") ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=1;"
        dbTBCreate(6) = "CREATE TABLE IF NOT EXISTS `purchase` (" &
                     "`PurchaseORNum` int(20) NOT NULL AUTO_INCREMENT," &
                     "`PRNum` int(20) Not NULL," &
                    "`SupplierID` int(20) Not NULL," &
                    "`TotalCost` float(20,4) Not NULL," &
                    "`Date` varchar(20) Not NULL," &
                    "`Remarks` text Not NULL," &
                    "PRIMARY KEY(`PurchaseORNum`)" &
                    ") ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;"
        dbTBCreate(7) = "CREATE TABLE IF NOT EXISTS `purchaselist` (" &
                      "`PurchaseORNum` int(20) Not NULL," &
                      "`ProductID` int(20) NOT NULL," &
                      "`CategoryID` int(20) NOT NULL," &
                      "`UnitOfMeasure` varchar(20) NOT NULL," &
                      "`UnitCost` float(12,4) Not NULL," &
                      "`Quantity` float(12,4) NOT NULL" &
                    ") ENGINE=InnoDB DEFAULT CHARSET=latin1;"
        dbTBCreate(8) = "CREATE TABLE IF NOT EXISTS `supplier` (" &
                      "`SupplierID` int(20) Not NULL AUTO_INCREMENT," &
                      "`Company` int(200) NOT NULL," &
                      "`AddressStreet` varchar(200) Not NULL," &
                      "`AddressCity` varchar(200) NOT NULL," &
                      "`AddressZip` int(6) Not NULL," &
                      "`PhoneNum` int(20) NOT NULL," &
                      "PRIMARY KEY(`SupplierID`)" &
                      ") ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;"
        dbTBCreate(9) = "CREATE TABLE IF NOT EXISTS `products` (" &
                      "`ProductID` int(20) Not NULL AUTO_INCREMENT," &
                      "`CategoryID` int(20) NOT NULL," &
                      "`Description` varchar(150) Not NULL," &
                      "`Price` float(12,4) NOT NULL," &
                      "`Stocks` int(20) Not NULL," &
                      "`ReorderLevel` int(20) Not NULL," &
                      " PRIMARY KEY(`ProductID`), " &
                     " UNIQUE KEY `ProductID` (`ProductID`)" &
                    ") ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;"
        dbTBCreate(10) = "CREATE TABLE IF NOT EXISTS `orders` (" &
                      "`OrderNum` int(20) Not NULL AUTO_INCREMENT," &
                      "`CustomerNum` int(20) NOT NULL," &
                      "`EmpID` int(20) Not NULL," &
                      "`QoutedPrice` float(4,4) NOT NULL," &
                      "`Discount` float(4,2) Not NULL," &
                      "`OrderTime` varchar(10) NOT NULL," &
                      "`OrderDate` varchar(25) NOT NULL," &
                      "PRIMARY KEY (`OrderNum`)" &
                    ") ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;"
        dbTBCreate(11) = "CREATE TABLE IF NOT EXISTS `orderlist` (" &
                      "`OrderNum` int(20) Not NULL," &
                      "`ProductID` int(20) NOT NULL," &
                      "`UnitPrice` float(10,2) Not NULL," &
                      "`Quantity` float(10,2) NOT NULL" &
                    ") ENGINE=InnoDB DEFAULT CHARSET=latin1;"
        dbTBCreate(12) = "CREATE TABLE IF NOT EXISTS `customer` (" &
                      "`CustomerNum` int(30) NOT NULL AUTO_INCREMENT," &
                      "`CitizenID` int(30) NOT NULL," &
                      "`EmpID` varchar(200) Not NULL," &
                      "`NameFirst` varchar(200) NOT NULL," &
                      "`NameMiddle` varchar(200) Not NULL," &
                      "`NameLast` varchar(200) NOT NULL," &
                      "`AddressStreet` varchar(200) Not NULL," &
                      "`AddressBarangay` varchar(200) NOT NULL," &
                      "`AddressMunCity` varchar(200) Not NULL," &
                      "`AddressProvince` varchar(200) NOT NULL," &
                      "`Contact` varchar(200) NOT NULL," &
                      "PRIMARY KEY (`CustomerNum`)," &
                      "UNIQUE KEY `CitizenID` (`CitizenID`)" &
                    ") ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;"
        dbTBCreate(13) = "CREATE TABLE IF NOT EXISTS `foodlist` (
  `ProductID` int(30) NOT NULL AUTO_INCREMENT,
  `CategoryID` int(30) NOT NULL,
  `Description` varchar(200) NOT NULL,
  `UnitPrice` double(12,2) NOT NULL,
  `Availability` varchar(15) NOT NULL,
  PRIMARY KEY (`ProductID`),
  UNIQUE KEY `ProductID` (`ProductID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 "
        dbTBCreate(14) = "CREATE USER '" & dbUser & "'@'localhost' IDENTIFIED BY '" & dbPass & "';"
        dbTBCreate(15) = "GRANT ALL PRIVILEGES ON `" & dbname & "\_%`.* TO '" & dbUser & "'@'localhost'"
        dbTBCreate(16) = "GRANT ALL PRIVILEGES ON  `" & dbname & "` . * TO  '" & dbUser & "'@'localhost' WITH GRANT OPTION"
        Return dbTBCreate
    End Function
End Class
