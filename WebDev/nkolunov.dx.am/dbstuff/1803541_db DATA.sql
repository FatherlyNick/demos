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

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`ID`, `username`, `hashPass`, `secretAns`, `secretQ`) VALUES
(20, 'admin', '2ac9cb7dc02b3c0083eb70898e549b63', 'f05d088638558a99f3cf10d0d1534f76', 3),
(21, 'nkolunov', 'abe1a2ca3645b0d21abb22dac845c295', '66ea79e8e1b42a0f6ce633d91fabdd46', 2),
(22, 'testAdmin', '2ac9cb7dc02b3c0083eb70898e549b63', 'ab86a1e1ef70dff97959067b723c5c24', 4),
(23, 'admintest3', '2ac9cb7dc02b3c0083eb70898e549b63', 'ad4a3a3ff8316b36caef449fb5d4406a', 1),
(24, 'admintest4', '7df5222fb59b99c7c598bee2ef00b85e', '5852224209af6c972235378dec5e8951', 2),
(25, 'fkj', '202cb962ac59075b964b07152d234b70', 'f854f4f00f510def47cea82a6e50920b', 2),
(26, 'qwert', '202cb962ac59075b964b07152d234b70', 'f814d138a540de3f36f12effc43b1b02', 3),
(27, 'qwe', '202cb962ac59075b964b07152d234b70', '0fa8b4a5a7483dba25fd16408aa7a744', 2),
(28, 'qwe2', '202cb962ac59075b964b07152d234b70', '0fa8b4a5a7483dba25fd16408aa7a744', 2),
(29, 'qwe3', '202cb962ac59075b964b07152d234b70', '0fa8b4a5a7483dba25fd16408aa7a744', 2),
(30, 'qwe4', '202cb962ac59075b964b07152d234b70', 'a5c4e9fc27f36d3f81e0b212ee8f4dff', 2),
(31, 'qqwertyu', '76d80224611fc919a5d54f0ff9fba446', '6941b8148e40b59590e6183b86040dff', 2),
(32, 'sdfghjhg', '202cb962ac59075b964b07152d234b70', 'af0206072b5beed8bec98cc4b3f50eec', 3),
(33, 'cv', 'de3ec0aa2234aa1e3ee275bbc715c6c9', '1befe6808c3979eb8f926951eb158284', 3),
(34, 'qaz', 'de3ec0aa2234aa1e3ee275bbc715c6c9', '0470f8221d51c5e51e2ffffd815787da', 1),
(35, 'az2', 'cc8c0a97c2dfcd73caff160b65aa39e2', '6da45e5b290fb124d5468a1fdba4ffcf', 2),
(36, 'jhg', '3212f5f463edb370ff55d3c3a7a15c8f', 'c1d5e3b48c86738bccfb90a0632fe206', 3),
(37, 'test123', '2ac9cb7dc02b3c0083eb70898e549b63', 'cdf9104e8bf4a5df98688eb8715321fa', 1);

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

--
-- Dumping data for table `calendary`
--

INSERT INTO `calendary` (`ID`, `DMY`, `event`, `eventType`, `username`) VALUES
(26, 31122017, '*** Happy new year! ***', 0, ''),
(25, 882017, '*** Admin Birthday ***', 0, ''),
(24, 412017, 'test String 1234', 0, ''),
(37, 312017, 'test event\r\n1\r\n2\r\n3\r\n', 0, ''),
(36, 512017, 'test', 0, ''),
(35, 1212017, 'test0', 0, ''),
(34, 1212017, 'test2', 0, ''),
(33, 2812017, 'test2', 0, ''),
(32, 322017, 'test2', 0, ''),
(31, 612017, 'test2', 0, ''),
(30, 212017, 'lol', 0, ''),
(29, 312017, 'test2', 0, ''),
(28, 1112017, 'test2', 0, ''),
(27, 1112017, 'test', 0, ''),
(23, 112017, 'erfgtyhujyhgt', 2, ''),
(38, 312017, 'werfgd', 0, ''),
(39, 312017, 'wefdsdaf', 0, ''),
(40, 312017, 'erghjhgtrfedfgh', 0, ''),
(41, 312017, 'edfredws', 0, ''),
(42, 312017, 'esdgfhjmhgfh,.lk,m', 0, ''),
(43, 412017, 'gfhgfederfgthtyg,,../\'[P{[]', 0, 'admintest4'),
(44, 212017, 'ghhhytug', 0, 'fkj'),
(45, 412017, 'Test event', 0, 'admin'),
(46, 412017, 'test event 2\r\n\r\n\r\n7u8i8o7u', 0, 'admin'),
(47, 822017, 'line 1<br />\r\nline 2<br />\r\n<br />\r\nLine 4<br />\r\n<br />\r\n<br />\r\nWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW', 0, 'admin');

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

