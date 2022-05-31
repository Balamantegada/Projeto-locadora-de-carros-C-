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
            this.Input_Nome = new System.Windows.Forms.TextBox();
            this.Input_Sobrenome = new System.Windows.Forms.TextBox();
            this.Btn_ConfirmCadastro = new System.Windows.Forms.Button();
            this.Bt_SalvarNovo = new System.Windows.Forms.Button();
            this.Btn_Atualizar = new System.Windows.Forms.Button();
            this.Bt_cancelar = new System.Windows.Forms.Button();
            this.Lbl_IdCliente = new System.Windows.Forms.Label();
            this.Input_Endereço_Completo = new System.Windows.Forms.TextBox();
            this.Input_Telefone = new System.Windows.Forms.TextBox();
            this.Input_Email = new System.Windows.Forms.TextBox();
            this.Input_CNH = new System.Windows.Forms.TextBox();
            this.Input_CEP_Residencia = new System.Windows.Forms.TextBox();
            this.Input_Ativo = new System.Windows.Forms.TextBox();
            this.Input_CPF = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_CPF_Atual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Input_Nome
            // 
            this.Input_Nome.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Nome.Location = new System.Drawing.Point(625, 50);
            this.Input_Nome.Name = "Input_Nome";
            this.Input_Nome.Size = new System.Drawing.Size(337, 27);
            this.Input_Nome.TabIndex = 2;
            // 
            // Input_Sobrenome
            // 
            this.Input_Sobrenome.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Sobrenome.Location = new System.Drawing.Point(625, 127);
            this.Input_Sobrenome.Name = "Input_Sobrenome";
            this.Input_Sobrenome.Size = new System.Drawing.Size(337, 27);
            this.Input_Sobrenome.TabIndex = 3;
            // 
            // Btn_ConfirmCadastro
            // 
            this.Btn_ConfirmCadastro.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_ConfirmCadastro.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ConfirmCadastro.Location = new System.Drawing.Point(220, 475);
            this.Btn_ConfirmCadastro.Name = "Btn_ConfirmCadastro";
            this.Btn_ConfirmCadastro.Size = new System.Drawing.Size(132, 46);
            this.Btn_ConfirmCadastro.TabIndex = 12;
            this.Btn_ConfirmCadastro.Text = "Confirmar";
            this.Btn_ConfirmCadastro.UseVisualStyleBackColor = false;
            this.Btn_ConfirmCadastro.Click += new System.EventHandler(this.Btn_ConfirmCadastro_Click);
            // 
            // Bt_SalvarNovo
            // 
            this.Bt_SalvarNovo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Bt_SalvarNovo.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_SalvarNovo.Location = new System.Drawing.Point(91, 475);
            this.Bt_SalvarNovo.Name = "Bt_SalvarNovo";
            this.Bt_SalvarNovo.Size = new System.Drawing.Size(132, 46);
            this.Bt_SalvarNovo.TabIndex = 10;
            this.Bt_SalvarNovo.Text = "Salvar/novo";
            this.Bt_SalvarNovo.UseVisualStyleBackColor = false;
            this.Bt_SalvarNovo.Click += new System.EventHandler(this.Bt_SalvarNovo_Click_1);
            // 
            // Btn_Atualizar
            // 
            this.Btn_Atualizar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Btn_Atualizar.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Atualizar.Location = new System.Drawing.Point(158, 475);
            this.Btn_Atualizar.Name = "Btn_Atualizar";
            this.Btn_Atualizar.Size = new System.Drawing.Size(132, 46);
            this.Btn_Atualizar.TabIndex = 11;
            this.Btn_Atualizar.Text = "Atualizar";
            this.Btn_Atualizar.UseVisualStyleBackColor = false;
            this.Btn_Atualizar.Click += new System.EventHandler(this.Btn_Atualizar_Click_1);
            // 
            // Bt_cancelar
            // 
            this.Bt_cancelar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Bt_cancelar.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_cancelar.Location = new System.Drawing.Point(957, 561);
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
            // Input_Endereço_Completo
            // 
            this.Input_Endereço_Completo.Font = new System.Drawing.Font("Javanese Text", 10.25F);
            this.Input_Endereço_Completo.Location = new System.Drawing.Point(625, 203);
            this.Input_Endereço_Completo.Name = "Input_Endereço_Completo";
            this.Input_Endereço_Completo.Size = new System.Drawing.Size(337, 39);
            this.Input_Endereço_Completo.TabIndex = 4;
            // 
            // Input_Telefone
            // 
            this.Input_Telefone.Font = new System.Drawing.Font("Javanese Text", 10.25F);
            this.Input_Telefone.Location = new System.Drawing.Point(625, 279);
            this.Input_Telefone.Name = "Input_Telefone";
            this.Input_Telefone.Size = new System.Drawing.Size(337, 39);
            this.Input_Telefone.TabIndex = 5;
            // 
            // Input_Email
            // 
            this.Input_Email.Font = new System.Drawing.Font("Javanese Text", 10.25F);
            this.Input_Email.Location = new System.Drawing.Point(625, 357);
            this.Input_Email.Name = "Input_Email";
            this.Input_Email.Size = new System.Drawing.Size(337, 39);
            this.Input_Email.TabIndex = 6;
            // 
            // Input_CNH
            // 
            this.Input_CNH.Font = new System.Drawing.Font("Javanese Text", 10.25F);
            this.Input_CNH.Location = new System.Drawing.Point(588, 432);
            this.Input_CNH.Name = "Input_CNH";
            this.Input_CNH.Size = new System.Drawing.Size(150, 39);
            this.Input_CNH.TabIndex = 7;
            // 
            // Input_CEP_Residencia
            // 
            this.Input_CEP_Residencia.Font = new System.Drawing.Font("Javanese Text", 10.25F);
            this.Input_CEP_Residencia.Location = new System.Drawing.Point(863, 510);
            this.Input_CEP_Residencia.Name = "Input_CEP_Residencia";
            this.Input_CEP_Residencia.Size = new System.Drawing.Size(150, 39);
            this.Input_CEP_Residencia.TabIndex = 8;
            // 
            // Input_Ativo
            // 
            this.Input_Ativo.Font = new System.Drawing.Font("Javanese Text", 10.25F);
            this.Input_Ativo.Location = new System.Drawing.Point(863, 432);
            this.Input_Ativo.Name = "Input_Ativo";
            this.Input_Ativo.Size = new System.Drawing.Size(150, 39);
            this.Input_Ativo.TabIndex = 9;
            this.Input_Ativo.Text = "1 ou 0";
            // 
            // Input_CPF
            // 
            this.Input_CPF.Location = new System.Drawing.Point(588, 517);
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
            this.Lbl_CPF_Atual.Location = new System.Drawing.Point(105, 208);
            this.Lbl_CPF_Atual.Name = "Lbl_CPF_Atual";
            this.Lbl_CPF_Atual.Size = new System.Drawing.Size(0, 34);
            this.Lbl_CPF_Atual.TabIndex = 29;
            // 
            // Frm_Cadastro_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1074, 606);
            this.Controls.Add(this.Lbl_CPF_Atual);
            this.Controls.Add(this.Input_CPF);
            this.Controls.Add(this.Input_Ativo);
            this.Controls.Add(this.Input_CEP_Residencia);
            this.Controls.Add(this.Input_CNH);
            this.Controls.Add(this.Input_Email);
            this.Controls.Add(this.Input_Telefone);
            this.Controls.Add(this.Input_Endereço_Completo);
            this.Controls.Add(this.Lbl_IdCliente);
            this.Controls.Add(this.Bt_cancelar);
            this.Controls.Add(this.Btn_Atualizar);
            this.Controls.Add(this.Bt_SalvarNovo);
            this.Controls.Add(this.Btn_ConfirmCadastro);
            this.Controls.Add(this.Input_Sobrenome);
            this.Controls.Add(this.Input_Nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Cadastro_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Input_Nome;
        private System.Windows.Forms.TextBox Input_Sobrenome;
        private System.Windows.Forms.Button Btn_ConfirmCadastro;
        private System.Windows.Forms.Button Bt_SalvarNovo;
        private System.Windows.Forms.Button Btn_Atualizar;
        private System.Windows.Forms.Button Bt_cancelar;
        private System.Windows.Forms.Label Lbl_IdCliente;
        private System.Windows.Forms.TextBox Input_Endereço_Completo;
        private System.Windows.Forms.TextBox Input_Telefone;
        private System.Windows.Forms.TextBox Input_Email;
        private System.Windows.Forms.TextBox Input_CNH;
        private System.Windows.Forms.TextBox Input_CEP_Residencia;
        private System.Windows.Forms.TextBox Input_Ativo;
        private System.Windows.Forms.MaskedTextBox Input_CPF;
        private System.Windows.Forms.Label Lbl_CPF_Atual;
    }
}