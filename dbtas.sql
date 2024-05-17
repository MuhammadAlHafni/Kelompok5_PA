-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 17, 2024 at 06:15 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbtas`
--
CREATE DATABASE IF NOT EXISTS `dbtas` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `dbtas`;

-- --------------------------------------------------------

--
-- Table structure for table `keranjang`
--

CREATE TABLE `keranjang` (
  `orderid` int(11) NOT NULL,
  `username` varchar(25) NOT NULL,
  `merk` varchar(10) NOT NULL,
  `harga` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `keranjang`
--

INSERT INTO `keranjang` (`orderid`, `username`, `merk`, `harga`, `jumlah`) VALUES
(0, 'kevin', 'Tera', 100000, 14),
(0, 'kevin', 'Halena', 250000, 2);

-- --------------------------------------------------------

--
-- Table structure for table `tbtas`
--

CREATE TABLE `tbtas` (
  `kodeTas` int(11) NOT NULL,
  `Merk` text NOT NULL,
  `Harga` int(11) NOT NULL,
  `Bahan` text NOT NULL,
  `Ukuran` text NOT NULL,
  `Kategori` text NOT NULL,
  `Warna` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbtas`
--

INSERT INTO `tbtas` (`kodeTas`, `Merk`, `Harga`, `Bahan`, `Ukuran`, `Kategori`, `Warna`) VALUES
(8, 'Tera', 100000, 'Kulit', 'Panjang', 'Tasselempang', 'Hijau'),
(9, 'Halena', 250000, 'Kulit', 'Lebar', 'Ransel', 'Merah');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `username` varchar(25) NOT NULL,
  `password` varchar(100) NOT NULL,
  `status` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `username`, `password`, `status`) VALUES
(1, 'admin', 'admin', 'admin'),
(2, 'kevin', '131', 'user');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbtas`
--
ALTER TABLE `tbtas`
  ADD PRIMARY KEY (`kodeTas`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbtas`
--
ALTER TABLE `tbtas`
  MODIFY `kodeTas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
