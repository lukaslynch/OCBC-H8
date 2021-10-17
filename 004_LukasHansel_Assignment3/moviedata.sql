-- Adminer 4.8.1 MySQL 5.5.5-10.4.21-MariaDB dump

SET NAMES utf8;
SET time_zone = '+00:00';
SET foreign_key_checks = 0;
SET sql_mode = 'NO_AUTO_VALUE_ON_ZERO';

SET NAMES utf8mb4;

DROP DATABASE IF EXISTS `moviedata`;
CREATE DATABASE `moviedata` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `moviedata`;

DROP TABLE IF EXISTS `tb_movie`;
CREATE TABLE `tb_movie` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(200) NOT NULL,
  `genre` varchar(50) NOT NULL,
  `duration` varchar(50) NOT NULL,
  `releasedate` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `tb_movie` (`id`, `name`, `genre`, `duration`, `releasedate`) VALUES
(1,	'Bad Boys For Life',	'Action/Comedy',	'2h 5 mins',	'2020-01-23 00:00:00'),
(3,	'Tokyo Drift',	'Action',	'1h 56 mins',	'2020-01-23 00:00:00'),
(4,	'A7x live in LBC',	'SONG',	'3h 12m',	'2021-10-17 19:21:40');

-- 2021-10-17 19:25:53