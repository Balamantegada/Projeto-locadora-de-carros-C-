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
    public partial class Frm_Cadastro_Funcionario : Form
    {
        private Funcionario comandos;

        public Frm_Cadastro_Funcionario(bool btSalvar, int id_funcio, String usuario_funcionario, String senha_funcio)
        {
            InitializeComponent();

            int idSalvar = id_funcio;
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
                this.Lbl_ConfirmSenha.Visible = false;
                this.Input_ConfirmSenha.Visible = false;
                this.Btn_Atualizar.Visible = true;
            }
            Lbl_IdCliente.Text = id_funcio.ToString();
            Input_Usuario.Text = usuario_funcionario;
            Input_Senha.Text = senha_funcio;

        }

        public void Clear()
        {
            Input_Usuario.Text =
            Input_Senha.Text =
            Input_ConfirmSenha.Text = String.Empty;
        }
        public void salvarRegistro(bool fechar, bool limpar)
        {
            try
            {
                this.comandos = new Funcionario();
                this.comandos.usuario_funcionario = Input_Usuario.Text;
                this.comandos.senha_funcio = Input_Senha.Text;
                this.comandos.CadastrarFuncionario();
                MessageBox.Show("Registro salvo com sucesso.");
                if (fechar) { Close(); } // se fechar for true então fecha aplicação;; se for falso ele nao fecha
                if (limpar) { Clear(); } // se o limpar for true então chama a função clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Btn_ConfirmCadastro_Click(object sender, EventArgs e)
        {
            if (Input_Usuario.Text.Equals(""))
            {
                MessageBox.Show("Nome obrigatório");
                return;
            }
            if (Input_Senha.Text.Equals(""))
            {
                MessageBox.Show("Senha obrigatória");
                return;
            }
            if (Input_ConfirmSenha.Text.Equals(Input_Senha.Text))
            {
                Frm_Funcionario_List f = new Frm_Funcionario_List();
                f.listarClientes();
                salvarRegistro(true, false);
            }
            else
            {
                MessageBox.Show("Digite a confirmação da senha corretamente");
                return;
            }
        }
        private void Bt_SalvarNovo_Click_1(object sender, EventArgs e)
        {
            if (Input_Usuario.Text.Equals(""))
            {
                MessageBox.Show("Nome obrigatório");
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
                this.comandos = new Funcionario();
                this.comandos.usuario_funcionario = Input_Usuario.Text;
                this.comandos.senha_funcio = Input_Senha.Text;
                this.comandos.AlterarFuncionario(Lbl_IdCliente.Text);
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
