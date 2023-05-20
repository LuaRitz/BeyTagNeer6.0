-- phpMyAdmin SQL Dump
-- version 4.8.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 20-Maio-2023 às 20:22
-- Versão do servidor: 10.1.32-MariaDB
-- PHP Version: 7.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cadastro`
--
CREATE DATABASE IF NOT EXISTS `cadastro` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `cadastro`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `carrinhocompras`
--

DROP TABLE IF EXISTS `carrinhocompras`;
CREATE TABLE `carrinhocompras` (
  `carrinho` int(8) NOT NULL,
  `nproduto` int(2) NOT NULL,
  `uscode` int(8) NOT NULL,
  `cep` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `produtos`
--

DROP TABLE IF EXISTS `produtos`;
CREATE TABLE `produtos` (
  `produto` int(2) NOT NULL,
  `nomeproduto` varchar(45) COLLATE utf8mb4_unicode_ci NOT NULL,
  `imagem` varchar(120) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Stock` int(11) NOT NULL,
  `preco` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Extraindo dados da tabela `produtos`
--

INSERT INTO `produtos` (`produto`, `nomeproduto`, `imagem`, `Stock`, `preco`) VALUES
(1, 'Alatreon', 'C:\\Users\\Aluno\\Documents\\GitHub\\BeyTagNeer6.0\\Fotos\\Action_figure\\Alatreon.jpg', 25, '499.00'),
(2, 'Astalos', 'C:\\Users\\Aluno\\Documents\\GitHub\\BeyTagNeer6.0\\Fotos\\Action_figure\\Astalos.png', 25, '299.00'),
(3, 'Brachydios', 'C:\\Users\\Aluno\\Documents\\GitHub\\BeyTagNeer6.0\\Fotos\\Action_figure\\Brachydios.jpg', 73, '435.00'),
(4, 'Diablos', 'C:\\Users\\Aluno\\Documents\\GitHub\\BeyTagNeer6.0\\Fotos\\Action_figure\\Diablos.jpg', 32, '326.00'),
(5, 'Fatalis', 'C:\\Users\\Aluno\\Documents\\GitHub\\BeyTagNeer6.0\\Fotos\\Action_figure\\Fatalis.jpg', 19, '678.00'),
(6, 'Glavenus', 'C:\\Users\\Aluno\\Documents\\GitHub\\BeyTagNeer6.0\\Fotos\\Action_figure\\Glavenus.jpg', 65, '234.90'),
(7, 'Lagiacrus', 'C:\\Users\\Aluno\\Documents\\GitHub\\BeyTagNeer6.0\\Fotos\\Action_figure\\Lagiacrus.jpg', 45, '294.90'),
(8, 'Malfiestio', 'C:\\Users\\Aluno\\Documents\\GitHub\\BeyTagNeer6.0\\Fotos\\Action_figure\\Malfestio.jpg', 53, '394.90'),
(9, 'Malzeno', 'C:\\Users\\Aluno\\Documents\\GitHub\\BeyTagNeer6.0\\Fotos\\Action_figure\\Malzeno.jpg', 42, '479.00'),
(10, 'Mizutsune', 'C:\\Users\\Aluno\\Documents\\GitHub\\BeyTagNeer6.0\\Fotos\\Action_figure\\Mizutsune.jpg', 69, '690.00'),
(11, 'Nargacuga', 'C:\\Users\\Aluno\\Documents\\GitHub\\BeyTagNeer6.0\\Fotos\\Action_figure\\Nargacuga.jpg', 44, '240.00'),
(12, 'Odagaron', 'C:\\Users\\Aluno\\Documents\\GitHub\\BeyTagNeer6.0\\Fotos\\Action_figure\\Odagaron.jpg', 32, '420.00'),
(13, 'SafiJiiva', 'C:\\Users\\Aluno\\Documents\\GitHub\\BeyTagNeer6.0\\Fotos\\Action_figure\\SafiJiiva.jpg', 63, '370.00'),
(14, 'Tigrex', 'C:\\Users\\Aluno\\Documents\\GitHub\\BeyTagNeer6.0\\Fotos\\Action_figure\\Tigrex.jpg', 24, '470.00'),
(15, 'Valstrax', 'C:\\Users\\Aluno\\Documents\\GitHub\\BeyTagNeer6.0\\Fotos\\Action_figure\\Valstrax.jpg', 41, '469.00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE `usuario` (
  `usercode` int(8) NOT NULL,
  `nome` varchar(45) COLLATE utf8mb4_unicode_ci NOT NULL,
  `email` varchar(60) COLLATE utf8mb4_unicode_ci NOT NULL,
  `login` varchar(12) COLLATE utf8mb4_unicode_ci NOT NULL,
  `senha` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `ncarrinho` int(8) DEFAULT NULL,
  `perfil` int(1) NOT NULL,
  `userimage` varchar(45) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`usercode`, `nome`, `email`, `login`, `senha`, `ncarrinho`, `perfil`, `userimage`) VALUES
(1, 'Lucas', 'lukinhasfht@gmail.com', 'Lua', '123', NULL, 2, NULL),
(2, 'fasd', 'dsa', 'asd', '123', NULL, 0, NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `carrinhocompras`
--
ALTER TABLE `carrinhocompras`
  ADD PRIMARY KEY (`carrinho`);

--
-- Indexes for table `produtos`
--
ALTER TABLE `produtos`
  ADD PRIMARY KEY (`produto`);

--
-- Indexes for table `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`usercode`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `carrinhocompras`
--
ALTER TABLE `carrinhocompras`
  MODIFY `carrinho` int(8) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `produtos`
--
ALTER TABLE `produtos`
  MODIFY `produto` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `usuario`
--
ALTER TABLE `usuario`
  MODIFY `usercode` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
