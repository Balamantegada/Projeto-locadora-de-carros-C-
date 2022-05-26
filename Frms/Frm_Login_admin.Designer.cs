namespace SistemaCliente
{
    partial class Frm_Login_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login_admin));
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Input_Usuario = new System.Windows.Forms.TextBox();
            this.Input_Senha = new System.Windows.Forms.TextBox();
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.Btn_Logar = new System.Windows.Forms.Button();
            this.Lbl_Erro = new System.Windows.Forms.Label();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Usuario.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_Usuario.Location = new System.Drawing.Point(318, 173);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(117, 34);
            this.Lbl_Usuario.TabIndex = 0;
            this.Lbl_Usuario.Text = "Usuario:";
            // 
            // Input_Usuario
            // 
            this.Input_Usuario.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F);
            this.Input_Usuario.Location = new System.Drawing.Point(435, 173);
            this.Input_Usuario.Name = "Input_Usuario";
            this.Input_Usuario.Size = new System.Drawing.Size(145, 37);
            this.Input_Usuario.TabIndex = 1;
            this.Input_Usuario.Text = "adm";
            // 
            // Input_Senha
            // 
            this.Input_Senha.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F);
            this.Input_Senha.Location = new System.Drawing.Point(435, 234);
            this.Input_Senha.Name = "Input_Senha";
            this.Input_Senha.PasswordChar = '*';
            this.Input_Senha.Size = new System.Drawing.Size(145, 37);
            this.Input_Senha.TabIndex = 2;
            this.Input_Senha.Text = "adm";
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
            this.Lbl_Titulo.Location = new System.Drawing.Point(391, 117);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(150, 43);
            this.Lbl_Titulo.TabIndex = 7;
            this.Lbl_Titulo.Text = "Admins:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaCliente.Properties.Resources.admin_icon;
            this.pictureBox1.Location = new System.Drawing.Point(224, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Login_admin
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
            this.Controls.Add(this.Input_Usuario);
            this.Controls.Add(this.Lbl_Usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Login_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Login_admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.TextBox Input_Usuario;
        private System.Windows.Forms.TextBox Input_Senha;
        private System.Windows.Forms.Label Lbl_Senha;
        private System.Windows.Forms.Button Btn_Logar;
        private System.Windows.Forms.Label Lbl_Erro;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}