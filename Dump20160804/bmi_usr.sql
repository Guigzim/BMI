-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: bmi
-- ------------------------------------------------------
-- Server version	5.7.12-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `usr`
--

DROP TABLE IF EXISTS `usr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usr` (
  `ID_USR` smallint(5) unsigned zerofill NOT NULL,
  `USR_LOGIN` varchar(20) NOT NULL,
  `USR_SENHA` varchar(45) NOT NULL,
  `USR_NOME` varchar(45) NOT NULL,
  `USR_NIVEL` smallint(6) unsigned NOT NULL,
  `USR_STATUS` char(1) NOT NULL,
  PRIMARY KEY (`ID_USR`),
  UNIQUE KEY `IDUSR_UNIQUE` (`ID_USR`),
  UNIQUE KEY `USR_LOGIN_UNIQUE` (`USR_LOGIN`),
  KEY `USR_NIVEL_idx` (`USR_NIVEL`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabela referente aos cadastros de usuários do sistema.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usr`
--

LOCK TABLES `usr` WRITE;
/*!40000 ALTER TABLE `usr` DISABLE KEYS */;
INSERT INTO `usr` VALUES (00001,'BRUNO.SEARA','d3v3l0p','BRUNO FILLIPE DE BARROS SEÁRA',5,'A'),(00002,'DAIANE.SANTOS','230382','DAIANE DOS SANTOS',5,'A'),(00003,'GUILHERME.BARROS','123','GUILHERME DE BARROS DA ROCHA',5,'I'),(00004,'MARLI.SANTOS','marli438','MARLI DOS SANTOS',3,'A'),(00005,'JUSSARA.BARROS','151167','JUSSARA DE BARROS',3,'A'),(00006,'MAIRA.MONTEIRO','maira','MAIRA MONTEIRO',3,'I');
/*!40000 ALTER TABLE `usr` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-08-04 19:49:31
