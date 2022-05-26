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
    public partial class Frm_Cliente_List : Form
    {
        private Cliente comandos;
        string cpf_cliente;

        string nome_cliente;
        string sobrenome_cliente;
        string endereço_completo;
        string telefone_cliente;
        string email_cliente;
        string cnh_cliente;
        string cep_residencia_cliente;
        string data_cliente;
        int ativo_cliente;
        bool btSalvar;

        public Frm_Cliente_List()
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
            MySqlDataReader temp = this.comandos.ListarClientesFiltro(Filtro);
            DataTable dt = new DataTable();
            dt.Load(temp);
            dataGridUsuario.DataSource = dt;
        }

        private void Novo_Cliente_Click(object sender, EventArgs e)
        {
            string cpf_cliente = "0";
            string nome_cliente = "";
            string sobrenome_cliente = "";
            string endereço_completo ="";
            string telefone_cliente = "";
            string email_cliente = "";
            string cnh_cliente = "";
            string cep_residencia_cliente = "";
            string data_cliente = "";
            int ativo_cliente = 0;
            Frm_Cadastro_Clientes form = new Frm_Cadastro_Clientes(btSalvar = false, cpf_cliente, nome_cliente, sobrenome_cliente, endereço_completo, telefone_cliente, email_cliente, cnh_cliente, cep_residencia_cliente, data_cliente, ativo_cliente);
            form.Show();
            listarClientes();
        }

        public void listarClientes()
        {
            this.comandos = new Cliente();
            MySqlDataReader temp = this.comandos.ListarClientes();
            DataTable dt = new DataTable();
            dt.Load(temp);
            dataGridUsuario.DataSource = dt;
        }
        private void Btn_Alterar_Click(object sender, EventArgs e)
        {
            if (cpf_cliente == "")
            {
                MessageBox.Show("Selecione um CPF.");
                return;
            }
            else
            {
                Frm_Cadastro_Clientes form = new Frm_Cadastro_Clientes(btSalvar = true, cpf_cliente, nome_cliente, sobrenome_cliente, endereço_completo, telefone_cliente, email_cliente, cnh_cliente, cep_residencia_cliente, data_cliente, ativo_cliente);
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
            cpf_cliente = linha.Cells[0].Value.ToString();
            nome_cliente = linha.Cells[1].Value.ToString();
            sobrenome_cliente = linha.Cells[2].Value.ToString();
            endereço_completo = linha.Cells[3].Value.ToString();
            telefone_cliente = linha.Cells[4].Value.ToString();
            email_cliente = linha.Cells[5].Value.ToString();
            cnh_cliente = linha.Cells[6].Value.ToString();
            cep_residencia_cliente = linha.Cells[7].Value.ToString();
            data_cliente = linha.Cells[8].Value.ToString();
            ativo_cliente = (int)linha.Cells[9].Value;

            Lbl_CPF.Text = cpf_cliente.ToString();
            if(ativo_cliente == 0)
            {
                Lbl_Ativo.Text = "Inativo";
                Bt_Excluir.Text = "Ativar";
            }
            else
            {
                Lbl_Ativo.Text = "Ativo";
                Bt_Excluir.Text = "Desativar";
            }
        }

        private void Bt_Excluir_Click(object sender, EventArgs e)
        {
            if (cpf_cliente.ToString() == "")
            {
                MessageBox.Show("Selecione um cpf para atualziar.");
                return;
            }
            else
            {
                Frm_Cadastro_Clientes form = new Frm_Cadastro_Clientes(btSalvar = true, cpf_cliente, nome_cliente, sobrenome_cliente, endereço_completo, telefone_cliente, email_cliente, cnh_cliente, cep_residencia_cliente, data_cliente, ativo_cliente);
                this.comandos.DeletarCliente(cpf_cliente, ativo_cliente);
                listarClientes();
                MessageBox.Show("Atividade do cliente atualizada.");
            }
        }
    }
}
