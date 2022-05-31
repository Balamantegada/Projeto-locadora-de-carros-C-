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
    public partial class Frm_Cadastro_Clientes : Form
    {
        private Cliente comandos;

        public Frm_Cadastro_Clientes(bool btSalvar, string cpf_cliente, string nome_cliente, string sobrenome_cliente, string endereço_completo, string telefone_cliente, string email_cliente, string cnh_cliente, string cep_residencia_cliente, string data_cliente, int ativo_cliente)
        {
            InitializeComponent();
            bool btSalvarCliente = btSalvar;
            if (btSalvar == false)
            {
                this.Btn_ConfirmCadastro.Visible = true;
                this.Bt_SalvarNovo.Visible = true;
                this.Btn_Atualizar.Visible = false;
            }
            else
            {
                this.Btn_ConfirmCadastro.Visible = false;
                this.Bt_SalvarNovo.Visible = false;
                this.Input_Sobrenome.Visible = false;
                this.Btn_Atualizar.Visible = true;
            }
            Input_CPF.Text = cpf_cliente;
            Input_Nome.Text = nome_cliente;
            Input_Sobrenome.Text = sobrenome_cliente;
            Input_Endereço_Completo.Text = endereço_completo;
            Input_Telefone.Text = telefone_cliente;
            Input_Email.Text = email_cliente;
            Input_CNH.Text = cnh_cliente;
            Input_CEP_Residencia.Text = cep_residencia_cliente;
            Input_Ativo.Text = ativo_cliente.ToString();
            Lbl_CPF_Atual.Text = cpf_cliente;
        }
        public void Clear()
        {
            Input_CPF.Text =
            Input_Nome.Text =
            Input_Sobrenome.Text = 
            Input_Endereço_Completo.Text =
            Input_Telefone.Text =
            Input_Email.Text =
            Input_CNH.Text =
            Input_CEP_Residencia.Text =
            Input_Ativo.Text = String.Empty;
        }
        public void salvarRegistro(bool fechar, bool limpar)
        {
            try
            {
                this.comandos = new Cliente();
                
                this.comandos.cpf_cliente = Input_CPF.Text;
                this.comandos.nome_cliente = Input_Nome.Text;
                this.comandos.sobrenome_cliente = Input_Sobrenome.Text;
                this.comandos.endereço_completo = Input_Endereço_Completo.Text;
                this.comandos.telefone_cliente = Input_Telefone.Text;
                this.comandos.email_cliente = Input_Email.Text;
                this.comandos.cnh_cliente = Input_CNH.Text;
                this.comandos.cep_residencia_cliente = Input_CEP_Residencia.Text;
                this.comandos.ativo_cliente = Int32.Parse(Input_Ativo.Text);
                this.comandos.CadastrarCliente();
                MessageBox.Show("Registro salvo com sucesso.");
                Clear();
                if (fechar) { Close(); } // se fechar for true então fecha aplicação;; se for falso ele nao fecha
                if (limpar) { Clear(); } // se o limpar for true então chama a função clear();
            }
            catch (Exception c)
            {
                if (c.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Cpf duplicado!: " + c.Message, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    this.Lbl_CPF_Atual.ForeColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Erro de Conexão ao banco ", "Não foi possivel salvar o registro :", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void Btn_ConfirmCadastro_Click(object sender, EventArgs e)
        {
            if (Input_CPF.Text.Equals(""))
            {
                MessageBox.Show("CPF obrigatório.");
                return;
            }
            if (Input_Telefone.Text.Equals(""))
            {
                MessageBox.Show("Telefone obrigatório.");
                return;
            }
            if (Input_CNH.Text.Equals(""))
            {
                MessageBox.Show("CNH obrigatório.");
                return;
            }
            Frm_Funcionario_List f = new Frm_Funcionario_List();
            f.listarClientes();
            salvarRegistro(true, false);
        }
        private void Bt_SalvarNovo_Click_1(object sender, EventArgs e)
        {
            if (Input_CPF.Text.Equals(""))
            {
                MessageBox.Show("CPF obrigatório.");
                return;
            }
            if (Input_Telefone.Text.Equals(""))
            {
                MessageBox.Show("Telefone obrigatório.");
                return;
            }
            if (Input_CNH.Text.Equals(""))
            {
                MessageBox.Show("CNH obrigatório.");
                return;
            }
            salvarRegistro(false, true);
        }

        private void Bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Atualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.comandos = new Cliente();
                this.comandos.cpf_cliente = Input_CPF.Text;
                this.comandos.nome_cliente = Input_Nome.Text;
                this.comandos.sobrenome_cliente = Input_Sobrenome.Text;
                this.comandos.endereço_completo = Input_Endereço_Completo.Text;
                this.comandos.telefone_cliente = Input_Telefone.Text;
                this.comandos.email_cliente = Input_Email.Text;
                this.comandos.cnh_cliente = Input_CNH.Text;
                this.comandos.cep_residencia_cliente = Input_CEP_Residencia.Text;
                if (Input_Ativo.Text == "0")
                {
                    this.comandos.ativo_cliente = 0;
                }
                if(Input_Ativo.Text == "1")
                {
                    this.comandos.ativo_cliente = 1;
                }
                this.comandos.AlterarCliente(Lbl_CPF_Atual.Text);
                MessageBox.Show("Registro Atualizado com sucesso.");
                this.Close();

            }
            catch (Exception c)
            {
                MessageBox.Show("Erro na Atualização " + c.ToString());
            }
        }
    }
}
