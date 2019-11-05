-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: pdb9.awardspace.net
-- Generation Time: Oct 08, 2017 at 10:52 PM
-- Server version: 5.7.19-log
-- PHP Version: 5.5.38

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `1803541_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `accounts`
--

CREATE TABLE `accounts` (
  `ID` int(11) NOT NULL,
  `username` varchar(16) NOT NULL DEFAULT 'username',
  `hashPass` varchar(255) CHARACTER SET ascii COLLATE ascii_bin NOT NULL DEFAULT 'password' COMMENT 'This is the password hashed',
  `secretAns` varchar(255) NOT NULL COMMENT 'The secret answer',
  `secretQ` int(255) NOT NULL COMMENT 'Secret question'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `calendary`
--

CREATE TABLE `calendary` (
  `ID` int(11) NOT NULL COMMENT 'ID of the post',
  `DMY` int(255) NOT NULL COMMENT 'day month year combined into one number',
  `event` varchar(2048) NOT NULL COMMENT 'Event text',
  `eventType` int(255) NOT NULL COMMENT 'The type of the event',
  `username` varchar(255) NOT NULL COMMENT 'username of the user that posted the event'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `comments`
--

CREATE TABLE `comments` (
  `ID` int(10) UNSIGNED NOT NULL COMMENT 'Bug ID',
  `title` varchar(80) NOT NULL COMMENT 'Comment title',
  `body` varchar(5000) NOT NULL DEFAULT 'Description' COMMENT 'Comment body',
  `date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT 'Comment time stamp'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `feature_req`
--

CREATE TABLE `feature_req` (
  `ID` bigint(20) UNSIGNED NOT NULL COMMENT 'id of feature request',
  `req_title` varchar(255) NOT NULL COMMENT 'Title of the requested feature',
  `req_body` varchar(1023) NOT NULL COMMENT 'Body of the requested feature',
  `req_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Req feature timestamp'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `issues`
--

CREATE TABLE `issues` (
  `ID` bigint(20) UNSIGNED NOT NULL COMMENT 'id num of issue report',
  `is_title` varchar(255) NOT NULL COMMENT 'Title of the issue',
  `is_body` varchar(1023) NOT NULL COMMENT 'Body of issue',
  `is_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT 'is_timestamp for tracking purposes'
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COMMENT='Reported issues table';

-- --------------------------------------------------------

--
-- Table structure for table `posts`
--

CREATE TABLE `posts` (
  `ID` int(11) NOT NULL COMMENT 'ID of the entry',
  `original` varchar(1000) NOT NULL,
  `translation` varchar(1000) NOT NULL,
  `P_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `imgURL` varchar(1023) NOT NULL COMMENT 'URL for an image',
  `voURL` varchar(1023) NOT NULL COMMENT 'URL for the VO'
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COMMENT='Table to be used with definitionary';

-- --------------------------------------------------------

--
-- Table structure for table `updates`
--

CREATE TABLE `updates` (
  `ID` int(11) NOT NULL COMMENT 'ID of the entry',
  `updateText` varchar(2092) CHARACTER SET armscii8 COLLATE armscii8_bin NOT NULL,
  `imgurl` varchar(1000) CHARACTER SET armscii8 COLLATE armscii8_bin NOT NULL DEFAULT 'img/nkLogo.png' COMMENT 'link to an image associated with an update',
  `uDate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COMMENT='Table to be used site updates';

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accounts`
--
ALTER TABLE `accounts`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `calendary`
--
ALTER TABLE `calendary`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `comments`
--
ALTER TABLE `comments`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `feature_req`
--
ALTER TABLE `feature_req`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `ID` (`ID`);

--
-- Indexes for table `issues`
--
ALTER TABLE `issues`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `ID` (`ID`);

--
-- Indexes for table `posts`
--
ALTER TABLE `posts`
  ADD PRIMARY KEY (`ID`) COMMENT 'ID of the entry';

--
-- Indexes for table `updates`
--
ALTER TABLE `updates`
  ADD PRIMARY KEY (`ID`) COMMENT 'ID of the entry';

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accounts`
--
ALTER TABLE `accounts`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;
--
-- AUTO_INCREMENT for table `calendary`
--
ALTER TABLE `calendary`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID of the post', AUTO_INCREMENT=48;
--
-- AUTO_INCREMENT for table `comments`
--
ALTER TABLE `comments`
  MODIFY `ID` int(10) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Bug ID', AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `feature_req`
--
ALTER TABLE `feature_req`
  MODIFY `ID` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'id of feature request';
--
-- AUTO_INCREMENT for table `issues`
--
ALTER TABLE `issues`
  MODIFY `ID` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'id num of issue report';
--
-- AUTO_INCREMENT for table `posts`
--
ALTER TABLE `posts`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID of the entry', AUTO_INCREMENT=109;
--
-- AUTO_INCREMENT for table `updates`
--
ALTER TABLE `updates`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT COMMENT 'ID of the entry', AUTO_INCREMENT=18;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
