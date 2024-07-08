namespace flappy_bird
{
    partial class Form2
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
            this.cano_cima = new System.Windows.Forms.PictureBox();
            this.cano_baixo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.passaro = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chao = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cano_cima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cano_baixo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passaro)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chao)).BeginInit();
            this.SuspendLayout();
            // 
            // cano_cima
            // 
            this.cano_cima.Image = global::flappy_bird.Properties.Resources.pipedown;
            this.cano_cima.Location = new System.Drawing.Point(208, -14);
            this.cano_cima.Name = "cano_cima";
            this.cano_cima.Size = new System.Drawing.Size(100, 111);
            this.cano_cima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cano_cima.TabIndex = 1;
            this.cano_cima.TabStop = false;
            // 
            // cano_baixo
            // 
            this.cano_baixo.Image = global::flappy_bird.Properties.Resources.pipe;
            this.cano_baixo.Location = new System.Drawing.Point(12, 215);
            this.cano_baixo.Name = "cano_baixo";
            this.cano_baixo.Size = new System.Drawing.Size(100, 142);
            this.cano_baixo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cano_baixo.TabIndex = 3;
            this.cano_baixo.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(170, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "PLAY";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passaro
            // 
            this.passaro.Image = global::flappy_bird.Properties.Resources.bird;
            this.passaro.Location = new System.Drawing.Point(32, 107);
            this.passaro.Name = "passaro";
            this.passaro.Size = new System.Drawing.Size(80, 65);
            this.passaro.TabIndex = 4;
            this.passaro.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(338, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // chao
            // 
            this.chao.Image = global::flappy_bird.Properties.Resources.ground;
            this.chao.Location = new System.Drawing.Point(-181, 298);
            this.chao.Name = "chao";
            this.chao.Size = new System.Drawing.Size(719, 59);
            this.chao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chao.TabIndex = 7;
            this.chao.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(338, 338);
            this.Controls.Add(this.chao);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.passaro);
            this.Controls.Add(this.cano_baixo);
            this.Controls.Add(this.cano_cima);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Pagina Principal";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cano_cima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cano_baixo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passaro)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox cano_cima;
        private PictureBox cano_baixo;
        private Button button1;
        private PictureBox passaro;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ficheiroToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private PictureBox chao;
    }
}