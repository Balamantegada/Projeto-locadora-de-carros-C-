using MySql.Data.MySqlClient;
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
    public partial class Frm_Funcionario_List : Form
    {
        private Funcionario comandos;
        int id_funcio;
        string usuario_funcionario;
        string senha_funcio;
        bool btSalvar;

        public Frm_Funcionario_List()
        {
            InitializeComponent();
        }

        private void Frm_User_List_Load(object sender, EventArgs e)
        {
            listarClientes();
        }
        private void Bt_BuscarNome_Click(object sender, EventArgs e)
        {
            String Filtro = Input_BuscarUsuario.Text;
            MySqlDataReader temp = this.comandos.ListarFuncionariosFiltro(Filtro);
            DataTable dt = new DataTable();
            dataGridUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridUsuario.RowTemplate.Height = 120;
            dataGridUsuario.AllowUserToAddRows = false;
            dt.Load(temp);
            dataGridUsuario.DataSource = dt;
        }

        private void Novo_Cliente_Click(object sender, EventArgs e)
        {
            int id_funcio = 0;
            string usuario_funcionario = "";
            string senha_funcio = "";
            Frm_Cadastro_Funcionario form = new Frm_Cadastro_Funcionario(btSalvar = false, id_funcio, usuario_funcionario, senha_funcio);
            form.Show();
            listarClientes();
        }

        public void listarClientes()
        {
            this.comandos = new Funcionario();
            MySqlDataReader temp = this.comandos.ListarFuncionarios();
            DataTable dt = new DataTable();
            dataGridUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridUsuario.RowTemplate.Height = 120;
            dataGridUsuario.AllowUserToAddRows = false;
            dt.Load(temp);
            dataGridUsuario.DataSource = dt;
        }
        private void Btn_Alterar_Click(object sender, EventArgs e)
        {
            if (Lbl_NomeCliente.Text == "-----")
            {
                MessageBox.Show("Selecione um Nome");
                return;
            }
            else
            {
                Frm_Cadastro_Funcionario form = new Frm_Cadastro_Funcionario(btSalvar = true, id_funcio, usuario_funcionario, senha_funcio);
                form.Show();
            }
        }

        private void Btn_Atualizar_Click(object sender, EventArgs e)
        {
            listarClientes();
        }
        private void dataGridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha = dataGridUsuario.Rows[e.RowIndex];
            id_funcio = (int)linha.Cells[0].Value;
            usuario_funcionario = linha.Cells[1].Value.ToString();
            senha_funcio = linha.Cells[2].Value.ToString();
            Lbl_NomeCliente.Text = usuario_funcionario;
            Lbl_NumeroCell.Text = senha_funcio;
        }

        private void Bt_Excluir_Click(object sender, EventArgs e)
        {
            if (usuario_funcionario == "")
            {
                MessageBox.Show("Selecione um Nome para excluir");
                return;
            }
            else
            {
                Frm_Cadastro_Funcionario form = new Frm_Cadastro_Funcionario(btSalvar = true, id_funcio, usuario_funcionario, senha_funcio);
                this.comandos.DeletarFuncionario(id_funcio);
                MessageBox.Show("Cadastro de funcionario deletado com sucesso");
            }
        }
    }
}
