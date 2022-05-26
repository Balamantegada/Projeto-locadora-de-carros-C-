using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemaCliente.DataBase
{
    class ConexaoDB
    {
        private MySqlConnection con;
        private MySqlCommand command;
        private MySqlDataAdapter da;
        
        public ConexaoDB()
        {
            Conectar();
        }
        public void Conectar()
        {
            String stringCon = ConfigurationManager.AppSettings["ConexaoBD"];
            this.con = new MySqlConnection(stringCon);
            this.command = this.con.CreateCommand();
            this.con.Open();
        }
        public void NonQuery(String sql)
        {
            this.command.CommandText = sql;
            this.command.ExecuteNonQuery();
        }
        public MySqlDataReader Query(String sql)
        {
            this.command.CommandText = sql;
            return this.command.ExecuteReader();
        }
    }
}
