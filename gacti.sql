-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Nov 21, 2018 at 06:42 PM
-- Server version: 5.7.21
-- PHP Version: 5.6.35

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `gacti`
--

-- --------------------------------------------------------

--
-- Table structure for table `activite`
--

DROP TABLE IF EXISTS `activite`;
CREATE TABLE IF NOT EXISTS `activite` (
  `CODEANIM` char(8) NOT NULL,
  `DATEACT` date NOT NULL,
  `CODEETATACT` char(2) NOT NULL,
  `HRRDVACT` time DEFAULT NULL,
  `PRIXACT` decimal(7,2) DEFAULT NULL,
  `HRDEBUTACT` time DEFAULT NULL,
  `HRFINACT` time DEFAULT NULL,
  `DATEANNULEACT` date DEFAULT NULL,
  `NOMRESP` char(40) DEFAULT NULL,
  `PRENOMRESP` char(30) DEFAULT NULL,
  PRIMARY KEY (`CODEANIM`,`DATEACT`),
  KEY `I_FK_ACTIVITE_ANIMATION` (`CODEANIM`),
  KEY `I_FK_ACTIVITE_ETAT_ACT` (`CODEETATACT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `activite`
--

INSERT INTO `activite` (`CODEANIM`, `DATEACT`, `CODEETATACT`, `HRRDVACT`, `PRIXACT`, `HRDEBUTACT`, `HRFINACT`, `DATEANNULEACT`, `NOMRESP`, `PRENOMRESP`) VALUES
('COMMAM', '2018-11-17', 'AN', '02:39:03', '0.00', '04:39:03', '21:39:03', '2018-11-17', 'e', 'e'),
('COMMAM', '2018-11-18', 'VA', '11:44:11', '0.00', '12:44:11', '11:44:11', '2018-11-25', 'e', 'e'),
('COMMAM', '2018-11-21', 'VA', '14:44:20', '0.00', '14:44:20', '16:44:20', '2018-12-14', 'e', 'e'),
('COMMAM', '2018-11-24', 'VA', '14:47:07', '0.00', '17:47:07', '21:47:07', '2014-11-21', 'e', 'e'),
('COMMAM', '2018-12-14', 'VA', '13:02:09', '0.00', '13:02:09', '13:02:09', '2018-11-17', 'e', 'e'),
('HU', '2018-11-17', 'VA', '12:36:09', '0.00', '12:36:09', '12:36:09', '2018-11-17', 'e', 'e'),
('HU', '2018-11-18', 'VA', '09:40:45', '0.00', '09:40:45', '10:40:45', '2018-11-19', 'e', 'e'),
('HU', '2018-11-20', 'VA', '09:48:16', '0.00', '09:48:16', '09:48:16', '2018-11-18', 'e', 'e'),
('HU', '2018-11-21', 'VA', '14:45:55', '0.00', '15:45:55', '16:45:55', '2109-05-15', 'e', 'e'),
('HU', '2018-12-15', 'VA', '09:48:35', '0.00', '09:48:35', '09:48:35', '2018-11-14', 'e', 'e'),
('HU', '2019-01-11', 'VA', '10:10:07', '0.00', '10:10:07', '10:10:07', '2018-10-01', 'e', 'e'),
('HU', '2019-01-30', 'VA', '10:11:05', '0.00', '10:11:05', '10:11:05', '2018-11-18', 'e', 'e');

-- --------------------------------------------------------

--
-- Table structure for table `animation`
--

DROP TABLE IF EXISTS `animation`;
CREATE TABLE IF NOT EXISTS `animation` (
  `CODEANIM` char(8) NOT NULL,
  `CODETYPEANIM` char(5) NOT NULL,
  `NOMANIM` char(40) DEFAULT NULL,
  `DATECREATIONANIM` date DEFAULT NULL,
  `DATEVALIDITEANIM` date DEFAULT NULL,
  `DUREEANIM` double(5,0) DEFAULT NULL,
  `LIMITEAGE` int(2) DEFAULT NULL,
  `TARIFANIM` decimal(7,2) DEFAULT NULL,
  `NBREPLACEANIM` int(2) DEFAULT NULL,
  `DESCRIPTANIM` char(250) DEFAULT NULL,
  `COMMENTANIM` char(250) DEFAULT NULL,
  `DIFFICULTEANIM` char(40) DEFAULT NULL,
  PRIMARY KEY (`CODEANIM`),
  KEY `I_FK_ANIMATION_TYPE_ANIM` (`CODETYPEANIM`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `animation`
--

INSERT INTO `animation` (`CODEANIM`, `CODETYPEANIM`, `NOMANIM`, `DATECREATIONANIM`, `DATEVALIDITEANIM`, `DUREEANIM`, `LIMITEAGE`, `TARIFANIM`, `NBREPLACEANIM`, `DESCRIPTANIM`, `COMMENTANIM`, `DIFFICULTEANIM`) VALUES
('COMMAM', 'BABC', 'Haytoprz', '2018-11-17', '2020-11-17', 455, 3, '35000.00', 10, 'Brein ded, ay drop\n', 'Brein ded, ay drop\nBrein ded, ay drop\n', 'Facile'),
('HU', 'BBBB', 'The Hu', '2018-11-17', '2022-12-02', 120, 3, '10.00', 10, 'Hu hu hu hu hu', 'Hu hu hu hu hu\nHu hu hu hu hu\nHu hu hu hu hu\nHu hu hu hu hu\n', 'Facile'),
('LANYMATI', 'BABC', 'Une animation quelconque', '2018-11-17', '2020-11-17', 540, 14, '740.00', 2, 'Eit', 'Madafak ayyyyyy\nMadafak ayyyyyy\nMadafak ayyyyyy\nMadafak ayyyyyy\nMadafak ayyyyyy\nMadafak ayyyyyy\nMadafak ayyyyyy\nMadafak ayyyyyy\nMadafak ayyyyyy\nMadafak ayyyyyy\nMadafak ayyyyyy\nMadafak ayyyyyy\nMadafak ayyyyyy\nMadafak ayyyyyy\nMadafak ayyyyyy\n', 'Très difficile');

-- --------------------------------------------------------

--
-- Table structure for table `compte`
--

DROP TABLE IF EXISTS `compte`;
CREATE TABLE IF NOT EXISTS `compte` (
  `USER` char(8) NOT NULL,
  `MDP` char(10) DEFAULT NULL,
  `NOMCOMPTE` char(40) DEFAULT NULL,
  `PRENOMCOMPTE` char(30) DEFAULT NULL,
  `DATEINSCRIP` date DEFAULT NULL,
  `DATEFERME` date DEFAULT NULL,
  `TYPEPROFIL` char(2) DEFAULT NULL,
  `DATEDEBSEJOUR` date DEFAULT NULL,
  `DATEFINSEJOUR` date DEFAULT NULL,
  `DATENAISCOMPTE` date DEFAULT NULL,
  `ADRMAILCOMPTE` char(70) DEFAULT NULL,
  `NOTELCOMPTE` char(15) DEFAULT NULL,
  PRIMARY KEY (`USER`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `compte`
--

INSERT INTO `compte` (`USER`, `MDP`, `NOMCOMPTE`, `PRENOMCOMPTE`, `DATEINSCRIP`, `DATEFERME`, `TYPEPROFIL`, `DATEDEBSEJOUR`, `DATEFINSEJOUR`, `DATENAISCOMPTE`, `ADRMAILCOMPTE`, `NOTELCOMPTE`) VALUES
('e', 'e', 'e', 'e', '2016-10-02', '2020-10-02', 'E', '2017-10-11', '2018-10-03', '2000-10-10', 'e.e@e.e', '0123465789'),
('v', 'v', 'v', 'v', '2016-10-02', '2020-10-02', 'V', '2016-10-11', '2020-10-03', '2000-10-10', 'v.v@v.v', '0123465789'),
('v1', 'v1', 'v1', 'v1', '2016-10-02', '2014-10-02', 'V', '2016-10-11', '2020-10-03', '2000-10-10', 'v.v@v.v', '0123465789'),
('v2', 'v2', 'v2', 'v2', '2016-10-02', '2020-10-02', 'V', '2016-10-11', '2020-10-03', '2000-10-10', 'v.v@v.v', '0123465789');

-- --------------------------------------------------------

--
-- Table structure for table `etat_act`
--

DROP TABLE IF EXISTS `etat_act`;
CREATE TABLE IF NOT EXISTS `etat_act` (
  `CODEETATACT` char(2) NOT NULL,
  `NOMETATACT` char(25) DEFAULT NULL,
  PRIMARY KEY (`CODEETATACT`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `etat_act`
--

INSERT INTO `etat_act` (`CODEETATACT`, `NOMETATACT`) VALUES
('AN', 'Annulée'),
('EC', 'En cours'),
('VA', 'Valide');

-- --------------------------------------------------------

--
-- Table structure for table `inscription`
--

DROP TABLE IF EXISTS `inscription`;
CREATE TABLE IF NOT EXISTS `inscription` (
  `NOINSCRIP` bigint(6) NOT NULL AUTO_INCREMENT,
  `USER` char(8) NOT NULL,
  `CODEANIM` char(8) NOT NULL,
  `DATEACT` date NOT NULL,
  `DATEINSCRIP` date DEFAULT NULL,
  `DATEANNULE` date DEFAULT NULL,
  PRIMARY KEY (`NOINSCRIP`),
  KEY `I_FK_INSCRIPTION_COMPTE` (`USER`),
  KEY `I_FK_INSCRIPTION_ACTIVITE` (`CODEANIM`,`DATEACT`)
) ENGINE=InnoDB AUTO_INCREMENT=92418 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `inscription`
--

INSERT INTO `inscription` (`NOINSCRIP`, `USER`, `CODEANIM`, `DATEACT`, `DATEINSCRIP`, `DATEANNULE`) VALUES
(92415, 'v', 'HU', '2019-01-30', '2018-11-18', '2018-11-18'),
(92416, 'v', 'COMMAM', '2018-12-14', '2018-11-18', '2018-11-17'),
(92417, 'v', 'HU', '2018-11-21', '2018-11-18', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `type_anim`
--

DROP TABLE IF EXISTS `type_anim`;
CREATE TABLE IF NOT EXISTS `type_anim` (
  `CODETYPEANIM` char(5) NOT NULL,
  `NOMTYPEANIM` char(50) DEFAULT NULL,
  PRIMARY KEY (`CODETYPEANIM`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `type_anim`
--

INSERT INTO `type_anim` (`CODETYPEANIM`, `NOMTYPEANIM`) VALUES
('BABC', 'Babacool cyka blyat'),
('BBBB', 'Ibrouttre est boakfe');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `activite`
--
ALTER TABLE `activite`
  ADD CONSTRAINT `activite_ibfk_1` FOREIGN KEY (`CODEANIM`) REFERENCES `animation` (`CODEANIM`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `activite_ibfk_2` FOREIGN KEY (`CODEETATACT`) REFERENCES `etat_act` (`CODEETATACT`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `animation`
--
ALTER TABLE `animation`
  ADD CONSTRAINT `animation_ibfk_1` FOREIGN KEY (`CODETYPEANIM`) REFERENCES `type_anim` (`CODETYPEANIM`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `inscription`
--
ALTER TABLE `inscription`
  ADD CONSTRAINT `inscription_ibfk_1` FOREIGN KEY (`USER`) REFERENCES `compte` (`USER`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `inscription_ibfk_2` FOREIGN KEY (`CODEANIM`,`DATEACT`) REFERENCES `activite` (`CODEANIM`, `DATEACT`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
