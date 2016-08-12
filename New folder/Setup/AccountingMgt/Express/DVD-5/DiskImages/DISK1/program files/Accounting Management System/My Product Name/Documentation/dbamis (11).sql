-- phpMyAdmin SQL Dump
-- version 4.0.4
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jul 27, 2016 at 12:37 PM
-- Server version: 5.6.12-log
-- PHP Version: 5.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `dbamis`
--
CREATE DATABASE IF NOT EXISTS `dbamis` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `dbamis`;

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `getItemId`(IN `barcodeNum` INT, IN `descriptionname` VARCHAR(100))
    NO SQL
select if(count(itemid)=0,(select max(itemid)+1 from items),itemid)itemid from items where barcode like barcodenum and description like descriptionname$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getItems`()
    NO SQL
SELECT description, itemid, price, ifnull(( SELECT buildid FROM foodingredient WHERE foodingredient.foodid = items.itemid ORDER BY buildid DESC  LIMIT 0 , 1 ),0)buildid FROM items WHERE salestatus =1 LIMIT 0 , 30$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getOrders`()
BEGIN select orderid,customerid,ifnull(tablenum,0)tablenum,orderdate,ifnull(discount,0)discount,ifnull(paymentAmt,0),empid,orderstatus from orders; END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getSearchItem`(IN `itemname` VARCHAR(200))
    NO SQL
SELECT description, itemid, price, ifnull(( SELECT buildid FROM foodingredient WHERE foodingredient.foodid = items.itemid ORDER BY buildid DESC  LIMIT 0 , 1 ),0)buildid FROM items WHERE salestatus =1 and items.description like itemname LIMIT 0 , 30$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getSold`(IN `tostart` VARCHAR(20), IN `toend` VARCHAR(20))
select orderline.orderid,
orderline.orderlineid,
items.barcode,
items.description,
orderline.quantity,
orderline.price,
(orderline.quantity*orderline.Price)revenue,
orders.orderdate from orders, orderline
left join items on orderline.itemid=items.itemid
where orders.orderid=orderline.orderid and
date(orders.orderdate) >= tostart
and
date(orders.orderdate) <= toend
ORDER BY `orderline`.`orderlineID` ASC$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getSupplierName`(IN `suppliername` VARCHAR(40))
    NO SQL
SELECT  if(count(`supplierid`)=0,'',`supplierid`)`supplierid`,ifnull(`company`,'')company FROM  `supplier` WHERE company LIKE  suppliername$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getSuppliers`()
    NO SQL
