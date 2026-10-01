namespace Atividade_Polimorfismo
{
    partial class w_Det_Tel
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
            this.txb_EstTrab = new System.Windows.Forms.TextBox();
            this.lbl_EstTrab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txb_EstTrab
            // 
            this.txb_EstTrab.Location = new System.Drawing.Point(141, 104);
            this.txb_EstTrab.Margin = new System.Windows.Forms.Padding(2);
            this.txb_EstTrab.Name = "txb_EstTrab";
            this.txb_EstTrab.Size = new System.Drawing.Size(117, 20);
            this.txb_EstTrab.TabIndex = 37;
            // 
            // lbl_EstTrab
            // 
            this.lbl_EstTrab.AutoSize = true;
            this.lbl_EstTrab.Location = new System.Drawing.Point(29, 107);
            this.lbl_EstTrab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_EstTrab.Name = "lbl_EstTrab";
            this.lbl_EstTrab.Size = new System.Drawing.Size(109, 13);
            this.lbl_EstTrab.TabIndex = 36;
            this.lbl_EstTrab.Text = "Estação de Trabalho:";
            this.lbl_EstTrab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // w_Det_Tel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(467, 135);
            this.Controls.Add(this.txb_EstTrab);
            this.Controls.Add(this.lbl_EstTrab);
            this.Name = "w_Det_Tel";
            this.Text = "Detalhe [ - ]";
            this.Load += new System.EventHandler(this.w_Det_Tel_Load);
            this.Controls.SetChildIndex(this.txb_Nome, 0);
            this.Controls.SetChildIndex(this.txb_Salario, 0);
            this.Controls.SetChildIndex(this.lbl_EstTrab, 0);
            this.Controls.SetChildIndex(this.txb_EstTrab, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txb_EstTrab;
        private System.Windows.Forms.Label lbl_EstTrab;
    }
}
