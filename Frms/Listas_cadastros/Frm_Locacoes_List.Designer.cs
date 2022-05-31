namespace SistemaCliente
{
    partial class Frm_Locacoe_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Locacoe_List));
            this.dataGridUsuario = new System.Windows.Forms.DataGridView();
            this.Input_BuscarUsuario = new System.Windows.Forms.TextBox();
            this.Btn_Atualizar = new System.Windows.Forms.Button();
            this.Lbl_CPF = new System.Windows.Forms.Label();
            this.Lbl_Ativo = new System.Windows.Forms.Label();
            this.Btn_Alterar = new System.Windows.Forms.Button();
            this.Bt_BuscarCliente = new System.Windows.Forms.Button();
            this.Novo_Cliente = new System.Windows.Forms.Button();
            this.Bt_Excluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridUsuario
            // 
            this.dataGridUsuario.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsuario.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridUsuario.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridUsuario.Location = new System.Drawing.Point(50, 100);
            this.dataGridUsuario.Name = "dataGridUsuario";
            this.dataGridUsuario.Size = new System.Drawing.Size(1282, 400);
            this.dataGridUsuario.TabIndex = 0;
            this.dataGridUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClientes_CellClick);
            // 
            // Input_BuscarUsuario
            // 
            this.Input_BuscarUsuario.Font = new System.Drawing.Font("Javanese Text", 13.25F);
            this.Input_BuscarUsuario.Location = new System.Drawing.Point(50, 34);
            this.Input_BuscarUsuario.Multiline = true;
            this.Input_BuscarUsuario.Name = "Input_BuscarUsuario";
            this.Input_BuscarUsuario.Size = new System.Drawing.Size(150, 41);
            this.Input_BuscarUsuario.TabIndex = 1;
            this.Input_BuscarUsuario.Text = "Pesquisa";
            // 
            // Btn_Atualizar
            // 
            this.Btn_Atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.Btn_Atualizar.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F);
            this.Btn_Atualizar.Location = new System.Drawing.Point(325, 40);
            this.Btn_Atualizar.Name = "Btn_Atualizar";
            this.Btn_Atualizar.Size = new System.Drawing.Size(100, 30);
            this.Btn_Atualizar.TabIndex = 3;
            this.Btn_Atualizar.Text = "Atualizar";
            this.Btn_Atualizar.UseVisualStyleBackColor = false;
            this.Btn_Atualizar.Click += new System.EventHandler(this.Btn_Atualizar_Click);
            // 
            // Lbl_CPF
            // 
            this.Lbl_CPF.AutoSize = true;
            this.Lbl_CPF.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_CPF.Font = new System.Drawing.Font("Franklin Gothic Book", 16.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_CPF.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_CPF.Location = new System.Drawing.Point(431, 40);
            this.Lbl_CPF.Name = "Lbl_CPF";
            this.Lbl_CPF.Size = new System.Drawing.Size(48, 29);
            this.Lbl_CPF.TabIndex = 3;
            this.Lbl_CPF.Text = "-----";
            this.Lbl_CPF.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Lbl_Ativo
            // 
            this.Lbl_Ativo.AutoSize = true;
            this.Lbl_Ativo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Ativo.Font = new System.Drawing.Font("Franklin Gothic Book", 16.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Ativo.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_Ativo.Location = new System.Drawing.Point(943, 40);
            this.Lbl_Ativo.Name = "Lbl_Ativo";
            this.Lbl_Ativo.Size = new System.Drawing.Size(48, 29);
            this.Lbl_Ativo.TabIndex = 4;
            this.Lbl_Ativo.Text = "-----";
            // 
            // Btn_Alterar
            // 
            this.Btn_Alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.Btn_Alterar.Location = new System.Drawing.Point(1176, 526);
            this.Btn_Alterar.Name = "Btn_Alterar";
            this.Btn_Alterar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Alterar.TabIndex = 5;
            this.Btn_Alterar.Text = "Alterar";
            this.Btn_Alterar.UseVisualStyleBackColor = false;
            this.Btn_Alterar.Click += new System.EventHandler(this.Btn_Alterar_Click);
            // 
            // Bt_BuscarCliente
            // 
            this.Bt_BuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.Bt_BuscarCliente.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F);
            this.Bt_BuscarCliente.Location = new System.Drawing.Point(219, 40);
            this.Bt_BuscarCliente.Name = "Bt_BuscarCliente";
            this.Bt_BuscarCliente.Size = new System.Drawing.Size(100, 30);
            this.Bt_BuscarCliente.TabIndex = 2;
            this.Bt_BuscarCliente.Text = "Buscar";
            this.Bt_BuscarCliente.UseVisualStyleBackColor = false;
            this.Bt_BuscarCliente.Click += new System.EventHandler(this.Bt_BuscarNome_Click);
            // 
            // Novo_Cliente
            // 
            this.Novo_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.Novo_Cliente.Location = new System.Drawing.Point(1095, 526);
            this.Novo_Cliente.Name = "Novo_Cliente";
            this.Novo_Cliente.Size = new System.Drawing.Size(75, 23);
            this.Novo_Cliente.TabIndex = 4;
            this.Novo_Cliente.Text = "Novo";
            this.Novo_Cliente.UseVisualStyleBackColor = false;
            this.Novo_Cliente.Click += new System.EventHandler(this.Novo_Cliente_Click);
            // 
            // Bt_Excluir
            // 
            this.Bt_Excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.Bt_Excluir.Location = new System.Drawing.Point(1257, 526);
            this.Bt_Excluir.Name = "Bt_Excluir";
            this.Bt_Excluir.Size = new System.Drawing.Size(75, 23);
            this.Bt_Excluir.TabIndex = 6;
            this.Bt_Excluir.Text = "Desativar";
            this.Bt_Excluir.UseVisualStyleBackColor = false;
            this.Bt_Excluir.Click += new System.EventHandler(this.Bt_Excluir_Click);
            // 
            // Frm_Locacoe_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1344, 561);
            this.Controls.Add(this.Bt_Excluir);
            this.Controls.Add(this.Novo_Cliente);
            this.Controls.Add(this.Bt_BuscarCliente);
            this.Controls.Add(this.Btn_Alterar);
            this.Controls.Add(this.Lbl_Ativo);
            this.Controls.Add(this.Lbl_CPF);
            this.Controls.Add(this.Btn_Atualizar);
            this.Controls.Add(this.Input_BuscarUsuario);
            this.Controls.Add(this.dataGridUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Locacoe_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Locaoções_List";
            this.Load += new System.EventHandler(this.Frm_User_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridUsuario;
        private System.Windows.Forms.TextBox Input_BuscarUsuario;
        private System.Windows.Forms.Button Btn_Atualizar;
        private System.Windows.Forms.Label Lbl_CPF;
        private System.Windows.Forms.Label Lbl_Ativo;
        private System.Windows.Forms.Button Btn_Alterar;
        private System.Windows.Forms.Button Bt_BuscarCliente;
        private System.Windows.Forms.Button Novo_Cliente;
        private System.Windows.Forms.Button Bt_Excluir;
    }
}