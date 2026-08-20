namespace Atividade_Polimorfismo
{
    partial class w_Det_Ana
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Nivel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nível:";
            // 
            // cb_Nivel
            // 
            this.cb_Nivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Nivel.FormattingEnabled = true;
            this.cb_Nivel.Location = new System.Drawing.Point(75, 94);
            this.cb_Nivel.Name = "cb_Nivel";
            this.cb_Nivel.Size = new System.Drawing.Size(117, 21);
            this.cb_Nivel.TabIndex = 37;
            // 
            // w_Det_Ana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(467, 132);
            this.Controls.Add(this.cb_Nivel);
            this.Controls.Add(this.label1);
            this.Name = "w_Det_Ana";
            this.Text = "Detalhe [ - ]";
            this.Controls.SetChildIndex(this.btn_Gravar, 0);
            this.Controls.SetChildIndex(this.btn_Sair, 0);
            this.Controls.SetChildIndex(this.lbl_Salario, 0);
            this.Controls.SetChildIndex(this.lbl_Nome, 0);
            this.Controls.SetChildIndex(this.lbl_Bonificacao, 0);
            this.Controls.SetChildIndex(this.txb_Bonificacao, 0);
            this.Controls.SetChildIndex(this.txb_Nome, 0);
            this.Controls.SetChildIndex(this.txb_Salario, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cb_Nivel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Nivel;
    }
}
