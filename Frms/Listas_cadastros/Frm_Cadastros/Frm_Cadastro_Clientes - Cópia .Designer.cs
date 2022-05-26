namespace SistemaCliente
{
    partial class Frm_Cadastro_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cadastro_Clientes));
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Input_Nome = new System.Windows.Forms.TextBox();
            this.Lbl_Sobrenome = new System.Windows.Forms.Label();
            this.Input_Sobrenome = new System.Windows.Forms.TextBox();
            this.Lbl_CPF = new System.Windows.Forms.Label();
            this.Btn_ConfirmCadastro = new System.Windows.Forms.Button();
            this.Bt_SalvarNovo = new System.Windows.Forms.Button();
            this.Btn_Atualizar = new System.Windows.Forms.Button();
            this.Bt_cancelar = new System.Windows.Forms.Button();
            this.Lbl_IdCliente = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_Endereço_Completo = new System.Windows.Forms.Label();
            this.Input_Endereço_Completo = new System.Windows.Forms.TextBox();
            this.Lbl_Telefone = new System.Windows.Forms.Label();
            this.Input_Telefone = new System.Windows.Forms.TextBox();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Input_Email = new System.Windows.Forms.TextBox();
            this.Lbl_CNH = new System.Windows.Forms.Label();
            this.Input_CNH = new System.Windows.Forms.TextBox();
            this.Lbl_CEP_Residencia = new System.Windows.Forms.Label();
            this.Input_CEP_Residencia = new System.Windows.Forms.TextBox();
            this.Lbl_Ativo = new System.Windows.Forms.Label();
            this.Input_Ativo = new System.Windows.Forms.TextBox();
            this.Input_CPF = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_CPF_Atual = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Nome.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Nome.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_Nome.Location = new System.Drawing.Point(78, 197);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(95, 34);
            this.Lbl_Nome.TabIndex = 14;
            this.Lbl_Nome.Text = "Nome:";
            // 
            // Input_Nome
            // 
            this.Input_Nome.Font = new System.Drawing.Font("Javanese Text", 10.25F);
            this.Input_Nome.Location = new System.Drawing.Point(179, 192);
            this.Input_Nome.Name = "Input_Nome";
            this.Input_Nome.Size = new System.Drawing.Size(150, 39);
            this.Input_Nome.TabIndex = 2;
            // 
            // Lbl_Sobrenome
            // 
            this.Lbl_Sobrenome.AutoSize = true;
            this.Lbl_Sobrenome.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Sobrenome.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Sobrenome.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_Sobrenome.Location = new System.Drawing.Point(9, 253);
            this.Lbl_Sobrenome.Name = "Lbl_Sobrenome";
            this.Lbl_Sobrenome.Size = new System.Drawing.Size(164, 34);
            this.Lbl_Sobrenome.TabIndex = 16;
            this.Lbl_Sobrenome.Text = "Sobrenome:";
            // 
            // Input_Sobrenome
            // 
            this.Input_Sobrenome.Font = new System.Drawing.Font("Javanese Text", 10.25F);
            this.Input_Sobrenome.Location = new System.Drawing.Point(179, 253);
            this.Input_Sobrenome.Name = "Input_Sobrenome";
            this.Input_Sobrenome.Size = new System.Drawing.Size(150, 39);
            this.Input_Sobrenome.TabIndex = 3;
            // 
            // Lbl_CPF
            // 
            this.Lbl_CPF.AutoSize = true;
            this.Lbl_CPF.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_CPF.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_CPF.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_CPF.Location = new System.Drawing.Point(102, 137);
            this.Lbl_CPF.Name = "Lbl_CPF";
            this.Lbl_CPF.Size = new System.Drawing.Size(71, 34);
            this.Lbl_CPF.TabIndex = 20;
            this.Lbl_CPF.Text = "CPF:";
            // 
            // Btn_ConfirmCadastro
            // 
            this.Btn_ConfirmCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.Btn_ConfirmCadastro.Font = new System.Drawing.Font("Franklin Gothic Book", 13.75F, System.Drawing.FontStyle.Bold);
            this.Btn_ConfirmCadastro.Location = new System.Drawing.Point(456, 516);
            this.Btn_ConfirmCadastro.Name = "Btn_ConfirmCadastro";
            this.Btn_ConfirmCadastro.Size = new System.Drawing.Size(105, 33);
            this.Btn_ConfirmCadastro.TabIndex = 12;
            this.Btn_ConfirmCadastro.Text = "Confirmar";
            this.Btn_ConfirmCadastro.UseVisualStyleBackColor = false;
            this.Btn_ConfirmCadastro.Click += new System.EventHandler(this.Btn_ConfirmCadastro_Click);
            // 
            // Bt_SalvarNovo
            // 
            this.Bt_SalvarNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.Bt_SalvarNovo.Font = new System.Drawing.Font("Franklin Gothic Book", 13.75F, System.Drawing.FontStyle.Bold);
            this.Bt_SalvarNovo.Location = new System.Drawing.Point(327, 516);
            this.Bt_SalvarNovo.Name = "Bt_SalvarNovo";
            this.Bt_SalvarNovo.Size = new System.Drawing.Size(105, 33);
            this.Bt_SalvarNovo.TabIndex = 10;
            this.Bt_SalvarNovo.Text = "Salvar/novo";
            this.Bt_SalvarNovo.UseVisualStyleBackColor = false;
            this.Bt_SalvarNovo.Click += new System.EventHandler(this.Bt_SalvarNovo_Click_1);
            // 
            // Btn_Atualizar
            // 
            this.Btn_Atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.Btn_Atualizar.Font = new System.Drawing.Font("Franklin Gothic Book", 13.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Atualizar.Location = new System.Drawing.Point(394, 516);
            this.Btn_Atualizar.Name = "Btn_Atualizar";
            this.Btn_Atualizar.Size = new System.Drawing.Size(105, 33);
            this.Btn_Atualizar.TabIndex = 11;
            this.Btn_Atualizar.Text = "Atualizar";
            this.Btn_Atualizar.UseVisualStyleBackColor = false;
            this.Btn_Atualizar.Click += new System.EventHandler(this.Btn_Atualizar_Click_1);
            // 
            // Bt_cancelar
            // 
            this.Bt_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.Bt_cancelar.Font = new System.Drawing.Font("Franklin Gothic Book", 13.75F, System.Drawing.FontStyle.Bold);
            this.Bt_cancelar.Location = new System.Drawing.Point(767, 516);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaCliente.Properties.Resources.clientes_icon1;
            this.pictureBox1.Location = new System.Drawing.Point(400, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // Lbl_Endereço_Completo
            // 
            this.Lbl_Endereço_Completo.AutoSize = true;
            this.Lbl_Endereço_Completo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Endereço_Completo.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Endereço_Completo.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_Endereço_Completo.Location = new System.Drawing.Point(33, 305);
            this.Lbl_Endereço_Completo.Name = "Lbl_Endereço_Completo";
            this.Lbl_Endereço_Completo.Size = new System.Drawing.Size(140, 34);
            this.Lbl_Endereço_Completo.TabIndex = 31;
            this.Lbl_Endereço_Completo.Text = "Endereço:";
            // 
            // Input_Endereço_Completo
            // 
            this.Input_Endereço_Completo.Font = new System.Drawing.Font("Javanese Text", 10.25F);
            this.Input_Endereço_Completo.Location = new System.Drawing.Point(179, 305);
            this.Input_Endereço_Completo.Name = "Input_Endereço_Completo";
            this.Input_Endereço_Completo.Size = new System.Drawing.Size(272, 39);
            this.Input_Endereço_Completo.TabIndex = 4;
            // 
            // Lbl_Telefone
            // 
            this.Lbl_Telefone.AutoSize = true;
            this.Lbl_Telefone.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Telefone.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Telefone.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_Telefone.Location = new System.Drawing.Point(44, 362);
            this.Lbl_Telefone.Name = "Lbl_Telefone";
            this.Lbl_Telefone.Size = new System.Drawing.Size(129, 34);
            this.Lbl_Telefone.TabIndex = 33;
            this.Lbl_Telefone.Text = "Telefone:";
            // 
            // Input_Telefone
            // 
            this.Input_Telefone.Font = new System.Drawing.Font("Javanese Text", 10.25F);
            this.Input_Telefone.Location = new System.Drawing.Point(179, 362);
            this.Input_Telefone.Name = "Input_Telefone";
            this.Input_Telefone.Size = new System.Drawing.Size(171, 39);
            this.Input_Telefone.TabIndex = 5;
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Email.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Email.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_Email.Location = new System.Drawing.Point(347, 137);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(91, 34);
            this.Lbl_Email.TabIndex = 35;
            this.Lbl_Email.Text = "Email:";
            // 
            // Input_Email
            // 
            this.Input_Email.Font = new System.Drawing.Font("Javanese Text", 10.25F);
            this.Input_Email.Location = new System.Drawing.Point(444, 137);
            this.Input_Email.Name = "Input_Email";
            this.Input_Email.Size = new System.Drawing.Size(256, 39);
            this.Input_Email.TabIndex = 6;
            // 
            // Lbl_CNH
            // 
            this.Lbl_CNH.AutoSize = true;
            this.Lbl_CNH.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_CNH.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_CNH.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_CNH.Location = new System.Drawing.Point(361, 182);
            this.Lbl_CNH.Name = "Lbl_CNH";
            this.Lbl_CNH.Size = new System.Drawing.Size(77, 34);
            this.Lbl_CNH.TabIndex = 37;
            this.Lbl_CNH.Text = "CNH:";
            // 
            // Input_CNH
            // 
            this.Input_CNH.Font = new System.Drawing.Font("Javanese Text", 10.25F);
            this.Input_CNH.Location = new System.Drawing.Point(444, 182);
            this.Input_CNH.Name = "Input_CNH";
            this.Input_CNH.Size = new System.Drawing.Size(150, 39);
            this.Input_CNH.TabIndex = 7;
            // 
            // Lbl_CEP_Residencia
            // 
            this.Lbl_CEP_Residencia.AutoSize = true;
            this.Lbl_CEP_Residencia.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_CEP_Residencia.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_CEP_Residencia.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_CEP_Residencia.Location = new System.Drawing.Point(361, 227);
            this.Lbl_CEP_Residencia.Name = "Lbl_CEP_Residencia";
            this.Lbl_CEP_Residencia.Size = new System.Drawing.Size(72, 34);
            this.Lbl_CEP_Residencia.TabIndex = 39;
            this.Lbl_CEP_Residencia.Text = "CEP:";
            // 
            // Input_CEP_Residencia
            // 
            this.Input_CEP_Residencia.Font = new System.Drawing.Font("Javanese Text", 10.25F);
            this.Input_CEP_Residencia.Location = new System.Drawing.Point(444, 227);
            this.Input_CEP_Residencia.Name = "Input_CEP_Residencia";
            this.Input_CEP_Residencia.Size = new System.Drawing.Size(150, 39);
            this.Input_CEP_Residencia.TabIndex = 8;
            // 
            // Lbl_Ativo
            // 
            this.Lbl_Ativo.AutoSize = true;
            this.Lbl_Ativo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Ativo.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Ativo.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_Ativo.Location = new System.Drawing.Point(399, 366);
            this.Lbl_Ativo.Name = "Lbl_Ativo";
            this.Lbl_Ativo.Size = new System.Drawing.Size(136, 34);
            this.Lbl_Ativo.TabIndex = 41;
            this.Lbl_Ativo.Text = "Atividade:";
            // 
            // Input_Ativo
            // 
            this.Input_Ativo.Font = new System.Drawing.Font("Javanese Text", 10.25F);
            this.Input_Ativo.Location = new System.Drawing.Point(550, 366);
            this.Input_Ativo.Name = "Input_Ativo";
            this.Input_Ativo.Size = new System.Drawing.Size(150, 39);
            this.Input_Ativo.TabIndex = 9;
            this.Input_Ativo.Text = "1 ou 0";
            // 
            // Input_CPF
            // 
            this.Input_CPF.Location = new System.Drawing.Point(179, 144);
            this.Input_CPF.Mask = "00000000000";
            this.Input_CPF.Name = "Input_CPF";
            this.Input_CPF.Size = new System.Drawing.Size(150, 20);
            this.Input_CPF.TabIndex = 1;
            // 
            // Lbl_CPF_Atual
            // 
            this.Lbl_CPF_Atual.AutoSize = true;
            this.Lbl_CPF_Atual.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_CPF_Atual.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_CPF_Atual.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_CPF_Atual.Location = new System.Drawing.Point(323, 65);
            this.Lbl_CPF_Atual.Name = "Lbl_CPF_Atual";
            this.Lbl_CPF_Atual.Size = new System.Drawing.Size(71, 34);
            this.Lbl_CPF_Atual.TabIndex = 43;
            this.Lbl_CPF_Atual.Text = "CPF:";
            // 
            // Frm_Cadastro_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.Lbl_CPF_Atual);
            this.Controls.Add(this.Input_CPF);
            this.Controls.Add(this.Lbl_Ativo);
            this.Controls.Add(this.Input_Ativo);
            this.Controls.Add(this.Lbl_CEP_Residencia);
            this.Controls.Add(this.Input_CEP_Residencia);
            this.Controls.Add(this.Lbl_CNH);
            this.Controls.Add(this.Input_CNH);
            this.Controls.Add(this.Lbl_Email);
            this.Controls.Add(this.Input_Email);
            this.Controls.Add(this.Lbl_Telefone);
            this.Controls.Add(this.Input_Telefone);
            this.Controls.Add(this.Lbl_Endereço_Completo);
            this.Controls.Add(this.Input_Endereço_Completo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lbl_IdCliente);
            this.Controls.Add(this.Bt_cancelar);
            this.Controls.Add(this.Btn_Atualizar);
            this.Controls.Add(this.Bt_SalvarNovo);
            this.Controls.Add(this.Btn_ConfirmCadastro);
            this.Controls.Add(this.Lbl_CPF);
            this.Controls.Add(this.Lbl_Sobrenome);
            this.Controls.Add(this.Input_Sobrenome);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.Input_Nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Cadastro_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.TextBox Input_Nome;
        private System.Windows.Forms.Label Lbl_Sobrenome;
        private System.Windows.Forms.TextBox Input_Sobrenome;
        private System.Windows.Forms.Label Lbl_CPF;
        private System.Windows.Forms.Button Btn_ConfirmCadastro;
        private System.Windows.Forms.Button Bt_SalvarNovo;
        private System.Windows.Forms.Button Btn_Atualizar;
        private System.Windows.Forms.Button Bt_cancelar;
        private System.Windows.Forms.Label Lbl_IdCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl_Endereço_Completo;
        private System.Windows.Forms.TextBox Input_Endereço_Completo;
        private System.Windows.Forms.Label Lbl_Telefone;
        private System.Windows.Forms.TextBox Input_Telefone;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.TextBox Input_Email;
        private System.Windows.Forms.Label Lbl_CNH;
        private System.Windows.Forms.TextBox Input_CNH;
        private System.Windows.Forms.Label Lbl_CEP_Residencia;
        private System.Windows.Forms.TextBox Input_CEP_Residencia;
        private System.Windows.Forms.Label Lbl_Ativo;
        private System.Windows.Forms.TextBox Input_Ativo;
        private System.Windows.Forms.MaskedTextBox Input_CPF;
        private System.Windows.Forms.Label Lbl_CPF_Atual;
    }
}