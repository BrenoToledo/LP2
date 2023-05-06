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
    public partial class FrmHorista : Form
    {
        public FrmHorista()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FrmHorista_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Horista ObjHorista = new Horista();

            //set 
            ObjHorista.Matricula = Convert.ToInt32(txtBoxMatricula.Text);
            ObjHorista.NomeEmpregado = txtBoxNomeMensalista.Text;
            ObjHorista.DataEntradaEmpresa = Convert.ToDateTime(txtDate.Text);
            ObjHorista.SalarioHora = Convert.ToDouble(txtBoxSalarioMensalista.Text);
            ObjHorista.NumeroHora = Convert.ToDouble(txtHora.Text);
            ObjHorista.DiasFalta = Convert.ToInt32(txtFalta.Text);


            if (rdBtnSim.Checked)
            {
                ObjHorista.HomeOffice = 'S';
            }
            else
            {
                ObjHorista.HomeOffice = 'N';
            }

            //Get

            MessageBox.Show($"Matrícula: {ObjHorista.Matricula}.\n" +
                            $"Nome: {ObjHorista.NomeEmpregado}.\n" +
                            $"Data Entrada: {ObjHorista.DataEntradaEmpresa}\n" +
                            $"Salário Bruto: {ObjHorista.SalarioBruto().ToString("N2")}\n" +
                            $"Tempo de Empresa: {ObjHorista.TempoTrabalho()}\n" +
                            $"{ObjHorista.VerificaHome()}");
        }

    }
    }

