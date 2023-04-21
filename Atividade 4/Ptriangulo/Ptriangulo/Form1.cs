using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close(); // Fechar a Aplicação
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();  // Limpar os dados do TextBox
            txtLadoB.Clear();  // Limpar os dados do TextBox
            txtLadoC.Clear();  // Limpar os dados do TextBox
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double ladoA;
            double ladoB;
            double ladoC;

            if (!double.TryParse(txtLadoA.Text,out ladoA))
                MessageBox.Show("Lado A inválido");
            else if (!double.TryParse(txtLadoB.Text, out ladoB))
                MessageBox.Show("Lado B inválido");
            else if (!double.TryParse(txtLadoC.Text, out ladoC))
                MessageBox.Show("Lado C inválido");

            else // Testar se os valores digitados formam um triangulo
            {
                if(ladoA < (ladoB + ladoC) && ladoA > Math.Abs (ladoB - ladoC) &&
                   ladoB < (ladoA + ladoC) && ladoB > Math.Abs (ladoA - ladoC) &&
                   ladoC < (ladoA + ladoB) && ladoC > Math.Abs (ladoA - ladoB) )
                
                { // SE VERDADEIRO

                    // Verificar o Tipo do triângulo
                    if ((ladoA == ladoB) && (ladoB == ladoC))
                    {
                        MessageBox.Show("É um equilátero");
                    }
                    else if ((ladoA != ladoB ) && (ladoB != ladoC) && (ladoC != ladoA))
                    {
                        MessageBox.Show("É um escaleno");
                    }
                    else
                    {
                        MessageBox.Show("É um isósceles");
                    }
                }

                else // SE FALSO
                {
                    MessageBox.Show("Os Lados fornecidos não formam um triângulo");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
