-- phpMyAdmin SQL Dump
-- version 4.0.4
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jul 23, 2016 at 03:58 AM
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
CREATE DEFINER=`root`@`localhost` PROCEDURE `getItems`()
    NO SQL
SELECT description, itemid, price, ifnull(( SELECT buildid FROM foodingredient WHERE foodingredient.foodid = items.itemid ORDER BY buildid DESC  LIMIT 0 , 1 ),0)buildid FROM items WHERE salestatus =1 LIMIT 0 , 30$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getOrderID`()
    NO SQL
select ifnull(if(orderstatus=1,max(orderid)+1,(select orderid from orders)),1)orderid from orders order by orderid desc limit 0,1$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getOrders`()
BEGIN select orderid,customerid,ifnull(tablenum,0)tablenum,orderdate,ifnull(discount,0)discount,ifnull(paymentAmt,0),empid,orderstatus from orders; END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getSearchItem`(IN `itemname` VARCHAR(200))
    NO SQL
SELECT description, itemid, price, ifnull(( SELECT buildid FROM foodingredient WHERE foodingredient.foodid = items.itemid ORDER BY buildid DESC  LIMIT 0 , 1 ),0)buildid FROM items WHERE salestatus =1 and items.description like itemname LIMIT 0 , 30$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `printOrderList`(IN `customerOrder` INT(30))
SELECT *  FROM  `orders` , orderline,items
WHERE orders.orderid = orderline.orderid and orderline.itemid=items.itemid And orders.orderid =customerOrder ORDER BY orders.orderid, orderline.orderlineid$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE IF NOT EXISTS `customers` (
  `CustomerID` int(11) NOT NULL AUTO_INCREMENT,
  `CustomerName` varchar(100) NOT NULL,
  PRIMARY KEY (`CustomerID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`CustomerID`, `CustomerName`) VALUES
