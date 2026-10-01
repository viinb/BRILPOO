namespace Atividade_Polimorfismo
{
    partial class w_Det
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
            this.txb_Bonificacao = new System.Windows.Forms.TextBox();
            this.lbl_Bonificacao = new System.Windows.Forms.Label();
            this.txb_Salario = new System.Windows.Forms.TextBox();
            this.txb_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Salario = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_Bonificacao
            // 
            this.txb_Bonificacao.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txb_Bonificacao.Location = new System.Drawing.Point(213, 54);
            this.txb_Bonificacao.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Bonificacao.Name = "txb_Bonificacao";
            this.txb_Bonificacao.ReadOnly = true;
            this.txb_Bonificacao.Size = new System.Drawing.Size(117, 20);
            this.txb_Bonificacao.TabIndex = 35;
            // 
            // lbl_Bonificacao
            // 
            this.lbl_Bonificacao.AutoSize = true;
            this.lbl_Bonificacao.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Bonificacao.Location = new System.Drawing.Point(237, 39);
            this.lbl_Bonificacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Bonificacao.Name = "lbl_Bonificacao";
            this.lbl_Bonificacao.Size = new System.Drawing.Size(63, 13);
            this.lbl_Bonificacao.TabIndex = 34;
            this.lbl_Bonificacao.Text = "Bonificação";
            this.lbl_Bonificacao.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txb_Salario
            // 
            this.txb_Salario.Location = new System.Drawing.Point(75, 54);
            this.txb_Salario.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Salario.Name = "txb_Salario";
            this.txb_Salario.Size = new System.Drawing.Size(117, 20);
            this.txb_Salario.TabIndex = 33;
            // 
            // txb_Nome
            // 
            this.txb_Nome.Location = new System.Drawing.Point(75, 24);
            this.txb_Nome.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Nome.Name = "txb_Nome";
            this.txb_Nome.Size = new System.Drawing.Size(117, 20);
            this.txb_Nome.TabIndex = 32;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(33, 24);
            this.lbl_Nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_Nome.TabIndex = 30;
            this.lbl_Nome.Text = "Nome:";
            this.lbl_Nome.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_Salario
            // 
            this.lbl_Salario.AutoSize = true;
            this.lbl_Salario.Location = new System.Drawing.Point(29, 57);
            this.lbl_Salario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Salario.Name = "lbl_Salario";
            this.lbl_Salario.Size = new System.Drawing.Size(42, 13);
            this.lbl_Salario.TabIndex = 31;
            this.lbl_Salario.Text = "Salário:";
            this.lbl_Salario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Sair
            // 
            this.btn_Sair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Sair.Location = new System.Drawing.Point(363, 50);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(88, 28);
            this.btn_Sair.TabIndex = 29;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Location = new System.Drawing.Point(363, 16);
            this.btn_Gravar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(88, 28);
            this.btn_Gravar.TabIndex = 28;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // w_Det
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 98);
            this.Controls.Add(this.txb_Bonificacao);
            this.Controls.Add(this.lbl_Bonificacao);
            this.Controls.Add(this.txb_Salario);
            this.Controls.Add(this.txb_Nome);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.lbl_Salario);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Gravar);
            this.Name = "w_Det";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalhes";
            this.Load += new System.EventHandler(this.w_Det_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.TextBox txb_Bonificacao;
        protected System.Windows.Forms.Label lbl_Bonificacao;
        protected System.Windows.Forms.TextBox txb_Salario;
        protected System.Windows.Forms.TextBox txb_Nome;
        protected System.Windows.Forms.Label lbl_Nome;
        protected System.Windows.Forms.Label lbl_Salario;
        protected System.Windows.Forms.Button btn_Sair;
        protected System.Windows.Forms.Button btn_Gravar;
    }
}