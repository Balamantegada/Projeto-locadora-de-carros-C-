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
            this.Input_Usuario = new System.Windows.Forms.TextBox();
            this.Input_Senha = new System.Windows.Forms.TextBox();
            this.Btn_Logar = new System.Windows.Forms.Button();
            this.Lbl_Erro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Input_Usuario
            // 
            this.Input_Usuario.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Usuario.Location = new System.Drawing.Point(623, 143);
            this.Input_Usuario.Name = "Input_Usuario";
            this.Input_Usuario.Size = new System.Drawing.Size(253, 43);
            this.Input_Usuario.TabIndex = 1;
            // 
            // Input_Senha
            // 
            this.Input_Senha.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Senha.Location = new System.Drawing.Point(623, 358);
            this.Input_Senha.Name = "Input_Senha";
            this.Input_Senha.PasswordChar = '*';
            this.Input_Senha.Size = new System.Drawing.Size(145, 43);
            this.Input_Senha.TabIndex = 2;
            // 
            // Btn_Logar
            // 
            this.Btn_Logar.BackColor = System.Drawing.Color.Teal;
            this.Btn_Logar.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Logar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Logar.Location = new System.Drawing.Point(134, 348);
            this.Btn_Logar.Name = "Btn_Logar";
            this.Btn_Logar.Size = new System.Drawing.Size(162, 59);
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
            this.Lbl_Erro.Location = new System.Drawing.Point(620, 440);
            this.Lbl_Erro.Name = "Lbl_Erro";
            this.Lbl_Erro.Size = new System.Drawing.Size(0, 17);
            this.Lbl_Erro.TabIndex = 5;
            // 
            // Frm_Login_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.Lbl_Erro);
            this.Controls.Add(this.Btn_Logar);
            this.Controls.Add(this.Input_Senha);
            this.Controls.Add(this.Input_Usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Login_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Input_Usuario;
        private System.Windows.Forms.TextBox Input_Senha;
        private System.Windows.Forms.Button Btn_Logar;
        private System.Windows.Forms.Label Lbl_Erro;
    }
}