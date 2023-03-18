using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PtestsEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // NOME 

            // QUANDO APERTAR A TECLA == KeyPress

            // Se a tecla pressionada foi ENTER (CHAR 13 ASCI)
            if (e.KeyChar == (char)(13)) {

                // Envia comando de teclado TAB
                SendKeys.Send("{TAB}");

                //Desabilita o Som da mudança de Foco
                e.Handled= true;
            }

        }


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Se a tecla pressionada foi ENTER (CHAR 13 ASCI)
            if (e.KeyChar == (char)(13))
            {

                // Envia comando de teclado TAB
                SendKeys.Send("{TAB}");

                //Desabilita o Som da mudança de Foco
                e.Handled = true;
            }


        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Se a tecla pressionada foi ENTER (CHAR 13 ASCI)
            if (e.KeyChar == (char)(13))
            {

                // Envia comando de teclado TAB
                SendKeys.Send("{TAB}");

                //Desabilita o Som da mudança de Foco
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Se a tecla pressionada foi ENTER (CHAR 13 ASCI)
            if (e.KeyChar == (char)(13))
            {

                // Envia comando de teclado TAB
                SendKeys.Send("{TAB}");

                //Desabilita o Som da mudança de Foco
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Se a tecla pressionada foi ENTER (CHAR 13 ASCI)
            if (e.KeyChar == (char)(13))
            {

                // Envia comando de teclado TAB
                SendKeys.Send("{TAB}");

                //Desabilita o Som da mudança de Foco
                e.Handled = true;
            }
        }


        // ----------------------------------------------------------------------------------
        //
        //                                       VALIDAÇÃO
        //
        //-----------------------------------------------------------------------------------

        private void textBox1_Validated(object sender, EventArgs e)
        {
            // VALIDANDO O NOME COM VALIDATED

            if ((textBox1.Text == "") || (textBox1.Text.Length < 3))
            {
                MessageBox.Show("Nome Inválido!");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            // VALIDANDO O NOME COM VALIDATING

            if ((textBox2.Text == "") || (textBox2.Text.Length < 5))
            {
                MessageBox.Show("Endereço Inválido!");
                e.Cancel = true;
            }

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {

            // VALIDANDO O NOME COM lEAVE ( QUANDO SAIR DO COMPONENTE)

            if ((textBox1.Text == "") || (textBox1.Text.Length < 3))
            {
                MessageBox.Show("Email Inválido!");
            }

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            // Boas Vindas Ao usuário, pegando o nome da máquina
            string MachineName = Environment.UserDomainName;
            MessageBox.Show($"Olá, {MachineName}!");
        }
    }
}