select if(count(company)=0,'',company)company from supplier$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `printOrderList`(IN `customerOrder` INT(30))
SELECT *  FROM  `orders` , orderline,items WHERE orders.orderid = orderline.orderid and orderline.itemid=items.itemid And orders.orderid =customerOrder ORDER BY orders.orderid, orderline.orderlineid$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE IF NOT EXISTS `customers` (
  `CustomerID` int(11) NOT NULL AUTO_INCREMENT,
  `CustomerName` varchar(100) NOT NULL,
  PRIMARY KEY (`CustomerID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

CREATE TABLE IF NOT EXISTS `employees` (
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
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `expenses`
--

CREATE TABLE IF NOT EXISTS `expenses` (
  `expenseid` int(11) NOT NULL,
  `AccountTitle` varchar(200) NOT NULL,
  `Amount` double(12,2) NOT NULL,
  `DateTime` datetime NOT NULL,
  `EmpID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `foodingredient`
--

CREATE TABLE IF NOT EXISTS `foodingredient` (
  `ingredientid` int(30) NOT NULL AUTO_INCREMENT,
  `foodid` int(30) NOT NULL,
  `itemid` int(20) NOT NULL,
  `buildID` int(255) DEFAULT NULL,
  `unit` varchar(7) DEFAULT NULL,
  `quantity` double(12,3) DEFAULT NULL,
  PRIMARY KEY (`ingredientid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `items`
--

CREATE TABLE IF NOT EXISTS `items` (
  `ItemID` int(11) NOT NULL AUTO_INCREMENT,
  `Barcode` varchar(50) DEFAULT NULL,
  `Description` varchar(45) NOT NULL,
  `Brand` varchar(45) DEFAULT NULL,
  `Price` double(12,4) DEFAULT NULL,
  `UnitValue` varchar(20) NOT NULL,
  `UnitType` varchar(10) NOT NULL,
  `Category` varchar(45) NOT NULL,
  `ItemType` tinyint(1) NOT NULL,
  `InitialQuantity` double(5,2) DEFAULT NULL,
  `SaleStatus` tinyint(1) DEFAULT NULL,
  `image` blob,
  PRIMARY KEY (`ItemID`),
  UNIQUE KEY `Description` (`Description`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `job`
--

CREATE TABLE IF NOT EXISTS `job` (
  `JobGradeID` int(10) NOT NULL AUTO_INCREMENT,
  `JobDescription` varchar(30) NOT NULL,
  `Salary` double(10,2) NOT NULL DEFAULT '0.00',
  PRIMARY KEY (`JobGradeID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `job`
--

INSERT INTO `job` (`JobGradeID`, `JobDescription`, `Salary`) VALUES
(1, 'DBADMINISTRATOR', 250.00);

-- --------------------------------------------------------

--
-- Table structure for table `jobdtr`
--

CREATE TABLE IF NOT EXISTS `jobdtr` (
  `DTRID` bigint(20) NOT NULL AUTO_INCREMENT,
  `EmpID` int(11) NOT NULL,
  `dateTimeIn` datetime DEFAULT NULL,
  `dateTimeOut` datetime DEFAULT NULL,
  `DTRStatus` int(1) NOT NULL DEFAULT '0' COMMENT '0=Pending;1=Accepted;2=Deny',
  PRIMARY KEY (`DTRID`),
  KEY `EmpID` (`EmpID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `orderline`
--

CREATE TABLE IF NOT EXISTS `orderline` (
  `orderlineID` int(30) NOT NULL AUTO_INCREMENT,
  `orderid` int(30) DEFAULT NULL,
  `ItemID` int(30) DEFAULT NULL,
  `buildid` int(11) DEFAULT NULL,
  `quantity` double(12,2) DEFAULT NULL,
  `price` double(11,2) DEFAULT NULL,
  `status` tinyint(4) DEFAULT '0' COMMENT '0=Pending 1=Given',
  PRIMARY KEY (`orderlineID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE IF NOT EXISTS `orders` (
  `OrderID` int(30) NOT NULL AUTO_INCREMENT,
  `CustomerID` int(30) DEFAULT NULL,
  `tableNum` int(30) NOT NULL DEFAULT '0',
  `OrderDate` datetime DEFAULT NULL,
  `Discount` float DEFAULT '0',
  `PaymentAmt` double(11,2) NOT NULL DEFAULT '0.00',
  `EmpID` int(30) DEFAULT NULL,
  `OrderStatus` tinyint(4) NOT NULL DEFAULT '0' COMMENT '0=pending;1=completed',
  PRIMARY KEY (`OrderID`),
  KEY `OrderID` (`OrderID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `po`
--

CREATE TABLE IF NOT EXISTS `po` (
  `POID` int(11) NOT NULL AUTO_INCREMENT,
  `SupplierID` int(11) NOT NULL,
  `EmpID` int(11) NOT NULL,
  `PODate` date NOT NULL,
  `TotalCost` double NOT NULL DEFAULT '0',
  `Status` tinyint(4) NOT NULL,
  `PODeliveryDate` date DEFAULT NULL,
  PRIMARY KEY (`POID`),
  KEY `SupplierID` (`SupplierID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `podeliveries`
--

CREATE TABLE IF NOT EXISTS `podeliveries` (
  `podeliveryID` int(30) NOT NULL AUTO_INCREMENT,
  `polistid` int(30) DEFAULT NULL,
  `podeliverydate` datetime DEFAULT NULL,
  `poquantity` double(12,2) DEFAULT NULL,
  PRIMARY KEY (`podeliveryID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `polist`
--

CREATE TABLE IF NOT EXISTS `polist` (
  `POListID` int(11) NOT NULL AUTO_INCREMENT,
  `POID` int(11) NOT NULL,
  `ItemID` int(11) NOT NULL,
  `Quantity` double(10,2) NOT NULL,
  `Cost` double NOT NULL DEFAULT '0',
  `postatus` int(11) NOT NULL,
  `QuantityDelivery` int(11) DEFAULT NULL,
  `DeliveryDate` date DEFAULT NULL,
  PRIMARY KEY (`POListID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE IF NOT EXISTS `supplier` (
  `SupplierID` int(11) NOT NULL AUTO_INCREMENT,
  `Company` varchar(45) NOT NULL,
  `Address` varchar(45) NOT NULL,
  `Contact` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`SupplierID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`SupplierID`, `Company`, `Address`, `Contact`) VALUES
(1, 'KCC Mall of Gensan', 'General Santos City', '5555');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `UserID` int(30) NOT NULL AUTO_INCREMENT,
  `EmpID` int(30) NOT NULL,
  `Username` varchar(20) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Function` enum('Admin','Cashier','Manager') NOT NULL,
  PRIMARY KEY (`UserID`),
  UNIQUE KEY `Username_UNIQUE` (`Username`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Stand-in structure for view `vstockin`
--
CREATE TABLE IF NOT EXISTS `vstockin` (
`POID` int(11)
,`itemid` int(11)
,`barcode` varchar(50)
,`description` varchar(45)
,`price` double(12,4)
,`category` varchar(45)
,`supllierid` int(11)
,`empid` int(11)
,`podate` date
,`status` tinyint(4)
,`podeliverydate` date
,`polistid` int(11)
,`unittype` varchar(10)
,`quantity` double(10,2)
,`cost` double
);
-- --------------------------------------------------------

--
-- Structure for view `vstockin`
--
DROP TABLE IF EXISTS `vstockin`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vstockin` AS (select `po`.`POID` AS `POID`,`polist`.`ItemID` AS `itemid`,`items`.`Barcode` AS `barcode`,`items`.`Description` AS `description`,`items`.`Price` AS `price`,`items`.`Category` AS `category`,`po`.`SupplierID` AS `supllierid`,`po`.`EmpID` AS `empid`,`po`.`PODate` AS `podate`,`po`.`Status` AS `status`,`po`.`PODeliveryDate` AS `podeliverydate`,`polist`.`POListID` AS `polistid`,`items`.`UnitType` AS `unittype`,`polist`.`Quantity` AS `quantity`,`polist`.`Cost` AS `cost` from ((`po` join `polist` on((`po`.`POID` = `polist`.`POID`))) left join `items` on((`items`.`ItemID` = `polist`.`ItemID`))));

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
