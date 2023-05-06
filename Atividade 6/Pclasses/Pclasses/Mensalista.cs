using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pclasses
{
    class Mensalista : Empregado // especializacao -> heranca
    {

        public double SalarioMensal { get; set; }

        public Mensalista()
        {

        }

        public Mensalista(int matricula, string nome, DateTime dataEntrada, double salarioMensal)
        {
            Matricula = matricula;
            NomeEmpregado = nome;
            DataEntradaEmpresa = dataEntrada;
            SalarioMensal = salarioMensal;
        }

        public override double SalarioBruto()
        {
            return SalarioMensal;
        }
    }
}
