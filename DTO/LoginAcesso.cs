using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistemaCliente.DataBase;

namespace SistemaCliente.DTO
{
    internal class LoginAcesso
    {
        private ConexaoDB conexao;
        
        private string _usuario;
        private string _senha;

        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        public string senha
        {
            get { return _senha; }
            set { _senha = value; }
        }
        public LoginAcesso()
        {
            this.conexao = new ConexaoDB();
        }
        public MySqlDataReader ProcurarAdmin(string usuario, string senha)
        {
            return this.conexao.Query("SELECT * from adms WHERE (usuario_adm='" + usuario + "' and senha_adm='" + senha + "');");
        }
        public MySqlDataReader ProcurarFuncionario(string usuario, string senha)
        {
            return this.conexao.Query("SELECT * from funcionarios WHERE (usuario_funcio='" + usuario + "' and senha_funcio='" + senha + "');");
        }
        public LoginAcesso(string usuario, string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
        }
    }
}
