-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Gegenereerd op: 17 mrt 2023 om 10:08
-- Serverversie: 10.4.27-MariaDB
-- PHP-versie: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hospital`
--

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `hospital`
--

CREATE TABLE `hospital` (
  `ID` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `peopleinhospital`
--

CREATE TABLE `peopleinhospital` (
  `Person` int(11) NOT NULL,
  `Hospital` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `person`
--

CREATE TABLE `person` (
  `ID` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Birth` date NOT NULL,
  `Type` int(11) NOT NULL,
  `Problem` varchar(250) DEFAULT NULL,
  `Treatment` varchar(250) DEFAULT NULL,
  `Area` varchar(250) DEFAULT NULL,
  `Specialty` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `type`
--

CREATE TABLE `type` (
  `ID` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Gegevens worden geëxporteerd voor tabel `type`
--

INSERT INTO `type` (`ID`, `Name`) VALUES
(1, 'Patient'),
(2, 'Nurse'),
(3, 'Doctor');

--
-- Indexen voor geëxporteerde tabellen
--

--
-- Indexen voor tabel `hospital`
--
ALTER TABLE `hospital`
  ADD PRIMARY KEY (`ID`);

--
-- Indexen voor tabel `peopleinhospital`
--
ALTER TABLE `peopleinhospital`
  ADD PRIMARY KEY (`Person`,`Hospital`),
  ADD KEY `Hospital` (`Hospital`),
  ADD KEY `Person` (`Person`);

--
-- Indexen voor tabel `person`
--
ALTER TABLE `person`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Type` (`Type`);

--
-- Indexen voor tabel `type`
--
ALTER TABLE `type`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `ID` (`ID`);

--
-- AUTO_INCREMENT voor geëxporteerde tabellen
--

--
-- AUTO_INCREMENT voor een tabel `hospital`
--
ALTER TABLE `hospital`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT voor een tabel `person`
--
ALTER TABLE `person`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT voor een tabel `type`
--
ALTER TABLE `type`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Beperkingen voor geëxporteerde tabellen
--

--
-- Beperkingen voor tabel `peopleinhospital`
--
ALTER TABLE `peopleinhospital`
  ADD CONSTRAINT `peopleinhospital_ibfk_1` FOREIGN KEY (`Hospital`) REFERENCES `hospital` (`ID`),
  ADD CONSTRAINT `peopleinhospital_ibfk_2` FOREIGN KEY (`Person`) REFERENCES `person` (`ID`);

--
-- Beperkingen voor tabel `person`
--
ALTER TABLE `person`
  ADD CONSTRAINT `person_ibfk_1` FOREIGN KEY (`Type`) REFERENCES `type` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
