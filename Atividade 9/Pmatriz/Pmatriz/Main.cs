using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Pmatriz
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Exercicio01_Click(object sender, EventArgs e)
        {
            int NUMERODEVEZES = 20;

            int[] vetor = new int[NUMERODEVEZES]; // Cria um array de inteiros com tamanho 20
            string mensagem = ""; // Cria uma variável para armazenar a mensagem de saída

            string auxiliar;
            for (var i = 0; i < NUMERODEVEZES; i++)
            {
                auxiliar = Microsoft.VisualBasic.Interaction.InputBox("Digite um número", "Entrada de dados"); // Solicita ao usuário que digite um número

                if (!int.TryParse(auxiliar, out vetor[i])) // Tenta converter o valor digitado para inteiro e armazena no array vetor
                {
                    MessageBox.Show("Número inválido. Por favor, digite um número válido."); // Exibe uma mensagem de erro se o valor não for válido
                    i--; // Decrementa o contador para repetir a iteração do mesmo índice
                }
            }

            Array.Reverse(vetor); // Inverte a ordem dos elementos no array

            mensagem += "Valores Invertidos:\n\n";

            foreach (int valor in vetor)
            {
                mensagem += valor + "\n"; // Adiciona cada valor do array na mensagem de saída
            }

            MessageBox.Show(mensagem); // Exibe a mensagem com os valores invertidos
        }

        private void btn_Exercicio02_Click(object sender, EventArgs e)
        {
            // TODO:
        }
        private void btn_Exercicio03_Click(object sender, EventArgs e)
        {
            string[] Alunos = { "Viviane", "André", "Hélio", "Denise", "Junior", "Leonardo", "Jose", "Nelma", "Tobby" };
            Int32 I, Total = 0;
            Int32 N = Alunos.Length;
            for (I = 0; I < N - 1; I++)
            {
                Total += Alunos[I].Length; 
            }

            MessageBox.Show(Total.ToString());

            // RESPOSTA = C)46
        }

        private void btn_Exercicio04_Click(object sender, EventArgs e)
        {
            {
                ArrayList alunos = new ArrayList(); // Cria um ArrayList para armazenar os alunos

                // Adiciona os alunos diretamente no ArrayList
                alunos.Add("Ana");
                alunos.Add("André");
                alunos.Add("Débora");
                alunos.Add("Fátima");
                alunos.Add("João");
                alunos.Add("Janete");
                alunos.Add("Otávio");
                alunos.Add("Marcelo");
                alunos.Add("Pedro");
                alunos.Add("Thais");

                // Exclui o aluno Otávio do ArrayList
                alunos.Remove("Otávio");

                // Cria uma string com os demais alunos
                string mensagem = "Alunos restantes:\n";
                foreach (string aluno in alunos)
                {
                    mensagem += aluno + "\n";
                }

                // Exibe a mensagem em uma MessageBox
                MessageBox.Show(mensagem);

                // Encerra o programa
                Application.Exit();
            }
        }

        private void btn_Exercicio05_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[20, 3]; // Cria uma matriz para armazenar as notas dos alunos

            // Recebe os dados das notas via InputBox e preenche a matriz
            for (int aluno = 0; aluno < 20; aluno++)
            {
                for (int nota = 0; nota < 3; nota++)
                {
                    string auxiliar = Microsoft.VisualBasic.Interaction.InputBox($"Digite a nota {nota + 1} do aluno {aluno + 1}", "Entrada de dados");

                    // Verifica se o usuário cancelou a entrada de dados
                    if (string.IsNullOrEmpty(auxiliar))
                    {
                        MessageBox.Show("Entrada de dados cancelada. O programa será encerrado.");
                        return; // Encerra o programa
                    }

                    if (!double.TryParse(auxiliar, out notas[aluno, nota]))
                    {
                        MessageBox.Show("Nota inválida. Por favor, digite uma nota válida.");
                        nota--;
                    }
                }
            }

            // Calcula e mostra a média de cada aluno
            string mensagem = "";
            for (int aluno = 0; aluno < 20; aluno++)
            {
                double soma = 0;
                for (int nota = 0; nota < 3; nota++)
                {
                    soma += notas[aluno, nota];
                }
                double media = soma / 3;
                mensagem += $"Aluno {aluno + 1}: média: {media.ToString("0.0")}\n";
            }

            // Exibe a mensagem com as médias dos alunos em uma MessageBox
            MessageBox.Show(mensagem);

            // Encerra o programa
            Application.Exit();
        }

        private void btn_Exercicio06_Click(object sender, EventArgs e)
        {
            frm_Exercicio06 exercicio06 = new frm_Exercicio06();

            exercicio06.Show();
        }
    }
}

