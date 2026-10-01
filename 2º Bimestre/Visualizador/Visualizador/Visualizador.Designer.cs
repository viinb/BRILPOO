namespace Visualizador
{
    partial class w_Visualizador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_Visualizador));
            btn_Selecionar = new Button();
            btn_Sair = new Button();
            op_SelFigura = new OpenFileDialog();
            pb_Figura = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_Figura).BeginInit();
            SuspendLayout();
            // 
            // btn_Selecionar
            // 
            btn_Selecionar.Location = new Point(545, 24);
            btn_Selecionar.Name = "btn_Selecionar";
            btn_Selecionar.Size = new Size(234, 23);
            btn_Selecionar.TabIndex = 0;
            btn_Selecionar.Text = "Selecionar Imagem...";
            btn_Selecionar.UseVisualStyleBackColor = true;
            btn_Selecionar.Click += btn_Selecionar_Click;
            // 
            // btn_Sair
            // 
            btn_Sair.Location = new Point(545, 53);
            btn_Sair.Name = "btn_Sair";
            btn_Sair.Size = new Size(234, 23);
            btn_Sair.TabIndex = 1;
            btn_Sair.Text = "Sair";
            btn_Sair.UseVisualStyleBackColor = true;
            btn_Sair.Click += btn_Sair_Click;
            // 
            // op_SelFigura
            // 
            op_SelFigura.FileName = "op_SelFigura";
            op_SelFigura.FileOk += op_SelFigura_FileOk;
            // 
            // pb_Figura
            // 
            pb_Figura.BackgroundImageLayout = ImageLayout.Zoom;
            pb_Figura.Location = new Point(0, 0);
            pb_Figura.Name = "pb_Figura";
            pb_Figura.Size = new Size(518, 409);
            pb_Figura.TabIndex = 2;
            pb_Figura.TabStop = false;
            // 
            // w_Visualizador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(804, 441);
            Controls.Add(pb_Figura);
            Controls.Add(btn_Sair);
            Controls.Add(btn_Selecionar);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "w_Visualizador";
            Text = "Visualizador";
            Load += w_Visualizador_Load;
            ((System.ComponentModel.ISupportInitialize)pb_Figura).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Selecionar;
        private Button btn_Sair;
        private OpenFileDialog op_SelFigura;
        private PictureBox pb_Figura;
    }
}
