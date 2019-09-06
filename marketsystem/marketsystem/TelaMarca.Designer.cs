namespace marketsystem
{
    partial class TelaMarca
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
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.labBuscar = new System.Windows.Forms.Label();
            this.btnListarTodos = new System.Windows.Forms.Button();
            this.id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpj_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtCadNome = new System.Windows.Forms.TextBox();
            this.txtCadCnpj = new System.Windows.Forms.TextBox();
            this.txtCadTelefone = new System.Windows.Forms.TextBox();
            this.txtCadEndereco = new System.Windows.Forms.TextBox();
            this.labCadId = new System.Windows.Forms.Label();
            this.labCadNome = new System.Windows.Forms.Label();
            this.labCadCnpj = new System.Windows.Forms.Label();
            this.labCadTelefone = new System.Windows.Forms.Label();
            this.labCadEndereco = new System.Windows.Forms.Label();
            this.btnCadEnviar = new System.Windows.Forms.Button();
            this.gbCadastrar = new System.Windows.Forms.GroupBox();
            this.gbAlterar = new System.Windows.Forms.GroupBox();
            this.labAltId = new System.Windows.Forms.Label();
            this.btnAltEnviar = new System.Windows.Forms.Button();
            this.txtAltId = new System.Windows.Forms.TextBox();
            this.txtAltEndereco = new System.Windows.Forms.TextBox();
            this.labAltEndereco = new System.Windows.Forms.Label();
            this.labAltNome = new System.Windows.Forms.Label();
            this.labAltTelefone = new System.Windows.Forms.Label();
            this.txtAltTelefone = new System.Windows.Forms.TextBox();
            this.txtAltNome = new System.Windows.Forms.TextBox();
            this.labAltCnpj = new System.Windows.Forms.Label();
            this.txtAltCnpj = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.gbCadastrar.SuspendLayout();
            this.gbAlterar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMarca
            // 
            this.dgvMarca.AllowUserToAddRows = false;
            this.dgvMarca.AllowUserToDeleteRows = false;
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_col,
            this.nome_col,
            this.cnpj_col,
            this.telefone_col,
            this.endereco_col});
            this.dgvMarca.Location = new System.Drawing.Point(13, 73);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.ReadOnly = true;
            this.dgvMarca.RowHeadersVisible = false;
            this.dgvMarca.Size = new System.Drawing.Size(952, 247);
            this.dgvMarca.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Info;
            this.txtBuscar.Location = new System.Drawing.Point(13, 47);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(773, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // labBuscar
            // 
            this.labBuscar.AutoSize = true;
            this.labBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBuscar.Location = new System.Drawing.Point(12, 31);
            this.labBuscar.Name = "labBuscar";
            this.labBuscar.Size = new System.Drawing.Size(43, 13);
            this.labBuscar.TabIndex = 2;
            this.labBuscar.Text = "Buscar:";
            // 
            // btnListarTodos
            // 
            this.btnListarTodos.Location = new System.Drawing.Point(792, 45);
            this.btnListarTodos.Name = "btnListarTodos";
            this.btnListarTodos.Size = new System.Drawing.Size(173, 23);
            this.btnListarTodos.TabIndex = 3;
            this.btnListarTodos.Text = "Listar Todos";
            this.btnListarTodos.UseVisualStyleBackColor = true;
            this.btnListarTodos.Click += new System.EventHandler(this.btnListarTodos_Click);
            // 
            // id_col
            // 
            this.id_col.DataPropertyName = "Id";
            this.id_col.HeaderText = "ID";
            this.id_col.MinimumWidth = 50;
            this.id_col.Name = "id_col";
            this.id_col.ReadOnly = true;
            // 
            // nome_col
            // 
            this.nome_col.DataPropertyName = "Nome";
            this.nome_col.HeaderText = "Nome da Empresa";
            this.nome_col.MinimumWidth = 200;
            this.nome_col.Name = "nome_col";
            this.nome_col.ReadOnly = true;
            this.nome_col.Width = 247;
            // 
            // cnpj_col
            // 
            this.cnpj_col.DataPropertyName = "Cnpj";
            this.cnpj_col.HeaderText = "CNPJ";
            this.cnpj_col.MinimumWidth = 100;
            this.cnpj_col.Name = "cnpj_col";
            this.cnpj_col.ReadOnly = true;
            this.cnpj_col.Width = 150;
            // 
            // telefone_col
            // 
            this.telefone_col.DataPropertyName = "Telefone";
            this.telefone_col.HeaderText = "Telefone";
            this.telefone_col.MinimumWidth = 100;
            this.telefone_col.Name = "telefone_col";
            this.telefone_col.ReadOnly = true;
            this.telefone_col.Width = 150;
            // 
            // endereco_col
            // 
            this.endereco_col.DataPropertyName = "Endereco";
            this.endereco_col.HeaderText = "Endereço";
            this.endereco_col.MinimumWidth = 200;
            this.endereco_col.Name = "endereco_col";
            this.endereco_col.ReadOnly = true;
            this.endereco_col.Width = 300;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(220, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // txtCadNome
            // 
            this.txtCadNome.Location = new System.Drawing.Point(220, 55);
            this.txtCadNome.Name = "txtCadNome";
            this.txtCadNome.Size = new System.Drawing.Size(239, 20);
            this.txtCadNome.TabIndex = 5;
            // 
            // txtCadCnpj
            // 
            this.txtCadCnpj.Location = new System.Drawing.Point(220, 85);
            this.txtCadCnpj.Name = "txtCadCnpj";
            this.txtCadCnpj.Size = new System.Drawing.Size(152, 20);
            this.txtCadCnpj.TabIndex = 6;
            // 
            // txtCadTelefone
            // 
            this.txtCadTelefone.Location = new System.Drawing.Point(220, 115);
            this.txtCadTelefone.Name = "txtCadTelefone";
            this.txtCadTelefone.Size = new System.Drawing.Size(152, 20);
            this.txtCadTelefone.TabIndex = 7;
            // 
            // txtCadEndereco
            // 
            this.txtCadEndereco.Location = new System.Drawing.Point(220, 143);
            this.txtCadEndereco.Name = "txtCadEndereco";
            this.txtCadEndereco.Size = new System.Drawing.Size(374, 20);
            this.txtCadEndereco.TabIndex = 8;
            // 
            // labCadId
            // 
            this.labCadId.AutoSize = true;
            this.labCadId.Location = new System.Drawing.Point(193, 32);
            this.labCadId.Name = "labCadId";
            this.labCadId.Size = new System.Drawing.Size(21, 13);
            this.labCadId.TabIndex = 9;
            this.labCadId.Text = "ID:";
            // 
            // labCadNome
            // 
            this.labCadNome.AutoSize = true;
            this.labCadNome.Location = new System.Drawing.Point(117, 58);
            this.labCadNome.Name = "labCadNome";
            this.labCadNome.Size = new System.Drawing.Size(97, 13);
            this.labCadNome.TabIndex = 10;
            this.labCadNome.Text = "Nome da Empresa:";
            // 
            // labCadCnpj
            // 
            this.labCadCnpj.AutoSize = true;
            this.labCadCnpj.Location = new System.Drawing.Point(177, 88);
            this.labCadCnpj.Name = "labCadCnpj";
            this.labCadCnpj.Size = new System.Drawing.Size(37, 13);
            this.labCadCnpj.TabIndex = 11;
            this.labCadCnpj.Text = "CNPJ:";
            // 
            // labCadTelefone
            // 
            this.labCadTelefone.AutoSize = true;
            this.labCadTelefone.Location = new System.Drawing.Point(162, 118);
            this.labCadTelefone.Name = "labCadTelefone";
            this.labCadTelefone.Size = new System.Drawing.Size(52, 13);
            this.labCadTelefone.TabIndex = 12;
            this.labCadTelefone.Text = "Telefone:";
            // 
            // labCadEndereco
            // 
            this.labCadEndereco.AutoSize = true;
            this.labCadEndereco.Location = new System.Drawing.Point(158, 146);
            this.labCadEndereco.Name = "labCadEndereco";
            this.labCadEndereco.Size = new System.Drawing.Size(56, 13);
            this.labCadEndereco.TabIndex = 13;
            this.labCadEndereco.Text = "Endereço:";
            // 
            // btnCadEnviar
            // 
            this.btnCadEnviar.Location = new System.Drawing.Point(220, 169);
            this.btnCadEnviar.Name = "btnCadEnviar";
            this.btnCadEnviar.Size = new System.Drawing.Size(152, 23);
            this.btnCadEnviar.TabIndex = 14;
            this.btnCadEnviar.Text = "Enviar";
            this.btnCadEnviar.UseVisualStyleBackColor = true;
            // 
            // gbCadastrar
            // 
            this.gbCadastrar.Controls.Add(this.labCadId);
            this.gbCadastrar.Controls.Add(this.btnCadEnviar);
            this.gbCadastrar.Controls.Add(this.textBox1);
            this.gbCadastrar.Controls.Add(this.txtCadEndereco);
            this.gbCadastrar.Controls.Add(this.labCadEndereco);
            this.gbCadastrar.Controls.Add(this.labCadNome);
            this.gbCadastrar.Controls.Add(this.labCadTelefone);
            this.gbCadastrar.Controls.Add(this.txtCadTelefone);
            this.gbCadastrar.Controls.Add(this.txtCadNome);
            this.gbCadastrar.Controls.Add(this.labCadCnpj);
            this.gbCadastrar.Controls.Add(this.txtCadCnpj);
            this.gbCadastrar.Location = new System.Drawing.Point(287, 338);
            this.gbCadastrar.Name = "gbCadastrar";
            this.gbCadastrar.Size = new System.Drawing.Size(666, 283);
            this.gbCadastrar.TabIndex = 15;
            this.gbCadastrar.TabStop = false;
            this.gbCadastrar.Text = "Cadastrar";
            this.gbCadastrar.Visible = false;
            // 
            // gbAlterar
            // 
            this.gbAlterar.Controls.Add(this.labAltId);
            this.gbAlterar.Controls.Add(this.btnAltEnviar);
            this.gbAlterar.Controls.Add(this.txtAltId);
            this.gbAlterar.Controls.Add(this.txtAltEndereco);
            this.gbAlterar.Controls.Add(this.labAltEndereco);
            this.gbAlterar.Controls.Add(this.labAltNome);
            this.gbAlterar.Controls.Add(this.labAltTelefone);
            this.gbAlterar.Controls.Add(this.txtAltTelefone);
            this.gbAlterar.Controls.Add(this.txtAltNome);
            this.gbAlterar.Controls.Add(this.labAltCnpj);
            this.gbAlterar.Controls.Add(this.txtAltCnpj);
            this.gbAlterar.Location = new System.Drawing.Point(287, 338);
            this.gbAlterar.Name = "gbAlterar";
            this.gbAlterar.Size = new System.Drawing.Size(666, 283);
            this.gbAlterar.TabIndex = 16;
            this.gbAlterar.TabStop = false;
            this.gbAlterar.Text = "Alterar";
            this.gbAlterar.Visible = false;
            // 
            // labAltId
            // 
            this.labAltId.AutoSize = true;
            this.labAltId.Location = new System.Drawing.Point(193, 32);
            this.labAltId.Name = "labAltId";
            this.labAltId.Size = new System.Drawing.Size(21, 13);
            this.labAltId.TabIndex = 9;
            this.labAltId.Text = "ID:";
            // 
            // btnAltEnviar
            // 
            this.btnAltEnviar.Location = new System.Drawing.Point(220, 169);
            this.btnAltEnviar.Name = "btnAltEnviar";
            this.btnAltEnviar.Size = new System.Drawing.Size(152, 23);
            this.btnAltEnviar.TabIndex = 14;
            this.btnAltEnviar.Text = "Enviar";
            this.btnAltEnviar.UseVisualStyleBackColor = true;
            // 
            // txtAltId
            // 
            this.txtAltId.BackColor = System.Drawing.SystemColors.Info;
            this.txtAltId.Location = new System.Drawing.Point(220, 29);
            this.txtAltId.Name = "txtAltId";
            this.txtAltId.ReadOnly = true;
            this.txtAltId.Size = new System.Drawing.Size(100, 20);
            this.txtAltId.TabIndex = 4;
            // 
            // txtAltEndereco
            // 
            this.txtAltEndereco.Location = new System.Drawing.Point(220, 143);
            this.txtAltEndereco.Name = "txtAltEndereco";
            this.txtAltEndereco.Size = new System.Drawing.Size(374, 20);
            this.txtAltEndereco.TabIndex = 8;
            // 
            // labAltEndereco
            // 
            this.labAltEndereco.AutoSize = true;
            this.labAltEndereco.Location = new System.Drawing.Point(158, 146);
            this.labAltEndereco.Name = "labAltEndereco";
            this.labAltEndereco.Size = new System.Drawing.Size(56, 13);
            this.labAltEndereco.TabIndex = 13;
            this.labAltEndereco.Text = "Endereço:";
            // 
            // labAltNome
            // 
            this.labAltNome.AutoSize = true;
            this.labAltNome.Location = new System.Drawing.Point(117, 58);
            this.labAltNome.Name = "labAltNome";
            this.labAltNome.Size = new System.Drawing.Size(97, 13);
            this.labAltNome.TabIndex = 10;
            this.labAltNome.Text = "Nome da Empresa:";
            // 
            // labAltTelefone
            // 
            this.labAltTelefone.AutoSize = true;
            this.labAltTelefone.Location = new System.Drawing.Point(162, 118);
            this.labAltTelefone.Name = "labAltTelefone";
            this.labAltTelefone.Size = new System.Drawing.Size(52, 13);
            this.labAltTelefone.TabIndex = 12;
            this.labAltTelefone.Text = "Telefone:";
            // 
            // txtAltTelefone
            // 
            this.txtAltTelefone.Location = new System.Drawing.Point(220, 115);
            this.txtAltTelefone.Name = "txtAltTelefone";
            this.txtAltTelefone.Size = new System.Drawing.Size(152, 20);
            this.txtAltTelefone.TabIndex = 7;
            // 
            // txtAltNome
            // 
            this.txtAltNome.Location = new System.Drawing.Point(220, 55);
            this.txtAltNome.Name = "txtAltNome";
            this.txtAltNome.Size = new System.Drawing.Size(239, 20);
            this.txtAltNome.TabIndex = 5;
            // 
            // labAltCnpj
            // 
            this.labAltCnpj.AutoSize = true;
            this.labAltCnpj.Location = new System.Drawing.Point(177, 88);
            this.labAltCnpj.Name = "labAltCnpj";
            this.labAltCnpj.Size = new System.Drawing.Size(37, 13);
            this.labAltCnpj.TabIndex = 11;
            this.labAltCnpj.Text = "CNPJ:";
            // 
            // txtAltCnpj
            // 
            this.txtAltCnpj.Location = new System.Drawing.Point(220, 85);
            this.txtAltCnpj.Name = "txtAltCnpj";
            this.txtAltCnpj.Size = new System.Drawing.Size(152, 20);
            this.txtAltCnpj.TabIndex = 6;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(15, 342);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(266, 71);
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(15, 419);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(266, 71);
            this.btnAlterar.TabIndex = 17;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(15, 496);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(266, 71);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // TelaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 645);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gbAlterar);
            this.Controls.Add(this.gbCadastrar);
            this.Controls.Add(this.btnListarTodos);
            this.Controls.Add(this.labBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvMarca);
            this.Name = "TelaMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaMarca";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            this.gbCadastrar.ResumeLayout(false);
            this.gbCadastrar.PerformLayout();
            this.gbAlterar.ResumeLayout(false);
            this.gbAlterar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarca;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label labBuscar;
        private System.Windows.Forms.Button btnListarTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpj_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco_col;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtCadNome;
        private System.Windows.Forms.TextBox txtCadCnpj;
        private System.Windows.Forms.TextBox txtCadTelefone;
        private System.Windows.Forms.TextBox txtCadEndereco;
        private System.Windows.Forms.Label labCadId;
        private System.Windows.Forms.Label labCadNome;
        private System.Windows.Forms.Label labCadCnpj;
        private System.Windows.Forms.Label labCadTelefone;
        private System.Windows.Forms.Label labCadEndereco;
        private System.Windows.Forms.Button btnCadEnviar;
        private System.Windows.Forms.GroupBox gbCadastrar;
        private System.Windows.Forms.GroupBox gbAlterar;
        private System.Windows.Forms.Label labAltId;
        private System.Windows.Forms.Button btnAltEnviar;
        private System.Windows.Forms.TextBox txtAltId;
        private System.Windows.Forms.TextBox txtAltEndereco;
        private System.Windows.Forms.Label labAltEndereco;
        private System.Windows.Forms.Label labAltNome;
        private System.Windows.Forms.Label labAltTelefone;
        private System.Windows.Forms.TextBox txtAltTelefone;
        private System.Windows.Forms.TextBox txtAltNome;
        private System.Windows.Forms.Label labAltCnpj;
        private System.Windows.Forms.TextBox txtAltCnpj;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
    }
}