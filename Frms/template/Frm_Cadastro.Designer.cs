/*namespace SistemaCliente
{
    partial class Frm_Cadastro
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
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.Input_Senha = new System.Windows.Forms.TextBox();
            this.Lbl_ConfirmSenha = new System.Windows.Forms.Label();
            this.Input_ConfirmSenha = new System.Windows.Forms.TextBox();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Input_Email = new System.Windows.Forms.TextBox();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Input_Nome = new System.Windows.Forms.TextBox();
            this.Lbl_Telefone = new System.Windows.Forms.Label();
            this.Btn_ConfirmCadastro = new System.Windows.Forms.Button();
            this.Input_NumeroCelular = new System.Windows.Forms.MaskedTextBox();
            this.Bt_SalvarNovo = new System.Windows.Forms.Button();
            this.Btn_Atualizar = new System.Windows.Forms.Button();
            this.Bt_cancelar = new System.Windows.Forms.Button();
            this.Lbl_IdCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.AutoSize = true;
            this.Lbl_Senha.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Senha.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Senha.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_Senha.Location = new System.Drawing.Point(289, 264);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(101, 34);
            this.Lbl_Senha.TabIndex = 14;
            this.Lbl_Senha.Text = "Senha:";
            // 
            // Input_Senha
            // 
            this.Input_Senha.Font = new System.Drawing.Font("Javanese Text", 10.25F);
            this.Input_Senha.Location = new System.Drawing.Point(400, 267);
            this.Input_Senha.Name = "Input_Senha";
            this.Input_Senha.Size = new System.Drawing.Size(150, 39);
            this.Input_Senha.TabIndex = 4;
            // 
            // Lbl_ConfirmSenha
            // 
            this.Lbl_ConfirmSenha.AutoSize = true;
            this.Lbl_ConfirmSenha.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_ConfirmSenha.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_ConfirmSenha.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_ConfirmSenha.Location = new System.Drawing.Point(161, 323);
            this.Lbl_ConfirmSenha.Name = "Lbl_ConfirmSenha";
            this.Lbl_ConfirmSenha.Size = new System.Drawing.Size(229, 34);
            this.Lbl_ConfirmSenha.TabIndex = 16;
            this.Lbl_ConfirmSenha.Text = "Confirmar senha:";
            // 
            // Input_ConfirmSenha
            // 
            this.Input_ConfirmSenha.Font = new System.Drawing.Font("Javanese Text", 10.25F);
            this.Input_ConfirmSenha.Location = new System.Drawing.Point(396, 326);
            this.Input_ConfirmSenha.Name = "Input_ConfirmSenha";
            this.Input_ConfirmSenha.PasswordChar = '*';
            this.Input_ConfirmSenha.Size = new System.Drawing.Size(150, 39);
            this.Input_ConfirmSenha.TabIndex = 5;
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Email.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Email.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_Email.Location = new System.Drawing.Point(299, 163);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(91, 34);
            this.Lbl_Email.TabIndex = 18;
            this.Lbl_Email.Text = "Email:";
            // 
            // Input_Email
            // 
            this.Input_Email.Font = new System.Drawing.Font("Javanese Text", 10.25F);
            this.Input_Email.Location = new System.Drawing.Point(400, 163);
            this.Input_Email.Name = "Input_Email";
            this.Input_Email.Size = new System.Drawing.Size(150, 39);
            this.Input_Email.TabIndex = 2;
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Nome.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Nome.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_Nome.Location = new System.Drawing.Point(299, 114);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(95, 34);
            this.Lbl_Nome.TabIndex = 20;
            this.Lbl_Nome.Text = "Nome:";
            // 
            // Input_Nome
            // 
            this.Input_Nome.Font = new System.Drawing.Font("Javanese Text", 10.25F);
            this.Input_Nome.Location = new System.Drawing.Point(400, 117);
            this.Input_Nome.Name = "Input_Nome";
            this.Input_Nome.Size = new System.Drawing.Size(150, 39);
            this.Input_Nome.TabIndex = 1;
            // 
            // Lbl_Telefone
            // 
            this.Lbl_Telefone.AutoSize = true;
            this.Lbl_Telefone.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Telefone.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Telefone.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_Telefone.Location = new System.Drawing.Point(142, 215);
            this.Lbl_Telefone.Name = "Lbl_Telefone";
            this.Lbl_Telefone.Size = new System.Drawing.Size(252, 34);
            this.Lbl_Telefone.TabIndex = 22;
            this.Lbl_Telefone.Text = "Numero de celular:";
            // 
            // Btn_ConfirmCadastro
            // 
            this.Btn_ConfirmCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.Btn_ConfirmCadastro.Font = new System.Drawing.Font("Franklin Gothic Book", 13.75F, System.Drawing.FontStyle.Bold);
            this.Btn_ConfirmCadastro.Location = new System.Drawing.Point(457, 407);
            this.Btn_ConfirmCadastro.Name = "Btn_ConfirmCadastro";
            this.Btn_ConfirmCadastro.Size = new System.Drawing.Size(105, 33);
            this.Btn_ConfirmCadastro.TabIndex = 8;
            this.Btn_ConfirmCadastro.Text = "Confirmar";
            this.Btn_ConfirmCadastro.UseVisualStyleBackColor = false;
            this.Btn_ConfirmCadastro.Click += new System.EventHandler(this.Btn_ConfirmCadastro_Click);
            // 
            // Input_NumeroCelular
            // 
            this.Input_NumeroCelular.Font = new System.Drawing.Font("Javanese Text", 10.25F);
            this.Input_NumeroCelular.Location = new System.Drawing.Point(400, 218);
            this.Input_NumeroCelular.Mask = "(99) 0000-0000";
            this.Input_NumeroCelular.Name = "Input_NumeroCelular";
            this.Input_NumeroCelular.Size = new System.Drawing.Size(150, 39);
            this.Input_NumeroCelular.TabIndex = 3;
            // 
            // Bt_SalvarNovo
            // 
            this.Bt_SalvarNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.Bt_SalvarNovo.Font = new System.Drawing.Font("Franklin Gothic Book", 13.75F, System.Drawing.FontStyle.Bold);
            this.Bt_SalvarNovo.Location = new System.Drawing.Point(328, 407);
            this.Bt_SalvarNovo.Name = "Bt_SalvarNovo";
            this.Bt_SalvarNovo.Size = new System.Drawing.Size(105, 33);
            this.Bt_SalvarNovo.TabIndex = 6;
            this.Bt_SalvarNovo.Text = "Salvar/novo";
            this.Bt_SalvarNovo.UseVisualStyleBackColor = false;
            this.Bt_SalvarNovo.Click += new System.EventHandler(this.Bt_SalvarNovo_Click_1);
            // 
            // Btn_Atualizar
            // 
            this.Btn_Atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.Btn_Atualizar.Font = new System.Drawing.Font("Franklin Gothic Book", 13.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Atualizar.Location = new System.Drawing.Point(395, 407);
            this.Btn_Atualizar.Name = "Btn_Atualizar";
            this.Btn_Atualizar.Size = new System.Drawing.Size(105, 33);
            this.Btn_Atualizar.TabIndex = 7;
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
            this.Bt_cancelar.TabIndex = 9;
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
            this.Lbl_IdCliente.Location = new System.Drawing.Point(394, 61);
            this.Lbl_IdCliente.Name = "Lbl_IdCliente";
            this.Lbl_IdCliente.Size = new System.Drawing.Size(0, 34);
            this.Lbl_IdCliente.TabIndex = 28;
            // 
            // Frm_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.Lbl_IdCliente);
            this.Controls.Add(this.Bt_cancelar);
            this.Controls.Add(this.Btn_Atualizar);
            this.Controls.Add(this.Bt_SalvarNovo);
            this.Controls.Add(this.Input_NumeroCelular);
            this.Controls.Add(this.Btn_ConfirmCadastro);
            this.Controls.Add(this.Lbl_Telefone);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.Input_Nome);
            this.Controls.Add(this.Lbl_Email);
            this.Controls.Add(this.Input_Email);
            this.Controls.Add(this.Lbl_ConfirmSenha);
            this.Controls.Add(this.Input_ConfirmSenha);
            this.Controls.Add(this.Lbl_Senha);
            this.Controls.Add(this.Input_Senha);
            this.Name = "Frm_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Senha;
        private System.Windows.Forms.TextBox Input_Senha;
        private System.Windows.Forms.Label Lbl_ConfirmSenha;
        private System.Windows.Forms.TextBox Input_ConfirmSenha;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.TextBox Input_Email;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.TextBox Input_Nome;
        private System.Windows.Forms.Label Lbl_Telefone;
        private System.Windows.Forms.Button Btn_ConfirmCadastro;
        private System.Windows.Forms.MaskedTextBox Input_NumeroCelular;
        private System.Windows.Forms.Button Bt_SalvarNovo;
        private System.Windows.Forms.Button Btn_Atualizar;
        private System.Windows.Forms.Button Bt_cancelar;
        private System.Windows.Forms.Label Lbl_IdCliente;
    }
}*/