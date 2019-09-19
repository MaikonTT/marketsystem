namespace marketsystem
{
    partial class TelaProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.labBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.labCargo = new System.Windows.Forms.Label();
            this.labEndereco = new System.Windows.Forms.Label();
            this.txtCadPeso = new System.Windows.Forms.TextBox();
            this.txtCadDescri = new System.Windows.Forms.TextBox();
            this.txtCadValVend = new System.Windows.Forms.TextBox();
            this.txtCadValCust = new System.Windows.Forms.TextBox();
            this.labNome = new System.Windows.Forms.Label();
            this.labTelefone = new System.Windows.Forms.Label();
            this.txtCadQuant = new System.Windows.Forms.TextBox();
            this.labData_nasc = new System.Windows.Forms.Label();
            this.btnCadEnviar = new System.Windows.Forms.Button();
            this.cbCadMarca = new System.Windows.Forms.ComboBox();
            this.labCadMarca = new System.Windows.Forms.Label();
            this.gbCadastrar = new System.Windows.Forms.GroupBox();
            this.gbAlterar = new System.Windows.Forms.GroupBox();
            this.labAltId = new System.Windows.Forms.Label();
            this.txtAltId = new System.Windows.Forms.TextBox();
            this.labAltMarca = new System.Windows.Forms.Label();
            this.cbAltMarca = new System.Windows.Forms.ComboBox();
            this.btnAltEnviar = new System.Windows.Forms.Button();
            this.labAltValVend = new System.Windows.Forms.Label();
            this.txtAltQuant = new System.Windows.Forms.TextBox();
            this.labAltValCust = new System.Windows.Forms.Label();
            this.labAltDesc = new System.Windows.Forms.Label();
            this.txtAltValCust = new System.Windows.Forms.TextBox();
            this.txtAltValVend = new System.Windows.Forms.TextBox();
            this.txtAltDesc = new System.Windows.Forms.TextBox();
            this.txtAltPeso = new System.Windows.Forms.TextBox();
            this.labAltQuant = new System.Windows.Forms.Label();
            this.labAltPeso = new System.Windows.Forms.Label();
            this.id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quant_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valcust_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valvend_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.gbCadastrar.SuspendLayout();
            this.gbAlterar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(12, 386);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(228, 50);
            this.btnAlterar.TabIndex = 24;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 330);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(228, 50);
            this.btnCadastrar.TabIndex = 23;
            this.btnCadastrar.Text = "Cadastrar Produto";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(12, 442);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(228, 50);
            this.btnExcluir.TabIndex = 27;
            this.btnExcluir.Text = "Excluír";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // labBuscar
            // 
            this.labBuscar.AutoSize = true;
            this.labBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBuscar.Location = new System.Drawing.Point(9, 7);
            this.labBuscar.Name = "labBuscar";
            this.labBuscar.Size = new System.Drawing.Size(40, 13);
            this.labBuscar.TabIndex = 26;
            this.labBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Info;
            this.txtBuscar.Location = new System.Drawing.Point(12, 23);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(741, 20);
            this.txtBuscar.TabIndex = 25;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(759, 23);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(137, 23);
            this.btnListar.TabIndex = 19;
            this.btnListar.Text = "Listar todos";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvProd
            // 
            this.dgvProd.AllowUserToAddRows = false;
            this.dgvProd.AllowUserToDeleteRows = false;
            this.dgvProd.AllowUserToResizeRows = false;
            this.dgvProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_col,
            this.desc_col,
            this.marca_col,
            this.peso_col,
            this.quant_col,
            this.valcust_col,
            this.valvend_col});
            this.dgvProd.Location = new System.Drawing.Point(12, 49);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.ReadOnly = true;
            this.dgvProd.RowHeadersVisible = false;
            this.dgvProd.RowHeadersWidth = 40;
            this.dgvProd.RowTemplate.Height = 15;
            this.dgvProd.RowTemplate.ReadOnly = true;
            this.dgvProd.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProd.Size = new System.Drawing.Size(884, 271);
            this.dgvProd.TabIndex = 18;
            // 
            // labCargo
            // 
            this.labCargo.AutoSize = true;
            this.labCargo.Location = new System.Drawing.Point(92, 106);
            this.labCargo.Name = "labCargo";
            this.labCargo.Size = new System.Drawing.Size(34, 13);
            this.labCargo.TabIndex = 4;
            this.labCargo.Text = "Peso:";
            // 
            // labEndereco
            // 
            this.labEndereco.AutoSize = true;
            this.labEndereco.Location = new System.Drawing.Point(61, 134);
            this.labEndereco.Name = "labEndereco";
            this.labEndereco.Size = new System.Drawing.Size(65, 13);
            this.labEndereco.TabIndex = 5;
            this.labEndereco.Text = "Quantidade:";
            // 
            // txtCadPeso
            // 
            this.txtCadPeso.Location = new System.Drawing.Point(132, 103);
            this.txtCadPeso.Name = "txtCadPeso";
            this.txtCadPeso.Size = new System.Drawing.Size(134, 20);
            this.txtCadPeso.TabIndex = 9;
            // 
            // txtCadDescri
            // 
            this.txtCadDescri.Location = new System.Drawing.Point(132, 38);
            this.txtCadDescri.Name = "txtCadDescri";
            this.txtCadDescri.Size = new System.Drawing.Size(271, 20);
            this.txtCadDescri.TabIndex = 8;
            // 
            // txtCadValVend
            // 
            this.txtCadValVend.Location = new System.Drawing.Point(132, 189);
            this.txtCadValVend.Name = "txtCadValVend";
            this.txtCadValVend.Size = new System.Drawing.Size(134, 20);
            this.txtCadValVend.TabIndex = 10;
            // 
            // txtCadValCust
            // 
            this.txtCadValCust.Location = new System.Drawing.Point(132, 161);
            this.txtCadValCust.Name = "txtCadValCust";
            this.txtCadValCust.Size = new System.Drawing.Size(134, 20);
            this.txtCadValCust.TabIndex = 10;
            // 
            // labNome
            // 
            this.labNome.AutoSize = true;
            this.labNome.Location = new System.Drawing.Point(17, 41);
            this.labNome.Name = "labNome";
            this.labNome.Size = new System.Drawing.Size(113, 13);
            this.labNome.TabIndex = 3;
            this.labNome.Text = "Descrição do Produto:";
            // 
            // labTelefone
            // 
            this.labTelefone.AutoSize = true;
            this.labTelefone.Location = new System.Drawing.Point(46, 164);
            this.labTelefone.Name = "labTelefone";
            this.labTelefone.Size = new System.Drawing.Size(79, 13);
            this.labTelefone.TabIndex = 6;
            this.labTelefone.Text = "Valor de Custo:";
            // 
            // txtCadQuant
            // 
            this.txtCadQuant.Location = new System.Drawing.Point(132, 131);
            this.txtCadQuant.Name = "txtCadQuant";
            this.txtCadQuant.Size = new System.Drawing.Size(134, 20);
            this.txtCadQuant.TabIndex = 10;
            // 
            // labData_nasc
            // 
            this.labData_nasc.AutoSize = true;
            this.labData_nasc.Location = new System.Drawing.Point(42, 192);
            this.labData_nasc.Name = "labData_nasc";
            this.labData_nasc.Size = new System.Drawing.Size(83, 13);
            this.labData_nasc.TabIndex = 7;
            this.labData_nasc.Text = "Valor de Venda:";
            // 
            // btnCadEnviar
            // 
            this.btnCadEnviar.Location = new System.Drawing.Point(132, 215);
            this.btnCadEnviar.Name = "btnCadEnviar";
            this.btnCadEnviar.Size = new System.Drawing.Size(134, 23);
            this.btnCadEnviar.TabIndex = 2;
            this.btnCadEnviar.Text = "Enviar";
            this.btnCadEnviar.UseVisualStyleBackColor = true;
            this.btnCadEnviar.Click += new System.EventHandler(this.btnCadEnviar_Click);
            // 
            // cbCadMarca
            // 
            this.cbCadMarca.FormattingEnabled = true;
            this.cbCadMarca.Location = new System.Drawing.Point(132, 68);
            this.cbCadMarca.Name = "cbCadMarca";
            this.cbCadMarca.Size = new System.Drawing.Size(134, 21);
            this.cbCadMarca.TabIndex = 11;
            // 
            // labCadMarca
            // 
            this.labCadMarca.AutoSize = true;
            this.labCadMarca.Location = new System.Drawing.Point(86, 71);
            this.labCadMarca.Name = "labCadMarca";
            this.labCadMarca.Size = new System.Drawing.Size(40, 13);
            this.labCadMarca.TabIndex = 12;
            this.labCadMarca.Text = "Marca:";
            // 
            // gbCadastrar
            // 
            this.gbCadastrar.Controls.Add(this.labCadMarca);
            this.gbCadastrar.Controls.Add(this.cbCadMarca);
            this.gbCadastrar.Controls.Add(this.btnCadEnviar);
            this.gbCadastrar.Controls.Add(this.labData_nasc);
            this.gbCadastrar.Controls.Add(this.txtCadQuant);
            this.gbCadastrar.Controls.Add(this.labTelefone);
            this.gbCadastrar.Controls.Add(this.labNome);
            this.gbCadastrar.Controls.Add(this.txtCadValCust);
            this.gbCadastrar.Controls.Add(this.txtCadValVend);
            this.gbCadastrar.Controls.Add(this.txtCadDescri);
            this.gbCadastrar.Controls.Add(this.txtCadPeso);
            this.gbCadastrar.Controls.Add(this.labEndereco);
            this.gbCadastrar.Controls.Add(this.labCargo);
            this.gbCadastrar.Location = new System.Drawing.Point(253, 326);
            this.gbCadastrar.Name = "gbCadastrar";
            this.gbCadastrar.Size = new System.Drawing.Size(643, 252);
            this.gbCadastrar.TabIndex = 21;
            this.gbCadastrar.TabStop = false;
            this.gbCadastrar.Text = "Cadastrar";
            this.gbCadastrar.Visible = false;
            // 
            // gbAlterar
            // 
            this.gbAlterar.Controls.Add(this.labAltId);
            this.gbAlterar.Controls.Add(this.txtAltId);
            this.gbAlterar.Controls.Add(this.labAltMarca);
            this.gbAlterar.Controls.Add(this.cbAltMarca);
            this.gbAlterar.Controls.Add(this.btnAltEnviar);
            this.gbAlterar.Controls.Add(this.labAltValVend);
            this.gbAlterar.Controls.Add(this.txtAltQuant);
            this.gbAlterar.Controls.Add(this.labAltValCust);
            this.gbAlterar.Controls.Add(this.labAltDesc);
            this.gbAlterar.Controls.Add(this.txtAltValCust);
            this.gbAlterar.Controls.Add(this.txtAltValVend);
            this.gbAlterar.Controls.Add(this.txtAltDesc);
            this.gbAlterar.Controls.Add(this.txtAltPeso);
            this.gbAlterar.Controls.Add(this.labAltQuant);
            this.gbAlterar.Controls.Add(this.labAltPeso);
            this.gbAlterar.Location = new System.Drawing.Point(253, 326);
            this.gbAlterar.Name = "gbAlterar";
            this.gbAlterar.Size = new System.Drawing.Size(643, 252);
            this.gbAlterar.TabIndex = 28;
            this.gbAlterar.TabStop = false;
            this.gbAlterar.Text = "Alterar";
            this.gbAlterar.Visible = false;
            // 
            // labAltId
            // 
            this.labAltId.AutoSize = true;
            this.labAltId.Location = new System.Drawing.Point(105, 16);
            this.labAltId.Name = "labAltId";
            this.labAltId.Size = new System.Drawing.Size(21, 13);
            this.labAltId.TabIndex = 14;
            this.labAltId.Text = "ID:";
            // 
            // txtAltId
            // 
            this.txtAltId.BackColor = System.Drawing.SystemColors.Info;
            this.txtAltId.Location = new System.Drawing.Point(132, 12);
            this.txtAltId.Name = "txtAltId";
            this.txtAltId.Size = new System.Drawing.Size(81, 20);
            this.txtAltId.TabIndex = 13;
            // 
            // labAltMarca
            // 
            this.labAltMarca.AutoSize = true;
            this.labAltMarca.Location = new System.Drawing.Point(86, 71);
            this.labAltMarca.Name = "labAltMarca";
            this.labAltMarca.Size = new System.Drawing.Size(40, 13);
            this.labAltMarca.TabIndex = 12;
            this.labAltMarca.Text = "Marca:";
            // 
            // cbAltMarca
            // 
            this.cbAltMarca.FormattingEnabled = true;
            this.cbAltMarca.Location = new System.Drawing.Point(132, 68);
            this.cbAltMarca.Name = "cbAltMarca";
            this.cbAltMarca.Size = new System.Drawing.Size(134, 21);
            this.cbAltMarca.Sorted = true;
            this.cbAltMarca.TabIndex = 11;
            // 
            // btnAltEnviar
            // 
            this.btnAltEnviar.Location = new System.Drawing.Point(132, 215);
            this.btnAltEnviar.Name = "btnAltEnviar";
            this.btnAltEnviar.Size = new System.Drawing.Size(134, 23);
            this.btnAltEnviar.TabIndex = 2;
            this.btnAltEnviar.Text = "Enviar";
            this.btnAltEnviar.UseVisualStyleBackColor = true;
            // 
            // labAltValVend
            // 
            this.labAltValVend.AutoSize = true;
            this.labAltValVend.Location = new System.Drawing.Point(42, 192);
            this.labAltValVend.Name = "labAltValVend";
            this.labAltValVend.Size = new System.Drawing.Size(83, 13);
            this.labAltValVend.TabIndex = 7;
            this.labAltValVend.Text = "Valor de Venda:";
            // 
            // txtAltQuant
            // 
            this.txtAltQuant.Location = new System.Drawing.Point(132, 131);
            this.txtAltQuant.Name = "txtAltQuant";
            this.txtAltQuant.Size = new System.Drawing.Size(134, 20);
            this.txtAltQuant.TabIndex = 10;
            // 
            // labAltValCust
            // 
            this.labAltValCust.AutoSize = true;
            this.labAltValCust.Location = new System.Drawing.Point(46, 164);
            this.labAltValCust.Name = "labAltValCust";
            this.labAltValCust.Size = new System.Drawing.Size(79, 13);
            this.labAltValCust.TabIndex = 6;
            this.labAltValCust.Text = "Valor de Custo:";
            // 
            // labAltDesc
            // 
            this.labAltDesc.AutoSize = true;
            this.labAltDesc.Location = new System.Drawing.Point(12, 41);
            this.labAltDesc.Name = "labAltDesc";
            this.labAltDesc.Size = new System.Drawing.Size(113, 13);
            this.labAltDesc.TabIndex = 3;
            this.labAltDesc.Text = "Descrição do Produto:";
            // 
            // txtAltValCust
            // 
            this.txtAltValCust.Location = new System.Drawing.Point(132, 161);
            this.txtAltValCust.Name = "txtAltValCust";
            this.txtAltValCust.Size = new System.Drawing.Size(134, 20);
            this.txtAltValCust.TabIndex = 10;
            // 
            // txtAltValVend
            // 
            this.txtAltValVend.Location = new System.Drawing.Point(132, 189);
            this.txtAltValVend.Name = "txtAltValVend";
            this.txtAltValVend.Size = new System.Drawing.Size(134, 20);
            this.txtAltValVend.TabIndex = 10;
            // 
            // txtAltDesc
            // 
            this.txtAltDesc.Location = new System.Drawing.Point(132, 38);
            this.txtAltDesc.Name = "txtAltDesc";
            this.txtAltDesc.Size = new System.Drawing.Size(271, 20);
            this.txtAltDesc.TabIndex = 8;
            // 
            // txtAltPeso
            // 
            this.txtAltPeso.Location = new System.Drawing.Point(132, 103);
            this.txtAltPeso.Name = "txtAltPeso";
            this.txtAltPeso.Size = new System.Drawing.Size(134, 20);
            this.txtAltPeso.TabIndex = 9;
            // 
            // labAltQuant
            // 
            this.labAltQuant.AutoSize = true;
            this.labAltQuant.Location = new System.Drawing.Point(61, 134);
            this.labAltQuant.Name = "labAltQuant";
            this.labAltQuant.Size = new System.Drawing.Size(65, 13);
            this.labAltQuant.TabIndex = 5;
            this.labAltQuant.Text = "Quantidade:";
            // 
            // labAltPeso
            // 
            this.labAltPeso.AutoSize = true;
            this.labAltPeso.Location = new System.Drawing.Point(92, 106);
            this.labAltPeso.Name = "labAltPeso";
            this.labAltPeso.Size = new System.Drawing.Size(34, 13);
            this.labAltPeso.TabIndex = 4;
            this.labAltPeso.Text = "Peso:";
            // 
            // id_col
            // 
            this.id_col.DataPropertyName = "id";
            this.id_col.HeaderText = "ID";
            this.id_col.MinimumWidth = 80;
            this.id_col.Name = "id_col";
            this.id_col.ReadOnly = true;
            this.id_col.Width = 80;
            // 
            // desc_col
            // 
            this.desc_col.DataPropertyName = "descricao";
            this.desc_col.HeaderText = "Descrição do Produto";
            this.desc_col.MinimumWidth = 300;
            this.desc_col.Name = "desc_col";
            this.desc_col.ReadOnly = true;
            this.desc_col.Width = 300;
            // 
            // marca_col
            // 
            this.marca_col.DataPropertyName = "marca";
            this.marca_col.HeaderText = "Marca";
            this.marca_col.MinimumWidth = 125;
            this.marca_col.Name = "marca_col";
            this.marca_col.ReadOnly = true;
            this.marca_col.Width = 125;
            // 
            // peso_col
            // 
            this.peso_col.DataPropertyName = "peso";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.peso_col.DefaultCellStyle = dataGridViewCellStyle1;
            this.peso_col.HeaderText = "Peso";
            this.peso_col.MinimumWidth = 80;
            this.peso_col.Name = "peso_col";
            this.peso_col.ReadOnly = true;
            this.peso_col.Width = 88;
            // 
            // quant_col
            // 
            this.quant_col.DataPropertyName = "quantidade";
            this.quant_col.HeaderText = "Quantidade";
            this.quant_col.MinimumWidth = 80;
            this.quant_col.Name = "quant_col";
            this.quant_col.ReadOnly = true;
            this.quant_col.Width = 85;
            // 
            // valcust_col
            // 
            this.valcust_col.DataPropertyName = "val_custo";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.valcust_col.DefaultCellStyle = dataGridViewCellStyle2;
            this.valcust_col.HeaderText = "Valor de Custo";
            this.valcust_col.MinimumWidth = 100;
            this.valcust_col.Name = "valcust_col";
            this.valcust_col.ReadOnly = true;
            // 
            // valvend_col
            // 
            this.valvend_col.DataPropertyName = "val_venda";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.valvend_col.DefaultCellStyle = dataGridViewCellStyle3;
            this.valvend_col.HeaderText = "Valor de Venda";
            this.valvend_col.MinimumWidth = 100;
            this.valvend_col.Name = "valvend_col";
            this.valvend_col.ReadOnly = true;
            // 
            // TelaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 598);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.labBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvProd);
            this.Controls.Add(this.gbCadastrar);
            this.Controls.Add(this.gbAlterar);
            this.Name = "TelaProduto";
            this.Text = "Tela Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.gbCadastrar.ResumeLayout(false);
            this.gbCadastrar.PerformLayout();
            this.gbAlterar.ResumeLayout(false);
            this.gbAlterar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label labBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.Label labCargo;
        private System.Windows.Forms.Label labEndereco;
        private System.Windows.Forms.TextBox txtCadPeso;
        private System.Windows.Forms.TextBox txtCadDescri;
        private System.Windows.Forms.TextBox txtCadValVend;
        private System.Windows.Forms.TextBox txtCadValCust;
        private System.Windows.Forms.Label labNome;
        private System.Windows.Forms.Label labTelefone;
        private System.Windows.Forms.TextBox txtCadQuant;
        private System.Windows.Forms.Label labData_nasc;
        private System.Windows.Forms.Button btnCadEnviar;
        private System.Windows.Forms.ComboBox cbCadMarca;
        private System.Windows.Forms.Label labCadMarca;
        private System.Windows.Forms.GroupBox gbCadastrar;
        private System.Windows.Forms.GroupBox gbAlterar;
        private System.Windows.Forms.Label labAltId;
        private System.Windows.Forms.TextBox txtAltId;
        private System.Windows.Forms.Label labAltMarca;
        private System.Windows.Forms.ComboBox cbAltMarca;
        private System.Windows.Forms.Button btnAltEnviar;
        private System.Windows.Forms.Label labAltValVend;
        private System.Windows.Forms.TextBox txtAltQuant;
        private System.Windows.Forms.Label labAltValCust;
        private System.Windows.Forms.Label labAltDesc;
        private System.Windows.Forms.TextBox txtAltValCust;
        private System.Windows.Forms.TextBox txtAltValVend;
        private System.Windows.Forms.TextBox txtAltDesc;
        private System.Windows.Forms.TextBox txtAltPeso;
        private System.Windows.Forms.Label labAltQuant;
        private System.Windows.Forms.Label labAltPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn quant_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn valcust_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn valvend_col;
    }
}