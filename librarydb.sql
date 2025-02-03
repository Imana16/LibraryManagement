-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 03, 2025 at 12:04 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `librarydb`
--

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE `books` (
  `BookID` int(11) NOT NULL,
  `Title` varchar(255) NOT NULL,
  `Author` varchar(255) NOT NULL,
  `Publisher` varchar(255) DEFAULT NULL,
  `Year` int(11) DEFAULT NULL,
  `Genre` varchar(255) DEFAULT NULL,
  `CopiesAvailable` int(11) DEFAULT NULL,
  `BookImage` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`BookID`, `Title`, `Author`, `Publisher`, `Year`, `Genre`, `CopiesAvailable`, `BookImage`) VALUES
(1, 'The Great Gatsby', 'F. Scott Fitzgerald', 'Scribner', 1926, 'Classic', -1, 'path_to_image1.jpg'),
(2, '1984 ', 'George Orwell', 'Secker & Warburg', 1949, 'Dystopian', 1, 'C:\\Users\\Imana\\Downloads\\librarymanagemtsystem-01\\Thefish.jpg'),
(3, 'To Kill a Mockingbird', 'Harper Lee', 'J.B. Lippincott & Co.', 1960, 'Fiction', 2, 'path_to_image3.jpg'),
(4, 'The Catcher in the Rye', 'J.D. Salinger', 'Little, Brown and Company', 1951, 'Classic', 4, 'path_to_image4.jpg'),
(5, 'Moby-Dick', 'Herman Melville', 'Harper & Brothers', 1851, 'Adventure', 1, 'C:\\Users\\Imana\\Downloads\\librarymanagemtsystem-01\\Thefish.jpg'),
(9, 'The Fish in the Sea', 'Maya Angelou', 'Atlas', 2014, 'Fiction', 2, 'C:\\Users\\Imana\\Downloads\\librarymanagemtsystem-01\\Thefish.jpg'),
(11, 'Pride and Prejudice', 'Jane Austen', 'T. Egerton', 1813, 'Classic', 3, 'path_to_image7.jpg'),
(12, 'War and Peace', 'Leo Tolstoy', 'The Russian Messenger', 1869, 'Historical', 2, 'path_to_image8.jpg'),
(13, 'The Odyssey', 'Homer', 'Penguin Classics', -800, 'Epic Poetry', 1, 'path_to_image9.jpg'),
(14, 'The Picture of Dorian Gray', 'Oscar Wilde', 'Lippincott\'s Monthly Magazine', 1890, 'Gothic Fiction', 2, 'path_to_image10.jpg'),
(15, 'The Hobbit', 'J.R.R. Tolkien', 'George Allen & Unwin', 1937, 'Fantasy', 5, 'path_to_image11.jpg'),
(16, 'Fahrenheit 451', 'Ray Bradbury', 'Ballantine Books', 1953, 'Dystopian', 4, 'path_to_image12.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `borrowedbooks`
--

CREATE TABLE `borrowedbooks` (
  `BorrowedBookID` int(11) NOT NULL,
  `MemberID` int(11) NOT NULL,
  `BookID` int(11) NOT NULL,
  `BorrowDate` datetime NOT NULL,
  `ReturnDate` datetime DEFAULT NULL,
  `DueDate` datetime NOT NULL,
  `Fine` decimal(10,2) NOT NULL DEFAULT 0.00,
  `PaymentStatus` enum('Paid','Unpaid') NOT NULL DEFAULT 'Unpaid'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `borrowedbooks`
--

INSERT INTO `borrowedbooks` (`BorrowedBookID`, `MemberID`, `BookID`, `BorrowDate`, `ReturnDate`, `DueDate`, `Fine`, `PaymentStatus`) VALUES
(1, 1, 1, '2025-02-02 15:45:33', '2025-02-03 05:19:43', '2025-02-09 15:45:33', 0.00, 'Unpaid'),
(2, 1, 2, '2025-02-02 15:45:41', '2025-02-03 05:19:20', '2025-02-09 15:45:41', 0.00, 'Unpaid'),
(3, 4, 2, '2025-02-02 17:00:29', '2025-02-02 21:50:31', '2025-02-09 17:00:29', 0.00, 'Unpaid'),
(4, 4, 9, '2025-02-02 17:26:30', NULL, '2025-02-09 17:26:30', 0.00, 'Unpaid'),
(5, 4, 9, '2025-02-02 17:58:18', NULL, '2025-02-09 17:58:18', 0.00, 'Unpaid'),
(6, 2, 9, '2025-02-02 18:04:45', '2025-02-02 21:51:49', '2025-02-09 18:04:45', 0.00, 'Unpaid'),
(7, 1, 9, '2025-02-02 18:31:16', NULL, '2025-02-09 18:31:16', 0.00, 'Unpaid'),
(8, 1, 2, '2025-02-02 18:33:50', NULL, '2025-02-09 18:33:50', 0.00, 'Unpaid'),
(9, 4, 1, '2025-02-02 20:26:15', '2025-02-02 21:49:22', '2025-02-09 20:26:15', 0.00, 'Unpaid'),
(10, 3, 2, '2025-02-02 21:52:55', '2025-02-02 21:53:32', '2025-02-09 21:52:55', 0.00, 'Unpaid'),
(11, 3, 5, '2025-02-02 21:54:23', '2025-02-02 21:54:31', '2025-02-09 21:54:23', 0.00, 'Unpaid'),
(12, 1, 2, '2025-02-03 05:19:14', NULL, '2025-02-10 05:19:14', 0.00, 'Unpaid');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `UserID` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Role` varchar(40) NOT NULL,
  `Fullname` varchar(50) NOT NULL,
  `Email` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`UserID`, `Username`, `Password`, `Role`, `Fullname`, `Email`) VALUES
(1, 'Charles', 'lib123', 'Librarian', 'Charles George', 'charles.george@example.com'),
(2, 'admin', 'admin123', 'Admin', 'John', 'admin.john@example.com');

-- --------------------------------------------------------

--
-- Table structure for table `members`
--

CREATE TABLE `members` (
  `MemberID` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Password` varchar(100) NOT NULL,
  `DateJoined` datetime DEFAULT current_timestamp(),
  `Role` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `members`
--

INSERT INTO `members` (`MemberID`, `Name`, `Email`, `Password`, `DateJoined`, `Role`) VALUES
(1, 'Maya ', 'Maya@gmail.com', 'my123', '2025-01-29 11:47:12', 'Member'),
(2, 'Jane Smith', 'jane.smith@example.com', 'jn456', '2025-01-29 11:47:12', 'Member'),
(3, 'Angel', 'Angel@gmail.con', 'im1235', '2025-01-29 16:17:15', 'Member'),
(4, 'Prem', 'prem@gmail.com', 'xyz', '2025-02-01 15:37:37', 'Member');

-- --------------------------------------------------------

--
-- Table structure for table `reservations`
--

CREATE TABLE `reservations` (
  `ReservationID` int(11) NOT NULL,
  `MemberID` int(11) DEFAULT NULL,
  `BookID` int(11) DEFAULT NULL,
  `ReservationDate` datetime DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `reservations`
--

INSERT INTO `reservations` (`ReservationID`, `MemberID`, `BookID`, `ReservationDate`, `Status`) VALUES
(2, 3, 2, '2025-02-02 20:34:05', 'Canceled'),
(3, 3, 5, '2025-02-02 20:34:27', 'Fulfilled'),
(4, 3, 3, '2025-02-02 20:54:28', 'Canceled'),
(5, 4, 1, '2025-02-02 21:48:41', 'Fulfilled'),
(6, 4, 1, '2025-02-02 21:49:52', 'Pending'),
(7, 1, 1, '2025-02-03 05:20:29', 'Pending');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`BookID`);

--
-- Indexes for table `borrowedbooks`
--
ALTER TABLE `borrowedbooks`
  ADD PRIMARY KEY (`BorrowedBookID`),
  ADD KEY `fk_member` (`MemberID`),
  ADD KEY `fk_book` (`BookID`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`UserID`);

--
-- Indexes for table `members`
--
ALTER TABLE `members`
  ADD PRIMARY KEY (`MemberID`);

--
-- Indexes for table `reservations`
--
ALTER TABLE `reservations`
  ADD PRIMARY KEY (`ReservationID`),
  ADD KEY `MemberID` (`MemberID`),
  ADD KEY `BookID` (`BookID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `books`
--
ALTER TABLE `books`
  MODIFY `BookID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `borrowedbooks`
--
ALTER TABLE `borrowedbooks`
  MODIFY `BorrowedBookID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `members`
--
ALTER TABLE `members`
  MODIFY `MemberID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `reservations`
--
ALTER TABLE `reservations`
  MODIFY `ReservationID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `borrowedbooks`
--
ALTER TABLE `borrowedbooks`
  ADD CONSTRAINT `fk_book` FOREIGN KEY (`BookID`) REFERENCES `books` (`BookID`) ON DELETE CASCADE,
  ADD CONSTRAINT `fk_member` FOREIGN KEY (`MemberID`) REFERENCES `members` (`MemberID`) ON DELETE CASCADE;

--
-- Constraints for table `reservations`
--
ALTER TABLE `reservations`
  ADD CONSTRAINT `reservations_ibfk_1` FOREIGN KEY (`MemberID`) REFERENCES `members` (`MemberID`),
  ADD CONSTRAINT `reservations_ibfk_2` FOREIGN KEY (`BookID`) REFERENCES `books` (`BookID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
