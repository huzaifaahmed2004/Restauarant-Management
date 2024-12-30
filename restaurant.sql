-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: localhost    Database: restaurantdb
-- ------------------------------------------------------
-- Server version	8.0.39

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `menu`
--

DROP TABLE IF EXISTS `menu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `menu` (
  `ItemID` int NOT NULL AUTO_INCREMENT,
  `ItemName` varchar(100) NOT NULL,
  `Price` decimal(10,2) NOT NULL,
  `Category` varchar(50) NOT NULL,
  `ImagePath` varchar(255) DEFAULT NULL,
  `IsActive` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`ItemID`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menu`
--

LOCK TABLES `menu` WRITE;
/*!40000 ALTER TABLE `menu` DISABLE KEYS */;
INSERT INTO `menu` VALUES (1,'Iced Tea',300.00,'Beverage','Images\\iced_tea.jpeg',1),(2,'Burger',599.00,'Main Course','Images\\burger.jpeg',1),(3,'Pizza',899.00,'Main Course','Images\\pizza.jpeg',1),(4,'Salad',250.00,'Side','Images\\salad.jpeg',1),(8,'Spaghetti',649.00,'Main Course','Images\\spaghetti.jpeg',1),(9,'Grilled Chicken',1099.00,'Main Course','Images\\grilled_chicken.jpeg',1),(10,'French Fries',349.00,'Sides','Images\\fries.jpeg',1),(11,'Ice Cream',199.00,'Desserts','Images\\ice_cream.jpeg',1),(12,'Apple Pie',5.49,'Desserts','Images\\apple_pie.jpeg',0),(13,'Coca-Cola',99.00,'Beverages','Images\\coca_cola.jpeg',1),(14,'Lemonade',250.00,'Beverages','Images\\lemonade.jpeg',1),(16,'Apple Pie',500.00,'Desserts','Images\\apple_pie.jpeg',1);
/*!40000 ALTER TABLE `menu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderdetails`
--

DROP TABLE IF EXISTS `orderdetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orderdetails` (
  `OrderDetailID` int NOT NULL AUTO_INCREMENT,
  `OrderID` int DEFAULT NULL,
  `ItemID` int DEFAULT NULL,
  `Quantity` int NOT NULL,
  `Price` decimal(10,2) NOT NULL,
  PRIMARY KEY (`OrderDetailID`),
  KEY `OrderID` (`OrderID`),
  KEY `ItemID` (`ItemID`),
  CONSTRAINT `orderdetails_ibfk_1` FOREIGN KEY (`OrderID`) REFERENCES `orders` (`OrderID`),
  CONSTRAINT `orderdetails_ibfk_2` FOREIGN KEY (`ItemID`) REFERENCES `menu` (`ItemID`)
) ENGINE=InnoDB AUTO_INCREMENT=192 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderdetails`
--

LOCK TABLES `orderdetails` WRITE;
/*!40000 ALTER TABLE `orderdetails` DISABLE KEYS */;
INSERT INTO `orderdetails` VALUES (137,21,1,2,300.00),(138,21,2,1,599.00),(139,22,3,1,899.00),(140,23,4,3,250.00),(141,24,8,2,649.00),(142,25,9,1,1099.00),(143,26,10,4,349.00),(144,27,11,1,199.00),(145,28,12,2,5.49),(146,29,13,3,99.00),(147,30,14,1,250.00),(148,31,16,2,500.00),(149,32,1,1,300.00),(150,33,2,2,599.00),(151,34,3,3,899.00),(152,35,4,1,250.00),(153,36,8,2,649.00),(154,37,9,1,1099.00),(155,38,10,1,349.00),(156,39,11,2,199.00),(157,40,12,3,5.49),(158,41,13,1,99.00),(159,42,14,2,250.00),(160,43,16,2,500.00),(161,44,1,3,300.00),(162,45,2,2,599.00),(163,46,3,4,899.00),(164,47,4,2,250.00),(165,48,8,1,649.00),(166,49,9,1,1099.00),(167,50,10,1,349.00),(168,51,11,2,199.00),(169,52,12,3,5.49),(170,53,13,1,99.00),(171,54,14,3,250.00),(172,55,16,4,500.00),(173,56,1,2,300.00),(174,57,2,1,599.00),(175,58,3,1,899.00),(176,59,4,1,250.00),(177,60,8,2,649.00),(178,61,9,1,1099.00),(179,62,10,2,349.00),(180,63,11,1,199.00),(181,64,12,1,5.49),(182,65,13,1,99.00),(183,66,14,1,250.00),(184,67,16,2,500.00),(185,68,1,3,300.00),(186,69,2,4,599.00),(187,70,3,1,899.00),(188,71,3,2,1798.00),(189,71,8,3,1947.00),(190,71,10,1,349.00),(191,72,3,3,2697.00);
/*!40000 ALTER TABLE `orderdetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `OrderID` int NOT NULL AUTO_INCREMENT,
  `OrderTime` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `OrderStatus` varchar(50) DEFAULT 'Pending',
  PRIMARY KEY (`OrderID`)
) ENGINE=InnoDB AUTO_INCREMENT=73 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (21,'2024-12-30 03:30:00','Completed'),(22,'2024-12-30 04:00:00','Completed'),(23,'2024-12-30 04:30:00','Pending'),(24,'2024-12-30 05:00:00','Completed'),(25,'2024-12-30 05:30:00','Cancelled'),(26,'2024-12-30 06:00:00','Completed'),(27,'2024-12-30 06:30:00','Completed'),(28,'2024-12-30 07:00:00','Pending'),(29,'2024-12-30 07:30:00','Completed'),(30,'2024-12-30 08:00:00','Cancelled'),(31,'2024-12-30 08:30:00','Completed'),(32,'2024-12-30 09:00:00','Pending'),(33,'2024-12-30 09:30:00','Completed'),(34,'2024-12-30 10:00:00','Completed'),(35,'2024-12-30 10:30:00','Cancelled'),(36,'2024-12-29 17:30:00','Completed'),(37,'2024-12-29 18:00:00','Pending'),(38,'2024-12-29 18:30:00','Completed'),(39,'2024-12-29 13:30:00','Completed'),(40,'2024-12-29 14:00:00','Pending'),(41,'2024-12-29 14:30:00','Cancelled'),(42,'2024-12-28 17:00:00','Completed'),(43,'2024-12-28 17:30:00','Cancelled'),(44,'2024-12-28 18:00:00','Completed'),(45,'2024-12-28 18:30:00','Pending'),(46,'2024-12-27 16:00:00','Completed'),(47,'2024-12-27 16:30:00','Completed'),(48,'2024-12-27 17:00:00','Pending'),(49,'2024-12-27 17:30:00','Cancelled'),(50,'2024-12-26 13:00:00','Completed'),(51,'2024-12-26 13:30:00','Completed'),(52,'2024-12-26 14:00:00','Cancelled'),(53,'2024-12-26 14:30:00','Completed'),(54,'2024-12-25 12:30:00','Completed'),(55,'2024-12-25 13:00:00','Cancelled'),(56,'2024-12-25 13:30:00','Completed'),(57,'2024-12-25 14:00:00','Pending'),(58,'2024-12-24 15:00:00','Completed'),(59,'2024-12-24 15:30:00','Cancelled'),(60,'2024-12-24 16:00:00','Completed'),(61,'2024-12-24 16:30:00','Pending'),(62,'2024-12-23 14:00:00','Completed'),(63,'2024-12-23 14:30:00','Completed'),(64,'2024-12-23 15:00:00','Cancelled'),(65,'2024-12-23 15:30:00','Completed'),(66,'2024-12-23 16:00:00','Pending'),(67,'2024-12-23 16:30:00','Completed'),(68,'2024-12-23 17:00:00','Cancelled'),(69,'2024-12-23 17:30:00','Completed'),(70,'2024-12-22 18:00:00','Completed'),(71,'2024-12-30 15:00:30','Pending'),(72,'2024-12-30 15:01:04','Pending');
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payments`
--

DROP TABLE IF EXISTS `payments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payments` (
  `PaymentID` int NOT NULL AUTO_INCREMENT,
  `OrderID` int DEFAULT NULL,
  `PaymentAmount` decimal(10,2) NOT NULL,
  `PaymentStatus` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`PaymentID`),
  KEY `OrderID` (`OrderID`),
  CONSTRAINT `payments_ibfk_1` FOREIGN KEY (`OrderID`) REFERENCES `orders` (`OrderID`)
) ENGINE=InnoDB AUTO_INCREMENT=118 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payments`
--

LOCK TABLES `payments` WRITE;
/*!40000 ALTER TABLE `payments` DISABLE KEYS */;
INSERT INTO `payments` VALUES (81,21,899.00,'Completed'),(82,22,1498.00,'Completed'),(83,23,2499.00,'Completed'),(84,24,649.00,'Completed'),(85,25,249.00,'Cancelled'),(86,26,1498.00,'Completed'),(87,27,1498.00,'Completed'),(88,28,249.00,'Completed'),(89,29,199.00,'Completed'),(90,30,349.00,'Cancelled'),(91,31,1099.00,'Completed'),(92,32,649.00,'Completed'),(93,33,699.00,'Completed'),(94,34,1998.00,'Completed'),(95,35,349.00,'Cancelled'),(96,36,349.00,'Completed'),(97,37,199.00,'Completed'),(98,38,2499.00,'Completed'),(99,39,249.00,'Completed'),(100,40,249.00,'Completed'),(101,41,249.00,'Cancelled'),(102,42,1498.00,'Completed'),(103,43,249.00,'Cancelled'),(104,44,1498.00,'Completed'),(105,45,249.00,'Pending'),(106,46,2499.00,'Completed'),(107,47,2499.00,'Completed'),(108,48,249.00,'Pending'),(109,49,249.00,'Cancelled'),(110,50,649.00,'Completed'),(111,51,649.00,'Completed'),(112,52,249.00,'Cancelled'),(113,53,649.00,'Completed'),(114,54,199.00,'Completed'),(115,55,199.00,'Cancelled'),(116,71,4094.00,'Completed'),(117,72,2697.00,'Completed');
/*!40000 ALTER TABLE `payments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `UserID` int NOT NULL AUTO_INCREMENT,
  `Username` varchar(100) NOT NULL,
  `Password` varchar(100) NOT NULL,
  `Role` varchar(50) NOT NULL,
  `DateCreated` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (4,'admin','240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9','Admin','2024-12-29 09:03:15'),(5,'cashier','b4c94003c562bb0d89535eca77f07284fe560fd48a7cc1ed99f0a56263d616ba','Cashier','2024-12-29 09:03:15'),(6,'staff','2f005e42a17da46ec51ba6f11d725e60788931a1dadd33d9cb85084fb32bb166','Kitchen Staff','2024-12-29 09:03:15'),(7,'farhan','ab8e0ab4f66d755d955ff302d94ae83e02a0e46bc8f217751afa458cfa7e0b42','Kitchen Staff','2024-12-30 07:24:23');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-12-30 20:05:01
