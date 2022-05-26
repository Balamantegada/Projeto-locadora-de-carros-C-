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
    public partial class Frm_Locacoe_List : Form
    {
        private Locacoes comandos;
        int cpf_locatorio;

        int id_carro;
        string km_inicial;
        string km_entrega_carro;
        string data_locacao;
        string data_devolucao;
        int finalizado;
        bool btSalvar;

        public Frm_Locacoe_List()
        {
            InitializeComponent();
        }

        private void Frm_User_List_Load(object sender, EventArgs e)
        {
            listarlocacoes();
        }
        private void Bt_BuscarNome_Click(object sender, EventArgs e)
        {
            String Filtro = Input_BuscarUsuario.Text;
            MySqlDataReader temp = this.comandos.ListarLocacoesFiltro(Filtro);
            DataTable dt = new DataTable();
            dataGridUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridUsuario.RowTemplate.Height = 120;
            dt.Load(temp);
            dataGridUsuario.DataSource = dt;
        }

        private void Novo_Cliente_Click(object sender, EventArgs e)
        {
            int cpf_locatorio = 0;

            int id_carro = 0;
            string km_inicial = "";
            string km_entrega_carro = "";
            string data_locacao = "";
            string data_devolucao = "";
            int finalizado = 0;
            Frm_Cadastro_Locacoes form = new Frm_Cadastro_Locacoes(btSalvar = true, cpf_locatorio, id_carro, km_inicial, km_entrega_carro, data_locacao, data_devolucao, finalizado);
            form.Show();
            listarlocacoes();
        }

        public void listarlocacoes()
        {
            this.comandos = new Locacoes();
            MySqlDataReader temp = this.comandos.ListarLocacoes();
            DataTable dt = new DataTable();
            dt.Load(temp);
            dataGridUsuario.DataSource = dt;
        }
        private void Btn_Alterar_Click(object sender, EventArgs e)
        {
            if (Lbl_CPF.Text == "-----")
            {
                MessageBox.Show("Selecione um CPF.");
                return;
            }
            else
            {
                Frm_Cadastro_Locacoes form = new Frm_Cadastro_Locacoes(btSalvar = false, cpf_locatorio, id_carro, km_inicial, km_entrega_carro, data_locacao, data_devolucao, finalizado);
                form.Show();
            }
        }
        private void Btn_Atualizar_Click(object sender, EventArgs e)
        {
            listarlocacoes();
        }
        private void dataGridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha = dataGridUsuario.Rows[e.RowIndex];
            cpf_locatorio = (int)linha.Cells[0].Value;
            id_carro = (int)linha.Cells[1].Value;
            km_inicial = linha.Cells[2].Value.ToString();
            km_entrega_carro = linha.Cells[3].Value.ToString();
            data_locacao = linha.Cells[4].Value.ToString();
            data_devolucao = linha.Cells[5].Value.ToString();
            finalizado = (int)linha.Cells[6].Value;

            Lbl_CPF.Text = cpf_locatorio.ToString();
            if(finalizado == 0)
            {
                Lbl_Ativo.Text = "Finalizado";
                Bt_Excluir.Text = "Em aberto";
            }
            else
            {
                Lbl_Ativo.Text = "Em aberto";
                Bt_Excluir.Text = "Finalizar";
            }
        }

        private void Bt_Excluir_Click(object sender, EventArgs e)
        {
            if (cpf_locatorio.ToString() == "")
            {
                MessageBox.Show("Selecione um cpf para atualziar.");
                return;
            }
            else
            {
                if (Lbl_Ativo.Text == "Em aberto")
                {
                    Frm_Cadastro_Locacoes form = new Frm_Cadastro_Locacoes(btSalvar = false, cpf_locatorio, id_carro, km_inicial, km_entrega_carro, data_locacao, data_devolucao, finalizado);
                    this.comandos = new Locacoes();
                    this.comandos.FinalizarLocacao(cpf_locatorio, id_carro, finalizado);
                    listarlocacoes();
                    MessageBox.Show("Atividade do cliente atualizada.");
                }
                else
                {
                    this.comandos = new Locacoes();
                    this.comandos.id_carro = Int32.Parse(id_carro.ToString());
                    MySqlDataReader temp = this.comandos.VerificarLocado();
                    if (temp.HasRows)
                    {
                        MessageBox.Show("Carro já locado, altere ID do carro.");
                    }
                    else
                    {
                        Frm_Cadastro_Locacoes form = new Frm_Cadastro_Locacoes(btSalvar = false, cpf_locatorio, id_carro, km_inicial, km_entrega_carro, data_locacao, data_devolucao, finalizado);
                        this.comandos = new Locacoes();
                        this.comandos.FinalizarLocacao(cpf_locatorio, id_carro, finalizado);
                        listarlocacoes();
                        MessageBox.Show("Atividade do cliente atualizada.");
                    }
                }

            }
        }
    }
}