(1, 'Walk-IN');

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`EmpID`, `NameFirst`, `NameMiddle`, `NameLast`, `Gender`, `BirthDate`, `BirthAddress`, `MaritalStatus`, `AddressStreet`, `AddressBarangay`, `AddressMunCity`, `AddressProvince`, `AddressZip`, `Contact`, `EmploymentStatus`, `EmpImage`, `deleted`, `EmploymentStarted`) VALUES
(1, 'Administrator', 'Administrator', 'Administrator', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL, 0, '0000-00-00'),
(2, 'Marlo', 'D', 'Ajeno', '', '2016-07-04', '', 0, '', '', '', '', '', '', 0, 0xffd8ffe000104a46494600010101006000600000ffdb004300080606070605080707070909080a0c140d0c0b0b0c1912130f141d1a1f1e1d1a1c1c20242e2720222c231c1c2837292c30313434341f27393d38323c2e333432ffdb0043010909090c0b0c180d0d1832211c213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232ffc0001108006e006e03012200021101031101ffc4001f0000010501010101010100000000000000000102030405060708090a0bffc400b5100002010303020403050504040000017d01020300041105122131410613516107227114328191a1082342b1c11552d1f02433627282090a161718191a25262728292a3435363738393a434445464748494a535455565758595a636465666768696a737475767778797a838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae1e2e3e4e5e6e7e8e9eaf1f2f3f4f5f6f7f8f9faffc4001f0100030101010101010101010000000000000102030405060708090a0bffc400b51100020102040403040705040400010277000102031104052131061241510761711322328108144291a1b1c109233352f0156272d10a162434e125f11718191a262728292a35363738393a434445464748494a535455565758595a636465666768696a737475767778797a82838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae2e3e4e5e6e7e8e9eaf2f3f4f5f6f7f8f9faffda000c03010002110311003f00f52d8734ddb53107de9306bbae78dca45b78a36f3532a33305f5ab5776ab0c68c83ad27349d86a8b7172ec67eda36d49b6942e6aae472916da36d4c13de9767bd2e61aa657c5215ab063f7a4da28e60f66cac4534ad5ad8290aa814730bd9950ad376d5920530a8a77138174d253a92b2b9d4e22c12289f6e7b66b46e648a4b6009e40e2b1668d89df18e475a95242d1a86e707ad4ca377735854e58f2b1d904914014d3f29c0e01ea69f955ea40c7a9aab98b48292904b196da2452de99e69f40ac3714d229f4945c2c4645348e2a5c5348a771729111498a908a4c5171728ef3be5ce413e9eb49e60d8db87cddaa93dfc4a3e41b9b1c718aa92ea12b0e596303a60d3506cd255628dc8e68c45d812306aa4f770db8f91c377001ac6373e60019dd80fca918af03764552a567a99cf10e4ac9171f5592424f9602e3b1e6ab03bd496cf273926a2320e70063d2904fc70335aa56d91cee577ef31fb403c7e756a3bfb88d40dfb80e991544ce33922959c0193c6686afb845db6351756603e7453ee0e2a5fed687fbafd3dab0fce463c9a51227639c75a870468aa4bb9d0c57d04833bb61ee1aa70c0f20e4572c6e11085660bb8e1413d4d3e3be685f6a4a3775db9a870348d4ee74b499f4ac25d66503e60a6a61acfac7f91a97065f3c4cdde70493ed4cdfd88fd6b07fe127b1278771ff0001a917c41607fe5b91f543fe15dbece4ba1c4e4bb9b81bb52e40efc7bd638d66c5ba5cafe391520d4ec9871770e7fdf14b9593a1a9b971c914d2e3a8354d6f6d1ba4e84fb38a7f9f0951b5d3fefaa43df626f333c76a63485ba67f134c122fad34c8beb4ec2b017205616a7e2db4d35d923266954721318fc4d3fc55a8b587876ea683779b80a08e8b92067f5af2086f249a4906e6dcc0907ae6b9eb5471d11d742873ae6676571e2abbb9bb86677843440b2a8e9ebfe1588baeea02fbed46697ce079cb70726b1ae260a887fe5a63393dd4ff009351485926c33632a38ae26e4f7677469c52d11d847e2ad5602930badc013fbb621bfc8a43e3ad6d87fcb00c18e72bfe15c6bcee18c6ae48c03d2918c921f95ce578c53529aea57b283dd1ddfd8dbfbfcffb947d8e51f75d7fef922b4844f9e0a7d37629a62900cec3c7bd7b5cecf9b737dca1f64b9032187ea297c9bc1d3271e8d574fafcf9fad3816c646fc53e764b948a41af57b3fe62aca6a7a9436fe4a8fdd825b0635272460f38cf4feb5279871f7cfe228dfdb7e0e71d2939736e0a528bba2bade5ca11ba3e3e98a7aea970bd4b01ed9ab219f19cfe9484be3271f5aae662e6652bdbafed0b636f70f218d8e4aef3ce3d6b10e83a6e772bcaa73d438ff0ae948cf555cfb815118918731af1cf6ac6518c9ea8da15e71564d9cfa683a628f9cc927a167e9edc63fc9a2e740b09a20239e68dd7a124115b6d6f093f73f2a88dac44f0a7a564e8c3b1d11c555fe67f81ce0f0b2ef2df6c27d0edc54e7c311ed0cb76eb21fbd950c3fcf4ad7fb2267f8c669bf6439e1d8566e8c7b1b2c5d4eff81bcd73031cba039ed9a21b8b36f97c973eb8a53712b30fdd86c9e800a459a4ddb7cb28b9e738aeb3cd70f2fc49c49663831c8323d73432c3fc1bc0f71c54264662095c11ce72314e667505941cfd7a5348c9c0713080432be71ef428b76392fb71d9b34c3713eec82c17b707ad29b9da3129c1f50734072b2630db31c02acdd828c9a68b688361bcb5ff0078914ab009555c33127d3b5585b5765c24f2a91d3349936b159ed63cfcbe4b7d24ff001a6b5ac4bd6171fee9071533d8c921244bcfb8a68b295481bc9603a05eb48697995cdaa31c0e3fde22a36b5441d56af0b69b1bbcc071db674a536ac4b0217af7039fd2a5d8a4daea643c0073bc05f63cd34c58e8c4fae1856b081b91b771cf3c51e4291cc79fa7ff005aa4d54995401106258281e9d29bc91b95d4ae7bf4abc6d90372ce39e7041fe62ab9b7452c085f94e7000e6b4ba1b9752342c006508477a796447c70376782c0ff002ab221468f93825b8f941a059a3c5e680a486e72b8edf8d3b91745311468e1c70782dbaa431a1dac0a63b81d7f2a77941d4aa9edc8351a42426158824fad1715c956431afee9d73d0e7ad4a259cbee001233919edf855568363f017a753d6ae42bbd58127e56c75a96d03b13a3dc90a72847b54aad3be70633838c544aa138dbd47041c526e8a4608c8d9eb92d9acdc88d895a36dd825011d4535a266f9c91cf2326992e9eb92448c0819e0d431c048c166e0f634ae5244854f6f5ea31d69e3683cb0271db34d11a82465b39ea4d201b570c738e952d9a451fffd9, 0, '2016-07-04'),
(5, 'C', 'C', 'Cashier', '', '2016-07-10', '', 0, '', '', '', '', '', '', 0, 0xffd8ffe000104a46494600010101006000600000ffdb004300080606070605080707070909080a0c140d0c0b0b0c1912130f141d1a1f1e1d1a1c1c20242e2720222c231c1c2837292c30313434341f27393d38323c2e333432ffdb0043010909090c0b0c180d0d1832211c213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232ffc0001108006e006e03012200021101031101ffc4001f0000010501010101010100000000000000000102030405060708090a0bffc400b5100002010303020403050504040000017d01020300041105122131410613516107227114328191a1082342b1c11552d1f02433627282090a161718191a25262728292a3435363738393a434445464748494a535455565758595a636465666768696a737475767778797a838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae1e2e3e4e5e6e7e8e9eaf1f2f3f4f5f6f7f8f9faffc4001f0100030101010101010101010000000000000102030405060708090a0bffc400b51100020102040403040705040400010277000102031104052131061241510761711322328108144291a1b1c109233352f0156272d10a162434e125f11718191a262728292a35363738393a434445464748494a535455565758595a636465666768696a737475767778797a82838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae2e3e4e5e6e7e8e9eaf2f3f4f5f6f7f8f9faffda000c03010002110311003f00f4ea426969a6bb4f186d14525021d45251400ea4a4c9a3340c76692928a402d2d3734500482908a052d2181a61a0b0a8cb0aa403b3499a6eea4dc29889334533751ba801f9a5cd47b851b852024cd26699b8505a8b00fa5cd47ba8dd40c981a7678a84353c3521dc84bd465ea22f44e3cb68941cb3a2b607bf4157a21a8b7b0fdf47982a2995a12aad90c57241ed4c52589c761934f4b5c5caf62c6f1eb4be6555120ed4799458562d6f1eb46f155b7d1be8b058b1be8df55bcca37d161d8b3be943d55de68127bd2b058b81e9e1b8aa424a955e9342656691541676c281926b2bc47e20b1d5350b796c77858e111ee65e8413cf1d7b579cbddeb2c086bcb9231cfef4e3e9d6aba1d4a353e5cb2a7d1f03f9d743c3a96ad8e38870f84f499b5a2e4323b6d55000688ff4ab4fe28b38e4792dad268f29b572e783dcf4af2f13eac8b91793819e7131ff001a63cfaab820ddccc07fd353c50b0cbbfe20f117edf71e850f896e6f2fe2b66469773637364607735b7bfdebc7964d462937add488c38056520ff3a9bedbab67fe4213f3ff004d8d5fb1f325d55b9eb7ba8dd5e466fb5507fe4233ff00dfe349f6fd5338fb7cff00f7f8d3f62fb8bda23d737d287c1eb5e40d7fa98ff9884e48ff00a6c69bfda3a9f4fb7dc7fdfd34bd8bee3f6a8f602fef46ec57901d4753079beb8ffbfa7fc698351d4b247dba7c0ffa6a697b07dc7ed11ec81cd49bb8af191a86a1bb8bd9ff00efe9ff001a5fed1d4719fb5ce7feda9ff1a5ec5f70e74683c1641f6e38c704467afe75098206e40619ebf21ff1ab851c30f9df8efbb19a87ca908cef62474e7a56f63cbfada2a3410293f2e7fed99ff1a5f2e12c0796dcf39f2ce47eb560c12138691bdce4d060719c48c09e8734c1e2a254d9001ca3123a7eef93fad1b2107fd5b9edcc5ffd7ab7e4394c191fa63af6a0dbca5b779d2023fda340feb512b85b7f94796dd30498fbfe74c290803e4ef9c08cf4fceadf9121eb2be7b734ef218f2647cffbd4c5f5a89402db6fc16c8ebf70ff008d3fc9b66380c300f743565ad8e08c9e7af34a607c01e637e75257d6a05168a2e7076e3fd8cd482ce223e5903023fbbffd7ab22d4ab12246e7fda340b7653f2ca47ae5a82beb3023fece5c0c02467b01fe34f3a6e064119fa7ff005ea416ef9ff5ad827a64f341b57c67cc627eb50efdc7f5a88a6e9b1d416232323ad47f6d6407805bae28c203f30c30eb8c53563898e7cb185e8c3a1a9e660e952ec1f6c90a8608bcf726905dbb63f7a9bfb8278a4f2d07f08cf5e076a6feed97ee0e7b81d28e662f674ff9479b86c29326770ec31479bb4aee95b6b1ea013c53446aa41da303b9cf34f544da58a838ea7b1a2ec7cb05d04defb81590153c0c52f98ab26d32fe47a71498476ce33b476c53b0ac819b903d4d1717bbd8424b02be66d20fa9a6977e33216e32467ad4a89b864edda4f009a61890b1d9853dc9e295ca5cbd86f984a8dd85e327273c53d048d3670bb303e6dc334f11960542e30339c534dbed6dc7ee9ea0704d2b8fddec3886790382c5475da6a50a53077be0fa91914c4b71e5926338238c707f3a93cb644184e0ff00781a96d8d28f626f250025863dcf4a896d03303b1481d30b8ad13852a428e6a39241b7eee38c82295ce773914decc3fde8f3ec474a67d9ce481173dfde896e9d642bb89f4a8935072a0e3a678f5a6169b261077f2f93ea334c16ea3ac7d39c8a9d6f972008f231c9279a745791c9c790a36d02bc915d6dd3aaa004f727a51f6489b3bd51875e957e3781fe668412ded4d91e0518310c7d28b8bda329ec88a8201041c0e718347d9e3259bef1f5cd58125b9cfeeb20fa8ffebd5792ea359c26d6521b036814ae5a9362bc4b202a5467e94a902e576850149e94f32479190dc8eb81c544d791a101449c8cf5c50526cb040504051f2f3e94e421a3e037272723350a10f10943383df241a549d1948fde1c1e492293345b1fffd9, 0, '2016-07-10'),
(7, 'Rom', 'r', 'Rom', '', '2016-07-13', '', 0, '', '', '', '', '', '', 0, 0xffd8ffe000104a46494600010101000000000000ffdb0043000604040405040605050609060506090b080606080b0c0a0a0b0a0a0c100c0c0c0c0c0c100c0e0f100f0e0c1313141413131c1b1b1b1c1f1f1f1f1f1f1f1f1f1fffdb0043010707070d0c0d181010181a1511151a1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1f1fffc000110800c800c803011100021101031101ffc4001c0001000300030101000000000000000000000506070203040801ffc4003e1000020103020205060c050500000000000001020304050611122113314161810714223271912336424351526283a1b1b3c124728292c2337374a2b2ffc4001a010100030101010000000000000000000000040506030102ffc4002d11010001030203080105010100000000000001020304051131415112132122323361b181717291a1d15223ffda000c03010002110311003f00b31b362000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000003b295bdc56dfa2a53a9b75f045cbf23c9aa238cbea2999e10e72b0be8ae295bd58a5d6dc2497e4791729eb0f66dd5d25d07d3e0000000000000000000000000000000000012384d3f93ccdc743654f78c76e96b4b94209fd67fb759c6fe4516a37a922c63577676a61a4e0fc9e6171ea352e979f5cae6dd45f069f743abfbb728afea372bf08f2c2fb1f4cb7478d5e6959e9d3a74e0a14e2a105d518a492f04409999e2b08888e0e478f5e4bcc462ef53577694abefdb3845bf07b6e8e945eae8f4ccc3957668afd5112ad64fc99612e139594e76553b126ea53f749f17fd89f6b54b94fabcc81774ab757a7caa566b4567712a552a52e9ed975d7a3bca297da5eb47c56c5ad8ceb773c22769f954dfc0b96fc66378eb08125a100000000000000000000000000002674be9ab9cedf74516e9dad2da5735f6f553ea8afb4fb08b97951669df9f24bc4c59bd56dca38b61c763acf1d690b4b4a6a951a6b925d6df6b6fb5bfa4ccdcb9557576aae2d45ab54d14f6698f07a4f874000000000cebca469bb4b6a54b2b674952e39f4775082da2dc96f19edd4bab665de9993555334553bf4516a98b4d3115d31b75504b852800000000000000000000000024db492ddbe4920370d3785a587c450b38a5d2a5c57135f2aa4bd67fb2ee329937e6ed7357f0d7e2d88b54453fcfea9323a40000000000086d656aae74c6420d6fc149d55ddd1353ff1256157d9bb4febf6899d476acd51f1f4c54d4b260000000000000000000000003dfa7e8aad9dc7d26b78cee69292eee35bfe071c8ab6b754fc4bbe353bdca63e61ba1926c0000000000000e9bda3d3d9d7a3d7d2d39c36fe68b47d5156d544be2e53bd331f0c08d8b160000000000000000000000002534afc64c6ff00c8a7ff00a23e5fb557e89387eed3fac36f328d700000000000000301bba6a9dd56a6baa15251e5d5c9b46c689de2258aae36aa61d47d3e4000000000000000000000024b4ccf8351631edbff0015497be697ee70ca8ded55fb65231676bb4fee86e264daf000000000000006159e8286772305cd46eab2dfd95246bb1e77b74fed8fa63b2236b957ee9fb784eae20000000000000000000000178d05a361791a798bd725461538ad6947971ca0fd693fa149153a866f67c94f1e6b8d3b062aff00d2ae1c9a5944bf00000000000000667aff00482b4955ccda4a52a35aa395dd3973e09d496fc49fd5727b17da76676b6b757188f067f52c2ecef729e133e2a416aa800000000000000000000000d9b43dcd1afa62c7a26be0e2e9d44bb2716f7dff00332f9d4cc5eab76af02a89b34ec9d2226000000000000002035e5cd0a3a5ef1556b7aaa34e9c5f6cdc935b7b36dfc099a7d3337a36e485a8d5116677e6c6cd3b2a000000000000000000000012d80d4d94c1d594ad24a54aa6dd2d0a8b784b6ede5b34fbd11f23168bb1e6e2938d975d99f2f0e8d7b03958e57136d7ea2a0eb45b9413df6945b8c97bd19ac8b5ddd734f46a31ef7794455d5ef38bb00000000000f166b251c662aeaf9a52e820e518be49c9f28af193475b16bbcae29eae37eef7744d5d18f67f5264b375e352ee4a34e9ff00a5421ba8477ee7beefbd9a6c7c6a2d46d4b2f93955de9dea4512118000000000000000000000000693e4b327d259dd63a6fd2a1255a927f567ca497b24bf128f56b5b551575f05fe91777a668e9e2bd150b80000000000148f2a39454b1f6f8d83f4ee67d2545f629f56fed93fc0b6d2ad6f54d7d151abdeda98a3ab332f59f0000000000000000000000000025b4ae61e27396f7527b516fa3b8ff6e7c9fbbd6f023e5d9ef2dcc73e495877fbbb91572e6db534d269ee9f34d1946b4000000003f273842129cda8c229ca527c924b9b6cf62377933b312d4f99798ccd7bc5bf43bf05ba7d94e3ca3efebf13558b63bbb714f3e6c965dfef6e4d5cb97e88a24230000000000000000000000000000357f279a8164315e635a7bddd9251e7d72a5d507fd3eabf033ba8e3f62bed470abeda5d3327b747667d54fd2d8572c8000000145f28fa9951a0f0d6b3f86aa93bc92f9307cd43db2edeef696fa662ef3de4f08e0a7d532f68eee9e33c59b178a0000000000000000000000000000073a16f5ee2b468d0a72ab566f68538272937dc91e5554531bcf07d534cd53b478cb49d15a1ef31b730c9df5574ae126a16b4da6b692d9f48f9a7ec5ef28f3b3e9ae3b14c7875ff0017d81a7d56e7b754ed3d3fd5dca95b8000006b74d6fb77a0322d55a3f358eb8ad79372bdb6a927395dae725bbdfe11767b7a8d2e266dbae229f4cf4ff198ccc2b944cd5ea8ebfeab24e578000000000000000000000000e54a955ab5234e942552a49ed184536dbee484cc446f2f622667685b707e4df2d79c35720fcc6ddf3e06b7aad7f2fc9f1f715b7f53a29f0a7cd3fd2cf1f4baebf1abcb1fdb42c369dc4e1e9705951519b5b4eb4bd2a92f6cbf65c8a5bf935dd9f34aeec63516a3cb092382400000000000ade6f4160f26e5569c3ccee5f3e968a5c2dfda8753f0d89d6350b96fc27cd1f28191a75bb9e31e59f85132fa075063f79c2979e505f39437934bbe1eb7bb72decea16ebe7d99f9535fd3aed1c23b51f0adca328c9c649a927b34f934d139040f00000000000000049b7b2e6df5202c18ad0ba8b2294d5bf9b517f3b71e87ba3b39fe043bb9f6a8e7bcfc2759d3eed7cb68f95b31de4b31d4b695fdd54b897d4a695387b1bf4a4ff02bae6ab54fa636595ad2288f54effd2d58ec2e2b1b0e1b1b5a743b1ca2b793f6c9ef27e2caeb97ebafd53bacad58a2dfa6367b4e4ea0000000000000000023f29a7b0d948bf3db58549edb2abb70d45fd71da477b5915dbf4cb85dc6b773d50a7e53c95c5f14f1777b7d146e16ebfbe2bfc4b2b5ab7fdc7f0abbda47fc4ff2a86534c67719bbbbb49c69af9e87a74f6fe68ee9789656b2addcf4cab2f625cb7ea845921180000000024b0181bdcd5f2b5b6da292e2ab5a5eac23f4bfd91c323229b54ef2918f8f55dabb30d5f05a470d8784654692ab7497a575516f3dfecf647c0cee46657778cf8746931f0addae11bcf54d1152c00000000000000000000000000010796d17a7f26a52a96ca8d67f3f436a72dfe9697a2fc512ece6ddb7c2778f943bd836ae718da7e19bea9d2179829c6a71f4f6551ed4eba5b34feacd73d9fe65e6266537bc3854a1cbc2aaccefc69ea802621000001ac7936c7d1a1a7617514ba5bc9ce53976ed0938457870b7e267753b933776e54b4ba5db8a6d76b9d4b595cb200000000000000000000000000000001e0cfe3a191c35dd9ca3c4ea539747dd38ade0ff00b923b63dcec57153864daeddb9a7e1859ad63c00000d8b407c51b0fbdfd69999d43deabf1f50d4e9bec53f9fb9584849c0000000000000000000000000000000007cf86cd8800000362d01f146c3ef7f5a666750f7aafc7d4353a6fb14fe7ee56121270000000000000000000000000000000001f3e1b362000000d8b407c51b0fbdfd69999d43deabf1f50d4e9bec53f9fb9584849c0000000000000000000000000000000007cf86cd8800000362d01f146c3ef7f5a666750f7aafc7d4353a6fb14fe7ee56121270000000000000000000000000000000001f3e1b362003ffd9, 0, '2016-07-13');

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=20 ;

