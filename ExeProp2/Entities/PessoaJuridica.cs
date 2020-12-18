using System;
using System.Collections.Generic;
using System.Text;

namespace ExeProp2.Entities
{
    class PessoaJuridica : Pessoa
    {

        public int NumeroFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios) : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double Imposto(double renda)
        {
            double imposto = 0.0;
            if (NumeroFuncionarios > 10)
            {
                imposto = renda * 0.14;
            }
            else
            {
                imposto = renda * 0.16;
            }
            return imposto;
        }
    }
}
