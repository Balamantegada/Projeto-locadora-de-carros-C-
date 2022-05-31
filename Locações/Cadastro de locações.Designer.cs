namespace SistemaCliente
{
    partial class Frm_Cadastro_Locacoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cadastro_Locacoes));
            this.Btn_ConfirmCadastro = new System.Windows.Forms.Button();
            this.Bt_SalvarNovo = new System.Windows.Forms.Button();
            this.Btn_Atualizar = new System.Windows.Forms.Button();
            this.Bt_cancelar = new System.Windows.Forms.Button();
            this.Lbl_IdCliente = new System.Windows.Forms.Label();
            this.Input_Finalizado = new System.Windows.Forms.TextBox();
            this.Input_CPF_locatorio = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_CPF_Atual = new System.Windows.Forms.Label();
            this.Input_ID_Carro = new System.Windows.Forms.MaskedTextBox();
            this.Input_Km_Inicial = new System.Windows.Forms.MaskedTextBox();
            this.Input_Km_Entrega = new System.Windows.Forms.MaskedTextBox();
            this.Input_Data_Locacao = new System.Windows.Forms.MaskedTextBox();
            this.Input_Data_Devolucao = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Btn_ConfirmCadastro
            // 
            this.Btn_ConfirmCadastro.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_ConfirmCadastro.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ConfirmCadastro.Location = new System.Drawing.Point(224, 466);
            this.Btn_ConfirmCadastro.Name = "Btn_ConfirmCadastro";
            this.Btn_ConfirmCadastro.Size = new System.Drawing.Size(105, 33);
            this.Btn_ConfirmCadastro.TabIndex = 12;
            this.Btn_ConfirmCadastro.Text = "Confirmar";
            this.Btn_ConfirmCadastro.UseVisualStyleBackColor = false;
            this.Btn_ConfirmCadastro.Click += new System.EventHandler(this.Btn_ConfirmCadastro_Click);
            // 
            // Bt_SalvarNovo
            // 
            this.Bt_SalvarNovo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Bt_SalvarNovo.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_SalvarNovo.Location = new System.Drawing.Point(95, 466);
            this.Bt_SalvarNovo.Name = "Bt_SalvarNovo";
            this.Bt_SalvarNovo.Size = new System.Drawing.Size(105, 33);
            this.Bt_SalvarNovo.TabIndex = 10;
            this.Bt_SalvarNovo.Text = "Salvar/novo";
            this.Bt_SalvarNovo.UseVisualStyleBackColor = false;
            this.Bt_SalvarNovo.Click += new System.EventHandler(this.Bt_SalvarNovo_Click_1);
            // 
            // Btn_Atualizar
            // 
            this.Btn_Atualizar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_Atualizar.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Atualizar.Location = new System.Drawing.Point(162, 466);
            this.Btn_Atualizar.Name = "Btn_Atualizar";
            this.Btn_Atualizar.Size = new System.Drawing.Size(105, 33);
            this.Btn_Atualizar.TabIndex = 11;
            this.Btn_Atualizar.Text = "Atualizar";
            this.Btn_Atualizar.UseVisualStyleBackColor = false;
            this.Btn_Atualizar.Click += new System.EventHandler(this.Btn_Atualizar_Click_1);
            // 
            // Bt_cancelar
            // 
            this.Bt_cancelar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Bt_cancelar.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_cancelar.Location = new System.Drawing.Point(817, 466);
            this.Bt_cancelar.Name = "Bt_cancelar";
            this.Bt_cancelar.Size = new System.Drawing.Size(105, 33);
            this.Bt_cancelar.TabIndex = 13;
            this.Bt_cancelar.Text = "Fechar";
            this.Bt_cancelar.UseVisualStyleBackColor = false;
            this.Bt_cancelar.Click += new System.EventHandler(this.Bt_cancelar_Click);
            // 
            // Lbl_IdCliente
            // 
            this.Lbl_IdCliente.AutoSize = true;
            this.Lbl_IdCliente.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_IdCliente.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_IdCliente.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_IdCliente.Location = new System.Drawing.Point(561, 137);
            this.Lbl_IdCliente.Name = "Lbl_IdCliente";
            this.Lbl_IdCliente.Size = new System.Drawing.Size(0, 34);
            this.Lbl_IdCliente.TabIndex = 28;
            // 
            // Input_Finalizado
            // 
            this.Input_Finalizado.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Finalizado.Location = new System.Drawing.Point(527, 408);
            this.Input_Finalizado.Name = "Input_Finalizado";
            this.Input_Finalizado.Size = new System.Drawing.Size(221, 22);
            this.Input_Finalizado.TabIndex = 9;
            this.Input_Finalizado.Text = "1 caso locado, apague caso esteja finalizado.";
            // 
            // Input_CPF_locatorio
            // 
            this.Input_CPF_locatorio.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_CPF_locatorio.Location = new System.Drawing.Point(527, 276);
            this.Input_CPF_locatorio.Mask = "00000000000";
            this.Input_CPF_locatorio.Name = "Input_CPF_locatorio";
            this.Input_CPF_locatorio.Size = new System.Drawing.Size(124, 22);
            this.Input_CPF_locatorio.TabIndex = 1;
            // 
            // Lbl_CPF_Atual
            // 
            this.Lbl_CPF_Atual.AutoSize = true;
            this.Lbl_CPF_Atual.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_CPF_Atual.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_CPF_Atual.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_CPF_Atual.Location = new System.Drawing.Point(511, 103);
            this.Lbl_CPF_Atual.Name = "Lbl_CPF_Atual";
            this.Lbl_CPF_Atual.Size = new System.Drawing.Size(0, 34);
            this.Lbl_CPF_Atual.TabIndex = 43;
            // 
            // Input_ID_Carro
            // 
            this.Input_ID_Carro.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_ID_Carro.Location = new System.Drawing.Point(527, 208);
            this.Input_ID_Carro.Mask = "0000";
            this.Input_ID_Carro.Name = "Input_ID_Carro";
            this.Input_ID_Carro.Size = new System.Drawing.Size(124, 22);
            this.Input_ID_Carro.TabIndex = 44;
            // 
            // Input_Km_Inicial
            // 
            this.Input_Km_Inicial.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Km_Inicial.Location = new System.Drawing.Point(772, 208);
            this.Input_Km_Inicial.Mask = "0000";
            this.Input_Km_Inicial.Name = "Input_Km_Inicial";
            this.Input_Km_Inicial.Size = new System.Drawing.Size(129, 22);
            this.Input_Km_Inicial.TabIndex = 45;
            // 
            // Input_Km_Entrega
            // 
            this.Input_Km_Entrega.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Km_Entrega.Location = new System.Drawing.Point(772, 276);
            this.Input_Km_Entrega.Mask = "0000";
            this.Input_Km_Entrega.Name = "Input_Km_Entrega";
            this.Input_Km_Entrega.Size = new System.Drawing.Size(129, 22);
            this.Input_Km_Entrega.TabIndex = 46;
            // 
            // Input_Data_Locacao
            // 
            this.Input_Data_Locacao.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Data_Locacao.Location = new System.Drawing.Point(527, 346);
            this.Input_Data_Locacao.Mask = "00/00/0000";
            this.Input_Data_Locacao.Name = "Input_Data_Locacao";
            this.Input_Data_Locacao.Size = new System.Drawing.Size(124, 22);
            this.Input_Data_Locacao.TabIndex = 47;
            this.Input_Data_Locacao.ValidatingType = typeof(System.DateTime);
            // 
            // Input_Data_Devolucao
            // 
            this.Input_Data_Devolucao.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Data_Devolucao.Location = new System.Drawing.Point(772, 346);
            this.Input_Data_Devolucao.Mask = "00/00/0000";
            this.Input_Data_Devolucao.Name = "Input_Data_Devolucao";
            this.Input_Data_Devolucao.Size = new System.Drawing.Size(129, 22);
            this.Input_Data_Devolucao.TabIndex = 48;
            this.Input_Data_Devolucao.ValidatingType = typeof(System.DateTime);
            // 
            // Frm_Cadastro_Locacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.Input_Data_Devolucao);
            this.Controls.Add(this.Input_Data_Locacao);
            this.Controls.Add(this.Input_Km_Entrega);
            this.Controls.Add(this.Input_Km_Inicial);
            this.Controls.Add(this.Input_ID_Carro);
            this.Controls.Add(this.Lbl_CPF_Atual);
            this.Controls.Add(this.Input_CPF_locatorio);
            this.Controls.Add(this.Input_Finalizado);
            this.Controls.Add(this.Lbl_IdCliente);
            this.Controls.Add(this.Bt_cancelar);
            this.Controls.Add(this.Btn_Atualizar);
            this.Controls.Add(this.Bt_SalvarNovo);
            this.Controls.Add(this.Btn_ConfirmCadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Cadastro_Locacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de locação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_ConfirmCadastro;
        private System.Windows.Forms.Button Bt_SalvarNovo;
        private System.Windows.Forms.Button Btn_Atualizar;
        private System.Windows.Forms.Button Bt_cancelar;
        private System.Windows.Forms.Label Lbl_IdCliente;
        private System.Windows.Forms.TextBox Input_Finalizado;
        private System.Windows.Forms.MaskedTextBox Input_CPF_locatorio;
        private System.Windows.Forms.Label Lbl_CPF_Atual;
        private System.Windows.Forms.MaskedTextBox Input_ID_Carro;
        private System.Windows.Forms.MaskedTextBox Input_Km_Inicial;
        private System.Windows.Forms.MaskedTextBox Input_Km_Entrega;
        private System.Windows.Forms.MaskedTextBox Input_Data_Locacao;
        private System.Windows.Forms.MaskedTextBox Input_Data_Devolucao;
    }
}