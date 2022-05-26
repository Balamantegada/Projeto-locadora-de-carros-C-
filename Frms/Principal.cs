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
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }
        private void Btn_Login_admin_Click(object sender, EventArgs e)
        {
            Frm_Login_admin f = new Frm_Login_admin();
            f.ShowDialog();
        }

        private void Btn_Login_Funcio_Click(object sender, EventArgs e)
        {
            Frm_Login_funcio f = new Frm_Login_funcio();
            f.ShowDialog();
        }
    }
}
