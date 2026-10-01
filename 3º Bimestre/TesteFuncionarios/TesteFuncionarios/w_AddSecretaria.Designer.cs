namespace TesteFuncionarios
{
    partial class w_AddSecretaria
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
            this.tb_Ramal = new System.Windows.Forms.TextBox();
            this.tb_Salario = new System.Windows.Forms.TextBox();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.btn_AddGerente = new System.Windows.Forms.Button();
            this.lbl_Ramal = new System.Windows.Forms.Label();
            this.lbl_Salario = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Ramal
            // 
            this.tb_Ramal.Location = new System.Drawing.Point(55, 58);
            this.tb_Ramal.Name = "tb_Ramal";
            this.tb_Ramal.Size = new System.Drawing.Size(177, 20);
            this.tb_Ramal.TabIndex = 16;
            // 
            // tb_Salario
            // 
            this.tb_Salario.Location = new System.Drawing.Point(55, 32);
            this.tb_Salario.Name = "tb_Salario";
            this.tb_Salario.Size = new System.Drawing.Size(177, 20);
            this.tb_Salario.TabIndex = 15;
            // 
            // tb_Nome
            // 
            this.tb_Nome.Location = new System.Drawing.Point(55, 7);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(177, 20);
            this.tb_Nome.TabIndex = 14;
            // 
            // btn_AddGerente
            // 
            this.btn_AddGerente.Location = new System.Drawing.Point(14, 84);
            this.btn_AddGerente.Name = "btn_AddGerente";
            this.btn_AddGerente.Size = new System.Drawing.Size(218, 23);
            this.btn_AddGerente.TabIndex = 13;
            this.btn_AddGerente.Text = "Ok";
            this.btn_AddGerente.UseVisualStyleBackColor = true;
            this.btn_AddGerente.Click += new System.EventHandler(this.btn_AddGerente_Click);
            // 
            // lbl_Ramal
            // 
            this.lbl_Ramal.AutoSize = true;
            this.lbl_Ramal.Location = new System.Drawing.Point(11, 61);
            this.lbl_Ramal.Name = "lbl_Ramal";
            this.lbl_Ramal.Size = new System.Drawing.Size(40, 13);
            this.lbl_Ramal.TabIndex = 11;
            this.lbl_Ramal.Text = "Ramal:";
            // 
            // lbl_Salario
            // 
            this.lbl_Salario.AutoSize = true;
            this.lbl_Salario.Location = new System.Drawing.Point(11, 35);
            this.lbl_Salario.Name = "lbl_Salario";
            this.lbl_Salario.Size = new System.Drawing.Size(42, 13);
            this.lbl_Salario.TabIndex = 10;
            this.lbl_Salario.Text = "Salario:";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(11, 10);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_Nome.TabIndex = 9;
            this.lbl_Nome.Text = "Nome:";
            // 
            // w_AddSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 119);
            this.Controls.Add(this.tb_Ramal);
            this.Controls.Add(this.tb_Salario);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.btn_AddGerente);
            this.Controls.Add(this.lbl_Ramal);
            this.Controls.Add(this.lbl_Salario);
            this.Controls.Add(this.lbl_Nome);
            this.Name = "w_AddSecretaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adicionar Secretaria";
            this.Load += new System.EventHandler(this.w_AddSecretaria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Ramal;
        private System.Windows.Forms.TextBox tb_Salario;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.Button btn_AddGerente;
        private System.Windows.Forms.Label lbl_Ramal;
        private System.Windows.Forms.Label lbl_Salario;
        private System.Windows.Forms.Label lbl_Nome;
    }
}