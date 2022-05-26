using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Configuration;
using SistemaCliente.DataBase;
using SistemaCliente.DTO;

namespace SistemaCliente
{
    public partial class Frm_Cadastro_Locacoes : Form
    {
        private Locacoes comandos;
        private LoginAcesso verifica;

        public Frm_Cadastro_Locacoes(bool btSalvar, int cpf_locatorio, int id_carro, string km_inicial, string km_entrega_carro, string data_locacao, string data_devolucao, int finalizado)
        {
            InitializeComponent();
            bool btSalvarCliente = btSalvar;
            if (btSalvar == true)
            {
                this.Btn_ConfirmCadastro.Visible = true;
                this.Bt_SalvarNovo.Visible = true;
                this.Btn_Atualizar.Visible = false;
                Clear();
            }
            else
            {
                this.Btn_ConfirmCadastro.Visible = false;
                this.Bt_SalvarNovo.Visible = false;
                this.Btn_Atualizar.Visible = true;
                Input_Finalizado.Text = finalizado.ToString();
            }
            Input_CPF_locatorio.Text = cpf_locatorio.ToString();
            Input_ID_Carro.Text = id_carro.ToString();
            Input_Km_Inicial.Text = km_inicial;
            Input_Km_Entrega.Text = km_entrega_carro;
            Input_Data_Locacao.Text = data_locacao;
            Input_Data_Devolucao.Text = data_devolucao;
            Lbl_CPF_Atual.Text = cpf_locatorio.ToString();
        }
        public void Clear()
        {
            Input_CPF_locatorio.Text =
            Input_ID_Carro.Text =
            Input_Km_Inicial.Text =
            Input_Km_Entrega.Text =
            Input_Data_Locacao.Text =
            Input_Data_Devolucao.Text = String.Empty;
            Input_Finalizado.Text = "1 caso locado, apague caso esteja finalizado."; 
        }
        public void salvarRegistro(bool fechar, bool limpar)
        {
            try
            {
                this.comandos = new Locacoes();
                
                this.comandos.cpf_locatorio = Int32.Parse(Input_CPF_locatorio.Text);
                this.comandos.id_carro = Int32.Parse(Input_ID_Carro.Text);
                this.comandos.km_inicial = Input_Km_Inicial.Text;
                this.comandos.km_entrega_carro = Input_Km_Entrega.Text;
                this.comandos.data_locacao = Input_Data_Locacao.Text;
                this.comandos.data_devolucao = Input_Data_Devolucao.Text;
                if (Input_Finalizado.Text == "")
                {
                    this.comandos.finalizado = 0;
                }
                else
                {
                    this.comandos.finalizado = 1;
                }
                this.comandos.CadastrarLocacao();
                MessageBox.Show("Locação salva com sucesso.");
                Clear();
                if (fechar) { Close(); } // se fechar for true então fecha aplicação;; se for falso ele nao fecha
                if (limpar) { Clear(); } // se o limpar for true então chama a função clear();
            }
            catch (Exception c)
            {
                if (c.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Cpf duplicado!: " + c.Message, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    this.Lbl_CPF_Locatorio.ForeColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Erro de Conexão ao banco ", "Não foi possivel salvar o registro :", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void Btn_ConfirmCadastro_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(Input_Km_Inicial.Text) > Int32.Parse(Input_Km_Entrega.Text))
            {
                MessageBox.Show("Nunca que o Km inicial será maior que o de entrega.");
                Input_Km_Entrega.ForeColor = Color.Red;
                Input_Km_Inicial.ForeColor = Color.Red;
                return;
            }
            this.comandos = new Locacoes();
            this.comandos.id_carro = Int32.Parse(Input_ID_Carro.Text);
            MySqlDataReader temp = this.comandos.VerificarLocado();
            if (temp.HasRows)
            {
                MessageBox.Show("Carro já locado, altere ID do carro.");
            }
            else
            {
                Frm_Funcionario_List f = new Frm_Funcionario_List();
                f.listarClientes();
                salvarRegistro(true, false);
            }
        }
        private void Bt_SalvarNovo_Click_1(object sender, EventArgs e)
        {
            if (Int32.Parse(Input_Km_Inicial.Text) > Int32.Parse(Input_Km_Entrega.Text))
            {
                MessageBox.Show("Nunca que o Km inicial será maior que o de entrega.");
                Input_Km_Entrega.ForeColor = Color.Red;
                Input_Km_Inicial.ForeColor = Color.Red;
                return;
            }
            this.comandos = new Locacoes();
            this.comandos.id_carro = Int32.Parse(Input_ID_Carro.Text);
            MySqlDataReader temp = this.comandos.VerificarLocado();
            if (temp.HasRows)
            {
                MessageBox.Show("Carro já locado, altere ID do carro.");
            }
            else
            {
                Frm_Funcionario_List f = new Frm_Funcionario_List();
                f.listarClientes();
                salvarRegistro(false, true);
            }

        }

        private void Bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Atualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.comandos = new Locacoes();
                this.comandos.id_carro = Int32.Parse(Input_ID_Carro.Text);
                MySqlDataReader temp = this.comandos.VerificarLocado();
                if (temp.HasRows)
                {
                    MessageBox.Show("Carro já locado, altere ID do carro.");
                }
                else
                {
                    this.comandos = new Locacoes();
                    this.comandos.cpf_locatorio = Int32.Parse(Input_CPF_locatorio.Text);
                    this.comandos.id_carro = Int32.Parse(Input_ID_Carro.Text);
                    this.comandos.km_inicial = Input_Km_Inicial.Text;
                    this.comandos.km_entrega_carro = Input_Km_Entrega.Text;
                    this.comandos.data_locacao = Input_Data_Locacao.Text;
                    this.comandos.data_devolucao = Input_Data_Devolucao.Text;
                    this.comandos.finalizado = Int32.Parse(Input_Finalizado.Text);
                    this.comandos.AlterarLocacao(Lbl_CPF_Atual.Text);
                    MessageBox.Show("Locação Atualizado com sucesso.");
                    this.Close();
                }
            }
            catch (Exception c)
            {
                MessageBox.Show("Erro na Atualização " + c.ToString());
            }
        }
    }
}
