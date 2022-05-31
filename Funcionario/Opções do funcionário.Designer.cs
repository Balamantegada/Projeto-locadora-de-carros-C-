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
            this.SuspendLayout();
            // 
            // Btn_Cadastrar_Cliente
            // 
            this.Btn_Cadastrar_Cliente.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Cadastrar_Cliente.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cadastrar_Cliente.Location = new System.Drawing.Point(552, 192);
            this.Btn_Cadastrar_Cliente.Name = "Btn_Cadastrar_Cliente";
            this.Btn_Cadastrar_Cliente.Size = new System.Drawing.Size(336, 47);
            this.Btn_Cadastrar_Cliente.TabIndex = 1;
            this.Btn_Cadastrar_Cliente.Text = "Cadastrar cliente";
            this.Btn_Cadastrar_Cliente.UseVisualStyleBackColor = false;
            this.Btn_Cadastrar_Cliente.Click += new System.EventHandler(this.Btn_Cadastrar_Cliente_Click);
            // 
            // Btn_Cadastrar_Locações
            // 
            this.Btn_Cadastrar_Locações.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Cadastrar_Locações.Font = new System.Drawing.Font("Franklin Gothic Book", 19.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cadastrar_Locações.Location = new System.Drawing.Point(552, 305);
            this.Btn_Cadastrar_Locações.Name = "Btn_Cadastrar_Locações";
            this.Btn_Cadastrar_Locações.Size = new System.Drawing.Size(336, 44);
            this.Btn_Cadastrar_Locações.TabIndex = 2;
            this.Btn_Cadastrar_Locações.Text = "Cadastrar locações";
            this.Btn_Cadastrar_Locações.UseVisualStyleBackColor = false;
            this.Btn_Cadastrar_Locações.Click += new System.EventHandler(this.Btn_Cadastrar_Locações_Click);
            // 
            // Frm_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.Btn_Cadastrar_Locações);
            this.Controls.Add(this.Btn_Cadastrar_Cliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Funcionario";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Cadastrar_Cliente;
        private System.Windows.Forms.Button Btn_Cadastrar_Locações;
    }
}