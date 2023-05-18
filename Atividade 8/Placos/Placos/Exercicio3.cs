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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void Exercicio3_Load(object sender, EventArgs e)
        {

        }

        private void btn_Verifica_Click(object sender, EventArgs e)
        {
            /*
             
            ------------------------Visual-------------------------

            [ x ] Inserir Label
            [ x ] Inserir TextBox
            [ x ] Inserir Botão
            [ x ] Configurar no Maximo 50 Caracteres no TextBox
            [ x ] MsgBox com a mensagem 
            [ x ] MsgBox se é palimdromo ou não 

            ----------------------Aplicação-----------------------

            [ x ] Retirar Acentos
            [ x ] Retirar Espaços
            [ x ] Transformar em Maiúscula

             */

            // DECLARACÕES 

            string textEdited = "";
            int lenText = 0;


            // Atribuindo o texto digitado para a variável que será trabalhada. 
            textEdited = txt_Texto.Text;

            //Converter para maiusculas
            textEdited = textEdited.ToUpper();

            // Retira caracteres
            textEdited = textEdited.Replace(" ", ""); // Retira os espaços
            textEdited = textEdited.Replace(",", ""); // Retira os caracteres
            textEdited = textEdited.Replace("-", ""); // Retira os caracteres
            textEdited = textEdited.Replace(".", ""); // Retira os caracteres
            textEdited = textEdited.Replace("!", ""); // Retira os caracteres
            textEdited = textEdited.Replace(".", ""); // Retira os caracteres
            textEdited = textEdited.Replace("@", ""); // Retira os caracteres

            // ------- A ---------
            textEdited = textEdited.Replace("Ã", "A"); // Tratamento dos acentos
            textEdited = textEdited.Replace("Á", "A"); // Tratamento dos acentos
            textEdited = textEdited.Replace("À", "A"); // Tratamento dos acentos
            textEdited = textEdited.Replace("Â", "A"); // Tratamento dos acentos

            // ------- E ---------
            textEdited = textEdited.Replace(" ", "E"); // Tratamento dos acentos
            textEdited = textEdited.Replace("È", "E"); // Tratamento dos acentos
            textEdited = textEdited.Replace("É", "E"); // Tratamento dos acentos
            textEdited = textEdited.Replace("Ê", "E"); // Tratamento dos acentos

            // ------- I ---------
            textEdited = textEdited.Replace(" ", "I"); // Tratamento dos acentos
            textEdited = textEdited.Replace("Í", "I"); // Tratamento dos acentos
            textEdited = textEdited.Replace("Ì", "I"); // Tratamento dos acentos
            textEdited = textEdited.Replace("Î", "I"); // Tratamento dos acentos

            // ------- O ---------
            textEdited = textEdited.Replace("Õ", "O"); // Tratamento dos acentos
            textEdited = textEdited.Replace("Ó", "O"); // Tratamento dos acentos
            textEdited = textEdited.Replace("Ò", "O"); // Tratamento dos acentos
            textEdited = textEdited.Replace("Ô", "O"); // Tratamento dos acentos

            // ------- U ---------
            textEdited = textEdited.Replace(" ", "U"); // Tratamento dos acentos
            textEdited = textEdited.Replace("Ú", "U"); // Tratamento dos acentos
            textEdited = textEdited.Replace("Ù", "U"); // Tratamento dos acentos
            textEdited = textEdited.Replace("Û", "U"); // Tratamento dos acentos

            // Verifica o Tamanho da palavra e se é impar ou par

            lenText = textEdited.Length; // Tamanho do Texto

            // Convertendo para array de char
            char[] arrayTexto = textEdited.ToCharArray();
            Array.Reverse(arrayTexto);
            string inverso = new string(arrayTexto);

            if (textEdited == inverso)
            {
                // Código a ser executado se o texto for um palíndromo
                MessageBox.Show("O texto " + txt_Texto.Text + " é um palíndromo.");
            }
            else
            {
                // Código a ser executado se o texto não for um palíndromo
                MessageBox.Show("O texto " + txt_Texto.Text + " não é um palíndromo.");
            }

        }
    }
}
