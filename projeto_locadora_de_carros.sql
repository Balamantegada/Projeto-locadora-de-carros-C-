-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 31-Maio-2022 às 16:26
-- Versão do servidor: 10.4.22-MariaDB
-- versão do PHP: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `locadora-de-carros`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `adms`
--

CREATE TABLE `adms` (
  `id_adm` int(11) NOT NULL,
  `usuario_adm` varchar(80) NOT NULL,
  `senha_adm` int(80) NOT NULL,
  `data_adm` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `adms`
--

INSERT INTO `adms` (`id_adm`, `usuario_adm`, `senha_adm`, `data_adm`) VALUES
(1, 'Thaina', 'Thaina', '2022-05-31 11:28:33');

-- --------------------------------------------------------

--
-- Estrutura da tabela `carros`
--

CREATE TABLE `carros` (
  `id_carro` int(11) NOT NULL,
  `modelo` varchar(80) NOT NULL,
  `tamanho` varchar(80) NOT NULL,
  `categoria` varchar(80) NOT NULL,
  `cilindradas` varchar(80) NOT NULL,
  `gps` varchar(80) NOT NULL,
  `tela_de_lcd` varchar(80) NOT NULL,
  `fabricante` varchar(80) NOT NULL,
  `ano` varchar(12) NOT NULL,
  `painel_digital` varchar(80) NOT NULL,
  `cambio_automatico` varchar(80) NOT NULL,
  `tipo_de_combustivel` varchar(80) NOT NULL,
  `data_de_compra` varchar(14) NOT NULL,
  `valor_da_compra` varchar(40) NOT NULL,
  `placa` varchar(14) NOT NULL,
  `ja_locado` varchar(1) NOT NULL,
  `foto_url` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientes`
--

CREATE TABLE `clientes` (
  `cpf_cliente` int(11) NOT NULL,
  `nome_cliente` varchar(80) NOT NULL,
  `sobrenome_cliente` varchar(80) NOT NULL,
  `endereço_completo` varchar(140) NOT NULL,
  `telefone_cliente` varchar(20) NOT NULL,
  `email_cliente` varchar(80) NOT NULL,
  `cnh_cliente` varchar(11) NOT NULL,
  `cep_residencia_cliente` varchar(8) NOT NULL,
  `data_cliente` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `ativo_cliente` int(1) NOT NULL COMMENT '0 = desativado\r\n1 = ativado'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionarios`
--

CREATE TABLE `funcionarios` (
  `id_funcio` int(11) NOT NULL,
  `usuario_funcio` varchar(80) NOT NULL,
  `senha_funcio` varchar(80) NOT NULL,
  `data_funcio` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `funcionarios`
--

INSERT INTO `funcionarios` (`id_funcio`, `usuario_funcio`, `senha_funcio`, `data_funcio`) VALUES
(1, 'Daniel', 'Daniel', '2022-05-31 11:30:20');

-- --------------------------------------------------------

--
-- Estrutura da tabela `locacoes`
--

CREATE TABLE `locacoes` (
  `cpf_do_locatorio` int(11) NOT NULL,
  `id_carro` int(10) NOT NULL,
  `km_inicial` varchar(80) NOT NULL,
  `km_entrega_carro` varchar(80) NOT NULL,
  `data_locacao` varchar(80) NOT NULL,
  `data_devolucao` varchar(80) NOT NULL,
  `finalizado` int(1) NOT NULL COMMENT '0 = em aberto\r\n1 = finalizado'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Índices para tabelas despejadas
--

--
-- Índices para tabela `adms`
--
ALTER TABLE `adms`
  ADD PRIMARY KEY (`id_adm`);

--
-- Índices para tabela `carros`
--
ALTER TABLE `carros`
  ADD PRIMARY KEY (`id_carro`);

--
-- Índices para tabela `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`cpf_cliente`);

--
-- Índices para tabela `funcionarios`
--
ALTER TABLE `funcionarios`
  ADD PRIMARY KEY (`id_funcio`);

--
-- Índices para tabela `locacoes`
--
ALTER TABLE `locacoes`
  ADD PRIMARY KEY (`cpf_do_locatorio`,`id_carro`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `adms`
--
ALTER TABLE `adms`
  MODIFY `id_adm` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=0;

--
-- AUTO_INCREMENT de tabela `carros`
--
ALTER TABLE `carros`
  MODIFY `id_carro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=0;

--
-- AUTO_INCREMENT de tabela `funcionarios`
--
ALTER TABLE `funcionarios`
  MODIFY `id_funcio` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=0;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
