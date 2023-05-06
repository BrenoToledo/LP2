using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pclasses
{
    public partial class FrmMensalista : Form
    {
        public FrmMensalista()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmMensalista_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();

            //set 
            objMensalista.Matricula = Convert.ToInt32(txtBoxMatriculaMensalista.Text);
            objMensalista.NomeEmpregado = txtBoxNomeMensalista.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(mkdTxtBoxDataEntradaMensalista.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtBoxSalarioMensalista.Text);

            if (rdBtnSimMensalista.Checked)
            {
                objMensalista.HomeOffice = 'S';
            }
            else
            {
                objMensalista.HomeOffice = 'N';
            }

            //Get

            MessageBox.Show($"Matrícula: {objMensalista.Matricula}. \n " +
            $"Nome: {objMensalista.NomeEmpregado}. \n " +
            $"Data Entrada: {objMensalista.DataEntradaEmpresa} \n " +
            $"Salário Bruto: {objMensalista.SalarioBruto().ToString("N2")} \n " +
            $"Tempo de Empresa: {objMensalista.TempoTrabalho()} \n" +
            $"{objMensalista.VerificaHome()}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista(Convert.ToInt32(txtBoxMatriculaMensalista.Text),
                                            txtBoxNomeMensalista.Text,
                                            Convert.ToDateTime(mkdTxtBoxDataEntradaMensalista.Text),
                                            Convert.ToDouble(txtBoxSalarioMensalista.Text));

            MessageBox.Show($"Matrícula: {objMensalista.Matricula}. \n " +
                $"Nome: {objMensalista.NomeEmpregado}. \n " +
                $"Data Entrada: {objMensalista.DataEntradaEmpresa} \n " +
                $"Salário Bruto: {objMensalista.SalarioBruto().ToString("N2")} \n " +
                $"Tempo de Empresa: {objMensalista.TempoTrabalho()} \n" +
                $"{objMensalista.VerificaHome()}");
        }
    }
    
}
