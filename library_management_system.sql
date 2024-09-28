-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 20, 2023 at 11:51 AM
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
-- Database: `library_management_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `add_book`
--

CREATE TABLE `add_book` (
  `Book_ID` int(255) NOT NULL,
  `Book_Name` varchar(250) NOT NULL,
  `Book_Author_Name` varchar(250) NOT NULL,
  `Book_Publication` varchar(250) NOT NULL,
  `Book_Purchase_Date` varchar(250) NOT NULL,
  `Book_Price` varchar(250) NOT NULL,
  `Book_Quantity` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `add_book`
--

INSERT INTO `add_book` (`Book_ID`, `Book_Name`, `Book_Author_Name`, `Book_Publication`, `Book_Purchase_Date`, `Book_Price`, `Book_Quantity`) VALUES
(1, 'JAVA', 'java', 'LO', '2023-11-15', '1030', '2'),
(2, 'OOP', 'oop', 'SL', '2023-11-15', '1020', '2'),
(3, 'C#', 'c', 'In', '2023-11-15', '540', '4'),
(4, 'HTML', 'html', 'RV', '2023-11-15', '400', '2');

-- --------------------------------------------------------

--
-- Table structure for table `add_student`
--

CREATE TABLE `add_student` (
  `Student_Name` varchar(250) NOT NULL,
  `Enrollment_No` varchar(250) NOT NULL,
  `Department` varchar(250) NOT NULL,
  `Student_Semester` varchar(250) NOT NULL,
  `Student_Contact` varchar(250) NOT NULL,
  `Student_Email` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `add_student`
--

INSERT INTO `add_student` (`Student_Name`, `Enrollment_No`, `Department`, `Student_Semester`, `Student_Contact`, `Student_Email`) VALUES
('Hiruni', '18APP3051', 'CS', '2,1', '071', 'hi'),
('Tharushi', '18APP3500', 'PST', '3,1', '0717601143', 'tharushi@gmal.com');

-- --------------------------------------------------------

--
-- Table structure for table `ir_book`
--

CREATE TABLE `ir_book` (
  `ID` int(11) NOT NULL,
  `Student_Enroll` varchar(250) NOT NULL,
  `Student_Name` varchar(250) NOT NULL,
  `Student_Department` varchar(250) NOT NULL,
  `Student_Semester` varchar(250) NOT NULL,
  `Student_Contact` varchar(250) NOT NULL,
  `Student_Email` varchar(250) NOT NULL,
  `Book_Name` varchar(500) NOT NULL,
  `Book_Issue_Date` varchar(250) NOT NULL,
  `Book_Return_Date` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `ir_book`
--

INSERT INTO `ir_book` (`ID`, `Student_Enroll`, `Student_Name`, `Student_Department`, `Student_Semester`, `Student_Contact`, `Student_Email`, `Book_Name`, `Book_Issue_Date`, `Book_Return_Date`) VALUES
(1, '18APP3500', 'Tharushi', 'PST', '3,1', '0717601143', 'tharushi@gmal.com', 'JAVA', 'Friday, November 17, 2023', 'Friday, November 17, 2023'),
(2, '18APP3500', 'Tharushi', 'PST', '3,1', '0717601143', 'tharushi@gmal.com', 'OOP', 'Friday, November 17, 2023', 'NULL'),
(3, '18APP3500', 'Tharushi', 'PST', '3,1', '0717601143', 'tharushi@gmal.com', 'C#', 'Friday, November 17, 2023', 'Friday, November 17, 2023');

-- --------------------------------------------------------

--
-- Table structure for table `log_in`
--

CREATE TABLE `log_in` (
  `First_Name` varchar(150) NOT NULL,
  `Last_Name` varchar(150) NOT NULL,
  `Email` varchar(150) NOT NULL,
  `User_Name` varchar(150) NOT NULL,
  `Password` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `log_in`
--

INSERT INTO `log_in` (`First_Name`, `Last_Name`, `Email`, `User_Name`, `Password`) VALUES
('Pradeepika', 'Chathurani', 'p@gmail.com', '18APP3010', '1234'),
('Vihadu', 'Thenul', 'vihadu@gmail.com', '18APP30503', '1234'),
('Tharushi', 'Devindi', 'tharushimdevindi@gmail.com', '18APP3500', '1234'),
('Hiruni', 'Shavindi', 'hiruni40@gmail.com', '18APP3501', '1234'),
('Ganidu', 'Deneth', 'gnidu@gmail.com', '18APP3502', '1234'),
('Tharushi', 'Devindi', 'tharushimdevindi@gmail.com', 'APP18321', '1234');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `add_book`
--
ALTER TABLE `add_book`
  ADD PRIMARY KEY (`Book_ID`);

--
-- Indexes for table `add_student`
--
ALTER TABLE `add_student`
  ADD PRIMARY KEY (`Enrollment_No`);

--
-- Indexes for table `ir_book`
--
ALTER TABLE `ir_book`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `log_in`
--
ALTER TABLE `log_in`
  ADD PRIMARY KEY (`User_Name`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `add_book`
--
ALTER TABLE `add_book`
  MODIFY `Book_ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `ir_book`
--
ALTER TABLE `ir_book`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
