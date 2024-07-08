using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace flappy_bird
{
    public partial class Form2 : Form
    {


        int velocidade_cano = 8;
        int gravidade = 5;
        int ponto = 0;


        public Form2()
        {
            InitializeComponent();
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Show();

            Form1 form1 = new Form1();

            form1.ShowDialog();

            
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

        private void facilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Timer.Interval = 8;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            

        }

        private void medioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

