using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExperienciasDeLab
{
    class Animais
    {
        public int Sapo = 0;
        public int Rato = 0;
        public int Coelho = 0;
        public int Total;
        public double PorcentagemSapo;
        public double PorcentagemRato;
        public double PorcentagemCoelho;



        public void Quantia(string animal, int quantidade)
        {
        if(animal == "S")
            {
                Sapo += quantidade;
            }
        else if (animal == "R")
            {
                Rato += quantidade;
            }
        else if (animal == "C")
            {
                Coelho += quantidade;
            }
        else
            {
                Console.WriteLine("Dados incorretos !");
            }
            Total = Sapo + Rato + Coelho;
            PorcentagemSapo = (double) Sapo * 100 / Total;
            PorcentagemRato = (double)Rato * 100 / Total;
            PorcentagemCoelho = (double)Coelho * 100 / Total;
        }
        
        public override string ToString()
        {
            return "Total: " + Total + "cobaias " +
                    " .Total de coelhos: " +Coelho
                   + " .Total de ratos: " + Rato +
                   " .Total de sapos: " + Sapo +
                   " .Percentual de coelhos: " + PorcentagemCoelho.ToString("F2", CultureInfo.InvariantCulture) +" % " +
                   " .Percentual de ratos: "+ PorcentagemRato.ToString("F2", CultureInfo.InvariantCulture) + " % " +
                   " .Percentual de sapos: " + PorcentagemSapo.ToString("F2", CultureInfo.InvariantCulture) + " % ";
        }
    }
}
