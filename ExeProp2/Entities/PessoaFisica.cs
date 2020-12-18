using System;
using System.Collections.Generic;
using System.Text;

namespace ExeProp2.Entities
{
    class PessoaFisica : Pessoa
    {

        public double GastosSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastoSaude) : base(nome, rendaAnual)
        {
            GastosSaude = gastoSaude;
        }

        public override double Imposto(double renda)
        {
            double imposto = 0.0;
            if (renda <= 20.000)
            {
                imposto = renda * 0.15;
            }
            else
            {
                imposto = renda * 0.25;
            }

            if (GastosSaude > 0.0)
            {
                imposto -= GastosSaude * 0.50;
            }
            return imposto;

        }

    }
}
