-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 26-Maio-2022 às 16:10
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
-- Banco de dados: `projeto_locadora_de_carros`
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
(1, 'adm', 0, '2022-04-28 12:36:33'),
(2, '[value-2]', 0, '0000-00-00 00:00:00');

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

--
-- Extraindo dados da tabela `carros`
--

INSERT INTO `carros` (`id_carro`, `modelo`, `tamanho`, `categoria`, `cilindradas`, `gps`, `tela_de_lcd`, `fabricante`, `ano`, `painel_digital`, `cambio_automatico`, `tipo_de_combustivel`, `data_de_compra`, `valor_da_compra`, `placa`, `ja_locado`, `foto_url`) VALUES
(4, '[value-2]', '[value-3]', '[value-4]', '[value-5]', '[value-6]', '[value-7]', '[value-8]', '[value-9]', '[value-10]', '[value-11]', '[value-12]', '[value-13]', '[value-14]', '[value-15]', '1', ''),
(7, '\"+modelo+\"', '\" + tamanho + \"', '\" + categoria + \"', '\" + cilindradas + \"', '\" + gps + \"', '\" + tela_de_lcd + \"', '\" + fabricante + \"', '\" + ano + \"', '\" + painel_digital + \"', '\" + cambio_automatico + \"', '\" + tipo_de_combustivel + \"', '\" + data_de_co', '\" + valor_de_compra + \"', '\" + placa + \"', '', ''),
(8, '\" + modelo + \"', '\" + tamanho + \"', '\" + categoria + \"', '\" + cilindradas + \"', '\" + gps + \"', '\" + tela_de_lcd + \"', '\" + fabricante + \"', '\" + ano + \"', '\" + painel_digital + \"', '\" + cambio_automatico + \"', '\" + tipo_de_combustivel + \"', '\" + data_de_co', '\" + valor_de_compra + \"', '\" + placa + \"', '', ''),
(9, '1231', '', '', '', '', '', '', '', '', '', '', '  /  /', '', '', '', 'C:UsersEscola SDesktopimages.jpg'),
(10, 'sfgsdfgfd', '', '', '', '', '', '', '', '', '', '', '  /  /', '', '', '', 'C:UsersEscola SDesktopAngolan.jpg'),
(11, 'dasdasd', '', '', '', '', '', '', '', '', '', '', '  /  /', '', '', '', ''),
(12, 'xcvxcv', '', '', '', '', '', '', '', '', '', '', '  /  /', '', '', '', ''),
(13, 'a', '', '', '', '', '', '', '', '', '', '', '  /  /', '', '', '', ''),
(14, 'dgdg', '', '', '', '', '', '', '', '', '', '', '  /  /', '', '', '', ''),
(15, 'Angolano', '', '', '', '', '', '', '', '', '', '', '  /  /', '', '', '', 'C:?Users?Escola S?Desktop?Angolan.jpg'),
(16, 'imagrm', '', '', '', '', '', '', '', '', '', '', '  /  /', '', '', '', 'C:?Users?Escola S?Desktop?Angolan2.jpg');

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

--
-- Extraindo dados da tabela `clientes`
--

INSERT INTO `clientes` (`cpf_cliente`, `nome_cliente`, `sobrenome_cliente`, `endereço_completo`, `telefone_cliente`, `email_cliente`, `cnh_cliente`, `cep_residencia_cliente`, `data_cliente`, `ativo_cliente`) VALUES
(14, 'Marcos', 'Gabriel', 'Rua antonio', '12343242341', 'marcosfurry@furry', '123', '21132', '2022-05-10 14:47:20', 0),
(99, 'Furry', '', '', '123123123', '', '123123123', '', '2022-05-10 14:47:13', 0),
(1213, 'Arthu', '', '123123', '1123123123', '12313213', '112313', '21312312', '2022-05-10 14:46:02', 0),
(6969, 'Shryu', '\"+sobrenome_cliente+\"', 'rua asdasda', '47999312312', 'shryu@shryu', '12312', '12312', '2022-05-05 14:20:31', 1);

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
(2, 'funcionario', 'funcionario', '2022-05-05 13:30:20');

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

--
-- Extraindo dados da tabela `locacoes`
--

INSERT INTO `locacoes` (`cpf_do_locatorio`, `id_carro`, `km_inicial`, `km_entrega_carro`, `data_locacao`, `data_devolucao`, `finalizado`) VALUES
(3, 5, '0000', '0000', '00/00/0000', '00/00/0000', 0),
(12, 5, '1231', '1231', '21/31/2312', '13/12/3123', 0),
(123, 5, '0000', '0000', '00/00/0000', '00/00/0000', 0),
(554, 5, '1111', '1111', '11/11/1111', '11/11/1111', 0),
(12312, 6, '0000', '0000', '00/00/0000', '00/00/0000', 0);

--
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
  MODIFY `id_adm` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `carros`
--
ALTER TABLE `carros`
  MODIFY `id_carro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT de tabela `funcionarios`
--
ALTER TABLE `funcionarios`
  MODIFY `id_funcio` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
