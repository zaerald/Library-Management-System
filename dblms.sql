-- phpMyAdmin SQL Dump
-- version 4.5.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 14, 2016 at 06:53 PM
-- Server version: 10.1.8-MariaDB
-- PHP Version: 5.6.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dblms`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblauthor`
--

CREATE TABLE `tblauthor` (
  `author_id` int(5) NOT NULL,
  `cutter` int(4) NOT NULL,
  `name` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblauthor`
--

INSERT INTO `tblauthor` (`author_id`, `cutter`, `name`) VALUES
(1, 117, 'Abal'),
(2, 118, 'Abar'),
(3, 117, 'Bacci'),
(4, 121, 'Bachell'),
(5, 142, 'Calan'),
(6, 147, 'Caldw'),
(7, 112, 'Dabi'),
(8, 115, 'Dabo'),
(9, 29, 'Ege'),
(10, 44, 'Ell');

-- --------------------------------------------------------

--
-- Table structure for table `tblavailability`
--

CREATE TABLE `tblavailability` (
  `availability_id` int(5) NOT NULL,
  `availability` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblavailability`
--

INSERT INTO `tblavailability` (`availability_id`, `availability`) VALUES
(1, 'Can be borrowed'),
(2, 'Library Only');

-- --------------------------------------------------------

--
-- Table structure for table `tblbookaccession`
--

CREATE TABLE `tblbookaccession` (
  `accession_no` int(7) NOT NULL,
  `book_id` int(5) NOT NULL,
  `available` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblbookaccession`
--

INSERT INTO `tblbookaccession` (`accession_no`, `book_id`, `available`) VALUES
(1, 1, 0),
(2, 2, 1),
(3, 3, 1),
(4, 4, 0),
(5, 5, 0),
(6, 6, 1),
(7, 7, 2);

-- --------------------------------------------------------

--
-- Table structure for table `tblbookauthor`
--

CREATE TABLE `tblbookauthor` (
  `book_id` int(5) NOT NULL,
  `author_id` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblbookauthor`
--

INSERT INTO `tblbookauthor` (`book_id`, `author_id`) VALUES
(1, 4),
(1, 5),
(2, 7),
(3, 2),
(4, 7),
(5, 5),
(6, 2),
(6, 3),
(6, 5),
(7, 2);

-- --------------------------------------------------------

--
-- Table structure for table `tblbookclassification`
--

CREATE TABLE `tblbookclassification` (
  `ddc` varchar(4) NOT NULL,
  `classification` varchar(120) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblbookclassification`
--

INSERT INTO `tblbookclassification` (`ddc`, `classification`) VALUES
('000', 'Computer science, information & general works'),
('005', 'Computer programming, programs & data'),
('014', 'Bibliographies and catalogs of anonymous & pseudonymous works'),
('017 ', 'General biographies and catalogs of works held in specific collections or offered for sale'),
('030', 'General encyclopedic works'),
('035 ', 'General encyclopedic works in Italian, Dalmatian, Romanian, Rhaetian, Sardinian, Corsican'),
('055', 'General serial publications in Italian, Dalmatian, Romanian, Rhaetian, Sardinian, Corsican'),
('056', 'General serial publications in Spanish, Portuguese, Galician'),
('131', 'Parapsychological and occult methods for achieving well-being, happiness, success'),
('137', 'Divinatory graphology'),
('200 ', 'Religion'),
('201 ', 'Religious mythology, general classes of religion, interreligious relations and attitudes, social theology');

-- --------------------------------------------------------

--
-- Table structure for table `tblbooks`
--

CREATE TABLE `tblbooks` (
  `book_id` int(5) NOT NULL,
  `ISBN` varchar(20) NOT NULL,
  `title` varchar(100) NOT NULL,
  `category_id` int(5) NOT NULL,
  `ddc` varchar(4) NOT NULL,
  `publisher_id` int(5) NOT NULL,
  `pubyear` year(4) NOT NULL,
  `availability_id` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblbooks`
--

INSERT INTO `tblbooks` (`book_id`, `ISBN`, `title`, `category_id`, `ddc`, `publisher_id`, `pubyear`, `availability_id`) VALUES
(1, '1-4028-9462-7', 'The first book', 6, '030', 4, 2012, 1),
(2, '978-1-4028-9462-6', 'The second book', 4, '014', 3, 2010, 1),
(3, '129416204', 'The Third Book', 6, '200 ', 4, 2013, 1),
(4, '1381-148124-12', 'The Fourth Book', 6, '055', 4, 2014, 1),
(5, '430714-123123', 'The Fifth Book', 5, '017 ', 1, 2015, 1),
(6, '1719401-12429-13', 'The Sixth Book', 7, '030', 3, 2016, 1),
(7, '120814-12314', 'The Seventh Book', 9, '131', 5, 2015, 2);

-- --------------------------------------------------------

--
-- Table structure for table `tblborrow`
--

CREATE TABLE `tblborrow` (
  `borrow_id` int(10) NOT NULL,
  `book_acc` int(7) NOT NULL,
  `dateborrowed` date NOT NULL,
  `duedate` date NOT NULL,
  `borrower_id` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblborrow`
--

INSERT INTO `tblborrow` (`borrow_id`, `book_acc`, `dateborrowed`, `duedate`, `borrower_id`) VALUES
(12, 4, '2016-03-28', '2016-03-31', '1234567-32'),
(13, 5, '2016-03-28', '2016-03-28', '20150030'),
(14, 1, '2016-03-28', '2016-03-31', '1234567-02');

-- --------------------------------------------------------

--
-- Table structure for table `tblcategory`
--

CREATE TABLE `tblcategory` (
  `category_id` int(5) NOT NULL,
  `category` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblcategory`
--

INSERT INTO `tblcategory` (`category_id`, `category`) VALUES
(1, 'Computer Science, Information & General Works'),
(2, 'Philosophy and psychology'),
(3, 'Religion'),
(4, 'Social Sciences'),
(5, 'Language'),
(6, 'Science'),
(7, 'Technology'),
(8, 'Arts and Recreation'),
(9, 'Literature'),
(10, 'History and Geography');

-- --------------------------------------------------------

--
-- Table structure for table `tblfaculty`
--

CREATE TABLE `tblfaculty` (
  `facid` varchar(10) NOT NULL,
  `firstname` varchar(20) NOT NULL,
  `lastname` varchar(20) NOT NULL,
  `gender` varchar(7) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblfaculty`
--

INSERT INTO `tblfaculty` (`facid`, `firstname`, `lastname`, `gender`) VALUES
('20150030', 'FirstTest', 'Lasttest', 'Male'),
('20150031', 'Human', 'Being', 'Female'),
('20150032', 'Persneym', 'Lasneym', 'Male');

-- --------------------------------------------------------

--
-- Table structure for table `tblpublisher`
--

CREATE TABLE `tblpublisher` (
  `publisher_id` int(5) NOT NULL,
  `publisher` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblpublisher`
--

INSERT INTO `tblpublisher` (`publisher_id`, `publisher`) VALUES
(1, 'Abiva Publishing House, Inc'),
(2, 'ArtPostAsia Inc.'),
(3, 'Sinag-Tala Publishers'),
(4, 'New Thoughts Publication'),
(5, 'Asian Escapades Management and Publishing Enterprises');

-- --------------------------------------------------------

--
-- Table structure for table `tblreturn`
--

CREATE TABLE `tblreturn` (
  `borrow_id` int(10) NOT NULL,
  `dateborrowed` date NOT NULL,
  `duedate` date NOT NULL,
  `datereturned` date NOT NULL,
  `book_acc` int(7) NOT NULL,
  `borrower_id` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblreturn`
--

INSERT INTO `tblreturn` (`borrow_id`, `dateborrowed`, `duedate`, `datereturned`, `book_acc`, `borrower_id`) VALUES
(9, '2016-03-28', '2016-03-31', '2016-04-01', 3, '1234567-02'),
(10, '2016-03-28', '2016-03-28', '2016-03-28', 4, '20150032'),
(11, '2016-03-28', '2016-03-31', '2016-04-01', 5, '1234567-02');

-- --------------------------------------------------------

--
-- Table structure for table `tblstudent`
--

CREATE TABLE `tblstudent` (
  `studid` varchar(10) NOT NULL,
  `firstname` varchar(20) NOT NULL,
  `lastname` varchar(20) NOT NULL,
  `gender` varchar(7) NOT NULL,
  `section_id` int(3) NOT NULL,
  `address` tinytext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstudent`
--

INSERT INTO `tblstudent` (`studid`, `firstname`, `lastname`, `gender`, `section_id`, `address`) VALUES
('1234567-02', 'Haru', 'Onodera', 'Female', 2, 'anywhere too'),
('1234567-32', 'Kosaki', 'Onodera', 'Female', 1, 'anywhere'),
('7654321-12', 'Firsttest', 'Lasttest', 'Male', 1, 'addresstest');

-- --------------------------------------------------------

--
-- Table structure for table `tblstudentsection`
--

CREATE TABLE `tblstudentsection` (
  `section_id` int(3) NOT NULL,
  `description` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstudentsection`
--

INSERT INTO `tblstudentsection` (`section_id`, `description`) VALUES
(1, 'Jasmin'),
(2, 'Sampaguita');

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE `tbluser` (
  `id` int(5) NOT NULL,
  `user` varchar(10) NOT NULL,
  `password` varchar(10) NOT NULL,
  `authorization` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbluser`
--

INSERT INTO `tbluser` (`id`, `user`, `password`, `authorization`) VALUES
(1, 'admin', 'admin', 'ADMIN');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblauthor`
--
ALTER TABLE `tblauthor`
  ADD PRIMARY KEY (`author_id`);

--
-- Indexes for table `tblavailability`
--
ALTER TABLE `tblavailability`
  ADD PRIMARY KEY (`availability_id`);

--
-- Indexes for table `tblbookaccession`
--
ALTER TABLE `tblbookaccession`
  ADD PRIMARY KEY (`accession_no`),
  ADD KEY `book_id` (`book_id`);

--
-- Indexes for table `tblbookauthor`
--
ALTER TABLE `tblbookauthor`
  ADD KEY `book_id` (`book_id`,`author_id`);

--
-- Indexes for table `tblbookclassification`
--
ALTER TABLE `tblbookclassification`
  ADD PRIMARY KEY (`ddc`);

--
-- Indexes for table `tblbooks`
--
ALTER TABLE `tblbooks`
  ADD PRIMARY KEY (`book_id`),
  ADD KEY `category` (`category_id`),
  ADD KEY `publisher_id` (`publisher_id`),
  ADD KEY `availability_id` (`availability_id`),
  ADD KEY `ddc` (`ddc`);

--
-- Indexes for table `tblborrow`
--
ALTER TABLE `tblborrow`
  ADD PRIMARY KEY (`borrow_id`),
  ADD KEY `book_id` (`book_acc`);

--
-- Indexes for table `tblcategory`
--
ALTER TABLE `tblcategory`
  ADD PRIMARY KEY (`category_id`);

--
-- Indexes for table `tblfaculty`
--
ALTER TABLE `tblfaculty`
  ADD PRIMARY KEY (`facid`);

--
-- Indexes for table `tblpublisher`
--
ALTER TABLE `tblpublisher`
  ADD PRIMARY KEY (`publisher_id`);

--
-- Indexes for table `tblreturn`
--
ALTER TABLE `tblreturn`
  ADD PRIMARY KEY (`borrow_id`),
  ADD KEY `borrow_id` (`borrow_id`);

--
-- Indexes for table `tblstudent`
--
ALTER TABLE `tblstudent`
  ADD PRIMARY KEY (`studid`),
  ADD KEY `section_id` (`section_id`);

--
-- Indexes for table `tblstudentsection`
--
ALTER TABLE `tblstudentsection`
  ADD PRIMARY KEY (`section_id`);

--
-- Indexes for table `tbluser`
--
ALTER TABLE `tbluser`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblauthor`
--
ALTER TABLE `tblauthor`
  MODIFY `author_id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `tblavailability`
--
ALTER TABLE `tblavailability`
  MODIFY `availability_id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `tblbooks`
--
ALTER TABLE `tblbooks`
  MODIFY `book_id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `tblborrow`
--
ALTER TABLE `tblborrow`
  MODIFY `borrow_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
--
-- AUTO_INCREMENT for table `tblcategory`
--
ALTER TABLE `tblcategory`
  MODIFY `category_id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `tblpublisher`
--
ALTER TABLE `tblpublisher`
  MODIFY `publisher_id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `tblreturn`
--
ALTER TABLE `tblreturn`
  MODIFY `borrow_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT for table `tblstudentsection`
--
ALTER TABLE `tblstudentsection`
  MODIFY `section_id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
