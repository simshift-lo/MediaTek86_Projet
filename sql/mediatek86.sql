-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 29 mai 2026 à 15:09
-- Version du serveur : 8.4.7
-- Version de PHP : 8.3.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek86`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(3, '2025-09-03 08:00:00', '2025-10-28 18:00:00', 2),
(9, '2025-08-26 08:00:00', '2025-09-09 18:00:00', 2),
(8, '2025-05-16 08:00:00', '2025-10-06 18:00:00', 3),
(2, '2025-01-08 00:00:00', '2025-01-26 00:00:00', 2),
(9, '2025-09-19 08:00:00', '2025-11-01 18:00:00', 2),
(1, '2025-02-04 08:00:00', '2025-02-07 18:00:00', 1),
(4, '2025-03-12 08:30:00', '2025-03-15 18:00:00', 3),
(6, '2025-04-01 09:00:00', '2025-04-03 17:00:00', 2),
(10, '2025-06-09 08:00:00', '2025-06-12 18:00:00', 4),
(5, '2025-07-17 08:30:00', '2025-07-20 18:00:00', 1),
(7, '2025-01-22 09:00:00', '2025-01-24 17:00:00', 2),
(2, '2025-02-18 08:00:00', '2025-02-20 18:00:00', 4),
(1, '2025-03-05 08:30:00', '2025-03-06 18:00:00', 3),
(6, '2025-05-13 09:00:00', '2025-05-16 17:00:00', 1),
(8, '2025-06-24 08:00:00', '2025-06-26 18:00:00', 2),
(10, '2025-07-02 08:30:00', '2025-07-04 18:00:00', 3),
(4, '2025-08-11 09:00:00', '2025-08-14 17:00:00', 1),
(5, '2025-09-08 08:00:00', '2025-09-10 18:00:00', 4),
(3, '2025-10-13 08:30:00', '2025-10-15 18:00:00', 2),
(7, '2025-11-04 09:00:00', '2025-11-07 17:00:00', 3),
(1, '2025-04-22 08:00:00', '2025-04-25 18:00:00', 4),
(9, '2025-05-28 08:30:00', '2025-05-30 18:00:00', 1),
(2, '2025-06-16 09:00:00', '2025-06-18 17:00:00', 2),
(6, '2025-07-29 08:00:00', '2025-07-31 18:00:00', 3),
(8, '2025-08-19 08:30:00', '2025-08-22 18:00:00', 4),
(10, '2025-09-24 09:00:00', '2025-09-26 17:00:00', 1),
(5, '2025-10-06 08:00:00', '2025-10-09 18:00:00', 2),
(4, '2025-11-17 08:30:00', '2025-11-19 18:00:00', 3),
(7, '2025-12-02 09:00:00', '2025-12-05 17:00:00', 4),
(3, '2025-12-15 08:00:00', '2025-12-18 18:00:00', 1),
(6, '2025-01-14 08:30:00', '2025-01-16 18:00:00', 2),
(8, '2025-02-11 09:00:00', '2025-02-13 17:00:00', 3),
(1, '2025-05-06 08:00:00', '2025-05-09 18:00:00', 1),
(10, '2025-03-24 08:30:00', '2025-03-27 18:00:00', 4),
(2, '2025-08-04 09:00:00', '2025-08-06 17:00:00', 2),
(5, '2025-11-25 08:00:00', '2025-11-28 18:00:00', 3),
(9, '2025-04-15 08:30:00', '2025-04-17 18:00:00', 4),
(3, '2025-06-03 09:00:00', '2025-06-05 17:00:00', 1),
(7, '2025-07-08 08:00:00', '2025-07-11 18:00:00', 2),
(4, '2025-09-30 08:30:00', '2025-10-02 18:00:00', 3),
(8, '2025-10-21 09:00:00', '2025-10-24 17:00:00', 1),
(6, '2025-12-08 08:00:00', '2025-12-10 18:00:00', 4),
(1, '2025-11-10 08:30:00', '2025-11-12 18:00:00', 2),
(10, '2025-02-26 09:00:00', '2025-02-28 17:00:00', 3),
(2, '2025-10-29 08:30:00', '2025-10-31 18:00:00', 4),
(9, '2025-12-22 09:00:00', '2025-12-24 17:00:00', 3),
(4, '2025-06-30 08:00:00', '2025-07-02 18:00:00', 2),
(7, '2025-05-20 08:30:00', '2025-05-23 18:00:00', 1),
(3, '2025-08-27 09:00:00', '2025-08-29 17:00:00', 4),
(2, '2025-05-29 00:00:00', '2025-05-29 00:00:00', 2),
(4, '2025-05-29 00:00:00', '2025-05-29 00:00:00', 4);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `prenom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `tel` varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `mail` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'Wyatt', 'Otto', '04 15 01 07 84', 'pretium.et@yahoo.couk', 2),
(2, 'Davenport', 'Demetrius', '07 58 34 36 98', 'fusce.aliquet@protonmail.org', 2),
(3, 'Osborne', 'Indigo', '08 27 91 06 11', 'lacus.quisque@icloud.net', 1),
(4, 'Jensen', 'Murphy', '07 39 15 52 15', 'fusce.dolor@outlook.net', 2),
(6, 'Vasquez', 'Roth', '08 98 79 49 95', 'consectetuer.ipsum@hotmail.net', 3),
(7, 'Mooney', 'Dara', '07 02 61 63 94', 'cursus.purus@hotmail.org', 2),
(8, 'Gonzales', 'Coby', '06 17 28 02 42', 'blandit.mattis.cras@icloud.com', 1),
(9, 'Warner', 'Karen', '05 02 75 81 61', 'elit@hotmail.org', 2),
(10, 'Humphrey', 'Mari', '02 43 50 35 55', 'non.quam@yahoo.couk', 2);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  `pwd` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
