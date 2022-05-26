namespace SistemaCliente
{
    partial class Frm_Login_funcio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login_funcio));
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Input_Nome = new System.Windows.Forms.TextBox();
            this.Input_Senha = new System.Windows.Forms.TextBox();
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.Btn_Logar = new System.Windows.Forms.Button();
            this.Lbl_Erro = new System.Windows.Forms.Label();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Nome.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Nome.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_Nome.Location = new System.Drawing.Point(334, 173);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(95, 34);
            this.Lbl_Nome.TabIndex = 0;
            this.Lbl_Nome.Text = "Nome:";
            // 
            // Input_Nome
            // 
            this.Input_Nome.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F);
            this.Input_Nome.Location = new System.Drawing.Point(435, 173);
            this.Input_Nome.Name = "Input_Nome";
            this.Input_Nome.Size = new System.Drawing.Size(145, 37);
            this.Input_Nome.TabIndex = 1;
            this.Input_Nome.Text = "funcionario";
            // 
            // Input_Senha
            // 
            this.Input_Senha.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F);
            this.Input_Senha.Location = new System.Drawing.Point(435, 234);
            this.Input_Senha.Name = "Input_Senha";
            this.Input_Senha.PasswordChar = '*';
            this.Input_Senha.Size = new System.Drawing.Size(145, 37);
            this.Input_Senha.TabIndex = 2;
            this.Input_Senha.Text = "funcionario";
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.AutoSize = true;
            this.Lbl_Senha.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Senha.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Senha.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_Senha.Location = new System.Drawing.Point(334, 237);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(101, 34);
            this.Lbl_Senha.TabIndex = 2;
            this.Lbl_Senha.Text = "Senha:";
            // 
            // Btn_Logar
            // 
            this.Btn_Logar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.Btn_Logar.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Logar.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Btn_Logar.Location = new System.Drawing.Point(399, 310);
            this.Btn_Logar.Name = "Btn_Logar";
            this.Btn_Logar.Size = new System.Drawing.Size(104, 44);
            this.Btn_Logar.TabIndex = 3;
            this.Btn_Logar.Text = "Entrar";
            this.Btn_Logar.UseVisualStyleBackColor = false;
            this.Btn_Logar.Click += new System.EventHandler(this.Btn_Logar_Click);
            // 
            // Lbl_Erro
            // 
            this.Lbl_Erro.AutoSize = true;
            this.Lbl_Erro.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Erro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Erro.ForeColor = System.Drawing.Color.IndianRed;
            this.Lbl_Erro.Location = new System.Drawing.Point(320, 292);
            this.Lbl_Erro.Name = "Lbl_Erro";
            this.Lbl_Erro.Size = new System.Drawing.Size(0, 17);
            this.Lbl_Erro.TabIndex = 5;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Franklin Gothic Book", 27.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Titulo.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_Titulo.Location = new System.Drawing.Point(340, 112);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(240, 43);
            this.Lbl_Titulo.TabIndex = 6;
            this.Lbl_Titulo.Text = "Funcionários:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaCliente.Properties.Resources.funcionario_perncil_icon;
            this.pictureBox1.Location = new System.Drawing.Point(230, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Login_funcio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Lbl_Erro);
            this.Controls.Add(this.Btn_Logar);
            this.Controls.Add(this.Input_Senha);
            this.Controls.Add(this.Lbl_Senha);
            this.Controls.Add(this.Input_Nome);
            this.Controls.Add(this.Lbl_Nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Login_funcio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Login_funcionário";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.TextBox Input_Nome;
        private System.Windows.Forms.TextBox Input_Senha;
        private System.Windows.Forms.Label Lbl_Senha;
        private System.Windows.Forms.Button Btn_Logar;
        private System.Windows.Forms.Label Lbl_Erro;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}