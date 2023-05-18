using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Placos
{
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) // REPETIDOS
        {
            {
                int count = 0;

                for (int i = 1; i < rchTxtFrase.Text.Length; i++)
                {
                    if (rchTxtFrase.Text[i] == rchTxtFrase.Text[i-1]) 
                    {
                        count++;
                    }
                }

                if (count <= 0)
                {
                    MessageBox.Show("Não foi encontrado! ");
                }
                else
                {
                    MessageBox.Show("Foi Encontrado " + count + " ocorrência(s)!");
                };
            }
        }

        private void rchTxtFrase_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)  // BtnBranco
        {
            int count = 0;

            for (int i = 0; i < rchTxtFrase.Text.Length ; i++)
            {
                
                if (rchTxtFrase.Text[i] == ' ')
                {
                    count++;
                }
            }

            if (count <= 0) 
            {
                MessageBox.Show("Não foi encontrado! ");
            }
            else 
            {
                MessageBox.Show("Foi Encontrado " + count + " ocorrência(s)!");
            };
            
        }

        private void btnContR_Click(object sender, EventArgs e) // Find R 
        {
            int count = 0;

            int i = 0; 

            while (i < rchTxtFrase.Text.Length)
            { 
                if (Char.ToUpper(rchTxtFrase.Text[i]) == 'R')
                {
                    count++;
                }

                i++;
            }

            if (count <= 0)
            {
                MessageBox.Show("Não foi encontrado! ");
            }
            else
            {
                MessageBox.Show("Foi Encontrado " + count + " ocorrência(s)!");
            };
        }
    }
}
