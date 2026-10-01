namespace FormHerdado
{
    partial class w_Base
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
            this.lb_Lista = new System.Windows.Forms.ListBox();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.pb_Imagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Lista
            // 
            this.lb_Lista.FormattingEnabled = true;
            this.lb_Lista.Location = new System.Drawing.Point(12, 12);
            this.lb_Lista.Name = "lb_Lista";
            this.lb_Lista.Size = new System.Drawing.Size(366, 290);
            this.lb_Lista.TabIndex = 0;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Location = new System.Drawing.Point(385, 279);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(260, 23);
            this.btn_Fechar.TabIndex = 2;
            this.btn_Fechar.Text = "button1";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            // 
            // pb_Imagem
            // 
            this.pb_Imagem.Image = global::FormHerdado.Properties.Resources.lista;
            this.pb_Imagem.Location = new System.Drawing.Point(384, 12);
            this.pb_Imagem.Name = "pb_Imagem";
            this.pb_Imagem.Size = new System.Drawing.Size(261, 261);
            this.pb_Imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Imagem.TabIndex = 1;
            this.pb_Imagem.TabStop = false;
            // 
            // w_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 318);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.pb_Imagem);
            this.Controls.Add(this.lb_Lista);
            this.Name = "w_Base";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Imagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Lista;
        private System.Windows.Forms.PictureBox pb_Imagem;
        private System.Windows.Forms.Button btn_Fechar;
    }
}

