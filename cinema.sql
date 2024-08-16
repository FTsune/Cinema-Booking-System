-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 13, 2022 at 10:17 AM
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
-- Database: `cinema`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`username`, `password`) VALUES
('admin', 'pass');

-- --------------------------------------------------------

--
-- Table structure for table `movie`
--

CREATE TABLE `movie` (
  `title` varchar(100) NOT NULL,
  `company` varchar(100) NOT NULL,
  `producer` varchar(100) NOT NULL,
  `director` varchar(100) NOT NULL,
  `genre` varchar(100) NOT NULL,
  `casts` varchar(100) NOT NULL,
  `date` date NOT NULL,
  `picture` varchar(150) DEFAULT NULL,
  `ticket` int(11) DEFAULT NULL,
  `price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `movie`
--

INSERT INTO `movie` (`title`, `company`, `producer`, `director`, `genre`, `casts`, `date`, `picture`, `ticket`, `price`) VALUES
('Black Panther: Wakanda Forever', 'Marvel Studios', 'Kevin Feige', 'Ryan Coogler', 'Action, Adventure', 'Letitia Wright, Tenoch Huerta', '2022-12-20', 'C:\\Users\\ADMIN\\Downloads\\Black_Panther_Wakanda_Forever_poster.jpg', 0, 360),
('Smile', 'Paramount Players, Temple Hill Entertainment', 'Marty Bowen, Wyck Godfrey', 'Parker Finn', 'Horror', 'Sosie Bacon, Jessie Usher, Kyle Gallner ', '2022-12-20', 'C:\\Users\\ADMIN\\Downloads\\Smile_(2022_film).jpg', 4, 300),
('Sonic the Hedgehog 2', 'SEGA Sammy Holdings', 'Neil H. Moritz', 'Jeff', 'Adventure, Comedy', 'Ben Schwartz, Jim Carrey', '2022-12-10', 'C:\\Users\\ADMIN\\Downloads\\Sonic_the_Hedgehog_2_film_poster.jpg', 9, 230),
('Spider-Man: No Way Home', 'Marvel Studios', 'Kevin Feige', 'The Russo Brothers', 'Sci-fi', 'Tom Holland, Zendaya', '2022-12-20', 'C:\\Users\\ADMIN\\Downloads\\spidermannwh.jpg', 17, 320),
('The Tunnel to Summer, The Exit of Goodbyes', 'CLAP', 'Ryoichiro Matsuo', 'Tomohisa Taguchi', 'Animation, Romance, Sci-Fi', 'Oji Suzuka, Marie Iitoyo, Tasuku Hatanaka', '2022-12-20', 'C:\\Users\\ADMIN\\Downloads\\The Tunnel to Summer.jpg', 25, 200),
('Uncharted', 'Columbia Pictures', 'Charles Roven, Alex Gartner, Avi Arad', 'Ruben Fleischer', 'Adventure, Action', 'Tom Holland, Sophia Taylor Ali, Mark Wahlberg', '2022-12-20', 'C:\\Users\\ADMIN\\Downloads\\Uncharted.png', 17, 250);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`username`, `password`, `email`) VALUES
('dhan', 'dhan', 'email@email.com'),
('Hero', 'hero', 'text@gmail.com'),
('reymer', 'pass', 'smaple'),
('usern', 'pass', 'email@g');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `movie`
--
ALTER TABLE `movie`
  ADD PRIMARY KEY (`title`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`username`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
