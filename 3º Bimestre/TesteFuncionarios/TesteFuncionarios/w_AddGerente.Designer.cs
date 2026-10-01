namespace TesteFuncionarios
{
    partial class w_AddGerente
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
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Salario = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.btn_AddGerente = new System.Windows.Forms.Button();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.tb_Salario = new System.Windows.Forms.TextBox();
            this.tb_Usuario = new System.Windows.Forms.TextBox();
            this.tb_Senha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(12, 9);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_Nome.TabIndex = 0;
            this.lbl_Nome.Text = "Nome:";
            // 
            // lbl_Salario
            // 
            this.lbl_Salario.AutoSize = true;
            this.lbl_Salario.Location = new System.Drawing.Point(12, 34);
            this.lbl_Salario.Name = "lbl_Salario";
            this.lbl_Salario.Size = new System.Drawing.Size(42, 13);
            this.lbl_Salario.TabIndex = 1;
            this.lbl_Salario.Text = "Salario:";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(12, 60);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(46, 13);
            this.lbl_Usuario.TabIndex = 2;
            this.lbl_Usuario.Text = "Usuário:";
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Location = new System.Drawing.Point(12, 86);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(41, 13);
            this.lbl_Senha.TabIndex = 3;
            this.lbl_Senha.Text = "Senha:";
            // 
            // btn_AddGerente
            // 
            this.btn_AddGerente.Location = new System.Drawing.Point(15, 109);
            this.btn_AddGerente.Name = "btn_AddGerente";
            this.btn_AddGerente.Size = new System.Drawing.Size(209, 23);
            this.btn_AddGerente.TabIndex = 4;
            this.btn_AddGerente.Text = "Ok";
            this.btn_AddGerente.UseVisualStyleBackColor = true;
            this.btn_AddGerente.Click += new System.EventHandler(this.btn_AddGerente_Click);
            // 
            // tb_Nome
            // 
            this.tb_Nome.Location = new System.Drawing.Point(56, 6);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(168, 20);
            this.tb_Nome.TabIndex = 5;
            // 
            // tb_Salario
            // 
            this.tb_Salario.Location = new System.Drawing.Point(56, 31);
            this.tb_Salario.Name = "tb_Salario";
            this.tb_Salario.Size = new System.Drawing.Size(168, 20);
            this.tb_Salario.TabIndex = 6;
            // 
            // tb_Usuario
            // 
            this.tb_Usuario.Location = new System.Drawing.Point(56, 57);
            this.tb_Usuario.Name = "tb_Usuario";
            this.tb_Usuario.Size = new System.Drawing.Size(168, 20);
            this.tb_Usuario.TabIndex = 7;
            // 
            // tb_Senha
            // 
            this.tb_Senha.Location = new System.Drawing.Point(56, 83);
            this.tb_Senha.Name = "tb_Senha";
            this.tb_Senha.Size = new System.Drawing.Size(168, 20);
            this.tb_Senha.TabIndex = 8;
            // 
            // w_AddGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 138);
            this.Controls.Add(this.tb_Senha);
            this.Controls.Add(this.tb_Usuario);
            this.Controls.Add(this.tb_Salario);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.btn_AddGerente);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.lbl_Salario);
            this.Controls.Add(this.lbl_Nome);
            this.Name = "w_AddGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adicionar Gerente";
            this.Load += new System.EventHandler(this.w_AddGerente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Salario;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.Button btn_AddGerente;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.TextBox tb_Salario;
        private System.Windows.Forms.TextBox tb_Usuario;
        private System.Windows.Forms.TextBox tb_Senha;
    }
}