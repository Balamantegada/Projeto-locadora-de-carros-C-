namespace SistemaCliente
{
    partial class Frm_Carros_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Carros_List));
            this.dataGridCarros = new System.Windows.Forms.DataGridView();
            this.Input_BuscarCarros = new System.Windows.Forms.TextBox();
            this.Btn_Atualizar = new System.Windows.Forms.Button();
            this.Lbl_Modelo = new System.Windows.Forms.Label();
            this.Lbl_Valor_Compra = new System.Windows.Forms.Label();
            this.Btn_Alterar = new System.Windows.Forms.Button();
            this.Bt_BuscarCliente = new System.Windows.Forms.Button();
            this.Novo_Cliente = new System.Windows.Forms.Button();
            this.Bt_Excluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCarros
            // 
            this.dataGridCarros.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCarros.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCarros.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridCarros.Location = new System.Drawing.Point(50, 100);
            this.dataGridCarros.Name = "dataGridCarros";
            this.dataGridCarros.Size = new System.Drawing.Size(1476, 400);
            this.dataGridCarros.TabIndex = 0;
            this.dataGridCarros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCarros_CellClick);
            // 
            // Input_BuscarCarros
            // 
            this.Input_BuscarCarros.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_BuscarCarros.Location = new System.Drawing.Point(50, 34);
            this.Input_BuscarCarros.Multiline = true;
            this.Input_BuscarCarros.Name = "Input_BuscarCarros";
            this.Input_BuscarCarros.Size = new System.Drawing.Size(150, 41);
            this.Input_BuscarCarros.TabIndex = 1;
            this.Input_BuscarCarros.Text = "...";
            // 
            // Btn_Atualizar
            // 
            this.Btn_Atualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Atualizar.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Atualizar.Location = new System.Drawing.Point(325, 40);
            this.Btn_Atualizar.Name = "Btn_Atualizar";
            this.Btn_Atualizar.Size = new System.Drawing.Size(100, 30);
            this.Btn_Atualizar.TabIndex = 2;
            this.Btn_Atualizar.Text = "Atualizar";
            this.Btn_Atualizar.UseVisualStyleBackColor = false;
            this.Btn_Atualizar.Click += new System.EventHandler(this.Btn_Atualizar_Click);
            // 
            // Lbl_Modelo
            // 
            this.Lbl_Modelo.AutoSize = true;
            this.Lbl_Modelo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Modelo.Font = new System.Drawing.Font("Gadugi", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Modelo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lbl_Modelo.Location = new System.Drawing.Point(731, 39);
            this.Lbl_Modelo.Name = "Lbl_Modelo";
            this.Lbl_Modelo.Size = new System.Drawing.Size(57, 27);
            this.Lbl_Modelo.TabIndex = 3;
            this.Lbl_Modelo.Text = "-----";
            this.Lbl_Modelo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Lbl_Valor_Compra
            // 
            this.Lbl_Valor_Compra.AutoSize = true;
            this.Lbl_Valor_Compra.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Valor_Compra.Font = new System.Drawing.Font("Gadugi", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Valor_Compra.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lbl_Valor_Compra.Location = new System.Drawing.Point(1259, 43);
            this.Lbl_Valor_Compra.Name = "Lbl_Valor_Compra";
            this.Lbl_Valor_Compra.Size = new System.Drawing.Size(57, 27);
            this.Lbl_Valor_Compra.TabIndex = 4;
            this.Lbl_Valor_Compra.Text = "-----";
            // 
            // Btn_Alterar
            // 
            this.Btn_Alterar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Alterar.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Alterar.Location = new System.Drawing.Point(1370, 526);
            this.Btn_Alterar.Name = "Btn_Alterar";
            this.Btn_Alterar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Alterar.TabIndex = 5;
            this.Btn_Alterar.Text = "Alterar";
            this.Btn_Alterar.UseVisualStyleBackColor = false;
            this.Btn_Alterar.Click += new System.EventHandler(this.Btn_Alterar_Click);
            // 
            // Bt_BuscarCliente
            // 
            this.Bt_BuscarCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bt_BuscarCliente.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_BuscarCliente.Location = new System.Drawing.Point(219, 40);
            this.Bt_BuscarCliente.Name = "Bt_BuscarCliente";
            this.Bt_BuscarCliente.Size = new System.Drawing.Size(100, 30);
            this.Bt_BuscarCliente.TabIndex = 6;
            this.Bt_BuscarCliente.Text = "Buscar";
            this.Bt_BuscarCliente.UseVisualStyleBackColor = false;
            this.Bt_BuscarCliente.Click += new System.EventHandler(this.Bt_BuscarNome_Click);
            // 
            // Novo_Cliente
            // 
            this.Novo_Cliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Novo_Cliente.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Novo_Cliente.Location = new System.Drawing.Point(1289, 526);
            this.Novo_Cliente.Name = "Novo_Cliente";
            this.Novo_Cliente.Size = new System.Drawing.Size(75, 23);
            this.Novo_Cliente.TabIndex = 7;
            this.Novo_Cliente.Text = "Novo";
            this.Novo_Cliente.UseVisualStyleBackColor = false;
            this.Novo_Cliente.Click += new System.EventHandler(this.Novo_Cliente_Click);
            // 
            // Bt_Excluir
            // 
            this.Bt_Excluir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bt_Excluir.Location = new System.Drawing.Point(1451, 526);
            this.Bt_Excluir.Name = "Bt_Excluir";
            this.Bt_Excluir.Size = new System.Drawing.Size(75, 23);
            this.Bt_Excluir.TabIndex = 8;
            this.Bt_Excluir.Text = "Deletar";
            this.Bt_Excluir.UseVisualStyleBackColor = false;
            this.Bt_Excluir.Click += new System.EventHandler(this.Bt_Excluir_Click);
            // 
            // Frm_Carros_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1553, 561);
            this.Controls.Add(this.Bt_Excluir);
            this.Controls.Add(this.Novo_Cliente);
            this.Controls.Add(this.Bt_BuscarCliente);
            this.Controls.Add(this.Btn_Alterar);
            this.Controls.Add(this.Lbl_Valor_Compra);
            this.Controls.Add(this.Lbl_Modelo);
            this.Controls.Add(this.Btn_Atualizar);
            this.Controls.Add(this.Input_BuscarCarros);
            this.Controls.Add(this.dataGridCarros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Carros_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de carros";
            this.Load += new System.EventHandler(this.Frm_User_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCarros;
        private System.Windows.Forms.TextBox Input_BuscarCarros;
        private System.Windows.Forms.Button Btn_Atualizar;
        private System.Windows.Forms.Label Lbl_Modelo;
        private System.Windows.Forms.Label Lbl_Valor_Compra;
        private System.Windows.Forms.Button Btn_Alterar;
        private System.Windows.Forms.Button Bt_BuscarCliente;
        private System.Windows.Forms.Button Novo_Cliente;
        private System.Windows.Forms.Button Bt_Excluir;
    }
}