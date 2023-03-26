using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pvolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // O método IsValidate não é utilizado, então foi comentado
        //public bool IsValidate (double txtBoxInput)
        //{
        //    double valor;
        //    if (!double.TryParse(Text, out valor)) {
        //        MessageBox.Show("Valido ");
        //    }
        //    return (true)
        //    else
        //    { 
        //        return false; 
        //    }   
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            // Não há necessidade de código aqui neste momento
        }

        // -------------------------------- VALIDAÇÕES ------------------------------
        private void txtRaio_Validated(object sender, EventArgs e)
        {
            double raio;

            if (!double.TryParse(txtRaio.Text, out raio))
            {
                MessageBox.Show("O valor informado não é um número válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRaio.Focus();
            }
            else if (raio <= 0)
            {
                MessageBox.Show("O raio deve ser um número positivo maior que zero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRaio.Focus();
            }
            else
            {
                // O valor informado é válido, pode-se prosseguir com a lógica desejada
            }
        }

        private void txtAltura_Validated(object sender, EventArgs e)
        {
            double altura;

            if (!double.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("O valor informado não é um número válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAltura.Focus();
            }
            else if (altura <= 0)
            {
                MessageBox.Show("A altura deve ser um número positivo maior que zero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAltura.Focus();
            }
            else
            {
                // O valor informado é válido, pode-se prosseguir com a lógica desejada
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double raio, altura, volume;

            if (!double.TryParse(txtRaio.Text, out raio) || raio <= 0)
            {
                MessageBox.Show("O raio deve ser um número positivo maior que zero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRaio.Focus();
                return;
            }

            if (!double.TryParse(txtAltura.Text, out altura) || altura <= 0)
            {
                MessageBox.Show("A altura deve ser um número positivo maior que zero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAltura.Focus();
                return;
            }

            // Cálculo do volume do cilindro
            volume = Math.PI * Math.Pow(raio, 2) * altura;

            // Exibição do volume na caixa de texto
            txtVolume.Text = volume.ToString("#,##0.00");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Encerramento da aplicação
            Application.Exit();
        }
    }
}
