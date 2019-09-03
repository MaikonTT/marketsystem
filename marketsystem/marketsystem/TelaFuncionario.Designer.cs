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
            this.btnAltEnviar = new System.Windows.Forms.Button();
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
            this.txtBuscaId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dgvFunc.Location = new System.Drawing.Point(12, 51);
            this.dgvFunc.Name = "dgvFunc";
            this.dgvFunc.ReadOnly = true;
            this.dgvFunc.RowHeadersVisible = false;
            this.dgvFunc.RowHeadersWidth = 40;
            this.dgvFunc.RowTemplate.Height = 15;
            this.dgvFunc.RowTemplate.ReadOnly = true;
            this.dgvFunc.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFunc.Size = new System.Drawing.Size(884, 271);
            this.dgvFunc.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(759, 25);
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
            this.btnCadastrar.Size = new System.Drawing.Size(201, 23);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar Funcionário";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(39, 394);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(201, 23);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // gbAlterar
            // 
            this.gbAlterar.Controls.Add(this.btnAltEnviar);
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
            // btnAltEnviar
            // 
            this.btnAltEnviar.Location = new System.Drawing.Point(132, 215);
            this.btnAltEnviar.Name = "btnAltEnviar";
            this.btnAltEnviar.Size = new System.Drawing.Size(134, 23);
            this.btnAltEnviar.TabIndex = 2;
            this.btnAltEnviar.Text = "Enviar";
            this.btnAltEnviar.UseVisualStyleBackColor = true;
            this.btnAltEnviar.Click += new System.EventHandler(this.btnAltEnviar_Click);
            // 
            // labAltData_nasc
            // 
            this.labAltData_nasc.AutoSize = true;
            this.labAltData_nasc.Location = new System.Drawing.Point(23, 181);
            this.labAltData_nasc.Name = "labAltData_nasc";
            this.labAltData_nasc.Size = new System.Drawing.Size(107, 13);
            this.labAltData_nasc.TabIndex = 7;
            this.labAltData_nasc.Text = "Data de Nascimento:";
            // 
            // txtAltEndereco
            // 
            this.txtAltEndereco.Location = new System.Drawing.Point(132, 111);
            this.txtAltEndereco.Name = "txtAltEndereco";
            this.txtAltEndereco.Size = new System.Drawing.Size(351, 20);
            this.txtAltEndereco.TabIndex = 10;
            // 
            // labAltTelefone
            // 
            this.labAltTelefone.AutoSize = true;
            this.labAltTelefone.Location = new System.Drawing.Point(78, 147);
            this.labAltTelefone.Name = "labAltTelefone";
            this.labAltTelefone.Size = new System.Drawing.Size(52, 13);
            this.labAltTelefone.TabIndex = 6;
            this.labAltTelefone.Text = "Telefone:";
            // 
            // labAltNome
            // 
            this.labAltNome.AutoSize = true;
            this.labAltNome.Location = new System.Drawing.Point(46, 41);
            this.labAltNome.Name = "labAltNome";
            this.labAltNome.Size = new System.Drawing.Size(84, 13);
            this.labAltNome.TabIndex = 3;
            this.labAltNome.Text = "Nome completo:";
            // 
            // txtAltTelefone
            // 
            this.txtAltTelefone.Location = new System.Drawing.Point(132, 144);
            this.txtAltTelefone.Name = "txtAltTelefone";
            this.txtAltTelefone.Size = new System.Drawing.Size(134, 20);
            this.txtAltTelefone.TabIndex = 10;
            // 
            // txtAltData_nasc
            // 
            this.txtAltData_nasc.Location = new System.Drawing.Point(132, 181);
            this.txtAltData_nasc.Name = "txtAltData_nasc";
            this.txtAltData_nasc.Size = new System.Drawing.Size(134, 20);
            this.txtAltData_nasc.TabIndex = 10;
            // 
            // txtAltNome
            // 
            this.txtAltNome.Location = new System.Drawing.Point(132, 38);
            this.txtAltNome.Name = "txtAltNome";
            this.txtAltNome.Size = new System.Drawing.Size(208, 20);
            this.txtAltNome.TabIndex = 8;
            // 
            // txtAltCargo
            // 
            this.txtAltCargo.Location = new System.Drawing.Point(132, 73);
            this.txtAltCargo.Name = "txtAltCargo";
            this.txtAltCargo.Size = new System.Drawing.Size(208, 20);
            this.txtAltCargo.TabIndex = 9;
            // 
            // labAltEndereco
            // 
            this.labAltEndereco.AutoSize = true;
            this.labAltEndereco.Location = new System.Drawing.Point(74, 111);
            this.labAltEndereco.Name = "labAltEndereco";
            this.labAltEndereco.Size = new System.Drawing.Size(56, 13);
            this.labAltEndereco.TabIndex = 5;
            this.labAltEndereco.Text = "Endereço:";
            // 
            // labAltCargo
            // 
            this.labAltCargo.AutoSize = true;
            this.labAltCargo.Location = new System.Drawing.Point(92, 76);
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
            this.btnExcluir.Location = new System.Drawing.Point(137, 364);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(103, 23);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluír";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtBuscaId
            // 
            this.txtBuscaId.BackColor = System.Drawing.SystemColors.Info;
            this.txtBuscaId.Location = new System.Drawing.Point(39, 366);
            this.txtBuscaId.Name = "txtBuscaId";
            this.txtBuscaId.Size = new System.Drawing.Size(92, 20);
            this.txtBuscaId.TabIndex = 11;
            this.txtBuscaId.TextChanged += new System.EventHandler(this.txtBuscaId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID:";
            // 
            // TelaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 592);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscaId);
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
        private System.Windows.Forms.TextBox txtBuscaId;
        private System.Windows.Forms.Label label1;
    }
}