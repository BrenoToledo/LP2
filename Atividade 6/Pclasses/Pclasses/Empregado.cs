using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pclasses
{
    abstract class Empregado
    {
        private int matricula; //atributo
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;
        private char homeOffice;

        public int Matricula //propriedades
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public string NomeEmpregado //propriedades
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }
        public DateTime DataEntradaEmpresa
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value; }
        }

        public Char HomeOffice
        {
            get { return homeOffice; }
            set { homeOffice = value; }
        }

        // metodo são ações/comportamentos

        public string VerificaHome()//Método
        {
            if (homeOffice == 'S')
                return "Empregado trabalha de home office";
            else
                return "Empregado Não trabalha em home office";
        }

        // Virtual --> poder ser sobreecrito

        public virtual int TempoTrabalho()
        {
            // representa um intervalo de tempo
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);

            return (span.Days);
        }

        // deve ser implementado nas classes filhas (subclasses) 

        public abstract double SalarioBruto(); //não preciso implementar
    }
}
