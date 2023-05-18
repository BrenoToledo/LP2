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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            /*
             
            salário bruto=A+Ax(0,05xB+0,1xC+0,1xD)+Total de gratificaçõesOnde:
            
            A=salário de acordo com o cargo (plano de carreira)
            B=Produção >=100 -> se sim B=1 caso contrário B=0
            C=Produção >=120 -> se sim C=1 caso contrário C=0
            D=Produção >=150 -> se sim D=1 caso contrário D=0

            Exemplo: Se Producao >=150 ele vai ter D=1, C=1 e B1.
            
            Restrição: O maior Salário Bruto a ser pago é 7.000,00. 
            Valor acima de 7.000,00 só poderá serpago a funcionários com 
            Produção>=150 e que tenham gratificação.

             */

            // Declarações

            string strNome = txt_Nome.Text;
            string strCargo = txt_Cargo.Text;
            string strMatricula = txt_Matricula.Text;
            string strSalario = txt_Salario.Text;
            string strProducao = txt_Producao.Text;
            string strGratificacao = txt_Gratificacao.Text;

            double dblSalarioBruto = 0;
            double dblSalario = 0;
            double dblProducao = 0;
            double dblGratificacao = 0;
            double dblA = 0;
            double dblB = 0;
            double dblC = 0;
            double dblD = 0;

            if ((double.TryParse(strSalario, out dblSalario)) && 
                (double.TryParse(strProducao, out dblProducao)) && 
                (double.TryParse(strGratificacao, out dblGratificacao)))
            {

                // Classificação dos valores A,B,C e D

                dblA = dblSalario; // Atribuindo Salario Ao A

                if (dblProducao >= 100)
                {
                    dblB = 1;
                }

                if (dblProducao >= 120)
                {
                    dblC = 1;
                }

                if (dblProducao >= 150)
                {
                    dblD = 1;
                }

                // Calcular Salário Bruto

                //---salário bruto=A+Ax(0,05xB+0,1xC+0,1xD)+Total de gratificações

                dblSalarioBruto = dblA + dblA * (0.05 * dblB + 0.1 * dblC + 0.1* dblD) + dblGratificacao;

                // Verifica Regra Salário Maximo
                if ((dblSalarioBruto > 7000) && (dblProducao < 150))
                {
                    dblSalarioBruto = 7000;
                }

                MessageBox.Show("O salário bruto será : R$:" + dblSalarioBruto);
            }
            else // Else do TryParse
            {
                MessageBox.Show("O Valor fornecido é inválido !");
                return;
            }


        }
    }
}
