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
    public partial class FrmExercicio3 : Form
    {
        public FrmExercicio3()
        {
            InitializeComponent();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtPalavra1.Clear();
            txtPalavra2.Clear();
            txtResultado.Clear();
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            string palavra1 = txtPalavra1.Text.ToLower();
            string palavra2 = txtPalavra2.Text.ToLower();

            int posicao = palavra2.IndexOf(palavra1);
            while (posicao >= 0)
            {
                palavra2 = palavra2.Substring(0, posicao) + palavra2.Substring(posicao + palavra1.Length);
                posicao = palavra2.IndexOf(palavra1);
            }

            txtResultado.Text = palavra2;
        }
        private void BtnRemoverReplace_Click(object sender, EventArgs e)
        {
            string palavra1 = txtPalavra1.Text.ToLower();
            string palavra2 = txtPalavra2.Text.ToLower();

            palavra2 = palavra2.Replace(palavra1, "");

            txtResultado.Text = palavra2;
        }
    }
}
