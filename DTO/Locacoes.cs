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
    internal class Locacoes
    {
        private ConexaoDB conexao;
        
        private int _cpf_locatorio;
        private int _id_carro;
        private string _km_inicial;
        private string _km_entrega_carro;
        private string _data_locacao;
        private string _data_devolucao;
        private int _finalizado;

        public int cpf_locatorio
        {
            get { return _cpf_locatorio; }
            set { _cpf_locatorio = value; }
        }
        public int id_carro
        {
            get { return _id_carro; }
            set { _id_carro = value; }
        }
        public string km_inicial
        {
            get { return _km_inicial; }
            set { _km_inicial = value;}
        }
        public string km_entrega_carro
        {
            get { return _km_entrega_carro; }
            set { _km_entrega_carro = value; }
        }
        public string data_locacao
        {
            get { return _data_locacao;}
            set { _data_locacao = value;}
        }
        public string data_devolucao
        {
            get { return _data_devolucao; }
            set { _data_devolucao = value; }
        }
        public int finalizado
        {
            get { return _finalizado; }
            set { _finalizado = value; }
        }
        public Locacoes()
        {
            this.conexao = new ConexaoDB();
        }
        public MySqlDataReader VerificarLocado()
        {
            return this.conexao.Query("SELECT * from carros WHERE (ja_locado ='1' and id_carro='" + id_carro + "');");
        }
        public void CadastrarLocacao()
        {
            if(id_carro.ToString() == "")
            {
                this.conexao.NonQuery("INSERT INTO `locacoes`(`cpf_do_locatorio`, `id_carro`, `km_inicial`, `km_entrega_carro`, `data_locacao`, `data_devolucao`, `finalizado`) VALUES ('" + cpf_locatorio + "','" + id_carro + "','" + km_inicial + "','" + km_entrega_carro + "','" + data_locacao + "','" + data_devolucao + "','" + finalizado + "')");
            }
            else
            {
                this.conexao.NonQuery("INSERT INTO `locacoes`(`cpf_do_locatorio`, `id_carro`, `km_inicial`, `km_entrega_carro`, `data_locacao`, `data_devolucao`, `finalizado`) VALUES ('" + cpf_locatorio + "','" + id_carro + "','" + km_inicial + "','" + km_entrega_carro + "','" + data_locacao + "','" + data_devolucao + "','" + finalizado + "')");
            }
            if (finalizado == 0)
            {
                this.conexao.NonQuery("UPDATE `carros` SET `ja_locado`='' WHERE id_carro='" + id_carro + "'");
            }
            else
            {
                this.conexao.NonQuery("UPDATE `carros` SET `ja_locado`='1' WHERE id_carro='" + id_carro + "'");
            }
        }
        public void AlterarLocacao(string cpf)
        {
            this.conexao.NonQuery(
                "UPDATE `locacoes` SET `cpf_do_locatorio`='"+cpf_locatorio+"',`id_carro`='"+id_carro+"',`km_inicial`='"+km_inicial+"',`km_entrega_carro`='"+km_entrega_carro+"',`data_locacao`='"+data_locacao+"',`data_devolucao`='"+data_devolucao+"',`finalizado`='"+finalizado+"' WHERE cpf_do_locatorio='"+cpf+"'");
            if (finalizado == 0)
            {
                this.conexao.NonQuery("UPDATE `carros` SET `ja_locado`='' WHERE id_carro='" + id_carro + "'");
            }
            else
            {
                this.conexao.NonQuery("UPDATE `carros` SET `ja_locado`='1' WHERE id_carro='" + id_carro + "'");
            }
        }
        public MySqlDataReader ListarLocacoes()
        {
            return this.conexao.Query("SELECT * from locacoes order by data_locacao ASC");
        }
        public MySqlDataReader ListarLocacoesFiltro(string filtro)
        {
            if (filtro == null)
            {
                return ListarLocacoes();
            }
            return this.conexao.Query("Select * from Locacoes WHERE cpf_do_locatorio LIKE '%" + filtro + "%' order by cpf_do_locatorio asc");
        }
        public void FinalizarLocacao(int cpf, int id, int opcao)
        {
            if (opcao == 0)
            {
                this.conexao.NonQuery(
                "UPDATE `locacoes` SET `finalizado`= '1' WHERE  cpf_do_locatorio = '" + cpf + "'");
                this.conexao.NonQuery("UPDATE `carros` SET `ja_locado`='1' WHERE id_carro='" + id + "'");
            }
            else
            {
                this.conexao.NonQuery(
                "UPDATE `locacoes` SET `finalizado`= '0' WHERE  cpf_do_locatorio = '" + cpf + "'");
                this.conexao.NonQuery("UPDATE `carros` SET `ja_locado`='' WHERE id_carro='" + id + "'");
            }
        }
        public Locacoes(int cpf_locatorio, int id_carro, string km_inicial, string km_entrega_carro, string data_locacao, string data_devolucao, int finalizado)
        {
            this.cpf_locatorio = cpf_locatorio;
            this.id_carro = id_carro;
            this.km_inicial = km_inicial;
            this.km_entrega_carro = km_entrega_carro;
            this.data_locacao = data_locacao;
            this.data_devolucao = data_devolucao;
            this.finalizado = finalizado;
        }
    }
}
