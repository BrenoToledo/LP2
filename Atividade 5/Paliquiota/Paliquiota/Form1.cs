using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paliquiota
{
    public partial class frm_CalculaAliquota : Form
    {
        public frm_CalculaAliquota()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {


        }

        private void cbox_Feminino_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_Feminino.Checked == true)
            {
                cbox_Masculino.Checked = false;
            }
            else
            {
                cbox_Masculino.Checked = true;
            }
        }
        private void cbox_Masculino_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_Masculino.Checked == true)
            {
                cbox_Feminino.Checked = false;
            }
            else
            {
                cbox_Feminino.Checked = true;
            }

        }

        private void mtbox_SalarioBruto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
            
        private void frm_CalculaAliquota_Load(object sender, EventArgs e)
        {


            // Escolhendo um valor de sexo do usuário 
            cbox_Masculino.Checked = true;

            //Desabilitando visualização da mensagem 
            lbl_Mensagem.Visible = false;

        }

        private void tbox_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_CalculaDesconto_Click(object sender, EventArgs e)
        {
            
            
            // VALIDAÇÃO

            // NOME 

            if (string.IsNullOrEmpty(tbox_Nome.Text))
            {
                MessageBox.Show("O nome do funcionário precisa ser válido");
                return;
            }

            if (tbox_Nome.Text.Length < 2)
            {
                MessageBox.Show("O nome do funcionário precisa ser válido");
                return;
            }

            // Salário

            if (double.TryParse(mtbox_SalarioBruto.Text ,out double double_SalarioBruto)) 
            {
                if (double_SalarioBruto < 0)
                {
                    MessageBox.Show("O valor do salário não é válido Menor Que 0");
                    return;
                }
            }
            else
            {
                MessageBox.Show("O valor do salário não é válido Conversão" + mtbox_SalarioBruto.Text);
                return;
            }


            // Pegando os valores preenchidos no Formulário

            string nome = tbox_Nome.Text;
            double salarioBruto = double_SalarioBruto;
            int numeroFilhos = (int) nupd_NumeroFilhos.Value;
            bool Is_Casado = cbox_IsCasado.Checked;
            bool Is_Homem = cbox_Masculino.Checked;

            // CALCULOS 

            double aliquotaINSS;
            double aliquotaIRPF;
            double valorSalarioFamilia;

            //MessageBox.Show(" "+salarioBruto);

            // Cálculo do desconto do INSS
            if (salarioBruto <= 800.47)
            {
                aliquotaINSS = 0.0765;
            }
            else if (salarioBruto <= 1050)
            {
                aliquotaINSS = 0.0865;
            }
            else if (salarioBruto <= 1400.77)
            {
                aliquotaINSS = 0.09;
            }
            else if (salarioBruto <= 2801.56)
            {
                aliquotaINSS = 0.11;
            }
            else
            {
                aliquotaINSS = 0.11;
            }

            double valorDescontoINSS = salarioBruto * aliquotaINSS;

            // Cálculo do desconto do IRPF
            if (salarioBruto <= 1257.12)
            {
                aliquotaIRPF = 0;
            }
            else if (salarioBruto <= 2512.08)
            {
                aliquotaIRPF = 0.15;
            }
            else
            {
                aliquotaIRPF = 0.275;
            }

            double valorDescontoIRPF = salarioBruto * aliquotaIRPF;

            // Cálculo do Salário Família
            if (salarioBruto <= 435.52)
            {
                valorSalarioFamilia = 22.33 * numeroFilhos;
            }
            else if (salarioBruto <= 654.61)
            {
                valorSalarioFamilia = 15.74 * numeroFilhos;
            }
            else
            {
                valorSalarioFamilia = 0;
            }

            double salarioLiquido = salarioBruto - valorDescontoINSS - valorDescontoIRPF;


            tbox_AliquotaINSS.ReadOnly = true;
            tbox_AliquotaIRPF.ReadOnly = true;
            tbox_DescontoINSS.ReadOnly = true;
            tbox_DescontoIRPF.ReadOnly = true;
            tbox_SalarioFamilia.ReadOnly = true;
            tbox_SalarioLiquido.ReadOnly = true;

            tbox_AliquotaINSS.Text = $"{aliquotaINSS * 100}%";
            tbox_AliquotaIRPF.Text = $"{aliquotaIRPF * 100}%";
            tbox_DescontoINSS.Text = $"{valorDescontoINSS}";
            tbox_DescontoIRPF.Text = $"{valorDescontoIRPF}";
            tbox_SalarioFamilia.Text = $"{valorSalarioFamilia}";
            tbox_SalarioLiquido.Text = $"{salarioLiquido}";

            string estadoCivil = Is_Casado ? "casado(a)" : "solteiro(a)";
            string mensagem = $"Os descontos do salário do Sr. {nome}, que é {estadoCivil} e possui {numeroFilhos} filho(s), são os seguintes:";

            lbl_Mensagem.Visible = true;
            lbl_Mensagem.Text = mensagem;
        }
    }
}
