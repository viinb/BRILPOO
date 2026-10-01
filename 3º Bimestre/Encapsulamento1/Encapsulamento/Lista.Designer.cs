namespace Encapsulamento
{
    partial class w_Lista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_Lista));
            this.btn_Add = new System.Windows.Forms.Button();
            this.lb_Lista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(266, 12);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(218, 23);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Adicionar";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lb_Lista
            // 
            this.lb_Lista.FormattingEnabled = true;
            this.lb_Lista.Location = new System.Drawing.Point(12, 12);
            this.lb_Lista.Name = "lb_Lista";
            this.lb_Lista.Size = new System.Drawing.Size(246, 290);
            this.lb_Lista.TabIndex = 1;
            this.lb_Lista.DoubleClick += new System.EventHandler(this.lb_Lista_DoubleClick);
            // 
            // w_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 313);
            this.Controls.Add(this.lb_Lista);
            this.Controls.Add(this.btn_Add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "w_Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Livros";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ListBox lb_Lista;
    }
}

