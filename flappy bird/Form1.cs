using System.Diagnostics;

namespace flappy_bird
{
    public partial class Form1 : Form
    {


        int velocidade_cano = 8;
        int gravidade = 5;
        public static int ponto = 0;



        public Form1()
        {
            InitializeComponent();
            //Valor.Text = Properties.Settings.Default.String;
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            passaro.Top += gravidade;
            cano_baixo.Left -= velocidade_cano;
            cano_cima.Left -= velocidade_cano;
            cano_cima2.Left -= velocidade_cano;
            cano_baixo2.Left -= velocidade_cano;
            pontos.Text = "Pontuação:" + ponto;

            Game_Menu.Hide();
            

            //Movimento dos canos
            if (cano_baixo.Left < -50)
            {
                cano_baixo.Left= 800;
                ponto++;
            }

            if(cano_cima.Left < -80)
            {
                cano_cima.Left= 950;
                ponto++;
            }

            //Movimento dos canos.2
            if (cano_baixo2.Left < -50)
            {
                cano_baixo2.Left = 800;
                ponto++;
            }

            if (cano_cima2.Left < -80)
            {
                cano_cima2.Left = 950;
                ponto++;
            }

            if (passaro.Bounds.IntersectsWith(cano_baixo.Bounds) ||
                passaro.Bounds.IntersectsWith(cano_cima.Bounds) || 
                passaro.Bounds.IntersectsWith(cano_cima2.Bounds) ||
                passaro.Bounds.IntersectsWith(cano_baixo2.Bounds) ||
                passaro.Bounds.IntersectsWith(chao.Bounds)
                )
            {
                endGame();

               
                Game_Menu.Show();
                

                
                
            }


            
            if (ponto > 5)
            {
                velocidade_cano = ;
            }


            if (passaro.Top < 28)
            {
                endGame();
                
            }

            
        }

        private void seta_baixo(object sender, KeyEventArgs e)
        {
             if ( e.KeyCode == Keys.Space)
            {
                gravidade = -5;
            }
        }

        private void seta_cima(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravidade = 5;
            }
        }

        private void endGame()
        {
            timer1.Stop();
            pontos.Text += " Game Over!!! ";
            
            
            
            
            //Gravar o Score em bloco de notas
            //int a = Int32.Parse(Valor.Text);

            
            //if (Score > a)
            //{
            //    Valor.Text = Score.ToString();
            //    Properties.Settings.Default.String = Valor.Text;
            //    Properties.Settings.Default.Save();
            //}
        }

        private void ficheiroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O pássaro é constantemente puxado para baixo " +
                "e um toque na tecla (space) faz com que ele suba um pouco, " +
                "em um movimento de arco. É possível pressionar rapidamente " +
                "para subir mais, porém cuidado para não perder o controle. " +
                "Canos verdes aparecerão em variadas alturas e seu objetivo é " +
                "desviar deles.");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //User_Menu.Show();
            Environment.Exit(0);
        }

        private void facilToolStripMenuItem_Click(object sender, EventArgs e)
        {


            timer1.Interval = 20;

            //if (ponto > 5)
            //{
            //    velocidade_cano = 15;
            //}

            //if (ponto > 15)
            //{
            //    velocidade_cano = 13;
            //}

            //if (ponto > 25)
            //{
            //    velocidade_cano = 10;
            //}
        }

        private void medioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 13;

            //if (ponto > 5)
            //{
            //    velocidade_cano = 12;
            //}

            //if (ponto > 15)
            //{
            //    velocidade_cano = 10;
            //}

            //if (ponto > 25)
            //{
            //    velocidade_cano = 8;
            //}
        }

        private void lbl_restart_Click(object sender, EventArgs e)
        {
            //this.Show();

            //Form1 form1 = new Form1();

            //form1.ShowDialog();

            timer1.Start();
            Game_Menu.Hide();

            if (facilToolStripMenuItem = true)
            {
                timer1.Interval = 15;
            }

            if (medioToolStripMenuItem = true)
            {
                timer1.Interval = 13;
            }

            if (dificilToolStripMenuItem = true)
            {
                timer1.Interval = 10;
            }

            passaro.Location = new Point(12, 200);
            cano_baixo.Location = new Point(282, 293);
            cano_baixo2.Location = new Point(568, 324);
            cano_cima.Location = new Point(344, 24);
            cano_cima2.Location = new Point(526, 24);
            ponto = 0;
            


        }

        private void lbl_sair_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("");

            DialogResult result = MessageBox.Show("Quer gravar o seu jogo?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Código para lidar com a seleção de "Sim"
                this.Show();

                Form3 form3 = new Form3();

                form3.ShowDialog();
            }
            else if (result == DialogResult.No)
            {
                // Código para lidar com a seleção de "Não"
                Environment.Exit(0);
            }
            


        }

        private void pontos_Click(object sender, EventArgs e)
        {

        }

        private void dificilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 8;

            //if (ponto > 5)
            //{
            //    velocidade_cano = 8;
            //}

            //if (ponto > 15)
            //{
            //    velocidade_cano = 7;
            //}

            //if (ponto > 25)
            //{
            //    velocidade_cano = 5;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //if (tb_user.Text != "")
            //{
            //    // a caixa de texto tem texto inserido
            //    StreamWriter writer = new StreamWriter("notepad.txt");
            //    writer.Write($"{tb_user.Text}, {ponto}");
            //    writer.Close();
            //    Process.Start("notepad.exe", "notepad.txt");

            //    User_Menu.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("A caixa de texto esta vazia!");
            //}
        }

        private void Game_Menu_Enter(object sender, EventArgs e)
        {

        }

        private void tb_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void modoJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}