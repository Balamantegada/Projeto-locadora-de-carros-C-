using MySql.Data.MySqlClient;
using SistemaCliente.DataBase;
using SistemaCliente.DTO;
using SistemaCliente.Frms;
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
    public partial class Frm_Login_admin : Form
    {
        private LoginAcesso comandos;
        public Frm_Login_admin()
        {
            InitializeComponent();
        }
        
        private void Btn_Logar_Click(object sender, EventArgs e)
        {
            if ((Input_Usuario.Text == "") || (Input_Senha.Text == ""))
            {
                Lbl_Erro.Text = "LOGIN INCORRETO - Por favor insera sua senha e usuário.";
            }
            else
            {
                try
                {
                    this.comandos = new LoginAcesso();
                    MySqlDataReader temp = this.comandos.ProcurarAdmin(Input_Usuario.Text, Input_Senha.Text);
                    if (temp.HasRows)
                    {
                        Frm_Admin f = new Frm_Admin();
                        f.ShowDialog();
                        Input_Usuario.Text = "";
                        Input_Senha.Text = "";
                    }
                    else
                    {
                        Lbl_Erro.Text = "LOGIN INCORRETO - Usuário ou Senha incorretos.";
                        Input_Usuario.Text = "";
                        Input_Senha.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
