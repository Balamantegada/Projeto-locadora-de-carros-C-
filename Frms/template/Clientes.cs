/*using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.Memcached;
using SistemaCliente.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCliente.DTO
{
    public class Funcionario
    {
        private ConexaoDB conexao;

        private int _id_cliente;

        private string _nome_cliente;
        private string _email;
        private string _numero_cell;
        private string _senha;
        private string _data_cliente;

        public int id_cliente
        {
            get { return _id_cliente; }
            set { _id_cliente = value; }
        }
        public string nome_cliente
        {
            get { return _nome_cliente; }
            set { _nome_cliente = value; }
        }
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string numero_cell
        {
            get { return _numero_cell; }
            set { _numero_cell = value; }
        }
        public string senha
        {
            get { return _senha; }
            set { _senha = value; }
        }
        public string data_cliente
        {
            get { return _data_cliente; }
            set { _data_cliente = value; }
        }
        public Funcionario()
        {
            this.conexao = new ConexaoDB();
        }
        public void CadastrarCliente()
        {
            this.conexao.NonQuery(
                "INSERT INTO `cliente`(`nome`, `email`, `numero_cell`, `senha`, `data_cliente`) VALUES('" + nome_cliente + "', '" + email + "', '" + numero_cell + "', '" + senha + "', default);");
        }
        public void AlterarCliente(string id_cliente)
        {
            this.conexao.NonQuery(
                "UPDATE `cliente` SET `nome`='" + nome_cliente + "',`email`='" + email + "', `numero_cell`='" + numero_cell + "', `senha`= '" + senha + "' WHERE id_cliente = '" + id_cliente + "'");
               
        }
        public MySqlDataReader ListarClientes()
        {
            return this.conexao.Query("SELECT * from cliente order by nome ASC");
        }
        public MySqlDataReader ListarClienteFiltro(string filtro)
        {
            if (filtro == null)
            {
                return ListarClientes();
            }
            return this.conexao.Query("Select * from cliente WHERE nome LIKE '%" + filtro + "%' order by nome asc");
        }
        public Funcionario(int id_cliente, string nome_cliente, string email, string numero_cell, string senha, string data_cliente)
        {
            this.id_cliente = id_cliente;
            this.nome_cliente = nome_cliente;
            this.email = email;
            this.numero_cell = numero_cell;
            this.senha = senha;
            this.data_cliente = data_cliente;
        }
    }

}*/