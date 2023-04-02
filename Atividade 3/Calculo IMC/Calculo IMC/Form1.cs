using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_IMC
{
    public partial class Form1 : Form
    {
        //⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛VARIÁVEIS GLOBAIS⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛
        double peso;
        double altura;
        double resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        //⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛
        //⬛                              BOTÕES                                     ⬛
        //⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛
        private void button3_Click(object sender, EventArgs e)
        {

            // [X]TODO: Limpar as Entradas e Saida

            mtxtAltura.Clear();
            mtxtPeso.Clear();

            lblMenssage.Text = "";

        }
        private void button2_Click(object sender, EventArgs e)
        {

            // [X]TODO: Código que fecha a aplicação

            Application.Exit();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblMenssage.Text = "";

            if ((Double.TryParse(mtxtPeso.Text, out peso)) && (Double.TryParse(mtxtAltura.Text, out altura)))
            {
                if (peso <= 0)
                {
                    lblMenssage.Text = "Peso inválido!";
                    lblMenssage.ForeColor = Color.Red;
                }
                else if (altura <= 0)
                {
                    lblMenssage.Text = "Altura inválida!";
                    lblMenssage.ForeColor = Color.Red;
                }
                else
                {
                    resultado = peso / (Math.Pow(altura, 2));
                    resultado = Math.Round(resultado, 1);

                    if (resultado < 18.5)
                    {
                        lblMenssage.Text = "Magreza";
                        lblMenssage.ForeColor = Color.Red;
                    }
                    else if (resultado <= 24.9)
                    {
                        lblMenssage.Text = "Normal";
                        lblMenssage.ForeColor = Color.Green;
                    }
                    else if (resultado <= 29.9)
                    {
                        lblMenssage.Text = "Sobrepeso";
                        lblMenssage.ForeColor = Color.Yellow;
                    }
                    else if (resultado <= 39.9)
                    {
                        lblMenssage.Text = "Obesidade";
                        lblMenssage.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblMenssage.Text = "Obesidade grave";
                        lblMenssage.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                lblMenssage.Text = "Valores inválidos";
                lblMenssage.ForeColor = Color.Red;
            }

        }

        //⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛
        //⬛                               VALIDAÇÕES                                ⬛
        //⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛⬛
        private void mtxtPeso_TextChanged(object sender, EventArgs e)
        {
            lblMenssage.Text = "";
            lblMenssage.ForeColor = Color.Black;
        }

        private void mtxtAltura_TextChanged(object sender, EventArgs e)
        {
            lblMenssage.Text = "";
            lblMenssage.ForeColor = Color.Black;
        }

        private void mtxtPeso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtxtPeso_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(mtxtPeso.Text, out peso))
            {
                lblMenssage.Text = "";
                lblMenssage.Text = "Peso inválido!";
                lblMenssage.ForeColor = Color.Red;
            }
        }

        private void mtxtAltura_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(mtxtAltura.Text, out altura))
            {
                lblMenssage.Text = "";
                lblMenssage.Text = "Altura inválido!";
                lblMenssage.ForeColor = Color.Red;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMenssage.Text = "";
            lblMenssage.Text = "Bem Vindo(a)";
            lblMenssage.ForeColor = Color.Black;
        }
    }
}
