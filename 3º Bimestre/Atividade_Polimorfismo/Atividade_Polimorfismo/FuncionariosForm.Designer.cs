namespace Atividade_Polimorfismo
{
    partial class FuncionariosForm
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
            this.lbx_Funcionarios = new System.Windows.Forms.ListBox();
            this.bt_Adicionar = new System.Windows.Forms.Button();
            this.bt_Remover = new System.Windows.Forms.Button();
            this.rb_Gerente = new System.Windows.Forms.RadioButton();
            this.rb_Telefonista = new System.Windows.Forms.RadioButton();
            this.rb_Secretario = new System.Windows.Forms.RadioButton();
            this.gpb_Funcionarios = new System.Windows.Forms.GroupBox();
            this.rb_Analista = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gpb_Funcionarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbx_Funcionarios
            // 
            this.lbx_Funcionarios.FormattingEnabled = true;
            this.lbx_Funcionarios.Location = new System.Drawing.Point(26, 30);
            this.lbx_Funcionarios.Margin = new System.Windows.Forms.Padding(2);
            this.lbx_Funcionarios.Name = "lbx_Funcionarios";
            this.lbx_Funcionarios.Size = new System.Drawing.Size(470, 199);
            this.lbx_Funcionarios.TabIndex = 0;
            this.lbx_Funcionarios.SelectedIndexChanged += new System.EventHandler(this.lbx_Funcionarios_SelectedIndexChanged);
            this.lbx_Funcionarios.DoubleClick += new System.EventHandler(this.lbx_Funcionarios_DoubleClick);
            // 
            // bt_Adicionar
            // 
            this.bt_Adicionar.Location = new System.Drawing.Point(517, 141);
            this.bt_Adicionar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Adicionar.Name = "bt_Adicionar";
            this.bt_Adicionar.Size = new System.Drawing.Size(88, 28);
            this.bt_Adicionar.TabIndex = 11;
            this.bt_Adicionar.Text = "Adicionar";
            this.bt_Adicionar.UseVisualStyleBackColor = true;
            this.bt_Adicionar.Click += new System.EventHandler(this.bt_Adicionar_Click);
            // 
            // bt_Remover
            // 
            this.bt_Remover.Location = new System.Drawing.Point(517, 173);
            this.bt_Remover.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Remover.Name = "bt_Remover";
            this.bt_Remover.Size = new System.Drawing.Size(88, 28);
            this.bt_Remover.TabIndex = 12;
            this.bt_Remover.Text = "Remover";
            this.bt_Remover.UseVisualStyleBackColor = true;
            this.bt_Remover.Click += new System.EventHandler(this.bt_Remover_Click);
            // 
            // rb_Gerente
            // 
            this.rb_Gerente.AutoSize = true;
            this.rb_Gerente.Checked = true;
            this.rb_Gerente.Location = new System.Drawing.Point(8, 17);
            this.rb_Gerente.Margin = new System.Windows.Forms.Padding(2);
            this.rb_Gerente.Name = "rb_Gerente";
            this.rb_Gerente.Size = new System.Drawing.Size(63, 17);
            this.rb_Gerente.TabIndex = 2;
            this.rb_Gerente.TabStop = true;
            this.rb_Gerente.Text = "Gerente";
            this.rb_Gerente.UseVisualStyleBackColor = true;
            // 
            // rb_Telefonista
            // 
            this.rb_Telefonista.AutoSize = true;
            this.rb_Telefonista.Location = new System.Drawing.Point(8, 39);
            this.rb_Telefonista.Margin = new System.Windows.Forms.Padding(2);
            this.rb_Telefonista.Name = "rb_Telefonista";
            this.rb_Telefonista.Size = new System.Drawing.Size(77, 17);
            this.rb_Telefonista.TabIndex = 3;
            this.rb_Telefonista.Text = "Telefonista";
            this.rb_Telefonista.UseVisualStyleBackColor = true;
            // 
            // rb_Secretario
            // 
            this.rb_Secretario.AutoSize = true;
            this.rb_Secretario.Location = new System.Drawing.Point(8, 61);
            this.rb_Secretario.Margin = new System.Windows.Forms.Padding(2);
            this.rb_Secretario.Name = "rb_Secretario";
            this.rb_Secretario.Size = new System.Drawing.Size(73, 17);
            this.rb_Secretario.TabIndex = 4;
            this.rb_Secretario.Text = "Secretária";
            this.rb_Secretario.UseVisualStyleBackColor = true;
            // 
            // gpb_Funcionarios
            // 
            this.gpb_Funcionarios.Controls.Add(this.rb_Analista);
            this.gpb_Funcionarios.Controls.Add(this.rb_Gerente);
            this.gpb_Funcionarios.Controls.Add(this.rb_Secretario);
            this.gpb_Funcionarios.Controls.Add(this.rb_Telefonista);
            this.gpb_Funcionarios.Location = new System.Drawing.Point(509, 30);
            this.gpb_Funcionarios.Margin = new System.Windows.Forms.Padding(2);
            this.gpb_Funcionarios.Name = "gpb_Funcionarios";
            this.gpb_Funcionarios.Padding = new System.Windows.Forms.Padding(2);
            this.gpb_Funcionarios.Size = new System.Drawing.Size(150, 107);
            this.gpb_Funcionarios.TabIndex = 1;
            this.gpb_Funcionarios.TabStop = false;
            this.gpb_Funcionarios.Text = "Funcionários";
            // 
            // rb_Analista
            // 
            this.rb_Analista.AutoSize = true;
            this.rb_Analista.Location = new System.Drawing.Point(8, 83);
            this.rb_Analista.Margin = new System.Windows.Forms.Padding(2);
            this.rb_Analista.Name = "rb_Analista";
            this.rb_Analista.Size = new System.Drawing.Size(62, 17);
            this.rb_Analista.TabIndex = 5;
            this.rb_Analista.Text = "Analista";
            this.rb_Analista.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "<Duplo clique par EDITAR>";
            // 
            // FuncionariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpb_Funcionarios);
            this.Controls.Add(this.bt_Remover);
            this.Controls.Add(this.bt_Adicionar);
            this.Controls.Add(this.lbx_Funcionarios);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FuncionariosForm";
            this.Text = "Lista de Funcionários";
            this.Load += new System.EventHandler(this.FuncionariosForm_Load);
            this.gpb_Funcionarios.ResumeLayout(false);
            this.gpb_Funcionarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_Funcionarios;
        private System.Windows.Forms.Button bt_Adicionar;
        private System.Windows.Forms.Button bt_Remover;
        private System.Windows.Forms.RadioButton rb_Gerente;
        private System.Windows.Forms.RadioButton rb_Telefonista;
        private System.Windows.Forms.RadioButton rb_Secretario;
        private System.Windows.Forms.GroupBox gpb_Funcionarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_Analista;
    }
}