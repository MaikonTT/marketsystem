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
            this.gbFormularioCad = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).BeginInit();
            this.gbFormularioCad.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFunc
            // 
            this.dgvFunc.AllowUserToAddRows = false;
            this.dgvFunc.AllowUserToDeleteRows = false;
            this.dgvFunc.AllowUserToResizeRows = false;
            this.dgvFunc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunc.Location = new System.Drawing.Point(12, 12);
            this.dgvFunc.Name = "dgvFunc";
            this.dgvFunc.ReadOnly = true;
            this.dgvFunc.RowHeadersVisible = false;
            this.dgvFunc.RowHeadersWidth = 40;
            this.dgvFunc.RowTemplate.Height = 15;
            this.dgvFunc.RowTemplate.ReadOnly = true;
            this.dgvFunc.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFunc.Size = new System.Drawing.Size(884, 310);
            this.dgvFunc.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(12, 328);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(64, 23);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
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
            // gbFormularioCad
            // 
            this.gbFormularioCad.Controls.Add(this.btnEnviar);
            this.gbFormularioCad.Controls.Add(this.labData_nasc);
            this.gbFormularioCad.Controls.Add(this.txtEndereco);
            this.gbFormularioCad.Controls.Add(this.labTelefone);
            this.gbFormularioCad.Controls.Add(this.labNome);
            this.gbFormularioCad.Controls.Add(this.txtTelefone);
            this.gbFormularioCad.Controls.Add(this.txtData_nasc);
            this.gbFormularioCad.Controls.Add(this.txtNome);
            this.gbFormularioCad.Controls.Add(this.txtCargo);
            this.gbFormularioCad.Controls.Add(this.labEndereco);
            this.gbFormularioCad.Controls.Add(this.labCargo);
            this.gbFormularioCad.Location = new System.Drawing.Point(253, 328);
            this.gbFormularioCad.Name = "gbFormularioCad";
            this.gbFormularioCad.Size = new System.Drawing.Size(643, 252);
            this.gbFormularioCad.TabIndex = 11;
            this.gbFormularioCad.TabStop = false;
            this.gbFormularioCad.Text = "Cadastrar";
            this.gbFormularioCad.Visible = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(83, 328);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // TelaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 592);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvFunc);
            this.Controls.Add(this.gbFormularioCad);
            this.Name = "TelaFuncionario";
            this.Text = "TelaFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).EndInit();
            this.gbFormularioCad.ResumeLayout(false);
            this.gbFormularioCad.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox gbFormularioCad;
        private System.Windows.Forms.Button btnCadastrar;
    }
}