using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenu
{
    public partial class FrmExercicio5 : Form
    {
        public FrmExercicio5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;

            if (!int.TryParse(txtNumero1.Text, out num1))
            {
                MessageBox.Show("O primeiro número informado não é válido.");
                return;
            }

            if (!int.TryParse(txtNumero2.Text, out num2))
            {
                MessageBox.Show("O segundo número informado não é válido.");
                return;
            }

            if (num1 >= num2)
            {
                MessageBox.Show("O primeiro número deve ser menor que o segundo número.");
                return;
            }

            Random random = new Random();
            int sorteio = random.Next(num1, num2 + 1); // Gera um número aleatório entre num1 e num2

            MessageBox.Show("O número sorteado foi: " + sorteio);
        }
    }
}
