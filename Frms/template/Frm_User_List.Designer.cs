/*namespace SistemaCliente
{
    partial class Frm_User_List
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
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.Input_BuscarNome = new System.Windows.Forms.TextBox();
            this.Btn_Atualizar = new System.Windows.Forms.Button();
            this.Lbl_NomeCliente = new System.Windows.Forms.Label();
            this.Lbl_NumeroCell = new System.Windows.Forms.Label();
            this.Btn_Alterar = new System.Windows.Forms.Button();
            this.Bt_BuscarCliente = new System.Windows.Forms.Button();
            this.Novo_Cliente = new System.Windows.Forms.Button();
            this.Bt_Excluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridClientes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridClientes.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridClientes.Location = new System.Drawing.Point(50, 100);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.Size = new System.Drawing.Size(800, 400);
            this.dataGridClientes.TabIndex = 0;
            this.dataGridClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClientes_CellClick_1);
            // 
            // Input_BuscarNome
            // 
            this.Input_BuscarNome.Font = new System.Drawing.Font("Javanese Text", 13.25F);
            this.Input_BuscarNome.Location = new System.Drawing.Point(50, 34);
            this.Input_BuscarNome.Multiline = true;
            this.Input_BuscarNome.Name = "Input_BuscarNome";
            this.Input_BuscarNome.Size = new System.Drawing.Size(150, 41);
            this.Input_BuscarNome.TabIndex = 1;
            this.Input_BuscarNome.Text = "teste";
            // 
            // Btn_Atualizar
            // 
            this.Btn_Atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.Btn_Atualizar.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F);
            this.Btn_Atualizar.Location = new System.Drawing.Point(325, 40);
            this.Btn_Atualizar.Name = "Btn_Atualizar";
            this.Btn_Atualizar.Size = new System.Drawing.Size(100, 30);
            this.Btn_Atualizar.TabIndex = 2;
            this.Btn_Atualizar.Text = "Atualizar";
            this.Btn_Atualizar.UseVisualStyleBackColor = false;
            this.Btn_Atualizar.Click += new System.EventHandler(this.Btn_Atualizar_Click_1);
            // 
            // Lbl_NomeCliente
            // 
            this.Lbl_NomeCliente.AutoSize = true;
            this.Lbl_NomeCliente.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_NomeCliente.Font = new System.Drawing.Font("Franklin Gothic Book", 16.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_NomeCliente.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_NomeCliente.Location = new System.Drawing.Point(431, 40);
            this.Lbl_NomeCliente.Name = "Lbl_NomeCliente";
            this.Lbl_NomeCliente.Size = new System.Drawing.Size(48, 29);
            this.Lbl_NomeCliente.TabIndex = 3;
            this.Lbl_NomeCliente.Text = "-----";
            this.Lbl_NomeCliente.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Lbl_NumeroCell
            // 
            this.Lbl_NumeroCell.AutoSize = true;
            this.Lbl_NumeroCell.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_NumeroCell.Font = new System.Drawing.Font("Franklin Gothic Book", 16.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_NumeroCell.ForeColor = System.Drawing.Color.Snow;
            this.Lbl_NumeroCell.Location = new System.Drawing.Point(626, 39);
            this.Lbl_NumeroCell.Name = "Lbl_NumeroCell";
            this.Lbl_NumeroCell.Size = new System.Drawing.Size(48, 29);
            this.Lbl_NumeroCell.TabIndex = 4;
            this.Lbl_NumeroCell.Text = "-----";
            // 
            // Btn_Alterar
            // 
            this.Btn_Alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.Btn_Alterar.Location = new System.Drawing.Point(694, 517);
            this.Btn_Alterar.Name = "Btn_Alterar";
            this.Btn_Alterar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Alterar.TabIndex = 5;
            this.Btn_Alterar.Text = "Alterar";
            this.Btn_Alterar.UseVisualStyleBackColor = false;
            this.Btn_Alterar.Click += new System.EventHandler(this.Btn_Alterar_Click_1);
            // 
            // Bt_BuscarCliente
            // 
            this.Bt_BuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.Bt_BuscarCliente.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F);
            this.Bt_BuscarCliente.Location = new System.Drawing.Point(219, 40);
            this.Bt_BuscarCliente.Name = "Bt_BuscarCliente";
            this.Bt_BuscarCliente.Size = new System.Drawing.Size(100, 30);
            this.Bt_BuscarCliente.TabIndex = 6;
            this.Bt_BuscarCliente.Text = "Buscar";
            this.Bt_BuscarCliente.UseVisualStyleBackColor = false;
            this.Bt_BuscarCliente.Click += new System.EventHandler(this.Bt_BuscarNome_Click_1);
            // 
            // Novo_Cliente
            // 
            this.Novo_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.Novo_Cliente.Location = new System.Drawing.Point(613, 517);
            this.Novo_Cliente.Name = "Novo_Cliente";
            this.Novo_Cliente.Size = new System.Drawing.Size(75, 23);
            this.Novo_Cliente.TabIndex = 7;
            this.Novo_Cliente.Text = "Novo";
            this.Novo_Cliente.UseVisualStyleBackColor = false;
            this.Novo_Cliente.Click += new System.EventHandler(this.Novo_Cliente_Click);
            // 
            // Bt_Excluir
            // 
            this.Bt_Excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.Bt_Excluir.Location = new System.Drawing.Point(775, 517);
            this.Bt_Excluir.Name = "Bt_Excluir";
            this.Bt_Excluir.Size = new System.Drawing.Size(75, 23);
            this.Bt_Excluir.TabIndex = 8;
            this.Bt_Excluir.Text = "Excluir";
            this.Bt_Excluir.UseVisualStyleBackColor = false;
            // 
            // Frm_User_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.Bt_Excluir);
            this.Controls.Add(this.Novo_Cliente);
            this.Controls.Add(this.Bt_BuscarCliente);
            this.Controls.Add(this.Btn_Alterar);
            this.Controls.Add(this.Lbl_NumeroCell);
            this.Controls.Add(this.Lbl_NomeCliente);
            this.Controls.Add(this.Btn_Atualizar);
            this.Controls.Add(this.Input_BuscarNome);
            this.Controls.Add(this.dataGridClientes);
            this.Name = "Frm_User_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_User_List";
            this.Load += new System.EventHandler(this.Frm_User_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridClientes;
        private System.Windows.Forms.TextBox Input_BuscarNome;
        private System.Windows.Forms.Button Btn_Atualizar;
        private System.Windows.Forms.Label Lbl_NomeCliente;
        private System.Windows.Forms.Label Lbl_NumeroCell;
        private System.Windows.Forms.Button Btn_Alterar;
        private System.Windows.Forms.Button Bt_BuscarCliente;
        private System.Windows.Forms.Button Novo_Cliente;
        private System.Windows.Forms.Button Bt_Excluir;
    }
}*/