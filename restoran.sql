-- phpMyAdmin SQL Dump
-- version 3.2.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Jul 09, 2014 at 04:00 PM
-- Server version: 5.1.41
-- PHP Version: 5.3.1

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `restoran`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_menu`
--

CREATE TABLE IF NOT EXISTS `tbl_menu` (
  `id_menu` varchar(5) NOT NULL,
  `nama` varchar(20) NOT NULL,
  `kategori` varchar(5) NOT NULL,
  `harga` int(11) NOT NULL,
  PRIMARY KEY (`id_menu`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_menu`
--

INSERT INTO `tbl_menu` (`id_menu`, `nama`, `kategori`, `harga`) VALUES
('F01', 'Bakso Sapi', 'Food', 15000),
('D01', 'Susu Anget', 'Drink', 5000),
('F02', 'Soto Ayam', 'Food', 10000),
('D02', 'Es Teh', 'Drink', 2500),
('F03', 'Soto Sapi', 'Food', 12000);

-- --------------------------------------------------------

--
-- Table structure for table `transaksi`
--

CREATE TABLE IF NOT EXISTS `transaksi` (
  `id_transaksi` varchar(5) NOT NULL,
  `id_menu` varchar(5) NOT NULL,
  `jumlah_beli` int(10) NOT NULL,
  `jumlah_pesan` int(10) NOT NULL,
  `total_bayar` int(10) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `transaksi`
--

INSERT INTO `transaksi` (`id_transaksi`, `id_menu`, `jumlah_beli`, `jumlah_pesan`, `total_bayar`) VALUES
(' T-3', 'F01', 1, 1, 15000),
(' T-2', 'D02', 1, 1, 2500),
(' T-1', 'D02', 1, 1, 2500);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `id_user` varchar(5) NOT NULL,
  `nama_user` varchar(15) NOT NULL,
  `password` varchar(15) NOT NULL,
  `status` varchar(10) NOT NULL,
  PRIMARY KEY (`id_user`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id_user`, `nama_user`, `password`, `status`) VALUES
('U1', 'Aldy', 'Aldy', 'Admin'),
('U2', 'Nanda', 'Nanda', 'Admin'),
('U3', 'kasir', 'kasir', 'Kasir');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
