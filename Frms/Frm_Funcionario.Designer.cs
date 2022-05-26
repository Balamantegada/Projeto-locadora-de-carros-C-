namespace SistemaCliente.Frms
{
    partial class Frm_Funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Funcionario));
            this.Btn_Cadastrar_Cliente = new System.Windows.Forms.Button();
            this.Btn_Cadastrar_Locações = new System.Windows.Forms.Button();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Cadastrar_Cliente
            // 
            this.Btn_Cadastrar_Cliente.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Cadastrar_Cliente.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cadastrar_Cliente.Location = new System.Drawing.Point(334, 190);
            this.Btn_Cadastrar_Cliente.Name = "Btn_Cadastrar_Cliente";
            this.Btn_Cadastrar_Cliente.Size = new System.Drawing.Size(300, 100);
            this.Btn_Cadastrar_Cliente.TabIndex = 1;
            this.Btn_Cadastrar_Cliente.Text = "Cadastrar\r\ncliente";
            this.Btn_Cadastrar_Cliente.UseVisualStyleBackColor = false;
            this.Btn_Cadastrar_Cliente.Click += new System.EventHandler(this.Btn_Cadastrar_Cliente_Click);
            // 
            // Btn_Cadastrar_Locações
            // 
            this.Btn_Cadastrar_Locações.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Cadastrar_Locações.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cadastrar_Locações.Location = new System.Drawing.Point(334, 296);
            this.Btn_Cadastrar_Locações.Name = "Btn_Cadastrar_Locações";
            this.Btn_Cadastrar_Locações.Size = new System.Drawing.Size(300, 100);
            this.Btn_Cadastrar_Locações.TabIndex = 2;
            this.Btn_Cadastrar_Locações.Text = "Cadastrar\r\nlocações";
            this.Btn_Cadastrar_Locações.UseVisualStyleBackColor = false;
            this.Btn_Cadastrar_Locações.Click += new System.EventHandler(this.Btn_Cadastrar_Locações_Click);
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Franklin Gothic Book", 27.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Titulo.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_Titulo.Location = new System.Drawing.Point(383, 97);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(150, 43);
            this.Lbl_Titulo.TabIndex = 10;
            this.Lbl_Titulo.Text = "Opções:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::SistemaCliente.Properties.Resources.locação_icon;
            this.pictureBox4.Location = new System.Drawing.Point(224, 296);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(104, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SistemaCliente.Properties.Resources.clientes_icon;
            this.pictureBox2.Location = new System.Drawing.Point(224, 193);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Frm_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Btn_Cadastrar_Locações);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Btn_Cadastrar_Cliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Cadastrar_Cliente;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Btn_Cadastrar_Locações;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label Lbl_Titulo;
    }
}