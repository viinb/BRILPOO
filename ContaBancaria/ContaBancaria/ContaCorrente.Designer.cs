namespace ContaBancaria
{
    partial class w_ContaCorrente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_ContaCorrente));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSaldoAtual = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblValorOperacao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSaldoAtual = new System.Windows.Forms.TextBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.btnCriarConta = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.txtValorOperacao = new System.Windows.Forms.TextBox();
            this.txtCashback = new System.Windows.Forms.Label();
            this.lbContas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(175, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblSaldoAtual
            // 
            this.lblSaldoAtual.AutoSize = true;
            this.lblSaldoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoAtual.Location = new System.Drawing.Point(175, 33);
            this.lblSaldoAtual.Name = "lblSaldoAtual";
            this.lblSaldoAtual.Size = new System.Drawing.Size(95, 20);
            this.lblSaldoAtual.TabIndex = 1;
            this.lblSaldoAtual.Text = "Saldo Atual:";
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimite.Location = new System.Drawing.Point(175, 59);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(55, 20);
            this.lblLimite.TabIndex = 2;
            this.lblLimite.Text = "Limite:";
            // 
            // lblValorOperacao
            // 
            this.lblValorOperacao.AutoSize = true;
            this.lblValorOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorOperacao.Location = new System.Drawing.Point(175, 233);
            this.lblValorOperacao.Name = "lblValorOperacao";
            this.lblValorOperacao.Size = new System.Drawing.Size(146, 20);
            this.lblValorOperacao.TabIndex = 3;
            this.lblValorOperacao.Text = "Valor da Operação:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(278, 9);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(216, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtSaldoAtual
            // 
            this.txtSaldoAtual.Location = new System.Drawing.Point(278, 35);
            this.txtSaldoAtual.Name = "txtSaldoAtual";
            this.txtSaldoAtual.Size = new System.Drawing.Size(216, 20);
            this.txtSaldoAtual.TabIndex = 5;
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(278, 61);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(216, 20);
            this.txtLimite.TabIndex = 6;
            // 
            // btnCriarConta
            // 
            this.btnCriarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarConta.Location = new System.Drawing.Point(178, 96);
            this.btnCriarConta.Name = "btnCriarConta";
            this.btnCriarConta.Size = new System.Drawing.Size(314, 32);
            this.btnCriarConta.TabIndex = 8;
            this.btnCriarConta.Text = "Criar Conta";
            this.btnCriarConta.UseVisualStyleBackColor = true;
            this.btnCriarConta.Click += new System.EventHandler(this.btnCriarConta_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacar.Location = new System.Drawing.Point(291, 266);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(91, 29);
            this.btnSacar.TabIndex = 9;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(402, 266);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(91, 29);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseCompatibleTextRendering = true;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositar.Location = new System.Drawing.Point(178, 266);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(92, 29);
            this.btnDepositar.TabIndex = 11;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // txtValorOperacao
            // 
            this.txtValorOperacao.Location = new System.Drawing.Point(327, 235);
            this.txtValorOperacao.Name = "txtValorOperacao";
            this.txtValorOperacao.Size = new System.Drawing.Size(166, 20);
            this.txtValorOperacao.TabIndex = 12;
            // 
            // txtCashback
            // 
            this.txtCashback.AutoSize = true;
            this.txtCashback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashback.Location = new System.Drawing.Point(175, 204);
            this.txtCashback.Name = "txtCashback";
            this.txtCashback.Size = new System.Drawing.Size(84, 20);
            this.txtCashback.TabIndex = 13;
            this.txtCashback.Text = "Cashback:";
            // 
            // lbContas
            // 
            this.lbContas.FormattingEnabled = true;
            this.lbContas.Location = new System.Drawing.Point(12, 12);
            this.lbContas.Name = "lbContas";
            this.lbContas.Size = new System.Drawing.Size(148, 251);
            this.lbContas.TabIndex = 14;
            this.lbContas.SelectedIndexChanged += new System.EventHandler(this.lbContas_SelectedIndexChanged);
            // 
            // w_ContaCorrente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 308);
            this.Controls.Add(this.lbContas);
            this.Controls.Add(this.txtCashback);
            this.Controls.Add(this.txtValorOperacao);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnCriarConta);
            this.Controls.Add(this.txtLimite);
            this.Controls.Add(this.txtSaldoAtual);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblValorOperacao);
            this.Controls.Add(this.lblLimite);
            this.Controls.Add(this.lblSaldoAtual);
            this.Controls.Add(this.lblNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "w_ContaCorrente";
            this.Text = "Conta Corrente (Victor)";
            this.Load += new System.EventHandler(this.w_ContaCorrente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSaldoAtual;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblValorOperacao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSaldoAtual;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.Button btnCriarConta;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.TextBox txtValorOperacao;
        private System.Windows.Forms.Label txtCashback;
        private System.Windows.Forms.ListBox lbContas;
    }
}