--
-- Dumping data for table `foodingredient`
--

INSERT INTO `foodingredient` (`ingredientid`, `foodid`, `itemid`, `buildID`, `unit`, `quantity`) VALUES
(1, 2, 1, 1, 'SLICE', 3.000),
(2, 2, 1, 2, 'SLICE', 3.000),
(3, 2, 3, 2, 'TBSP', 2.000),
(4, 6, 8, 3, 'KG', 0.250),
(5, 6, 4, 3, 'TSP', 0.500),
(6, 6, 8, 4, 'KG', 0.260),
(7, 5, 9, 5, 'PCS', 0.250),
(8, 5, 4, 5, 'TSP', 0.250),
(9, 5, 9, 6, 'PCS', 0.250),
(10, 5, 10, 6, 'TSP', 1.000),
(11, 5, 1, 6, 'SLICE', 3.000),
(12, 5, 9, 7, 'PCS', 0.250),
(13, 5, 10, 7, 'TSP', 1.000),
(14, 5, 1, 7, 'SLICE', 3.000),
(15, 7, 9, 8, 'PCS', 1.000),
(16, 5, 9, 9, 'PCS', 0.250),
(17, 5, 10, 9, 'TSP', 1.000),
(18, 5, 1, 9, 'SLICE', 3.000),
(19, 5, 9, 9, 'PCS', 1.000);

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
  `InitialQuantity` double(5,2) NOT NULL,
  `SaleStatus` tinyint(1) NOT NULL,
  `image` blob,
  PRIMARY KEY (`ItemID`),
  UNIQUE KEY `Description` (`Description`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=35 ;

--
-- Dumping data for table `items`
--

INSERT INTO `items` (`ItemID`, `Barcode`, `Description`, `Brand`, `Price`, `UnitValue`, `UnitType`, `Category`, `ItemType`, `InitialQuantity`, `SaleStatus`, `image`) VALUES
(1, '1234123', 'CREAM BREAD(INGREDIENT)', 'YELLOW FIN', 0.0000, '25', 'SLICE', 'INGREDIENT', 1, 0.00, 0, NULL),
(2, '1', 'PEANUT BUTTER SANDWICH', NULL, 15.0000, '', '', '', 2, 0.00, 1, NULL),
(3, '41234231', 'PEANUT BUTTER', 'NESTLE', 0.0000, '350', 'MG', 'INGREDIENT', 1, 0.00, 0, NULL),
(4, '7845415', 'GINISA MIX CHICKEN', '', 0.0000, '35', 'G', 'INGREDIENT', 1, 0.00, 0, NULL),
(5, '3', 'EGG SANDWICH', NULL, 20.0000, '', '', '', 2, 0.00, 1, NULL),
(6, '4', 'CHICKEN ADOBO', NULL, 25.0000, '', '', '', 2, 0.00, 1, NULL),
(7, '5', 'CHICKEN CURRY', NULL, 25.0000, '', '', '', 2, 0.00, 1, NULL),
(8, '', 'CHICKEN RAW', '', 0.0000, '1', 'KG', 'INGREDIENT', 1, 0.00, 0, NULL),
(9, '', 'EGG RAW', '', 0.0000, '1', 'PCS', 'INGREDIENT', 1, 0.00, 0, NULL),
(10, '5681215', 'MAYONASE', '', 0.0000, '385', 'MG', 'INGREDIENTS', 1, 0.00, 0, NULL),
(13, '121352', 'WAFFER BISCUITS', 'NISSIN', 7.5000, '1', 'pcs', 'BISCUITS', 0, 0.00, 0, NULL),
(14, '22423', 'RC SODA COLA 250ML', 'RC', 11.5000, '', 'pcs', 'BEVERAGE', 0, 0.00, 1, NULL),
(15, '38524', 'COKE LIGHT 300ML', 'COCA-COLA', 67.5000, '', 'pcs', 'BEVERAGE', 0, 0.00, 1, NULL),
(16, '4681', 'COKE REGULAR SODA 1.5L', 'COCA-COLA', 47.0000, '', 'pcs', 'BEVERAGE', 0, 0.00, 1, NULL),
(17, '4669', 'COKE REGULAR 330ML', 'COCA-COLA', 64.5000, '', 'pcs', 'BEVERAGE', 0, 0.00, 1, NULL),
(18, '112481', 'COKE ZERO IN CAN 330ML', 'COCA-COLA', 64.5000, '', 'pcs', 'BEVERAGE', 0, 0.00, 1, NULL),
(19, '112483', 'COKE ZERO SODA 1.5L', 'COCA-COLA', 145.5000, '', 'pcs', 'BEVERAGE', 0, 0.00, 1, NULL),
(20, '32941', 'MUG ROOT BEER IN CAN 330ML', 'MUG', 63.0000, '', 'pcs', 'BEVERAGE', 0, 0.00, 1, NULL),
(21, '32922', 'PEPSI REGULAR SODA IN CAN 330ML', 'PEPSI', 63.0000, '', 'pcs', 'BEVERAGE', 0, 0.00, 1, NULL),
(22, '4672', 'ROYAL REGULAR 330ML', 'COCA-COLA', 64.5000, '', 'pcs', 'BEVERAGE', 0, 0.00, 1, NULL),
(23, '4682', 'ROYAL ORANGE SODA 1.5L', 'COCA-COLA', 48.5000, '', 'pcs', 'BEVERAGE', 0, 0.00, 1, NULL),
(24, '4671', 'SPRITE REGULAR 330ML', 'COCA-COLA', 64.5000, '', 'pcs', 'BEVERAGE', 0, 0.00, 1, NULL),
(25, '4683', 'SPRITE REGULAR SODA 1.5L', 'COCA-COLA', 48.5000, '', 'pcs', 'BEVERAGE', 0, 0.00, 1, NULL),
(26, '32940', 'MOUNTAIN DEW REGULAR SODA IN CAN 330ML', 'PEPSICO', 63.0000, '', 'pcs', 'BEVERAGE', 0, 0.00, 1, NULL),
(27, '71225', 'MOUNTAIN DEW REGULAR SODA 1.5L', 'PEPSICO', 47.5000, '', 'pcs', 'BEVERAGE', 0, 0.00, 1, NULL),
(28, '4690', 'COKE REGULAR SODA 2L', 'COCA-COLA', 53.0000, '', 'pcs', 'BEVERAGE', 0, 0.00, 1, NULL),
(29, '4691', 'SPRITE ORANGE SODA 2L', 'COCA-COLA', 53.0000, '', 'pcs', 'BEVERAGE', 0, 0.00, 1, NULL),
(30, '4693', 'ROYAL REGULAR SODA 2L', 'COCA-COLA', 53.0000, '', 'pcs', 'BEVERAGE', 0, 0.00, 1, NULL),
(31, '60847', 'CRUNCH CHOCOLATE BAR SINGLES 43.9G', 'NESTLE', 45.0000, '', 'pcs', 'SNACK', 0, 0.00, 1, NULL),
(32, '20', 'RICE', '', 15.0000, '1', 'CUP', 'EXTRA', 0, 0.00, 1, NULL),
(33, '152364', 'Pineapple Can', 'Dole', 50.0000, '355', 'pcs', 'BEVERAGE', 0, 0.00, 1, NULL),
(34, '3478273', 'COKE 8oz', 'COCA-COLA', 15.0000, '360', 'ML', 'BEVERAGE', 0, 0.00, 1, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `job`
--

CREATE TABLE IF NOT EXISTS `job` (
  `JobGradeID` int(10) NOT NULL AUTO_INCREMENT,
  `JobDescription` varchar(30) NOT NULL,
  `Salary` double(10,2) NOT NULL DEFAULT '0.00',
  PRIMARY KEY (`JobGradeID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `job`
--

INSERT INTO `job` (`JobGradeID`, `JobDescription`, `Salary`) VALUES
(1, 'Manager', 250.00),
(2, 'Cashier', 210.00),
(3, 'Cook', 260.00);

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=20 ;

--
-- Dumping data for table `jobdtr`
--

INSERT INTO `jobdtr` (`DTRID`, `EmpID`, `dateTimeIn`, `dateTimeOut`, `DTRStatus`) VALUES
(1, 1, '2016-07-03 03:45:54', '2016-07-03 03:49:19', 0),
(2, 1, '2016-07-03 03:47:31', '2016-07-03 04:07:46', 0),
(4, 1, '2016-07-03 04:08:09', '2016-07-03 04:08:20', 0),
(5, 1, '2016-07-03 04:10:05', '2016-07-03 04:11:18', 0),
(6, 1, '2016-07-03 04:11:30', '2016-07-03 04:12:37', 0),
(7, 2, '2016-07-03 04:11:47', '2016-07-03 04:12:42', 0),
(8, 2, '2016-07-03 04:12:46', '2016-07-12 02:55:44', 0),
(9, 1, '2016-07-03 04:12:49', '2016-07-04 05:37:18', 0),
(10, 1, '2016-07-04 05:37:35', '2016-07-04 06:06:50', 0),
(11, 1, '2016-07-04 06:06:58', '2016-07-04 09:35:25', 0),
(12, 1, '2016-07-04 09:36:13', '2016-07-04 09:43:57', 0),
(13, 1, '2016-07-04 11:15:45', '2016-07-13 04:01:32', 0),
(14, 2, '2016-07-12 02:55:50', '2016-07-13 03:57:28', 0),
(15, 3, '2016-07-13 11:08:29', '2016-07-13 16:08:04', 0),
(16, 3, '2016-07-13 16:08:09', NULL, 0),
(17, 7, '2016-07-13 16:08:41', '2016-07-13 16:09:15', 0),
(18, 7, '2016-07-13 16:15:12', NULL, 0),
(19, 2, '2016-07-21 14:17:09', NULL, 0);

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
  `price` int(11) NOT NULL,
  `status` tinyint(4) DEFAULT '0' COMMENT '"0"=Pending "1"=Given',
  PRIMARY KEY (`orderlineID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Dumping data for table `orderline`
--

INSERT INTO `orderline` (`orderlineID`, `orderid`, `ItemID`, `buildid`, `quantity`, `price`, `status`) VALUES
(1, 1, 18, 0, 1.00, 65, 0),
(2, 1, 27, 27, 2.00, 48, 0),
(3, 2, 14, 0, 1.00, 12, 0),
(4, 2, 6, 4, 1.00, 25, 0),
(5, 3, 20, 0, 1.00, 63, 0),
(6, 3, 7, 8, 1.00, 25, 0),
(7, 3, 32, 0, 1.00, 15, 0),
(8, 4, 34, 34, 5.00, 15, 0);

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
  PRIMARY KEY (`OrderID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`OrderID`, `CustomerID`, `tableNum`, `OrderDate`, `Discount`, `PaymentAmt`, `EmpID`, `OrderStatus`) VALUES
(1, NULL, 2, '2016-07-22 22:33:38', 0, 159.50, 1, 1),
(2, NULL, 1, '2016-07-22 22:34:20', 0, 36.50, 1, 1),
(3, NULL, 5, '2016-07-22 22:36:34', 0, 103.00, 1, 1),
(4, NULL, 5, '2016-07-23 11:55:17', 0, 75.00, 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `po`
--

CREATE TABLE IF NOT EXISTS `po` (
  `POID` int(11) NOT NULL AUTO_INCREMENT,
  `SupplierID` int(11) NOT NULL,
  `EmpID` int(11) NOT NULL,
  `PODate` date NOT NULL,
  `Status` tinyint(4) NOT NULL,
  `PODeliveryDate` date DEFAULT NULL,
  PRIMARY KEY (`POID`),
  KEY `SupplierID` (`SupplierID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=13 ;

--
-- Dumping data for table `po`
--

INSERT INTO `po` (`POID`, `SupplierID`, `EmpID`, `PODate`, `Status`, `PODeliveryDate`) VALUES
(1, 1, 1, '2016-07-10', 1, '2016-07-10'),
(2, 1, 1, '2016-07-10', 1, '2016-07-10'),
(3, 2, 1, '2016-07-11', 1, '2016-07-11'),
(4, 2, 1, '2016-07-11', 1, '2016-07-11'),
(5, 2, 1, '2016-07-11', 1, '2016-07-11'),
(6, 2, 1, '2016-07-11', 1, '2016-07-11'),
(7, 2, 1, '2016-07-11', 1, '2016-07-11'),
(8, 2, 1, '2016-07-11', 1, '2016-07-11'),
(9, 2, 1, '2016-07-11', 1, '2016-07-11'),
(10, 2, 1, '2016-07-11', 1, '2016-07-11'),
(11, 2, 1, '2016-07-11', 1, '2016-07-11'),
(12, 0, 1, '0000-00-00', 0, NULL);

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=22 ;

--
-- Dumping data for table `polist`
--

INSERT INTO `polist` (`POListID`, `POID`, `ItemID`, `Quantity`, `Cost`, `postatus`, `QuantityDelivery`, `DeliveryDate`) VALUES
(1, 1, 13, 25.00, 7.5, 0, NULL, '0000-00-00'),
(2, 2, 14, 24.00, 11.5, 0, NULL, '0000-00-00'),
(3, 2, 15, 10.00, 67.5, 0, NULL, '0000-00-00'),
(4, 2, 16, 12.00, 47, 0, NULL, '0000-00-00'),
(5, 2, 17, 24.00, 64.5, 0, NULL, '0000-00-00'),
(6, 2, 18, 12.00, 64.5, 0, NULL, '0000-00-00'),
(7, 2, 19, 12.00, 145.5, 0, NULL, '0000-00-00'),
(8, 2, 20, 10.00, 63, 0, NULL, '0000-00-00'),
(9, 3, 21, 24.00, 63, 0, NULL, '0000-00-00'),
(10, 3, 22, 24.00, 64.5, 0, NULL, '0000-00-00'),
(12, 4, 23, 12.00, 48.5, 0, NULL, '0000-00-00'),
(13, 4, 24, 24.00, 64.5, 0, NULL, '0000-00-00'),
(14, 5, 25, 12.00, 48.5, 0, NULL, '0000-00-00'),
(15, 6, 26, 24.00, 63, 0, NULL, '0000-00-00'),
(16, 7, 27, 12.00, 47.5, 0, NULL, '0000-00-00'),
(17, 7, 28, 12.00, 53, 0, NULL, '0000-00-00'),
(18, 8, 29, 12.00, 53, 0, NULL, '0000-00-00'),
(19, 9, 30, 12.00, 53, 0, NULL, '0000-00-00'),
(20, 10, 30, 12.00, 53, 0, NULL, '0000-00-00'),
(21, 11, 31, 24.00, 36.5, 0, NULL, '0000-00-00');

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`SupplierID`, `Company`, `Address`, `Contact`) VALUES
(1, 'KCC MALL OF GENSAN', '', ''),
(2, 'WALTER MART SUPERMARKET', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `UserID` int(30) NOT NULL AUTO_INCREMENT,
  `EmpID` int(30) NOT NULL,
  `Username` varchar(20) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Function` enum('Admin','Cashier','Manager','Cook') NOT NULL,
  PRIMARY KEY (`UserID`),
  UNIQUE KEY `Username_UNIQUE` (`Username`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`UserID`, `EmpID`, `Username`, `Password`, `Function`) VALUES
(1, 1, 'Admin', 'Admin', 'Admin'),
(2, 2, 'marlo', 'marlo', 'Admin'),
(4, 5, 'c', 'c', 'Cashier'),
(7, 7, 'rom', 'rom', 'Cook');

-- --------------------------------------------------------

--
-- Stand-in structure for view `vfoodusage`
--
CREATE TABLE IF NOT EXISTS `vfoodusage` (
`itemid` int(11)
,`buildid` int(255)
,`foodmenu` varchar(45)
,`description` varchar(45)
,`brand` varchar(45)
,`sum(ingredients.quantity)` double(20,3)
,`unit` varchar(7)
);
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
-- Structure for view `vfoodusage`
--
DROP TABLE IF EXISTS `vfoodusage`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vfoodusage` AS select `items`.`ItemID` AS `itemid`,`ingredients`.`buildID` AS `buildid`,(select `items`.`Description` from (`foodingredient` join `items`) where ((`items`.`ItemID` = `foodingredient`.`foodid`) and (`foodingredient`.`foodid` = `ingredients`.`foodid`)) group by `items`.`Description`) AS `foodmenu`,`items`.`Description` AS `description`,`items`.`Brand` AS `brand`,sum(`ingredients`.`quantity`) AS `sum(ingredients.quantity)`,`ingredients`.`unit` AS `unit` from ((`foodingredient` `ingredients` left join `orderline` on((`orderline`.`buildid` = `ingredients`.`buildID`))) join `items` on((`items`.`ItemID` = `ingredients`.`itemid`))) group by `ingredients`.`buildID`;

-- --------------------------------------------------------

--
-- Structure for view `vstockin`
--
DROP TABLE IF EXISTS `vstockin`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vstockin` AS (select `po`.`POID` AS `POID`,`polist`.`ItemID` AS `itemid`,`items`.`Barcode` AS `barcode`,`items`.`Description` AS `description`,`items`.`Price` AS `price`,`items`.`Category` AS `category`,`po`.`SupplierID` AS `supllierid`,`po`.`EmpID` AS `empid`,`po`.`PODate` AS `podate`,`po`.`Status` AS `status`,`po`.`PODeliveryDate` AS `podeliverydate`,`polist`.`POListID` AS `polistid`,`items`.`UnitType` AS `unittype`,`polist`.`Quantity` AS `quantity`,`polist`.`Cost` AS `cost` from ((`po` join `polist` on((`po`.`POID` = `polist`.`POID`))) left join `items` on((`items`.`ItemID` = `polist`.`ItemID`))));

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
