-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: pos_db
-- ------------------------------------------------------
-- Server version	8.0.30

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
-- Table structure for table `deadline`
--

DROP TABLE IF EXISTS `deadline`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `deadline` (
  `date` varchar(45) NOT NULL,
  `sales` int NOT NULL,
  `profit` int NOT NULL,
  `cash` int NOT NULL,
  `card` int NOT NULL,
  `breakfast` int NOT NULL,
  `lunch` int NOT NULL,
  `evening` int NOT NULL,
  PRIMARY KEY (`date`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `deadline`
--

LOCK TABLES `deadline` WRITE;
/*!40000 ALTER TABLE `deadline` DISABLE KEYS */;
INSERT INTO `deadline` VALUES ('08-20',168000,138500,40001,127999,0,0,0),('08-21',375400,219500,114300,261100,0,159300,0),('08-22',183500,111500,85600,97900,183500,0,0);
/*!40000 ALTER TABLE `deadline` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `deadline_menu`
--

DROP TABLE IF EXISTS `deadline_menu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `deadline_menu` (
  `id` int NOT NULL,
  `date` varchar(45) NOT NULL,
  `menu` varchar(45) NOT NULL,
  `count` int NOT NULL,
  `category` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `deadline_menu`
--

LOCK TABLES `deadline_menu` WRITE;
/*!40000 ALTER TABLE `deadline_menu` DISABLE KEYS */;
INSERT INTO `deadline_menu` VALUES (0,'08-21','어묵탕',3,'메인 메뉴'),(1,'08-21','볶이',3,'메인 메뉴'),(2,'08-21','치즈떡볶이',3,'메인 메뉴'),(3,'08-21','순대',3,'메인 메뉴'),(4,'08-22','볶이',10,'메인 메뉴'),(5,'08-22','치즈떡볶이',13,'메인 메뉴'),(6,'08-22','순대',5,'메인 메뉴'),(7,'08-22','어묵탕',8,'메인 메뉴'),(8,'08-22','김말이(3)',1,'튀김'),(9,'08-22','튀김만두(3)',2,'튀김'),(10,'08-22','치즈볼(2)',2,'튀김'),(11,'08-22','고구마튀김',1,'튀김'),(12,'08-22','튀김어묵(6)',5,'튀김'),(13,'08-22','사이다',3,'음료'),(14,'08-22','제로콜라',1,'음료'),(15,'08-22','환타(파인)',2,'음료'),(16,'08-22','콜라',3,'음료'),(17,'08-22','치킨링(10)',1,'튀김');
/*!40000 ALTER TABLE `deadline_menu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `login`
--

DROP TABLE IF EXISTS `login`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `login` (
  `id` varchar(45) NOT NULL,
  `pw` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `login`
--

LOCK TABLES `login` WRITE;
/*!40000 ALTER TABLE `login` DISABLE KEYS */;
INSERT INTO `login` VALUES ('1234','123');
/*!40000 ALTER TABLE `login` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `menu`
--

DROP TABLE IF EXISTS `menu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `menu` (
  `idMenu` int NOT NULL,
  `category` varchar(45) NOT NULL,
  `Name` varchar(45) NOT NULL,
  `Price` int NOT NULL,
  `cost` int NOT NULL,
  PRIMARY KEY (`idMenu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menu`
--

LOCK TABLES `menu` WRITE;
/*!40000 ALTER TABLE `menu` DISABLE KEYS */;
INSERT INTO `menu` VALUES (1,'메인 메뉴','볶이',3200,500),(2,'메인 메뉴','치즈떡볶이',4000,3000),(3,'메인 메뉴','순대',3500,2500),(4,'메인 메뉴','어묵탕',7000,5000),(5,'메인 메뉴','메인',0,0),(6,'메인 메뉴','메인',0,0),(7,'메인 메뉴','메인',0,0),(8,'메인 메뉴','메인',0,0),(9,'메인 메뉴','메인',0,0),(10,'튀김','튀김만두(3)',1500,1000),(11,'튀김','김말이(3)',1500,1000),(12,'튀김','치킨링(10)',1500,1000),(13,'튀김','치즈볼(2)',1000,500),(14,'튀김','고구마튀김',1500,500),(15,'튀김','튀김어묵(6)',1500,1000),(16,'튀김','새우튀김(2)',2000,1000),(17,'튀김','튀김',0,0),(18,'튀김','튀김',0,0),(19,'음료','튀김',0,0),(20,'음료','콜라',1000,500),(21,'음료','사이다',1000,500),(22,'음료','환타(포도)',1000,500),(23,'음료','환타(파인)',1000,500),(24,'음료','제로콜라',1000,500),(25,'음료','음료',0,0),(26,'음료','음료',0,0),(27,'음료','음료',0,0);
/*!40000 ALTER TABLE `menu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order`
--

DROP TABLE IF EXISTS `order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `order` (
  `idOrder` int NOT NULL,
  `Table` int NOT NULL,
  `Order` varchar(1000) NOT NULL,
  `order_com` varchar(45) NOT NULL,
  `Order_position` varchar(100) NOT NULL,
  PRIMARY KEY (`idOrder`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order`
--

LOCK TABLES `order` WRITE;
/*!40000 ALTER TABLE `order` DISABLE KEYS */;
INSERT INTO `order` VALUES (1,0,'1.볶이.2,2.치즈떡볶이.2,','x','Order\\1.txt'),(2,6,'1.볶이.1,2.어묵탕.1,3.치즈떡볶이.1,4.순대.1,','●','Order\\2.txt'),(3,0,'1.볶이.1,2.치즈떡볶이.1,3.순대.1,','x','Order\\3.txt'),(4,1,'1.볶이.1,2.어묵탕.1,3.순대.1,','x','Order\\4.txt'),(5,9,'1.볶이.1,2.치즈떡볶이.1,3.어묵탕.1,','x','Order\\5.txt'),(6,1,'1.볶이.2,2.치즈떡볶이.3,3.어묵탕.4,4.순대.3,5.사이다.3,6.제로콜라.1,7.환타(파인).2,8.콜라.3,10.치즈볼(2).1,11.튀김만두(3).1,12.튀김어묵(6).1,13.치킨링(10).1,','●','Order\\6.txt'),(7,0,'1.볶이.1,2.어묵탕.1,3.치즈떡볶이.1,','●','Order\\7.txt'),(8,1,'1.순대.3,','x','Order\\8.txt'),(9,0,'1.볶이.1,2.치즈떡볶이.1,','x','Order\\9.txt'),(10,1,'1.순대.1,','●','Order\\10.txt'),(11,3,'1.볶이.1,2.어묵탕.1,3.치즈떡볶이.1,','x','Order\\11.txt'),(12,4,'1.치즈떡볶이.3,','x','Order\\12.txt'),(13,3,'1.볶이.1,2.치즈떡볶이.1,','x','Order\\13.txt');
/*!40000 ALTER TABLE `order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `receipt`
--

DROP TABLE IF EXISTS `receipt`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `receipt` (
  `idreceipt` int NOT NULL,
  `Date` varchar(45) NOT NULL,
  `number` int NOT NULL,
  `payment` int NOT NULL,
  `cash` int DEFAULT NULL,
  `card` int DEFAULT NULL,
  `refund` varchar(45) DEFAULT NULL,
  `receipt_position` varchar(100) NOT NULL,
  PRIMARY KEY (`idreceipt`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receipt`
--

LOCK TABLES `receipt` WRITE;
/*!40000 ALTER TABLE `receipt` DISABLE KEYS */;
INSERT INTO `receipt` VALUES (1,'08-21',1,57000,0,57000,'x','Receipt\\08-21-1.txt'),(2,'08-21',2,21400,21400,0,'x','Receipt\\08-21-2.txt'),(3,'08-21',3,17700,17700,0,'x','Receipt\\08-21-3.txt'),(4,'08-21',4,17700,0,10000,'x','Receipt\\08-21-4.txt'),(5,'08-21',5,17700,7700,10000,'x','Receipt\\08-21-5.txt'),(6,'08-21',6,17400,0,17400,'x','Receipt\\08-21-6.txt'),(7,'08-21',7,14200,0,14200,'x','Receipt\\08-21-7.txt'),(8,'08-21',8,17700,17700,0,'x','Receipt\\08-21-8.txt'),(9,'08-21',9,14200,14200,0,'x','Receipt\\08-21-9.txt'),(10,'08-21',10,20900,0,20900,'x','Receipt\\08-21-10.txt'),(11,'08-21',11,14200,0,14200,'x','Receipt\\08-21-11.txt'),(12,'08-21',12,17700,0,17700,'x','Receipt\\08-21-12.txt'),(13,'08-21',13,14200,0,14200,'x','Receipt\\08-21-13.txt'),(14,'08-21',14,17700,0,17700,'x','Receipt\\08-21-14.txt'),(15,'08-21',15,17700,0,17700,'x','Receipt\\08-21-15.txt'),(16,'08-21',16,17700,0,0,'x','Receipt\\08-21-16.txt'),(17,'08-21',17,17700,0,0,'x','Receipt\\08-21-17.txt'),(18,'08-21',18,17700,0,0,'x','Receipt\\08-21-18.txt'),(19,'08-21',19,17700,0,17700,'x','Receipt\\08-21-19.txt'),(20,'08-21',20,17700,0,17700,'x','Receipt\\08-21-20.txt'),(21,'08-21',21,17700,0,17700,'x','Receipt\\08-21-21.txt'),(22,'08-21',22,17700,0,17700,'x','Receipt\\08-21-22.txt'),(23,'08-21',23,17700,0,17700,'x','Receipt\\08-21-23.txt'),(24,'08-21',24,17700,0,17700,'x','Receipt\\08-21-24.txt'),(25,'08-21',25,17700,0,17700,'x','Receipt\\08-21-25.txt'),(26,'08-21',26,17700,17700,0,'x','Receipt\\08-21-26.txt'),(27,'08-21',27,17700,17700,0,'x','Receipt\\08-21-27.txt'),(28,'08-22',1,10700,0,10700,'x','Receipt\\08-22-1.txt'),(29,'08-22',2,14200,14200,0,'x','Receipt\\08-22-2.txt'),(30,'08-22',3,29200,0,29200,'x','Receipt\\08-22-3.txt'),(31,'08-22',4,71400,71400,0,'x','Receipt\\08-22-4.txt'),(32,'08-22',5,14200,0,14200,'x','Receipt\\08-22-5.txt'),(33,'08-22',6,12000,0,12000,'x','Receipt\\08-22-6.txt'),(34,'08-22',7,7200,0,7200,'x','Receipt\\08-22-7.txt'),(35,'08-22',8,14400,0,14400,'x','Receipt\\08-22-8.txt'),(36,'08-22',9,10200,0,10200,'x','Receipt\\08-22-9.txt');
/*!40000 ALTER TABLE `receipt` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `table`
--

DROP TABLE IF EXISTS `table`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `table` (
  `table_num` int NOT NULL,
  `table_name` varchar(45) NOT NULL,
  `table_x` int NOT NULL,
  `table_y` int NOT NULL,
  `table_width` int NOT NULL,
  `table_height` int NOT NULL,
  PRIMARY KEY (`table_num`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `table`
--

LOCK TABLES `table` WRITE;
/*!40000 ALTER TABLE `table` DISABLE KEYS */;
INSERT INTO `table` VALUES (0,'btn_table1',20,20,90,60),(1,'btn_table2',140,20,90,60),(2,'btn_table3',260,20,90,60),(3,'btn_table4',380,20,90,60),(4,'btn_table5',500,20,90,60),(5,'btn_table6',20,110,90,60),(6,'btn_table7',140,110,90,60),(7,'btn_table8',260,110,90,60),(8,'btn_table9',380,110,90,60),(9,'btn_table10',378,360,90,60),(10,'btn_table11',20,200,90,60),(11,'btn_table12',140,200,90,60),(12,'btn_table13',260,200,90,60),(13,'btn_table14',380,200,90,60),(14,'btn_table15',500,200,90,60),(15,'btn_table16',20,290,90,60);
/*!40000 ALTER TABLE `table` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-08-22 12:22:14
