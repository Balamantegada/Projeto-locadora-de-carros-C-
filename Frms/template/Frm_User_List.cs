/*sing MySql.Data.MySqlClient;
using SistemaCliente.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaCliente
{
    public partial class Frm_User_List : Form
    {
        private Funcionario comandos;
        int id_cliente;
        string nome_cliente;
        string email;
        string numero_cell;
        string senha;
        bool btSalvar;

        public Frm_User_List()
        {
            InitializeComponent();
        }

        private void Frm_User_List_Load(object sender, EventArgs e)
        {
            listarClientes();
        }
        private void Bt_BuscarNome_Click_1(object sender, EventArgs e)
        {
            String Filtro = Input_BuscarNome.Text;
            MySqlDataReader temp = this.comandos.ListarClienteFiltro(Filtro);
            DataTable dt = new DataTable();
            dt.Load(temp);
            dataGridClientes.DataSource = dt;
        }

        private void Novo_Cliente_Click(object sender, EventArgs e)
        {
            int id_cliente = 0;
            string Nome = "";
            string Email = "";
            string Numero_cell = "";
            string Senha = "";
            Frm_Cadastro form = new Frm_Cadastro(btSalvar = false, id_cliente, Nome, Email, Numero_cell, Senha);
            form.Show();
            listarClientes();
        }

        public void listarClientes()
        {
            this.comandos = new Clientes();
            MySqlDataReader temp = this.comandos.ListarClientes();
            DataTable dt = new DataTable();
            dt.Load(temp);
            dataGridClientes.DataSource = dt;
        }
        private void Btn_Alterar_Click_1(object sender, EventArgs e)
        {
            if (nome_cliente=="")
            {
                MessageBox.Show("Selecione um Nome");
                return;
            }
            else
            {
                Frm_Cadastro form = new Frm_Cadastro(btSalvar = true, id_cliente, nome_cliente, email, numero_cell, senha);
                form.Show();
            }
        }

        private void Btn_Atualizar_Click_1(object sender, EventArgs e)
        {
            listarClientes();
        }
        private void dataGridClientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha = dataGridClientes.Rows[e.RowIndex];
            id_cliente = (int)linha.Cells[0].Value;
            nome_cliente = linha.Cells[1].Value.ToString();
            email = linha.Cells[2].Value.ToString();
            numero_cell = linha.Cells[3].Value.ToString();
            senha = linha.Cells[4].Value.ToString();
            Lbl_NomeCliente.Text = nome_cliente;
            Lbl_NumeroCell.Text = numero_cell;
        }
    }
}
*/