-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 25-Fev-2023 às 19:05
-- Versão do servidor: 10.4.19-MariaDB
-- versão do PHP: 8.0.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `cadastro`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `carrinhocompras`
--

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

CREATE TABLE `produtos` (
  `produto` int(2) NOT NULL,
  `nomeproduto` varchar(45) COLLATE utf8mb4_unicode_ci NOT NULL,
  `imagem` varchar(45) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

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
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `carrinhocompras`
--
ALTER TABLE `carrinhocompras`
  ADD PRIMARY KEY (`carrinho`);

--
-- Índices para tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`usercode`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `carrinhocompras`
--
ALTER TABLE `carrinhocompras`
  MODIFY `carrinho` int(8) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `usercode` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;