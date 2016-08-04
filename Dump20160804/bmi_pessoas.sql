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
-- Table structure for table `pessoas`
--

DROP TABLE IF EXISTS `pessoas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pessoas` (
  `cod_pessoa` smallint(5) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `nome_pessoa` varchar(100) NOT NULL,
  `cpf_pessoa` varchar(11) DEFAULT NULL,
  `data_nasc_pessoa` date NOT NULL,
  `sexo_pessoa` char(1) NOT NULL,
  `d_e_l_e_t_` char(1) DEFAULT NULL,
  `cidade_natal` varchar(45) DEFAULT NULL,
  `papel_pessoa` smallint(5) unsigned zerofill NOT NULL,
  `usr_cadastro` smallint(6) unsigned zerofill NOT NULL,
  `data_cadastro` date NOT NULL,
  PRIMARY KEY (`cod_pessoa`),
  UNIQUE KEY `cod_pessoa_UNIQUE` (`cod_pessoa`),
  UNIQUE KEY `cpf_pessoa_UNIQUE` (`cpf_pessoa`),
  KEY `usr_cadastro_idx` (`usr_cadastro`),
  KEY `papel_idx` (`papel_pessoa`),
  CONSTRAINT `papel` FOREIGN KEY (`papel_pessoa`) REFERENCES `papeis_pessoas` (`cod_papel_pessoa`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pessoas`
--

LOCK TABLES `pessoas` WRITE;
/*!40000 ALTER TABLE `pessoas` DISABLE KEYS */;
INSERT INTO `pessoas` VALUES (00001,'BRUNO FILLIPE DE BARROS SEÁRA','05291122994','1986-11-04','M',NULL,'FLORIANOPOLIS',00001,000001,'2016-07-29');
/*!40000 ALTER TABLE `pessoas` ENABLE KEYS */;
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
