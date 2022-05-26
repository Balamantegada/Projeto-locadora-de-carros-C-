using MySql.Data.MySqlClient;
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

        private int _id_funcio;

        private string _usuario_funcionario;
        private string _senha_funcio;
        private string _data_funcio;

        public int id_funcio
        {
            get { return _id_funcio; }
            set { _id_funcio = value; }
        }
        public string usuario_funcionario
        {
            get { return _usuario_funcionario; }
            set { _usuario_funcionario = value; }
        }
        public string senha_funcio
        {
            get { return _senha_funcio; }
            set { _senha_funcio = value; }
        }
        public string data_funcio
        {
            get { return _data_funcio; }
            set { _data_funcio = value; }
        }
        public Funcionario()
        {
            this.conexao = new ConexaoDB();
        }
        public void CadastrarFuncionario()
        {
            this.conexao.NonQuery(
                "INSERT INTO `funcionarios`(`usuario_funcio`, `senha_funcio`) VALUES('" + usuario_funcionario + "', '" + senha_funcio + "')");
        }
        public void AlterarFuncionario(string id_funcio)
        {
            this.conexao.NonQuery(
                "UPDATE `funcionarios` SET `usuario_funcio`='" + usuario_funcionario + "', `senha_funcio`= '" + senha_funcio + "' WHERE id_funcio = '" + id_funcio + "'");
        }
        public MySqlDataReader ListarFuncionarios()
        {
            return this.conexao.Query("SELECT * from funcionarios order by usuario_funcio ASC");
        }
        public MySqlDataReader ListarFuncionariosFiltro(string filtro)
        {
            if (filtro == null)
            {
                return ListarFuncionarios();
            }
            return this.conexao.Query("Select * from funcionarios WHERE usuario_funcio LIKE '%" + filtro + "%' order by usuario_funcio asc");
        }
        public void DeletarFuncionario(int id_funcio)
        {
            this.conexao.NonQuery(
                "DELETE FROM `funcionarios` WHERE id_funcio = '" + id_funcio + "'");
        }
        public Funcionario(int id_cliente, string usuario_funcionario, string senha_funcio, string data_funcio)
        {
            this.id_funcio = id_cliente;
            this.usuario_funcionario = usuario_funcionario;
            this.senha_funcio = senha_funcio;
            this.data_funcio = data_funcio;
        }
    }

}