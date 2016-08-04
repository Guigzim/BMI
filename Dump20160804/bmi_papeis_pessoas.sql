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
-- Table structure for table `papeis_pessoas`
--

DROP TABLE IF EXISTS `papeis_pessoas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `papeis_pessoas` (
  `cod_papel_pessoa` smallint(5) unsigned zerofill NOT NULL,
  `desc_papel_pessoa` varchar(45) NOT NULL,
  `usr_cadastro` smallint(5) unsigned zerofill NOT NULL,
  `data_cadastro` date NOT NULL,
  `D_E_L_E_T_` char(1) DEFAULT NULL,
  PRIMARY KEY (`cod_papel_pessoa`),
  UNIQUE KEY `cod_tipo_UNIQUE` (`cod_papel_pessoa`),
  UNIQUE KEY `desc_tipo_pessoa_UNIQUE` (`desc_papel_pessoa`),
  KEY `usr_cadastro_idx` (`usr_cadastro`),
  CONSTRAINT `usr_cadastro` FOREIGN KEY (`usr_cadastro`) REFERENCES `usr` (`ID_USR`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `papeis_pessoas`
--

LOCK TABLES `papeis_pessoas` WRITE;
/*!40000 ALTER TABLE `papeis_pessoas` DISABLE KEYS */;
INSERT INTO `papeis_pessoas` VALUES (00001,'ADMINISTRADOR',00001,'2016-07-29',NULL),(00002,'USUÁRIO',00001,'2016-07-29',NULL),(00003,'ENFERMEIRO',00001,'2016-07-29',NULL),(00004,'PROFESSOR',00001,'2016-07-29',NULL),(00005,'ALUNO',00001,'2016-07-29',NULL);
/*!40000 ALTER TABLE `papeis_pessoas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-08-04 19:49:30
