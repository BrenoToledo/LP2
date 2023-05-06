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
    public partial class FrmExercicio4 : Form
    {
        public FrmExercicio4()
        {
            InitializeComponent();
        }

        private void btnIsNumber_Click(object sender, EventArgs e)
        {
            string mytext = richTextBox1.Text;
            int NumberCount =0;

            for (int i = 0; i < mytext.Length; i++)
            {
                if (char.IsNumber(mytext[i]))
                {
                    NumberCount++;
                }
            }

            MessageBox.Show(" Foram encontrados " + NumberCount + " numeros!");
        }

        private void btnFirstSpace_Click(object sender, EventArgs e)
        {
            string myText = richTextBox1.Text;
            int position = 0;

            while (position < myText.Length)
            {
                if (char.IsWhiteSpace(myText[position]))
                {
                    MessageBox.Show("O primeiro espaço em branco foi encontrado na posição " + position);
                    return;
                }

                position++;
            }

            MessageBox.Show("Nenhum espaço em branco foi encontrado.");
        }

        private void btnIsLetter_Click(object sender, EventArgs e)
        {
            string myText = richTextBox1.Text;
            int letterCount = 0;

            foreach (char c in myText)
            {
                if (char.IsLetter(c))
                {
                    letterCount++;
                }
            }

            MessageBox.Show("O texto contém " + letterCount + " caracteres alfabéticos.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text= string.Empty;
        }
    }
}
