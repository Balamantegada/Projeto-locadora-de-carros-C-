namespace SistemaCliente
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.Btn_Login_admin = new System.Windows.Forms.Button();
            this.Btn_Login_Funcio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Login_admin
            // 
            this.Btn_Login_admin.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Login_admin.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login_admin.Location = new System.Drawing.Point(814, 373);
            this.Btn_Login_admin.Name = "Btn_Login_admin";
            this.Btn_Login_admin.Size = new System.Drawing.Size(300, 100);
            this.Btn_Login_admin.TabIndex = 1;
            this.Btn_Login_admin.Text = "Login\r\nadmin";
            this.Btn_Login_admin.UseVisualStyleBackColor = false;
            this.Btn_Login_admin.Click += new System.EventHandler(this.Btn_Login_admin_Click);
            // 
            // Btn_Login_Funcio
            // 
            this.Btn_Login_Funcio.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Login_Funcio.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login_Funcio.Location = new System.Drawing.Point(814, 479);
            this.Btn_Login_Funcio.Name = "Btn_Login_Funcio";
            this.Btn_Login_Funcio.Size = new System.Drawing.Size(300, 100);
            this.Btn_Login_Funcio.TabIndex = 2;
            this.Btn_Login_Funcio.Text = "Login\r\nfuncionário";
            this.Btn_Login_Funcio.UseVisualStyleBackColor = false;
            this.Btn_Login_Funcio.Click += new System.EventHandler(this.Btn_Login_Funcio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaCliente.Properties.Resources.principal_icon;
            this.pictureBox1.Location = new System.Drawing.Point(814, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Login_Funcio);
            this.Controls.Add(this.Btn_Login_admin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Login_admin;
        private System.Windows.Forms.Button Btn_Login_Funcio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

