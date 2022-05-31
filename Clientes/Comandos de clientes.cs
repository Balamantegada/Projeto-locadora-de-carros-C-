using MySql.Data.MySqlClient;
using SistemaCliente.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCliente.DTO
{
    internal class Cliente
    {
        private ConexaoDB conexao;

        private string _cpf_cliente;

        private string _nome_cliente;
        private string _sobrenome_cliente;
        private string _endereço_completo;
        private string _telefone_cliente;
        private string _email_cliente;
        private string _cnh_cliente;
        private string _cep_residencia_cliente;
        private string _data_cliente;
        private int _ativo_cliente;

        public string cpf_cliente
        {
            get { return _cpf_cliente; }
            set { _cpf_cliente = value; }
        }
        public string nome_cliente
        {
            get { return _nome_cliente; }
            set { _nome_cliente = value; }
        }
        public string sobrenome_cliente
        {
            get { return _sobrenome_cliente; }
            set { _sobrenome_cliente = value; }
        }
        public string endereço_completo
        {
            get { return _endereço_completo; }
            set { _endereço_completo = value; }
        }
        public string telefone_cliente
        {
            get { return _telefone_cliente; }
            set { _telefone_cliente = value; }
        }
        public string email_cliente
        {
            get { return _email_cliente; }
            set { _email_cliente = value; }
        }
        public string cnh_cliente
        {
            get { return _cnh_cliente; }
            set { _cnh_cliente = value; }
        }
        public string cep_residencia_cliente
        {
            get { return _cep_residencia_cliente; }
            set { _cep_residencia_cliente = value; }
        }
        public string data_cliente
        {
            get { return _data_cliente; }
            set { _data_cliente = value; }
        }
        public int ativo_cliente
        {
            get { return _ativo_cliente; }
            set { _ativo_cliente = value; }
        }
        public Cliente()
        {
            this.conexao = new ConexaoDB();
        }
        public void CadastrarCliente()
        {
            this.conexao.NonQuery(
                "INSERT INTO `clientes`(`cpf_cliente`, `nome_cliente`, `sobrenome_cliente`, `endereço_completo`, `telefone_cliente`, `email_cliente`, `cnh_cliente`, `cep_residencia_cliente`, `ativo_cliente`) VALUES('" + cpf_cliente + "', '" + nome_cliente + "', '"+sobrenome_cliente+"', '"+endereço_completo+"', '"+telefone_cliente+"', '"+email_cliente+"', '"+ cnh_cliente +"', '"+ cep_residencia_cliente +"', '"+ ativo_cliente +"')");
        }
        public void AlterarCliente(string chave_alterar)
        {
            this.conexao.NonQuery(
                "UPDATE `clientes` SET `cpf_cliente`='" + cpf_cliente + "', `nome_cliente`= '" + nome_cliente + "', `sobrenome_cliente`= '"+sobrenome_cliente+"',`endereço_completo`= '"+endereço_completo+"', `telefone_cliente`= '"+telefone_cliente+"', `email_cliente`= '"+email_cliente+"', `cnh_cliente`= '"+cnh_cliente+"', `cep_residencia_cliente`= '"+cep_residencia_cliente+"', `ativo_cliente`= '"+ ativo_cliente+"' WHERE cpf_cliente = '" + chave_alterar + "'");

        }
        public MySqlDataReader ListarClientes()
        {
            return this.conexao.Query("SELECT * from clientes order by data_cliente ASC");
        }
        public MySqlDataReader ListarClientesFiltro(string filtro)
        {
            if (filtro == null)
            {
                return ListarClientes();
            }
            return this.conexao.Query("Select * from clientes WHERE nome_cliente LIKE '%" + filtro + "%' order by nome_cliente asc");
        }
        public void DeletarCliente(string cpf_cliente, int opcao)
        {
            if(opcao == 0)
            {
                this.conexao.NonQuery(
                "UPDATE `clientes` SET `ativo_cliente`= '1' WHERE cpf_cliente = '" + cpf_cliente + "'");
            }
            else
            {
                this.conexao.NonQuery(
                "UPDATE `clientes` SET `ativo_cliente`= '0' WHERE cpf_cliente = '" + cpf_cliente + "'");
            }
            
        }
        public Cliente(string cpf_cliente, string nome_cliente, string sobrenome_cliente, string endereço_completo, string telefone_cliente, string email_cliente, string cnh_cliente, string cep_residencia_cliente, string data_cliente, int ativo_cliente)
        {
            this.cpf_cliente = cpf_cliente;
            this.nome_cliente = nome_cliente;
            this.sobrenome_cliente = sobrenome_cliente;
            this.endereço_completo = endereço_completo;
            this.telefone_cliente = telefone_cliente;
            this.email_cliente = email_cliente;
            this.cnh_cliente = cnh_cliente;
            this.cep_residencia_cliente = cep_residencia_cliente;
            this.data_cliente = data_cliente;
            this.ativo_cliente = ativo_cliente;
        }
    }
}