--
-- Dumping data for table `comments`
--

INSERT INTO `comments` (`ID`, `title`, `body`, `date`) VALUES
(1, 'Everything is on fire!', 'The room is on fire.', '0000-00-00 00:00:00');

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

--
-- Dumping data for table `posts`
--

INSERT INTO `posts` (`ID`, `original`, `translation`, `P_date`, `imgURL`, `voURL`) VALUES
(97, 'Sizzling', 'Electric noise', '2017-10-08 12:08:01', '', ''),
(108, 'Globalization \r\n\r\n(Held et al., 1999: 2)', 'Globalization can perhaps best be defined as\r\nthe â€œwidening, deepening and speeding up of worldwide interconnected-\r\nness in all aspects of contemporary social lifeâ€.', '2017-10-08 15:49:42', '', ''),
(107, 'img and vo test', '12345\r\n35345345rjiogjiotrio', '2017-10-08 12:51:08', 'img-urllol', 'VOurl-lol'),
(106, 'Pen', 'Tool for writing', '2017-10-08 12:34:23', 'https://i.imgur.com/KV8wwkV.jpg', '');

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
-- Dumping data for table `updates`
--

INSERT INTO `updates` (`ID`, `updateText`, `imgurl`, `uDate`) VALUES
(1, 'test update', '', '2017-08-07 20:16:23'),
(2, 'test update 2', '.', '2017-08-07 20:28:37'),
(3, 'This is the first update entry. Text strings 1234567890-=\r\n\r\n!"?$%^&*()_+?`\\|<>,.?/;\'#[]:@~{}', 'img/nkLogo.png', '2017-08-07 20:45:52'),
(4, 'Update from a form 1 TEST', '', '2017-08-08 21:40:59'),
(5, 'This is the first official update of nkolunov. As such, I will establish the format of the update. First, there needs to be a list things that are new. This is followed by an optional message from the admin and ended with an image which shows off the latest feature\r\n+ Front page updates now have an authenticated form.\r\n The key features are here. They include a custom dictionary where you can add a word pair, a calendar where a user can log their upcoming events and reminders. At the moment the site\'s appearance isn\'t exactly great. This will change soon as it is the next in line of things to be added/improved.', 'img/nkLogo.png', '2017-08-09 11:33:22'),
(6, 'line 1<br />\r\nline 2<br />\r\n<br />\r\nLine 4<br />\r\n<br />\r\n\\n newlinechar\\nn2\\nn3', '', '2017-08-09 11:37:47'),
(7, 'test 123<br />\r\n213456<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\newtrhhgghjghjghjWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW', 'img/nkLogo.png', '2017-08-09 11:41:56'),
(8, 'line1<br />\r\nline2<br />\r\n<br />\r\nWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW', 'img/nkLogo.png', '2017-08-09 11:43:19'),
(9, 'WWWWWWWWWWWWWWWWWWWW<br />\r\nWWWWWWWWWWWWWWWWWWWW<br />\r\nWWWWWWWWWWWWWWWWWWWW<br />\r\nWWWWWWWWWWWWWWWWWWWW<br />\r\nWWWWWWWWWWWWWWWWWWWW<br />\r\nWWWWWWWWWWWWWWWWWWWW<br />\r\nWWWWWWWWWWWWWWWWWWWW<br />\r\nWWWWWWWWWWWWWWWWWWWW<br />\r\nWWWWWWWWWWWWWWWWWWWW<br />\r\nWWWWWWWWWWWWWWWWWWWW<br />\r\nWWWWWWWWWWWWWWWWWWWW<br />\r\nWWWWWWWWWWWWWWWWWWWW<br />\r\nWWWWWWWWWWWWWWWWWWWW<br />\r\nWWWWWWWWWWWWWWWWWWWW<br />\r\nWWWWWWWWWWWWWWWWWWWW<br />\r\nWWW', 'img/nkLogo.png', '2017-08-09 11:46:32'),
(10, 'v0.11.0<br />\r\nWhats new:<br />\r\n+ Updated the front <br />\r\npage to include <br />\r\nupdate posts<br />\r\n+ Removed <br />\r\nchangelist from <br />\r\nfront page<br />\r\n+ Centered the <br />\r\nnavButtons<br />\r\n+ Created Updates <br />\r\ntable<br />\r\n+ New <br />\r\ngetUpdates.php pull <br />\r\n- it will only pull <br />\r\nthe latest updates<br />\r\n+ Added an official <br />\r\nlogo to the site<br />\r\n- Need to add a <br />\r\nwayt to easier post <br />\r\nsite updates<br />\r\n- Need to add a <br />\r\npage on which all <br />\r\nupdates are visible', 'img/nkLogo.png', '2017-08-10 10:02:39'),
(11, 'v0.11.0<br />\r\nWhats new:<br />\r\n+ Updated the front page to include update posts<br />\r\n+ Removed changelist from front page<br />\r\n+ Centered the navButtons<br />\r\n+ Created Updates table<br />\r\n+ New getUpdates.php pull - it will only pull the latest <br />\r\nupdates<br />\r\n+ Added an official logo to the site<br />\r\n- Need to add a wayt to easier post site updates<br />\r\n- Need to add a page on which all updates are visible', 'img/nkLogo.png', '2017-08-10 10:06:40'),
(12, 'v0.11.0<br />\r\n Whats new:<br />\r\n + Updated the front page to include update posts<br />\r\n + Removed changelist from front page<br />\r\n + Centered the navButtons<br />\r\n + Created Updates table<br />\r\n + New getUpdates.php pull - it will only pull the latest updates<br />\r\n + Added an official logo to the site<br />\r\n - Need to add a wayt to easier post site updates<br />\r\n - Need to add a page on which all updates are visible', 'img/nkLogo.png', '2017-08-10 13:06:57'),
(13, 'Hello bun!', 'img/nkLogo.png', '2017-08-11 22:54:45'),
(14, 'Long line test 1 qwertyuiop[]asdfghjkl;\'zxcvbnm,./qwetyiop[]wertyuiop<br />\r\n[sdfghkjlsxcvbnjrdcfgvbhewrdtfygqweryttrywetyewtywefrtygweftygywefcgwecfgvefhdf<br />\r\nLine2 fgyhgftytguugytfygyhtyguihyguhiyguuhyghu========WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW<br />\r\nLine3 WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW<br />\r\n', 'img/nkLogo.png', '2017-08-14 18:51:10'),
(15, 'Test', 'img/nkLogo.png', '2017-08-18 11:44:34'),
(16, 'This is a test post intended to see the boundaries of the Admin post box on the main page. Test strings follow<br />\r\nNew line, testing space separated strings, simulating along sentence.<br />\r\n!PLACEHOLDER! !PLACEHOLDER! !PLACEHOLDER! !PLACEHOLDER! !PLACEHOLDER! !PLACEHOLDER! !PLACEHOLDER! !<br />\r\nPLACEHOLDER! !PLACEHOLDER! !PLACEHOLDER! !PLACEHOLDER! !PLACEHOLDER! !PLACEHOLDER! !PLACEHOLDER! !<br />\r\nPLACEHOLDER! !PLACEHOLDER! !PLACEHOLDER! !PLACEHOLDER! !PLACEHOLDER! !PLACEHOLDER! !PLACEHOLDER! !<br />\r\nPLACEHOLDER! !PLACEHOLDER! !PLACEHOLDER! !PLACEHOLDER! !PLACEHOLDER! !PLACEHOLDER! !PLACEHOLDER! <br />\r\nNew line, testing a long string of \'W\' covering the entire form.<br />\r\nWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW<br />\r\nNew line, testing a long string 50% of the form length.<br />\r\nWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW<br />\r\nNew line, testing the height of the Admin Update form. Line-break separa', 'img/nkLogo.png', '2017-08-18 11:50:43'),
(17, 'Month of September is planned to be big.<br />\r\nFinal two features of Defy (which were delayed until this month) are to be added and a complete front-end <br />\r\nrefresh of the site will begin.<br />\r\n[The wrap-up of nkolunov v1]<br />\r\nThe first steps of the features are already in place. All that needs to be done is some back-end work.<br />\r\nThe features should give a more complete online dictionary experience. Ability to link sounds and images to <br />\r\nindividual words give the user every real-world view of the word. The way it is written, pronounced and <br />\r\nencountered in life.<br />\r\n<br />\r\n[The road ahead]<br />\r\nWith these two final features taken care of, the site itself is long due for a fresh coat of paint.<br />\r\nThis will signify the end of the initial version of the nkolunov site and I will officially title the sunset <br />\r\nversion as v1. The refreshed version will naturally be v2.<br />\r\nThis will begin with several meetings with the stakeholders and following an agile method, several (two / <br />\r\nthree, no more in order to stay focused) version of the new site will be made. These will be presented and <br />\r\naspects of the best-looking will be carried over to the next generation. This is repeated a few times until <br />\r\nthe optimal look is achieved.<br />\r\nI estimate this will take over 6 months.', 'http://cdn.quotesgram.com/img/11/14/307216706-TheRoadNotTaken_jpg_scaled1000.jpg', '2017-09-17 20:10:01');

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
