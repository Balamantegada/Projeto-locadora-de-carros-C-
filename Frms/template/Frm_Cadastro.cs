/*using System;
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
    public partial class Frm_Cadastro : Form
    {
        private Funcionario DTO;

        public Frm_Cadastro(bool btSalvar, int id_cliente, String nome, string email, string numero_celular, String senha)
        {
            InitializeComponent();

            int idSalvar = id_cliente;
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
                this.Btn_Atualizar.Visible = true;
            }
            Lbl_IdCliente.Text = id_cliente.ToString();
            Input_Nome.Text = nome;
            Input_Email.Text = email;
            Input_NumeroCelular.Text = numero_celular;
            Input_Senha.Text = senha;

        }

        public void Clear()
        {
            Input_Nome.Text =
            Input_Email.Text = 
            Input_NumeroCelular.Text = 
            Input_Senha.Text =
            Input_ConfirmSenha.Text = String.Empty;
        }
        public void salvarRegistro(bool fechar, bool limpar)
        {
            try
            {
                this.DTO = new Clientes();
                this.DTO.nome_cliente = Input_Nome.Text;
                this.DTO.email = Input_Email.Text;
                this.DTO.numero_cell = Input_NumeroCelular.Text;
                this.DTO.senha = Input_Senha.Text;
                this.DTO.CadastrarCliente();
                MessageBox.Show("Registro salvo com sucesso.");
                if (fechar) { Close(); } // se fechar for true então fecha aplicação;; se for falso ele nao fecha
                if (limpar) { Clear(); } // se o limpar for true então chama a função clear();
            }
            catch (Exception c)
            {
                if (c.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Usuário Já existe!: " + c.Message, "Erro no Formulário", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    this.Lbl_Nome.ForeColor = Color.Red;
                    this.Lbl_Nome.Text = "Usuário Duplicado";
                }
                else
                {
                    MessageBox.Show("Erro de Conexão ao banco ", "Não foi possivel salvar o registro :", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void Btn_ConfirmCadastro_Click(object sender, EventArgs e)
        {
            if (Input_Nome.Text.Equals(""))
            {
                MessageBox.Show("Nome obrigatório");
                return;
            }
            if (Input_Email.Text.Equals(""))
            {
                MessageBox.Show("Email obrigatório");
                return;
            }
            if (Input_NumeroCelular.Text.Equals(""))
            {
                MessageBox.Show("Numero de celular obrigatório");
                return;
            }
            if (Input_Senha.Text.Equals(""))
            {
                MessageBox.Show("Senha obrigatória");
                return;
            }
            if (Input_ConfirmSenha.Text.Equals(Input_Senha.Text))
            {
                Frm_User_List f = new Frm_User_List();
                f.listarClientes();
                salvarRegistro(true, false);
            }
            else
            {
                MessageBox.Show("Digite a confirmação da senah corretamente");
                return;
            }
        }
        private void Bt_SalvarNovo_Click_1(object sender, EventArgs e)
        {
            if (Input_Nome.Text.Equals(""))
            {
                MessageBox.Show("Nome obrigatório");
                return;
            }
            if (Input_Email.Text.Equals(""))
            {
                MessageBox.Show("Email obrigatório");
                return;
            }
            if (Input_NumeroCelular.Text.Equals(""))
            {
                MessageBox.Show("Numero de celular obrigatório");
                return;
            }
            if (Input_Senha.Text.Equals(""))
            {
                MessageBox.Show("Senha obrigatória");
                return;
            }
            if (Input_ConfirmSenha.Text.Equals(Input_Senha.Text))
            {
                salvarRegistro(false, true);
            }
            else
            {
                MessageBox.Show("Digite a confirmação da senah corretamente");
                return;
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
                this.DTO = new Clientes();
                this.DTO.nome_cliente = Input_Nome.Text;
                this.DTO.email = Input_Email.Text;
                this.DTO.numero_cell = Input_NumeroCelular.Text;
                this.DTO.senha = Input_Senha.Text;
                this.DTO.AlterarCliente(Lbl_IdCliente.Text);
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
*/