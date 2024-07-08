namespace flappy_bird
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.cano_cima = new System.Windows.Forms.PictureBox();
            this.passaro = new System.Windows.Forms.PictureBox();
            this.cano_baixo = new System.Windows.Forms.PictureBox();
            this.chao = new System.Windows.Forms.PictureBox();
            this.pontos = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classificaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gravarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modoJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dificilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cano_cima2 = new System.Windows.Forms.PictureBox();
            this.cano_baixo2 = new System.Windows.Forms.PictureBox();
            this.Game_Menu = new System.Windows.Forms.GroupBox();
            this.lbl_sair = new System.Windows.Forms.Label();
            this.lbl_restart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cano_cima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passaro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cano_baixo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cano_cima2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cano_baixo2)).BeginInit();
            this.Game_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cano_cima
            // 
            this.cano_cima.Image = global::flappy_bird.Properties.Resources.pipedown;
            this.cano_cima.Location = new System.Drawing.Point(344, 24);
            this.cano_cima.Name = "cano_cima";
            this.cano_cima.Size = new System.Drawing.Size(100, 96);
            this.cano_cima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cano_cima.TabIndex = 0;
            this.cano_cima.TabStop = false;
            // 
            // passaro
            // 
            this.passaro.Image = global::flappy_bird.Properties.Resources.bird;
            this.passaro.Location = new System.Drawing.Point(12, 200);
            this.passaro.Name = "passaro";
            this.passaro.Size = new System.Drawing.Size(80, 65);
            this.passaro.TabIndex = 1;
            this.passaro.TabStop = false;
            // 
            // cano_baixo
            // 
            this.cano_baixo.Image = global::flappy_bird.Properties.Resources.pipe;
            this.cano_baixo.Location = new System.Drawing.Point(282, 340);
            this.cano_baixo.Name = "cano_baixo";
            this.cano_baixo.Size = new System.Drawing.Size(100, 195);
            this.cano_baixo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cano_baixo.TabIndex = 2;
            this.cano_baixo.TabStop = false;
            // 
            // chao
            // 
            this.chao.Image = global::flappy_bird.Properties.Resources.ground;
            this.chao.Location = new System.Drawing.Point(0, 443);
            this.chao.Name = "chao";
            this.chao.Size = new System.Drawing.Size(719, 92);
            this.chao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chao.TabIndex = 3;
            this.chao.TabStop = false;
            // 
            // pontos
            // 
            this.pontos.AutoSize = true;
            this.pontos.Font = new System.Drawing.Font("Imprint MT Shadow", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pontos.Location = new System.Drawing.Point(0, 37);
            this.pontos.Name = "pontos";
            this.pontos.Size = new System.Drawing.Size(295, 56);
            this.pontos.TabIndex = 4;
            this.pontos.Text = "Pontuação: 0";
            this.pontos.Click += new System.EventHandler(this.pontos_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.modoJogoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(709, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classificaçãoToolStripMenuItem,
            this.gravarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            this.ficheiroToolStripMenuItem.Click += new System.EventHandler(this.ficheiroToolStripMenuItem_Click);
            // 
            // classificaçãoToolStripMenuItem
            // 
            this.classificaçãoToolStripMenuItem.Name = "classificaçãoToolStripMenuItem";
            this.classificaçãoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.classificaçãoToolStripMenuItem.Text = "Classificação";
            // 
            // gravarToolStripMenuItem
            // 
            this.gravarToolStripMenuItem.Name = "gravarToolStripMenuItem";
            this.gravarToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.gravarToolStripMenuItem.Text = "Gravar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.sairToolStripMenuItem.Text = "Sair ";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // modoJogoToolStripMenuItem
            // 
            this.modoJogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facilToolStripMenuItem,
            this.medioToolStripMenuItem,
            this.dificilToolStripMenuItem});
            this.modoJogoToolStripMenuItem.Name = "modoJogoToolStripMenuItem";
            this.modoJogoToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.modoJogoToolStripMenuItem.Text = "Modo Jogo";
            this.modoJogoToolStripMenuItem.Click += new System.EventHandler(this.modoJogoToolStripMenuItem_Click);
            // 
            // facilToolStripMenuItem
            // 
            this.facilToolStripMenuItem.Name = "facilToolStripMenuItem";
            this.facilToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.facilToolStripMenuItem.Text = "Facil";
            this.facilToolStripMenuItem.Click += new System.EventHandler(this.facilToolStripMenuItem_Click);
            // 
            // medioToolStripMenuItem
            // 
            this.medioToolStripMenuItem.Name = "medioToolStripMenuItem";
            this.medioToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.medioToolStripMenuItem.Text = "Medio";
            this.medioToolStripMenuItem.Click += new System.EventHandler(this.medioToolStripMenuItem_Click);
            // 
            // dificilToolStripMenuItem
            // 
            this.dificilToolStripMenuItem.Name = "dificilToolStripMenuItem";
            this.dificilToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.dificilToolStripMenuItem.Text = "Dificil";
            this.dificilToolStripMenuItem.Click += new System.EventHandler(this.dificilToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // cano_cima2
            // 
            this.cano_cima2.Image = global::flappy_bird.Properties.Resources.pipedown;
            this.cano_cima2.Location = new System.Drawing.Point(526, 24);
            this.cano_cima2.Name = "cano_cima2";
            this.cano_cima2.Size = new System.Drawing.Size(100, 116);
            this.cano_cima2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cano_cima2.TabIndex = 6;
            this.cano_cima2.TabStop = false;
            // 
            // cano_baixo2
            // 
            this.cano_baixo2.Image = global::flappy_bird.Properties.Resources.pipe;
            this.cano_baixo2.Location = new System.Drawing.Point(568, 340);
            this.cano_baixo2.Name = "cano_baixo2";
            this.cano_baixo2.Size = new System.Drawing.Size(100, 131);
            this.cano_baixo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cano_baixo2.TabIndex = 7;
            this.cano_baixo2.TabStop = false;
            // 
            // Game_Menu
            // 
            this.Game_Menu.Controls.Add(this.lbl_sair);
            this.Game_Menu.Controls.Add(this.lbl_restart);
            this.Game_Menu.Location = new System.Drawing.Point(203, 126);
            this.Game_Menu.Name = "Game_Menu";
            this.Game_Menu.Size = new System.Drawing.Size(317, 197);
            this.Game_Menu.TabIndex = 10;
            this.Game_Menu.TabStop = false;
            this.Game_Menu.Text = "Menu";
            this.Game_Menu.Visible = false;
            this.Game_Menu.Enter += new System.EventHandler(this.Game_Menu_Enter);
            // 
            // lbl_sair
            // 
            this.lbl_sair.AutoSize = true;
            this.lbl_sair.Font = new System.Drawing.Font("Imprint MT Shadow", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_sair.Location = new System.Drawing.Point(100, 108);
            this.lbl_sair.Name = "lbl_sair";
            this.lbl_sair.Size = new System.Drawing.Size(121, 56);
            this.lbl_sair.TabIndex = 6;
            this.lbl_sair.Text = "Sair ";
            this.lbl_sair.Click += new System.EventHandler(this.lbl_sair_Click);
            // 
            // lbl_restart
            // 
            this.lbl_restart.AutoSize = true;
            this.lbl_restart.Font = new System.Drawing.Font("Imprint MT Shadow", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_restart.Location = new System.Drawing.Point(66, 19);
            this.lbl_restart.Name = "lbl_restart";
            this.lbl_restart.Size = new System.Drawing.Size(175, 56);
            this.lbl_restart.TabIndex = 5;
            this.lbl_restart.Text = "Restart";
            this.lbl_restart.Click += new System.EventHandler(this.lbl_restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(709, 483);
            this.Controls.Add(this.Game_Menu);
            this.Controls.Add(this.pontos);
            this.Controls.Add(this.chao);
            this.Controls.Add(this.cano_baixo2);
            this.Controls.Add(this.passaro);
            this.Controls.Add(this.cano_baixo);
            this.Controls.Add(this.cano_cima);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cano_cima2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.seta_baixo);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.seta_cima);
            ((System.ComponentModel.ISupportInitialize)(this.cano_cima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passaro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cano_baixo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chao)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cano_cima2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cano_baixo2)).EndInit();
            this.Game_Menu.ResumeLayout(false);
            this.Game_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox cano_cima;
        private PictureBox passaro;
        private PictureBox cano_baixo;
        private PictureBox chao;
        private Label pontos;
        private System.Windows.Forms.Timer timer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ficheiroToolStripMenuItem;
        private ToolStripMenuItem modoJogoToolStripMenuItem;
        private ToolStripMenuItem facilToolStripMenuItem;
        private ToolStripMenuItem medioToolStripMenuItem;
        private ToolStripMenuItem dificilToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem classificaçãoToolStripMenuItem;
        private ToolStripMenuItem gravarToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private PictureBox cano_cima2;
        private PictureBox cano_baixo2;
        private GroupBox Game_Menu;
        private Label lbl_sair;
        private Label lbl_restart;
    }
}