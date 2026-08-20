namespace Atividade_Polimorfismo
{
    partial class w_Det_Sec
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
            this.txb_Ramal = new System.Windows.Forms.TextBox();
            this.lbl_Ramal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txb_Ramal
            // 
            this.txb_Ramal.Location = new System.Drawing.Point(75, 97);
            this.txb_Ramal.Margin = new System.Windows.Forms.Padding(2);
            this.txb_Ramal.Name = "txb_Ramal";
            this.txb_Ramal.Size = new System.Drawing.Size(117, 20);
            this.txb_Ramal.TabIndex = 40;
            // 
            // lbl_Ramal
            // 
            this.lbl_Ramal.AutoSize = true;
            this.lbl_Ramal.Location = new System.Drawing.Point(31, 100);
            this.lbl_Ramal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Ramal.Name = "lbl_Ramal";
            this.lbl_Ramal.Size = new System.Drawing.Size(40, 13);
            this.lbl_Ramal.TabIndex = 39;
            this.lbl_Ramal.Text = "Ramal:";
            this.lbl_Ramal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // w_Det_Sec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(467, 128);
            this.Controls.Add(this.txb_Ramal);
            this.Controls.Add(this.lbl_Ramal);
            this.Name = "w_Det_Sec";
            this.Text = "Detalhe [ - ]";
            this.Controls.SetChildIndex(this.txb_Nome, 0);
            this.Controls.SetChildIndex(this.txb_Salario, 0);
            this.Controls.SetChildIndex(this.lbl_Ramal, 0);
            this.Controls.SetChildIndex(this.txb_Ramal, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Ramal;
        private System.Windows.Forms.Label lbl_Ramal;
    }
}
