namespace JUNTANDO_TUDO_v2
{
    partial class frm_ListaPessoas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dg_Lista = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Pos_Vetor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_Inst = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.gb_Parceiro = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_CPF = new System.Windows.Forms.TextBox();
            this.btn_ImprimirContrato = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Lista)).BeginInit();
            this.gb_Inst.SuspendLayout();
            this.gb_Parceiro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_Lista
            // 
            this.dg_Lista.AllowUserToAddRows = false;
            this.dg_Lista.AllowUserToDeleteRows = false;
            this.dg_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Tipo,
            this.Pos_Vetor});
            this.dg_Lista.Location = new System.Drawing.Point(10, 20);
            this.dg_Lista.Name = "dg_Lista";
            this.dg_Lista.ReadOnly = true;
            this.dg_Lista.RowTemplate.Height = 25;
            this.dg_Lista.Size = new System.Drawing.Size(560, 217);
            this.dg_Lista.TabIndex = 0;
            this.dg_Lista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Lista_CellClick);
            this.dg_Lista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Lista_CellContentClick);
            this.dg_Lista.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Lista_CellEnter);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 300;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Items.AddRange(new object[] {
            "Aluno",
            "TAE",
            "Professor",
            "Parceiro"});
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Pos_Vetor
            // 
            this.Pos_Vetor.HeaderText = "Pos_Vetor";
            this.Pos_Vetor.Name = "Pos_Vetor";
            this.Pos_Vetor.ReadOnly = true;
            this.Pos_Vetor.Visible = false;
            // 
            // gb_Inst
            // 
            this.gb_Inst.Controls.Add(this.label2);
            this.gb_Inst.Controls.Add(this.tb_2);
            this.gb_Inst.Controls.Add(this.label1);
            this.gb_Inst.Controls.Add(this.tb_1);
            this.gb_Inst.Location = new System.Drawing.Point(590, 20);
            this.gb_Inst.Name = "gb_Inst";
            this.gb_Inst.Size = new System.Drawing.Size(207, 125);
            this.gb_Inst.TabIndex = 1;
            this.gb_Inst.TabStop = false;
            this.gb_Inst.Text = "Instituição";
            this.gb_Inst.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Média:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_2
            // 
            this.tb_2.Location = new System.Drawing.Point(63, 44);
            this.tb_2.Name = "tb_2";
            this.tb_2.ReadOnly = true;
            this.tb_2.Size = new System.Drawing.Size(139, 20);
            this.tb_2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Curso:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(63, 19);
            this.tb_1.Name = "tb_1";
            this.tb_1.ReadOnly = true;
            this.tb_1.Size = new System.Drawing.Size(86, 20);
            this.tb_1.TabIndex = 0;
            // 
            // gb_Parceiro
            // 
            this.gb_Parceiro.Controls.Add(this.label3);
            this.gb_Parceiro.Controls.Add(this.groupBox4);
            this.gb_Parceiro.Controls.Add(this.tb_CPF);
            this.gb_Parceiro.Location = new System.Drawing.Point(590, 150);
            this.gb_Parceiro.Name = "gb_Parceiro";
            this.gb_Parceiro.Size = new System.Drawing.Size(207, 87);
            this.gb_Parceiro.TabIndex = 3;
            this.gb_Parceiro.TabStop = false;
            this.gb_Parceiro.Text = "Parceiro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF/CNPJ:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(7, 99);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(171, 87);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parceiros";
            // 
            // tb_CPF
            // 
            this.tb_CPF.Location = new System.Drawing.Point(63, 34);
            this.tb_CPF.Name = "tb_CPF";
            this.tb_CPF.ReadOnly = true;
            this.tb_CPF.Size = new System.Drawing.Size(139, 20);
            this.tb_CPF.TabIndex = 4;
            // 
            // btn_ImprimirContrato
            // 
            this.btn_ImprimirContrato.Location = new System.Drawing.Point(133, 243);
            this.btn_ImprimirContrato.Name = "btn_ImprimirContrato";
            this.btn_ImprimirContrato.Size = new System.Drawing.Size(115, 23);
            this.btn_ImprimirContrato.TabIndex = 4;
            this.btn_ImprimirContrato.Text = "Imprimir Contrato";
            this.btn_ImprimirContrato.UseVisualStyleBackColor = true;
            this.btn_ImprimirContrato.Click += new System.EventHandler(this.btn_ImprimirContrato_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Mostrar Detalhe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_ListaPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 272);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ImprimirContrato);
            this.Controls.Add(this.gb_Parceiro);
            this.Controls.Add(this.gb_Inst);
            this.Controls.Add(this.dg_Lista);
            this.Name = "frm_ListaPessoas";
            this.Text = "Lista de Pessoas - IFSP";
            this.Load += new System.EventHandler(this.frm_ListaPessoas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Lista)).EndInit();
            this.gb_Inst.ResumeLayout(false);
            this.gb_Inst.PerformLayout();
            this.gb_Parceiro.ResumeLayout(false);
            this.gb_Parceiro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_Lista;
        private System.Windows.Forms.GroupBox gb_Inst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.GroupBox gb_Parceiro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tb_CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewComboBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pos_Vetor;
        private System.Windows.Forms.Button btn_ImprimirContrato;
        private System.Windows.Forms.Button button1;
    }
}

