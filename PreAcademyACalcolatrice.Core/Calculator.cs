using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyACalcolatrice.Core
{
    public class Calculator
    {
        public double SommaNumeri(double x, double y)
        {
            return x + y;
        }
        public double SottraiNumeri(double x, double y)
        {
            return x - y;
        }

        public double MoltiplicaNumeri(double x, double y)
        {
            return x * y;
        }

        /// <summary>
        /// Questo metodo fa la divisione tra x e y e se y=0 restituisce null
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double? DividiNumeri(double x, double y)
        {
            if (y == 0)
            {
                return null;
            }
            return x / y;
        }

        public bool VerificaSeAMaggioreDiB(double a, double b)
        {
            if (a >= b)
            {
                return true;
            }
            return false;
        }
    }
}
