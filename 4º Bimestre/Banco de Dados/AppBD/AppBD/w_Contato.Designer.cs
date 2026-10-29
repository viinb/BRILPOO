namespace AppBD
{
    partial class w_Contato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_Contato));
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Telefone = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(9, 15);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(19, 13);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "Id:";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(12, 31);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(182, 20);
            this.txt_ID.TabIndex = 1;
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Location = new System.Drawing.Point(12, 148);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(383, 20);
            this.txt_Telefone.TabIndex = 3;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(9, 54);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_Nome.TabIndex = 2;
            this.lbl_Nome.Text = "Nome:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(14, 70);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(381, 20);
            this.txt_Nome.TabIndex = 5;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(9, 93);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(38, 13);
            this.lbl_Email.TabIndex = 4;
            this.lbl_Email.Text = "E-mail:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(12, 109);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(182, 20);
            this.txt_Email.TabIndex = 7;
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.Location = new System.Drawing.Point(9, 132);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(52, 13);
            this.lbl_Telefone.TabIndex = 6;
            this.lbl_Telefone.Text = "Telefone:";
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Location = new System.Drawing.Point(320, 175);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(75, 23);
            this.btn_Gravar.TabIndex = 8;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppBD.Properties.Resources.shisa;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(334, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // w_Contato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 213);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Gravar);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbl_Telefone);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.txt_Telefone);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_ID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "w_Contato";
            this.Text = "Dados do Contato";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Telefone;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_Email;
        public System.Windows.Forms.Label lbl_Telefone;
        private System.Windows.Forms.Button btn_Gravar;
        public System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}