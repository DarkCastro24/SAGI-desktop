-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 20-09-2019 a las 02:11:15
-- Versión del servidor: 10.4.6-MariaDB
-- Versión de PHP: 7.3.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `inmuebles2`
--
CREATE DATABASE IF NOT EXISTS `inmuebles2` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `inmuebles2`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `apartamento`
--

CREATE TABLE `apartamento` (
  `id_apartamento` int(11) NOT NULL,
  `estado` int(1) NOT NULL,
  `id_departamento` int(2) NOT NULL,
  `precio_apartamento` int(8) NOT NULL,
  `descripcion_apar` varchar(200) NOT NULL,
  `direccion_apartamento` varchar(200) NOT NULL,
  `municipio_apar` int(3) NOT NULL,
  `numero_piso_apar` int(2) NOT NULL,
  `numero_cuartos_apar` int(2) NOT NULL,
  `numero_baños_apar` int(2) DEFAULT NULL,
  `area_departamento` int(3) NOT NULL,
  `numero_edificio` int(3) DEFAULT NULL,
  `bloque_edificio` varchar(3) DEFAULT NULL,
  `tipo_apartamento` int(1) NOT NULL,
  `imagen1` longtext DEFAULT NULL,
  `imagen2` longtext DEFAULT NULL,
  `imagen3` longtext DEFAULT NULL,
  `imagen4` longtext DEFAULT NULL,
  `descripcion_edificio` varchar(200) DEFAULT NULL,
  `id_cliente` int(11) NOT NULL,
  `id_empleado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `casa`
--

CREATE TABLE `casa` (
  `id_casa` int(11) NOT NULL,
  `estado` int(1) NOT NULL,
  `id_departamento` int(2) NOT NULL,
  `precio_casa` int(8) NOT NULL,
  `direccion_casa` varchar(200) NOT NULL,
  `descripcion_casa` varchar(200) NOT NULL,
  `municipio_casa` int(3) NOT NULL,
  `numero_pisos_casa` int(2) NOT NULL,
  `numero_cuartos_casa` int(2) NOT NULL,
  `numero_baños_casa` int(2) NOT NULL,
  `area_casa` int(3) NOT NULL,
  `area_terreno` int(3) NOT NULL,
  `numero_garage` int(2) DEFAULT NULL,
  `descripcion_garage` varchar(200) DEFAULT NULL,
  `numero_patio` int(2) DEFAULT NULL,
  `descripcion_patio` varchar(200) DEFAULT NULL,
  `tipoCasa` int(1) NOT NULL,
  `imagen1` longtext DEFAULT NULL,
  `imagen2` longtext DEFAULT NULL,
  `imagen3` longtext DEFAULT NULL,
  `imagen4` longtext DEFAULT NULL,
  `id_cliente` int(11) NOT NULL,
  `id_empleado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cita`
--

CREATE TABLE `cita` (
  `id_cita` int(11) NOT NULL,
  `empleado` int(11) NOT NULL,
  `cliente` int(11) NOT NULL,
  `id_prioridad` int(11) NOT NULL,
  `id_estado` int(11) NOT NULL,
  `asunto` varchar(100) NOT NULL,
  `lugar` varchar(200) NOT NULL,
  `fecha` date NOT NULL,
  `hora` int(2) NOT NULL,
  `min` int(2) NOT NULL,
  `periodo` varchar(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `id_cliente` int(11) NOT NULL,
  `id_genero` int(1) NOT NULL,
  `tipoCliente` int(1) NOT NULL,
  `estadoCivil` int(1) NOT NULL,
  `id_estado` int(1) NOT NULL,
  `nombre_client` varchar(30) NOT NULL,
  `apellido_cliente` varchar(30) NOT NULL,
  `dui` varchar(10) NOT NULL,
  `nacimiento_cliente` date NOT NULL,
  `correo_cliente` varchar(25) NOT NULL,
  `direccion_cliente` varchar(200) NOT NULL,
  `telefono` varchar(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `departamento`
--

CREATE TABLE `departamento` (
  `id_departamento` int(2) NOT NULL,
  `departamento` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `departamento`
--

INSERT INTO `departamento` (`id_departamento`, `departamento`) VALUES
(1, 'Ahuachapan'),
(2, 'Cuscatlan'),
(3, 'Chalatenango'),
(4, 'Cabañas'),
(5, 'La Libertad'),
(6, 'La Paz'),
(7, 'La Union'),
(8, 'Morazan'),
(9, 'San Miguel'),
(10, 'San Salvador'),
(11, 'San Vicente'),
(12, 'Santa Ana'),
(13, 'Sonsonate'),
(14, 'Usulutan');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalleapar`
--

CREATE TABLE `detalleapar` (
  `id_factura` int(11) NOT NULL,
  `apartamento` int(11) NOT NULL,
  `iva` int(2) NOT NULL,
  `subtotal` int(8) NOT NULL,
  `comision` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detallecasa`
--

CREATE TABLE `detallecasa` (
  `id_factura` int(11) NOT NULL,
  `casa` int(11) NOT NULL,
  `iva` int(2) NOT NULL,
  `subtotal` int(8) NOT NULL,
  `comision` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalleterreno`
--

CREATE TABLE `detalleterreno` (
  `id_factura` int(11) NOT NULL,
  `terreno` int(11) NOT NULL,
  `iva` int(2) NOT NULL,
  `subtotal` int(8) NOT NULL,
  `comision` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleados`
--

CREATE TABLE `empleados` (
  `id_empleado` int(11) NOT NULL,
  `id_genero` int(1) NOT NULL,
  `estado` int(1) NOT NULL,
  `tipoUsuario` int(1) NOT NULL,
  `nombre_empl` varchar(30) NOT NULL,
  `apellido_empl` varchar(30) NOT NULL,
  `nacimiento_empl` date NOT NULL,
  `correo_empl` varchar(40) DEFAULT NULL,
  `direccion_empl` varchar(100) DEFAULT NULL,
  `profesion` varchar(30) DEFAULT NULL,
  `usuario` varchar(25) NOT NULL,
  `clave` varchar(100) NOT NULL DEFAULT 'efAdsX436aQfSUcxfwNEbBolhN0=',
  `intentos` int(2) NOT NULL DEFAULT 0,
  `pregunta1` int(2) DEFAULT NULL,
  `pregunta2` int(2) DEFAULT NULL,
  `pregunta3` int(2) DEFAULT NULL,
  `respuesta1` varchar(30) DEFAULT NULL,
  `respuesta2` varchar(30) DEFAULT NULL,
  `respuesta3` varchar(30) DEFAULT NULL,
  `codigo` varchar(10) DEFAULT NULL,
  `codigo_correo` int(4) NOT NULL,
  `id_empresa` int(1) DEFAULT NULL,
  `imagen` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empresa`
--

CREATE TABLE `empresa` (
  `id_empresa` int(11) NOT NULL,
  `empresa` varchar(45) DEFAULT NULL,
  `nit` varchar(17) DEFAULT NULL,
  `representante_legal` varchar(75) DEFAULT NULL,
  `tipoEmpresa` int(1) NOT NULL,
  `direccion` varchar(150) DEFAULT NULL,
  `logoempresa` longtext DEFAULT NULL,
  `correo_empresa` varchar(50) NOT NULL,
  `contraseña_correo` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estadocivil`
--

CREATE TABLE `estadocivil` (
  `id_estadoCivil` int(1) NOT NULL,
  `estado_civil` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `estadocivil`
--

INSERT INTO `estadocivil` (`id_estadoCivil`, `estado_civil`) VALUES
(1, 'Casado'),
(2, 'Soltero'),
(3, 'Divorciado'),
(4, 'Viudo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estadoclien`
--

CREATE TABLE `estadoclien` (
  `id_estado` int(1) NOT NULL,
  `estado_cliente` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `estadoclien`
--

INSERT INTO `estadoclien` (`id_estado`, `estado_cliente`) VALUES
(1, 'Disponible'),
(2, 'No disponible');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estadofactura`
--

CREATE TABLE `estadofactura` (
  `id_estado` int(11) NOT NULL,
  `estado_factura` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `estadofactura`
--

INSERT INTO `estadofactura` (`id_estado`, `estado_factura`) VALUES
(1, 'Pagada'),
(2, 'Generada');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estadopropiedad`
--

CREATE TABLE `estadopropiedad` (
  `id_estado` int(1) NOT NULL,
  `estadoPropiedad` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `estadopropiedad`
--

INSERT INTO `estadopropiedad` (`id_estado`, `estadoPropiedad`) VALUES
(1, 'Disponible'),
(2, 'No disponible');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estadousuario`
--

CREATE TABLE `estadousuario` (
  `id_estado` int(1) NOT NULL,
  `estado_usuario` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `estadousuario`
--

INSERT INTO `estadousuario` (`id_estado`, `estado_usuario`) VALUES
(1, 'Activo'),
(2, 'Inactivo'),
(3, 'Bloqueado');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estado_cita`
--

CREATE TABLE `estado_cita` (
  `id_estadoCita` int(11) NOT NULL,
  `estado_cita` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `estado_cita`
--

INSERT INTO `estado_cita` (`id_estadoCita`, `estado_cita`) VALUES
(1, 'Pendiente'),
(3, 'Cancelada'),
(4, 'Finalizada');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `facturaapar`
--

CREATE TABLE `facturaapar` (
  `id_facturaApar` int(11) NOT NULL,
  `cliente` int(11) NOT NULL,
  `empleado` int(11) NOT NULL,
  `estado` int(11) NOT NULL,
  `detalle` int(11) NOT NULL,
  `total` double(7,2) NOT NULL,
  `fecha_de_factura` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `facturacasa`
--

CREATE TABLE `facturacasa` (
  `id_facturaCasa` int(11) NOT NULL,
  `cliente` int(11) NOT NULL,
  `empleado` int(11) NOT NULL,
  `estado` int(11) NOT NULL,
  `total` double(7,2) NOT NULL,
  `fecha_de_factura` date NOT NULL,
  `detalle` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `facturaterreno`
--

CREATE TABLE `facturaterreno` (
  `id_facturaTerr` int(11) NOT NULL,
  `cliente` int(11) NOT NULL,
  `empleado` int(11) NOT NULL,
  `estado` int(11) NOT NULL,
  `total` double(7,2) NOT NULL,
  `fecha_de_factura` date NOT NULL,
  `detalle` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `municipios`
--

CREATE TABLE `municipios` (
  `id_municipio` int(3) NOT NULL,
  `id_departamento` int(3) NOT NULL,
  `municipio` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `municipios`
--

INSERT INTO `municipios` (`id_municipio`, `id_departamento`, `municipio`) VALUES
(1, 1, 'Apaneca'),
(2, 1, 'Atiquizaya'),
(3, 1, 'Concepción de Ataco'),
(4, 1, 'El Refugio'),
(5, 1, 'Guaymango'),
(6, 1, 'El Refugio'),
(7, 1, 'Guaymango'),
(8, 1, 'El Refugio'),
(9, 1, 'Jujutla'),
(10, 2, 'Sensuntepeque'),
(11, 2, 'Ilobasco'),
(12, 2, 'Tejutepeque'),
(13, 2, 'Victoria'),
(14, 2, 'Jutiapa'),
(15, 2, 'San Isidro'),
(16, 2, 'Dolores'),
(17, 3, 'Chalatenago'),
(18, 3, 'Agua Caliente'),
(19, 3, 'Arcatao'),
(20, 3, 'Azacualpa'),
(21, 3, 'Cancasque'),
(22, 3, 'Citala'),
(23, 3, 'Comalapa'),
(24, 3, 'Concepcion Quezaltepeque'),
(25, 3, 'Dulce nombre de maria'),
(26, 3, 'El Carrizal'),
(27, 3, 'El Paraiso'),
(28, 3, 'La laguna'),
(29, 3, 'La laguna'),
(30, 3, 'La palma'),
(31, 3, 'La reina'),
(32, 3, 'Las Flores'),
(33, 3, 'Las vueltas'),
(34, 3, 'Nombre de jesus'),
(35, 3, 'Nueva Concepcion'),
(36, 3, 'Nueva trinidad'),
(37, 3, 'Ojos de agua'),
(38, 3, 'Potonico'),
(39, 3, 'San Antonio de la cruz'),
(40, 3, 'San Antonio Los Ranchos'),
(41, 3, 'San Fernando'),
(42, 3, 'San Francisco Lempa'),
(43, 3, 'San Francisco Morazan'),
(44, 3, 'San Ignacio'),
(45, 3, 'San Isidro Labrador'),
(46, 3, 'San Luis del Carmen'),
(47, 3, 'San Miguel de mercedes'),
(48, 3, 'San Rafael'),
(49, 3, 'Santa Rita'),
(50, 3, 'Tejutla'),
(51, 4, 'Cojutepeque'),
(52, 4, 'Candelaria'),
(53, 4, 'El carmen'),
(54, 4, 'El rosario'),
(55, 4, 'Monte San Juan'),
(56, 4, 'Oratorio de Concepcion'),
(57, 4, 'San Bartolome Perulapia'),
(58, 4, 'San cristobal'),
(59, 4, 'San jose guayabal'),
(60, 4, 'San Pedro Perulapan'),
(61, 4, 'San Rafael cedros'),
(62, 4, 'San Ramon'),
(63, 4, 'Santa Cruz Analquito'),
(64, 4, 'Santa Cruz Michalpa'),
(65, 4, 'Suchitoto'),
(66, 4, 'Tenancingo'),
(67, 5, 'San Tecla'),
(68, 5, 'Antiguo Cuscatlan'),
(69, 5, 'Chiltiupan'),
(70, 5, 'Cuidad Arce'),
(71, 5, 'Colon'),
(72, 5, 'Comasagua'),
(73, 5, 'Huizucar'),
(74, 5, 'Jayaque'),
(75, 5, 'Jicalapa'),
(76, 5, 'La libertad'),
(77, 5, 'Nuevo Cuscatlan'),
(78, 5, 'Quezaltepeque'),
(79, 5, 'San Juan Opico'),
(80, 5, 'Sacacoyo'),
(81, 5, 'San Jose Villanueva'),
(82, 5, 'San Matias'),
(83, 5, 'San Pablo Tacachico'),
(84, 5, 'Talnique'),
(85, 5, 'Tamanique'),
(86, 5, 'Teotepeque'),
(87, 5, 'Tepecoyo'),
(88, 5, 'Zaragoza'),
(89, 6, 'Zacatecoluca'),
(90, 6, 'Cuyultitlan'),
(91, 6, 'El rosario'),
(92, 6, 'Jerusalen'),
(93, 6, 'Mercedes la ceiba'),
(94, 6, 'Olocuilta'),
(95, 6, 'Paraiso de Osorio'),
(96, 6, 'San Antonio Masahuat'),
(97, 6, 'San Emigdio'),
(98, 6, 'San Francisco Chinameca'),
(99, 6, 'San Pedro Masahuat'),
(100, 6, 'San Juan Noualco'),
(101, 6, 'San Juan Talpa'),
(102, 6, 'San Juan Tepezontes'),
(103, 6, 'San Luis la herradura'),
(104, 6, 'San luis talapa'),
(105, 6, 'San Miguel Tepezontes'),
(106, 6, 'San pedro nonualco'),
(107, 6, 'San rafael obrajuelo'),
(108, 6, 'Santa Maria Ostuma'),
(109, 6, 'Santiago Nonualco'),
(110, 6, 'Tapalhuaca'),
(111, 7, 'La union'),
(112, 7, 'Anamoros'),
(113, 7, 'Bolivar'),
(114, 7, 'Concepcion de Oriente'),
(115, 7, 'Conchagua'),
(116, 7, 'El Carmen'),
(117, 7, 'El Sauce'),
(118, 7, 'Intipuca'),
(119, 7, 'Lislique'),
(120, 7, 'Meanguera'),
(121, 7, 'Nueva Esparta'),
(122, 7, 'Pasaquina'),
(123, 7, 'Poloros'),
(124, 7, 'San Alejo'),
(125, 7, 'San Jose'),
(126, 7, 'Santa Rosa de lima'),
(127, 7, 'Yayantique'),
(128, 7, 'Yacuaiquin'),
(129, 8, 'San Franciso Gotera'),
(130, 8, 'Arambala'),
(131, 8, 'Cacaopera'),
(132, 8, 'Chilanga'),
(133, 8, 'Corinto'),
(134, 8, 'Delicias de concepcion'),
(135, 8, 'El divisadero'),
(136, 8, 'El rosario'),
(137, 8, 'Gualocolti'),
(138, 8, 'Guatajiagua'),
(139, 8, 'Joateca'),
(140, 8, 'Jocoaitique'),
(141, 8, 'Jocoro'),
(142, 8, 'Lolotiquillo'),
(143, 8, 'Meanguera'),
(144, 8, 'Osicala'),
(145, 8, 'Perquin'),
(146, 8, 'San Carlos'),
(147, 8, 'San Fernando'),
(148, 8, 'San Isidro'),
(149, 8, 'San Simon'),
(150, 8, 'Sensembra'),
(151, 8, 'Sociedad'),
(152, 8, 'Torola'),
(153, 8, 'Yamabal'),
(154, 9, 'San Miguel'),
(155, 9, 'Carolina'),
(156, 9, 'Chapeltique'),
(157, 9, 'Chinameca'),
(158, 9, 'Chirilagua'),
(159, 9, 'Ciudad Barrios'),
(160, 9, 'Camacaran'),
(161, 9, 'El transito'),
(162, 9, 'Lolotique'),
(163, 9, 'Moncagua'),
(164, 9, 'Nueva Guadalupe'),
(165, 9, 'Quelepa'),
(166, 9, 'San antonio'),
(167, 9, 'San gerardo'),
(168, 9, 'San jorge'),
(169, 9, 'San luis de la reina'),
(170, 9, 'San rafael de oriente'),
(171, 9, 'Sesori'),
(172, 9, 'Uluazapa'),
(173, 10, 'San Salvador'),
(174, 10, 'Aguilares'),
(175, 10, 'Apopa'),
(176, 10, 'Ayututepeque'),
(177, 10, 'Cuscatancingo'),
(178, 10, 'Delgado'),
(179, 10, 'El paisnal'),
(180, 10, 'Guazapa'),
(181, 10, 'Ilopango'),
(182, 10, 'Mejicanos'),
(183, 10, 'Nejapa'),
(184, 10, 'Panchimalco'),
(185, 10, 'Rosario de mora'),
(186, 10, 'San Marcos'),
(187, 10, 'San Martin'),
(188, 10, 'Santiago Texacuangos'),
(189, 10, 'Santo Tomas'),
(190, 10, 'Soyapango'),
(191, 10, 'Tonacatepeque'),
(192, 11, 'San Vicente'),
(193, 11, 'Apastepeque'),
(194, 11, 'Guadalupe'),
(195, 11, 'San Cayetano Istepeque'),
(196, 11, 'San Esteban Catarina'),
(197, 11, 'San Iidefonso'),
(198, 11, 'San Lorenzo'),
(199, 11, 'San Sebastian'),
(200, 11, 'Santa Clara'),
(201, 11, 'San Sebastian'),
(202, 11, 'Santa Clara'),
(203, 11, 'Santo domingo'),
(204, 11, 'Tecolupa'),
(205, 11, 'Tepetitan'),
(206, 11, 'Verapaz'),
(207, 12, 'Santa Ana'),
(208, 12, 'Candelaria de la Frontera'),
(209, 12, 'Chalchupa'),
(210, 12, 'Coatepeque'),
(211, 12, 'El Congo'),
(212, 12, 'El Porvenir'),
(213, 12, 'Masahuat'),
(214, 12, 'Metapan'),
(215, 12, 'San Antonio Pajonal'),
(216, 12, 'San Sebastian Salitrillo'),
(217, 12, 'Santa Rosa Guachipilin'),
(218, 12, 'Santiago de la Frontera'),
(219, 12, 'Texistepeque'),
(220, 13, 'Sonsonate'),
(221, 13, 'Acajutla'),
(222, 13, 'Armenia'),
(223, 13, 'Caluco'),
(224, 13, 'Cuisnahuat'),
(225, 13, 'Izalco'),
(226, 13, 'Juayua'),
(227, 13, 'Nahuizalco'),
(228, 13, 'Nahulingo'),
(229, 13, 'Salcoatitlan'),
(230, 13, 'San Antonio del Monte'),
(231, 13, 'San Julian'),
(232, 13, 'Santa Catarina Masahuat'),
(233, 13, 'Santa Isabel Ishuatan'),
(234, 13, 'Santo domingo de guzman'),
(235, 13, 'Sonzacate'),
(236, 14, 'Usulutan'),
(237, 14, 'Alegria'),
(238, 14, 'Berlin'),
(239, 14, 'California'),
(240, 14, 'Concepcion Batres'),
(241, 14, 'El Triunfo'),
(242, 14, 'Ereguayquin'),
(243, 14, 'Estanzuelas'),
(244, 14, 'Jilisco'),
(245, 14, 'Jucuapa'),
(246, 14, 'Jucuaran'),
(247, 14, 'Mercedes Umaña'),
(248, 14, 'Nueva Granada'),
(249, 14, 'Ozatlan'),
(250, 14, 'Puerto el triunfo'),
(251, 14, 'San aguistin'),
(252, 14, 'San buenaventura'),
(253, 14, 'San dionisio'),
(254, 14, 'San Francisco Javier'),
(255, 14, 'Santa elena'),
(256, 14, 'Santa maria'),
(257, 14, 'Santiago de maria'),
(258, 14, 'Tecapan');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `preguntas`
--

CREATE TABLE `preguntas` (
  `id_pregunta` int(2) NOT NULL,
  `preguntas` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `preguntas`
--

INSERT INTO `preguntas` (`id_pregunta`, `preguntas`) VALUES
(1, '¿Que nombre te gustaria cambiarte?'),
(2, '¿Cuando tuvo su primera novia?'),
(3, '¿Cual es tu equipo de futbol favorito?'),
(4, '¿Como se llama tu mejor amigo?'),
(5, '¿Cual es tu comida favorita?'),
(6, '¿Como se llama tu pelicula favorita?'),
(7, '¿En cual ciudad te gustaria vivir?'),
(8, '¿Como se llama el primer colegio donde estudiaste?'),
(9, '¿Cual es tu mejor pasatiempo?'),
(10, '¿Cual es tu videojuego favorito?');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `prioridad`
--

CREATE TABLE `prioridad` (
  `id_prioridad` int(11) NOT NULL,
  `prioridad` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `prioridad`
--

INSERT INTO `prioridad` (`id_prioridad`, `prioridad`) VALUES
(1, 'Urgente'),
(2, 'Promedio'),
(3, 'Leve');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbgenero`
--

CREATE TABLE `tbgenero` (
  `id_genero` int(1) NOT NULL,
  `genero` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbgenero`
--

INSERT INTO `tbgenero` (`id_genero`, `genero`) VALUES
(1, 'Masculino'),
(2, 'Femenino');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `terreno`
--

CREATE TABLE `terreno` (
  `id_terreno` int(11) NOT NULL,
  `tipoRelieve` int(11) NOT NULL,
  `tipoTerreno` int(11) NOT NULL,
  `id_departamento` int(2) NOT NULL,
  `estado` int(11) NOT NULL,
  `precio_terreno` int(8) NOT NULL,
  `area_terreno` int(5) NOT NULL,
  `direccion_terreno` varchar(200) NOT NULL,
  `municipio_ter` int(3) NOT NULL,
  `imagen1` longtext DEFAULT NULL,
  `imagen2` longtext DEFAULT NULL,
  `imagen3` longtext DEFAULT NULL,
  `imagen4` longtext DEFAULT NULL,
  `descripcion_terreno` varchar(200) DEFAULT NULL,
  `id_cliente` int(11) NOT NULL,
  `id_empleado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipocliente`
--

CREATE TABLE `tipocliente` (
  `id_tipoCliente` int(1) NOT NULL,
  `tipo_cliente` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipocliente`
--

INSERT INTO `tipocliente` (`id_tipoCliente`, `tipo_cliente`) VALUES
(1, 'Vendedor'),
(2, 'Comprador');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tiporelieve`
--

CREATE TABLE `tiporelieve` (
  `id_tipoRelieve` int(1) NOT NULL,
  `tipo_relieve` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tiporelieve`
--

INSERT INTO `tiporelieve` (`id_tipoRelieve`, `tipo_relieve`) VALUES
(1, 'Llanuras'),
(2, 'Mesetas'),
(3, 'Valles'),
(4, 'Montañas'),
(7, 'Cordilleras');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipoterreno`
--

CREATE TABLE `tipoterreno` (
  `id_tipoTerreno` int(1) NOT NULL,
  `tipo_terreno` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipoterreno`
--

INSERT INTO `tipoterreno` (`id_tipoTerreno`, `tipo_terreno`) VALUES
(1, 'Arenosos'),
(2, 'Arcillosos duros'),
(3, 'Graveras'),
(4, 'Orgánicos'),
(7, 'Inorgánicos'),
(8, 'Secos');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipousuario`
--

CREATE TABLE `tipousuario` (
  `id_tipoUsuario` int(1) NOT NULL,
  `tipo_usuario` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipousuario`
--

INSERT INTO `tipousuario` (`id_tipoUsuario`, `tipo_usuario`) VALUES
(1, 'Root'),
(2, 'Admin'),
(3, 'Corredor');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_apartamento`
--

CREATE TABLE `tipo_apartamento` (
  `id_tipoApartamento` int(1) NOT NULL,
  `tipo_apartamento` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipo_apartamento`
--

INSERT INTO `tipo_apartamento` (`id_tipoApartamento`, `tipo_apartamento`) VALUES
(1, 'Lujoso'),
(2, 'Condominio');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_casa`
--

CREATE TABLE `tipo_casa` (
  `id_tipoCasa` int(1) NOT NULL,
  `tipo_casa` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipo_casa`
--

INSERT INTO `tipo_casa` (`id_tipoCasa`, `tipo_casa`) VALUES
(1, 'Esquina'),
(2, 'Pasaje');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_empresa`
--

CREATE TABLE `tipo_empresa` (
  `id_tipo_empresa` int(1) NOT NULL,
  `tipo_empresa` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipo_empresa`
--

INSERT INTO `tipo_empresa` (`id_tipo_empresa`, `tipo_empresa`) VALUES
(1, 'Casa Matriz'),
(2, 'Sucursal');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `apartamento`
--
ALTER TABLE `apartamento`
  ADD PRIMARY KEY (`id_apartamento`),
  ADD KEY `apartamento_ibfk_1` (`estado`),
  ADD KEY `apartamento_ibfk_2` (`id_departamento`),
  ADD KEY `tipo_apartamento_idx` (`tipo_apartamento`),
  ADD KEY `municipio_idx` (`municipio_apar`);

--
-- Indices de la tabla `casa`
--
ALTER TABLE `casa`
  ADD PRIMARY KEY (`id_casa`),
  ADD KEY `casa_ibfk_1` (`estado`),
  ADD KEY `casa_ibfk_2` (`id_departamento`),
  ADD KEY `tipo_casa_idx` (`tipoCasa`),
  ADD KEY `municipio_idx` (`municipio_casa`);

--
-- Indices de la tabla `cita`
--
ALTER TABLE `cita`
  ADD PRIMARY KEY (`id_cita`),
  ADD KEY `empleado` (`empleado`),
  ADD KEY `cliente` (`cliente`),
  ADD KEY `id_prioridad` (`id_prioridad`),
  ADD KEY `estado` (`id_estado`);

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id_cliente`),
  ADD KEY `id_genero` (`id_genero`),
  ADD KEY `tipoCliente` (`tipoCliente`),
  ADD KEY `estadoCivil` (`estadoCivil`),
  ADD KEY `id_estado` (`id_estado`);

--
-- Indices de la tabla `departamento`
--
ALTER TABLE `departamento`
  ADD PRIMARY KEY (`id_departamento`);

--
-- Indices de la tabla `detalleapar`
--
ALTER TABLE `detalleapar`
  ADD PRIMARY KEY (`id_factura`),
  ADD KEY `apartamento` (`apartamento`);

--
-- Indices de la tabla `detallecasa`
--
ALTER TABLE `detallecasa`
  ADD PRIMARY KEY (`id_factura`),
  ADD KEY `casa` (`casa`);

--
-- Indices de la tabla `detalleterreno`
--
ALTER TABLE `detalleterreno`
  ADD PRIMARY KEY (`id_factura`),
  ADD KEY `terreno` (`terreno`);

--
-- Indices de la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD PRIMARY KEY (`id_empleado`),
  ADD KEY `pregunta1` (`pregunta1`),
  ADD KEY `pregunta2` (`pregunta2`),
  ADD KEY `pregunta3` (`pregunta3`),
  ADD KEY `id_genero` (`id_genero`),
  ADD KEY `estado` (`estado`),
  ADD KEY `tipoUsuario` (`tipoUsuario`),
  ADD KEY `empresa_idx` (`id_empresa`);

--
-- Indices de la tabla `empresa`
--
ALTER TABLE `empresa`
  ADD PRIMARY KEY (`id_empresa`),
  ADD KEY `tipo_empresa` (`tipoEmpresa`);

--
-- Indices de la tabla `estadocivil`
--
ALTER TABLE `estadocivil`
  ADD PRIMARY KEY (`id_estadoCivil`);

--
-- Indices de la tabla `estadoclien`
--
ALTER TABLE `estadoclien`
  ADD PRIMARY KEY (`id_estado`);

--
-- Indices de la tabla `estadofactura`
--
ALTER TABLE `estadofactura`
  ADD PRIMARY KEY (`id_estado`);

--
-- Indices de la tabla `estadopropiedad`
--
ALTER TABLE `estadopropiedad`
  ADD PRIMARY KEY (`id_estado`);

--
-- Indices de la tabla `estadousuario`
--
ALTER TABLE `estadousuario`
  ADD PRIMARY KEY (`id_estado`);

--
-- Indices de la tabla `estado_cita`
--
ALTER TABLE `estado_cita`
  ADD PRIMARY KEY (`id_estadoCita`);

--
-- Indices de la tabla `facturaapar`
--
ALTER TABLE `facturaapar`
  ADD PRIMARY KEY (`id_facturaApar`),
  ADD KEY `empleado` (`empleado`),
  ADD KEY `cliente` (`cliente`),
  ADD KEY `estado` (`estado`),
  ADD KEY `facturaapar_ibfk_4` (`detalle`);

--
-- Indices de la tabla `facturacasa`
--
ALTER TABLE `facturacasa`
  ADD PRIMARY KEY (`id_facturaCasa`),
  ADD KEY `empleado` (`empleado`),
  ADD KEY `cliente` (`cliente`),
  ADD KEY `estado` (`estado`),
  ADD KEY `detalle` (`detalle`);

--
-- Indices de la tabla `facturaterreno`
--
ALTER TABLE `facturaterreno`
  ADD PRIMARY KEY (`id_facturaTerr`),
  ADD KEY `empleado` (`empleado`),
  ADD KEY `cliente` (`cliente`),
  ADD KEY `estado` (`estado`),
  ADD KEY `detalle` (`detalle`);

--
-- Indices de la tabla `municipios`
--
ALTER TABLE `municipios`
  ADD PRIMARY KEY (`id_municipio`),
  ADD KEY `municipios_ibfk_1` (`id_departamento`);

--
-- Indices de la tabla `preguntas`
--
ALTER TABLE `preguntas`
  ADD PRIMARY KEY (`id_pregunta`);

--
-- Indices de la tabla `prioridad`
--
ALTER TABLE `prioridad`
  ADD PRIMARY KEY (`id_prioridad`);

--
-- Indices de la tabla `tbgenero`
--
ALTER TABLE `tbgenero`
  ADD PRIMARY KEY (`id_genero`);

--
-- Indices de la tabla `terreno`
--
ALTER TABLE `terreno`
  ADD PRIMARY KEY (`id_terreno`),
  ADD KEY `estado` (`estado`),
  ADD KEY `id_departamento` (`id_departamento`),
  ADD KEY `tipoTerreno` (`tipoTerreno`),
  ADD KEY `tipoRelieve` (`tipoRelieve`),
  ADD KEY `municipio_idx` (`municipio_ter`);

--
-- Indices de la tabla `tipocliente`
--
ALTER TABLE `tipocliente`
  ADD PRIMARY KEY (`id_tipoCliente`);

--
-- Indices de la tabla `tiporelieve`
--
ALTER TABLE `tiporelieve`
  ADD PRIMARY KEY (`id_tipoRelieve`);

--
-- Indices de la tabla `tipoterreno`
--
ALTER TABLE `tipoterreno`
  ADD PRIMARY KEY (`id_tipoTerreno`);

--
-- Indices de la tabla `tipousuario`
--
ALTER TABLE `tipousuario`
  ADD PRIMARY KEY (`id_tipoUsuario`);

--
-- Indices de la tabla `tipo_apartamento`
--
ALTER TABLE `tipo_apartamento`
  ADD PRIMARY KEY (`id_tipoApartamento`);

--
-- Indices de la tabla `tipo_casa`
--
ALTER TABLE `tipo_casa`
  ADD PRIMARY KEY (`id_tipoCasa`);

--
-- Indices de la tabla `tipo_empresa`
--
ALTER TABLE `tipo_empresa`
  ADD PRIMARY KEY (`id_tipo_empresa`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `apartamento`
--
ALTER TABLE `apartamento`
  MODIFY `id_apartamento` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `casa`
--
ALTER TABLE `casa`
  MODIFY `id_casa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=171;

--
-- AUTO_INCREMENT de la tabla `cita`
--
ALTER TABLE `cita`
  MODIFY `id_cita` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id_cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `departamento`
--
ALTER TABLE `departamento`
  MODIFY `id_departamento` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT de la tabla `detalleapar`
--
ALTER TABLE `detalleapar`
  MODIFY `id_factura` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT de la tabla `detallecasa`
--
ALTER TABLE `detallecasa`
  MODIFY `id_factura` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `detalleterreno`
--
ALTER TABLE `detalleterreno`
  MODIFY `id_factura` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `empleados`
--
ALTER TABLE `empleados`
  MODIFY `id_empleado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT de la tabla `empresa`
--
ALTER TABLE `empresa`
  MODIFY `id_empresa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de la tabla `estadocivil`
--
ALTER TABLE `estadocivil`
  MODIFY `id_estadoCivil` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `estadoclien`
--
ALTER TABLE `estadoclien`
  MODIFY `id_estado` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `estadofactura`
--
ALTER TABLE `estadofactura`
  MODIFY `id_estado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `estadopropiedad`
--
ALTER TABLE `estadopropiedad`
  MODIFY `id_estado` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `estadousuario`
--
ALTER TABLE `estadousuario`
  MODIFY `id_estado` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `estado_cita`
--
ALTER TABLE `estado_cita`
  MODIFY `id_estadoCita` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `facturaapar`
--
ALTER TABLE `facturaapar`
  MODIFY `id_facturaApar` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `facturacasa`
--
ALTER TABLE `facturacasa`
  MODIFY `id_facturaCasa` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `facturaterreno`
--
ALTER TABLE `facturaterreno`
  MODIFY `id_facturaTerr` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `municipios`
--
ALTER TABLE `municipios`
  MODIFY `id_municipio` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=259;

--
-- AUTO_INCREMENT de la tabla `prioridad`
--
ALTER TABLE `prioridad`
  MODIFY `id_prioridad` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `terreno`
--
ALTER TABLE `terreno`
  MODIFY `id_terreno` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tipo_apartamento`
--
ALTER TABLE `tipo_apartamento`
  MODIFY `id_tipoApartamento` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tipo_casa`
--
ALTER TABLE `tipo_casa`
  MODIFY `id_tipoCasa` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `apartamento`
--
ALTER TABLE `apartamento`
  ADD CONSTRAINT `apartamento_ibfk_1` FOREIGN KEY (`estado`) REFERENCES `estadopropiedad` (`id_estado`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `apartamento_ibfk_2` FOREIGN KEY (`id_departamento`) REFERENCES `departamento` (`id_departamento`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `municipio` FOREIGN KEY (`municipio_apar`) REFERENCES `municipios` (`id_municipio`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tipo_apartamento` FOREIGN KEY (`tipo_apartamento`) REFERENCES `tipo_apartamento` (`id_tipoApartamento`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `casa`
--
ALTER TABLE `casa`
  ADD CONSTRAINT `casa_ibfk_1` FOREIGN KEY (`estado`) REFERENCES `estadopropiedad` (`id_estado`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `casa_ibfk_2` FOREIGN KEY (`id_departamento`) REFERENCES `departamento` (`id_departamento`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `casa_ibfk_3` FOREIGN KEY (`municipio_casa`) REFERENCES `municipios` (`id_municipio`),
  ADD CONSTRAINT `tipo_casa` FOREIGN KEY (`tipoCasa`) REFERENCES `tipo_casa` (`id_tipoCasa`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `cita`
--
ALTER TABLE `cita`
  ADD CONSTRAINT `cita_ibfk_1` FOREIGN KEY (`empleado`) REFERENCES `empleados` (`id_empleado`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cita_ibfk_2` FOREIGN KEY (`cliente`) REFERENCES `cliente` (`id_cliente`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cita_ibfk_3` FOREIGN KEY (`id_prioridad`) REFERENCES `prioridad` (`id_prioridad`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cita_ibfk_4` FOREIGN KEY (`id_estado`) REFERENCES `estado_cita` (`id_estadoCita`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD CONSTRAINT `cliente_ibfk_1` FOREIGN KEY (`id_genero`) REFERENCES `tbgenero` (`id_genero`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cliente_ibfk_2` FOREIGN KEY (`tipoCliente`) REFERENCES `tipocliente` (`id_tipoCliente`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cliente_ibfk_3` FOREIGN KEY (`estadoCivil`) REFERENCES `estadocivil` (`id_estadoCivil`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `cliente_ibfk_4` FOREIGN KEY (`id_estado`) REFERENCES `estadoclien` (`id_estado`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `detallecasa`
--
ALTER TABLE `detallecasa`
  ADD CONSTRAINT `detallecasa_ibfk_1` FOREIGN KEY (`casa`) REFERENCES `casa` (`id_casa`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `facturaapar`
--
ALTER TABLE `facturaapar`
  ADD CONSTRAINT `facturaapar_ibfk_1` FOREIGN KEY (`empleado`) REFERENCES `empleados` (`id_empleado`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `facturaapar_ibfk_2` FOREIGN KEY (`cliente`) REFERENCES `cliente` (`id_cliente`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `facturaapar_ibfk_3` FOREIGN KEY (`estado`) REFERENCES `estadofactura` (`id_estado`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `facturaapar_ibfk_4` FOREIGN KEY (`detalle`) REFERENCES `detalleapar` (`id_factura`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
