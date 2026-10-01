namespace Encapsulamento
{
    partial class w_Detalhe
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.tb_Titulo = new System.Windows.Forms.TextBox();
            this.tb_Autor = new System.Windows.Forms.TextBox();
            this.lbl_Autor = new System.Windows.Forms.Label();
            this.tb_Codigo = new System.Windows.Forms.TextBox();
            this.lb_Codigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.Location = new System.Drawing.Point(42, 161);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(116, 48);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(24, 101);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(71, 25);
            this.lbl_Titulo.TabIndex = 1;
            this.lbl_Titulo.Text = "Título:";
            // 
            // tb_Titulo
            // 
            this.tb_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Titulo.Location = new System.Drawing.Point(116, 101);
            this.tb_Titulo.Name = "tb_Titulo";
            this.tb_Titulo.Size = new System.Drawing.Size(158, 31);
            this.tb_Titulo.TabIndex = 0;
            // 
            // tb_Autor
            // 
            this.tb_Autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Autor.Location = new System.Drawing.Point(116, 64);
            this.tb_Autor.Name = "tb_Autor";
            this.tb_Autor.Size = new System.Drawing.Size(158, 31);
            this.tb_Autor.TabIndex = 2;
            // 
            // lbl_Autor
            // 
            this.lbl_Autor.AutoSize = true;
            this.lbl_Autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Autor.Location = new System.Drawing.Point(24, 64);
            this.lbl_Autor.Name = "lbl_Autor";
            this.lbl_Autor.Size = new System.Drawing.Size(69, 25);
            this.lbl_Autor.TabIndex = 3;
            this.lbl_Autor.Text = "Autor:";
            // 
            // tb_Codigo
            // 
            this.tb_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Codigo.Location = new System.Drawing.Point(116, 26);
            this.tb_Codigo.Name = "tb_Codigo";
            this.tb_Codigo.ReadOnly = true;
            this.tb_Codigo.Size = new System.Drawing.Size(158, 31);
            this.tb_Codigo.TabIndex = 4;
            // 
            // lb_Codigo
            // 
            this.lb_Codigo.AutoSize = true;
            this.lb_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Codigo.Location = new System.Drawing.Point(24, 26);
            this.lb_Codigo.Name = "lb_Codigo";
            this.lb_Codigo.Size = new System.Drawing.Size(86, 25);
            this.lb_Codigo.TabIndex = 5;
            this.lb_Codigo.Text = "Código:";
            // 
            // w_Detalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 233);
            this.Controls.Add(this.tb_Codigo);
            this.Controls.Add(this.lb_Codigo);
            this.Controls.Add(this.tb_Autor);
            this.Controls.Add(this.lbl_Autor);
            this.Controls.Add(this.tb_Titulo);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_OK);
            this.Name = "w_Detalhe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalhe do Livro";
            this.Load += new System.EventHandler(this.w_Detalhe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.TextBox tb_Titulo;
        private System.Windows.Forms.TextBox tb_Autor;
        private System.Windows.Forms.Label lbl_Autor;
        private System.Windows.Forms.TextBox tb_Codigo;
        private System.Windows.Forms.Label lb_Codigo;
    }
}