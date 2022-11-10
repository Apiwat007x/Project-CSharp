-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 10, 2022 at 05:37 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `myshop`
--

-- --------------------------------------------------------

--
-- Table structure for table `food`
--

CREATE TABLE `food` (
  `ID` int(11) NOT NULL,
  `name` text COLLATE utf8_unicode_ci NOT NULL,
  `price` int(11) NOT NULL,
  `amount` int(11) NOT NULL,
  `picture` text COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `food`
--

INSERT INTO `food` (`ID`, `name`, `price`, `amount`, `picture`) VALUES
(11, 'พิซซ่าซีฟู้ด', 159, 22, 'D:\\food\\1.png'),
(12, 'พิซซ่าเบคอน', 159, 29, 'D:\\food\\2.png'),
(13, 'พิซซ่าเปปเปอโรนี', 159, 22, 'D:\\food\\3.png'),
(14, 'พิซซ่าเห็ดทรัฟเฟิล', 159, 27, 'D:\\food\\4.png'),
(15, 'พิซซ่าค็อกเทลกุ้ง', 159, 29, 'D:\\food\\5.png'),
(16, 'นักเก็ตไก่', 59, 29, 'D:\\food\\ไก่.png'),
(17, 'ขนมปังอบกระเทียม', 49, 28, 'D:\\food\\ขนมปัง.png'),
(18, 'ทาร์ตไข่', 29, 20, 'D:\\food\\ทาร์ต.png'),
(19, 'ผักโขมอบชีส', 69, 28, 'D:\\food\\ผักโขม.png'),
(20, 'เฟรนฟราย', 49, 27, 'D:\\food\\เฟรนฟราย.png');

-- --------------------------------------------------------

--
-- Table structure for table `register`
--

CREATE TABLE `register` (
  `ID` int(11) NOT NULL,
  `username` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `name` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `surname` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `TEL` int(11) NOT NULL,
  `address` varchar(255) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `register`
--

INSERT INTO `register` (`ID`, `username`, `password`, `name`, `surname`, `TEL`, `address`) VALUES
(1, 'z', 'z', 'z', 'z', 123456789, 'ขอนแก่น'),
(2, 'title', 'title', 'apiwat', 'saengpara', 930878790, '32 หมู่ 5 ต.น้ำเที่ยง อ.คำชะอี จ.มุกดาหาร'),
(3, 'joji000', '123456789j', 'ชาคริต', 'ทิพวัฒน์', 930592001, '555/63 อ.เมือง ต.เมืองเก่า จ.ขอนแก่น 40000'),
(4, 'my', 'shop', 'ti', 'tle', 930878790, 'ขอนแก่น'),
(5, 'buy', 'sell', 'tii', 'tlee', 123456789, 'ขอนแก่น');

-- --------------------------------------------------------

--
-- Table structure for table `salehis`
--

CREATE TABLE `salehis` (
  `ID` int(11) NOT NULL,
  `username` text COLLATE utf8_unicode_ci NOT NULL,
  `name` text COLLATE utf8_unicode_ci NOT NULL,
  `amount` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `date` datetime NOT NULL,
  `status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `salehis`
--

INSERT INTO `salehis` (`ID`, `username`, `name`, `amount`, `price`, `date`, `status`) VALUES
(42, 'z', 'นักเก็ตไก่', 1, 59, '2022-09-29 16:16:47', 1),
(43, 'z', 'พิซซ่าเห็ดทรัฟเฟิล', 1, 159, '2022-09-29 16:16:50', 1),
(44, 'z', 'พิซซ่าเปปเปอโรนี', 1, 159, '2022-09-29 16:24:35', 1),
(45, 'z', 'พิซซ่าค็อกเทลกุ้ง', 1, 159, '2022-09-29 16:24:40', 1),
(46, 'z', 'พิซซ่าซีฟู้ด', 1, 159, '2022-09-29 16:24:43', 1),
(47, 'z', 'เฟรนฟราย', 1, 49, '2022-09-29 16:26:23', 1),
(48, 'z', 'ผักโขมอบชีส', 1, 69, '2022-09-29 16:26:25', 1),
(49, 'z', 'ขนมปังอบกระเทียม', 1, 49, '2022-09-29 16:26:27', 1),
(50, 'joji000', 'พิซซ่าซีฟู้ด', 1, 159, '2022-09-29 16:28:39', 1),
(51, 'joji000', 'ทาร์ตไข่', 1, 29, '2022-09-29 16:28:41', 1),
(52, 'joji000', 'พิซซ่าเปปเปอโรนี', 1, 159, '2022-09-29 17:14:15', 1),
(53, 'joji000', 'เฟรนฟราย', 1, 49, '2022-09-29 17:14:21', 1),
(54, 'z', 'พิซซ่าซีฟู้ด', 1, 159, '2022-10-03 20:19:13', 1),
(55, 'z', 'พิซซ่าเปปเปอโรนี', 1, 159, '2022-10-03 20:19:16', 1),
(56, 'z', 'พิซซ่าซีฟู้ด', 1, 159, '2022-10-03 22:21:04', 1),
(57, 'z', 'พิซซ่าเห็ดทรัฟเฟิล', 1, 159, '2022-10-03 22:21:06', 1),
(58, 'z', 'พิซซ่าซีฟู้ด', 1, 159, '2022-11-10 20:48:24', 1),
(59, 'z', 'พิซซ่าเปปเปอโรนี', 1, 159, '2022-11-10 20:48:34', 1),
(60, 'z', 'พิซซ่าเปปเปอโรนี', 1, 159, '2022-11-10 23:24:05', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `food`
--
ALTER TABLE `food`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `register`
--
ALTER TABLE `register`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `salehis`
--
ALTER TABLE `salehis`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `food`
--
ALTER TABLE `food`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `register`
--
ALTER TABLE `register`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `salehis`
--
ALTER TABLE `salehis`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=61;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
