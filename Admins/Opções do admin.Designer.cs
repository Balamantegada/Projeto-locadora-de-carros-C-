namespace SistemaCliente.Frms
{
    partial class Frm_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Admin));
            this.Btn_Cadastrar_Funcio = new System.Windows.Forms.Button();
            this.Btn_Cadastrar_Cliente = new System.Windows.Forms.Button();
            this.Btn_Cadastrar_Carros = new System.Windows.Forms.Button();
            this.Btn_Cadastrar_Locações = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Cadastrar_Funcio
            // 
            this.Btn_Cadastrar_Funcio.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Cadastrar_Funcio.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Cadastrar_Funcio.Location = new System.Drawing.Point(559, 122);
            this.Btn_Cadastrar_Funcio.Name = "Btn_Cadastrar_Funcio";
            this.Btn_Cadastrar_Funcio.Size = new System.Drawing.Size(306, 39);
            this.Btn_Cadastrar_Funcio.TabIndex = 1;
            this.Btn_Cadastrar_Funcio.Text = "Cadastrar funcionário\r\n";
            this.Btn_Cadastrar_Funcio.UseVisualStyleBackColor = false;
            this.Btn_Cadastrar_Funcio.Click += new System.EventHandler(this.Btn_Cadastrar_Funcio_Click);
            // 
            // Btn_Cadastrar_Cliente
            // 
            this.Btn_Cadastrar_Cliente.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Cadastrar_Cliente.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cadastrar_Cliente.Location = new System.Drawing.Point(559, 202);
            this.Btn_Cadastrar_Cliente.Name = "Btn_Cadastrar_Cliente";
            this.Btn_Cadastrar_Cliente.Size = new System.Drawing.Size(306, 43);
            this.Btn_Cadastrar_Cliente.TabIndex = 2;
            this.Btn_Cadastrar_Cliente.Text = "Cadastrar cliente";
            this.Btn_Cadastrar_Cliente.UseVisualStyleBackColor = false;
            this.Btn_Cadastrar_Cliente.Click += new System.EventHandler(this.Btn_Cadastrar_Cliente_Click);
            // 
            // Btn_Cadastrar_Carros
            // 
            this.Btn_Cadastrar_Carros.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Cadastrar_Carros.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cadastrar_Carros.Location = new System.Drawing.Point(559, 286);
            this.Btn_Cadastrar_Carros.Name = "Btn_Cadastrar_Carros";
            this.Btn_Cadastrar_Carros.Size = new System.Drawing.Size(306, 43);
            this.Btn_Cadastrar_Carros.TabIndex = 3;
            this.Btn_Cadastrar_Carros.Text = "Cadastrar carros";
            this.Btn_Cadastrar_Carros.UseVisualStyleBackColor = false;
            this.Btn_Cadastrar_Carros.Click += new System.EventHandler(this.Btn_Cadastrar_Carros_Click);
            // 
            // Btn_Cadastrar_Locações
            // 
            this.Btn_Cadastrar_Locações.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Cadastrar_Locações.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cadastrar_Locações.Location = new System.Drawing.Point(559, 368);
            this.Btn_Cadastrar_Locações.Name = "Btn_Cadastrar_Locações";
            this.Btn_Cadastrar_Locações.Size = new System.Drawing.Size(306, 43);
            this.Btn_Cadastrar_Locações.TabIndex = 4;
            this.Btn_Cadastrar_Locações.Text = "Cadastrar locações";
            this.Btn_Cadastrar_Locações.UseVisualStyleBackColor = false;
            this.Btn_Cadastrar_Locações.Click += new System.EventHandler(this.Btn_Cadastrar_Locações_Click);
            // 
            // Frm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.Btn_Cadastrar_Locações);
            this.Controls.Add(this.Btn_Cadastrar_Carros);
            this.Controls.Add(this.Btn_Cadastrar_Cliente);
            this.Controls.Add(this.Btn_Cadastrar_Funcio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel do admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cadastrar_Funcio;
        private System.Windows.Forms.Button Btn_Cadastrar_Cliente;
        private System.Windows.Forms.Button Btn_Cadastrar_Carros;
        private System.Windows.Forms.Button Btn_Cadastrar_Locações;
    }
}