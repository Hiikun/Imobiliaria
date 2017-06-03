DROP DATABASE IF EXISTS `imobiliaria`;
CREATE DATABASE  IF NOT EXISTS `imobiliaria` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `imobiliaria`;
-- MySQL dump 10.13  Distrib 5.6.13, for Win32 (x86)
--
-- Host: 127.0.0.1    Database: imobiliaria
-- ------------------------------------------------------
-- Server version	5.5.5-10.1.13-MariaDB

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
-- Table structure for table `alugueis`
--

DROP TABLE IF EXISTS `alugueis`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `alugueis` (
  `id_locacao` int(11) NOT NULL,
  `data_vencimento` date NOT NULL,
  `valor_pago` decimal(10,2) DEFAULT NULL,
  `data_pagamento` date DEFAULT NULL,
  `obs` text,
  PRIMARY KEY (`id_locacao`,`data_vencimento`),
  CONSTRAINT `fk_ALUGUEIS_LOCACAO1` FOREIGN KEY (`id_locacao`) REFERENCES `locacao` (`id_locacao`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alugueis`
--

LOCK TABLES `alugueis` WRITE;
/*!40000 ALTER TABLE `alugueis` DISABLE KEYS */;
/*!40000 ALTER TABLE `alugueis` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clientes` (
  `id_cliente` smallint(6) NOT NULL AUTO_INCREMENT,
  `nome_cliente` varchar(255) DEFAULT NULL,
  `cpf` varchar(15) DEFAULT NULL,
  `rg` varchar(15) DEFAULT NULL,
  `endereco_completo` text,
  `cep` varchar(9) DEFAULT NULL,
  `telefone1` varchar(15) DEFAULT NULL,
  `telefone2` varchar(15) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `dt_nascimento` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `funcionarios`
--

DROP TABLE IF EXISTS `funcionarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `funcionarios` (
  `funid` int(11) NOT NULL AUTO_INCREMENT,
  `funnome` varchar(100) DEFAULT NULL,
  `funlogin` varchar(16) DEFAULT NULL,
  `funsenha` varchar(32) DEFAULT NULL,
  `funtipo` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`funid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `funcionarios`
--

LOCK TABLES `funcionarios` WRITE;
/*!40000 ALTER TABLE `funcionarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `funcionarios` ENABLE KEYS */;
UNLOCK TABLES;

INSERT INTO funcionarios
(funid, funnome, funlogin, funsenha, funtipo)
VALUES
('1', 'adminn', 'adminn', '9c1ad00a16a7c67e2727b471ac969e96', 'Administrador'),
('2', 'usuario', 'usuario', 'f8032d5cae3de20fcec887f395ec9a6a', 'Usuario');


--
-- Table structure for table `imoveis`
--

DROP TABLE IF EXISTS `imoveis`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `imoveis` (
  `id_imovel` smallint(6) NOT NULL AUTO_INCREMENT,
  `id_cliente` smallint(6) NOT NULL,
  `nome_imovel` varchar(256) DEFAULT NULL,
  `endereco` text,
  `bairro` varchar(45) DEFAULT NULL,
  `zona_cidade` varchar(10) DEFAULT NULL,
  `cep` varchar(9) DEFAULT NULL,
  `tipo_imovel` varchar(256) DEFAULT NULL,
  `condominio` bit(1) DEFAULT NULL,
  `metragem` decimal(10,2) DEFAULT NULL,
  `dormitorios` tinyint(4) DEFAULT NULL,
  `banheiros` tinyint(4) DEFAULT NULL,
  `suites` tinyint(4) DEFAULT NULL,
  `vagas_garagem` tinyint(4) DEFAULT NULL,
  `valor_aluguel_sugerido` decimal(10,2) DEFAULT NULL,
  `valor_iptu` decimal(10,2) DEFAULT NULL,
  `requisitos_inquilino` text,
  `obs` text,
  PRIMARY KEY (`id_imovel`),
  KEY `fk_IMOVEIS_CLIENTES_idx` (`id_cliente`),
  CONSTRAINT `fk_IMOVEIS_CLIENTES` FOREIGN KEY (`id_cliente`) REFERENCES `clientes` (`id_cliente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `imoveis`
--

LOCK TABLES `imoveis` WRITE;
/*!40000 ALTER TABLE `imoveis` DISABLE KEYS */;
/*!40000 ALTER TABLE `imoveis` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `locacao`
--

DROP TABLE IF EXISTS `locacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `locacao` (
  `id_locacao` int(11) NOT NULL AUTO_INCREMENT,
  `id_imovel` smallint(6) NOT NULL,
  `id_inquilino` smallint(6) NOT NULL,
  `id_advogado` smallint(6) NOT NULL,
  `valor_aluguel` decimal(10,4) DEFAULT NULL,
  `periodicidade` varchar(10) DEFAULT NULL,
  `percentual_multa` decimal(5,2) DEFAULT NULL,
  `dia_vencimento` tinyint(4) DEFAULT NULL,
  `data_inicio` date DEFAULT NULL,
  `data_fim` date DEFAULT NULL,
  `ativo` bit(1) DEFAULT NULL,
  `responsavel_pagamento` varchar(45) DEFAULT NULL,
  `obs` text,
  PRIMARY KEY (`id_locacao`),
  KEY `fk_LOCACAO_IMOVEIS1_idx` (`id_imovel`),
  KEY `fk_LOCACAO_CLIENTES1_idx` (`id_inquilino`),
  KEY `fk_LOCACAO_PROFISSIONAIS1_idx` (`id_advogado`),
  CONSTRAINT `fk_LOCACAO_CLIENTES1` FOREIGN KEY (`id_inquilino`) REFERENCES `clientes` (`id_cliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_LOCACAO_IMOVEIS1` FOREIGN KEY (`id_imovel`) REFERENCES `imoveis` (`id_imovel`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_LOCACAO_PROFISSIONAIS1` FOREIGN KEY (`id_advogado`) REFERENCES `profissionais` (`id_profissional`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `locacao`
--

LOCK TABLES `locacao` WRITE;
/*!40000 ALTER TABLE `locacao` DISABLE KEYS */;
/*!40000 ALTER TABLE `locacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `profissionais`
--

DROP TABLE IF EXISTS `profissionais`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `profissionais` (
  `id_profissional` smallint(6) NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) DEFAULT NULL,
  `profissao` varchar(45) DEFAULT NULL,
  `telefone1` varchar(15) DEFAULT NULL,
  `telefone2` varchar(15) DEFAULT NULL,
  `valor_hora` decimal(10,2) DEFAULT NULL,
  `obs` text,
  PRIMARY KEY (`id_profissional`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `profissionais`
--

LOCK TABLES `profissionais` WRITE;
/*!40000 ALTER TABLE `profissionais` DISABLE KEYS */;
/*!40000 ALTER TABLE `profissionais` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `servicos_imovel`
--

DROP TABLE IF EXISTS `servicos_imovel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `servicos_imovel` (
  `id_trabalho` smallint(6) NOT NULL AUTO_INCREMENT,
  `id_profissional` smallint(6) NOT NULL,
  `id_imovel` smallint(6) NOT NULL,
  `data_servico` VARCHAR(50) DEFAULT NULL,
  `valor_total` decimal(10,2) DEFAULT NULL,
  `obs` text,
  PRIMARY KEY (`id_trabalho`),
  KEY `fk_SERVICOS_IMOVEL_PROFISSIONAIS1_idx` (`id_profissional`),
  KEY `fk_SERVICOS_IMOVEL_IMOVEIS1_idx` (`id_imovel`),
  CONSTRAINT `fk_SERVICOS_IMOVEL_IMOVEIS1` FOREIGN KEY (`id_imovel`) REFERENCES `imoveis` (`id_imovel`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_SERVICOS_IMOVEL_PROFISSIONAIS1` FOREIGN KEY (`id_profissional`) REFERENCES `profissionais` (`id_profissional`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `servicos_imovel`
--

LOCK TABLES `servicos_imovel` WRITE;
/*!40000 ALTER TABLE `servicos_imovel` DISABLE KEYS */;
/*!40000 ALTER TABLE `servicos_imovel` ENABLE KEYS */;
UNLOCK TABLES;

/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-04-26  0:52:10
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */
