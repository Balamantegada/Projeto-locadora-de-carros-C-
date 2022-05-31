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
    public partial class Frm_Carros_List : Form
    {
        private Carros comandos;
        int id_carro;

        string tamanho;
        string categoria;
        string cilindradas;
        string gps;
        string tela_de_lcd;
        string fabricante;
        string modelo;
        string ano;
        string painel_digital;
        string cambio_automatico;
        string tipo_de_combustivel;
        string data_de_compra;
        string valor_de_compra;
        string placa;
        string foto;
        bool btSalvar;
        public Frm_Carros_List()
        {
            InitializeComponent();
        }

        private void Frm_User_List_Load(object sender, EventArgs e)
        {
            listarCarros();
        }
        private void Bt_BuscarNome_Click(object sender, EventArgs e)
        {
            String Filtro = Input_BuscarCarros.Text;
            MySqlDataReader temp = this.comandos.ListarCarrosFiltro(Filtro);
            DataTable dt = new DataTable();
            dataGridCarros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCarros.RowTemplate.Height = 120;
            dataGridCarros.AllowUserToAddRows = false;
            dt.Load(temp);
            dataGridCarros.DataSource = dt;
        }

        private void Novo_Cliente_Click(object sender, EventArgs e)
        {
            id_carro = 0;
            modelo = "";
            tamanho = "";
            categoria = "";
            cilindradas = "";
            gps = "";
            tela_de_lcd = "";
            fabricante = "";
            ano = "";
            painel_digital = "";
            cambio_automatico = "";
            tipo_de_combustivel = "";
            data_de_compra = "";
            valor_de_compra = "";
            placa = "";
            foto = "";
            Frm_Cadastro_Carros form = new Frm_Cadastro_Carros(btSalvar = false, id_carro, tamanho, categoria, cilindradas, gps, tela_de_lcd, fabricante, modelo, ano, painel_digital, cambio_automatico, tipo_de_combustivel, data_de_compra, valor_de_compra, placa, foto);
            form.Show();
            listarCarros();
        }

        public void listarCarros()
        {
            this.comandos = new Carros();
            MySqlDataReader temp = this.comandos.ListarCarros();
            DataTable dt = new DataTable();
            dataGridCarros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCarros.RowTemplate.Height = 120;
            dataGridCarros.AllowUserToAddRows = false;
            dt.Load(temp);
            dataGridCarros.DataSource = dt;
        }
        private void Btn_Alterar_Click(object sender, EventArgs e)
        {
            if (Lbl_Modelo.Text == "-----")
            {
                MessageBox.Show("Selecione um carro.");
                return;
            }
            else
            {
                Frm_Cadastro_Carros form = new Frm_Cadastro_Carros(btSalvar = true, id_carro, tamanho, categoria, cilindradas, gps, tela_de_lcd, fabricante, modelo, ano, painel_digital, cambio_automatico, tipo_de_combustivel, data_de_compra, valor_de_compra, placa, foto);
                form.Show();
            }
        }
        private void Btn_Atualizar_Click(object sender, EventArgs e)
        {
            listarCarros();
        }
        private void dataGridCarros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha = dataGridCarros.Rows[e.RowIndex];

            id_carro = (int)linha.Cells[0].Value;
            modelo = linha.Cells[1].Value.ToString();
            categoria = linha.Cells[2].Value.ToString();
            cilindradas = linha.Cells[3].Value.ToString();
            gps = linha.Cells[4].Value.ToString();
            tela_de_lcd = linha.Cells[5].Value.ToString();
            fabricante = linha.Cells[6].Value.ToString();
            tamanho = linha.Cells[7].Value.ToString();
            ano = linha.Cells[8].Value.ToString();
            painel_digital = linha.Cells[9].Value.ToString();
            cambio_automatico = linha.Cells[10].Value.ToString();
            tipo_de_combustivel = linha.Cells[11].Value.ToString();
            data_de_compra = linha.Cells[12].Value.ToString();
            valor_de_compra = linha.Cells[13].Value.ToString();
            placa = linha.Cells[14].Value.ToString();
            foto = linha.Cells[16].Value.ToString();

            Lbl_Modelo.Text = modelo;
            Lbl_Valor_Compra.Text = valor_de_compra;
        }

        private void Bt_Excluir_Click(object sender, EventArgs e)
        {
            if (modelo == "-----")
            {
                MessageBox.Show("Selecione um carro para excluir.");
                return;
            }
            else
            {
                Frm_Cadastro_Carros form = new Frm_Cadastro_Carros(btSalvar = true, id_carro, tamanho, categoria, cilindradas, gps, tela_de_lcd, fabricante, modelo, ano, painel_digital, cambio_automatico, tipo_de_combustivel, data_de_compra, valor_de_compra, placa, foto);
                this.comandos.DeletarCarro(id_carro);
                MessageBox.Show("Cadastro de carro deletado com sucesso.");
            }
        }
    }
}
