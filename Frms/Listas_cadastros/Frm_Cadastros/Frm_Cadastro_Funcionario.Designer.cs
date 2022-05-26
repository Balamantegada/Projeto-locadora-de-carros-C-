namespace SistemaCliente
{
    partial class Frm_Cadastro_Funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cadastro_Funcionario));
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.Input_Senha = new System.Windows.Forms.TextBox();
            this.Lbl_ConfirmSenha = new System.Windows.Forms.Label();
            this.Input_ConfirmSenha = new System.Windows.Forms.TextBox();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Input_Usuario = new System.Windows.Forms.TextBox();
            this.Btn_ConfirmCadastro = new System.Windows.Forms.Button();
            this.Bt_SalvarNovo = new System.Windows.Forms.Button();
            this.Btn_Atualizar = new System.Windows.Forms.Button();
            this.Bt_cancelar = new System.Windows.Forms.Button();
            this.Lbl_IdCliente = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.AutoSize = true;
            this.Lbl_Senha.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Senha.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Senha.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_Senha.Location = new System.Drawing.Point(289, 189);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(101, 34);
            this.Lbl_Senha.TabIndex = 14;
            this.Lbl_Senha.Text = "Senha:";
            // 
            // Input_Senha
            // 
            this.Input_Senha.Font = new System.Drawing.Font("Javanese Text", 10.25F);
            this.Input_Senha.Location = new System.Drawing.Point(400, 192);
            this.Input_Senha.Name = "Input_Senha";
            this.Input_Senha.Size = new System.Drawing.Size(150, 39);
            this.Input_Senha.TabIndex = 2;
            // 
            // Lbl_ConfirmSenha
            // 
            this.Lbl_ConfirmSenha.AutoSize = true;
            this.Lbl_ConfirmSenha.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_ConfirmSenha.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_ConfirmSenha.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_ConfirmSenha.Location = new System.Drawing.Point(165, 249);
            this.Lbl_ConfirmSenha.Name = "Lbl_ConfirmSenha";
            this.Lbl_ConfirmSenha.Size = new System.Drawing.Size(229, 34);
            this.Lbl_ConfirmSenha.TabIndex = 16;
            this.Lbl_ConfirmSenha.Text = "Confirmar senha:";
            // 
            // Input_ConfirmSenha
            // 
            this.Input_ConfirmSenha.Font = new System.Drawing.Font("Javanese Text", 10.25F);
            this.Input_ConfirmSenha.Location = new System.Drawing.Point(400, 252);
            this.Input_ConfirmSenha.Name = "Input_ConfirmSenha";
            this.Input_ConfirmSenha.PasswordChar = '*';
            this.Input_ConfirmSenha.Size = new System.Drawing.Size(150, 39);
            this.Input_ConfirmSenha.TabIndex = 3;
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Usuario.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_Usuario.Location = new System.Drawing.Point(277, 133);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(117, 34);
            this.Lbl_Usuario.TabIndex = 20;
            this.Lbl_Usuario.Text = "Usuário:";
            // 
            // Input_Usuario
            // 
            this.Input_Usuario.Font = new System.Drawing.Font("Javanese Text", 10.25F);
            this.Input_Usuario.Location = new System.Drawing.Point(400, 137);
            this.Input_Usuario.Name = "Input_Usuario";
            this.Input_Usuario.Size = new System.Drawing.Size(150, 39);
            this.Input_Usuario.TabIndex = 1;
            // 
            // Btn_ConfirmCadastro
            // 
            this.Btn_ConfirmCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.Btn_ConfirmCadastro.Font = new System.Drawing.Font("Franklin Gothic Book", 13.75F, System.Drawing.FontStyle.Bold);
            this.Btn_ConfirmCadastro.Location = new System.Drawing.Point(456, 345);
            this.Btn_ConfirmCadastro.Name = "Btn_ConfirmCadastro";
            this.Btn_ConfirmCadastro.Size = new System.Drawing.Size(105, 33);
            this.Btn_ConfirmCadastro.TabIndex = 6;
            this.Btn_ConfirmCadastro.Text = "Confirmar";
            this.Btn_ConfirmCadastro.UseVisualStyleBackColor = false;
            this.Btn_ConfirmCadastro.Click += new System.EventHandler(this.Btn_ConfirmCadastro_Click);
            // 
            // Bt_SalvarNovo
            // 
            this.Bt_SalvarNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.Bt_SalvarNovo.Font = new System.Drawing.Font("Franklin Gothic Book", 13.75F, System.Drawing.FontStyle.Bold);
            this.Bt_SalvarNovo.Location = new System.Drawing.Point(327, 345);
            this.Bt_SalvarNovo.Name = "Bt_SalvarNovo";
            this.Bt_SalvarNovo.Size = new System.Drawing.Size(105, 33);
            this.Bt_SalvarNovo.TabIndex = 4;
            this.Bt_SalvarNovo.Text = "Salvar/novo";
            this.Bt_SalvarNovo.UseVisualStyleBackColor = false;
            this.Bt_SalvarNovo.Click += new System.EventHandler(this.Bt_SalvarNovo_Click_1);
            // 
            // Btn_Atualizar
            // 
            this.Btn_Atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.Btn_Atualizar.Font = new System.Drawing.Font("Franklin Gothic Book", 13.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Atualizar.Location = new System.Drawing.Point(394, 345);
            this.Btn_Atualizar.Name = "Btn_Atualizar";
            this.Btn_Atualizar.Size = new System.Drawing.Size(105, 33);
            this.Btn_Atualizar.TabIndex = 5;
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
            this.Bt_cancelar.TabIndex = 7;
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
            this.pictureBox1.Image = global::SistemaCliente.Properties.Resources.funcionario_perncil_icon1;
            this.pictureBox1.Location = new System.Drawing.Point(400, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Cadastro_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lbl_IdCliente);
            this.Controls.Add(this.Bt_cancelar);
            this.Controls.Add(this.Btn_Atualizar);
            this.Controls.Add(this.Bt_SalvarNovo);
            this.Controls.Add(this.Btn_ConfirmCadastro);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.Input_Usuario);
            this.Controls.Add(this.Lbl_ConfirmSenha);
            this.Controls.Add(this.Input_ConfirmSenha);
            this.Controls.Add(this.Lbl_Senha);
            this.Controls.Add(this.Input_Senha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Cadastro_Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Senha;
        private System.Windows.Forms.TextBox Input_Senha;
        private System.Windows.Forms.Label Lbl_ConfirmSenha;
        private System.Windows.Forms.TextBox Input_ConfirmSenha;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.TextBox Input_Usuario;
        private System.Windows.Forms.Button Btn_ConfirmCadastro;
        private System.Windows.Forms.Button Bt_SalvarNovo;
        private System.Windows.Forms.Button Btn_Atualizar;
        private System.Windows.Forms.Button Bt_cancelar;
        private System.Windows.Forms.Label Lbl_IdCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}