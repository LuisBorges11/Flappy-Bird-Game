using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace flappy_bird
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            string texto = tb_user.Text;
            Regex regex = new Regex("^[a-zA-Z]+$");
            if (regex.IsMatch(texto))
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\agrma\Documents\ATEC - TPSICAS 1022\Programação\C#\vstudio-form_exe\flappy bird\Record.Score.txt", true))
                {
                    sw.WriteLine($"Jogador: {tb_user.Text}; Score: {Form1.ponto}; ");


                }

                MessageBox.Show("Foi gravado com sucesso");

                foreach (Form form in Application.OpenForms)
                {
                    form.Close();
                }
            }
            else 
            {
                MessageBox.Show("O texto contém caracteres que não são letras ou a caixa esta vazia!.");
            }

            //else 
            //{
            //    MessageBox.Show("A caixa de texto esta vazia!");
            //}


            //if (tb_user.Text != "")
            //{

            //    //Tentativa 1
            //    // a caixa de texto tem texto inserido
            //    //StreamWriter writer = new StreamWriter("notepad.txt");
            //    //writer.Write($"{tb_user.Text}, {Form1.ponto}");
            //    //writer.Close();
            //    //Process.Start("notepad.exe", "notepad.txt");


            //    //Tentativa 2
            //    //    StreamWriter writer = new StreamWriter("C:\\Users\\agrma\\Documents" +
            //    //    "\\ATEC - TPSICAS 1022\\Programação\\C#\\vstudio-form_exe\\flappy bird");

            //    //    writer.WriteLine($"{tb_user.Text}, {Form1.ponto}");
            //    //    writer.Close();
            //    //    Environment.Exit(0);

            //    //Tentativa 3
            //    //using (StreamWriter sw = new StreamWriter(@"C:\Users\agrma\Documents\ATEC - TPSICAS 1022\Programação\C#\vstudio-form_exe\flappy bird\Record.Score.txt", true))
            //    //{
            //    //sw.WriteLine($"Jogador: {tb_user.Text}; Score: {Form1.ponto}; ");
                    

            //    //}

            //    //MessageBox.Show("Foi gravado com sucesso");
                
            //    //foreach (Form form in Application.OpenForms)
            //    //{
            //    //    form.Close();
            //    //}
               
            //    //this.Close();

                
            //}
            //else if
            //{
            //    MessageBox.Show("A caixa de texto esta vazia!");
            //}
        }

        private void tb_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
