CREATE DATABASE IF NOT EXISTS `loja_andre`;
USE `loja_andre`;

DROP TABLE IF EXISTS `produtos`;
CREATE TABLE IF NOT EXISTS `produtos` (
  `cd_id` int NOT NULL AUTO_INCREMENT,
  `cd_produto` varchar(140) NOT NULL,
  `nm_produto` varchar(140) NOT NULL,
  PRIMARY KEY (`cd_id`,`cd_produto`)
);

DROP TABLE IF EXISTS `quantidade`;
CREATE TABLE IF NOT EXISTS `quantidade` (
  `cd_id` int NOT NULL AUTO_INCREMENT,
  `nm_produto` varchar(140) NOT NULL,
  `qt_produto` varchar(140) NOT NULL,
  PRIMARY KEY (`cd_id`)
);
COMMIT;