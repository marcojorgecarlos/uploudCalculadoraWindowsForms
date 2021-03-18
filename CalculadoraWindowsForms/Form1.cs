using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int numeroAnte;
        string numeroDepo;
        int ope;
        int resultado;
        int numeroConta;

        private void button3_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "9";
            numeroDepo = numeroDepo + "9";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void zero_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "0";
            numeroDepo = numeroDepo + "0";
        }

        private void um_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "1";
            numeroDepo = numeroDepo + "1";
        }

        private void dois_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "2";
            numeroDepo = numeroDepo + "2";
        }

        private void tres_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "3";
            numeroDepo = numeroDepo + "3";
        }

        private void quatro_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "4";
            numeroDepo = numeroDepo + "4";
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "5";
            numeroDepo = numeroDepo + "5";
        }

        private void seis_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "6";
            numeroDepo = numeroDepo + "6";
        }

        private void sete_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "7";
            numeroDepo = numeroDepo + "7";
        }

        private void oito_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text + "8";
            numeroDepo = numeroDepo + "8";
        }

        private void somar_Click(object sender, EventArgs e)
        {
            if(tela.Text == "")
            {
                tela.Text = "0";
            }
            numeroAnte = int.Parse(tela.Text);
            numeroDepo = "";
            tela.Text = tela.Text + " + ";
            ope = 1;
        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (tela.Text == "")
            {
                tela.Text = "0";
            }
            numeroAnte = int.Parse(tela.Text);
            numeroDepo = "";
            tela.Text = tela.Text +  " - ";
            ope = 2;
        }

        private void div_Click(object sender, EventArgs e)
        {
            if (tela.Text == "")
            {
                tela.Text = "1";
            }
            numeroAnte = int.Parse(tela.Text);
            numeroDepo = "";
            tela.Text = tela.Text + " / ";
            ope = 3;
        }

        private void mult_Click(object sender, EventArgs e)
        {
            if (tela.Text == "")
            {
                tela.Text = "1";
            }
            numeroAnte = int.Parse(tela.Text);
            numeroDepo = "";
            tela.Text = tela.Text + " * ";
            ope = 4;
        }

        private void result_Click(object sender, EventArgs e)
        {
            numeroConta = int.Parse(numeroDepo);

            switch (ope)
            {
                case 1:
                    resultado = numeroAnte + numeroConta;
                    tela.Text = resultado.ToString();
                    break;

                case 2:
                    resultado = numeroAnte - numeroConta;
                    tela.Text = resultado.ToString();
                    break;

                case 3:
                    resultado = numeroAnte / numeroConta;
                    tela.Text = resultado.ToString();
                    break;

                case 4:
                    resultado = numeroAnte * numeroConta;
                    tela.Text = resultado.ToString();
                    break;

                default:
                    break;
            }
        }

        private void apagar_Click(object sender, EventArgs e)
        {
            tela.Text = tela.Text.Substring(0, tela.Text.Length - 1);
        }
    }
}
