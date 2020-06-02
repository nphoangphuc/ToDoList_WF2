-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jun 02, 2020 at 02:01 PM
-- Server version: 8.0.20
-- PHP Version: 7.4.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `task`
--

-- --------------------------------------------------------

--
-- Table structure for table `tasklist`
--

CREATE TABLE `tasklist` (
  `ID` int NOT NULL,
  `TITLE` varchar(255) CHARACTER SET utf32 COLLATE utf32_unicode_ci NOT NULL,
  `DESCRIPTION` text COLLATE utf32_unicode_ci,
  `CREATEDDATE` date DEFAULT NULL,
  `DUEDATE` date DEFAULT NULL,
  `ALARMDATE` date DEFAULT NULL,
  `ALARMTIME` varchar(255) COLLATE utf32_unicode_ci DEFAULT NULL,
  `TAGS` text COLLATE utf32_unicode_ci,
  `DONE` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_unicode_ci;

--
-- Dumping data for table `tasklist`
--

INSERT INTO `tasklist` (`ID`, `TITLE`, `DESCRIPTION`, `CREATEDDATE`, `DUEDATE`, `ALARMDATE`, `ALARMTIME`, `TAGS`, `DONE`) VALUES
(1, 'Get up', 'Get up early to do something', '2020-05-20', '2020-05-08', NULL, NULL, '#silly #work #goout #weekend', 0),
(2, 'Hang out', 'Go out with friends at the weekend', '2020-05-08', '2020-05-08', '2020-05-08', '14:33:31', '#goout #party #weekend', 0),
(3, 'Do Final Project', 'Finish the To-Do App', '2020-05-02', '2020-05-10', NULL, NULL, '#homework #project #wf #csharp', 0),
(4, 'Delete Task', 'Show number of task will be deleted and get confirmation', '2020-05-05', '2020-05-08', NULL, NULL, '#wf #task #project', 1),
(5, 'Done/Undone task 1', 'Done/Undone Singe task by click the done checkbox ', '2020-05-08', '2020-05-08', NULL, NULL, '#project #tassk #wf ', 1),
(6, 'Done/Undone Task 2', 'Done/Undone Selected Multiple Task by press the Done/Undone button', '2020-06-02', '2020-06-02', NULL, NULL, '#wf #task #final #project', 1),
(7, 'Search bar', 'Add the search bar to search task by tags', '2020-06-02', '2020-06-02', '2020-05-08', '17:45:21', '#wf #task #final #project', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tasklist`
--
ALTER TABLE `tasklist`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tasklist`
--
ALTER TABLE `tasklist`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
