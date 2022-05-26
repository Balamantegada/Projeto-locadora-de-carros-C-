using MySql.Data.MySqlClient;
using SistemaCliente.DataBase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCliente.DTO
{
    internal class Carros
    {
        private ConexaoDB conexao;

        private int _id_carro;

        private string _tamanho;
        private string _categoria;
        private string _cilindradas;
        private string _gps;
        private string _tela_de_lcd;
        private string _fabricante;
        private string _modelo;
        private string _ano;
        private string _painel_digital;
        private string _cambio_automatico;
        private string _tipo_de_combustivel;
        private string _data_de_compra;
        private string _valor_de_compra;
        private string _placa;
        private string _caminho_imagem;


        public int id_carro
        {
            get { return _id_carro; }
            set { _id_carro = value; }
        }
        public string tamanho
        {
            get { return _tamanho; }
            set { _tamanho = value;}
        }
        public string categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }
        public string cilindradas
        {
            get { return _cilindradas; }
            set { _cilindradas = value;}
        }
        public string gps
        {
            get { return _gps; }
            set { _gps = value; }
        }
        public string tela_de_lcd
        {
            get { return _tela_de_lcd; }
            set { _tela_de_lcd = value; }
        }
        public string fabricante
        {
            get { return _fabricante; }
            set { _fabricante = value; }
        }
        public string modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
        public string ano
        {
            get { return _ano; }
            set { _ano = value; }
        }
        public string painel_digital
        {
            get { return _painel_digital;}
            set { _painel_digital = value;}
        }
        public string cambio_automatico
        {
            get { return _cambio_automatico; }
            set { _cambio_automatico = value; }
        }
        public string tipo_de_combustivel
        {
            get { return _tipo_de_combustivel; }
            set { _tipo_de_combustivel = value; }
        }
        public string data_de_compra
        {
            get { return _data_de_compra; }
            set { _data_de_compra = value; }
        }
        public string valor_de_compra
        {
            get { return _valor_de_compra; }
            set { _valor_de_compra = value; }
        }
        public string placa
        {
            get { return _placa; }
            set { _placa = value; }
        }
        public string caminho_imagem
        {
            get { return _caminho_imagem; }
            set { _caminho_imagem = value; }
        }
        public Carros()
        {
            this.conexao = new ConexaoDB();
        }
        public void CadastrarCarro()
        {
            this.conexao.NonQuery("INSERT INTO `carros`(`modelo`,`tamanho`, `categoria`, `cilindradas`, `gps`, `tela_de_lcd`, `fabricante`,`ano`, `painel_digital`, `cambio_automatico`, `tipo_de_combustivel`, `data_de_compra`, `valor_da_compra`, `placa`, `foto_url`) VALUES ('" + modelo + "', '" + tamanho + "','" + categoria + "','" + cilindradas + "','" + gps + "','" + tela_de_lcd + "','" + fabricante + "','" + ano + "','" + painel_digital + "','" + cambio_automatico + "','" + tipo_de_combustivel + "','" + data_de_compra + "','" + valor_de_compra + "','" + placa + "','"+ caminho_imagem +"')");
        }
        public void AlterarCarro(int id_carro)
        {
            
            this.conexao.NonQuery(
                "UPDATE `carros` SET `tamanho`='" + tamanho + "', `categoria`= '" + categoria + "', `cilindradas`= '"+cilindradas+"',`gps`= '"+gps+"', `tela_de_lcd`= '"+tela_de_lcd+"', `fabricante`= '"+fabricante+"', `modelo`= '"+modelo+"',`ano`= '"+ano+"', `painel_digital`= '"+painel_digital+"', `cambio_automatico`= '"+cambio_automatico+"', `tipo_de_combustivel`='"+tipo_de_combustivel+"', `data_de_compra`='"+data_de_compra+"', `valor_da_compra`='"+valor_de_compra+"', `placa`='"+placa+"', `foto_url`='"+caminho_imagem+"' WHERE id_carro = '" + id_carro + "'");

        }
        public MySqlDataReader ListarCarros()
        {
            return this.conexao.Query("SELECT * from carros order by id_carro ASC");
        }
        public MySqlDataReader ListarCarrosFiltro(string filtro)
        {
            if (filtro == null)
            {
                return ListarCarros();
            }
            return this.conexao.Query("Select * from carros WHERE modelo LIKE '%" + filtro + "%' order by modelo asc");
        }
        public void DeletarCarro(int id_carro)
        {
            this.conexao.NonQuery(
                "DELETE FROM `carros` WHERE id_carro = '" + id_carro + "'");
        }
        public Carros(int id_carro, string tamanho, string categoria, string cilindradas, string gps, string tela_de_lcd, string fabricante, string modelo, string ano, string painel_digital, string cambio_automatico, string tipo_de_combustivel, string data_de_compra, string valor_de_compra,string placa, string imagem_byte)
        {
            this.id_carro = id_carro;
            this.tamanho = tamanho;
            this.categoria = categoria;
            this.cilindradas = cilindradas;
            this.gps = gps;
            this.tela_de_lcd = tela_de_lcd;
            this.fabricante = fabricante;
            this.modelo = modelo;
            this.ano = ano;
            this.painel_digital = painel_digital;
            this.cambio_automatico = cambio_automatico;
            this.tipo_de_combustivel = tipo_de_combustivel;
            this.data_de_compra = data_de_compra;
            this.valor_de_compra= valor_de_compra;
            this.placa = placa;
            this.caminho_imagem = imagem_byte;
        }
    }
}