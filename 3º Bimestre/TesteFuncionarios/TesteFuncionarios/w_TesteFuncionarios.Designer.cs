namespace TesteFuncionarios
{
    partial class w_TesteFuncionarios
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
            this.lb_ListaFuncionarios = new System.Windows.Forms.ListBox();
            this.btn_AddGerente = new System.Windows.Forms.Button();
            this.btn_AddTelefonista = new System.Windows.Forms.Button();
            this.btn_AddSecretaria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_ListaFuncionarios
            // 
            this.lb_ListaFuncionarios.FormattingEnabled = true;
            this.lb_ListaFuncionarios.Location = new System.Drawing.Point(12, 12);
            this.lb_ListaFuncionarios.Name = "lb_ListaFuncionarios";
            this.lb_ListaFuncionarios.Size = new System.Drawing.Size(462, 251);
            this.lb_ListaFuncionarios.TabIndex = 0;
            // 
            // btn_AddGerente
            // 
            this.btn_AddGerente.Location = new System.Drawing.Point(12, 272);
            this.btn_AddGerente.Name = "btn_AddGerente";
            this.btn_AddGerente.Size = new System.Drawing.Size(150, 23);
            this.btn_AddGerente.TabIndex = 1;
            this.btn_AddGerente.Text = "Adicionar Gerente";
            this.btn_AddGerente.UseVisualStyleBackColor = true;
            this.btn_AddGerente.Click += new System.EventHandler(this.btn_AddGerente_Click);
            // 
            // btn_AddTelefonista
            // 
            this.btn_AddTelefonista.Location = new System.Drawing.Point(168, 272);
            this.btn_AddTelefonista.Name = "btn_AddTelefonista";
            this.btn_AddTelefonista.Size = new System.Drawing.Size(150, 23);
            this.btn_AddTelefonista.TabIndex = 2;
            this.btn_AddTelefonista.Text = "Adicionar Telefonista";
            this.btn_AddTelefonista.UseVisualStyleBackColor = true;
            this.btn_AddTelefonista.Click += new System.EventHandler(this.btn_AddTelefonista_Click);
            // 
            // btn_AddSecretaria
            // 
            this.btn_AddSecretaria.Location = new System.Drawing.Point(324, 272);
            this.btn_AddSecretaria.Name = "btn_AddSecretaria";
            this.btn_AddSecretaria.Size = new System.Drawing.Size(150, 23);
            this.btn_AddSecretaria.TabIndex = 3;
            this.btn_AddSecretaria.Text = "Adicionar Secretaria";
            this.btn_AddSecretaria.UseVisualStyleBackColor = true;
            this.btn_AddSecretaria.Click += new System.EventHandler(this.btn_AddSecretaria_Click);
            // 
            // w_TesteFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 304);
            this.Controls.Add(this.btn_AddSecretaria);
            this.Controls.Add(this.btn_AddTelefonista);
            this.Controls.Add(this.btn_AddGerente);
            this.Controls.Add(this.lb_ListaFuncionarios);
            this.Name = "w_TesteFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste Funcionários";
            this.Load += new System.EventHandler(this.w_TesteFuncionarios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_ListaFuncionarios;
        private System.Windows.Forms.Button btn_AddGerente;
        private System.Windows.Forms.Button btn_AddTelefonista;
        private System.Windows.Forms.Button btn_AddSecretaria;
    }
}

