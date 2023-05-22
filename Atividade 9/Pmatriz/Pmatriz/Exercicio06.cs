using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pmatriz
{
    public partial class frm_Exercicio06 : Form
    {
        public frm_Exercicio06()
        {
            InitializeComponent();
        }

        private void btn_Executar_Click(object sender, EventArgs e)
        {

            // Definir o valor de N com base no último dígito do seu RA
            int ultimoDigitoRa = 7; // Coloque o último dígito do seu RA aqui

            int N = ultimoDigitoRa;
            if (N == 0)
                N = 10;
            else if (N > 1)
                N = N % 10;

            // Carregar os nomes e calcular os tamanhos
            for (int i = 0; i < N; i++)
            {
                string nome = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome completo da pessoa:", "Entrada de dados");

                // Verificar se o usuário cancelou a entrada de dados
                if (string.IsNullOrEmpty(nome))
                {
                    MessageBox.Show("Entrada de dados cancelada. O programa será encerrado.");
                    return; // Encerrar o programa
                }

                // Calcular o tamanho do nome desconsiderando os espaços em branco
                int tamanho = nome.Replace(" ", "").Length;

                // Criar a string de exemplo com o nome e tamanho
                string texto_form = $"O nome: {nome} tem {tamanho} caracteres.";

                // Adicionar a string de exemplo ao ListBox
                lbx_formulario.Items.Add(texto_form);
                
             
            }
        }
    }
}
