namespace SistemaCliente
{
    partial class Glads
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glads));
            this.Btn_Login_admin = new System.Windows.Forms.Button();
            this.Btn_Login_Funcio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Login_admin
            // 
            this.Btn_Login_admin.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Login_admin.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login_admin.Location = new System.Drawing.Point(241, 366);
            this.Btn_Login_admin.Name = "Btn_Login_admin";
            this.Btn_Login_admin.Size = new System.Drawing.Size(232, 55);
            this.Btn_Login_admin.TabIndex = 1;
            this.Btn_Login_admin.Text = "Admin";
            this.Btn_Login_admin.UseVisualStyleBackColor = false;
            this.Btn_Login_admin.Click += new System.EventHandler(this.Btn_Login_admin_Click);
            // 
            // Btn_Login_Funcio
            // 
            this.Btn_Login_Funcio.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Login_Funcio.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login_Funcio.Location = new System.Drawing.Point(479, 366);
            this.Btn_Login_Funcio.Name = "Btn_Login_Funcio";
            this.Btn_Login_Funcio.Size = new System.Drawing.Size(243, 55);
            this.Btn_Login_Funcio.TabIndex = 2;
            this.Btn_Login_Funcio.Text = "Funcionário";
            this.Btn_Login_Funcio.UseVisualStyleBackColor = false;
            this.Btn_Login_Funcio.Click += new System.EventHandler(this.Btn_Login_Funcio_Click);
            // 
            // Glads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.Btn_Login_Funcio);
            this.Controls.Add(this.Btn_Login_admin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Glads";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GLADS";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Login_admin;
        private System.Windows.Forms.Button Btn_Login_Funcio;
    }
}

