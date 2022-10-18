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
-- Table structure for table `citas`
--

DROP TABLE IF EXISTS `citas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `citas` (
  `idCita` int NOT NULL AUTO_INCREMENT,
  `nombre_cita` varchar(100) NOT NULL,
  `telefono_cita` varchar(100) NOT NULL,
  `fecha_cita` datetime NOT NULL,
  PRIMARY KEY (`idCita`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `citas`
--

LOCK TABLES `citas` WRITE;
/*!40000 ALTER TABLE `citas` DISABLE KEYS */;
INSERT INTO `citas` VALUES (1,'Rolando','6691792989','2022-07-29 15:15:36'),(2,'Miguel','6691234567','2022-07-29 14:16:33'),(3,'Juan','6691232323','2022-07-29 20:17:45'),(4,'José','6691858283','2022-07-29 16:18:34');
/*!40000 ALTER TABLE `citas` ENABLE KEYS */;
UNLOCK TABLES;

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
  PRIMARY KEY (`idCorte`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cortecaja`
--

LOCK TABLES `cortecaja` WRITE;
/*!40000 ALTER TABLE `cortecaja` DISABLE KEYS */;
INSERT INTO `cortecaja` VALUES (14,0,0,0,0,'2022-02-18 19:45:35'),(15,220,88,132,2,'2022-02-18 20:06:53'),(16,1290,543,747,8,'2022-02-19 15:13:56'),(17,1740,738,1002,11,'2022-02-19 15:20:26'),(18,150,60,90,1,'2022-02-21 18:36:30'),(19,470,188,282,4,'2022-07-26 19:56:40'),(20,500,200,300,2,'2022-07-30 01:23:38');
/*!40000 ALTER TABLE `cortecaja` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gastos`
--

DROP TABLE IF EXISTS `gastos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `gastos` (
  `idGasto` int NOT NULL AUTO_INCREMENT,
  `nombre_gasto` varchar(100) NOT NULL,
  `descripcion_gasto` varchar(200) NOT NULL,
  `cantidad_gasto` float NOT NULL,
  `fecha_gasto` datetime NOT NULL,
  PRIMARY KEY (`idGasto`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gastos`
--

LOCK TABLES `gastos` WRITE;
/*!40000 ALTER TABLE `gastos` DISABLE KEYS */;
INSERT INTO `gastos` VALUES (1,'Test','Testttttttttttttttt',500,'2022-08-13 19:22:36'),(2,'Pruebaaaaaa','Probando probando 123',100,'2022-08-13 19:13:45');
/*!40000 ALTER TABLE `gastos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nomina`
--

DROP TABLE IF EXISTS `nomina`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `nomina` (
  `idNomina` int NOT NULL AUTO_INCREMENT,
  `total_nomina` int NOT NULL,
  `fecha_nomina` datetime NOT NULL,
  `totalComision_nomina` int NOT NULL,
  PRIMARY KEY (`idNomina`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nomina`
--

LOCK TABLES `nomina` WRITE;
/*!40000 ALTER TABLE `nomina` DISABLE KEYS */;
INSERT INTO `nomina` VALUES (1,1771,'2022-02-10 23:00:28',0),(2,1571,'2022-02-10 23:01:17',0),(3,1771,'2022-02-10 23:03:16',0),(4,1771,'2022-02-10 23:05:57',0),(5,1571,'2022-02-10 23:06:25',0),(6,1771,'2022-02-10 23:07:37',771),(7,1771,'2022-02-10 23:09:30',771),(8,1571,'2022-02-10 23:15:13',771),(9,1771,'2022-02-10 23:15:29',771),(10,1455,'2022-02-11 21:21:44',455),(11,1080,'2022-02-11 23:42:01',80),(12,976,'2022-02-12 12:44:04',176),(13,1148,'2022-02-12 13:59:22',148),(14,1240,'2022-02-15 10:30:26',240),(15,1364,'2022-02-17 17:29:57',564),(16,1412,'2022-02-18 20:28:07',612),(17,1280,'2022-02-18 20:30:13',280),(18,1112,'2022-02-19 15:16:08',112),(19,1060,'2022-02-21 18:37:22',60),(20,3860,'2022-02-26 15:19:38',60),(21,4067,'2022-08-10 21:51:39',267);
/*!40000 ALTER TABLE `nomina` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `idUsuario` int NOT NULL AUTO_INCREMENT,
  `nombre_usuario` varchar(100) NOT NULL,
  `contrasena_usuario` varchar(100) NOT NULL,
  `fecha_usuario` datetime NOT NULL,
  `privilegio_usuario` varchar(100) NOT NULL,
  PRIMARY KEY (`idUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'Rolando','123','2022-07-28 18:18:35','Admin'),(5,'Cajera','123','2022-08-13 18:03:23','Cajera');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
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
  PRIMARY KEY (`id_ventas`)
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventas`
--

LOCK TABLES `ventas` WRITE;
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
INSERT INTO `ventas` VALUES (5,'Hadamari','Corte de Niño','2022-08-13 18:31:13',40,48,120),(6,'Hadamari','Corte de Cabello','0001-01-01 00:00:00',40,60,150),(7,'Saul','Corte de Cabello','2022-02-08 17:46:00',50,75,150),(9,'Jaz','Tinte de Barba','2022-02-08 18:17:46',40,40,100),(10,'Gustavo','Barba Media','2022-02-08 18:30:46',40,56,140),(11,'Gustavo','Corte de Cabello','2022-02-10 13:08:20',40,60,150),(12,'Saul','Corte de Cabello','2022-02-10 13:11:40',50,75,150),(13,'Jaz','Corte con Navajas','2022-02-12 00:33:32',40,68,170),(14,'Jaz','Mascarilla Negra','2022-02-12 12:39:38',40,20,50),(15,'Keila','Facial Exprés','2022-02-12 12:50:00',40,60,150),(16,'Gustavo','Barba Completa','2022-02-12 12:50:33',40,64,160),(17,'Saul','Facial Exprés','2022-02-12 13:54:51',50,75,150),(18,'Gustavo','Fascial Completo','2022-02-12 13:56:24',40,100,250),(19,'Keila','Fascial Completo','2022-02-15 10:30:08',40,100,250),(20,'Gustavo','Corte de Cabello','2022-02-15 14:23:40',40,60,150),(21,'Gustavo','Barba Completa','2022-02-16 17:15:04',40,64,160),(22,'Gustavo','Fascial Completo','2022-02-17 17:29:36',40,100,250),(23,'Jaz','Corte de Niño','2022-02-18 19:36:56',40,48,120),(24,'Keila','Tinte de Barba','2022-02-18 19:37:03',40,40,100),(25,'Gustavo','Corte de Niño','2022-02-18 20:23:01',40,48,120),(26,'Jaz','Barba Completa','2022-02-19 13:27:41',40,64,160),(27,'Saul','Corte de Niño','2022-02-19 13:34:34',50,60,120),(28,'Gustavo','Barba Completa','2022-02-19 14:11:15',40,64,160),(29,'Saul','Corte de Cabello','2022-02-19 15:12:17',50,75,150),(30,'Gustavo','Corte de Cabello','2022-02-19 15:12:25',40,60,150),(31,'Jaz','Corte de Cabello','2022-02-19 15:12:35',40,60,150),(32,'Keila','Corte de Cabello','2022-02-19 15:12:41',40,60,150),(33,'Jaz','Fascial Completo','2022-02-19 15:13:06',40,100,250),(34,'Saul','Corte de Cabello','2022-02-19 15:19:56',50,75,150),(35,'Gustavo','Corte de Cabello','2022-02-19 15:20:03',40,60,150),(36,'Jaz','Corte de Cabello','2022-02-19 15:20:10',40,60,150),(37,'Jaz','Tinte de Cabello','2022-02-21 18:35:46',40,60,150),(38,'Saul','Barba Completa','2022-02-22 16:28:10',50,80,160),(39,'Keila','Facial Exprés','2022-02-22 16:53:27',40,60,150),(40,'Keila','Tinte de Barba','2022-02-22 16:54:27',40,40,100),(41,'Jaz','Barba Media','2022-02-22 16:56:22',40,56,140),(42,'Saul','Corte de Niño','2022-02-22 17:04:41',50,60,120),(43,'Keila','Facial Exprés','2022-02-22 17:06:04',40,60,150),(44,'Jaz','Corte de Niño','2022-02-22 18:29:59',40,48,120),(45,'Jaz','Corte de Cabello','2022-02-22 18:33:53',40,60,150),(46,'Gustavo','Barba Completa','2022-02-22 18:35:12',40,64,160),(47,'Gustavo','Barba Media','2022-02-22 18:37:17',40,56,140),(48,'Jaz','Barba Media','2022-02-22 18:37:41',40,56,140),(49,'Gustavo','Corte con Navajas','2022-02-22 18:38:56',40,68,170),(50,'Gustavo','Barba Completa','2022-02-22 18:39:08',40,64,160),(51,'Gustavo','Barba Media','2022-02-22 18:39:35',40,56,140),(52,'Saul','Barba Media','2022-02-22 18:40:00',50,70,140),(53,'Gustavo','Corte de Niño','2022-02-22 18:40:50',40,48,120),(54,'Keila','Barba Media','2022-02-22 18:42:16',40,56,140),(55,'Jaz','Barba Completa','2022-02-22 18:50:30',40,64,160),(56,'Keila','Corte de Cabello','2022-02-22 18:52:04',40,60,150),(57,'Gustavo','Barba Media','2022-02-22 18:56:18',40,56,140),(58,'Gustavo','Tinte de Barba','2022-02-22 19:22:03',40,40,100),(59,'Saul','Corte con Navajas','2022-02-22 19:28:23',50,85,170),(60,'Keila','Corte con Navajas','2022-02-22 19:30:25',40,68,170),(61,'Gustavo','Barba Media','2022-02-22 19:50:08',40,56,140),(62,'Saul','Barba Media','2022-02-22 19:51:50',50,70,140),(63,'Gustavo','Barba Completa','2022-02-22 19:53:13',40,64,160),(64,'Gustavo','Fascial Completo','2022-02-22 20:01:01',40,100,250),(65,'Jaz','Facial Exprés','2022-02-22 23:53:06',40,60,150),(66,'Jaz','Corte con Navajas','2022-02-23 00:28:23',40,68,170),(67,'Gustavo','Barba Completa','2022-02-23 00:30:42',40,64,160),(68,'Jaz','Barba Completa','2022-02-23 00:36:45',40,64,160),(69,'Gustavo','Barba Completa','2022-02-23 00:38:09',40,64,160),(70,'Saul','Corte de Niño','2022-02-23 00:39:31',50,60,120),(71,'Keila','Corte de Niño','2022-02-23 00:43:40',40,48,120),(72,'Gustavo','Barba Completa','2022-02-23 00:46:03',40,64,160),(73,'Gustavo','Corte con Navajas','2022-02-23 00:50:05',40,68,170),(74,'Saul','Barba Completa','2022-02-23 00:51:10',50,80,160),(75,'Saul','Corte de Niño','2022-02-23 00:53:01',50,60,120),(76,'Gustavo','Barba Completa','2022-02-23 00:54:17',40,64,160),(77,'Saul','Corte de Niño','2022-02-23 00:56:02',50,60,120),(78,'Gustavo','Corte con Navajas','2022-02-24 19:14:53',40,68,170),(79,'Keila','Barba Media','2022-02-25 10:19:22',40,56,140),(80,'Gustavo','Barba Completa','2022-02-25 11:06:19',40,64,160),(81,'Gustavo','Mascarilla Negra','2022-02-25 11:25:07',40,20,50),(82,'Saul','Facial Exprés','2022-02-25 14:10:42',50,75,150),(83,'Jaz','Mascarilla Negra','2022-02-26 11:16:28',40,20,50),(84,'Jaz','Tinte de Barba','2022-02-26 11:55:08',40,40,100),(85,'Gustavo','Barba Completa','2022-03-15 16:07:45',40,64,160),(86,'Gustavo','Barba Completa','2022-07-20 15:18:04',40,64,160),(87,'Eduardo','Corte de Niño','2022-07-28 18:12:04',40,48,120),(88,'Eduardo','Tinte de Cabello','2022-07-29 00:28:30',40,60,150),(89,'Eduardo','Paquete Premium','2022-07-29 00:29:44',40,140,350),(90,'Saul','Barba Completa','2022-08-08 10:59:45',50,80,160),(91,'Eduardo','Corte de Niño','2022-08-08 11:00:03',40,48,120),(92,'Eduardo','Tinte de Barba','2022-08-09 12:57:09',40,40,100),(94,'Eduardo','Corte de Niño','2022-08-10 21:44:11',40,48,120),(97,'Eduardo','Corte de Cabello','2022-09-21 23:19:04',40,60,150),(98,'Saul','Corte de Niño','2022-10-17 17:48:07',50,60,120),(99,'Eduardo','Barba Completa','2022-10-17 18:33:21',40,64,160),(100,'Jazmin','Corte de Niño','2022-10-18 00:50:22',40,48,120);
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

-- Dump completed on 2022-10-18  1:35:22
