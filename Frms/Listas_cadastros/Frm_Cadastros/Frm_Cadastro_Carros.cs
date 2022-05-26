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
    public partial class Frm_Cadastro_Carros : Form
    {
        private Carros comandos;

        public Frm_Cadastro_Carros(bool btSalvar, int id_carro, string tamanho, string categoria, string cilindradas, string gps, string tela_de_lcd, string fabricante, string modelo, string ano, string painel_digital, string cambio_automatico, string tipo_de_combustivel, string data_de_compra, string valor_de_compra, string placa, string foto)
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
                this.Btn_Atualizar.Visible = true;
            }
            Lbl_Id_Carro.Text = id_carro.ToString();
            Input_Tamanho.Text = tamanho;
            Input_Categoria.Text = categoria;
            Input_Cilindradas.Text = cilindradas;
            Input_Gps.Text = gps;
            Input_Tela_De_Lcd.Text = tela_de_lcd;
            Input_Fabricante.Text = fabricante;
            Input_Modelo.Text = modelo;
            Input_Ano.Text = ano;
            Input_Painel_Digital.Text = painel_digital;
            Input_Cambio_automatico.Text = cambio_automatico;
            Input_Tipo_de_Combustivel.Text = tipo_de_combustivel;
            Input_Data_de_Compra.Text = data_de_compra;
            Input_Valor_de_Compra.Text = valor_de_compra;
            Input_Placa.Text = placa;
            if(foto == "")
            {
                IMG_Imagem_Carro.Image = null;
            }
            else
            {
                
            }
        }
        public void Clear()
        {
            Input_Modelo.Text =
            Input_Tamanho.Text = 
            Input_Categoria.Text =
            Input_Cilindradas.Text =
            Input_Gps.Text =
            Input_Tela_De_Lcd.Text =
            Input_Fabricante.Text =
            Input_Ano.Text =
            Input_Painel_Digital.Text =
            Input_Cambio_automatico.Text =
            Input_Tipo_de_Combustivel.Text =
            Input_Data_de_Compra.Text =
            Input_Valor_de_Compra.Text =
            Input_Placa.Text =
            Txt_imagem.Text = String.Empty;
        }
        public void salvarRegistro(bool fechar, bool limpar)
        {
            try
            {
                string caminhoArquivo = AppDomain.CurrentDomain.BaseDirectory + System.Configuration.ConfigurationManager.AppSettings["caminhoFotoCarro"];
                
                this.comandos = new Carros();

                this.comandos.modelo = Input_Modelo.Text;
                this.comandos.tamanho = Input_Tamanho.Text;
                this.comandos.categoria = Input_Categoria.Text;
                this.comandos.cilindradas = Input_Cilindradas.Text;
                this.comandos.gps = Input_Gps.Text;
                this.comandos.tela_de_lcd = Input_Tela_De_Lcd.Text;
                this.comandos.fabricante = Input_Fabricante.Text;
                this.comandos.ano = Input_Ano.Text;
                this.comandos.painel_digital = Input_Painel_Digital.Text;
                this.comandos.cambio_automatico = Input_Cambio_automatico.Text;
                this.comandos.tipo_de_combustivel = Input_Tipo_de_Combustivel.Text;
                this.comandos.data_de_compra = Input_Data_de_Compra.Text;
                this.comandos.valor_de_compra = Input_Valor_de_Compra.Text;
                this.comandos.placa = Input_Placa.Text;
                string ola="",oi=Txt_imagem.Text;
                for (int i = 0;i>= oi.Length-1;i++)
                {
                    if (oi[i]=='\\')
                    {
                        ola += "\\\\";
                    }
                    else
                    {
                        ola += oi[i];
                    }
                }
                this.comandos.caminho_imagem = ola;
                this.comandos.CadastrarCarro();
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
                    this.Lbl_Id_Carro.ForeColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Erro de Conexão ao banco ", "Não foi possivel salvar o registro :", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void Btn_ConfirmCadastro_Click(object sender, EventArgs e)
        {
            if (Input_Modelo.Text.Equals(""))
            {
                MessageBox.Show("Modelo obrigatório.");
                return;
            }
            Frm_Carros_List f = new Frm_Carros_List();
            f.listarCarros();
            salvarRegistro(true, false);
        }
        private void Bt_SalvarNovo_Click_1(object sender, EventArgs e)
        {
            if (Input_Modelo.Text.Equals(""))
            {
                MessageBox.Show("Modelo obrigatório.");
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
                this.comandos = new Carros();
                this.comandos.modelo = Input_Modelo.Text;
                this.comandos.tamanho = Input_Tamanho.Text;
                this.comandos.categoria = Input_Categoria.Text;
                this.comandos.cilindradas = Input_Cilindradas.Text;
                this.comandos.gps = Input_Gps.Text;
                this.comandos.tela_de_lcd = Input_Tela_De_Lcd.Text;
                this.comandos.fabricante = Input_Fabricante.Text;
                this.comandos.ano = Input_Ano.Text;
                this.comandos.painel_digital = Input_Painel_Digital.Text;
                this.comandos.cambio_automatico = Input_Cambio_automatico.Text;
                this.comandos.tipo_de_combustivel = Input_Tipo_de_Combustivel.Text;
                this.comandos.data_de_compra = Input_Data_de_Compra.Text;
                this.comandos.valor_de_compra = Input_Valor_de_Compra.Text;
                this.comandos.placa = Input_Placa.Text;
                this.comandos.caminho_imagem = Txt_imagem.Text;
                this.comandos.AlterarCarro(Int32.Parse(Lbl_Id_Carro.Text));
                MessageBox.Show("Registro Atualizado com sucesso.");
                this.Close();

            }
            catch (Exception c)
            {
                MessageBox.Show("Erro na Atualização " + c.ToString());
            }
        }

        private void Btn_Inserir_imagem_Click(object sender, EventArgs e)
        {
            CarregarFoto();
        }
        private void CarregarFoto()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|AllFiles(*.*)|*.*";
            dialog.Multiselect = false;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (dialog != null)
                    {
                        string caminhoFoto = dialog.FileName.ToString();
                        Txt_imagem.Text = caminhoFoto;
                        IMG_Imagem_Carro.ImageLocation = caminhoFoto;
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma foto selecionada.");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
            }
            
        }
    }
}
