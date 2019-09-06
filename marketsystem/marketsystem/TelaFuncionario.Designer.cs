namespace marketsystem
{
    partial class TelaFuncionario
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
            this.dgvFunc = new System.Windows.Forms.DataGridView();
            this.id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNasc_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.labNome = new System.Windows.Forms.Label();
            this.labCargo = new System.Windows.Forms.Label();
            this.labEndereco = new System.Windows.Forms.Label();
            this.labTelefone = new System.Windows.Forms.Label();
            this.labData_nasc = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtData_nasc = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.gbCadastrar = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.gbAlterar = new System.Windows.Forms.GroupBox();
            this.labAltId = new System.Windows.Forms.Label();
            this.btnAltEnviar = new System.Windows.Forms.Button();
            this.txtAltId = new System.Windows.Forms.TextBox();
            this.labAltData_nasc = new System.Windows.Forms.Label();
            this.txtAltEndereco = new System.Windows.Forms.TextBox();
            this.labAltTelefone = new System.Windows.Forms.Label();
            this.labAltNome = new System.Windows.Forms.Label();
            this.txtAltTelefone = new System.Windows.Forms.TextBox();
            this.txtAltData_nasc = new System.Windows.Forms.TextBox();
            this.txtAltNome = new System.Windows.Forms.TextBox();
            this.txtAltCargo = new System.Windows.Forms.TextBox();
            this.labAltEndereco = new System.Windows.Forms.Label();
            this.labAltCargo = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.labBuscar = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).BeginInit();
            this.gbCadastrar.SuspendLayout();
            this.gbAlterar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFunc
            // 
            this.dgvFunc.AllowUserToAddRows = false;
            this.dgvFunc.AllowUserToDeleteRows = false;
            this.dgvFunc.AllowUserToResizeRows = false;
            this.dgvFunc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_col,
            this.nome_col,
            this.cargo_col,
            this.endereco_col,
            this.telefone_col,
            this.dataNasc_col});
            this.dgvFunc.Location = new System.Drawing.Point(12, 51);
            this.dgvFunc.Name = "dgvFunc";
            this.dgvFunc.ReadOnly = true;
            this.dgvFunc.RowHeadersVisible = false;
            this.dgvFunc.RowHeadersWidth = 40;
            this.dgvFunc.RowTemplate.Height = 20;
            this.dgvFunc.RowTemplate.ReadOnly = true;
            this.dgvFunc.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFunc.Size = new System.Drawing.Size(884, 271);
            this.dgvFunc.TabIndex = 0;
            this.dgvFunc.SelectionChanged += new System.EventHandler(this.dgvFunc_SelectionChanged);
            // 
            // id_col
            // 
            this.id_col.DataPropertyName = "id";
            this.id_col.HeaderText = "ID";
            this.id_col.MinimumWidth = 10;
            this.id_col.Name = "id_col";
            this.id_col.ReadOnly = true;
            this.id_col.Width = 30;
            // 
            // nome_col
            // 
            this.nome_col.DataPropertyName = "nome";
            this.nome_col.HeaderText = "Nome";
            this.nome_col.MinimumWidth = 150;
            this.nome_col.Name = "nome_col";
            this.nome_col.ReadOnly = true;
            this.nome_col.Width = 190;
            // 
            // cargo_col
            // 
            this.cargo_col.DataPropertyName = "cargo";
            this.cargo_col.HeaderText = "Cargo";
            this.cargo_col.MinimumWidth = 150;
            this.cargo_col.Name = "cargo_col";
            this.cargo_col.ReadOnly = true;
            this.cargo_col.Width = 150;
            // 
            // endereco_col
            // 
            this.endereco_col.DataPropertyName = "endereco";
            this.endereco_col.HeaderText = "Endereço";
            this.endereco_col.MinimumWidth = 200;
            this.endereco_col.Name = "endereco_col";
            this.endereco_col.ReadOnly = true;
            this.endereco_col.Width = 300;
            // 
            // telefone_col
            // 
            this.telefone_col.DataPropertyName = "telefone";
            this.telefone_col.HeaderText = "Telefone";
            this.telefone_col.MinimumWidth = 100;
            this.telefone_col.Name = "telefone_col";
            this.telefone_col.ReadOnly = true;
            // 
            // dataNasc_col
            // 
            this.dataNasc_col.DataPropertyName = "data_nasc";
            this.dataNasc_col.HeaderText = "Data de Nascimento";
            this.dataNasc_col.MinimumWidth = 100;
            this.dataNasc_col.Name = "dataNasc_col";
            this.dataNasc_col.ReadOnly = true;
            this.dataNasc_col.Width = 110;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(759, 23);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(137, 23);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar todos";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(132, 215);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(134, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // labNome
            // 
            this.labNome.AutoSize = true;
            this.labNome.Location = new System.Drawing.Point(46, 41);
            this.labNome.Name = "labNome";
            this.labNome.Size = new System.Drawing.Size(84, 13);
            this.labNome.TabIndex = 3;
            this.labNome.Text = "Nome completo:";
            // 
            // labCargo
            // 
            this.labCargo.AutoSize = true;
            this.labCargo.Location = new System.Drawing.Point(92, 76);
            this.labCargo.Name = "labCargo";
            this.labCargo.Size = new System.Drawing.Size(38, 13);
            this.labCargo.TabIndex = 4;
            this.labCargo.Text = "Cargo:";
            // 
            // labEndereco
            // 
            this.labEndereco.AutoSize = true;
            this.labEndereco.Location = new System.Drawing.Point(74, 111);
            this.labEndereco.Name = "labEndereco";
            this.labEndereco.Size = new System.Drawing.Size(56, 13);
            this.labEndereco.TabIndex = 5;
            this.labEndereco.Text = "Endereço:";
            // 
            // labTelefone
            // 
            this.labTelefone.AutoSize = true;
            this.labTelefone.Location = new System.Drawing.Point(78, 147);
            this.labTelefone.Name = "labTelefone";
            this.labTelefone.Size = new System.Drawing.Size(52, 13);
            this.labTelefone.TabIndex = 6;
            this.labTelefone.Text = "Telefone:";
            // 
            // labData_nasc
            // 
            this.labData_nasc.AutoSize = true;
            this.labData_nasc.Location = new System.Drawing.Point(23, 181);
            this.labData_nasc.Name = "labData_nasc";
            this.labData_nasc.Size = new System.Drawing.Size(107, 13);
            this.labData_nasc.TabIndex = 7;
            this.labData_nasc.Text = "Data de Nascimento:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(132, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(208, 20);
            this.txtNome.TabIndex = 8;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(132, 73);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(208, 20);
            this.txtCargo.TabIndex = 9;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(132, 144);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(134, 20);
            this.txtTelefone.TabIndex = 10;
            // 
            // txtData_nasc
            // 
            this.txtData_nasc.Location = new System.Drawing.Point(132, 181);
            this.txtData_nasc.Name = "txtData_nasc";
            this.txtData_nasc.Size = new System.Drawing.Size(134, 20);
            this.txtData_nasc.TabIndex = 10;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(132, 111);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(351, 20);
            this.txtEndereco.TabIndex = 10;
            // 
            // gbCadastrar
            // 
            this.gbCadastrar.Controls.Add(this.btnEnviar);
            this.gbCadastrar.Controls.Add(this.labData_nasc);
            this.gbCadastrar.Controls.Add(this.txtEndereco);
            this.gbCadastrar.Controls.Add(this.labTelefone);
            this.gbCadastrar.Controls.Add(this.labNome);
            this.gbCadastrar.Controls.Add(this.txtTelefone);
            this.gbCadastrar.Controls.Add(this.txtData_nasc);
            this.gbCadastrar.Controls.Add(this.txtNome);
            this.gbCadastrar.Controls.Add(this.txtCargo);
            this.gbCadastrar.Controls.Add(this.labEndereco);
            this.gbCadastrar.Controls.Add(this.labCargo);
            this.gbCadastrar.Location = new System.Drawing.Point(253, 328);
            this.gbCadastrar.Name = "gbCadastrar";
            this.gbCadastrar.Size = new System.Drawing.Size(643, 252);
            this.gbCadastrar.TabIndex = 11;
            this.gbCadastrar.TabStop = false;
            this.gbCadastrar.Text = "Cadastrar";
            this.gbCadastrar.Visible = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(39, 335);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(201, 50);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar Funcionário";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(39, 391);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(201, 50);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // gbAlterar
            // 
            this.gbAlterar.Controls.Add(this.labAltId);
            this.gbAlterar.Controls.Add(this.btnAltEnviar);
            this.gbAlterar.Controls.Add(this.txtAltId);
            this.gbAlterar.Controls.Add(this.labAltData_nasc);
            this.gbAlterar.Controls.Add(this.txtAltEndereco);
            this.gbAlterar.Controls.Add(this.labAltTelefone);
            this.gbAlterar.Controls.Add(this.labAltNome);
            this.gbAlterar.Controls.Add(this.txtAltTelefone);
            this.gbAlterar.Controls.Add(this.txtAltData_nasc);
            this.gbAlterar.Controls.Add(this.txtAltNome);
            this.gbAlterar.Controls.Add(this.txtAltCargo);
            this.gbAlterar.Controls.Add(this.labAltEndereco);
            this.gbAlterar.Controls.Add(this.labAltCargo);
            this.gbAlterar.Location = new System.Drawing.Point(253, 328);
            this.gbAlterar.Name = "gbAlterar";
            this.gbAlterar.Size = new System.Drawing.Size(643, 252);
            this.gbAlterar.TabIndex = 11;
            this.gbAlterar.TabStop = false;
            this.gbAlterar.Text = "Alterar";
            this.gbAlterar.Visible = false;
            // 
            // labAltId
            // 
            this.labAltId.AutoSize = true;
            this.labAltId.Location = new System.Drawing.Point(109, 15);
            this.labAltId.Name = "labAltId";
            this.labAltId.Size = new System.Drawing.Size(21, 13);
            this.labAltId.TabIndex = 17;
            this.labAltId.Text = "ID:";
            // 
            // btnAltEnviar
            // 
            this.btnAltEnviar.Location = new System.Drawing.Point(132, 216);
            this.btnAltEnviar.Name = "btnAltEnviar";
            this.btnAltEnviar.Size = new System.Drawing.Size(134, 23);
            this.btnAltEnviar.TabIndex = 2;
            this.btnAltEnviar.Text = "Enviar";
            this.btnAltEnviar.UseVisualStyleBackColor = true;
            this.btnAltEnviar.Click += new System.EventHandler(this.btnAltEnviar_Click);
            // 
            // txtAltId
            // 
            this.txtAltId.BackColor = System.Drawing.SystemColors.Info;
            this.txtAltId.Location = new System.Drawing.Point(132, 12);
            this.txtAltId.Name = "txtAltId";
            this.txtAltId.ReadOnly = true;
            this.txtAltId.Size = new System.Drawing.Size(74, 20);
            this.txtAltId.TabIndex = 11;
            this.txtAltId.TextChanged += new System.EventHandler(this.txtBuscaId_TextChanged);
            // 
            // labAltData_nasc
            // 
            this.labAltData_nasc.AutoSize = true;
            this.labAltData_nasc.Location = new System.Drawing.Point(23, 184);
            this.labAltData_nasc.Name = "labAltData_nasc";
            this.labAltData_nasc.Size = new System.Drawing.Size(107, 13);
            this.labAltData_nasc.TabIndex = 7;
            this.labAltData_nasc.Text = "Data de Nascimento:";
            // 
            // txtAltEndereco
            // 
            this.txtAltEndereco.Location = new System.Drawing.Point(132, 114);
            this.txtAltEndereco.Name = "txtAltEndereco";
            this.txtAltEndereco.Size = new System.Drawing.Size(351, 20);
            this.txtAltEndereco.TabIndex = 10;
            // 
            // labAltTelefone
            // 
            this.labAltTelefone.AutoSize = true;
            this.labAltTelefone.Location = new System.Drawing.Point(78, 150);
            this.labAltTelefone.Name = "labAltTelefone";
            this.labAltTelefone.Size = new System.Drawing.Size(52, 13);
            this.labAltTelefone.TabIndex = 6;
            this.labAltTelefone.Text = "Telefone:";
            // 
            // labAltNome
            // 
            this.labAltNome.AutoSize = true;
            this.labAltNome.Location = new System.Drawing.Point(46, 44);
            this.labAltNome.Name = "labAltNome";
            this.labAltNome.Size = new System.Drawing.Size(84, 13);
            this.labAltNome.TabIndex = 3;
            this.labAltNome.Text = "Nome completo:";
            // 
            // txtAltTelefone
            // 
            this.txtAltTelefone.Location = new System.Drawing.Point(132, 147);
            this.txtAltTelefone.Name = "txtAltTelefone";
            this.txtAltTelefone.Size = new System.Drawing.Size(134, 20);
            this.txtAltTelefone.TabIndex = 10;
            // 
            // txtAltData_nasc
            // 
            this.txtAltData_nasc.Location = new System.Drawing.Point(132, 184);
            this.txtAltData_nasc.Name = "txtAltData_nasc";
            this.txtAltData_nasc.Size = new System.Drawing.Size(134, 20);
            this.txtAltData_nasc.TabIndex = 10;
            // 
            // txtAltNome
            // 
            this.txtAltNome.Location = new System.Drawing.Point(132, 41);
            this.txtAltNome.Name = "txtAltNome";
            this.txtAltNome.Size = new System.Drawing.Size(208, 20);
            this.txtAltNome.TabIndex = 8;
            // 
            // txtAltCargo
            // 
            this.txtAltCargo.Location = new System.Drawing.Point(132, 76);
            this.txtAltCargo.Name = "txtAltCargo";
            this.txtAltCargo.Size = new System.Drawing.Size(208, 20);
            this.txtAltCargo.TabIndex = 9;
            // 
            // labAltEndereco
            // 
            this.labAltEndereco.AutoSize = true;
            this.labAltEndereco.Location = new System.Drawing.Point(74, 114);
            this.labAltEndereco.Name = "labAltEndereco";
            this.labAltEndereco.Size = new System.Drawing.Size(56, 13);
            this.labAltEndereco.TabIndex = 5;
            this.labAltEndereco.Text = "Endereço:";
            // 
            // labAltCargo
            // 
            this.labAltCargo.AutoSize = true;
            this.labAltCargo.Location = new System.Drawing.Point(92, 79);
            this.labAltCargo.Name = "labAltCargo";
            this.labAltCargo.Size = new System.Drawing.Size(38, 13);
            this.labAltCargo.TabIndex = 4;
            this.labAltCargo.Text = "Cargo:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Info;
            this.txtBuscar.Location = new System.Drawing.Point(12, 25);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(741, 20);
            this.txtBuscar.TabIndex = 14;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // labBuscar
            // 
            this.labBuscar.AutoSize = true;
            this.labBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBuscar.Location = new System.Drawing.Point(9, 9);
            this.labBuscar.Name = "labBuscar";
            this.labBuscar.Size = new System.Drawing.Size(40, 13);
            this.labBuscar.TabIndex = 15;
            this.labBuscar.Text = "Buscar";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(39, 447);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(201, 50);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluír";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // TelaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 592);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.labBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvFunc);
            this.Controls.Add(this.gbAlterar);
            this.Controls.Add(this.gbCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaFuncionario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaFuncionario_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).EndInit();
            this.gbCadastrar.ResumeLayout(false);
            this.gbCadastrar.PerformLayout();
            this.gbAlterar.ResumeLayout(false);
            this.gbAlterar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFunc;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label labNome;
        private System.Windows.Forms.Label labCargo;
        private System.Windows.Forms.Label labEndereco;
        private System.Windows.Forms.Label labTelefone;
        private System.Windows.Forms.Label labData_nasc;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtData_nasc;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.GroupBox gbCadastrar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.GroupBox gbAlterar;
        private System.Windows.Forms.Button btnAltEnviar;
        private System.Windows.Forms.Label labAltData_nasc;
        private System.Windows.Forms.TextBox txtAltEndereco;
        private System.Windows.Forms.Label labAltTelefone;
        private System.Windows.Forms.Label labAltNome;
        private System.Windows.Forms.TextBox txtAltTelefone;
        private System.Windows.Forms.TextBox txtAltData_nasc;
        private System.Windows.Forms.TextBox txtAltNome;
        private System.Windows.Forms.TextBox txtAltCargo;
        private System.Windows.Forms.Label labAltEndereco;
        private System.Windows.Forms.Label labAltCargo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label labBuscar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtAltId;
        private System.Windows.Forms.Label labAltId;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNasc_col;
    }
}