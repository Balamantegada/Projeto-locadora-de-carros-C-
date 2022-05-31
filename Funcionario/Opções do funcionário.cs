using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCliente.Frms
{
    public partial class Frm_Funcionario : Form
    {
        public Frm_Funcionario()
        {
            InitializeComponent();
        }

        private void Btn_Cadastrar_Cliente_Click(object sender, EventArgs e)
        {
            Frm_Cliente_List f = new Frm_Cliente_List();
            f.ShowDialog();
        }

        private void Btn_Cadastrar_Locações_Click(object sender, EventArgs e)
        {
            Frm_Locacoe_List f = new Frm_Locacoe_List();
            f.ShowDialog();
        }
    }
}
