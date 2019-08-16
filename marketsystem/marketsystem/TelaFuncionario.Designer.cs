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
            this.end_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nasc_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFunc
            // 
            this.dgvFunc.AllowUserToAddRows = false;
            this.dgvFunc.AllowUserToDeleteRows = false;
            this.dgvFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_col,
            this.nome_col,
            this.cargo_col,
            this.end_col,
            this.tel_col,
            this.nasc_col});
            this.dgvFunc.Location = new System.Drawing.Point(12, 12);
            this.dgvFunc.Name = "dgvFunc";
            this.dgvFunc.ReadOnly = true;
            this.dgvFunc.RowHeadersVisible = false;
            this.dgvFunc.Size = new System.Drawing.Size(884, 310);
            this.dgvFunc.TabIndex = 0;
            // 
            // id_col
            // 
            this.id_col.HeaderText = "ID";
            this.id_col.Name = "id_col";
            this.id_col.ReadOnly = true;
            this.id_col.Width = 30;
            // 
            // nome_col
            // 
            this.nome_col.HeaderText = "Nome";
            this.nome_col.Name = "nome_col";
            this.nome_col.ReadOnly = true;
            this.nome_col.Width = 200;
            // 
            // cargo_col
            // 
            this.cargo_col.HeaderText = "Cargo";
            this.cargo_col.Name = "cargo_col";
            this.cargo_col.ReadOnly = true;
            // 
            // end_col
            // 
            this.end_col.HeaderText = "Endereço";
            this.end_col.Name = "end_col";
            this.end_col.ReadOnly = true;
            this.end_col.Width = 250;
            // 
            // tel_col
            // 
            this.tel_col.HeaderText = "Telefone";
            this.tel_col.Name = "tel_col";
            this.tel_col.ReadOnly = true;
            this.tel_col.Width = 150;
            // 
            // nasc_col
            // 
            this.nasc_col.HeaderText = "Data de Nascimento";
            this.nasc_col.Name = "nasc_col";
            this.nasc_col.ReadOnly = true;
            this.nasc_col.Width = 150;
            // 
            // TelaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 535);
            this.Controls.Add(this.dgvFunc);
            this.Name = "TelaFuncionario";
            this.Text = "TelaFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn nasc_col;
    }
}