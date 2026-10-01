namespace Atividade_Polimorfismo
{
    partial class w_Det_Ger
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
            this.txb_Senha = new System.Windows.Forms.TextBox();
            this.txb_Usuario = new System.Windows.Forms.TextBox();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txb_Senha
            // 
            this.txb_Senha.Location = new System.Drawing.Point(256, 106);
            this.txb_Senha.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Senha.Name = "txb_Senha";
            this.txb_Senha.Size = new System.Drawing.Size(117, 20);
            this.txb_Senha.TabIndex = 39;
            // 
            // txb_Usuario
            // 
            this.txb_Usuario.Location = new System.Drawing.Point(75, 106);
            this.txb_Usuario.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Usuario.Name = "txb_Usuario";
            this.txb_Usuario.ShortcutsEnabled = false;
            this.txb_Usuario.Size = new System.Drawing.Size(117, 20);
            this.txb_Usuario.TabIndex = 38;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(26, 109);
            this.lbl_Usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(46, 13);
            this.lbl_Usuario.TabIndex = 36;
            this.lbl_Usuario.Text = "Usuário:";
            this.lbl_Usuario.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Location = new System.Drawing.Point(210, 109);
            this.lbl_Senha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(41, 13);
            this.lbl_Senha.TabIndex = 37;
            this.lbl_Senha.Text = "Senha:";
            this.lbl_Senha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // w_Det_Ger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(484, 142);
            this.Controls.Add(this.txb_Senha);
            this.Controls.Add(this.txb_Usuario);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.lbl_Senha);
            this.Name = "w_Det_Ger";
            this.Text = "Detalhe [ - ]";
            this.Load += new System.EventHandler(this.w_Det_Ger_Load);
            this.Controls.SetChildIndex(this.btn_Gravar, 0);
            this.Controls.SetChildIndex(this.btn_Sair, 0);
            this.Controls.SetChildIndex(this.lbl_Salario, 0);
            this.Controls.SetChildIndex(this.lbl_Nome, 0);
            this.Controls.SetChildIndex(this.lbl_Bonificacao, 0);
            this.Controls.SetChildIndex(this.txb_Bonificacao, 0);
            this.Controls.SetChildIndex(this.txb_Nome, 0);
            this.Controls.SetChildIndex(this.txb_Salario, 0);
            this.Controls.SetChildIndex(this.lbl_Senha, 0);
            this.Controls.SetChildIndex(this.lbl_Usuario, 0);
            this.Controls.SetChildIndex(this.txb_Usuario, 0);
            this.Controls.SetChildIndex(this.txb_Senha, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Senha;
        private System.Windows.Forms.TextBox txb_Usuario;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Senha;
    }
}
