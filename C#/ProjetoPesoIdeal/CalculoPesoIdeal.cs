using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPesoIdeal
{
    public class CalculoPesoIdeal
    {

        double altura = 0, pesoIdeal = 0;
        
        public double pesoFeminino(double pAltura)
        {
            pesoIdeal = (62.7 * pAltura) - 44.7;
            return pesoIdeal;
        }

        public double pesoMasculino(double pAltura)
        {
           pesoIdeal = (72.7 * pAltura) - 58;
           return pesoIdeal;
        }


    }
}
