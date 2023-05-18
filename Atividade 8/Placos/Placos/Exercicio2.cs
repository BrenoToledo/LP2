using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Placos
{
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        //private void 
        private void btnCalcular_Click(object sender, EventArgs e)
        {

            double number = 0;
            double number_h = 0;

            if (double.TryParse(txtEntrada.Text, out number) && number > 0)
            {
                Console.WriteLine("Número informado: " + number);
                for (int i = 1; i <= number; i++)
                {
                    number_h += 1.0 / i;
                }

                Console.WriteLine("Valor de H: " + number_h);
                MessageBox.Show("O valor de H é: " + number_h);
            }
            else
            {
                MessageBox.Show("Informe um valor maior que 0!");
            }

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
