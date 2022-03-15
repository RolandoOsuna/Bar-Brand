-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: localhost    Database: wtfbarber
-- ------------------------------------------------------
-- Server version	8.0.22

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cortecaja`
--

DROP TABLE IF EXISTS `cortecaja`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cortecaja` (
  `idCorte` int NOT NULL AUTO_INCREMENT,
  `totalVentas_corte` int NOT NULL,
  `comisionesTotal_corte` int NOT NULL,
  `ganancia_corte` int NOT NULL,
  `productosVendidos_corte` int NOT NULL,
  `fecha_corte` datetime NOT NULL,
  `fondo_corte` int NOT NULL,
  PRIMARY KEY (`idCorte`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cortecaja`
--

LOCK TABLES `cortecaja` WRITE;
/*!40000 ALTER TABLE `cortecaja` DISABLE KEYS */;
INSERT INTO `cortecaja` VALUES (14,0,0,0,0,'2022-02-18 19:45:35',0),(15,220,88,132,2,'2022-02-18 20:06:53',0);
/*!40000 ALTER TABLE `cortecaja` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nomina`
--

DROP TABLE IF EXISTS `nomina`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `nomina` (
  `idNomina` int NOT NULL AUTO_INCREMENT,
  `empleado_nomina` varchar(100) NOT NULL,
  `total_nomina` int NOT NULL,
  `fecha_nomina` datetime NOT NULL,
  `totalComision_nomina` int NOT NULL,
  PRIMARY KEY (`idNomina`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nomina`
--

LOCK TABLES `nomina` WRITE;
/*!40000 ALTER TABLE `nomina` DISABLE KEYS */;
INSERT INTO `nomina` VALUES (1,'Saul',1771,'2022-02-10 23:00:28',0),(2,'Gustavo',1571,'2022-02-10 23:01:17',0),(3,'Jaz',1771,'2022-02-10 23:03:16',0),(4,'Keila',1771,'2022-02-10 23:05:57',0),(5,'Gustavo',1571,'2022-02-10 23:06:25',0),(6,'Jaz',1771,'2022-02-10 23:07:37',771),(7,'Jaz',1771,'2022-02-10 23:09:30',771),(8,'Gustavo',1571,'2022-02-10 23:15:13',771),(9,'Saul',1771,'2022-02-10 23:15:29',771),(10,'Saul',1455,'2022-02-11 21:21:44',455),(11,'Keila',1080,'2022-02-11 23:42:01',80),(12,'Gustavo',976,'2022-02-12 12:44:04',176),(13,'Jaz',1148,'2022-02-12 13:59:22',148),(14,'Keila',1240,'2022-02-15 10:30:26',240),(15,'Gustavo',1364,'2022-02-17 17:29:57',564),(16,'Gustavo',1412,'2022-02-18 20:28:07',612),(17,'Keila',1280,'2022-02-18 20:30:13',280);
/*!40000 ALTER TABLE `nomina` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventas`
--

DROP TABLE IF EXISTS `ventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ventas` (
  `id_ventas` int NOT NULL AUTO_INCREMENT,
  `empleado_venta` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `producto_venta` varchar(100) NOT NULL,
  `fecha_venta` datetime NOT NULL,
  `comision_venta` double NOT NULL,
  `totalComision_venta` double NOT NULL,
  `totalFinal_venta` double NOT NULL,
  `corteCaja_venta` tinyint(1) NOT NULL DEFAULT '0',
  `fechaCorteCaja_ventas` datetime DEFAULT NULL,
  `nomina_ventas` int NOT NULL,
  `fechaNomina_ventas` datetime NOT NULL,
  PRIMARY KEY (`id_ventas`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventas`
--

LOCK TABLES `ventas` WRITE;
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
INSERT INTO `ventas` VALUES (1,'Saul','Corte y Barba','2022-02-06 21:26:42',50,75,150,0,NULL,0,'0000-00-00 00:00:00'),(2,'Keila','Corte, Barba y Mascarilla','2022-02-07 10:32:13',40,80,200,0,NULL,0,'0000-00-00 00:00:00'),(3,'Gustavo','Corte y Barba','2022-02-07 10:35:15',40,60,150,0,NULL,0,'0000-00-00 00:00:00'),(4,'Saul','Corte con Navajas','2022-02-07 12:11:35',50,85,170,0,NULL,0,'0000-00-00 00:00:00'),(5,'Saul','Barba Media','2022-02-07 12:53:12',50,70,140,0,NULL,0,'0000-00-00 00:00:00'),(6,'Saul','Corte de Cabello','2022-02-08 17:45:24',50,75,150,0,NULL,0,'0000-00-00 00:00:00'),(7,'Saul','Corte de Cabello','2022-02-08 17:46:00',50,75,150,0,NULL,0,'0000-00-00 00:00:00'),(8,'Jaz','Mascarilla Negra','2022-02-08 17:48:29',40,20,50,0,NULL,0,'0000-00-00 00:00:00'),(9,'Jaz','Tinte de Barba','2022-02-08 18:17:46',40,40,100,0,NULL,0,'0000-00-00 00:00:00'),(10,'Gustavo','Barba Media','2022-02-08 18:30:46',40,56,140,0,NULL,0,'0000-00-00 00:00:00'),(11,'Gustavo','Corte de Cabello','2022-02-10 13:08:20',40,60,150,0,NULL,0,'0001-01-01 00:00:00'),(12,'Saul','Corte de Cabello','2022-02-10 13:11:40',50,75,150,0,NULL,0,'0001-01-01 00:00:00'),(13,'Jaz','Corte con Navajas','2022-02-12 00:33:32',40,68,170,0,NULL,0,'0001-01-01 00:00:00'),(14,'Jaz','Mascarilla Negra','2022-02-12 12:39:38',40,20,50,0,NULL,0,'0001-01-01 00:00:00'),(15,'Keila','Facial Exprés','2022-02-12 12:50:00',40,60,150,0,NULL,0,'0001-01-01 00:00:00'),(16,'Gustavo','Barba Completa','2022-02-12 12:50:33',40,64,160,0,NULL,0,'0001-01-01 00:00:00'),(17,'Saul','Facial Exprés','2022-02-12 13:54:51',50,75,150,0,NULL,0,'0001-01-01 00:00:00'),(18,'Gustavo','Fascial Completo','2022-02-12 13:56:24',40,100,250,0,NULL,0,'0001-01-01 00:00:00'),(19,'Keila','Fascial Completo','2022-02-15 10:30:08',40,100,250,0,NULL,0,'0001-01-01 00:00:00'),(20,'Gustavo','Corte de Cabello','2022-02-15 14:23:40',40,60,150,0,NULL,0,'0001-01-01 00:00:00'),(21,'Gustavo','Barba Completa','2022-02-16 17:15:04',40,64,160,0,NULL,0,'0001-01-01 00:00:00'),(22,'Gustavo','Fascial Completo','2022-02-17 17:29:36',40,100,250,0,NULL,0,'0001-01-01 00:00:00'),(23,'Jaz','Corte de Niño','2022-02-18 19:36:56',40,48,120,0,NULL,0,'0001-01-01 00:00:00'),(24,'Keila','Tinte de Barba','2022-02-18 19:37:03',40,40,100,0,NULL,0,'0001-01-01 00:00:00'),(25,'Gustavo','Corte de Niño','2022-02-18 20:23:01',40,48,120,0,NULL,0,'0001-01-01 00:00:00');
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'wtfbarber'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-02-18 20:37:53
