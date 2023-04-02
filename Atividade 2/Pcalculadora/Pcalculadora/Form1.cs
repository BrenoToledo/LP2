using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pcalculadora
{
    public partial class Form1 : Form
    {
        // ██████████████████████ VARIÁVEIS GLOBAIS ███████████████████████

        public double numero1;
        public double numero2;
        public double resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // ██████████████████████████████████████████████████████████████████
        // █                             VALIDAÇÃO                          █
        // ██████████████████████████████████████████████████████████████████

        private void textNum1_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(textNum1.Text, out numero1))
            {
                MessageBox.Show("O valor digitado não é permitido!");
            }
        }
        private void textNum2_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(textNum2.Text, out numero2))
            {
                MessageBox.Show("O valor digitado não é permitido!");
            }
        }


        // ██████████████████████████████████████████████████████████████████
        // █                              BOTÕES                            █
        // ██████████████████████████████████████████████████████████████████

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            // [X]TODO: LIMPAR TODAS AS TXTBOX

            textNum1.Clear();
            textNum2.Clear();

            textResultado.Clear();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            // [X]TODO: SAIR DA APLICAÇÃO
            System.Windows.Forms.Application.Exit();

        }

        // ███████████████████████████ CALCULOS █████████████████████████████

        private void btnSoma_Click(object sender, EventArgs e)
        {
            // [X]TODO: VALIDAR -> SOMAR -> EXIBIR RESULTADO NA TXTBOX 3 

            //VALIDAÇÃO 
            if (double.TryParse(textNum1.Text, out numero1) && double.TryParse(textNum2.Text, out numero2))
            {

                //SOMAR
                resultado = numero1 + numero2;

                //RESULTADO
                textResultado.Text = resultado.ToString();

            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            // [X]TODO: VALIDAR -> SUBTRAIR -> EXIBIR RESULTADO NA TXTBOX 3 

            //VALIDAÇÃO 
            if (double.TryParse(textNum1.Text, out numero1) && double.TryParse(textNum2.Text, out numero2))
            {
                //SOMAR
                resultado = numero1 - numero2;

                //RESULTADO
                textResultado.Text = resultado.ToString();

            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            // TODO: VALIDAR -> MULTIPLICAR -> EXIBIR RESULTADO NA TXTBOX 3 

            //VALIDAÇÃO 
            if (double.TryParse(textNum1.Text, out numero1) && double.TryParse(textNum2.Text, out numero2))
            {
                //SOMAR
                resultado = numero1 * numero2;

                //RESULTADO
                textResultado.Text = resultado.ToString();
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            // TODO: VALIDAR -> DIVISÃO -> EXIBIR RESULTADO NA TXTBOX 3 

            //VALIDAÇÃO 
            if (double.TryParse(textNum1.Text, out numero1) && double.TryParse(textNum2.Text, out numero2))
            {
                if (numero2 == 0)
                {
                    MessageBox.Show("Não é possivel dividir por ZERO! ");
                }
                else
                {

                    //SOMAR
                    resultado = numero1 / numero2;

                    //RESULTADO
                    textResultado.Text = resultado.ToString();

                }

            }

        }

    }
}
