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
    public partial class Frm_Login_funcio : Form
    {
        private LoginAcesso comandos;
        public Frm_Login_funcio()
        {
            InitializeComponent();
        }
        
        private void Btn_Logar_Click(object sender, EventArgs e)
        {
            
            if ((Input_Nome.Text == "") || (Input_Senha.Text == ""))
            {
                Lbl_Erro.Text = "Erro";
            }
            else
            {
                try
                {
                    this.comandos = new LoginAcesso();
                    MySqlDataReader temp = this.comandos.ProcurarFuncionario(Input_Nome.Text, Input_Senha.Text);
                    if (temp.HasRows)
                    {
                        Frm_Funcionario f = new Frm_Funcionario();
                        f.ShowDialog();
                    }
                    else
                    {
                        Lbl_Erro.Text = "Erro.";
                        Input_Nome.Text = "";
                        Input_Senha.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            

            Input_Nome.Text = "";
            Input_Senha.Text = "";
        }
    }
}
