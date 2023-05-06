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
    public partial class FrmExercicio2 : Form
    {
        public FrmExercicio2()
        {
            InitializeComponent();
        }

        private void BtnComparar_Click(object sender, EventArgs e)
        {
            if(string.Compare(txtPalavra1.Text, txtPalavra2.Text,true) == 0)
            {
                txtResultado.Text = "São iguais";
            }
            else
            {
                txtResultado.Text = "São diferentes";
            }
        }

        private void BtnInserirMeio_Click(object sender, EventArgs e)
        {
            int metade = txtPalavra2.Text.Length / 2;
            txtResultado.Text = $"{txtPalavra2.Text.Substring(0, metade)}{txtPalavra1.Text}{txtPalavra2.Text.Substring(metade, txtPalavra2.Text.Length-metade)}";
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtPalavra1.Clear();
            txtPalavra2.Clear();
            txtResultado.Clear();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            int metade = txtPalavra1.Text.Length / 2;
            txtResultado.Text = txtPalavra1.Text.Insert(metade, "**");
        }
    }
}
