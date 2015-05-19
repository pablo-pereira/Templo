-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         5.6.24-log - MySQL Community Server (GPL)
-- SO del servidor:              Win64
-- HeidiSQL Versión:             9.1.0.4867
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Volcando estructura de base de datos para templo
CREATE DATABASE IF NOT EXISTS `templo` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `templo`;


-- Volcando estructura para tabla templo.actividades
CREATE TABLE IF NOT EXISTS `actividades` (
  `idActividad` int(11) NOT NULL AUTO_INCREMENT,
  `idDepartamento` int(11) DEFAULT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  `descripcion` text,
  `requeridos` int(100) DEFAULT NULL,
  `dificultad` int(100) DEFAULT NULL,
  PRIMARY KEY (`idActividad`),
  KEY `FK__departamentos` (`idDepartamento`),
  CONSTRAINT `FK__departamentos` FOREIGN KEY (`idDepartamento`) REFERENCES `departamentos` (`idDepartamento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla templo.actividades: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `actividades` DISABLE KEYS */;
/*!40000 ALTER TABLE `actividades` ENABLE KEYS */;


-- Volcando estructura para tabla templo.candidatos
CREATE TABLE IF NOT EXISTS `candidatos` (
  `idCandidatos` int(11) NOT NULL AUTO_INCREMENT,
  `idVotacion` int(11) DEFAULT NULL,
  `idMiembro` int(11) DEFAULT NULL,
  `cantidadVotos` int(255) DEFAULT NULL,
  PRIMARY KEY (`idCandidatos`),
  KEY `FK_candidatos_votaciones` (`idVotacion`),
  KEY `FK_candidatos_miembros` (`idMiembro`),
  CONSTRAINT `FK_candidatos_miembros` FOREIGN KEY (`idMiembro`) REFERENCES `miembros` (`idMiembro`),
  CONSTRAINT `FK_candidatos_votaciones` FOREIGN KEY (`idVotacion`) REFERENCES `votaciones` (`idVotacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla templo.candidatos: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `candidatos` DISABLE KEYS */;
/*!40000 ALTER TABLE `candidatos` ENABLE KEYS */;


-- Volcando estructura para tabla templo.cargos
CREATE TABLE IF NOT EXISTS `cargos` (
  `idCargo` int(11) NOT NULL AUTO_INCREMENT,
  `idDepartamento` int(11) DEFAULT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  `descripcion` text,
  `cupo` int(10) DEFAULT NULL,
  `mayoriaSimple` tinyint(1) DEFAULT NULL,
  `mitadMasUno` tinyint(1) DEFAULT NULL,
  `miembroJunta` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idCargo`),
  KEY `FK_cargos_departamentos` (`idDepartamento`),
  CONSTRAINT `FK_cargos_departamentos` FOREIGN KEY (`idDepartamento`) REFERENCES `departamentos` (`idDepartamento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla templo.cargos: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `cargos` DISABLE KEYS */;
/*!40000 ALTER TABLE `cargos` ENABLE KEYS */;


-- Volcando estructura para tabla templo.departamentos
CREATE TABLE IF NOT EXISTS `departamentos` (
  `idDepartamento` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `descripcion` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`idDepartamento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla templo.departamentos: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `departamentos` DISABLE KEYS */;
/*!40000 ALTER TABLE `departamentos` ENABLE KEYS */;


-- Volcando estructura para tabla templo.integrantescomnom
CREATE TABLE IF NOT EXISTS `integrantescomnom` (
  `idIntegrantesComNom` int(11) NOT NULL AUTO_INCREMENT,
  `idSesion` int(11) DEFAULT NULL,
  `idMiembro` int(11) DEFAULT NULL,
  `presente` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idIntegrantesComNom`),
  KEY `FK_integrantescomnom_sesiones` (`idSesion`),
  KEY `FK_integrantescomnom_miembros` (`idMiembro`),
  CONSTRAINT `FK_integrantescomnom_miembros` FOREIGN KEY (`idMiembro`) REFERENCES `miembros` (`idMiembro`),
  CONSTRAINT `FK_integrantescomnom_sesiones` FOREIGN KEY (`idSesion`) REFERENCES `sesiones` (`idSesion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla templo.integrantescomnom: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `integrantescomnom` DISABLE KEYS */;
/*!40000 ALTER TABLE `integrantescomnom` ENABLE KEYS */;


-- Volcando estructura para tabla templo.miembros
CREATE TABLE IF NOT EXISTS `miembros` (
  `idMiembro` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `apellido` varchar(100) DEFAULT NULL,
  `telefono` varchar(50) DEFAULT NULL,
  `mail` varchar(100) DEFAULT NULL,
  `direccion` varchar(200) DEFAULT NULL,
  `fechaBaja` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`idMiembro`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla templo.miembros: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `miembros` DISABLE KEYS */;
/*!40000 ALTER TABLE `miembros` ENABLE KEYS */;


-- Volcando estructura para tabla templo.ocupa
CREATE TABLE IF NOT EXISTS `ocupa` (
  `idOcupa` int(11) NOT NULL AUTO_INCREMENT,
  `idCargo` int(11) DEFAULT NULL,
  `idMiembro` int(11) DEFAULT NULL,
  `fechaDesde` datetime(6) DEFAULT NULL,
  `fechaHasta` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`idOcupa`),
  KEY `FK_ocupa_cargos` (`idCargo`),
  KEY `FK_ocupa_miembros` (`idMiembro`),
  CONSTRAINT `FK_ocupa_cargos` FOREIGN KEY (`idCargo`) REFERENCES `cargos` (`idCargo`),
  CONSTRAINT `FK_ocupa_miembros` FOREIGN KEY (`idMiembro`) REFERENCES `miembros` (`idMiembro`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla templo.ocupa: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `ocupa` DISABLE KEYS */;
/*!40000 ALTER TABLE `ocupa` ENABLE KEYS */;


-- Volcando estructura para tabla templo.planificaciones
CREATE TABLE IF NOT EXISTS `planificaciones` (
  `idPlanificacion` int(11) NOT NULL AUTO_INCREMENT,
  `idActividad` int(11) DEFAULT NULL,
  `idOcupa` int(11) DEFAULT NULL,
  `fecha` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`idPlanificacion`),
  KEY `FK_planificaciones_actividades` (`idActividad`),
  KEY `FK_planificaciones_ocupa` (`idOcupa`),
  CONSTRAINT `FK_planificaciones_actividades` FOREIGN KEY (`idActividad`) REFERENCES `actividades` (`idActividad`),
  CONSTRAINT `FK_planificaciones_ocupa` FOREIGN KEY (`idOcupa`) REFERENCES `ocupa` (`idOcupa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla templo.planificaciones: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `planificaciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `planificaciones` ENABLE KEYS */;


-- Volcando estructura para tabla templo.sesiones
CREATE TABLE IF NOT EXISTS `sesiones` (
  `idSesion` int(11) NOT NULL AUTO_INCREMENT,
  `fechaHoraInicio` datetime(6) DEFAULT NULL,
  `fechaHoraFin` datetime(6) DEFAULT NULL,
  `primeraOracion` varchar(100) DEFAULT NULL,
  `segundaOracion` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idSesion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla templo.sesiones: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `sesiones` DISABLE KEYS */;
/*!40000 ALTER TABLE `sesiones` ENABLE KEYS */;


-- Volcando estructura para tabla templo.votaciones
CREATE TABLE IF NOT EXISTS `votaciones` (
  `idVotacion` int(11) NOT NULL AUTO_INCREMENT,
  `idSesion` int(11) DEFAULT NULL,
  `idCargo` int(11) DEFAULT NULL,
  `confirmado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idVotacion`),
  KEY `FK_votaciones_sesiones` (`idSesion`),
  KEY `FK_votaciones_cargos` (`idCargo`),
  CONSTRAINT `FK_votaciones_cargos` FOREIGN KEY (`idCargo`) REFERENCES `cargos` (`idCargo`),
  CONSTRAINT `FK_votaciones_sesiones` FOREIGN KEY (`idSesion`) REFERENCES `sesiones` (`idSesion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla templo.votaciones: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `votaciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `votaciones` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
